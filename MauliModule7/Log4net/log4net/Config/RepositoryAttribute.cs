// Decompiled with JetBrains decompiler
// Type: log4net.Config.RepositoryAttribute
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;

#nullable disable
namespace log4net.Config;

[AttributeUsage(AttributeTargets.Assembly)]
[Serializable]
public class RepositoryAttribute : Attribute
{
  private string m_name;
  private Type m_repositoryType;

  public RepositoryAttribute()
  {
  }

  public RepositoryAttribute(string name) => this.m_name = name;

  public string Name
  {
    get => this.m_name;
    set => this.m_name = value;
  }

  public Type RepositoryType
  {
    get => this.m_repositoryType;
    set => this.m_repositoryType = value;
  }
}
