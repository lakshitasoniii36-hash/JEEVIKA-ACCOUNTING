// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.IMsoEnvelopeVBEvents_SinkHelper
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[ClassInterface(ClassInterfaceType.None)]
public sealed class IMsoEnvelopeVBEvents_SinkHelper : IMsoEnvelopeVBEvents
{
  public IMsoEnvelopeVBEvents_EnvelopeHideEventHandler m_EnvelopeHideDelegate;
  public IMsoEnvelopeVBEvents_EnvelopeShowEventHandler m_EnvelopeShowDelegate;
  public int m_dwCookie;

  public virtual void EnvelopeHide()
  {
    if (this.m_EnvelopeHideDelegate == null)
      return;
    this.m_EnvelopeHideDelegate();
  }

  public virtual void EnvelopeShow()
  {
    if (this.m_EnvelopeShowDelegate == null)
      return;
    this.m_EnvelopeShowDelegate();
  }

  internal IMsoEnvelopeVBEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_EnvelopeHideDelegate = (IMsoEnvelopeVBEvents_EnvelopeHideEventHandler) null;
    this.m_EnvelopeShowDelegate = (IMsoEnvelopeVBEvents_EnvelopeShowEventHandler) null;
  }
}
