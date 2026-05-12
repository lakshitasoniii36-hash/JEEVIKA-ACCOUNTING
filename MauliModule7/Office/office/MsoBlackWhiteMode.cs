// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.MsoBlackWhiteMode
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

#nullable disable
namespace Microsoft.Office.Core;

public enum MsoBlackWhiteMode
{
  msoBlackWhiteMixed = -2, // 0xFFFFFFFE
  msoBlackWhiteAutomatic = 1,
  msoBlackWhiteGrayScale = 2,
  msoBlackWhiteLightGrayScale = 3,
  msoBlackWhiteInverseGrayScale = 4,
  msoBlackWhiteGrayOutline = 5,
  msoBlackWhiteBlackTextAndLine = 6,
  msoBlackWhiteHighContrast = 7,
  msoBlackWhiteBlack = 8,
  msoBlackWhiteWhite = 9,
  msoBlackWhiteDontShow = 10, // 0x0000000A
}
