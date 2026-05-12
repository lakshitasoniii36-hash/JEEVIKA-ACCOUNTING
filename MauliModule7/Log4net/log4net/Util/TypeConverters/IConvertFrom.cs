// Decompiled with JetBrains decompiler
// Type: log4net.Util.TypeConverters.IConvertFrom
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;

#nullable disable
namespace log4net.Util.TypeConverters;

public interface IConvertFrom
{
  bool CanConvertFrom(Type sourceType);

  object ConvertFrom(object source);
}
