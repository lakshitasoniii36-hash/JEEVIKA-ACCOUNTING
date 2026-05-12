// Decompiled with JetBrains decompiler
// Type: log4net.Layout.RawPropertyLayout
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;

#nullable disable
namespace log4net.Layout;

public class RawPropertyLayout : IRawLayout
{
  private string m_key;

  public string Key
  {
    get => this.m_key;
    set => this.m_key = value;
  }

  public virtual object Format(LoggingEvent loggingEvent)
  {
    return loggingEvent.LookupProperty(this.m_key);
  }
}
