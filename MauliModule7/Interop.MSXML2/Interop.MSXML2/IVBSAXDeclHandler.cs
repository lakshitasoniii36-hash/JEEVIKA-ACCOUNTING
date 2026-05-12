// Decompiled with JetBrains decompiler
// Type: MSXML2.IVBSAXDeclHandler
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("E8917260-7579-4BE1-B5DD-7AFBFA6F077B")]
[TypeLibType(4288)]
[ComImport]
public interface IVBSAXDeclHandler
{
  [DispId(1367)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void elementDecl([MarshalAs(UnmanagedType.BStr), In, Out] ref string strName, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strModel);

  [DispId(1368)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void attributeDecl(
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strElementName,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strAttributeName,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strType,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strValueDefault,
    [MarshalAs(UnmanagedType.BStr), In, Out] ref string strValue);

  [DispId(1369)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void internalEntityDecl([MarshalAs(UnmanagedType.BStr), In, Out] ref string strName, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strValue);

  [DispId(1370)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void externalEntityDecl([MarshalAs(UnmanagedType.BStr), In, Out] ref string strName, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strPublicId, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strSystemId);
}
