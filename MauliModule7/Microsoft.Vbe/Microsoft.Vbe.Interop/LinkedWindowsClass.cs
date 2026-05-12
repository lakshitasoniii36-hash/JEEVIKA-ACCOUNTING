// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop.LinkedWindowsClass
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Vbe.Interop;

[Guid("0002E187-0000-0000-C000-000000000046")]
[DefaultMember("Item")]
[TypeLibType(2)]
[ClassInterface(0)]
[ComImport]
public class LinkedWindowsClass : _LinkedWindows, LinkedWindows, IEnumerable
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern LinkedWindowsClass();

  [DispId(1)]
  public virtual extern VBE VBE { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2)]
  public virtual extern Window Parent { [TypeLibFunc(64 /*0x40*/), DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Window Item([MarshalAs(UnmanagedType.Struct), In] object index);

  [DispId(201)]
  public virtual extern int Count { [DispId(201), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(-4)]
  [TypeLibFunc(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  public virtual extern IEnumerator GetEnumerator();

  [DispId(202)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Remove([MarshalAs(UnmanagedType.Interface), In] Window Window);

  [DispId(203)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Add([MarshalAs(UnmanagedType.Interface), In] Window Window);
}
