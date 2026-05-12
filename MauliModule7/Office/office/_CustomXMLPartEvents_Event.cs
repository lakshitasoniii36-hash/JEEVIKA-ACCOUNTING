// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core._CustomXMLPartEvents_Event
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[ComVisible(false)]
[ComEventInterface(typeof (_CustomXMLPartEvents), typeof (_CustomXMLPartEvents_EventProvider))]
[TypeLibType(16 /*0x10*/)]
public interface _CustomXMLPartEvents_Event
{
  event _CustomXMLPartEvents_NodeAfterInsertEventHandler NodeAfterInsert;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_NodeAfterInsert(
    [In] _CustomXMLPartEvents_NodeAfterInsertEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_NodeAfterInsert(
    [In] _CustomXMLPartEvents_NodeAfterInsertEventHandler obj0);

  event _CustomXMLPartEvents_NodeAfterDeleteEventHandler NodeAfterDelete;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_NodeAfterDelete(
    [In] _CustomXMLPartEvents_NodeAfterDeleteEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_NodeAfterDelete(
    [In] _CustomXMLPartEvents_NodeAfterDeleteEventHandler obj0);

  event _CustomXMLPartEvents_NodeAfterReplaceEventHandler NodeAfterReplace;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_NodeAfterReplace(
    [In] _CustomXMLPartEvents_NodeAfterReplaceEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_NodeAfterReplace(
    [In] _CustomXMLPartEvents_NodeAfterReplaceEventHandler obj0);
}
