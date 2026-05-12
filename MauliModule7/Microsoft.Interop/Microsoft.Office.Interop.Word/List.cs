// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.List
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[TypeLibType(4288)]
[Guid("00020992-0000-0000-C000-000000000046")]
[ComImport]
public interface List
{
  [DispId(1)]
  Range Range { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2)]
  ListParagraphs ListParagraphs { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(3)]
  bool SingleListTemplate { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(101)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ConvertNumbersToText([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType);

  [DispId(102)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveNumbers([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType);

  [DispId(103)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int CountNumberedItems([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumberType, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Level);

  [DispId(104)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyListTemplateOld([MarshalAs(UnmanagedType.Interface), In] ListTemplate ListTemplate, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ContinuePreviousList);

  [DispId(105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  WdContinue CanContinuePreviousList([MarshalAs(UnmanagedType.Interface), In] ListTemplate ListTemplate);

  [DispId(106)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyListTemplate(
    [MarshalAs(UnmanagedType.Interface), In] ListTemplate ListTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ContinuePreviousList,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultListBehavior);

  [DispId(4)]
  string StyleName { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(107)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyListTemplateWithLevel(
    [MarshalAs(UnmanagedType.Interface), In] ListTemplate ListTemplate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ContinuePreviousList,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultListBehavior,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ApplyLevel);
}
