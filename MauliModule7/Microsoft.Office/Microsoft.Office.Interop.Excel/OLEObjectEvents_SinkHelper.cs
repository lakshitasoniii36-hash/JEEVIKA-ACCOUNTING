// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.OLEObjectEvents_SinkHelper
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[ClassInterface(ClassInterfaceType.None)]
public sealed class OLEObjectEvents_SinkHelper : OLEObjectEvents
{
  public OLEObjectEvents_LostFocusEventHandler m_LostFocusDelegate;
  public OLEObjectEvents_GotFocusEventHandler m_GotFocusDelegate;
  public int m_dwCookie;

  public virtual void LostFocus()
  {
    if (this.m_LostFocusDelegate == null)
      return;
    this.m_LostFocusDelegate();
  }

  public virtual void GotFocus()
  {
    if (this.m_GotFocusDelegate == null)
      return;
    this.m_GotFocusDelegate();
  }

  internal OLEObjectEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_LostFocusDelegate = (OLEObjectEvents_LostFocusEventHandler) null;
    this.m_GotFocusDelegate = (OLEObjectEvents_GotFocusEventHandler) null;
  }
}
