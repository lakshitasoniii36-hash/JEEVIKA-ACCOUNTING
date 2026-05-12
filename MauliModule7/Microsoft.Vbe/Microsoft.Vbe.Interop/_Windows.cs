// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop._Windows
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

[DefaultMember("Item")]
[Guid("F57B7ED0-D8AB-11D1-85DF-00C04F98F42C")]
[TypeLibType(4160)]
[ComImport]
public interface _Windows : _Windows_old
{
  [DispId(1)]
  new VBE VBE { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2)]
  new Application Parent { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  new Window Item([MarshalAs(UnmanagedType.Struct), In] object index);

  [DispId(201)]
  new int Count { [DispId(201), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(-4)]
  [TypeLibFunc(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(300)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Window CreateToolWindow(
    [MarshalAs(UnmanagedType.Interface), In] AddIn AddInInst,
    [MarshalAs(UnmanagedType.BStr), In] string ProgId,
    [MarshalAs(UnmanagedType.BStr), In] string Caption,
    [MarshalAs(UnmanagedType.BStr), In] string GuidPosition,
    [MarshalAs(UnmanagedType.IDispatch), In, Out] ref object DocObj);
}
