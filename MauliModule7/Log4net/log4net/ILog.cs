// Decompiled with JetBrains decompiler
// Type: log4net.ILog
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System;

#nullable disable
namespace log4net;

public interface ILog : ILoggerWrapper
{
  void Debug(object message);

  void Debug(object message, Exception exception);

  void DebugFormat(string format, params object[] args);

  void DebugFormat(string format, object arg0);

  void DebugFormat(string format, object arg0, object arg1);

  void DebugFormat(string format, object arg0, object arg1, object arg2);

  void DebugFormat(IFormatProvider provider, string format, params object[] args);

  void Info(object message);

  void Info(object message, Exception exception);

  void InfoFormat(string format, params object[] args);

  void InfoFormat(string format, object arg0);

  void InfoFormat(string format, object arg0, object arg1);

  void InfoFormat(string format, object arg0, object arg1, object arg2);

  void InfoFormat(IFormatProvider provider, string format, params object[] args);

  void Warn(object message);

  void Warn(object message, Exception exception);

  void WarnFormat(string format, params object[] args);

  void WarnFormat(string format, object arg0);

  void WarnFormat(string format, object arg0, object arg1);

  void WarnFormat(string format, object arg0, object arg1, object arg2);

  void WarnFormat(IFormatProvider provider, string format, params object[] args);

  void Error(object message);

  void Error(object message, Exception exception);

  void ErrorFormat(string format, params object[] args);

  void ErrorFormat(string format, object arg0);

  void ErrorFormat(string format, object arg0, object arg1);

  void ErrorFormat(string format, object arg0, object arg1, object arg2);

  void ErrorFormat(IFormatProvider provider, string format, params object[] args);

  void Fatal(object message);

  void Fatal(object message, Exception exception);

  void FatalFormat(string format, params object[] args);

  void FatalFormat(string format, object arg0);

  void FatalFormat(string format, object arg0, object arg1);

  void FatalFormat(string format, object arg0, object arg1, object arg2);

  void FatalFormat(IFormatProvider provider, string format, params object[] args);

  bool IsDebugEnabled { get; }

  bool IsInfoEnabled { get; }

  bool IsWarnEnabled { get; }

  bool IsErrorEnabled { get; }

  bool IsFatalEnabled { get; }
}
