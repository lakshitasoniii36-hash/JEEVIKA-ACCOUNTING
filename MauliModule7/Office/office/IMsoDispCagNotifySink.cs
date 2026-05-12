// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.IMsoDispCagNotifySink
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(4304)]
[Guid("000C0359-0000-0000-C000-000000000046")]
[ComImport]
public interface IMsoDispCagNotifySink
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void InsertClip([MarshalAs(UnmanagedType.IUnknown), In] object pClipMoniker, [MarshalAs(UnmanagedType.IUnknown), In] object pItemMoniker);

  [DispId(2)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void WindowIsClosing();
}
