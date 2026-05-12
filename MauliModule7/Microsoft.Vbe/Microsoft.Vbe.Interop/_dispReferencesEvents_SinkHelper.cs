// Decompiled with JetBrains decompiler
// Type: Microsoft.Vbe.Interop._dispReferencesEvents_SinkHelper
// Assembly: Microsoft.Vbe.Interop, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: BF75DD26-529A-4A74-BB16-05FDA8592B17
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Vbe.Interop.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Vbe.Interop;

[ClassInterface(ClassInterfaceType.None)]
public sealed class _dispReferencesEvents_SinkHelper : _dispReferencesEvents
{
  public _dispReferencesEvents_ItemRemovedEventHandler m_ItemRemovedDelegate;
  public _dispReferencesEvents_ItemAddedEventHandler m_ItemAddedDelegate;
  public int m_dwCookie;

  public virtual void ItemRemoved([In] Reference obj0)
  {
    if (this.m_ItemRemovedDelegate == null)
      return;
    this.m_ItemRemovedDelegate(obj0);
  }

  public virtual void ItemAdded([In] Reference obj0)
  {
    if (this.m_ItemAddedDelegate == null)
      return;
    this.m_ItemAddedDelegate(obj0);
  }

  internal _dispReferencesEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_ItemRemovedDelegate = (_dispReferencesEvents_ItemRemovedEventHandler) null;
    this.m_ItemAddedDelegate = (_dispReferencesEvents_ItemAddedEventHandler) null;
  }
}
