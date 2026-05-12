// Decompiled with JetBrains decompiler
// Type: log4net.Filter.StringMatchFilter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System;
using System.Text.RegularExpressions;

#nullable disable
namespace log4net.Filter;

public class StringMatchFilter : FilterSkeleton
{
  protected bool m_acceptOnMatch = true;
  protected string m_stringToMatch;
  protected string m_stringRegexToMatch;
  protected Regex m_regexToMatch;

  public override void ActivateOptions()
  {
    if (this.m_stringRegexToMatch == null)
      return;
    this.m_regexToMatch = new Regex(this.m_stringRegexToMatch, RegexOptions.Compiled);
  }

  public bool AcceptOnMatch
  {
    get => this.m_acceptOnMatch;
    set => this.m_acceptOnMatch = value;
  }

  public string StringToMatch
  {
    get => this.m_stringToMatch;
    set => this.m_stringToMatch = value;
  }

  public string RegexToMatch
  {
    get => this.m_stringRegexToMatch;
    set => this.m_stringRegexToMatch = value;
  }

  public override FilterDecision Decide(LoggingEvent loggingEvent)
  {
    string input = loggingEvent != null ? loggingEvent.RenderedMessage : throw new ArgumentNullException(nameof (loggingEvent));
    if (input == null || this.m_stringToMatch == null && this.m_regexToMatch == null)
      return FilterDecision.Neutral;
    if (this.m_regexToMatch != null)
    {
      if (!this.m_regexToMatch.Match(input).Success)
        return FilterDecision.Neutral;
      return this.m_acceptOnMatch ? FilterDecision.Accept : FilterDecision.Deny;
    }
    if (this.m_stringToMatch == null || input.IndexOf(this.m_stringToMatch) == -1)
      return FilterDecision.Neutral;
    return this.m_acceptOnMatch ? FilterDecision.Accept : FilterDecision.Deny;
  }
}
