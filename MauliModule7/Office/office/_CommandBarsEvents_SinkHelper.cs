// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core._CommandBarsEvents_SinkHelper
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[ClassInterface(ClassInterfaceType.None)]
public sealed class _CommandBarsEvents_SinkHelper : _CommandBarsEvents
{
  public _CommandBarsEvents_OnUpdateEventHandler m_OnUpdateDelegate;
  public int m_dwCookie;

  public virtual void OnUpdate()
  {
    if (this.m_OnUpdateDelegate == null)
      return;
    this.m_OnUpdateDelegate();
  }

  internal _CommandBarsEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_OnUpdateDelegate = (_CommandBarsEvents_OnUpdateEventHandler) null;
  }
}
