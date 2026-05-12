// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.InlineShapes
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using Microsoft.Office.Core;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[TypeLibType(4288)]
[Guid("000209A9-0000-0000-C000-000000000046")]
[ComImport]
public interface InlineShapes : IEnumerable
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
  InlineShape this[[In] int Index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(100)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  InlineShape AddPicture(
    [MarshalAs(UnmanagedType.BStr), In] string FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LinkToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveWithDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range);

  [DispId(24)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  InlineShape AddOLEObject(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ClassType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LinkToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DisplayAsIcon,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IconFileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IconIndex,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IconLabel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range);

  [DispId(102)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  InlineShape AddOLEControl([MarshalAs(UnmanagedType.Struct), In, Optional] ref object ClassType, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range);

  [DispId(200)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  InlineShape New([MarshalAs(UnmanagedType.Interface), In] Range Range);

  [DispId(104)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  InlineShape AddHorizontalLine([MarshalAs(UnmanagedType.BStr), In] string FileName, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range);

  [DispId(105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  InlineShape AddHorizontalLineStandard([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range);

  [DispId(106)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  InlineShape AddPictureBullet([MarshalAs(UnmanagedType.BStr), In] string FileName, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range);

  [DispId(107)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  InlineShape AddChart([In] XlChartType Type = (XlChartType) -1, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range);
}
