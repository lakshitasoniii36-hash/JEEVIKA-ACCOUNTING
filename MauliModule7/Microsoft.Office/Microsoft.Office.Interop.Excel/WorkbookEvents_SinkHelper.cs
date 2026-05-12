// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.WorkbookEvents_SinkHelper
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[ClassInterface(ClassInterfaceType.None)]
public sealed class WorkbookEvents_SinkHelper : WorkbookEvents
{
  public WorkbookEvents_RowsetCompleteEventHandler m_RowsetCompleteDelegate;
  public WorkbookEvents_AfterXmlExportEventHandler m_AfterXmlExportDelegate;
  public WorkbookEvents_BeforeXmlExportEventHandler m_BeforeXmlExportDelegate;
  public WorkbookEvents_AfterXmlImportEventHandler m_AfterXmlImportDelegate;
  public WorkbookEvents_BeforeXmlImportEventHandler m_BeforeXmlImportDelegate;
  public WorkbookEvents_SyncEventHandler m_SyncDelegate;
  public WorkbookEvents_PivotTableOpenConnectionEventHandler m_PivotTableOpenConnectionDelegate;
  public WorkbookEvents_PivotTableCloseConnectionEventHandler m_PivotTableCloseConnectionDelegate;
  public WorkbookEvents_SheetPivotTableUpdateEventHandler m_SheetPivotTableUpdateDelegate;
  public WorkbookEvents_SheetFollowHyperlinkEventHandler m_SheetFollowHyperlinkDelegate;
  public WorkbookEvents_SheetChangeEventHandler m_SheetChangeDelegate;
  public WorkbookEvents_SheetCalculateEventHandler m_SheetCalculateDelegate;
  public WorkbookEvents_SheetDeactivateEventHandler m_SheetDeactivateDelegate;
  public WorkbookEvents_SheetActivateEventHandler m_SheetActivateDelegate;
  public WorkbookEvents_SheetBeforeRightClickEventHandler m_SheetBeforeRightClickDelegate;
  public WorkbookEvents_SheetBeforeDoubleClickEventHandler m_SheetBeforeDoubleClickDelegate;
  public WorkbookEvents_SheetSelectionChangeEventHandler m_SheetSelectionChangeDelegate;
  public WorkbookEvents_WindowDeactivateEventHandler m_WindowDeactivateDelegate;
  public WorkbookEvents_WindowActivateEventHandler m_WindowActivateDelegate;
  public WorkbookEvents_WindowResizeEventHandler m_WindowResizeDelegate;
  public WorkbookEvents_AddinUninstallEventHandler m_AddinUninstallDelegate;
  public WorkbookEvents_AddinInstallEventHandler m_AddinInstallDelegate;
  public WorkbookEvents_NewSheetEventHandler m_NewSheetDelegate;
  public WorkbookEvents_BeforePrintEventHandler m_BeforePrintDelegate;
  public WorkbookEvents_BeforeSaveEventHandler m_BeforeSaveDelegate;
  public WorkbookEvents_BeforeCloseEventHandler m_BeforeCloseDelegate;
  public WorkbookEvents_DeactivateEventHandler m_DeactivateDelegate;
  public WorkbookEvents_ActivateEventHandler m_ActivateDelegate;
  public WorkbookEvents_OpenEventHandler m_OpenDelegate;
  public int m_dwCookie;

  public virtual void RowsetComplete([In] string obj0, [In] string obj1, [In] bool obj2)
  {
    if (this.m_RowsetCompleteDelegate == null)
      return;
    this.m_RowsetCompleteDelegate(obj0, obj1, obj2);
  }

  public virtual void AfterXmlExport([In] XmlMap obj0, [In] string obj1, [In] XlXmlExportResult obj2)
  {
    if (this.m_AfterXmlExportDelegate == null)
      return;
    this.m_AfterXmlExportDelegate(obj0, obj1, obj2);
  }

  public virtual void BeforeXmlExport([In] XmlMap obj0, [In] string obj1, [In] ref bool obj2)
  {
    if (this.m_BeforeXmlExportDelegate == null)
      return;
    this.m_BeforeXmlExportDelegate(obj0, obj1, ref obj2);
  }

