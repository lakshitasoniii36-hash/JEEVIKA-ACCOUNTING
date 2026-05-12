// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.Protection
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(4096 /*0x1000*/)]
[InterfaceType(2)]
[Guid("00024467-0000-0000-C000-000000000046")]
[ComImport]
public interface Protection
{
  [DispId(2032)]
  bool AllowFormattingCells { [DispId(2032), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2033)]
  bool AllowFormattingColumns { [DispId(2033), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2034)]
  bool AllowFormattingRows { [DispId(2034), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2035)]
  bool AllowInsertingColumns { [DispId(2035), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2036)]
  bool AllowInsertingRows { [DispId(2036), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2037)]
  bool AllowInsertingHyperlinks { [DispId(2037), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2038)]
  bool AllowDeletingColumns { [DispId(2038), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2039)]
  bool AllowDeletingRows { [DispId(2039), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2040)]
  bool AllowSorting { [DispId(2040), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2041)]
  bool AllowFiltering { [DispId(2041), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2042)]
  bool AllowUsingPivotTables { [DispId(2042), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2236)]
  AllowEditRanges AllowEditRanges { [DispId(2236), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
}
