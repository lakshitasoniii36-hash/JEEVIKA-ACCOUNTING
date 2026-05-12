// Decompiled with JetBrains decompiler
// Type: MauliModule7.CReportBillFullPage14headSR
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

public class CReportBillFullPage14headSR : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CReportBillFullPage14headSR()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CReportBillFullPage14headSR.__ENCList)
    {
      if (CReportBillFullPage14headSR.__ENCList.Count == CReportBillFullPage14headSR.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CReportBillFullPage14headSR.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CReportBillFullPage14headSR.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CReportBillFullPage14headSR.__ENCList[index1] = CReportBillFullPage14headSR.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CReportBillFullPage14headSR.__ENCList.RemoveRange(index1, checked (CReportBillFullPage14headSR.__ENCList.Count - index1));
        CReportBillFullPage14headSR.__ENCList.Capacity = CReportBillFullPage14headSR.__ENCList.Count;
      }
      CReportBillFullPage14headSR.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CReportBillFullPage14headSR() => CReportBillFullPage14headSR.__ENCAddToList((object) this);

  public override string ResourceName
  {
    get => "CReportBillFullPage14headSR.rpt";
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
    get => "MauliModule7.CReportBillFullPage14headSR.rpt";
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

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_SocietyName
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[0];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t1 => (IParameterField) this.DataDefinition.ParameterFields[1];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t2 => (IParameterField) this.DataDefinition.ParameterFields[2];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t3 => (IParameterField) this.DataDefinition.ParameterFields[3];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t4 => (IParameterField) this.DataDefinition.ParameterFields[4];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t5 => (IParameterField) this.DataDefinition.ParameterFields[5];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t6 => (IParameterField) this.DataDefinition.ParameterFields[6];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t7 => (IParameterField) this.DataDefinition.ParameterFields[7];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t8 => (IParameterField) this.DataDefinition.ParameterFields[8];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_PBldg
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[9];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t9 => (IParameterField) this.DataDefinition.ParameterFields[10];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t10 => (IParameterField) this.DataDefinition.ParameterFields[11];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t11 => (IParameterField) this.DataDefinition.ParameterFields[12];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t12 => (IParameterField) this.DataDefinition.ParameterFields[13];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_PType
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[14];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t13 => (IParameterField) this.DataDefinition.ParameterFields[15];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t14
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[16 /*0x10*/];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t15 => (IParameterField) this.DataDefinition.ParameterFields[17];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t16 => (IParameterField) this.DataDefinition.ParameterFields[18];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t17 => (IParameterField) this.DataDefinition.ParameterFields[19];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t18 => (IParameterField) this.DataDefinition.ParameterFields[20];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t19 => (IParameterField) this.DataDefinition.ParameterFields[21];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t20 => (IParameterField) this.DataDefinition.ParameterFields[22];
}
