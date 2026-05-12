// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.WorkbookEvents
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[InterfaceType(2)]
[Guid("00024412-0000-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface WorkbookEvents
{
  [DispId(1923)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Open();

  [DispId(304)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Activate();

  [DispId(1530)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Deactivate();

  [DispId(1546)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeClose([In, Out] ref bool Cancel);

  [DispId(1547)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeSave([In] bool SaveAsUI, [In, Out] ref bool Cancel);

  [DispId(1549)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforePrint([In, Out] ref bool Cancel);

  [DispId(1550)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NewSheet([MarshalAs(UnmanagedType.IDispatch), In] object Sh);

  [DispId(1552)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddinInstall();

  [DispId(1553)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddinUninstall();

  [DispId(1554)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowResize([MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [DispId(1556)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowActivate([MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [DispId(1557)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowDeactivate([MarshalAs(UnmanagedType.Interface), In] Window Wn);

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

  [DispId(1854)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetFollowHyperlink([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] Hyperlink Target);

  [DispId(2157)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetPivotTableUpdate([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] PivotTable Target);

  [DispId(2158)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableCloseConnection([MarshalAs(UnmanagedType.Interface), In] PivotTable Target);

  [DispId(2159)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableOpenConnection([MarshalAs(UnmanagedType.Interface), In] PivotTable Target);

  [DispId(2266)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Sync([In] MsoSyncEventType SyncEventType);

  [DispId(2283)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeXmlImport([MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [MarshalAs(UnmanagedType.BStr), In] string Url, [In] bool IsRefresh, [In, Out] ref bool Cancel);

  [DispId(2285)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AfterXmlImport([MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [In] bool IsRefresh, [In] XlXmlImportResult Result);

  [DispId(2287)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeXmlExport([MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [MarshalAs(UnmanagedType.BStr), In] string Url, [In, Out] ref bool Cancel);

  [DispId(2288)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AfterXmlExport([MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [MarshalAs(UnmanagedType.BStr), In] string Url, [In] XlXmlExportResult Result);

  [DispId(2610)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RowsetComplete([MarshalAs(UnmanagedType.BStr), In] string Description, [MarshalAs(UnmanagedType.BStr), In] string Sheet, [In] bool Success);
}
