// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.CommandBar
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[Guid("000C0304-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
[ComImport]
public interface CommandBar : _IMsoOleAccDispObj
{
  [DispId(-5000)]
  new object accParent { [TypeLibFunc(1088), DispId(-5000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(-5001)]
  new int accChildCount { [TypeLibFunc(1088), DispId(-5001), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(1088)]
  [DispId(-5002)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  new object get_accChild([MarshalAs(UnmanagedType.Struct), In] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5003)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accName([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5004)]
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

  [TypeLibFunc(1088)]
  [DispId(-5009)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new int get_accHelpTopic([MarshalAs(UnmanagedType.BStr)] out string pszHelpFile, [MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5010)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accKeyboardShortcut([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5011)]
  new object accFocus { [TypeLibFunc(1088), DispId(-5011), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(-5012)]
  new object accSelection { [DispId(-5012), TypeLibFunc(1088), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [TypeLibFunc(1088)]
  [DispId(-5013)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accDefaultAction([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5014)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void accSelect([In] int flagsSelect, [MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5015)]
  [TypeLibFunc(1088)]
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

  [DispId(-5017)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object accHitTest([In] int xLeft, [In] int yTop);

  [TypeLibFunc(1088)]
  [DispId(-5018)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void accDoDefaultAction([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5003)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void set_accName([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild, [MarshalAs(UnmanagedType.BStr), In, Optional] string pszName);

  [DispId(-5004)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void set_accValue([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild, [MarshalAs(UnmanagedType.BStr), In, Optional] string pszValue);

  [DispId(1610809344 /*0x60030000*/)]
  new object Application { [DispId(1610809344 /*0x60030000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809345 /*0x60030001*/)]
  new int Creator { [DispId(1610809345 /*0x60030001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874880 /*0x60040000*/)]
  bool BuiltIn { [DispId(1610874880 /*0x60040000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874881 /*0x60040001*/)]
  string Context { [DispId(1610874881 /*0x60040001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874881 /*0x60040001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874883 /*0x60040003*/)]
  CommandBarControls Controls { [DispId(1610874883 /*0x60040003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610874884 /*0x60040004*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Delete();

  [DispId(1610874885 /*0x60040005*/)]
  bool Enabled { [DispId(1610874885 /*0x60040005*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874885 /*0x60040005*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874887 /*0x60040007*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  CommandBarControl FindControl(
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Type,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Id,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Tag,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Visible,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object Recursive);

  [DispId(1610874888 /*0x60040008*/)]
  int Height { [DispId(1610874888 /*0x60040008*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874888 /*0x60040008*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874890 /*0x6004000A*/)]
  int Index { [DispId(1610874890 /*0x6004000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874891 /*0x6004000B*/)]
  int InstanceId { [TypeLibFunc(64 /*0x40*/), DispId(1610874891 /*0x6004000B*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874892 /*0x6004000C*/)]
  int Left { [DispId(1610874892 /*0x6004000C*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874892 /*0x6004000C*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874894 /*0x6004000E*/)]
  string Name { [DispId(1610874894 /*0x6004000E*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874894 /*0x6004000E*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874896 /*0x60040010*/)]
  string NameLocal { [DispId(1610874896 /*0x60040010*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874896 /*0x60040010*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874898)]
  object Parent { [DispId(1610874898), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610874899)]
  MsoBarPosition Position { [DispId(1610874899), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874899), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874901)]
  int RowIndex { [DispId(1610874901), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874901), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874903)]
  MsoBarProtection Protection { [DispId(1610874903), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874903), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874905)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Reset();

  [DispId(1610874906)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ShowPopup([MarshalAs(UnmanagedType.Struct), In, Optional] object x, [MarshalAs(UnmanagedType.Struct), In, Optional] object y);

  [DispId(1610874907)]
  int Top { [DispId(1610874907), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874907), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874909)]
  MsoBarType Type { [DispId(1610874909), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874910)]
  bool Visible { [DispId(1610874910), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874910), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874912 /*0x60040020*/)]
  int Width { [DispId(1610874912 /*0x60040020*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874912 /*0x60040020*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874914)]
  bool AdaptiveMenu { [DispId(1610874914), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874914), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874916)]
  int Id { [DispId(1610874916), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
}
