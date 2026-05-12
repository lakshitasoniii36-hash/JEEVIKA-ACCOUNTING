// Decompiled with JetBrains decompiler
// Type: MSXML2.ISAXXMLFilter
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("70409222-CA09-4475-ACB8-40312FE8D145")]
[InterfaceType(1)]
[TypeLibType(16 /*0x10*/)]
[ComImport]
public interface ISAXXMLFilter : ISAXXMLReader
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new bool getFeature([In] ref ushort pwchName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void putFeature([In] ref ushort pwchName, [In] bool vfValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object getProperty([In] ref ushort pwchName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void putProperty([In] ref ushort pwchName, [MarshalAs(UnmanagedType.Struct), In] object varValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  new ISAXEntityResolver getEntityResolver();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void putEntityResolver([MarshalAs(UnmanagedType.Interface), In] ISAXEntityResolver pResolver);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  new ISAXContentHandler getContentHandler();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void putContentHandler([MarshalAs(UnmanagedType.Interface), In] ISAXContentHandler pHandler);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  new ISAXDTDHandler getDTDHandler();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void putDTDHandler([MarshalAs(UnmanagedType.Interface), In] ISAXDTDHandler pHandler);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  new ISAXErrorHandler getErrorHandler();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void putErrorHandler([MarshalAs(UnmanagedType.Interface), In] ISAXErrorHandler pHandler);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new IntPtr getBaseURL();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void putBaseURL([In] ref ushort pwchBaseUrl);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new IntPtr getSecureBaseURL();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void putSecureBaseURL([In] ref ushort pwchSecureBaseUrl);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void parse([MarshalAs(UnmanagedType.Struct), In, Optional] object varInput);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void parseURL([In] ref ushort pwchUrl);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ISAXXMLReader getParent();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void putParent([MarshalAs(UnmanagedType.Interface), In] ISAXXMLReader pReader);
}
