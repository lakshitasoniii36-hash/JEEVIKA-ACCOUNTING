// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.MsoDateTimeFormat
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

#nullable disable
namespace Microsoft.Office.Core;

public enum MsoDateTimeFormat
{
  msoDateTimeFormatMixed = -2, // 0xFFFFFFFE
  msoDateTimeMdyy = 1,
  msoDateTimeddddMMMMddyyyy = 2,
  msoDateTimedMMMMyyyy = 3,
  msoDateTimeMMMMdyyyy = 4,
  msoDateTimedMMMyy = 5,
  msoDateTimeMMMMyy = 6,
  msoDateTimeMMyy = 7,
  msoDateTimeMMddyyHmm = 8,
  msoDateTimeMMddyyhmmAMPM = 9,
  msoDateTimeHmm = 10, // 0x0000000A
  msoDateTimeHmmss = 11, // 0x0000000B
  msoDateTimehmmAMPM = 12, // 0x0000000C
  msoDateTimehmmssAMPM = 13, // 0x0000000D
  msoDateTimeFigureOut = 14, // 0x0000000E
}
