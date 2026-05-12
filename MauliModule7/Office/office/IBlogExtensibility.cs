// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.IBlogExtensibility
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(4288)]
[Guid("000C03C4-0000-0000-C000-000000000046")]
[ComImport]
public interface IBlogExtensibility
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BlogProviderProperties(
    [MarshalAs(UnmanagedType.BStr)] out string BlogProvider,
    [MarshalAs(UnmanagedType.BStr)] out string FriendlyName,
    out MsoBlogCategorySupport CategorySupport,
    out bool Padding);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetupBlogAccount(
    [MarshalAs(UnmanagedType.BStr), In] string Account,
    [In] int ParentWindow,
    [MarshalAs(UnmanagedType.IDispatch), In] object Document,
    [In] bool NewAccount,
    out bool ShowPictureUI);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void GetUserBlogs(
    [MarshalAs(UnmanagedType.BStr), In] string Account,
    [In] int ParentWindow,
    [MarshalAs(UnmanagedType.IDispatch), In] object Document,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array BlogNames,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array BlogIDs,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array BlogURLs);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void GetRecentPosts(
    [MarshalAs(UnmanagedType.BStr), In] string Account,
    [In] int ParentWindow,
    [MarshalAs(UnmanagedType.IDispatch), In] object Document,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array PostTitles,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array PostDates,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array PostIDs);

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Open(
    [MarshalAs(UnmanagedType.BStr), In] string Account,
    [MarshalAs(UnmanagedType.BStr), In] string PostID,
    [In] int ParentWindow,
    [MarshalAs(UnmanagedType.BStr)] out string xHTML,
    [MarshalAs(UnmanagedType.BStr)] out string Title,
    [MarshalAs(UnmanagedType.BStr)] out string DatePosted,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array Categories);

  [DispId(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PublishPost(
    [MarshalAs(UnmanagedType.BStr), In] string Account,
    [In] int ParentWindow,
    [MarshalAs(UnmanagedType.IDispatch), In] object Document,
    [MarshalAs(UnmanagedType.BStr), In] string xHTML,
    [MarshalAs(UnmanagedType.BStr), In] string Title,
    [MarshalAs(UnmanagedType.BStr), In] string DateTime,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR), In] Array Categories,
    [In] bool Draft,
    [MarshalAs(UnmanagedType.BStr)] out string PostID,
    [MarshalAs(UnmanagedType.BStr)] out string PublishMessage);

  [DispId(7)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RepublishPost(
    [MarshalAs(UnmanagedType.BStr), In] string Account,
    [In] int ParentWindow,
    [MarshalAs(UnmanagedType.IDispatch), In] object Document,
    [MarshalAs(UnmanagedType.BStr), In] string PostID,
    [MarshalAs(UnmanagedType.BStr), In] string xHTML,
    [MarshalAs(UnmanagedType.BStr), In] string Title,
    [MarshalAs(UnmanagedType.BStr), In] string DateTime,
    [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR), In] Array Categories,
    [In] bool Draft,
    [MarshalAs(UnmanagedType.BStr)] out string PublishMessage);

  [DispId(8)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void GetCategories([MarshalAs(UnmanagedType.BStr), In] string Account, [In] int ParentWindow, [MarshalAs(UnmanagedType.IDispatch), In] object Document, [MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_BSTR)] out Array Categories);
}
