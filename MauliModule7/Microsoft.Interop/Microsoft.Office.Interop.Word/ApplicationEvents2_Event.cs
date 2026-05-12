// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.ApplicationEvents2_Event
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[TypeLibType(16 /*0x10*/)]
[ComVisible(false)]
[ComEventInterface(typeof (ApplicationEvents2), typeof (ApplicationEvents2_EventProvider))]
public interface ApplicationEvents2_Event
{
  event ApplicationEvents2_StartupEventHandler Startup;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Startup([In] ApplicationEvents2_StartupEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Startup([In] ApplicationEvents2_StartupEventHandler obj0);

  event ApplicationEvents2_QuitEventHandler Quit;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Quit([In] ApplicationEvents2_QuitEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Quit([In] ApplicationEvents2_QuitEventHandler obj0);

  event ApplicationEvents2_DocumentChangeEventHandler DocumentChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentChange([In] ApplicationEvents2_DocumentChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentChange([In] ApplicationEvents2_DocumentChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentOpen([In] ApplicationEvents2_DocumentOpenEventHandler obj0);

  event ApplicationEvents2_DocumentOpenEventHandler DocumentOpen;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentOpen([In] ApplicationEvents2_DocumentOpenEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentBeforeClose(
    [In] ApplicationEvents2_DocumentBeforeCloseEventHandler obj0);

  event ApplicationEvents2_DocumentBeforeCloseEventHandler DocumentBeforeClose;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentBeforeClose(
    [In] ApplicationEvents2_DocumentBeforeCloseEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentBeforePrint(
    [In] ApplicationEvents2_DocumentBeforePrintEventHandler obj0);

  event ApplicationEvents2_DocumentBeforePrintEventHandler DocumentBeforePrint;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentBeforePrint(
    [In] ApplicationEvents2_DocumentBeforePrintEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentBeforeSave(
    [In] ApplicationEvents2_DocumentBeforeSaveEventHandler obj0);

  event ApplicationEvents2_DocumentBeforeSaveEventHandler DocumentBeforeSave;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentBeforeSave(
    [In] ApplicationEvents2_DocumentBeforeSaveEventHandler obj0);

  event ApplicationEvents2_NewDocumentEventHandler NewDocument;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_NewDocument([In] ApplicationEvents2_NewDocumentEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_NewDocument([In] ApplicationEvents2_NewDocumentEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowActivate([In] ApplicationEvents2_WindowActivateEventHandler obj0);

  event ApplicationEvents2_WindowActivateEventHandler WindowActivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowActivate([In] ApplicationEvents2_WindowActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowDeactivate(
    [In] ApplicationEvents2_WindowDeactivateEventHandler obj0);

  event ApplicationEvents2_WindowDeactivateEventHandler WindowDeactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowDeactivate(
    [In] ApplicationEvents2_WindowDeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowSelectionChange(
    [In] ApplicationEvents2_WindowSelectionChangeEventHandler obj0);

  event ApplicationEvents2_WindowSelectionChangeEventHandler WindowSelectionChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowSelectionChange(
    [In] ApplicationEvents2_WindowSelectionChangeEventHandler obj0);

  event ApplicationEvents2_WindowBeforeRightClickEventHandler WindowBeforeRightClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowBeforeRightClick(
    [In] ApplicationEvents2_WindowBeforeRightClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowBeforeRightClick(
    [In] ApplicationEvents2_WindowBeforeRightClickEventHandler obj0);

  event ApplicationEvents2_WindowBeforeDoubleClickEventHandler WindowBeforeDoubleClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowBeforeDoubleClick(
    [In] ApplicationEvents2_WindowBeforeDoubleClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowBeforeDoubleClick(
    [In] ApplicationEvents2_WindowBeforeDoubleClickEventHandler obj0);
}
