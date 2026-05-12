// Decompiled with JetBrains decompiler
// Type: MSXML2.IVBSAXXMLFilter
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("1299EB1B-5B88-433E-82DE-82CA75AD4E04")]
[TypeLibType(4288)]
[ComImport]
public interface IVBSAXXMLFilter
{
  [DispId(1309)]
  SAXXMLReader60 parent { [DispId(1309), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(1309), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }
}
