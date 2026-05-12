// Decompiled with JetBrains decompiler
// Type: MauliModule7.CReportBalanceSheetMarathi
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

public class CReportBalanceSheetMarathi : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CReportBalanceSheetMarathi()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CReportBalanceSheetMarathi.__ENCList)
    {
      if (CReportBalanceSheetMarathi.__ENCList.Count == CReportBalanceSheetMarathi.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CReportBalanceSheetMarathi.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CReportBalanceSheetMarathi.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CReportBalanceSheetMarathi.__ENCList[index1] = CReportBalanceSheetMarathi.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CReportBalanceSheetMarathi.__ENCList.RemoveRange(index1, checked (CReportBalanceSheetMarathi.__ENCList.Count - index1));
        CReportBalanceSheetMarathi.__ENCList.Capacity = CReportBalanceSheetMarathi.__ENCList.Count;
      }
      CReportBalanceSheetMarathi.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CReportBalanceSheetMarathi() => CReportBalanceSheetMarathi.__ENCAddToList((object) this);

  public override string ResourceName
  {
    get => "CReportBalanceSheetMarathi.rpt";
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
    get => "MauliModule7.CReportBalanceSheetMarathi.rpt";
    set
    {
    }
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section1 => this.ReportDefinition.Sections[0];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section2 => this.ReportDefinition.Sections[1];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section PageHeaderSection2 => this.ReportDefinition.Sections[2];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section DetailSection2 => this.ReportDefinition.Sections[3];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section4 => this.ReportDefinition.Sections[4];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section ReportFooterSection2 => this.ReportDefinition.Sections[5];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section5 => this.ReportDefinition.Sections[6];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
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

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_FYEAR
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[3];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_RType
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[4];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_AuthoName
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[5];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_AuthoAmt
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[6];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_L1 => (IParameterField) this.DataDefinition.ParameterFields[7];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_L2 => (IParameterField) this.DataDefinition.ParameterFields[8];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_L3 => (IParameterField) this.DataDefinition.ParameterFields[9];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_L4 => (IParameterField) this.DataDefinition.ParameterFields[10];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_L5 => (IParameterField) this.DataDefinition.ParameterFields[11];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_L6 => (IParameterField) this.DataDefinition.ParameterFields[12];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_L1Bold
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[13];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_L2Bold
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[14];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_L3Bold
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[15];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_L4Bold
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[16 /*0x10*/];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_L5Bold
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[17];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_L6Bold
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[18];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_LPrint
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[19];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_PrevDate
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[20];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_CurrDate
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[21];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_PrintDate
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[22];
  }
}
