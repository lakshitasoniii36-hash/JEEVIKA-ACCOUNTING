// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.IMsoLeaderLines
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[Guid("000C1723-0000-0000-C000-000000000046")]
[TypeLibType(4304)]
[ComImport]
public interface IMsoLeaderLines
{
  [DispId(235)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Select();

  [DispId(128 /*0x80*/)]
  IMsoBorder Border { [DispId(128 /*0x80*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

  [DispId(117)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void Delete();

  [DispId(1610743811 /*0x60020003*/)]
  IMsoChartFormat Format { [DispId(1610743811 /*0x60020003*/), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
}
