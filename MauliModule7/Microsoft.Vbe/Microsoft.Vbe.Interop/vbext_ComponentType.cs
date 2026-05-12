// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop.vbext_ComponentType
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[Guid("BE39F3D5-1B13-11D0-887F-00A0C90F2744")]
public enum vbext_ComponentType
{
  vbext_ct_StdModule = 1,
  vbext_ct_ClassModule = 2,
  vbext_ct_MSForm = 3,
  vbext_ct_ActiveXDesigner = 11, // 0x0000000B
  vbext_ct_Document = 100, // 0x00000064
}
