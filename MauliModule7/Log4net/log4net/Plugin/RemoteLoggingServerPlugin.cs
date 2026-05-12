// Decompiled with JetBrains decompiler
// Type: log4net.Plugin.RemoteLoggingServerPlugin
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Appender;
using log4net.Core;
using log4net.Repository;
using log4net.Util;
using System;
using System.Runtime.Remoting;

#nullable disable
namespace log4net.Plugin;

public class RemoteLoggingServerPlugin : PluginSkeleton
{
  private RemoteLoggingServerPlugin.RemoteLoggingSinkImpl m_sink;
  private string m_sinkUri;

  public RemoteLoggingServerPlugin()
    : base("RemoteLoggingServerPlugin:Unset URI")
  {
  }

  public RemoteLoggingServerPlugin(string sinkUri)
    : base("RemoteLoggingServerPlugin:" + sinkUri)
  {
    this.m_sinkUri = sinkUri;
  }

  public virtual string SinkUri
  {
    get => this.m_sinkUri;
    set => this.m_sinkUri = value;
  }

  public override void Attach(ILoggerRepository repository)
  {
    base.Attach(repository);
    this.m_sink = new RemoteLoggingServerPlugin.RemoteLoggingSinkImpl(repository);
    try
    {
      RemotingServices.Marshal((MarshalByRefObject) this.m_sink, this.m_sinkUri, typeof (RemotingAppender.IRemoteLoggingSink));
    }
    catch (Exception ex)
    {
      LogLog.Error("RemoteLoggingServerPlugin: Failed to Marshal remoting sink", ex);
    }
  }

  public override void Shutdown()
  {
    RemotingServices.Disconnect((MarshalByRefObject) this.m_sink);
    this.m_sink = (RemoteLoggingServerPlugin.RemoteLoggingSinkImpl) null;
    base.Shutdown();
  }

  private class RemoteLoggingSinkImpl : MarshalByRefObject, RemotingAppender.IRemoteLoggingSink
  {
    private readonly ILoggerRepository m_repository;

    public RemoteLoggingSinkImpl(ILoggerRepository repository) => this.m_repository = repository;

    public void LogEvents(LoggingEvent[] events)
    {
      if (events == null)
        return;
      foreach (LoggingEvent logEvent in events)
      {
        if (logEvent != null)
          this.m_repository.Log(logEvent);
      }
    }

    public override object InitializeLifetimeService() => (object) null;
  }
}
