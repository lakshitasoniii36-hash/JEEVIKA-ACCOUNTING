// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.AppEvents_SinkHelper
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[ClassInterface(ClassInterfaceType.None)]
public sealed class AppEvents_SinkHelper : AppEvents
{
  public AppEvents_AfterCalculateEventHandler m_AfterCalculateDelegate;
  public AppEvents_WorkbookRowsetCompleteEventHandler m_WorkbookRowsetCompleteDelegate;
  public AppEvents_WorkbookAfterXmlExportEventHandler m_WorkbookAfterXmlExportDelegate;
  public AppEvents_WorkbookBeforeXmlExportEventHandler m_WorkbookBeforeXmlExportDelegate;
  public AppEvents_WorkbookAfterXmlImportEventHandler m_WorkbookAfterXmlImportDelegate;
  public AppEvents_WorkbookBeforeXmlImportEventHandler m_WorkbookBeforeXmlImportDelegate;
  public AppEvents_WorkbookSyncEventHandler m_WorkbookSyncDelegate;
  public AppEvents_WorkbookPivotTableOpenConnectionEventHandler m_WorkbookPivotTableOpenConnectionDelegate;
  public AppEvents_WorkbookPivotTableCloseConnectionEventHandler m_WorkbookPivotTableCloseConnectionDelegate;
  public AppEvents_SheetPivotTableUpdateEventHandler m_SheetPivotTableUpdateDelegate;
  public AppEvents_SheetFollowHyperlinkEventHandler m_SheetFollowHyperlinkDelegate;
  public AppEvents_WindowDeactivateEventHandler m_WindowDeactivateDelegate;
  public AppEvents_WindowActivateEventHandler m_WindowActivateDelegate;
  public AppEvents_WindowResizeEventHandler m_WindowResizeDelegate;
  public AppEvents_WorkbookAddinUninstallEventHandler m_WorkbookAddinUninstallDelegate;
  public AppEvents_WorkbookAddinInstallEventHandler m_WorkbookAddinInstallDelegate;
  public AppEvents_WorkbookNewSheetEventHandler m_WorkbookNewSheetDelegate;
  public AppEvents_WorkbookBeforePrintEventHandler m_WorkbookBeforePrintDelegate;
  public AppEvents_WorkbookBeforeSaveEventHandler m_WorkbookBeforeSaveDelegate;
  public AppEvents_WorkbookBeforeCloseEventHandler m_WorkbookBeforeCloseDelegate;
  public AppEvents_WorkbookDeactivateEventHandler m_WorkbookDeactivateDelegate;
  public AppEvents_WorkbookActivateEventHandler m_WorkbookActivateDelegate;
  public AppEvents_WorkbookOpenEventHandler m_WorkbookOpenDelegate;
  public AppEvents_SheetChangeEventHandler m_SheetChangeDelegate;
  public AppEvents_SheetCalculateEventHandler m_SheetCalculateDelegate;
  public AppEvents_SheetDeactivateEventHandler m_SheetDeactivateDelegate;
  public AppEvents_SheetActivateEventHandler m_SheetActivateDelegate;
  public AppEvents_SheetBeforeRightClickEventHandler m_SheetBeforeRightClickDelegate;
  public AppEvents_SheetBeforeDoubleClickEventHandler m_SheetBeforeDoubleClickDelegate;
  public AppEvents_SheetSelectionChangeEventHandler m_SheetSelectionChangeDelegate;
  public AppEvents_NewWorkbookEventHandler m_NewWorkbookDelegate;
  public int m_dwCookie;

  public virtual void AfterCalculate()
  {
    if (this.m_AfterCalculateDelegate == null)
      return;
    this.m_AfterCalculateDelegate();
  }

  public virtual void WorkbookRowsetComplete([In] Workbook obj0, [In] string obj1, [In] string obj2, [In] bool obj3)
  {
    if (this.m_WorkbookRowsetCompleteDelegate == null)
      return;
    this.m_WorkbookRowsetCompleteDelegate(obj0, obj1, obj2, obj3);
  }

  public virtual void WorkbookAfterXmlExport(
    [In] Workbook obj0,
    [In] XmlMap obj1,
    [In] string obj2,
    [In] XlXmlExportResult obj3)
  {
    if (this.m_WorkbookAfterXmlExportDelegate == null)
      return;
    this.m_WorkbookAfterXmlExportDelegate(obj0, obj1, obj2, obj3);
  }