  public virtual void AfterXmlImport([In] XmlMap obj0, [In] bool obj1, [In] XlXmlImportResult obj2)
  {
    if (this.m_AfterXmlImportDelegate == null)
      return;
    this.m_AfterXmlImportDelegate(obj0, obj1, obj2);
  }

  public virtual void BeforeXmlImport([In] XmlMap obj0, [In] string obj1, [In] bool obj2, [In] ref bool obj3)
  {
    if (this.m_BeforeXmlImportDelegate == null)
      return;
    this.m_BeforeXmlImportDelegate(obj0, obj1, obj2, ref obj3);
  }

  public virtual void Sync([In] MsoSyncEventType obj0)
  {
    if (this.m_SyncDelegate == null)
      return;
    this.m_SyncDelegate(obj0);
  }

  public virtual void PivotTableOpenConnection([In] PivotTable obj0)
  {
    if (this.m_PivotTableOpenConnectionDelegate == null)
      return;
    this.m_PivotTableOpenConnectionDelegate(obj0);
  }

  public virtual void PivotTableCloseConnection([In] PivotTable obj0)
  {
    if (this.m_PivotTableCloseConnectionDelegate == null)
      return;
    this.m_PivotTableCloseConnectionDelegate(obj0);
  }

  public virtual void SheetPivotTableUpdate([In] object obj0, [In] PivotTable obj1)
  {
    if (this.m_SheetPivotTableUpdateDelegate == null)
      return;
    this.m_SheetPivotTableUpdateDelegate(obj0, obj1);
  }

  public virtual void SheetFollowHyperlink([In] object obj0, [In] Hyperlink obj1)
  {
    if (this.m_SheetFollowHyperlinkDelegate == null)
      return;
    this.m_SheetFollowHyperlinkDelegate(obj0, obj1);
  }

  public virtual void SheetChange([In] object obj0, [In] Range obj1)
  {
    if (this.m_SheetChangeDelegate == null)
      return;
    this.m_SheetChangeDelegate(obj0, obj1);
  }

  public virtual void SheetCalculate([In] object obj0)
  {
    if (this.m_SheetCalculateDelegate == null)
      return;
    this.m_SheetCalculateDelegate(obj0);
  }

  public virtual void SheetDeactivate([In] object obj0)
  {
    if (this.m_SheetDeactivateDelegate == null)
      return;
    this.m_SheetDeactivateDelegate(obj0);
  }

  public virtual void SheetActivate([In] object obj0)
  {
    if (this.m_SheetActivateDelegate == null)
      return;
    this.m_SheetActivateDelegate(obj0);
  }

  public virtual void SheetBeforeRightClick([In] object obj0, [In] Range obj1, [In] ref bool obj2)
  {
    if (this.m_SheetBeforeRightClickDelegate == null)
      return;
    this.m_SheetBeforeRightClickDelegate(obj0, obj1, ref obj2);
  }

  public virtual void SheetBeforeDoubleClick([In] object obj0, [In] Range obj1, [In] ref bool obj2)
  {
    if (this.m_SheetBeforeDoubleClickDelegate == null)
      return;
    this.m_SheetBeforeDoubleClickDelegate(obj0, obj1, ref obj2);
  }

  public virtual void SheetSelectionChange([In] object obj0, [In] Range obj1)
  {
    if (this.m_SheetSelectionChangeDelegate == null)
      return;
    this.m_SheetSelectionChangeDelegate(obj0, obj1);
  }

  public virtual void WindowDeactivate([In] Window obj0)
  {
    if (this.m_WindowDeactivateDelegate == null)
      return;
    this.m_WindowDeactivateDelegate(obj0);
  }

  public virtual void WindowActivate([In] Window obj0)
  {
    if (this.m_WindowActivateDelegate == null)
      return;
    this.m_WindowActivateDelegate(obj0);
  }

  public virtual void WindowResize([In] Window obj0)
  {
    if (this.m_WindowResizeDelegate == null)
      return;
    this.m_WindowResizeDelegate(obj0);
  }

  public virtual void AddinUninstall()
  {
    if (this.m_AddinUninstallDelegate == null)
      return;
    this.m_AddinUninstallDelegate();
  }

  public virtual void AddinInstall()
  {
    if (this.m_AddinInstallDelegate == null)
      return;
    this.m_AddinInstallDelegate();
  }

