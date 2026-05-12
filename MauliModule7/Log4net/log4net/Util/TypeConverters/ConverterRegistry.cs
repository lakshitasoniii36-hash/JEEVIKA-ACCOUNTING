// Decompiled with JetBrains decompiler
// Type: log4net.Util.TypeConverters.ConverterRegistry
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Layout;
using System;
using System.Collections;
using System.Net;
using System.Text;

#nullable disable
namespace log4net.Util.TypeConverters;

public sealed class ConverterRegistry
{
  private static Hashtable s_type2converter = new Hashtable();

  private ConverterRegistry()
  {
  }

  static ConverterRegistry()
  {
    ConverterRegistry.AddConverter(typeof (bool), typeof (BooleanConverter));
    ConverterRegistry.AddConverter(typeof (Encoding), typeof (EncodingConverter));
    ConverterRegistry.AddConverter(typeof (Type), typeof (TypeConverter));
    ConverterRegistry.AddConverter(typeof (PatternLayout), typeof (PatternLayoutConverter));
    ConverterRegistry.AddConverter(typeof (PatternString), typeof (PatternStringConverter));
    ConverterRegistry.AddConverter(typeof (IPAddress), typeof (IPAddressConverter));
  }

  public static void AddConverter(Type destinationType, object converter)
  {
    if (destinationType == null || converter == null)
      return;
    lock (ConverterRegistry.s_type2converter)
      ConverterRegistry.s_type2converter[(object) destinationType] = converter;
  }

  public static void AddConverter(Type destinationType, Type converterType)
  {
    ConverterRegistry.AddConverter(destinationType, ConverterRegistry.CreateConverterInstance(converterType));
  }

  public static IConvertTo GetConvertTo(Type sourceType, Type destinationType)
  {
    lock (ConverterRegistry.s_type2converter)
    {
      if (!(ConverterRegistry.s_type2converter[(object) sourceType] is IConvertTo converterFromAttribute2) && ConverterRegistry.GetConverterFromAttribute(sourceType) is IConvertTo converterFromAttribute2)
        ConverterRegistry.s_type2converter[(object) sourceType] = (object) converterFromAttribute2;
      return converterFromAttribute2;
    }
  }

  public static IConvertFrom GetConvertFrom(Type destinationType)
  {
    lock (ConverterRegistry.s_type2converter)
    {
      if (!(ConverterRegistry.s_type2converter[(object) destinationType] is IConvertFrom converterFromAttribute2) && ConverterRegistry.GetConverterFromAttribute(destinationType) is IConvertFrom converterFromAttribute2)
        ConverterRegistry.s_type2converter[(object) destinationType] = (object) converterFromAttribute2;
      return converterFromAttribute2;
    }
  }

  private static object GetConverterFromAttribute(Type destinationType)
  {
    object[] customAttributes = destinationType.GetCustomAttributes(typeof (TypeConverterAttribute), true);
    return customAttributes != null && customAttributes.Length > 0 && customAttributes[0] is TypeConverterAttribute converterAttribute ? ConverterRegistry.CreateConverterInstance(SystemInfo.GetTypeFromString(destinationType, converterAttribute.ConverterTypeName, false, true)) : (object) null;
  }

  private static object CreateConverterInstance(Type converterType)
  {
    if (converterType == null)
      throw new ArgumentNullException(nameof (converterType), "CreateConverterInstance cannot create instance, converterType is null");
    if (!typeof (IConvertFrom).IsAssignableFrom(converterType))
    {
      if (!typeof (IConvertTo).IsAssignableFrom(converterType))
      {
        LogLog.Error($"ConverterRegistry: Cannot CreateConverterInstance of type [{converterType.FullName}], type does not implement IConvertFrom or IConvertTo");
        goto label_7;
      }
    }
    try
    {
      return Activator.CreateInstance(converterType);
    }
    catch (Exception ex)
    {
      LogLog.Error($"ConverterRegistry: Cannot CreateConverterInstance of type [{converterType.FullName}], Exception in call to Activator.CreateInstance", ex);
    }
label_7:
    return (object) null;
  }
}
