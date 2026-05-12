// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.RefreshEvents_Event
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[ComEventInterface(typeof (RefreshEvents), typeof (RefreshEvents_EventProvider))]
[TypeLibType(16 /*0x10*/)]
[ComVisible(false)]
public interface RefreshEvents_Event
{
  event RefreshEvents_BeforeRefreshEventHandler BeforeRefresh;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_BeforeRefresh([In] RefreshEvents_BeforeRefreshEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_BeforeRefresh([In] RefreshEvents_BeforeRefreshEventHandler obj0);

  event RefreshEvents_AfterRefreshEventHandler AfterRefresh;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_AfterRefresh([In] RefreshEvents_AfterRefreshEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_AfterRefresh([In] RefreshEvents_AfterRefreshEventHandler obj0);
}