  public virtual void NewSheet([In] object obj0)
  {
    if (this.m_NewSheetDelegate == null)
      return;
    this.m_NewSheetDelegate(obj0);
  }

  public virtual void BeforePrint([In] ref bool obj0)
  {
    if (this.m_BeforePrintDelegate == null)
      return;
    this.m_BeforePrintDelegate(ref obj0);
  }

  public virtual void BeforeSave([In] bool obj0, [In] ref bool obj1)
  {
    if (this.m_BeforeSaveDelegate == null)
      return;
    this.m_BeforeSaveDelegate(obj0, ref obj1);
  }

  public virtual void BeforeClose([In] ref bool obj0)
  {
    if (this.m_BeforeCloseDelegate == null)
      return;
    this.m_BeforeCloseDelegate(ref obj0);
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

  public virtual void Open()
  {
    if (this.m_OpenDelegate == null)
      return;
    this.m_OpenDelegate();
  }

  internal WorkbookEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_RowsetCompleteDelegate = (WorkbookEvents_RowsetCompleteEventHandler) null;
    this.m_AfterXmlExportDelegate = (WorkbookEvents_AfterXmlExportEventHandler) null;
    this.m_BeforeXmlExportDelegate = (WorkbookEvents_BeforeXmlExportEventHandler) null;
    this.m_AfterXmlImportDelegate = (WorkbookEvents_AfterXmlImportEventHandler) null;
    this.m_BeforeXmlImportDelegate = (WorkbookEvents_BeforeXmlImportEventHandler) null;
    this.m_SyncDelegate = (WorkbookEvents_SyncEventHandler) null;
    this.m_PivotTableOpenConnectionDelegate = (WorkbookEvents_PivotTableOpenConnectionEventHandler) null;
    this.m_PivotTableCloseConnectionDelegate = (WorkbookEvents_PivotTableCloseConnectionEventHandler) null;
    this.m_SheetPivotTableUpdateDelegate = (WorkbookEvents_SheetPivotTableUpdateEventHandler) null;
    this.m_SheetFollowHyperlinkDelegate = (WorkbookEvents_SheetFollowHyperlinkEventHandler) null;
    this.m_SheetChangeDelegate = (WorkbookEvents_SheetChangeEventHandler) null;
    this.m_SheetCalculateDelegate = (WorkbookEvents_SheetCalculateEventHandler) null;
    this.m_SheetDeactivateDelegate = (WorkbookEvents_SheetDeactivateEventHandler) null;
    this.m_SheetActivateDelegate = (WorkbookEvents_SheetActivateEventHandler) null;
    this.m_SheetBeforeRightClickDelegate = (WorkbookEvents_SheetBeforeRightClickEventHandler) null;
    this.m_SheetBeforeDoubleClickDelegate = (WorkbookEvents_SheetBeforeDoubleClickEventHandler) null;
    this.m_SheetSelectionChangeDelegate = (WorkbookEvents_SheetSelectionChangeEventHandler) null;
    this.m_WindowDeactivateDelegate = (WorkbookEvents_WindowDeactivateEventHandler) null;
    this.m_WindowActivateDelegate = (WorkbookEvents_WindowActivateEventHandler) null;
    this.m_WindowResizeDelegate = (WorkbookEvents_WindowResizeEventHandler) null;
    this.m_AddinUninstallDelegate = (WorkbookEvents_AddinUninstallEventHandler) null;
    this.m_AddinInstallDelegate = (WorkbookEvents_AddinInstallEventHandler) null;
    this.m_NewSheetDelegate = (WorkbookEvents_NewSheetEventHandler) null;
    this.m_BeforePrintDelegate = (WorkbookEvents_BeforePrintEventHandler) null;
    this.m_BeforeSaveDelegate = (WorkbookEvents_BeforeSaveEventHandler) null;
    this.m_BeforeCloseDelegate = (WorkbookEvents_BeforeCloseEventHandler) null;
    this.m_DeactivateDelegate = (WorkbookEvents_DeactivateEventHandler) null;
    this.m_ActivateDelegate = (WorkbookEvents_ActivateEventHandler) null;
    this.m_OpenDelegate = (WorkbookEvents_OpenEventHandler) null;
  }
}
