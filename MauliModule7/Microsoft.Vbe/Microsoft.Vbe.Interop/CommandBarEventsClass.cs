// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop.CommandBarEventsClass
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[TypeLibType(2)]
[Guid("0002E132-0000-0000-C000-000000000046")]
[ClassInterface(0)]
[ComSourceInterfaces("Microsoft.Vbe.Interop._dispCommandBarControlEvents\0\0")]
[ComImport]
public class CommandBarEventsClass : 
  _CommandBarControlEvents,
  CommandBarEvents,
  _dispCommandBarControlEvents_Event
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern CommandBarEventsClass();

  public virtual extern event _dispCommandBarControlEvents_ClickEventHandler Click;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Click(
    [In] _dispCommandBarControlEvents_ClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Click(
    [In] _dispCommandBarControlEvents_ClickEventHandler obj0);
}
