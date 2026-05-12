// Decompiled with JetBrains decompiler
// Type: MSXML2.IVBMXNamespaceManager
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(4288)]
[Guid("C90352F5-643C-4FBC-BB23-E996EB2D51FD")]
[ComImport]
public interface IVBMXNamespaceManager
{
  [DispId(1406)]
  bool allowOverride { [DispId(1406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1407)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reset();

  [DispId(1408)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void pushContext();

  [DispId(1409)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void pushNodeContext([MarshalAs(UnmanagedType.Interface), In] IXMLDOMNode contextNode, [In] bool fDeep = true);

  [DispId(1410)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void popContext();

  [DispId(1411)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void declarePrefix([MarshalAs(UnmanagedType.BStr), In] string prefix, [MarshalAs(UnmanagedType.BStr), In] string namespaceURI);

  [DispId(1412)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IMXNamespacePrefixes getDeclaredPrefixes();

  [DispId(1413)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IMXNamespacePrefixes getPrefixes([MarshalAs(UnmanagedType.BStr), In] string namespaceURI);

  [DispId(1414)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object getURI([MarshalAs(UnmanagedType.BStr), In] string prefix);

  [DispId(1415)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object getURIFromNode([MarshalAs(UnmanagedType.BStr), In] string strPrefix, [MarshalAs(UnmanagedType.Interface), In] IXMLDOMNode contextNode);
}
