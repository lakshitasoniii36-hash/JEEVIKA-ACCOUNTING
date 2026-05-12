// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop._dispReferences_Events_Event
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[ComVisible(false)]
[ComEventInterface(typeof (_dispReferences_Events), typeof (_dispReferences_Events_EventProvider))]
[TypeLibType(16 /*0x10*/)]
public interface _dispReferences_Events_Event
{
  event _dispReferences_Events_ItemAddedEventHandler ItemAdded;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_ItemAdded([In] _dispReferences_Events_ItemAddedEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_ItemAdded([In] _dispReferences_Events_ItemAddedEventHandler obj0);

  event _dispReferences_Events_ItemRemovedEventHandler ItemRemoved;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_ItemRemoved(
    [In] _dispReferences_Events_ItemRemovedEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_ItemRemoved(
    [In] _dispReferences_Events_ItemRemovedEventHandler obj0);
}
