// Decompiled with JetBrains decompiler
// Type: MauliModule7.CachedCReportBillFullPageWithReceipt21HeadNew5
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
public class CachedCReportBillFullPageWithReceipt21HeadNew5 : Component, ICachedReport
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CachedCReportBillFullPageWithReceipt21HeadNew5()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CachedCReportBillFullPageWithReceipt21HeadNew5.__ENCList)
    {
      if (CachedCReportBillFullPageWithReceipt21HeadNew5.__ENCList.Count == CachedCReportBillFullPageWithReceipt21HeadNew5.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CachedCReportBillFullPageWithReceipt21HeadNew5.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CachedCReportBillFullPageWithReceipt21HeadNew5.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CachedCReportBillFullPageWithReceipt21HeadNew5.__ENCList[index1] = CachedCReportBillFullPageWithReceipt21HeadNew5.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CachedCReportBillFullPageWithReceipt21HeadNew5.__ENCList.RemoveRange(index1, checked (CachedCReportBillFullPageWithReceipt21HeadNew5.__ENCList.Count - index1));
        CachedCReportBillFullPageWithReceipt21HeadNew5.__ENCList.Capacity = CachedCReportBillFullPageWithReceipt21HeadNew5.__ENCList.Count;
      }
      CachedCReportBillFullPageWithReceipt21HeadNew5.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CachedCReportBillFullPageWithReceipt21HeadNew5()
  {
    CachedCReportBillFullPageWithReceipt21HeadNew5.__ENCAddToList((object) this);
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
    CReportBillFullPageWithReceipt21HeadNew5 report = new CReportBillFullPageWithReceipt21HeadNew5();
    report.Site = this.Site;
    return (ReportDocument) report;
  }

  public virtual string GetCustomizedCacheKey(RequestContext request) => (string) null;
}
