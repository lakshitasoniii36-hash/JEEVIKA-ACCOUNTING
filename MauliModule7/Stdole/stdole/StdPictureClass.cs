// Decompiled with JetBrains decompiler
// Type: stdole.StdPictureClass
// Assembly: stdole, Version=7.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 1DF05181-E8B1-41E5-9E16-182D6B591D92
// Assembly location: C:\WINDOWS\assembly\GAC\stdole\7.0.3300.0__b03f5f7f11d50a3a\stdole.dll

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace stdole;

[TypeLibType(2)]
[ComConversionLoss]
[Guid("0BE35204-8F91-11CE-9DE3-00AA004BB851")]
[DefaultMember("Handle")]
[ClassInterface(0)]
[ComImport]
public class StdPictureClass : Picture, StdPicture, IPicture
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern StdPictureClass();

  [ComAliasName("stdole.OLE_HANDLE")]
  [DispId(0)]
  public virtual extern int Handle { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2)]
  [ComAliasName("stdole.OLE_HANDLE")]
  public virtual extern int hPal { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] set; }

  [DispId(3)]
  public virtual extern short Type { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(4)]
  [ComAliasName("stdole.OLE_XSIZE_HIMETRIC")]
  public virtual extern int Width { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(5)]
  [ComAliasName("stdole.OLE_YSIZE_HIMETRIC")]
  public virtual extern int Height { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(6)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Render(
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

  [ComAliasName("stdole.OLE_HANDLE")]
  public virtual extern int IPicture_Handle { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("stdole.OLE_HANDLE")] get; }

  [ComAliasName("stdole.OLE_HANDLE")]
  public virtual extern int IPicture_hPal { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("stdole.OLE_HANDLE")] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: ComAliasName("stdole.OLE_HANDLE"), In] set; }

  public virtual extern short IPicture_Type { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [ComAliasName("stdole.OLE_XSIZE_HIMETRIC")]
  public virtual extern int IPicture_Width { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("stdole.OLE_XSIZE_HIMETRIC")] get; }

  [ComAliasName("stdole.OLE_YSIZE_HIMETRIC")]
  public virtual extern int IPicture_Height { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("stdole.OLE_YSIZE_HIMETRIC")] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void IPicture_Render(
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

  public virtual extern int CurDC { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SelectPicture([In] int hdcIn, out int phdcOut, [ComAliasName("stdole.OLE_HANDLE")] out int phbmpOut);

  public virtual extern bool KeepOriginalFormat { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PictureChanged();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SaveAsFile([In] IntPtr pstm, [In] bool fSaveMemCopy, out int pcbSize);

  public virtual extern int Attributes { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetHdc([ComAliasName("stdole.OLE_HANDLE"), In] int hdc);
}
