// Decompiled with JetBrains decompiler
// Type: log4net.Config.ConfiguratorAttribute
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Repository;
using System;
using System.Reflection;

#nullable disable
namespace log4net.Config;

[AttributeUsage(AttributeTargets.Assembly)]
public abstract class ConfiguratorAttribute : Attribute, IComparable
{
  private int m_priority;

  protected ConfiguratorAttribute(int priority) => this.m_priority = priority;

  public abstract void Configure(Assembly sourceAssembly, ILoggerRepository targetRepository);

  public int CompareTo(object obj)
  {
    if (this == obj)
      return 0;
    int num = -1;
    if (obj is ConfiguratorAttribute configuratorAttribute)
    {
      num = configuratorAttribute.m_priority.CompareTo(this.m_priority);
      if (num == 0)
        num = -1;
    }
    return num;
  }
}
