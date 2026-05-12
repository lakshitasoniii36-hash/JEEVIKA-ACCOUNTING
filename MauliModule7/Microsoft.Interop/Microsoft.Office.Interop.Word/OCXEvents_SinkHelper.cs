// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.OCXEvents_SinkHelper
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[ClassInterface(ClassInterfaceType.None)]
public sealed class OCXEvents_SinkHelper : OCXEvents
{
  public OCXEvents_LostFocusEventHandler m_LostFocusDelegate;
  public OCXEvents_GotFocusEventHandler m_GotFocusDelegate;
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

  internal OCXEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_LostFocusDelegate = (OCXEvents_LostFocusEventHandler) null;
    this.m_GotFocusDelegate = (OCXEvents_GotFocusEventHandler) null;
  }
}
