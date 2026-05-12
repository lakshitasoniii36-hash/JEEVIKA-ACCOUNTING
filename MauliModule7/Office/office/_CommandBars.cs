// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core._CommandBars
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using stdole;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Core;

[Guid("000C0302-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
[ComImport]
public interface _CommandBars : _IMsoDispObj, IEnumerable
{
  [DispId(1610743808 /*0x60020000*/)]
  new object Application { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  new int Creator { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809344 /*0x60030000*/)]
  CommandBarControl ActionControl { [DispId(1610809344 /*0x60030000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809345 /*0x60030001*/)]
  CommandBar ActiveMenuBar { [DispId(1610809345 /*0x60030001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809346 /*0x60030002*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CommandBar Add([MarshalAs(UnmanagedType.Struct), In, Optional] object Name, [MarshalAs(UnmanagedType.Struct), In, Optional] object Position, [MarshalAs(UnmanagedType.Struct), In, Optional] object MenuBar, [MarshalAs(UnmanagedType.Struct), In, Optional] object Temporary);

  [DispId(1610809347 /*0x60030003*/)]
  int Count { [DispId(1610809347 /*0x60030003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809348 /*0x60030004*/)]
  bool DisplayTooltips { [DispId(1610809348 /*0x60030004*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809348 /*0x60030004*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809350 /*0x60030006*/)]
  bool DisplayKeysInTooltips { [DispId(1610809350 /*0x60030006*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809350 /*0x60030006*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809352 /*0x60030008*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CommandBarControl FindControl([MarshalAs(UnmanagedType.Struct), In, Optional] object Type, [MarshalAs(UnmanagedType.Struct), In, Optional] object Id, [MarshalAs(UnmanagedType.Struct), In, Optional] object Tag, [MarshalAs(UnmanagedType.Struct), In, Optional] object Visible);

  [DispId(0)]
  CommandBar this[[MarshalAs(UnmanagedType.Struct), In] object Index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809354 /*0x6003000A*/)]
  bool LargeButtons { [DispId(1610809354 /*0x6003000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809354 /*0x6003000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809356 /*0x6003000C*/)]
  MsoMenuAnimation MenuAnimationStyle { [DispId(1610809356 /*0x6003000C*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809356 /*0x6003000C*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(1024 /*0x0400*/)]
  [DispId(-4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(1610809359 /*0x6003000F*/)]
  object Parent { [DispId(1610809359 /*0x6003000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809360 /*0x60030010*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ReleaseFocus();

  [DispId(1610809361)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int get_IdsString([In] int ids, [MarshalAs(UnmanagedType.BStr)] out string pbstrName);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610809362)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int get_TmcGetName([In] int tmc, [MarshalAs(UnmanagedType.BStr)] out string pbstrName);

  [DispId(1610809363)]
  bool AdaptiveMenus { [DispId(1610809363), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809363), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809365)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CommandBarControls FindControls([MarshalAs(UnmanagedType.Struct), In, Optional] object Type, [MarshalAs(UnmanagedType.Struct), In, Optional] object Id, [MarshalAs(UnmanagedType.Struct), In, Optional] object Tag, [MarshalAs(UnmanagedType.Struct), In, Optional] object Visible);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610809366)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CommandBar AddEx(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TbidOrName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Position,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MenuBar,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Temporary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TbtrProtection);

  [DispId(1610809367)]
  bool DisplayFonts { [DispId(1610809367), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809367), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809369)]
  bool DisableCustomize { [DispId(1610809369), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809369), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809371)]
  bool DisableAskAQuestionDropdown { [DispId(1610809371), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809371), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809373)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ExecuteMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809374)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool GetEnabledMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809375)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool GetVisibleMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809376 /*0x60030020*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool GetPressedMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809377)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetLabelMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809378)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetScreentipMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809379)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string GetSupertipMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809380)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: ComAliasName("stdole.IPictureDisp")]
  [return: MarshalAs(UnmanagedType.Interface)]
  IPictureDisp GetImageMso([MarshalAs(UnmanagedType.BStr), In] string idMso, [In] int Width, [In] int Height);
}
