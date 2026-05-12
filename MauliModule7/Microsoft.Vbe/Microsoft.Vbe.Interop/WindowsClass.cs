// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop.WindowsClass
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

[ClassInterface(0)]
[DefaultMember("Item")]
[Guid("0002E185-0000-0000-C000-000000000046")]
[TypeLibType(2)]
[ComImport]
public class WindowsClass : _Windows, Windows
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern WindowsClass();

  [DispId(1)]
  public virtual extern VBE VBE { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2)]
  public virtual extern Application Parent { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Window Item([MarshalAs(UnmanagedType.Struct), In] object index);

  [DispId(201)]
  public virtual extern int Count { [DispId(201), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(1)]
  [DispId(-4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  public virtual extern IEnumerator GetEnumerator();

  [DispId(300)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Window CreateToolWindow(
    [MarshalAs(UnmanagedType.Interface), In] AddIn AddInInst,
    [MarshalAs(UnmanagedType.BStr), In] string ProgId,
    [MarshalAs(UnmanagedType.BStr), In] string Caption,
    [MarshalAs(UnmanagedType.BStr), In] string GuidPosition,
    [MarshalAs(UnmanagedType.IDispatch), In, Out] ref object DocObj);
}
