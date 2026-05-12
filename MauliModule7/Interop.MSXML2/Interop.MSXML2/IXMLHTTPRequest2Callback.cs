// Decompiled with JetBrains decompiler
// Type: MSXML2.IXMLHTTPRequest2Callback
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[InterfaceType(1)]
[Guid("A44A9299-E321-40DE-8866-341B41669162")]
[ComImport]
public interface IXMLHTTPRequest2Callback
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OnRedirect([MarshalAs(UnmanagedType.Interface), In] FreeThreadedXMLHTTP60 pXHR, [MarshalAs(UnmanagedType.LPWStr), In] string pwszRedirectUrl);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OnHeadersAvailable([MarshalAs(UnmanagedType.Interface), In] FreeThreadedXMLHTTP60 pXHR, [In] uint dwStatus, [MarshalAs(UnmanagedType.LPWStr), In] string pwszStatus);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ondataavailable([MarshalAs(UnmanagedType.Interface), In] FreeThreadedXMLHTTP60 pXHR, [MarshalAs(UnmanagedType.Interface), In] ISequentialStream pResponseStream);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OnResponseReceived([MarshalAs(UnmanagedType.Interface), In] FreeThreadedXMLHTTP60 pXHR, [MarshalAs(UnmanagedType.Interface), In] ISequentialStream pResponseStream);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OnError([MarshalAs(UnmanagedType.Interface), In] FreeThreadedXMLHTTP60 pXHR, [MarshalAs(UnmanagedType.Error), In] int hrError);
}
