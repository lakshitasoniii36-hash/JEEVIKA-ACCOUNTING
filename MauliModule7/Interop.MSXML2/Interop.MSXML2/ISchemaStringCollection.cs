// Decompiled with JetBrains decompiler
// Type: MSXML2.ISchemaStringCollection
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace MSXML2;

[Guid("50EA08B1-DD1B-4664-9A50-C2F40F4BD79A")]
[TypeLibType(4288)]
[ComImport]
public interface ISchemaStringCollection : IEnumerable
{
  [DispId(0)]
  [IndexerName("item")]
  string this[[In] int index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1447)]
  int length { [DispId(1447), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(65)]
  [DispId(-4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();
}
