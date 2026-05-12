// Decompiled with JetBrains decompiler
// Type: log4net.Filter.LevelRangeFilter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System;

#nullable disable
namespace log4net.Filter;

public class LevelRangeFilter : FilterSkeleton
{
  private bool m_acceptOnMatch = true;
  private Level m_levelMin;
  private Level m_levelMax;

  public bool AcceptOnMatch
  {
    get => this.m_acceptOnMatch;
    set => this.m_acceptOnMatch = value;
  }

  public Level LevelMin
  {
    get => this.m_levelMin;
    set => this.m_levelMin = value;
  }

  public Level LevelMax
  {
    get => this.m_levelMax;
    set => this.m_levelMax = value;
  }

  public override FilterDecision Decide(LoggingEvent loggingEvent)
  {
    if (loggingEvent == null)
      throw new ArgumentNullException(nameof (loggingEvent));
    if (this.m_levelMin != (Level) null && loggingEvent.Level < this.m_levelMin || this.m_levelMax != (Level) null && loggingEvent.Level > this.m_levelMax)
      return FilterDecision.Deny;
    return this.m_acceptOnMatch ? FilterDecision.Accept : FilterDecision.Neutral;
  }
}
