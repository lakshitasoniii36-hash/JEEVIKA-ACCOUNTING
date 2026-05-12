// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.ApplicationEvents4
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[InterfaceType(2)]
[Guid("00020A01-0000-0000-C000-000000000046")]
[TypeLibType(4240)]
[ComImport]
public interface ApplicationEvents4
{
  [TypeLibFunc(65)]
  [DispId(1)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Startup();

  [DispId(2)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Quit();

  [DispId(3)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DocumentChange();

  [DispId(4)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DocumentOpen([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [DispId(6)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DocumentBeforeClose([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In, Out] ref bool Cancel);

  [DispId(7)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DocumentBeforePrint([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In, Out] ref bool Cancel);

  [DispId(8)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DocumentBeforeSave([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In] ref bool SaveAsUI, [In, Out] ref bool Cancel);

  [DispId(9)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NewDocument([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [DispId(10)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowActivate([MarshalAs(UnmanagedType.Interface), In] Document Doc, [MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [DispId(11)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowDeactivate([MarshalAs(UnmanagedType.Interface), In] Document Doc, [MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [DispId(12)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowSelectionChange([MarshalAs(UnmanagedType.Interface), In] Selection Sel);

  [DispId(13)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowBeforeRightClick([MarshalAs(UnmanagedType.Interface), In] Selection Sel, [In, Out] ref bool Cancel);

  [DispId(14)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowBeforeDoubleClick([MarshalAs(UnmanagedType.Interface), In] Selection Sel, [In, Out] ref bool Cancel);

  [DispId(15)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EPostagePropertyDialog([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [DispId(16 /*0x10*/)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EPostageInsert([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [DispId(17)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeAfterMerge([MarshalAs(UnmanagedType.Interface), In] Document Doc, [MarshalAs(UnmanagedType.Interface), In] Document DocResult);

  [DispId(18)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeAfterRecordMerge([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [DispId(19)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeBeforeMerge([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In] int StartRecord, [In] int EndRecord, [In, Out] ref bool Cancel);

  [DispId(20)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeBeforeRecordMerge([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In, Out] ref bool Cancel);

  [DispId(21)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeDataSourceLoad([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [DispId(22)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeDataSourceValidate([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In] ref bool Handled);

  [DispId(23)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeWizardSendToCustom([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [DispId(24)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeWizardStateChange(
    [MarshalAs(UnmanagedType.Interface), In] Document Doc,
    [In] ref int FromState,
    [In] ref int ToState,
    [In] ref bool Handled);

  [DispId(25)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowSize([MarshalAs(UnmanagedType.Interface), In] Document Doc, [MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [DispId(26)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void XMLSelectionChange([MarshalAs(UnmanagedType.Interface), In] Selection Sel, [MarshalAs(UnmanagedType.Interface), In] XMLNode OldXMLNode, [MarshalAs(UnmanagedType.Interface), In] XMLNode NewXMLNode, [In] ref int Reason);

  [DispId(27)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void XMLValidationError([MarshalAs(UnmanagedType.Interface), In] XMLNode XMLNode);

  [DispId(28)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DocumentSync([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In] MsoSyncEventType SyncEventType);

  [DispId(29)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EPostageInsertEx(
    [MarshalAs(UnmanagedType.Interface), In] Document Doc,
    [In] int cpDeliveryAddrStart,
    [In] int cpDeliveryAddrEnd,
    [In] int cpReturnAddrStart,
    [In] int cpReturnAddrEnd,
    [In] int xaWidth,
    [In] int yaHeight,
    [MarshalAs(UnmanagedType.BStr), In] string bstrPrinterName,
    [MarshalAs(UnmanagedType.BStr), In] string bstrPaperFeed,
    [In] bool fPrint,
    [In, Out] ref bool fCancel);

  [DispId(30)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeDataSourceValidate2([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In, Out] ref bool Handled);
}
