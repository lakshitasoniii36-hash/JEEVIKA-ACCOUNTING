// Decompiled with JetBrains decompiler
// Type: log4net.Appender.OutputDebugStringAppender
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System.Runtime.InteropServices;

#nullable disable
namespace log4net.Appender;

public class OutputDebugStringAppender : AppenderSkeleton
{
  protected override void Append(LoggingEvent loggingEvent)
  {
    OutputDebugStringAppender.OutputDebugString(this.RenderLoggingEvent(loggingEvent));
  }

  protected override bool RequiresLayout => true;

  [DllImport("Kernel32.dll")]
  protected static extern void OutputDebugString(string message);
}
