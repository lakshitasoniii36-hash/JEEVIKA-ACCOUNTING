// Decompiled with JetBrains decompiler
// Type: MSXML2.IVBSAXLexicalHandler
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("032AAC35-8C0E-4D9D-979F-E3B702935576")]
[TypeLibType(4288)]
[ComImport]
public interface IVBSAXLexicalHandler
{
  [DispId(1358)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void startDTD([MarshalAs(UnmanagedType.BStr), In, Out] ref string strName, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strPublicId, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strSystemId);

  [DispId(1359)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void endDTD();

  [DispId(1360)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void startEntity([MarshalAs(UnmanagedType.BStr), In, Out] ref string strName);

  [DispId(1361)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void endEntity([MarshalAs(UnmanagedType.BStr), In, Out] ref string strName);

  [DispId(1362)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void startCDATA();

  [DispId(1363)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void endCDATA();

  [DispId(1364)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void comment([MarshalAs(UnmanagedType.BStr), In, Out] ref string strChars);
}
