// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.Selection
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[Guid("00020975-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
[DefaultMember("Text")]
[ComImport]
public interface Selection
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
  WdSelectionType Type { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(7)]
  WdStoryType StoryType { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(8)]
  object Style { [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

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

  [DispId(64 /*0x40*/)]
  Fields Fields { [DispId(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(65)]
  FormFields FormFields { [DispId(65), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(66)]
  Frames Frames { [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1102)]
  ParagraphFormat ParagraphFormat { [DispId(1102), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(1102), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(1101)]
  PageSetup PageSetup { [DispId(1101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(1101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(75)]
  Bookmarks Bookmarks { [DispId(75), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(152)]
  int StoryLength { [DispId(152), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(153)]
  WdLanguageID LanguageID { [DispId(153), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(153), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(154)]
  WdLanguageID LanguageIDFarEast { [DispId(154), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(154), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(155)]
  WdLanguageID LanguageIDOther { [DispId(155), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(155), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(156)]
  Hyperlinks Hyperlinks { [DispId(156), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(302)]
  Columns Columns { [DispId(302), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(303)]
  Rows Rows { [DispId(303), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(306)]
  HeaderFooter HeaderFooter { [DispId(306), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(307)]
  bool IsEndOfRowMark { [DispId(307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(308)]
  int BookmarkID { [DispId(308), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(309)]
  int PreviousBookmarkID { [DispId(309), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(262)]
  Find Find { [DispId(262), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(400)]
  Range Range { [DispId(400), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(401)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object get_Information([In] WdInformation Type);

  [DispId(402)]
  WdSelectionFlags Flags { [DispId(402), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(402), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(403)]
  bool Active { [DispId(403), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(404)]
  bool StartIsActive { [DispId(404), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(404), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(405)]
  bool IPAtEndOfLine { [DispId(405), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(406)]
  bool ExtendMode { [DispId(406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(407)]
  bool ColumnSelectMode { [DispId(407), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(407), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(410)]
  WdTextOrientation Orientation { [DispId(410), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(410), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(411)]
  InlineShapes InlineShapes { [DispId(411), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1003)]
  Document Document { [DispId(1003), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1004)]
  ShapeRange ShapeRange { [DispId(1004), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

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

  [DispId(129)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int Expand([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit);

  [DispId(160 /*0xA0*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertParagraph();

  [DispId(161)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertParagraphAfter();

  [DispId(162)]
  [TypeLibFunc(64 /*0x40*/)]
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

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(163)]
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
  [return: MarshalAs(UnmanagedType.Interface)]
  Field PreviousField();

  [DispId(178)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Field NextField();

  [DispId(212)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertParagraphBefore();

  [DispId(214)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertCells([MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShiftCells);

  [DispId(300)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Extend([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Character);

  [DispId(301)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Shrink();

  [DispId(500)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int MoveLeft([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Extend);

  [DispId(501)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int MoveRight([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Extend);

  [DispId(502)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int MoveUp([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Extend);

  [DispId(503)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int MoveDown([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Extend);

  [DispId(504)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int HomeKey([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Extend);

  [DispId(505)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int EndKey([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Unit, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Extend);

  [DispId(506)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EscapeKey();

  [DispId(507)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void TypeText([MarshalAs(UnmanagedType.BStr), In] string Text);

  [DispId(509)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CopyFormat();

  [DispId(510)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PasteFormat();

  [DispId(512 /*0x0200*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void TypeParagraph();

  [DispId(513)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void TypeBackspace();

  [DispId(514)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NextSubdocument();

  [DispId(515)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PreviousSubdocument();

  [DispId(516)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectColumn();

  [DispId(517)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectCurrentFont();

  [DispId(518)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectCurrentAlignment();

  [DispId(519)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectCurrentSpacing();

  [DispId(520)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectCurrentIndent();

  [DispId(521)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectCurrentTabs();

  [DispId(522)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectCurrentColor();

  [DispId(523)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CreateTextbox();

  [DispId(524)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WholeStory();

  [DispId(525)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectRow();

  [DispId(526)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SplitTable();

  [DispId(528)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertRows([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumRows);

  [DispId(529)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertColumns();

  [DispId(530)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertFormula([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Formula, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberFormat);

  [DispId(531)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Revision NextRevision([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Wrap);

  [DispId(532)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Revision PreviousRevision([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Wrap);

  [DispId(533)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PasteAsNestedTable();

  [DispId(534)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  AutoTextEntry CreateAutoTextEntry([MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.BStr), In] string StyleName);

  [DispId(535)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DetectLanguage();

  [DispId(536)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectCell();

  [DispId(537)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertRowsBelow([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumRows);

  [DispId(538)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertColumnsRight();

  [DispId(539)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertRowsAbove([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumRows);

  [DispId(600)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RtlRun();

  [DispId(601)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void LtrRun();

  [DispId(602)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BoldRun();

  [DispId(603)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ItalicRun();

  [DispId(605)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RtlPara();

  [DispId(606)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void LtrPara();

  [DispId(444)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertDateTime(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DateTimeFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsField,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertAsFullWidth,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DateLanguage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CalendarType);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(445)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Sort2000(
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

  [DispId(457)]
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

  [DispId(1005)]
  int NoProofing { [DispId(1005), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1005), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1006)]
  Tables TopLevelTables { [DispId(1006), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1007)]
  bool LanguageDetected { [DispId(1007), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1007), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1008)]
  float FitTextWidth { [DispId(1008), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1008), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1009)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearFormatting();

  [DispId(1010)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PasteAppendTable();

  [DispId(1011)]
  HTMLDivisions HTMLDivisions { [DispId(1011), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1015)]
  SmartTags SmartTags { [DispId(1015), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1021)]
  ShapeRange ChildShapeRange { [DispId(1021), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1022)]
  bool HasChildShapeRange { [DispId(1022), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1024 /*0x0400*/)]
  FootnoteOptions FootnoteOptions { [DispId(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1025)]
  EndnoteOptions EndnoteOptions { [DispId(1025), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1012)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ToggleCharacterCode();

  [DispId(1013)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PasteAndFormat([In] WdRecoveryType Type);

  [DispId(1014)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PasteExcelTable([In] bool LinkedToExcel, [In] bool WordFormatting, [In] bool RTF);

  [DispId(1019)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ShrinkDiscontiguousSelection();

  [DispId(1020)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertStyleSeparator();

  [DispId(1023 /*0x03FF*/)]
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
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LanguageID,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SubFieldNumber,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SubFieldNumber2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SubFieldNumber3);

  [DispId(310)]
  XMLNodes XMLNodes { [DispId(310), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(311)]
  XMLNode XMLParentNode { [DispId(311), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(313)]
  Editors Editors { [DispId(313), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(314)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string get_XML([In] bool DataOnly = false);

  [DispId(315)]
  object EnhMetaFileBits { [DispId(315), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1027)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range GoToEditableRange([MarshalAs(UnmanagedType.Struct), In, Optional] ref object EditorID);

  [DispId(1028)]
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

  [DispId(316)]
  OMaths OMaths { [DispId(316), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(317)]
  string WordOpenXML { [DispId(317), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1030)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearParagraphStyle();

  [DispId(1031)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearCharacterAllFormatting();

  [DispId(1032)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearCharacterStyle();

  [DispId(1033)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearCharacterDirectFormatting();

  [DispId(1034)]
  ContentControls ContentControls { [TypeLibFunc(64 /*0x40*/), DispId(1034), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1035)]
  ContentControl ParentContentControl { [TypeLibFunc(64 /*0x40*/), DispId(1035), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1036)]
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

  [DispId(1037)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ReadingModeGrowFont();

  [DispId(1038)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ReadingModeShrinkFont();

  [DispId(1039)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearParagraphAllFormatting();

  [DispId(1040)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearParagraphDirectFormatting();

  [DispId(1041)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertNewPage();
}
