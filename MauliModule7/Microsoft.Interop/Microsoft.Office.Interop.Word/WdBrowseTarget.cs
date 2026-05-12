// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdBrowseTarget
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdBrowseTarget
{
  wdBrowsePage = 1,
  wdBrowseSection = 2,
  wdBrowseComment = 3,
  wdBrowseFootnote = 4,
  wdBrowseEndnote = 5,
  wdBrowseField = 6,
  wdBrowseTable = 7,
  wdBrowseGraphic = 8,
  wdBrowseHeading = 9,
  wdBrowseEdit = 10, // 0x0000000A
  wdBrowseFind = 11, // 0x0000000B
  wdBrowseGoTo = 12, // 0x0000000C
}
