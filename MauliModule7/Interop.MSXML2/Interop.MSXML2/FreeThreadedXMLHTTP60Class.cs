// Decompiled with JetBrains decompiler
// Type: MSXML2.FreeThreadedXMLHTTP60Class
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[ComConversionLoss]
[Guid("88D96A09-F192-11D4-A65F-0040963251E5")]
[TypeLibType(2)]
[ClassInterface(0)]
[ComImport]
public class FreeThreadedXMLHTTP60Class : IXMLHTTPRequest2, FreeThreadedXMLHTTP60
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern FreeThreadedXMLHTTP60Class();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void open(
    [MarshalAs(UnmanagedType.LPWStr), In] string pwszMethod,
    [MarshalAs(UnmanagedType.LPWStr), In] string pwszUrl,
    [MarshalAs(UnmanagedType.Interface), In] IXMLHTTPRequest2Callback pStatusCallback,
    [MarshalAs(UnmanagedType.LPWStr), In] string pwszUserName,
    [MarshalAs(UnmanagedType.LPWStr), In] string pwszPassword,
    [MarshalAs(UnmanagedType.LPWStr), In] string pwszProxyUserName,
    [MarshalAs(UnmanagedType.LPWStr), In] string pwszProxyPassword);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void send([MarshalAs(UnmanagedType.Interface), In] ISequentialStream pBody, [In] ulong cbBody);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void abort();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetCookie([In] ref tagXHR_COOKIE pCookie, out uint pdwCookieState);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetCustomResponseStream([MarshalAs(UnmanagedType.Interface), In] ISequentialStream pSequentialStream);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setProperty([ComAliasName("MSXML2.XHR_PROPERTY"), In] XHR_PROPERTY eProperty, [In] ulong ullValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setRequestHeader([MarshalAs(UnmanagedType.LPWStr), In] string pwszHeader, [MarshalAs(UnmanagedType.LPWStr), In] string pwszValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getAllResponseHeaders([MarshalAs(UnmanagedType.LPWStr)] out string ppwszHeaders);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void GetCookie(
    [MarshalAs(UnmanagedType.LPWStr), In] string pwszUrl,
    [MarshalAs(UnmanagedType.LPWStr), In] string pwszName,
    [In] uint dwFlags,
    out uint pcCookies,
    [Out] IntPtr ppCookies);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void getResponseHeader([MarshalAs(UnmanagedType.LPWStr), In] string pwszHeader, [MarshalAs(UnmanagedType.LPWStr)] out string ppwszValue);
}
