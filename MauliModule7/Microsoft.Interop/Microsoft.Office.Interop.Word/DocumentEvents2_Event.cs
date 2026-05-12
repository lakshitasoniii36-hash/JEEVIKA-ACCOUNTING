// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.DocumentEvents2_Event
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[ComVisible(false)]
[TypeLibType(16 /*0x10*/)]
[ComEventInterface(typeof (DocumentEvents2), typeof (DocumentEvents2_EventProvider))]
public interface DocumentEvents2_Event
{
  event DocumentEvents2_NewEventHandler New;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_New([In] DocumentEvents2_NewEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_New([In] DocumentEvents2_NewEventHandler obj0);

  event DocumentEvents2_OpenEventHandler Open;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Open([In] DocumentEvents2_OpenEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Open([In] DocumentEvents2_OpenEventHandler obj0);

  event DocumentEvents2_CloseEventHandler Close;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Close([In] DocumentEvents2_CloseEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Close([In] DocumentEvents2_CloseEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Sync([In] DocumentEvents2_SyncEventHandler obj0);

  event DocumentEvents2_SyncEventHandler Sync;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Sync([In] DocumentEvents2_SyncEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_XMLAfterInsert([In] DocumentEvents2_XMLAfterInsertEventHandler obj0);

  event DocumentEvents2_XMLAfterInsertEventHandler XMLAfterInsert;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_XMLAfterInsert([In] DocumentEvents2_XMLAfterInsertEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_XMLBeforeDelete([In] DocumentEvents2_XMLBeforeDeleteEventHandler obj0);

  event DocumentEvents2_XMLBeforeDeleteEventHandler XMLBeforeDelete;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_XMLBeforeDelete([In] DocumentEvents2_XMLBeforeDeleteEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_ContentControlAfterAdd(
    [In] DocumentEvents2_ContentControlAfterAddEventHandler obj0);

  event DocumentEvents2_ContentControlAfterAddEventHandler ContentControlAfterAdd;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_ContentControlAfterAdd(
    [In] DocumentEvents2_ContentControlAfterAddEventHandler obj0);

  event DocumentEvents2_ContentControlBeforeDeleteEventHandler ContentControlBeforeDelete;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_ContentControlBeforeDelete(
    [In] DocumentEvents2_ContentControlBeforeDeleteEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_ContentControlBeforeDelete(
    [In] DocumentEvents2_ContentControlBeforeDeleteEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_ContentControlOnExit(
    [In] DocumentEvents2_ContentControlOnExitEventHandler obj0);

  event DocumentEvents2_ContentControlOnExitEventHandler ContentControlOnExit;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_ContentControlOnExit(
    [In] DocumentEvents2_ContentControlOnExitEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_ContentControlOnEnter(
    [In] DocumentEvents2_ContentControlOnEnterEventHandler obj0);

  event DocumentEvents2_ContentControlOnEnterEventHandler ContentControlOnEnter;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_ContentControlOnEnter(
    [In] DocumentEvents2_ContentControlOnEnterEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_ContentControlBeforeStoreUpdate(
    [In] DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler obj0);

  event DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler ContentControlBeforeStoreUpdate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_ContentControlBeforeStoreUpdate(
    [In] DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler obj0);

  event DocumentEvents2_ContentControlBeforeContentUpdateEventHandler ContentControlBeforeContentUpdate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_ContentControlBeforeContentUpdate(
    [In] DocumentEvents2_ContentControlBeforeContentUpdateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_ContentControlBeforeContentUpdate(
    [In] DocumentEvents2_ContentControlBeforeContentUpdateEventHandler obj0);

  event DocumentEvents2_BuildingBlockInsertEventHandler BuildingBlockInsert;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_BuildingBlockInsert(
    [In] DocumentEvents2_BuildingBlockInsertEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_BuildingBlockInsert(
    [In] DocumentEvents2_BuildingBlockInsertEventHandler obj0);
}
