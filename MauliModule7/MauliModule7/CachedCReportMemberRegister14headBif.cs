// Decompiled with JetBrains decompiler
// Type: MauliModule7.CachedCReportMemberRegister14headBif
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MauliModule7;

[ToolboxBitmap(typeof (ExportOptions), "report.bmp")]
public class CachedCReportMemberRegister14headBif : Component, ICachedReport
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CachedCReportMemberRegister14headBif()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CachedCReportMemberRegister14headBif.__ENCList)
    {
      if (CachedCReportMemberRegister14headBif.__ENCList.Count == CachedCReportMemberRegister14headBif.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CachedCReportMemberRegister14headBif.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CachedCReportMemberRegister14headBif.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CachedCReportMemberRegister14headBif.__ENCList[index1] = CachedCReportMemberRegister14headBif.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CachedCReportMemberRegister14headBif.__ENCList.RemoveRange(index1, checked (CachedCReportMemberRegister14headBif.__ENCList.Count - index1));
        CachedCReportMemberRegister14headBif.__ENCList.Capacity = CachedCReportMemberRegister14headBif.__ENCList.Count;
      }
      CachedCReportMemberRegister14headBif.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CachedCReportMemberRegister14headBif()
  {
    CachedCReportMemberRegister14headBif.__ENCAddToList((object) this);
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public virtual bool IsCacheable
  {
    get => true;
    set
    {
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public virtual bool ShareDBLogonInfo
  {
    get => false;
    set
    {
    }
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public virtual TimeSpan CacheTimeOut
  {
    get => CachedReportConstants.DEFAULT_TIMEOUT;
    set
    {
    }
  }

  public virtual ReportDocument CreateReport()
  {
    CReportMemberRegister14headBif report = new CReportMemberRegister14headBif();
    report.Site = this.Site;
    return (ReportDocument) report;
  }

  public virtual string GetCustomizedCacheKey(RequestContext request) => (string) null;
}
