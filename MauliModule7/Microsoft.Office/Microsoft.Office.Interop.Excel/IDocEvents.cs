// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IDocEvents
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[Guid("00024411-0001-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface IDocEvents
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectionChange([MarshalAs(UnmanagedType.Interface), In] Range Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeDoubleClick([MarshalAs(UnmanagedType.Interface), In] Range Target, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeRightClick([MarshalAs(UnmanagedType.Interface), In] Range Target, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Activate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Deactivate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Calculate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Change([MarshalAs(UnmanagedType.Interface), In] Range Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void FollowHyperlink([MarshalAs(UnmanagedType.Interface), In] Hyperlink Target);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableUpdate([MarshalAs(UnmanagedType.Interface), In] PivotTable Target);
}
