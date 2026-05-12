// Decompiled with JetBrains decompiler
// Type: stdole.FontEvents_FontChangedEventHandler
// Assembly: stdole, Version=7.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 1DF05181-E8B1-41E5-9E16-182D6B591D92
// Assembly location: C:\WINDOWS\assembly\GAC\stdole\7.0.3300.0__b03f5f7f11d50a3a\stdole.dll

using System.Runtime.InteropServices;

#nullable disable
namespace stdole;

[ComVisible(false)]
public delegate void FontEvents_FontChangedEventHandler([MarshalAs(UnmanagedType.BStr), In] string PropertyName);
