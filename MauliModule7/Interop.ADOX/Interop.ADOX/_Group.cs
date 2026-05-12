// Decompiled with JetBrains decompiler
// Type: ADOX._Group
// Assembly: Interop.ADOX, Version=2.8.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 69CDF16F-3374-4ED0-952A-9EAF19059C50
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.ADOX.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace ADOX;

[DefaultMember("Name")]
[Guid("00000628-0000-0010-8000-00AA006D2EA4")]
[TypeLibType(4288)]
[ComImport]
public interface _Group : _Group25
{
  [DispId(0)]
  new string Name { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new RightsEnum GetPermissions([MarshalAs(UnmanagedType.Struct), In] object Name, [In] ObjectTypeEnum ObjectType, [MarshalAs(UnmanagedType.Struct), In, Optional] object ObjectTypeId);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void SetPermissions(
    [MarshalAs(UnmanagedType.Struct), In] object Name,
    [In] ObjectTypeEnum ObjectType,
    [In] ActionEnum Action,
    [In] RightsEnum Rights,
    [In] InheritTypeEnum Inherit = InheritTypeEnum.adInheritNone,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ObjectTypeId);

  [DispId(4)]
  new Users Users { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(5)]
  Properties Properties { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(6)]
  Catalog ParentCatalog { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(6)]
  [SpecialName]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void let_ParentCatalog([MarshalAs(UnmanagedType.Interface), In] Catalog ppvObject);
}
