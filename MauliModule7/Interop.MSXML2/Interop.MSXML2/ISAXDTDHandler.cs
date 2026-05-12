// Decompiled with JetBrains decompiler
// Type: MSXML2.ISAXDTDHandler
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[InterfaceType(1)]
[Guid("E15C1BAF-AFB3-4D60-8C36-19A8C45DEFED")]
[TypeLibType(16 /*0x10*/)]
[ComImport]
public interface ISAXDTDHandler
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void notationDecl(
    [In] ref ushort pwchName,
    [In] int cchName,
    [In] ref ushort pwchPublicId,
    [In] int cchPublicId,
    [In] ref ushort pwchSystemId,
    [In] int cchSystemId);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void unparsedEntityDecl(
    [In] ref ushort pwchName,
    [In] int cchName,
    [In] ref ushort pwchPublicId,
    [In] int cchPublicId,
    [In] ref ushort pwchSystemId,
    [In] int cchSystemId,
    [In] ref ushort pwchNotationName,
    [In] int cchNotationName);
}
