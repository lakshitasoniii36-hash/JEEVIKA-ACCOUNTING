// Decompiled with JetBrains decompiler
// Type: MauliModule7.CachedCReportBillFullPage14headSR
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
public class CachedCReportBillFullPage14headSR : Component, ICachedReport
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CachedCReportBillFullPage14headSR()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CachedCReportBillFullPage14headSR.__ENCList)
    {
      if (CachedCReportBillFullPage14headSR.__ENCList.Count == CachedCReportBillFullPage14headSR.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CachedCReportBillFullPage14headSR.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CachedCReportBillFullPage14headSR.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CachedCReportBillFullPage14headSR.__ENCList[index1] = CachedCReportBillFullPage14headSR.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CachedCReportBillFullPage14headSR.__ENCList.RemoveRange(index1, checked (CachedCReportBillFullPage14headSR.__ENCList.Count - index1));
        CachedCReportBillFullPage14headSR.__ENCList.Capacity = CachedCReportBillFullPage14headSR.__ENCList.Count;
      }
      CachedCReportBillFullPage14headSR.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CachedCReportBillFullPage14headSR()
  {
    CachedCReportBillFullPage14headSR.__ENCAddToList((object) this);
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

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public virtual TimeSpan CacheTimeOut
  {
    get => CachedReportConstants.DEFAULT_TIMEOUT;
    set
    {
    }
  }

  public virtual ReportDocument CreateReport()
  {
    CReportBillFullPage14headSR report = new CReportBillFullPage14headSR();
    report.Site = this.Site;
    return (ReportDocument) report;
  }

  public virtual string GetCustomizedCacheKey(RequestContext request) => (string) null;
}
