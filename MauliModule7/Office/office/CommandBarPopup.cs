// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.CommandBarPopup
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(4288)]
[Guid("000C030A-0000-0000-C000-000000000046")]
[ComImport]
public interface CommandBarPopup : CommandBarControl
{
  [DispId(-5000)]
  new object accParent { [DispId(-5000), TypeLibFunc(1088), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(-5001)]
  new int accChildCount { [DispId(-5001), TypeLibFunc(1088), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(1088)]
  [DispId(-5002)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  new object get_accChild([MarshalAs(UnmanagedType.Struct), In] object varChild);

  [DispId(-5003)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accName([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5004)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accValue([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5005)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accDescription([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5006)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object get_accRole([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5007)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object get_accState([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5008)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accHelp([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5009)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new int get_accHelpTopic([MarshalAs(UnmanagedType.BStr)] out string pszHelpFile, [MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5010)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  new string get_accKeyboardShortcut([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5011)]
  new object accFocus { [TypeLibFunc(1088), DispId(-5011), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(-5012)]
  new object accSelection { [TypeLibFunc(1088), DispId(-5012), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [TypeLibFunc(1088)]
  [DispId(-5013)]
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

  [DispId(-5017)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  new object accHitTest([In] int xLeft, [In] int yTop);

  [DispId(-5018)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void accDoDefaultAction([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5003)]
  [TypeLibFunc(1088)]
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
  new bool BeginGroup { [DispId(1610874880 /*0x60040000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874880 /*0x60040000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874882 /*0x60040002*/)]
  new bool BuiltIn { [DispId(1610874882 /*0x60040002*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874883 /*0x60040003*/)]
  new string Caption { [DispId(1610874883 /*0x60040003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874883 /*0x60040003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874885 /*0x60040005*/)]
  new object Control { [DispId(1610874885 /*0x60040005*/), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610874886 /*0x60040006*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  new CommandBarControl Copy([MarshalAs(UnmanagedType.Struct), In, Optional] object Bar, [MarshalAs(UnmanagedType.Struct), In, Optional] object Before);

  [DispId(1610874887 /*0x60040007*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void Delete([MarshalAs(UnmanagedType.Struct), In, Optional] object Temporary);

  [DispId(1610874888 /*0x60040008*/)]
  new string DescriptionText { [DispId(1610874888 /*0x60040008*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874888 /*0x60040008*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874890 /*0x6004000A*/)]
  new bool Enabled { [DispId(1610874890 /*0x6004000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874890 /*0x6004000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874892 /*0x6004000C*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void Execute();

  [DispId(1610874893 /*0x6004000D*/)]
  new int Height { [DispId(1610874893 /*0x6004000D*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874893 /*0x6004000D*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874895 /*0x6004000F*/)]
  new int HelpContextId { [DispId(1610874895 /*0x6004000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874895 /*0x6004000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874897)]
  new string HelpFile { [DispId(1610874897), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874897), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874899)]
  new int Id { [DispId(1610874899), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874900)]
  new int Index { [DispId(1610874900), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874901)]
  new int InstanceId { [DispId(1610874901), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874902)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  new CommandBarControl Move([MarshalAs(UnmanagedType.Struct), In, Optional] object Bar, [MarshalAs(UnmanagedType.Struct), In, Optional] object Before);

  [DispId(1610874903)]
  new int Left { [DispId(1610874903), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874904)]
  new MsoControlOLEUsage OLEUsage { [DispId(1610874904), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874904), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874906)]
  new string OnAction { [DispId(1610874906), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874906), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874908)]
  new CommandBar Parent { [DispId(1610874908), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610874909)]
  new string Parameter { [DispId(1610874909), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874909), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874911)]
  new int Priority { [DispId(1610874911), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874911), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874913)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void Reset();

  [DispId(1610874914)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void SetFocus();

  [DispId(1610874915)]
  new string Tag { [DispId(1610874915), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874915), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874917)]
  new string TooltipText { [DispId(1610874917), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874917), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874919)]
  new int Top { [DispId(1610874919), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874920)]
  new MsoControlType Type { [DispId(1610874920), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874921)]
  new bool Visible { [DispId(1610874921), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874921), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874923)]
  new int Width { [DispId(1610874923), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874923), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874925)]
  new bool IsPriorityDropped { [DispId(1610874925), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874926)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void Reserved1();

  [DispId(1610874927)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void Reserved2();

  [DispId(1610874928 /*0x60040030*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void Reserved3();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610874929)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void Reserved4();

  [DispId(1610874930)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void Reserved5();

  [DispId(1610874931)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void Reserved6();

  [DispId(1610874932)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  new void Reserved7();

  [DispId(1610940416 /*0x60050000*/)]
  CommandBar CommandBar { [DispId(1610940416 /*0x60050000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610940417 /*0x60050001*/)]
  CommandBarControls Controls { [DispId(1610940417 /*0x60050001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610940418 /*0x60050002*/)]
  MsoOLEMenuGroup OLEMenuGroup { [DispId(1610940418 /*0x60050002*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610940418 /*0x60050002*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
}
