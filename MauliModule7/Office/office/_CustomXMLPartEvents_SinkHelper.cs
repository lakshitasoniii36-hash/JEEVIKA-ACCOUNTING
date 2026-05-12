// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core._CustomXMLPartEvents_SinkHelper
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[ClassInterface(ClassInterfaceType.None)]
public sealed class _CustomXMLPartEvents_SinkHelper : _CustomXMLPartEvents
{
  public _CustomXMLPartEvents_NodeAfterReplaceEventHandler m_NodeAfterReplaceDelegate;
  public _CustomXMLPartEvents_NodeAfterDeleteEventHandler m_NodeAfterDeleteDelegate;
  public _CustomXMLPartEvents_NodeAfterInsertEventHandler m_NodeAfterInsertDelegate;
  public int m_dwCookie;

  public virtual void NodeAfterReplace([In] CustomXMLNode obj0, [In] CustomXMLNode obj1, [In] bool obj2)
  {
    if (this.m_NodeAfterReplaceDelegate == null)
      return;
    this.m_NodeAfterReplaceDelegate(obj0, obj1, obj2);
  }

  public virtual void NodeAfterDelete(
    [In] CustomXMLNode obj0,
    [In] CustomXMLNode obj1,
    [In] CustomXMLNode obj2,
    [In] bool obj3)
  {
    if (this.m_NodeAfterDeleteDelegate == null)
      return;
    this.m_NodeAfterDeleteDelegate(obj0, obj1, obj2, obj3);
  }

  public virtual void NodeAfterInsert([In] CustomXMLNode obj0, [In] bool obj1)
  {
    if (this.m_NodeAfterInsertDelegate == null)
      return;
    this.m_NodeAfterInsertDelegate(obj0, obj1);
  }

  internal _CustomXMLPartEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_NodeAfterReplaceDelegate = (_CustomXMLPartEvents_NodeAfterReplaceEventHandler) null;
    this.m_NodeAfterDeleteDelegate = (_CustomXMLPartEvents_NodeAfterDeleteEventHandler) null;
    this.m_NodeAfterInsertDelegate = (_CustomXMLPartEvents_NodeAfterInsertEventHandler) null;
  }
}
