// Decompiled with JetBrains decompiler
// Type: log4net.Config.SecurityContextProviderAttribute
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using log4net.Repository;
using log4net.Util;
using System;
using System.Reflection;

#nullable disable
namespace log4net.Config;

[AttributeUsage(AttributeTargets.Assembly)]
[Serializable]
public sealed class SecurityContextProviderAttribute : ConfiguratorAttribute
{
  private Type m_providerType;

  public SecurityContextProviderAttribute(Type providerType)
    : base(100)
  {
    this.m_providerType = providerType;
  }

  public Type ProviderType
  {
    get => this.m_providerType;
    set => this.m_providerType = value;
  }

  public override void Configure(Assembly sourceAssembly, ILoggerRepository targetRepository)
  {
    if (this.m_providerType == null)
    {
      LogLog.Error($"SecurityContextProviderAttribute: Attribute specified on assembly [{sourceAssembly.FullName}] with null ProviderType.");
    }
    else
    {
      LogLog.Debug($"SecurityContextProviderAttribute: Creating provider of type [{this.m_providerType.FullName}]");
      if (!(Activator.CreateInstance(this.m_providerType) is SecurityContextProvider instance))
        LogLog.Error($"SecurityContextProviderAttribute: Failed to create SecurityContextProvider instance of type [{this.m_providerType.Name}].");
      else
        SecurityContextProvider.DefaultProvider = instance;
    }
  }
}
