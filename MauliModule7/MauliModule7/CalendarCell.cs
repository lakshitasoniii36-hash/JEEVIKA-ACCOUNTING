// Decompiled with JetBrains decompiler
// Type: MauliModule7.CalendarCell
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

public class CalendarCell : DataGridViewTextBoxCell
{
  public CalendarCell() => this.Style.Format = "d";

  public override void InitializeEditingControl(
    int rowIndex,
    object initialFormattedValue,
    DataGridViewCellStyle dataGridViewCellStyle)
  {
    base.InitializeEditingControl(rowIndex, RuntimeHelpers.GetObjectValue(initialFormattedValue), dataGridViewCellStyle);
    CalendarEditingControl editingControl = (CalendarEditingControl) this.DataGridView.EditingControl;
    if (this.Value == DBNull.Value || this.Value == null)
      return;
    editingControl.Value = Conversions.ToDate(this.Value);
  }

  public override System.Type EditType => typeof (CalendarEditingControl);

  public override System.Type ValueType => typeof (DateTime);
}
