// Decompiled with JetBrains decompiler
// Type: log4net.Layout.Pattern.RelativeTimePatternConverter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System;
using System.Globalization;
using System.IO;

#nullable disable
namespace log4net.Layout.Pattern;

internal sealed class RelativeTimePatternConverter : PatternLayoutConverter
{
  protected override void Convert(TextWriter writer, LoggingEvent loggingEvent)
  {
    writer.Write(RelativeTimePatternConverter.TimeDifferenceInMillis(LoggingEvent.StartTime, loggingEvent.TimeStamp).ToString((IFormatProvider) NumberFormatInfo.InvariantInfo));
  }

  private static long TimeDifferenceInMillis(DateTime start, DateTime end)
  {
    return (long) (end.ToUniversalTime() - start.ToUniversalTime()).TotalMilliseconds;
  }
}
