// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.MailMergeFields
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
[Guid("0002091F-0000-0000-C000-000000000046")]
[ComImport]
public interface MailMergeFields : IEnumerable
{
  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [TypeLibFunc(1024 /*0x0400*/)]
  [DispId(-4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(1)]
  int Count { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(0)]
  MailMergeField this[[In] int Index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(101)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  MailMergeField Add([MarshalAs(UnmanagedType.Interface), In] Range Range, [MarshalAs(UnmanagedType.BStr), In] string Name);

  [DispId(102)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  MailMergeField AddAsk(
    [MarshalAs(UnmanagedType.Interface), In] Range Range,
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Prompt,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultAskText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AskOnce);

  [DispId(103)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  MailMergeField AddFillIn(
    [MarshalAs(UnmanagedType.Interface), In] Range Range,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Prompt,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultFillInText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AskOnce);

  [DispId(104)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  MailMergeField AddIf(
    [MarshalAs(UnmanagedType.Interface), In] Range Range,
    [MarshalAs(UnmanagedType.BStr), In] string MergeField,
    [In] WdMailMergeComparison Comparison,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CompareTo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TrueAutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TrueText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FalseAutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FalseText);

  [DispId(105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  MailMergeField AddMergeRec([MarshalAs(UnmanagedType.Interface), In] Range Range);

  [DispId(106)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  MailMergeField AddMergeSeq([MarshalAs(UnmanagedType.Interface), In] Range Range);

  [DispId(107)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  MailMergeField AddNext([MarshalAs(UnmanagedType.Interface), In] Range Range);

  [DispId(108)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  MailMergeField AddNextIf(
    [MarshalAs(UnmanagedType.Interface), In] Range Range,
    [MarshalAs(UnmanagedType.BStr), In] string MergeField,
    [In] WdMailMergeComparison Comparison,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CompareTo);

  [DispId(109)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  MailMergeField AddSet([MarshalAs(UnmanagedType.Interface), In] Range Range, [MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ValueText, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ValueAutoText);

  [DispId(110)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  MailMergeField AddSkipIf(
    [MarshalAs(UnmanagedType.Interface), In] Range Range,
    [MarshalAs(UnmanagedType.BStr), In] string MergeField,
    [In] WdMailMergeComparison Comparison,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CompareTo);
}
