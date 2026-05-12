// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.MsoEnvelopeClass
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[ClassInterface(0)]
[ComSourceInterfaces("Microsoft.Office.Core.IMsoEnvelopeVBEvents\0\0")]
[Guid("0006F01A-0000-0000-C000-000000000046")]
[ComImport]
public class MsoEnvelopeClass : IMsoEnvelopeVB, MsoEnvelope, IMsoEnvelopeVBEvents_Event
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  internal extern MsoEnvelopeClass();

  [DispId(1)]
  public virtual extern string Introduction { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(2)]
  public virtual extern object Item { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(3)]
  public virtual extern object Parent { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(4)]
  public virtual extern object CommandBars { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  public virtual extern event IMsoEnvelopeVBEvents_EnvelopeShowEventHandler EnvelopeShow;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_EnvelopeShow([In] IMsoEnvelopeVBEvents_EnvelopeShowEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_EnvelopeShow([In] IMsoEnvelopeVBEvents_EnvelopeShowEventHandler obj0);

  public virtual extern event IMsoEnvelopeVBEvents_EnvelopeHideEventHandler EnvelopeHide;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_EnvelopeHide([In] IMsoEnvelopeVBEvents_EnvelopeHideEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_EnvelopeHide([In] IMsoEnvelopeVBEvents_EnvelopeHideEventHandler obj0);
}
