// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.AppEvents
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[InterfaceType(2)]
[Guid("00024413-0000-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface AppEvents
{
  [DispId(1565)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NewWorkbook([MarshalAs(UnmanagedType.Interface), In] Workbook Wb);

  [DispId(1558)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetSelectionChange([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] Range Target);

  [DispId(1559)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetBeforeDoubleClick([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] Range Target, [In, Out] ref bool Cancel);

  [DispId(1560)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetBeforeRightClick([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] Range Target, [In, Out] ref bool Cancel);

  [DispId(1561)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetActivate([MarshalAs(UnmanagedType.IDispatch), In] object Sh);

  [DispId(1562)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetDeactivate([MarshalAs(UnmanagedType.IDispatch), In] object Sh);

  [DispId(1563)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetCalculate([MarshalAs(UnmanagedType.IDispatch), In] object Sh);

  [DispId(1564)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetChange([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] Range Target);

  [DispId(1567)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookOpen([MarshalAs(UnmanagedType.Interface), In] Workbook Wb);

  [DispId(1568)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookActivate([MarshalAs(UnmanagedType.Interface), In] Workbook Wb);

  [DispId(1569)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookDeactivate([MarshalAs(UnmanagedType.Interface), In] Workbook Wb);

  [DispId(1570)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforeClose([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [In, Out] ref bool Cancel);

  [DispId(1571)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforeSave([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [In] bool SaveAsUI, [In, Out] ref bool Cancel);

  [DispId(1572)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforePrint([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [In, Out] ref bool Cancel);

  [DispId(1573)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookNewSheet([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.IDispatch), In] object Sh);

  [DispId(1574)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAddinInstall([MarshalAs(UnmanagedType.Interface), In] Workbook Wb);

  [DispId(1575)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAddinUninstall([MarshalAs(UnmanagedType.Interface), In] Workbook Wb);

  [DispId(1554)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowResize([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [DispId(1556)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowActivate([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [DispId(1557)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowDeactivate([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [DispId(1854)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetFollowHyperlink([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] Hyperlink Target);

  [DispId(2157)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetPivotTableUpdate([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] PivotTable Target);

  [DispId(2160)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookPivotTableCloseConnection([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] PivotTable Target);

  [DispId(2161)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookPivotTableOpenConnection([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] PivotTable Target);

  [DispId(2289)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookSync([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [In] MsoSyncEventType SyncEventType);

  [DispId(2290)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforeXmlImport(
    [MarshalAs(UnmanagedType.Interface), In] Workbook Wb,
    [MarshalAs(UnmanagedType.Interface), In] XmlMap Map,
    [MarshalAs(UnmanagedType.BStr), In] string Url,
    [In] bool IsRefresh,
    [In, Out] ref bool Cancel);

  [DispId(2291)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAfterXmlImport([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [In] bool IsRefresh, [In] XlXmlImportResult Result);

  [DispId(2292)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookBeforeXmlExport([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [MarshalAs(UnmanagedType.BStr), In] string Url, [In, Out] ref bool Cancel);

  [DispId(2293)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookAfterXmlExport([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [MarshalAs(UnmanagedType.BStr), In] string Url, [In] XlXmlExportResult Result);

  [DispId(2611)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WorkbookRowsetComplete([MarshalAs(UnmanagedType.Interface), In] Workbook Wb, [MarshalAs(UnmanagedType.BStr), In] string Description, [MarshalAs(UnmanagedType.BStr), In] string Sheet, [In] bool Success);

  [DispId(2612)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AfterCalculate();
}
