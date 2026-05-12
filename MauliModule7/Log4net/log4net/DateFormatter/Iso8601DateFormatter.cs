// Decompiled with JetBrains decompiler
// Type: log4net.DateFormatter.Iso8601DateFormatter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;
using System.Text;

#nullable disable
namespace log4net.DateFormatter;

public class Iso8601DateFormatter : AbsoluteTimeDateFormatter
{
  protected override void FormatDateWithoutMillis(DateTime dateToFormat, StringBuilder buffer)
  {
    buffer.Append(dateToFormat.Year);
    buffer.Append('-');
    int month = dateToFormat.Month;
    if (month < 10)
      buffer.Append('0');
    buffer.Append(month);
    buffer.Append('-');
    int day = dateToFormat.Day;
    if (day < 10)
      buffer.Append('0');
    buffer.Append(day);
    buffer.Append(' ');
    base.FormatDateWithoutMillis(dateToFormat, buffer);
  }
}
