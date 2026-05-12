// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.ApplicationEvents4_Event
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[TypeLibType(16 /*0x10*/)]
[ComEventInterface(typeof (ApplicationEvents4), typeof (ApplicationEvents4_EventProvider))]
[ComVisible(false)]
public interface ApplicationEvents4_Event
{
  event ApplicationEvents4_StartupEventHandler Startup;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Startup([In] ApplicationEvents4_StartupEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Startup([In] ApplicationEvents4_StartupEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_Quit([In] ApplicationEvents4_QuitEventHandler obj0);

  event ApplicationEvents4_QuitEventHandler Quit;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_Quit([In] ApplicationEvents4_QuitEventHandler obj0);

  event ApplicationEvents4_DocumentChangeEventHandler DocumentChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentChange([In] ApplicationEvents4_DocumentChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentChange([In] ApplicationEvents4_DocumentChangeEventHandler obj0);

  event ApplicationEvents4_DocumentOpenEventHandler DocumentOpen;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentOpen([In] ApplicationEvents4_DocumentOpenEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentOpen([In] ApplicationEvents4_DocumentOpenEventHandler obj0);

  event ApplicationEvents4_DocumentBeforeCloseEventHandler DocumentBeforeClose;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentBeforeClose(
    [In] ApplicationEvents4_DocumentBeforeCloseEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentBeforeClose(
    [In] ApplicationEvents4_DocumentBeforeCloseEventHandler obj0);

  event ApplicationEvents4_DocumentBeforePrintEventHandler DocumentBeforePrint;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentBeforePrint(
    [In] ApplicationEvents4_DocumentBeforePrintEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentBeforePrint(
    [In] ApplicationEvents4_DocumentBeforePrintEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentBeforeSave(
    [In] ApplicationEvents4_DocumentBeforeSaveEventHandler obj0);

  event ApplicationEvents4_DocumentBeforeSaveEventHandler DocumentBeforeSave;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentBeforeSave(
    [In] ApplicationEvents4_DocumentBeforeSaveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_NewDocument([In] ApplicationEvents4_NewDocumentEventHandler obj0);

  event ApplicationEvents4_NewDocumentEventHandler NewDocument;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_NewDocument([In] ApplicationEvents4_NewDocumentEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowActivate([In] ApplicationEvents4_WindowActivateEventHandler obj0);

  event ApplicationEvents4_WindowActivateEventHandler WindowActivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowActivate([In] ApplicationEvents4_WindowActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowDeactivate(
    [In] ApplicationEvents4_WindowDeactivateEventHandler obj0);

  event ApplicationEvents4_WindowDeactivateEventHandler WindowDeactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowDeactivate(
    [In] ApplicationEvents4_WindowDeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowSelectionChange(
    [In] ApplicationEvents4_WindowSelectionChangeEventHandler obj0);

  event ApplicationEvents4_WindowSelectionChangeEventHandler WindowSelectionChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowSelectionChange(
    [In] ApplicationEvents4_WindowSelectionChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowBeforeRightClick(
    [In] ApplicationEvents4_WindowBeforeRightClickEventHandler obj0);

  event ApplicationEvents4_WindowBeforeRightClickEventHandler WindowBeforeRightClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowBeforeRightClick(
    [In] ApplicationEvents4_WindowBeforeRightClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowBeforeDoubleClick(
    [In] ApplicationEvents4_WindowBeforeDoubleClickEventHandler obj0);

  event ApplicationEvents4_WindowBeforeDoubleClickEventHandler WindowBeforeDoubleClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowBeforeDoubleClick(
    [In] ApplicationEvents4_WindowBeforeDoubleClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_EPostagePropertyDialog(
    [In] ApplicationEvents4_EPostagePropertyDialogEventHandler obj0);

  event ApplicationEvents4_EPostagePropertyDialogEventHandler EPostagePropertyDialog;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_EPostagePropertyDialog(
    [In] ApplicationEvents4_EPostagePropertyDialogEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_EPostageInsert([In] ApplicationEvents4_EPostageInsertEventHandler obj0);

  event ApplicationEvents4_EPostageInsertEventHandler EPostageInsert;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_EPostageInsert([In] ApplicationEvents4_EPostageInsertEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeAfterMerge(
    [In] ApplicationEvents4_MailMergeAfterMergeEventHandler obj0);

  event ApplicationEvents4_MailMergeAfterMergeEventHandler MailMergeAfterMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeAfterMerge(
    [In] ApplicationEvents4_MailMergeAfterMergeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeAfterRecordMerge(
    [In] ApplicationEvents4_MailMergeAfterRecordMergeEventHandler obj0);

  event ApplicationEvents4_MailMergeAfterRecordMergeEventHandler MailMergeAfterRecordMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeAfterRecordMerge(
    [In] ApplicationEvents4_MailMergeAfterRecordMergeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeBeforeMerge(
    [In] ApplicationEvents4_MailMergeBeforeMergeEventHandler obj0);

  event ApplicationEvents4_MailMergeBeforeMergeEventHandler MailMergeBeforeMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeBeforeMerge(
    [In] ApplicationEvents4_MailMergeBeforeMergeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeBeforeRecordMerge(
    [In] ApplicationEvents4_MailMergeBeforeRecordMergeEventHandler obj0);

  event ApplicationEvents4_MailMergeBeforeRecordMergeEventHandler MailMergeBeforeRecordMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeBeforeRecordMerge(
    [In] ApplicationEvents4_MailMergeBeforeRecordMergeEventHandler obj0);

  event ApplicationEvents4_MailMergeDataSourceLoadEventHandler MailMergeDataSourceLoad;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeDataSourceLoad(
    [In] ApplicationEvents4_MailMergeDataSourceLoadEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeDataSourceLoad(
    [In] ApplicationEvents4_MailMergeDataSourceLoadEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeDataSourceValidate(
    [In] ApplicationEvents4_MailMergeDataSourceValidateEventHandler obj0);

  event ApplicationEvents4_MailMergeDataSourceValidateEventHandler MailMergeDataSourceValidate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeDataSourceValidate(
    [In] ApplicationEvents4_MailMergeDataSourceValidateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeWizardSendToCustom(
    [In] ApplicationEvents4_MailMergeWizardSendToCustomEventHandler obj0);

  event ApplicationEvents4_MailMergeWizardSendToCustomEventHandler MailMergeWizardSendToCustom;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeWizardSendToCustom(
    [In] ApplicationEvents4_MailMergeWizardSendToCustomEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeWizardStateChange(
    [In] ApplicationEvents4_MailMergeWizardStateChangeEventHandler obj0);

  event ApplicationEvents4_MailMergeWizardStateChangeEventHandler MailMergeWizardStateChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeWizardStateChange(
    [In] ApplicationEvents4_MailMergeWizardStateChangeEventHandler obj0);

  event ApplicationEvents4_WindowSizeEventHandler WindowSize;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_WindowSize([In] ApplicationEvents4_WindowSizeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_WindowSize([In] ApplicationEvents4_WindowSizeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_XMLSelectionChange(
    [In] ApplicationEvents4_XMLSelectionChangeEventHandler obj0);

  event ApplicationEvents4_XMLSelectionChangeEventHandler XMLSelectionChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_XMLSelectionChange(
    [In] ApplicationEvents4_XMLSelectionChangeEventHandler obj0);

  event ApplicationEvents4_XMLValidationErrorEventHandler XMLValidationError;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_XMLValidationError(
    [In] ApplicationEvents4_XMLValidationErrorEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_XMLValidationError(
    [In] ApplicationEvents4_XMLValidationErrorEventHandler obj0);

  event ApplicationEvents4_DocumentSyncEventHandler DocumentSync;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_DocumentSync([In] ApplicationEvents4_DocumentSyncEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_DocumentSync([In] ApplicationEvents4_DocumentSyncEventHandler obj0);

  event ApplicationEvents4_EPostageInsertExEventHandler EPostageInsertEx;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_EPostageInsertEx(
    [In] ApplicationEvents4_EPostageInsertExEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_EPostageInsertEx(
    [In] ApplicationEvents4_EPostageInsertExEventHandler obj0);

  event ApplicationEvents4_MailMergeDataSourceValidate2EventHandler MailMergeDataSourceValidate2;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_MailMergeDataSourceValidate2(
    [In] ApplicationEvents4_MailMergeDataSourceValidate2EventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_MailMergeDataSourceValidate2(
    [In] ApplicationEvents4_MailMergeDataSourceValidate2EventHandler obj0);
}
