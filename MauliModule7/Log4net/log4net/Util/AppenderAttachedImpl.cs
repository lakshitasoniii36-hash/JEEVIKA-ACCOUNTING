// Decompiled with JetBrains decompiler
// Type: log4net.Util.AppenderAttachedImpl
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Appender;
using log4net.Core;
using System;

#nullable disable
namespace log4net.Util;

public class AppenderAttachedImpl : IAppenderAttachable
{
  private AppenderCollection m_appenderList;
  private IAppender[] m_appenderArray;

  public int AppendLoopOnAppenders(LoggingEvent loggingEvent)
  {
    if (loggingEvent == null)
      throw new ArgumentNullException(nameof (loggingEvent));
    if (this.m_appenderList == null)
      return 0;
    if (this.m_appenderArray == null)
      this.m_appenderArray = this.m_appenderList.ToArray();
    foreach (IAppender appender in this.m_appenderArray)
    {
      try
      {
        appender.DoAppend(loggingEvent);
      }
      catch (Exception ex)
      {
        LogLog.Error($"AppenderAttachedImpl: Failed to append to appender [{appender.Name}]", ex);
      }
    }
    return this.m_appenderList.Count;
  }

  public int AppendLoopOnAppenders(LoggingEvent[] loggingEvents)
  {
    if (loggingEvents == null)
      throw new ArgumentNullException(nameof (loggingEvents));
    if (loggingEvents.Length == 0)
      throw new ArgumentException("loggingEvents array must not be empty", nameof (loggingEvents));
    if (loggingEvents.Length == 1)
      return this.AppendLoopOnAppenders(loggingEvents[0]);
    if (this.m_appenderList == null)
      return 0;
    if (this.m_appenderArray == null)
      this.m_appenderArray = this.m_appenderList.ToArray();
    foreach (IAppender appender in this.m_appenderArray)
    {
      try
      {
        AppenderAttachedImpl.CallAppend(appender, loggingEvents);
      }
      catch (Exception ex)
      {
        LogLog.Error($"AppenderAttachedImpl: Failed to append to appender [{appender.Name}]", ex);
      }
    }
    return this.m_appenderList.Count;
  }

  private static void CallAppend(IAppender appender, LoggingEvent[] loggingEvents)
  {
    if (appender is IBulkAppender bulkAppender)
    {
      bulkAppender.DoAppend(loggingEvents);
    }
    else
    {
      foreach (LoggingEvent loggingEvent in loggingEvents)
        appender.DoAppend(loggingEvent);
    }
  }

  public void AddAppender(IAppender newAppender)
  {
    if (newAppender == null)
      throw new ArgumentNullException(nameof (newAppender));
    this.m_appenderArray = (IAppender[]) null;
    if (this.m_appenderList == null)
      this.m_appenderList = new AppenderCollection(1);
    if (this.m_appenderList.Contains(newAppender))
      return;
    this.m_appenderList.Add(newAppender);
  }

  public AppenderCollection Appenders
  {
    get
    {
      return this.m_appenderList == null ? AppenderCollection.EmptyCollection : AppenderCollection.ReadOnly(this.m_appenderList);
    }
  }

  public IAppender GetAppender(string name)
  {
    if (this.m_appenderList != null && name != null)
    {
      foreach (IAppender appender in this.m_appenderList)
      {
        if (name == appender.Name)
          return appender;
      }
    }
    return (IAppender) null;
  }

  public void RemoveAllAppenders()
  {
    if (this.m_appenderList == null)
      return;
    foreach (IAppender appender in this.m_appenderList)
    {
      try
      {
        appender.Close();
      }
      catch (Exception ex)
      {
        LogLog.Error($"AppenderAttachedImpl: Failed to Close appender [{appender.Name}]", ex);
      }
    }
    this.m_appenderList = (AppenderCollection) null;
    this.m_appenderArray = (IAppender[]) null;
  }

  public IAppender RemoveAppender(IAppender appender)
  {
    if (appender != null && this.m_appenderList != null)
    {
      this.m_appenderList.Remove(appender);
      if (this.m_appenderList.Count == 0)
        this.m_appenderList = (AppenderCollection) null;
      this.m_appenderArray = (IAppender[]) null;
    }
    return appender;
  }

  public IAppender RemoveAppender(string name) => this.RemoveAppender(this.GetAppender(name));
}
