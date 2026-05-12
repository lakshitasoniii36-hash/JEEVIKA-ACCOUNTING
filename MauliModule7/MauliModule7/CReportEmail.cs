// Decompiled with JetBrains decompiler
// Type: MauliModule7.CReportEmail
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MauliModule7;

public class CReportEmail : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CReportEmail()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CReportEmail.__ENCList)
    {
      if (CReportEmail.__ENCList.Count == CReportEmail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CReportEmail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CReportEmail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CReportEmail.__ENCList[index1] = CReportEmail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CReportEmail.__ENCList.RemoveRange(index1, checked (CReportEmail.__ENCList.Count - index1));
        CReportEmail.__ENCList.Capacity = CReportEmail.__ENCList.Count;
      }
      CReportEmail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CReportEmail() => CReportEmail.__ENCAddToList((object) this);

  public override string ResourceName
  {
    get => "CReportEmail.rpt";
    set
    {
    }
  }

  public override bool NewGenerator
  {
    get => true;
    set
    {
    }
  }

  public override string FullResourceName
  {
    get => "MauliModule7.CReportEmail.rpt";
    set
    {
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section1 => this.ReportDefinition.Sections[0];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section2 => this.ReportDefinition.Sections[1];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section3 => this.ReportDefinition.Sections[2];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section4 => this.ReportDefinition.Sections[3];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section5 => this.ReportDefinition.Sections[4];
}
