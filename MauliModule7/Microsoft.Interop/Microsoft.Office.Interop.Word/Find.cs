// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.Find
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[TypeLibType(4288)]
[Guid("000209B0-0000-0000-C000-000000000046")]
[ComImport]
public interface Find
{
  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(10)]
  bool Forward { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(11)]
  Font Font { [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(12)]
  bool Found { [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(13)]
  bool MatchAllWordForms { [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(14)]
  bool MatchCase { [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(15)]
  bool MatchWildcards { [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(16 /*0x10*/)]
  bool MatchSoundsLike { [DispId(16 /*0x10*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(16 /*0x10*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(17)]
  bool MatchWholeWord { [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(40)]
  bool MatchFuzzy { [DispId(40), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(40), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(41)]
  bool MatchByte { [DispId(41), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(41), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(18)]
  ParagraphFormat ParagraphFormat { [DispId(18), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(18), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(19)]
  object Style { [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(22)]
  string Text { [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(23)]
  WdLanguageID LanguageID { [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(24)]
  int Highlight { [DispId(24), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(24), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(25)]
  Replacement Replacement { [DispId(25), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(26)]
  Frame Frame { [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(27)]
  WdFindWrap Wrap { [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(28)]
  bool Format { [DispId(28), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(28), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(29)]
  WdLanguageID LanguageIDFarEast { [DispId(29), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(29), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(60)]
  WdLanguageID LanguageIDOther { [DispId(60), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(60), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(61)]
  bool CorrectHangulEndings { [DispId(61), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(61), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(30)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool ExecuteOld(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FindText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchCase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchWholeWord,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchWildcards,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchSoundsLike,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchAllWordForms,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Forward,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Wrap,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReplaceWith,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Replace);

  [DispId(31 /*0x1F*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearFormatting();

  [DispId(32 /*0x20*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetAllFuzzyOptions();

  [DispId(33)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearAllFuzzyOptions();

  [DispId(444)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Execute(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FindText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchCase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchWholeWord,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchWildcards,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchSoundsLike,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchAllWordForms,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Forward,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Wrap,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReplaceWith,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Replace,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchKashida,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchDiacritics,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchAlefHamza,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchControl);

  [DispId(34)]
  int NoProofing { [DispId(34), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(34), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(100)]
  bool MatchKashida { [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(101)]
  bool MatchDiacritics { [DispId(101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(102)]
  bool MatchAlefHamza { [DispId(102), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(102), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(103)]
  bool MatchControl { [DispId(103), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(103), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(104)]
  bool MatchPhrase { [DispId(104), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(104), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(105)]
  bool MatchPrefix { [DispId(105), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(105), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(106)]
  bool MatchSuffix { [DispId(106), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(106), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(107)]
  bool IgnoreSpace { [DispId(107), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(107), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(108)]
  bool IgnorePunct { [DispId(108), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(108), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(445)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool HitHighlight(
    [MarshalAs(UnmanagedType.Struct), In] ref object FindText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object HighlightColor,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TextColor,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchCase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchWholeWord,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchPrefix,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchSuffix,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchPhrase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchWildcards,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchSoundsLike,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchAllWordForms,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchByte,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchFuzzy,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchKashida,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchDiacritics,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchAlefHamza,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchControl,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreSpace,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnorePunct,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object HanjaPhoneticHangul);

  [DispId(446)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool ClearHitHighlight();

  [DispId(447)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Execute2007(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FindText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchCase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchWholeWord,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchWildcards,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchSoundsLike,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchAllWordForms,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Forward,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Wrap,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReplaceWith,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Replace,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchKashida,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchDiacritics,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchAlefHamza,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchControl,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchPrefix,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchSuffix,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchPhrase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreSpace,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnorePunct);

  [DispId(109)]
  bool HanjaPhoneticHangul { [DispId(109), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(109), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
}
