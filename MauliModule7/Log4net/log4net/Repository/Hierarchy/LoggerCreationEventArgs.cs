// Decompiled with JetBrains decompiler
// Type: log4net.Repository.Hierarchy.LoggerCreationEventArgs
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;

#nullable disable
namespace log4net.Repository.Hierarchy;

public class LoggerCreationEventArgs : EventArgs
{
  private Logger m_log;

  public LoggerCreationEventArgs(Logger log) => this.m_log = log;

  public Logger Logger => this.m_log;
}
