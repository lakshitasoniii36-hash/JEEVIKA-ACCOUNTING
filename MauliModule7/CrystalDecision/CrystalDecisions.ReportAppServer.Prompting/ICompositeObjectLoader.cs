// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.ICompositeObjectLoader
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[TypeLibType(4688)]
[Guid("87F73F47-642E-4888-9A84-DD2A339F5C32")]
[ComImport]
public interface ICompositeObjectLoader : IObjectLoader
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object load([MarshalAs(UnmanagedType.BStr), In] string objRef, [MarshalAs(UnmanagedType.BStr), In] string objType);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new int getProtocolCount();

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string getProtocol([In] int Index);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743811 /*0x60020003*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve10();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743812 /*0x60020004*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve9();

  [DispId(1610743813 /*0x60020005*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve8();

  [DispId(1610743814 /*0x60020006*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve7();

  [DispId(1610743815 /*0x60020007*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve6();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743816 /*0x60020008*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve5();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743817 /*0x60020009*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve4();

  [DispId(1610743818 /*0x6002000A*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve3();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743819 /*0x6002000B*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve2();

  [DispId(1610743820 /*0x6002000C*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void reserve1();

  [DispId(100)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IObjectLoader get_Loader([MarshalAs(UnmanagedType.BStr), In] string protocol);

  [DispId(100)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void set_Loader([MarshalAs(UnmanagedType.BStr), In] string protocol, [MarshalAs(UnmanagedType.Interface), In] IObjectLoader Loader);
}
