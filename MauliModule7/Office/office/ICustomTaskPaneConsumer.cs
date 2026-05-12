// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.ICustomTaskPaneConsumer
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[Guid("000C033E-0000-0000-C000-000000000046")]
[TypeLibType(4288)]
[ComImport]
public interface ICustomTaskPaneConsumer
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void CTPFactoryAvailable([MarshalAs(UnmanagedType.Interface), In] ICTPFactory CTPFactoryInst);
}
