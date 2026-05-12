// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.ApplicationEvents4_SinkHelper
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using Microsoft.Office.Core;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[ClassInterface(ClassInterfaceType.None)]
public sealed class ApplicationEvents4_SinkHelper : ApplicationEvents4
{
  public ApplicationEvents4_MailMergeDataSourceValidate2EventHandler m_MailMergeDataSourceValidate2Delegate;
  public ApplicationEvents4_EPostageInsertExEventHandler m_EPostageInsertExDelegate;
  public ApplicationEvents4_DocumentSyncEventHandler m_DocumentSyncDelegate;
  public ApplicationEvents4_XMLValidationErrorEventHandler m_XMLValidationErrorDelegate;
  public ApplicationEvents4_XMLSelectionChangeEventHandler m_XMLSelectionChangeDelegate;
  public ApplicationEvents4_WindowSizeEventHandler m_WindowSizeDelegate;
  public ApplicationEvents4_MailMergeWizardStateChangeEventHandler m_MailMergeWizardStateChangeDelegate;
  public ApplicationEvents4_MailMergeWizardSendToCustomEventHandler m_MailMergeWizardSendToCustomDelegate;
  public ApplicationEvents4_MailMergeDataSourceValidateEventHandler m_MailMergeDataSourceValidateDelegate;
  public ApplicationEvents4_MailMergeDataSourceLoadEventHandler m_MailMergeDataSourceLoadDelegate;
  public ApplicationEvents4_MailMergeBeforeRecordMergeEventHandler m_MailMergeBeforeRecordMergeDelegate;
  public ApplicationEvents4_MailMergeBeforeMergeEventHandler m_MailMergeBeforeMergeDelegate;
  public ApplicationEvents4_MailMergeAfterRecordMergeEventHandler m_MailMergeAfterRecordMergeDelegate;
  public ApplicationEvents4_MailMergeAfterMergeEventHandler m_MailMergeAfterMergeDelegate;
  public ApplicationEvents4_EPostageInsertEventHandler m_EPostageInsertDelegate;
  public ApplicationEvents4_EPostagePropertyDialogEventHandler m_EPostagePropertyDialogDelegate;
  public ApplicationEvents4_WindowBeforeDoubleClickEventHandler m_WindowBeforeDoubleClickDelegate;
  public ApplicationEvents4_WindowBeforeRightClickEventHandler m_WindowBeforeRightClickDelegate;
  public ApplicationEvents4_WindowSelectionChangeEventHandler m_WindowSelectionChangeDelegate;
  public ApplicationEvents4_WindowDeactivateEventHandler m_WindowDeactivateDelegate;
  public ApplicationEvents4_WindowActivateEventHandler m_WindowActivateDelegate;
  public ApplicationEvents4_NewDocumentEventHandler m_NewDocumentDelegate;
  public ApplicationEvents4_DocumentBeforeSaveEventHandler m_DocumentBeforeSaveDelegate;
  public ApplicationEvents4_DocumentBeforePrintEventHandler m_DocumentBeforePrintDelegate;
  public ApplicationEvents4_DocumentBeforeCloseEventHandler m_DocumentBeforeCloseDelegate;
  public ApplicationEvents4_DocumentOpenEventHandler m_DocumentOpenDelegate;
  public ApplicationEvents4_DocumentChangeEventHandler m_DocumentChangeDelegate;
  public ApplicationEvents4_QuitEventHandler m_QuitDelegate;
  public ApplicationEvents4_StartupEventHandler m_StartupDelegate;
  public int m_dwCookie;

  public virtual void MailMergeDataSourceValidate2([In] Document obj0, [In] ref bool obj1)
  {
    if (this.m_MailMergeDataSourceValidate2Delegate == null)
      return;
    this.m_MailMergeDataSourceValidate2Delegate(obj0, ref obj1);
  }

  public virtual void EPostageInsertEx(
    [In] Document obj0,
    [In] int obj1,
    [In] int obj2,
    [In] int obj3,
    [In] int obj4,
    [In] int obj5,
    [In] int obj6,
    [In] string obj7,
    [In] string obj8,
    [In] bool obj9,
    [In] ref bool obj10)
  {
    if (this.m_EPostageInsertExDelegate == null)
      return;
    this.m_EPostageInsertExDelegate(obj0, obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, ref obj10);
  }

  public virtual void DocumentSync([In] Document obj0, [In] MsoSyncEventType obj1)
  {
    if (this.m_DocumentSyncDelegate == null)
      return;
    this.m_DocumentSyncDelegate(obj0, obj1);
  }

  public virtual void XMLValidationError([In] XMLNode obj0)
  {
    if (this.m_XMLValidationErrorDelegate == null)
      return;
    this.m_XMLValidationErrorDelegate(obj0);
  }

