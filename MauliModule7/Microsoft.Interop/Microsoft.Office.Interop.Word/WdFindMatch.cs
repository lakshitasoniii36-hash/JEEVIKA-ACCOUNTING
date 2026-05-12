// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdFindMatch
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdFindMatch
{
  wdMatchGraphic = 1,
  wdMatchCommentMark = 5,
  wdMatchTabCharacter = 9,
  wdMatchCaretCharacter = 11, // 0x0000000B
  wdMatchColumnBreak = 14, // 0x0000000E
  wdMatchField = 19, // 0x00000013
  wdMatchNonbreakingHyphen = 30, // 0x0000001E
  wdMatchOptionalHyphen = 31, // 0x0000001F
  wdMatchNonbreakingSpace = 160, // 0x000000A0
  wdMatchEnDash = 8211, // 0x00002013
  wdMatchEmDash = 8212, // 0x00002014
  wdMatchManualLineBreak = 65551, // 0x0001000F
  wdMatchParagraphMark = 65551, // 0x0001000F
  wdMatchFootnoteMark = 65554, // 0x00010012
  wdMatchEndnoteMark = 65555, // 0x00010013
  wdMatchManualPageBreak = 65564, // 0x0001001C
  wdMatchAnyDigit = 65567, // 0x0001001F
  wdMatchSectionBreak = 65580, // 0x0001002C
  wdMatchAnyLetter = 65583, // 0x0001002F
  wdMatchAnyCharacter = 65599, // 0x0001003F
  wdMatchWhiteSpace = 65655, // 0x00010077
}
