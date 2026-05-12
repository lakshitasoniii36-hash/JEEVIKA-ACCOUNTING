// Decompiled with JetBrains decompiler
// Type: MSXML2.ISAXContentHandler
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(16 /*0x10*/)]
[InterfaceType(1)]
[Guid("1545CDFA-9E4E-4497-A8A4-2BF7D0112C44")]
[ComImport]
public interface ISAXContentHandler
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void putDocumentLocator([MarshalAs(UnmanagedType.Interface), In] ISAXLocator pLocator);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void startDocument();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void endDocument();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void startPrefixMapping([In] ref ushort pwchPrefix, [In] int cchPrefix, [In] ref ushort pwchUri, [In] int cchUri);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void endPrefixMapping([In] ref ushort pwchPrefix, [In] int cchPrefix);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void startElement(
    [In] ref ushort pwchNamespaceUri,
    [In] int cchNamespaceUri,
    [In] ref ushort pwchLocalName,
    [In] int cchLocalName,
    [In] ref ushort pwchQName,
    [In] int cchQName,
    [MarshalAs(UnmanagedType.Interface), In] ISAXAttributes pAttributes);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void endElement(
    [In] ref ushort pwchNamespaceUri,
    [In] int cchNamespaceUri,
    [In] ref ushort pwchLocalName,
    [In] int cchLocalName,
    [In] ref ushort pwchQName,
    [In] int cchQName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void characters([In] ref ushort pwchChars, [In] int cchChars);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ignorableWhitespace([In] ref ushort pwchChars, [In] int cchChars);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void processingInstruction(
    [In] ref ushort pwchTarget,
    [In] int cchTarget,
    [In] ref ushort pwchData,
    [In] int cchData);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void skippedEntity([In] ref ushort pwchName, [In] int cchName);
}
