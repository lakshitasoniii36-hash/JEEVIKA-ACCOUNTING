// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word._Global
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using Microsoft.Office.Core;
using Microsoft.Vbe.Interop;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[DefaultMember("Name")]
[TypeLibType(4304)]
[Guid("000209B9-0000-0000-C000-000000000046")]
[ComImport]
public interface _Global
{
  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(0)]
  string Name { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1)]
  Documents Documents { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2)]
  Windows Windows { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(3)]
  Document ActiveDocument { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(4)]
  Window ActiveWindow { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(5)]
  Selection Selection { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(6)]
  object WordBasic { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(27)]
  bool PrintPreview { [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

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

  [DispId(17)]
  FileConverters FileConverters { [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(19)]
  Dialogs Dialogs { [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(20)]
  CaptionLabels CaptionLabels { [DispId(20), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(21)]
  AutoCaptions AutoCaptions { [DispId(21), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(22)]
  AddIns AddIns { [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(28)]
  Tasks Tasks { [DispId(28), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(55)]
  object MacroContainer { [DispId(55), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(57)]
  CommandBars CommandBars { [DispId(57), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(59)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  SynonymInfo get_SynonymInfo([MarshalAs(UnmanagedType.BStr), In] string Word, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LanguageID);

  [DispId(61)]
  VBE VBE { [DispId(61), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

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

  [DispId(93)]
  Options Options { [DispId(93), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(95)]
  Dictionaries CustomDictionaries { [DispId(95), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(97)]
  string StatusBar { [DispId(97), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(104)]
  bool ShowVisualBasicEditor { [DispId(104), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(104), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(109)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool get_IsObjectValid([MarshalAs(UnmanagedType.IDispatch), In] object Object);

  [DispId(110)]
  HangulHanjaConversionDictionaries HangulHanjaDictionaries { [DispId(110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

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

  [DispId(329)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Help([MarshalAs(UnmanagedType.Struct), In] ref object HelpType);

  [DispId(345)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Window NewWindow();

  [DispId(354)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string CleanString([MarshalAs(UnmanagedType.BStr), In] string String);

  [DispId(355)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ChangeFileOpenDirectory([MarshalAs(UnmanagedType.BStr), In] string Path);

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
  float PointsToPixels([In] float Points, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object fVertical);

  [DispId(386)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float PixelsToPoints([In] float Pixels, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object fVertical);

  [DispId(111)]
  LanguageSettings LanguageSettings { [DispId(111), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(112 /*0x70*/)]
  AnswerWizard AnswerWizard { [DispId(112 /*0x70*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(113)]
  AutoCorrect AutoCorrectEmail { [DispId(113), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
}
