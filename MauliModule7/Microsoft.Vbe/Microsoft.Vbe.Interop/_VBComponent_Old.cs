// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop._VBComponent_Old
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[TypeLibType(4176)]
[Guid("0002E164-0000-0000-C000-000000000046")]
[ComImport]
public interface _VBComponent_Old
{
  [DispId(10)]
  bool Saved { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(48 /*0x30*/)]
  string Name { [DispId(48 /*0x30*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(48 /*0x30*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(49)]
  object Designer { [DispId(49), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(50)]
  CodeModule CodeModule { [DispId(50), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(51)]
  vbext_ComponentType Type { [DispId(51), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(52)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Export([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [DispId(53)]
  VBE VBE { [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(54)]
  VBComponents Collection { [DispId(54), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(55)]
  bool HasOpenDesigner { [DispId(55), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(56)]
  Properties Properties { [DispId(56), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(57)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Window DesignerWindow();

  [DispId(60)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Activate();
}
