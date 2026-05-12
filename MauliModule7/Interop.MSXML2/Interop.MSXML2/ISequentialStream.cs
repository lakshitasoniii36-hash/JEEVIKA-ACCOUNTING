// Decompiled with JetBrains decompiler
// Type: MSXML2.ISequentialStream
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[InterfaceType(1)]
[Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D")]
[ComImport]
public interface ISequentialStream
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoteRead(out byte pv, [In] uint cb, out uint pcbRead);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoteWrite([In] ref byte pv, [In] uint cb, out uint pcbWritten);
}
