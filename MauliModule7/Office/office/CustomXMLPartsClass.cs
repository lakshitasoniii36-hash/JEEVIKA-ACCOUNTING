// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.CustomXMLPartsClass
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Core;

[ComSourceInterfaces("Microsoft.Office.Core._CustomXMLPartsEvents\0\0")]
[Guid("000CDB0C-0000-0000-C000-000000000046")]
[ClassInterface(0)]
[ComImport]
public class CustomXMLPartsClass : 
  _CustomXMLParts,
  CustomXMLParts,
  _CustomXMLPartsEvents_Event,
  IEnumerable
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  internal extern CustomXMLPartsClass();

  [DispId(1610743808 /*0x60020000*/)]
  public virtual extern object Application { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  public virtual extern int Creator { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809344 /*0x60030000*/)]
  public virtual extern object Parent { [DispId(1610809344 /*0x60030000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809345 /*0x60030001*/)]
  public virtual extern int Count { [DispId(1610809345 /*0x60030001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(0)]
  public virtual extern CustomXMLPart this[[MarshalAs(UnmanagedType.Struct), In] object Index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809347 /*0x60030003*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CustomXMLPart Add([MarshalAs(UnmanagedType.BStr), In] string XML = "", [MarshalAs(UnmanagedType.Struct), In, Optional] object SchemaCollection);

  [DispId(1610809348 /*0x60030004*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CustomXMLPart SelectByID([MarshalAs(UnmanagedType.BStr), In] string Id);

  [DispId(1610809349 /*0x60030005*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CustomXMLParts SelectByNamespace([MarshalAs(UnmanagedType.BStr), In] string NamespaceURI);

  [DispId(-4)]
  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  public virtual extern IEnumerator GetEnumerator();

  public virtual extern event _CustomXMLPartsEvents_PartAfterAddEventHandler PartAfterAdd;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_PartAfterAdd(
    [In] _CustomXMLPartsEvents_PartAfterAddEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_PartAfterAdd(
    [In] _CustomXMLPartsEvents_PartAfterAddEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_PartBeforeDelete(
    [In] _CustomXMLPartsEvents_PartBeforeDeleteEventHandler obj0);

  public virtual extern event _CustomXMLPartsEvents_PartBeforeDeleteEventHandler PartBeforeDelete;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_PartBeforeDelete(
    [In] _CustomXMLPartsEvents_PartBeforeDeleteEventHandler obj0);

  public virtual extern event _CustomXMLPartsEvents_PartAfterLoadEventHandler PartAfterLoad;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_PartAfterLoad(
    [In] _CustomXMLPartsEvents_PartAfterLoadEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_PartAfterLoad(
    [In] _CustomXMLPartsEvents_PartAfterLoadEventHandler obj0);
}
