// Decompiled with JetBrains decompiler
// Type: log4net.Util.PatternStringConverters.EnvironmentPatternConverter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;
using System.IO;
using System.Security;

#nullable disable
namespace log4net.Util.PatternStringConverters;

internal sealed class EnvironmentPatternConverter : PatternConverter
{
  protected override void Convert(TextWriter writer, object state)
  {
    try
    {
      if (this.Option == null || this.Option.Length <= 0)
        return;
      string environmentVariable = Environment.GetEnvironmentVariable(this.Option);
      if (environmentVariable == null || environmentVariable.Length <= 0)
        return;
      writer.Write(environmentVariable);
    }
    catch (SecurityException ex)
    {
      LogLog.Debug("EnvironmentPatternConverter: Security exception while trying to expand environment variables. Error Ignored. No Expansion.", (Exception) ex);
    }
    catch (Exception ex)
    {
      LogLog.Error("EnvironmentPatternConverter: Error occurred while converting environment variable.", ex);
    }
  }
}
