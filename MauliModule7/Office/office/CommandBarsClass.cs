// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.CommandBarsClass
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

[ComSourceInterfaces("Microsoft.Office.Core._CommandBarsEvents\0\0")]
[Guid("55F88893-7708-11D1-ACEB-006008961DA5")]
[ClassInterface(0)]
[ComImport]
public class CommandBarsClass : _CommandBars, CommandBars, _CommandBarsEvents_Event, IEnumerable
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  internal extern CommandBarsClass();

  [DispId(1610743808 /*0x60020000*/)]
  public virtual extern object Application { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  public virtual extern int Creator { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809344 /*0x60030000*/)]
  public virtual extern CommandBarControl ActionControl { [DispId(1610809344 /*0x60030000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809345 /*0x60030001*/)]
  public virtual extern CommandBar ActiveMenuBar { [DispId(1610809345 /*0x60030001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809346 /*0x60030002*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CommandBar Add(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Position,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MenuBar,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Temporary);

  [DispId(1610809347 /*0x60030003*/)]
  public virtual extern int Count { [DispId(1610809347 /*0x60030003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610809348 /*0x60030004*/)]
  public virtual extern bool DisplayTooltips { [DispId(1610809348 /*0x60030004*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809348 /*0x60030004*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809350 /*0x60030006*/)]
  public virtual extern bool DisplayKeysInTooltips { [DispId(1610809350 /*0x60030006*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809350 /*0x60030006*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809352 /*0x60030008*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CommandBarControl FindControl(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Type,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Id,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Tag,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Visible);

  [DispId(0)]
  public virtual extern CommandBar this[[MarshalAs(UnmanagedType.Struct), In] object Index] { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610809354 /*0x6003000A*/)]
  public virtual extern bool LargeButtons { [DispId(1610809354 /*0x6003000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809354 /*0x6003000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809356 /*0x6003000C*/)]
  public virtual extern MsoMenuAnimation MenuAnimationStyle { [DispId(1610809356 /*0x6003000C*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809356 /*0x6003000C*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(1024 /*0x0400*/)]
  [DispId(-4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  public virtual extern IEnumerator GetEnumerator();

  [DispId(1610809359 /*0x6003000F*/)]
  public virtual extern object Parent { [DispId(1610809359 /*0x6003000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809360 /*0x60030010*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ReleaseFocus();

  [DispId(1610809361)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int get_IdsString([In] int ids, [MarshalAs(UnmanagedType.BStr)] out string pbstrName);

  [DispId(1610809362)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int get_TmcGetName([In] int tmc, [MarshalAs(UnmanagedType.BStr)] out string pbstrName);

  [DispId(1610809363)]
  public virtual extern bool AdaptiveMenus { [DispId(1610809363), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809363), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809365)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CommandBarControls FindControls(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Type,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Id,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Tag,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Visible);

  [DispId(1610809366)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CommandBar AddEx(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TbidOrName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Position,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MenuBar,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Temporary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TbtrProtection);

  [DispId(1610809367)]
  public virtual extern bool DisplayFonts { [DispId(1610809367), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809367), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809369)]
  public virtual extern bool DisableCustomize { [DispId(1610809369), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809369), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809371)]
  public virtual extern bool DisableAskAQuestionDropdown { [DispId(1610809371), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610809371), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610809373)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ExecuteMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809374)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool GetEnabledMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809375)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool GetVisibleMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809376 /*0x60030020*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool GetPressedMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809377)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string GetLabelMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809378)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string GetScreentipMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809379)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string GetSupertipMso([MarshalAs(UnmanagedType.BStr), In] string idMso);

  [DispId(1610809380)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: ComAliasName("stdole.IPictureDisp")]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern IPictureDisp GetImageMso([MarshalAs(UnmanagedType.BStr), In] string idMso, [In] int Width, [In] int Height);

  public virtual extern event _CommandBarsEvents_OnUpdateEventHandler OnUpdate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_OnUpdate([In] _CommandBarsEvents_OnUpdateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_OnUpdate([In] _CommandBarsEvents_OnUpdateEventHandler obj0);
}
