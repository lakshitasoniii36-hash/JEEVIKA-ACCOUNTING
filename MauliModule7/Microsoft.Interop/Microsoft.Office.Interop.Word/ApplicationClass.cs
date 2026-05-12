// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.ApplicationClass
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using Microsoft.Office.Core;
using Microsoft.Vbe.Interop;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[ClassInterface(0)]
[ComSourceInterfaces("Microsoft.Office.Interop.Word.ApplicationEvents4\0Microsoft.Office.Interop.Word.ApplicationEvents\0Microsoft.Office.Interop.Word.ApplicationEvents2\0Microsoft.Office.Interop.Word.ApplicationEvents3\0\0")]
[Guid("000209FF-0000-0000-C000-000000000046")]
[TypeLibType(2)]
[DefaultMember("Name")]
[ComImport]
public class ApplicationClass : 
  _Application,
  Application,
  ApplicationEvents4_Event,
  ApplicationEvents_Event,
  ApplicationEvents2_Event,
  ApplicationEvents3_Event
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern ApplicationClass();

  [DispId(1000)]
  public virtual extern Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  public virtual extern int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  public virtual extern object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(0)]
  public virtual extern string Name { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(6)]
  public virtual extern Documents Documents { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2)]
  public virtual extern Windows Windows { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(3)]
  public virtual extern Document ActiveDocument { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(4)]
  public virtual extern Window ActiveWindow { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(5)]
  public virtual extern Selection Selection { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1)]
  public virtual extern object WordBasic { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(7)]
  public virtual extern RecentFiles RecentFiles { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(8)]
  public virtual extern Template NormalTemplate { [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(9)]
  public virtual extern Microsoft.Office.Interop.Word.System System { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(10)]
  public virtual extern AutoCorrect AutoCorrect { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(11)]
  public virtual extern FontNames FontNames { [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(12)]
  public virtual extern FontNames LandscapeFontNames { [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(13)]
  public virtual extern FontNames PortraitFontNames { [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(14)]
  public virtual extern Languages Languages { [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(15)]
  public virtual extern Assistant Assistant { [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(16 /*0x10*/)]
  public virtual extern Browser Browser { [DispId(16 /*0x10*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(17)]
  public virtual extern FileConverters FileConverters { [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(18)]
  public virtual extern MailingLabel MailingLabel { [DispId(18), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(19)]
  public virtual extern Dialogs Dialogs { [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(20)]
  public virtual extern CaptionLabels CaptionLabels { [DispId(20), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(21)]
  public virtual extern AutoCaptions AutoCaptions { [DispId(21), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(22)]
  public virtual extern AddIns AddIns { [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(23)]
  public virtual extern bool Visible { [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(24)]
  public virtual extern string Version { [DispId(24), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(26)]
  public virtual extern bool ScreenUpdating { [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(27)]
  public virtual extern bool PrintPreview { [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(28)]
  public virtual extern Tasks Tasks { [DispId(28), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(29)]
  public virtual extern bool DisplayStatusBar { [TypeLibFunc(64 /*0x40*/), DispId(29), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(29), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(30)]
  public virtual extern bool SpecialMode { [DispId(30), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(33)]
  public virtual extern int UsableWidth { [DispId(33), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(34)]
  public virtual extern int UsableHeight { [DispId(34), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(36)]
  public virtual extern bool MathCoprocessorAvailable { [DispId(36), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(37)]
  public virtual extern bool MouseAvailable { [DispId(37), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(46)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object get_International([In] WdInternationalIndex Index);

  [DispId(47)]
  public virtual extern string Build { [DispId(47), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(48 /*0x30*/)]
  public virtual extern bool CapsLock { [DispId(48 /*0x30*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(49)]
  public virtual extern bool NumLock { [DispId(49), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(52)]
  public virtual extern string UserName { [DispId(52), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(52), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(53)]
  public virtual extern string UserInitials { [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(54)]
  public virtual extern string UserAddress { [DispId(54), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(54), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(55)]
  public virtual extern object MacroContainer { [DispId(55), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(56)]
  public virtual extern bool DisplayRecentFiles { [DispId(56), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(56), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(57)]
  public virtual extern CommandBars CommandBars { [DispId(57), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(59)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern SynonymInfo get_SynonymInfo([MarshalAs(UnmanagedType.BStr), In] string Word, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LanguageID);

  [DispId(61)]
  public virtual extern VBE VBE { [DispId(61), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(64 /*0x40*/)]
  public virtual extern string DefaultSaveFormat { [DispId(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(65)]
  public virtual extern ListGalleries ListGalleries { [DispId(65), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(66)]
  public virtual extern string ActivePrinter { [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(67)]
  public virtual extern Templates Templates { [DispId(67), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(68)]
  public virtual extern object CustomizationContext { [DispId(68), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; [DispId(68), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IDispatch), In] set; }

  [DispId(69)]
  public virtual extern KeyBindings KeyBindings { [DispId(69), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(70)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern KeysBoundTo get_KeysBoundTo(
    [In] WdKeyCategory KeyCategory,
    [MarshalAs(UnmanagedType.BStr), In] string Command,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CommandParameter);

  [DispId(71)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern KeyBinding get_FindKey([In] int KeyCode, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object KeyCode2);

  [DispId(80 /*0x50*/)]
  public virtual extern string Caption { [DispId(80 /*0x50*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(80 /*0x50*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(81)]
  public virtual extern string Path { [DispId(81), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(82)]
  public virtual extern bool DisplayScrollBars { [DispId(82), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(82), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(83)]
  public virtual extern string StartupPath { [DispId(83), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(83), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(85)]
  public virtual extern int BackgroundSavingStatus { [DispId(85), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(86)]
  public virtual extern int BackgroundPrintingStatus { [DispId(86), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(87)]
  public virtual extern int Left { [DispId(87), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(87), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(88)]
  public virtual extern int Top { [DispId(88), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(88), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(89)]
  public virtual extern int Width { [DispId(89), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(89), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(90)]
  public virtual extern int Height { [DispId(90), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(90), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(91)]
  public virtual extern WdWindowState WindowState { [DispId(91), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(91), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(92)]
  public virtual extern bool DisplayAutoCompleteTips { [DispId(92), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(92), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(93)]
  public virtual extern Options Options { [DispId(93), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(94)]
  public virtual extern WdAlertLevel DisplayAlerts { [DispId(94), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(94), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(95)]
  public virtual extern Dictionaries CustomDictionaries { [DispId(95), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(96 /*0x60*/)]
  public virtual extern string PathSeparator { [DispId(96 /*0x60*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(97)]
  public virtual extern string StatusBar { [DispId(97), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(98)]
  public virtual extern bool MAPIAvailable { [DispId(98), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(99)]
  public virtual extern bool DisplayScreenTips { [DispId(99), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(99), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(100)]
  public virtual extern WdEnableCancelKey EnableCancelKey { [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(101)]
  public virtual extern bool UserControl { [DispId(101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(103)]
  public virtual extern FileSearch FileSearch { [TypeLibFunc(64 /*0x40*/), DispId(103), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(104)]
  public virtual extern WdMailSystem MailSystem { [DispId(104), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(105)]
  public virtual extern string DefaultTableSeparator { [DispId(105), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(105), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(106)]
  public virtual extern bool ShowVisualBasicEditor { [DispId(106), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(106), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(108)]
  public virtual extern string BrowseExtraFileTypes { [DispId(108), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(108), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(109)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool get_IsObjectValid([MarshalAs(UnmanagedType.IDispatch), In] object Object);

  [DispId(110)]
  public virtual extern HangulHanjaConversionDictionaries HangulHanjaDictionaries { [DispId(110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(348)]
  public virtual extern MailMessage MailMessage { [DispId(348), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(386)]
  public virtual extern bool FocusInMailHeader { [DispId(386), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Quit(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveChanges,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OriginalFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RouteDocument);

  [DispId(301)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ScreenRefresh();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(302)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PrintOutOld(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Background,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Append,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OutputFileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Item,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Pages,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PageType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ActivePrinterMacGX,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ManualDuplexPrint);

  [DispId(303)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void LookupNameProperties([MarshalAs(UnmanagedType.BStr), In] string Name);

  [DispId(304)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SubstituteFont([MarshalAs(UnmanagedType.BStr), In] string UnavailableFont, [MarshalAs(UnmanagedType.BStr), In] string SubstituteFont);

  [DispId(305)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool Repeat([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Times);

  [DispId(310)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DDEExecute([In] int Channel, [MarshalAs(UnmanagedType.BStr), In] string Command);

  [DispId(311)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int DDEInitiate([MarshalAs(UnmanagedType.BStr), In] string App, [MarshalAs(UnmanagedType.BStr), In] string Topic);

  [DispId(312)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DDEPoke([In] int Channel, [MarshalAs(UnmanagedType.BStr), In] string Item, [MarshalAs(UnmanagedType.BStr), In] string Data);

  [DispId(313)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string DDERequest([In] int Channel, [MarshalAs(UnmanagedType.BStr), In] string Item);

  [DispId(314)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DDETerminate([In] int Channel);

  [DispId(315)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DDETerminateAll();

  [DispId(316)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int BuildKeyCode(
    [In] WdKey Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Arg4);

  [DispId(317)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string KeyString([In] int KeyCode, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object KeyCode2);

  [DispId(318)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void OrganizerCopy(
    [MarshalAs(UnmanagedType.BStr), In] string Source,
    [MarshalAs(UnmanagedType.BStr), In] string Destination,
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [In] WdOrganizerObject Object);

  [DispId(319)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void OrganizerDelete([MarshalAs(UnmanagedType.BStr), In] string Source, [MarshalAs(UnmanagedType.BStr), In] string Name, [In] WdOrganizerObject Object);

  [DispId(320)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void OrganizerRename(
    [MarshalAs(UnmanagedType.BStr), In] string Source,
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.BStr), In] string NewName,
    [In] WdOrganizerObject Object);

  [DispId(321)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void AddAddress([MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR), In] ref Array TagID, [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR), In] ref Array Value);

  [DispId(322)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string GetAddress(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddressProperties,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UseAutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DisplaySelectDialog,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SelectDialog,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CheckNamesDialog,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RecentAddressesChoice,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UpdateRecentAddresses);

  [DispId(323)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool CheckGrammar([MarshalAs(UnmanagedType.BStr), In] string String);

  [DispId(324)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool CheckSpelling(
    [MarshalAs(UnmanagedType.BStr), In] string Word,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreUppercase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MainDictionary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary10);

  [DispId(326)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ResetIgnoreAll();

  [DispId(327)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern SpellingSuggestions GetSpellingSuggestions(
    [MarshalAs(UnmanagedType.BStr), In] string Word,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreUppercase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MainDictionary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SuggestionMode,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary10);

  [DispId(328)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void GoBack();

  [DispId(329)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Help([MarshalAs(UnmanagedType.Struct), In] ref object HelpType);

  [DispId(330)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void AutomaticChange();

  [DispId(331)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ShowMe();

  [DispId(332)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void HelpTool();

  [DispId(345)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Window NewWindow();

  [DispId(346)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ListCommands([In] bool ListAllCommands);

  [DispId(349)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ShowClipboard();

  [DispId(350)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void OnTime([MarshalAs(UnmanagedType.Struct), In] ref object When, [MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Tolerance);

  [DispId(351)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void NextLetter();

  [DispId(353)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern short MountVolume(
    [MarshalAs(UnmanagedType.BStr), In] string Zone,
    [MarshalAs(UnmanagedType.BStr), In] string Server,
    [MarshalAs(UnmanagedType.BStr), In] string Volume,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object User,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UserPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object VolumePassword);

  [DispId(354)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string CleanString([MarshalAs(UnmanagedType.BStr), In] string String);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(356)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SendFax();

  [DispId(357)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ChangeFileOpenDirectory([MarshalAs(UnmanagedType.BStr), In] string Path);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(358)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RunOld([MarshalAs(UnmanagedType.BStr), In] string MacroName);

  [DispId(359)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void GoForward();

  [DispId(360)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Move([In] int Left, [In] int Top);

  [DispId(361)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Resize([In] int Width, [In] int Height);

  [DispId(370)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern float InchesToPoints([In] float Inches);

  [DispId(371)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern float CentimetersToPoints([In] float Centimeters);

  [DispId(372)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern float MillimetersToPoints([In] float Millimeters);

  [DispId(373)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern float PicasToPoints([In] float Picas);

  [DispId(374)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern float LinesToPoints([In] float Lines);

  [DispId(380)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern float PointsToInches([In] float Points);

  [DispId(381)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern float PointsToCentimeters([In] float Points);

  [DispId(382)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern float PointsToMillimeters([In] float Points);

  [DispId(383)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern float PointsToPicas([In] float Points);

  [DispId(384)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern float PointsToLines([In] float Points);

  [DispId(385)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Activate();

  [DispId(387)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern float PointsToPixels([In] float Points, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object fVertical);

  [DispId(388)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern float PixelsToPoints([In] float Pixels, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object fVertical);

  [DispId(400)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void KeyboardLatin();

  [DispId(401)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void KeyboardBidi();

  [DispId(402)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ToggleKeyboard();

  [DispId(446)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int Keyboard([In] int LangId = 0);

  [DispId(404)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string ProductCode();

  [DispId(405)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Microsoft.Office.Interop.Word.DefaultWebOptions DefaultWebOptions();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(407)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DiscussionSupport([MarshalAs(UnmanagedType.Struct), In] ref object Range, [MarshalAs(UnmanagedType.Struct), In] ref object cid, [MarshalAs(UnmanagedType.Struct), In] ref object piCSE);

  [DispId(414)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetDefaultTheme([MarshalAs(UnmanagedType.BStr), In] string Name, [In] WdDocumentMedium DocumentType);

  [DispId(416)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string GetDefaultTheme([In] WdDocumentMedium DocumentType);

  [DispId(389)]
  public virtual extern EmailOptions EmailOptions { [DispId(389), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(391)]
  public virtual extern MsoLanguageID Language { [DispId(391), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(111)]
  public virtual extern COMAddIns COMAddIns { [DispId(111), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(112 /*0x70*/)]
  public virtual extern bool CheckLanguage { [DispId(112 /*0x70*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(112 /*0x70*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(403)]
  public virtual extern LanguageSettings LanguageSettings { [DispId(403), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(406)]
  public virtual extern bool Dummy1 { [DispId(406), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(409)]
  public virtual extern AnswerWizard AnswerWizard { [DispId(409), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(447)]
  public virtual extern MsoFeatureInstall FeatureInstall { [DispId(447), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(447), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(444)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PrintOut2000(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Background,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Append,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OutputFileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Item,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Pages,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PageType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ActivePrinterMacGX,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ManualDuplexPrint,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperWidth,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperHeight);

  [DispId(445)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object Run(
    [MarshalAs(UnmanagedType.BStr), In] string MacroName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object varg30);

  [DispId(448)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Background,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Append,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OutputFileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Item,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Pages,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PageType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ActivePrinterMacGX,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ManualDuplexPrint,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperWidth,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperHeight);

  [DispId(449)]
  public virtual extern MsoAutomationSecurity AutomationSecurity { [DispId(449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(450)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern FileDialog get_FileDialog([In] MsoFileDialogType FileDialogType);

  [DispId(451)]
  public virtual extern string EmailTemplate { [DispId(451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(452)]
  public virtual extern bool ShowWindowsInTaskbar { [DispId(452), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(452), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(454)]
  public virtual extern NewFile NewDocument { [DispId(454), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(455)]
  public virtual extern bool ShowStartupDialog { [DispId(455), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(455), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(456)]
  public virtual extern AutoCorrect AutoCorrectEmail { [DispId(456), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(457)]
  public virtual extern TaskPanes TaskPanes { [DispId(457), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(459)]
  public virtual extern bool DefaultLegalBlackline { [DispId(459), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(459), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(458)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool Dummy2();

  [DispId(460)]
  public virtual extern SmartTagRecognizers SmartTagRecognizers { [DispId(460), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(461)]
  public virtual extern SmartTagTypes SmartTagTypes { [DispId(461), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(463)]
  public virtual extern XMLNamespaces XMLNamespaces { [DispId(463), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(464)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PutFocusInMailHeader();

  [DispId(465)]
  public virtual extern bool ArbitraryXMLSupportAvailable { [DispId(465), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(466)]
  public virtual extern string BuildFull { [TypeLibFunc(64 /*0x40*/), DispId(466), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(467)]
  public virtual extern string BuildFeatureCrew { [TypeLibFunc(64 /*0x40*/), DispId(467), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(469)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void LoadMasterList([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [DispId(470)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Document CompareDocuments(
    [MarshalAs(UnmanagedType.Interface), In] Document OriginalDocument,
    [MarshalAs(UnmanagedType.Interface), In] Document RevisedDocument,
    [In] WdCompareDestination Destination = WdCompareDestination.wdCompareDestinationNew,
    [In] WdGranularity Granularity = WdGranularity.wdGranularityWordLevel,
    [In] bool CompareFormatting = true,
    [In] bool CompareCaseChanges = true,
    [In] bool CompareWhitespace = true,
    [In] bool CompareTables = true,
    [In] bool CompareHeaders = true,
    [In] bool CompareFootnotes = true,
    [In] bool CompareTextboxes = true,
    [In] bool CompareFields = true,
    [In] bool CompareComments = true,
    [In] bool CompareMoves = true,
    [MarshalAs(UnmanagedType.BStr), In] string RevisedAuthor = "",
    [In] bool IgnoreAllComparisonWarnings = false);

  [DispId(471)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Document MergeDocuments(
    [MarshalAs(UnmanagedType.Interface), In] Document OriginalDocument,
    [MarshalAs(UnmanagedType.Interface), In] Document RevisedDocument,
    [In] WdCompareDestination Destination = WdCompareDestination.wdCompareDestinationNew,
    [In] WdGranularity Granularity = WdGranularity.wdGranularityWordLevel,
    [In] bool CompareFormatting = true,
    [In] bool CompareCaseChanges = true,
    [In] bool CompareWhitespace = true,
    [In] bool CompareTables = true,
    [In] bool CompareHeaders = true,
    [In] bool CompareFootnotes = true,
    [In] bool CompareTextboxes = true,
    [In] bool CompareFields = true,
    [In] bool CompareComments = true,
    [In] bool CompareMoves = true,
    [MarshalAs(UnmanagedType.BStr), In] string OriginalAuthor = "",
    [MarshalAs(UnmanagedType.BStr), In] string RevisedAuthor = "",
    [In] WdMergeFormatFrom FormatFrom = WdMergeFormatFrom.wdMergeFormatFromPrompt);

  [DispId(472)]
  public virtual extern Bibliography Bibliography { [DispId(472), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(473)]
  public virtual extern bool ShowStylePreviews { [DispId(473), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(473), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(474)]
  public virtual extern bool RestrictLinkedStyles { [DispId(474), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(474), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(475)]
  public virtual extern OMathAutoCorrect OMathAutoCorrect { [DispId(475), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(476)]
  public virtual extern bool DisplayDocumentInformationPanel { [DispId(476), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(476), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(477)]
  public virtual extern IAssistance Assistance { [DispId(477), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(478)]
  public virtual extern bool OpenAttachmentsInFullScreen { [DispId(478), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(478), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(479)]
  public virtual extern int ActiveEncryptionSession { [DispId(479), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(480)]
  public virtual extern bool DontResetInsertionPointProperties { [DispId(480), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(480), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Startup([In] ApplicationEvents4_StartupEventHandler obj0);

  public virtual extern event ApplicationEvents4_StartupEventHandler Startup;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Startup([In] ApplicationEvents4_StartupEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Quit([In] ApplicationEvents4_QuitEventHandler obj0);

  public virtual extern event ApplicationEvents4_QuitEventHandler ApplicationEvents4_Event_Quit;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Quit([In] ApplicationEvents4_QuitEventHandler obj0);

  public virtual extern event ApplicationEvents4_DocumentChangeEventHandler DocumentChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_DocumentChange([In] ApplicationEvents4_DocumentChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_DocumentChange(
    [In] ApplicationEvents4_DocumentChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_DocumentOpen([In] ApplicationEvents4_DocumentOpenEventHandler obj0);

  public virtual extern event ApplicationEvents4_DocumentOpenEventHandler DocumentOpen;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_DocumentOpen([In] ApplicationEvents4_DocumentOpenEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_DocumentBeforeClose(
    [In] ApplicationEvents4_DocumentBeforeCloseEventHandler obj0);

  public virtual extern event ApplicationEvents4_DocumentBeforeCloseEventHandler DocumentBeforeClose;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_DocumentBeforeClose(
    [In] ApplicationEvents4_DocumentBeforeCloseEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_DocumentBeforePrint(
    [In] ApplicationEvents4_DocumentBeforePrintEventHandler obj0);

  public virtual extern event ApplicationEvents4_DocumentBeforePrintEventHandler DocumentBeforePrint;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_DocumentBeforePrint(
    [In] ApplicationEvents4_DocumentBeforePrintEventHandler obj0);

  public virtual extern event ApplicationEvents4_DocumentBeforeSaveEventHandler DocumentBeforeSave;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_DocumentBeforeSave(
    [In] ApplicationEvents4_DocumentBeforeSaveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_DocumentBeforeSave(
    [In] ApplicationEvents4_DocumentBeforeSaveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_NewDocument([In] ApplicationEvents4_NewDocumentEventHandler obj0);

  public virtual extern event ApplicationEvents4_NewDocumentEventHandler ApplicationEvents4_Event_NewDocument;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_NewDocument([In] ApplicationEvents4_NewDocumentEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_WindowActivate([In] ApplicationEvents4_WindowActivateEventHandler obj0);

  public virtual extern event ApplicationEvents4_WindowActivateEventHandler WindowActivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_WindowActivate(
    [In] ApplicationEvents4_WindowActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_WindowDeactivate(
    [In] ApplicationEvents4_WindowDeactivateEventHandler obj0);

  public virtual extern event ApplicationEvents4_WindowDeactivateEventHandler WindowDeactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_WindowDeactivate(
    [In] ApplicationEvents4_WindowDeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_WindowSelectionChange(
    [In] ApplicationEvents4_WindowSelectionChangeEventHandler obj0);

  public virtual extern event ApplicationEvents4_WindowSelectionChangeEventHandler WindowSelectionChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_WindowSelectionChange(
    [In] ApplicationEvents4_WindowSelectionChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_WindowBeforeRightClick(
    [In] ApplicationEvents4_WindowBeforeRightClickEventHandler obj0);

  public virtual extern event ApplicationEvents4_WindowBeforeRightClickEventHandler WindowBeforeRightClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_WindowBeforeRightClick(
    [In] ApplicationEvents4_WindowBeforeRightClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_WindowBeforeDoubleClick(
    [In] ApplicationEvents4_WindowBeforeDoubleClickEventHandler obj0);

  public virtual extern event ApplicationEvents4_WindowBeforeDoubleClickEventHandler WindowBeforeDoubleClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_WindowBeforeDoubleClick(
    [In] ApplicationEvents4_WindowBeforeDoubleClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_EPostagePropertyDialog(
    [In] ApplicationEvents4_EPostagePropertyDialogEventHandler obj0);

  public virtual extern event ApplicationEvents4_EPostagePropertyDialogEventHandler EPostagePropertyDialog;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_EPostagePropertyDialog(
    [In] ApplicationEvents4_EPostagePropertyDialogEventHandler obj0);

  public virtual extern event ApplicationEvents4_EPostageInsertEventHandler EPostageInsert;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_EPostageInsert([In] ApplicationEvents4_EPostageInsertEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_EPostageInsert(
    [In] ApplicationEvents4_EPostageInsertEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_MailMergeAfterMerge(
    [In] ApplicationEvents4_MailMergeAfterMergeEventHandler obj0);

  public virtual extern event ApplicationEvents4_MailMergeAfterMergeEventHandler MailMergeAfterMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_MailMergeAfterMerge(
    [In] ApplicationEvents4_MailMergeAfterMergeEventHandler obj0);

  public virtual extern event ApplicationEvents4_MailMergeAfterRecordMergeEventHandler MailMergeAfterRecordMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_MailMergeAfterRecordMerge(
    [In] ApplicationEvents4_MailMergeAfterRecordMergeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_MailMergeAfterRecordMerge(
    [In] ApplicationEvents4_MailMergeAfterRecordMergeEventHandler obj0);

  public virtual extern event ApplicationEvents4_MailMergeBeforeMergeEventHandler MailMergeBeforeMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_MailMergeBeforeMerge(
    [In] ApplicationEvents4_MailMergeBeforeMergeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_MailMergeBeforeMerge(
    [In] ApplicationEvents4_MailMergeBeforeMergeEventHandler obj0);

  public virtual extern event ApplicationEvents4_MailMergeBeforeRecordMergeEventHandler MailMergeBeforeRecordMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_MailMergeBeforeRecordMerge(
    [In] ApplicationEvents4_MailMergeBeforeRecordMergeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_MailMergeBeforeRecordMerge(
    [In] ApplicationEvents4_MailMergeBeforeRecordMergeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_MailMergeDataSourceLoad(
    [In] ApplicationEvents4_MailMergeDataSourceLoadEventHandler obj0);

  public virtual extern event ApplicationEvents4_MailMergeDataSourceLoadEventHandler MailMergeDataSourceLoad;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_MailMergeDataSourceLoad(
    [In] ApplicationEvents4_MailMergeDataSourceLoadEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_MailMergeDataSourceValidate(
    [In] ApplicationEvents4_MailMergeDataSourceValidateEventHandler obj0);

  public virtual extern event ApplicationEvents4_MailMergeDataSourceValidateEventHandler MailMergeDataSourceValidate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_MailMergeDataSourceValidate(
    [In] ApplicationEvents4_MailMergeDataSourceValidateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_MailMergeWizardSendToCustom(
    [In] ApplicationEvents4_MailMergeWizardSendToCustomEventHandler obj0);

  public virtual extern event ApplicationEvents4_MailMergeWizardSendToCustomEventHandler MailMergeWizardSendToCustom;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_MailMergeWizardSendToCustom(
    [In] ApplicationEvents4_MailMergeWizardSendToCustomEventHandler obj0);

  public virtual extern event ApplicationEvents4_MailMergeWizardStateChangeEventHandler MailMergeWizardStateChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_MailMergeWizardStateChange(
    [In] ApplicationEvents4_MailMergeWizardStateChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_MailMergeWizardStateChange(
    [In] ApplicationEvents4_MailMergeWizardStateChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_WindowSize([In] ApplicationEvents4_WindowSizeEventHandler obj0);

  public virtual extern event ApplicationEvents4_WindowSizeEventHandler WindowSize;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_WindowSize([In] ApplicationEvents4_WindowSizeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_XMLSelectionChange(
    [In] ApplicationEvents4_XMLSelectionChangeEventHandler obj0);

  public virtual extern event ApplicationEvents4_XMLSelectionChangeEventHandler XMLSelectionChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_XMLSelectionChange(
    [In] ApplicationEvents4_XMLSelectionChangeEventHandler obj0);

  public virtual extern event ApplicationEvents4_XMLValidationErrorEventHandler XMLValidationError;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_XMLValidationError(
    [In] ApplicationEvents4_XMLValidationErrorEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_XMLValidationError(
    [In] ApplicationEvents4_XMLValidationErrorEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_DocumentSync([In] ApplicationEvents4_DocumentSyncEventHandler obj0);

  public virtual extern event ApplicationEvents4_DocumentSyncEventHandler DocumentSync;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_DocumentSync([In] ApplicationEvents4_DocumentSyncEventHandler obj0);

  public virtual extern event ApplicationEvents4_EPostageInsertExEventHandler EPostageInsertEx;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_EPostageInsertEx(
    [In] ApplicationEvents4_EPostageInsertExEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_EPostageInsertEx(
    [In] ApplicationEvents4_EPostageInsertExEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_MailMergeDataSourceValidate2(
    [In] ApplicationEvents4_MailMergeDataSourceValidate2EventHandler obj0);

  public virtual extern event ApplicationEvents4_MailMergeDataSourceValidate2EventHandler MailMergeDataSourceValidate2;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_MailMergeDataSourceValidate2(
    [In] ApplicationEvents4_MailMergeDataSourceValidate2EventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_add_Startup(
    [In] ApplicationEvents2_StartupEventHandler obj0);

  public virtual extern event ApplicationEvents2_StartupEventHandler ApplicationEvents2_Event_Startup;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_remove_Startup(
    [In] ApplicationEvents2_StartupEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_add_Quit(
    [In] ApplicationEvents2_QuitEventHandler obj0);

  public virtual extern event ApplicationEvents2_QuitEventHandler ApplicationEvents2_Event_Quit;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_remove_Quit(
    [In] ApplicationEvents2_QuitEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_add_DocumentChange(
    [In] ApplicationEvents2_DocumentChangeEventHandler obj0);

  public virtual extern event ApplicationEvents2_DocumentChangeEventHandler ApplicationEvents2_Event_DocumentChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_remove_DocumentChange(
    [In] ApplicationEvents2_DocumentChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_add_DocumentOpen(
    [In] ApplicationEvents2_DocumentOpenEventHandler obj0);

  public virtual extern event ApplicationEvents2_DocumentOpenEventHandler ApplicationEvents2_Event_DocumentOpen;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_remove_DocumentOpen(
    [In] ApplicationEvents2_DocumentOpenEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_add_DocumentBeforeClose(
    [In] ApplicationEvents2_DocumentBeforeCloseEventHandler obj0);

  public virtual extern event ApplicationEvents2_DocumentBeforeCloseEventHandler ApplicationEvents2_Event_DocumentBeforeClose;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_remove_DocumentBeforeClose(
    [In] ApplicationEvents2_DocumentBeforeCloseEventHandler obj0);

  public virtual extern event ApplicationEvents2_DocumentBeforePrintEventHandler ApplicationEvents2_Event_DocumentBeforePrint;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_add_DocumentBeforePrint(
    [In] ApplicationEvents2_DocumentBeforePrintEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_remove_DocumentBeforePrint(
    [In] ApplicationEvents2_DocumentBeforePrintEventHandler obj0);

  public virtual extern event ApplicationEvents2_DocumentBeforeSaveEventHandler ApplicationEvents2_Event_DocumentBeforeSave;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_add_DocumentBeforeSave(
    [In] ApplicationEvents2_DocumentBeforeSaveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_remove_DocumentBeforeSave(
    [In] ApplicationEvents2_DocumentBeforeSaveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_add_NewDocument(
    [In] ApplicationEvents2_NewDocumentEventHandler obj0);

  public virtual extern event ApplicationEvents2_NewDocumentEventHandler ApplicationEvents2_Event_NewDocument;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_remove_NewDocument(
    [In] ApplicationEvents2_NewDocumentEventHandler obj0);

  public virtual extern event ApplicationEvents2_WindowActivateEventHandler ApplicationEvents2_Event_WindowActivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_add_WindowActivate(
    [In] ApplicationEvents2_WindowActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_remove_WindowActivate(
    [In] ApplicationEvents2_WindowActivateEventHandler obj0);

  public virtual extern event ApplicationEvents2_WindowDeactivateEventHandler ApplicationEvents2_Event_WindowDeactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_add_WindowDeactivate(
    [In] ApplicationEvents2_WindowDeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_remove_WindowDeactivate(
    [In] ApplicationEvents2_WindowDeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_add_WindowSelectionChange(
    [In] ApplicationEvents2_WindowSelectionChangeEventHandler obj0);

  public virtual extern event ApplicationEvents2_WindowSelectionChangeEventHandler ApplicationEvents2_Event_WindowSelectionChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_remove_WindowSelectionChange(
    [In] ApplicationEvents2_WindowSelectionChangeEventHandler obj0);

  public virtual extern event ApplicationEvents2_WindowBeforeRightClickEventHandler ApplicationEvents2_Event_WindowBeforeRightClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_add_WindowBeforeRightClick(
    [In] ApplicationEvents2_WindowBeforeRightClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_remove_WindowBeforeRightClick(
    [In] ApplicationEvents2_WindowBeforeRightClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_add_WindowBeforeDoubleClick(
    [In] ApplicationEvents2_WindowBeforeDoubleClickEventHandler obj0);

  public virtual extern event ApplicationEvents2_WindowBeforeDoubleClickEventHandler ApplicationEvents2_Event_WindowBeforeDoubleClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents2_Event_remove_WindowBeforeDoubleClick(
    [In] ApplicationEvents2_WindowBeforeDoubleClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_Startup(
    [In] ApplicationEvents3_StartupEventHandler obj0);

  public virtual extern event ApplicationEvents3_StartupEventHandler ApplicationEvents3_Event_Startup;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_Startup(
    [In] ApplicationEvents3_StartupEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_Quit(
    [In] ApplicationEvents3_QuitEventHandler obj0);

  public virtual extern event ApplicationEvents3_QuitEventHandler ApplicationEvents3_Event_Quit;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_Quit(
    [In] ApplicationEvents3_QuitEventHandler obj0);

  public virtual extern event ApplicationEvents3_DocumentChangeEventHandler ApplicationEvents3_Event_DocumentChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_DocumentChange(
    [In] ApplicationEvents3_DocumentChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_DocumentChange(
    [In] ApplicationEvents3_DocumentChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_DocumentOpen(
    [In] ApplicationEvents3_DocumentOpenEventHandler obj0);

  public virtual extern event ApplicationEvents3_DocumentOpenEventHandler ApplicationEvents3_Event_DocumentOpen;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_DocumentOpen(
    [In] ApplicationEvents3_DocumentOpenEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_DocumentBeforeClose(
    [In] ApplicationEvents3_DocumentBeforeCloseEventHandler obj0);

  public virtual extern event ApplicationEvents3_DocumentBeforeCloseEventHandler ApplicationEvents3_Event_DocumentBeforeClose;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_DocumentBeforeClose(
    [In] ApplicationEvents3_DocumentBeforeCloseEventHandler obj0);

  public virtual extern event ApplicationEvents3_DocumentBeforePrintEventHandler ApplicationEvents3_Event_DocumentBeforePrint;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_DocumentBeforePrint(
    [In] ApplicationEvents3_DocumentBeforePrintEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_DocumentBeforePrint(
    [In] ApplicationEvents3_DocumentBeforePrintEventHandler obj0);

  public virtual extern event ApplicationEvents3_DocumentBeforeSaveEventHandler ApplicationEvents3_Event_DocumentBeforeSave;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_DocumentBeforeSave(
    [In] ApplicationEvents3_DocumentBeforeSaveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_DocumentBeforeSave(
    [In] ApplicationEvents3_DocumentBeforeSaveEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_NewDocument(
    [In] ApplicationEvents3_NewDocumentEventHandler obj0);

  public virtual extern event ApplicationEvents3_NewDocumentEventHandler ApplicationEvents3_Event_NewDocument;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_NewDocument(
    [In] ApplicationEvents3_NewDocumentEventHandler obj0);

  public virtual extern event ApplicationEvents3_WindowActivateEventHandler ApplicationEvents3_Event_WindowActivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_WindowActivate(
    [In] ApplicationEvents3_WindowActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_WindowActivate(
    [In] ApplicationEvents3_WindowActivateEventHandler obj0);

  public virtual extern event ApplicationEvents3_WindowDeactivateEventHandler ApplicationEvents3_Event_WindowDeactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_WindowDeactivate(
    [In] ApplicationEvents3_WindowDeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_WindowDeactivate(
    [In] ApplicationEvents3_WindowDeactivateEventHandler obj0);

  public virtual extern event ApplicationEvents3_WindowSelectionChangeEventHandler ApplicationEvents3_Event_WindowSelectionChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_WindowSelectionChange(
    [In] ApplicationEvents3_WindowSelectionChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_WindowSelectionChange(
    [In] ApplicationEvents3_WindowSelectionChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_WindowBeforeRightClick(
    [In] ApplicationEvents3_WindowBeforeRightClickEventHandler obj0);

  public virtual extern event ApplicationEvents3_WindowBeforeRightClickEventHandler ApplicationEvents3_Event_WindowBeforeRightClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_WindowBeforeRightClick(
    [In] ApplicationEvents3_WindowBeforeRightClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_WindowBeforeDoubleClick(
    [In] ApplicationEvents3_WindowBeforeDoubleClickEventHandler obj0);

  public virtual extern event ApplicationEvents3_WindowBeforeDoubleClickEventHandler ApplicationEvents3_Event_WindowBeforeDoubleClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_WindowBeforeDoubleClick(
    [In] ApplicationEvents3_WindowBeforeDoubleClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_EPostagePropertyDialog(
    [In] ApplicationEvents3_EPostagePropertyDialogEventHandler obj0);

  public virtual extern event ApplicationEvents3_EPostagePropertyDialogEventHandler ApplicationEvents3_Event_EPostagePropertyDialog;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_EPostagePropertyDialog(
    [In] ApplicationEvents3_EPostagePropertyDialogEventHandler obj0);

  public virtual extern event ApplicationEvents3_EPostageInsertEventHandler ApplicationEvents3_Event_EPostageInsert;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_EPostageInsert(
    [In] ApplicationEvents3_EPostageInsertEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_EPostageInsert(
    [In] ApplicationEvents3_EPostageInsertEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_MailMergeAfterMerge(
    [In] ApplicationEvents3_MailMergeAfterMergeEventHandler obj0);

  public virtual extern event ApplicationEvents3_MailMergeAfterMergeEventHandler ApplicationEvents3_Event_MailMergeAfterMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_MailMergeAfterMerge(
    [In] ApplicationEvents3_MailMergeAfterMergeEventHandler obj0);

  public virtual extern event ApplicationEvents3_MailMergeAfterRecordMergeEventHandler ApplicationEvents3_Event_MailMergeAfterRecordMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_MailMergeAfterRecordMerge(
    [In] ApplicationEvents3_MailMergeAfterRecordMergeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_MailMergeAfterRecordMerge(
    [In] ApplicationEvents3_MailMergeAfterRecordMergeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_MailMergeBeforeMerge(
    [In] ApplicationEvents3_MailMergeBeforeMergeEventHandler obj0);

  public virtual extern event ApplicationEvents3_MailMergeBeforeMergeEventHandler ApplicationEvents3_Event_MailMergeBeforeMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_MailMergeBeforeMerge(
    [In] ApplicationEvents3_MailMergeBeforeMergeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_MailMergeBeforeRecordMerge(
    [In] ApplicationEvents3_MailMergeBeforeRecordMergeEventHandler obj0);

  public virtual extern event ApplicationEvents3_MailMergeBeforeRecordMergeEventHandler ApplicationEvents3_Event_MailMergeBeforeRecordMerge;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_MailMergeBeforeRecordMerge(
    [In] ApplicationEvents3_MailMergeBeforeRecordMergeEventHandler obj0);

  public virtual extern event ApplicationEvents3_MailMergeDataSourceLoadEventHandler ApplicationEvents3_Event_MailMergeDataSourceLoad;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_MailMergeDataSourceLoad(
    [In] ApplicationEvents3_MailMergeDataSourceLoadEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_MailMergeDataSourceLoad(
    [In] ApplicationEvents3_MailMergeDataSourceLoadEventHandler obj0);

  public virtual extern event ApplicationEvents3_MailMergeDataSourceValidateEventHandler ApplicationEvents3_Event_MailMergeDataSourceValidate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_MailMergeDataSourceValidate(
    [In] ApplicationEvents3_MailMergeDataSourceValidateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_MailMergeDataSourceValidate(
    [In] ApplicationEvents3_MailMergeDataSourceValidateEventHandler obj0);

  public virtual extern event ApplicationEvents3_MailMergeWizardSendToCustomEventHandler ApplicationEvents3_Event_MailMergeWizardSendToCustom;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_MailMergeWizardSendToCustom(
    [In] ApplicationEvents3_MailMergeWizardSendToCustomEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_MailMergeWizardSendToCustom(
    [In] ApplicationEvents3_MailMergeWizardSendToCustomEventHandler obj0);

  public virtual extern event ApplicationEvents3_MailMergeWizardStateChangeEventHandler ApplicationEvents3_Event_MailMergeWizardStateChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_MailMergeWizardStateChange(
    [In] ApplicationEvents3_MailMergeWizardStateChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_MailMergeWizardStateChange(
    [In] ApplicationEvents3_MailMergeWizardStateChangeEventHandler obj0);

  public virtual extern event ApplicationEvents3_WindowSizeEventHandler ApplicationEvents3_Event_WindowSize;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_add_WindowSize(
    [In] ApplicationEvents3_WindowSizeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplicationEvents3_Event_remove_WindowSize(
    [In] ApplicationEvents3_WindowSizeEventHandler obj0);
}
