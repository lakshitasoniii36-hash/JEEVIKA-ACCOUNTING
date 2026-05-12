// Decompiled with JetBrains decompiler
// Type: log4net.Core.SecurityContextProvider
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Util;

#nullable disable
namespace log4net.Core;

public class SecurityContextProvider
{
  private static SecurityContextProvider s_defaultProvider = new SecurityContextProvider();

  public static SecurityContextProvider DefaultProvider
  {
    get => SecurityContextProvider.s_defaultProvider;
    set => SecurityContextProvider.s_defaultProvider = value;
  }

  protected SecurityContextProvider()
  {
  }

  public virtual SecurityContext CreateSecurityContext(object consumer)
  {
    return (SecurityContext) NullSecurityContext.Instance;
  }
}
