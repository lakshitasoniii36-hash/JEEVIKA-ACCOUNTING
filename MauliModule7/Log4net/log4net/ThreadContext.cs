// Decompiled with JetBrains decompiler
// Type: log4net.ThreadContext
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Util;

#nullable disable
namespace log4net;

public sealed class ThreadContext
{
  private static readonly ThreadContextProperties s_properties = new ThreadContextProperties();
  private static readonly ThreadContextStacks s_stacks = new ThreadContextStacks((ContextPropertiesBase) ThreadContext.s_properties);

  private ThreadContext()
  {
  }

  public static ThreadContextProperties Properties => ThreadContext.s_properties;

  public static ThreadContextStacks Stacks => ThreadContext.s_stacks;
}
