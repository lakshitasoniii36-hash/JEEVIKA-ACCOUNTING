// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.Speech
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(4096 /*0x1000*/)]
[Guid("00024466-0000-0000-C000-000000000046")]
[InterfaceType(2)]
[ComImport]
public interface Speech
{
  [DispId(2017)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Speak([MarshalAs(UnmanagedType.BStr), In] string Text, [MarshalAs(UnmanagedType.Struct), In, Optional] object SpeakAsync, [MarshalAs(UnmanagedType.Struct), In, Optional] object SpeakXML, [MarshalAs(UnmanagedType.Struct), In, Optional] object Purge);

  [DispId(168)]
  XlSpeakDirection Direction { [DispId(168), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(168), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2235)]
  bool SpeakCellOnEnter { [DispId(2235), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2235), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
}
