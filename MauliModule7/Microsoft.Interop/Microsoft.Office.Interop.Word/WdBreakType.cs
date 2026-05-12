// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdBreakType
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdBreakType
{
  wdSectionBreakNextPage = 2,
  wdSectionBreakContinuous = 3,
  wdSectionBreakEvenPage = 4,
  wdSectionBreakOddPage = 5,
  wdLineBreak = 6,
  wdPageBreak = 7,
  wdColumnBreak = 8,
  wdLineBreakClearLeft = 9,
  wdLineBreakClearRight = 10, // 0x0000000A
  wdTextWrappingBreak = 11, // 0x0000000B
}
