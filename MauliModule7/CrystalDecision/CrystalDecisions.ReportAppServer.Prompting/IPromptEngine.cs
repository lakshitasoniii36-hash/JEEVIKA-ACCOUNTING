// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.IPromptEngine
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[Guid("6CEF5C28-ADEA-4AE0-8A35-F5D15D63E806")]
[TypeLibType(4688)]
[ComImport]
public interface IPromptEngine
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PromptingResult startPrompting(
    [MarshalAs(UnmanagedType.Interface), In] PromptingUnits units,
    [MarshalAs(UnmanagedType.Interface), In] CRPromptingInfoProvider infoProvider,
    [MarshalAs(UnmanagedType.Interface), In] PromptingOption option);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PromptingResult processPrompting([MarshalAs(UnmanagedType.Interface), In] IPromptingFeedback feedback);
}
