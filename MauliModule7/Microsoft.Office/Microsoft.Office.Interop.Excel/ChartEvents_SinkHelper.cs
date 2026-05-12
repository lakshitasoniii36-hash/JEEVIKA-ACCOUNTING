// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.ChartEvents_SinkHelper
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[ClassInterface(ClassInterfaceType.None)]
public sealed class ChartEvents_SinkHelper : ChartEvents
{
  public ChartEvents_CalculateEventHandler m_CalculateDelegate;
  public ChartEvents_SeriesChangeEventHandler m_SeriesChangeDelegate;
  public ChartEvents_SelectEventHandler m_SelectDelegate;
  public ChartEvents_BeforeDoubleClickEventHandler m_BeforeDoubleClickDelegate;
  public ChartEvents_DragOverEventHandler m_DragOverDelegate;
  public ChartEvents_DragPlotEventHandler m_DragPlotDelegate;
  public ChartEvents_BeforeRightClickEventHandler m_BeforeRightClickDelegate;
  public ChartEvents_MouseMoveEventHandler m_MouseMoveDelegate;
  public ChartEvents_MouseUpEventHandler m_MouseUpDelegate;
  public ChartEvents_MouseDownEventHandler m_MouseDownDelegate;
  public ChartEvents_ResizeEventHandler m_ResizeDelegate;
  public ChartEvents_DeactivateEventHandler m_DeactivateDelegate;
  public ChartEvents_ActivateEventHandler m_ActivateDelegate;
  public int m_dwCookie;

  public virtual void Calculate()
  {
    if (this.m_CalculateDelegate == null)
      return;
    this.m_CalculateDelegate();
  }

  public virtual void SeriesChange([In] int obj0, [In] int obj1)
  {
    if (this.m_SeriesChangeDelegate == null)
      return;
    this.m_SeriesChangeDelegate(obj0, obj1);
  }

  public virtual void Select([In] int obj0, [In] int obj1, [In] int obj2)
  {
    if (this.m_SelectDelegate == null)
      return;
    this.m_SelectDelegate(obj0, obj1, obj2);
  }

  public virtual void BeforeDoubleClick([In] int obj0, [In] int obj1, [In] int obj2, [In] ref bool obj3)
  {
    if (this.m_BeforeDoubleClickDelegate == null)
      return;
    this.m_BeforeDoubleClickDelegate(obj0, obj1, obj2, ref obj3);
  }

  public virtual void DragOver()
  {
    if (this.m_DragOverDelegate == null)
      return;
    this.m_DragOverDelegate();
  }

  public virtual void DragPlot()
  {
    if (this.m_DragPlotDelegate == null)
      return;
    this.m_DragPlotDelegate();
  }

  public virtual void BeforeRightClick([In] ref bool obj0)
  {
    if (this.m_BeforeRightClickDelegate == null)
      return;
    this.m_BeforeRightClickDelegate(ref obj0);
  }

  public virtual void MouseMove([In] int obj0, [In] int obj1, [In] int obj2, [In] int obj3)
  {
    if (this.m_MouseMoveDelegate == null)
      return;
    this.m_MouseMoveDelegate(obj0, obj1, obj2, obj3);
  }

  public virtual void MouseUp([In] int obj0, [In] int obj1, [In] int obj2, [In] int obj3)
  {
    if (this.m_MouseUpDelegate == null)
      return;
    this.m_MouseUpDelegate(obj0, obj1, obj2, obj3);
  }

  public virtual void MouseDown([In] int obj0, [In] int obj1, [In] int obj2, [In] int obj3)
  {
    if (this.m_MouseDownDelegate == null)
      return;
    this.m_MouseDownDelegate(obj0, obj1, obj2, obj3);
  }

  public virtual void Resize()
  {
    if (this.m_ResizeDelegate == null)
      return;
    this.m_ResizeDelegate();
  }

  public virtual void Deactivate()
  {
    if (this.m_DeactivateDelegate == null)
      return;
    this.m_DeactivateDelegate();
  }

  public virtual void Activate()
  {
    if (this.m_ActivateDelegate == null)
      return;
    this.m_ActivateDelegate();
  }

  internal ChartEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_CalculateDelegate = (ChartEvents_CalculateEventHandler) null;
    this.m_SeriesChangeDelegate = (ChartEvents_SeriesChangeEventHandler) null;
    this.m_SelectDelegate = (ChartEvents_SelectEventHandler) null;
    this.m_BeforeDoubleClickDelegate = (ChartEvents_BeforeDoubleClickEventHandler) null;
    this.m_DragOverDelegate = (ChartEvents_DragOverEventHandler) null;
    this.m_DragPlotDelegate = (ChartEvents_DragPlotEventHandler) null;
    this.m_BeforeRightClickDelegate = (ChartEvents_BeforeRightClickEventHandler) null;
    this.m_MouseMoveDelegate = (ChartEvents_MouseMoveEventHandler) null;
    this.m_MouseUpDelegate = (ChartEvents_MouseUpEventHandler) null;
    this.m_MouseDownDelegate = (ChartEvents_MouseDownEventHandler) null;
    this.m_ResizeDelegate = (ChartEvents_ResizeEventHandler) null;
    this.m_DeactivateDelegate = (ChartEvents_DeactivateEventHandler) null;
    this.m_ActivateDelegate = (ChartEvents_ActivateEventHandler) null;
  }
}
