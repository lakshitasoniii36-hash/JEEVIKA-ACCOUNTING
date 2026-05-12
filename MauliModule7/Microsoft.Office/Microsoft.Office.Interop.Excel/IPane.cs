// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IPane
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[Guid("00020895-0001-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface IPane
{
  [DispId(148)]
  Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Activate();

  [DispId(486)]
  int Index { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object LargeScroll([MarshalAs(UnmanagedType.Struct), In, Optional] object Down, [MarshalAs(UnmanagedType.Struct), In, Optional] object Up, [MarshalAs(UnmanagedType.Struct), In, Optional] object ToRight, [MarshalAs(UnmanagedType.Struct), In, Optional] object ToLeft);

  [DispId(654)]
  int ScrollColumn { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(655)]
  int ScrollRow { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object SmallScroll([MarshalAs(UnmanagedType.Struct), In, Optional] object Down, [MarshalAs(UnmanagedType.Struct), In, Optional] object Up, [MarshalAs(UnmanagedType.Struct), In, Optional] object ToRight, [MarshalAs(UnmanagedType.Struct), In, Optional] object ToLeft);

  [DispId(1118)]
  Range VisibleRange { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ScrollIntoView([In] int Left, [In] int Top, [In] int Width, [In] int Height, [MarshalAs(UnmanagedType.Struct), In, Optional] object Start);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int PointsToScreenPixelsX([In] int Points);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int PointsToScreenPixelsY([In] int Points);
}
