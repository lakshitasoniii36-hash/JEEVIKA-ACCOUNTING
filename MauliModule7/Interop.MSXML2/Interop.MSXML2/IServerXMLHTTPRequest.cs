// Decompiled with JetBrains decompiler
// Type: MSXML2.IServerXMLHTTPRequest
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(4160)]
[Guid("2E9196BF-13BA-4DD4-91CA-6C571F281495")]
[ComImport]
public interface IServerXMLHTTPRequest : IXMLHTTPRequest
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void open(
    [MarshalAs(UnmanagedType.BStr), In] string bstrMethod,
    [MarshalAs(UnmanagedType.BStr), In] string bstrUrl,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varAsync,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object bstrUser,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object bstrPassword);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void setRequestHeader([MarshalAs(UnmanagedType.BStr), In] string bstrHeader, [MarshalAs(UnmanagedType.BStr), In] string bstrValue);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string getResponseHeader([MarshalAs(UnmanagedType.BStr), In] string bstrHeader);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string getAllResponseHeaders();

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void send([MarshalAs(UnmanagedType.Struct), In, Optional] object varBody);

  [DispId(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void abort();

  [DispId(7)]
  new int status { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(8)]
  new string statusText { [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(9)]
  new object responseXML { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(10)]
  new string responseText { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(11)]
  new object responseBody { [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(12)]
  new object responseStream { [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(13)]
  new int readyState { [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(14)]
  new object onreadystatechange { [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IDispatch), In] set; }

  [DispId(15)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void setTimeouts([In] int resolveTimeout, [In] int connectTimeout, [In] int sendTimeout, [In] int receiveTimeout);

  [DispId(16 /*0x10*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool waitForResponse([MarshalAs(UnmanagedType.Struct), In, Optional] object timeoutInSeconds);

  [DispId(17)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object getOption([ComAliasName("MSXML2.SERVERXMLHTTP_OPTION"), In] SERVERXMLHTTP_OPTION option);

  [DispId(18)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void setOption([ComAliasName("MSXML2.SERVERXMLHTTP_OPTION"), In] SERVERXMLHTTP_OPTION option, [MarshalAs(UnmanagedType.Struct), In] object value);
}
