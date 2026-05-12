// Decompiled with JetBrains decompiler
// Type: log4net.Config.BasicConfigurator
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Appender;
using log4net.Layout;
using log4net.Repository;
using log4net.Util;
using System.Reflection;

#nullable disable
namespace log4net.Config;

public sealed class BasicConfigurator
{
  private BasicConfigurator()
  {
  }

  public static void Configure()
  {
    BasicConfigurator.Configure(LogManager.GetRepository(Assembly.GetCallingAssembly()));
  }

  public static void Configure(IAppender appender)
  {
    BasicConfigurator.Configure(LogManager.GetRepository(Assembly.GetCallingAssembly()), appender);
  }

  public static void Configure(ILoggerRepository repository)
  {
    PatternLayout patternLayout = new PatternLayout();
    patternLayout.ConversionPattern = "%timestamp [%thread] %level %logger %ndc - %message%newline";
    patternLayout.ActivateOptions();
    ConsoleAppender consoleAppender = new ConsoleAppender();
    consoleAppender.Layout = (ILayout) patternLayout;
    consoleAppender.ActivateOptions();
    BasicConfigurator.Configure(repository, (IAppender) consoleAppender);
  }

  public static void Configure(ILoggerRepository repository, IAppender appender)
  {
    if (repository is IBasicRepositoryConfigurator repositoryConfigurator)
      repositoryConfigurator.Configure(appender);
    else
      LogLog.Warn($"BasicConfigurator: Repository [{(object) repository}] does not support the BasicConfigurator");
  }
}
