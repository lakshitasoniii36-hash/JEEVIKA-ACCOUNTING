// Decompiled with JetBrains decompiler
// Type: log4net.MDC
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

#nullable disable
namespace log4net;

public sealed class MDC
{
  private MDC()
  {
  }

  public static string Get(string key) => ThreadContext.Properties[key]?.ToString();

  public static void Set(string key, string value)
  {
    ThreadContext.Properties[key] = (object) value;
  }

  public static void Remove(string key) => ThreadContext.Properties.Remove(key);

  public static void Clear() => ThreadContext.Properties.Clear();
}
