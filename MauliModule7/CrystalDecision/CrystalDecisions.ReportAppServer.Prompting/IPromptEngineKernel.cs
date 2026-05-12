// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.IPromptEngineKernel
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[Guid("CAB83B5B-1800-4AB5-AC3D-96714C5865E9")]
[TypeLibType(4688)]
[ComImport]
public interface IPromptEngineKernel
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IPromptingRenderResult render([MarshalAs(UnmanagedType.BStr), In] string ContextHandle);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int resolve([MarshalAs(UnmanagedType.BStr), In] string ContextHandle, [MarshalAs(UnmanagedType.Interface), In] IPromptingFeedback feedback);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string prepare([MarshalAs(UnmanagedType.Interface), In] PromptingUnits units, [MarshalAs(UnmanagedType.Interface), In] CRPromptingInfoProvider info, [MarshalAs(UnmanagedType.Interface), In] PromptingOption option);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PromptingResolveUnits realize([MarshalAs(UnmanagedType.BStr), In] string ContextHandle);

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void finish([MarshalAs(UnmanagedType.BStr), In] string ContextHandle);

  [DispId(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string resolveContext([MarshalAs(UnmanagedType.Interface), In] IPromptingFeedback pFeedback);

  [DispId(7)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IPromptingRenderOption getRenderOption([MarshalAs(UnmanagedType.BStr), In] string ContextHandle);
}
