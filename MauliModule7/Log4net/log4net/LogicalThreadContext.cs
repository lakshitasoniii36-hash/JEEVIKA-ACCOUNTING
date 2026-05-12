// Decompiled with JetBrains decompiler
// Type: log4net.LogicalThreadContext
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Util;

#nullable disable
namespace log4net;

public sealed class LogicalThreadContext
{
  private static readonly LogicalThreadContextProperties s_properties = new LogicalThreadContextProperties();
  private static readonly ThreadContextStacks s_stacks = new ThreadContextStacks((ContextPropertiesBase) LogicalThreadContext.s_properties);

  private LogicalThreadContext()
  {
  }

  public static LogicalThreadContextProperties Properties => LogicalThreadContext.s_properties;

  public static ThreadContextStacks Stacks => LogicalThreadContext.s_stacks;
}
