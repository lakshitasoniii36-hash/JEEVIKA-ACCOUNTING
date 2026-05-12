// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.Pane
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[InterfaceType(2)]
[Guid("00020895-0000-0000-C000-000000000046")]
[TypeLibType(4096 /*0x1000*/)]
[ComImport]
public interface Pane
{
  [DispId(148)]
  Application Application { [DispId(148), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [DispId(149), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [DispId(150), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(304)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Activate();

  [DispId(486)]
  int Index { [DispId(486), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(547)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object LargeScroll([MarshalAs(UnmanagedType.Struct), In, Optional] object Down, [MarshalAs(UnmanagedType.Struct), In, Optional] object Up, [MarshalAs(UnmanagedType.Struct), In, Optional] object ToRight, [MarshalAs(UnmanagedType.Struct), In, Optional] object ToLeft);

  [DispId(654)]
  int ScrollColumn { [DispId(654), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(654), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(655)]
  int ScrollRow { [DispId(655), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(655), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(548)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object SmallScroll([MarshalAs(UnmanagedType.Struct), In, Optional] object Down, [MarshalAs(UnmanagedType.Struct), In, Optional] object Up, [MarshalAs(UnmanagedType.Struct), In, Optional] object ToRight, [MarshalAs(UnmanagedType.Struct), In, Optional] object ToLeft);

  [DispId(1118)]
  Range VisibleRange { [DispId(1118), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1781)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ScrollIntoView([In] int Left, [In] int Top, [In] int Width, [In] int Height, [MarshalAs(UnmanagedType.Struct), In, Optional] object Start);

  [DispId(1776)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int PointsToScreenPixelsX([In] int Points);

  [DispId(1777)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int PointsToScreenPixelsY([In] int Points);
}
