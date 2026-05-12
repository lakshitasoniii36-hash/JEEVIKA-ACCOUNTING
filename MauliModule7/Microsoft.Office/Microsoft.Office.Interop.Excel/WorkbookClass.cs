// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.WorkbookClass
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using Microsoft.Vbe.Interop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[ClassInterface(0)]
[Guid("00020819-0000-0000-C000-000000000046")]
[ComSourceInterfaces("Microsoft.Office.Interop.Excel.WorkbookEvents\0\0")]
[TypeLibType(2)]
[ComImport]
public class WorkbookClass : _Workbook, Workbook, WorkbookEvents_Event
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern WorkbookClass();

  [DispId(148)]
  public virtual extern Application Application { [DispId(148), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  public virtual extern XlCreator Creator { [DispId(149), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  public virtual extern object Parent { [DispId(150), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1441)]
  public virtual extern bool AcceptLabelsInFormulas { [TypeLibFunc(64 /*0x40*/), DispId(1441), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1441), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(304)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Activate();

  [DispId(183)]
  public virtual extern Chart ActiveChart { [DispId(183), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(307)]
  public virtual extern object ActiveSheet { [DispId(307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(574)]
  public virtual extern string Author { [LCIDConversion(0), DispId(574), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(574), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1442)]
  public virtual extern int AutoUpdateFrequency { [DispId(1442), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1442), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1443)]
  public virtual extern bool AutoUpdateSaveChanges { [DispId(1443), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1443), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1444)]
  public virtual extern int ChangeHistoryDuration { [DispId(1444), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1444), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1176)]
  public virtual extern object BuiltinDocumentProperties { [DispId(1176), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [LCIDConversion(3)]
  [DispId(989)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ChangeFileAccess(
    [In] XlFileAccess Mode,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WritePassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Notify);

  [DispId(802)]
  [LCIDConversion(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ChangeLink([MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.BStr), In] string NewName, [In] XlLinkType Type = XlLinkType.xlLinkTypeExcelLinks);

  [DispId(121)]
  public virtual extern Sheets Charts { [DispId(121), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(3)]
  [DispId(277)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Close([MarshalAs(UnmanagedType.Struct), In, Optional] object SaveChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename, [MarshalAs(UnmanagedType.Struct), In, Optional] object RouteWorkbook);

  [DispId(1373)]
  public virtual extern string CodeName { [DispId(1373), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(-2147418112 /*0x80010000*/)]
  public virtual extern string _CodeName { [TypeLibFunc(1024 /*0x0400*/), DispId(-2147418112 /*0x80010000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(-2147418112 /*0x80010000*/), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [LCIDConversion(1)]
  [DispId(286)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object get_Colors([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(286)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void set_Colors([MarshalAs(UnmanagedType.Struct), In, Optional] object Index, [MarshalAs(UnmanagedType.Struct), In, Optional] object RHS);

  [DispId(1439)]
  public virtual extern CommandBars CommandBars { [DispId(1439), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(575)]
  public virtual extern string Comments { [TypeLibFunc(64 /*0x40*/), DispId(575), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(575), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1175)]
  public virtual extern XlSaveConflictResolution ConflictResolution { [DispId(1175), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1175), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1190)]
  public virtual extern object Container { [DispId(1190), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(287)]
  public virtual extern bool CreateBackup { [DispId(287), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1177)]
  public virtual extern object CustomDocumentProperties { [DispId(1177), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(403)]
  public virtual extern bool Date1904 { [LCIDConversion(0), DispId(403), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(403), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(1)]
  [DispId(397)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void DeleteNumberFormat([MarshalAs(UnmanagedType.BStr), In] string NumberFormat);

  [DispId(764)]
  public virtual extern Sheets DialogSheets { [DispId(764), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(404)]
  public virtual extern XlDisplayDrawingObjects DisplayDrawingObjects { [LCIDConversion(0), DispId(404), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(404), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(0)]
  [DispId(1168)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool ExclusiveAccess();

  [DispId(288)]
  public virtual extern XlFileFormat FileFormat { [DispId(288), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(973)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ForwardMailer();

  [DispId(289)]
  public virtual extern string FullName { [LCIDConversion(0), DispId(289), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(976)]
  public virtual extern bool HasMailer { [LCIDConversion(0), DispId(976), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(976), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(290)]
  public virtual extern bool HasPassword { [DispId(290), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(950)]
  public virtual extern bool HasRoutingSlip { [LCIDConversion(0), DispId(950), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), DispId(950), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1445)]
  public virtual extern bool IsAddin { [DispId(1445), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1445), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(577)]
  public virtual extern string Keywords { [TypeLibFunc(64 /*0x40*/), DispId(577), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(577), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(807)]
  [LCIDConversion(4)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object LinkInfo(
    [MarshalAs(UnmanagedType.BStr), In] string Name,
    [In] XlLinkInfo LinkInfo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Type,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object EditionRef);

  [LCIDConversion(1)]
  [DispId(808)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object LinkSources([MarshalAs(UnmanagedType.Struct), In, Optional] object Type);

  [DispId(979)]
  public virtual extern Mailer Mailer { [DispId(979), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1446)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void MergeWorkbook([MarshalAs(UnmanagedType.Struct), In] object Filename);

  [DispId(582)]
  public virtual extern Sheets Modules { [DispId(582), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1169)]
  public virtual extern bool MultiUserEditing { [LCIDConversion(0), DispId(1169), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(110)]
  public virtual extern string Name { [DispId(110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(442)]
  public virtual extern Names Names { [DispId(442), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(0)]
  [DispId(280)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Window NewWindow();

  [DispId(1178)]
  public virtual extern string OnSave { [DispId(1178), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), DispId(1178), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1031)]
  public virtual extern string OnSheetActivate { [LCIDConversion(0), DispId(1031), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1031), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1081)]
  public virtual extern string OnSheetDeactivate { [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), DispId(1081), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), DispId(1081), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(803)]
  [LCIDConversion(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void OpenLinks([MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnly, [MarshalAs(UnmanagedType.Struct), In, Optional] object Type);

  [DispId(291)]
  public virtual extern string Path { [DispId(291), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1447)]
  public virtual extern bool PersonalViewListSettings { [DispId(1447), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1447), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1448)]
  public virtual extern bool PersonalViewPrintSettings { [DispId(1448), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1448), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1449)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern Microsoft.Office.Interop.Excel.PivotCaches PivotCaches();

  [DispId(1166)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Post([MarshalAs(UnmanagedType.Struct), In, Optional] object DestName);

  [DispId(405)]
  public virtual extern bool PrecisionAsDisplayed { [LCIDConversion(0), DispId(405), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(405), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(7)]
  [DispId(905)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void _PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate);

  [LCIDConversion(1)]
  [DispId(281)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PrintPreview([MarshalAs(UnmanagedType.Struct), In, Optional] object EnableChanges);

  [DispId(282)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void _Protect([MarshalAs(UnmanagedType.Struct), In, Optional] object Password, [MarshalAs(UnmanagedType.Struct), In, Optional] object Structure, [MarshalAs(UnmanagedType.Struct), In, Optional] object Windows);

  [DispId(1450)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ProtectSharing(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SharingPassword);

  [DispId(588)]
  public virtual extern bool ProtectStructure { [DispId(588), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(295)]
  public virtual extern bool ProtectWindows { [DispId(295), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(296)]
  public virtual extern bool ReadOnly { [DispId(296), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(297)]
  public virtual extern bool _ReadOnlyRecommended { [LCIDConversion(0), DispId(297), TypeLibFunc(1088), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1452)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RefreshAll();

  [LCIDConversion(0)]
  [DispId(977)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Reply();

  [DispId(978)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ReplyAll();

  [DispId(1453)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RemoveUser([In] int Index);

  [DispId(1172)]
  public virtual extern int RevisionNumber { [DispId(1172), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [LCIDConversion(0)]
  [TypeLibFunc(64 /*0x40*/)]
  [DispId(946)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Route();

  [DispId(951)]
  public virtual extern bool Routed { [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), DispId(951), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(949)]
  public virtual extern RoutingSlip RoutingSlip { [DispId(949), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(634)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RunAutoMacros([In] XlRunAutoMacro Which);

  [DispId(283)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Save();

  [LCIDConversion(11)]
  [TypeLibFunc(1088)]
  [DispId(284)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void _SaveAs(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
    [In] XlSaveAsAccessMode AccessMode = XlSaveAsAccessMode.xlNoChange,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ConflictResolution,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AddToMru,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextCodepage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout);

  [DispId(175)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SaveCopyAs([MarshalAs(UnmanagedType.Struct), In, Optional] object Filename);

  [DispId(298)]
  public virtual extern bool Saved { [LCIDConversion(0), DispId(298), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(298), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(406)]
  public virtual extern bool SaveLinkValues { [LCIDConversion(0), DispId(406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(947)]
  [LCIDConversion(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SendMail([MarshalAs(UnmanagedType.Struct), In] object Recipients, [MarshalAs(UnmanagedType.Struct), In, Optional] object Subject, [MarshalAs(UnmanagedType.Struct), In, Optional] object ReturnReceipt);

  [DispId(980)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SendMailer([MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat, [In] XlPriority Priority = XlPriority.xlPriorityNormal);

  [DispId(809)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetLinkOnData([MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.Struct), In, Optional] object Procedure);

  [DispId(485)]
  public virtual extern Sheets Sheets { [DispId(485), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1171)]
  public virtual extern bool ShowConflictHistory { [DispId(1171), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1171), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(493)]
  public virtual extern Styles Styles { [DispId(493), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(953)]
  public virtual extern string Subject { [LCIDConversion(0), DispId(953), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(953), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(199)]
  public virtual extern string Title { [TypeLibFunc(64 /*0x40*/), DispId(199), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(64 /*0x40*/), DispId(199), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(285)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Unprotect([MarshalAs(UnmanagedType.Struct), In, Optional] object Password);

  [DispId(1455)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void UnprotectSharing([MarshalAs(UnmanagedType.Struct), In, Optional] object SharingPassword);

  [LCIDConversion(0)]
  [DispId(995)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void UpdateFromFile();

  [DispId(804)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void UpdateLink([MarshalAs(UnmanagedType.Struct), In, Optional] object Name, [MarshalAs(UnmanagedType.Struct), In, Optional] object Type);

  [DispId(411)]
  public virtual extern bool UpdateRemoteReferences { [DispId(411), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(411), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1210)]
  public virtual extern bool UserControl { [TypeLibFunc(64 /*0x40*/), DispId(1210), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1210), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1173)]
  public virtual extern object UserStatus { [DispId(1173), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1456)]
  public virtual extern CustomViews CustomViews { [DispId(1456), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(430)]
  public virtual extern Windows Windows { [DispId(430), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(494)]
  public virtual extern Sheets Worksheets { [DispId(494), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(299)]
  public virtual extern bool WriteReserved { [LCIDConversion(0), DispId(299), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(300)]
  public virtual extern string WriteReservedBy { [LCIDConversion(0), DispId(300), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(581)]
  public virtual extern Sheets Excel4IntlMacroSheets { [DispId(581), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(579)]
  public virtual extern Sheets Excel4MacroSheets { [DispId(579), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1457)]
  public virtual extern bool TemplateRemoveExtData { [DispId(1457), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1457), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1458)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void HighlightChangesOptions([MarshalAs(UnmanagedType.Struct), In, Optional] object When, [MarshalAs(UnmanagedType.Struct), In, Optional] object Who, [MarshalAs(UnmanagedType.Struct), In, Optional] object Where);

  [DispId(1461)]
  public virtual extern bool HighlightChangesOnScreen { [DispId(1461), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1461), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1462)]
  public virtual extern bool KeepChangeHistory { [DispId(1462), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1462), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1463)]
  public virtual extern bool ListChangesOnNewSheet { [DispId(1463), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1463), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1464)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PurgeChangeHistoryNow([In] int Days, [MarshalAs(UnmanagedType.Struct), In, Optional] object SharingPassword);

  [DispId(1466)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void AcceptAllChanges([MarshalAs(UnmanagedType.Struct), In, Optional] object When, [MarshalAs(UnmanagedType.Struct), In, Optional] object Who, [MarshalAs(UnmanagedType.Struct), In, Optional] object Where);

  [DispId(1467)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RejectAllChanges([MarshalAs(UnmanagedType.Struct), In, Optional] object When, [MarshalAs(UnmanagedType.Struct), In, Optional] object Who, [MarshalAs(UnmanagedType.Struct), In, Optional] object Where);

  [DispId(684)]
  [LCIDConversion(16 /*0x10*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PivotTableWizard(
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

  [DispId(1468)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ResetColors();

  [DispId(1469)]
  public virtual extern VBProject VBProject { [DispId(1469), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1470)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void FollowHyperlink(
    [MarshalAs(UnmanagedType.BStr), In] string Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SubAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object NewWindow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AddHistory,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ExtraInfo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Method,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object HeaderInfo);

  [DispId(1476)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void AddToFavorites();

  [DispId(1769)]
  public virtual extern bool IsInplace { [DispId(1769), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(1088)]
  [DispId(1772)]
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

  [DispId(1818)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void WebPagePreview();

  [DispId(1819)]
  public virtual extern PublishObjects PublishObjects { [DispId(1819), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1820)]
  public virtual extern WebOptions WebOptions { [DispId(1820), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1821)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ReloadAs([In] MsoEncoding Encoding);

  [DispId(1823)]
  public virtual extern HTMLProject HTMLProject { [TypeLibFunc(64 /*0x40*/), DispId(1823), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1824)]
  public virtual extern bool EnvelopeVisible { [DispId(1824), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1824), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1806)]
  public virtual extern int CalculationVersion { [DispId(1806), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2044)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Dummy17([In] int calcid);

  [DispId(1826)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void sblt([MarshalAs(UnmanagedType.BStr), In] string s);

  [DispId(1828)]
  public virtual extern bool VBASigned { [DispId(1828), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2046)]
  public virtual extern bool ShowPivotTableFieldList { [DispId(2046), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2046), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(864)]
  public virtual extern XlUpdateLinks UpdateLinks { [DispId(864), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(864), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2047 /*0x07FF*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void BreakLink([MarshalAs(UnmanagedType.BStr), In] string Name, [In] XlLinkType Type);

  [DispId(2048 /*0x0800*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Dummy16();

  [LCIDConversion(12)]
  [DispId(1925)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SaveAs(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
    [In] XlSaveAsAccessMode AccessMode = XlSaveAsAccessMode.xlNoChange,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ConflictResolution,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AddToMru,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextCodepage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Local);

  [DispId(2049)]
  public virtual extern bool EnableAutoRecover { [DispId(2049), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2049), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2050)]
  public virtual extern bool RemovePersonalInformation { [DispId(2050), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2050), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1927)]
  public virtual extern string FullNameURLEncoded { [DispId(1927), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(2051)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CheckIn([MarshalAs(UnmanagedType.Struct), In, Optional] object SaveChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] object Comments, [MarshalAs(UnmanagedType.Struct), In, Optional] object MakePublic);

  [DispId(2053)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern bool CanCheckIn();

  [DispId(2054)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SendForReview(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Recipients,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Subject,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowMessage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IncludeAttachment);

  [DispId(2057)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ReplyWithChanges([MarshalAs(UnmanagedType.Struct), In, Optional] object ShowMessage);

  [DispId(2058)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void EndReview();

  [DispId(429)]
  public virtual extern string Password { [DispId(429), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(429), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1128)]
  public virtual extern string WritePassword { [DispId(1128), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1128), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(2059)]
  public virtual extern string PasswordEncryptionProvider { [DispId(2059), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(2060)]
  public virtual extern string PasswordEncryptionAlgorithm { [DispId(2060), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(2061)]
  public virtual extern int PasswordEncryptionKeyLength { [DispId(2061), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2062)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetPasswordEncryptionOptions(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PasswordEncryptionProvider,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PasswordEncryptionAlgorithm,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PasswordEncryptionKeyLength,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PasswordEncryptionFileProperties);

  [DispId(2063)]
  public virtual extern bool PasswordEncryptionFileProperties { [DispId(2063), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2005)]
  public virtual extern bool ReadOnlyRecommended { [DispId(2005), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2005), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2029)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Protect([MarshalAs(UnmanagedType.Struct), In, Optional] object Password, [MarshalAs(UnmanagedType.Struct), In, Optional] object Structure, [MarshalAs(UnmanagedType.Struct), In, Optional] object Windows);

  [DispId(2064)]
  public virtual extern SmartTagOptions SmartTagOptions { [DispId(2064), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2065)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RecheckSmartTags();

  [DispId(2264)]
  public virtual extern Permission Permission { [DispId(2264), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2265)]
  public virtual extern SharedWorkspace SharedWorkspace { [DispId(2265), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2266)]
  public virtual extern Sync Sync { [DispId(2266), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2267)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SendFaxOverInternet(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Recipients,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Subject,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowMessage);

  [DispId(2268)]
  public virtual extern XmlNamespaces XmlNamespaces { [DispId(2268), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2269)]
  public virtual extern XmlMaps XmlMaps { [DispId(2269), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2270)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern XlXmlImportResult XmlImport(
    [MarshalAs(UnmanagedType.BStr), In] string Url,
    [MarshalAs(UnmanagedType.Interface)] out XmlMap ImportMap,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Overwrite,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Destination);

  [DispId(2273)]
  public virtual extern SmartDocument SmartDocument { [DispId(2273), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2274)]
  public virtual extern DocumentLibraryVersions DocumentLibraryVersions { [DispId(2274), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2275)]
  public virtual extern bool InactiveListBorderVisible { [DispId(2275), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2275), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2276)]
  public virtual extern bool DisplayInkComments { [DispId(2276), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2276), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2277)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern XlXmlImportResult XmlImportXml(
    [MarshalAs(UnmanagedType.BStr), In] string Data,
    [MarshalAs(UnmanagedType.Interface)] out XmlMap ImportMap,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Overwrite,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Destination);

  [DispId(2278)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SaveAsXMLData([MarshalAs(UnmanagedType.BStr), In] string Filename, [MarshalAs(UnmanagedType.Interface), In] XmlMap Map);

  [DispId(2279)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ToggleFormsDesign();

  [DispId(2512)]
  public virtual extern MetaProperties ContentTypeProperties { [DispId(2512), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2513)]
  public virtual extern Connections Connections { [DispId(2513), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2514)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void RemoveDocumentInformation([In] XlRemoveDocInfoType RemoveDocInfoType);

  [DispId(2516)]
  public virtual extern SignatureSet Signatures { [DispId(2516), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2517)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CheckInWithVersion(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SaveChanges,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Comments,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MakePublic,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object VersionType);

  [DispId(2519)]
  public virtual extern ServerPolicy ServerPolicy { [DispId(2519), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2520)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void LockServerFile();

  [DispId(2521)]
  public virtual extern DocumentInspectors DocumentInspectors { [DispId(2521), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2522)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern WorkflowTasks GetWorkflowTasks();

  [DispId(2523)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern WorkflowTemplates GetWorkflowTemplates();

  [DispId(2361)]
  [LCIDConversion(9)]
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

  [DispId(2524)]
  public virtual extern ServerViewableItems ServerViewableItems { [DispId(2524), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2525)]
  public virtual extern TableStyles TableStyles { [DispId(2525), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2526)]
  public virtual extern object DefaultTableStyle { [TypeLibFunc(1024 /*0x0400*/), DispId(2526), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(2526), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(2527)]
  public virtual extern object DefaultPivotTableStyle { [TypeLibFunc(1024 /*0x0400*/), DispId(2527), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [TypeLibFunc(1024 /*0x0400*/), DispId(2527), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(2528)]
  public virtual extern bool CheckCompatibility { [DispId(2528), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2528), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2529)]
  public virtual extern bool HasVBProject { [DispId(2529), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2530)]
  public virtual extern CustomXMLParts CustomXMLParts { [DispId(2530), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2531)]
  public virtual extern bool Final { [DispId(2531), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2531), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2532)]
  public virtual extern Research Research { [DispId(2532), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2533)]
  public virtual extern OfficeTheme Theme { [DispId(2533), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2534)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ApplyTheme([MarshalAs(UnmanagedType.BStr), In] string Filename);

  [DispId(2535)]
  public virtual extern bool Excel8CompatibilityMode { [DispId(2535), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2536)]
  public virtual extern bool ConnectionsDisabled { [DispId(2536), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2537)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void EnableConnections();

  [DispId(2538)]
  public virtual extern bool ShowPivotChartActiveFields { [DispId(2538), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2538), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

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

  [DispId(2539)]
  public virtual extern IconSets IconSets { [DispId(2539), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2540)]
  public virtual extern string EncryptionProvider { [DispId(2540), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2540), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(2541)]
  public virtual extern bool DoNotPromptForConvert { [DispId(2541), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2541), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2542)]
  public virtual extern bool ForceFullCalculation { [DispId(2542), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2542), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2543)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void ProtectSharingEx(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SharingPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Open([In] WorkbookEvents_OpenEventHandler obj0);

  public virtual extern event WorkbookEvents_OpenEventHandler Open;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Open([In] WorkbookEvents_OpenEventHandler obj0);

  public virtual extern event WorkbookEvents_ActivateEventHandler WorkbookEvents_Event_Activate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Activate([In] WorkbookEvents_ActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Activate([In] WorkbookEvents_ActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Deactivate([In] WorkbookEvents_DeactivateEventHandler obj0);

  public virtual extern event WorkbookEvents_DeactivateEventHandler Deactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Deactivate([In] WorkbookEvents_DeactivateEventHandler obj0);

  public virtual extern event WorkbookEvents_BeforeCloseEventHandler BeforeClose;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_BeforeClose([In] WorkbookEvents_BeforeCloseEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_BeforeClose([In] WorkbookEvents_BeforeCloseEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_BeforeSave([In] WorkbookEvents_BeforeSaveEventHandler obj0);

  public virtual extern event WorkbookEvents_BeforeSaveEventHandler BeforeSave;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_BeforeSave([In] WorkbookEvents_BeforeSaveEventHandler obj0);

  public virtual extern event WorkbookEvents_BeforePrintEventHandler BeforePrint;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_BeforePrint([In] WorkbookEvents_BeforePrintEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_BeforePrint([In] WorkbookEvents_BeforePrintEventHandler obj0);

  public virtual extern event WorkbookEvents_NewSheetEventHandler NewSheet;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_NewSheet([In] WorkbookEvents_NewSheetEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_NewSheet([In] WorkbookEvents_NewSheetEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_AddinInstall([In] WorkbookEvents_AddinInstallEventHandler obj0);

  public virtual extern event WorkbookEvents_AddinInstallEventHandler AddinInstall;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_AddinInstall([In] WorkbookEvents_AddinInstallEventHandler obj0);

  public virtual extern event WorkbookEvents_AddinUninstallEventHandler AddinUninstall;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_AddinUninstall([In] WorkbookEvents_AddinUninstallEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_AddinUninstall([In] WorkbookEvents_AddinUninstallEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_WindowResize([In] WorkbookEvents_WindowResizeEventHandler obj0);

  public virtual extern event WorkbookEvents_WindowResizeEventHandler WindowResize;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_WindowResize([In] WorkbookEvents_WindowResizeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_WindowActivate([In] WorkbookEvents_WindowActivateEventHandler obj0);

  public virtual extern event WorkbookEvents_WindowActivateEventHandler WindowActivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_WindowActivate([In] WorkbookEvents_WindowActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_WindowDeactivate([In] WorkbookEvents_WindowDeactivateEventHandler obj0);

  public virtual extern event WorkbookEvents_WindowDeactivateEventHandler WindowDeactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_WindowDeactivate(
    [In] WorkbookEvents_WindowDeactivateEventHandler obj0);

  public virtual extern event WorkbookEvents_SheetSelectionChangeEventHandler SheetSelectionChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_SheetSelectionChange(
    [In] WorkbookEvents_SheetSelectionChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_SheetSelectionChange(
    [In] WorkbookEvents_SheetSelectionChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_SheetBeforeDoubleClick(
    [In] WorkbookEvents_SheetBeforeDoubleClickEventHandler obj0);

  public virtual extern event WorkbookEvents_SheetBeforeDoubleClickEventHandler SheetBeforeDoubleClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_SheetBeforeDoubleClick(
    [In] WorkbookEvents_SheetBeforeDoubleClickEventHandler obj0);

  public virtual extern event WorkbookEvents_SheetBeforeRightClickEventHandler SheetBeforeRightClick;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_SheetBeforeRightClick(
    [In] WorkbookEvents_SheetBeforeRightClickEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_SheetBeforeRightClick(
    [In] WorkbookEvents_SheetBeforeRightClickEventHandler obj0);

  public virtual extern event WorkbookEvents_SheetActivateEventHandler SheetActivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_SheetActivate([In] WorkbookEvents_SheetActivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_SheetActivate([In] WorkbookEvents_SheetActivateEventHandler obj0);

  public virtual extern event WorkbookEvents_SheetDeactivateEventHandler SheetDeactivate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_SheetDeactivate([In] WorkbookEvents_SheetDeactivateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_SheetDeactivate([In] WorkbookEvents_SheetDeactivateEventHandler obj0);

  public virtual extern event WorkbookEvents_SheetCalculateEventHandler SheetCalculate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_SheetCalculate([In] WorkbookEvents_SheetCalculateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_SheetCalculate([In] WorkbookEvents_SheetCalculateEventHandler obj0);

  public virtual extern event WorkbookEvents_SheetChangeEventHandler SheetChange;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_SheetChange([In] WorkbookEvents_SheetChangeEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_SheetChange([In] WorkbookEvents_SheetChangeEventHandler obj0);

  public virtual extern event WorkbookEvents_SheetFollowHyperlinkEventHandler SheetFollowHyperlink;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_SheetFollowHyperlink(
    [In] WorkbookEvents_SheetFollowHyperlinkEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_SheetFollowHyperlink(
    [In] WorkbookEvents_SheetFollowHyperlinkEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_SheetPivotTableUpdate(
    [In] WorkbookEvents_SheetPivotTableUpdateEventHandler obj0);

  public virtual extern event WorkbookEvents_SheetPivotTableUpdateEventHandler SheetPivotTableUpdate;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_SheetPivotTableUpdate(
    [In] WorkbookEvents_SheetPivotTableUpdateEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_PivotTableCloseConnection(
    [In] WorkbookEvents_PivotTableCloseConnectionEventHandler obj0);

  public virtual extern event WorkbookEvents_PivotTableCloseConnectionEventHandler PivotTableCloseConnection;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_PivotTableCloseConnection(
    [In] WorkbookEvents_PivotTableCloseConnectionEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_PivotTableOpenConnection(
    [In] WorkbookEvents_PivotTableOpenConnectionEventHandler obj0);

  public virtual extern event WorkbookEvents_PivotTableOpenConnectionEventHandler PivotTableOpenConnection;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_PivotTableOpenConnection(
    [In] WorkbookEvents_PivotTableOpenConnectionEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Sync([In] WorkbookEvents_SyncEventHandler obj0);

  public virtual extern event WorkbookEvents_SyncEventHandler WorkbookEvents_Event_Sync;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Sync([In] WorkbookEvents_SyncEventHandler obj0);

  public virtual extern event WorkbookEvents_BeforeXmlImportEventHandler BeforeXmlImport;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_BeforeXmlImport([In] WorkbookEvents_BeforeXmlImportEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_BeforeXmlImport([In] WorkbookEvents_BeforeXmlImportEventHandler obj0);

  public virtual extern event WorkbookEvents_AfterXmlImportEventHandler AfterXmlImport;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_AfterXmlImport([In] WorkbookEvents_AfterXmlImportEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_AfterXmlImport([In] WorkbookEvents_AfterXmlImportEventHandler obj0);

  public virtual extern event WorkbookEvents_BeforeXmlExportEventHandler BeforeXmlExport;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_BeforeXmlExport([In] WorkbookEvents_BeforeXmlExportEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_BeforeXmlExport([In] WorkbookEvents_BeforeXmlExportEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_AfterXmlExport([In] WorkbookEvents_AfterXmlExportEventHandler obj0);

  public virtual extern event WorkbookEvents_AfterXmlExportEventHandler AfterXmlExport;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_AfterXmlExport([In] WorkbookEvents_AfterXmlExportEventHandler obj0);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_RowsetComplete([In] WorkbookEvents_RowsetCompleteEventHandler obj0);

  public virtual extern event WorkbookEvents_RowsetCompleteEventHandler RowsetComplete;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_RowsetComplete([In] WorkbookEvents_RowsetCompleteEventHandler obj0);
}
