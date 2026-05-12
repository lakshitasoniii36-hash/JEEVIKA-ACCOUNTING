// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.AppEvents_Event
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(16 /*0x10*/)]
[ComVisible(false)]
[ComEventInterface(typeof (AppEvents), typeof (AppEvents_EventProvider))]
public interface AppEvents_Event
{
  event AppEvents_NewWorkbookEventHandler NewWorkbook;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_NewWorkbook([In] AppEvents_NewWorkbookEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_NewWorkbook([In] AppEvents_NewWorkbookEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetSelectionChange([In] AppEvents_SheetSelectionChangeEventHandler obj0);

  event AppEvents_SheetSelectionChangeEventHandler SheetSelectionChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetSelectionChange([In] AppEvents_SheetSelectionChangeEventHandler obj0);

  event AppEvents_SheetBeforeDoubleClickEventHandler SheetBeforeDoubleClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetBeforeDoubleClick([In] AppEvents_SheetBeforeDoubleClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetBeforeDoubleClick([In] AppEvents_SheetBeforeDoubleClickEventHandler obj0);

  event AppEvents_SheetBeforeRightClickEventHandler SheetBeforeRightClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetBeforeRightClick([In] AppEvents_SheetBeforeRightClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetBeforeRightClick([In] AppEvents_SheetBeforeRightClickEventHandler obj0);

  event AppEvents_SheetActivateEventHandler SheetActivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetActivate([In] AppEvents_SheetActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetActivate([In] AppEvents_SheetActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetDeactivate([In] AppEvents_SheetDeactivateEventHandler obj0);

  event AppEvents_SheetDeactivateEventHandler SheetDeactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetDeactivate([In] AppEvents_SheetDeactivateEventHandler obj0);

  event AppEvents_SheetCalculateEventHandler SheetCalculate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetCalculate([In] AppEvents_SheetCalculateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetCalculate([In] AppEvents_SheetCalculateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetChange([In] AppEvents_SheetChangeEventHandler obj0);

  event AppEvents_SheetChangeEventHandler SheetChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetChange([In] AppEvents_SheetChangeEventHandler obj0);

  event AppEvents_WorkbookOpenEventHandler WorkbookOpen;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookOpen([In] AppEvents_WorkbookOpenEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookOpen([In] AppEvents_WorkbookOpenEventHandler obj0);

  event AppEvents_WorkbookActivateEventHandler WorkbookActivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookActivate([In] AppEvents_WorkbookActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookActivate([In] AppEvents_WorkbookActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookDeactivate([In] AppEvents_WorkbookDeactivateEventHandler obj0);

  event AppEvents_WorkbookDeactivateEventHandler WorkbookDeactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookDeactivate([In] AppEvents_WorkbookDeactivateEventHandler obj0);

  event AppEvents_WorkbookBeforeCloseEventHandler WorkbookBeforeClose;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookBeforeClose([In] AppEvents_WorkbookBeforeCloseEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookBeforeClose([In] AppEvents_WorkbookBeforeCloseEventHandler obj0);

  event AppEvents_WorkbookBeforeSaveEventHandler WorkbookBeforeSave;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookBeforeSave([In] AppEvents_WorkbookBeforeSaveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookBeforeSave([In] AppEvents_WorkbookBeforeSaveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookBeforePrint([In] AppEvents_WorkbookBeforePrintEventHandler obj0);

  event AppEvents_WorkbookBeforePrintEventHandler WorkbookBeforePrint;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookBeforePrint([In] AppEvents_WorkbookBeforePrintEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookNewSheet([In] AppEvents_WorkbookNewSheetEventHandler obj0);

  event AppEvents_WorkbookNewSheetEventHandler WorkbookNewSheet;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookNewSheet([In] AppEvents_WorkbookNewSheetEventHandler obj0);

  event AppEvents_WorkbookAddinInstallEventHandler WorkbookAddinInstall;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookAddinInstall([In] AppEvents_WorkbookAddinInstallEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookAddinInstall([In] AppEvents_WorkbookAddinInstallEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookAddinUninstall([In] AppEvents_WorkbookAddinUninstallEventHandler obj0);

  event AppEvents_WorkbookAddinUninstallEventHandler WorkbookAddinUninstall;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookAddinUninstall([In] AppEvents_WorkbookAddinUninstallEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowResize([In] AppEvents_WindowResizeEventHandler obj0);

  event AppEvents_WindowResizeEventHandler WindowResize;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowResize([In] AppEvents_WindowResizeEventHandler obj0);

  event AppEvents_WindowActivateEventHandler WindowActivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowActivate([In] AppEvents_WindowActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowActivate([In] AppEvents_WindowActivateEventHandler obj0);

  event AppEvents_WindowDeactivateEventHandler WindowDeactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowDeactivate([In] AppEvents_WindowDeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowDeactivate([In] AppEvents_WindowDeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetFollowHyperlink([In] AppEvents_SheetFollowHyperlinkEventHandler obj0);

  event AppEvents_SheetFollowHyperlinkEventHandler SheetFollowHyperlink;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetFollowHyperlink([In] AppEvents_SheetFollowHyperlinkEventHandler obj0);

  event AppEvents_SheetPivotTableUpdateEventHandler SheetPivotTableUpdate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_SheetPivotTableUpdate([In] AppEvents_SheetPivotTableUpdateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_SheetPivotTableUpdate([In] AppEvents_SheetPivotTableUpdateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookPivotTableCloseConnection(
    [In] AppEvents_WorkbookPivotTableCloseConnectionEventHandler obj0);

  event AppEvents_WorkbookPivotTableCloseConnectionEventHandler WorkbookPivotTableCloseConnection;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookPivotTableCloseConnection(
    [In] AppEvents_WorkbookPivotTableCloseConnectionEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookPivotTableOpenConnection(
    [In] AppEvents_WorkbookPivotTableOpenConnectionEventHandler obj0);

  event AppEvents_WorkbookPivotTableOpenConnectionEventHandler WorkbookPivotTableOpenConnection;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookPivotTableOpenConnection(
    [In] AppEvents_WorkbookPivotTableOpenConnectionEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookSync([In] AppEvents_WorkbookSyncEventHandler obj0);

  event AppEvents_WorkbookSyncEventHandler WorkbookSync;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookSync([In] AppEvents_WorkbookSyncEventHandler obj0);

  event AppEvents_WorkbookBeforeXmlImportEventHandler WorkbookBeforeXmlImport;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookBeforeXmlImport([In] AppEvents_WorkbookBeforeXmlImportEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookBeforeXmlImport([In] AppEvents_WorkbookBeforeXmlImportEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookAfterXmlImport([In] AppEvents_WorkbookAfterXmlImportEventHandler obj0);

  event AppEvents_WorkbookAfterXmlImportEventHandler WorkbookAfterXmlImport;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookAfterXmlImport([In] AppEvents_WorkbookAfterXmlImportEventHandler obj0);

  event AppEvents_WorkbookBeforeXmlExportEventHandler WorkbookBeforeXmlExport;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookBeforeXmlExport([In] AppEvents_WorkbookBeforeXmlExportEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookBeforeXmlExport([In] AppEvents_WorkbookBeforeXmlExportEventHandler obj0);

  event AppEvents_WorkbookAfterXmlExportEventHandler WorkbookAfterXmlExport;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookAfterXmlExport([In] AppEvents_WorkbookAfterXmlExportEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookAfterXmlExport([In] AppEvents_WorkbookAfterXmlExportEventHandler obj0);

  event AppEvents_WorkbookRowsetCompleteEventHandler WorkbookRowsetComplete;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WorkbookRowsetComplete([In] AppEvents_WorkbookRowsetCompleteEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WorkbookRowsetComplete([In] AppEvents_WorkbookRowsetCompleteEventHandler obj0);

  event AppEvents_AfterCalculateEventHandler AfterCalculate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_AfterCalculate([In] AppEvents_AfterCalculateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_AfterCalculate([In] AppEvents_AfterCalculateEventHandler obj0);
}
