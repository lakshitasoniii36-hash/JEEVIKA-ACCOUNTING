// Decompiled with JetBrains decompiler
// Type: MauliModule7.CReportBillHalfPageWithReceiptSR
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

public class CReportBillHalfPageWithReceiptSR : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CReportBillHalfPageWithReceiptSR()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CReportBillHalfPageWithReceiptSR.__ENCList)
    {
      if (CReportBillHalfPageWithReceiptSR.__ENCList.Count == CReportBillHalfPageWithReceiptSR.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CReportBillHalfPageWithReceiptSR.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CReportBillHalfPageWithReceiptSR.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CReportBillHalfPageWithReceiptSR.__ENCList[index1] = CReportBillHalfPageWithReceiptSR.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CReportBillHalfPageWithReceiptSR.__ENCList.RemoveRange(index1, checked (CReportBillHalfPageWithReceiptSR.__ENCList.Count - index1));
        CReportBillHalfPageWithReceiptSR.__ENCList.Capacity = CReportBillHalfPageWithReceiptSR.__ENCList.Count;
      }
      CReportBillHalfPageWithReceiptSR.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CReportBillHalfPageWithReceiptSR()
  {
    CReportBillHalfPageWithReceiptSR.__ENCAddToList((object) this);
  }

  public override string ResourceName
  {
    get => "CReportBillHalfPageWithReceiptSR.rpt";
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
    get => "MauliModule7.CReportBillHalfPageWithReceiptSR.rpt";
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
  public Section GroupHeaderSection1 => this.ReportDefinition.Sections[2];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section3 => this.ReportDefinition.Sections[3];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section DetailSection1 => this.ReportDefinition.Sections[4];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section GroupFooterSection1 => this.ReportDefinition.Sections[5];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section4 => this.ReportDefinition.Sections[6];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section5 => this.ReportDefinition.Sections[7];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_SocietyName
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[0];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t1 => (IParameterField) this.DataDefinition.ParameterFields[1];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t2 => (IParameterField) this.DataDefinition.ParameterFields[2];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t3 => (IParameterField) this.DataDefinition.ParameterFields[3];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t4 => (IParameterField) this.DataDefinition.ParameterFields[4];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t5 => (IParameterField) this.DataDefinition.ParameterFields[5];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t9 => (IParameterField) this.DataDefinition.ParameterFields[10];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t10 => (IParameterField) this.DataDefinition.ParameterFields[11];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
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

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t17 => (IParameterField) this.DataDefinition.ParameterFields[19];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t18 => (IParameterField) this.DataDefinition.ParameterFields[20];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t20 => (IParameterField) this.DataDefinition.ParameterFields[21];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t19 => (IParameterField) this.DataDefinition.ParameterFields[22];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_tbold1
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[23];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_tbold2
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[24];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_tbold3
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[25];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_tbold4
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[26];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_tbold5
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[27];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_tbold6
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[28];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_PrintSign
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[29];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_Signpath
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[30];
  }
}
