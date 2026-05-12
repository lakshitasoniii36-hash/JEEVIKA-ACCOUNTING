// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.IPromptEngineRenderer
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[Guid("A4B76F39-2EF2-4EEC-B646-39E1226480F9")]
[TypeLibType(4688)]
[ComImport]
public interface IPromptEngineRenderer
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  IPromptingRenderResult render([MarshalAs(UnmanagedType.Interface), In] PromptEngineRuntimeContext Context, [MarshalAs(UnmanagedType.Interface), In] IPromptingRenderOption option);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int resolve([MarshalAs(UnmanagedType.Interface), In] PromptEngineRuntimeContext Context, [MarshalAs(UnmanagedType.Interface), In] IPromptingFeedback feedback);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void resolveContext([MarshalAs(UnmanagedType.Interface), In] IPromptingFeedback feedback, [MarshalAs(UnmanagedType.Interface)] out PromptEngineRuntimeContext newContext);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void requireContextID([MarshalAs(UnmanagedType.Interface), In] IPromptingRenderOption option, out bool requireID);

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void createPromptID([MarshalAs(UnmanagedType.Interface), In] PromptEngineRuntimeContext Context, [MarshalAs(UnmanagedType.BStr)] out string ID);
}
