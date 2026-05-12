// Decompiled with JetBrains decompiler
// Type: log4net.Util.TypeConverters.PatternStringConverter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;

#nullable disable
namespace log4net.Util.TypeConverters;

internal class PatternStringConverter : IConvertTo, IConvertFrom
{
  public bool CanConvertTo(Type targetType) => typeof (string).IsAssignableFrom(targetType);

  public object ConvertTo(object source, Type targetType)
  {
    if (source is PatternString patternString && this.CanConvertTo(targetType))
      return (object) patternString.Format();
    throw ConversionNotSupportedException.Create(targetType, source);
  }

  public bool CanConvertFrom(Type sourceType) => sourceType == typeof (string);

  public object ConvertFrom(object source)
  {
    return source is string pattern ? (object) new PatternString(pattern) : throw ConversionNotSupportedException.Create(typeof (PatternString), source);
  }
}
