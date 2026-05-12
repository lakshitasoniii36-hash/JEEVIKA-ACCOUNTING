// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.CustomXMLSchemaCollectionClass
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Core;

[ClassInterface(0)]
[Guid("000CDB0D-0000-0000-C000-000000000046")]
[TypeLibType(2)]
[ComImport]
public class CustomXMLSchemaCollectionClass : 
  _CustomXMLSchemaCollection,
  CustomXMLSchemaCollection,
  IEnumerable
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern CustomXMLSchemaCollectionClass();

  [DispId(1610743808 /*0x60020000*/)]
  public virtual extern object Application { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  public virtual extern int Creator { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809344 /*0x60030000*/)]
  public virtual extern object Parent { [DispId(1610809344 /*0x60030000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809345 /*0x60030001*/)]
  public virtual extern int Count { [DispId(1610809345 /*0x60030001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(0)]
  public virtual extern CustomXMLSchema this[[MarshalAs(UnmanagedType.Struct), In] object Index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809347 /*0x60030003*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string get_NamespaceURI([In] int Index);

  [DispId(1610809348 /*0x60030004*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CustomXMLSchema Add(
    [MarshalAs(UnmanagedType.BStr), In] string NamespaceURI = "",
    [MarshalAs(UnmanagedType.BStr), In] string Alias = "",
    [MarshalAs(UnmanagedType.BStr), In] string FileName = "",
    [In] bool InstallForAllUsers = false);

  [DispId(1610809349 /*0x60030005*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void AddCollection([MarshalAs(UnmanagedType.Interface), In] CustomXMLSchemaCollection SchemaCollection);

  [DispId(1610809350 /*0x60030006*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool Validate();

  [TypeLibFunc(1024 /*0x0400*/)]
  [DispId(-4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  public virtual extern IEnumerator GetEnumerator();
}
