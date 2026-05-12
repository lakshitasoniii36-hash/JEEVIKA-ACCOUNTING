// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop._dispReferences_Events
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[InterfaceType(2)]
[DefaultMember("ItemAdded")]
[Guid("CDDE3804-2064-11CF-867F-00AA005FF34A")]
[TypeLibType(4240)]
[ComImport]
public interface _dispReferences_Events
{
  [DispId(0)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ItemAdded([MarshalAs(UnmanagedType.Interface)] Reference Reference);

  [DispId(1)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ItemRemoved([MarshalAs(UnmanagedType.Interface)] Reference Reference);
}
