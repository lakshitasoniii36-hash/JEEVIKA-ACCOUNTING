// Decompiled with JetBrains decompiler
// Type: log4net.Util.CompositeProperties
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System.Collections;

#nullable disable
namespace log4net.Util;

public sealed class CompositeProperties
{
  private PropertiesDictionary m_flattened;
  private ArrayList m_nestedProperties = new ArrayList();

  internal CompositeProperties()
  {
  }

  public object this[string key]
  {
    get
    {
      if (this.m_flattened != null)
        return this.m_flattened[key];
      foreach (ReadOnlyPropertiesDictionary nestedProperty in this.m_nestedProperties)
      {
        if (nestedProperty.Contains(key))
          return nestedProperty[key];
      }
      return (object) null;
    }
  }

  public void Add(ReadOnlyPropertiesDictionary properties)
  {
    this.m_flattened = (PropertiesDictionary) null;
    this.m_nestedProperties.Add((object) properties);
  }

  public PropertiesDictionary Flatten()
  {
    if (this.m_flattened == null)
    {
      this.m_flattened = new PropertiesDictionary();
      int count = this.m_nestedProperties.Count;
      while (--count >= 0)
      {
        foreach (DictionaryEntry dictionaryEntry in (IEnumerable) this.m_nestedProperties[count])
          this.m_flattened[(string) dictionaryEntry.Key] = dictionaryEntry.Value;
      }
    }
    return this.m_flattened;
  }
}
