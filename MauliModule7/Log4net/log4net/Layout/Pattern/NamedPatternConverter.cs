// Decompiled with JetBrains decompiler
// Type: log4net.Layout.Pattern.NamedPatternConverter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using log4net.Util;
using System.IO;

#nullable disable
namespace log4net.Layout.Pattern;

internal abstract class NamedPatternConverter : PatternLayoutConverter, IOptionHandler
{
  protected int m_precision;

  public void ActivateOptions()
  {
    this.m_precision = 0;
    if (this.Option == null)
      return;
    string s = this.Option.Trim();
    if (s.Length <= 0)
      return;
    int val;
    if (SystemInfo.TryParse(s, out val))
    {
      if (val <= 0)
        LogLog.Error($"NamedPatternConverter: Precision option ({s}) isn't a positive integer.");
      else
        this.m_precision = val;
    }
    else
      LogLog.Error($"NamedPatternConverter: Precision option \"{s}\" not a decimal integer.");
  }

  protected abstract string GetFullyQualifiedName(LoggingEvent loggingEvent);

  protected override void Convert(TextWriter writer, LoggingEvent loggingEvent)
  {
    string fullyQualifiedName = this.GetFullyQualifiedName(loggingEvent);
    if (this.m_precision <= 0)
    {
      writer.Write(fullyQualifiedName);
    }
    else
    {
      int length = fullyQualifiedName.Length;
      int num = length - 1;
      for (int precision = this.m_precision; precision > 0; --precision)
      {
        num = fullyQualifiedName.LastIndexOf('.', num - 1);
        if (num == -1)
        {
          writer.Write(fullyQualifiedName);
          return;
        }
      }
      writer.Write(fullyQualifiedName.Substring(num + 1, length - num - 1));
    }
  }
}
