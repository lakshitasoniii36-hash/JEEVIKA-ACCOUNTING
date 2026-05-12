// Decompiled with JetBrains decompiler
// Type: log4net.Repository.Hierarchy.DefaultLoggerFactory
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;

#nullable disable
namespace log4net.Repository.Hierarchy;

internal class DefaultLoggerFactory : ILoggerFactory
{
  internal DefaultLoggerFactory()
  {
  }

  public Logger CreateLogger(string name)
  {
    return name == null ? (Logger) new RootLogger(Level.Debug) : (Logger) new DefaultLoggerFactory.LoggerImpl(name);
  }

  internal sealed class LoggerImpl : Logger
  {
    internal LoggerImpl(string name)
      : base(name)
    {
    }
  }
}
