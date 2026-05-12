// Decompiled with JetBrains decompiler
// Type: log4net.Filter.PropertyFilter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System;

#nullable disable
namespace log4net.Filter;

public class PropertyFilter : StringMatchFilter
{
  private string m_key;

  public string Key
  {
    get => this.m_key;
    set => this.m_key = value;
  }

  public override FilterDecision Decide(LoggingEvent loggingEvent)
  {
    if (loggingEvent == null)
      throw new ArgumentNullException(nameof (loggingEvent));
    if (this.m_key == null)
      return FilterDecision.Neutral;
    object obj = loggingEvent.LookupProperty(this.m_key);
    string andRender = loggingEvent.Repository.RendererMap.FindAndRender(obj);
    if (andRender == null || this.m_stringToMatch == null && this.m_regexToMatch == null)
      return FilterDecision.Neutral;
    if (this.m_regexToMatch != null)
    {
      if (!this.m_regexToMatch.Match(andRender).Success)
        return FilterDecision.Neutral;
      return this.m_acceptOnMatch ? FilterDecision.Accept : FilterDecision.Deny;
    }
    if (this.m_stringToMatch == null || andRender.IndexOf(this.m_stringToMatch) == -1)
      return FilterDecision.Neutral;
    return this.m_acceptOnMatch ? FilterDecision.Accept : FilterDecision.Deny;
  }
}
