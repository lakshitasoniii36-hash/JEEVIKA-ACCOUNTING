// Decompiled with JetBrains decompiler
// Type: log4net.Appender.MemoryAppender
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System;
using System.Collections;

#nullable disable
namespace log4net.Appender;

public class MemoryAppender : AppenderSkeleton
{
  protected ArrayList m_eventsList;
  protected FixFlags m_fixFlags = FixFlags.All;

  public MemoryAppender() => this.m_eventsList = new ArrayList();

  public virtual LoggingEvent[] GetEvents()
  {
    return (LoggingEvent[]) this.m_eventsList.ToArray(typeof (LoggingEvent));
  }

  [Obsolete("Use Fix property")]
  public virtual bool OnlyFixPartialEventData
  {
    get => this.Fix == FixFlags.Partial;
    set
    {
      if (value)
        this.Fix = FixFlags.Partial;
      else
        this.Fix = FixFlags.All;
    }
  }

  public virtual FixFlags Fix
  {
    get => this.m_fixFlags;
    set => this.m_fixFlags = value;
  }

  protected override void Append(LoggingEvent loggingEvent)
  {
    loggingEvent.Fix = this.Fix;
    this.m_eventsList.Add((object) loggingEvent);
  }

  public virtual void Clear() => this.m_eventsList.Clear();
}
