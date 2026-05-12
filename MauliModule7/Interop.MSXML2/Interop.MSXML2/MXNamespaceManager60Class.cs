// Decompiled with JetBrains decompiler
// Type: MSXML2.MXNamespaceManager60Class
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(2)]
[ClassInterface(0)]
[Guid("88D96A11-F192-11D4-A65F-0040963251E5")]
[ComImport]
public class MXNamespaceManager60Class : 
  IVBMXNamespaceManager,
  MXNamespaceManager60,
  IMXNamespaceManager
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern MXNamespaceManager60Class();

  [DispId(1406)]
  public virtual extern bool allowOverride { [DispId(1406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1407)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reset();

  [DispId(1408)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void pushContext();

  [DispId(1409)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void pushNodeContext([MarshalAs(UnmanagedType.Interface), In] IXMLDOMNode contextNode, [In] bool fDeep = true);

  [DispId(1410)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void popContext();

  [DispId(1411)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void declarePrefix([MarshalAs(UnmanagedType.BStr), In] string prefix, [MarshalAs(UnmanagedType.BStr), In] string namespaceURI);

  [DispId(1412)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern IMXNamespacePrefixes getDeclaredPrefixes();

  [DispId(1413)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern IMXNamespacePrefixes getPrefixes([MarshalAs(UnmanagedType.BStr), In] string namespaceURI);

  [DispId(1414)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object getURI([MarshalAs(UnmanagedType.BStr), In] string prefix);

  [DispId(1415)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object getURIFromNode([MarshalAs(UnmanagedType.BStr), In] string strPrefix, [MarshalAs(UnmanagedType.Interface), In] IXMLDOMNode contextNode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void putAllowOverride([In] bool fOverride);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool getAllowOverride();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void IMXNamespaceManager_reset();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void IMXNamespaceManager_pushContext();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void IMXNamespaceManager_pushNodeContext(
    [MarshalAs(UnmanagedType.Interface), In] IXMLDOMNode contextNode,
    [In] bool fDeep);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void IMXNamespaceManager_popContext();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void IMXNamespaceManager_declarePrefix([MarshalAs(UnmanagedType.LPWStr), In] string prefix, [MarshalAs(UnmanagedType.LPWStr), In] string namespaceURI);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getDeclaredPrefix(
    [In] int nIndex,
    [In, Out] ref ushort pwchPrefix,
    [In, Out] ref int pcchPrefix);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getPrefix(
    [MarshalAs(UnmanagedType.LPWStr), In] string pwszNamespaceURI,
    [In] int nIndex,
    [In, Out] ref ushort pwchPrefix,
    [In, Out] ref int pcchPrefix);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getURI(
    [MarshalAs(UnmanagedType.LPWStr), In] string pwchPrefix,
    [MarshalAs(UnmanagedType.Interface), In] IXMLDOMNode pContextNode,
    [In, Out] ref ushort pwchUri,
    [In, Out] ref int pcchUri);
}
