// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IDialogSheet
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(4112)]
[Guid("000208AF-0001-0000-C000-000000000046")]
[ComImport]
public interface IDialogSheet
{
  [DispId(148)]
  Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Activate();

  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Copy([MarshalAs(UnmanagedType.Struct), In, Optional] object Before, [MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Delete();

  [DispId(1373)]
  string CodeName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(-2147418112 /*0x80010000*/)]
  string _CodeName { [TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(486)]
  int Index { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Move([MarshalAs(UnmanagedType.Struct), In, Optional] object Before, [MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [DispId(110)]
  string Name { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(502)]
  object Next { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(628)]
  string OnDoubleClick { [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1031)]
  string OnSheetActivate { [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1081)]
  string OnSheetDeactivate { [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(998)]
  PageSetup PageSetup { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(503)]
  object Previous { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [LCIDConversion(7)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate);

  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintPreview([MarshalAs(UnmanagedType.Struct), In, Optional] object EnableChanges);

  [LCIDConversion(5)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Protect(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DrawingObjects,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Contents,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Scenarios,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UserInterfaceOnly);

  [DispId(292)]
  bool ProtectContents { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(293)]
  bool ProtectDrawingObjects { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1159)]
  bool ProtectionMode { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(294)]
  bool ProtectScenarios { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [LCIDConversion(9)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _SaveAs(
    [MarshalAs(UnmanagedType.BStr), In] string Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AddToMru,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextCodepage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout);

  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Select([MarshalAs(UnmanagedType.Struct), In, Optional] object Replace);

  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Unprotect([MarshalAs(UnmanagedType.Struct), In, Optional] object Password);

  [DispId(558)]
  XlSheetVisibility Visible { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1377)]
  Shapes Shapes { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy29();

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Arcs([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy31();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy32();

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Buttons([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy34();

  [DispId(1424)]
  bool EnableCalculation { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy36();

  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ChartObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object CheckBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckSpelling(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CustomDictionary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreUppercase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AlwaysSuggest,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SpellLang);

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy40();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy41();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy42();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy43();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy44();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy45();

  [DispId(643)]
  bool DisplayAutomaticPageBreaks { [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Drawings([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object DrawingObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object DropDowns([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(1156)]
  bool EnableAutoFilter { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1425)]
  XlEnableSelection EnableSelection { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1157)]
  bool EnableOutlining { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1158)]
  bool EnablePivotTable { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object Evaluate([MarshalAs(UnmanagedType.Struct), In] object Name);

  [LCIDConversion(1)]
  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object _Evaluate([MarshalAs(UnmanagedType.Struct), In] object Name);

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy56();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ResetAllPageBreaks();

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object GroupBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object GroupObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Labels([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Lines([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ListBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(442)]
  Names Names { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object OLEObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy65();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy66();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy67();

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object OptionButtons([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy69();

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Ovals([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Paste([MarshalAs(UnmanagedType.Struct), In, Optional] object Destination, [MarshalAs(UnmanagedType.Struct), In, Optional] object Link);

  [TypeLibFunc(1088)]
  [LCIDConversion(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _PasteSpecial(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Link,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DisplayAsIcon,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconFileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconIndex,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconLabel);

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Pictures([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy74();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy75();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy76();

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Rectangles([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy78();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy79();

  [DispId(1433)]
  string ScrollArea { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object ScrollBars([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy82();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy83();

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object Spinners([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy85();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy86();

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object TextBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy88();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy89();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy90();

  [DispId(1418)]
  HPageBreaks HPageBreaks { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1419)]
  VPageBreaks VPageBreaks { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1434)]
  QueryTables QueryTables { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1435)]
  bool DisplayPageBreaks { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(575)]
  Comments Comments { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1393)]
  Hyperlinks Hyperlinks { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearCircles();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CircleInvalid();

  [DispId(648)]
  int _DisplayRightToLeft { [TypeLibFunc(1088), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), TypeLibFunc(1088), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(793)]
  AutoFilter AutoFilter { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1774)]
  bool DisplayRightToLeft { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1816)]
  Scripts Scripts { [TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(8)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrToFileName);

  [TypeLibFunc(1088)]
  [LCIDConversion(6)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _CheckSpelling(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CustomDictionary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreUppercase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AlwaysSuggest,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SpellLang,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreFinalYaa,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SpellScript);

  [DispId(1041)]
  Tab Tab { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2021)]
  MsoEnvelope MailEnvelope { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SaveAs(
    [MarshalAs(UnmanagedType.BStr), In] string Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AddToMru,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextCodepage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Local);

  [DispId(2030)]
  CustomProperties CustomProperties { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2016)]
  SmartTags SmartTags { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(176 /*0xB0*/)]
  Protection Protection { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(7)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PasteSpecial(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Link,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DisplayAsIcon,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconFileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconIndex,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconLabel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object NoHTMLFormatting);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Protect(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DrawingObjects,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Contents,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Scenarios,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UserInterfaceOnly,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AllowFormattingCells,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AllowFormattingColumns,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AllowFormattingRows,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AllowInsertingColumns,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AllowInsertingRows,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AllowInsertingHyperlinks,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AllowDeletingColumns,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AllowDeletingRows,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AllowSorting,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AllowFiltering,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AllowUsingPivotTables);

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy113();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy114();

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy115();

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOutEx(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrToFileName);

  [DispId(2511)]
  bool EnableFormatConditionsCalculation { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(880)]
  Sort Sort { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ExportAsFixedFormat(
    [In] XlFixedFormatType Type,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Quality,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IncludeDocProperties,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnorePrintAreas,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OpenAfterPublish,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FixedFormatExtClassPtr);

  [DispId(857)]
  object DefaultButton { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(839)]
  DialogFrame DialogFrame { [TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  object EditBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(814)]
  object Focus { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Hide([MarshalAs(UnmanagedType.Struct), In, Optional] object Cancel);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Show();
}
