// Decompiled with JetBrains decompiler
// Type: stdole.IPicture
// Assembly: stdole, Version=7.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 1DF05181-E8B1-41E5-9E16-182D6B591D92
// Assembly location: C:\WINDOWS\assembly\GAC\stdole\7.0.3300.0__b03f5f7f11d50a3a\stdole.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace stdole;

[ComConversionLoss]
[TypeLibType(16 /*0x10*/)]
[Guid("7BF80980-BF32-101A-8BBB-00AA00300CAB")]
[InterfaceType(1)]
[ComImport]
public interface IPicture
{
  [DispId(1610678272 /*0x60010000*/)]
  [ComAliasName("stdole.OLE_HANDLE")]
  int Handle { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("stdole.OLE_HANDLE")] get; }

  [DispId(1610678273 /*0x60010001*/)]
  [ComAliasName("stdole.OLE_HANDLE")]
  int hPal { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("stdole.OLE_HANDLE")] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: ComAliasName("stdole.OLE_HANDLE"), In] set; }

  [DispId(1610678274 /*0x60010002*/)]
  short Type { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610678275 /*0x60010003*/)]
  [ComAliasName("stdole.OLE_XSIZE_HIMETRIC")]
  int Width { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("stdole.OLE_XSIZE_HIMETRIC")] get; }

  [DispId(1610678276 /*0x60010004*/)]
  [ComAliasName("stdole.OLE_YSIZE_HIMETRIC")]
  int Height { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("stdole.OLE_YSIZE_HIMETRIC")] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Render(
    [In] int hdc,
    [In] int x,
    [In] int y,
    [In] int cx,
    [In] int cy,
    [ComAliasName("stdole.OLE_XPOS_HIMETRIC"), In] int xSrc,
    [ComAliasName("stdole.OLE_YPOS_HIMETRIC"), In] int ySrc,
    [ComAliasName("stdole.OLE_XSIZE_HIMETRIC"), In] int cxSrc,
    [ComAliasName("stdole.OLE_YSIZE_HIMETRIC"), In] int cySrc,
    [In] IntPtr prcWBounds);

  [DispId(1610678279 /*0x60010007*/)]
  int CurDC { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectPicture([In] int hdcIn, out int phdcOut, [ComAliasName("stdole.OLE_HANDLE")] out int phbmpOut);

  [DispId(1610678281 /*0x60010009*/)]
  bool KeepOriginalFormat { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PictureChanged();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SaveAsFile([In] IntPtr pstm, [In] bool fSaveMemCopy, out int pcbSize);

  [DispId(1610678285 /*0x6001000D*/)]
  int Attributes { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetHdc([ComAliasName("stdole.OLE_HANDLE"), In] int hdc);
}
