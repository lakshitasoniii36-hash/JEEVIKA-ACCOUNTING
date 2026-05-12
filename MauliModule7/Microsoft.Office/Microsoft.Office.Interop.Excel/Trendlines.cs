// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.Trendlines
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

[TypeLibType(4096 /*0x1000*/)]
[Guid("000208BD-0000-0000-C000-000000000046")]
[InterfaceType(2)]
[DefaultMember("_Default")]
[ComImport]
public interface Trendlines
{
  [DispId(148)]
  Application Application { [DispId(148), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [DispId(149), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [DispId(150), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(181)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Trendline Add(
    [In] XlTrendlineType Type = XlTrendlineType.xlLinear,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Order,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Period,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Forward,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Backward,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Intercept,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DisplayEquation,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DisplayRSquared,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Name);

  [DispId(118)]
  int Count { [DispId(118), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(170)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Trendline Item([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(1024 /*0x0400*/)]
  [DispId(-4)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  IEnumerator GetEnumerator();

  [TypeLibFunc(1024 /*0x0400*/)]
  [DispId(0)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Trendline _Default([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);
}
