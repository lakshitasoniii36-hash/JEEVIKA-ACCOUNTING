// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.DocEvents_Event
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[ComVisible(false)]
[TypeLibType(16 /*0x10*/)]
[ComEventInterface(typeof (DocEvents), typeof (DocEvents_EventProvider))]
public interface DocEvents_Event
{
  event DocEvents_SelectionChangeEventHandler SelectionChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SelectionChange([In] DocEvents_SelectionChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SelectionChange([In] DocEvents_SelectionChangeEventHandler obj0);

  event DocEvents_BeforeDoubleClickEventHandler BeforeDoubleClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_BeforeDoubleClick([In] DocEvents_BeforeDoubleClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_BeforeDoubleClick([In] DocEvents_BeforeDoubleClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_BeforeRightClick([In] DocEvents_BeforeRightClickEventHandler obj0);

  event DocEvents_BeforeRightClickEventHandler BeforeRightClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_BeforeRightClick([In] DocEvents_BeforeRightClickEventHandler obj0);

  event DocEvents_ActivateEventHandler Activate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Activate([In] DocEvents_ActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Activate([In] DocEvents_ActivateEventHandler obj0);

  event DocEvents_DeactivateEventHandler Deactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Deactivate([In] DocEvents_DeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Deactivate([In] DocEvents_DeactivateEventHandler obj0);

  event DocEvents_CalculateEventHandler Calculate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Calculate([In] DocEvents_CalculateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Calculate([In] DocEvents_CalculateEventHandler obj0);

  event DocEvents_ChangeEventHandler Change;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Change([In] DocEvents_ChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Change([In] DocEvents_ChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_FollowHyperlink([In] DocEvents_FollowHyperlinkEventHandler obj0);

  event DocEvents_FollowHyperlinkEventHandler FollowHyperlink;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_FollowHyperlink([In] DocEvents_FollowHyperlinkEventHandler obj0);

  event DocEvents_PivotTableUpdateEventHandler PivotTableUpdate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_PivotTableUpdate([In] DocEvents_PivotTableUpdateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_PivotTableUpdate([In] DocEvents_PivotTableUpdateEventHandler obj0);
}
