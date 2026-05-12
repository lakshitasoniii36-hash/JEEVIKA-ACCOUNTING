// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core._CustomXMLPartsEvents_Event
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(16 /*0x10*/)]
[ComVisible(false)]
[ComEventInterface(typeof (_CustomXMLPartsEvents), typeof (_CustomXMLPartsEvents_EventProvider))]
public interface _CustomXMLPartsEvents_Event
{
  event _CustomXMLPartsEvents_PartAfterAddEventHandler PartAfterAdd;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_PartAfterAdd(
    [In] _CustomXMLPartsEvents_PartAfterAddEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_PartAfterAdd(
    [In] _CustomXMLPartsEvents_PartAfterAddEventHandler obj0);

  event _CustomXMLPartsEvents_PartBeforeDeleteEventHandler PartBeforeDelete;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_PartBeforeDelete(
    [In] _CustomXMLPartsEvents_PartBeforeDeleteEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_PartBeforeDelete(
    [In] _CustomXMLPartsEvents_PartBeforeDeleteEventHandler obj0);

  event _CustomXMLPartsEvents_PartAfterLoadEventHandler PartAfterLoad;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_PartAfterLoad(
    [In] _CustomXMLPartsEvents_PartAfterLoadEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_PartAfterLoad(
    [In] _CustomXMLPartsEvents_PartAfterLoadEventHandler obj0);
}
