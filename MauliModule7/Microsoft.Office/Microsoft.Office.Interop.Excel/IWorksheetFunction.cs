// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IWorksheetFunction
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[Guid("00020845-0001-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface IWorksheetFunction
{
  [DispId(148)]
  Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _WSFunction(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Count(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsNA([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsError([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Sum(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Average(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Min(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Max(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Npv(
    [In] double Arg1,
    [MarshalAs(UnmanagedType.Struct), In] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double StDev(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Dollar([In] double Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Fixed([In] double Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Pi();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ln([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Log10([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Round([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Lookup([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Index([MarshalAs(UnmanagedType.Struct), In] object Arg1, [In] double Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Rept([MarshalAs(UnmanagedType.BStr), In] string Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool And(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Or(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DCount([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DSum([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DAverage([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DMin([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DMax([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DStDev([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Var(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DVar([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Text([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.BStr), In] string Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object LinEst([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Trend([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object LogEst([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Growth([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Pv([In] double Arg1, [In] double Arg2, [In] double Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Fv([In] double Arg1, [In] double Arg2, [In] double Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NPer([In] double Arg1, [In] double Arg2, [In] double Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Pmt([In] double Arg1, [In] double Arg2, [In] double Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Rate([In] double Arg1, [In] double Arg2, [In] double Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double MIrr([MarshalAs(UnmanagedType.Struct), In] object Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Irr([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Match([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Weekday([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Search([MarshalAs(UnmanagedType.BStr), In] string Arg1, [MarshalAs(UnmanagedType.BStr), In] string Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Transpose([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Atan2([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Asin([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Acos([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Choose(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object HLookup([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object VLookup([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Log([In] double Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Proper([MarshalAs(UnmanagedType.BStr), In] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Trim([MarshalAs(UnmanagedType.BStr), In] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Replace([MarshalAs(UnmanagedType.BStr), In] string Arg1, [In] double Arg2, [In] double Arg3, [MarshalAs(UnmanagedType.BStr), In] string Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Substitute([MarshalAs(UnmanagedType.BStr), In] string Arg1, [MarshalAs(UnmanagedType.BStr), In] string Arg2, [MarshalAs(UnmanagedType.BStr), In] string Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Find([MarshalAs(UnmanagedType.BStr), In] string Arg1, [MarshalAs(UnmanagedType.BStr), In] string Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsErr([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsText([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsNumber([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Sln([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Syd([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ddb([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Clean([MarshalAs(UnmanagedType.BStr), In] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double MDeterm([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object MInverse([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object MMult([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ipmt([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ppmt([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CountA(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Product(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Fact([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DProduct([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsNonText([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double StDevP(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double VarP(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DStDevP([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DVarP([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsLogical([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DCountA([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string USDollar([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FindB([MarshalAs(UnmanagedType.BStr), In] string Arg1, [MarshalAs(UnmanagedType.BStr), In] string Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SearchB([MarshalAs(UnmanagedType.BStr), In] string Arg1, [MarshalAs(UnmanagedType.BStr), In] string Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ReplaceB([MarshalAs(UnmanagedType.BStr), In] string Arg1, [In] double Arg2, [In] double Arg3, [MarshalAs(UnmanagedType.BStr), In] string Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double RoundUp([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double RoundDown([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Rank([In] double Arg1, [MarshalAs(UnmanagedType.Interface), In] Range Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Days360([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Vdb(
    [In] double Arg1,
    [In] double Arg2,
    [In] double Arg3,
    [In] double Arg4,
    [In] double Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Median(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumProduct(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Sinh([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Cosh([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Tanh([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Asinh([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Acosh([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Atanh([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object DGet([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Db([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Frequency([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AveDev(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BetaDist([In] double Arg1, [In] double Arg2, [In] double Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double GammaLn([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BetaInv([In] double Arg1, [In] double Arg2, [In] double Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BinomDist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ChiDist([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ChiInv([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Combin([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Confidence([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CritBinom([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Even([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ExponDist([In] double Arg1, [In] double Arg2, [In] bool Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FDist([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FInv([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Fisher([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FisherInv([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Floor([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double GammaDist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double GammaInv([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ceiling([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double HypGeomDist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double LogNormDist([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double LogInv([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NegBinomDist([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NormDist([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NormSDist([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NormInv([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NormSInv([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Standardize([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Odd([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Permut([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Poisson([In] double Arg1, [In] double Arg2, [In] bool Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TDist([In] double Arg1, [In] double Arg2, [In] double Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Weibull([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] bool Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumXMY2([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumX2MY2([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumX2PY2([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ChiTest([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Correl([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Covar([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Forecast([In] double Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FTest([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Intercept([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Pearson([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double RSq([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double StEyx([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Slope([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TTest([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [In] double Arg3, [In] double Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Prob([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [In] double Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DevSq(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double GeoMean(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double HarMean(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumSq(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Kurt(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Skew(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ZTest([MarshalAs(UnmanagedType.Struct), In] object Arg1, [In] double Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Large([MarshalAs(UnmanagedType.Struct), In] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Small([MarshalAs(UnmanagedType.Struct), In] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Quartile([MarshalAs(UnmanagedType.Struct), In] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Percentile([MarshalAs(UnmanagedType.Struct), In] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double PercentRank([MarshalAs(UnmanagedType.Struct), In] object Arg1, [In] double Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Mode(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TrimMean([MarshalAs(UnmanagedType.Struct), In] object Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TInv([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Power([In] double Arg1, [In] double Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Radians([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Degrees([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Subtotal(
    [In] double Arg1,
    [MarshalAs(UnmanagedType.Interface), In] Range Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumIf([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CountIf([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CountBlank([MarshalAs(UnmanagedType.Interface), In] Range Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Ispmt([In] double Arg1, [In] double Arg2, [In] double Arg3, [In] double Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Roman([In] double Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Asc([MarshalAs(UnmanagedType.BStr), In] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Dbcs([MarshalAs(UnmanagedType.BStr), In] string Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Phonetic([MarshalAs(UnmanagedType.Interface), In] Range Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string BahtText([In] double Arg1);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ThaiDayOfWeek([In] double Arg1);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ThaiDigit([MarshalAs(UnmanagedType.BStr), In] string Arg1);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ThaiMonthOfYear([In] double Arg1);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ThaiNumSound([In] double Arg1);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ThaiNumString([In] double Arg1);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ThaiStringLength([MarshalAs(UnmanagedType.BStr), In] string Arg1);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsThaiDigit([MarshalAs(UnmanagedType.BStr), In] string Arg1);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double RoundBahtDown([In] double Arg1);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double RoundBahtUp([In] double Arg1);

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ThaiYear([In] double Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object RTD(
    [MarshalAs(UnmanagedType.Struct), In] object progID,
    [MarshalAs(UnmanagedType.Struct), In] object server,
    [MarshalAs(UnmanagedType.Struct), In] object topic1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object topic28);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Hex2Bin([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Hex2Dec([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Hex2Oct([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Dec2Bin([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Dec2Hex([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Dec2Oct([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Oct2Bin([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Oct2Hex([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Oct2Dec([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Bin2Dec([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Bin2Oct([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Bin2Hex([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImSub([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImDiv([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImPower([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImAbs([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImSqrt([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImLn([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImLog2([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImLog10([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImSin([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImCos([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImExp([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImArgument([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImConjugate([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Imaginary([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ImReal([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string Complex([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImSum(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string ImProduct(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SeriesSum([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FactDouble([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SqrtPi([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Quotient([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Delta([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double GeStep([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsEven([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool IsOdd([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double MRound([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Erf([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double ErfC([MarshalAs(UnmanagedType.Struct), In] object Arg1);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BesselJ([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BesselK([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BesselY([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double BesselI([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Xirr([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Xnpv([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double PriceMat([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In] object Arg4, [MarshalAs(UnmanagedType.Struct), In] object Arg5, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double YieldMat([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In] object Arg4, [MarshalAs(UnmanagedType.Struct), In] object Arg5, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double IntRate([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In] object Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Received([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In] object Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Disc([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In] object Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double PriceDisc([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In] object Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double YieldDisc([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In] object Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TBillEq([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TBillPrice([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double TBillYield([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Price(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DollarDe([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double DollarFr([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Nominal([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Effect([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CumPrinc([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In] object Arg4, [MarshalAs(UnmanagedType.Struct), In] object Arg5, [MarshalAs(UnmanagedType.Struct), In] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CumIPmt([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In] object Arg4, [MarshalAs(UnmanagedType.Struct), In] object Arg5, [MarshalAs(UnmanagedType.Struct), In] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double EDate([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double EoMonth([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double YearFrac([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CoupDayBs([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CoupDays([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CoupDaysNc([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CoupNcd([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CoupNum([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CoupPcd([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Duration([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In] object Arg4, [MarshalAs(UnmanagedType.Struct), In] object Arg5, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double MDuration([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In] object Arg4, [MarshalAs(UnmanagedType.Struct), In] object Arg5, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double OddLPrice(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double OddLYield(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double OddFPrice(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double OddFYield(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double RandBetween([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double WeekNum([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AmorDegrc(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AmorLinc(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Convert([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AccrInt(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AccrIntM([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In] object Arg3, [MarshalAs(UnmanagedType.Struct), In] object Arg4, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double WorkDay([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double NetworkDays([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Gcd(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double MultiNomial(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double Lcm(
    [MarshalAs(UnmanagedType.Struct), In] object Arg1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double FVSchedule([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double SumIfs(
    [MarshalAs(UnmanagedType.Interface), In] Range Arg1,
    [MarshalAs(UnmanagedType.Interface), In] Range Arg2,
    [MarshalAs(UnmanagedType.Struct), In] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double CountIfs(
    [MarshalAs(UnmanagedType.Interface), In] Range Arg1,
    [MarshalAs(UnmanagedType.Struct), In] object Arg2,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg30);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AverageIf([MarshalAs(UnmanagedType.Interface), In] Range Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2, [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg3);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  double AverageIfs(
    [MarshalAs(UnmanagedType.Interface), In] Range Arg1,
    [MarshalAs(UnmanagedType.Interface), In] Range Arg2,
    [MarshalAs(UnmanagedType.Struct), In] object Arg3,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg4,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg5,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg6,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg7,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg8,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg9,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg10,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg11,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg12,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg13,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg14,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg15,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg16,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg17,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg18,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg19,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg20,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg21,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg22,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg23,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg24,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg25,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg26,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg27,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg28,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Arg29);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object IfError([MarshalAs(UnmanagedType.Struct), In] object Arg1, [MarshalAs(UnmanagedType.Struct), In] object Arg2);
}
