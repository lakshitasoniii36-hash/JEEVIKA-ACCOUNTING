// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.CustomXMLPartClass
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[ClassInterface(0)]
[Guid("000CDB08-0000-0000-C000-000000000046")]
[ComSourceInterfaces("Microsoft.Office.Core._CustomXMLPartEvents\0\0")]
[ComImport]
public class CustomXMLPartClass : _CustomXMLPart, CustomXMLPart, _CustomXMLPartEvents_Event
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  internal extern CustomXMLPartClass();

  [DispId(1610743808 /*0x60020000*/)]
  public virtual extern object Application { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  public virtual extern int Creator { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809344 /*0x60030000*/)]
  public virtual extern object Parent { [DispId(1610809344 /*0x60030000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809345 /*0x60030001*/)]
  public virtual extern CustomXMLNode DocumentElement { [DispId(1610809345 /*0x60030001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809346 /*0x60030002*/)]
  public virtual extern string Id { [DispId(1610809346 /*0x60030002*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809347 /*0x60030003*/)]
  public virtual extern string NamespaceURI { [DispId(1610809347 /*0x60030003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809348 /*0x60030004*/)]
  public virtual extern CustomXMLSchemaCollection SchemaCollection { [DispId(1610809348 /*0x60030004*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(1610809348 /*0x60030004*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(1610809350 /*0x60030006*/)]
  public virtual extern CustomXMLPrefixMappings NamespaceManager { [DispId(1610809350 /*0x60030006*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809351 /*0x60030007*/)]
  public virtual extern string XML { [DispId(1610809351 /*0x60030007*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809352 /*0x60030008*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void AddNode(
    [MarshalAs(UnmanagedType.Interface), In] CustomXMLNode Parent,
    [MarshalAs(UnmanagedType.BStr), In] string Name = "",
    [MarshalAs(UnmanagedType.BStr), In] string NamespaceURI = "",
    [MarshalAs(UnmanagedType.Interface), In] CustomXMLNode NextSibling = null,
    [In] MsoCustomXMLNodeType NodeType = MsoCustomXMLNodeType.msoCustomXMLNodeElement,
    [MarshalAs(UnmanagedType.BStr), In] string NodeValue = "");

  [DispId(1610809353 /*0x60030009*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Delete();

  [DispId(1610809354 /*0x6003000A*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool Load([MarshalAs(UnmanagedType.BStr), In] string FilePath);

  [DispId(1610809355 /*0x6003000B*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool LoadXML([MarshalAs(UnmanagedType.BStr), In] string XML);

  [DispId(1610809356 /*0x6003000C*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CustomXMLNodes SelectNodes([MarshalAs(UnmanagedType.BStr), In] string XPath);

  [DispId(1610809357 /*0x6003000D*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CustomXMLNode SelectSingleNode([MarshalAs(UnmanagedType.BStr), In] string XPath);

  [DispId(1610809358 /*0x6003000E*/)]
  public virtual extern CustomXMLValidationErrors Errors { [DispId(1610809358 /*0x6003000E*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809359 /*0x6003000F*/)]
  public virtual extern bool BuiltIn { [DispId(1610809359 /*0x6003000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_NodeAfterInsert(
    [In] _CustomXMLPartEvents_NodeAfterInsertEventHandler obj0);

  public virtual extern event _CustomXMLPartEvents_NodeAfterInsertEventHandler NodeAfterInsert;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_NodeAfterInsert(
    [In] _CustomXMLPartEvents_NodeAfterInsertEventHandler obj0);

  public virtual extern event _CustomXMLPartEvents_NodeAfterDeleteEventHandler NodeAfterDelete;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_NodeAfterDelete(
    [In] _CustomXMLPartEvents_NodeAfterDeleteEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_NodeAfterDelete(
    [In] _CustomXMLPartEvents_NodeAfterDeleteEventHandler obj0);

  public virtual extern event _CustomXMLPartEvents_NodeAfterReplaceEventHandler NodeAfterReplace;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_NodeAfterReplace(
    [In] _CustomXMLPartEvents_NodeAfterReplaceEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_NodeAfterReplace(
    [In] _CustomXMLPartEvents_NodeAfterReplaceEventHandler obj0);
}
