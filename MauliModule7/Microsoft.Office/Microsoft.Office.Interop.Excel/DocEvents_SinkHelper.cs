// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.DocEvents_SinkHelper
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[ClassInterface(ClassInterfaceType.None)]
public sealed class DocEvents_SinkHelper : DocEvents
{
  public DocEvents_PivotTableUpdateEventHandler m_PivotTableUpdateDelegate;
  public DocEvents_FollowHyperlinkEventHandler m_FollowHyperlinkDelegate;
  public DocEvents_ChangeEventHandler m_ChangeDelegate;
  public DocEvents_CalculateEventHandler m_CalculateDelegate;
  public DocEvents_DeactivateEventHandler m_DeactivateDelegate;
  public DocEvents_ActivateEventHandler m_ActivateDelegate;
  public DocEvents_BeforeRightClickEventHandler m_BeforeRightClickDelegate;
  public DocEvents_BeforeDoubleClickEventHandler m_BeforeDoubleClickDelegate;
  public DocEvents_SelectionChangeEventHandler m_SelectionChangeDelegate;
  public int m_dwCookie;

  public virtual void PivotTableUpdate([In] PivotTable obj0)
  {
    if (this.m_PivotTableUpdateDelegate == null)
      return;
    this.m_PivotTableUpdateDelegate(obj0);
  }

  public virtual void FollowHyperlink([In] Hyperlink obj0)
  {
    if (this.m_FollowHyperlinkDelegate == null)
      return;
    this.m_FollowHyperlinkDelegate(obj0);
  }

  public virtual void Change([In] Range obj0)
  {
    if (this.m_ChangeDelegate == null)
      return;
    this.m_ChangeDelegate(obj0);
  }

  public virtual void Calculate()
  {
    if (this.m_CalculateDelegate == null)
      return;
    this.m_CalculateDelegate();
  }

  public virtual void Deactivate()
  {
    if (this.m_DeactivateDelegate == null)
      return;
    this.m_DeactivateDelegate();
  }

  public virtual void Activate()
  {
    if (this.m_ActivateDelegate == null)
      return;
    this.m_ActivateDelegate();
  }

  public virtual void BeforeRightClick([In] Range obj0, [In] ref bool obj1)
  {
    if (this.m_BeforeRightClickDelegate == null)
      return;
    this.m_BeforeRightClickDelegate(obj0, ref obj1);
  }

  public virtual void BeforeDoubleClick([In] Range obj0, [In] ref bool obj1)
  {
    if (this.m_BeforeDoubleClickDelegate == null)
      return;
    this.m_BeforeDoubleClickDelegate(obj0, ref obj1);
  }

  public virtual void SelectionChange([In] Range obj0)
  {
    if (this.m_SelectionChangeDelegate == null)
      return;
    this.m_SelectionChangeDelegate(obj0);
  }

  internal DocEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_PivotTableUpdateDelegate = (DocEvents_PivotTableUpdateEventHandler) null;
    this.m_FollowHyperlinkDelegate = (DocEvents_FollowHyperlinkEventHandler) null;
    this.m_ChangeDelegate = (DocEvents_ChangeEventHandler) null;
    this.m_CalculateDelegate = (DocEvents_CalculateEventHandler) null;
    this.m_DeactivateDelegate = (DocEvents_DeactivateEventHandler) null;
    this.m_ActivateDelegate = (DocEvents_ActivateEventHandler) null;
    this.m_BeforeRightClickDelegate = (DocEvents_BeforeRightClickEventHandler) null;
    this.m_BeforeDoubleClickDelegate = (DocEvents_BeforeDoubleClickEventHandler) null;
    this.m_SelectionChangeDelegate = (DocEvents_SelectionChangeEventHandler) null;
  }
}
