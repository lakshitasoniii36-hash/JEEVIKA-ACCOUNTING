// Decompiled with JetBrains decompiler
// Type: MauliModule7.InvRegisterfdwise
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

public class InvRegisterfdwise : ReportClass
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static InvRegisterfdwise()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (InvRegisterfdwise.__ENCList)
    {
      if (InvRegisterfdwise.__ENCList.Count == InvRegisterfdwise.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (InvRegisterfdwise.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (InvRegisterfdwise.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              InvRegisterfdwise.__ENCList[index1] = InvRegisterfdwise.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        InvRegisterfdwise.__ENCList.RemoveRange(index1, checked (InvRegisterfdwise.__ENCList.Count - index1));
        InvRegisterfdwise.__ENCList.Capacity = InvRegisterfdwise.__ENCList.Count;
      }
      InvRegisterfdwise.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public InvRegisterfdwise() => InvRegisterfdwise.__ENCAddToList((object) this);

  public override string ResourceName
  {
    get => "InvRegisterfdwise.rpt";
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
    get => "MauliModule7.InvRegisterfdwise.rpt";
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
  public Section GroupHeaderSection1 => this.ReportDefinition.Sections[2];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public Section Section3 => this.ReportDefinition.Sections[3];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section DetailSection2 => this.ReportDefinition.Sections[4];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section GroupFooterSection1 => this.ReportDefinition.Sections[5];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section4 => this.ReportDefinition.Sections[6];

  [Browsable(false)]
  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  public Section Section5 => this.ReportDefinition.Sections[7];

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
  [Browsable(false)]
  public IParameterField Parameter_societyname
  {
    get => (IParameterField) this.DataDefinition.ParameterFields[0];
  }
}
