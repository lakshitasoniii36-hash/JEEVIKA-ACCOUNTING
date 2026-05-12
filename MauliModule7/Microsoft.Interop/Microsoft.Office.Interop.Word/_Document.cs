// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word._Document
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

[TypeLibType(4176)]
[Guid("0002096B-0000-0000-C000-000000000046")]
[DefaultMember("Name")]
[ComImport]
public interface _Document
{
  [DispId(0)]
  string Name { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1)]
  Application Application { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1000)]
  object BuiltInDocumentProperties { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(2)]
  object CustomDocumentProperties { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(3)]
  string Path { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(4)]
  Bookmarks Bookmarks { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(6)]
  Tables Tables { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(7)]
  Footnotes Footnotes { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(8)]
  Endnotes Endnotes { [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(9)]
  Comments Comments { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(10)]
  WdDocumentType Type { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(11)]
  bool AutoHyphenation { [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(12)]
  bool HyphenateCaps { [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(13)]
  int HyphenationZone { [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(14)]
  int ConsecutiveHyphensLimit { [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(15)]
  Sections Sections { [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(16 /*0x10*/)]
  Paragraphs Paragraphs { [DispId(16 /*0x10*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(17)]
  Words Words { [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(18)]
  Sentences Sentences { [DispId(18), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(19)]
  Characters Characters { [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(20)]
  Fields Fields { [DispId(20), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(21)]
  FormFields FormFields { [DispId(21), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(22)]
  Styles Styles { [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(23)]
  Frames Frames { [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(25)]
  TablesOfFigures TablesOfFigures { [DispId(25), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(26)]
  Variables Variables { [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(27)]
  MailMerge MailMerge { [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(28)]
  Envelope Envelope { [DispId(28), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(29)]
  string FullName { [DispId(29), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(30)]
  Revisions Revisions { [DispId(30), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(31 /*0x1F*/)]
  TablesOfContents TablesOfContents { [DispId(31 /*0x1F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(32 /*0x20*/)]
  TablesOfAuthorities TablesOfAuthorities { [DispId(32 /*0x20*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1101)]
  PageSetup PageSetup { [DispId(1101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(1101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(34)]
  Windows Windows { [DispId(34), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(35)]
  bool HasRoutingSlip { [TypeLibFunc(64 /*0x40*/), DispId(35), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(35), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(36)]
  RoutingSlip RoutingSlip { [DispId(36), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(37)]
  bool Routed { [TypeLibFunc(64 /*0x40*/), DispId(37), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(38)]
  TablesOfAuthoritiesCategories TablesOfAuthoritiesCategories { [DispId(38), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(39)]
  Indexes Indexes { [DispId(39), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(40)]
  bool Saved { [DispId(40), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(40), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(41)]
  Microsoft.Office.Interop.Word.Range Content { [DispId(41), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(42)]
  Window ActiveWindow { [DispId(42), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(43)]
  WdDocumentKind Kind { [DispId(43), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(43), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(44)]
  bool ReadOnly { [DispId(44), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(45)]
  Subdocuments Subdocuments { [DispId(45), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(46)]
  bool IsMasterDocument { [DispId(46), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(48 /*0x30*/)]
  float DefaultTabStop { [DispId(48 /*0x30*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(48 /*0x30*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(50)]
  bool EmbedTrueTypeFonts { [DispId(50), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(50), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(51)]
  bool SaveFormsData { [DispId(51), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(51), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(52)]
  bool ReadOnlyRecommended { [DispId(52), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(52), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(53)]
  bool SaveSubsetFonts { [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(55)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool get_Compatibility([In] WdCompatibility Type);

  [DispId(55)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void set_Compatibility([In] WdCompatibility Type, [In] bool prop);

  [DispId(56)]
  StoryRanges StoryRanges { [DispId(56), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(57)]
  CommandBars CommandBars { [DispId(57), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(58)]
  bool IsSubdocument { [DispId(58), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(59)]
  int SaveFormat { [DispId(59), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(60)]
  WdProtectionType ProtectionType { [DispId(60), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(61)]
  Hyperlinks Hyperlinks { [DispId(61), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(62)]
  Shapes Shapes { [DispId(62), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(63 /*0x3F*/)]
  ListTemplates ListTemplates { [DispId(63 /*0x3F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(64 /*0x40*/)]
  Lists Lists { [DispId(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(66)]
  bool UpdateStylesOnOpen { [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(67)]
  object AttachedTemplate { [TypeLibFunc(1024 /*0x0400*/), DispId(67), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(67), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(68)]
  InlineShapes InlineShapes { [DispId(68), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(69)]
  Shape Background { [DispId(69), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(69), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(70)]
  bool GrammarChecked { [DispId(70), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(70), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(71)]
  bool SpellingChecked { [DispId(71), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(71), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(72)]
  bool ShowGrammaticalErrors { [DispId(72), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(72), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(73)]
  bool ShowSpellingErrors { [DispId(73), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(73), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(75)]
  Versions Versions { [TypeLibFunc(64 /*0x40*/), DispId(75), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(76)]
  bool ShowSummary { [DispId(76), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(76), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(77)]
  WdSummaryMode SummaryViewMode { [DispId(77), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(77), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(78)]
  int SummaryLength { [DispId(78), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(78), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(79)]
  bool PrintFractionalWidths { [DispId(79), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(79), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(80 /*0x50*/)]
  bool PrintPostScriptOverText { [DispId(80 /*0x50*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(80 /*0x50*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(82)]
  object Container { [DispId(82), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(83)]
  bool PrintFormsData { [DispId(83), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(83), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(84)]
  ListParagraphs ListParagraphs { [DispId(84), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(85)]
  string Password { [DispId(85), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(86)]
  string WritePassword { [DispId(86), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(87)]
  bool HasPassword { [DispId(87), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(88)]
  bool WriteReserved { [DispId(88), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(90)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string get_ActiveWritingStyle([MarshalAs(UnmanagedType.Struct), In] ref object LanguageID);

  [DispId(90)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void set_ActiveWritingStyle([MarshalAs(UnmanagedType.Struct), In] ref object LanguageID, [MarshalAs(UnmanagedType.BStr), In] string prop);

  [DispId(92)]
  bool UserControl { [DispId(92), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(92), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(93)]
  bool HasMailer { [DispId(93), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(93), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(94)]
  Mailer Mailer { [DispId(94), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(96 /*0x60*/)]
  ReadabilityStatistics ReadabilityStatistics { [DispId(96 /*0x60*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(97)]
  ProofreadingErrors GrammaticalErrors { [DispId(97), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(98)]
  ProofreadingErrors SpellingErrors { [DispId(98), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(99)]
  VBProject VBProject { [DispId(99), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(100)]
  bool FormsDesign { [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(-2147418112 /*0x80010000*/)]
  string _CodeName { [DispId(-2147418112 /*0x80010000*/), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(1024 /*0x0400*/), DispId(-2147418112 /*0x80010000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(262)]
  string CodeName { [DispId(262), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(300)]
  bool SnapToGrid { [DispId(300), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(300), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(301)]
  bool SnapToShapes { [DispId(301), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(301), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(302)]
  float GridDistanceHorizontal { [DispId(302), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(302), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(303)]
  float GridDistanceVertical { [DispId(303), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(303), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(304)]
  float GridOriginHorizontal { [DispId(304), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(304), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(305)]
  float GridOriginVertical { [DispId(305), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(305), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(306)]
  int GridSpaceBetweenHorizontalLines { [DispId(306), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(306), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(307)]
  int GridSpaceBetweenVerticalLines { [DispId(307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(308)]
  bool GridOriginFromMargin { [DispId(308), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(308), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(309)]
  bool KerningByAlgorithm { [DispId(309), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(309), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(310)]
  WdJustificationMode JustificationMode { [DispId(310), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(310), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(311)]
  WdFarEastLineBreakLevel FarEastLineBreakLevel { [DispId(311), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(311), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(312)]
  string NoLineBreakBefore { [DispId(312), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(312), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(313)]
  string NoLineBreakAfter { [DispId(313), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(313), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(314)]
  bool TrackRevisions { [DispId(314), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(314), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(315)]
  bool PrintRevisions { [DispId(315), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(315), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(316)]
  bool ShowRevisions { [DispId(316), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(316), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Close([MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OriginalFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RouteDocument);

  [DispId(102)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SaveAs2000(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LockComments,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EmbedTrueTypeFonts,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveNativePictureFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveFormsData,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveAsAOCELetter);

  [DispId(103)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Repaginate();

  [DispId(104)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void FitToPages();

  [DispId(105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ManualHyphenation();

  [DispId(65535 /*0xFFFF*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Select();

  [DispId(106)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DataForm();

  [DispId(107)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Route();

  [DispId(108)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Save();

  [DispId(109)]
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
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ActivePrinterMacGX,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ManualDuplexPrint);

  [DispId(110)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SendMail();

  [DispId(2000)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Microsoft.Office.Interop.Word.Range Range([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Start, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object End);

  [DispId(112 /*0x70*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RunAutoMacro([In] WdAutoMacros Which);

  [DispId(113)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Activate();

  [DispId(114)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintPreview();

  [DispId(115)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Microsoft.Office.Interop.Word.Range GoTo(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object What,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Which,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Name);

  [DispId(116)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Undo([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Times);

  [DispId(117)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Redo([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Times);

  [DispId(118)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int ComputeStatistics([In] WdStatistic Statistic, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludeFootnotesAndEndnotes);

  [DispId(119)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MakeCompatibilityDefault();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(120)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Protect2002([In] WdProtectionType Type, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NoReset, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password);

  [DispId(121)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Unprotect([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password);

  [DispId(122)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EditionOptions([In] WdEditionType Type, [In] WdEditionOption Option, [MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format);

  [DispId(123)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RunLetterWizard([MarshalAs(UnmanagedType.Struct), In, Optional] ref object LetterContent, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WizardMode);

  [DispId(124)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  LetterContent GetLetterContent();

  [DispId(125)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetLetterContent([MarshalAs(UnmanagedType.Struct), In] ref object LetterContent);

  [DispId(126)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CopyStylesFromTemplate([MarshalAs(UnmanagedType.BStr), In] string Template);

  [DispId(127 /*0x7F*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void UpdateStyles();

  [DispId(131)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckGrammar();

  [DispId(132)]
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

  [DispId(135)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void FollowHyperlink(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SubAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NewWindow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddHistory,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExtraInfo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Method,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object HeaderInfo);

  [DispId(136)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddToFavorites();

  [DispId(137)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Reload();

  [DispId(138)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Microsoft.Office.Interop.Word.Range AutoSummarize(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Length,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Mode,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UpdateProperties);

  [DispId(140)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveNumbers([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType);

  [DispId(141)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ConvertNumbersToText([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType);

  [DispId(142)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int CountNumberedItems([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Level);

  [DispId(143)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Post();

  [DispId(144 /*0x90*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ToggleFormsDesign();

  [DispId(145)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Compare2000([MarshalAs(UnmanagedType.BStr), In] string Name);

  [DispId(146)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void UpdateSummaryProperties();

  [DispId(147)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object GetCrossReferenceItems([MarshalAs(UnmanagedType.Struct), In] ref object ReferenceType);

  [DispId(148)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AutoFormat();

  [DispId(149)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ViewCode();

  [DispId(150)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ViewPropertyBrowser();

  [DispId(250)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ForwardMailer();

  [DispId(251)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Reply();

  [DispId(252)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ReplyAll();

  [DispId(253)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SendMailer([MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Priority);

  [DispId(254)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void UndoClear();

  [DispId(255 /*0xFF*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PresentIt();

  [DispId(256 /*0x0100*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SendFax([MarshalAs(UnmanagedType.BStr), In] string Address, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Subject);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(257)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Merge2000([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [DispId(258)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClosePrintPreview();

  [DispId(259)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckConsistency();

  [DispId(260)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  LetterContent CreateLetterContent(
    [MarshalAs(UnmanagedType.BStr), In] string DateFormat,
    [In] bool IncludeHeaderFooter,
    [MarshalAs(UnmanagedType.BStr), In] string PageDesign,
    [In] WdLetterStyle LetterStyle,
    [In] bool Letterhead,
    [In] WdLetterheadLocation LetterheadLocation,
    [In] float LetterheadSize,
    [MarshalAs(UnmanagedType.BStr), In] string RecipientName,
    [MarshalAs(UnmanagedType.BStr), In] string RecipientAddress,
    [MarshalAs(UnmanagedType.BStr), In] string Salutation,
    [In] WdSalutationType SalutationType,
    [MarshalAs(UnmanagedType.BStr), In] string RecipientReference,
    [MarshalAs(UnmanagedType.BStr), In] string MailingInstructions,
    [MarshalAs(UnmanagedType.BStr), In] string AttentionLine,
    [MarshalAs(UnmanagedType.BStr), In] string Subject,
    [MarshalAs(UnmanagedType.BStr), In] string CCList,
    [MarshalAs(UnmanagedType.BStr), In] string ReturnAddress,
    [MarshalAs(UnmanagedType.BStr), In] string SenderName,
    [MarshalAs(UnmanagedType.BStr), In] string Closing,
    [MarshalAs(UnmanagedType.BStr), In] string SenderCompany,
    [MarshalAs(UnmanagedType.BStr), In] string SenderJobTitle,
    [MarshalAs(UnmanagedType.BStr), In] string SenderInitials,
    [In] int EnclosureNumber,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InfoBlock,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RecipientCode,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RecipientGender,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddressShortForm,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderCity,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderCode,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderGender,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderReference);

  [DispId(317)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AcceptAllRevisions();

  [DispId(318)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RejectAllRevisions();

  [DispId(151)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DetectLanguage();

  [DispId(322)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyTheme([MarshalAs(UnmanagedType.BStr), In] string Name);

  [DispId(323)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveTheme();

  [DispId(325)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WebPagePreview();

  [DispId(331)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ReloadAs([In] MsoEncoding Encoding);

  [DispId(540)]
  string ActiveTheme { [DispId(540), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(541)]
  string ActiveThemeDisplayName { [DispId(541), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(319)]
  Email Email { [DispId(319), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(320)]
  Scripts Scripts { [DispId(320), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(321)]
  bool LanguageDetected { [DispId(321), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(321), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(326)]
  WdFarEastLineBreakLanguageID FarEastLineBreakLanguage { [DispId(326), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(326), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(327)]
  Frameset Frameset { [DispId(327), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(328)]
  object ClickAndTypeParagraphStyle { [DispId(328), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [TypeLibFunc(1024 /*0x0400*/), DispId(328), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(329)]
  HTMLProject HTMLProject { [DispId(329), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(330)]
  WebOptions WebOptions { [DispId(330), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(332)]
  MsoEncoding OpenEncoding { [DispId(332), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(333)]
  MsoEncoding SaveEncoding { [DispId(333), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(333), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(334)]
  bool OptimizeForWord97 { [DispId(334), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(334), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(335)]
  bool VBASigned { [DispId(335), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(444)]
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
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ActivePrinterMacGX,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ManualDuplexPrint,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperWidth,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperHeight);

  [DispId(445)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void sblt([MarshalAs(UnmanagedType.BStr), In] string s);

  [DispId(447)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ConvertVietDoc([In] int CodePageOrigin);

  [DispId(446)]
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
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ActivePrinterMacGX,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ManualDuplexPrint,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperWidth,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperHeight);

  [DispId(336)]
  MsoEnvelope MailEnvelope { [DispId(336), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(337)]
  bool DisableFeatures { [DispId(337), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(337), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(338)]
  bool DoNotEmbedSystemFonts { [DispId(338), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(338), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(339)]
  SignatureSet Signatures { [DispId(339), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(340)]
  string DefaultTargetFrame { [DispId(340), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(340), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(342)]
  HTMLDivisions HTMLDivisions { [DispId(342), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(343)]
  WdDisableFeaturesIntroducedAfter DisableFeaturesIntroducedAfter { [DispId(343), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(343), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(344)]
  bool RemovePersonalInformation { [DispId(344), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(344), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(346)]
  SmartTags SmartTags { [DispId(346), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(345)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Compare2002(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AuthorName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CompareTarget,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DetectFormatChanges,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreAllComparisonWarnings,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles);

  [DispId(349)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckIn([In] bool SaveChanges = true, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Comments, [In] bool MakePublic = false);

  [DispId(351)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool CanCheckin();

  [DispId(362)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Merge(
    [MarshalAs(UnmanagedType.BStr), In] string FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MergeTarget,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DetectFormatChanges,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UseFormattingFrom,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles);

  [DispId(347)]
  bool EmbedSmartTags { [DispId(347), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(347), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(348)]
  bool SmartTagsAsXMLProps { [DispId(348), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(348), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(357)]
  MsoEncoding TextEncoding { [DispId(357), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(357), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(358)]
  WdLineEndingType TextLineEnding { [DispId(358), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(358), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(353)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SendForReview(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Recipients,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Subject,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowMessage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludeAttachment);

  [DispId(354)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ReplyWithChanges([MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowMessage);

  [DispId(356)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EndReview();

  [DispId(360)]
  StyleSheets StyleSheets { [DispId(360), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(365)]
  object DefaultTableStyle { [DispId(365), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(367)]
  string PasswordEncryptionProvider { [DispId(367), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(368)]
  string PasswordEncryptionAlgorithm { [DispId(368), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(369)]
  int PasswordEncryptionKeyLength { [DispId(369), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(370)]
  bool PasswordEncryptionFileProperties { [DispId(370), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(361)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetPasswordEncryptionOptions(
    [MarshalAs(UnmanagedType.BStr), In] string PasswordEncryptionProvider,
    [MarshalAs(UnmanagedType.BStr), In] string PasswordEncryptionAlgorithm,
    [In] int PasswordEncryptionKeyLength,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordEncryptionFileProperties);

  [DispId(363)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RecheckSmartTags();

  [DispId(364)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveSmartTags();

  [DispId(366)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetDefaultTableStyle([MarshalAs(UnmanagedType.Struct), In] ref object Style, [In] bool SetInTemplate);

  [DispId(371)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DeleteAllComments();

  [DispId(372)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AcceptAllRevisionsShown();

  [DispId(373)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RejectAllRevisionsShown();

  [DispId(374)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DeleteAllCommentsShown();

  [DispId(375)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ResetFormFields();

  [DispId(376)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SaveAs(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LockComments,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EmbedTrueTypeFonts,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveNativePictureFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveFormsData,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveAsAOCELetter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Encoding,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertLineBreaks,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AllowSubstitutions,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LineEnding,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddBiDiMarks);

  [DispId(377)]
  bool EmbedLinguisticData { [DispId(377), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(377), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(448)]
  bool FormattingShowFont { [DispId(448), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(448), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(449)]
  bool FormattingShowClear { [DispId(449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(450)]
  bool FormattingShowParagraph { [DispId(450), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(450), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(451)]
  bool FormattingShowNumbering { [DispId(451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(452)]
  WdShowFilter FormattingShowFilter { [DispId(452), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(452), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(378)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckNewSmartTags();

  [DispId(453)]
  Permission Permission { [DispId(453), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(460)]
  XMLNodes XMLNodes { [DispId(460), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(461)]
  XMLSchemaReferences XMLSchemaReferences { [DispId(461), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(462)]
  SmartDocument SmartDocument { [DispId(462), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(463)]
  SharedWorkspace SharedWorkspace { [DispId(463), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(466)]
  Sync Sync { [DispId(466), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(471)]
  bool EnforceStyle { [DispId(471), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(471), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(472)]
  bool AutoFormatOverride { [DispId(472), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(472), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(473)]
  bool XMLSaveDataOnly { [DispId(473), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(473), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(477)]
  bool XMLHideNamespaces { [DispId(477), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(477), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(478)]
  bool XMLShowAdvancedErrors { [DispId(478), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(478), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(474)]
  bool XMLUseXSLTWhenSaving { [DispId(474), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(474), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(475)]
  string XMLSaveThroughXSLT { [DispId(475), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(475), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(476)]
  DocumentLibraryVersions DocumentLibraryVersions { [DispId(476), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(481)]
  bool ReadingModeLayoutFrozen { [DispId(481), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(481), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(484)]
  bool RemoveDateAndTime { [DispId(484), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(484), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(464)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SendFaxOverInternet([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Recipients, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Subject, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowMessage);

  [DispId(500)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void TransformDocument([MarshalAs(UnmanagedType.BStr), In] string Path, [In] bool DataOnly = true);

  [DispId(467)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Protect(
    [In] WdProtectionType Type,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NoReset,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UseIRM,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EnforceStyleLock);

  [DispId(468)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectAllEditableRanges([MarshalAs(UnmanagedType.Struct), In, Optional] ref object EditorID);

  [DispId(469)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DeleteAllEditableRanges([MarshalAs(UnmanagedType.Struct), In, Optional] ref object EditorID);

  [DispId(479)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DeleteAllInkAnnotations();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(482)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddDocumentWorkspaceHeader(
    [In] bool RichFormat,
    [MarshalAs(UnmanagedType.BStr), In] string Url,
    [MarshalAs(UnmanagedType.BStr), In] string Title,
    [MarshalAs(UnmanagedType.BStr), In] string Description,
    [MarshalAs(UnmanagedType.BStr), In] string ID);

  [DispId(483)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveDocumentWorkspaceHeader([MarshalAs(UnmanagedType.BStr), In] string ID);

  [DispId(485)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Compare(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AuthorName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CompareTarget,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DetectFormatChanges,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreAllComparisonWarnings,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RemovePersonalInformation,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RemoveDateAndTime);

  [DispId(487)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveLockedStyles();

  [DispId(486)]
  XMLChildNodeSuggestions ChildNodeSuggestions { [DispId(486), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(488)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  XMLNode SelectSingleNode([MarshalAs(UnmanagedType.BStr), In] string XPath, [MarshalAs(UnmanagedType.BStr), In] string PrefixMapping = "", [In] bool FastSearchSkippingTextNodes = true);

  [DispId(489)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  XMLNodes SelectNodes([MarshalAs(UnmanagedType.BStr), In] string XPath, [MarshalAs(UnmanagedType.BStr), In] string PrefixMapping = "", [In] bool FastSearchSkippingTextNodes = true);

  [DispId(490)]
  XMLNodes XMLSchemaViolations { [DispId(490), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(491)]
  int ReadingLayoutSizeX { [DispId(491), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(491), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(492)]
  int ReadingLayoutSizeY { [DispId(492), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(492), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(493)]
  WdStyleSort StyleSortMethod { [DispId(493), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(493), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(496)]
  MetaProperties ContentTypeProperties { [DispId(496), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(499)]
  bool TrackMoves { [DispId(499), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(499), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(502)]
  bool TrackFormatting { [DispId(502), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(502), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(503)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Dummy1();

  [DispId(504)]
  OMaths OMaths { [DispId(504), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(495)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveDocumentInformation([In] WdRemoveDocInfoType RemoveDocInfoType);

  [DispId(501)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckInWithVersion(
    [In] bool SaveChanges = true,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Comments,
    [In] bool MakePublic = false,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object VersionType);

  [DispId(505)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Dummy2();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(506)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Dummy3();

  [DispId(507)]
  ServerPolicy ServerPolicy { [DispId(507), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(508)]
  ContentControls ContentControls { [DispId(508), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(510)]
  DocumentInspectors DocumentInspectors { [DispId(510), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(509)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void LockServerFile();

  [DispId(511 /*0x01FF*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  WorkflowTasks GetWorkflowTasks();

  [DispId(512 /*0x0200*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  WorkflowTemplates GetWorkflowTemplates();

  [DispId(514)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Dummy4();

  [DispId(515)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddMeetingWorkspaceHeader(
    [In] bool SkipIfAbsent,
    [MarshalAs(UnmanagedType.BStr), In] string Url,
    [MarshalAs(UnmanagedType.BStr), In] string Title,
    [MarshalAs(UnmanagedType.BStr), In] string Description,
    [MarshalAs(UnmanagedType.BStr), In] string ID);

  [DispId(516)]
  Bibliography Bibliography { [DispId(516), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(517)]
  bool LockTheme { [DispId(517), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(517), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(518)]
  bool LockQuickStyleSet { [DispId(518), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(518), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(519)]
  string OriginalDocumentTitle { [DispId(519), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(520)]
  string RevisedDocumentTitle { [DispId(520), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(521)]
  CustomXMLParts CustomXMLParts { [DispId(521), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(522)]
  bool FormattingShowNextLevel { [DispId(522), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(522), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(523)]
  bool FormattingShowUserStyleName { [DispId(523), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(523), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(524)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SaveAsQuickStyleSet([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [DispId(525)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyQuickStyleSet([MarshalAs(UnmanagedType.BStr), In] string Name);

  [DispId(526)]
  Research Research { [DispId(526), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(527)]
  bool Final { [DispId(527), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(527), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(528)]
  WdOMathBreakBin OMathBreakBin { [DispId(528), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(528), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(529)]
  WdOMathBreakSub OMathBreakSub { [DispId(529), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(529), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(530)]
  WdOMathJc OMathJc { [DispId(530), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(530), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(531)]
  float OMathLeftMargin { [DispId(531), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(531), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(532)]
  float OMathRightMargin { [DispId(532), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(532), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(535)]
  float OMathWrap { [DispId(535), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(535), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(536)]
  bool OMathIntSubSupLim { [DispId(536), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(536), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(537)]
  bool OMathNarySupSubLim { [DispId(537), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(537), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(539)]
  bool OMathSmallFrac { [DispId(539), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(539), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(542)]
  string WordOpenXML { [DispId(542), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(545)]
  OfficeTheme DocumentTheme { [DispId(545), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(546)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyDocumentTheme([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [DispId(548)]
  bool HasVBProject { [DispId(548), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(549)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ContentControls SelectLinkedControls([MarshalAs(UnmanagedType.Interface), In] CustomXMLNode Node);

  [DispId(550)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ContentControls SelectUnlinkedControls([MarshalAs(UnmanagedType.Interface), In] CustomXMLPart Stream = null);

  [DispId(551)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ContentControls SelectContentControlsByTitle([MarshalAs(UnmanagedType.BStr), In] string Title);

  [DispId(552)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ExportAsFixedFormat(
    [MarshalAs(UnmanagedType.BStr), In] string OutputFileName,
    [In] WdExportFormat ExportFormat,
    [In] bool OpenAfterExport = false,
    [In] WdExportOptimizeFor OptimizeFor = WdExportOptimizeFor.wdExportOptimizeForPrint,
    [In] WdExportRange Range = WdExportRange.wdExportAllDocument,
    [In] int From = 1,
    [In] int To = 1,
    [In] WdExportItem Item = WdExportItem.wdExportDocumentContent,
    [In] bool IncludeDocProps = false,
    [In] bool KeepIRM = true,
    [In] WdExportCreateBookmarks CreateBookmarks = WdExportCreateBookmarks.wdExportCreateNoBookmarks,
    [In] bool DocStructureTags = true,
    [In] bool BitmapMissingFonts = true,
    [In] bool UseISO19005_1 = false,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FixedFormatExtClassPtr);

  [DispId(553)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void FreezeLayout();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(554)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void UnfreezeLayout();

  [DispId(555)]
  string OMathFontName { [DispId(555), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(555), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(558)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DowngradeDocument();

  [DispId(559)]
  string EncryptionProvider { [DispId(559), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(559), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(560)]
  bool UseMathDefaults { [DispId(560), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(560), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(563)]
  int CurrentRsid { [DispId(563), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(561)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Convert();

  [DispId(562)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ContentControls SelectContentControlsByTag([MarshalAs(UnmanagedType.BStr), In] string Tag);
}
