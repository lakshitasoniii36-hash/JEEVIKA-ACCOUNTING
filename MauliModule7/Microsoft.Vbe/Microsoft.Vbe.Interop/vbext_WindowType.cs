// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop.vbext_WindowType
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[Guid("BE39F3DB-1B13-11D0-887F-00A0C90F2744")]
public enum vbext_WindowType
{
  vbext_wt_CodeWindow = 0,
  vbext_wt_Designer = 1,
  vbext_wt_Browser = 2,
  vbext_wt_Watch = 3,
  vbext_wt_Locals = 4,
  vbext_wt_Immediate = 5,
  vbext_wt_ProjectWindow = 6,
  vbext_wt_PropertyWindow = 7,
  vbext_wt_Find = 8,
  vbext_wt_FindReplace = 9,
  vbext_wt_Toolbox = 10, // 0x0000000A
  vbext_wt_LinkedWindowFrame = 11, // 0x0000000B
  vbext_wt_MainWindow = 12, // 0x0000000C
  vbext_wt_ToolWindow = 15, // 0x0000000F
}
