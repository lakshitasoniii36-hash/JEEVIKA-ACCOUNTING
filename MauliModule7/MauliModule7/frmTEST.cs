// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmTEST
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmTEST : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("TextBox1")]
  private TextBox _TextBox1;
  private DataGridView dataGridView2;

  [DebuggerNonUserCode]
  static frmTEST()
  {
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmTEST.__ENCList)
    {
      if (frmTEST.__ENCList.Count == frmTEST.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmTEST.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmTEST.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmTEST.__ENCList[index1] = frmTEST.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmTEST.__ENCList.RemoveRange(index1, checked (frmTEST.__ENCList.Count - index1));
        frmTEST.__ENCList.Capacity = frmTEST.__ENCList.Count;
      }
      frmTEST.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
    }
  }

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.DataGridView1 = new DataGridView();
    this.Button1 = new Button();
    this.Label1 = new Label();
    this.TextBox1 = new TextBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(64 /*0x40*/, 94);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(311, 218);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 0;
    Button button1_1 = this.Button1;
    point1 = new Point(123, 402);
    Point point3 = point1;
    button1_1.Location = point3;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(75, 23);
    Size size3 = size1;
    button1_2.Size = size3;
    this.Button1.TabIndex = 1;
    this.Button1.Text = "Button1";
    this.Button1.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(331, 40);
    Point point4 = point1;
    label1_1.Location = point4;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(39, 13);
    Size size4 = size1;
    label1_2.Size = size4;
    this.Label1.TabIndex = 2;
    this.Label1.Text = "Label1";
    TextBox textBox1_1 = this.TextBox1;
    point1 = new Point(97, 23);
    Point point5 = point1;
    textBox1_1.Location = point5;
    this.TextBox1.Name = "TextBox1";
    TextBox textBox1_2 = this.TextBox1;
    size1 = new Size(100, 20);
    Size size5 = size1;
    textBox1_2.Size = size5;
    this.TextBox1.TabIndex = 3;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(615, 496);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.TextBox1);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.DataGridView1);
    this.Name = nameof (frmTEST);
    this.Text = "TEST";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual Button Button1
  {
    [DebuggerNonUserCode] get => this._Button1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Button1 = value;
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox TextBox1
  {
    [DebuggerNonUserCode] get => this._TextBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox1 = value;
  }

  [STAThread]
  public static void Main() => Application.Run((Form) new frmTEST());

  public frmTEST()
  {
    this.Load += new EventHandler(this.frmTEST_Load);
    frmTEST.__ENCAddToList((object) this);
    this.dataGridView2 = new DataGridView();
    this.dataGridView2.Dock = DockStyle.Fill;
    this.Controls.Add((Control) this.dataGridView2);
    this.Text = "DataGridView calendar column demo";
  }

  private void frmTEST_Load(object sender, EventArgs e)
  {
    this.dataGridView2.Columns.Add((DataGridViewColumn) new GridDateControl());
    this.dataGridView2.RowCount = 5;
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.dataGridView2.Rows)
        row.Cells[0].Value = (object) DBNull.Value;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }
}
