// Decompiled with JetBrains decompiler
// Type: log4net.Core.LoggerWrapperImpl
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

#nullable disable
namespace log4net.Core;

public abstract class LoggerWrapperImpl : ILoggerWrapper
{
  private readonly ILogger m_logger;

  protected LoggerWrapperImpl(ILogger logger) => this.m_logger = logger;

  public virtual ILogger Logger => this.m_logger;
}
