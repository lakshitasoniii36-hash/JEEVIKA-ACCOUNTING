// Decompiled with JetBrains decompiler
// Type: MSXML2.ISAXLexicalHandler
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[InterfaceType(1)]
[Guid("7F85D5F5-47A8-4497-BDA5-84BA04819EA6")]
[TypeLibType(16 /*0x10*/)]
[ComImport]
public interface ISAXLexicalHandler
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void startDTD(
    [In] ref ushort pwchName,
    [In] int cchName,
    [In] ref ushort pwchPublicId,
    [In] int cchPublicId,
    [In] ref ushort pwchSystemId,
    [In] int cchSystemId);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void endDTD();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void startEntity([In] ref ushort pwchName, [In] int cchName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void endEntity([In] ref ushort pwchName, [In] int cchName);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void startCDATA();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void endCDATA();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void comment([In] ref ushort pwchChars, [In] int cchChars);
}
