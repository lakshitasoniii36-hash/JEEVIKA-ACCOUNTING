// Decompiled with JetBrains decompiler
// Type: log4net.Core.LevelEvaluator
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;

#nullable disable
namespace log4net.Core;

public class LevelEvaluator : ITriggeringEventEvaluator
{
  private Level m_threshold;

  public LevelEvaluator()
    : this(Level.Off)
  {
  }

  public LevelEvaluator(Level threshold)
  {
    this.m_threshold = !(threshold == (Level) null) ? threshold : throw new ArgumentNullException(nameof (threshold));
  }

  public Level Threshold
  {
    get => this.m_threshold;
    set => this.m_threshold = value;
  }

  public bool IsTriggeringEvent(LoggingEvent loggingEvent)
  {
    if (loggingEvent == null)
      throw new ArgumentNullException(nameof (loggingEvent));
    return loggingEvent.Level >= this.m_threshold;
  }
}
