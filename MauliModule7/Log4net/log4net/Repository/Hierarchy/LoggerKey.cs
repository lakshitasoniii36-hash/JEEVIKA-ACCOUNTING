// Decompiled with JetBrains decompiler
// Type: log4net.Repository.Hierarchy.LoggerKey
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

#nullable disable
namespace log4net.Repository.Hierarchy;

internal sealed class LoggerKey
{
  private readonly string m_name;
  private readonly int m_hashCache;

  internal LoggerKey(string name)
  {
    this.m_name = string.Intern(name);
    this.m_hashCache = name.GetHashCode();
  }

  public override int GetHashCode() => this.m_hashCache;

  public override bool Equals(object obj)
  {
    if (this == obj)
      return true;
    return obj is LoggerKey loggerKey && (object) this.m_name == (object) loggerKey.m_name;
  }
}
