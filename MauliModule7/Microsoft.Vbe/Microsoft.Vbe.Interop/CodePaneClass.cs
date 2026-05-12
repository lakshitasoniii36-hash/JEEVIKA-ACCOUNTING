// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop.CodePaneClass
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[TypeLibType(2)]
[ClassInterface(0)]
[Guid("0002E178-0000-0000-C000-000000000046")]
[ComImport]
public class CodePaneClass : _CodePane, CodePane
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public extern CodePaneClass();

  [DispId(1610743808 /*0x60020000*/)]
  public virtual extern CodePanes Collection { [DispId(1610743808 /*0x60020000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743809 /*0x60020001*/)]
  public virtual extern VBE VBE { [DispId(1610743809 /*0x60020001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743810 /*0x60020002*/)]
  public virtual extern Window Window { [DispId(1610743810 /*0x60020002*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743811 /*0x60020003*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void GetSelection(
    out int StartLine,
    out int StartColumn,
    out int EndLine,
    out int EndColumn);

  [DispId(1610743812 /*0x60020004*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetSelection(
    [In] int StartLine,
    [In] int StartColumn,
    [In] int EndLine,
    [In] int EndColumn);

  [DispId(1610743813 /*0x60020005*/)]
  public virtual extern int TopLine { [DispId(1610743813 /*0x60020005*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610743813 /*0x60020005*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610743815 /*0x60020007*/)]
  public virtual extern int CountOfVisibleLines { [DispId(1610743815 /*0x60020007*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610743816 /*0x60020008*/)]
  public virtual extern CodeModule CodeModule { [DispId(1610743816 /*0x60020008*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610743817 /*0x60020009*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Show();

  [DispId(1610743818 /*0x6002000A*/)]
  public virtual extern vbext_CodePaneview CodePaneView { [DispId(1610743818 /*0x6002000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
}
