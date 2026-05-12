// Decompiled with JetBrains decompiler
// Type: ShockwaveFlashObjects._IShockwaveFlashEvents
// Assembly: ShockwaveFlashObjects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 074923B7-35CE-44D7-AC6B-153DD1515B7D
// Assembly location: C:\WINDOWS\assembly\GAC\ShockwaveFlashObjects\1.0.0.0__692fbea5521e1304\ShockwaveFlashObjects.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace ShockwaveFlashObjects;

[Guid("D27CDB6D-AE6D-11CF-96B8-444553540000")]
[TypeLibType(4112)]
[InterfaceType(2)]
[ComImport]
public interface _IShockwaveFlashEvents
{
  [DispId(-609)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OnReadyStateChange(int newState);

  [DispId(1958)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OnProgress(int percentDone);

  [DispId(150)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void FSCommand([MarshalAs(UnmanagedType.BStr), In] string command, [MarshalAs(UnmanagedType.BStr), In] string args);

  [DispId(197)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void FlashCall([MarshalAs(UnmanagedType.BStr), In] string request);
}
