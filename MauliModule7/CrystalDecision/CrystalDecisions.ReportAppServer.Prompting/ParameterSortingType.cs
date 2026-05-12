// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.ParameterSortingType
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[Guid("D0CB23DF-F677-4152-BC77-AAFCD394CA36")]
[TypeLibType(528)]
public enum ParameterSortingType
{
  ParameterSortingType_NoSort = 0,
  ParameterSortingType_AlphabeticalAscending = 1,
  ParameterSortingType_Ascending = 1,
  ParameterSortingType_AlphabeticalDescending = 2,
  ParameterSortingType_Descending = 2,
  ParameterSortingType_NumericalAscending = 3,
  ParameterSortingType_NumericalDescending = 4,
  ParameterSortingType_DateTimeAscending = 5,
  ParameterSortingType_DateTimeDescending = 6,
}
