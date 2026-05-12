// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core._CommandBarComboBoxEvents_SinkHelper
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[ClassInterface(ClassInterfaceType.None)]
public sealed class _CommandBarComboBoxEvents_SinkHelper : _CommandBarComboBoxEvents
{
  public _CommandBarComboBoxEvents_ChangeEventHandler m_ChangeDelegate;
  public int m_dwCookie;

  public virtual void Change([In] CommandBarComboBox obj0)
  {
    if (this.m_ChangeDelegate == null)
      return;
    this.m_ChangeDelegate(obj0);
  }

  internal _CommandBarComboBoxEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_ChangeDelegate = (_CommandBarComboBoxEvents_ChangeEventHandler) null;
  }
}
