// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.Table
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[DefaultMember("Range")]
[TypeLibType(4288)]
[Guid("00020951-0000-0000-C000-000000000046")]
[ComImport]
public interface Table
{
  [DispId(0)]
  Range Range { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(100)]
  Columns Columns { [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(101)]
  Rows Rows { [DispId(101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1100)]
  Borders Borders { [DispId(1100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(1100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(104)]
  Shading Shading { [DispId(104), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(105)]
  bool Uniform { [DispId(105), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(106)]
  int AutoFormatType { [DispId(106), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(200)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Select();

  [DispId(9)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Delete();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(10)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SortOld(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExcludeHeader,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CaseSensitive,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LanguageID);

  [DispId(12)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SortAscending();

  [DispId(13)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SortDescending();

  [DispId(14)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AutoFormat(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyBorders,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyShading,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyFont,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyColor,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyHeadingRows,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyLastRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyFirstColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyLastColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoFit);

  [DispId(15)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void UpdateAutoFormat();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(16 /*0x10*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range ConvertToTextOld([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Separator);

  [DispId(17)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Microsoft.Office.Interop.Word.Cell Cell([In] int Row, [In] int Column);

  [DispId(18)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Table Split([MarshalAs(UnmanagedType.Struct), In] ref object BeforeRow);

  [DispId(19)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range ConvertToText([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Separator, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NestedTables);

  [DispId(20)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AutoFitBehavior([In] WdAutoFitBehavior Behavior);

  [DispId(23)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Sort(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExcludeHeader,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CaseSensitive,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object BidiSort,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreThe,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreKashida,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreDiacritics,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreHe,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LanguageID);

  [DispId(107)]
  Tables Tables { [DispId(107), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(108)]
  int NestingLevel { [DispId(108), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(109)]
  bool AllowPageBreaks { [DispId(109), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(109), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(110)]
  bool AllowAutoFit { [DispId(110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(111)]
  float PreferredWidth { [DispId(111), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(111), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(112 /*0x70*/)]
  WdPreferredWidthType PreferredWidthType { [DispId(112 /*0x70*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(112 /*0x70*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(113)]
  float TopPadding { [DispId(113), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(113), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(114)]
  float BottomPadding { [DispId(114), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(114), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(115)]
  float LeftPadding { [DispId(115), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(115), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(116)]
  float RightPadding { [DispId(116), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(116), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(117)]
  float Spacing { [DispId(117), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(117), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(118)]
  WdTableDirection TableDirection { [DispId(118), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(118), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(119)]
  string ID { [DispId(119), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(119), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(201)]
  object Style { [DispId(201), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(201), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(202)]
  bool ApplyStyleHeadingRows { [DispId(202), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(202), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(203)]
  bool ApplyStyleLastRow { [DispId(203), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(203), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(204)]
  bool ApplyStyleFirstColumn { [DispId(204), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(204), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(205)]
  bool ApplyStyleLastColumn { [DispId(205), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(205), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(206)]
  bool ApplyStyleRowBands { [DispId(206), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(206), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(207)]
  bool ApplyStyleColumnBands { [DispId(207), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(207), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(208 /*0xD0*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyStyleDirectFormatting([MarshalAs(UnmanagedType.BStr), In] string StyleName);
}
