// Decompiled with JetBrains decompiler
// Type: ShockwaveFlashObjects._IShockwaveFlashEvents_Event
// Assembly: ShockwaveFlashObjects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 074923B7-35CE-44D7-AC6B-153DD1515B7D
// Assembly location: C:\WINDOWS\assembly\GAC\ShockwaveFlashObjects\1.0.0.0__692fbea5521e1304\ShockwaveFlashObjects.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace ShockwaveFlashObjects;

[ComVisible(false)]
[TypeLibType(16 /*0x10*/)]
[ComEventInterface(typeof (_IShockwaveFlashEvents), typeof (_IShockwaveFlashEvents_EventProvider))]
public interface _IShockwaveFlashEvents_Event
{
  event _IShockwaveFlashEvents_OnReadyStateChangeEventHandler OnReadyStateChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_OnReadyStateChange(
    [In] _IShockwaveFlashEvents_OnReadyStateChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_OnReadyStateChange(
    [In] _IShockwaveFlashEvents_OnReadyStateChangeEventHandler obj0);

  event _IShockwaveFlashEvents_OnProgressEventHandler OnProgress;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_OnProgress([In] _IShockwaveFlashEvents_OnProgressEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_OnProgress([In] _IShockwaveFlashEvents_OnProgressEventHandler obj0);

  event _IShockwaveFlashEvents_FSCommandEventHandler FSCommand;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_FSCommand([In] _IShockwaveFlashEvents_FSCommandEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_FSCommand([In] _IShockwaveFlashEvents_FSCommandEventHandler obj0);

  event _IShockwaveFlashEvents_FlashCallEventHandler FlashCall;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_FlashCall([In] _IShockwaveFlashEvents_FlashCallEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_FlashCall([In] _IShockwaveFlashEvents_FlashCallEventHandler obj0);
}
