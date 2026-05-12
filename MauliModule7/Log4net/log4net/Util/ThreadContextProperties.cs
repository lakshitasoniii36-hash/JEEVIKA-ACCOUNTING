// Decompiled with JetBrains decompiler
// Type: log4net.Util.ThreadContextProperties
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;
using System.Threading;

#nullable disable
namespace log4net.Util;

public sealed class ThreadContextProperties : ContextPropertiesBase
{
  private static readonly LocalDataStoreSlot s_threadLocalSlot = Thread.AllocateDataSlot();

  internal ThreadContextProperties()
  {
  }

  public override object this[string key]
  {
    get => this.GetProperties(false)?[key];
    set => this.GetProperties(true)[key] = value;
  }

  public void Remove(string key) => this.GetProperties(false)?.Remove(key);

  public void Clear() => this.GetProperties(false)?.Clear();

  internal PropertiesDictionary GetProperties(bool create)
  {
    PropertiesDictionary data = (PropertiesDictionary) Thread.GetData(ThreadContextProperties.s_threadLocalSlot);
    if (data == null && create)
    {
      data = new PropertiesDictionary();
      Thread.SetData(ThreadContextProperties.s_threadLocalSlot, (object) data);
    }
    return data;
  }
}
