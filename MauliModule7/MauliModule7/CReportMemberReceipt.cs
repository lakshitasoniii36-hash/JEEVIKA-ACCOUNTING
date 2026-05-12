// Decompiled with JetBrains decompiler
// Type: MauliModule7.CReportMemberReceipt
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace MauliModule7;

public class CReportMemberReceipt : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CReportMemberReceipt()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CReportMemberReceipt.__ENCList)
    {
      if (CReportMemberReceipt.__ENCList.Count == CReportMemberReceipt.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CReportMemberReceipt.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CReportMemberReceipt.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CReportMemberReceipt.__ENCList[index1] = CReportMemberReceipt.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CReportMemberReceipt.__ENCList.RemoveRange(index1, checked (CReportMemberReceipt.__ENCList.Count - index1));
        CReportMemberReceipt.__ENCList.Capacity = CReportMemberReceipt.__ENCList.Count;
      }
      CReportMemberReceipt.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CReportMemberReceipt() => CReportMemberReceipt.__ENCAddToList((object) this);

  public override string ResourceName
  {
    get => "CReportMemberReceipt.rpt";
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
    get => "MauliModule7.CReportMemberReceipt.rpt";
    set
    {
    }
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section1 => this.ReportDefinition.Sections[0];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section2 => this.ReportDefinition.Sections[1];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section3 => this.ReportDefinition.Sections[2];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section4 => this.ReportDefinition.Sections[3];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section5 => this.ReportDefinition.Sections[4];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_SocietyName
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[0];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_PBldg
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[1];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_Newpage
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[2];
  }
}
