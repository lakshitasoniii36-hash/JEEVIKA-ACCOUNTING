// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop._dispCommandBarControlEvents
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[Guid("0002E131-0000-0000-C000-000000000046")]
[InterfaceType(2)]
[TypeLibType(4096 /*0x1000*/)]
[ComImport]
public interface _dispCommandBarControlEvents
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Click([MarshalAs(UnmanagedType.IDispatch), In] object CommandBarControl, [In] ref bool handled, [In] ref bool CancelDefault);
}
