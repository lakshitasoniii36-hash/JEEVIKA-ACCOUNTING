// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.IDiscreteValue
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[TypeLibType(4688)]
[Guid("FBAFF764-8E73-4FFD-9A8D-BC10DCECFFEE")]
[ComImport]
public interface IDiscreteValue : IValue
{
  [DispId(1001)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  new IValue Clone([In] bool DeepClone = true);

  [DispId(1002)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void CopyTo([MarshalAs(UnmanagedType.Interface), In] IValue value, [In] bool DeepCopy = true);

  [DispId(1003)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new bool Equals([MarshalAs(UnmanagedType.Interface), In] IValue value);

  [DispId(1004)]
  new string ClassName { [DispId(1004), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1)]
  new bool IsNull { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743814 /*0x60020006*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve10();

  [DispId(1610743815 /*0x60020007*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve9();

  [DispId(1610743816 /*0x60020008*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve8();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743817 /*0x60020009*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve7();

  [DispId(1610743818 /*0x6002000A*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve6();

  [DispId(1610743819 /*0x6002000B*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve5();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743820 /*0x6002000C*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve4();

  [DispId(1610743821 /*0x6002000D*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve3();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743822 /*0x6002000E*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve2();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743823 /*0x6002000F*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve1();

  [DispId(100)]
  string value { [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610809346 /*0x60030002*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve10a();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610809347 /*0x60030003*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve9a();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610809348 /*0x60030004*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve8a();

  [DispId(1610809349 /*0x60030005*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve7a();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610809350 /*0x60030006*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve6a();

  [DispId(1610809351 /*0x60030007*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve5a();

  [DispId(1610809352 /*0x60030008*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve4a();

  [DispId(1610809353 /*0x60030009*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve3a();

  [DispId(1610809354 /*0x6003000A*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve2a();

  [DispId(1610809355 /*0x6003000B*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve1a();
}
