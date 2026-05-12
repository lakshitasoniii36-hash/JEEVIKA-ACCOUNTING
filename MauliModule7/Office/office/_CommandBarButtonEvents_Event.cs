// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core._CommandBarButtonEvents_Event
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[ComVisible(false)]
[ComEventInterface(typeof (_CommandBarButtonEvents), typeof (_CommandBarButtonEvents_EventProvider))]
[TypeLibType(16 /*0x10*/)]
public interface _CommandBarButtonEvents_Event
{
  event _CommandBarButtonEvents_ClickEventHandler Click;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Click([In] _CommandBarButtonEvents_ClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Click([In] _CommandBarButtonEvents_ClickEventHandler obj0);
}
