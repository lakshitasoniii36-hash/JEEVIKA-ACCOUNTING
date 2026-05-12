// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.OCXEvents_Event
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[TypeLibType(16 /*0x10*/)]
[ComEventInterface(typeof (OCXEvents), typeof (OCXEvents_EventProvider))]
[ComVisible(false)]
public interface OCXEvents_Event
{
  event OCXEvents_GotFocusEventHandler GotFocus;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_GotFocus([In] OCXEvents_GotFocusEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_GotFocus([In] OCXEvents_GotFocusEventHandler obj0);

  event OCXEvents_LostFocusEventHandler LostFocus;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_LostFocus([In] OCXEvents_LostFocusEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_LostFocus([In] OCXEvents_LostFocusEventHandler obj0);
}
