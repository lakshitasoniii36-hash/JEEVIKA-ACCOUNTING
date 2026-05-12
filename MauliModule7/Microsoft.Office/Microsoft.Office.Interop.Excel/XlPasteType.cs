// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.XlPasteType
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

#nullable disable
namespace Microsoft.Office.Interop.Excel;

public enum XlPasteType
{
  xlPasteValues = -4163, // 0xFFFFEFBD
  xlPasteComments = -4144, // 0xFFFFEFD0
  xlPasteFormulas = -4123, // 0xFFFFEFE5
  xlPasteFormats = -4122, // 0xFFFFEFE6
  xlPasteAll = -4104, // 0xFFFFEFF8
  xlPasteValidation = 6,
  xlPasteAllExceptBorders = 7,
  xlPasteColumnWidths = 8,
  xlPasteFormulasAndNumberFormats = 11, // 0x0000000B
  xlPasteValuesAndNumberFormats = 12, // 0x0000000C
  xlPasteAllUsingSourceTheme = 13, // 0x0000000D
}
