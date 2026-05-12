// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.IApplicationEvents4
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[Guid("00020A01-0001-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface IApplicationEvents4
{
  [TypeLibFunc(65)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Startup();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Quit();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DocumentChange();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DocumentOpen([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DocumentBeforeClose([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DocumentBeforePrint([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DocumentBeforeSave([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In] ref bool SaveAsUI, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void NewDocument([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowActivate([MarshalAs(UnmanagedType.Interface), In] Document Doc, [MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowDeactivate([MarshalAs(UnmanagedType.Interface), In] Document Doc, [MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowSelectionChange([MarshalAs(UnmanagedType.Interface), In] Selection Sel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowBeforeRightClick([MarshalAs(UnmanagedType.Interface), In] Selection Sel, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowBeforeDoubleClick([MarshalAs(UnmanagedType.Interface), In] Selection Sel, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EPostagePropertyDialog([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EPostageInsert([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeAfterMerge([MarshalAs(UnmanagedType.Interface), In] Document Doc, [MarshalAs(UnmanagedType.Interface), In] Document DocResult);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeAfterRecordMerge([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeBeforeMerge([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In] int StartRecord, [In] int EndRecord, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeBeforeRecordMerge([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeDataSourceLoad([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeDataSourceValidate([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In] ref bool Handled);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeWizardSendToCustom([MarshalAs(UnmanagedType.Interface), In] Document Doc);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeWizardStateChange(
    [MarshalAs(UnmanagedType.Interface), In] Document Doc,
    [In] ref int FromState,
    [In] ref int ToState,
    [In] ref bool Handled);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowSize([MarshalAs(UnmanagedType.Interface), In] Document Doc, [MarshalAs(UnmanagedType.Interface), In] Window Wn);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void XMLSelectionChange([MarshalAs(UnmanagedType.Interface), In] Selection Sel, [MarshalAs(UnmanagedType.Interface), In] XMLNode OldXMLNode, [MarshalAs(UnmanagedType.Interface), In] XMLNode NewXMLNode, [In] ref int Reason);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void XMLValidationError([MarshalAs(UnmanagedType.Interface), In] XMLNode XMLNode);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DocumentSync([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In] MsoSyncEventType SyncEventType);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MailMergeDataSourceValidate2([MarshalAs(UnmanagedType.Interface), In] Document Doc, [In, Out] ref bool Handled);
}
