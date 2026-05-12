// Decompiled with JetBrains decompiler
// Type: MSXML2.ISchemaComplexType
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace MSXML2;

[Guid("50EA08B9-DD1B-4664-9A50-C2F40F4BD79A")]
[TypeLibType(4288)]
[ComImport]
public interface ISchemaComplexType : ISchemaType
{
  [DispId(1457)]
  new string name { [DispId(1457), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1459)]
  new string namespaceURI { [DispId(1459), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1467)]
  new ISchema schema { [DispId(1467), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1440)]
  new string id { [DispId(1440), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [ComAliasName("MSXML2.SOMITEMTYPE")]
  [DispId(1446)]
  new SOMITEMTYPE itemType { [DispId(1446), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("MSXML2.SOMITEMTYPE")] get; }

  [DispId(1478)]
  new IVBSAXAttributes unhandledAttributes { [DispId(1478), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1483)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new bool writeAnnotation([MarshalAs(UnmanagedType.IUnknown), In] object annotationSink);

  [DispId(1428)]
  new ISchemaItemCollection baseTypes { [DispId(1428), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1437)]
  [ComAliasName("MSXML2.SCHEMADERIVATIONMETHOD")]
  new SCHEMADERIVATIONMETHOD final { [DispId(1437), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("MSXML2.SCHEMADERIVATIONMETHOD")] get; }

  [ComAliasName("MSXML2.SCHEMATYPEVARIETY")]
  [DispId(1480)]
  new SCHEMATYPEVARIETY variety { [DispId(1480), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("MSXML2.SCHEMATYPEVARIETY")] get; }

  [ComAliasName("MSXML2.SCHEMADERIVATIONMETHOD")]
  [DispId(1432)]
  new SCHEMADERIVATIONMETHOD derivedBy { [DispId(1432), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("MSXML2.SCHEMADERIVATIONMETHOD")] get; }

  [DispId(1445)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new bool isValid([MarshalAs(UnmanagedType.BStr), In] string data);

  [DispId(1452)]
  new string minExclusive { [DispId(1452), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1453)]
  new string minInclusive { [DispId(1453), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1448)]
  new string maxExclusive { [DispId(1448), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1449)]
  new string maxInclusive { [DispId(1449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1475)]
  new object totalDigits { [DispId(1475), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1439)]
  new object fractionDigits { [DispId(1439), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1447)]
  new object length { [DispId(1447), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1454)]
  new object minLength { [DispId(1454), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1450)]
  new object maxLength { [DispId(1450), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1435)]
  new ISchemaStringCollection enumeration { [DispId(1435), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1482)]
  [ComAliasName("MSXML2.SCHEMAWHITESPACE")]
  new SCHEMAWHITESPACE whitespace { [DispId(1482), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("MSXML2.SCHEMAWHITESPACE")] get; }

  [DispId(1462)]
  new ISchemaStringCollection patterns { [DispId(1462), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1442)]
  bool isAbstract { [DispId(1442), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1425)]
  ISchemaAny anyAttribute { [DispId(1425), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1427)]
  ISchemaItemCollection attributes { [DispId(1427), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [ComAliasName("MSXML2.SCHEMACONTENTTYPE")]
  [DispId(1430)]
  SCHEMACONTENTTYPE contentType { [DispId(1430), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("MSXML2.SCHEMACONTENTTYPE")] get; }

  [DispId(1429)]
  ISchemaModelGroup contentModel { [DispId(1429), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1464)]
  [ComAliasName("MSXML2.SCHEMADERIVATIONMETHOD")]
  SCHEMADERIVATIONMETHOD prohibitedSubstitutions { [DispId(1464), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("MSXML2.SCHEMADERIVATIONMETHOD")] get; }
}
