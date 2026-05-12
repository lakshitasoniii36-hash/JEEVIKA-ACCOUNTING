// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.XlParameterDataType
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

#nullable disable
namespace Microsoft.Office.Interop.Excel;

public enum XlParameterDataType
{
  xlParamTypeWChar = -8, // 0xFFFFFFF8
  xlParamTypeBit = -7, // 0xFFFFFFF9
  xlParamTypeTinyInt = -6, // 0xFFFFFFFA
  xlParamTypeBigInt = -5, // 0xFFFFFFFB
  xlParamTypeLongVarBinary = -4, // 0xFFFFFFFC
  xlParamTypeVarBinary = -3, // 0xFFFFFFFD
  xlParamTypeBinary = -2, // 0xFFFFFFFE
  xlParamTypeLongVarChar = -1, // 0xFFFFFFFF
  xlParamTypeUnknown = 0,
  xlParamTypeChar = 1,
  xlParamTypeNumeric = 2,
  xlParamTypeDecimal = 3,
  xlParamTypeInteger = 4,
  xlParamTypeSmallInt = 5,
  xlParamTypeFloat = 6,
  xlParamTypeReal = 7,
  xlParamTypeDouble = 8,
  xlParamTypeDate = 9,
  xlParamTypeTime = 10, // 0x0000000A
  xlParamTypeTimestamp = 11, // 0x0000000B
  xlParamTypeVarChar = 12, // 0x0000000C
}
