// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.IMsoEnvelopeVBEvents_Event
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(16 /*0x10*/)]
[ComVisible(false)]
[ComEventInterface(typeof (IMsoEnvelopeVBEvents), typeof (IMsoEnvelopeVBEvents_EventProvider))]
public interface IMsoEnvelopeVBEvents_Event
{
  event IMsoEnvelopeVBEvents_EnvelopeShowEventHandler EnvelopeShow;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_EnvelopeShow([In] IMsoEnvelopeVBEvents_EnvelopeShowEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_EnvelopeShow([In] IMsoEnvelopeVBEvents_EnvelopeShowEventHandler obj0);

  event IMsoEnvelopeVBEvents_EnvelopeHideEventHandler EnvelopeHide;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_EnvelopeHide([In] IMsoEnvelopeVBEvents_EnvelopeHideEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_EnvelopeHide([In] IMsoEnvelopeVBEvents_EnvelopeHideEventHandler obj0);
}
