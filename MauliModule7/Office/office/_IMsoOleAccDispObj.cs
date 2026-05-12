// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core._IMsoOleAccDispObj
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(4304)]
[Guid("000C0301-0000-0000-C000-000000000046")]
[ComImport]
public interface _IMsoOleAccDispObj : IAccessible
{
  [DispId(-5000)]
  new object accParent { [DispId(-5000), TypeLibFunc(1088), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(-5001)]
  new int accChildCount { [DispId(-5001), TypeLibFunc(1088), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(-5002)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  new object get_accChild([MarshalAs(UnmanagedType.Struct), In] object varChild);

  [DispId(-5003)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accName([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5004)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accValue([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5005)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accDescription([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5006)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object get_accRole([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5007)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object get_accState([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5008)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accHelp([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5009)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new int get_accHelpTopic([MarshalAs(UnmanagedType.BStr)] out string pszHelpFile, [MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5010)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accKeyboardShortcut([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5011)]
  new object accFocus { [DispId(-5011), TypeLibFunc(1088), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(-5012)]
  new object accSelection { [DispId(-5012), TypeLibFunc(1088), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(-5013)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accDefaultAction([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5014)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void accSelect([In] int flagsSelect, [MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5015)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void accLocation(
    out int pxLeft,
    out int pyTop,
    out int pcxWidth,
    out int pcyHeight,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5016)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object accNavigate([In] int navDir, [MarshalAs(UnmanagedType.Struct), In, Optional] object varStart);

  [TypeLibFunc(1088)]
  [DispId(-5017)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object accHitTest([In] int xLeft, [In] int yTop);

  [TypeLibFunc(1088)]
  [DispId(-5018)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void accDoDefaultAction([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5003)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void set_accName([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild, [MarshalAs(UnmanagedType.BStr), In, Optional] string pszName);

  [TypeLibFunc(1088)]
  [DispId(-5004)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void set_accValue([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild, [MarshalAs(UnmanagedType.BStr), In, Optional] string pszValue);

  [DispId(1610809344 /*0x60030000*/)]
  object Application { [DispId(1610809344 /*0x60030000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809345 /*0x60030001*/)]
  int Creator { [DispId(1610809345 /*0x60030001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
}
