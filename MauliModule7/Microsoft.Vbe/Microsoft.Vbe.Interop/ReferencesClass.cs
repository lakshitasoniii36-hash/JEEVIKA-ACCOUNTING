// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop.ReferencesClass
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

[Guid("0002E17C-0000-0000-C000-000000000046")]
[DefaultMember("Item")]
[TypeLibType(2)]
[ComSourceInterfaces("Microsoft.Vbe.Interop._dispReferences_Events\0\0")]
[ClassInterface(0)]
[ComImport]
public class ReferencesClass : _References, References, _dispReferences_Events_Event, IEnumerable
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern ReferencesClass();

  [DispId(1610743808 /*0x60020000*/)]
  public virtual extern VBProject Parent { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  public virtual extern VBE VBE { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Reference Item([MarshalAs(UnmanagedType.Struct), In] object index);

  [DispId(1610743811 /*0x60020003*/)]
  public virtual extern int Count { [DispId(1610743811 /*0x60020003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(-4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  public virtual extern IEnumerator GetEnumerator();

  [DispId(1610743813 /*0x60020005*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Reference AddFromGuid([MarshalAs(UnmanagedType.BStr), In] string Guid, [In] int Major, [In] int Minor);

  [DispId(1610743814 /*0x60020006*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Reference AddFromFile([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [DispId(1610743815 /*0x60020007*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Remove([MarshalAs(UnmanagedType.Interface), In] Reference Reference);

  public virtual extern event _dispReferences_Events_ItemAddedEventHandler ItemAdded;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_ItemAdded([In] _dispReferences_Events_ItemAddedEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_ItemAdded([In] _dispReferences_Events_ItemAddedEventHandler obj0);

  public virtual extern event _dispReferences_Events_ItemRemovedEventHandler ItemRemoved;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_ItemRemoved(
    [In] _dispReferences_Events_ItemRemovedEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_ItemRemoved(
    [In] _dispReferences_Events_ItemRemovedEventHandler obj0);
}
