// Decompiled with JetBrains decompiler
// Type: MauliModule7.CReportMemberOsListCodewiseDetail
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

public class CReportMemberOsListCodewiseDetail : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CReportMemberOsListCodewiseDetail()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CReportMemberOsListCodewiseDetail.__ENCList)
    {
      if (CReportMemberOsListCodewiseDetail.__ENCList.Count == CReportMemberOsListCodewiseDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CReportMemberOsListCodewiseDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CReportMemberOsListCodewiseDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CReportMemberOsListCodewiseDetail.__ENCList[index1] = CReportMemberOsListCodewiseDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CReportMemberOsListCodewiseDetail.__ENCList.RemoveRange(index1, checked (CReportMemberOsListCodewiseDetail.__ENCList.Count - index1));
        CReportMemberOsListCodewiseDetail.__ENCList.Capacity = CReportMemberOsListCodewiseDetail.__ENCList.Count;
      }
      CReportMemberOsListCodewiseDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CReportMemberOsListCodewiseDetail()
  {
    CReportMemberOsListCodewiseDetail.__ENCAddToList((object) this);
  }

  public override string ResourceName
  {
    get => "CReportMemberOsListCodewiseDetail.rpt";
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
    get => "MauliModule7.CReportMemberOsListCodewiseDetail.rpt";
    set
    {
    }
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section1 => this.ReportDefinition.Sections[0];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section2 => this.ReportDefinition.Sections[1];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section3 => this.ReportDefinition.Sections[2];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section4 => this.ReportDefinition.Sections[3];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section5 => this.ReportDefinition.Sections[4];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_SocietyName
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[0];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_TitleLine1
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[1];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_PeriodDateTo
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[2];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_FYEAR
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[3];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_ListType
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[4];
  }
}
