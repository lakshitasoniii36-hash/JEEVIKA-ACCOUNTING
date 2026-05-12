// Decompiled with JetBrains decompiler
// Type: MauliModule7.CachedCReprotCashBankNewGroup
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
public class CachedCReprotCashBankNewGroup : Component, ICachedReport
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CachedCReprotCashBankNewGroup()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CachedCReprotCashBankNewGroup.__ENCList)
    {
      if (CachedCReprotCashBankNewGroup.__ENCList.Count == CachedCReprotCashBankNewGroup.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CachedCReprotCashBankNewGroup.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CachedCReprotCashBankNewGroup.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CachedCReprotCashBankNewGroup.__ENCList[index1] = CachedCReprotCashBankNewGroup.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CachedCReprotCashBankNewGroup.__ENCList.RemoveRange(index1, checked (CachedCReprotCashBankNewGroup.__ENCList.Count - index1));
        CachedCReprotCashBankNewGroup.__ENCList.Capacity = CachedCReprotCashBankNewGroup.__ENCList.Count;
      }
      CachedCReprotCashBankNewGroup.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CachedCReprotCashBankNewGroup()
  {
    CachedCReprotCashBankNewGroup.__ENCAddToList((object) this);
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
    CReprotCashBankNewGroup report = new CReprotCashBankNewGroup();
    report.Site = this.Site;
    return (ReportDocument) report;
  }

  public virtual string GetCustomizedCacheKey(RequestContext request) => (string) null;
}
