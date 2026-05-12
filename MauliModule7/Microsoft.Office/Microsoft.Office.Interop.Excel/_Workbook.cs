// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel._Workbook
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using Microsoft.Office.Core;
using Microsoft.Vbe.Interop;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[Guid("000208DA-0000-0000-C000-000000000046")]
[TypeLibType(4160)]
[ComImport]
public interface _Workbook
{
  [DispId(148)]
  Application Application { [DispId(148), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [DispId(149), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [DispId(150), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1441)]
  bool AcceptLabelsInFormulas { [TypeLibFunc(64 /*0x40*/), DispId(1441), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [TypeLibFunc(64 /*0x40*/), DispId(1441), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(0)]
  [DispId(304)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Activate();

  [DispId(183)]
  Chart ActiveChart { [DispId(183), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(307)]
  object ActiveSheet { [DispId(307), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(574)]
  string Author { [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), DispId(574), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(64 /*0x40*/), DispId(574), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1442)]
  int AutoUpdateFrequency { [DispId(1442), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1442), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1443)]
  bool AutoUpdateSaveChanges { [DispId(1443), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1443), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1444)]
  int ChangeHistoryDuration { [DispId(1444), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1444), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1176)]
  object BuiltinDocumentProperties { [DispId(1176), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(989)]
  [LCIDConversion(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ChangeFileAccess([In] XlFileAccess Mode, [MarshalAs(UnmanagedType.Struct), In, Optional] object WritePassword, [MarshalAs(UnmanagedType.Struct), In, Optional] object Notify);

  [DispId(802)]
  [LCIDConversion(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ChangeLink([MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.BStr), In] string NewName, [In] XlLinkType Type = XlLinkType.xlLinkTypeExcelLinks);

  [DispId(121)]
  Sheets Charts { [DispId(121), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [LCIDConversion(3)]
  [DispId(277)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Close([MarshalAs(UnmanagedType.Struct), In, Optional] object SaveChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename, [MarshalAs(UnmanagedType.Struct), In, Optional] object RouteWorkbook);

  [DispId(1373)]
  string CodeName { [DispId(1373), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(-2147418112 /*0x80010000*/)]
  string _CodeName { [TypeLibFunc(1024 /*0x0400*/), DispId(-2147418112 /*0x80010000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(-2147418112 /*0x80010000*/), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [LCIDConversion(1)]
  [DispId(286)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object get_Colors([MarshalAs(UnmanagedType.Struct), In, Optional] object Index);

  [DispId(286)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void set_Colors([MarshalAs(UnmanagedType.Struct), In, Optional] object Index, [MarshalAs(UnmanagedType.Struct), In, Optional] object RHS);

  [DispId(1439)]
  CommandBars CommandBars { [DispId(1439), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(575)]
  string Comments { [LCIDConversion(0), DispId(575), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(64 /*0x40*/), DispId(575), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1175)]
  XlSaveConflictResolution ConflictResolution { [DispId(1175), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1175), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1190)]
  object Container { [DispId(1190), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(287)]
  bool CreateBackup { [DispId(287), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1177)]
  object CustomDocumentProperties { [DispId(1177), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(403)]
  bool Date1904 { [LCIDConversion(0), DispId(403), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(403), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(397)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DeleteNumberFormat([MarshalAs(UnmanagedType.BStr), In] string NumberFormat);

  [DispId(764)]
  Sheets DialogSheets { [DispId(764), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(404)]
  XlDisplayDrawingObjects DisplayDrawingObjects { [LCIDConversion(0), DispId(404), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(404), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [LCIDConversion(0)]
  [DispId(1168)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool ExclusiveAccess();

  [DispId(288)]
  XlFileFormat FileFormat { [DispId(288), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [LCIDConversion(0)]
  [DispId(973)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ForwardMailer();

  [DispId(289)]
  string FullName { [DispId(289), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(976)]
  bool HasMailer { [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), DispId(976), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(976), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(290)]
  bool HasPassword { [DispId(290), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(950)]
  bool HasRoutingSlip { [LCIDConversion(0), DispId(950), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), DispId(950), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1445)]
  bool IsAddin { [DispId(1445), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1445), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(577)]
  string Keywords { [LCIDConversion(0), DispId(577), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), DispId(577), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [LCIDConversion(4)]
  [DispId(807)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object LinkInfo([MarshalAs(UnmanagedType.BStr), In] string Name, [In] XlLinkInfo LinkInfo, [MarshalAs(UnmanagedType.Struct), In, Optional] object Type, [MarshalAs(UnmanagedType.Struct), In, Optional] object EditionRef);

  [LCIDConversion(1)]
  [DispId(808)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object LinkSources([MarshalAs(UnmanagedType.Struct), In, Optional] object Type);

  [DispId(979)]
  Mailer Mailer { [DispId(979), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1446)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void MergeWorkbook([MarshalAs(UnmanagedType.Struct), In] object Filename);

  [DispId(582)]
  Sheets Modules { [TypeLibFunc(64 /*0x40*/), DispId(582), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1169)]
  bool MultiUserEditing { [DispId(1169), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(110)]
  string Name { [DispId(110), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(442)]
  Names Names { [DispId(442), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(280)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Window NewWindow();

  [DispId(1178)]
  string OnSave { [DispId(1178), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1178), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1031)]
  string OnSheetActivate { [DispId(1031), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), DispId(1031), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1081)]
  string OnSheetDeactivate { [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), DispId(1081), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1081), TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(803)]
  [LCIDConversion(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OpenLinks([MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnly, [MarshalAs(UnmanagedType.Struct), In, Optional] object Type);

  [DispId(291)]
  string Path { [LCIDConversion(0), DispId(291), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(1447)]
  bool PersonalViewListSettings { [DispId(1447), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1447), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1448)]
  bool PersonalViewPrintSettings { [DispId(1448), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1448), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1449)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Microsoft.Office.Interop.Excel.PivotCaches PivotCaches();

  [DispId(1166)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Post([MarshalAs(UnmanagedType.Struct), In, Optional] object DestName);

  [DispId(405)]
  bool PrecisionAsDisplayed { [DispId(405), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(405), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [TypeLibFunc(1088)]
  [LCIDConversion(7)]
  [DispId(905)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _PrintOut(
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
  void PrintPreview([MarshalAs(UnmanagedType.Struct), In, Optional] object EnableChanges);

  [TypeLibFunc(1088)]
  [DispId(282)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Protect([MarshalAs(UnmanagedType.Struct), In, Optional] object Password, [MarshalAs(UnmanagedType.Struct), In, Optional] object Structure, [MarshalAs(UnmanagedType.Struct), In, Optional] object Windows);

  [DispId(1450)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ProtectSharing(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SharingPassword);

  [DispId(588)]
  bool ProtectStructure { [DispId(588), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(295)]
  bool ProtectWindows { [DispId(295), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(296)]
  bool ReadOnly { [LCIDConversion(0), DispId(296), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(297)]
  bool _ReadOnlyRecommended { [DispId(297), TypeLibFunc(1088), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1452)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RefreshAll();

  [LCIDConversion(0)]
  [DispId(977)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Reply();

  [LCIDConversion(0)]
  [DispId(978)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ReplyAll();

  [DispId(1453)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveUser([In] int Index);

  [DispId(1172)]
  int RevisionNumber { [DispId(1172), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [LCIDConversion(0)]
  [DispId(946)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Route();

  [DispId(951)]
  bool Routed { [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), DispId(951), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(949)]
  RoutingSlip RoutingSlip { [DispId(949), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(634)]
  [LCIDConversion(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RunAutoMacros([In] XlRunAutoMacro Which);

  [DispId(283)]
  [LCIDConversion(0)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Save();

  [TypeLibFunc(1088)]
  [DispId(284)]
  [LCIDConversion(11)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _SaveAs(
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
  void SaveCopyAs([MarshalAs(UnmanagedType.Struct), In, Optional] object Filename);

  [DispId(298)]
  bool Saved { [DispId(298), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(298), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(406)]
  bool SaveLinkValues { [DispId(406), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [LCIDConversion(0), DispId(406), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(947)]
  [LCIDConversion(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SendMail([MarshalAs(UnmanagedType.Struct), In] object Recipients, [MarshalAs(UnmanagedType.Struct), In, Optional] object Subject, [MarshalAs(UnmanagedType.Struct), In, Optional] object ReturnReceipt);

  [DispId(980)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SendMailer([MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat, [In] XlPriority Priority = XlPriority.xlPriorityNormal);

  [DispId(809)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetLinkOnData([MarshalAs(UnmanagedType.BStr), In] string Name, [MarshalAs(UnmanagedType.Struct), In, Optional] object Procedure);

  [DispId(485)]
  Sheets Sheets { [DispId(485), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1171)]
  bool ShowConflictHistory { [LCIDConversion(0), DispId(1171), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1171), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(493)]
  Styles Styles { [DispId(493), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(953)]
  string Subject { [LCIDConversion(0), DispId(953), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(953), LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(199)]
  string Title { [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), DispId(199), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(64 /*0x40*/), DispId(199), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [LCIDConversion(1)]
  [DispId(285)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Unprotect([MarshalAs(UnmanagedType.Struct), In, Optional] object Password);

  [DispId(1455)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void UnprotectSharing([MarshalAs(UnmanagedType.Struct), In, Optional] object SharingPassword);

  [LCIDConversion(0)]
  [DispId(995)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void UpdateFromFile();

  [DispId(804)]
  [LCIDConversion(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void UpdateLink([MarshalAs(UnmanagedType.Struct), In, Optional] object Name, [MarshalAs(UnmanagedType.Struct), In, Optional] object Type);

  [DispId(411)]
  bool UpdateRemoteReferences { [DispId(411), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(411), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1210)]
  bool UserControl { [TypeLibFunc(64 /*0x40*/), DispId(1210), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1210), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1173)]
  object UserStatus { [LCIDConversion(0), DispId(1173), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(1456)]
  CustomViews CustomViews { [DispId(1456), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(430)]
  Windows Windows { [DispId(430), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(494)]
  Sheets Worksheets { [DispId(494), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(299)]
  bool WriteReserved { [LCIDConversion(0), DispId(299), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(300)]
  string WriteReservedBy { [LCIDConversion(0), DispId(300), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(581)]
  Sheets Excel4IntlMacroSheets { [DispId(581), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(579)]
  Sheets Excel4MacroSheets { [DispId(579), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1457)]
  bool TemplateRemoveExtData { [DispId(1457), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1457), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1458)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void HighlightChangesOptions([MarshalAs(UnmanagedType.Struct), In, Optional] object When, [MarshalAs(UnmanagedType.Struct), In, Optional] object Who, [MarshalAs(UnmanagedType.Struct), In, Optional] object Where);

  [DispId(1461)]
  bool HighlightChangesOnScreen { [DispId(1461), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1461), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1462)]
  bool KeepChangeHistory { [DispId(1462), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1462), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1463)]
  bool ListChangesOnNewSheet { [DispId(1463), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1463), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1464)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PurgeChangeHistoryNow([In] int Days, [MarshalAs(UnmanagedType.Struct), In, Optional] object SharingPassword);

  [DispId(1466)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AcceptAllChanges([MarshalAs(UnmanagedType.Struct), In, Optional] object When, [MarshalAs(UnmanagedType.Struct), In, Optional] object Who, [MarshalAs(UnmanagedType.Struct), In, Optional] object Where);

  [DispId(1467)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RejectAllChanges([MarshalAs(UnmanagedType.Struct), In, Optional] object When, [MarshalAs(UnmanagedType.Struct), In, Optional] object Who, [MarshalAs(UnmanagedType.Struct), In, Optional] object Where);

  [DispId(684)]
  [LCIDConversion(16 /*0x10*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PivotTableWizard(
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
  void ResetColors();

  [DispId(1469)]
  VBProject VBProject { [DispId(1469), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1470)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void FollowHyperlink(
    [MarshalAs(UnmanagedType.BStr), In] string Address,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SubAddress,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object NewWindow,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object AddHistory,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ExtraInfo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Method,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object HeaderInfo);

  [DispId(1476)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddToFavorites();

  [DispId(1769)]
  bool IsInplace { [DispId(1769), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(1088)]
  [LCIDConversion(8)]
  [DispId(1772)]
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

  [DispId(1818)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WebPagePreview();

  [DispId(1819)]
  PublishObjects PublishObjects { [DispId(1819), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1820)]
  WebOptions WebOptions { [DispId(1820), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1821)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ReloadAs([In] MsoEncoding Encoding);

  [DispId(1823)]
  HTMLProject HTMLProject { [DispId(1823), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1824)]
  bool EnvelopeVisible { [DispId(1824), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1824), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1806)]
  int CalculationVersion { [DispId(1806), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(2044)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Dummy17([In] int calcid);

  [DispId(1826)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void sblt([MarshalAs(UnmanagedType.BStr), In] string s);

  [DispId(1828)]
  bool VBASigned { [DispId(1828), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2046)]
  bool ShowPivotTableFieldList { [DispId(2046), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2046), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(864)]
  XlUpdateLinks UpdateLinks { [DispId(864), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(864), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2047 /*0x07FF*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void BreakLink([MarshalAs(UnmanagedType.BStr), In] string Name, [In] XlLinkType Type);

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(2048 /*0x0800*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Dummy16();

  [DispId(1925)]
  [LCIDConversion(12)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SaveAs(
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
  bool EnableAutoRecover { [DispId(2049), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2049), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2050)]
  bool RemovePersonalInformation { [DispId(2050), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2050), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1927)]
  string FullNameURLEncoded { [DispId(1927), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(2051)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckIn([MarshalAs(UnmanagedType.Struct), In, Optional] object SaveChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] object Comments, [MarshalAs(UnmanagedType.Struct), In, Optional] object MakePublic);

  [DispId(2053)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool CanCheckIn();

  [DispId(2054)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SendForReview(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Recipients,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Subject,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowMessage,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object IncludeAttachment);

  [DispId(2057)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ReplyWithChanges([MarshalAs(UnmanagedType.Struct), In, Optional] object ShowMessage);

  [DispId(2058)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EndReview();

  [DispId(429)]
  string Password { [DispId(429), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(429), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1128)]
  string WritePassword { [DispId(1128), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1128), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(2059)]
  string PasswordEncryptionProvider { [DispId(2059), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(2060)]
  string PasswordEncryptionAlgorithm { [DispId(2060), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

  [DispId(2061)]
  int PasswordEncryptionKeyLength { [DispId(2061), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2062)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetPasswordEncryptionOptions(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PasswordEncryptionProvider,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PasswordEncryptionAlgorithm,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PasswordEncryptionKeyLength,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PasswordEncryptionFileProperties);

  [DispId(2063)]
  bool PasswordEncryptionFileProperties { [DispId(2063), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2005)]
  bool ReadOnlyRecommended { [DispId(2005), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2005), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2029)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Protect([MarshalAs(UnmanagedType.Struct), In, Optional] object Password, [MarshalAs(UnmanagedType.Struct), In, Optional] object Structure, [MarshalAs(UnmanagedType.Struct), In, Optional] object Windows);

  [DispId(2064)]
  SmartTagOptions SmartTagOptions { [DispId(2064), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2065)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RecheckSmartTags();

  [DispId(2264)]
  Permission Permission { [DispId(2264), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2265)]
  SharedWorkspace SharedWorkspace { [DispId(2265), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2266)]
  Sync Sync { [DispId(2266), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2267)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SendFaxOverInternet([MarshalAs(UnmanagedType.Struct), In, Optional] object Recipients, [MarshalAs(UnmanagedType.Struct), In, Optional] object Subject, [MarshalAs(UnmanagedType.Struct), In, Optional] object ShowMessage);

  [DispId(2268)]
  XmlNamespaces XmlNamespaces { [DispId(2268), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2269)]
  XmlMaps XmlMaps { [DispId(2269), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2270)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  XlXmlImportResult XmlImport(
    [MarshalAs(UnmanagedType.BStr), In] string Url,
    [MarshalAs(UnmanagedType.Interface)] out XmlMap ImportMap,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Overwrite,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Destination);

  [DispId(2273)]
  SmartDocument SmartDocument { [DispId(2273), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2274)]
  DocumentLibraryVersions DocumentLibraryVersions { [DispId(2274), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2275)]
  bool InactiveListBorderVisible { [DispId(2275), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2275), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2276)]
  bool DisplayInkComments { [DispId(2276), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2276), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2277)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  XlXmlImportResult XmlImportXml(
    [MarshalAs(UnmanagedType.BStr), In] string Data,
    [MarshalAs(UnmanagedType.Interface)] out XmlMap ImportMap,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Overwrite,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Destination);

  [DispId(2278)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SaveAsXMLData([MarshalAs(UnmanagedType.BStr), In] string Filename, [MarshalAs(UnmanagedType.Interface), In] XmlMap Map);

  [DispId(2279)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ToggleFormsDesign();

  [DispId(2512)]
  MetaProperties ContentTypeProperties { [DispId(2512), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2513)]
  Connections Connections { [DispId(2513), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2514)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void RemoveDocumentInformation([In] XlRemoveDocInfoType RemoveDocInfoType);

  [DispId(2516)]
  SignatureSet Signatures { [DispId(2516), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2517)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CheckInWithVersion(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SaveChanges,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Comments,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MakePublic,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object VersionType);

  [DispId(2519)]
  ServerPolicy ServerPolicy { [DispId(2519), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2520)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void LockServerFile();

  [DispId(2521)]
  DocumentInspectors DocumentInspectors { [DispId(2521), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2522)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  WorkflowTasks GetWorkflowTasks();

  [DispId(2523)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  WorkflowTemplates GetWorkflowTemplates();

  [DispId(2361)]
  [LCIDConversion(9)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOutEx(
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
  ServerViewableItems ServerViewableItems { [DispId(2524), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2525)]
  TableStyles TableStyles { [DispId(2525), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2526)]
  object DefaultTableStyle { [DispId(2526), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [TypeLibFunc(1024 /*0x0400*/), DispId(2526), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(2527)]
  object DefaultPivotTableStyle { [DispId(2527), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(2527), TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In] set; }

  [DispId(2528)]
  bool CheckCompatibility { [DispId(2528), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2528), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2529)]
  bool HasVBProject { [DispId(2529), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2530)]
  CustomXMLParts CustomXMLParts { [DispId(2530), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2531)]
  bool Final { [DispId(2531), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2531), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2532)]
  Research Research { [DispId(2532), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2533)]
  OfficeTheme Theme { [DispId(2533), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2534)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ApplyTheme([MarshalAs(UnmanagedType.BStr), In] string Filename);

  [DispId(2535)]
  bool Excel8CompatibilityMode { [DispId(2535), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2536)]
  bool ConnectionsDisabled { [DispId(2536), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(2537)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void EnableConnections();

  [DispId(2538)]
  bool ShowPivotChartActiveFields { [DispId(2538), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2538), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2493)]
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

  [DispId(2539)]
  IconSets IconSets { [DispId(2539), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2540)]
  string EncryptionProvider { [DispId(2540), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2540), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(2541)]
  bool DoNotPromptForConvert { [DispId(2541), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2541), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2542)]
  bool ForceFullCalculation { [DispId(2542), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(2542), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(2543)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ProtectSharingEx(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object SharingPassword,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat);
}
