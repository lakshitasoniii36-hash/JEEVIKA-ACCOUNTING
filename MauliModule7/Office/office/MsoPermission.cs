// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.MsoPermission
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

#nullable disable
namespace Microsoft.Office.Core;

public enum MsoPermission
{
  msoPermissionRead = 1,
  msoPermissionView = 1,
  msoPermissionEdit = 2,
  msoPermissionSave = 4,
  msoPermissionExtract = 8,
  msoPermissionChange = 15, // 0x0000000F
  msoPermissionPrint = 16, // 0x00000010
  msoPermissionObjModel = 32, // 0x00000020
  msoPermissionFullControl = 64, // 0x00000040
  msoPermissionAllCommon = 127, // 0x0000007F
}
