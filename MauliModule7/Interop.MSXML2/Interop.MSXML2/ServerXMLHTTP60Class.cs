// Decompiled with JetBrains decompiler
// Type: MSXML2.ServerXMLHTTP60Class
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(2)]
[ClassInterface(0)]
[Guid("88D96A0B-F192-11D4-A65F-0040963251E5")]
[ComImport]
public class ServerXMLHTTP60Class : IServerXMLHTTPRequest2, ServerXMLHTTP60
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern ServerXMLHTTP60Class();

  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void open(
    [MarshalAs(UnmanagedType.BStr), In] string bstrMethod,
    [MarshalAs(UnmanagedType.BStr), In] string bstrUrl,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varAsync,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object bstrUser,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object bstrPassword);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setRequestHeader([MarshalAs(UnmanagedType.BStr), In] string bstrHeader, [MarshalAs(UnmanagedType.BStr), In] string bstrValue);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string getResponseHeader([MarshalAs(UnmanagedType.BStr), In] string bstrHeader);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string getAllResponseHeaders();

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void send([MarshalAs(UnmanagedType.Struct), In, Optional] object varBody);

  [DispId(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void abort();

  [DispId(7)]
  public virtual extern int status { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(8)]
  public virtual extern string statusText { [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(9)]
  public virtual extern object responseXML { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(10)]
  public virtual extern string responseText { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(11)]
  public virtual extern object responseBody { [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(12)]
  public virtual extern object responseStream { [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(13)]
  public virtual extern int readyState { [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(14)]
  public virtual extern object onreadystatechange { [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IDispatch), In] set; }

  [DispId(15)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setTimeouts(
    [In] int resolveTimeout,
    [In] int connectTimeout,
    [In] int sendTimeout,
    [In] int receiveTimeout);

  [DispId(16 /*0x10*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool waitForResponse([MarshalAs(UnmanagedType.Struct), In, Optional] object timeoutInSeconds);

  [DispId(17)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object getOption([ComAliasName("MSXML2.SERVERXMLHTTP_OPTION"), In] SERVERXMLHTTP_OPTION option);

  [DispId(18)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setOption([ComAliasName("MSXML2.SERVERXMLHTTP_OPTION"), In] SERVERXMLHTTP_OPTION option, [MarshalAs(UnmanagedType.Struct), In] object value);

  [DispId(19)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setProxy(
    [ComAliasName("MSXML2.SXH_PROXY_SETTING"), In] SXH_PROXY_SETTING proxySetting,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varProxyServer,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varBypassList);

  [DispId(20)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void setProxyCredentials([MarshalAs(UnmanagedType.BStr), In] string bstrUserName, [MarshalAs(UnmanagedType.BStr), In] string bstrPassword);
}
