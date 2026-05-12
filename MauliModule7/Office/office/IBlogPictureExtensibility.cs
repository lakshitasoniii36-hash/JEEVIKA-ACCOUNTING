// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.IBlogPictureExtensibility
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(4288)]
[Guid("000C03C5-0000-0000-C000-000000000046")]
[ComImport]
public interface IBlogPictureExtensibility
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BlogPictureProviderProperties([MarshalAs(UnmanagedType.BStr)] out string BlogPictureProvider, [MarshalAs(UnmanagedType.BStr)] out string FriendlyName);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CreatePictureAccount(
    [MarshalAs(UnmanagedType.BStr), In] string Account,
    [MarshalAs(UnmanagedType.BStr), In] string BlogProvider,
    [In] int ParentWindow,
    [MarshalAs(UnmanagedType.IDispatch), In] object Document);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PublishPicture(
    [MarshalAs(UnmanagedType.BStr), In] string Account,
    [In] int ParentWindow,
    [MarshalAs(UnmanagedType.IDispatch), In] object Document,
    [MarshalAs(UnmanagedType.IUnknown), In] object Image,
    [MarshalAs(UnmanagedType.BStr)] out string PictureURI,
    [In] int ImageType);
}
