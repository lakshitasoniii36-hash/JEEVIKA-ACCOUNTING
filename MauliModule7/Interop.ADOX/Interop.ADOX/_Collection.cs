// Decompiled with JetBrains decompiler
// Type: ADOX._Collection
// Assembly: Interop.ADOX, Version=2.8.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 69CDF16F-3374-4ED0-952A-9EAF19059C50
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.ADOX.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace ADOX;

[Guid("00000512-0000-0010-8000-00AA006D2EA4")]
[TypeLibType(4288)]
[ComImport]
public interface _Collection : IEnumerable
{
  [DispId(1610743808 /*0x60020000*/)]
  int Count { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(1)]
  [DispId(-4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(1610743810 /*0x60020002*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Refresh();
}
