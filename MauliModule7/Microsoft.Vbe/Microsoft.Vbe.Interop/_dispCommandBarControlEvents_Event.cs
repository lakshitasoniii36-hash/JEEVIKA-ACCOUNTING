// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop._dispCommandBarControlEvents_Event
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[TypeLibType(16 /*0x10*/)]
[ComEventInterface(typeof (_dispCommandBarControlEvents), typeof (_dispCommandBarControlEvents_EventProvider))]
[ComVisible(false)]
public interface _dispCommandBarControlEvents_Event
{
  event _dispCommandBarControlEvents_ClickEventHandler Click;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Click(
    [In] _dispCommandBarControlEvents_ClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Click(
    [In] _dispCommandBarControlEvents_ClickEventHandler obj0);
}
