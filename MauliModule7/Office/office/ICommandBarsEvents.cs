// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Core.ICommandBarsEvents
// Assembly: office, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: B995883C-34F0-4A0F-9779-9CEB61E0CAD4
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\office.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Core;

[Guid("55F88892-7708-11D1-ACEB-006008961DA5")]
[TypeLibType(4304)]
[ComImport]
public interface ICommandBarsEvents
{
  [DispId(1)]
  [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
  void OnUpdate();
}
