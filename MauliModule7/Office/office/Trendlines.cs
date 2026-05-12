// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.Trendlines
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Core;

[Guid("000C1722-0000-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface Trendlines : IEnumerable
{
  [DispId(150)]
  object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IMsoTrendline Add(
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
  int Count { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IMsoTrendline Item([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();
}
