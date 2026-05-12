// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.XlTrendlineType
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(16 /*0x10*/)]
public enum XlTrendlineType
{
  xlLogarithmic = -4133, // 0xFFFFEFDB
  xlLinear = -4132, // 0xFFFFEFDC
  xlPolynomial = 3,
  xlPower = 4,
  xlExponential = 5,
  xlMovingAvg = 6,
}
