// Decompiled with JetBrains decompiler
// Type: ADOX.CatalogClass
// Assembly: Interop.ADOX, Version=2.8.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 69CDF16F-3374-4ED0-952A-9EAF19059C50
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.ADOX.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace ADOX;

[ClassInterface(0)]
[TypeLibType(2)]
[DefaultMember("Tables")]
[Guid("00000602-0000-0010-8000-00AA006D2EA4")]
[ComImport]
public class CatalogClass : _Catalog, Catalog
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern CatalogClass();

  [DispId(0)]
  public virtual extern Tables Tables { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1)]
  public virtual extern object ActiveConnection { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IDispatch), In] set; }

  [DispId(1)]
  [SpecialName]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void let_ActiveConnection([MarshalAs(UnmanagedType.Struct), In] object pVal);

  [DispId(2)]
  public virtual extern Procedures Procedures { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(3)]
  public virtual extern Views Views { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(4)]
  public virtual extern Groups Groups { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(5)]
  public virtual extern Users Users { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object Create([MarshalAs(UnmanagedType.BStr), In] string ConnectString);

  [DispId(7)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string GetObjectOwner(
    [MarshalAs(UnmanagedType.BStr), In] string ObjectName,
    [In] ObjectTypeEnum ObjectType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ObjectTypeId);

  [DispId(8)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetObjectOwner(
    [MarshalAs(UnmanagedType.BStr), In] string ObjectName,
    [In] ObjectTypeEnum ObjectType,
    [MarshalAs(UnmanagedType.BStr), In] string UserName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ObjectTypeId);
}
