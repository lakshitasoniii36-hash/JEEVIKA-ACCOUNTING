// Decompiled with JetBrains decompiler
// Type: log4net.Util.PatternStringConverters.ProcessIdPatternConverter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System.Diagnostics;
using System.IO;
using System.Security;

#nullable disable
namespace log4net.Util.PatternStringConverters;

internal sealed class ProcessIdPatternConverter : PatternConverter
{
  protected override void Convert(TextWriter writer, object state)
  {
    try
    {
      writer.Write(Process.GetCurrentProcess().Id);
    }
    catch (SecurityException ex)
    {
      LogLog.Debug("ProcessIdPatternConverter: Security exception while trying to get current process id. Error Ignored.");
      writer.Write(SystemInfo.NotAvailableText);
    }
  }
}
