// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.ListObjects
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[InterfaceType(2)]
[TypeLibType(4096 /*0x1000*/)]
[Guid("00024470-0000-0000-C000-000000000046")]
[ComImport]
public interface ListObjects
{
  [DispId(148)]
  Application Application { [DispId(148), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [DispId(149), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [DispId(150), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [TypeLibFunc(1088)]
  [DispId(2085)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ListObject Add(
    [In] XlListObjectSourceType SourceType = XlListObjectSourceType.xlSrcRange,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Source,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object LinkSource,
    [In] XlYesNoGuess XlListObjectHasHeaders = XlYesNoGuess.xlGuess,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Destination);

  [DispId(0)]
  [IndexerName("_Default")]
  ListObject this[[MarshalAs(UnmanagedType.Struct), In] object Index] { [TypeLibFunc(1024 /*0x0400*/), DispId(0), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(1024 /*0x0400*/)]
  [DispId(-4)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  IEnumerator GetEnumerator();

  [DispId(170)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ListObject get_Item([MarshalAs(UnmanagedType.Struct), In] object Index);

  [DispId(118)]
  int Count { [DispId(118), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(181)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ListObject AddEx(
    [In] XlListObjectSourceType SourceType = XlListObjectSourceType.xlSrcRange,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Source,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object LinkSource,
    [In] XlYesNoGuess XlListObjectHasHeaders = XlYesNoGuess.xlGuess,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Destination,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TableStyleName);
}
