// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IWorksheets
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[Guid("000208B1-0001-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface IWorksheets : IEnumerable
{
  [DispId(148)]
  Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [LCIDConversion(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Add([MarshalAs(UnmanagedType.Struct), In, Optional] object Before, [MarshalAs(UnmanagedType.Struct), In, Optional] object After, [MarshalAs(UnmanagedType.Struct), In, Optional] object Count, [MarshalAs(UnmanagedType.Struct), In, Optional] object Type);

  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Copy([MarshalAs(UnmanagedType.Struct), In, Optional] object Before, [MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [DispId(118)]
  int Count { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Delete();

  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void FillAcrossSheets([MarshalAs(UnmanagedType.Interface), In] Range Range, [In] XlFillWith Type = XlFillWith.xlFillWithAll);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object get_Item([MarshalAs(UnmanagedType.Struct), In] object Index);

  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Move([MarshalAs(UnmanagedType.Struct), In, Optional] object Before, [MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [LCIDConversion(7)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate);

  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintPreview([MarshalAs(UnmanagedType.Struct), In, Optional] object EnableChanges);

  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Select([MarshalAs(UnmanagedType.Struct), In, Optional] object Replace);

  [DispId(1418)]
  HPageBreaks HPageBreaks { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1419)]
  VPageBreaks VPageBreaks { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(558)]
  object Visible { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(0)]
  [IndexerName("_Default")]
  object this[[MarshalAs(UnmanagedType.Struct), In] object Index] { [TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [LCIDConversion(8)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrToFileName);

  [LCIDConversion(9)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOutEx(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrToFileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnorePrintAreas);
}
