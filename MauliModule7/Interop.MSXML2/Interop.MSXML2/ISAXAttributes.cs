// Decompiled with JetBrains decompiler
// Type: MSXML2.ISAXAttributes
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("F078ABE1-45D2-4832-91EA-4466CE2F25C9")]
[TypeLibType(16 /*0x10*/)]
[InterfaceType(1)]
[ComConversionLoss]
[ComImport]
public interface ISAXAttributes
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int getLength();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void getURI([In] int nIndex, [Out] IntPtr ppwchUri, out int pcchUri);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void getLocalName([In] int nIndex, [Out] IntPtr ppwchLocalName, out int pcchLocalName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void getQName([In] int nIndex, [Out] IntPtr ppwchQName, out int pcchQName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void getName(
    [In] int nIndex,
    [Out] IntPtr ppwchUri,
    out int pcchUri,
    [Out] IntPtr ppwchLocalName,
    out int pcchLocalName,
    [Out] IntPtr ppwchQName,
    out int pcchQName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int getIndexFromName([In] ref ushort pwchUri, [In] int cchUri, [In] ref ushort pwchLocalName, [In] int cchLocalName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int getIndexFromQName([In] ref ushort pwchQName, [In] int cchQName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void getType([In] int nIndex, [Out] IntPtr ppwchType, out int pcchType);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void getTypeFromName(
    [In] ref ushort pwchUri,
    [In] int cchUri,
    [In] ref ushort pwchLocalName,
    [In] int cchLocalName,
    [Out] IntPtr ppwchType,
    out int pcchType);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void getTypeFromQName([In] ref ushort pwchQName, [In] int cchQName, [Out] IntPtr ppwchType, out int pcchType);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void getValue([In] int nIndex, [Out] IntPtr ppwchValue, out int pcchValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void getValueFromName(
    [In] ref ushort pwchUri,
    [In] int cchUri,
    [In] ref ushort pwchLocalName,
    [In] int cchLocalName,
    [Out] IntPtr ppwchValue,
    out int pcchValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void getValueFromQName([In] ref ushort pwchQName, [In] int cchQName, [Out] IntPtr ppwchValue, out int pcchValue);
}
