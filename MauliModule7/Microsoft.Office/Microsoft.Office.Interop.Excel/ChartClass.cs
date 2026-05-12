// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.ChartClass
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[ComSourceInterfaces("Microsoft.Office.Interop.Excel.ChartEvents\0\0")]
[TypeLibType(2)]
[ClassInterface(0)]
[Guid("00020821-0000-0000-C000-000000000046")]
[ComImport]
public class ChartClass : _Chart, Chart, ChartEvents_Event
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern ChartClass();

  [DispId(148)]
  public virtual extern Application Application { [DispId(148), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  public virtual extern XlCreator Creator { [DispId(149), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  public virtual extern object Parent { [DispId(150), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(304)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Activate();

  [DispId(551)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Copy([MarshalAs(UnmanagedType.Struct), In, Optional] object Before, [MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [LCIDConversion(0)]
  [DispId(117)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Delete();

  [DispId(1373)]
  public virtual extern string CodeName { [DispId(1373), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(-2147418112 /*0x80010000*/)]
  public virtual extern string _CodeName { [TypeLibFunc(1024 /*0x0400*/), DispId(-2147418112 /*0x80010000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(-2147418112 /*0x80010000*/), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(486)]
  public virtual extern int Index { [LCIDConversion(0), DispId(486), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(637)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Move([MarshalAs(UnmanagedType.Struct), In, Optional] object Before, [MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [DispId(110)]
  public virtual extern string Name { [DispId(110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(502)]
  public virtual extern object Next { [DispId(502), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(628)]
  public virtual extern string OnDoubleClick { [LCIDConversion(0), DispId(628), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(64 /*0x40*/), DispId(628), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1031)]
  public virtual extern string OnSheetActivate { [DispId(1031), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1031), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1081)]
  public virtual extern string OnSheetDeactivate { [TypeLibFunc(64 /*0x40*/), DispId(1081), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(64 /*0x40*/), DispId(1081), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(998)]
  public virtual extern PageSetup PageSetup { [DispId(998), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(503)]
  public virtual extern object Previous { [DispId(503), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(905)]
  [LCIDConversion(7)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void _PrintOut(
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
  public virtual extern void PrintPreview([MarshalAs(UnmanagedType.Struct), In, Optional] object EnableChanges);

  [TypeLibFunc(1088)]
  [LCIDConversion(5)]
  [DispId(282)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void _Protect(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DrawingObjects,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Contents,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Scenarios,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UserInterfaceOnly);

  [DispId(292)]
  public virtual extern bool ProtectContents { [DispId(292), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(293)]
  public virtual extern bool ProtectDrawingObjects { [DispId(293), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1159)]
  public virtual extern bool ProtectionMode { [DispId(1159), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(65559)]
  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void _Dummy23();

  [TypeLibFunc(1088)]
  [DispId(284)]
  [LCIDConversion(9)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void _SaveAs(
    [MarshalAs(UnmanagedType.BStr), In] string Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AddToMru,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextCodepage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout);

  [LCIDConversion(1)]
  [DispId(235)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Select([MarshalAs(UnmanagedType.Struct), In, Optional] object Replace);

  [DispId(285)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Unprotect([MarshalAs(UnmanagedType.Struct), In, Optional] object Password);

  [DispId(558)]
  public virtual extern XlSheetVisibility Visible { [LCIDConversion(0), DispId(558), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(558), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1377)]
  public virtual extern Shapes Shapes { [DispId(1377), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(1088)]
  [DispId(151)]
  [LCIDConversion(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void _ApplyDataLabels(
    [In] XlDataLabelsType Type = XlDataLabelsType.xlDataLabelsShowValue,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object LegendKey,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object HasLeaderLines);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(760)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Arcs([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(17)]
  public virtual extern ChartGroup Area3DGroup { [DispId(17), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(1)]
  [DispId(9)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object AreaGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(114)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void AutoFormat([In] int Gallery, [MarshalAs(UnmanagedType.Struct), In, Optional] object Format);

  [DispId(107)]
  public virtual extern bool AutoScaling { [LCIDConversion(0), DispId(107), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(107), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(2)]
  [DispId(23)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Axes([MarshalAs(UnmanagedType.Struct), In, Optional] object Type, [In] XlAxisGroup AxisGroup = XlAxisGroup.xlPrimary);

  [DispId(1188)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetBackgroundPicture([MarshalAs(UnmanagedType.BStr), In] string Filename);

  [DispId(18)]
  public virtual extern ChartGroup Bar3DGroup { [LCIDConversion(0), DispId(18), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(10)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object BarGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(557)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Buttons([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(80 /*0x50*/)]
  public virtual extern ChartArea ChartArea { [LCIDConversion(0), DispId(80 /*0x50*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(1)]
  [DispId(8)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object ChartGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(1060)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object ChartObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(81)]
  public virtual extern ChartTitle ChartTitle { [LCIDConversion(0), DispId(81), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(11)]
  [DispId(196)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ChartWizard(
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
  public virtual extern object CheckBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(4)]
  [DispId(505)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CheckSpelling(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CustomDictionary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreUppercase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AlwaysSuggest,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SpellLang);

  [DispId(19)]
  public virtual extern ChartGroup Column3DGroup { [DispId(19), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(11)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object ColumnGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(213)]
  [LCIDConversion(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CopyPicture(
    [In] XlPictureAppearance Appearance = XlPictureAppearance.xlScreen,
    [In] XlCopyPictureFormat Format = XlCopyPictureFormat.xlPicture,
    [In] XlPictureAppearance Size = XlPictureAppearance.xlPrinter);

  [DispId(79)]
  public virtual extern Corners Corners { [LCIDConversion(0), DispId(79), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(7)]
  [DispId(458)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CreatePublisher(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Edition,
    [In] XlPictureAppearance Appearance = XlPictureAppearance.xlScreen,
    [In] XlPictureAppearance Size = XlPictureAppearance.xlScreen,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsPICT,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsBIFF,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsRTF,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsVALU);

  [DispId(1395)]
  public virtual extern DataTable DataTable { [DispId(1395), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(48 /*0x30*/)]
  public virtual extern int DepthPercent { [DispId(48 /*0x30*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(48 /*0x30*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1120)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Deselect();

  [DispId(93)]
  public virtual extern XlDisplayBlanksAs DisplayBlanksAs { [DispId(93), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(93), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(14)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object DoughnutGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(1)]
  [DispId(772)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Drawings([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(88)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object DrawingObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(1)]
  [DispId(836)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object DropDowns([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(49)]
  public virtual extern int Elevation { [LCIDConversion(0), DispId(49), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(49), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object Evaluate([MarshalAs(UnmanagedType.Struct), In] object Name);

  [TypeLibFunc(1024 /*0x0400*/)]
  [LCIDConversion(1)]
  [DispId(-5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object _Evaluate([MarshalAs(UnmanagedType.Struct), In] object Name);

  [DispId(83)]
  public virtual extern Floor Floor { [LCIDConversion(0), DispId(83), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(50)]
  public virtual extern int GapDepth { [LCIDConversion(0), DispId(50), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(50), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(834)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object GroupBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [DispId(1113)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object GroupObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(52)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object get_HasAxis([MarshalAs(UnmanagedType.Struct), In, Optional] object Index1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Index2);

  [DispId(52)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void set_HasAxis([MarshalAs(UnmanagedType.Struct), In, Optional] object Index1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Index2, [MarshalAs(UnmanagedType.Struct), In, Optional] object RHS);

  [DispId(1396)]
  public virtual extern bool HasDataTable { [DispId(1396), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1396), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(53)]
  public virtual extern bool HasLegend { [LCIDConversion(0), DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(53), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(54)]
  public virtual extern bool HasTitle { [LCIDConversion(0), DispId(54), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(54), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(55)]
  public virtual extern int HeightPercent { [DispId(55), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(55), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1393)]
  public virtual extern Hyperlinks Hyperlinks { [DispId(1393), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [DispId(841)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Labels([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(84)]
  public virtual extern Legend Legend { [LCIDConversion(0), DispId(84), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(20)]
  public virtual extern ChartGroup Line3DGroup { [DispId(20), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [DispId(12)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object LineGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(767 /*0x02FF*/)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Lines([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(832)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object ListBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(1397)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Chart Location([In] XlChartLocation Where, [MarshalAs(UnmanagedType.Struct), In, Optional] object Name);

  [DispId(799)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object OLEObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [DispId(826)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object OptionButtons([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(801)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Ovals([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(211)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Paste([MarshalAs(UnmanagedType.Struct), In, Optional] object Type);

  [DispId(57)]
  public virtual extern int Perspective { [LCIDConversion(0), DispId(57), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(57), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(771)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Pictures([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(21)]
  public virtual extern ChartGroup Pie3DGroup { [LCIDConversion(0), DispId(21), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(1)]
  [DispId(13)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object PieGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(85)]
  public virtual extern PlotArea PlotArea { [DispId(85), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(92)]
  public virtual extern bool PlotVisibleOnly { [LCIDConversion(0), DispId(92), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(92), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(1)]
  [DispId(15)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object RadarGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(774)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Rectangles([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(58)]
  public virtual extern object RightAngleAxes { [LCIDConversion(0), DispId(58), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(58), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(59)]
  public virtual extern object Rotation { [DispId(59), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [LCIDConversion(0), DispId(59), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [LCIDConversion(1)]
  [DispId(830)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object ScrollBars([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(1)]
  [DispId(68)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object SeriesCollection([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(94)]
  public virtual extern bool SizeWithWindow { [LCIDConversion(0), DispId(94), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), DispId(94), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1399)]
  public virtual extern bool ShowWindow { [TypeLibFunc(64 /*0x40*/), DispId(1399), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1399), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(838)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Spinners([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(109)]
  public virtual extern int SubType { [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), DispId(109), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), DispId(109), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(22)]
  public virtual extern ChartGroup SurfaceGroup { [DispId(22), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(777)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object TextBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(108)]
  public virtual extern int Type { [TypeLibFunc(64 /*0x40*/), DispId(108), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(108), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1400)]
  public virtual extern XlChartType ChartType { [DispId(1400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1401)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplyCustomType([In] XlChartType ChartType, [MarshalAs(UnmanagedType.Struct), In, Optional] object TypeName);

  [DispId(86)]
  public virtual extern Walls Walls { [DispId(86), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(210)]
  public virtual extern bool WallsAndGridlines2D { [DispId(210), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), DispId(210), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(16 /*0x10*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object XYGroups([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(1403)]
  public virtual extern XlBarShape BarShape { [DispId(1403), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1403), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(202)]
  public virtual extern XlRowCol PlotBy { [DispId(202), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(202), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1404)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CopyChartBuild();

  [DispId(1405)]
  public virtual extern bool ProtectFormatting { [DispId(1405), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1405), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1406)]
  public virtual extern bool ProtectData { [DispId(1406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1407)]
  public virtual extern bool ProtectGoalSeek { [TypeLibFunc(64 /*0x40*/), DispId(1407), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), DispId(1407), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1408)]
  public virtual extern bool ProtectSelection { [DispId(1408), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1408), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1409)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void GetChartElement(
    [In] int x,
    [In] int y,
    [In] ref int ElementID,
    [In] ref int Arg1,
    [In] ref int Arg2);

  [DispId(1413)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetSourceData([MarshalAs(UnmanagedType.Interface), In] Range Source, [MarshalAs(UnmanagedType.Struct), In, Optional] object PlotBy);

  [DispId(1414)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool Export([MarshalAs(UnmanagedType.BStr), In] string Filename, [MarshalAs(UnmanagedType.Struct), In, Optional] object FilterName, [MarshalAs(UnmanagedType.Struct), In, Optional] object Interactive);

  [DispId(1417)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Refresh();

  [DispId(1814)]
  public virtual extern PivotLayout PivotLayout { [DispId(1814), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1815)]
  public virtual extern bool HasPivotFields { [TypeLibFunc(64 /*0x40*/), DispId(1815), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1815), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1816)]
  public virtual extern Scripts Scripts { [TypeLibFunc(64 /*0x40*/), DispId(1816), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(8)]
  [TypeLibFunc(1088)]
  [DispId(1772)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrToFileName);

  [DispId(1041)]
  public virtual extern Tab Tab { [DispId(1041), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2021)]
  public virtual extern MsoEnvelope MailEnvelope { [DispId(2021), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(10)]
  [DispId(1922)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplyDataLabels(
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
  public virtual extern void SaveAs(
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
  public virtual extern void Protect(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DrawingObjects,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Contents,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Scenarios,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UserInterfaceOnly);

  [DispId(2500)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplyLayout([In] int Layout, [MarshalAs(UnmanagedType.Struct), In, Optional] object ChartType);

  [DispId(2502)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetElement([In] MsoChartElementType Element);

  [DispId(2504)]
  public virtual extern bool ShowDataLabelsOverMaximum { [DispId(2504), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2504), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2505)]
  public virtual extern Walls SideWall { [DispId(2505), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2506)]
  public virtual extern Walls BackWall { [DispId(2506), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2361)]
  [LCIDConversion(8)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PrintOutEx(
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
  public virtual extern void ApplyChartTemplate([MarshalAs(UnmanagedType.BStr), In] string Filename);

  [DispId(2508)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SaveChartTemplate([MarshalAs(UnmanagedType.BStr), In] string Filename);

  [DispId(219)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetDefaultChart([MarshalAs(UnmanagedType.Struct), In] object Name);

  [DispId(2493)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ExportAsFixedFormat(
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
  public virtual extern object ChartStyle { [DispId(2509), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(2509), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(2510)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ClearToMatchStyle();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Activate([In] ChartEvents_ActivateEventHandler obj0);

  public virtual extern event ChartEvents_ActivateEventHandler ChartEvents_Event_Activate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Activate([In] ChartEvents_ActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Deactivate([In] ChartEvents_DeactivateEventHandler obj0);

  public virtual extern event ChartEvents_DeactivateEventHandler Deactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Deactivate([In] ChartEvents_DeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Resize([In] ChartEvents_ResizeEventHandler obj0);

  public virtual extern event ChartEvents_ResizeEventHandler Resize;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Resize([In] ChartEvents_ResizeEventHandler obj0);

  public virtual extern event ChartEvents_MouseDownEventHandler MouseDown;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_MouseDown([In] ChartEvents_MouseDownEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_MouseDown([In] ChartEvents_MouseDownEventHandler obj0);

  public virtual extern event ChartEvents_MouseUpEventHandler MouseUp;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_MouseUp([In] ChartEvents_MouseUpEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_MouseUp([In] ChartEvents_MouseUpEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_MouseMove([In] ChartEvents_MouseMoveEventHandler obj0);

  public virtual extern event ChartEvents_MouseMoveEventHandler MouseMove;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_MouseMove([In] ChartEvents_MouseMoveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_BeforeRightClick([In] ChartEvents_BeforeRightClickEventHandler obj0);

  public virtual extern event ChartEvents_BeforeRightClickEventHandler BeforeRightClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_BeforeRightClick([In] ChartEvents_BeforeRightClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_DragPlot([In] ChartEvents_DragPlotEventHandler obj0);

  public virtual extern event ChartEvents_DragPlotEventHandler DragPlot;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_DragPlot([In] ChartEvents_DragPlotEventHandler obj0);

  public virtual extern event ChartEvents_DragOverEventHandler DragOver;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_DragOver([In] ChartEvents_DragOverEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_DragOver([In] ChartEvents_DragOverEventHandler obj0);

  public virtual extern event ChartEvents_BeforeDoubleClickEventHandler BeforeDoubleClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_BeforeDoubleClick([In] ChartEvents_BeforeDoubleClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_BeforeDoubleClick([In] ChartEvents_BeforeDoubleClickEventHandler obj0);

  public virtual extern event ChartEvents_SelectEventHandler ChartEvents_Event_Select;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Select([In] ChartEvents_SelectEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Select([In] ChartEvents_SelectEventHandler obj0);

  public virtual extern event ChartEvents_SeriesChangeEventHandler SeriesChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_SeriesChange([In] ChartEvents_SeriesChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_SeriesChange([In] ChartEvents_SeriesChangeEventHandler obj0);

  public virtual extern event ChartEvents_CalculateEventHandler Calculate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Calculate([In] ChartEvents_CalculateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Calculate([In] ChartEvents_CalculateEventHandler obj0);
}
