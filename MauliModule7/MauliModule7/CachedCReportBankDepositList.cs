// Decompiled with JetBrains decompiler
// Type: MauliModule7.CachedCReportBankDepositList
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
public class CachedCReportBankDepositList : Component, ICachedReport
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CachedCReportBankDepositList()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CachedCReportBankDepositList.__ENCList)
    {
      if (CachedCReportBankDepositList.__ENCList.Count == CachedCReportBankDepositList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CachedCReportBankDepositList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CachedCReportBankDepositList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CachedCReportBankDepositList.__ENCList[index1] = CachedCReportBankDepositList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CachedCReportBankDepositList.__ENCList.RemoveRange(index1, checked (CachedCReportBankDepositList.__ENCList.Count - index1));
        CachedCReportBankDepositList.__ENCList.Capacity = CachedCReportBankDepositList.__ENCList.Count;
      }
      CachedCReportBankDepositList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CachedCReportBankDepositList()
  {
    CachedCReportBankDepositList.__ENCAddToList((object) this);
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
    CReportBankDepositList report = new CReportBankDepositList();
    report.Site = this.Site;
    return (ReportDocument) report;
  }

  public virtual string GetCustomizedCacheKey(RequestContext request) => (string) null;
}
