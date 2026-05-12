// Decompiled with JetBrains decompiler
// Type: log4net.Appender.RemotingAppender
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System;
using System.Collections;
using System.Threading;

#nullable disable
namespace log4net.Appender;

public class RemotingAppender : BufferingAppenderSkeleton
{
  private string m_sinkUrl;
  private RemotingAppender.IRemoteLoggingSink m_sinkObj;
  private int m_queuedCallbackCount;
  private ManualResetEvent m_workQueueEmptyEvent = new ManualResetEvent(true);

  public string Sink
  {
    get => this.m_sinkUrl;
    set => this.m_sinkUrl = value;
  }

  public override void ActivateOptions()
  {
    base.ActivateOptions();
    IDictionary state = (IDictionary) new Hashtable();
    state[(object) "typeFilterLevel"] = (object) "Full";
    this.m_sinkObj = (RemotingAppender.IRemoteLoggingSink) Activator.GetObject(typeof (RemotingAppender.IRemoteLoggingSink), this.m_sinkUrl, (object) state);
  }

  protected override void SendBuffer(LoggingEvent[] events)
  {
    this.BeginAsyncSend();
    if (ThreadPool.QueueUserWorkItem(new WaitCallback(this.SendBufferCallback), (object) events))
      return;
    this.EndAsyncSend();
    this.ErrorHandler.Error($"RemotingAppender [{this.Name}] failed to ThreadPool.QueueUserWorkItem logging events in SendBuffer.");
  }

  protected override void OnClose()
  {
    base.OnClose();
    if (this.m_workQueueEmptyEvent.WaitOne(30000, false))
      return;
    this.ErrorHandler.Error($"RemotingAppender [{this.Name}] failed to send all queued events before close, in OnClose.");
  }

  private void BeginAsyncSend()
  {
    this.m_workQueueEmptyEvent.Reset();
    Interlocked.Increment(ref this.m_queuedCallbackCount);
  }

  private void EndAsyncSend()
  {
    if (Interlocked.Decrement(ref this.m_queuedCallbackCount) > 0)
      return;
    this.m_workQueueEmptyEvent.Set();
  }

  private void SendBufferCallback(object state)
  {
    try
    {
      this.m_sinkObj.LogEvents((LoggingEvent[]) state);
    }
    catch (Exception ex)
    {
      this.ErrorHandler.Error("Failed in SendBufferCallback", ex);
    }
    finally
    {
      this.EndAsyncSend();
    }
  }

  public interface IRemoteLoggingSink
  {
    void LogEvents(LoggingEvent[] events);
  }
}
