// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.CalloutFormat
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[Guid("000209C5-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
[ComImport]
public interface CalloutFormat
{
  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1)]
  object Parent { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(100)]
  MsoTriState Accent { [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(100), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(101)]
  MsoCalloutAngleType Angle { [DispId(101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(102)]
  MsoTriState AutoAttach { [DispId(102), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(102), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(103)]
  MsoTriState AutoLength { [DispId(103), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(104)]
  MsoTriState Border { [DispId(104), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(104), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(105)]
  float Drop { [DispId(105), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(106)]
  MsoCalloutDropType DropType { [DispId(106), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(107)]
  float Gap { [DispId(107), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(107), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(108)]
  float Length { [DispId(108), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(109)]
  MsoCalloutType Type { [DispId(109), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(109), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(10)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AutomaticLength();

  [DispId(11)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CustomDrop([In] float Drop);

  [DispId(12)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CustomLength([In] float Length);

  [DispId(13)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PresetDrop([In] MsoCalloutDropType DropType);
}
