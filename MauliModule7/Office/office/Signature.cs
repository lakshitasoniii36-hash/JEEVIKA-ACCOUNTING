// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.Signature
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(4288)]
[Guid("000C0411-0000-0000-C000-000000000046")]
[ComImport]
public interface Signature : _IMsoDispObj
{
  [DispId(1610743808 /*0x60020000*/)]
  new object Application { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  new int Creator { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809344 /*0x60030000*/)]
  string Signer { [TypeLibFunc(64 /*0x40*/), DispId(1610809344 /*0x60030000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809345 /*0x60030001*/)]
  string Issuer { [TypeLibFunc(64 /*0x40*/), DispId(1610809345 /*0x60030001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1610809346 /*0x60030002*/)]
  object ExpireDate { [TypeLibFunc(64 /*0x40*/), DispId(1610809346 /*0x60030002*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1610809347 /*0x60030003*/)]
  bool IsValid { [DispId(1610809347 /*0x60030003*/), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809348 /*0x60030004*/)]
  bool AttachCertificate { [DispId(1610809348 /*0x60030004*/), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809348 /*0x60030004*/), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809350 /*0x60030006*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Delete();

  [DispId(1610809351 /*0x60030007*/)]
  object Parent { [DispId(1610809351 /*0x60030007*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809352 /*0x60030008*/)]
  bool IsCertificateExpired { [TypeLibFunc(64 /*0x40*/), DispId(1610809352 /*0x60030008*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809353 /*0x60030009*/)]
  bool IsCertificateRevoked { [TypeLibFunc(64 /*0x40*/), DispId(1610809353 /*0x60030009*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809354 /*0x6003000A*/)]
  object SignDate { [DispId(1610809354 /*0x6003000A*/), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1610809355 /*0x6003000B*/)]
  bool IsSigned { [DispId(1610809355 /*0x6003000B*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809356 /*0x6003000C*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Sign(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varSigImg,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varDelSuggSigner,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varDelSuggSignerLine2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varDelSuggSignerEmail);

  [DispId(1610809357 /*0x6003000D*/)]
  SignatureInfo Details { [DispId(1610809357 /*0x6003000D*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809358 /*0x6003000E*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ShowDetails();

  [DispId(1610809359 /*0x6003000F*/)]
  bool CanSetup { [DispId(1610809359 /*0x6003000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809360 /*0x60030010*/)]
  SignatureSetup Setup { [DispId(1610809360 /*0x60030010*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809361)]
  bool IsSignatureLine { [DispId(1610809361), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809362)]
  object SignatureLineShape { [DispId(1610809362), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809363)]
  int SortHint { [DispId(1610809363), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
}
