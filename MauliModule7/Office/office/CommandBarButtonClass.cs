// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.CommandBarButtonClass
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using stdole;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[ComSourceInterfaces("Microsoft.Office.Core._CommandBarButtonEvents\0\0")]
[ClassInterface(0)]
[Guid("55F88891-7708-11D1-ACEB-006008961DA5")]
[ComImport]
public class CommandBarButtonClass : 
  _CommandBarButton,
  CommandBarButton,
  _CommandBarButtonEvents_Event
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  internal extern CommandBarButtonClass();

  [DispId(-5000)]
  public virtual extern object accParent { [TypeLibFunc(1088), DispId(-5000), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(-5001)]
  public virtual extern int accChildCount { [DispId(-5001), TypeLibFunc(1088), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [TypeLibFunc(1088)]
  [DispId(-5002)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.IDispatch)]
  public virtual extern object get_accChild([MarshalAs(UnmanagedType.Struct), In] object varChild);

  [DispId(-5003)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string get_accName([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5004)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string get_accValue([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5005)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string get_accDescription([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5006)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object get_accRole([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5007)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object get_accState([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5008)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string get_accHelp([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5009)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern int get_accHelpTopic([MarshalAs(UnmanagedType.BStr)] out string pszHelpFile, [MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5010)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string get_accKeyboardShortcut([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5011)]
  public virtual extern object accFocus { [DispId(-5011), TypeLibFunc(1088), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(-5012)]
  public virtual extern object accSelection { [TypeLibFunc(1088), DispId(-5012), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; }

  [DispId(-5013)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.BStr)]
  public virtual extern string get_accDefaultAction([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5014)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void accSelect([In] int flagsSelect, [MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5015)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void accLocation(
    out int pxLeft,
    out int pyTop,
    out int pcxWidth,
    out int pcyHeight,
    [MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [TypeLibFunc(1088)]
  [DispId(-5016)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object accNavigate([In] int navDir, [MarshalAs(UnmanagedType.Struct), In, Optional] object varStart);

  [DispId(-5017)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Struct)]
  public virtual extern object accHitTest([In] int xLeft, [In] int yTop);

  [DispId(-5018)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void accDoDefaultAction([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild);

  [DispId(-5003)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void set_accName([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild, [MarshalAs(UnmanagedType.BStr), In, Optional] string pszName);

  [DispId(-5004)]
  [TypeLibFunc(1088)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void set_accValue([MarshalAs(UnmanagedType.Struct), In, Optional] object varChild, [MarshalAs(UnmanagedType.BStr), In, Optional] string pszValue);

  [DispId(1610809344 /*0x60030000*/)]
  public virtual extern object Application { [DispId(1610809344 /*0x60030000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610809345 /*0x60030001*/)]
  public virtual extern int Creator { [DispId(1610809345 /*0x60030001*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874880 /*0x60040000*/)]
  public virtual extern bool BeginGroup { [DispId(1610874880 /*0x60040000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874880 /*0x60040000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874882 /*0x60040002*/)]
  public virtual extern bool BuiltIn { [DispId(1610874882 /*0x60040002*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874883 /*0x60040003*/)]
  public virtual extern string Caption { [DispId(1610874883 /*0x60040003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874883 /*0x60040003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874885 /*0x60040005*/)]
  public virtual extern object Control { [TypeLibFunc(64 /*0x40*/), DispId(1610874885 /*0x60040005*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IDispatch)] get; }

  [DispId(1610874886 /*0x60040006*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CommandBarControl Copy([MarshalAs(UnmanagedType.Struct), In, Optional] object Bar, [MarshalAs(UnmanagedType.Struct), In, Optional] object Before);

  [DispId(1610874887 /*0x60040007*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Delete([MarshalAs(UnmanagedType.Struct), In, Optional] object Temporary);

  [DispId(1610874888 /*0x60040008*/)]
  public virtual extern string DescriptionText { [DispId(1610874888 /*0x60040008*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874888 /*0x60040008*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874890 /*0x6004000A*/)]
  public virtual extern bool Enabled { [DispId(1610874890 /*0x6004000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874890 /*0x6004000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874892 /*0x6004000C*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Execute();

  [DispId(1610874893 /*0x6004000D*/)]
  public virtual extern int Height { [DispId(1610874893 /*0x6004000D*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874893 /*0x6004000D*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874895 /*0x6004000F*/)]
  public virtual extern int HelpContextId { [DispId(1610874895 /*0x6004000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874895 /*0x6004000F*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874897)]
  public virtual extern string HelpFile { [DispId(1610874897), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874897), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874899)]
  public virtual extern int Id { [DispId(1610874899), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874900)]
  public virtual extern int Index { [DispId(1610874900), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874901)]
  public virtual extern int InstanceId { [DispId(1610874901), TypeLibFunc(64 /*0x40*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874902)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  [return: MarshalAs(UnmanagedType.Interface)]
  public virtual extern CommandBarControl Move([MarshalAs(UnmanagedType.Struct), In, Optional] object Bar, [MarshalAs(UnmanagedType.Struct), In, Optional] object Before);

  [DispId(1610874903)]
  public virtual extern int Left { [DispId(1610874903), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874904)]
  public virtual extern MsoControlOLEUsage OLEUsage { [DispId(1610874904), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874904), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874906)]
  public virtual extern string OnAction { [DispId(1610874906), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874906), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874908)]
  public virtual extern CommandBar Parent { [DispId(1610874908), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(1610874909)]
  public virtual extern string Parameter { [DispId(1610874909), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874909), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874911)]
  public virtual extern int Priority { [DispId(1610874911), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874911), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874913)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Reset();

  [DispId(1610874914)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void SetFocus();

  [DispId(1610874915)]
  public virtual extern string Tag { [DispId(1610874915), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874915), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874917)]
  public virtual extern string TooltipText { [DispId(1610874917), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610874917), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610874919)]
  public virtual extern int Top { [DispId(1610874919), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874920)]
  public virtual extern MsoControlType Type { [DispId(1610874920), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874921)]
  public virtual extern bool Visible { [DispId(1610874921), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874921), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874923)]
  public virtual extern int Width { [DispId(1610874923), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610874923), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610874925)]
  public virtual extern bool IsPriorityDropped { [DispId(1610874925), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

  [DispId(1610874926)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Reserved1();

  [DispId(1610874927)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Reserved2();

  [DispId(1610874928 /*0x60040030*/)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Reserved3();

  [DispId(1610874929)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Reserved4();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610874930)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Reserved5();

  [TypeLibFunc(64 /*0x40*/)]
  [DispId(1610874931)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Reserved6();

  [DispId(1610874932)]
  [TypeLibFunc(64 /*0x40*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void Reserved7();

  [DispId(1610940416 /*0x60050000*/)]
  public virtual extern bool BuiltInFace { [DispId(1610940416 /*0x60050000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610940416 /*0x60050000*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610940418 /*0x60050002*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void CopyFace();

  [DispId(1610940419 /*0x60050003*/)]
  public virtual extern int FaceId { [DispId(1610940419 /*0x60050003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610940419 /*0x60050003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610940421 /*0x60050005*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void PasteFace();

  [DispId(1610940422 /*0x60050006*/)]
  public virtual extern string ShortcutText { [DispId(1610940422 /*0x60050006*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1610940422 /*0x60050006*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

  [DispId(1610940424 /*0x60050008*/)]
  public virtual extern MsoButtonState State { [DispId(1610940424 /*0x60050008*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610940424 /*0x60050008*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610940426 /*0x6005000A*/)]
  public virtual extern MsoButtonStyle Style { [DispId(1610940426 /*0x6005000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610940426 /*0x6005000A*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [DispId(1610940428 /*0x6005000C*/)]
  public virtual extern MsoCommandBarButtonHyperlinkType HyperlinkType { [DispId(1610940428 /*0x6005000C*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1610940428 /*0x6005000C*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

  [ComAliasName("stdole.IPictureDisp")]
  [DispId(1610940430 /*0x6005000E*/)]
  public virtual extern IPictureDisp Picture { [DispId(1610940430 /*0x6005000E*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("stdole.IPictureDisp"), MarshalAs(UnmanagedType.Interface)] get; [DispId(1610940430 /*0x6005000E*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: ComAliasName("stdole.IPictureDisp"), MarshalAs(UnmanagedType.Interface), In] set; }

  [DispId(1610940432 /*0x60050010*/)]
  [ComAliasName("stdole.IPictureDisp")]
  public virtual extern IPictureDisp Mask { [DispId(1610940432 /*0x60050010*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: ComAliasName("stdole.IPictureDisp"), MarshalAs(UnmanagedType.Interface)] get; [DispId(1610940432 /*0x60050010*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: ComAliasName("stdole.IPictureDisp"), MarshalAs(UnmanagedType.Interface), In] set; }

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void add_Click([In] _CommandBarButtonEvents_ClickEventHandler obj0);

  public virtual extern event _CommandBarButtonEvents_ClickEventHandler Click;

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  public virtual extern void remove_Click([In] _CommandBarButtonEvents_ClickEventHandler obj0);
}
