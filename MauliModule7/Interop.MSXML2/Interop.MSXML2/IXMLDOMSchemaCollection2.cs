// Decompiled with JetBrains decompiler
// Type: MSXML2.IXMLDOMSchemaCollection2
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace MSXML2;

[Guid("50EA08B0-DD1B-4664-9A50-C2F40F4BD79A")]
[TypeLibType(4288)]
[ComImport]
public interface IXMLDOMSchemaCollection2 : IXMLDOMSchemaCollection
{
  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void add([MarshalAs(UnmanagedType.BStr), In] string namespaceURI, [MarshalAs(UnmanagedType.Struct), In] object var);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  new IXMLDOMNode get([MarshalAs(UnmanagedType.BStr), In] string namespaceURI);

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void remove([MarshalAs(UnmanagedType.BStr), In] string namespaceURI);

  [DispId(6)]
  new int length { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(0)]
  [IndexerName("namespaceURI")]
  new string this[[In] int index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(8)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void addCollection([MarshalAs(UnmanagedType.Interface), In] IXMLDOMSchemaCollection otherCollection);

  [TypeLibFunc(65)]
  [DispId(-4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(1419)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void validate();

  [DispId(1420)]
  bool validateOnLoad { [DispId(1420), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1420), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1421)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ISchema getSchema([MarshalAs(UnmanagedType.BStr), In] string namespaceURI);

  [DispId(1422)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ISchemaItem getDeclaration([MarshalAs(UnmanagedType.Interface), In] IXMLDOMNode node);
}
