// Decompiled with JetBrains decompiler
// Type: stdole.FontEvents
// Assembly: stdole, Version=7.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 1DF05181-E8B1-41E5-9E16-182D6B591D92
// Assembly location: C:\WINDOWS\assembly\GAC\stdole\7.0.3300.0__b03f5f7f11d50a3a\stdole.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace stdole;

[Guid("4EF6100A-AF88-11D0-9846-00C04FC29993")]
[TypeLibType(4112)]
[InterfaceType(2)]
[ComImport]
public interface FontEvents
{
  [DispId(9)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void FontChanged([MarshalAs(UnmanagedType.BStr), In] string PropertyName);
}
