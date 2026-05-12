// Decompiled with JetBrains decompiler
// Type: MSXML2.IVBSAXEntityResolver
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(4288)]
[Guid("0C05D096-F45B-4ACA-AD1A-AA0BC25518DC")]
[ComImport]
public interface IVBSAXEntityResolver
{
  [DispId(1319)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object resolveEntity([MarshalAs(UnmanagedType.BStr), In, Out] ref string strPublicId, [MarshalAs(UnmanagedType.BStr), In, Out] ref string strSystemId);
}
