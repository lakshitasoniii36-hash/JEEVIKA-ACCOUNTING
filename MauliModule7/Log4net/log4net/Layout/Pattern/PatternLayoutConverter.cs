// Decompiled with JetBrains decompiler
// Type: log4net.Layout.Pattern.PatternLayoutConverter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using log4net.Util;
using System;
using System.IO;

#nullable disable
namespace log4net.Layout.Pattern;

public abstract class PatternLayoutConverter : PatternConverter
{
  private bool m_ignoresException = true;

  public virtual bool IgnoresException
  {
    get => this.m_ignoresException;
    set => this.m_ignoresException = value;
  }

  protected abstract void Convert(TextWriter writer, LoggingEvent loggingEvent);

  protected override void Convert(TextWriter writer, object state)
  {
    if (!(state is LoggingEvent loggingEvent))
      throw new ArgumentException($"state must be of type [{typeof (LoggingEvent).FullName}]", nameof (state));
    this.Convert(writer, loggingEvent);
  }
}
