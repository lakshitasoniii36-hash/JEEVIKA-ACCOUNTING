// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.EncryptionProvider
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(4160)]
[Guid("000CD809-0000-0000-C000-000000000046")]
[ComImport]
public interface EncryptionProvider
{
  [DispId(1610743808 /*0x60020000*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object GetProviderDetail([In] EncryptionProviderDetail encprovdet);

  [DispId(1610743809 /*0x60020001*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int NewSession([MarshalAs(UnmanagedType.IUnknown), In] object ParentWindow);

  [DispId(1610743810 /*0x60020002*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int Authenticate([MarshalAs(UnmanagedType.IUnknown), In] object ParentWindow, [MarshalAs(UnmanagedType.IUnknown), In] object EncryptionData, out uint PermissionsMask);

  [DispId(1610743811 /*0x60020003*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int CloneSession([In] int SessionHandle);

  [DispId(1610743812 /*0x60020004*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EndSession([In] int SessionHandle);

  [DispId(1610743813 /*0x60020005*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int Save([In] int SessionHandle, [MarshalAs(UnmanagedType.IUnknown), In] object EncryptionData);

  [DispId(1610743814 /*0x60020006*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EncryptStream(
    [In] int SessionHandle,
    [MarshalAs(UnmanagedType.BStr), In] string StreamName,
    [MarshalAs(UnmanagedType.IUnknown), In] object UnencryptedStream,
    [MarshalAs(UnmanagedType.IUnknown), In] object EncryptedStream);

  [DispId(1610743815 /*0x60020007*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DecryptStream(
    [In] int SessionHandle,
    [MarshalAs(UnmanagedType.BStr), In] string StreamName,
    [MarshalAs(UnmanagedType.IUnknown), In] object EncryptedStream,
    [MarshalAs(UnmanagedType.IUnknown), In] object UnencryptedStream);

  [DispId(1610743816 /*0x60020008*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ShowSettings([In] int SessionHandle, [MarshalAs(UnmanagedType.IUnknown), In] object ParentWindow, [In] bool ReadOnly, out bool Remove);
}
