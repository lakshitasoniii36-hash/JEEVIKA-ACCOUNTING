// Decompiled with JetBrains decompiler
// Type: log4net.Util.TypeConverters.TypeConverterAttribute
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;

#nullable disable
namespace log4net.Util.TypeConverters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface)]
public sealed class TypeConverterAttribute : Attribute
{
  private string m_typeName;

  public TypeConverterAttribute()
  {
  }

  public TypeConverterAttribute(string typeName) => this.m_typeName = typeName;

  public TypeConverterAttribute(Type converterType)
  {
    this.m_typeName = SystemInfo.AssemblyQualifiedName(converterType);
  }

  public string ConverterTypeName
  {
    get => this.m_typeName;
    set => this.m_typeName = value;
  }
}
