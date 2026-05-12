// Decompiled with JetBrains decompiler
// Type: MSXML2.ISAXEntityResolver
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(16 /*0x10*/)]
[Guid("99BCA7BD-E8C4-4D5F-A0CF-6D907901FF07")]
[InterfaceType(1)]
[ComImport]
public interface ISAXEntityResolver
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object resolveEntity([In] ref ushort pwchPublicId, [In] ref ushort pwchSystemId);
}
