// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdMailMergeDataSource
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdMailMergeDataSource
{
  wdNoMergeInfo = -1, // 0xFFFFFFFF
  wdMergeInfoFromWord = 0,
  wdMergeInfoFromAccessDDE = 1,
  wdMergeInfoFromExcelDDE = 2,
  wdMergeInfoFromMSQueryDDE = 3,
  wdMergeInfoFromODBC = 4,
  wdMergeInfoFromODSO = 5,
}
