// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.OfficeDataSourceObject
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(4288)]
[Guid("000C1530-0000-0000-C000-000000000046")]
[ComImport]
public interface OfficeDataSourceObject
{
  [DispId(1)]
  string ConnectString { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(2)]
  string Table { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(3)]
  string DataSource { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(4)]
  object Columns { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(5)]
  int RowCount { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(6)]
  object Filters { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610743817 /*0x60020009*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int Move([In] MsoMoveRow MsoMoveRow, [In] int RowNbr = 1);

  [DispId(1610743818 /*0x6002000A*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Open(
    [MarshalAs(UnmanagedType.BStr), In] string bstrSrc = "",
    [MarshalAs(UnmanagedType.BStr), In] string bstrConnect = "",
    [MarshalAs(UnmanagedType.BStr), In] string bstrTable = "",
    [In] int fOpenExclusive = 0,
    [In] int fNeverPrompt = 1);

  [DispId(1610743819 /*0x6002000B*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetSortOrder(
    [MarshalAs(UnmanagedType.BStr), In] string SortField1,
    [In] bool SortAscending1 = true,
    [MarshalAs(UnmanagedType.BStr), In] string SortField2 = "",
    [In] bool SortAscending2 = true,
    [MarshalAs(UnmanagedType.BStr), In] string SortField3 = "",
    [In] bool SortAscending3 = true);

  [DispId(1610743820 /*0x6002000C*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyFilter();
}
