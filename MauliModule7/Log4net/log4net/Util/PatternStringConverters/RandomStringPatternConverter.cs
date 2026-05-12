// Decompiled with JetBrains decompiler
// Type: log4net.Util.PatternStringConverters.RandomStringPatternConverter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System;
using System.IO;

#nullable disable
namespace log4net.Util.PatternStringConverters;

internal sealed class RandomStringPatternConverter : PatternConverter, IOptionHandler
{
  private static readonly Random s_random = new Random();
  private int m_length = 4;

  public void ActivateOptions()
  {
    string option = this.Option;
    if (option == null || option.Length <= 0)
      return;
    int val;
    if (SystemInfo.TryParse(option, out val))
      this.m_length = val;
    else
      LogLog.Error($"RandomStringPatternConverter: Could not convert Option [{option}] to Length Int32");
  }

  protected override void Convert(TextWriter writer, object state)
  {
    try
    {
      lock (RandomStringPatternConverter.s_random)
      {
        for (int index = 0; index < this.m_length; ++index)
        {
          int num = RandomStringPatternConverter.s_random.Next(36);
          if (num < 26)
          {
            char ch = (char) (65 + num);
            writer.Write(ch);
          }
          else if (num < 36)
          {
            char ch = (char) (48 /*0x30*/ + (num - 26));
            writer.Write(ch);
          }
          else
            writer.Write('X');
        }
      }
    }
    catch (Exception ex)
    {
      LogLog.Error("RandomStringPatternConverter: Error occurred while converting.", ex);
    }
  }
}
