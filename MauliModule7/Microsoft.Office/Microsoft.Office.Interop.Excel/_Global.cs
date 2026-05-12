// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel._Global
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[Guid("000208D9-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
[ComImport]
public interface _Global
{
  [DispId(148)]
  Application Application { [DispId(148), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [DispId(149), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  Application Parent { [DispId(150), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(305)]
  Range ActiveCell { [DispId(305), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(183)]
  Chart ActiveChart { [DispId(183), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(815)]
  DialogSheet ActiveDialog { [DispId(815), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(758)]
  MenuBar ActiveMenuBar { [TypeLibFunc(64 /*0x40*/), DispId(758), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(306)]
  string ActivePrinter { [LCIDConversion(0), DispId(306), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [LCIDConversion(0), DispId(306), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(307)]
  object ActiveSheet { [DispId(307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(759)]
  Window ActiveWindow { [DispId(759), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(308)]
  Workbook ActiveWorkbook { [DispId(308), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(549)]
  AddIns AddIns { [TypeLibFunc(1024 /*0x0400*/), DispId(549), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1438)]
  Assistant Assistant { [DispId(1438), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(279)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Calculate();

  [DispId(238)]
  Range Cells { [DispId(238), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(121)]
  Sheets Charts { [DispId(121), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(241)]
  Range Columns { [TypeLibFunc(1024 /*0x0400*/), DispId(241), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1439)]
  CommandBars CommandBars { [DispId(1439), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(332)]
  int DDEAppReturnCode { [LCIDConversion(0), DispId(332), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(333)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DDEExecute([In] int Channel, [MarshalAs(UnmanagedType.BStr), In] string String);

  [LCIDConversion(2)]
  [DispId(334)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int DDEInitiate([MarshalAs(UnmanagedType.BStr), In] string App, [MarshalAs(UnmanagedType.BStr), In] string Topic);

  [DispId(335)]
  [LCIDConversion(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DDEPoke([In] int Channel, [MarshalAs(UnmanagedType.Struct), In] object Item, [MarshalAs(UnmanagedType.Struct), In] object Data);

  [DispId(336)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object DDERequest([In] int Channel, [MarshalAs(UnmanagedType.BStr), In] string Item);

  [DispId(337)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DDETerminate([In] int Channel);

  [DispId(764)]
  Sheets DialogSheets { [TypeLibFunc(64 /*0x40*/), DispId(764), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(1)]
  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Evaluate([MarshalAs(UnmanagedType.Struct), In] object Name);

  [DispId(-5)]
  [LCIDConversion(1)]
  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _Evaluate([MarshalAs(UnmanagedType.Struct), In] object Name);

  [DispId(350)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object ExecuteExcel4Macro([MarshalAs(UnmanagedType.BStr), In] string String);

  [DispId(766)]
  [LCIDConversion(30)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range Intersect(
    [MarshalAs(UnmanagedType.Interface), In] Range Arg1,
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

  [DispId(589)]
  MenuBars MenuBars { [DispId(589), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(582)]
  Modules Modules { [TypeLibFunc(64 /*0x40*/), DispId(582), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(442)]
  Names Names { [DispId(442), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(197)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range get_Range([MarshalAs(UnmanagedType.Struct), In] object Cell1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Cell2);

  [DispId(258)]
  Range Rows { [TypeLibFunc(1024 /*0x0400*/), DispId(258), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(259)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Run(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Macro,
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

  [DispId(806)]
  [LCIDConversion(31 /*0x1F*/)]
  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _Run2(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Macro,
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

  [DispId(147)]
  object Selection { [LCIDConversion(0), DispId(147), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(383)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SendKeys([MarshalAs(UnmanagedType.Struct), In] object Keys, [MarshalAs(UnmanagedType.Struct), In, Optional] object Wait);

  [DispId(485)]
  Sheets Sheets { [DispId(485), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(776)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Menu get_ShortcutMenus([In] int Index);

  [DispId(778)]
  Workbook ThisWorkbook { [LCIDConversion(0), DispId(778), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(552)]
  Toolbars Toolbars { [DispId(552), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(779)]
  [LCIDConversion(30)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Range Union(
    [MarshalAs(UnmanagedType.Interface), In] Range Arg1,
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

  [DispId(430)]
  Windows Windows { [DispId(430), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(572)]
  Workbooks Workbooks { [DispId(572), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1440)]
  WorksheetFunction WorksheetFunction { [DispId(1440), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(494)]
  Sheets Worksheets { [DispId(494), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(581)]
  Sheets Excel4IntlMacroSheets { [DispId(581), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(579)]
  Sheets Excel4MacroSheets { [DispId(579), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
}
