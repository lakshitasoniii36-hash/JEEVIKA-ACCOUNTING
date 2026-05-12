// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.CrFieldValueTypeEnum
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[Guid("48F376C8-3E12-11D3-9169-00902741EE7C")]
public enum CrFieldValueTypeEnum
{
  crFieldValueTypeInt8sField = 0,
  crFieldValueTypeInt8uField = 1,
  crFieldValueTypeInt16sField = 2,
  crFieldValueTypeInt16uField = 3,
  crFieldValueTypeInt32sField = 4,
  crFieldValueTypeInt32uField = 5,
  crFieldValueTypeNumberField = 6,
  crFieldValueTypeCurrencyField = 7,
  crFieldValueTypeBooleanField = 8,
  crFieldValueTypeDateField = 9,
  crFieldValueTypeTimeField = 10, // 0x0000000A
  crFieldValueTypeStringField = 11, // 0x0000000B
  crFieldValueTypeTransientMemoField = 12, // 0x0000000C
  crFieldValueTypePersistentMemoField = 13, // 0x0000000D
  crFieldValueTypeBlobField = 14, // 0x0000000E
  crFieldValueTypeDateTimeField = 15, // 0x0000000F
  [TypeLibVar(64 /*0x40*/)] crFieldValueTypeDecimalField = 16, // 0x00000010
  [TypeLibVar(64 /*0x40*/)] crFieldValueTypeInt64sField = 17, // 0x00000011
  [TypeLibVar(64 /*0x40*/)] crFieldValueTypeInt64uField = 18, // 0x00000012
  crFieldValueTypeBitmapField = 20, // 0x00000014
  crFieldValueTypeIconField = 21, // 0x00000015
  crFieldValueTypePictureField = 22, // 0x00000016
  crFieldValueTypeOleField = 23, // 0x00000017
  crFieldValueTypeChartField = 24, // 0x00000018
  crFieldValueTypeSameAsInputField = 25, // 0x00000019
  crFieldValueTypePointerField = 100, // 0x00000064
  crFieldValueTypeInterfacePointerField = 101, // 0x00000065
  crFieldValueTypeUnknownField = 255, // 0x000000FF
}
