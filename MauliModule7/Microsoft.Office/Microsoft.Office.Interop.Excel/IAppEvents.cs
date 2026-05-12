// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IAppEvents
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(4112)]
[Guid("00024413-0001-0000-C000-000000000046")]
[ComImport]
public interface IAppEvents
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NewWorkbook([MarshalAs(UnmanagedType.Interface), In] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetSelectionChange([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] Range Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetBeforeDoubleClick([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] Range Target, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetBeforeRightClick([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] Range Target, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetActivate([MarshalAs(UnmanagedType.IDispatch), In] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetDeactivate([MarshalAs(UnmanagedType.IDispatch), In] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetCalculate([MarshalAs(UnmanagedType.IDispatch), In] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetChange([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] Range Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookOpen([MarshalAs(UnmanagedType.Interface), In] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookActivate([MarshalAs(UnmanagedType.Interface), In] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookDeactivate([MarshalAs(UnmanagedType.Interface), In] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforeClose([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforeSave([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [In] bool SaveAsUI, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforePrint([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookNewSheet([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.IDispatch), In] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAddinInstall([MarshalAs(UnmanagedType.Interface), In] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAddinUninstall([MarshalAs(UnmanagedType.Interface), In] Workbook Wb);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowResize([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowActivate([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowDeactivate([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetFollowHyperlink([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] Hyperlink Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetPivotTableUpdate([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookPivotTableCloseConnection([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookPivotTableOpenConnection([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookSync([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [In] MsoSyncEventType SyncEventType);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforeXmlImport(
    [MarshalAs(UnmanagedType.Interface), In] Workbook Wb,
    [MarshalAs(UnmanagedType.Interface), In] XmlMap Map,
    [MarshalAs(UnmanagedType.BStr), In] string Url,
    [In] bool IsRefresh,
    [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAfterXmlImport([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [In] bool IsRefresh, [In] XlXmlImportResult Result);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforeXmlExport([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [MarshalAs(UnmanagedType.BStr), In] string Url, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAfterXmlExport([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [MarshalAs(UnmanagedType.BStr), In] string Url, [In] XlXmlExportResult Result);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookRowsetComplete([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.BStr), In] string Description, [MarshalAs(UnmanagedType.BStr), In] string Sheet, [In] bool Success);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AfterCalculate();
}
