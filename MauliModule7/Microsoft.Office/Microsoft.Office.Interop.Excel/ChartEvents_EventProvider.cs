// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.ChartEvents_EventProvider
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

internal sealed class ChartEvents_EventProvider : ChartEvents_Event, IDisposable
{
  private UCOMIConnectionPointContainer m_ConnectionPointContainer;
  private ArrayList m_aEventSinkHelpers;
  private UCOMIConnectionPoint m_ConnectionPoint;

  private void Init()
  {
    UCOMIConnectionPoint ppCP = (UCOMIConnectionPoint) null;
    Guid riid = new Guid(new byte[16 /*0x10*/]
    {
      (byte) 15,
      (byte) 68,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 192 /*0xC0*/,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 70
    });
    this.m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
    this.m_ConnectionPoint = ppCP;
    this.m_aEventSinkHelpers = new ArrayList();
  }

  public virtual void add_Calculate([In] ChartEvents_CalculateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      ChartEvents_SinkHelper pUnkSink = new ChartEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_CalculateDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_Calculate([In] ChartEvents_CalculateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        ChartEvents_SinkHelper aEventSinkHelper = (ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_CalculateDelegate != null && ((aEventSinkHelper.m_CalculateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void add_SeriesChange([In] ChartEvents_SeriesChangeEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      ChartEvents_SinkHelper pUnkSink = new ChartEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_SeriesChangeDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_SeriesChange([In] ChartEvents_SeriesChangeEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        ChartEvents_SinkHelper aEventSinkHelper = (ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_SeriesChangeDelegate != null && ((aEventSinkHelper.m_SeriesChangeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void add_Select([In] ChartEvents_SelectEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      ChartEvents_SinkHelper pUnkSink = new ChartEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_SelectDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_Select([In] ChartEvents_SelectEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        ChartEvents_SinkHelper aEventSinkHelper = (ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_SelectDelegate != null && ((aEventSinkHelper.m_SelectDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void add_BeforeDoubleClick([In] ChartEvents_BeforeDoubleClickEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      ChartEvents_SinkHelper pUnkSink = new ChartEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_BeforeDoubleClickDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_BeforeDoubleClick([In] ChartEvents_BeforeDoubleClickEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        ChartEvents_SinkHelper aEventSinkHelper = (ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_BeforeDoubleClickDelegate != null && ((aEventSinkHelper.m_BeforeDoubleClickDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void add_DragOver([In] ChartEvents_DragOverEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      ChartEvents_SinkHelper pUnkSink = new ChartEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_DragOverDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_DragOver([In] ChartEvents_DragOverEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        ChartEvents_SinkHelper aEventSinkHelper = (ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_DragOverDelegate != null && ((aEventSinkHelper.m_DragOverDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void add_DragPlot([In] ChartEvents_DragPlotEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      ChartEvents_SinkHelper pUnkSink = new ChartEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_DragPlotDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_DragPlot([In] ChartEvents_DragPlotEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        ChartEvents_SinkHelper aEventSinkHelper = (ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_DragPlotDelegate != null && ((aEventSinkHelper.m_DragPlotDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void add_BeforeRightClick([In] ChartEvents_BeforeRightClickEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      ChartEvents_SinkHelper pUnkSink = new ChartEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_BeforeRightClickDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_BeforeRightClick([In] ChartEvents_BeforeRightClickEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        ChartEvents_SinkHelper aEventSinkHelper = (ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_BeforeRightClickDelegate != null && ((aEventSinkHelper.m_BeforeRightClickDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void add_MouseMove([In] ChartEvents_MouseMoveEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      ChartEvents_SinkHelper pUnkSink = new ChartEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_MouseMoveDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_MouseMove([In] ChartEvents_MouseMoveEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        ChartEvents_SinkHelper aEventSinkHelper = (ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_MouseMoveDelegate != null && ((aEventSinkHelper.m_MouseMoveDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void add_MouseUp([In] ChartEvents_MouseUpEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      ChartEvents_SinkHelper pUnkSink = new ChartEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_MouseUpDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_MouseUp([In] ChartEvents_MouseUpEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        ChartEvents_SinkHelper aEventSinkHelper = (ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_MouseUpDelegate != null && ((aEventSinkHelper.m_MouseUpDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void add_MouseDown([In] ChartEvents_MouseDownEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      ChartEvents_SinkHelper pUnkSink = new ChartEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_MouseDownDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_MouseDown([In] ChartEvents_MouseDownEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        ChartEvents_SinkHelper aEventSinkHelper = (ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_MouseDownDelegate != null && ((aEventSinkHelper.m_MouseDownDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void add_Resize([In] ChartEvents_ResizeEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      ChartEvents_SinkHelper pUnkSink = new ChartEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_ResizeDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_Resize([In] ChartEvents_ResizeEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        ChartEvents_SinkHelper aEventSinkHelper = (ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_ResizeDelegate != null && ((aEventSinkHelper.m_ResizeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void add_Deactivate([In] ChartEvents_DeactivateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      ChartEvents_SinkHelper pUnkSink = new ChartEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_DeactivateDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_Deactivate([In] ChartEvents_DeactivateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        ChartEvents_SinkHelper aEventSinkHelper = (ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_DeactivateDelegate != null && ((aEventSinkHelper.m_DeactivateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void add_Activate([In] ChartEvents_ActivateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      ChartEvents_SinkHelper pUnkSink = new ChartEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_ActivateDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_Activate([In] ChartEvents_ActivateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        ChartEvents_SinkHelper aEventSinkHelper = (ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_ActivateDelegate != null && ((aEventSinkHelper.m_ActivateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public ChartEvents_EventProvider([In] object obj0)
  {
    this.m_ConnectionPointContainer = (UCOMIConnectionPointContainer) obj0;
  }

  public override void Finalize()
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        return;
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 < count)
      {
        do
        {
          this.m_ConnectionPoint.Unadvise(((ChartEvents_SinkHelper) this.m_aEventSinkHelpers[index]).m_dwCookie);
          ++index;
        }
        while (index < count);
      }
      Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void Dispose()
  {
    this.Finalize();
    GC.SuppressFinalize((object) this);
  }
}
