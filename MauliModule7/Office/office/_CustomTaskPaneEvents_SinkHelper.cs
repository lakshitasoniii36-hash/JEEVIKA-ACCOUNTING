// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core._CustomTaskPaneEvents_SinkHelper
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[ClassInterface(ClassInterfaceType.None)]
public sealed class _CustomTaskPaneEvents_SinkHelper : _CustomTaskPaneEvents
{
  public _CustomTaskPaneEvents_DockPositionStateChangeEventHandler m_DockPositionStateChangeDelegate;
  public _CustomTaskPaneEvents_VisibleStateChangeEventHandler m_VisibleStateChangeDelegate;
  public int m_dwCookie;

  public virtual void DockPositionStateChange([In] CustomTaskPane obj0)
  {
    if (this.m_DockPositionStateChangeDelegate == null)
      return;
    this.m_DockPositionStateChangeDelegate(obj0);
  }

  public virtual void VisibleStateChange([In] CustomTaskPane obj0)
  {
    if (this.m_VisibleStateChangeDelegate == null)
      return;
    this.m_VisibleStateChangeDelegate(obj0);
  }

  internal _CustomTaskPaneEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_DockPositionStateChangeDelegate = (_CustomTaskPaneEvents_DockPositionStateChangeEventHandler) null;
    this.m_VisibleStateChangeDelegate = (_CustomTaskPaneEvents_VisibleStateChangeEventHandler) null;
  }
}
