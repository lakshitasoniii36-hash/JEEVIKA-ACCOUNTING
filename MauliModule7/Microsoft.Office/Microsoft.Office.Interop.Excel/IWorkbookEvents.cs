// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IWorkbookEvents
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(4112)]
[Guid("00024412-0001-0000-C000-000000000046")]
[ComImport]
public interface IWorkbookEvents
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Open();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Activate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Deactivate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeClose([In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeSave([In] bool SaveAsUI, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforePrint([In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NewSheet([MarshalAs(UnmanagedType.IDispatch), In] object Sh);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddinInstall();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddinUninstall();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowResize([MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowActivate([MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowDeactivate([MarshalAs(UnmanagedType.Interface), In] Window Wn);

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
  void SheetFollowHyperlink([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] Hyperlink Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SheetPivotTableUpdate([MarshalAs(UnmanagedType.IDispatch), In] object Sh, [MarshalAs(UnmanagedType.Interface), In] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableCloseConnection([MarshalAs(UnmanagedType.Interface), In] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableOpenConnection([MarshalAs(UnmanagedType.Interface), In] PivotTable Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Sync([In] MsoSyncEventType SyncEventType);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeXmlImport([MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [MarshalAs(UnmanagedType.BStr), In] string Url, [In] bool IsRefresh, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AfterXmlImport([MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [In] bool IsRefresh, [In] XlXmlImportResult Result);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeXmlExport([MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [MarshalAs(UnmanagedType.BStr), In] string Url, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AfterXmlExport([MarshalAs(UnmanagedType.Interface), In] XmlMap Map, [MarshalAs(UnmanagedType.BStr), In] string Url, [In] XlXmlExportResult Result);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RowsetComplete([MarshalAs(UnmanagedType.BStr), In] string Description, [MarshalAs(UnmanagedType.BStr), In] string Sheet, [In] bool Success);
}
