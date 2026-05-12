// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word._Application
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

[TypeLibType(4304)]
[Guid("00020970-0000-0000-C000-000000000046")]
[DefaultMember("Name")]
[ComImport]
public interface _Application
{
  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(0)]
  string Name { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(6)]
  Documents Documents { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2)]
  Windows Windows { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(3)]
  Document ActiveDocument { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(4)]
  Window ActiveWindow { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(5)]
  Selection Selection { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1)]
  object WordBasic { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(7)]
  RecentFiles RecentFiles { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(8)]
  Template NormalTemplate { [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(9)]
  Microsoft.Office.Interop.Word.System System { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(10)]
  AutoCorrect AutoCorrect { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(11)]
  FontNames FontNames { [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(12)]
  FontNames LandscapeFontNames { [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(13)]
  FontNames PortraitFontNames { [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(14)]
  Languages Languages { [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(15)]
  Assistant Assistant { [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(16 /*0x10*/)]
  Browser Browser { [DispId(16 /*0x10*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(17)]
  FileConverters FileConverters { [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(18)]
  MailingLabel MailingLabel { [DispId(18), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(19)]
  Dialogs Dialogs { [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(20)]
  CaptionLabels CaptionLabels { [DispId(20), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(21)]
  AutoCaptions AutoCaptions { [DispId(21), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(22)]
  AddIns AddIns { [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(23)]
  bool Visible { [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(24)]
  string Version { [DispId(24), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(26)]
  bool ScreenUpdating { [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(27)]
  bool PrintPreview { [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(28)]
  Tasks Tasks { [DispId(28), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(29)]
  bool DisplayStatusBar { [TypeLibFunc(64 /*0x40*/), DispId(29), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), DispId(29), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(30)]
  bool SpecialMode { [DispId(30), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(33)]
  int UsableWidth { [DispId(33), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(34)]
  int UsableHeight { [DispId(34), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(36)]
  bool MathCoprocessorAvailable { [DispId(36), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(37)]
  bool MouseAvailable { [DispId(37), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(46)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object get_International([In] WdInternationalIndex Index);

  [DispId(47)]
  string Build { [DispId(47), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(48 /*0x30*/)]
  bool CapsLock { [DispId(48 /*0x30*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(49)]
  bool NumLock { [DispId(49), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(52)]
  string UserName { [DispId(52), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(52), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(53)]
  string UserInitials { [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(54)]
  string UserAddress { [DispId(54), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(54), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(55)]
  object MacroContainer { [DispId(55), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(56)]
  bool DisplayRecentFiles { [DispId(56), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(56), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(57)]
  CommandBars CommandBars { [DispId(57), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(59)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  SynonymInfo get_SynonymInfo([MarshalAs(UnmanagedType.BStr), In] string Word, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LanguageID);

  [DispId(61)]
  VBE VBE { [DispId(61), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(64 /*0x40*/)]
  string DefaultSaveFormat { [DispId(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(65)]
  ListGalleries ListGalleries { [DispId(65), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(66)]
  string ActivePrinter { [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(67)]
  Templates Templates { [DispId(67), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(68)]
  object CustomizationContext { [DispId(68), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; [DispId(68), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IDispatch), In] set; }

  [DispId(69)]
  KeyBindings KeyBindings { [DispId(69), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(70)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  KeysBoundTo get_KeysBoundTo(
    [In] WdKeyCategory KeyCategory,
    [MarshalAs(UnmanagedType.BStr), In] string Command,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CommandParameter);

  [DispId(71)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  KeyBinding get_FindKey([In] int KeyCode, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object KeyCode2);

  [DispId(80 /*0x50*/)]
  string Caption { [DispId(80 /*0x50*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(80 /*0x50*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(81)]
  string Path { [DispId(81), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(82)]
  bool DisplayScrollBars { [DispId(82), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(82), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(83)]
  string StartupPath { [DispId(83), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(83), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(85)]
  int BackgroundSavingStatus { [DispId(85), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(86)]
  int BackgroundPrintingStatus { [DispId(86), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(87)]
  int Left { [DispId(87), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(87), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(88)]
  int Top { [DispId(88), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(88), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(89)]
  int Width { [DispId(89), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(89), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(90)]
  int Height { [DispId(90), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(90), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(91)]
  WdWindowState WindowState { [DispId(91), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(91), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(92)]
  bool DisplayAutoCompleteTips { [DispId(92), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(92), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(93)]
  Options Options { [DispId(93), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(94)]
  WdAlertLevel DisplayAlerts { [DispId(94), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(94), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(95)]
  Dictionaries CustomDictionaries { [DispId(95), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(96 /*0x60*/)]
  string PathSeparator { [DispId(96 /*0x60*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(97)]
  string StatusBar { [DispId(97), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(98)]
  bool MAPIAvailable { [DispId(98), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(99)]
  bool DisplayScreenTips { [DispId(99), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(99), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(100)]
  WdEnableCancelKey EnableCancelKey { [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(101)]
  bool UserControl { [DispId(101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(103)]
  FileSearch FileSearch { [DispId(103), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(104)]
  WdMailSystem MailSystem { [DispId(104), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(105)]
  string DefaultTableSeparator { [DispId(105), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(105), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(106)]
  bool ShowVisualBasicEditor { [DispId(106), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(106), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(108)]
  string BrowseExtraFileTypes { [DispId(108), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(108), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(109)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool get_IsObjectValid([MarshalAs(UnmanagedType.IDispatch), In] object Object);

  [DispId(110)]
  HangulHanjaConversionDictionaries HangulHanjaDictionaries { [DispId(110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(348)]
  MailMessage MailMessage { [DispId(348), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(386)]
  bool FocusInMailHeader { [DispId(386), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Quit([MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OriginalFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RouteDocument);

  [DispId(301)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ScreenRefresh();

  [DispId(302)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOutOld(
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
  void LookupNameProperties([MarshalAs(UnmanagedType.BStr), In] string Name);

  [DispId(304)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SubstituteFont([MarshalAs(UnmanagedType.BStr), In] string UnavailableFont, [MarshalAs(UnmanagedType.BStr), In] string SubstituteFont);

  [DispId(305)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Repeat([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Times);

  [DispId(310)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DDEExecute([In] int Channel, [MarshalAs(UnmanagedType.BStr), In] string Command);

  [DispId(311)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int DDEInitiate([MarshalAs(UnmanagedType.BStr), In] string App, [MarshalAs(UnmanagedType.BStr), In] string Topic);

  [DispId(312)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DDEPoke([In] int Channel, [MarshalAs(UnmanagedType.BStr), In] string Item, [MarshalAs(UnmanagedType.BStr), In] string Data);

  [DispId(313)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string DDERequest([In] int Channel, [MarshalAs(UnmanagedType.BStr), In] string Item);

  [DispId(314)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DDETerminate([In] int Channel);

  [DispId(315)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DDETerminateAll();

  [DispId(316)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int BuildKeyCode([In] WdKey Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Arg4);

  [DispId(317)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string KeyString([In] int KeyCode, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object KeyCode2);

  [DispId(318)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OrganizerCopy([MarshalAs(UnmanagedType.BStr), In] string Source, [MarshalAs(UnmanagedType.BStr), In] string Destination, [MarshalAs(UnmanagedType.BStr), In] string Name, [In] WdOrganizerObject Object);

  [DispId(319)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OrganizerDelete([MarshalAs(UnmanagedType.BStr), In] string Source, [MarshalAs(UnmanagedType.BStr), In] string Name, [In] WdOrganizerObject Object);

  [DispId(320)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OrganizerRename([MarshalAs(UnmanagedType.BStr), In] string Source, [MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.BStr), In] string NewName, [In] WdOrganizerObject Object);

  [DispId(321)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddAddress([MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR), In] ref Array TagID, [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR), In] ref Array Value);

  [DispId(322)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetAddress(
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
  bool CheckGrammar([MarshalAs(UnmanagedType.BStr), In] string String);

  [DispId(324)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool CheckSpelling(
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
  void ResetIgnoreAll();

  [DispId(327)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  SpellingSuggestions GetSpellingSuggestions(
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
  void GoBack();

  [DispId(329)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Help([MarshalAs(UnmanagedType.Struct), In] ref object HelpType);

  [DispId(330)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AutomaticChange();

  [DispId(331)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ShowMe();

  [DispId(332)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HelpTool();

  [DispId(345)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Window NewWindow();

  [DispId(346)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ListCommands([In] bool ListAllCommands);

  [DispId(349)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ShowClipboard();

  [DispId(350)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OnTime([MarshalAs(UnmanagedType.Struct), In] ref object When, [MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Tolerance);

  [DispId(351)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NextLetter();

  [DispId(353)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  short MountVolume(
    [MarshalAs(UnmanagedType.BStr), In] string Zone,
    [MarshalAs(UnmanagedType.BStr), In] string Server,
    [MarshalAs(UnmanagedType.BStr), In] string Volume,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object User,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UserPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object VolumePassword);

  [DispId(354)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string CleanString([MarshalAs(UnmanagedType.BStr), In] string String);

  [DispId(356)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SendFax();

  [DispId(357)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ChangeFileOpenDirectory([MarshalAs(UnmanagedType.BStr), In] string Path);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(358)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RunOld([MarshalAs(UnmanagedType.BStr), In] string MacroName);

  [DispId(359)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void GoForward();

  [DispId(360)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Move([In] int Left, [In] int Top);

  [DispId(361)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Resize([In] int Width, [In] int Height);

  [DispId(370)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float InchesToPoints([In] float Inches);

  [DispId(371)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float CentimetersToPoints([In] float Centimeters);

  [DispId(372)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float MillimetersToPoints([In] float Millimeters);

  [DispId(373)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float PicasToPoints([In] float Picas);

  [DispId(374)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float LinesToPoints([In] float Lines);

  [DispId(380)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float PointsToInches([In] float Points);

  [DispId(381)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float PointsToCentimeters([In] float Points);

  [DispId(382)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float PointsToMillimeters([In] float Points);

  [DispId(383)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float PointsToPicas([In] float Points);

  [DispId(384)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float PointsToLines([In] float Points);

  [DispId(385)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Activate();

  [DispId(387)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float PointsToPixels([In] float Points, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object fVertical);

  [DispId(388)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float PixelsToPoints([In] float Pixels, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object fVertical);

  [DispId(400)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void KeyboardLatin();

  [DispId(401)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void KeyboardBidi();

  [DispId(402)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ToggleKeyboard();

  [DispId(446)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int Keyboard([In] int LangId = 0);

  [DispId(404)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ProductCode();

  [DispId(405)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Microsoft.Office.Interop.Word.DefaultWebOptions DefaultWebOptions();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(407)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DiscussionSupport([MarshalAs(UnmanagedType.Struct), In] ref object Range, [MarshalAs(UnmanagedType.Struct), In] ref object cid, [MarshalAs(UnmanagedType.Struct), In] ref object piCSE);

  [DispId(414)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetDefaultTheme([MarshalAs(UnmanagedType.BStr), In] string Name, [In] WdDocumentMedium DocumentType);

  [DispId(416)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetDefaultTheme([In] WdDocumentMedium DocumentType);

  [DispId(389)]
  EmailOptions EmailOptions { [DispId(389), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(391)]
  MsoLanguageID Language { [DispId(391), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(111)]
  COMAddIns COMAddIns { [DispId(111), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(112 /*0x70*/)]
  bool CheckLanguage { [DispId(112 /*0x70*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(112 /*0x70*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(403)]
  LanguageSettings LanguageSettings { [DispId(403), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(406)]
  bool Dummy1 { [TypeLibFunc(64 /*0x40*/), DispId(406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(409)]
  AnswerWizard AnswerWizard { [DispId(409), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(447)]
  MsoFeatureInstall FeatureInstall { [DispId(447), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(447), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(444)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOut2000(
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
  object Run(
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
  void PrintOut(
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
  MsoAutomationSecurity AutomationSecurity { [DispId(449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(450)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  FileDialog get_FileDialog([In] MsoFileDialogType FileDialogType);

  [DispId(451)]
  string EmailTemplate { [DispId(451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(452)]
  bool ShowWindowsInTaskbar { [DispId(452), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(452), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(454)]
  NewFile NewDocument { [DispId(454), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(455)]
  bool ShowStartupDialog { [DispId(455), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(455), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(456)]
  AutoCorrect AutoCorrectEmail { [DispId(456), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(457)]
  TaskPanes TaskPanes { [DispId(457), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(459)]
  bool DefaultLegalBlackline { [DispId(459), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(459), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(458)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Dummy2();

  [DispId(460)]
  SmartTagRecognizers SmartTagRecognizers { [DispId(460), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(461)]
  SmartTagTypes SmartTagTypes { [DispId(461), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(463)]
  XMLNamespaces XMLNamespaces { [DispId(463), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(464)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PutFocusInMailHeader();

  [DispId(465)]
  bool ArbitraryXMLSupportAvailable { [DispId(465), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(466)]
  string BuildFull { [DispId(466), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(467)]
  string BuildFeatureCrew { [TypeLibFunc(64 /*0x40*/), DispId(467), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(469)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void LoadMasterList([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [DispId(470)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Document CompareDocuments(
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
  Document MergeDocuments(
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
  Bibliography Bibliography { [DispId(472), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(473)]
  bool ShowStylePreviews { [DispId(473), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(473), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(474)]
  bool RestrictLinkedStyles { [DispId(474), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(474), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(475)]
  OMathAutoCorrect OMathAutoCorrect { [DispId(475), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(476)]
  bool DisplayDocumentInformationPanel { [DispId(476), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(476), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(477)]
  IAssistance Assistance { [DispId(477), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(478)]
  bool OpenAttachmentsInFullScreen { [DispId(478), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(478), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(479)]
  int ActiveEncryptionSession { [DispId(479), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(480)]
  bool DontResetInsertionPointProperties { [DispId(480), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(480), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
}
