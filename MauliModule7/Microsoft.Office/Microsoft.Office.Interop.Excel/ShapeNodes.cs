// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.ShapeNodes
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[DefaultMember("Item")]
[Guid("000C0319-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
[ComImport]
public interface ShapeNodes : _IMsoDispObj, IEnumerable
{
  [DispId(1610743808 /*0x60020000*/)]
  new object Application { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  new int Creator { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1)]
  object Parent { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(2)]
  int Count { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ShapeNode Item([MarshalAs(UnmanagedType.Struct), In] object Index);

  [DispId(-4)]
  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(11)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Delete([In] int Index);

  [DispId(12)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Insert(
    [In] int Index,
    [In] MsoSegmentType SegmentType,
    [In] MsoEditingType EditingType,
    [In] float X1,
    [In] float Y1,
    [In] float X2 = 0.0f,
    [In] float Y2 = 0.0f,
    [In] float X3 = 0.0f,
    [In] float Y3 = 0.0f);

  [DispId(13)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetEditingType([In] int Index, [In] MsoEditingType EditingType);

  [DispId(14)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetPosition([In] int Index, [In] float X1, [In] float Y1);

  [DispId(15)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetSegmentType([In] int Index, [In] MsoSegmentType SegmentType);
}
