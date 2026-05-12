// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.AppEvents_EventProvider
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

internal sealed class AppEvents_EventProvider : AppEvents_Event, IDisposable
{
  private UCOMIConnectionPointContainer m_ConnectionPointContainer;
  private ArrayList m_aEventSinkHelpers;
  private UCOMIConnectionPoint m_ConnectionPoint;

  private void Init()
  {
    UCOMIConnectionPoint ppCP = (UCOMIConnectionPoint) null;
    Guid riid = new Guid(new byte[16 /*0x10*/]
    {
      (byte) 19,
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

  public virtual void add_AfterCalculate([In] AppEvents_AfterCalculateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_AfterCalculateDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_AfterCalculate([In] AppEvents_AfterCalculateEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_AfterCalculateDelegate != null && ((aEventSinkHelper.m_AfterCalculateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookRowsetComplete([In] AppEvents_WorkbookRowsetCompleteEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookRowsetCompleteDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookRowsetComplete(
    [In] AppEvents_WorkbookRowsetCompleteEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookRowsetCompleteDelegate != null && ((aEventSinkHelper.m_WorkbookRowsetCompleteDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookAfterXmlExport([In] AppEvents_WorkbookAfterXmlExportEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookAfterXmlExportDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookAfterXmlExport(
    [In] AppEvents_WorkbookAfterXmlExportEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookAfterXmlExportDelegate != null && ((aEventSinkHelper.m_WorkbookAfterXmlExportDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookBeforeXmlExport([In] AppEvents_WorkbookBeforeXmlExportEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookBeforeXmlExportDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookBeforeXmlExport(
    [In] AppEvents_WorkbookBeforeXmlExportEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookBeforeXmlExportDelegate != null && ((aEventSinkHelper.m_WorkbookBeforeXmlExportDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookAfterXmlImport([In] AppEvents_WorkbookAfterXmlImportEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookAfterXmlImportDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookAfterXmlImport(
    [In] AppEvents_WorkbookAfterXmlImportEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookAfterXmlImportDelegate != null && ((aEventSinkHelper.m_WorkbookAfterXmlImportDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookBeforeXmlImport([In] AppEvents_WorkbookBeforeXmlImportEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookBeforeXmlImportDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookBeforeXmlImport(
    [In] AppEvents_WorkbookBeforeXmlImportEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookBeforeXmlImportDelegate != null && ((aEventSinkHelper.m_WorkbookBeforeXmlImportDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookSync([In] AppEvents_WorkbookSyncEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookSyncDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookSync([In] AppEvents_WorkbookSyncEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookSyncDelegate != null && ((aEventSinkHelper.m_WorkbookSyncDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookPivotTableOpenConnection(
    [In] AppEvents_WorkbookPivotTableOpenConnectionEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookPivotTableOpenConnectionDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookPivotTableOpenConnection(
    [In] AppEvents_WorkbookPivotTableOpenConnectionEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookPivotTableOpenConnectionDelegate != null && ((aEventSinkHelper.m_WorkbookPivotTableOpenConnectionDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookPivotTableCloseConnection(
    [In] AppEvents_WorkbookPivotTableCloseConnectionEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookPivotTableCloseConnectionDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookPivotTableCloseConnection(
    [In] AppEvents_WorkbookPivotTableCloseConnectionEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookPivotTableCloseConnectionDelegate != null && ((aEventSinkHelper.m_WorkbookPivotTableCloseConnectionDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_SheetPivotTableUpdate([In] AppEvents_SheetPivotTableUpdateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_SheetPivotTableUpdateDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_SheetPivotTableUpdate([In] AppEvents_SheetPivotTableUpdateEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_SheetPivotTableUpdateDelegate != null && ((aEventSinkHelper.m_SheetPivotTableUpdateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_SheetFollowHyperlink([In] AppEvents_SheetFollowHyperlinkEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_SheetFollowHyperlinkDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_SheetFollowHyperlink([In] AppEvents_SheetFollowHyperlinkEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_SheetFollowHyperlinkDelegate != null && ((aEventSinkHelper.m_SheetFollowHyperlinkDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WindowDeactivate([In] AppEvents_WindowDeactivateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WindowDeactivateDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WindowDeactivate([In] AppEvents_WindowDeactivateEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WindowDeactivateDelegate != null && ((aEventSinkHelper.m_WindowDeactivateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WindowActivate([In] AppEvents_WindowActivateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WindowActivateDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WindowActivate([In] AppEvents_WindowActivateEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WindowActivateDelegate != null && ((aEventSinkHelper.m_WindowActivateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WindowResize([In] AppEvents_WindowResizeEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WindowResizeDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WindowResize([In] AppEvents_WindowResizeEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WindowResizeDelegate != null && ((aEventSinkHelper.m_WindowResizeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookAddinUninstall([In] AppEvents_WorkbookAddinUninstallEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookAddinUninstallDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookAddinUninstall(
    [In] AppEvents_WorkbookAddinUninstallEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookAddinUninstallDelegate != null && ((aEventSinkHelper.m_WorkbookAddinUninstallDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookAddinInstall([In] AppEvents_WorkbookAddinInstallEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookAddinInstallDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookAddinInstall([In] AppEvents_WorkbookAddinInstallEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookAddinInstallDelegate != null && ((aEventSinkHelper.m_WorkbookAddinInstallDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookNewSheet([In] AppEvents_WorkbookNewSheetEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookNewSheetDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookNewSheet([In] AppEvents_WorkbookNewSheetEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookNewSheetDelegate != null && ((aEventSinkHelper.m_WorkbookNewSheetDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookBeforePrint([In] AppEvents_WorkbookBeforePrintEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookBeforePrintDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookBeforePrint([In] AppEvents_WorkbookBeforePrintEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookBeforePrintDelegate != null && ((aEventSinkHelper.m_WorkbookBeforePrintDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookBeforeSave([In] AppEvents_WorkbookBeforeSaveEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookBeforeSaveDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookBeforeSave([In] AppEvents_WorkbookBeforeSaveEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookBeforeSaveDelegate != null && ((aEventSinkHelper.m_WorkbookBeforeSaveDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookBeforeClose([In] AppEvents_WorkbookBeforeCloseEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookBeforeCloseDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookBeforeClose([In] AppEvents_WorkbookBeforeCloseEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookBeforeCloseDelegate != null && ((aEventSinkHelper.m_WorkbookBeforeCloseDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookDeactivate([In] AppEvents_WorkbookDeactivateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookDeactivateDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookDeactivate([In] AppEvents_WorkbookDeactivateEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookDeactivateDelegate != null && ((aEventSinkHelper.m_WorkbookDeactivateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookActivate([In] AppEvents_WorkbookActivateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookActivateDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookActivate([In] AppEvents_WorkbookActivateEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookActivateDelegate != null && ((aEventSinkHelper.m_WorkbookActivateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_WorkbookOpen([In] AppEvents_WorkbookOpenEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_WorkbookOpenDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_WorkbookOpen([In] AppEvents_WorkbookOpenEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_WorkbookOpenDelegate != null && ((aEventSinkHelper.m_WorkbookOpenDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_SheetChange([In] AppEvents_SheetChangeEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_SheetChangeDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_SheetChange([In] AppEvents_SheetChangeEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_SheetChangeDelegate != null && ((aEventSinkHelper.m_SheetChangeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_SheetCalculate([In] AppEvents_SheetCalculateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_SheetCalculateDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_SheetCalculate([In] AppEvents_SheetCalculateEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_SheetCalculateDelegate != null && ((aEventSinkHelper.m_SheetCalculateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_SheetDeactivate([In] AppEvents_SheetDeactivateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_SheetDeactivateDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_SheetDeactivate([In] AppEvents_SheetDeactivateEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_SheetDeactivateDelegate != null && ((aEventSinkHelper.m_SheetDeactivateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_SheetActivate([In] AppEvents_SheetActivateEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_SheetActivateDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_SheetActivate([In] AppEvents_SheetActivateEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_SheetActivateDelegate != null && ((aEventSinkHelper.m_SheetActivateDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_SheetBeforeRightClick([In] AppEvents_SheetBeforeRightClickEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_SheetBeforeRightClickDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_SheetBeforeRightClick([In] AppEvents_SheetBeforeRightClickEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_SheetBeforeRightClickDelegate != null && ((aEventSinkHelper.m_SheetBeforeRightClickDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_SheetBeforeDoubleClick([In] AppEvents_SheetBeforeDoubleClickEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_SheetBeforeDoubleClickDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_SheetBeforeDoubleClick(
    [In] AppEvents_SheetBeforeDoubleClickEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_SheetBeforeDoubleClickDelegate != null && ((aEventSinkHelper.m_SheetBeforeDoubleClickDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_SheetSelectionChange([In] AppEvents_SheetSelectionChangeEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_SheetSelectionChangeDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_SheetSelectionChange([In] AppEvents_SheetSelectionChangeEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_SheetSelectionChangeDelegate != null && ((aEventSinkHelper.m_SheetSelectionChangeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_NewWorkbook([In] AppEvents_NewWorkbookEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      AppEvents_SinkHelper pUnkSink = new AppEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_NewWorkbookDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_NewWorkbook([In] AppEvents_NewWorkbookEventHandler obj0)
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
        AppEvents_SinkHelper aEventSinkHelper = (AppEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_NewWorkbookDelegate != null && ((aEventSinkHelper.m_NewWorkbookDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public AppEvents_EventProvider([In] object obj0)
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
          this.m_ConnectionPoint.Unadvise(((AppEvents_SinkHelper) this.m_aEventSinkHelpers[index]).m_dwCookie);
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
