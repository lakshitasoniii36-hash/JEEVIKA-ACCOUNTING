// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop._ProjectTemplate
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[TypeLibType(4176)]
[Guid("0002E159-0000-0000-C000-000000000046")]
[ComImport]
public interface _ProjectTemplate
{
  [DispId(1)]
  Application Application { [TypeLibFunc(64 /*0x40*/), DispId(1), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(2)]
  Application Parent { [TypeLibFunc(64 /*0x40*/), DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
}
