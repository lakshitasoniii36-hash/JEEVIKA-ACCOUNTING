// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.ListFormat
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[TypeLibType(4288)]
[Guid("000209C0-0000-0000-C000-000000000046")]
[ComImport]
public interface ListFormat
{
  [DispId(68)]
  int ListLevelNumber { [DispId(68), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(68), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(69)]
  List List { [DispId(69), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(70)]
  ListTemplate ListTemplate { [DispId(70), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(71)]
  int ListValue { [DispId(71), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(72)]
  bool SingleList { [DispId(72), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(73)]
  bool SingleListTemplate { [DispId(73), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(74)]
  WdListType ListType { [DispId(74), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(75)]
  string ListString { [DispId(75), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(184)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  WdContinue CanContinuePreviousList([MarshalAs(UnmanagedType.Interface), In] ListTemplate ListTemplate);

  [DispId(185)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveNumbers([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType);

  [DispId(186)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ConvertNumbersToText([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType);

  [DispId(187)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int CountNumberedItems([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Level);

  [DispId(188)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyBulletDefaultOld();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(189)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyNumberDefaultOld();

  [DispId(190)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyOutlineNumberDefaultOld();

  [DispId(191)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyListTemplateOld(
    [MarshalAs(UnmanagedType.Interface), In] ListTemplate ListTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ContinuePreviousList,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyTo);

  [DispId(210)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ListOutdent();

  [DispId(211)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ListIndent();

  [DispId(212)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyBulletDefault([MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultListBehavior);

  [DispId(213)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyNumberDefault([MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultListBehavior);

  [DispId(214)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyOutlineNumberDefault([MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultListBehavior);

  [DispId(215)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyListTemplate(
    [MarshalAs(UnmanagedType.Interface), In] ListTemplate ListTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ContinuePreviousList,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyTo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultListBehavior);

  [DispId(76)]
  InlineShape ListPictureBullet { [DispId(76), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(216)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyListTemplateWithLevel(
    [MarshalAs(UnmanagedType.Interface), In] ListTemplate ListTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ContinuePreviousList,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyTo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultListBehavior,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyLevel);
}
