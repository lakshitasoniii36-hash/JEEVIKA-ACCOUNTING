// Decompiled with JetBrains decompiler
// Type: MSXML2.IMXAttributes
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("F10D27CC-3EC0-415C-8ED8-77AB1C5E7262")]
[TypeLibType(4288)]
[ComImport]
public interface IMXAttributes
{
  [DispId(1373)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void addAttribute(
    [MarshalAs(UnmanagedType.BStr), In] string strURI,
    [MarshalAs(UnmanagedType.BStr), In] string strLocalName,
    [MarshalAs(UnmanagedType.BStr), In] string strQName,
    [MarshalAs(UnmanagedType.BStr), In] string strType,
    [MarshalAs(UnmanagedType.BStr), In] string strValue);

  [DispId(1383)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void addAttributeFromIndex([MarshalAs(UnmanagedType.Struct), In] object varAtts, [In] int nIndex);

  [DispId(1374)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void clear();

  [DispId(1375)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void removeAttribute([In] int nIndex);

  [DispId(1376)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void setAttribute(
    [In] int nIndex,
    [MarshalAs(UnmanagedType.BStr), In] string strURI,
    [MarshalAs(UnmanagedType.BStr), In] string strLocalName,
    [MarshalAs(UnmanagedType.BStr), In] string strQName,
    [MarshalAs(UnmanagedType.BStr), In] string strType,
    [MarshalAs(UnmanagedType.BStr), In] string strValue);

  [DispId(1377)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void setAttributes([MarshalAs(UnmanagedType.Struct), In] object varAtts);

  [DispId(1378)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void setLocalName([In] int nIndex, [MarshalAs(UnmanagedType.BStr), In] string strLocalName);

  [DispId(1379)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void setQName([In] int nIndex, [MarshalAs(UnmanagedType.BStr), In] string strQName);

  [DispId(1380)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void setType([In] int nIndex, [MarshalAs(UnmanagedType.BStr), In] string strType);

  [DispId(1381)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void setURI([In] int nIndex, [MarshalAs(UnmanagedType.BStr), In] string strURI);

  [DispId(1382)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void setValue([In] int nIndex, [MarshalAs(UnmanagedType.BStr), In] string strValue);
}
