// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.ISeriesCollection
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(4112)]
[Guid("0002086C-0001-0000-C000-000000000046")]
[DefaultMember("_Default")]
[ComImport]
public interface ISeriesCollection : IEnumerable
{
  [DispId(148)]
  Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Series Add(
    [MarshalAs(UnmanagedType.Struct), In] object Source,
    [In] XlRowCol Rowcol = (XlRowCol) -4105,
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
  Series Item([MarshalAs(UnmanagedType.Struct), In] object Index);

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
  Series NewSeries();

  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Series _Default([MarshalAs(UnmanagedType.Struct), In] object Index);
}
