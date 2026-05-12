// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.DocumentEvents2
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[InterfaceType(2)]
[Guid("00020A02-0000-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface DocumentEvents2
{
  [DispId(4)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void New();

  [DispId(5)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Open();

  [DispId(6)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Close();

  [DispId(7)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Sync(MsoSyncEventType SyncEventType);

  [DispId(8)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void XMLAfterInsert([MarshalAs(UnmanagedType.Interface), In] XMLNode NewXMLNode, [In] bool InUndoRedo);

  [DispId(9)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void XMLBeforeDelete([MarshalAs(UnmanagedType.Interface), In] Range DeletedRange, [MarshalAs(UnmanagedType.Interface), In] XMLNode OldXMLNode, [In] bool InUndoRedo);

  [DispId(12)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ContentControlAfterAdd([MarshalAs(UnmanagedType.Interface), In] ContentControl NewContentControl, [In] bool InUndoRedo);

  [DispId(13)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ContentControlBeforeDelete([MarshalAs(UnmanagedType.Interface), In] ContentControl OldContentControl, [In] bool InUndoRedo);

  [DispId(14)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ContentControlOnExit([MarshalAs(UnmanagedType.Interface), In] ContentControl ContentControl, [In, Out] ref bool Cancel);

  [DispId(15)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ContentControlOnEnter([MarshalAs(UnmanagedType.Interface), In] ContentControl ContentControl);

  [DispId(16 /*0x10*/)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ContentControlBeforeStoreUpdate([MarshalAs(UnmanagedType.Interface), In] ContentControl ContentControl, [MarshalAs(UnmanagedType.BStr), In, Out] ref string Content);

  [DispId(17)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ContentControlBeforeContentUpdate([MarshalAs(UnmanagedType.Interface), In] ContentControl ContentControl, [MarshalAs(UnmanagedType.BStr), In, Out] ref string Content);

  [DispId(18)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BuildingBlockInsert(
    [MarshalAs(UnmanagedType.Interface), In] Range Range,
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.BStr), In] string Category,
    [MarshalAs(UnmanagedType.BStr), In] string BlockType,
    [MarshalAs(UnmanagedType.BStr), In] string Template);
}
