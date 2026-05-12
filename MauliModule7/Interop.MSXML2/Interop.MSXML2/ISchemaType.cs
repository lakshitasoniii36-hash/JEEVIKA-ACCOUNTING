// Decompiled with JetBrains decompiler
// Type: MSXML2.ISchemaType
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[TypeLibType(4288)]
[Guid("50EA08B8-DD1B-4664-9A50-C2F40F4BD79A")]
[ComImport]
public interface ISchemaType : ISchemaItem
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

  [DispId(1428)]
  ISchemaItemCollection baseTypes { [DispId(1428), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [ComAliasName("MSXML2.SCHEMADERIVATIONMETHOD")]
  [DispId(1437)]
  SCHEMADERIVATIONMETHOD final { [DispId(1437), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("MSXML2.SCHEMADERIVATIONMETHOD")] get; }

  [ComAliasName("MSXML2.SCHEMATYPEVARIETY")]
  [DispId(1480)]
  SCHEMATYPEVARIETY variety { [DispId(1480), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("MSXML2.SCHEMATYPEVARIETY")] get; }

  [DispId(1432)]
  [ComAliasName("MSXML2.SCHEMADERIVATIONMETHOD")]
  SCHEMADERIVATIONMETHOD derivedBy { [DispId(1432), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("MSXML2.SCHEMADERIVATIONMETHOD")] get; }

  [DispId(1445)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool isValid([MarshalAs(UnmanagedType.BStr), In] string data);

  [DispId(1452)]
  string minExclusive { [DispId(1452), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1453)]
  string minInclusive { [DispId(1453), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1448)]
  string maxExclusive { [DispId(1448), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1449)]
  string maxInclusive { [DispId(1449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1475)]
  object totalDigits { [DispId(1475), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1439)]
  object fractionDigits { [DispId(1439), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1447)]
  object length { [DispId(1447), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1454)]
  object minLength { [DispId(1454), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1450)]
  object maxLength { [DispId(1450), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1435)]
  ISchemaStringCollection enumeration { [DispId(1435), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [ComAliasName("MSXML2.SCHEMAWHITESPACE")]
  [DispId(1482)]
  SCHEMAWHITESPACE whitespace { [DispId(1482), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("MSXML2.SCHEMAWHITESPACE")] get; }

  [DispId(1462)]
  ISchemaStringCollection patterns { [DispId(1462), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
}