  public virtual void XMLSelectionChange([In] Selection obj0, [In] XMLNode obj1, [In] XMLNode obj2, [In] ref int obj3)
  {
    if (this.m_XMLSelectionChangeDelegate == null)
      return;
    this.m_XMLSelectionChangeDelegate(obj0, obj1, obj2, ref obj3);
  }

  public virtual void WindowSize([In] Document obj0, [In] Window obj1)
  {
    if (this.m_WindowSizeDelegate == null)
      return;
    this.m_WindowSizeDelegate(obj0, obj1);
  }

  public virtual void MailMergeWizardStateChange(
    [In] Document obj0,
    [In] ref int obj1,
    [In] ref int obj2,
    [In] ref bool obj3)
  {
    if (this.m_MailMergeWizardStateChangeDelegate == null)
      return;
    this.m_MailMergeWizardStateChangeDelegate(obj0, ref obj1, ref obj2, ref obj3);
  }

  public virtual void MailMergeWizardSendToCustom([In] Document obj0)
  {
    if (this.m_MailMergeWizardSendToCustomDelegate == null)
      return;
    this.m_MailMergeWizardSendToCustomDelegate(obj0);
  }

  public virtual void MailMergeDataSourceValidate([In] Document obj0, [In] ref bool obj1)
  {
    if (this.m_MailMergeDataSourceValidateDelegate == null)
      return;
    this.m_MailMergeDataSourceValidateDelegate(obj0, ref obj1);
  }

  public virtual void MailMergeDataSourceLoad([In] Document obj0)
  {
    if (this.m_MailMergeDataSourceLoadDelegate == null)
      return;
    this.m_MailMergeDataSourceLoadDelegate(obj0);
  }

  public virtual void MailMergeBeforeRecordMerge([In] Document obj0, [In] ref bool obj1)
  {
    if (this.m_MailMergeBeforeRecordMergeDelegate == null)
      return;
    this.m_MailMergeBeforeRecordMergeDelegate(obj0, ref obj1);
  }

  public virtual void MailMergeBeforeMerge([In] Document obj0, [In] int obj1, [In] int obj2, [In] ref bool obj3)
  {
    if (this.m_MailMergeBeforeMergeDelegate == null)
      return;
    this.m_MailMergeBeforeMergeDelegate(obj0, obj1, obj2, ref obj3);
  }

  public virtual void MailMergeAfterRecordMerge([In] Document obj0)
  {
    if (this.m_MailMergeAfterRecordMergeDelegate == null)
      return;
    this.m_MailMergeAfterRecordMergeDelegate(obj0);
  }

  public virtual void MailMergeAfterMerge([In] Document obj0, [In] Document obj1)
  {
    if (this.m_MailMergeAfterMergeDelegate == null)
      return;
    this.m_MailMergeAfterMergeDelegate(obj0, obj1);
  }

  public virtual void EPostageInsert([In] Document obj0)
  {
    if (this.m_EPostageInsertDelegate == null)
      return;
    this.m_EPostageInsertDelegate(obj0);
  }

  public virtual void EPostagePropertyDialog([In] Document obj0)
  {
    if (this.m_EPostagePropertyDialogDelegate == null)
      return;
    this.m_EPostagePropertyDialogDelegate(obj0);
  }

  public virtual void WindowBeforeDoubleClick([In] Selection obj0, [In] ref bool obj1)
  {
    if (this.m_WindowBeforeDoubleClickDelegate == null)
      return;
    this.m_WindowBeforeDoubleClickDelegate(obj0, ref obj1);
  }

  public virtual void WindowBeforeRightClick([In] Selection obj0, [In] ref bool obj1)
  {
    if (this.m_WindowBeforeRightClickDelegate == null)
      return;
    this.m_WindowBeforeRightClickDelegate(obj0, ref obj1);
  }

  public virtual void WindowSelectionChange([In] Selection obj0)
  {
    if (this.m_WindowSelectionChangeDelegate == null)
      return;
    this.m_WindowSelectionChangeDelegate(obj0);
  }

  public virtual void WindowDeactivate([In] Document obj0, [In] Window obj1)
  {
    if (this.m_WindowDeactivateDelegate == null)
      return;
    this.m_WindowDeactivateDelegate(obj0, obj1);
  }

  public virtual void WindowActivate([In] Document obj0, [In] Window obj1)
  {
    if (this.m_WindowActivateDelegate == null)
      return;
    this.m_WindowActivateDelegate(obj0, obj1);
  }

  public virtual void NewDocument([In] Document obj0)
  {
    if (this.m_NewDocumentDelegate == null)
      return;
    this.m_NewDocumentDelegate(obj0);
  }

  public virtual void DocumentBeforeSave([In] Document obj0, [In] ref bool obj1, [In] ref bool obj2)
  {
    if (this.m_DocumentBeforeSaveDelegate == null)
      return;
    this.m_DocumentBeforeSaveDelegate(obj0, ref obj1, ref obj2);
  }

