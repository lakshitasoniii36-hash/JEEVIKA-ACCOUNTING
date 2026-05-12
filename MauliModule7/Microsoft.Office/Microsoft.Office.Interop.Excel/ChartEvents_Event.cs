// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.ChartEvents_Event
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(16 /*0x10*/)]
[ComVisible(false)]
[ComEventInterface(typeof (ChartEvents), typeof (ChartEvents_EventProvider))]
public interface ChartEvents_Event
{
  event ChartEvents_ActivateEventHandler Activate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Activate([In] ChartEvents_ActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Activate([In] ChartEvents_ActivateEventHandler obj0);

  event ChartEvents_DeactivateEventHandler Deactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Deactivate([In] ChartEvents_DeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Deactivate([In] ChartEvents_DeactivateEventHandler obj0);

  event ChartEvents_ResizeEventHandler Resize;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Resize([In] ChartEvents_ResizeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Resize([In] ChartEvents_ResizeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MouseDown([In] ChartEvents_MouseDownEventHandler obj0);

  event ChartEvents_MouseDownEventHandler MouseDown;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MouseDown([In] ChartEvents_MouseDownEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MouseUp([In] ChartEvents_MouseUpEventHandler obj0);

  event ChartEvents_MouseUpEventHandler MouseUp;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MouseUp([In] ChartEvents_MouseUpEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MouseMove([In] ChartEvents_MouseMoveEventHandler obj0);

  event ChartEvents_MouseMoveEventHandler MouseMove;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MouseMove([In] ChartEvents_MouseMoveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_BeforeRightClick([In] ChartEvents_BeforeRightClickEventHandler obj0);

  event ChartEvents_BeforeRightClickEventHandler BeforeRightClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_BeforeRightClick([In] ChartEvents_BeforeRightClickEventHandler obj0);

  event ChartEvents_DragPlotEventHandler DragPlot;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DragPlot([In] ChartEvents_DragPlotEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DragPlot([In] ChartEvents_DragPlotEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DragOver([In] ChartEvents_DragOverEventHandler obj0);

  event ChartEvents_DragOverEventHandler DragOver;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DragOver([In] ChartEvents_DragOverEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_BeforeDoubleClick([In] ChartEvents_BeforeDoubleClickEventHandler obj0);

  event ChartEvents_BeforeDoubleClickEventHandler BeforeDoubleClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_BeforeDoubleClick([In] ChartEvents_BeforeDoubleClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Select([In] ChartEvents_SelectEventHandler obj0);

  event ChartEvents_SelectEventHandler Select;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Select([In] ChartEvents_SelectEventHandler obj0);

  event ChartEvents_SeriesChangeEventHandler SeriesChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SeriesChange([In] ChartEvents_SeriesChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SeriesChange([In] ChartEvents_SeriesChangeEventHandler obj0);

  event ChartEvents_CalculateEventHandler Calculate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Calculate([In] ChartEvents_CalculateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Calculate([In] ChartEvents_CalculateEventHandler obj0);
}
