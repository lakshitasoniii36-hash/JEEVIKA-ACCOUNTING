// Decompiled with JetBrains decompiler
// Type: MSXML2.XMLDOMDocumentEvents_SinkHelper
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(TypeLibTypeFlags.FHidden)]
[ClassInterface(ClassInterfaceType.None)]
public sealed class XMLDOMDocumentEvents_SinkHelper : XMLDOMDocumentEvents
{
  public XMLDOMDocumentEvents_ondataavailableEventHandler m_ondataavailableDelegate;
  public XMLDOMDocumentEvents_onreadystatechangeEventHandler m_onreadystatechangeDelegate;
  public int m_dwCookie;

  public virtual void ondataavailable()
  {
    if (this.m_ondataavailableDelegate == null)
      return;
    this.m_ondataavailableDelegate();
  }

  public virtual void onreadystatechange()
  {
    if (this.m_onreadystatechangeDelegate == null)
      return;
    this.m_onreadystatechangeDelegate();
  }

  internal XMLDOMDocumentEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_ondataavailableDelegate = (XMLDOMDocumentEvents_ondataavailableEventHandler) null;
    this.m_onreadystatechangeDelegate = (XMLDOMDocumentEvents_onreadystatechangeEventHandler) null;
  }
}
