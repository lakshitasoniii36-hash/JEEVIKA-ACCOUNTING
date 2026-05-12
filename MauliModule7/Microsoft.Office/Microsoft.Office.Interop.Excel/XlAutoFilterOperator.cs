// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.XlAutoFilterOperator
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

#nullable disable
namespace Microsoft.Office.Interop.Excel;

public enum XlAutoFilterOperator
{
  xlAnd = 1,
  xlOr = 2,
  xlTop10Items = 3,
  xlBottom10Items = 4,
  xlTop10Percent = 5,
  xlBottom10Percent = 6,
  xlFilterValues = 7,
  xlFilterCellColor = 8,
  xlFilterFontColor = 9,
  xlFilterIcon = 10, // 0x0000000A
  xlFilterDynamic = 11, // 0x0000000B
  xlFilterNoFill = 12, // 0x0000000C
  xlFilterAutomaticFontColor = 13, // 0x0000000D
  xlFilterNoIcon = 14, // 0x0000000E
}
