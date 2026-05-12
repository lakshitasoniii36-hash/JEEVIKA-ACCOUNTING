// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop._dispCommandBarControlEvents_SinkHelper
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[ClassInterface(ClassInterfaceType.None)]
public sealed class _dispCommandBarControlEvents_SinkHelper : _dispCommandBarControlEvents
{
  public _dispCommandBarControlEvents_ClickEventHandler m_ClickDelegate;
  public int m_dwCookie;

  public virtual void Click([In] object obj0, [In] ref bool obj1, [In] ref bool obj2)
  {
    if (this.m_ClickDelegate == null)
      return;
    this.m_ClickDelegate(obj0, ref obj1, ref obj2);
  }

  internal _dispCommandBarControlEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_ClickDelegate = (_dispCommandBarControlEvents_ClickEventHandler) null;
  }
}
