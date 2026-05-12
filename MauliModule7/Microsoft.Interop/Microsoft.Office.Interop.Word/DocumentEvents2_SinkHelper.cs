// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.DocumentEvents2_SinkHelper
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using Microsoft.Office.Core;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[ClassInterface(ClassInterfaceType.None)]
public sealed class DocumentEvents2_SinkHelper : DocumentEvents2
{
  public DocumentEvents2_BuildingBlockInsertEventHandler m_BuildingBlockInsertDelegate;
  public DocumentEvents2_ContentControlBeforeContentUpdateEventHandler m_ContentControlBeforeContentUpdateDelegate;
  public DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler m_ContentControlBeforeStoreUpdateDelegate;
  public DocumentEvents2_ContentControlOnEnterEventHandler m_ContentControlOnEnterDelegate;
  public DocumentEvents2_ContentControlOnExitEventHandler m_ContentControlOnExitDelegate;
  public DocumentEvents2_ContentControlBeforeDeleteEventHandler m_ContentControlBeforeDeleteDelegate;
  public DocumentEvents2_ContentControlAfterAddEventHandler m_ContentControlAfterAddDelegate;
  public DocumentEvents2_XMLBeforeDeleteEventHandler m_XMLBeforeDeleteDelegate;
  public DocumentEvents2_XMLAfterInsertEventHandler m_XMLAfterInsertDelegate;
  public DocumentEvents2_SyncEventHandler m_SyncDelegate;
  public DocumentEvents2_CloseEventHandler m_CloseDelegate;
  public DocumentEvents2_OpenEventHandler m_OpenDelegate;
  public DocumentEvents2_NewEventHandler m_NewDelegate;
  public int m_dwCookie;

  public virtual void BuildingBlockInsert(
    [In] Range obj0,
    [In] string obj1,
    [In] string obj2,
    [In] string obj3,
    [In] string obj4)
  {
    if (this.m_BuildingBlockInsertDelegate == null)
      return;
    this.m_BuildingBlockInsertDelegate(obj0, obj1, obj2, obj3, obj4);
  }

  public virtual void ContentControlBeforeContentUpdate([In] ContentControl obj0, [In] ref string obj1)
  {
    if (this.m_ContentControlBeforeContentUpdateDelegate == null)
      return;
    this.m_ContentControlBeforeContentUpdateDelegate(obj0, ref obj1);
  }

  public virtual void ContentControlBeforeStoreUpdate([In] ContentControl obj0, [In] ref string obj1)
  {
    if (this.m_ContentControlBeforeStoreUpdateDelegate == null)
      return;
    this.m_ContentControlBeforeStoreUpdateDelegate(obj0, ref obj1);
  }

  public virtual void ContentControlOnEnter([In] ContentControl obj0)
  {
    if (this.m_ContentControlOnEnterDelegate == null)
      return;
    this.m_ContentControlOnEnterDelegate(obj0);
  }

  public virtual void ContentControlOnExit([In] ContentControl obj0, [In] ref bool obj1)
  {
    if (this.m_ContentControlOnExitDelegate == null)
      return;
    this.m_ContentControlOnExitDelegate(obj0, ref obj1);
  }

  public virtual void ContentControlBeforeDelete([In] ContentControl obj0, [In] bool obj1)
  {
    if (this.m_ContentControlBeforeDeleteDelegate == null)
      return;
    this.m_ContentControlBeforeDeleteDelegate(obj0, obj1);
  }

  public virtual void ContentControlAfterAdd([In] ContentControl obj0, [In] bool obj1)
  {
    if (this.m_ContentControlAfterAddDelegate == null)
      return;
    this.m_ContentControlAfterAddDelegate(obj0, obj1);
  }

  public virtual void XMLBeforeDelete([In] Range obj0, [In] XMLNode obj1, [In] bool obj2)
  {
    if (this.m_XMLBeforeDeleteDelegate == null)
      return;
    this.m_XMLBeforeDeleteDelegate(obj0, obj1, obj2);
  }

  public virtual void XMLAfterInsert([In] XMLNode obj0, [In] bool obj1)
  {
    if (this.m_XMLAfterInsertDelegate == null)
      return;
    this.m_XMLAfterInsertDelegate(obj0, obj1);
  }

  public virtual void Sync([In] MsoSyncEventType obj0)
  {
    if (this.m_SyncDelegate == null)
      return;
    this.m_SyncDelegate(obj0);
  }

  public virtual void Close()
  {
    if (this.m_CloseDelegate == null)
      return;
    this.m_CloseDelegate();
  }

  public virtual void Open()
  {
    if (this.m_OpenDelegate == null)
      return;
    this.m_OpenDelegate();
  }

  public virtual void New()
  {
    if (this.m_NewDelegate == null)
      return;
    this.m_NewDelegate();
  }

  internal DocumentEvents2_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_BuildingBlockInsertDelegate = (DocumentEvents2_BuildingBlockInsertEventHandler) null;
    this.m_ContentControlBeforeContentUpdateDelegate = (DocumentEvents2_ContentControlBeforeContentUpdateEventHandler) null;
    this.m_ContentControlBeforeStoreUpdateDelegate = (DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler) null;
    this.m_ContentControlOnEnterDelegate = (DocumentEvents2_ContentControlOnEnterEventHandler) null;
    this.m_ContentControlOnExitDelegate = (DocumentEvents2_ContentControlOnExitEventHandler) null;
    this.m_ContentControlBeforeDeleteDelegate = (DocumentEvents2_ContentControlBeforeDeleteEventHandler) null;
    this.m_ContentControlAfterAddDelegate = (DocumentEvents2_ContentControlAfterAddEventHandler) null;
    this.m_XMLBeforeDeleteDelegate = (DocumentEvents2_XMLBeforeDeleteEventHandler) null;
    this.m_XMLAfterInsertDelegate = (DocumentEvents2_XMLAfterInsertEventHandler) null;
    this.m_SyncDelegate = (DocumentEvents2_SyncEventHandler) null;
    this.m_CloseDelegate = (DocumentEvents2_CloseEventHandler) null;
    this.m_OpenDelegate = (DocumentEvents2_OpenEventHandler) null;
    this.m_NewDelegate = (DocumentEvents2_NewEventHandler) null;
  }
}
