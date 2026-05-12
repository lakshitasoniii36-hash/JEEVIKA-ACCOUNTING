// Decompiled with JetBrains decompiler
// Type: MauliModule7.CReportReceiptFullPage21headNewShangstarr
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

public class CReportReceiptFullPage21headNewShangstarr : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static CReportReceiptFullPage21headNewShangstarr()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CReportReceiptFullPage21headNewShangstarr.__ENCList)
    {
      if (CReportReceiptFullPage21headNewShangstarr.__ENCList.Count == CReportReceiptFullPage21headNewShangstarr.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CReportReceiptFullPage21headNewShangstarr.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CReportReceiptFullPage21headNewShangstarr.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CReportReceiptFullPage21headNewShangstarr.__ENCList[index1] = CReportReceiptFullPage21headNewShangstarr.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CReportReceiptFullPage21headNewShangstarr.__ENCList.RemoveRange(index1, checked (CReportReceiptFullPage21headNewShangstarr.__ENCList.Count - index1));
        CReportReceiptFullPage21headNewShangstarr.__ENCList.Capacity = CReportReceiptFullPage21headNewShangstarr.__ENCList.Count;
      }
      CReportReceiptFullPage21headNewShangstarr.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CReportReceiptFullPage21headNewShangstarr()
  {
    CReportReceiptFullPage21headNewShangstarr.__ENCAddToList((object) this);
  }

  public override string ResourceName
  {
    get => "CReportReceiptFullPage21headNewShangstarr.rpt";
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
    get => "MauliModule7.CReportReceiptFullPage21headNewShangstarr.rpt";
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

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section DetailSection3 => this.ReportDefinition.Sections[3];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section DetailSection2 => this.ReportDefinition.Sections[4];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section DetailSection4 => this.ReportDefinition.Sections[5];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section4 => this.ReportDefinition.Sections[6];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section5 => this.ReportDefinition.Sections[7];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_SocietyName
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[0];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
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

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t7 => (IParameterField) this.DataDefinition.ParameterFields[7];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t12 => (IParameterField) this.DataDefinition.ParameterFields[13];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_PType
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[14];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t13 => (IParameterField) this.DataDefinition.ParameterFields[15];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t14
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[16 /*0x10*/];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t15 => (IParameterField) this.DataDefinition.ParameterFields[17];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t16 => (IParameterField) this.DataDefinition.ParameterFields[18];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t17 => (IParameterField) this.DataDefinition.ParameterFields[19];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t18 => (IParameterField) this.DataDefinition.ParameterFields[20];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t19 => (IParameterField) this.DataDefinition.ParameterFields[21];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t20 => (IParameterField) this.DataDefinition.ParameterFields[22];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t21 => (IParameterField) this.DataDefinition.ParameterFields[23];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t22 => (IParameterField) this.DataDefinition.ParameterFields[24];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t23 => (IParameterField) this.DataDefinition.ParameterFields[25];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t24 => (IParameterField) this.DataDefinition.ParameterFields[26];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t25 => (IParameterField) this.DataDefinition.ParameterFields[27];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t26 => (IParameterField) this.DataDefinition.ParameterFields[28];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_t27 => (IParameterField) this.DataDefinition.ParameterFields[29];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_t28 => (IParameterField) this.DataDefinition.ParameterFields[30];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_tbold7
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[31 /*0x1F*/];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_tbold8
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[32 /*0x20*/];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_tbold9
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[33];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_tbold10
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[34];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_tbold11
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[35];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_tbold12
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[36];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_tbold1
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[37];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_tbold2
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[38];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_tbold3
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[39];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_tbold4
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[40];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_tbold5
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[41];
  }

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_tbold6
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[42];
  }
}
