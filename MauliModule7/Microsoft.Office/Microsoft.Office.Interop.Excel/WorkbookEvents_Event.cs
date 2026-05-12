// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.WorkbookEvents_Event
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(16 /*0x10*/)]
[ComVisible(false)]
[ComEventInterface(typeof (WorkbookEvents), typeof (WorkbookEvents_EventProvider))]
public interface WorkbookEvents_Event
{
  event WorkbookEvents_OpenEventHandler Open;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Open([In] WorkbookEvents_OpenEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Open([In] WorkbookEvents_OpenEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Activate([In] WorkbookEvents_ActivateEventHandler obj0);

  event WorkbookEvents_ActivateEventHandler Activate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Activate([In] WorkbookEvents_ActivateEventHandler obj0);

  event WorkbookEvents_DeactivateEventHandler Deactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Deactivate([In] WorkbookEvents_DeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Deactivate([In] WorkbookEvents_DeactivateEventHandler obj0);

  event WorkbookEvents_BeforeCloseEventHandler BeforeClose;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_BeforeClose([In] WorkbookEvents_BeforeCloseEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_BeforeClose([In] WorkbookEvents_BeforeCloseEventHandler obj0);

  event WorkbookEvents_BeforeSaveEventHandler BeforeSave;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_BeforeSave([In] WorkbookEvents_BeforeSaveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_BeforeSave([In] WorkbookEvents_BeforeSaveEventHandler obj0);

  event WorkbookEvents_BeforePrintEventHandler BeforePrint;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_BeforePrint([In] WorkbookEvents_BeforePrintEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_BeforePrint([In] WorkbookEvents_BeforePrintEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_NewSheet([In] WorkbookEvents_NewSheetEventHandler obj0);

  event WorkbookEvents_NewSheetEventHandler NewSheet;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_NewSheet([In] WorkbookEvents_NewSheetEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_AddinInstall([In] WorkbookEvents_AddinInstallEventHandler obj0);

  event WorkbookEvents_AddinInstallEventHandler AddinInstall;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_AddinInstall([In] WorkbookEvents_AddinInstallEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_AddinUninstall([In] WorkbookEvents_AddinUninstallEventHandler obj0);

  event WorkbookEvents_AddinUninstallEventHandler AddinUninstall;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_AddinUninstall([In] WorkbookEvents_AddinUninstallEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowResize([In] WorkbookEvents_WindowResizeEventHandler obj0);

  event WorkbookEvents_WindowResizeEventHandler WindowResize;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowResize([In] WorkbookEvents_WindowResizeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowActivate([In] WorkbookEvents_WindowActivateEventHandler obj0);

  event WorkbookEvents_WindowActivateEventHandler WindowActivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowActivate([In] WorkbookEvents_WindowActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowDeactivate([In] WorkbookEvents_WindowDeactivateEventHandler obj0);

  event WorkbookEvents_WindowDeactivateEventHandler WindowDeactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowDeactivate([In] WorkbookEvents_WindowDeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetSelectionChange(
    [In] WorkbookEvents_SheetSelectionChangeEventHandler obj0);

  event WorkbookEvents_SheetSelectionChangeEventHandler SheetSelectionChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetSelectionChange(
    [In] WorkbookEvents_SheetSelectionChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetBeforeDoubleClick(
    [In] WorkbookEvents_SheetBeforeDoubleClickEventHandler obj0);

  event WorkbookEvents_SheetBeforeDoubleClickEventHandler SheetBeforeDoubleClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetBeforeDoubleClick(
    [In] WorkbookEvents_SheetBeforeDoubleClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetBeforeRightClick(
    [In] WorkbookEvents_SheetBeforeRightClickEventHandler obj0);

  event WorkbookEvents_SheetBeforeRightClickEventHandler SheetBeforeRightClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetBeforeRightClick(
    [In] WorkbookEvents_SheetBeforeRightClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetActivate([In] WorkbookEvents_SheetActivateEventHandler obj0);

  event WorkbookEvents_SheetActivateEventHandler SheetActivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetActivate([In] WorkbookEvents_SheetActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetDeactivate([In] WorkbookEvents_SheetDeactivateEventHandler obj0);

  event WorkbookEvents_SheetDeactivateEventHandler SheetDeactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetDeactivate([In] WorkbookEvents_SheetDeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetCalculate([In] WorkbookEvents_SheetCalculateEventHandler obj0);

  event WorkbookEvents_SheetCalculateEventHandler SheetCalculate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetCalculate([In] WorkbookEvents_SheetCalculateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetChange([In] WorkbookEvents_SheetChangeEventHandler obj0);

  event WorkbookEvents_SheetChangeEventHandler SheetChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetChange([In] WorkbookEvents_SheetChangeEventHandler obj0);

  event WorkbookEvents_SheetFollowHyperlinkEventHandler SheetFollowHyperlink;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetFollowHyperlink(
    [In] WorkbookEvents_SheetFollowHyperlinkEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetFollowHyperlink(
    [In] WorkbookEvents_SheetFollowHyperlinkEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetPivotTableUpdate(
    [In] WorkbookEvents_SheetPivotTableUpdateEventHandler obj0);

  event WorkbookEvents_SheetPivotTableUpdateEventHandler SheetPivotTableUpdate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetPivotTableUpdate(
    [In] WorkbookEvents_SheetPivotTableUpdateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_PivotTableCloseConnection(
    [In] WorkbookEvents_PivotTableCloseConnectionEventHandler obj0);

  event WorkbookEvents_PivotTableCloseConnectionEventHandler PivotTableCloseConnection;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_PivotTableCloseConnection(
    [In] WorkbookEvents_PivotTableCloseConnectionEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_PivotTableOpenConnection(
    [In] WorkbookEvents_PivotTableOpenConnectionEventHandler obj0);

  event WorkbookEvents_PivotTableOpenConnectionEventHandler PivotTableOpenConnection;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_PivotTableOpenConnection(
    [In] WorkbookEvents_PivotTableOpenConnectionEventHandler obj0);

  event WorkbookEvents_SyncEventHandler Sync;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Sync([In] WorkbookEvents_SyncEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Sync([In] WorkbookEvents_SyncEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_BeforeXmlImport([In] WorkbookEvents_BeforeXmlImportEventHandler obj0);

  event WorkbookEvents_BeforeXmlImportEventHandler BeforeXmlImport;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_BeforeXmlImport([In] WorkbookEvents_BeforeXmlImportEventHandler obj0);

  event WorkbookEvents_AfterXmlImportEventHandler AfterXmlImport;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_AfterXmlImport([In] WorkbookEvents_AfterXmlImportEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_AfterXmlImport([In] WorkbookEvents_AfterXmlImportEventHandler obj0);

  event WorkbookEvents_BeforeXmlExportEventHandler BeforeXmlExport;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_BeforeXmlExport([In] WorkbookEvents_BeforeXmlExportEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_BeforeXmlExport([In] WorkbookEvents_BeforeXmlExportEventHandler obj0);

  event WorkbookEvents_AfterXmlExportEventHandler AfterXmlExport;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_AfterXmlExport([In] WorkbookEvents_AfterXmlExportEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_AfterXmlExport([In] WorkbookEvents_AfterXmlExportEventHandler obj0);

  event WorkbookEvents_RowsetCompleteEventHandler RowsetComplete;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_RowsetComplete([In] WorkbookEvents_RowsetCompleteEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_RowsetComplete([In] WorkbookEvents_RowsetCompleteEventHandler obj0);
}
