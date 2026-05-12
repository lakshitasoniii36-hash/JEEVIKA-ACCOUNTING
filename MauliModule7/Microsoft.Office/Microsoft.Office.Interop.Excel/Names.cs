// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.Names
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[InterfaceType(2)]
[DefaultMember("_Default")]
[Guid("000208B8-0000-0000-C000-000000000046")]
[TypeLibType(4096 /*0x1000*/)]
[ComImport]
public interface Names
{
  [DispId(148)]
  Application Application { [DispId(148), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [DispId(149), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [DispId(150), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(181)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Name Add(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Name,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object RefersTo,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Visible,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object MacroType,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object ShortcutKey,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Category,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object NameLocal,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object RefersToLocal,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object CategoryLocal,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object RefersToR1C1,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object RefersToR1C1Local);

  [DispId(170)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Name Item([MarshalAs(UnmanagedType.Struct), In, Optional] object Index, [MarshalAs(UnmanagedType.Struct), In, Optional] object IndexLocal, [MarshalAs(UnmanagedType.Struct), In, Optional] object RefersTo);

  [TypeLibFunc(1024 /*0x0400*/)]
  [DispId(0)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Name _Default([MarshalAs(UnmanagedType.Struct), In, Optional] object Index, [MarshalAs(UnmanagedType.Struct), In, Optional] object IndexLocal, [MarshalAs(UnmanagedType.Struct), In, Optional] object RefersTo);

  [DispId(118)]
  int Count { [DispId(118), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(-4)]
  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  IEnumerator GetEnumerator();
}
