// Decompiled with JetBrains decompiler
// Type: stdole.FontEvents_Event
// Assembly: stdole, Version=7.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 1DF05181-E8B1-41E5-9E16-182D6B591D92
// Assembly location: C:\WINDOWS\assembly\GAC\stdole\7.0.3300.0__b03f5f7f11d50a3a\stdole.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace stdole;

[ComVisible(false)]
[ComEventInterface(typeof (FontEvents), typeof (FontEvents_EventProvider))]
public interface FontEvents_Event
{
  event FontEvents_FontChangedEventHandler FontChanged;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void add_FontChanged(FontEvents_FontChangedEventHandler A_1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void remove_FontChanged(FontEvents_FontChangedEventHandler A_1);
}
