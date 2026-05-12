// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core._CustomXMLPartsEvents_SinkHelper
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[ClassInterface(ClassInterfaceType.None)]
public sealed class _CustomXMLPartsEvents_SinkHelper : _CustomXMLPartsEvents
{
  public _CustomXMLPartsEvents_PartAfterLoadEventHandler m_PartAfterLoadDelegate;
  public _CustomXMLPartsEvents_PartBeforeDeleteEventHandler m_PartBeforeDeleteDelegate;
  public _CustomXMLPartsEvents_PartAfterAddEventHandler m_PartAfterAddDelegate;
  public int m_dwCookie;

  public virtual void PartAfterLoad([In] CustomXMLPart obj0)
  {
    if (this.m_PartAfterLoadDelegate == null)
      return;
    this.m_PartAfterLoadDelegate(obj0);
  }

  public virtual void PartBeforeDelete([In] CustomXMLPart obj0)
  {
    if (this.m_PartBeforeDeleteDelegate == null)
      return;
    this.m_PartBeforeDeleteDelegate(obj0);
  }

  public virtual void PartAfterAdd([In] CustomXMLPart obj0)
  {
    if (this.m_PartAfterAddDelegate == null)
      return;
    this.m_PartAfterAddDelegate(obj0);
  }

  internal _CustomXMLPartsEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_PartAfterLoadDelegate = (_CustomXMLPartsEvents_PartAfterLoadEventHandler) null;
    this.m_PartBeforeDeleteDelegate = (_CustomXMLPartsEvents_PartBeforeDeleteEventHandler) null;
    this.m_PartAfterAddDelegate = (_CustomXMLPartsEvents_PartAfterAddEventHandler) null;
  }
}
