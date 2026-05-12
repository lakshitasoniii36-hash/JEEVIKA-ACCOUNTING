// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.TablesOfAuthorities
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[Guid("00020912-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
[ComImport]
public interface TablesOfAuthorities : IEnumerable
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
  WdToaFormat Format { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(0)]
  TableOfAuthorities this[[In] int Index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(100)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  TableOfAuthorities Add(
    [MarshalAs(UnmanagedType.Interface), In] Range Range,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Category,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Bookmark,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Passim,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object KeepEntryFormatting,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Separator,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludeSequenceName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EntrySeparator,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PageRangeSeparator,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludeCategoryHeader,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PageNumberSeparator);

  [DispId(103)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NextCitation([MarshalAs(UnmanagedType.BStr), In] string ShortCitation);

  [DispId(101)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Field MarkCitation(
    [MarshalAs(UnmanagedType.Interface), In] Range Range,
    [MarshalAs(UnmanagedType.BStr), In] string ShortCitation,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LongCitation,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LongCitationAutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Category);

  [DispId(102)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MarkAllCitations(
    [MarshalAs(UnmanagedType.BStr), In] string ShortCitation,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LongCitation,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LongCitationAutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Category);
}
