// Decompiled with JetBrains decompiler
// Type: MauliModule7.CachedIregisterBlankLegal
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
public class CachedIregisterBlankLegal : Component, ICachedReport
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CachedIregisterBlankLegal()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CachedIregisterBlankLegal.__ENCList)
    {
      if (CachedIregisterBlankLegal.__ENCList.Count == CachedIregisterBlankLegal.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CachedIregisterBlankLegal.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CachedIregisterBlankLegal.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CachedIregisterBlankLegal.__ENCList[index1] = CachedIregisterBlankLegal.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CachedIregisterBlankLegal.__ENCList.RemoveRange(index1, checked (CachedIregisterBlankLegal.__ENCList.Count - index1));
        CachedIregisterBlankLegal.__ENCList.Capacity = CachedIregisterBlankLegal.__ENCList.Count;
      }
      CachedIregisterBlankLegal.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CachedIregisterBlankLegal() => CachedIregisterBlankLegal.__ENCAddToList((object) this);

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
    IregisterBlankLegal report = new IregisterBlankLegal();
    report.Site = this.Site;
    return (ReportDocument) report;
  }

  public virtual string GetCustomizedCacheKey(RequestContext request) => (string) null;
}
