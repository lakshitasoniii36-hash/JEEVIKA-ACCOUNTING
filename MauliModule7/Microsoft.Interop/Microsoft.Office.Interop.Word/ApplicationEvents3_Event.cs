// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.ApplicationEvents3_Event
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[ComEventInterface(typeof (ApplicationEvents3), typeof (ApplicationEvents3_EventProvider))]
[TypeLibType(16 /*0x10*/)]
[ComVisible(false)]
public interface ApplicationEvents3_Event
{
  event ApplicationEvents3_StartupEventHandler Startup;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Startup([In] ApplicationEvents3_StartupEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Startup([In] ApplicationEvents3_StartupEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Quit([In] ApplicationEvents3_QuitEventHandler obj0);

  event ApplicationEvents3_QuitEventHandler Quit;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Quit([In] ApplicationEvents3_QuitEventHandler obj0);

  event ApplicationEvents3_DocumentChangeEventHandler DocumentChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentChange([In] ApplicationEvents3_DocumentChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentChange([In] ApplicationEvents3_DocumentChangeEventHandler obj0);

  event ApplicationEvents3_DocumentOpenEventHandler DocumentOpen;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentOpen([In] ApplicationEvents3_DocumentOpenEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentOpen([In] ApplicationEvents3_DocumentOpenEventHandler obj0);

  event ApplicationEvents3_DocumentBeforeCloseEventHandler DocumentBeforeClose;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentBeforeClose(
    [In] ApplicationEvents3_DocumentBeforeCloseEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentBeforeClose(
    [In] ApplicationEvents3_DocumentBeforeCloseEventHandler obj0);

  event ApplicationEvents3_DocumentBeforePrintEventHandler DocumentBeforePrint;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentBeforePrint(
    [In] ApplicationEvents3_DocumentBeforePrintEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentBeforePrint(
    [In] ApplicationEvents3_DocumentBeforePrintEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentBeforeSave(
    [In] ApplicationEvents3_DocumentBeforeSaveEventHandler obj0);

  event ApplicationEvents3_DocumentBeforeSaveEventHandler DocumentBeforeSave;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentBeforeSave(
    [In] ApplicationEvents3_DocumentBeforeSaveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_NewDocument([In] ApplicationEvents3_NewDocumentEventHandler obj0);

  event ApplicationEvents3_NewDocumentEventHandler NewDocument;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_NewDocument([In] ApplicationEvents3_NewDocumentEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowActivate([In] ApplicationEvents3_WindowActivateEventHandler obj0);

  event ApplicationEvents3_WindowActivateEventHandler WindowActivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowActivate([In] ApplicationEvents3_WindowActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowDeactivate(
    [In] ApplicationEvents3_WindowDeactivateEventHandler obj0);

  event ApplicationEvents3_WindowDeactivateEventHandler WindowDeactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowDeactivate(
    [In] ApplicationEvents3_WindowDeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowSelectionChange(
    [In] ApplicationEvents3_WindowSelectionChangeEventHandler obj0);

  event ApplicationEvents3_WindowSelectionChangeEventHandler WindowSelectionChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowSelectionChange(
    [In] ApplicationEvents3_WindowSelectionChangeEventHandler obj0);

  event ApplicationEvents3_WindowBeforeRightClickEventHandler WindowBeforeRightClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowBeforeRightClick(
    [In] ApplicationEvents3_WindowBeforeRightClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowBeforeRightClick(
    [In] ApplicationEvents3_WindowBeforeRightClickEventHandler obj0);

  event ApplicationEvents3_WindowBeforeDoubleClickEventHandler WindowBeforeDoubleClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowBeforeDoubleClick(
    [In] ApplicationEvents3_WindowBeforeDoubleClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowBeforeDoubleClick(
    [In] ApplicationEvents3_WindowBeforeDoubleClickEventHandler obj0);

  event ApplicationEvents3_EPostagePropertyDialogEventHandler EPostagePropertyDialog;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_EPostagePropertyDialog(
    [In] ApplicationEvents3_EPostagePropertyDialogEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_EPostagePropertyDialog(
    [In] ApplicationEvents3_EPostagePropertyDialogEventHandler obj0);

  event ApplicationEvents3_EPostageInsertEventHandler EPostageInsert;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_EPostageInsert([In] ApplicationEvents3_EPostageInsertEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_EPostageInsert([In] ApplicationEvents3_EPostageInsertEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeAfterMerge(
    [In] ApplicationEvents3_MailMergeAfterMergeEventHandler obj0);

  event ApplicationEvents3_MailMergeAfterMergeEventHandler MailMergeAfterMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeAfterMerge(
    [In] ApplicationEvents3_MailMergeAfterMergeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeAfterRecordMerge(
    [In] ApplicationEvents3_MailMergeAfterRecordMergeEventHandler obj0);

  event ApplicationEvents3_MailMergeAfterRecordMergeEventHandler MailMergeAfterRecordMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeAfterRecordMerge(
    [In] ApplicationEvents3_MailMergeAfterRecordMergeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeBeforeMerge(
    [In] ApplicationEvents3_MailMergeBeforeMergeEventHandler obj0);

  event ApplicationEvents3_MailMergeBeforeMergeEventHandler MailMergeBeforeMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeBeforeMerge(
    [In] ApplicationEvents3_MailMergeBeforeMergeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeBeforeRecordMerge(
    [In] ApplicationEvents3_MailMergeBeforeRecordMergeEventHandler obj0);

  event ApplicationEvents3_MailMergeBeforeRecordMergeEventHandler MailMergeBeforeRecordMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeBeforeRecordMerge(
    [In] ApplicationEvents3_MailMergeBeforeRecordMergeEventHandler obj0);

  event ApplicationEvents3_MailMergeDataSourceLoadEventHandler MailMergeDataSourceLoad;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeDataSourceLoad(
    [In] ApplicationEvents3_MailMergeDataSourceLoadEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeDataSourceLoad(
    [In] ApplicationEvents3_MailMergeDataSourceLoadEventHandler obj0);

  event ApplicationEvents3_MailMergeDataSourceValidateEventHandler MailMergeDataSourceValidate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeDataSourceValidate(
    [In] ApplicationEvents3_MailMergeDataSourceValidateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeDataSourceValidate(
    [In] ApplicationEvents3_MailMergeDataSourceValidateEventHandler obj0);

  event ApplicationEvents3_MailMergeWizardSendToCustomEventHandler MailMergeWizardSendToCustom;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeWizardSendToCustom(
    [In] ApplicationEvents3_MailMergeWizardSendToCustomEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeWizardSendToCustom(
    [In] ApplicationEvents3_MailMergeWizardSendToCustomEventHandler obj0);

  event ApplicationEvents3_MailMergeWizardStateChangeEventHandler MailMergeWizardStateChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeWizardStateChange(
    [In] ApplicationEvents3_MailMergeWizardStateChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeWizardStateChange(
    [In] ApplicationEvents3_MailMergeWizardStateChangeEventHandler obj0);

  event ApplicationEvents3_WindowSizeEventHandler WindowSize;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowSize([In] ApplicationEvents3_WindowSizeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowSize([In] ApplicationEvents3_WindowSizeEventHandler obj0);
}
