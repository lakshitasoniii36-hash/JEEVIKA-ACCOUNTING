// Decompiled with JetBrains decompiler
// Type: log4net.Util.OnlyOnceErrorHandler
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System;

#nullable disable
namespace log4net.Util;

public class OnlyOnceErrorHandler : IErrorHandler
{
  private bool m_firstTime = true;
  private readonly string m_prefix;

  public OnlyOnceErrorHandler() => this.m_prefix = "";

  public OnlyOnceErrorHandler(string prefix) => this.m_prefix = prefix;

  public void Error(string message, Exception e, ErrorCode errorCode)
  {
    if (!this.IsEnabled)
      return;
    LogLog.Error($"[{this.m_prefix}] {message}", e);
  }

  public void Error(string message, Exception e)
  {
    if (!this.IsEnabled)
      return;
    LogLog.Error($"[{this.m_prefix}] {message}", e);
  }

  public void Error(string message)
  {
    if (!this.IsEnabled)
      return;
    LogLog.Error($"[{this.m_prefix}] {message}");
  }

  private bool IsEnabled
  {
    get
    {
      if (this.m_firstTime)
      {
        this.m_firstTime = false;
        return true;
      }
      return LogLog.InternalDebugging && !LogLog.QuietMode;
    }
  }
}
