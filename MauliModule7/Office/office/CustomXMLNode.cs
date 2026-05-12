// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.CustomXMLNode
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[Guid("000CDB04-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
[ComImport]
public interface CustomXMLNode : _IMsoDispObj
{
  [DispId(1610743808 /*0x60020000*/)]
  new object Application { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  new int Creator { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809344 /*0x60030000*/)]
  object Parent { [DispId(1610809344 /*0x60030000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809345 /*0x60030001*/)]
  CustomXMLNodes Attributes { [DispId(1610809345 /*0x60030001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809346 /*0x60030002*/)]
  string BaseName { [DispId(1610809346 /*0x60030002*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809347 /*0x60030003*/)]
  CustomXMLNodes ChildNodes { [DispId(1610809347 /*0x60030003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809348 /*0x60030004*/)]
  CustomXMLNode FirstChild { [DispId(1610809348 /*0x60030004*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809349 /*0x60030005*/)]
  CustomXMLNode LastChild { [DispId(1610809349 /*0x60030005*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809350 /*0x60030006*/)]
  string NamespaceURI { [DispId(1610809350 /*0x60030006*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809351 /*0x60030007*/)]
  CustomXMLNode NextSibling { [DispId(1610809351 /*0x60030007*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809352 /*0x60030008*/)]
  MsoCustomXMLNodeType NodeType { [DispId(1610809352 /*0x60030008*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809353 /*0x60030009*/)]
  string NodeValue { [DispId(1610809353 /*0x60030009*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610809353 /*0x60030009*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610809355 /*0x6003000B*/)]
  object OwnerDocument { [DispId(1610809355 /*0x6003000B*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809356 /*0x6003000C*/)]
  CustomXMLPart OwnerPart { [DispId(1610809356 /*0x6003000C*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809357 /*0x6003000D*/)]
  CustomXMLNode PreviousSibling { [DispId(1610809357 /*0x6003000D*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809358 /*0x6003000E*/)]
  CustomXMLNode ParentNode { [DispId(1610809358 /*0x6003000E*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809359 /*0x6003000F*/)]
  string Text { [DispId(1610809359 /*0x6003000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610809359 /*0x6003000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610809361)]
  string XPath { [DispId(1610809361), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809362)]
  string XML { [DispId(1610809362), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809363)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AppendChildNode(
    [MarshalAs(UnmanagedType.BStr), In] string Name = "",
    [MarshalAs(UnmanagedType.BStr), In] string NamespaceURI = "",
    [In] MsoCustomXMLNodeType NodeType = MsoCustomXMLNodeType.msoCustomXMLNodeElement,
    [MarshalAs(UnmanagedType.BStr), In] string NodeValue = "");

  [DispId(1610809364)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AppendChildSubtree([MarshalAs(UnmanagedType.BStr), In] string XML);

  [DispId(1610809365)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Delete();

  [DispId(1610809366)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool HasChildNodes();

  [DispId(1610809367)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertNodeBefore(
    [MarshalAs(UnmanagedType.BStr), In] string Name = "",
    [MarshalAs(UnmanagedType.BStr), In] string NamespaceURI = "",
    [In] MsoCustomXMLNodeType NodeType = MsoCustomXMLNodeType.msoCustomXMLNodeElement,
    [MarshalAs(UnmanagedType.BStr), In] string NodeValue = "",
    [MarshalAs(UnmanagedType.Interface), In] CustomXMLNode NextSibling = null);

  [DispId(1610809368)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertSubtreeBefore([MarshalAs(UnmanagedType.BStr), In] string XML, [MarshalAs(UnmanagedType.Interface), In] CustomXMLNode NextSibling = null);

  [DispId(1610809369)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveChild([MarshalAs(UnmanagedType.Interface), In] CustomXMLNode Child);

  [DispId(1610809370)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ReplaceChildNode(
    [MarshalAs(UnmanagedType.Interface), In] CustomXMLNode OldNode,
    [MarshalAs(UnmanagedType.BStr), In] string Name = "",
    [MarshalAs(UnmanagedType.BStr), In] string NamespaceURI = "",
    [In] MsoCustomXMLNodeType NodeType = MsoCustomXMLNodeType.msoCustomXMLNodeElement,
    [MarshalAs(UnmanagedType.BStr), In] string NodeValue = "");

  [DispId(1610809371)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ReplaceChildSubtree([MarshalAs(UnmanagedType.BStr), In] string XML, [MarshalAs(UnmanagedType.Interface), In] CustomXMLNode OldNode);

  [DispId(1610809372)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CustomXMLNodes SelectNodes([MarshalAs(UnmanagedType.BStr), In] string XPath);

  [DispId(1610809373)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CustomXMLNode SelectSingleNode([MarshalAs(UnmanagedType.BStr), In] string XPath);
}
