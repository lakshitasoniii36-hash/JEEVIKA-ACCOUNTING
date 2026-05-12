// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.LOVContextClass
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[TypeLibType(530)]
[ClassInterface(0)]
[Guid("D286AF75-70E6-4695-AFD7-3586A1CD593E")]
[ComImport]
public class LOVContextClass : ILOVContext, LOVContext
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern LOVContextClass();

  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int GetNodeCount();

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern LOVNode get_Node([In] int Index);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void set_Node([In] int Index, [MarshalAs(UnmanagedType.Interface), In] LOVNode Node);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void AddNode([MarshalAs(UnmanagedType.Interface), In] LOVNode Node);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void InsertNode([In] int Index, [MarshalAs(UnmanagedType.Interface), In] LOVNode Node);

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RemoveNode([In] int Index);

  [DispId(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RemoveAllNodes();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743815 /*0x60020007*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve20();

  [DispId(1610743816 /*0x60020008*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve19();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743817 /*0x60020009*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve18();

  [DispId(1610743818 /*0x6002000A*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve17();

  [DispId(1610743819 /*0x6002000B*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve16();

  [DispId(1610743820 /*0x6002000C*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve15();

  [DispId(1610743821 /*0x6002000D*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve14();

  [DispId(1610743822 /*0x6002000E*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve13();

  [DispId(1610743823 /*0x6002000F*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve12();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743824 /*0x60020010*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve11();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743825)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve10();

  [DispId(1610743826)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve9();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743827)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve8();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743828)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve7();

  [DispId(1610743829)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve6();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743830)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve5();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743831)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve4();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743832)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve3();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743833)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve2();

  [DispId(1610743834)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void reserve1();
}
