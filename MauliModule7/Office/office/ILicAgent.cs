// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.ILicAgent
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[Guid("00194002-D9C3-11D3-8D59-0050048384E3")]
[TypeLibType(4304)]
[ComImport]
public interface ILicAgent
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  uint Initialize([In] uint dwBPC, [In] uint dwMode, [MarshalAs(UnmanagedType.BStr), In] string bstrLicSource);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetFirstName();

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetFirstName([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetLastName();

  [DispId(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetLastName([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(7)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetOrgName();

  [DispId(8)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetOrgName([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(9)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetEmail();

  [DispId(10)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetEmail([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(11)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetPhone();

  [DispId(12)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetPhone([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(13)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetAddress1();

  [DispId(14)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetAddress1([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(15)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCity();

  [DispId(16 /*0x10*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetCity([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(17)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetState();

  [DispId(18)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetState([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(19)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCountryCode();

  [DispId(20)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetCountryCode([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(21)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCountryDesc();

  [DispId(22)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetCountryDesc([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(23)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetZip();

  [DispId(24)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetZip([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(25)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  uint GetIsoLanguage();

  [DispId(26)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetIsoLanguage([In] uint dwNewVal);

  [DispId(32 /*0x20*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetMSUpdate();

  [DispId(33)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetMSUpdate([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(34)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetMSOffer();

  [DispId(35)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetMSOffer([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(36)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetOtherOffer();

  [DispId(37)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetOtherOffer([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(38)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetAddress2();

  [DispId(39)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetAddress2([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(40)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  uint CheckSystemClock();

  [DispId(41)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  DateTime GetExistingExpiryDate();

  [DispId(42)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  DateTime GetNewExpiryDate();

  [DispId(43)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingFirstName();

  [DispId(44)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetBillingFirstName([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(45)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingLastName();

  [DispId(46)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetBillingLastName([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(47)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingPhone();

  [DispId(48 /*0x30*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetBillingPhone([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(49)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingAddress1();

  [DispId(50)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetBillingAddress1([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(51)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingAddress2();

  [DispId(52)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetBillingAddress2([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(53)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingCity();

  [DispId(54)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetBillingCity([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(55)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingState();

  [DispId(56)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetBillingState([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(57)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingCountryCode();

  [DispId(58)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetBillingCountryCode([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(59)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBillingZip();

  [DispId(60)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetBillingZip([MarshalAs(UnmanagedType.BStr), In] string bstrNewVal);

  [DispId(61)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  uint SaveBillingInfo([In] int bSave);

  [DispId(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int IsCCRenewalCountry([MarshalAs(UnmanagedType.BStr), In] string bstrCountryCode);

  [DispId(65)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetVATLabel([MarshalAs(UnmanagedType.BStr), In] string bstrCountryCode);

  [DispId(66)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  DateTime GetCCRenewalExpiryDate();

  [DispId(67)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetVATNumber([MarshalAs(UnmanagedType.BStr), In] string bstrVATNumber);

  [DispId(68)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetCreditCardType([MarshalAs(UnmanagedType.BStr), In] string bstrCCCode);

  [DispId(69)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetCreditCardNumber([MarshalAs(UnmanagedType.BStr), In] string bstrCCNumber);

  [DispId(70)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetCreditCardExpiryYear([In] uint dwCCYear);

  [DispId(71)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetCreditCardExpiryMonth([In] uint dwCCMonth);

  [DispId(72)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  uint GetCreditCardCount();

  [DispId(73)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCreditCardCode([In] uint dwIndex);

  [DispId(74)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCreditCardName([In] uint dwIndex);

  [DispId(75)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetVATNumber();

  [DispId(76)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCreditCardType();

  [DispId(77)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCreditCardNumber();

  [DispId(78)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  uint GetCreditCardExpiryYear();

  [DispId(79)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  uint GetCreditCardExpiryMonth();

  [DispId(80 /*0x50*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int GetDisconnectOption();

  [DispId(81)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetDisconnectOption([In] int bNewVal);

  [DispId(82)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AsyncProcessHandshakeRequest([In] int bReviseCustInfo);

  [DispId(83)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AsyncProcessNewLicenseRequest();

  [DispId(84)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AsyncProcessReissueLicenseRequest();

  [DispId(85)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AsyncProcessRetailRenewalLicenseRequest();

  [DispId(86)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AsyncProcessReviseCustInfoRequest();

  [DispId(87)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AsyncProcessCCRenewalPriceRequest();

  [DispId(88)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AsyncProcessCCRenewalLicenseRequest();

  [DispId(90)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  uint GetAsyncProcessReturnCode();

  [DispId(91)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int IsUpgradeAvailable();

  [DispId(92)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WantUpgrade([In] int bWantUpgrade);

  [DispId(93)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AsyncProcessDroppedLicenseRequest();

  [DispId(94)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GenerateInstallationId();

  [DispId(95)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  uint DepositConfirmationId([MarshalAs(UnmanagedType.BStr), In] string bstrVal);

  [DispId(96 /*0x60*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int VerifyCheckDigits([MarshalAs(UnmanagedType.BStr), In] string bstrCIDIID);

  [DispId(97)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  DateTime GetCurrentExpiryDate();

  [DispId(98)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CancelAsyncProcessRequest([In] int bIsLicenseRequest);

  [DispId(100)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetCurrencyDescription([In] uint dwCurrencyIndex);

  [DispId(101)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  uint GetPriceItemCount();

  [DispId(102)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetPriceItemLabel([In] uint dwIndex);

  [DispId(103)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetPriceItemValue([In] uint dwCurrencyIndex, [In] uint dwIndex);

  [DispId(104)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetInvoiceText();

  [DispId(105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetBackendErrorMsg();

  [DispId(106)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  uint GetCurrencyOption();

  [DispId(107)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetCurrencyOption([In] uint dwCurrencyOption);

  [DispId(108)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetEndOfLifeHtmlText();

  [DispId(109)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  uint DisplaySSLCert();
}
