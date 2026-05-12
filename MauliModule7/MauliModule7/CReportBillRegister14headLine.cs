// Decompiled with JetBrains decompiler
// Type: MauliModule7.CReportBillRegister14headLine
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

public class CReportBillRegister14headLine : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CReportBillRegister14headLine()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CReportBillRegister14headLine.__ENCList)
    {
      if (CReportBillRegister14headLine.__ENCList.Count == CReportBillRegister14headLine.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CReportBillRegister14headLine.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CReportBillRegister14headLine.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CReportBillRegister14headLine.__ENCList[index1] = CReportBillRegister14headLine.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CReportBillRegister14headLine.__ENCList.RemoveRange(index1, checked (CReportBillRegister14headLine.__ENCList.Count - index1));
        CReportBillRegister14headLine.__ENCList.Capacity = CReportBillRegister14headLine.__ENCList.Count;
      }
      CReportBillRegister14headLine.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CReportBillRegister14headLine()
  {
    CReportBillRegister14headLine.__ENCAddToList((object) this);
  }

  public override string ResourceName
  {
    get => "CReportBillRegister14headLine.rpt";
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
    get => "MauliModule7.CReportBillRegister14headLine.rpt";
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
  public Section Section3 => this.ReportDefinition.Sections[3];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section4 => this.ReportDefinition.Sections[4];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section5 => this.ReportDefinition.Sections[5];

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

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_PeriodDateFrom
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[4];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_H1 => (IParameterField) this.DataDefinition.ParameterFields[5];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_H2 => (IParameterField) this.DataDefinition.ParameterFields[6];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H3 => (IParameterField) this.DataDefinition.ParameterFields[7];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_H4 => (IParameterField) this.DataDefinition.ParameterFields[8];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_H5 => (IParameterField) this.DataDefinition.ParameterFields[9];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H6 => (IParameterField) this.DataDefinition.ParameterFields[10];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H7 => (IParameterField) this.DataDefinition.ParameterFields[11];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_H8 => (IParameterField) this.DataDefinition.ParameterFields[12];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_H9 => (IParameterField) this.DataDefinition.ParameterFields[13];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_H10 => (IParameterField) this.DataDefinition.ParameterFields[14];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_H11 => (IParameterField) this.DataDefinition.ParameterFields[15];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H12
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[16 /*0x10*/];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_H13 => (IParameterField) this.DataDefinition.ParameterFields[17];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H14 => (IParameterField) this.DataDefinition.ParameterFields[18];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H15 => (IParameterField) this.DataDefinition.ParameterFields[19];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H16 => (IParameterField) this.DataDefinition.ParameterFields[20];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_H17 => (IParameterField) this.DataDefinition.ParameterFields[21];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H18 => (IParameterField) this.DataDefinition.ParameterFields[22];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H19 => (IParameterField) this.DataDefinition.ParameterFields[23];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_H20 => (IParameterField) this.DataDefinition.ParameterFields[24];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H21 => (IParameterField) this.DataDefinition.ParameterFields[25];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H22 => (IParameterField) this.DataDefinition.ParameterFields[26];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H23 => (IParameterField) this.DataDefinition.ParameterFields[27];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H24 => (IParameterField) this.DataDefinition.ParameterFields[28];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_H25 => (IParameterField) this.DataDefinition.ParameterFields[29];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H26 => (IParameterField) this.DataDefinition.ParameterFields[30];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_H27
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[31 /*0x1F*/];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_PNarration
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[32 /*0x20*/];
  }
}
