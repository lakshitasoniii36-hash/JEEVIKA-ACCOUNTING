// Decompiled with JetBrains decompiler
// Type: MSXML2.IVBSAXErrorHandler
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(4288)]
[Guid("D963D3FE-173C-4862-9095-B92F66995F52")]
[ComImport]
public interface IVBSAXErrorHandler
{
  [DispId(1339)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void error([MarshalAs(UnmanagedType.Interface), In] IVBSAXLocator oLocator, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strErrorMessage, [In] int nErrorCode);

  [DispId(1340)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void fatalError([MarshalAs(UnmanagedType.Interface), In] IVBSAXLocator oLocator, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strErrorMessage, [In] int nErrorCode);

  [DispId(1341)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ignorableWarning([MarshalAs(UnmanagedType.Interface), In] IVBSAXLocator oLocator, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strErrorMessage, [In] int nErrorCode);
}
