// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IDialog
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[TypeLibType(4112)]
[Guid("0002087A-0001-0000-C000-000000000046")]
[ComImport]
public interface IDialog
{
  [DispId(148)]
  Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  bool Show(
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
}
