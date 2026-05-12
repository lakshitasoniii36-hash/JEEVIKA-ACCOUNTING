// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.IDocumentInspector
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[TypeLibType(256 /*0x0100*/)]
[InterfaceType(1)]
[Guid("000CD706-0000-0000-C000-000000000046")]
[ComImport]
public interface IDocumentInspector
{
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void GetInfo([MarshalAs(UnmanagedType.BStr)] out string Name, [MarshalAs(UnmanagedType.BStr)] out string Desc);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Inspect([MarshalAs(UnmanagedType.IDispatch), In] object Doc, out MsoDocInspectorStatus Status, [MarshalAs(UnmanagedType.BStr)] out string Result, [MarshalAs(UnmanagedType.BStr)] out string Action);

  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Fix([MarshalAs(UnmanagedType.IDispatch), In] object Doc, [In] int Hwnd, out MsoDocInspectorStatus Status, [MarshalAs(UnmanagedType.BStr)] out string Result);
}
