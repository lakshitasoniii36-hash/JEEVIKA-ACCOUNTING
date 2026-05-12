// Decompiled with JetBrains decompiler
// Type: log4net.Filter.FilterSkeleton
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;

#nullable disable
namespace log4net.Filter;

public abstract class FilterSkeleton : IFilter, IOptionHandler
{
  private IFilter m_next;

  public virtual void ActivateOptions()
  {
  }

  public abstract FilterDecision Decide(LoggingEvent loggingEvent);

  public IFilter Next
  {
    get => this.m_next;
    set => this.m_next = value;
  }
}
