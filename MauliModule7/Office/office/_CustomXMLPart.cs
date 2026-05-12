// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core._CustomXMLPart
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[Guid("000CDB05-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
[ComImport]
public interface _CustomXMLPart : _IMsoDispObj
{
  [DispId(1610743808 /*0x60020000*/)]
  new object Application { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  new int Creator { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809344 /*0x60030000*/)]
  object Parent { [DispId(1610809344 /*0x60030000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809345 /*0x60030001*/)]
  CustomXMLNode DocumentElement { [DispId(1610809345 /*0x60030001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809346 /*0x60030002*/)]
  string Id { [DispId(1610809346 /*0x60030002*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809347 /*0x60030003*/)]
  string NamespaceURI { [DispId(1610809347 /*0x60030003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809348 /*0x60030004*/)]
  CustomXMLSchemaCollection SchemaCollection { [DispId(1610809348 /*0x60030004*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(1610809348 /*0x60030004*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(1610809350 /*0x60030006*/)]
  CustomXMLPrefixMappings NamespaceManager { [DispId(1610809350 /*0x60030006*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809351 /*0x60030007*/)]
  string XML { [DispId(1610809351 /*0x60030007*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809352 /*0x60030008*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddNode(
    [MarshalAs(UnmanagedType.Interface), In] CustomXMLNode Parent,
    [MarshalAs(UnmanagedType.BStr), In] string Name = "",
    [MarshalAs(UnmanagedType.BStr), In] string NamespaceURI = "",
    [MarshalAs(UnmanagedType.Interface), In] CustomXMLNode NextSibling = null,
    [In] MsoCustomXMLNodeType NodeType = MsoCustomXMLNodeType.msoCustomXMLNodeElement,
    [MarshalAs(UnmanagedType.BStr), In] string NodeValue = "");

  [DispId(1610809353 /*0x60030009*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Delete();

  [DispId(1610809354 /*0x6003000A*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Load([MarshalAs(UnmanagedType.BStr), In] string FilePath);

  [DispId(1610809355 /*0x6003000B*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool LoadXML([MarshalAs(UnmanagedType.BStr), In] string XML);

  [DispId(1610809356 /*0x6003000C*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CustomXMLNodes SelectNodes([MarshalAs(UnmanagedType.BStr), In] string XPath);

  [DispId(1610809357 /*0x6003000D*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CustomXMLNode SelectSingleNode([MarshalAs(UnmanagedType.BStr), In] string XPath);

  [DispId(1610809358 /*0x6003000E*/)]
  CustomXMLValidationErrors Errors { [DispId(1610809358 /*0x6003000E*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809359 /*0x6003000F*/)]
  bool BuiltIn { [DispId(1610809359 /*0x6003000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
}
