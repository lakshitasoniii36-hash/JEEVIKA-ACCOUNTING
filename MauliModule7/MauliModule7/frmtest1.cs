// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmtest1
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmtest1 : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnGrid")]
  private Button _btnGrid;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("TextBox1")]
  private TextBox _TextBox1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Button3")]
  private Button _Button3;
  [AccessedThroughProperty("Button4")]
  private Button _Button4;

  [DebuggerNonUserCode]
  static frmtest1()
  {
  }

  [DebuggerNonUserCode]
  public frmtest1()
  {
    frmtest1.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmtest1.__ENCList)
    {
      if (frmtest1.__ENCList.Count == frmtest1.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmtest1.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmtest1.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmtest1.__ENCList[index1] = frmtest1.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmtest1.__ENCList.RemoveRange(index1, checked (frmtest1.__ENCList.Count - index1));
        frmtest1.__ENCList.Capacity = frmtest1.__ENCList.Count;
      }
      frmtest1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.btnGrid = new Button();
    this.DataGridView1 = new DataGridView();
    this.TextBox1 = new TextBox();
    this.Button2 = new Button();
    this.Button3 = new Button();
    this.Button4 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    Button btnGrid1 = this.btnGrid;
    Point point1 = new Point(377, 12);
    Point point2 = point1;
    btnGrid1.Location = point2;
    this.btnGrid.Name = "btnGrid";
    Button btnGrid2 = this.btnGrid;
    Size size1 = new Size(75, 23);
    Size size2 = size1;
    btnGrid2.Size = size2;
    this.btnGrid.TabIndex = 0;
    this.btnGrid.Text = "Button1";
    this.btnGrid.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(12, 28);
    Point point3 = point1;
    dataGridView1_1.Location = point3;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(240 /*0xF0*/, 150);
    Size size3 = size1;
    dataGridView1_2.Size = size3;
    this.DataGridView1.TabIndex = 1;
    TextBox textBox1_1 = this.TextBox1;
    point1 = new Point(50, 206);
    Point point4 = point1;
    textBox1_1.Location = point4;
    this.TextBox1.Name = "TextBox1";
    TextBox textBox1_2 = this.TextBox1;
    size1 = new Size(141, 20);
    Size size4 = size1;
    textBox1_2.Size = size4;
    this.TextBox1.TabIndex = 2;
    this.TextBox1.Text = "D:\\ANURAG\\TR2.xls";
    Button button2_1 = this.Button2;
    point1 = new Point(377, 53);
    Point point5 = point1;
    button2_1.Location = point5;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(75, 23);
    Size size5 = size1;
    button2_2.Size = size5;
    this.Button2.TabIndex = 3;
    this.Button2.Text = "Button2";
    this.Button2.UseVisualStyleBackColor = true;
    Button button3_1 = this.Button3;
    point1 = new Point(377, 99);
    Point point6 = point1;
    button3_1.Location = point6;
    this.Button3.Name = "Button3";
    Button button3_2 = this.Button3;
    size1 = new Size(75, 23);
    Size size6 = size1;
    button3_2.Size = size6;
    this.Button3.TabIndex = 4;
    this.Button3.Text = "Button3";
    this.Button3.UseVisualStyleBackColor = true;
    Button button4_1 = this.Button4;
    point1 = new Point(377, 155);
    Point point7 = point1;
    button4_1.Location = point7;
    this.Button4.Name = "Button4";
    Button button4_2 = this.Button4;
    size1 = new Size(75, 23);
    Size size7 = size1;
    button4_2.Size = size7;
    this.Button4.TabIndex = 5;
    this.Button4.Text = "Button4";
    this.Button4.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(601, 322);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Button4);
    this.Controls.Add((Control) this.Button3);
    this.Controls.Add((Control) this.Button2);
    this.Controls.Add((Control) this.TextBox1);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnGrid);
    this.Name = nameof (frmtest1);
    this.Text = nameof (frmtest1);
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnGrid
  {
    [DebuggerNonUserCode] get => this._btnGrid;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGrid_Click);
      if (this._btnGrid != null)
        this._btnGrid.Click -= eventHandler;
      this._btnGrid = value;
      if (this._btnGrid == null)
        return;
      this._btnGrid.Click += eventHandler;
    }
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual TextBox TextBox1
  {
    [DebuggerNonUserCode] get => this._TextBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox1 = value;
  }

  internal virtual Button Button2
  {
    [DebuggerNonUserCode] get => this._Button2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Button2 = value;
  }

  internal virtual Button Button3
  {
    [DebuggerNonUserCode] get => this._Button3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Button3 = value;
  }

  internal virtual Button Button4
  {
    [DebuggerNonUserCode] get => this._Button4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Button4 = value;
  }

  private void btnGrid_Click(object sender, EventArgs e)
  {
    try
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{this.TextBox1.Text}';Extended Properties=Excel 8.0;");
      OleDbCommand oleDbCommand = new OleDbCommand("SELECT * INTO [MS Access;Database=C:\\Book2.accdb].[Sheet1] FROM [tr2$]", connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ex.ToString());
      ProjectData.ClearProjectError();
    }
  }
}
