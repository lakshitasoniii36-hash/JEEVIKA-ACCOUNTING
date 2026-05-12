// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.XlFormatConditionType
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

#nullable disable
namespace Microsoft.Office.Interop.Excel;

public enum XlFormatConditionType
{
  xlCellValue = 1,
  xlExpression = 2,
  xlColorScale = 3,
  xlDatabar = 4,
  xlTop10 = 5,
  xlIconSets = 6,
  xlUniqueValues = 8,
  xlTextString = 9,
  xlBlanksCondition = 10, // 0x0000000A
  xlTimePeriod = 11, // 0x0000000B
  xlAboveAverageCondition = 12, // 0x0000000C
  xlNoBlanksCondition = 13, // 0x0000000D
  xlErrorsCondition = 16, // 0x00000010
  xlNoErrorsCondition = 17, // 0x00000011
}
