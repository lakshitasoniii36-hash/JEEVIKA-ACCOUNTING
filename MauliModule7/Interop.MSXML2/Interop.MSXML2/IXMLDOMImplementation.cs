// Decompiled with JetBrains decompiler
// Type: MSXML2.IXMLDOMImplementation
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("2933BF8F-7B36-11D2-B20E-00C04F983E60")]
[TypeLibType(4288)]
[ComImport]
public interface IXMLDOMImplementation
{
  [DispId(145)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool hasFeature([MarshalAs(UnmanagedType.BStr), In] string feature, [MarshalAs(UnmanagedType.BStr), In] string version);
}
