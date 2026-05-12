// Decompiled with JetBrains decompiler
// Type: MSXML2.IMXNamespaceManager
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[InterfaceType(1)]
[TypeLibType(16 /*0x10*/)]
[Guid("C90352F6-643C-4FBC-BB23-E996EB2D51FD")]
[ComImport]
public interface IMXNamespaceManager
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void putAllowOverride([In] bool fOverride);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool getAllowOverride();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reset();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void pushContext();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void pushNodeContext([MarshalAs(UnmanagedType.Interface), In] IXMLDOMNode contextNode, [In] bool fDeep);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void popContext();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void declarePrefix([MarshalAs(UnmanagedType.LPWStr), In] string prefix, [MarshalAs(UnmanagedType.LPWStr), In] string namespaceURI);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void getDeclaredPrefix([In] int nIndex, [In, Out] ref ushort pwchPrefix, [In, Out] ref int pcchPrefix);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void getPrefix([MarshalAs(UnmanagedType.LPWStr), In] string pwszNamespaceURI, [In] int nIndex, [In, Out] ref ushort pwchPrefix, [In, Out] ref int pcchPrefix);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void getURI([MarshalAs(UnmanagedType.LPWStr), In] string pwchPrefix, [MarshalAs(UnmanagedType.Interface), In] IXMLDOMNode pContextNode, [In, Out] ref ushort pwchUri, [In, Out] ref int pcchUri);
}
