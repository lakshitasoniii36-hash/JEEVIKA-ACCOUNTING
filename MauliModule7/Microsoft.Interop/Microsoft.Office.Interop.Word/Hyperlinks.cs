// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.Hyperlinks
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[Guid("0002099C-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
[ComImport]
public interface Hyperlinks : IEnumerable
{
  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1)]
  int Count { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(-4)]
  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(0)]
  Hyperlink this[[MarshalAs(UnmanagedType.Struct), In] ref object Index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(100)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Hyperlink _Add([MarshalAs(UnmanagedType.IDispatch), In] object Anchor, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SubAddress);

  [DispId(101)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Hyperlink Add(
    [MarshalAs(UnmanagedType.IDispatch), In] object Anchor,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SubAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ScreenTip,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TextToDisplay,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Target);
}
