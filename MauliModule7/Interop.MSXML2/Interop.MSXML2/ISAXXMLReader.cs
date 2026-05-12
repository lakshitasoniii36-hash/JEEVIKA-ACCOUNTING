// Decompiled with JetBrains decompiler
// Type: MSXML2.ISAXXMLReader
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[ComConversionLoss]
[Guid("A4F96ED0-F829-476E-81C0-CDC7BD2A0802")]
[InterfaceType(1)]
[TypeLibType(16 /*0x10*/)]
[ComImport]
public interface ISAXXMLReader
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool getFeature([In] ref ushort pwchName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void putFeature([In] ref ushort pwchName, [In] bool vfValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object getProperty([In] ref ushort pwchName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void putProperty([In] ref ushort pwchName, [MarshalAs(UnmanagedType.Struct), In] object varValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ISAXEntityResolver getEntityResolver();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void putEntityResolver([MarshalAs(UnmanagedType.Interface), In] ISAXEntityResolver pResolver);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ISAXContentHandler getContentHandler();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void putContentHandler([MarshalAs(UnmanagedType.Interface), In] ISAXContentHandler pHandler);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ISAXDTDHandler getDTDHandler();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void putDTDHandler([MarshalAs(UnmanagedType.Interface), In] ISAXDTDHandler pHandler);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ISAXErrorHandler getErrorHandler();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void putErrorHandler([MarshalAs(UnmanagedType.Interface), In] ISAXErrorHandler pHandler);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  IntPtr getBaseURL();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void putBaseURL([In] ref ushort pwchBaseUrl);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  IntPtr getSecureBaseURL();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void putSecureBaseURL([In] ref ushort pwchSecureBaseUrl);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void parse([MarshalAs(UnmanagedType.Struct), In, Optional] object varInput);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void parseURL([In] ref ushort pwchUrl);
}
