// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.PromptEngineKernelClass
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[ClassInterface(0)]
[TypeLibType(530)]
[ComSourceInterfaces("CrystalDecisions.ReportAppServer.Prompting._IPromptEngineEvents\0\0")]
[Guid("30A4831E-CCD9-4564-BD21-64DE1B2B3A3B")]
[ComImport]
public class PromptEngineKernelClass : 
  IPromptEngineKernel,
  PromptEngineKernel,
  _IPromptEngineEvents_Event
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern PromptEngineKernelClass();

  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern IPromptingRenderResult render([MarshalAs(UnmanagedType.BStr), In] string ContextHandle);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int resolve([MarshalAs(UnmanagedType.BStr), In] string ContextHandle, [MarshalAs(UnmanagedType.Interface), In] IPromptingFeedback feedback);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string prepare(
    [MarshalAs(UnmanagedType.Interface), In] PromptingUnits units,
    [MarshalAs(UnmanagedType.Interface), In] CRPromptingInfoProvider info,
    [MarshalAs(UnmanagedType.Interface), In] PromptingOption option);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern PromptingResolveUnits realize([MarshalAs(UnmanagedType.BStr), In] string ContextHandle);

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void finish([MarshalAs(UnmanagedType.BStr), In] string ContextHandle);

  [DispId(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string resolveContext([MarshalAs(UnmanagedType.Interface), In] IPromptingFeedback pFeedback);

  [DispId(7)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern IPromptingRenderOption getRenderOption([MarshalAs(UnmanagedType.BStr), In] string ContextHandle);
}
