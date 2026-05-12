// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdPasteDataType
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdPasteDataType
{
  wdPasteOLEObject = 0,
  wdPasteRTF = 1,
  wdPasteText = 2,
  wdPasteMetafilePicture = 3,
  wdPasteBitmap = 4,
  wdPasteDeviceIndependentBitmap = 5,
  wdPasteHyperlink = 7,
  wdPasteShape = 8,
  wdPasteEnhancedMetafile = 9,
  wdPasteHTML = 10, // 0x0000000A
}
