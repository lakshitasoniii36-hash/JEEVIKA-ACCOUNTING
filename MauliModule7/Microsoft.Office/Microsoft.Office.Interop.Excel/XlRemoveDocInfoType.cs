// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.XlRemoveDocInfoType
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

#nullable disable
namespace Microsoft.Office.Interop.Excel;

public enum XlRemoveDocInfoType
{
  xlRDIComments = 1,
  xlRDIRemovePersonalInformation = 4,
  xlRDIEmailHeader = 5,
  xlRDIRoutingSlip = 6,
  xlRDISendForReview = 7,
  xlRDIDocumentProperties = 8,
  xlRDIDocumentWorkspace = 10, // 0x0000000A
  xlRDIInkAnnotations = 11, // 0x0000000B
  xlRDIScenarioComments = 12, // 0x0000000C
  xlRDIPublishInfo = 13, // 0x0000000D
  xlRDIDocumentServerProperties = 14, // 0x0000000E
  xlRDIDocumentManagementPolicy = 15, // 0x0000000F
  xlRDIContentType = 16, // 0x00000010
  xlRDIDefinedNameComments = 18, // 0x00000012
  xlRDIInactiveDataConnections = 19, // 0x00000013
  xlRDIPrinterPath = 20, // 0x00000014
  xlRDIAll = 99, // 0x00000063
}
