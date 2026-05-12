// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.ApplicationEvents3_SinkHelper
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[ClassInterface(ClassInterfaceType.None)]
public sealed class ApplicationEvents3_SinkHelper : ApplicationEvents3
{
  public ApplicationEvents3_WindowSizeEventHandler m_WindowSizeDelegate;
  public ApplicationEvents3_MailMergeWizardStateChangeEventHandler m_MailMergeWizardStateChangeDelegate;
  public ApplicationEvents3_MailMergeWizardSendToCustomEventHandler m_MailMergeWizardSendToCustomDelegate;
  public ApplicationEvents3_MailMergeDataSourceValidateEventHandler m_MailMergeDataSourceValidateDelegate;
  public ApplicationEvents3_MailMergeDataSourceLoadEventHandler m_MailMergeDataSourceLoadDelegate;
  public ApplicationEvents3_MailMergeBeforeRecordMergeEventHandler m_MailMergeBeforeRecordMergeDelegate;
  public ApplicationEvents3_MailMergeBeforeMergeEventHandler m_MailMergeBeforeMergeDelegate;
  public ApplicationEvents3_MailMergeAfterRecordMergeEventHandler m_MailMergeAfterRecordMergeDelegate;
  public ApplicationEvents3_MailMergeAfterMergeEventHandler m_MailMergeAfterMergeDelegate;
  public ApplicationEvents3_EPostageInsertEventHandler m_EPostageInsertDelegate;
  public ApplicationEvents3_EPostagePropertyDialogEventHandler m_EPostagePropertyDialogDelegate;
  public ApplicationEvents3_WindowBeforeDoubleClickEventHandler m_WindowBeforeDoubleClickDelegate;
  public ApplicationEvents3_WindowBeforeRightClickEventHandler m_WindowBeforeRightClickDelegate;
  public ApplicationEvents3_WindowSelectionChangeEventHandler m_WindowSelectionChangeDelegate;
  public ApplicationEvents3_WindowDeactivateEventHandler m_WindowDeactivateDelegate;
  public ApplicationEvents3_WindowActivateEventHandler m_WindowActivateDelegate;
  public ApplicationEvents3_NewDocumentEventHandler m_NewDocumentDelegate;
  public ApplicationEvents3_DocumentBeforeSaveEventHandler m_DocumentBeforeSaveDelegate;
  public ApplicationEvents3_DocumentBeforePrintEventHandler m_DocumentBeforePrintDelegate;
  public ApplicationEvents3_DocumentBeforeCloseEventHandler m_DocumentBeforeCloseDelegate;
  public ApplicationEvents3_DocumentOpenEventHandler m_DocumentOpenDelegate;
  public ApplicationEvents3_DocumentChangeEventHandler m_DocumentChangeDelegate;
  public ApplicationEvents3_QuitEventHandler m_QuitDelegate;
  public ApplicationEvents3_StartupEventHandler m_StartupDelegate;
  public int m_dwCookie;

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

  internal ApplicationEvents3_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_WindowSizeDelegate = (ApplicationEvents3_WindowSizeEventHandler) null;
    this.m_MailMergeWizardStateChangeDelegate = (ApplicationEvents3_MailMergeWizardStateChangeEventHandler) null;
    this.m_MailMergeWizardSendToCustomDelegate = (ApplicationEvents3_MailMergeWizardSendToCustomEventHandler) null;
    this.m_MailMergeDataSourceValidateDelegate = (ApplicationEvents3_MailMergeDataSourceValidateEventHandler) null;
    this.m_MailMergeDataSourceLoadDelegate = (ApplicationEvents3_MailMergeDataSourceLoadEventHandler) null;
    this.m_MailMergeBeforeRecordMergeDelegate = (ApplicationEvents3_MailMergeBeforeRecordMergeEventHandler) null;
    this.m_MailMergeBeforeMergeDelegate = (ApplicationEvents3_MailMergeBeforeMergeEventHandler) null;
    this.m_MailMergeAfterRecordMergeDelegate = (ApplicationEvents3_MailMergeAfterRecordMergeEventHandler) null;
    this.m_MailMergeAfterMergeDelegate = (ApplicationEvents3_MailMergeAfterMergeEventHandler) null;
    this.m_EPostageInsertDelegate = (ApplicationEvents3_EPostageInsertEventHandler) null;
    this.m_EPostagePropertyDialogDelegate = (ApplicationEvents3_EPostagePropertyDialogEventHandler) null;
    this.m_WindowBeforeDoubleClickDelegate = (ApplicationEvents3_WindowBeforeDoubleClickEventHandler) null;
    this.m_WindowBeforeRightClickDelegate = (ApplicationEvents3_WindowBeforeRightClickEventHandler) null;
    this.m_WindowSelectionChangeDelegate = (ApplicationEvents3_WindowSelectionChangeEventHandler) null;
    this.m_WindowDeactivateDelegate = (ApplicationEvents3_WindowDeactivateEventHandler) null;
    this.m_WindowActivateDelegate = (ApplicationEvents3_WindowActivateEventHandler) null;
    this.m_NewDocumentDelegate = (ApplicationEvents3_NewDocumentEventHandler) null;
    this.m_DocumentBeforeSaveDelegate = (ApplicationEvents3_DocumentBeforeSaveEventHandler) null;
    this.m_DocumentBeforePrintDelegate = (ApplicationEvents3_DocumentBeforePrintEventHandler) null;
    this.m_DocumentBeforeCloseDelegate = (ApplicationEvents3_DocumentBeforeCloseEventHandler) null;
    this.m_DocumentOpenDelegate = (ApplicationEvents3_DocumentOpenEventHandler) null;
    this.m_DocumentChangeDelegate = (ApplicationEvents3_DocumentChangeEventHandler) null;
    this.m_QuitDelegate = (ApplicationEvents3_QuitEventHandler) null;
    this.m_StartupDelegate = (ApplicationEvents3_StartupEventHandler) null;
  }
}
