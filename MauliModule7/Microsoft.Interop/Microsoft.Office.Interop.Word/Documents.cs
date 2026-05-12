// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.Documents
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[Guid("0002096C-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
[ComImport]
public interface Documents : IEnumerable
{
  [TypeLibFunc(1024 /*0x0400*/)]
  [DispId(-4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(2)]
  int Count { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(0)]
  Document this[[MarshalAs(UnmanagedType.Struct), In] ref object Index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Close([MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OriginalFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RouteDocument);

  [DispId(11)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Document AddOld([MarshalAs(UnmanagedType.Struct), In, Optional] ref object Template, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NewTemplate);

  [DispId(12)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Document OpenOld(
    [MarshalAs(UnmanagedType.Struct), In] ref object FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConfirmConversions,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnly,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Revert,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format);

  [DispId(13)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Save([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NoPrompt, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OriginalFormat);

  [DispId(14)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Document Add(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Template,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NewTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DocumentType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Visible);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(15)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Document Open2000(
    [MarshalAs(UnmanagedType.Struct), In] ref object FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConfirmConversions,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnly,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Revert,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Encoding,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Visible);

  [DispId(16 /*0x10*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckOut([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [DispId(17)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool CanCheckOut([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(18)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Document Open2002(
    [MarshalAs(UnmanagedType.Struct), In] ref object FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConfirmConversions,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnly,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Revert,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Encoding,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Visible,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OpenAndRepair,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DocumentDirection,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NoEncodingDialog);

  [DispId(19)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Document Open(
    [MarshalAs(UnmanagedType.Struct), In] ref object FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConfirmConversions,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnly,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Revert,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Encoding,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Visible,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OpenAndRepair,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DocumentDirection,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NoEncodingDialog,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object XMLTransform);

  [DispId(20)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Document OpenNoRepairDialog(
    [MarshalAs(UnmanagedType.Struct), In] ref object FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConfirmConversions,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnly,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Revert,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Encoding,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Visible,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OpenAndRepair,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DocumentDirection,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NoEncodingDialog,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object XMLTransform);

  [DispId(21)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Document AddBlogDocument([MarshalAs(UnmanagedType.BStr), In] string ProviderID, [MarshalAs(UnmanagedType.BStr), In] string PostURL, [MarshalAs(UnmanagedType.BStr), In] string BlogName, [MarshalAs(UnmanagedType.BStr), In] string PostID = "");
}
