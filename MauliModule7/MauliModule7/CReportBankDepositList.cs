// Decompiled with JetBrains decompiler
// Type: MauliModule7.CReportBankDepositList
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

public class CReportBankDepositList : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CReportBankDepositList()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CReportBankDepositList.__ENCList)
    {
      if (CReportBankDepositList.__ENCList.Count == CReportBankDepositList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CReportBankDepositList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CReportBankDepositList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CReportBankDepositList.__ENCList[index1] = CReportBankDepositList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CReportBankDepositList.__ENCList.RemoveRange(index1, checked (CReportBankDepositList.__ENCList.Count - index1));
        CReportBankDepositList.__ENCList.Capacity = CReportBankDepositList.__ENCList.Count;
      }
      CReportBankDepositList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CReportBankDepositList() => CReportBankDepositList.__ENCAddToList((object) this);

  public override string ResourceName
  {
    get => "CReportBankDepositList.rpt";
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
    get => "MauliModule7.CReportBankDepositList.rpt";
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

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section3 => this.ReportDefinition.Sections[2];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section4 => this.ReportDefinition.Sections[3];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section5 => this.ReportDefinition.Sections[4];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_societyname
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[0];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_TitleLine1
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[1];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_FYEAR
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[2];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_PeriodDateTo
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[3];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_PeriodDateFrom
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[4];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_PBankName
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[5];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_PBankBranch
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[6];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_PDepositDate
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[7];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_PAccountNo
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[8];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_Ptotal
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[9];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_PNarration
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[10];
  }
}
