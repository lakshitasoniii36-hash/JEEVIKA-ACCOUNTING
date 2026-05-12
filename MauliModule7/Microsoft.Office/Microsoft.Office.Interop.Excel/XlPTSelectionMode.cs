// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.XlPTSelectionMode
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

#nullable disable
namespace Microsoft.Office.Interop.Excel;

public enum XlPTSelectionMode
{
  xlDataAndLabel = 0,
  xlLabelOnly = 1,
  xlDataOnly = 2,
  xlOrigin = 3,
  xlBlanks = 4,
  xlButton = 15, // 0x0000000F
  xlFirstRow = 256, // 0x00000100
}
