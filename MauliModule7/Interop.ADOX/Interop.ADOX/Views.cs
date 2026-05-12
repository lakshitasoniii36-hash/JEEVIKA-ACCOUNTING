// Decompiled with JetBrains decompiler
// Type: ADOX.Views
// Assembly: Interop.ADOX, Version=2.8.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 69CDF16F-3374-4ED0-952A-9EAF19059C50
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.ADOX.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace ADOX;

[TypeLibType(4288)]
[Guid("00000614-0000-0010-8000-00AA006D2EA4")]
[ComImport]
public interface Views : _Collection
{
  [DispId(1610743808 /*0x60020000*/)]
  new int Count { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(-4)]
  [TypeLibFunc(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(1610743810 /*0x60020002*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void Refresh();

  [DispId(0)]
  View this[[MarshalAs(UnmanagedType.Struct), In] object Item] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809345 /*0x60030001*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Append([MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.IDispatch), In] object Command);

  [DispId(1610809346 /*0x60030002*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Delete([MarshalAs(UnmanagedType.Struct), In] object Item);
}
