// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.OLEObjectEvents_Event
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[ComVisible(false)]
[ComEventInterface(typeof (OLEObjectEvents), typeof (OLEObjectEvents_EventProvider))]
[TypeLibType(16 /*0x10*/)]
public interface OLEObjectEvents_Event
{
  event OLEObjectEvents_GotFocusEventHandler GotFocus;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_GotFocus([In] OLEObjectEvents_GotFocusEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_GotFocus([In] OLEObjectEvents_GotFocusEventHandler obj0);

  event OLEObjectEvents_LostFocusEventHandler LostFocus;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_LostFocus([In] OLEObjectEvents_LostFocusEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_LostFocus([In] OLEObjectEvents_LostFocusEventHandler obj0);
}
