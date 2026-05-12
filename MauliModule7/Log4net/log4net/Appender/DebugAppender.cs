// Decompiled with JetBrains decompiler
// Type: log4net.Appender.DebugAppender
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using log4net.Layout;
using System;
using System.Diagnostics;

#nullable disable
namespace log4net.Appender;

public class DebugAppender : AppenderSkeleton
{
  private bool m_immediateFlush = true;

  public DebugAppender()
  {
  }

  [Obsolete("Instead use the default constructor and set the Layout property")]
  public DebugAppender(ILayout layout) => this.Layout = layout;

  public bool ImmediateFlush
  {
    get => this.m_immediateFlush;
    set => this.m_immediateFlush = value;
  }

  protected override void Append(LoggingEvent loggingEvent)
  {
    Debug.Write(this.RenderLoggingEvent(loggingEvent), loggingEvent.LoggerName);
    if (!this.m_immediateFlush)
      return;
    Debug.Flush();
  }

  protected override bool RequiresLayout => true;
}
