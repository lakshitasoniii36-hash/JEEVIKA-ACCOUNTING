// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdIMEMode
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdIMEMode
{
  wdIMEModeNoControl = 0,
  wdIMEModeOn = 1,
  wdIMEModeOff = 2,
  wdIMEModeHiragana = 4,
  wdIMEModeKatakana = 5,
  wdIMEModeKatakanaHalf = 6,
  wdIMEModeAlphaFull = 7,
  wdIMEModeAlpha = 8,
  wdIMEModeHangulFull = 9,
  wdIMEModeHangul = 10, // 0x0000000A
}
