// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.DocEvents
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[InterfaceType(2)]
[Guid("00024411-0000-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface DocEvents
{
  [DispId(1543)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectionChange([MarshalAs(UnmanagedType.Interface), In] Range Target);

  [DispId(1537)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeDoubleClick([MarshalAs(UnmanagedType.Interface), In] Range Target, [In, Out] ref bool Cancel);

  [DispId(1534)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeRightClick([MarshalAs(UnmanagedType.Interface), In] Range Target, [In, Out] ref bool Cancel);

  [DispId(304)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Activate();

  [DispId(1530)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Deactivate();

  [DispId(279)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Calculate();

  [DispId(1545)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Change([MarshalAs(UnmanagedType.Interface), In] Range Target);

  [DispId(1470)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void FollowHyperlink([MarshalAs(UnmanagedType.Interface), In] Hyperlink Target);

  [DispId(2156)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableUpdate([MarshalAs(UnmanagedType.Interface), In] PivotTable Target);
}
