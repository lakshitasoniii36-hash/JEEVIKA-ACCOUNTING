// Decompiled with JetBrains decompiler
// Type: log4net.Util.LogicalThreadContextProperties
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System.Runtime.Remoting.Messaging;

#nullable disable
namespace log4net.Util;

public sealed class LogicalThreadContextProperties : ContextPropertiesBase
{
  internal LogicalThreadContextProperties()
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
    PropertiesDictionary data = (PropertiesDictionary) CallContext.GetData("log4net.Util.LogicalThreadContextProperties");
    if (data == null && create)
    {
      data = new PropertiesDictionary();
      CallContext.SetData("log4net.Util.LogicalThreadContextProperties", (object) data);
    }
    return data;
  }
}
