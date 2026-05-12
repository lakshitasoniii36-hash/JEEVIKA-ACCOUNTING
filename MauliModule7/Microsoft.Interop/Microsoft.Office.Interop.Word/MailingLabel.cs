// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.MailingLabel
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[Guid("00020917-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
[ComImport]
public interface MailingLabel
{
  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(2)]
  bool DefaultPrintBarCode { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(4)]
  WdPaperTray DefaultLaserTray { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(8)]
  CustomLabels CustomLabels { [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(9)]
  string DefaultLabelName { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(101)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Document CreateNewDocument2000(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExtractAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LaserTray);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(102)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOut2000(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExtractAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LaserTray,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SingleLabel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Row,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Column);

  [DispId(103)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void LabelOptions();

  [DispId(104)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Document CreateNewDocument(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExtractAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LaserTray,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintEPostageLabel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Vertical);

  [DispId(105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExtractAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LaserTray,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SingleLabel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Row,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Column,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintEPostageLabel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Vertical);

  [DispId(10)]
  bool Vertical { [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(10), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(106)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Document CreateNewDocumentByID(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LabelID,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExtractAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LaserTray,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintEPostageLabel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Vertical);

  [DispId(107)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOutByID(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LabelID,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExtractAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LaserTray,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SingleLabel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Row,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Column,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintEPostageLabel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Vertical);
}
