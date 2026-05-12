// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop._dispReferencesEvents_Event
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[TypeLibType(16 /*0x10*/)]
[ComVisible(false)]
[ComEventInterface(typeof (_dispReferencesEvents), typeof (_dispReferencesEvents_EventProvider))]
public interface _dispReferencesEvents_Event
{
  event _dispReferencesEvents_ItemAddedEventHandler ItemAdded;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_ItemAdded([In] _dispReferencesEvents_ItemAddedEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_ItemAdded([In] _dispReferencesEvents_ItemAddedEventHandler obj0);

  event _dispReferencesEvents_ItemRemovedEventHandler ItemRemoved;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_ItemRemoved([In] _dispReferencesEvents_ItemRemovedEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_ItemRemoved([In] _dispReferencesEvents_ItemRemovedEventHandler obj0);
}
