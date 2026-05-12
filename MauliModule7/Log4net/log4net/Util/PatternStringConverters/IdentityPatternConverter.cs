// Decompiled with JetBrains decompiler
// Type: log4net.Util.PatternStringConverters.IdentityPatternConverter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System.IO;
using System.Security;
using System.Threading;

#nullable disable
namespace log4net.Util.PatternStringConverters;

internal sealed class IdentityPatternConverter : PatternConverter
{
  protected override void Convert(TextWriter writer, object state)
  {
    try
    {
      if (Thread.CurrentPrincipal == null || Thread.CurrentPrincipal.Identity == null || Thread.CurrentPrincipal.Identity.Name == null)
        return;
      writer.Write(Thread.CurrentPrincipal.Identity.Name);
    }
    catch (SecurityException ex)
    {
      LogLog.Debug("IdentityPatternConverter: Security exception while trying to get current thread principal. Error Ignored.");
      writer.Write(SystemInfo.NotAvailableText);
    }
  }
}
