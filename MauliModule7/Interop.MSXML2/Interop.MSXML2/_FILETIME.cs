// Decompiled with JetBrains decompiler
// Type: MSXML2._FILETIME
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct _FILETIME
{
  public uint dwLowDateTime;
  public uint dwHighDateTime;
}
