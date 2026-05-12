// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel._Chart
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(4288)]
[Guid("000208D6-0000-0000-C000-000000000046")]
[ComImport]
public interface _Chart
{
  [DispId(148)]
  Application Application { [DispId(148), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [DispId(149), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [DispId(150), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [LCIDConversion(0)]
  [DispId(304)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Activate();

  [LCIDConversion(2)]
  [DispId(551)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Copy([MarshalAs(UnmanagedType.Struct), In, Optional] object Before, [MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [LCIDConversion(0)]
  [DispId(117)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Delete();

  [DispId(1373)]
  string CodeName { [DispId(1373), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(-2147418112 /*0x80010000*/)]
  string _CodeName { [TypeLibFunc(1024 /*0x0400*/), DispId(-2147418112 /*0x80010000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(-2147418112 /*0x80010000*/), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(486)]
  int Index { [DispId(486), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [LCIDConversion(2)]
  [DispId(637)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Move([MarshalAs(UnmanagedType.Struct), In, Optional] object Before, [MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [DispId(110)]
  string Name { [DispId(110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(502)]
  object Next { [DispId(502), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(628)]
  string OnDoubleClick { [LCIDConversion(0), DispId(628), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(628), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1031)]
  string OnSheetActivate { [DispId(1031), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), DispId(1031), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1081)]
  string OnSheetDeactivate { [DispId(1081), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), DispId(1081), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(998)]
  PageSetup PageSetup { [DispId(998), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(503)]
  object Previous { [DispId(503), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [LCIDConversion(7)]
  [TypeLibFunc(1088)]
  [DispId(905)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate);

  [DispId(281)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintPreview([MarshalAs(UnmanagedType.Struct), In, Optional] object EnableChanges);

  [LCIDConversion(5)]
  [TypeLibFunc(1088)]
  [DispId(282)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Protect(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DrawingObjects,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Contents,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Scenarios,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UserInterfaceOnly);

  [DispId(292)]
  bool ProtectContents { [DispId(292), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(293)]
  bool ProtectDrawingObjects { [DispId(293), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1159)]
  bool ProtectionMode { [DispId(1159), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(65559)]
  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy23();

  [LCIDConversion(9)]
  [TypeLibFunc(1088)]
  [DispId(284)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _SaveAs(
    [MarshalAs(UnmanagedType.BStr), In] string Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AddToMru,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextCodepage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout);

  [DispId(235)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Select([MarshalAs(UnmanagedType.Struct), In, Optional] object Replace);

  [DispId(285)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Unprotect([MarshalAs(UnmanagedType.Struct), In, Optional] object Password);

  [DispId(558)]
  XlSheetVisibility Visible { [LCIDConversion(0), DispId(558), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(558), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1377)]
  Shapes Shapes { [DispId(1377), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(151)]
  [TypeLibFunc(1088)]
  [LCIDConversion(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _ApplyDataLabels(
    [In] XlDataLabelsType Type = XlDataLabelsType.xlDataLabelsShowValue,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object LegendKey,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object HasLeaderLines);

  [DispId(760)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Arcs([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(17)]
  ChartGroup Area3DGroup { [DispId(17), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(9)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object AreaGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(114)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AutoFormat([In] int Gallery, [MarshalAs(UnmanagedType.Struct), In, Optional] object Format);

  [DispId(107)]
  bool AutoScaling { [LCIDConversion(0), DispId(107), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(107), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(2)]
  [DispId(23)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Axes([MarshalAs(UnmanagedType.Struct), In, Optional] object Type, [In] XlAxisGroup AxisGroup = XlAxisGroup.xlPrimary);

  [DispId(1188)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetBackgroundPicture([MarshalAs(UnmanagedType.BStr), In] string Filename);

  [DispId(18)]
  ChartGroup Bar3DGroup { [DispId(18), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(10)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object BarGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(557)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Buttons([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(80 /*0x50*/)]
  ChartArea ChartArea { [DispId(80 /*0x50*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(8)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ChartGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(1060)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ChartObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(81)]
  ChartTitle ChartTitle { [LCIDConversion(0), DispId(81), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(11)]
  [DispId(196)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ChartWizard(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Source,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Gallery,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PlotBy,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CategoryLabels,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SeriesLabels,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object HasLegend,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Title,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CategoryTitle,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ValueTitle,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ExtraTitle);

  [DispId(824)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object CheckBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(505)]
  [LCIDConversion(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckSpelling(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CustomDictionary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreUppercase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AlwaysSuggest,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SpellLang);

  [DispId(19)]
  ChartGroup Column3DGroup { [DispId(19), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(11)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ColumnGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(3)]
  [DispId(213)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CopyPicture(
    [In] XlPictureAppearance Appearance = XlPictureAppearance.xlScreen,
    [In] XlCopyPictureFormat Format = XlCopyPictureFormat.xlPicture,
    [In] XlPictureAppearance Size = XlPictureAppearance.xlPrinter);

  [DispId(79)]
  Corners Corners { [TypeLibFunc(64 /*0x40*/), DispId(79), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(7)]
  [DispId(458)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CreatePublisher(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Edition,
    [In] XlPictureAppearance Appearance = XlPictureAppearance.xlScreen,
    [In] XlPictureAppearance Size = XlPictureAppearance.xlScreen,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsPICT,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsBIFF,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsRTF,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsVALU);

  [DispId(1395)]
  DataTable DataTable { [DispId(1395), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(48 /*0x30*/)]
  int DepthPercent { [DispId(48 /*0x30*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(48 /*0x30*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1120)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Deselect();

  [DispId(93)]
  XlDisplayBlanksAs DisplayBlanksAs { [DispId(93), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(93), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [DispId(14)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object DoughnutGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(772)]
  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Drawings([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(88)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object DrawingObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [DispId(836)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object DropDowns([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(49)]
  int Elevation { [DispId(49), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(49), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Evaluate([MarshalAs(UnmanagedType.Struct), In] object Name);

  [LCIDConversion(1)]
  [TypeLibFunc(1024 /*0x0400*/)]
  [DispId(-5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _Evaluate([MarshalAs(UnmanagedType.Struct), In] object Name);

  [DispId(83)]
  Floor Floor { [LCIDConversion(0), DispId(83), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(50)]
  int GapDepth { [DispId(50), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(50), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(834)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object GroupBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1113)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object GroupObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(2)]
  [DispId(52)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object get_HasAxis([MarshalAs(UnmanagedType.Struct), In, Optional] object Index1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Index2);

  [DispId(52)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void set_HasAxis([MarshalAs(UnmanagedType.Struct), In, Optional] object Index1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Index2, [MarshalAs(UnmanagedType.Struct), In, Optional] object RHS);

  [DispId(1396)]
  bool HasDataTable { [DispId(1396), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1396), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(53)]
  bool HasLegend { [LCIDConversion(0), DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(53), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(54)]
  bool HasTitle { [LCIDConversion(0), DispId(54), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(54), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(55)]
  int HeightPercent { [LCIDConversion(0), DispId(55), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(55), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1393)]
  Hyperlinks Hyperlinks { [DispId(1393), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [DispId(841)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Labels([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(84)]
  Legend Legend { [LCIDConversion(0), DispId(84), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(20)]
  ChartGroup Line3DGroup { [DispId(20), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(12)]
  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object LineGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(767 /*0x02FF*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Lines([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(1)]
  [DispId(832)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ListBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(1397)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Chart Location([In] XlChartLocation Where, [MarshalAs(UnmanagedType.Struct), In, Optional] object Name);

  [DispId(799)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object OLEObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(826)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object OptionButtons([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [DispId(801)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Ovals([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(1)]
  [DispId(211)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Paste([MarshalAs(UnmanagedType.Struct), In, Optional] object Type);

  [DispId(57)]
  int Perspective { [LCIDConversion(0), DispId(57), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(57), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(771)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Pictures([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(21)]
  ChartGroup Pie3DGroup { [DispId(21), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(13)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object PieGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(85)]
  PlotArea PlotArea { [DispId(85), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(92)]
  bool PlotVisibleOnly { [DispId(92), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(92), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [DispId(15)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object RadarGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(774)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Rectangles([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(58)]
  object RightAngleAxes { [LCIDConversion(0), DispId(58), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [LCIDConversion(0), DispId(58), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(59)]
  object Rotation { [DispId(59), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(59), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [DispId(830)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ScrollBars([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(1)]
  [DispId(68)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object SeriesCollection([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(94)]
  bool SizeWithWindow { [LCIDConversion(0), DispId(94), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), DispId(94), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1399)]
  bool ShowWindow { [DispId(1399), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), DispId(1399), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [DispId(838)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Spinners([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(109)]
  int SubType { [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), DispId(109), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), DispId(109), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(22)]
  ChartGroup SurfaceGroup { [TypeLibFunc(64 /*0x40*/), DispId(22), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(777)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object TextBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(108)]
  int Type { [TypeLibFunc(64 /*0x40*/), DispId(108), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(108), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1400)]
  XlChartType ChartType { [DispId(1400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1401)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyCustomType([In] XlChartType ChartType, [MarshalAs(UnmanagedType.Struct), In, Optional] object TypeName);

  [DispId(86)]
  Walls Walls { [DispId(86), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(210)]
  bool WallsAndGridlines2D { [DispId(210), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(210), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(16 /*0x10*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object XYGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(1403)]
  XlBarShape BarShape { [DispId(1403), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1403), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(202)]
  XlRowCol PlotBy { [DispId(202), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(202), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1404)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CopyChartBuild();

  [DispId(1405)]
  bool ProtectFormatting { [DispId(1405), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1405), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1406)]
  bool ProtectData { [DispId(1406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1407)]
  bool ProtectGoalSeek { [DispId(1407), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), DispId(1407), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1408)]
  bool ProtectSelection { [DispId(1408), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1408), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1409)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void GetChartElement([In] int x, [In] int y, [In] ref int ElementID, [In] ref int Arg1, [In] ref int Arg2);

  [DispId(1413)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetSourceData([MarshalAs(UnmanagedType.Interface), In] Range Source, [MarshalAs(UnmanagedType.Struct), In, Optional] object PlotBy);

  [DispId(1414)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Export([MarshalAs(UnmanagedType.BStr), In] string Filename, [MarshalAs(UnmanagedType.Struct), In, Optional] object FilterName, [MarshalAs(UnmanagedType.Struct), In, Optional] object Interactive);

  [DispId(1417)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Refresh();

  [DispId(1814)]
  PivotLayout PivotLayout { [DispId(1814), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1815)]
  bool HasPivotFields { [DispId(1815), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1815), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1816)]
  Scripts Scripts { [TypeLibFunc(64 /*0x40*/), DispId(1816), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(8)]
  [DispId(1772)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrToFileName);

  [DispId(1041)]
  Tab Tab { [DispId(1041), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2021)]
  MsoEnvelope MailEnvelope { [DispId(2021), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1922)]
  [LCIDConversion(10)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyDataLabels(
    [In] XlDataLabelsType Type = XlDataLabelsType.xlDataLabelsShowValue,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object LegendKey,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object HasLeaderLines,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowSeriesName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowCategoryName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowValue,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowPercentage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowBubbleSize,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Separator);

  [DispId(1925)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SaveAs(
    [MarshalAs(UnmanagedType.BStr), In] string Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AddToMru,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextCodepage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Local);

  [DispId(2029)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Protect(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DrawingObjects,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Contents,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Scenarios,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UserInterfaceOnly);

  [DispId(2500)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyLayout([In] int Layout, [MarshalAs(UnmanagedType.Struct), In, Optional] object ChartType);

  [DispId(2502)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetElement([In] MsoChartElementType Element);

  [DispId(2504)]
  bool ShowDataLabelsOverMaximum { [DispId(2504), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2504), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2505)]
  Walls SideWall { [DispId(2505), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2506)]
  Walls BackWall { [DispId(2506), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2361)]
  [LCIDConversion(8)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOutEx(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrToFileName);

  [DispId(2507)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyChartTemplate([MarshalAs(UnmanagedType.BStr), In] string Filename);

  [DispId(2508)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SaveChartTemplate([MarshalAs(UnmanagedType.BStr), In] string Filename);

  [DispId(219)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetDefaultChart([MarshalAs(UnmanagedType.Struct), In] object Name);

  [DispId(2493)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ExportAsFixedFormat(
    [In] XlFixedFormatType Type,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Quality,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IncludeDocProperties,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnorePrintAreas,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OpenAfterPublish,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FixedFormatExtClassPtr);

  [DispId(2509)]
  object ChartStyle { [DispId(2509), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(2509), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(2510)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearToMatchStyle();
}
