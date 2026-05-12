// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop.Property
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[Guid("0002E18C-0000-0000-C000-000000000046")]
[DefaultMember("Value")]
[TypeLibType(4160)]
[ComImport]
public interface Property
{
  [DispId(0)]
  object Value { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object get_IndexedValue([MarshalAs(UnmanagedType.Struct), In] object Index1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Index2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Index3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Index4);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void set_IndexedValue(
    [MarshalAs(UnmanagedType.Struct), In] object Index1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Index2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Index3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Index4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object lppvReturn);

  [DispId(4)]
  short NumIndices { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1)]
  Application Application { [TypeLibFunc(64 /*0x40*/), DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2)]
  Properties Parent { [TypeLibFunc(64 /*0x40*/), DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(40)]
  string Name { [DispId(40), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(41)]
  VBE VBE { [DispId(41), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(42)]
  Properties Collection { [DispId(42), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(45)]
  object Object { [DispId(45), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IUnknown)] get; [DispId(45), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IUnknown), In] set; }
}
