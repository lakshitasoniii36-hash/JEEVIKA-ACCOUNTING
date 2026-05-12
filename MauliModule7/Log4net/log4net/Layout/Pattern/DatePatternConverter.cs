// Decompiled with JetBrains decompiler
// Type: log4net.Layout.Pattern.DatePatternConverter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using log4net.DateFormatter;
using log4net.Util;
using System;
using System.Globalization;
using System.IO;

#nullable disable
namespace log4net.Layout.Pattern;

internal class DatePatternConverter : PatternLayoutConverter, IOptionHandler
{
  protected IDateFormatter m_dateFormatter;

  public void ActivateOptions()
  {
    string str = this.Option ?? "ISO8601";
    if (string.Compare(str, "ISO8601", true, CultureInfo.InvariantCulture) == 0)
      this.m_dateFormatter = (IDateFormatter) new Iso8601DateFormatter();
    else if (string.Compare(str, "ABSOLUTE", true, CultureInfo.InvariantCulture) == 0)
      this.m_dateFormatter = (IDateFormatter) new AbsoluteTimeDateFormatter();
    else if (string.Compare(str, "DATE", true, CultureInfo.InvariantCulture) == 0)
    {
      this.m_dateFormatter = (IDateFormatter) new DateTimeDateFormatter();
    }
    else
    {
      try
      {
        this.m_dateFormatter = (IDateFormatter) new SimpleDateFormatter(str);
      }
      catch (Exception ex)
      {
        LogLog.Error($"DatePatternConverter: Could not instantiate SimpleDateFormatter with [{str}]", ex);
        this.m_dateFormatter = (IDateFormatter) new Iso8601DateFormatter();
      }
    }
  }

  protected override void Convert(TextWriter writer, LoggingEvent loggingEvent)
  {
    try
    {
      this.m_dateFormatter.FormatDate(loggingEvent.TimeStamp, writer);
    }
    catch (Exception ex)
    {
      LogLog.Error("DatePatternConverter: Error occurred while converting date.", ex);
    }
  }
}
