// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop.ReferencesEventsClass
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[ClassInterface(0)]
[ComSourceInterfaces("Microsoft.Vbe.Interop._dispReferencesEvents\0\0")]
[Guid("0002E119-0000-0000-C000-000000000046")]
[TypeLibType(2)]
[ComImport]
public class ReferencesEventsClass : _ReferencesEvents, ReferencesEvents, _dispReferencesEvents_Event
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern ReferencesEventsClass();

  public virtual extern event _dispReferencesEvents_ItemAddedEventHandler ItemAdded;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_ItemAdded([In] _dispReferencesEvents_ItemAddedEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_ItemAdded([In] _dispReferencesEvents_ItemAddedEventHandler obj0);

  public virtual extern event _dispReferencesEvents_ItemRemovedEventHandler ItemRemoved;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_ItemRemoved([In] _dispReferencesEvents_ItemRemovedEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_ItemRemoved([In] _dispReferencesEvents_ItemRemovedEventHandler obj0);
}
