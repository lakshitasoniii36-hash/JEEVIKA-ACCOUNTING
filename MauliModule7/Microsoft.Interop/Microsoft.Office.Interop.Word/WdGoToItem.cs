// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdGoToItem
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdGoToItem
{
  wdGoToBookmark = -1, // 0xFFFFFFFF
  wdGoToSection = 0,
  wdGoToPage = 1,
  wdGoToTable = 2,
  wdGoToLine = 3,
  wdGoToFootnote = 4,
  wdGoToEndnote = 5,
  wdGoToComment = 6,
  wdGoToField = 7,
  wdGoToGraphic = 8,
  wdGoToObject = 9,
  wdGoToEquation = 10, // 0x0000000A
  wdGoToHeading = 11, // 0x0000000B
  wdGoToPercent = 12, // 0x0000000C
  wdGoToSpellingError = 13, // 0x0000000D
  wdGoToGrammaticalError = 14, // 0x0000000E
  wdGoToProofreadingError = 15, // 0x0000000F
}
