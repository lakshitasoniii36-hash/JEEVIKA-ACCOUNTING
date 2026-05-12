// Decompiled with JetBrains decompiler
// Type: ADOX._Catalog
// Assembly: Interop.ADOX, Version=2.8.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 69CDF16F-3374-4ED0-952A-9EAF19059C50
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.ADOX.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace ADOX;

[Guid("00000603-0000-0010-8000-00AA006D2EA4")]
[TypeLibType(4288)]
[DefaultMember("Tables")]
[ComImport]
public interface _Catalog
{
  [DispId(0)]
  Tables Tables { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1)]
  object ActiveConnection { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IDispatch), In] set; }

  [DispId(1)]
  [SpecialName]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void let_ActiveConnection([MarshalAs(UnmanagedType.Struct), In] object pVal);

  [DispId(2)]
  Procedures Procedures { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(3)]
  Views Views { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(4)]
  Groups Groups { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(5)]
  Users Users { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Create([MarshalAs(UnmanagedType.BStr), In] string ConnectString);

  [DispId(7)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetObjectOwner([MarshalAs(UnmanagedType.BStr), In] string ObjectName, [In] ObjectTypeEnum ObjectType, [MarshalAs(UnmanagedType.Struct), In, Optional] object ObjectTypeId);

  [DispId(8)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetObjectOwner(
    [MarshalAs(UnmanagedType.BStr), In] string ObjectName,
    [In] ObjectTypeEnum ObjectType,
    [MarshalAs(UnmanagedType.BStr), In] string UserName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ObjectTypeId);
}
