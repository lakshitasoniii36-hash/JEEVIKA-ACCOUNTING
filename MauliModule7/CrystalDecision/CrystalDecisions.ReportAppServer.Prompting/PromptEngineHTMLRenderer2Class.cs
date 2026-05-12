// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.PromptEngineHTMLRenderer2Class
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[ClassInterface(0)]
[Guid("50060CFF-ABE2-400C-8099-95F2A5432D3D")]
[TypeLibType(530)]
[ComImport]
public class PromptEngineHTMLRenderer2Class : IPromptEngineRenderer, PromptEngineHTMLRenderer2
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern PromptEngineHTMLRenderer2Class();

  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern IPromptingRenderResult render(
    [MarshalAs(UnmanagedType.Interface), In] PromptEngineRuntimeContext Context,
    [MarshalAs(UnmanagedType.Interface), In] IPromptingRenderOption option);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int resolve([MarshalAs(UnmanagedType.Interface), In] PromptEngineRuntimeContext Context, [MarshalAs(UnmanagedType.Interface), In] IPromptingFeedback feedback);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void resolveContext(
    [MarshalAs(UnmanagedType.Interface), In] IPromptingFeedback feedback,
    [MarshalAs(UnmanagedType.Interface)] out PromptEngineRuntimeContext newContext);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void requireContextID([MarshalAs(UnmanagedType.Interface), In] IPromptingRenderOption option, out bool requireID);

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void createPromptID([MarshalAs(UnmanagedType.Interface), In] PromptEngineRuntimeContext Context, [MarshalAs(UnmanagedType.BStr)] out string ID);
}
