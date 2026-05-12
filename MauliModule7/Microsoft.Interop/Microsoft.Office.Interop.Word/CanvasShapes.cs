// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.CanvasShapes
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using Microsoft.Office.Core;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[Guid("396F9073-F9FD-11D3-8EA0-0050049A1A01")]
[TypeLibType(4288)]
[ComImport]
public interface CanvasShapes : IEnumerable
{
  [DispId(8000)]
  Application Application { [DispId(8000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(8001)]
  int Creator { [DispId(8001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1)]
  object Parent { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(2)]
  int Count { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(-4)]
  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(0)]
  Shape this[[MarshalAs(UnmanagedType.Struct), In] ref object Index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(10)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddCallout([In] MsoCalloutType Type, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [DispId(11)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddConnector([In] MsoConnectorType Type, [In] float BeginX, [In] float BeginY, [In] float EndX, [In] float EndY);

  [DispId(12)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddCurve([MarshalAs(UnmanagedType.Struct), In] ref object SafeArrayOfPoints);

  [DispId(13)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddLabel(
    [In] MsoTextOrientation Orientation,
    [In] float Left,
    [In] float Top,
    [In] float Width,
    [In] float Height);

  [DispId(14)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddLine([In] float BeginX, [In] float BeginY, [In] float EndX, [In] float EndY);

  [DispId(15)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddPicture(
    [MarshalAs(UnmanagedType.BStr), In] string FileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LinkToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveWithDocument,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Left,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Top,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Width,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Height);

  [DispId(16 /*0x10*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddPolyline([MarshalAs(UnmanagedType.Struct), In] ref object SafeArrayOfPoints);

  [DispId(17)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddShape([In] int Type, [In] float Left, [In] float Top, [In] float Width, [In] float Height);

  [DispId(18)]
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

  [DispId(19)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Shape AddTextbox(
    [In] MsoTextOrientation Orientation,
    [In] float Left,
    [In] float Top,
    [In] float Width,
    [In] float Height);

  [DispId(20)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  FreeformBuilder BuildFreeform([In] MsoEditingType EditingType, [In] float X1, [In] float Y1);

  [DispId(21)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ShapeRange Range([MarshalAs(UnmanagedType.Struct), In] ref object Index);

  [DispId(22)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SelectAll();
}
