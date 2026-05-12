// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.MsoButtonStyle
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

#nullable disable
namespace Microsoft.Office.Core;

public enum MsoButtonStyle
{
  msoButtonAutomatic = 0,
  msoButtonIcon = 1,
  msoButtonCaption = 2,
  msoButtonIconAndCaption = 3,
  msoButtonIconAndWrapCaption = 7,
  msoButtonIconAndCaptionBelow = 11, // 0x0000000B
  msoButtonWrapCaption = 14, // 0x0000000E
  msoButtonIconAndWrapCaptionBelow = 15, // 0x0000000F
}
