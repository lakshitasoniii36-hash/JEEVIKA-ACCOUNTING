// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IChartEvents
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(4112)]
[Guid("0002440F-0001-0000-C000-000000000046")]
[ComImport]
public interface IChartEvents
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Activate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Deactivate();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Resize();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MouseDown([In] int Button, [In] int Shift, [In] int x, [In] int y);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MouseUp([In] int Button, [In] int Shift, [In] int x, [In] int y);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MouseMove([In] int Button, [In] int Shift, [In] int x, [In] int y);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeRightClick([In, Out] ref bool Cancel);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DragPlot();

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DragOver();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BeforeDoubleClick([In] int ElementID, [In] int Arg1, [In] int Arg2, [In, Out] ref bool Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Select([In] int ElementID, [In] int Arg1, [In] int Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SeriesChange([In] int SeriesIndex, [In] int PointIndex);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Calculate();
}
