// Decompiled with JetBrains decompiler
// Type: MauliModule7.CalendarEditingControl
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

internal class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private DataGridView dataGridViewControl;
  private bool valueIsChanged;
  private int rowIndexNum;

  [DebuggerNonUserCode]
  static CalendarEditingControl()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (CalendarEditingControl.__ENCList)
    {
      if (CalendarEditingControl.__ENCList.Count == CalendarEditingControl.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (CalendarEditingControl.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (CalendarEditingControl.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              CalendarEditingControl.__ENCList[index1] = CalendarEditingControl.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        CalendarEditingControl.__ENCList.RemoveRange(index1, checked (CalendarEditingControl.__ENCList.Count - index1));
        CalendarEditingControl.__ENCList.Capacity = CalendarEditingControl.__ENCList.Count;
      }
      CalendarEditingControl.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  public CalendarEditingControl()
  {
    CalendarEditingControl.__ENCAddToList((object) this);
    this.valueIsChanged = false;
    this.Format = DateTimePickerFormat.Short;
  }

  public object EditingControlFormattedValue
  {
    get => (object) this.Value.ToShortDateString();
    set
    {
      if (!(value is string))
        return;
      this.Value = DateTime.Parse(Conversions.ToString(value));
    }
  }

  public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
  {
    return (object) this.Value.ToShortDateString();
  }

  public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
  {
    this.Font = dataGridViewCellStyle.Font;
    this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
    this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
  }

  public int EditingControlRowIndex
  {
    get => this.rowIndexNum;
    set => this.rowIndexNum = value;
  }

  public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
  {
    switch (key & Keys.KeyCode)
    {
      case Keys.Prior:
      case Keys.Next:
      case Keys.End:
      case Keys.Home:
      case Keys.Left:
      case Keys.Up:
      case Keys.Right:
      case Keys.Down:
        return true;
      default:
        return false;
    }
  }

  public void PrepareEditingControlForEdit(bool selectAll)
  {
  }

  public bool RepositionEditingControlOnValueChange => false;

  public DataGridView EditingControlDataGridView
  {
    get => this.dataGridViewControl;
    set => this.dataGridViewControl = value;
  }

  public bool EditingControlValueChanged
  {
    get => this.valueIsChanged;
    set => this.valueIsChanged = value;
  }

  public Cursor EditingControlCursor => this.Cursor;

  protected override void OnValueChanged(EventArgs eventargs)
  {
    this.valueIsChanged = true;
    this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
    base.OnValueChanged(eventargs);
  }
}
