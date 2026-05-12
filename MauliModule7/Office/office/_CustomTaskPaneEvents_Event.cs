// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core._CustomTaskPaneEvents_Event
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[ComEventInterface(typeof (_CustomTaskPaneEvents), typeof (_CustomTaskPaneEvents_EventProvider))]
[TypeLibType(16 /*0x10*/)]
[ComVisible(false)]
public interface _CustomTaskPaneEvents_Event
{
  event _CustomTaskPaneEvents_VisibleStateChangeEventHandler VisibleStateChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_VisibleStateChange(
    [In] _CustomTaskPaneEvents_VisibleStateChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_VisibleStateChange(
    [In] _CustomTaskPaneEvents_VisibleStateChangeEventHandler obj0);

  event _CustomTaskPaneEvents_DockPositionStateChangeEventHandler DockPositionStateChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DockPositionStateChange(
    [In] _CustomTaskPaneEvents_DockPositionStateChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DockPositionStateChange(
    [In] _CustomTaskPaneEvents_DockPositionStateChangeEventHandler obj0);
}
