// Decompiled with JetBrains decompiler
// Type: log4net.Util.PatternStringConverters.NewLinePatternConverter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System.Globalization;

#nullable disable
namespace log4net.Util.PatternStringConverters;

internal sealed class NewLinePatternConverter : LiteralPatternConverter, IOptionHandler
{
  public void ActivateOptions()
  {
    if (string.Compare(this.Option, "DOS", true, CultureInfo.InvariantCulture) == 0)
      this.Option = "\r\n";
    else if (string.Compare(this.Option, "UNIX", true, CultureInfo.InvariantCulture) == 0)
      this.Option = "\n";
    else
      this.Option = SystemInfo.NewLine;
  }
}
