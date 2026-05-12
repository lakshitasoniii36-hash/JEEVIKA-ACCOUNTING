// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdRemoveDocInfoType
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdRemoveDocInfoType
{
  wdRDIComments = 1,
  wdRDIRevisions = 2,
  wdRDIVersions = 3,
  wdRDIRemovePersonalInformation = 4,
  wdRDIEmailHeader = 5,
  wdRDIRoutingSlip = 6,
  wdRDISendForReview = 7,
  wdRDIDocumentProperties = 8,
  wdRDITemplate = 9,
  wdRDIDocumentWorkspace = 10, // 0x0000000A
  wdRDIInkAnnotations = 11, // 0x0000000B
  wdRDIDocumentServerProperties = 14, // 0x0000000E
  wdRDIDocumentManagementPolicy = 15, // 0x0000000F
  wdRDIContentType = 16, // 0x00000010
  wdRDIAll = 99, // 0x00000063
}
