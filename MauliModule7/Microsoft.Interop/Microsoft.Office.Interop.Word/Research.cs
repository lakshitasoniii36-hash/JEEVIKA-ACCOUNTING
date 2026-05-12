// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.Research
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[Guid("E6AAEC05-E543-4085-BA92-9BF7D2474F51")]
[TypeLibType(4288)]
[ComImport]
public interface Research
{
  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(500)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Query(
    [MarshalAs(UnmanagedType.BStr), In] string ServiceID,
    [MarshalAs(UnmanagedType.BStr), In] string QueryString = "",
    [In] WdLanguageID QueryLanguage = WdLanguageID.wdLanguageNone,
    [In] bool UseSelection = false,
    [In] bool LaunchQuery = true);

  [DispId(501)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object SetLanguagePair([In] WdLanguageID LanguageFrom, [In] WdLanguageID LanguageTo);

  [DispId(502)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsResearchService([MarshalAs(UnmanagedType.BStr), In] string ServiceID);
}
