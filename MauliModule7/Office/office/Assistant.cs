// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.Assistant
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[Guid("000C0322-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
[DefaultMember("Item")]
[ComImport]
public interface Assistant : _IMsoDispObj
{
  [DispId(1610743808 /*0x60020000*/)]
  new object Application { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  new int Creator { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809344 /*0x60030000*/)]
  object Parent { [DispId(1610809344 /*0x60030000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809345 /*0x60030001*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Move([In] int xLeft, [In] int yTop);

  [DispId(1610809346 /*0x60030002*/)]
  int Top { [DispId(1610809346 /*0x60030002*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809346 /*0x60030002*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809348 /*0x60030004*/)]
  int Left { [DispId(1610809348 /*0x60030004*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809348 /*0x60030004*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809350 /*0x60030006*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Help();

  [DispId(1610809351 /*0x60030007*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int StartWizard(
    [In] bool On,
    [MarshalAs(UnmanagedType.BStr), In] string Callback,
    [In] int PrivateX,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Animation,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CustomTeaser,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Top,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Left,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Bottom,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Right);

  [DispId(1610809352 /*0x60030008*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EndWizard([In] int WizardID, [In] bool varfSuccess, [MarshalAs(UnmanagedType.Struct), In, Optional] object Animation);

  [DispId(1610809353 /*0x60030009*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ActivateWizard([In] int WizardID, [In] MsoWizardActType act, [MarshalAs(UnmanagedType.Struct), In, Optional] object Animation);

  [DispId(1610809354 /*0x6003000A*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ResetTips();

  [DispId(1610809355 /*0x6003000B*/)]
  Balloon NewBalloon { [DispId(1610809355 /*0x6003000B*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809356 /*0x6003000C*/)]
  MsoBalloonErrorType BalloonError { [DispId(1610809356 /*0x6003000C*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809357 /*0x6003000D*/)]
  bool Visible { [DispId(1610809357 /*0x6003000D*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809357 /*0x6003000D*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809359 /*0x6003000F*/)]
  MsoAnimationType Animation { [DispId(1610809359 /*0x6003000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809359 /*0x6003000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809361)]
  bool Reduced { [DispId(1610809361), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809361), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809363)]
  bool AssistWithHelp { [DispId(1610809363), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809363), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809365)]
  bool AssistWithWizards { [DispId(1610809365), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809365), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809367)]
  bool AssistWithAlerts { [DispId(1610809367), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809367), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809369)]
  bool MoveWhenInTheWay { [DispId(1610809369), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809369), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809371)]
  bool Sounds { [DispId(1610809371), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809371), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809373)]
  bool FeatureTips { [DispId(1610809373), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809373), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809375)]
  bool MouseTips { [DispId(1610809375), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809375), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809377)]
  bool KeyboardShortcutTips { [DispId(1610809377), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809377), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809379)]
  bool HighPriorityTips { [DispId(1610809379), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809379), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809381)]
  bool TipOfDay { [DispId(1610809381), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809381), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809383)]
  bool GuessHelp { [DispId(1610809383), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809383), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809385)]
  bool SearchWhenProgramming { [DispId(1610809385), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [DispId(1610809385), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(0)]
  string Item { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809388)]
  string FileName { [DispId(1610809388), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610809388), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610809390)]
  string Name { [DispId(1610809390), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809391)]
  bool On { [DispId(1610809391), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809391), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809393)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int DoAlert(
    [MarshalAs(UnmanagedType.BStr), In] string bstrAlertTitle,
    [MarshalAs(UnmanagedType.BStr), In] string bstrAlertText,
    [In] MsoAlertButtonType alb,
    [In] MsoAlertIconType alc,
    [In] MsoAlertDefaultType ald,
    [In] MsoAlertCancelType alq,
    [In] bool varfSysAlert);
}
