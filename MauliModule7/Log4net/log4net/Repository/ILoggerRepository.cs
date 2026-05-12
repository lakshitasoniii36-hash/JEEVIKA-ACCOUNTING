// Decompiled with JetBrains decompiler
// Type: log4net.Repository.ILoggerRepository
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Appender;
using log4net.Core;
using log4net.ObjectRenderer;
using log4net.Plugin;
using log4net.Util;

#nullable disable
namespace log4net.Repository;

public interface ILoggerRepository
{
  string Name { get; set; }

  RendererMap RendererMap { get; }

  PluginMap PluginMap { get; }

  LevelMap LevelMap { get; }

  Level Threshold { get; set; }

  ILogger Exists(string name);

  ILogger[] GetCurrentLoggers();

  ILogger GetLogger(string name);

  void Shutdown();

  void ResetConfiguration();

  void Log(LoggingEvent logEvent);

  bool Configured { get; set; }

  event LoggerRepositoryShutdownEventHandler ShutdownEvent;

  event LoggerRepositoryConfigurationResetEventHandler ConfigurationReset;

  event LoggerRepositoryConfigurationChangedEventHandler ConfigurationChanged;

  PropertiesDictionary Properties { get; }

  IAppender[] GetAppenders();
}
