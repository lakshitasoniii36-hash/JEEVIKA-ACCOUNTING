// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdRecoveryType
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdRecoveryType
{
  wdPasteDefault = 0,
  wdSingleCellText = 5,
  wdSingleCellTable = 6,
  wdListContinueNumbering = 7,
  wdListRestartNumbering = 8,
  wdTableAppendTable = 10, // 0x0000000A
  wdTableInsertAsRows = 11, // 0x0000000B
  wdTableOriginalFormatting = 12, // 0x0000000C
  wdChartPicture = 13, // 0x0000000D
  wdChart = 14, // 0x0000000E
  wdChartLinked = 15, // 0x0000000F
  wdFormatOriginalFormatting = 16, // 0x00000010
  wdUseDestinationStylesRecovery = 19, // 0x00000013
  wdFormatSurroundingFormattingWithEmphasis = 20, // 0x00000014
  wdFormatPlainText = 22, // 0x00000016
  wdTableOverwriteCells = 23, // 0x00000017
  wdListCombineWithExistingList = 24, // 0x00000018
  wdListDontMerge = 25, // 0x00000019
}
