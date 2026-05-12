// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.Range
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using Microsoft.Office.Core;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[Guid("0002095E-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
[DefaultMember("Text")]
[ComImport]
public interface Range
{
  [DispId(0)]
  string Text { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(2)]
  Range FormattedText { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(3)]
  int Start { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(4)]
  int End { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(5)]
  Font Font { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(6)]
  Range Duplicate { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(7)]
  WdStoryType StoryType { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(50)]
  Tables Tables { [DispId(50), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(51)]
  Words Words { [DispId(51), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(52)]
  Sentences Sentences { [DispId(52), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(53)]
  Characters Characters { [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(54)]
  Footnotes Footnotes { [DispId(54), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(55)]
  Endnotes Endnotes { [DispId(55), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(56)]
  Comments Comments { [DispId(56), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(57)]
  Cells Cells { [DispId(57), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(58)]
  Sections Sections { [DispId(58), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(59)]
  Paragraphs Paragraphs { [DispId(59), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1100)]
  Borders Borders { [DispId(1100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(1100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(61)]
  Shading Shading { [DispId(61), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(62)]
  TextRetrievalMode TextRetrievalMode { [DispId(62), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(62), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(64 /*0x40*/)]
  Fields Fields { [DispId(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(65)]
  FormFields FormFields { [DispId(65), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(66)]
  Frames Frames { [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1102)]
  ParagraphFormat ParagraphFormat { [DispId(1102), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(1102), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(68)]
  ListFormat ListFormat { [DispId(68), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(75)]
  Bookmarks Bookmarks { [DispId(75), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(130)]
  int Bold { [DispId(130), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(130), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(131)]
  int Italic { [DispId(131), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(131), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(139)]
  WdUnderline Underline { [DispId(139), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(139), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(140)]
  WdEmphasisMark EmphasisMark { [DispId(140), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(140), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(141)]
  bool DisableCharacterSpaceGrid { [DispId(141), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(141), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(150)]
  Revisions Revisions { [DispId(150), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(151)]
  object Style { [DispId(151), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(151), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(152)]
  int StoryLength { [DispId(152), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(153)]
  WdLanguageID LanguageID { [DispId(153), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(153), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(155)]
  SynonymInfo SynonymInfo { [DispId(155), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(156)]
  Hyperlinks Hyperlinks { [DispId(156), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(157)]
  ListParagraphs ListParagraphs { [DispId(157), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(159)]
  Subdocuments Subdocuments { [DispId(159), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(260)]
  bool GrammarChecked { [DispId(260), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(260), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(261)]
  bool SpellingChecked { [DispId(261), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(261), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(301)]
  WdColorIndex HighlightColorIndex { [DispId(301), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(301), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(302)]
  Columns Columns { [DispId(302), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(303)]
  Rows Rows { [DispId(303), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(304)]
  int CanEdit { [TypeLibFunc(64 /*0x40*/), DispId(304), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(305)]
  int CanPaste { [TypeLibFunc(64 /*0x40*/), DispId(305), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(307)]
  bool IsEndOfRowMark { [DispId(307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(308)]
  int BookmarkID { [DispId(308), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(309)]
  int PreviousBookmarkID { [DispId(309), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(262)]
  Find Find { [DispId(262), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1101)]
  PageSetup PageSetup { [DispId(1101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(1101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(311)]
  ShapeRange ShapeRange { [DispId(311), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(312)]
  WdCharacterCase Case { [DispId(312), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(312), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(313)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object get_Information([In] WdInformation Type);

  [DispId(314)]
  ReadabilityStatistics ReadabilityStatistics { [DispId(314), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(315)]
  ProofreadingErrors GrammaticalErrors { [DispId(315), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(316)]
  ProofreadingErrors SpellingErrors { [DispId(316), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(317)]
  WdTextOrientation Orientation { [DispId(317), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(317), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(319)]
  InlineShapes InlineShapes { [DispId(319), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(320)]
  Range NextStoryRange { [DispId(320), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(321)]
  WdLanguageID LanguageIDFarEast { [DispId(321), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(321), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(322)]
  WdLanguageID LanguageIDOther { [DispId(322), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(322), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(65535 /*0xFFFF*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Select();

  [DispId(100)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetRange([In] int Start, [In] int End);

  [DispId(101)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Collapse([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Direction);

  [DispId(102)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertBefore([MarshalAs(UnmanagedType.BStr), In] string Text);

  [DispId(104)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertAfter([MarshalAs(UnmanagedType.BStr), In] string Text);

  [DispId(105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range Next([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

  [DispId(106)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range Previous([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

  [DispId(107)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int StartOf([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Extend);

  [DispId(108)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int EndOf([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Extend);

  [DispId(109)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int Move([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

  [DispId(110)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int MoveStart([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

  [DispId(111)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int MoveEnd([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

  [DispId(112 /*0x70*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int MoveWhile([MarshalAs(UnmanagedType.Struct), In] ref object Cset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

  [DispId(113)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int MoveStartWhile([MarshalAs(UnmanagedType.Struct), In] ref object Cset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

  [DispId(114)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int MoveEndWhile([MarshalAs(UnmanagedType.Struct), In] ref object Cset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

  [DispId(115)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int MoveUntil([MarshalAs(UnmanagedType.Struct), In] ref object Cset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

  [DispId(116)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int MoveStartUntil([MarshalAs(UnmanagedType.Struct), In] ref object Cset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

  [DispId(117)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int MoveEndUntil([MarshalAs(UnmanagedType.Struct), In] ref object Cset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

  [DispId(119)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Cut();

  [DispId(120)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Copy();

  [DispId(121)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Paste();

  [DispId(122)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertBreak([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Type);

  [DispId(123)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertFile(
    [MarshalAs(UnmanagedType.BStr), In] string FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConfirmConversions,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Link,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Attachment);

  [DispId(125)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool InStory([MarshalAs(UnmanagedType.Interface), In] Range Range);

  [DispId(126)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool InRange([MarshalAs(UnmanagedType.Interface), In] Range Range);

  [DispId(127 /*0x7F*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int Delete([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count);

  [DispId(128 /*0x80*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WholeStory();

  [DispId(129)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int Expand([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit);

  [DispId(160 /*0xA0*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertParagraph();

  [DispId(161)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertParagraphAfter();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(162)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Table ConvertToTableOld(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Separator,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumRows,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumColumns,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InitialColumnWidth,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyBorders,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyShading,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyFont,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyColor,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyHeadingRows,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyLastRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyFirstColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyLastColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoFit);

  [DispId(163)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertDateTimeOld(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DateTimeFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsField,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsFullWidth);

  [DispId(164)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertSymbol([In] int CharacterNumber, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Font, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unicode, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Bias);

  [DispId(165)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertCrossReference_2002(
    [MarshalAs(UnmanagedType.Struct), In] ref object ReferenceType,
    [In] WdReferenceKind ReferenceKind,
    [MarshalAs(UnmanagedType.Struct), In] ref object ReferenceItem,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsHyperlink,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludePosition);

  [DispId(166)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertCaptionXP(
    [MarshalAs(UnmanagedType.Struct), In] ref object Label,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Title,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TitleAutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Position);

  [DispId(167)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CopyAsPicture();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(168)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SortOld(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExcludeHeader,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Separator,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CaseSensitive,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LanguageID);

  [DispId(169)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SortAscending();

  [DispId(170)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SortDescending();

  [DispId(171)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsEqual([MarshalAs(UnmanagedType.Interface), In] Range Range);

  [DispId(172)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  float Calculate();

  [DispId(173)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range GoTo([MarshalAs(UnmanagedType.Struct), In, Optional] ref object What, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Which, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Name);

  [DispId(174)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range GoToNext([In] WdGoToItem What);

  [DispId(175)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range GoToPrevious([In] WdGoToItem What);

  [DispId(176 /*0xB0*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PasteSpecial(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IconIndex,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Link,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Placement,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DisplayAsIcon,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DataType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IconFileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IconLabel);

  [DispId(177)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void LookupNameProperties();

  [DispId(178)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int ComputeStatistics([In] WdStatistic Statistic);

  [DispId(179)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Relocate([In] int Direction);

  [DispId(180)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckSynonyms();

  [DispId(181)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SubscribeTo([MarshalAs(UnmanagedType.BStr), In] string Edition, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format);

  [DispId(182)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CreatePublisher(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Edition,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ContainsPICT,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ContainsRTF,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ContainsText);

  [DispId(183)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertAutoText();

  [DispId(194)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertDatabase(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Style,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LinkToSource,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Connection,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SQLStatement,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SQLStatement1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DataSource,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludeFields);

  [DispId(195)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AutoFormat();

  [DispId(204)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckGrammar();

  [DispId(205)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckSpelling(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreUppercase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AlwaysSuggest,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary10);

  [DispId(209)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  SpellingSuggestions GetSpellingSuggestions(
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

  [DispId(212)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertParagraphBefore();

  [DispId(219)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NextSubdocument();

  [DispId(220)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PreviousSubdocument();

  [DispId(221)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ConvertHangulAndHanja(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConversionsMode,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FastConversion,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CheckHangulEnding,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EnableRecentOrdering,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CustomDictionary);

  [DispId(222)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PasteAsNestedTable();

  [DispId(223)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ModifyEnclosure([MarshalAs(UnmanagedType.Struct), In] ref object Style, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Symbol, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EnclosedText);

  [DispId(224 /*0xE0*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PhoneticGuide(
    [MarshalAs(UnmanagedType.BStr), In] string Text,
    [In] WdPhoneticGuideAlignmentType Alignment = ~WdPhoneticGuideAlignmentType.wdPhoneticGuideAlignmentCenter,
    [In] int Raise = 0,
    [In] int FontSize = 0,
    [MarshalAs(UnmanagedType.BStr), In] string FontName = "");

  [DispId(444)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertDateTime(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DateTimeFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsField,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsFullWidth,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DateLanguage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CalendarType);

  [DispId(484)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Sort(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExcludeHeader,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FieldNumber3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortFieldType3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortOrder3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SortColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Separator,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CaseSensitive,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object BidiSort,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreThe,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreKashida,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreDiacritics,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreHe,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LanguageID);

  [DispId(203)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DetectLanguage();

  [DispId(498)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Table ConvertToTable(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Separator,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumRows,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumColumns,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InitialColumnWidth,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyBorders,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyShading,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyFont,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyColor,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyHeadingRows,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyLastRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyFirstColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyLastColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoFit,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoFitBehavior,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultTableBehavior);

  [DispId(499)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void TCSCConverter(
    [In] WdTCSCConverterDirection WdTCSCConverterDirection = WdTCSCConverterDirection.wdTCSCConverterDirectionAuto,
    [In] bool CommonTerms = false,
    [In] bool UseVariants = false);

  [DispId(263)]
  bool LanguageDetected { [DispId(263), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(263), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(264)]
  float FitTextWidth { [DispId(264), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(264), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(265)]
  WdHorizontalInVerticalType HorizontalInVertical { [DispId(265), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(265), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(266)]
  WdTwoLinesInOneType TwoLinesInOne { [DispId(266), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(266), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(267)]
  bool CombineCharacters { [DispId(267), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(267), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(323)]
  int NoProofing { [DispId(323), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(323), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(324)]
  Tables TopLevelTables { [DispId(324), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(325)]
  Scripts Scripts { [DispId(325), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(326)]
  WdCharacterWidth CharacterWidth { [DispId(326), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(326), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(327)]
  WdKana Kana { [DispId(327), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(327), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(400)]
  int BoldBi { [DispId(400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(401)]
  int ItalicBi { [DispId(401), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(401), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(405)]
  string ID { [DispId(405), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(405), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(406)]
  HTMLDivisions HTMLDivisions { [DispId(406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(407)]
  SmartTags SmartTags { [DispId(407), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(408)]
  bool ShowAll { [DispId(408), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(408), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(409)]
  Document Document { [DispId(409), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(410)]
  FootnoteOptions FootnoteOptions { [DispId(410), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(411)]
  EndnoteOptions EndnoteOptions { [DispId(411), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(412)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PasteAndFormat([In] WdRecoveryType Type);

  [DispId(413)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PasteExcelTable([In] bool LinkedToExcel, [In] bool WordFormatting, [In] bool RTF);

  [DispId(414)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PasteAppendTable();

  [DispId(340)]
  XMLNodes XMLNodes { [DispId(340), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(341)]
  XMLNode XMLParentNode { [DispId(341), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(343)]
  Editors Editors { [DispId(343), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(344)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string get_XML([In] bool DataOnly = false);

  [DispId(345)]
  object EnhMetaFileBits { [DispId(345), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(415)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range GoToEditableRange([MarshalAs(UnmanagedType.Struct), In, Optional] ref object EditorID);

  [DispId(416)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertXML([MarshalAs(UnmanagedType.BStr), In] string XML, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Transform);

  [DispId(417)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertCaption(
    [MarshalAs(UnmanagedType.Struct), In] ref object Label,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Title,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object TitleAutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Position,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExcludeLabel);

  [DispId(418)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertCrossReference(
    [MarshalAs(UnmanagedType.Struct), In] ref object ReferenceType,
    [In] WdReferenceKind ReferenceKind,
    [MarshalAs(UnmanagedType.Struct), In] ref object ReferenceItem,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsHyperlink,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludePosition,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SeparateNumbers,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SeparatorString);

  [DispId(346)]
  OMaths OMaths { [DispId(346), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(420)]
  object CharacterStyle { [DispId(420), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(421)]
  object ParagraphStyle { [DispId(421), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(422)]
  object ListStyle { [DispId(422), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(423)]
  object TableStyle { [DispId(423), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(424)]
  ContentControls ContentControls { [DispId(424), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(425)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ExportFragment([MarshalAs(UnmanagedType.BStr), In] string FileName, [In] WdSaveFormat Format);

  [DispId(426)]
  string WordOpenXML { [DispId(426), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(427)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetListLevel([In] short Level);

  [DispId(500)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertAlignmentTab([In] int Alignment, [In] int RelativeTo = 0);

  [DispId(501)]
  ContentControl ParentContentControl { [DispId(501), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(502)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ImportFragment([MarshalAs(UnmanagedType.BStr), In] string FileName, [In] bool MatchDestination = false);

  [DispId(503)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ExportAsFixedFormat(
    [MarshalAs(UnmanagedType.BStr), In] string OutputFileName,
    [In] WdExportFormat ExportFormat,
    [In] bool OpenAfterExport = false,
    [In] WdExportOptimizeFor OptimizeFor = WdExportOptimizeFor.wdExportOptimizeForPrint,
    [In] bool ExportCurrentPage = false,
    [In] WdExportItem Item = WdExportItem.wdExportDocumentContent,
    [In] bool IncludeDocProps = false,
    [In] bool KeepIRM = true,
    [In] WdExportCreateBookmarks CreateBookmarks = WdExportCreateBookmarks.wdExportCreateNoBookmarks,
    [In] bool DocStructureTags = true,
    [In] bool BitmapMissingFonts = true,
    [In] bool UseISO19005_1 = false,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FixedFormatExtClassPtr);
}
