// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.MailMerge
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[TypeLibType(4288)]
[Guid("00020920-0000-0000-C000-000000000046")]
[ComImport]
public interface MailMerge
{
  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1)]
  WdMailMergeMainDocType MainDocumentType { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2)]
  WdMailMergeState State { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(3)]
  WdMailMergeDestination Destination { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(4)]
  MailMergeDataSource DataSource { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(5)]
  MailMergeFields Fields { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(6)]
  int ViewMailMergeFieldCodes { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(7)]
  bool SuppressBlankLines { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(8)]
  bool MailAsAttachment { [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(9)]
  string MailAddressFieldName { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(10)]
  string MailSubject { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(101)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CreateDataSource(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object HeaderRecord,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MSQuery,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SQLStatement,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SQLStatement1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Connection,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LinkToSource);

  [DispId(102)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CreateHeaderSource(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object HeaderRecord);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(103)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OpenDataSource2000(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConfirmConversions,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnly,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LinkToSource,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Revert,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Connection,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SQLStatement,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SQLStatement1);

  [DispId(104)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OpenHeaderSource2000(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConfirmConversions,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnly,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Revert,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordTemplate);

  [DispId(105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Execute([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Pause);

  [DispId(106)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Check();

  [DispId(107)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EditDataSource();

  [DispId(108)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EditHeaderSource();

  [DispId(109)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EditMainDocument();

  [DispId(111)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void UseAddressBook([MarshalAs(UnmanagedType.BStr), In] string Type);

  [DispId(11)]
  bool HighlightMergeFields { [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(11), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(12)]
  WdMailMergeMailFormat MailFormat { [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(13)]
  string ShowSendToCustom { [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(14)]
  int WizardState { [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(112 /*0x70*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OpenDataSource(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConfirmConversions,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnly,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LinkToSource,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Revert,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Connection,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SQLStatement,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SQLStatement1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OpenExclusive,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SubType);

  [DispId(113)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OpenHeaderSource(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConfirmConversions,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnly,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Revert,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OpenExclusive);

  [DispId(114)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ShowWizard(
    [MarshalAs(UnmanagedType.Struct), In] ref object InitialState,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowDocumentStep,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowTemplateStep,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowDataStep,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowWriteStep,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowPreviewStep,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ShowMergeStep);
}
