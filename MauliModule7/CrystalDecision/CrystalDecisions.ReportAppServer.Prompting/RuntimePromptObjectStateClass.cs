// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.RuntimePromptObjectStateClass
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[ClassInterface(0)]
[Guid("C87CD6F2-3054-4C14-87B7-33E39589C8DB")]
[TypeLibType(530)]
[ComImport]
public class RuntimePromptObjectStateClass : IRuntimePromptObjectState, RuntimePromptObjectState
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern RuntimePromptObjectStateClass();

  [DispId(1)]
  public virtual extern string ID { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(2)]
  public virtual extern LOVContexts ValueContexts { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool IsSameID([MarshalAs(UnmanagedType.BStr), In] string ID);
}
