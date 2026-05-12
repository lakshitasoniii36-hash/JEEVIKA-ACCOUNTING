// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting.IPromptPickList
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

[Guid("7D680C1E-07C2-4819-92B0-E019B09CE97F")]
[TypeLibType(4688)]
[ComImport]
public interface IPromptPickList
{
  [DispId(1001)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PromptPickList Clone([In] bool DeepClone = true);

  [DispId(1002)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CopyTo([MarshalAs(UnmanagedType.Interface), In] PromptPickList pickList, [In] bool DeepCopy = true);

  [DispId(1003)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Equals([MarshalAs(UnmanagedType.Interface), In] PromptPickList pickList);

  [DispId(1004)]
  string ClassName { [DispId(1004), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1)]
  int ColumnCount { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  PromptPickListColumn get_column([In] int Index);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void set_column([In] int Index, [MarshalAs(UnmanagedType.Interface), In] PromptPickListColumn column);

  [DispId(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddColumn([MarshalAs(UnmanagedType.Interface), In] PromptPickListColumn column);

  [DispId(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveColumn([In] int Index);

  [DispId(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertColumn([In] int Index, [MarshalAs(UnmanagedType.Interface), In] PromptPickListColumn column);

  [DispId(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveAllColumns();

  [DispId(7)]
  ParameterSortingType SortingType { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(8)]
  int SortingIndex { [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(8), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(9)]
  int RowCount { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(10)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Values2 get_row([In] int Index);

  [DispId(10)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void set_row([In] int Index, [MarshalAs(UnmanagedType.Interface), In] Values2 values);

  [DispId(11)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddRow([MarshalAs(UnmanagedType.Interface), In] Values2 values);

  [DispId(12)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveRow([In] int Index);

  [DispId(13)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertRow([In] int Index, [MarshalAs(UnmanagedType.Interface), In] Values2 values);

  [DispId(14)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveAllRows();

  [DispId(15)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int FindFirstRow([MarshalAs(UnmanagedType.BStr), In] string value, [In] int colIndex);

  [DispId(16 /*0x10*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetValue([In] int colIndex, [In] int rowIndex);

  [DispId(17)]
  object Rowset { [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IDispatch), In] set; }

  [DispId(1610743834)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve10();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743835)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve9();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743836)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve8();

  [DispId(1610743837)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve7();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743838)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve6();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743839)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve5();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743840 /*0x60020020*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve4();

  [DispId(1610743841)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve3();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743842)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve2();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610743843)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void reserve1();
}
