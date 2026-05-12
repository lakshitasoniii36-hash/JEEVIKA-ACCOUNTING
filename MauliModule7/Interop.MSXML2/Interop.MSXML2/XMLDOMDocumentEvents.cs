// Decompiled with JetBrains decompiler
// Type: MSXML2.XMLDOMDocumentEvents
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(4112)]
[InterfaceType(2)]
[Guid("3EFAA427-272F-11D2-836F-0000F87A7782")]
[ComImport]
public interface XMLDOMDocumentEvents
{
  [DispId(198)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ondataavailable();

  [DispId(-609)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void onreadystatechange();
}
