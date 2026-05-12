// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.WorksheetClass
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(2)]
[ClassInterface(0)]
[ComSourceInterfaces("Microsoft.Office.Interop.Excel.DocEvents\0\0")]
[Guid("00020820-0000-0000-C000-000000000046")]
[ComImport]
public class WorksheetClass : _Worksheet, Worksheet, DocEvents_Event
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern WorksheetClass();

  [DispId(148)]
  public virtual extern Application Application { [DispId(148), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  public virtual extern XlCreator Creator { [DispId(149), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  public virtual extern object Parent { [DispId(150), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(304)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Activate();

  [DispId(551)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Copy([MarshalAs(UnmanagedType.Struct), In, Optional] object Before, [MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [DispId(117)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Delete();

  [DispId(1373)]
  public virtual extern string CodeName { [DispId(1373), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(-2147418112 /*0x80010000*/)]
  public virtual extern string _CodeName { [TypeLibFunc(1024 /*0x0400*/), DispId(-2147418112 /*0x80010000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(-2147418112 /*0x80010000*/), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(486)]
  public virtual extern int Index { [LCIDConversion(0), DispId(486), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [LCIDConversion(2)]
  [DispId(637)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Move([MarshalAs(UnmanagedType.Struct), In, Optional] object Before, [MarshalAs(UnmanagedType.Struct), In, Optional] object After);

  [DispId(110)]
  public virtual extern string Name { [DispId(110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(502)]
  public virtual extern object Next { [DispId(502), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(628)]
  public virtual extern string OnDoubleClick { [DispId(628), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), DispId(628), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1031)]
  public virtual extern string OnSheetActivate { [LCIDConversion(0), DispId(1031), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1031), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1081)]
  public virtual extern string OnSheetDeactivate { [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), DispId(1081), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [LCIDConversion(0), DispId(1081), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(998)]
  public virtual extern PageSetup PageSetup { [DispId(998), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(503)]
  public virtual extern object Previous { [DispId(503), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [TypeLibFunc(1088)]
  [DispId(905)]
  [LCIDConversion(7)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void _PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate);

  [DispId(281)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PrintPreview([MarshalAs(UnmanagedType.Struct), In, Optional] object EnableChanges);

  [DispId(282)]
  [LCIDConversion(5)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void _Protect(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DrawingObjects,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Contents,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Scenarios,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UserInterfaceOnly);

  [DispId(292)]
  public virtual extern bool ProtectContents { [LCIDConversion(0), DispId(292), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(293)]
  public virtual extern bool ProtectDrawingObjects { [DispId(293), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1159)]
  public virtual extern bool ProtectionMode { [DispId(1159), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(294)]
  public virtual extern bool ProtectScenarios { [LCIDConversion(0), DispId(294), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [LCIDConversion(9)]
  [TypeLibFunc(1088)]
  [DispId(284)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void _SaveAs(
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
  [DispId(235)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Select([MarshalAs(UnmanagedType.Struct), In, Optional] object Replace);

  [DispId(285)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Unprotect([MarshalAs(UnmanagedType.Struct), In, Optional] object Password);

  [DispId(558)]
  public virtual extern XlSheetVisibility Visible { [DispId(558), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(558), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1377)]
  public virtual extern Shapes Shapes { [DispId(1377), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(401)]
  public virtual extern bool TransitionExpEval { [LCIDConversion(0), TypeLibFunc(1024 /*0x0400*/), DispId(401), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(401), TypeLibFunc(1024 /*0x0400*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(760)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Arcs([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(792)]
  public virtual extern bool AutoFilterMode { [DispId(792), LCIDConversion(0), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(792), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1188)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetBackgroundPicture([MarshalAs(UnmanagedType.BStr), In] string Filename);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(557)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Buttons([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(279)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Calculate();

  [DispId(1424)]
  public virtual extern bool EnableCalculation { [DispId(1424), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1424), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(238)]
  public virtual extern Range Cells { [DispId(238), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1060)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object ChartObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(824)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object CheckBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(4)]
  [DispId(505)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CheckSpelling(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CustomDictionary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreUppercase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AlwaysSuggest,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SpellLang);

  [DispId(1069)]
  public virtual extern Range CircularReference { [LCIDConversion(0), DispId(1069), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(970)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ClearArrows();

  [DispId(241)]
  public virtual extern Range Columns { [DispId(241), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(789)]
  public virtual extern XlConsolidationFunction ConsolidationFunction { [DispId(789), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(790)]
  public virtual extern object ConsolidationOptions { [LCIDConversion(0), DispId(790), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(791)]
  public virtual extern object ConsolidationSources { [DispId(791), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(643)]
  public virtual extern bool DisplayAutomaticPageBreaks { [TypeLibFunc(64 /*0x40*/), DispId(643), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), DispId(643), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(772)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Drawings([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(88)]
  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object DrawingObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(836)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object DropDowns([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(1156)]
  public virtual extern bool EnableAutoFilter { [DispId(1156), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1156), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1425)]
  public virtual extern XlEnableSelection EnableSelection { [DispId(1425), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1425), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1157)]
  public virtual extern bool EnableOutlining { [LCIDConversion(0), DispId(1157), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1157), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1158)]
  public virtual extern bool EnablePivotTable { [DispId(1158), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1158), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(1)]
  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object Evaluate([MarshalAs(UnmanagedType.Struct), In] object Name);

  [DispId(-5)]
  [TypeLibFunc(1024 /*0x0400*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object _Evaluate([MarshalAs(UnmanagedType.Struct), In] object Name);

  [DispId(800)]
  public virtual extern bool FilterMode { [LCIDConversion(0), DispId(800), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1426)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ResetAllPageBreaks();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(834)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object GroupBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1113)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object GroupObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(841)]
  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Labels([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(767 /*0x02FF*/)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Lines([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [DispId(832)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object ListBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(442)]
  public virtual extern Names Names { [DispId(442), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(1)]
  [DispId(799)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object OLEObjects([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(625)]
  public virtual extern string OnCalculate { [DispId(625), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(625), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(629)]
  public virtual extern string OnData { [TypeLibFunc(64 /*0x40*/), DispId(629), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(629), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(627)]
  public virtual extern string OnEntry { [TypeLibFunc(64 /*0x40*/), DispId(627), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(64 /*0x40*/), DispId(627), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(826)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object OptionButtons([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(102)]
  public virtual extern Outline Outline { [DispId(102), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [DispId(801)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Ovals([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(2)]
  [DispId(211)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Paste([MarshalAs(UnmanagedType.Struct), In, Optional] object Destination, [MarshalAs(UnmanagedType.Struct), In, Optional] object Link);

  [TypeLibFunc(1088)]
  [LCIDConversion(6)]
  [DispId(1027)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void _PasteSpecial(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Link,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DisplayAsIcon,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconFileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconIndex,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconLabel);

  [DispId(771)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Pictures([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(1)]
  [DispId(690)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object PivotTables([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(684)]
  [LCIDConversion(16 /*0x10*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern PivotTable PivotTableWizard(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SourceType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SourceData,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TableDestination,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TableName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object RowGrand,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnGrand,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SaveData,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object HasAutoFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AutoPage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Reserved,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object BackgroundQuery,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OptimizeCache,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PageFieldOrder,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PageFieldWrapCount,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadData,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Connection);

  [DispId(197)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Range get_Range([MarshalAs(UnmanagedType.Struct), In] object Cell1, [MarshalAs(UnmanagedType.Struct), In, Optional] object Cell2);

  [LCIDConversion(1)]
  [DispId(774)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Rectangles([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(258)]
  public virtual extern Range Rows { [DispId(258), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(908)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Scenarios([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(1433)]
  public virtual extern string ScrollArea { [DispId(1433), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1433), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [TypeLibFunc(64 /*0x40*/)]
  [LCIDConversion(1)]
  [DispId(830)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object ScrollBars([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [LCIDConversion(0)]
  [DispId(794)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ShowAllData();

  [LCIDConversion(0)]
  [DispId(409)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ShowDataForm();

  [LCIDConversion(1)]
  [DispId(838)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object Spinners([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(407)]
  public virtual extern double StandardHeight { [LCIDConversion(0), DispId(407), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(408)]
  public virtual extern double StandardWidth { [DispId(408), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(408), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(777)]
  [LCIDConversion(1)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object TextBoxes([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(402)]
  public virtual extern bool TransitionFormEntry { [TypeLibFunc(1024 /*0x0400*/), DispId(402), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(402), TypeLibFunc(1024 /*0x0400*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(108)]
  public virtual extern XlSheetType Type { [DispId(108), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(412)]
  public virtual extern Range UsedRange { [DispId(412), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1418)]
  public virtual extern HPageBreaks HPageBreaks { [DispId(1418), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1419)]
  public virtual extern VPageBreaks VPageBreaks { [DispId(1419), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1434)]
  public virtual extern QueryTables QueryTables { [DispId(1434), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1435)]
  public virtual extern bool DisplayPageBreaks { [DispId(1435), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1435), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(575)]
  public virtual extern Comments Comments { [DispId(575), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1393)]
  public virtual extern Hyperlinks Hyperlinks { [DispId(1393), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1436)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ClearCircles();

  [DispId(1437)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CircleInvalid();

  [DispId(648)]
  public virtual extern int _DisplayRightToLeft { [LCIDConversion(0), DispId(648), TypeLibFunc(1088), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(648), LCIDConversion(0), TypeLibFunc(1088), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(793)]
  public virtual extern AutoFilter AutoFilter { [DispId(793), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1774)]
  public virtual extern bool DisplayRightToLeft { [DispId(1774), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1774), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1816)]
  public virtual extern Scripts Scripts { [TypeLibFunc(64 /*0x40*/), DispId(1816), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1772)]
  [TypeLibFunc(1088)]
  [LCIDConversion(8)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrToFileName);

  [DispId(1817)]
  [LCIDConversion(6)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void _CheckSpelling(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CustomDictionary,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreUppercase,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AlwaysSuggest,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SpellLang,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnoreFinalYaa,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SpellScript);

  [DispId(1041)]
  public virtual extern Tab Tab { [DispId(1041), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2021)]
  public virtual extern MsoEnvelope MailEnvelope { [DispId(2021), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1925)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SaveAs(
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
  public virtual extern CustomProperties CustomProperties { [DispId(2030), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2016)]
  public virtual extern SmartTags SmartTags { [DispId(2016), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(176 /*0xB0*/)]
  public virtual extern Protection Protection { [DispId(176 /*0xB0*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1928)]
  [LCIDConversion(7)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PasteSpecial(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Format,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Link,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DisplayAsIcon,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconFileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconIndex,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IconLabel,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object NoHTMLFormatting);

  [DispId(2029)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Protect(
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

  [DispId(2259)]
  public virtual extern ListObjects ListObjects { [DispId(2259), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2260)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Range XmlDataQuery([MarshalAs(UnmanagedType.BStr), In] string XPath, [MarshalAs(UnmanagedType.Struct), In, Optional] object SelectionNamespaces, [MarshalAs(UnmanagedType.Struct), In, Optional] object Map);

  [DispId(2263)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Range XmlMapQuery([MarshalAs(UnmanagedType.BStr), In] string XPath, [MarshalAs(UnmanagedType.Struct), In, Optional] object SelectionNamespaces, [MarshalAs(UnmanagedType.Struct), In, Optional] object Map);

  [LCIDConversion(9)]
  [DispId(2361)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PrintOutEx(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrToFileName,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnorePrintAreas);

  [DispId(2511)]
  public virtual extern bool EnableFormatConditionsCalculation { [DispId(2511), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2511), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(880)]
  public virtual extern Sort Sort { [DispId(880), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2493)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ExportAsFixedFormat(
    [In] XlFixedFormatType Type,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Quality,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IncludeDocProperties,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IgnorePrintAreas,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OpenAfterPublish,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FixedFormatExtClassPtr);

  public virtual extern event DocEvents_SelectionChangeEventHandler SelectionChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_SelectionChange([In] DocEvents_SelectionChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_SelectionChange([In] DocEvents_SelectionChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_BeforeDoubleClick([In] DocEvents_BeforeDoubleClickEventHandler obj0);

  public virtual extern event DocEvents_BeforeDoubleClickEventHandler BeforeDoubleClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_BeforeDoubleClick([In] DocEvents_BeforeDoubleClickEventHandler obj0);

  public virtual extern event DocEvents_BeforeRightClickEventHandler BeforeRightClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_BeforeRightClick([In] DocEvents_BeforeRightClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_BeforeRightClick([In] DocEvents_BeforeRightClickEventHandler obj0);

  public virtual extern event DocEvents_ActivateEventHandler DocEvents_Event_Activate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Activate([In] DocEvents_ActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Activate([In] DocEvents_ActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Deactivate([In] DocEvents_DeactivateEventHandler obj0);

  public virtual extern event DocEvents_DeactivateEventHandler Deactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Deactivate([In] DocEvents_DeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Calculate([In] DocEvents_CalculateEventHandler obj0);

  public virtual extern event DocEvents_CalculateEventHandler DocEvents_Event_Calculate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Calculate([In] DocEvents_CalculateEventHandler obj0);

  public virtual extern event DocEvents_ChangeEventHandler Change;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Change([In] DocEvents_ChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Change([In] DocEvents_ChangeEventHandler obj0);

  public virtual extern event DocEvents_FollowHyperlinkEventHandler FollowHyperlink;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_FollowHyperlink([In] DocEvents_FollowHyperlinkEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_FollowHyperlink([In] DocEvents_FollowHyperlinkEventHandler obj0);

  public virtual extern event DocEvents_PivotTableUpdateEventHandler PivotTableUpdate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_PivotTableUpdate([In] DocEvents_PivotTableUpdateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_PivotTableUpdate([In] DocEvents_PivotTableUpdateEventHandler obj0);
}
