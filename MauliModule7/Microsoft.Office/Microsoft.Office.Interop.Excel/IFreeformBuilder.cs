// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IFreeformBuilder
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[Guid("0002443F-0001-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface IFreeformBuilder
{
  [DispId(148)]
  Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddNodes(
    [In] MsoSegmentType SegmentType,
    [In] MsoEditingType EditingType,
    [In] float X1,
    [In] float Y1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object X2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Y2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object X3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Y3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape ConvertToShape();
}
