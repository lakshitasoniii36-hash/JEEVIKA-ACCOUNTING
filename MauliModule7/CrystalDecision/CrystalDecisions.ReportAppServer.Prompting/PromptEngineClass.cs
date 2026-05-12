// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.PromptEngineClass
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[Guid("AC33EB2C-8DA5-4C9F-BD8D-AF020B9BFD38")]
[ClassInterface(0)]
[TypeLibType(530)]
[ComSourceInterfaces("CrystalDecisions.ReportAppServer.Prompting._IPromptEngineEvents\0\0")]
[ComImport]
public class PromptEngineClass : IPromptEngine, PromptEngine, _IPromptEngineEvents_Event
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern PromptEngineClass();

  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern PromptingResult startPrompting(
    [MarshalAs(UnmanagedType.Interface), In] PromptingUnits units,
    [MarshalAs(UnmanagedType.Interface), In] CRPromptingInfoProvider infoProvider,
    [MarshalAs(UnmanagedType.Interface), In] PromptingOption option);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern PromptingResult processPrompting([MarshalAs(UnmanagedType.Interface), In] IPromptingFeedback feedback);
}
