// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IShapes
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[DefaultMember("_Default")]
[Guid("0002443A-0001-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface IShapes : IEnumerable
{
  [DispId(148)]
  Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(118)]
  int Count { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape Item([MarshalAs(UnmanagedType.Struct), In] object Index);

  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape _Default([MarshalAs(UnmanagedType.Struct), In] object Index);

  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddCallout([In] MsoCalloutType Type, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddConnector([In] MsoConnectorType Type, [In] float BeginX, [In] float BeginY, [In] float EndX, [In] float EndY);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddCurve([MarshalAs(UnmanagedType.Struct), In] object SafeArrayOfPoints);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddLabel(
    [In] MsoTextOrientation Orientation,
    [In] float Left,
    [In] float Top,
    [In] float Width,
    [In] float Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddLine([In] float BeginX, [In] float BeginY, [In] float EndX, [In] float EndY);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddPicture(
    [MarshalAs(UnmanagedType.BStr), In] string Filename,
    [In] MsoTriState LinkToFile,
    [In] MsoTriState SaveWithDocument,
    [In] float Left,
    [In] float Top,
    [In] float Width,
    [In] float Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddPolyline([MarshalAs(UnmanagedType.Struct), In] object SafeArrayOfPoints);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddShape([In] MsoAutoShapeType Type, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddTextEffect(
    [In] MsoPresetTextEffect PresetTextEffect,
    [MarshalAs(UnmanagedType.BStr), In] string Text,
    [MarshalAs(UnmanagedType.BStr), In] string FontName,
    [In] float FontSize,
    [In] MsoTriState FontBold,
    [In] MsoTriState FontItalic,
    [In] float Left,
    [In] float Top);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddTextbox(
    [In] MsoTextOrientation Orientation,
    [In] float Left,
    [In] float Top,
    [In] float Width,
    [In] float Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  FreeformBuilder BuildFreeform([In] MsoEditingType EditingType, [In] float X1, [In] float Y1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ShapeRange get_Range([MarshalAs(UnmanagedType.Struct), In] object Index);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectAll();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddFormControl([In] XlFormControl Type, [In] int Left, [In] int Top, [In] int Width, [In] int Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddOLEObject(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ClassType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Link,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DisplayAsIcon,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconFileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconIndex,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconLabel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Left,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Top,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Width,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Height);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddDiagram([In] MsoDiagramType Type, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddCanvas([In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddChart([MarshalAs(UnmanagedType.Struct), In, Optional] object XlChartType, [MarshalAs(UnmanagedType.Struct), In, Optional] object Left, [MarshalAs(UnmanagedType.Struct), In, Optional] object Top, [MarshalAs(UnmanagedType.Struct), In, Optional] object Width, [MarshalAs(UnmanagedType.Struct), In, Optional] object Height);
}
