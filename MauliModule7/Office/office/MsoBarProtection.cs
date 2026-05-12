// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.MsoBarProtection
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

#nullable disable
namespace Microsoft.Office.Core;

public enum MsoBarProtection
{
  msoBarNoProtection = 0,
  msoBarNoCustomize = 1,
  msoBarNoResize = 2,
  msoBarNoMove = 4,
  msoBarNoChangeVisible = 8,
  msoBarNoChangeDock = 16, // 0x00000010
  msoBarNoVerticalDock = 32, // 0x00000020
  msoBarNoHorizontalDock = 64, // 0x00000040
}
