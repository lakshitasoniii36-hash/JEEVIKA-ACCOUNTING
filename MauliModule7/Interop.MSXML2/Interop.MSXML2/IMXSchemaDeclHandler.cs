// Decompiled with JetBrains decompiler
// Type: MSXML2.IMXSchemaDeclHandler
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(4288)]
[Guid("FA4BB38C-FAF9-4CCA-9302-D1DD0FE520DB")]
[ComImport]
public interface IMXSchemaDeclHandler
{
  [DispId(1403)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void schemaElementDecl([MarshalAs(UnmanagedType.Interface), In] ISchemaElement oSchemaElement);
}
