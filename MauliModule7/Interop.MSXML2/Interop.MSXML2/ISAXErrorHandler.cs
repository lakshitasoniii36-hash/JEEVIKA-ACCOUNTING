// Decompiled with JetBrains decompiler
// Type: MSXML2.ISAXErrorHandler
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("A60511C4-CCF5-479E-98A3-DC8DC545B7D0")]
[TypeLibType(16 /*0x10*/)]
[InterfaceType(1)]
[ComImport]
public interface ISAXErrorHandler
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void error([MarshalAs(UnmanagedType.Interface), In] ISAXLocator pLocator, [In] ref ushort pwchErrorMessage, [MarshalAs(UnmanagedType.Error), In] int hrErrorCode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void fatalError([MarshalAs(UnmanagedType.Interface), In] ISAXLocator pLocator, [In] ref ushort pwchErrorMessage, [MarshalAs(UnmanagedType.Error), In] int hrErrorCode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ignorableWarning([MarshalAs(UnmanagedType.Interface), In] ISAXLocator pLocator, [In] ref ushort pwchErrorMessage, [MarshalAs(UnmanagedType.Error), In] int hrErrorCode);
}
