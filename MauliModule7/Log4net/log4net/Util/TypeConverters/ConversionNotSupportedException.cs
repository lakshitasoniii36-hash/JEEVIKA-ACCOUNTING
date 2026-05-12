// Decompiled with JetBrains decompiler
// Type: log4net.Util.TypeConverters.ConversionNotSupportedException
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;
using System.Runtime.Serialization;

#nullable disable
namespace log4net.Util.TypeConverters;

[Serializable]
public class ConversionNotSupportedException : ApplicationException
{
  public ConversionNotSupportedException()
  {
  }

  public ConversionNotSupportedException(string message)
    : base(message)
  {
  }

  public ConversionNotSupportedException(string message, Exception innerException)
    : base(message, innerException)
  {
  }

  protected ConversionNotSupportedException(SerializationInfo info, StreamingContext context)
    : base(info, context)
  {
  }

  public static ConversionNotSupportedException Create(Type destinationType, object sourceValue)
  {
    return ConversionNotSupportedException.Create(destinationType, sourceValue, (Exception) null);
  }

  public static ConversionNotSupportedException Create(
    Type destinationType,
    object sourceValue,
    Exception innerException)
  {
    if (sourceValue == null)
      return new ConversionNotSupportedException($"Cannot convert value [null] to type [{(object) destinationType}]", innerException);
    return new ConversionNotSupportedException($"Cannot convert from type [{(object) sourceValue.GetType()}] value [{sourceValue}] to type [{(object) destinationType}]", innerException);
  }
}
