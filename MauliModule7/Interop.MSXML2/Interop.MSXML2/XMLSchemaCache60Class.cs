// Decompiled with JetBrains decompiler
// Type: MSXML2.XMLSchemaCache60Class
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace MSXML2;

[Guid("88D96A07-F192-11D4-A65F-0040963251E5")]
[TypeLibType(2)]
[ClassInterface(0)]
[ComImport]
public class XMLSchemaCache60Class : IXMLDOMSchemaCollection2, XMLSchemaCache60
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern XMLSchemaCache60Class();

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add([MarshalAs(UnmanagedType.BStr), In] string namespaceURI, [MarshalAs(UnmanagedType.Struct), In] object var);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern IXMLDOMNode get([MarshalAs(UnmanagedType.BStr), In] string namespaceURI);

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove([MarshalAs(UnmanagedType.BStr), In] string namespaceURI);

  [DispId(6)]
  public virtual extern int length { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(0)]
  [IndexerName("namespaceURI")]
  public virtual extern string this[[In] int index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(8)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void addCollection([MarshalAs(UnmanagedType.Interface), In] IXMLDOMSchemaCollection otherCollection);

  [DispId(-4)]
  [TypeLibFunc(65)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  public virtual extern IEnumerator GetEnumerator();

  [DispId(1419)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void validate();

  [DispId(1420)]
  public virtual extern bool validateOnLoad { [DispId(1420), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1420), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1421)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern ISchema getSchema([MarshalAs(UnmanagedType.BStr), In] string namespaceURI);

  [DispId(1422)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern ISchemaItem getDeclaration([MarshalAs(UnmanagedType.Interface), In] IXMLDOMNode node);
}
