// Decompiled with JetBrains decompiler
// Type: log4net.DateFormatter.SimpleDateFormatter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;
using System.Globalization;
using System.IO;

#nullable disable
namespace log4net.DateFormatter;

public class SimpleDateFormatter : IDateFormatter
{
  private readonly string m_formatString;

  public SimpleDateFormatter(string format) => this.m_formatString = format;

  public virtual void FormatDate(DateTime dateToFormat, TextWriter writer)
  {
    writer.Write(dateToFormat.ToString(this.m_formatString, (IFormatProvider) DateTimeFormatInfo.InvariantInfo));
  }
}
