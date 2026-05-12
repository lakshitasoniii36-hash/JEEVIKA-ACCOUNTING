// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.TablesOfFigures
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[TypeLibType(4288)]
[Guid("00020922-0000-0000-C000-000000000046")]
[ComImport]
public interface TablesOfFigures : IEnumerable
{
  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(-4)]
  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(1)]
  int Count { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2)]
  WdTofFormat Format { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(0)]
  TableOfFigures this[[In] int Index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(100)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  TableOfFigures AddOld(
    [MarshalAs(UnmanagedType.Interface), In] Range Range,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Caption,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludeLabel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UseHeadingStyles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UpperHeadingLevel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LowerHeadingLevel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UseFields,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TableID,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RightAlignPageNumbers,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludePageNumbers,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddedStyles);

  [DispId(101)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Field MarkEntry(
    [MarshalAs(UnmanagedType.Interface), In] Range Range,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Entry,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EntryAutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TableID,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Level);

  [DispId(444)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  TableOfFigures Add(
    [MarshalAs(UnmanagedType.Interface), In] Range Range,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Caption,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludeLabel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UseHeadingStyles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UpperHeadingLevel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LowerHeadingLevel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UseFields,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TableID,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RightAlignPageNumbers,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludePageNumbers,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddedStyles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UseHyperlinks,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object HidePageNumbersInWeb);
}
