// Decompiled with JetBrains decompiler
// Type: stdole.FontEvents_SinkHelper
// Assembly: stdole, Version=7.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 1DF05181-E8B1-41E5-9E16-182D6B591D92
// Assembly location: C:\WINDOWS\assembly\GAC\stdole\7.0.3300.0__b03f5f7f11d50a3a\stdole.dll

using System.Runtime.InteropServices;

#nullable disable
namespace stdole;

[ClassInterface(ClassInterfaceType.None)]
internal sealed class FontEvents_SinkHelper : FontEvents
{
  public FontEvents_FontChangedEventHandler m_FontChangedDelegate;
  public int m_dwCookie;

  public virtual void FontChanged(string A_1)
  {
    if (this.m_FontChangedDelegate == null)
      return;
    this.m_FontChangedDelegate(A_1);
  }

  internal FontEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_FontChangedDelegate = (FontEvents_FontChangedEventHandler) null;
  }
}
