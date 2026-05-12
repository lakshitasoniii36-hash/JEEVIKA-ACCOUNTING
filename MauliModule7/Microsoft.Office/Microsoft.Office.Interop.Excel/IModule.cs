// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IModule
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[Guid("000208AD-0001-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface IModule
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
  string OnDoubleClick { [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1031)]
  string OnSheetActivate { [TypeLibFunc(64 /*0x40*/), LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1081)]
  string OnSheetDeactivate { [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [LCIDConversion(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(998)]
  PageSetup PageSetup { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(503)]
  object Previous { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [TypeLibFunc(1088)]
  [LCIDConversion(7)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate);

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy18();

  [TypeLibFunc(1088)]
  [LCIDConversion(5)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Protect(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DrawingObjects,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Contents,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Scenarios,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UserInterfaceOnly);

  [DispId(292)]
  bool ProtectContents { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy21();

  [DispId(1159)]
  bool ProtectionMode { [LCIDConversion(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(1089)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _Dummy23();

  [TypeLibFunc(1088)]
  [LCIDConversion(9)]
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

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  object InsertFile([MarshalAs(UnmanagedType.Struct), In] object Filename, [MarshalAs(UnmanagedType.Struct), In, Optional] object Merge);

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
    [MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Protect(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object DrawingObjects,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Contents,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Scenarios,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object UserInterfaceOnly);

  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void _PrintOut_2(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void PrintOut(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object From,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object To,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Copies,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Preview,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ActivePrinter,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object PrintToFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Collate);
}
