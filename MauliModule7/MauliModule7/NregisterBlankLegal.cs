// Decompiled with JetBrains decompiler
// Type: MauliModule7.NregisterBlankLegal
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

public class NregisterBlankLegal : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static NregisterBlankLegal()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (NregisterBlankLegal.__ENCList)
    {
      if (NregisterBlankLegal.__ENCList.Count == NregisterBlankLegal.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (NregisterBlankLegal.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (NregisterBlankLegal.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              NregisterBlankLegal.__ENCList[index1] = NregisterBlankLegal.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        NregisterBlankLegal.__ENCList.RemoveRange(index1, checked (NregisterBlankLegal.__ENCList.Count - index1));
        NregisterBlankLegal.__ENCList.Capacity = NregisterBlankLegal.__ENCList.Count;
      }
      NregisterBlankLegal.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public NregisterBlankLegal() => NregisterBlankLegal.__ENCAddToList((object) this);

  public override string ResourceName
  {
    get => "NregisterBlankLegal.rpt";
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
    get => "MauliModule7.NregisterBlankLegal.rpt";
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

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_societyname
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[0];
  }
}
