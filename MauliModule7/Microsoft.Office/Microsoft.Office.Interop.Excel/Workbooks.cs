// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.Workbooks
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(4288)]
[Guid("000208DB-0000-0000-C000-000000000046")]
[ComImport]
public interface Workbooks : IEnumerable
{
  [DispId(148)]
  Application Application { [DispId(148), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [DispId(149), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [DispId(150), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(181)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook Add([MarshalAs(UnmanagedType.Struct), In, Optional] object Template);

  [DispId(277)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Close();

  [DispId(118)]
  int Count { [DispId(118), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(170)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook get_Item([MarshalAs(UnmanagedType.Struct), In] object Index);

  [DispId(-4)]
  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [LCIDConversion(13)]
  [DispId(682)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook _Open(
    [MarshalAs(UnmanagedType.BStr), In] string Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UpdateLinks,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnly,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Origin,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Delimiter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Editable,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Notify,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Converter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AddToMru);

  [LCIDConversion(14)]
  [TypeLibFunc(1088)]
  [DispId(683)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void __OpenText(
    [MarshalAs(UnmanagedType.BStr), In] string Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Origin,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object StartRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DataType,
    [In] XlTextQualifier TextQualifier = XlTextQualifier.xlTextQualifierDoubleQuote,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ConsecutiveDelimiter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Tab,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Semicolon,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Comma,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Space,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Other,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OtherChar,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FieldInfo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout);

  [DispId(0)]
  [IndexerName("_Default")]
  Workbook this[[MarshalAs(UnmanagedType.Struct), In] object Index] { [DispId(0), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(16 /*0x10*/)]
  [DispId(1773)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _OpenText(
    [MarshalAs(UnmanagedType.BStr), In] string Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Origin,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object StartRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DataType,
    [In] XlTextQualifier TextQualifier = XlTextQualifier.xlTextQualifierDoubleQuote,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ConsecutiveDelimiter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Tab,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Semicolon,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Comma,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Space,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Other,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OtherChar,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FieldInfo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DecimalSeparator,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ThousandsSeparator);

  [LCIDConversion(15)]
  [DispId(1923)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook Open(
    [MarshalAs(UnmanagedType.BStr), In] string Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UpdateLinks,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnly,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Origin,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Delimiter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Editable,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Notify,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Converter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AddToMru,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Local,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CorruptLoad);

  [DispId(1924)]
  [LCIDConversion(18)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OpenText(
    [MarshalAs(UnmanagedType.BStr), In] string Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Origin,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object StartRow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DataType,
    [In] XlTextQualifier TextQualifier = XlTextQualifier.xlTextQualifierDoubleQuote,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ConsecutiveDelimiter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Tab,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Semicolon,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Comma,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Space,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Other,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OtherChar,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FieldInfo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DecimalSeparator,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ThousandsSeparator,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TrailingMinusNumbers,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Local);

  [DispId(2067)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook OpenDatabase(
    [MarshalAs(UnmanagedType.BStr), In] string Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CommandText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CommandType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object BackgroundQuery,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ImportDataAs);

  [DispId(2069)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckOut([MarshalAs(UnmanagedType.BStr), In] string Filename);

  [DispId(2070)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool CanCheckOut([MarshalAs(UnmanagedType.BStr), In] string Filename);

  [TypeLibFunc(1088)]
  [DispId(2071)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook _OpenXML([MarshalAs(UnmanagedType.BStr), In] string Filename, [MarshalAs(UnmanagedType.Struct), In, Optional] object Stylesheets);

  [DispId(2280)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Workbook OpenXML([MarshalAs(UnmanagedType.BStr), In] string Filename, [MarshalAs(UnmanagedType.Struct), In, Optional] object Stylesheets, [MarshalAs(UnmanagedType.Struct), In, Optional] object LoadOption);
}
