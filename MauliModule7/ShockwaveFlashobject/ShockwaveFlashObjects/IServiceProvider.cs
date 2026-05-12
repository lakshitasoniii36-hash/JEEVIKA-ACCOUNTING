// Decompiled with JetBrains decompiler
// Type: ShockwaveFlashObjects.IServiceProvider
// Assembly: ShockwaveFlashObjects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 074923B7-35CE-44D7-AC6B-153DD1515B7D
// Assembly location: C:\WINDOWS\assembly\GAC\ShockwaveFlashObjects\1.0.0.0__692fbea5521e1304\ShockwaveFlashObjects.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace ShockwaveFlashObjects;

[Guid("6D5140C1-7436-11CE-8034-00AA006009FA")]
[InterfaceType(1)]
[ComImport]
public interface IServiceProvider
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoteQueryService([In] ref Guid guidService, [In] ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
}