  public virtual void DocumentBeforePrint([In] Document obj0, [In] ref bool obj1)
  {
    if (this.m_DocumentBeforePrintDelegate == null)
      return;
    this.m_DocumentBeforePrintDelegate(obj0, ref obj1);
  }

  public virtual void DocumentBeforeClose([In] Document obj0, [In] ref bool obj1)
  {
    if (this.m_DocumentBeforeCloseDelegate == null)
      return;
    this.m_DocumentBeforeCloseDelegate(obj0, ref obj1);
  }

  public virtual void DocumentOpen([In] Document obj0)
  {
    if (this.m_DocumentOpenDelegate == null)
      return;
    this.m_DocumentOpenDelegate(obj0);
  }

  public virtual void DocumentChange()
  {
    if (this.m_DocumentChangeDelegate == null)
      return;
    this.m_DocumentChangeDelegate();
  }

  public virtual void Quit()
  {
    if (this.m_QuitDelegate == null)
      return;
    this.m_QuitDelegate();
  }

  public virtual void Startup()
  {
    if (this.m_StartupDelegate == null)
      return;
    this.m_StartupDelegate();
  }

  internal ApplicationEvents4_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_MailMergeDataSourceValidate2Delegate = (ApplicationEvents4_MailMergeDataSourceValidate2EventHandler) null;
    this.m_EPostageInsertExDelegate = (ApplicationEvents4_EPostageInsertExEventHandler) null;
    this.m_DocumentSyncDelegate = (ApplicationEvents4_DocumentSyncEventHandler) null;
    this.m_XMLValidationErrorDelegate = (ApplicationEvents4_XMLValidationErrorEventHandler) null;
    this.m_XMLSelectionChangeDelegate = (ApplicationEvents4_XMLSelectionChangeEventHandler) null;
    this.m_WindowSizeDelegate = (ApplicationEvents4_WindowSizeEventHandler) null;
    this.m_MailMergeWizardStateChangeDelegate = (ApplicationEvents4_MailMergeWizardStateChangeEventHandler) null;
    this.m_MailMergeWizardSendToCustomDelegate = (ApplicationEvents4_MailMergeWizardSendToCustomEventHandler) null;
    this.m_MailMergeDataSourceValidateDelegate = (ApplicationEvents4_MailMergeDataSourceValidateEventHandler) null;
    this.m_MailMergeDataSourceLoadDelegate = (ApplicationEvents4_MailMergeDataSourceLoadEventHandler) null;
    this.m_MailMergeBeforeRecordMergeDelegate = (ApplicationEvents4_MailMergeBeforeRecordMergeEventHandler) null;
    this.m_MailMergeBeforeMergeDelegate = (ApplicationEvents4_MailMergeBeforeMergeEventHandler) null;
    this.m_MailMergeAfterRecordMergeDelegate = (ApplicationEvents4_MailMergeAfterRecordMergeEventHandler) null;
    this.m_MailMergeAfterMergeDelegate = (ApplicationEvents4_MailMergeAfterMergeEventHandler) null;
    this.m_EPostageInsertDelegate = (ApplicationEvents4_EPostageInsertEventHandler) null;
    this.m_EPostagePropertyDialogDelegate = (ApplicationEvents4_EPostagePropertyDialogEventHandler) null;
    this.m_WindowBeforeDoubleClickDelegate = (ApplicationEvents4_WindowBeforeDoubleClickEventHandler) null;
    this.m_WindowBeforeRightClickDelegate = (ApplicationEvents4_WindowBeforeRightClickEventHandler) null;
    this.m_WindowSelectionChangeDelegate = (ApplicationEvents4_WindowSelectionChangeEventHandler) null;
    this.m_WindowDeactivateDelegate = (ApplicationEvents4_WindowDeactivateEventHandler) null;
    this.m_WindowActivateDelegate = (ApplicationEvents4_WindowActivateEventHandler) null;
    this.m_NewDocumentDelegate = (ApplicationEvents4_NewDocumentEventHandler) null;
    this.m_DocumentBeforeSaveDelegate = (ApplicationEvents4_DocumentBeforeSaveEventHandler) null;
    this.m_DocumentBeforePrintDelegate = (ApplicationEvents4_DocumentBeforePrintEventHandler) null;
    this.m_DocumentBeforeCloseDelegate = (ApplicationEvents4_DocumentBeforeCloseEventHandler) null;
    this.m_DocumentOpenDelegate = (ApplicationEvents4_DocumentOpenEventHandler) null;
    this.m_DocumentChangeDelegate = (ApplicationEvents4_DocumentChangeEventHandler) null;
    this.m_QuitDelegate = (ApplicationEvents4_QuitEventHandler) null;
    this.m_StartupDelegate = (ApplicationEvents4_StartupEventHandler) null;
  }
}
