// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdReferenceKind
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdReferenceKind
{
  wdNumberFullContext = -4, // 0xFFFFFFFC
  wdNumberNoContext = -3, // 0xFFFFFFFD
  wdNumberRelativeContext = -2, // 0xFFFFFFFE
  wdContentText = -1, // 0xFFFFFFFF
  wdEntireCaption = 2,
  wdOnlyLabelAndNumber = 3,
  wdOnlyCaptionText = 4,
  wdFootnoteNumber = 5,
  wdEndnoteNumber = 6,
  wdPageNumber = 7,
  wdPosition = 15, // 0x0000000F
  wdFootnoteNumberFormatted = 16, // 0x00000010
  wdEndnoteNumberFormatted = 17, // 0x00000011
}
