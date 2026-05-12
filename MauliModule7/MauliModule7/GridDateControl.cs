// Decompiled with JetBrains decompiler
// Type: MauliModule7.GridDateControl
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

public class GridDateControl : DataGridViewColumn
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();

  [DebuggerNonUserCode]
  static GridDateControl()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (GridDateControl.__ENCList)
    {
      if (GridDateControl.__ENCList.Count == GridDateControl.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (GridDateControl.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (GridDateControl.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              GridDateControl.__ENCList[index1] = GridDateControl.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        GridDateControl.__ENCList.RemoveRange(index1, checked (GridDateControl.__ENCList.Count - index1));
        GridDateControl.__ENCList.Capacity = GridDateControl.__ENCList.Count;
      }
      GridDateControl.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public GridDateControl()
    : base((DataGridViewCell) new CalendarCell())
  {
    GridDateControl.__ENCAddToList((object) this);
  }

  public override DataGridViewCell CellTemplate
  {
    get => base.CellTemplate;
    set
    {
      base.CellTemplate = value == null || value.GetType().IsAssignableFrom(typeof (CalendarCell)) ? value : throw new InvalidCastException("Must be a CalendarCell");
    }
  }
}
