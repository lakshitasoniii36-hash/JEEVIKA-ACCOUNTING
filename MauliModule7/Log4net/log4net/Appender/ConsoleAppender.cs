// Decompiled with JetBrains decompiler
// Type: log4net.Appender.ConsoleAppender
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using log4net.Layout;
using System;
using System.Globalization;

#nullable disable
namespace log4net.Appender;

public class ConsoleAppender : AppenderSkeleton
{
  public const string ConsoleOut = "Console.Out";
  public const string ConsoleError = "Console.Error";
  private bool m_writeToErrorStream;

  public ConsoleAppender()
  {
  }

  [Obsolete("Instead use the default constructor and set the Layout property")]
  public ConsoleAppender(ILayout layout)
    : this(layout, false)
  {
  }

  [Obsolete("Instead use the default constructor and set the Layout & Target properties")]
  public ConsoleAppender(ILayout layout, bool writeToErrorStream)
  {
    this.Layout = layout;
    this.m_writeToErrorStream = writeToErrorStream;
  }

  public virtual string Target
  {
    get => !this.m_writeToErrorStream ? "Console.Out" : "Console.Error";
    set
    {
      if (string.Compare("Console.Error", value.Trim(), true, CultureInfo.InvariantCulture) == 0)
        this.m_writeToErrorStream = true;
      else
        this.m_writeToErrorStream = false;
    }
  }

  protected override void Append(LoggingEvent loggingEvent)
  {
    if (this.m_writeToErrorStream)
      Console.Error.Write(this.RenderLoggingEvent(loggingEvent));
    else
      Console.Write(this.RenderLoggingEvent(loggingEvent));
  }

  protected override bool RequiresLayout => true;
}
