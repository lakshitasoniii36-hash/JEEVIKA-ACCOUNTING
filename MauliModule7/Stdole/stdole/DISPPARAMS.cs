// Decompiled with JetBrains decompiler
// Type: stdole.DISPPARAMS
// Assembly: stdole, Version=7.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 1DF05181-E8B1-41E5-9E16-182D6B591D92
// Assembly location: C:\WINDOWS\assembly\GAC\stdole\7.0.3300.0__b03f5f7f11d50a3a\stdole.dll

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace stdole;

[ComConversionLoss]
[TypeLibType(512 /*0x0200*/)]
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct DISPPARAMS
{
  [ComConversionLoss]
  public IntPtr rgvarg;
  [ComConversionLoss]
  public IntPtr rgdispidNamedArgs;
  public uint cArgs;
  public uint cNamedArgs;
}
