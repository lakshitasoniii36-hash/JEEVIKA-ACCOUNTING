// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop._dispVBComponentsEvents
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[TypeLibType(4096 /*0x1000*/)]
[InterfaceType(2)]
[Guid("0002E116-0000-0000-C000-000000000046")]
[ComImport]
public interface _dispVBComponentsEvents
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ItemAdded([MarshalAs(UnmanagedType.Interface), In] VBComponent VBComponent);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ItemRemoved([MarshalAs(UnmanagedType.Interface), In] VBComponent VBComponent);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ItemRenamed([MarshalAs(UnmanagedType.Interface), In] VBComponent VBComponent, [MarshalAs(UnmanagedType.BStr), In] string OldName);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ItemSelected([MarshalAs(UnmanagedType.Interface), In] VBComponent VBComponent);

  [DispId(5)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ItemActivated([MarshalAs(UnmanagedType.Interface), In] VBComponent VBComponent);

  [DispId(6)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ItemReloaded([MarshalAs(UnmanagedType.Interface), In] VBComponent VBComponent);
}
