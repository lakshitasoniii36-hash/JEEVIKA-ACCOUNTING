// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.IAssistance
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(4288)]
[Guid("4291224C-DEFE-485B-8E69-6CF8AA85CB76")]
[ComImport]
public interface IAssistance
{
  [DispId(1610743808 /*0x60020000*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ShowHelp([MarshalAs(UnmanagedType.BStr), In] string HelpId = "", [MarshalAs(UnmanagedType.BStr), In] string Scope = "");

  [DispId(1610743809 /*0x60020001*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SearchHelp([MarshalAs(UnmanagedType.BStr), In] string Query, [MarshalAs(UnmanagedType.BStr), In] string Scope = "");

  [DispId(1610743810 /*0x60020002*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void SetDefaultContext([MarshalAs(UnmanagedType.BStr), In] string HelpId);

  [DispId(1610743811 /*0x60020003*/)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void ClearDefaultContext([MarshalAs(UnmanagedType.BStr), In] string HelpId);
}
