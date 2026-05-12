// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.SeriesCollection
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Core;

[Guid("000C170A-0000-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface SeriesCollection : IEnumerable
{
  [DispId(150)]
  object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IMsoSeries Add(
    [MarshalAs(UnmanagedType.Struct), In] object Source,
    [In] XlRowCol Rowcol = XlRowCol.xlColumns,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SeriesLabels,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CategoryLabels,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Replace);

  [DispId(118)]
  int Count { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Extend([MarshalAs(UnmanagedType.Struct), In] object Source, [MarshalAs(UnmanagedType.Struct), In, Optional] object Rowcol, [MarshalAs(UnmanagedType.Struct), In, Optional] object CategoryLabels);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IMsoSeries Item([MarshalAs(UnmanagedType.Struct), In] object Index);

  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Paste(
    [In] XlRowCol Rowcol = XlRowCol.xlColumns,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SeriesLabels,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CategoryLabels,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Replace,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object NewSeries);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IMsoSeries NewSeries();
}
