// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.IMsoChart
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[Guid("000C1709-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
[ComImport]
public interface IMsoChart
{
  [DispId(150)]
  object Parent { [DispId(150), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  bool HasTitle { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610743811 /*0x60020003*/)]
  IMsoChartTitle ChartTitle { [DispId(1610743811 /*0x60020003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743812 /*0x60020004*/)]
  int DepthPercent { [DispId(1610743812 /*0x60020004*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610743812 /*0x60020004*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610743814 /*0x60020006*/)]
  int Elevation { [DispId(1610743814 /*0x60020006*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610743814 /*0x60020006*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610743816 /*0x60020008*/)]
  int GapDepth { [DispId(1610743816 /*0x60020008*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610743816 /*0x60020008*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610743818 /*0x6002000A*/)]
  int HeightPercent { [DispId(1610743818 /*0x6002000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610743818 /*0x6002000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610743820 /*0x6002000C*/)]
  int Perspective { [DispId(1610743820 /*0x6002000C*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610743820 /*0x6002000C*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610743822 /*0x6002000E*/)]
  object RightAngleAxes { [DispId(1610743822 /*0x6002000E*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(1610743822 /*0x6002000E*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(1610743824 /*0x60020010*/)]
  object Rotation { [DispId(1610743824 /*0x60020010*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(1610743824 /*0x60020010*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(1610743826)]
  XlDisplayBlanksAs DisplayBlanksAs { [DispId(1610743826), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610743826), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610743828)]
  bool ProtectData { [TypeLibFunc(1), DispId(1610743828), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [TypeLibFunc(1), DispId(1610743828), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610743830)]
  bool ProtectFormatting { [DispId(1610743830), TypeLibFunc(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610743830), TypeLibFunc(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610743832)]
  bool ProtectGoalSeek { [TypeLibFunc(1), DispId(1610743832), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [TypeLibFunc(1), DispId(1610743832), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610743834)]
  bool ProtectSelection { [TypeLibFunc(1), DispId(1610743834), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [TypeLibFunc(1), DispId(1610743834), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610743836)]
  bool ProtectChartObjects { [TypeLibFunc(1), DispId(1610743836), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [TypeLibFunc(1), DispId(1610743836), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(1)]
  [DispId(1610743838)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void UnProtect([MarshalAs(UnmanagedType.Struct), In, Optional] object Password);

  [DispId(1610743839)]
  [TypeLibFunc(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Protect(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DrawingObjects,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Contents,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Scenarios,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UserInterfaceOnly);

  [DispId(8)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object get_ChartGroups([MarshalAs(UnmanagedType.Struct), In, Optional] ref object pvarIndex, [MarshalAs(UnmanagedType.Struct), In, Optional] object varIgallery);

  [DispId(68)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object SeriesCollection([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(151)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _ApplyDataLabels(
    [In] XlDataLabelsType Type = XlDataLabelsType.xlDataLabelsShowValue,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IMsoLegendKey,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object HasLeaderLines);

  [DispId(109)]
  int SubType { [TypeLibFunc(64 /*0x40*/), DispId(109), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), DispId(109), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(108)]
  int Type { [DispId(108), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(108), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(79)]
  IMsoCorners Corners { [DispId(79), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1922)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyDataLabels(
    [In] XlDataLabelsType Type = XlDataLabelsType.xlDataLabelsShowValue,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IMsoLegendKey,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object HasLeaderLines,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowSeriesName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowCategoryName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowValue,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowPercentage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowBubbleSize,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Separator);

  [DispId(1400)]
  XlChartType ChartType { [DispId(1400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1396)]
  bool HasDataTable { [DispId(1396), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1396), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1401)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyCustomType([In] XlChartType ChartType, [MarshalAs(UnmanagedType.Struct), In, Optional] object TypeName);

  [DispId(1409)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void GetChartElement([In] int x, [In] int y, [In, Out] ref int ElementID, [In, Out] ref int Arg1, [In, Out] ref int Arg2);

  [DispId(1413)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetSourceData([MarshalAs(UnmanagedType.BStr), In] string Source, [MarshalAs(UnmanagedType.Struct), In, Optional] object PlotBy);

  [DispId(202)]
  XlRowCol PlotBy { [DispId(202), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(202), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(53)]
  bool HasLegend { [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(84)]
  IMsoLegend Legend { [DispId(84), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743861)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Axes([MarshalAs(UnmanagedType.Struct), In, Optional] object Type, [In] XlAxisGroup AxisGroup = XlAxisGroup.xlPrimary);

  [DispId(1610743862)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void set_HasAxis([MarshalAs(UnmanagedType.Struct), In, Optional] object axisType, [MarshalAs(UnmanagedType.Struct), In, Optional] object AxisGroup, [MarshalAs(UnmanagedType.Struct), In, Optional] object pval);

  [DispId(1610743862)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object get_HasAxis([MarshalAs(UnmanagedType.Struct), In, Optional] object axisType, [MarshalAs(UnmanagedType.Struct), In, Optional] object AxisGroup);

  [DispId(1610743864)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IMsoWalls get_Walls([In] bool fBackWall = true);

  [DispId(1610743865)]
  IMsoFloor Floor { [DispId(1610743865), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743866)]
  IMsoPlotArea PlotArea { [DispId(1610743866), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(92)]
  bool PlotVisibleOnly { [DispId(92), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(92), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610743869)]
  IMsoChartArea ChartArea { [DispId(1610743869), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743870)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AutoFormat([In] int rGallery, [MarshalAs(UnmanagedType.Struct), In, Optional] object varFormat);

  [DispId(1610743871)]
  bool AutoScaling { [DispId(1610743871), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610743871), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610743873)]
  [TypeLibFunc(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetBackgroundPicture([MarshalAs(UnmanagedType.BStr), In] string bstr);

  [LCIDConversion(11)]
  [DispId(1610743874)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ChartWizard(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varSource,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varGallery,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varPlotBy,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varCategoryLabels,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varSeriesLabels,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varHasLegend,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varTitle,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varCategoryTitle,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varValueTitle,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varExtraTitle);

  [DispId(1610743875)]
  [LCIDConversion(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CopyPicture([In] int Appearance = 1, [In] int Format = -4147, [In] int Size = 2);

  [DispId(1610743876)]
  IMsoDataTable DataTable { [DispId(1610743876), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743877)]
  [TypeLibFunc(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Evaluate([MarshalAs(UnmanagedType.Struct), In] object varName, [In] int LocaleID, out int ObjType);

  [DispId(1610743878)]
  [TypeLibFunc(1025)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _Evaluate([MarshalAs(UnmanagedType.Struct), In] object varName, [In] int LocaleID);

  [TypeLibFunc(1)]
  [DispId(1610743879)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Paste([MarshalAs(UnmanagedType.Struct), In, Optional] object varType);

  [DispId(1610743880)]
  XlBarShape BarShape { [DispId(1610743880), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610743880), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610743882)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Export([MarshalAs(UnmanagedType.BStr), In] string bstr, [MarshalAs(UnmanagedType.Struct), In, Optional] object varFilterName, [MarshalAs(UnmanagedType.Struct), In, Optional] object varInteractive);

  [DispId(1610743883)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetDefaultChart([MarshalAs(UnmanagedType.Struct), In] object varName);

  [DispId(1610743884)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyChartTemplate([MarshalAs(UnmanagedType.BStr), In] string bstrFileName);

  [DispId(1610743885)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SaveChartTemplate([MarshalAs(UnmanagedType.BStr), In] string bstrFileName);

  [DispId(2377)]
  IMsoWalls SideWall { [DispId(2377), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2378)]
  IMsoWalls BackWall { [DispId(2378), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2465)]
  object ChartStyle { [DispId(2465), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(2465), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(2466)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearToMatchStyle();

  [DispId(1814)]
  object PivotLayout { [DispId(1814), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1815)]
  bool HasPivotFields { [DispId(1815), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1815), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610743894)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RefreshPivotTable();

  [DispId(1610743895)]
  bool ShowDataLabelsOverMaximum { [DispId(1610743895), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610743895), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2468)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyLayout([In] int Layout, [MarshalAs(UnmanagedType.Struct), In, Optional] object varChartType);

  [DispId(1610743898)]
  object Selection { [DispId(1610743898), TypeLibFunc(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610743899)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Refresh();

  [DispId(1610743900)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetElement([In] MsoChartElementType RHS);

  [DispId(1610743901)]
  IMsoChartData ChartData { [DispId(1610743901), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743902)]
  IMsoChartFormat Format { [DispId(1610743902), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743903)]
  Shapes Shapes { [DispId(1610743903), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
}
