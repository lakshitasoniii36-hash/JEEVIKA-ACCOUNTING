// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop._References
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
[TypeLibType(4304)]
[Guid("0002E17A-0000-0000-C000-000000000046")]
[ComImport]
public interface _References : IEnumerable
{
  [DispId(1610743808 /*0x60020000*/)]
  VBProject Parent { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  VBE VBE { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Reference Item([MarshalAs(UnmanagedType.Struct), In] object index);

  [DispId(1610743811 /*0x60020003*/)]
  int Count { [DispId(1610743811 /*0x60020003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(-4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(1610743813 /*0x60020005*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Reference AddFromGuid([MarshalAs(UnmanagedType.BStr), In] string Guid, [In] int Major, [In] int Minor);

  [DispId(1610743814 /*0x60020006*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Reference AddFromFile([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [DispId(1610743815 /*0x60020007*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Remove([MarshalAs(UnmanagedType.Interface), In] Reference Reference);
}
