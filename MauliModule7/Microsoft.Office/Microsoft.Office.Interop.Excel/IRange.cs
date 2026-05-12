// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IRange
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[Guid("00020846-0001-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface IRange : IEnumerable
{
  [DispId(148)]
  Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Activate();

  [DispId(1063)]
  object AddIndent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [LCIDConversion(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string get_Address(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object RowAbsolute,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnAbsolute,
    [In] XlReferenceStyle ReferenceStyle = XlReferenceStyle.xlA1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object External,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object RelativeTo);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string get_AddressLocal(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object RowAbsolute,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnAbsolute,
    [In] XlReferenceStyle ReferenceStyle = XlReferenceStyle.xlA1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object External,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object RelativeTo);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AdvancedFilter(
    [In] XlFilterAction Action,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CriteriaRange,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CopyToRange,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Unique);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ApplyNames(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Names,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreRelativeAbsolute,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UseRowColumnNames,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OmitColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OmitRow,
    [In] XlApplyNamesOrder Order = XlApplyNamesOrder.xlRowThenColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AppendLast);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ApplyOutlineStyles();

  [DispId(568)]
  Areas Areas { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string AutoComplete([MarshalAs(UnmanagedType.BStr), In] string String);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoFill([MarshalAs(UnmanagedType.Interface), In] Range Destination, [In] XlAutoFillType Type = XlAutoFillType.xlFillDefault);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoFilter(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Field,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Criteria1,
    [In] XlAutoFilterOperator Operator = XlAutoFilterOperator.xlAnd,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Criteria2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object VisibleDropDown);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoFit();

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoFormat(
    [In] XlRangeAutoFormat Format = XlRangeAutoFormat.xlRangeAutoFormatClassic1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Number,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Font,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Alignment,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Border,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Pattern,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Width);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object AutoOutline();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object BorderAround(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object LineStyle,
    [In] XlBorderWeight Weight = XlBorderWeight.xlThin,
    [In] XlColorIndex ColorIndex = XlColorIndex.xlColorIndexAutomatic,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Color);

  [DispId(435)]
  Borders Borders { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Calculate();

  [DispId(238)]
  Range Cells { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Characters get_Characters([MarshalAs(UnmanagedType.Struct), In, Optional] object Start, [MarshalAs(UnmanagedType.Struct), In, Optional] object Length);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CheckSpelling(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CustomDictionary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreUppercase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AlwaysSuggest,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SpellLang);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Clear();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearContents();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearFormats();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearNotes();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ClearOutline();

  [DispId(240 /*0xF0*/)]
  int Column { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range ColumnDifferences([MarshalAs(UnmanagedType.Struct), In] object Comparison);

  [DispId(241)]
  Range Columns { [TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(242)]
  object ColumnWidth { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Consolidate(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Sources,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Function,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TopRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object LeftColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateLinks);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Copy([MarshalAs(UnmanagedType.Struct), In, Optional] object Destination);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int CopyFromRecordset([MarshalAs(UnmanagedType.IUnknown), In] object Data, [MarshalAs(UnmanagedType.Struct), In, Optional] object MaxRows, [MarshalAs(UnmanagedType.Struct), In, Optional] object MaxColumns);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CopyPicture([In] XlPictureAppearance Appearance = XlPictureAppearance.xlScreen, [In] XlCopyPictureFormat Format = XlCopyPictureFormat.xlPicture);

  [DispId(118)]
  int Count { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CreateNames([MarshalAs(UnmanagedType.Struct), In, Optional] object Top, [MarshalAs(UnmanagedType.Struct), In, Optional] object Left, [MarshalAs(UnmanagedType.Struct), In, Optional] object Bottom, [MarshalAs(UnmanagedType.Struct), In, Optional] object Right);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CreatePublisher(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Edition,
    [In] XlPictureAppearance Appearance = XlPictureAppearance.xlScreen,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsPICT,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsBIFF,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsRTF,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ContainsVALU);

  [DispId(501)]
  Range CurrentArray { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(243)]
  Range CurrentRegion { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Cut([MarshalAs(UnmanagedType.Struct), In, Optional] object Destination);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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
  object this[[MarshalAs(UnmanagedType.Struct), In, Optional] object RowIndex, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnIndex] { [TypeLibFunc(1024 /*0x0400*/), LCIDConversion(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [TypeLibFunc(1024 /*0x0400*/), LCIDConversion(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In, Optional] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Delete([MarshalAs(UnmanagedType.Struct), In, Optional] object Shift);

  [DispId(543)]
  Range Dependents { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object DialogBox();

  [DispId(545)]
  Range DirectDependents { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(546)]
  Range DirectPrecedents { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object EditionOptions(
    [In] XlEditionType Type,
    [In] XlEditionOptionsOption Option,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Reference,
    [In] XlPictureAppearance Appearance = XlPictureAppearance.xlScreen,
    [In] XlPictureAppearance ChartSize = XlPictureAppearance.xlScreen,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Format);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range get_End([In] XlDirection Direction);

  [DispId(246)]
  Range EntireColumn { [TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(247)]
  Range EntireRow { [TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FillDown();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FillLeft();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FillRight();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FillUp();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range FindNext([MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range FindPrevious([MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [DispId(146)]
  Font Font { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(261)]
  object Formula { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(586)]
  object FormulaArray { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(1380)]
  XlFormulaLabel FormulaLabel { [TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(262)]
  object FormulaHidden { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(263)]
  object FormulaLocal { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(264)]
  object FormulaR1C1 { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(265)]
  object FormulaR1C1Local { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object FunctionWizard();

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool GoalSeek([MarshalAs(UnmanagedType.Struct), In] object Goal, [MarshalAs(UnmanagedType.Interface), In] Range ChangingCell);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Group([MarshalAs(UnmanagedType.Struct), In, Optional] object Start, [MarshalAs(UnmanagedType.Struct), In, Optional] object End, [MarshalAs(UnmanagedType.Struct), In, Optional] object By, [MarshalAs(UnmanagedType.Struct), In, Optional] object Periods);

  [DispId(266)]
  object HasArray { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(267)]
  object HasFormula { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(123)]
  object Height { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(268)]
  object Hidden { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(136)]
  object HorizontalAlignment { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(201)]
  object IndentLevel { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertIndent([In] int InsertAmount);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Insert([MarshalAs(UnmanagedType.Struct), In, Optional] object Shift, [MarshalAs(UnmanagedType.Struct), In, Optional] object CopyOrigin);

  [DispId(129)]
  Interior Interior { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object get_Item([MarshalAs(UnmanagedType.Struct), In] object RowIndex, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnIndex);

  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void set_Item([MarshalAs(UnmanagedType.Struct), In] object RowIndex, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnIndex, [MarshalAs(UnmanagedType.Struct), In, Optional] object RHS);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Justify();

  [DispId(127 /*0x7F*/)]
  object Left { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1187)]
  int ListHeaderRows { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ListNames();

  [DispId(691)]
  XlLocationInTable LocationInTable { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(269)]
  object Locked { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Merge([MarshalAs(UnmanagedType.Struct), In, Optional] object Across);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void UnMerge();

  [DispId(1385)]
  Range MergeArea { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(208 /*0xD0*/)]
  object MergeCells { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(110)]
  object Name { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object NavigateArrow([MarshalAs(UnmanagedType.Struct), In, Optional] object TowardPrecedent, [MarshalAs(UnmanagedType.Struct), In, Optional] object ArrowNumber, [MarshalAs(UnmanagedType.Struct), In, Optional] object LinkNumber);

  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(502)]
  Range Next { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string NoteText([MarshalAs(UnmanagedType.Struct), In, Optional] object Text, [MarshalAs(UnmanagedType.Struct), In, Optional] object Start, [MarshalAs(UnmanagedType.Struct), In, Optional] object Length);

  [DispId(193)]
  object NumberFormat { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(1097)]
  object NumberFormatLocal { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range get_Offset([MarshalAs(UnmanagedType.Struct), In, Optional] object RowOffset, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnOffset);

  [DispId(134)]
  object Orientation { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(271)]
  object OutlineLevel { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(255 /*0xFF*/)]
  int PageBreak { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Parse([MarshalAs(UnmanagedType.Struct), In, Optional] object ParseLine, [MarshalAs(UnmanagedType.Struct), In, Optional] object Destination);

  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _PasteSpecial(
    [In] XlPasteType Paste = XlPasteType.xlPasteAll,
    [In] XlPasteSpecialOperation Operation = XlPasteSpecialOperation.xlPasteSpecialOperationNone,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SkipBlanks,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Transpose);

  [DispId(731)]
  PivotField PivotField { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(740)]
  PivotItem PivotItem { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(716)]
  PivotTable PivotTable { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(544)]
  Range Precedents { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(504)]
  object PrefixCharacter { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(503)]
  Range Previous { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object PrintPreview([MarshalAs(UnmanagedType.Struct), In, Optional] object EnableChanges);

  [DispId(1386)]
  QueryTable QueryTable { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range get_Range([MarshalAs(UnmanagedType.Struct), In] object Cell1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Cell2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object RemoveSubtotal();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Replace(
    [MarshalAs(UnmanagedType.Struct), In] object What,
    [MarshalAs(UnmanagedType.Struct), In] object Replacement,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object LookAt,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SearchOrder,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MatchCase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MatchByte,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SearchFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReplaceFormat);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range get_Resize([MarshalAs(UnmanagedType.Struct), In, Optional] object RowSize, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnSize);

  [DispId(257)]
  int Row { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range RowDifferences([MarshalAs(UnmanagedType.Struct), In] object Comparison);

  [DispId(272)]
  object RowHeight { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(258)]
  Range Rows { [TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Select();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Show();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ShowDependents([MarshalAs(UnmanagedType.Struct), In, Optional] object Remove);

  [DispId(585)]
  object ShowDetail { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ShowErrors();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ShowPrecedents([MarshalAs(UnmanagedType.Struct), In, Optional] object Remove);

  [DispId(209)]
  object ShrinkToFit { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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
  SoundNote SoundNote { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range SpecialCells([In] XlCellType Type, [MarshalAs(UnmanagedType.Struct), In, Optional] object Value);

  [DispId(260)]
  object Style { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object SubscribeTo([MarshalAs(UnmanagedType.BStr), In] string Edition, [In] XlSubscribeToFormat Format = XlSubscribeToFormat.xlSubscribeToText);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Subtotal(
    [In] int GroupBy,
    [In] XlConsolidationFunction Function,
    [MarshalAs(UnmanagedType.Struct), In] object TotalList,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Replace,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PageBreaks,
    [In] XlSummaryRow SummaryBelowData = XlSummaryRow.xlSummaryBelow);

  [DispId(273)]
  object Summary { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Table([MarshalAs(UnmanagedType.Struct), In, Optional] object RowInput, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnInput);

  [DispId(138)]
  object Text { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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
  object Top { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Ungroup();

  [DispId(274)]
  object UseStandardHeight { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(275)]
  object UseStandardWidth { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(1387)]
  Validation Validation { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object get_Value([MarshalAs(UnmanagedType.Struct), In, Optional] object RangeValueDataType);

  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void set_Value([MarshalAs(UnmanagedType.Struct), In, Optional] object RangeValueDataType, [MarshalAs(UnmanagedType.Struct), In, Optional] object RHS);

  [DispId(1388)]
  object Value2 { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(137)]
  object VerticalAlignment { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(122)]
  object Width { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(348)]
  Worksheet Worksheet { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(276)]
  object WrapText { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Comment AddComment([MarshalAs(UnmanagedType.Struct), In, Optional] object Text);

  [DispId(910)]
  Comment Comment { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearComments();

  [DispId(1391)]
  Phonetic Phonetic { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1392)]
  FormatConditions FormatConditions { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(975)]
  int ReadingOrder { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1393)]
  Hyperlinks Hyperlinks { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1811)]
  Phonetics Phonetics { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetPhonetic();

  [DispId(1813)]
  string ID { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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
  PivotCell PivotCell { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Dirty();

  [DispId(2015)]
  Errors Errors { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2016)]
  SmartTags SmartTags { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Speak([MarshalAs(UnmanagedType.Struct), In, Optional] object SpeakDirection, [MarshalAs(UnmanagedType.Struct), In, Optional] object SpeakFormulas);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object PasteSpecial(
    [In] XlPasteType Paste = XlPasteType.xlPasteAll,
    [In] XlPasteSpecialOperation Operation = XlPasteSpecialOperation.xlPasteSpecialOperationNone,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SkipBlanks,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Transpose);

  [DispId(2020)]
  bool AllowEdit { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2257)]
  ListObject ListObject { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2258)]
  XPath XPath { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2491)]
  Actions ServerActions { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveDuplicates([MarshalAs(UnmanagedType.Struct), In, Optional] object Columns, [In] XlYesNoGuess Header = XlYesNoGuess.xlNo);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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
  string MDX { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

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

  [DispId(2499)]
  object CountLarge { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object CalculateRowMajorOrder();
}
