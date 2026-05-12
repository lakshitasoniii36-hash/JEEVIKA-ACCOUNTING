// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop._CodeModule
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[DefaultMember("Name")]
[Guid("0002E16E-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
[ComImport]
public interface _CodeModule
{
  [DispId(1610743808 /*0x60020000*/)]
  VBComponent Parent { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  VBE VBE { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(0)]
  string Name { [TypeLibFunc(64 /*0x40*/), DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(0), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610743812 /*0x60020004*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddFromString([MarshalAs(UnmanagedType.BStr), In] string String);

  [DispId(1610743813 /*0x60020005*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void AddFromFile([MarshalAs(UnmanagedType.BStr), In] string FileName);

  [DispId(1610743814 /*0x60020006*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string get_Lines([In] int StartLine, [In] int Count);

  [DispId(1610743815 /*0x60020007*/)]
  int CountOfLines { [DispId(1610743815 /*0x60020007*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610743816 /*0x60020008*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertLines([In] int Line, [MarshalAs(UnmanagedType.BStr), In] string String);

  [DispId(1610743817 /*0x60020009*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void DeleteLines([In] int StartLine, [In] int Count = 1);

  [DispId(1610743818 /*0x6002000A*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ReplaceLine([In] int Line, [MarshalAs(UnmanagedType.BStr), In] string String);

  [DispId(1610743819 /*0x6002000B*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int get_ProcStartLine([MarshalAs(UnmanagedType.BStr), In] string ProcName, [In] vbext_ProcKind ProcKind);

  [DispId(1610743820 /*0x6002000C*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int get_ProcCountLines([MarshalAs(UnmanagedType.BStr), In] string ProcName, [In] vbext_ProcKind ProcKind);

  [DispId(1610743821 /*0x6002000D*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int get_ProcBodyLine([MarshalAs(UnmanagedType.BStr), In] string ProcName, [In] vbext_ProcKind ProcKind);

  [DispId(1610743822 /*0x6002000E*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  string get_ProcOfLine([In] int Line, out vbext_ProcKind ProcKind);

  [DispId(1610743823 /*0x6002000F*/)]
  int CountOfDeclarationLines { [DispId(1610743823 /*0x6002000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610743824 /*0x60020010*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  int CreateEventProc([MarshalAs(UnmanagedType.BStr), In] string EventName, [MarshalAs(UnmanagedType.BStr), In] string ObjectName);

  [DispId(1610743825)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Find(
    [MarshalAs(UnmanagedType.BStr), In] string Target,
    [In, Out] ref int StartLine,
    [In, Out] ref int StartColumn,
    [In, Out] ref int EndLine,
    [In, Out] ref int EndColumn,
    [In] bool WholeWord = false,
    [In] bool MatchCase = false,
    [In] bool PatternSearch = false);

  [DispId(1610743826)]
  CodePane CodePane { [DispId(1610743826), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
}
