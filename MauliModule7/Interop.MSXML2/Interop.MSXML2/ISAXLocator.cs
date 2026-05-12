// Decompiled with JetBrains decompiler
// Type: MSXML2.ISAXLocator
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("9B7E472A-0DE4-4640-BFF3-84D38A051C31")]
[ComConversionLoss]
[TypeLibType(16 /*0x10*/)]
[InterfaceType(1)]
[ComImport]
public interface ISAXLocator
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int getColumnNumber();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int getLineNumber();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  IntPtr getPublicId();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  IntPtr getSystemId();
}
