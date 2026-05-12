// Decompiled with JetBrains decompiler
// Type: MSXML2.IVBSAXAttributes
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(4288)]
[Guid("10DC0586-132B-4CAC-8BB3-DB00AC8B7EE0")]
[ComImport]
public interface IVBSAXAttributes
{
  [DispId(1344)]
  int length { [DispId(1344), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1345)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string getURI([In] int nIndex);

  [DispId(1346)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string getLocalName([In] int nIndex);

  [DispId(1347)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string getQName([In] int nIndex);

  [DispId(1348)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int getIndexFromName([MarshalAs(UnmanagedType.BStr), In] string strURI, [MarshalAs(UnmanagedType.BStr), In] string strLocalName);

  [DispId(1349)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int getIndexFromQName([MarshalAs(UnmanagedType.BStr), In] string strQName);

  [DispId(1350)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string getType([In] int nIndex);

  [DispId(1351)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string getTypeFromName([MarshalAs(UnmanagedType.BStr), In] string strURI, [MarshalAs(UnmanagedType.BStr), In] string strLocalName);

  [DispId(1352)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string getTypeFromQName([MarshalAs(UnmanagedType.BStr), In] string strQName);

  [DispId(1353)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string getValue([In] int nIndex);

  [DispId(1354)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string getValueFromName([MarshalAs(UnmanagedType.BStr), In] string strURI, [MarshalAs(UnmanagedType.BStr), In] string strLocalName);

  [DispId(1355)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string getValueFromQName([MarshalAs(UnmanagedType.BStr), In] string strQName);
}