  public virtual void WorkbookBeforeXmlExport(
    [In] Workbook obj0,
    [In] XmlMap obj1,
    [In] string obj2,
    [In] ref bool obj3)
  {
    if (this.m_WorkbookBeforeXmlExportDelegate == null)
      return;
    this.m_WorkbookBeforeXmlExportDelegate(obj0, obj1, obj2, ref obj3);
  }

  public virtual void WorkbookAfterXmlImport(
    [In] Workbook obj0,
    [In] XmlMap obj1,
    [In] bool obj2,
    [In] XlXmlImportResult obj3)
  {
    if (this.m_WorkbookAfterXmlImportDelegate == null)
      return;
    this.m_WorkbookAfterXmlImportDelegate(obj0, obj1, obj2, obj3);
  }

  public virtual void WorkbookBeforeXmlImport(
    [In] Workbook obj0,
    [In] XmlMap obj1,
    [In] string obj2,
    [In] bool obj3,
    [In] ref bool obj4)
  {
    if (this.m_WorkbookBeforeXmlImportDelegate == null)
      return;
    this.m_WorkbookBeforeXmlImportDelegate(obj0, obj1, obj2, obj3, ref obj4);
  }

  public virtual void WorkbookSync([In] Workbook obj0, [In] MsoSyncEventType obj1)
  {
    if (this.m_WorkbookSyncDelegate == null)
      return;
    this.m_WorkbookSyncDelegate(obj0, obj1);
  }

  public virtual void WorkbookPivotTableOpenConnection([In] Workbook obj0, [In] PivotTable obj1)
  {
    if (this.m_WorkbookPivotTableOpenConnectionDelegate == null)
      return;
    this.m_WorkbookPivotTableOpenConnectionDelegate(obj0, obj1);
  }

