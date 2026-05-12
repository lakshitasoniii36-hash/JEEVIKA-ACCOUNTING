// Decompiled with JetBrains decompiler
// Type: MauliModule7.CachedCReportBillRegister14headVerticalsqftLine
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
public class CachedCReportBillRegister14headVerticalsqftLine : Component, ICachedReport
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CachedCReportBillRegister14headVerticalsqftLine()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CachedCReportBillRegister14headVerticalsqftLine.__ENCList)
    {
      if (CachedCReportBillRegister14headVerticalsqftLine.__ENCList.Count == CachedCReportBillRegister14headVerticalsqftLine.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CachedCReportBillRegister14headVerticalsqftLine.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CachedCReportBillRegister14headVerticalsqftLine.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CachedCReportBillRegister14headVerticalsqftLine.__ENCList[index1] = CachedCReportBillRegister14headVerticalsqftLine.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CachedCReportBillRegister14headVerticalsqftLine.__ENCList.RemoveRange(index1, checked (CachedCReportBillRegister14headVerticalsqftLine.__ENCList.Count - index1));
        CachedCReportBillRegister14headVerticalsqftLine.__ENCList.Capacity = CachedCReportBillRegister14headVerticalsqftLine.__ENCList.Count;
      }
      CachedCReportBillRegister14headVerticalsqftLine.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CachedCReportBillRegister14headVerticalsqftLine()
  {
    CachedCReportBillRegister14headVerticalsqftLine.__ENCAddToList((object) this);
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

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
    CReportBillRegister14headVerticalsqftLine report = new CReportBillRegister14headVerticalsqftLine();
    report.Site = this.Site;
    return (ReportDocument) report;
  }

  public virtual string GetCustomizedCacheKey(RequestContext request) => (string) null;
}
