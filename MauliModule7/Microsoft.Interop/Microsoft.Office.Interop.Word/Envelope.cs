// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.Envelope
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word;

[DefaultMember("DefaultSize")]
[Guid("00020918-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
[ComImport]
public interface Envelope
{
  [DispId(1000)]
  Application Application { [DispId(1000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1001)]
  int Creator { [DispId(1001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1002)]
  object Parent { [DispId(1002), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1)]
  Range Address { [DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2)]
  Range ReturnAddress { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(4)]
  bool DefaultPrintBarCode { [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(4), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(5)]
  bool DefaultPrintFIMA { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(6)]
  float DefaultHeight { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(7)]
  float DefaultWidth { [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(7), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(0)]
  string DefaultSize { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(9)]
  bool DefaultOmitReturnAddress { [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(9), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(12)]
  WdPaperTray FeedSource { [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(12), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(13)]
  float AddressFromLeft { [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(13), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(14)]
  float AddressFromTop { [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(14), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(15)]
  float ReturnAddressFromLeft { [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(15), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(16 /*0x10*/)]
  float ReturnAddressFromTop { [DispId(16 /*0x10*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(16 /*0x10*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(17)]
  Style AddressStyle { [DispId(17), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(18)]
  Style ReturnAddressStyle { [DispId(18), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(19)]
  WdEnvelopeOrientation DefaultOrientation { [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(19), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(20)]
  bool DefaultFaceUp { [DispId(20), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(20), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(101)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Insert2000(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExtractAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OmitReturnAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintBarCode,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintFIMA,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Size,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Height,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Width,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FeedSource,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddressFromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddressFromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddressFromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddressFromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultFaceUp,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultOrientation);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(102)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOut2000(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExtractAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OmitReturnAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintBarCode,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintFIMA,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Size,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Height,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Width,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FeedSource,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddressFromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddressFromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddressFromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddressFromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultFaceUp,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultOrientation);

  [DispId(103)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void UpdateDocument();

  [DispId(104)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Options();

  [DispId(22)]
  bool Vertical { [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(23)]
  float RecipientNamefromLeft { [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(23), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(24)]
  float RecipientNamefromTop { [DispId(24), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(24), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(25)]
  float RecipientPostalfromLeft { [DispId(25), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(25), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(26)]
  float RecipientPostalfromTop { [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(26), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(27)]
  float SenderNamefromLeft { [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(27), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(28)]
  float SenderNamefromTop { [DispId(28), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(28), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(29)]
  float SenderPostalfromLeft { [DispId(29), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(29), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(30)]
  float SenderPostalfromTop { [DispId(30), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(30), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(105)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Insert(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExtractAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OmitReturnAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintBarCode,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintFIMA,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Size,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Height,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Width,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FeedSource,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddressFromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddressFromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddressFromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddressFromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultFaceUp,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultOrientation,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintEPostage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Vertical,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RecipientNamefromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RecipientNamefromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RecipientPostalfromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RecipientPostalfromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderNamefromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderNamefromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderPostalfromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderPostalfromTop);

  [DispId(106)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ExtractAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OmitReturnAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAutoText,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintBarCode,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintFIMA,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Size,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Height,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Width,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FeedSource,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddressFromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddressFromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddressFromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReturnAddressFromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultFaceUp,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DefaultOrientation,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintEPostage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Vertical,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RecipientNamefromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RecipientNamefromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RecipientPostalfromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RecipientPostalfromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderNamefromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderNamefromTop,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderPostalfromLeft,
    [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SenderPostalfromTop);
}