  public virtual void WorkbookPivotTableCloseConnection([In] Workbook obj0, [In] PivotTable obj1)
  {
    if (this.m_WorkbookPivotTableCloseConnectionDelegate == null)
      return;
    this.m_WorkbookPivotTableCloseConnectionDelegate(obj0, obj1);
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

  public virtual void WindowDeactivate([In] Workbook obj0, [In] Window obj1)
  {
    if (this.m_WindowDeactivateDelegate == null)
      return;
    this.m_WindowDeactivateDelegate(obj0, obj1);
  }

  public virtual void WindowActivate([In] Workbook obj0, [In] Window obj1)
  {
    if (this.m_WindowActivateDelegate == null)
      return;
    this.m_WindowActivateDelegate(obj0, obj1);
  }

  public virtual void WindowResize([In] Workbook obj0, [In] Window obj1)
  {
    if (this.m_WindowResizeDelegate == null)
      return;
    this.m_WindowResizeDelegate(obj0, obj1);
  }

  public virtual void WorkbookAddinUninstall([In] Workbook obj0)
  {
    if (this.m_WorkbookAddinUninstallDelegate == null)
      return;
    this.m_WorkbookAddinUninstallDelegate(obj0);
  }

  public virtual void WorkbookAddinInstall([In] Workbook obj0)
  {
    if (this.m_WorkbookAddinInstallDelegate == null)
      return;
    this.m_WorkbookAddinInstallDelegate(obj0);
  }

  public virtual void WorkbookNewSheet([In] Workbook obj0, [In] object obj1)
  {
    if (this.m_WorkbookNewSheetDelegate == null)
      return;
    this.m_WorkbookNewSheetDelegate(obj0, obj1);
  }

  public virtual void WorkbookBeforePrint([In] Workbook obj0, [In] ref bool obj1)
  {
    if (this.m_WorkbookBeforePrintDelegate == null)
      return;
    this.m_WorkbookBeforePrintDelegate(obj0, ref obj1);
  }

  public virtual void WorkbookBeforeSave([In] Workbook obj0, [In] bool obj1, [In] ref bool obj2)
  {
    if (this.m_WorkbookBeforeSaveDelegate == null)
      return;
    this.m_WorkbookBeforeSaveDelegate(obj0, obj1, ref obj2);
  }

  public virtual void WorkbookBeforeClose([In] Workbook obj0, [In] ref bool obj1)
  {
    if (this.m_WorkbookBeforeCloseDelegate == null)
      return;
    this.m_WorkbookBeforeCloseDelegate(obj0, ref obj1);
  }

  public virtual void WorkbookDeactivate([In] Workbook obj0)
  {
    if (this.m_WorkbookDeactivateDelegate == null)
      return;
    this.m_WorkbookDeactivateDelegate(obj0);
  }

  public virtual void WorkbookActivate([In] Workbook obj0)
  {
    if (this.m_WorkbookActivateDelegate == null)
      return;
    this.m_WorkbookActivateDelegate(obj0);
  }

  public virtual void WorkbookOpen([In] Workbook obj0)
  {
    if (this.m_WorkbookOpenDelegate == null)
      return;
    this.m_WorkbookOpenDelegate(obj0);
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

  public virtual void NewWorkbook([In] Workbook obj0)
  {
    if (this.m_NewWorkbookDelegate == null)
      return;
    this.m_NewWorkbookDelegate(obj0);
  }

  internal AppEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_AfterCalculateDelegate = (AppEvents_AfterCalculateEventHandler) null;
    this.m_WorkbookRowsetCompleteDelegate = (AppEvents_WorkbookRowsetCompleteEventHandler) null;
    this.m_WorkbookAfterXmlExportDelegate = (AppEvents_WorkbookAfterXmlExportEventHandler) null;
    this.m_WorkbookBeforeXmlExportDelegate = (AppEvents_WorkbookBeforeXmlExportEventHandler) null;
    this.m_WorkbookAfterXmlImportDelegate = (AppEvents_WorkbookAfterXmlImportEventHandler) null;
    this.m_WorkbookBeforeXmlImportDelegate = (AppEvents_WorkbookBeforeXmlImportEventHandler) null;
    this.m_WorkbookSyncDelegate = (AppEvents_WorkbookSyncEventHandler) null;
    this.m_WorkbookPivotTableOpenConnectionDelegate = (AppEvents_WorkbookPivotTableOpenConnectionEventHandler) null;
    this.m_WorkbookPivotTableCloseConnectionDelegate = (AppEvents_WorkbookPivotTableCloseConnectionEventHandler) null;
    this.m_SheetPivotTableUpdateDelegate = (AppEvents_SheetPivotTableUpdateEventHandler) null;
    this.m_SheetFollowHyperlinkDelegate = (AppEvents_SheetFollowHyperlinkEventHandler) null;
    this.m_WindowDeactivateDelegate = (AppEvents_WindowDeactivateEventHandler) null;
    this.m_WindowActivateDelegate = (AppEvents_WindowActivateEventHandler) null;
    this.m_WindowResizeDelegate = (AppEvents_WindowResizeEventHandler) null;
    this.m_WorkbookAddinUninstallDelegate = (AppEvents_WorkbookAddinUninstallEventHandler) null;
    this.m_WorkbookAddinInstallDelegate = (AppEvents_WorkbookAddinInstallEventHandler) null;
    this.m_WorkbookNewSheetDelegate = (AppEvents_WorkbookNewSheetEventHandler) null;
    this.m_WorkbookBeforePrintDelegate = (AppEvents_WorkbookBeforePrintEventHandler) null;
    this.m_WorkbookBeforeSaveDelegate = (AppEvents_WorkbookBeforeSaveEventHandler) null;
    this.m_WorkbookBeforeCloseDelegate = (AppEvents_WorkbookBeforeCloseEventHandler) null;
    this.m_WorkbookDeactivateDelegate = (AppEvents_WorkbookDeactivateEventHandler) null;
    this.m_WorkbookActivateDelegate = (AppEvents_WorkbookActivateEventHandler) null;
    this.m_WorkbookOpenDelegate = (AppEvents_WorkbookOpenEventHandler) null;
    this.m_SheetChangeDelegate = (AppEvents_SheetChangeEventHandler) null;
    this.m_SheetCalculateDelegate = (AppEvents_SheetCalculateEventHandler) null;
    this.m_SheetDeactivateDelegate = (AppEvents_SheetDeactivateEventHandler) null;
    this.m_SheetActivateDelegate = (AppEvents_SheetActivateEventHandler) null;
    this.m_SheetBeforeRightClickDelegate = (AppEvents_SheetBeforeRightClickEventHandler) null;
    this.m_SheetBeforeDoubleClickDelegate = (AppEvents_SheetBeforeDoubleClickEventHandler) null;
    this.m_SheetSelectionChangeDelegate = (AppEvents_SheetSelectionChangeEventHandler) null;
    this.m_NewWorkbookDelegate = (AppEvents_NewWorkbookEventHandler) null;
  }
}
