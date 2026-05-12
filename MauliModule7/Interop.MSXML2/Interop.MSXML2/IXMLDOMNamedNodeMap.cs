// Decompiled with JetBrains decompiler
// Type: MSXML2.IXMLDOMNamedNodeMap
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace MSXML2;

[TypeLibType(4288)]
[Guid("2933BF83-7B36-11D2-B20E-00C04F983E60")]
[ComImport]
public interface IXMLDOMNamedNodeMap : IEnumerable
{
  [DispId(83)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IXMLDOMNode getNamedItem([MarshalAs(UnmanagedType.BStr), In] string name);

  [DispId(84)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IXMLDOMNode setNamedItem([MarshalAs(UnmanagedType.Interface), In] IXMLDOMNode newItem);

  [DispId(85)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IXMLDOMNode removeNamedItem([MarshalAs(UnmanagedType.BStr), In] string name);

  [DispId(0)]
  [IndexerName("item")]
  IXMLDOMNode this[[In] int index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(74)]
  int length { [DispId(74), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(87)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IXMLDOMNode getQualifiedItem([MarshalAs(UnmanagedType.BStr), In] string baseName, [MarshalAs(UnmanagedType.BStr), In] string namespaceURI);

  [DispId(88)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IXMLDOMNode removeQualifiedItem([MarshalAs(UnmanagedType.BStr), In] string baseName, [MarshalAs(UnmanagedType.BStr), In] string namespaceURI);

  [DispId(89)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IXMLDOMNode nextNode();

  [DispId(90)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reset();

  [DispId(-4)]
  [TypeLibFunc(65)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();
}
