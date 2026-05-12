// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.INames
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

[TypeLibType(4112)]
[DefaultMember("_Default")]
[Guid("000208B8-0001-0000-C000-000000000046")]
[ComImport]
public interface INames : IEnumerable
{
  [DispId(148)]
  Application Application { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(149)]
  XlCreator Creator { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(150)]
  object Parent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
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

  [LCIDConversion(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Name Item([MarshalAs(UnmanagedType.Struct), In, Optional] object Index, [MarshalAs(UnmanagedType.Struct), In, Optional] object IndexLocal, [MarshalAs(UnmanagedType.Struct), In, Optional] object RefersTo);

  [TypeLibFunc(1024 /*0x0400*/)]
  [LCIDConversion(3)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  Name _Default([MarshalAs(UnmanagedType.Struct), In, Optional] object Index, [MarshalAs(UnmanagedType.Struct), In, Optional] object IndexLocal, [MarshalAs(UnmanagedType.Struct), In, Optional] object RefersTo);

  [DispId(118)]
  int Count { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(1024 /*0x0400*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (EnumeratorToEnumVariantMarshaler))]
  new IEnumerator GetEnumerator();
}
