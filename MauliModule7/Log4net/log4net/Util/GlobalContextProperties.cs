// Decompiled with JetBrains decompiler
// Type: log4net.Util.GlobalContextProperties
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

#nullable disable
namespace log4net.Util;

public sealed class GlobalContextProperties : ContextPropertiesBase
{
  private volatile ReadOnlyPropertiesDictionary m_readOnlyProperties = new ReadOnlyPropertiesDictionary();
  private readonly object m_syncRoot = new object();

  internal GlobalContextProperties()
  {
  }

  public override object this[string key]
  {
    get => this.m_readOnlyProperties[key];
    set
    {
      lock (this.m_syncRoot)
      {
        PropertiesDictionary propertiesDictionary = new PropertiesDictionary(this.m_readOnlyProperties);
        propertiesDictionary[key] = value;
        this.m_readOnlyProperties = new ReadOnlyPropertiesDictionary((ReadOnlyPropertiesDictionary) propertiesDictionary);
      }
    }
  }

  public void Remove(string key)
  {
    lock (this.m_syncRoot)
    {
      if (!this.m_readOnlyProperties.Contains(key))
        return;
      PropertiesDictionary propertiesDictionary = new PropertiesDictionary(this.m_readOnlyProperties);
      propertiesDictionary.Remove(key);
      this.m_readOnlyProperties = new ReadOnlyPropertiesDictionary((ReadOnlyPropertiesDictionary) propertiesDictionary);
    }
  }

  public void Clear()
  {
    lock (this.m_syncRoot)
      this.m_readOnlyProperties = new ReadOnlyPropertiesDictionary();
  }

  internal ReadOnlyPropertiesDictionary GetReadOnlyProperties() => this.m_readOnlyProperties;
}
