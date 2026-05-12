// Decompiled with JetBrains decompiler
// Type: ADOX._User25
// Assembly: Interop.ADOX, Version=2.8.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 69CDF16F-3374-4ED0-952A-9EAF19059C50
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.ADOX.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace ADOX;

[DefaultMember("Name")]
[Guid("00000619-0000-0010-8000-00AA006D2EA4")]
[TypeLibType(4288)]
[ComImport]
public interface _User25
{
  [DispId(0)]
  string Name { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  RightsEnum GetPermissions([MarshalAs(UnmanagedType.Struct), In] object Name, [In] ObjectTypeEnum ObjectType, [MarshalAs(UnmanagedType.Struct), In, Optional] object ObjectTypeId);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetPermissions(
    [MarshalAs(UnmanagedType.Struct), In] object Name,
    [In] ObjectTypeEnum ObjectType,
    [In] ActionEnum Action,
    [In] RightsEnum Rights,
    [In] InheritTypeEnum Inherit = InheritTypeEnum.adInheritNone,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ObjectTypeId);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ChangePassword([MarshalAs(UnmanagedType.BStr), In] string OldPassword, [MarshalAs(UnmanagedType.BStr), In] string NewPassword);

  [DispId(5)]
  Groups Groups { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
}
