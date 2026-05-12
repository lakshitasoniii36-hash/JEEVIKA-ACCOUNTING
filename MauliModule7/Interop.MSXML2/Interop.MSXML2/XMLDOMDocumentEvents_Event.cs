// Decompiled with JetBrains decompiler
// Type: MSXML2.XMLDOMDocumentEvents_Event
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[ComVisible(false)]
[TypeLibType(16 /*0x10*/)]
[ComEventInterface(typeof (XMLDOMDocumentEvents), typeof (XMLDOMDocumentEvents_EventProvider))]
public interface XMLDOMDocumentEvents_Event
{
  event XMLDOMDocumentEvents_ondataavailableEventHandler ondataavailable;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_ondataavailable(
    [In] XMLDOMDocumentEvents_ondataavailableEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_ondataavailable(
    [In] XMLDOMDocumentEvents_ondataavailableEventHandler obj0);

  event XMLDOMDocumentEvents_onreadystatechangeEventHandler onreadystatechange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_onreadystatechange(
    [In] XMLDOMDocumentEvents_onreadystatechangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_onreadystatechange(
    [In] XMLDOMDocumentEvents_onreadystatechangeEventHandler obj0);
}
