// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.SignatureProvider
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using stdole;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(4160)]
[Guid("000CD6A3-0000-0000-C000-000000000046")]
[ComImport]
public interface SignatureProvider
{
  [DispId(1610743808 /*0x60020000*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: ComAliasName("stdole.IPictureDisp")]
  [return: MarshalAs(UnmanagedType.Interface)]
  IPictureDisp GenerateSignatureLineImage(
    [In] SignatureLineImage siglnimg,
    [MarshalAs(UnmanagedType.Interface), In] SignatureSetup psigsetup,
    [MarshalAs(UnmanagedType.Interface), In] SignatureInfo psiginfo,
    [MarshalAs(UnmanagedType.IUnknown), In] object XmlDsigStream);

  [DispId(1610743809 /*0x60020001*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ShowSignatureSetup([MarshalAs(UnmanagedType.IUnknown), In] object ParentWindow, [MarshalAs(UnmanagedType.Interface), In] SignatureSetup psigsetup);

  [DispId(1610743810 /*0x60020002*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ShowSigningCeremony([MarshalAs(UnmanagedType.IUnknown), In] object ParentWindow, [MarshalAs(UnmanagedType.Interface), In] SignatureSetup psigsetup, [MarshalAs(UnmanagedType.Interface), In] SignatureInfo psiginfo);

  [DispId(1610743811 /*0x60020003*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SignXmlDsig(
    [MarshalAs(UnmanagedType.IUnknown), In] object QueryContinue,
    [MarshalAs(UnmanagedType.Interface), In] SignatureSetup psigsetup,
    [MarshalAs(UnmanagedType.Interface), In] SignatureInfo psiginfo,
    [MarshalAs(UnmanagedType.IUnknown), In] object XmlDsigStream);

  [DispId(1610743812 /*0x60020004*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NotifySignatureAdded([MarshalAs(UnmanagedType.IUnknown), In] object ParentWindow, [MarshalAs(UnmanagedType.Interface), In] SignatureSetup psigsetup, [MarshalAs(UnmanagedType.Interface), In] SignatureInfo psiginfo);

  [DispId(1610743813 /*0x60020005*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void VerifyXmlDsig(
    [MarshalAs(UnmanagedType.IUnknown), In] object QueryContinue,
    [MarshalAs(UnmanagedType.Interface), In] SignatureSetup psigsetup,
    [MarshalAs(UnmanagedType.Interface), In] SignatureInfo psiginfo,
    [MarshalAs(UnmanagedType.IUnknown), In] object XmlDsigStream,
    [In, Out] ref ContentVerificationResults pcontverres,
    [In, Out] ref CertificateVerificationResults pcertverres);

  [DispId(1610743814 /*0x60020006*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ShowSignatureDetails(
    [MarshalAs(UnmanagedType.IUnknown), In] object ParentWindow,
    [MarshalAs(UnmanagedType.Interface), In] SignatureSetup psigsetup,
    [MarshalAs(UnmanagedType.Interface), In] SignatureInfo psiginfo,
    [MarshalAs(UnmanagedType.IUnknown), In] object XmlDsigStream,
    [In, Out] ref ContentVerificationResults pcontverres,
    [In, Out] ref CertificateVerificationResults pcertverres);

  [DispId(1610743815 /*0x60020007*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object GetProviderDetail([In] SignatureProviderDetail sigprovdet);

  [DispId(1610743816 /*0x60020008*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_UI1)]
  Array HashStream([MarshalAs(UnmanagedType.IUnknown), In] object QueryContinue, [MarshalAs(UnmanagedType.IUnknown), In] object Stream);
}
