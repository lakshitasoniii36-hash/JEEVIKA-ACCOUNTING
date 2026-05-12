// Decompiled with JetBrains decompiler
// Type: MSXML2.ISchemaAttribute
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("50EA08B6-DD1B-4664-9A50-C2F40F4BD79A")]
[TypeLibType(4288)]
[ComImport]
public interface ISchemaAttribute : ISchemaItem
{
  [DispId(1457)]
  new string name { [DispId(1457), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1459)]
  new string namespaceURI { [DispId(1459), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1467)]
  new ISchema schema { [DispId(1467), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1440)]
  new string id { [DispId(1440), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1446)]
  [ComAliasName("MSXML2.SOMITEMTYPE")]
  new SOMITEMTYPE itemType { [DispId(1446), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("MSXML2.SOMITEMTYPE")] get; }

  [DispId(1478)]
  new IVBSAXAttributes unhandledAttributes { [DispId(1478), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1483)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new bool writeAnnotation([MarshalAs(UnmanagedType.IUnknown), In] object annotationSink);

  [DispId(1476)]
  ISchemaType type { [DispId(1476), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1469)]
  ISchemaComplexType scope { [DispId(1469), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1431)]
  string defaultValue { [DispId(1431), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1438)]
  string fixedValue { [DispId(1438), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [ComAliasName("MSXML2.SCHEMAUSE")]
  [DispId(1479)]
  SCHEMAUSE use { [DispId(1479), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("MSXML2.SCHEMAUSE")] get; }

  [DispId(1444)]
  bool isReference { [DispId(1444), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
}
