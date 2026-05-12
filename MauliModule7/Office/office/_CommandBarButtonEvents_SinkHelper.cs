// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core._CommandBarButtonEvents_SinkHelper
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[ClassInterface(ClassInterfaceType.None)]
public sealed class _CommandBarButtonEvents_SinkHelper : _CommandBarButtonEvents
{
  public _CommandBarButtonEvents_ClickEventHandler m_ClickDelegate;
  public int m_dwCookie;

  public virtual void Click([In] CommandBarButton obj0, [In] ref bool obj1)
  {
    if (this.m_ClickDelegate == null)
      return;
    this.m_ClickDelegate(obj0, ref obj1);
  }

  internal _CommandBarButtonEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_ClickDelegate = (_CommandBarButtonEvents_ClickEventHandler) null;
  }
}
