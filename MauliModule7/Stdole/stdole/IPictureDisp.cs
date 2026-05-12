// Decompiled with JetBrains decompiler
// Type: stdole.IPictureDisp
// Assembly: stdole, Version=7.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 1DF05181-E8B1-41E5-9E16-182D6B591D92
// Assembly location: C:\WINDOWS\assembly\GAC\stdole\7.0.3300.0__b03f5f7f11d50a3a\stdole.dll

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace stdole;

[DefaultMember("Handle")]
[InterfaceType(2)]
[Guid("7BF80981-BF32-101A-8BBB-00AA00300CAB")]
[ComConversionLoss]
[ComImport]
public interface IPictureDisp
{
  [DispId(0)]
  [ComAliasName("stdole.OLE_HANDLE")]
  int Handle { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2)]
  [ComAliasName("stdole.OLE_HANDLE")]
  int hPal { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

  [DispId(3)]
  short Type { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(4)]
  [ComAliasName("stdole.OLE_XSIZE_HIMETRIC")]
  int Width { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(5)]
  [ComAliasName("stdole.OLE_YSIZE_HIMETRIC")]
  int Height { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(6)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Render(
    int hdc,
    int x,
    int y,
    int cx,
    int cy,
    [ComAliasName("stdole.OLE_XPOS_HIMETRIC")] int xSrc,
    [ComAliasName("stdole.OLE_YPOS_HIMETRIC")] int ySrc,
    [ComAliasName("stdole.OLE_XSIZE_HIMETRIC")] int cxSrc,
    [ComAliasName("stdole.OLE_YSIZE_HIMETRIC")] int cySrc,
    IntPtr prcWBounds);
}
