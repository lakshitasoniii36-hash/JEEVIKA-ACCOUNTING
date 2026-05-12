// Decompiled with JetBrains decompiler
// Type: log4net.Util.LogLog
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;
using System.Diagnostics;

#nullable disable
namespace log4net.Util;

public sealed class LogLog
{
  private const string PREFIX = "log4net: ";
  private const string ERR_PREFIX = "log4net:ERROR ";
  private const string WARN_PREFIX = "log4net:WARN ";
  private static bool s_debugEnabled;
  private static bool s_quietMode;

  private LogLog()
  {
  }

  static LogLog()
  {
    try
    {
      LogLog.InternalDebugging = OptionConverter.ToBoolean(SystemInfo.GetAppSetting("log4net.Internal.Debug"), false);
      LogLog.QuietMode = OptionConverter.ToBoolean(SystemInfo.GetAppSetting("log4net.Internal.Quiet"), false);
    }
    catch (Exception ex)
    {
      LogLog.Error("LogLog: Exception while reading ConfigurationSettings. Check your .config file is well formed XML.", ex);
    }
  }

  public static bool InternalDebugging
  {
    get => LogLog.s_debugEnabled;
    set => LogLog.s_debugEnabled = value;
  }

  public static bool QuietMode
  {
    get => LogLog.s_quietMode;
    set => LogLog.s_quietMode = value;
  }

  public static bool IsDebugEnabled => LogLog.s_debugEnabled && !LogLog.s_quietMode;

  public static void Debug(string message)
  {
    if (!LogLog.IsDebugEnabled)
      return;
    LogLog.EmitOutLine("log4net: " + message);
  }

  public static void Debug(string message, Exception exception)
  {
    if (!LogLog.IsDebugEnabled)
      return;
    LogLog.EmitOutLine("log4net: " + message);
    if (exception == null)
      return;
    LogLog.EmitOutLine(exception.ToString());
  }

  public static bool IsWarnEnabled => !LogLog.s_quietMode;

  public static void Warn(string message)
  {
    if (!LogLog.IsWarnEnabled)
      return;
    LogLog.EmitErrorLine("log4net:WARN " + message);
  }

  public static void Warn(string message, Exception exception)
  {
    if (!LogLog.IsWarnEnabled)
      return;
    LogLog.EmitErrorLine("log4net:WARN " + message);
    if (exception == null)
      return;
    LogLog.EmitErrorLine(exception.ToString());
  }

  public static bool IsErrorEnabled => !LogLog.s_quietMode;

  public static void Error(string message)
  {
    if (!LogLog.IsErrorEnabled)
      return;
    LogLog.EmitErrorLine("log4net:ERROR " + message);
  }

  public static void Error(string message, Exception exception)
  {
    if (!LogLog.IsErrorEnabled)
      return;
    LogLog.EmitErrorLine("log4net:ERROR " + message);
    if (exception == null)
      return;
    LogLog.EmitErrorLine(exception.ToString());
  }

  private static void EmitOutLine(string message)
  {
    try
    {
      Console.Out.WriteLine(message);
      Trace.WriteLine(message);
    }
    catch
    {
    }
  }

  private static void EmitErrorLine(string message)
  {
    try
    {
      Console.Error.WriteLine(message);
      Trace.WriteLine(message);
    }
    catch
    {
    }
  }
}
