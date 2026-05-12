// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.IToolbarButtons
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[Guid("0002085F-0001-0000-C000-000000000046")]
[TypeLibType(4112)]
[ComImport]
public interface IToolbarButtons : IEnumerable
{
  [DispId(148)]
  Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ToolbarButton Add(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Button,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Before,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object OnAction,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Pushed,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Enabled,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object StatusBar,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object HelpFile,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object HelpContextID);

  [DispId(118)]
  int Count { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  ToolbarButton get_Item([In] int Index);

  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();

  [DispId(0)]
  [IndexerName("_Default")]
  ToolbarButton this[[In] int Index] { [TypeLibFunc(1024 /*0x0400*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
}
