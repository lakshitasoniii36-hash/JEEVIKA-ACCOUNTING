// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.WdPaperTray
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

#nullable disable
namespace Microsoft.Office.Interop.Word;

public enum WdPaperTray
{
  wdPrinterDefaultBin = 0,
  wdPrinterOnlyBin = 1,
  wdPrinterUpperBin = 1,
  wdPrinterLowerBin = 2,
  wdPrinterMiddleBin = 3,
  wdPrinterManualFeed = 4,
  wdPrinterEnvelopeFeed = 5,
  wdPrinterManualEnvelopeFeed = 6,
  wdPrinterAutomaticSheetFeed = 7,
  wdPrinterTractorFeed = 8,
  wdPrinterSmallFormatBin = 9,
  wdPrinterLargeFormatBin = 10, // 0x0000000A
  wdPrinterLargeCapacityBin = 11, // 0x0000000B
  wdPrinterPaperCassette = 14, // 0x0000000E
  wdPrinterFormSource = 15, // 0x0000000F
}
