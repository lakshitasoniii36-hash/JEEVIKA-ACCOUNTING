// Decompiled with JetBrains decompiler
// Type: MSXML2.IVBSAXContentHandler
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("2ED7290A-4DD5-4B46-BB26-4E4155E77FAA")]
[TypeLibType(4288)]
[ComImport]
public interface IVBSAXContentHandler
{
  [DispId(1322)]
  IVBSAXLocator documentLocator { [DispId(1322), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(1323)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void startDocument();

  [DispId(1324)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void endDocument();

  [DispId(1325)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void startPrefixMapping([MarshalAs(UnmanagedType.BStr), In, Out] ref string strPrefix, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strURI);

  [DispId(1326)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void endPrefixMapping([MarshalAs(UnmanagedType.BStr), In, Out] ref string strPrefix);

  [DispId(1327)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void startElement(
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strNamespaceURI,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strLocalName,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strQName,
    [MarshalAs(UnmanagedType.Interface), In] IVBSAXAttributes oAttributes);

  [DispId(1328)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void endElement([MarshalAs(UnmanagedType.BStr), In, Out] ref string strNamespaceURI, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strLocalName, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strQName);

  [DispId(1329)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void characters([MarshalAs(UnmanagedType.BStr), In, Out] ref string strChars);

  [DispId(1330)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ignorableWhitespace([MarshalAs(UnmanagedType.BStr), In, Out] ref string strChars);

  [DispId(1331)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void processingInstruction([MarshalAs(UnmanagedType.BStr), In, Out] ref string strTarget, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strData);

  [DispId(1332)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void skippedEntity([MarshalAs(UnmanagedType.BStr), In, Out] ref string strName);
}
