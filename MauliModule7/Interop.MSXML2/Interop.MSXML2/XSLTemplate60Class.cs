// Decompiled with JetBrains decompiler
// Type: MSXML2.XSLTemplate60Class
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("88D96A08-F192-11D4-A65F-0040963251E5")]
[ClassInterface(0)]
[TypeLibType(2)]
[ComImport]
public class XSLTemplate60Class : IXSLTemplate, XSLTemplate60
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern XSLTemplate60Class();

  [DispId(2)]
  public virtual extern IXMLDOMNode stylesheet { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern IXSLProcessor createProcessor();
}
