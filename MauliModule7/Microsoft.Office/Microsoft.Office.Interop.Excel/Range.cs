// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.Range
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[Guid("00020846-0000-0000-C000-000000000046")]
[TypeLibType(4096 /*0x1000*/)]
[InterfaceType(2)]
[ComImport]
public interface Range
{
  [DispId(148)]
  Application Application { [DispId(148), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [DispId(149), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [DispId(150), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(304)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Activate();

  [DispId(1063)]
  object AddIndent { [DispId(1063), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(1063), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(236)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string get_Address(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object RowAbsolute,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnAbsolute,
    [In] XlReferenceStyle ReferenceStyle = XlReferenceStyle.xlA1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object External,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object RelativeTo);

  [DispId(437)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string get_AddressLocal(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object RowAbsolute,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnAbsolute,
    [In] XlReferenceStyle ReferenceStyle = XlReferenceStyle.xlA1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object External,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object RelativeTo);

  [DispId(876)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AdvancedFilter(
    [In] XlFilterAction Action,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CriteriaRange,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CopyToRange,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Unique);

  [DispId(441)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ApplyNames(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Names,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreRelativeAbsolute,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UseRowColumnNames,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OmitColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OmitRow,
    [In] XlApplyNamesOrder Order = XlApplyNamesOrder.xlRowThenColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AppendLast);

  [DispId(448)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ApplyOutlineStyles();

  [DispId(568)]
  Areas Areas { [DispId(568), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1185)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string AutoComplete([MarshalAs(UnmanagedType.BStr), In] string String);

  [DispId(449)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoFill([MarshalAs(UnmanagedType.Interface), In] Range Destination, [In] XlAutoFillType Type = XlAutoFillType.xlFillDefault);

  [DispId(793)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoFilter(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Field,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Criteria1,
    [In] XlAutoFilterOperator Operator = XlAutoFilterOperator.xlAnd,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Criteria2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object VisibleDropDown);

  [DispId(237)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoFit();

  [DispId(114)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoFormat(
    [In] XlRangeAutoFormat Format = XlRangeAutoFormat.xlRangeAutoFormatClassic1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Number,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Font,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Alignment,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Border,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Pattern,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Width);

  [DispId(1036)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoOutline();

  [DispId(1067)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object BorderAround(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object LineStyle,
    [In] XlBorderWeight Weight = XlBorderWeight.xlThin,
    [In] XlColorIndex ColorIndex = XlColorIndex.xlColorIndexAutomatic,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Color);

  [DispId(435)]
  Borders Borders { [DispId(435), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(279)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Calculate();

  [DispId(238)]
  Range Cells { [DispId(238), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(603)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Characters get_Characters([MarshalAs(UnmanagedType.Struct), In, Optional] object Start, [MarshalAs(UnmanagedType.Struct), In, Optional] object Length);

  [DispId(505)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CheckSpelling(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CustomDictionary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreUppercase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AlwaysSuggest,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SpellLang);

  [DispId(111)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Clear();

  [DispId(113)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearContents();

  [DispId(112 /*0x70*/)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearFormats();

  [DispId(239)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearNotes();

  [DispId(1037)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearOutline();

  [DispId(240 /*0xF0*/)]
  int Column { [DispId(240 /*0xF0*/), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(510)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range ColumnDifferences([MarshalAs(UnmanagedType.Struct), In] object Comparison);

  [DispId(241)]
  Range Columns { [TypeLibFunc(1024 /*0x0400*/), DispId(241), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(242)]
  object ColumnWidth { [DispId(242), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(242), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(482)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Consolidate(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Sources,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Function,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TopRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object LeftColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateLinks);

  [DispId(551)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Copy([MarshalAs(UnmanagedType.Struct), In, Optional] object Destination);

  [DispId(1152)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int CopyFromRecordset([MarshalAs(UnmanagedType.IUnknown), In] object Data, [MarshalAs(UnmanagedType.Struct), In, Optional] object MaxRows, [MarshalAs(UnmanagedType.Struct), In, Optional] object MaxColumns);

  [DispId(213)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CopyPicture([In] XlPictureAppearance Appearance = XlPictureAppearance.xlScreen, [In] XlCopyPictureFormat Format = XlCopyPictureFormat.xlPicture);

  [DispId(118)]
  int Count { [DispId(118), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(457)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CreateNames([MarshalAs(UnmanagedType.Struct), In, Optional] object Top, [MarshalAs(UnmanagedType.Struct), In, Optional] object Left, [MarshalAs(UnmanagedType.Struct), In, Optional] object Bottom, [MarshalAs(UnmanagedType.Struct), In, Optional] object Right);

  [DispId(458)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CreatePublisher(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Edition,
    [In] XlPictureAppearance Appearance = XlPictureAppearance.xlScreen,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsPICT,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsBIFF,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsRTF,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsVALU);

  [DispId(501)]
  Range CurrentArray { [DispId(501), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(243)]
  Range CurrentRegion { [DispId(243), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(565)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Cut([MarshalAs(UnmanagedType.Struct), In, Optional] object Destination);

  [DispId(464)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object DataSeries(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Rowcol,
    [In] XlDataSeriesType Type = XlDataSeriesType.xlDataSeriesLinear,
    [In] XlDataSeriesDate Date = XlDataSeriesDate.xlDay,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Step,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Stop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Trend);

  [DispId(0)]
  [IndexerName("_Default")]
  object this[[MarshalAs(UnmanagedType.Struct), In, Optional] object RowIndex, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnIndex] { [DispId(0), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(0), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In, Optional] set; }

  [DispId(117)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Delete([MarshalAs(UnmanagedType.Struct), In, Optional] object Shift);

  [DispId(543)]
  Range Dependents { [DispId(543), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(245)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object DialogBox();

  [DispId(545)]
  Range DirectDependents { [DispId(545), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(546)]
  Range DirectPrecedents { [DispId(546), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1131)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object EditionOptions(
    [In] XlEditionType Type,
    [In] XlEditionOptionsOption Option,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Reference,
    [In] XlPictureAppearance Appearance = XlPictureAppearance.xlScreen,
    [In] XlPictureAppearance ChartSize = XlPictureAppearance.xlScreen,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Format);

  [DispId(500)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range get_End([In] XlDirection Direction);

  [DispId(246)]
  Range EntireColumn { [DispId(246), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(247)]
  Range EntireRow { [TypeLibFunc(1024 /*0x0400*/), DispId(247), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(248)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FillDown();

  [DispId(249)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FillLeft();

  [DispId(250)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FillRight();

  [DispId(251)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FillUp();

  [DispId(398)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range Find(
    [MarshalAs(UnmanagedType.Struct), In] object What,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object After,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object LookIn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object LookAt,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SearchOrder,
    [In] XlSearchDirection SearchDirection = XlSearchDirection.xlNext,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MatchCase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MatchByte,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SearchFormat);

  [DispId(399)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range FindNext([MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [DispId(400)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range FindPrevious([MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [DispId(146)]
  Font Font { [DispId(146), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(261)]
  object Formula { [DispId(261), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(261), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(586)]
  object FormulaArray { [DispId(586), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(586), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(1380)]
  XlFormulaLabel FormulaLabel { [TypeLibFunc(64 /*0x40*/), DispId(1380), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1380), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(262)]
  object FormulaHidden { [DispId(262), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(262), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(263)]
  object FormulaLocal { [DispId(263), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(263), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(264)]
  object FormulaR1C1 { [DispId(264), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(264), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(265)]
  object FormulaR1C1Local { [DispId(265), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(265), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(571)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FunctionWizard();

  [DispId(472)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool GoalSeek([MarshalAs(UnmanagedType.Struct), In] object Goal, [MarshalAs(UnmanagedType.Interface), In] Range ChangingCell);

  [DispId(46)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Group([MarshalAs(UnmanagedType.Struct), In, Optional] object Start, [MarshalAs(UnmanagedType.Struct), In, Optional] object End, [MarshalAs(UnmanagedType.Struct), In, Optional] object By, [MarshalAs(UnmanagedType.Struct), In, Optional] object Periods);

  [DispId(266)]
  object HasArray { [DispId(266), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(267)]
  object HasFormula { [DispId(267), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(123)]
  object Height { [DispId(123), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(268)]
  object Hidden { [DispId(268), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(268), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(136)]
  object HorizontalAlignment { [DispId(136), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(136), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(201)]
  object IndentLevel { [DispId(201), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(201), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(1381)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertIndent([In] int InsertAmount);

  [DispId(252)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Insert([MarshalAs(UnmanagedType.Struct), In, Optional] object Shift, [MarshalAs(UnmanagedType.Struct), In, Optional] object CopyOrigin);

  [DispId(129)]
  Interior Interior { [DispId(129), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(170)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object get_Item([MarshalAs(UnmanagedType.Struct), In] object RowIndex, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnIndex);

  [DispId(170)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void set_Item([MarshalAs(UnmanagedType.Struct), In] object RowIndex, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnIndex, [MarshalAs(UnmanagedType.Struct), In, Optional] object _param3);

  [DispId(495)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Justify();

  [DispId(127 /*0x7F*/)]
  object Left { [DispId(127 /*0x7F*/), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1187)]
  int ListHeaderRows { [DispId(1187), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(253)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ListNames();

  [DispId(691)]
  XlLocationInTable LocationInTable { [DispId(691), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(269)]
  object Locked { [DispId(269), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(269), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(564)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Merge([MarshalAs(UnmanagedType.Struct), In, Optional] object Across);

  [DispId(1384)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void UnMerge();

  [DispId(1385)]
  Range MergeArea { [DispId(1385), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(208 /*0xD0*/)]
  object MergeCells { [DispId(208 /*0xD0*/), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(208 /*0xD0*/), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(110)]
  object Name { [DispId(110), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(110), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(1032)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object NavigateArrow([MarshalAs(UnmanagedType.Struct), In, Optional] object TowardPrecedent, [MarshalAs(UnmanagedType.Struct), In, Optional] object ArrowNumber, [MarshalAs(UnmanagedType.Struct), In, Optional] object LinkNumber);

  [DispId(-4)]
  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  IEnumerator GetEnumerator();

  [DispId(502)]
  Range Next { [DispId(502), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1127)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string NoteText([MarshalAs(UnmanagedType.Struct), In, Optional] object Text, [MarshalAs(UnmanagedType.Struct), In, Optional] object Start, [MarshalAs(UnmanagedType.Struct), In, Optional] object Length);

  [DispId(193)]
  object NumberFormat { [DispId(193), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(193), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(1097)]
  object NumberFormatLocal { [DispId(1097), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(1097), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(254)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range get_Offset([MarshalAs(UnmanagedType.Struct), In, Optional] object RowOffset, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnOffset);

  [DispId(134)]
  object Orientation { [DispId(134), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(134), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(271)]
  object OutlineLevel { [DispId(271), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(271), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(255 /*0xFF*/)]
  int PageBreak { [DispId(255 /*0xFF*/), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(255 /*0xFF*/), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(477)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Parse([MarshalAs(UnmanagedType.Struct), In, Optional] object ParseLine, [MarshalAs(UnmanagedType.Struct), In, Optional] object Destination);

  [TypeLibFunc(1088)]
  [DispId(1027)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _PasteSpecial(
    [In] XlPasteType Paste = XlPasteType.xlPasteAll,
    [In] XlPasteSpecialOperation Operation = XlPasteSpecialOperation.xlPasteSpecialOperationNone,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SkipBlanks,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Transpose);

  [DispId(731)]
  PivotField PivotField { [DispId(731), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(740)]
  PivotItem PivotItem { [DispId(740), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(716)]
  PivotTable PivotTable { [DispId(716), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(544)]
  Range Precedents { [DispId(544), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(504)]
  object PrefixCharacter { [DispId(504), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(503)]
  Range Previous { [DispId(503), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(905)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate);

  [DispId(281)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object PrintPreview([MarshalAs(UnmanagedType.Struct), In, Optional] object EnableChanges);

  [DispId(1386)]
  QueryTable QueryTable { [DispId(1386), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(197)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range get_Range([MarshalAs(UnmanagedType.Struct), In] object Cell1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Cell2);

  [DispId(883)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object RemoveSubtotal();

  [DispId(226)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Replace(
    [MarshalAs(UnmanagedType.Struct), In] object What,
    [MarshalAs(UnmanagedType.Struct), In] object Replacement,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object LookAt,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SearchOrder,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MatchCase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MatchByte,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SearchFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReplaceFormat);

  [DispId(256 /*0x0100*/)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range get_Resize([MarshalAs(UnmanagedType.Struct), In, Optional] object RowSize, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnSize);

  [DispId(257)]
  int Row { [DispId(257), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(511 /*0x01FF*/)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range RowDifferences([MarshalAs(UnmanagedType.Struct), In] object Comparison);

  [DispId(272)]
  object RowHeight { [DispId(272), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(272), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(258)]
  Range Rows { [TypeLibFunc(1024 /*0x0400*/), DispId(258), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(259)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Run(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [DispId(235)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Select();

  [DispId(496)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Show();

  [DispId(877)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ShowDependents([MarshalAs(UnmanagedType.Struct), In, Optional] object Remove);

  [DispId(585)]
  object ShowDetail { [DispId(585), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(585), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(878)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ShowErrors();

  [DispId(879)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ShowPrecedents([MarshalAs(UnmanagedType.Struct), In, Optional] object Remove);

  [DispId(209)]
  object ShrinkToFit { [DispId(209), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(209), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(880)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Sort(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Key1,
    [In] XlSortOrder Order1 = XlSortOrder.xlAscending,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Key2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Type,
    [In] XlSortOrder Order2 = XlSortOrder.xlAscending,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Key3,
    [In] XlSortOrder Order3 = XlSortOrder.xlAscending,
    [In] XlYesNoGuess Header = XlYesNoGuess.xlNo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OrderCustom,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MatchCase,
    [In] XlSortOrientation Orientation = XlSortOrientation.xlSortRows,
    [In] XlSortMethod SortMethod = XlSortMethod.xlPinYin,
    [In] XlSortDataOption DataOption1 = XlSortDataOption.xlSortNormal,
    [In] XlSortDataOption DataOption2 = XlSortDataOption.xlSortNormal,
    [In] XlSortDataOption DataOption3 = XlSortDataOption.xlSortNormal);

  [DispId(881)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object SortSpecial(
    [In] XlSortMethod SortMethod = XlSortMethod.xlPinYin,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Key1,
    [In] XlSortOrder Order1 = XlSortOrder.xlAscending,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Type,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Key2,
    [In] XlSortOrder Order2 = XlSortOrder.xlAscending,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Key3,
    [In] XlSortOrder Order3 = XlSortOrder.xlAscending,
    [In] XlYesNoGuess Header = XlYesNoGuess.xlNo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OrderCustom,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MatchCase,
    [In] XlSortOrientation Orientation = XlSortOrientation.xlSortRows,
    [In] XlSortDataOption DataOption1 = XlSortDataOption.xlSortNormal,
    [In] XlSortDataOption DataOption2 = XlSortDataOption.xlSortNormal,
    [In] XlSortDataOption DataOption3 = XlSortDataOption.xlSortNormal);

  [DispId(916)]
  SoundNote SoundNote { [DispId(916), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(410)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range SpecialCells([In] XlCellType Type, [MarshalAs(UnmanagedType.Struct), In, Optional] object Value);

  [DispId(260)]
  object Style { [DispId(260), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(260), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(481)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object SubscribeTo([MarshalAs(UnmanagedType.BStr), In] string Edition, [In] XlSubscribeToFormat Format = XlSubscribeToFormat.xlSubscribeToText);

  [DispId(882)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Subtotal(
    [In] int GroupBy,
    [In] XlConsolidationFunction Function,
    [MarshalAs(UnmanagedType.Struct), In] object TotalList,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Replace,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PageBreaks,
    [In] XlSummaryRow SummaryBelowData = XlSummaryRow.xlSummaryBelow);

  [DispId(273)]
  object Summary { [DispId(273), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(497)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Table([MarshalAs(UnmanagedType.Struct), In, Optional] object RowInput, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnInput);

  [DispId(138)]
  object Text { [DispId(138), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1040)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object TextToColumns(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Destination,
    [In] XlTextParsingType DataType = XlTextParsingType.xlDelimited,
    [In] XlTextQualifier TextQualifier = XlTextQualifier.xlTextQualifierDoubleQuote,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ConsecutiveDelimiter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Tab,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Semicolon,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Comma,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Space,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Other,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OtherChar,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FieldInfo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DecimalSeparator,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ThousandsSeparator,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TrailingMinusNumbers);

  [DispId(126)]
  object Top { [DispId(126), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(244)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Ungroup();

  [DispId(274)]
  object UseStandardHeight { [DispId(274), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(274), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(275)]
  object UseStandardWidth { [DispId(275), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(275), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(1387)]
  Validation Validation { [DispId(1387), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(6)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object get_Value([MarshalAs(UnmanagedType.Struct), In, Optional] object RangeValueDataType);

  [DispId(6)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void set_Value([MarshalAs(UnmanagedType.Struct), In, Optional] object RangeValueDataType, [MarshalAs(UnmanagedType.Struct), In, Optional] object _param2);

  [DispId(1388)]
  object Value2 { [DispId(1388), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(1388), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(137)]
  object VerticalAlignment { [DispId(137), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(137), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(122)]
  object Width { [DispId(122), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(348)]
  Worksheet Worksheet { [DispId(348), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(276)]
  object WrapText { [DispId(276), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(276), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(1389)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Comment AddComment([MarshalAs(UnmanagedType.Struct), In, Optional] object Text);

  [DispId(910)]
  Comment Comment { [DispId(910), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1390)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearComments();

  [DispId(1391)]
  Phonetic Phonetic { [DispId(1391), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1392)]
  FormatConditions FormatConditions { [DispId(1392), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(975)]
  int ReadingOrder { [DispId(975), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(975), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1393)]
  Hyperlinks Hyperlinks { [DispId(1393), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1811)]
  Phonetics Phonetics { [DispId(1811), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1812)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetPhonetic();

  [DispId(1813)]
  string ID { [DispId(1813), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1813), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1772)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrToFileName);

  [DispId(2013)]
  PivotCell PivotCell { [DispId(2013), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2014)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Dirty();

  [DispId(2015)]
  Errors Errors { [DispId(2015), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2016)]
  SmartTags SmartTags { [DispId(2016), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2017)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Speak([MarshalAs(UnmanagedType.Struct), In, Optional] object SpeakDirection, [MarshalAs(UnmanagedType.Struct), In, Optional] object SpeakFormulas);

  [DispId(1928)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object PasteSpecial(
    [In] XlPasteType Paste = XlPasteType.xlPasteAll,
    [In] XlPasteSpecialOperation Operation = XlPasteSpecialOperation.xlPasteSpecialOperationNone,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SkipBlanks,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Transpose);

  [DispId(2020)]
  bool AllowEdit { [DispId(2020), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2257)]
  ListObject ListObject { [DispId(2257), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2258)]
  XPath XPath { [DispId(2258), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2491)]
  Actions ServerActions { [DispId(2491), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2492)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveDuplicates([MarshalAs(UnmanagedType.Struct), In, Optional] object Columns, [In] XlYesNoGuess Header = XlYesNoGuess.xlNo);

  [DispId(2361)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object PrintOutEx(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrToFileName);

  [DispId(2123)]
  string MDX { [DispId(2123), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(2493)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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

  [DispId(2499)]
  object CountLarge { [DispId(2499), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(2364)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CalculateRowMajorOrder();
}
