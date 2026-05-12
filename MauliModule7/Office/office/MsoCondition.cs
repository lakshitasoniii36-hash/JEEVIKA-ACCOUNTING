// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.MsoCondition
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(16 /*0x10*/)]
public enum MsoCondition
{
  msoConditionFileTypeAllFiles = 1,
  msoConditionFileTypeOfficeFiles = 2,
  msoConditionFileTypeWordDocuments = 3,
  msoConditionFileTypeExcelWorkbooks = 4,
  msoConditionFileTypePowerPointPresentations = 5,
  msoConditionFileTypeBinders = 6,
  msoConditionFileTypeDatabases = 7,
  msoConditionFileTypeTemplates = 8,
  msoConditionIncludes = 9,
  msoConditionIncludesPhrase = 10, // 0x0000000A
  msoConditionBeginsWith = 11, // 0x0000000B
  msoConditionEndsWith = 12, // 0x0000000C
  msoConditionIncludesNearEachOther = 13, // 0x0000000D
  msoConditionIsExactly = 14, // 0x0000000E
  msoConditionIsNot = 15, // 0x0000000F
  msoConditionYesterday = 16, // 0x00000010
  msoConditionToday = 17, // 0x00000011
  msoConditionTomorrow = 18, // 0x00000012
  msoConditionLastWeek = 19, // 0x00000013
  msoConditionThisWeek = 20, // 0x00000014
  msoConditionNextWeek = 21, // 0x00000015
  msoConditionLastMonth = 22, // 0x00000016
  msoConditionThisMonth = 23, // 0x00000017
  msoConditionNextMonth = 24, // 0x00000018
  msoConditionAnytime = 25, // 0x00000019
  msoConditionAnytimeBetween = 26, // 0x0000001A
  msoConditionOn = 27, // 0x0000001B
  msoConditionOnOrAfter = 28, // 0x0000001C
  msoConditionOnOrBefore = 29, // 0x0000001D
  msoConditionInTheNext = 30, // 0x0000001E
  msoConditionInTheLast = 31, // 0x0000001F
  msoConditionEquals = 32, // 0x00000020
  msoConditionDoesNotEqual = 33, // 0x00000021
  msoConditionAnyNumberBetween = 34, // 0x00000022
  msoConditionAtMost = 35, // 0x00000023
  msoConditionAtLeast = 36, // 0x00000024
  msoConditionMoreThan = 37, // 0x00000025
  msoConditionLessThan = 38, // 0x00000026
  msoConditionIsYes = 39, // 0x00000027
  msoConditionIsNo = 40, // 0x00000028
  msoConditionIncludesFormsOf = 41, // 0x00000029
  msoConditionFreeText = 42, // 0x0000002A
  msoConditionFileTypeOutlookItems = 43, // 0x0000002B
  msoConditionFileTypeMailItem = 44, // 0x0000002C
  msoConditionFileTypeCalendarItem = 45, // 0x0000002D
  msoConditionFileTypeContactItem = 46, // 0x0000002E
  msoConditionFileTypeNoteItem = 47, // 0x0000002F
  msoConditionFileTypeJournalItem = 48, // 0x00000030
  msoConditionFileTypeTaskItem = 49, // 0x00000031
  msoConditionFileTypePhotoDrawFiles = 50, // 0x00000032
  msoConditionFileTypeDataConnectionFiles = 51, // 0x00000033
  msoConditionFileTypePublisherFiles = 52, // 0x00000034
  msoConditionFileTypeProjectFiles = 53, // 0x00000035
  msoConditionFileTypeDocumentImagingFiles = 54, // 0x00000036
  msoConditionFileTypeVisioFiles = 55, // 0x00000037
  msoConditionFileTypeDesignerFiles = 56, // 0x00000038
  msoConditionFileTypeWebPages = 57, // 0x00000039
  msoConditionEqualsLow = 58, // 0x0000003A
  msoConditionEqualsNormal = 59, // 0x0000003B
  msoConditionEqualsHigh = 60, // 0x0000003C
  msoConditionNotEqualToLow = 61, // 0x0000003D
  msoConditionNotEqualToNormal = 62, // 0x0000003E
  msoConditionNotEqualToHigh = 63, // 0x0000003F
  msoConditionEqualsNotStarted = 64, // 0x00000040
  msoConditionEqualsInProgress = 65, // 0x00000041
  msoConditionEqualsCompleted = 66, // 0x00000042
  msoConditionEqualsWaitingForSomeoneElse = 67, // 0x00000043
  msoConditionEqualsDeferred = 68, // 0x00000044
  msoConditionNotEqualToNotStarted = 69, // 0x00000045
  msoConditionNotEqualToInProgress = 70, // 0x00000046
  msoConditionNotEqualToCompleted = 71, // 0x00000047
  msoConditionNotEqualToWaitingForSomeoneElse = 72, // 0x00000048
  msoConditionNotEqualToDeferred = 73, // 0x00000049
}
