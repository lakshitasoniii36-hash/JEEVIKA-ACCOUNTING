// Decompiled with JetBrains decompiler
// Type: MSXML2.IVBSAXDTDHandler
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(4288)]
[Guid("24FB3297-302D-4620-BA39-3A732D850558")]
[ComImport]
public interface IVBSAXDTDHandler
{
  [DispId(1335)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void notationDecl([MarshalAs(UnmanagedType.BStr), In, Out] ref string strName, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strPublicId, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strSystemId);

  [DispId(1336)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void unparsedEntityDecl(
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strName,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strPublicId,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strSystemId,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strNotationName);
}
