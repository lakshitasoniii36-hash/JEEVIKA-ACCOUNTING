// Decompiled with JetBrains decompiler
// Type: log4net.Plugin.PluginSkeleton
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Repository;

#nullable disable
namespace log4net.Plugin;

public abstract class PluginSkeleton : IPlugin
{
  private string m_name;
  private ILoggerRepository m_repository;

  protected PluginSkeleton(string name) => this.m_name = name;

  public virtual string Name
  {
    get => this.m_name;
    set => this.m_name = value;
  }

  public virtual void Attach(ILoggerRepository repository) => this.m_repository = repository;

  public virtual void Shutdown()
  {
  }

  protected virtual ILoggerRepository LoggerRepository
  {
    get => this.m_repository;
    set => this.m_repository = value;
  }
}
