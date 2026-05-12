// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.XlConditionValueTypes
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

#nullable disable
namespace Microsoft.Office.Interop.Excel;

public enum XlConditionValueTypes
{
  xlConditionValueNone = -1, // 0xFFFFFFFF
  xlConditionValueNumber = 0,
  xlConditionValueLowestValue = 1,
  xlConditionValueHighestValue = 2,
  xlConditionValuePercent = 3,
  xlConditionValueFormula = 4,
  xlConditionValuePercentile = 5,
}
