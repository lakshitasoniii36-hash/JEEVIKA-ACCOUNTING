// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop.Events
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[Guid("0002E167-0000-0000-C000-000000000046")]
[TypeLibType(4160)]
[ComImport]
public interface Events
{
  [DispId(202)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ReferencesEvents get_ReferencesEvents([MarshalAs(UnmanagedType.Interface), In] VBProject VBProject);

  [DispId(205)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CommandBarEvents get_CommandBarEvents([MarshalAs(UnmanagedType.IDispatch), In] object CommandBarControl);
}
