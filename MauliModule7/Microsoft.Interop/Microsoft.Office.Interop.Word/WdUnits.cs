// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdUnits
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdUnits
{
  wdCharacter = 1,
  wdWord = 2,
  wdSentence = 3,
  wdParagraph = 4,
  wdLine = 5,
  wdStory = 6,
  wdScreen = 7,
  wdSection = 8,
  wdColumn = 9,
  wdRow = 10, // 0x0000000A
  wdWindow = 11, // 0x0000000B
  wdCell = 12, // 0x0000000C
  wdCharacterFormatting = 13, // 0x0000000D
  wdParagraphFormatting = 14, // 0x0000000E
  wdTable = 15, // 0x0000000F
  wdItem = 16, // 0x00000010
}
