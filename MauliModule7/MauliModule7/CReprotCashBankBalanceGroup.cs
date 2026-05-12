// Decompiled with JetBrains decompiler
// Type: MauliModule7.CReprotCashBankBalanceGroup
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

public class CReprotCashBankBalanceGroup : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CReprotCashBankBalanceGroup()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CReprotCashBankBalanceGroup.__ENCList)
    {
      if (CReprotCashBankBalanceGroup.__ENCList.Count == CReprotCashBankBalanceGroup.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CReprotCashBankBalanceGroup.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CReprotCashBankBalanceGroup.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CReprotCashBankBalanceGroup.__ENCList[index1] = CReprotCashBankBalanceGroup.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CReprotCashBankBalanceGroup.__ENCList.RemoveRange(index1, checked (CReprotCashBankBalanceGroup.__ENCList.Count - index1));
        CReprotCashBankBalanceGroup.__ENCList.Capacity = CReprotCashBankBalanceGroup.__ENCList.Count;
      }
      CReprotCashBankBalanceGroup.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CReprotCashBankBalanceGroup() => CReprotCashBankBalanceGroup.__ENCAddToList((object) this);

  public override string ResourceName
  {
    get => "CReprotCashBankBalanceGroup.rpt";
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
    get => "MauliModule7.CReprotCashBankBalanceGroup.rpt";
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
  public Section PageHeaderSection2 => this.ReportDefinition.Sections[2];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section GroupHeaderSection5 => this.ReportDefinition.Sections[3];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section GroupHeaderSection6 => this.ReportDefinition.Sections[4];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section GroupHeaderSection1 => this.ReportDefinition.Sections[5];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section GroupHeaderSection3 => this.ReportDefinition.Sections[6];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section GroupHeaderSection2 => this.ReportDefinition.Sections[7];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section GroupHeaderSection4 => this.ReportDefinition.Sections[8];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section DetailSection4 => this.ReportDefinition.Sections[9];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section DetailSection2 => this.ReportDefinition.Sections[10];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section DetailSection5 => this.ReportDefinition.Sections[11];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section DetailSection1 => this.ReportDefinition.Sections[12];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section DetailSection7 => this.ReportDefinition.Sections[13];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section GroupFooterSection5 => this.ReportDefinition.Sections[14];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section GroupFooterSection2 => this.ReportDefinition.Sections[15];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section GroupFooterSection10 => this.ReportDefinition.Sections[16 /*0x10*/];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section GroupFooterSection3 => this.ReportDefinition.Sections[17];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section GroupFooterSection4 => this.ReportDefinition.Sections[18];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section GroupFooterSection6 => this.ReportDefinition.Sections[19];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section GroupFooterSection1 => this.ReportDefinition.Sections[20];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section GroupFooterSection8 => this.ReportDefinition.Sections[21];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section GroupFooterSection7 => this.ReportDefinition.Sections[22];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section4 => this.ReportDefinition.Sections[23];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section5 => this.ReportDefinition.Sections[24];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_FYEAR
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[0];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_TitleLine1
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[1];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_SocietyName
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[2];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
  public IParameterField Parameter_PNarration
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[5];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_Pbreak
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[6];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_PMonthlyBreak
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[7];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_ChkPAN
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[8];
  }
}
