// Decompiled with JetBrains decompiler
// Type: MauliModule7.JregisterLegal
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

public class JregisterLegal : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static JregisterLegal()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (JregisterLegal.__ENCList)
    {
      if (JregisterLegal.__ENCList.Count == JregisterLegal.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (JregisterLegal.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (JregisterLegal.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              JregisterLegal.__ENCList[index1] = JregisterLegal.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        JregisterLegal.__ENCList.RemoveRange(index1, checked (JregisterLegal.__ENCList.Count - index1));
        JregisterLegal.__ENCList.Capacity = JregisterLegal.__ENCList.Count;
      }
      JregisterLegal.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public JregisterLegal() => JregisterLegal.__ENCAddToList((object) this);

  public override string ResourceName
  {
    get => "JregisterLegal.rpt";
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
    get => "MauliModule7.JregisterLegal.rpt";
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

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section3 => this.ReportDefinition.Sections[2];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section DetailSection2 => this.ReportDefinition.Sections[3];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section ReportFooterSection2 => this.ReportDefinition.Sections[4];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section5 => this.ReportDefinition.Sections[5];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_societyname
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[0];
  }

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public IParameterField Parameter_vpaddprint
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[1];
  }
}
