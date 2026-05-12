// Decompiled with JetBrains decompiler
// Type: MauliModule7.CachedCReportTrialBalanceNamewise
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
public class CachedCReportTrialBalanceNamewise : Component, ICachedReport
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CachedCReportTrialBalanceNamewise()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CachedCReportTrialBalanceNamewise.__ENCList)
    {
      if (CachedCReportTrialBalanceNamewise.__ENCList.Count == CachedCReportTrialBalanceNamewise.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CachedCReportTrialBalanceNamewise.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CachedCReportTrialBalanceNamewise.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CachedCReportTrialBalanceNamewise.__ENCList[index1] = CachedCReportTrialBalanceNamewise.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CachedCReportTrialBalanceNamewise.__ENCList.RemoveRange(index1, checked (CachedCReportTrialBalanceNamewise.__ENCList.Count - index1));
        CachedCReportTrialBalanceNamewise.__ENCList.Capacity = CachedCReportTrialBalanceNamewise.__ENCList.Count;
      }
      CachedCReportTrialBalanceNamewise.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CachedCReportTrialBalanceNamewise()
  {
    CachedCReportTrialBalanceNamewise.__ENCAddToList((object) this);
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
    CReportTrialBalanceNamewise report = new CReportTrialBalanceNamewise();
    report.Site = this.Site;
    return (ReportDocument) report;
  }

  public virtual string GetCustomizedCacheKey(RequestContext request) => (string) null;
}
