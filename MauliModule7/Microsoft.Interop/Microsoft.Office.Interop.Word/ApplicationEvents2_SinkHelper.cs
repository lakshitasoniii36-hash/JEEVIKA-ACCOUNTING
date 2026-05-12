// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.ApplicationEvents2_SinkHelper
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[ClassInterface(ClassInterfaceType.None)]
public sealed class ApplicationEvents2_SinkHelper : ApplicationEvents2
{
  public ApplicationEvents2_WindowBeforeDoubleClickEventHandler m_WindowBeforeDoubleClickDelegate;
  public ApplicationEvents2_WindowBeforeRightClickEventHandler m_WindowBeforeRightClickDelegate;
  public ApplicationEvents2_WindowSelectionChangeEventHandler m_WindowSelectionChangeDelegate;
  public ApplicationEvents2_WindowDeactivateEventHandler m_WindowDeactivateDelegate;
  public ApplicationEvents2_WindowActivateEventHandler m_WindowActivateDelegate;
  public ApplicationEvents2_NewDocumentEventHandler m_NewDocumentDelegate;
  public ApplicationEvents2_DocumentBeforeSaveEventHandler m_DocumentBeforeSaveDelegate;
  public ApplicationEvents2_DocumentBeforePrintEventHandler m_DocumentBeforePrintDelegate;
  public ApplicationEvents2_DocumentBeforeCloseEventHandler m_DocumentBeforeCloseDelegate;
  public ApplicationEvents2_DocumentOpenEventHandler m_DocumentOpenDelegate;
  public ApplicationEvents2_DocumentChangeEventHandler m_DocumentChangeDelegate;
  public ApplicationEvents2_QuitEventHandler m_QuitDelegate;
  public ApplicationEvents2_StartupEventHandler m_StartupDelegate;
  public int m_dwCookie;

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

  internal ApplicationEvents2_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_WindowBeforeDoubleClickDelegate = (ApplicationEvents2_WindowBeforeDoubleClickEventHandler) null;
    this.m_WindowBeforeRightClickDelegate = (ApplicationEvents2_WindowBeforeRightClickEventHandler) null;
    this.m_WindowSelectionChangeDelegate = (ApplicationEvents2_WindowSelectionChangeEventHandler) null;
    this.m_WindowDeactivateDelegate = (ApplicationEvents2_WindowDeactivateEventHandler) null;
    this.m_WindowActivateDelegate = (ApplicationEvents2_WindowActivateEventHandler) null;
    this.m_NewDocumentDelegate = (ApplicationEvents2_NewDocumentEventHandler) null;
    this.m_DocumentBeforeSaveDelegate = (ApplicationEvents2_DocumentBeforeSaveEventHandler) null;
    this.m_DocumentBeforePrintDelegate = (ApplicationEvents2_DocumentBeforePrintEventHandler) null;
    this.m_DocumentBeforeCloseDelegate = (ApplicationEvents2_DocumentBeforeCloseEventHandler) null;
    this.m_DocumentOpenDelegate = (ApplicationEvents2_DocumentOpenEventHandler) null;
    this.m_DocumentChangeDelegate = (ApplicationEvents2_DocumentChangeEventHandler) null;
    this.m_QuitDelegate = (ApplicationEvents2_QuitEventHandler) null;
    this.m_StartupDelegate = (ApplicationEvents2_StartupEventHandler) null;
  }
}
