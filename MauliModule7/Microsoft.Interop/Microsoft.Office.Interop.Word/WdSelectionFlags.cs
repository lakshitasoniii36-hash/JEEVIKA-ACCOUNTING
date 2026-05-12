// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdSelectionFlags
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdSelectionFlags
{
  wdSelStartActive = 1,
  wdSelAtEOL = 2,
  wdSelOvertype = 4,
  wdSelActive = 8,
  wdSelReplace = 16, // 0x00000010
}
