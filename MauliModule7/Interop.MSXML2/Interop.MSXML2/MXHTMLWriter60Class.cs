// Decompiled with JetBrains decompiler
// Type: MSXML2.MXHTMLWriter60Class
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("88D96A10-F192-11D4-A65F-0040963251E5")]
[TypeLibType(2)]
[ClassInterface(0)]
[ComImport]
public class MXHTMLWriter60Class : 
  IMXWriter,
  MXHTMLWriter60,
  ISAXContentHandler,
  ISAXDeclHandler,
  ISAXDTDHandler,
  ISAXErrorHandler,
  ISAXLexicalHandler,
  IVBSAXContentHandler,
  IVBSAXDeclHandler,
  IVBSAXDTDHandler,
  IVBSAXErrorHandler,
  IVBSAXLexicalHandler
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern MXHTMLWriter60Class();

  [DispId(1385)]
  public virtual extern object output { [DispId(1385), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; [DispId(1385), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1387)]
  public virtual extern string encoding { [DispId(1387), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; [DispId(1387), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1388)]
  public virtual extern bool byteOrderMark { [DispId(1388), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1388), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1389)]
  public virtual extern bool indent { [DispId(1389), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1389), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1390)]
  public virtual extern bool standalone { [DispId(1390), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1390), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1391)]
  public virtual extern bool omitXMLDeclaration { [DispId(1391), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1391), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1392)]
  public virtual extern string version { [DispId(1392), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; [DispId(1392), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1393)]
  public virtual extern bool disableOutputEscaping { [DispId(1393), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1393), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1394)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void flush();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void putDocumentLocator([MarshalAs(UnmanagedType.Interface), In] ISAXLocator pLocator);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void startDocument();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void endDocument();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void startPrefixMapping(
    [In] ref ushort pwchPrefix,
    [In] int cchPrefix,
    [In] ref ushort pwchUri,
    [In] int cchUri);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void endPrefixMapping([In] ref ushort pwchPrefix, [In] int cchPrefix);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void startElement(
    [In] ref ushort pwchNamespaceUri,
    [In] int cchNamespaceUri,
    [In] ref ushort pwchLocalName,
    [In] int cchLocalName,
    [In] ref ushort pwchQName,
    [In] int cchQName,
    [MarshalAs(UnmanagedType.Interface), In] ISAXAttributes pAttributes);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void endElement(
    [In] ref ushort pwchNamespaceUri,
    [In] int cchNamespaceUri,
    [In] ref ushort pwchLocalName,
    [In] int cchLocalName,
    [In] ref ushort pwchQName,
    [In] int cchQName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void characters([In] ref ushort pwchChars, [In] int cchChars);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ignorableWhitespace([In] ref ushort pwchChars, [In] int cchChars);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void processingInstruction(
    [In] ref ushort pwchTarget,
    [In] int cchTarget,
    [In] ref ushort pwchData,
    [In] int cchData);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void skippedEntity([In] ref ushort pwchName, [In] int cchName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void elementDecl(
    [In] ref ushort pwchName,
    [In] int cchName,
    [In] ref ushort pwchModel,
    [In] int cchModel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void attributeDecl(
    [In] ref ushort pwchElementName,
    [In] int cchElementName,
    [In] ref ushort pwchAttributeName,
    [In] int cchAttributeName,
    [In] ref ushort pwchType,
    [In] int cchType,
    [In] ref ushort pwchValueDefault,
    [In] int cchValueDefault,
    [In] ref ushort pwchValue,
    [In] int cchValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void internalEntityDecl(
    [In] ref ushort pwchName,
    [In] int cchName,
    [In] ref ushort pwchValue,
    [In] int cchValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void externalEntityDecl(
    [In] ref ushort pwchName,
    [In] int cchName,
    [In] ref ushort pwchPublicId,
    [In] int cchPublicId,
    [In] ref ushort pwchSystemId,
    [In] int cchSystemId);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void notationDecl(
    [In] ref ushort pwchName,
    [In] int cchName,
    [In] ref ushort pwchPublicId,
    [In] int cchPublicId,
    [In] ref ushort pwchSystemId,
    [In] int cchSystemId);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void unparsedEntityDecl(
    [In] ref ushort pwchName,
    [In] int cchName,
    [In] ref ushort pwchPublicId,
    [In] int cchPublicId,
    [In] ref ushort pwchSystemId,
    [In] int cchSystemId,
    [In] ref ushort pwchNotationName,
    [In] int cchNotationName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void error(
    [MarshalAs(UnmanagedType.Interface), In] ISAXLocator pLocator,
    [In] ref ushort pwchErrorMessage,
    [MarshalAs(UnmanagedType.Error), In] int hrErrorCode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void fatalError(
    [MarshalAs(UnmanagedType.Interface), In] ISAXLocator pLocator,
    [In] ref ushort pwchErrorMessage,
    [MarshalAs(UnmanagedType.Error), In] int hrErrorCode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ignorableWarning(
    [MarshalAs(UnmanagedType.Interface), In] ISAXLocator pLocator,
    [In] ref ushort pwchErrorMessage,
    [MarshalAs(UnmanagedType.Error), In] int hrErrorCode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void startDTD(
    [In] ref ushort pwchName,
    [In] int cchName,
    [In] ref ushort pwchPublicId,
    [In] int cchPublicId,
    [In] ref ushort pwchSystemId,
    [In] int cchSystemId);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void endDTD();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void startEntity([In] ref ushort pwchName, [In] int cchName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void endEntity([In] ref ushort pwchName, [In] int cchName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void startCDATA();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void endCDATA();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void comment([In] ref ushort pwchChars, [In] int cchChars);

  public virtual extern IVBSAXLocator documentLocator { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void IVBSAXContentHandler_startDocument();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void IVBSAXContentHandler_endDocument();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void startPrefixMapping([MarshalAs(UnmanagedType.BStr), In, Out] ref string strPrefix, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strURI);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void endPrefixMapping([MarshalAs(UnmanagedType.BStr), In, Out] ref string strPrefix);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void startElement(
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strNamespaceURI,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strLocalName,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strQName,
    [MarshalAs(UnmanagedType.Interface), In] IVBSAXAttributes oAttributes);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void endElement(
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strNamespaceURI,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strLocalName,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strQName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void characters([MarshalAs(UnmanagedType.BStr), In, Out] ref string strChars);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ignorableWhitespace([MarshalAs(UnmanagedType.BStr), In, Out] ref string strChars);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void processingInstruction([MarshalAs(UnmanagedType.BStr), In, Out] ref string strTarget, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strData);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void skippedEntity([MarshalAs(UnmanagedType.BStr), In, Out] ref string strName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void elementDecl([MarshalAs(UnmanagedType.BStr), In, Out] ref string strName, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strModel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void attributeDecl(
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strElementName,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strAttributeName,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strType,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strValueDefault,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void internalEntityDecl([MarshalAs(UnmanagedType.BStr), In, Out] ref string strName, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void externalEntityDecl(
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strName,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strPublicId,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strSystemId);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void notationDecl(
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strName,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strPublicId,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strSystemId);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void unparsedEntityDecl(
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strName,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strPublicId,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strSystemId,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strNotationName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void error(
    [MarshalAs(UnmanagedType.Interface), In] IVBSAXLocator oLocator,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strErrorMessage,
    [In] int nErrorCode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void fatalError(
    [MarshalAs(UnmanagedType.Interface), In] IVBSAXLocator oLocator,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strErrorMessage,
    [In] int nErrorCode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ignorableWarning(
    [MarshalAs(UnmanagedType.Interface), In] IVBSAXLocator oLocator,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strErrorMessage,
    [In] int nErrorCode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void startDTD(
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strName,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strPublicId,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strSystemId);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void IVBSAXLexicalHandler_endDTD();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void startEntity([MarshalAs(UnmanagedType.BStr), In, Out] ref string strName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void endEntity([MarshalAs(UnmanagedType.BStr), In, Out] ref string strName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void IVBSAXLexicalHandler_startCDATA();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void IVBSAXLexicalHandler_endCDATA();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void comment([MarshalAs(UnmanagedType.BStr), In, Out] ref string strChars);
}
