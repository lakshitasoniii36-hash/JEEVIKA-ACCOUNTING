// Decompiled with JetBrains decompiler
// Type: stdole.GUID
// Assembly: stdole, Version=7.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 1DF05181-E8B1-41E5-9E16-182D6B591D92
// Assembly location: C:\WINDOWS\assembly\GAC\stdole\7.0.3300.0__b03f5f7f11d50a3a\stdole.dll

using System.Runtime.InteropServices;

#nullable disable
namespace stdole;

[TypeLibType(16 /*0x10*/)]
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct GUID
{
  public uint Data1;
  public ushort Data2;
  public ushort Data3;
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
  public byte[] Data4;
}
