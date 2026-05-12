// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdInlineShapeType
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdInlineShapeType
{
  wdInlineShapeEmbeddedOLEObject = 1,
  wdInlineShapeLinkedOLEObject = 2,
  wdInlineShapePicture = 3,
  wdInlineShapeLinkedPicture = 4,
  wdInlineShapeOLEControlObject = 5,
  wdInlineShapeHorizontalLine = 6,
  wdInlineShapePictureHorizontalLine = 7,
  wdInlineShapeLinkedPictureHorizontalLine = 8,
  wdInlineShapePictureBullet = 9,
  wdInlineShapeScriptAnchor = 10, // 0x0000000A
  wdInlineShapeOWSAnchor = 11, // 0x0000000B
  wdInlineShapeChart = 12, // 0x0000000C
  wdInlineShapeDiagram = 13, // 0x0000000D
  wdInlineShapeLockedCanvas = 14, // 0x0000000E
  wdInlineShapeSmartArt = 15, // 0x0000000F
}
