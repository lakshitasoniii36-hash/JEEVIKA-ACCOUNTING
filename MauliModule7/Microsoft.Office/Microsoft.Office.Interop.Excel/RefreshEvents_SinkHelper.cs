// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.RefreshEvents_SinkHelper
// Assembly: Microsoft.Office.Interop.Excel, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 201AF11D-0E77-491F-92E5-AC46D3FEB35B
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Excel.dll

using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel;

[ClassInterface(ClassInterfaceType.None)]
public sealed class RefreshEvents_SinkHelper : RefreshEvents
{
  public RefreshEvents_AfterRefreshEventHandler m_AfterRefreshDelegate;
  public RefreshEvents_BeforeRefreshEventHandler m_BeforeRefreshDelegate;
  public int m_dwCookie;

  public virtual void AfterRefresh([In] bool obj0)
  {
    if (this.m_AfterRefreshDelegate == null)
      return;
    this.m_AfterRefreshDelegate(obj0);
  }

  public virtual void BeforeRefresh([In] ref bool obj0)
  {
    if (this.m_BeforeRefreshDelegate == null)
      return;
    this.m_BeforeRefreshDelegate(ref obj0);
  }

  internal RefreshEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_AfterRefreshDelegate = (RefreshEvents_AfterRefreshEventHandler) null;
    this.m_BeforeRefreshDelegate = (RefreshEvents_BeforeRefreshEventHandler) null;
  }
}
