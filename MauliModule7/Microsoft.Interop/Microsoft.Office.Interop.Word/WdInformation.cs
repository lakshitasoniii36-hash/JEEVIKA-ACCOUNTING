// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdInformation
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdInformation
{
  wdActiveEndAdjustedPageNumber = 1,
  wdActiveEndSectionNumber = 2,
  wdActiveEndPageNumber = 3,
  wdNumberOfPagesInDocument = 4,
  wdHorizontalPositionRelativeToPage = 5,
  wdVerticalPositionRelativeToPage = 6,
  wdHorizontalPositionRelativeToTextBoundary = 7,
  wdVerticalPositionRelativeToTextBoundary = 8,
  wdFirstCharacterColumnNumber = 9,
  wdFirstCharacterLineNumber = 10, // 0x0000000A
  wdFrameIsSelected = 11, // 0x0000000B
  wdWithInTable = 12, // 0x0000000C
  wdStartOfRangeRowNumber = 13, // 0x0000000D
  wdEndOfRangeRowNumber = 14, // 0x0000000E
  wdMaximumNumberOfRows = 15, // 0x0000000F
  wdStartOfRangeColumnNumber = 16, // 0x00000010
  wdEndOfRangeColumnNumber = 17, // 0x00000011
  wdMaximumNumberOfColumns = 18, // 0x00000012
  wdZoomPercentage = 19, // 0x00000013
  wdSelectionMode = 20, // 0x00000014
  wdCapsLock = 21, // 0x00000015
  wdNumLock = 22, // 0x00000016
  wdOverType = 23, // 0x00000017
  wdRevisionMarking = 24, // 0x00000018
  wdInFootnoteEndnotePane = 25, // 0x00000019
  wdInCommentPane = 26, // 0x0000001A
  wdInHeaderFooter = 28, // 0x0000001C
  wdAtEndOfRowMarker = 31, // 0x0000001F
  wdReferenceOfType = 32, // 0x00000020
  wdHeaderFooterType = 33, // 0x00000021
  wdInMasterDocument = 34, // 0x00000022
  wdInFootnote = 35, // 0x00000023
  wdInEndnote = 36, // 0x00000024
  wdInWordMail = 37, // 0x00000025
  wdInClipboard = 38, // 0x00000026
}
