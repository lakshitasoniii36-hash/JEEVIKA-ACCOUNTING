// Decompiled with JetBrains decompiler
// Type: MSXML2.SAXAttributes60Class
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[ComConversionLoss]
[ClassInterface(0)]
[Guid("88D96A0E-F192-11D4-A65F-0040963251E5")]
[TypeLibType(2)]
[ComImport]
public class SAXAttributes60Class : IMXAttributes, SAXAttributes60, IVBSAXAttributes, ISAXAttributes
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern SAXAttributes60Class();

  [DispId(1373)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void addAttribute(
    [MarshalAs(UnmanagedType.BStr), In] string strURI,
    [MarshalAs(UnmanagedType.BStr), In] string strLocalName,
    [MarshalAs(UnmanagedType.BStr), In] string strQName,
    [MarshalAs(UnmanagedType.BStr), In] string strType,
    [MarshalAs(UnmanagedType.BStr), In] string strValue);

  [DispId(1383)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void addAttributeFromIndex([MarshalAs(UnmanagedType.Struct), In] object varAtts, [In] int nIndex);

  [DispId(1374)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void clear();

  [DispId(1375)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void removeAttribute([In] int nIndex);

  [DispId(1376)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setAttribute(
    [In] int nIndex,
    [MarshalAs(UnmanagedType.BStr), In] string strURI,
    [MarshalAs(UnmanagedType.BStr), In] string strLocalName,
    [MarshalAs(UnmanagedType.BStr), In] string strQName,
    [MarshalAs(UnmanagedType.BStr), In] string strType,
    [MarshalAs(UnmanagedType.BStr), In] string strValue);

  [DispId(1377)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setAttributes([MarshalAs(UnmanagedType.Struct), In] object varAtts);

  [DispId(1378)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setLocalName([In] int nIndex, [MarshalAs(UnmanagedType.BStr), In] string strLocalName);

  [DispId(1379)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setQName([In] int nIndex, [MarshalAs(UnmanagedType.BStr), In] string strQName);

  [DispId(1380)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setType([In] int nIndex, [MarshalAs(UnmanagedType.BStr), In] string strType);

  [DispId(1381)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setURI([In] int nIndex, [MarshalAs(UnmanagedType.BStr), In] string strURI);

  [DispId(1382)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setValue([In] int nIndex, [MarshalAs(UnmanagedType.BStr), In] string strValue);

  public virtual extern int length { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string getURI([In] int nIndex);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string getLocalName([In] int nIndex);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string getQName([In] int nIndex);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int getIndexFromName([MarshalAs(UnmanagedType.BStr), In] string strURI, [MarshalAs(UnmanagedType.BStr), In] string strLocalName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int getIndexFromQName([MarshalAs(UnmanagedType.BStr), In] string strQName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string getType([In] int nIndex);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string getTypeFromName([MarshalAs(UnmanagedType.BStr), In] string strURI, [MarshalAs(UnmanagedType.BStr), In] string strLocalName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string getTypeFromQName([MarshalAs(UnmanagedType.BStr), In] string strQName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string getValue([In] int nIndex);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string getValueFromName([MarshalAs(UnmanagedType.BStr), In] string strURI, [MarshalAs(UnmanagedType.BStr), In] string strLocalName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string getValueFromQName([MarshalAs(UnmanagedType.BStr), In] string strQName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int getLength();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getURI([In] int nIndex, [Out] IntPtr ppwchUri, out int pcchUri);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getLocalName([In] int nIndex, [Out] IntPtr ppwchLocalName, out int pcchLocalName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getQName([In] int nIndex, [Out] IntPtr ppwchQName, out int pcchQName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getName(
    [In] int nIndex,
    [Out] IntPtr ppwchUri,
    out int pcchUri,
    [Out] IntPtr ppwchLocalName,
    out int pcchLocalName,
    [Out] IntPtr ppwchQName,
    out int pcchQName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int getIndexFromName(
    [In] ref ushort pwchUri,
    [In] int cchUri,
    [In] ref ushort pwchLocalName,
    [In] int cchLocalName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int getIndexFromQName([In] ref ushort pwchQName, [In] int cchQName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getType([In] int nIndex, [Out] IntPtr ppwchType, out int pcchType);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getTypeFromName(
    [In] ref ushort pwchUri,
    [In] int cchUri,
    [In] ref ushort pwchLocalName,
    [In] int cchLocalName,
    [Out] IntPtr ppwchType,
    out int pcchType);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getTypeFromQName(
    [In] ref ushort pwchQName,
    [In] int cchQName,
    [Out] IntPtr ppwchType,
    out int pcchType);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getValue([In] int nIndex, [Out] IntPtr ppwchValue, out int pcchValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getValueFromName(
    [In] ref ushort pwchUri,
    [In] int cchUri,
    [In] ref ushort pwchLocalName,
    [In] int cchLocalName,
    [Out] IntPtr ppwchValue,
    out int pcchValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getValueFromQName(
    [In] ref ushort pwchQName,
    [In] int cchQName,
    [Out] IntPtr ppwchValue,
    out int pcchValue);
}
