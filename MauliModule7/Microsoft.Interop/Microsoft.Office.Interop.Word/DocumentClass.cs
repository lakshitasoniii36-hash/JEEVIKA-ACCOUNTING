// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.DocumentClass
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

[TypeLibType(2)]
[DefaultMember("Name")]
[ComSourceInterfaces("Microsoft.Office.Interop.Word.DocumentEvents2\0Microsoft.Office.Interop.Word.DocumentEvents\0\0")]
[Guid("00020906-0000-0000-C000-000000000046")]
[ClassInterface(0)]
[ComImport]
public class DocumentClass : _Document, Document, DocumentEvents2_Event, DocumentEvents_Event
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern DocumentClass();

  [DispId(0)]
  public virtual extern string Name { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1)]
  public virtual extern Application Application { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  public virtual extern int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  public virtual extern object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1000)]
  public virtual extern object BuiltInDocumentProperties { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(2)]
  public virtual extern object CustomDocumentProperties { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(3)]
  public virtual extern string Path { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(4)]
  public virtual extern Bookmarks Bookmarks { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(6)]
  public virtual extern Tables Tables { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(7)]
  public virtual extern Footnotes Footnotes { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(8)]
  public virtual extern Endnotes Endnotes { [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(9)]
  public virtual extern Comments Comments { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(10)]
  public virtual extern WdDocumentType Type { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(11)]
  public virtual extern bool AutoHyphenation { [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(12)]
  public virtual extern bool HyphenateCaps { [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(13)]
  public virtual extern int HyphenationZone { [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(14)]
  public virtual extern int ConsecutiveHyphensLimit { [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(15)]
  public virtual extern Sections Sections { [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(16 /*0x10*/)]
  public virtual extern Paragraphs Paragraphs { [DispId(16 /*0x10*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(17)]
  public virtual extern Words Words { [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(18)]
  public virtual extern Sentences Sentences { [DispId(18), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(19)]
  public virtual extern Characters Characters { [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(20)]
  public virtual extern Fields Fields { [DispId(20), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(21)]
  public virtual extern FormFields FormFields { [DispId(21), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(22)]
  public virtual extern Styles Styles { [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(23)]
  public virtual extern Frames Frames { [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(25)]
  public virtual extern TablesOfFigures TablesOfFigures { [DispId(25), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(26)]
  public virtual extern Variables Variables { [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(27)]
  public virtual extern MailMerge MailMerge { [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(28)]
  public virtual extern Envelope Envelope { [DispId(28), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(29)]
  public virtual extern string FullName { [DispId(29), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(30)]
  public virtual extern Revisions Revisions { [DispId(30), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(31 /*0x1F*/)]
  public virtual extern TablesOfContents TablesOfContents { [DispId(31 /*0x1F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(32 /*0x20*/)]
  public virtual extern TablesOfAuthorities TablesOfAuthorities { [DispId(32 /*0x20*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1101)]
  public virtual extern PageSetup PageSetup { [DispId(1101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(1101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(34)]
  public virtual extern Windows Windows { [DispId(34), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(35)]
  public virtual extern bool HasRoutingSlip { [TypeLibFunc(64 /*0x40*/), DispId(35), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(35), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(36)]
  public virtual extern RoutingSlip RoutingSlip { [TypeLibFunc(64 /*0x40*/), DispId(36), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(37)]
  public virtual extern bool Routed { [DispId(37), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(38)]
  public virtual extern TablesOfAuthoritiesCategories TablesOfAuthoritiesCategories { [DispId(38), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(39)]
  public virtual extern Indexes Indexes { [DispId(39), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(40)]
  public virtual extern bool Saved { [DispId(40), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(40), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(41)]
  public virtual extern Microsoft.Office.Interop.Word.Range Content { [DispId(41), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(42)]
  public virtual extern Window ActiveWindow { [DispId(42), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(43)]
  public virtual extern WdDocumentKind Kind { [DispId(43), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(43), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(44)]
  public virtual extern bool ReadOnly { [DispId(44), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(45)]
  public virtual extern Subdocuments Subdocuments { [DispId(45), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(46)]
  public virtual extern bool IsMasterDocument { [DispId(46), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(48 /*0x30*/)]
  public virtual extern float DefaultTabStop { [DispId(48 /*0x30*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(48 /*0x30*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(50)]
  public virtual extern bool EmbedTrueTypeFonts { [DispId(50), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(50), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(51)]
  public virtual extern bool SaveFormsData { [DispId(51), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(51), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(52)]
  public virtual extern bool ReadOnlyRecommended { [DispId(52), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(52), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(53)]
  public virtual extern bool SaveSubsetFonts { [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(53), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(55)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool get_Compatibility([In] WdCompatibility Type);

  [DispId(55)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void set_Compatibility([In] WdCompatibility Type, [In] bool prop);

  [DispId(56)]
  public virtual extern StoryRanges StoryRanges { [DispId(56), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(57)]
  public virtual extern CommandBars CommandBars { [DispId(57), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(58)]
  public virtual extern bool IsSubdocument { [DispId(58), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(59)]
  public virtual extern int SaveFormat { [DispId(59), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(60)]
  public virtual extern WdProtectionType ProtectionType { [DispId(60), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(61)]
  public virtual extern Hyperlinks Hyperlinks { [DispId(61), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(62)]
  public virtual extern Shapes Shapes { [DispId(62), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(63 /*0x3F*/)]
  public virtual extern ListTemplates ListTemplates { [DispId(63 /*0x3F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(64 /*0x40*/)]
  public virtual extern Lists Lists { [DispId(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(66)]
  public virtual extern bool UpdateStylesOnOpen { [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(66), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(67)]
  public virtual extern object AttachedTemplate { [TypeLibFunc(1024 /*0x0400*/), DispId(67), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [TypeLibFunc(1024 /*0x0400*/), DispId(67), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(68)]
  public virtual extern InlineShapes InlineShapes { [DispId(68), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(69)]
  public virtual extern Shape Background { [DispId(69), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(69), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(70)]
  public virtual extern bool GrammarChecked { [DispId(70), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(70), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(71)]
  public virtual extern bool SpellingChecked { [DispId(71), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(71), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(72)]
  public virtual extern bool ShowGrammaticalErrors { [DispId(72), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(72), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(73)]
  public virtual extern bool ShowSpellingErrors { [DispId(73), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(73), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(75)]
  public virtual extern Versions Versions { [DispId(75), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(76)]
  public virtual extern bool ShowSummary { [DispId(76), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(76), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(77)]
  public virtual extern WdSummaryMode SummaryViewMode { [DispId(77), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(77), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(78)]
  public virtual extern int SummaryLength { [DispId(78), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(78), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(79)]
  public virtual extern bool PrintFractionalWidths { [DispId(79), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(79), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(80 /*0x50*/)]
  public virtual extern bool PrintPostScriptOverText { [DispId(80 /*0x50*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(80 /*0x50*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(82)]
  public virtual extern object Container { [DispId(82), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(83)]
  public virtual extern bool PrintFormsData { [DispId(83), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(83), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(84)]
  public virtual extern ListParagraphs ListParagraphs { [DispId(84), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(85)]
  public virtual extern string Password { [DispId(85), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(86)]
  public virtual extern string WritePassword { [DispId(86), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(87)]
  public virtual extern bool HasPassword { [DispId(87), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(88)]
  public virtual extern bool WriteReserved { [DispId(88), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(90)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string get_ActiveWritingStyle([MarshalAs(UnmanagedType.Struct), In] ref object LanguageID);

  [DispId(90)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void set_ActiveWritingStyle([MarshalAs(UnmanagedType.Struct), In] ref object LanguageID, [MarshalAs(UnmanagedType.BStr), In] string prop);

  [DispId(92)]
  public virtual extern bool UserControl { [DispId(92), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(92), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(93)]
  public virtual extern bool HasMailer { [DispId(93), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(93), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(94)]
  public virtual extern Mailer Mailer { [DispId(94), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(96 /*0x60*/)]
  public virtual extern ReadabilityStatistics ReadabilityStatistics { [DispId(96 /*0x60*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(97)]
  public virtual extern ProofreadingErrors GrammaticalErrors { [DispId(97), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(98)]
  public virtual extern ProofreadingErrors SpellingErrors { [DispId(98), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(99)]
  public virtual extern VBProject VBProject { [DispId(99), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(100)]
  public virtual extern bool FormsDesign { [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(-2147418112 /*0x80010000*/)]
  public virtual extern string _CodeName { [DispId(-2147418112 /*0x80010000*/), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(-2147418112 /*0x80010000*/), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(262)]
  public virtual extern string CodeName { [DispId(262), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(300)]
  public virtual extern bool SnapToGrid { [DispId(300), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(300), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(301)]
  public virtual extern bool SnapToShapes { [DispId(301), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(301), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(302)]
  public virtual extern float GridDistanceHorizontal { [DispId(302), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(302), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(303)]
  public virtual extern float GridDistanceVertical { [DispId(303), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(303), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(304)]
  public virtual extern float GridOriginHorizontal { [DispId(304), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(304), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(305)]
  public virtual extern float GridOriginVertical { [DispId(305), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(305), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(306)]
  public virtual extern int GridSpaceBetweenHorizontalLines { [DispId(306), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(306), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(307)]
  public virtual extern int GridSpaceBetweenVerticalLines { [DispId(307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(308)]
  public virtual extern bool GridOriginFromMargin { [DispId(308), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(308), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(309)]
  public virtual extern bool KerningByAlgorithm { [DispId(309), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(309), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(310)]
  public virtual extern WdJustificationMode JustificationMode { [DispId(310), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(310), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(311)]
  public virtual extern WdFarEastLineBreakLevel FarEastLineBreakLevel { [DispId(311), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(311), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(312)]
  public virtual extern string NoLineBreakBefore { [DispId(312), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(312), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(313)]
  public virtual extern string NoLineBreakAfter { [DispId(313), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(313), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(314)]
  public virtual extern bool TrackRevisions { [DispId(314), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(314), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(315)]
  public virtual extern bool PrintRevisions { [DispId(315), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(315), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(316)]
  public virtual extern bool ShowRevisions { [DispId(316), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(316), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Close(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveChanges,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OriginalFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RouteDocument);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(102)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SaveAs2000(
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
  public virtual extern void Repaginate();

  [DispId(104)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void FitToPages();

  [DispId(105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ManualHyphenation();

  [DispId(65535 /*0xFFFF*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Select();

  [DispId(106)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DataForm();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(107)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Route();

  [DispId(108)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Save();

  [DispId(109)]
  [TypeLibFunc(64 /*0x40*/)]
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
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ActivePrinterMacGX,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ManualDuplexPrint);

  [DispId(110)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SendMail();

  [DispId(2000)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Microsoft.Office.Interop.Word.Range Range([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Start, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object End);

  [DispId(112 /*0x70*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RunAutoMacro([In] WdAutoMacros Which);

  [DispId(113)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Activate();

  [DispId(114)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PrintPreview();

  [DispId(115)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Microsoft.Office.Interop.Word.Range GoTo(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object What,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Which,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Count,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Name);

  [DispId(116)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool Undo([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Times);

  [DispId(117)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool Redo([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Times);

  [DispId(118)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int ComputeStatistics(
    [In] WdStatistic Statistic,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludeFootnotesAndEndnotes);

  [DispId(119)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void MakeCompatibilityDefault();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(120)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Protect2002(
    [In] WdProtectionType Type,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NoReset,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password);

  [DispId(121)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Unprotect([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password);

  [DispId(122)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void EditionOptions(
    [In] WdEditionType Type,
    [In] WdEditionOption Option,
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format);

  [DispId(123)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RunLetterWizard([MarshalAs(UnmanagedType.Struct), In, Optional] ref object LetterContent, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WizardMode);

  [DispId(124)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern LetterContent GetLetterContent();

  [DispId(125)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetLetterContent([MarshalAs(UnmanagedType.Struct), In] ref object LetterContent);

  [DispId(126)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CopyStylesFromTemplate([MarshalAs(UnmanagedType.BStr), In] string Template);

  [DispId(127 /*0x7F*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void UpdateStyles();

  [DispId(131)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CheckGrammar();

  [DispId(132)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CheckSpelling(
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
  public virtual extern void FollowHyperlink(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SubAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NewWindow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddHistory,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExtraInfo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Method,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object HeaderInfo);

  [DispId(136)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void AddToFavorites();

  [DispId(137)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Reload();

  [DispId(138)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Microsoft.Office.Interop.Word.Range AutoSummarize(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Length,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Mode,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UpdateProperties);

  [DispId(140)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RemoveNumbers([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType);

  [DispId(141)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ConvertNumbersToText([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType);

  [DispId(142)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int CountNumberedItems([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Level);

  [DispId(143)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Post();

  [DispId(144 /*0x90*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ToggleFormsDesign();

  [DispId(145)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Compare2000([MarshalAs(UnmanagedType.BStr), In] string Name);

  [DispId(146)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void UpdateSummaryProperties();

  [DispId(147)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object GetCrossReferenceItems([MarshalAs(UnmanagedType.Struct), In] ref object ReferenceType);

  [DispId(148)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void AutoFormat();

  [DispId(149)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ViewCode();

  [DispId(150)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ViewPropertyBrowser();

  [DispId(250)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ForwardMailer();

  [DispId(251)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Reply();

  [DispId(252)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ReplyAll();

  [DispId(253)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SendMailer([MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Priority);

  [DispId(254)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void UndoClear();

  [DispId(255 /*0xFF*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PresentIt();

  [DispId(256 /*0x0100*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SendFax([MarshalAs(UnmanagedType.BStr), In] string Address, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Subject);

  [DispId(257)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Merge2000([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [DispId(258)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ClosePrintPreview();

  [DispId(259)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CheckConsistency();

  [DispId(260)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern LetterContent CreateLetterContent(
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
  public virtual extern void AcceptAllRevisions();

  [DispId(318)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RejectAllRevisions();

  [DispId(151)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DetectLanguage();

  [DispId(322)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplyTheme([MarshalAs(UnmanagedType.BStr), In] string Name);

  [DispId(323)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RemoveTheme();

  [DispId(325)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void WebPagePreview();

  [DispId(331)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ReloadAs([In] MsoEncoding Encoding);

  [DispId(540)]
  public virtual extern string ActiveTheme { [DispId(540), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(541)]
  public virtual extern string ActiveThemeDisplayName { [DispId(541), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(319)]
  public virtual extern Email Email { [DispId(319), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(320)]
  public virtual extern Scripts Scripts { [DispId(320), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(321)]
  public virtual extern bool LanguageDetected { [DispId(321), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(321), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(326)]
  public virtual extern WdFarEastLineBreakLanguageID FarEastLineBreakLanguage { [DispId(326), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(326), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(327)]
  public virtual extern Frameset Frameset { [DispId(327), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(328)]
  public virtual extern object ClickAndTypeParagraphStyle { [DispId(328), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [TypeLibFunc(1024 /*0x0400*/), DispId(328), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(329)]
  public virtual extern HTMLProject HTMLProject { [DispId(329), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(330)]
  public virtual extern WebOptions WebOptions { [DispId(330), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(332)]
  public virtual extern MsoEncoding OpenEncoding { [DispId(332), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(333)]
  public virtual extern MsoEncoding SaveEncoding { [DispId(333), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(333), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(334)]
  public virtual extern bool OptimizeForWord97 { [DispId(334), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(334), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(335)]
  public virtual extern bool VBASigned { [DispId(335), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

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
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ActivePrinterMacGX,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ManualDuplexPrint,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperWidth,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperHeight);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(445)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void sblt([MarshalAs(UnmanagedType.BStr), In] string s);

  [DispId(447)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ConvertVietDoc([In] int CodePageOrigin);

  [DispId(446)]
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
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ActivePrinterMacGX,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ManualDuplexPrint,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomColumn,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperWidth,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperHeight);

  [DispId(336)]
  public virtual extern MsoEnvelope MailEnvelope { [DispId(336), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(337)]
  public virtual extern bool DisableFeatures { [DispId(337), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(337), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(338)]
  public virtual extern bool DoNotEmbedSystemFonts { [DispId(338), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(338), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(339)]
  public virtual extern SignatureSet Signatures { [DispId(339), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(340)]
  public virtual extern string DefaultTargetFrame { [DispId(340), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(340), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(342)]
  public virtual extern HTMLDivisions HTMLDivisions { [DispId(342), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(343)]
  public virtual extern WdDisableFeaturesIntroducedAfter DisableFeaturesIntroducedAfter { [DispId(343), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(343), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(344)]
  public virtual extern bool RemovePersonalInformation { [DispId(344), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(344), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(346)]
  public virtual extern SmartTags SmartTags { [DispId(346), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(345)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Compare2002(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AuthorName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CompareTarget,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DetectFormatChanges,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IgnoreAllComparisonWarnings,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles);

  [DispId(349)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CheckIn([In] bool SaveChanges = true, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Comments, [In] bool MakePublic = false);

  [DispId(351)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool CanCheckin();

  [DispId(362)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Merge(
    [MarshalAs(UnmanagedType.BStr), In] string FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MergeTarget,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DetectFormatChanges,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UseFormattingFrom,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles);

  [DispId(347)]
  public virtual extern bool EmbedSmartTags { [DispId(347), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(347), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(348)]
  public virtual extern bool SmartTagsAsXMLProps { [DispId(348), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(348), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(357)]
  public virtual extern MsoEncoding TextEncoding { [DispId(357), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(357), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(358)]
  public virtual extern WdLineEndingType TextLineEnding { [DispId(358), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(358), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(353)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SendForReview(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Recipients,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Subject,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowMessage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object IncludeAttachment);

  [DispId(354)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ReplyWithChanges([MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowMessage);

  [DispId(356)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void EndReview();

  [DispId(360)]
  public virtual extern StyleSheets StyleSheets { [DispId(360), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(365)]
  public virtual extern object DefaultTableStyle { [DispId(365), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(367)]
  public virtual extern string PasswordEncryptionProvider { [DispId(367), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(368)]
  public virtual extern string PasswordEncryptionAlgorithm { [DispId(368), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(369)]
  public virtual extern int PasswordEncryptionKeyLength { [DispId(369), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(370)]
  public virtual extern bool PasswordEncryptionFileProperties { [DispId(370), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(361)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetPasswordEncryptionOptions(
    [MarshalAs(UnmanagedType.BStr), In] string PasswordEncryptionProvider,
    [MarshalAs(UnmanagedType.BStr), In] string PasswordEncryptionAlgorithm,
    [In] int PasswordEncryptionKeyLength,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordEncryptionFileProperties);

  [DispId(363)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RecheckSmartTags();

  [DispId(364)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RemoveSmartTags();

  [DispId(366)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetDefaultTableStyle([MarshalAs(UnmanagedType.Struct), In] ref object Style, [In] bool SetInTemplate);

  [DispId(371)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DeleteAllComments();

  [DispId(372)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void AcceptAllRevisionsShown();

  [DispId(373)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RejectAllRevisionsShown();

  [DispId(374)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DeleteAllCommentsShown();

  [DispId(375)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ResetFormFields();

  [DispId(376)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SaveAs(
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
  public virtual extern bool EmbedLinguisticData { [DispId(377), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(377), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(448)]
  public virtual extern bool FormattingShowFont { [DispId(448), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(448), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(449)]
  public virtual extern bool FormattingShowClear { [DispId(449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(449), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(450)]
  public virtual extern bool FormattingShowParagraph { [DispId(450), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(450), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(451)]
  public virtual extern bool FormattingShowNumbering { [DispId(451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(451), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(452)]
  public virtual extern WdShowFilter FormattingShowFilter { [DispId(452), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(452), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(378)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CheckNewSmartTags();

  [DispId(453)]
  public virtual extern Permission Permission { [DispId(453), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(460)]
  public virtual extern XMLNodes XMLNodes { [DispId(460), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(461)]
  public virtual extern XMLSchemaReferences XMLSchemaReferences { [DispId(461), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(462)]
  public virtual extern SmartDocument SmartDocument { [DispId(462), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(463)]
  public virtual extern SharedWorkspace SharedWorkspace { [DispId(463), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(466)]
  public virtual extern Sync Sync { [DispId(466), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(471)]
  public virtual extern bool EnforceStyle { [DispId(471), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(471), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(472)]
  public virtual extern bool AutoFormatOverride { [DispId(472), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(472), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(473)]
  public virtual extern bool XMLSaveDataOnly { [DispId(473), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(473), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(477)]
  public virtual extern bool XMLHideNamespaces { [DispId(477), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(477), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(478)]
  public virtual extern bool XMLShowAdvancedErrors { [DispId(478), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(478), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(474)]
  public virtual extern bool XMLUseXSLTWhenSaving { [DispId(474), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(474), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(475)]
  public virtual extern string XMLSaveThroughXSLT { [DispId(475), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(475), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(476)]
  public virtual extern DocumentLibraryVersions DocumentLibraryVersions { [DispId(476), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(481)]
  public virtual extern bool ReadingModeLayoutFrozen { [DispId(481), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(481), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(484)]
  public virtual extern bool RemoveDateAndTime { [DispId(484), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(484), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(464)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SendFaxOverInternet(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Recipients,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Subject,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowMessage);

  [DispId(500)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void TransformDocument([MarshalAs(UnmanagedType.BStr), In] string Path, [In] bool DataOnly = true);

  [DispId(467)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Protect(
    [In] WdProtectionType Type,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NoReset,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object UseIRM,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EnforceStyleLock);

  [DispId(468)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SelectAllEditableRanges([MarshalAs(UnmanagedType.Struct), In, Optional] ref object EditorID);

  [DispId(469)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DeleteAllEditableRanges([MarshalAs(UnmanagedType.Struct), In, Optional] ref object EditorID);

  [DispId(479)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DeleteAllInkAnnotations();

  [DispId(482)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void AddDocumentWorkspaceHeader(
    [In] bool RichFormat,
    [MarshalAs(UnmanagedType.BStr), In] string Url,
    [MarshalAs(UnmanagedType.BStr), In] string Title,
    [MarshalAs(UnmanagedType.BStr), In] string Description,
    [MarshalAs(UnmanagedType.BStr), In] string ID);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(483)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RemoveDocumentWorkspaceHeader([MarshalAs(UnmanagedType.BStr), In] string ID);

  [DispId(485)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Compare(
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
  public virtual extern void RemoveLockedStyles();

  [DispId(486)]
  public virtual extern XMLChildNodeSuggestions ChildNodeSuggestions { [DispId(486), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(488)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern XMLNode SelectSingleNode(
    [MarshalAs(UnmanagedType.BStr), In] string XPath,
    [MarshalAs(UnmanagedType.BStr), In] string PrefixMapping = "",
    [In] bool FastSearchSkippingTextNodes = true);

  [DispId(489)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern XMLNodes SelectNodes(
    [MarshalAs(UnmanagedType.BStr), In] string XPath,
    [MarshalAs(UnmanagedType.BStr), In] string PrefixMapping = "",
    [In] bool FastSearchSkippingTextNodes = true);

  [DispId(490)]
  public virtual extern XMLNodes XMLSchemaViolations { [DispId(490), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(491)]
  public virtual extern int ReadingLayoutSizeX { [DispId(491), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(491), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(492)]
  public virtual extern int ReadingLayoutSizeY { [DispId(492), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(492), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(493)]
  public virtual extern WdStyleSort StyleSortMethod { [DispId(493), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(493), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(496)]
  public virtual extern MetaProperties ContentTypeProperties { [DispId(496), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(499)]
  public virtual extern bool TrackMoves { [DispId(499), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(499), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(502)]
  public virtual extern bool TrackFormatting { [DispId(502), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(502), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(503)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Dummy1();

  [DispId(504)]
  public virtual extern OMaths OMaths { [DispId(504), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(495)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RemoveDocumentInformation([In] WdRemoveDocInfoType RemoveDocInfoType);

  [DispId(501)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CheckInWithVersion(
    [In] bool SaveChanges = true,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Comments,
    [In] bool MakePublic = false,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object VersionType);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(505)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Dummy2();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(506)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Dummy3();

  [DispId(507)]
  public virtual extern ServerPolicy ServerPolicy { [DispId(507), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(508)]
  public virtual extern ContentControls ContentControls { [DispId(508), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(510)]
  public virtual extern DocumentInspectors DocumentInspectors { [DispId(510), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(509)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void LockServerFile();

  [DispId(511 /*0x01FF*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern WorkflowTasks GetWorkflowTasks();

  [DispId(512 /*0x0200*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern WorkflowTemplates GetWorkflowTemplates();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(514)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Dummy4();

  [DispId(515)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void AddMeetingWorkspaceHeader(
    [In] bool SkipIfAbsent,
    [MarshalAs(UnmanagedType.BStr), In] string Url,
    [MarshalAs(UnmanagedType.BStr), In] string Title,
    [MarshalAs(UnmanagedType.BStr), In] string Description,
    [MarshalAs(UnmanagedType.BStr), In] string ID);

  [DispId(516)]
  public virtual extern Bibliography Bibliography { [DispId(516), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(517)]
  public virtual extern bool LockTheme { [DispId(517), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(517), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(518)]
  public virtual extern bool LockQuickStyleSet { [DispId(518), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(518), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(519)]
  public virtual extern string OriginalDocumentTitle { [DispId(519), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(520)]
  public virtual extern string RevisedDocumentTitle { [DispId(520), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(521)]
  public virtual extern CustomXMLParts CustomXMLParts { [DispId(521), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(522)]
  public virtual extern bool FormattingShowNextLevel { [DispId(522), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(522), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(523)]
  public virtual extern bool FormattingShowUserStyleName { [DispId(523), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(523), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(524)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SaveAsQuickStyleSet([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [DispId(525)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplyQuickStyleSet([MarshalAs(UnmanagedType.BStr), In] string Name);

  [DispId(526)]
  public virtual extern Research Research { [DispId(526), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(527)]
  public virtual extern bool Final { [DispId(527), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(527), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(528)]
  public virtual extern WdOMathBreakBin OMathBreakBin { [DispId(528), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(528), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(529)]
  public virtual extern WdOMathBreakSub OMathBreakSub { [DispId(529), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(529), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(530)]
  public virtual extern WdOMathJc OMathJc { [DispId(530), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(530), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(531)]
  public virtual extern float OMathLeftMargin { [DispId(531), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(531), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(532)]
  public virtual extern float OMathRightMargin { [DispId(532), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(532), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(535)]
  public virtual extern float OMathWrap { [DispId(535), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(535), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(536)]
  public virtual extern bool OMathIntSubSupLim { [DispId(536), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(536), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(537)]
  public virtual extern bool OMathNarySupSubLim { [DispId(537), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(537), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(539)]
  public virtual extern bool OMathSmallFrac { [DispId(539), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(539), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(542)]
  public virtual extern string WordOpenXML { [DispId(542), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(545)]
  public virtual extern OfficeTheme DocumentTheme { [DispId(545), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(546)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplyDocumentTheme([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [DispId(548)]
  public virtual extern bool HasVBProject { [DispId(548), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(549)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern ContentControls SelectLinkedControls([MarshalAs(UnmanagedType.Interface), In] CustomXMLNode Node);

  [DispId(550)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern ContentControls SelectUnlinkedControls([MarshalAs(UnmanagedType.Interface), In] CustomXMLPart Stream = null);

  [DispId(551)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern ContentControls SelectContentControlsByTitle([MarshalAs(UnmanagedType.BStr), In] string Title);

  [DispId(552)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ExportAsFixedFormat(
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
  public virtual extern void FreezeLayout();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(554)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void UnfreezeLayout();

  [DispId(555)]
  public virtual extern string OMathFontName { [DispId(555), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(555), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(558)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DowngradeDocument();

  [DispId(559)]
  public virtual extern string EncryptionProvider { [DispId(559), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(559), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(560)]
  public virtual extern bool UseMathDefaults { [DispId(560), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(560), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(563)]
  public virtual extern int CurrentRsid { [DispId(563), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(561)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Convert();

  [DispId(562)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern ContentControls SelectContentControlsByTag([MarshalAs(UnmanagedType.BStr), In] string Tag);

  public virtual extern event DocumentEvents2_NewEventHandler New;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_New([In] DocumentEvents2_NewEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_New([In] DocumentEvents2_NewEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Open([In] DocumentEvents2_OpenEventHandler obj0);

  public virtual extern event DocumentEvents2_OpenEventHandler Open;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Open([In] DocumentEvents2_OpenEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Close([In] DocumentEvents2_CloseEventHandler obj0);

  public virtual extern event DocumentEvents2_CloseEventHandler DocumentEvents2_Event_Close;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Close([In] DocumentEvents2_CloseEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Sync([In] DocumentEvents2_SyncEventHandler obj0);

  public virtual extern event DocumentEvents2_SyncEventHandler DocumentEvents2_Event_Sync;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Sync([In] DocumentEvents2_SyncEventHandler obj0);

  public virtual extern event DocumentEvents2_XMLAfterInsertEventHandler XMLAfterInsert;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_XMLAfterInsert([In] DocumentEvents2_XMLAfterInsertEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_XMLAfterInsert([In] DocumentEvents2_XMLAfterInsertEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_XMLBeforeDelete([In] DocumentEvents2_XMLBeforeDeleteEventHandler obj0);

  public virtual extern event DocumentEvents2_XMLBeforeDeleteEventHandler XMLBeforeDelete;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_XMLBeforeDelete([In] DocumentEvents2_XMLBeforeDeleteEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_ContentControlAfterAdd(
    [In] DocumentEvents2_ContentControlAfterAddEventHandler obj0);

  public virtual extern event DocumentEvents2_ContentControlAfterAddEventHandler ContentControlAfterAdd;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_ContentControlAfterAdd(
    [In] DocumentEvents2_ContentControlAfterAddEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_ContentControlBeforeDelete(
    [In] DocumentEvents2_ContentControlBeforeDeleteEventHandler obj0);

  public virtual extern event DocumentEvents2_ContentControlBeforeDeleteEventHandler ContentControlBeforeDelete;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_ContentControlBeforeDelete(
    [In] DocumentEvents2_ContentControlBeforeDeleteEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_ContentControlOnExit(
    [In] DocumentEvents2_ContentControlOnExitEventHandler obj0);

  public virtual extern event DocumentEvents2_ContentControlOnExitEventHandler ContentControlOnExit;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_ContentControlOnExit(
    [In] DocumentEvents2_ContentControlOnExitEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_ContentControlOnEnter(
    [In] DocumentEvents2_ContentControlOnEnterEventHandler obj0);

  public virtual extern event DocumentEvents2_ContentControlOnEnterEventHandler ContentControlOnEnter;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_ContentControlOnEnter(
    [In] DocumentEvents2_ContentControlOnEnterEventHandler obj0);

  public virtual extern event DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler ContentControlBeforeStoreUpdate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_ContentControlBeforeStoreUpdate(
    [In] DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_ContentControlBeforeStoreUpdate(
    [In] DocumentEvents2_ContentControlBeforeStoreUpdateEventHandler obj0);

  public virtual extern event DocumentEvents2_ContentControlBeforeContentUpdateEventHandler ContentControlBeforeContentUpdate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_ContentControlBeforeContentUpdate(
    [In] DocumentEvents2_ContentControlBeforeContentUpdateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_ContentControlBeforeContentUpdate(
    [In] DocumentEvents2_ContentControlBeforeContentUpdateEventHandler obj0);

  public virtual extern event DocumentEvents2_BuildingBlockInsertEventHandler BuildingBlockInsert;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_BuildingBlockInsert(
    [In] DocumentEvents2_BuildingBlockInsertEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_BuildingBlockInsert(
    [In] DocumentEvents2_BuildingBlockInsertEventHandler obj0);

  public virtual extern event DocumentEvents_NewEventHandler DocumentEvents_Event_New;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DocumentEvents_Event_add_New([In] DocumentEvents_NewEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DocumentEvents_Event_remove_New([In] DocumentEvents_NewEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DocumentEvents_Event_add_Open([In] DocumentEvents_OpenEventHandler obj0);

  public virtual extern event DocumentEvents_OpenEventHandler DocumentEvents_Event_Open;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DocumentEvents_Event_remove_Open([In] DocumentEvents_OpenEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DocumentEvents_Event_add_Close([In] DocumentEvents_CloseEventHandler obj0);

  public virtual extern event DocumentEvents_CloseEventHandler DocumentEvents_Event_Close;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DocumentEvents_Event_remove_Close([In] DocumentEvents_CloseEventHandler obj0);
}
