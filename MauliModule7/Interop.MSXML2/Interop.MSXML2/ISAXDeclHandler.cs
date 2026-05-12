// Decompiled with JetBrains decompiler
// Type: MSXML2.ISAXDeclHandler
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(16 /*0x10*/)]
[InterfaceType(1)]
[Guid("862629AC-771A-47B2-8337-4E6843C1BE90")]
[ComImport]
public interface ISAXDeclHandler
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void elementDecl([In] ref ushort pwchName, [In] int cchName, [In] ref ushort pwchModel, [In] int cchModel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void attributeDecl(
    [In] ref ushort pwchElementName,
    [In] int cchElementName,
    [In] ref ushort pwchAttributeName,
    [In] int cchAttributeName,
    [In] ref ushort pwchType,
    [In] int cchType,
    [In] ref ushort pwchValueDefault,
    [In] int cchValueDefault,
    [In] ref ushort pwchValue,
    [In] int cchValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void internalEntityDecl([In] ref ushort pwchName, [In] int cchName, [In] ref ushort pwchValue, [In] int cchValue);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void externalEntityDecl(
    [In] ref ushort pwchName,
    [In] int cchName,
    [In] ref ushort pwchPublicId,
    [In] int cchPublicId,
    [In] ref ushort pwchSystemId,
    [In] int cchSystemId);
}
