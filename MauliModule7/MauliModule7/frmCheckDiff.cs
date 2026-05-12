// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmCheckDiff
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmCheckDiff : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("txtPassword")]
  private TextBox _txtPassword;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;

  [DebuggerNonUserCode]
  static frmCheckDiff()
  {
  }

  [DebuggerNonUserCode]
  public frmCheckDiff()
  {
    this.Load += new EventHandler(this.frmCheckDiff_Load);
    this.KeyDown += new KeyEventHandler(this.frmCheckDiff_KeyDown);
    frmCheckDiff.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmCheckDiff.__ENCList)
    {
      if (frmCheckDiff.__ENCList.Count == frmCheckDiff.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmCheckDiff.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmCheckDiff.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmCheckDiff.__ENCList[index1] = frmCheckDiff.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmCheckDiff.__ENCList.RemoveRange(index1, checked (frmCheckDiff.__ENCList.Count - index1));
        frmCheckDiff.__ENCList.Capacity = frmCheckDiff.__ENCList.Count;
      }
      frmCheckDiff.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle9 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle10 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle11 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle12 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle13 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle14 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle15 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle16 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCheckDiff));
    this.DataGridView2 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.btnExit = new Button();
    this.btnDelete = new Button();
    this.txtPassword = new TextBox();
    this.Label2 = new Label();
    this.DataGridView6 = new DataGridView();
    this.DataGridView7 = new DataGridView();
    this.DataGridView8 = new DataGridView();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    this.SuspendLayout();
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView2_1 = this.DataGridView2;
    Point point1 = new Point(6, 19);
    Point point2 = point1;
    dataGridView2_1.Location = point2;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    Size size1 = new Size(10, 10);
    Size size2 = size1;
    dataGridView2_2.Size = size2;
    this.DataGridView2.TabIndex = 2;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Window;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.ControlText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle4;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(22, 19);
    Point point3 = point1;
    dataGridView1_1.Location = point3;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size3 = size1;
    dataGridView1_2.Size = size3;
    this.DataGridView1.TabIndex = 3;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Control;
    gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.WindowText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle5;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Window;
    gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.ControlText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.False;
    this.DataGridView3.DefaultCellStyle = gridViewCellStyle6;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(38, 19);
    Point point4 = point1;
    dataGridView3_1.Location = point4;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 10);
    Size size4 = size1;
    dataGridView3_2.Size = size4;
    this.DataGridView3.TabIndex = 4;
    gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle7.BackColor = SystemColors.Control;
    gridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle7.ForeColor = SystemColors.WindowText;
    gridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle7.WrapMode = DataGridViewTriState.True;
    this.DataGridView4.ColumnHeadersDefaultCellStyle = gridViewCellStyle7;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle8.BackColor = SystemColors.Window;
    gridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle8.ForeColor = SystemColors.ControlText;
    gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle8.WrapMode = DataGridViewTriState.False;
    this.DataGridView4.DefaultCellStyle = gridViewCellStyle8;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(54, 19);
    Point point5 = point1;
    dataGridView4_1.Location = point5;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size5 = size1;
    dataGridView4_2.Size = size5;
    this.DataGridView4.TabIndex = 5;
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle9.BackColor = SystemColors.Control;
    gridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle9.ForeColor = SystemColors.WindowText;
    gridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle9.WrapMode = DataGridViewTriState.True;
    this.DataGridView5.ColumnHeadersDefaultCellStyle = gridViewCellStyle9;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle10.BackColor = SystemColors.Window;
    gridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle10.ForeColor = SystemColors.ControlText;
    gridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle10.WrapMode = DataGridViewTriState.False;
    this.DataGridView5.DefaultCellStyle = gridViewCellStyle10;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(-1, 0);
    Point point6 = point1;
    dataGridView5_1.Location = point6;
    this.DataGridView5.Name = "DataGridView5";
    this.DataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(854, 238);
    Size size6 = size1;
    dataGridView5_2.Size = size6;
    this.DataGridView5.TabIndex = 6;
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(904, 180);
    Point point7 = point1;
    grpVisible1.Location = point7;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(76, 66);
    Size size7 = size1;
    grpVisible2.Size = size7;
    this.grpVisible.TabIndex = 7;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    Button btnExit1 = this.btnExit;
    point1 = new Point(869, 494);
    Point point8 = point1;
    btnExit1.Location = point8;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(111, 33);
    Size size8 = size1;
    btnExit2.Size = size8;
    this.btnExit.TabIndex = 11;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(869, 107);
    Point point9 = point1;
    btnDelete1.Location = point9;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(113, 48 /*0x30*/);
    Size size9 = size1;
    btnDelete2.Size = size9;
    this.btnDelete.TabIndex = 10;
    this.btnDelete.Text = "Delete Selected Transaction";
    this.btnDelete.UseVisualStyleBackColor = true;
    TextBox txtPassword1 = this.txtPassword;
    point1 = new Point(869, 71);
    Point point10 = point1;
    txtPassword1.Location = point10;
    this.txtPassword.MaxLength = 200;
    this.txtPassword.Name = "txtPassword";
    this.txtPassword.PasswordChar = '*';
    TextBox txtPassword2 = this.txtPassword;
    size1 = new Size(111, 20);
    Size size10 = size1;
    txtPassword2.Size = size10;
    this.txtPassword.TabIndex = 12;
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(899, 55);
    Point point11 = point1;
    label2_1.Location = point11;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(53, 13);
    Size size11 = size1;
    label2_2.Size = size11;
    this.Label2.TabIndex = 40;
    this.Label2.Text = "Password";
    gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle11.BackColor = SystemColors.Control;
    gridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle11.ForeColor = SystemColors.WindowText;
    gridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle11.WrapMode = DataGridViewTriState.True;
    this.DataGridView6.ColumnHeadersDefaultCellStyle = gridViewCellStyle11;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle12.BackColor = SystemColors.Window;
    gridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle12.ForeColor = SystemColors.ControlText;
    gridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle12.WrapMode = DataGridViewTriState.False;
    this.DataGridView6.DefaultCellStyle = gridViewCellStyle12;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(-1, 271);
    Point point12 = point1;
    dataGridView6_1.Location = point12;
    this.DataGridView6.Name = "DataGridView6";
    this.DataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(854, 238);
    Size size12 = size1;
    dataGridView6_2.Size = size12;
    this.DataGridView6.TabIndex = 41;
    gridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle13.BackColor = SystemColors.Control;
    gridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle13.ForeColor = SystemColors.WindowText;
    gridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle13.WrapMode = DataGridViewTriState.True;
    this.DataGridView7.ColumnHeadersDefaultCellStyle = gridViewCellStyle13;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle14.BackColor = SystemColors.Window;
    gridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle14.ForeColor = SystemColors.ControlText;
    gridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle14.WrapMode = DataGridViewTriState.False;
    this.DataGridView7.DefaultCellStyle = gridViewCellStyle14;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(6, 35);
    Point point13 = point1;
    dataGridView7_1.Location = point13;
    this.DataGridView7.Name = "DataGridView7";
    this.DataGridView7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size13 = size1;
    dataGridView7_2.Size = size13;
    this.DataGridView7.TabIndex = 6;
    gridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle15.BackColor = SystemColors.Control;
    gridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle15.ForeColor = SystemColors.WindowText;
    gridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle15.WrapMode = DataGridViewTriState.True;
    this.DataGridView8.ColumnHeadersDefaultCellStyle = gridViewCellStyle15;
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle16.BackColor = SystemColors.Window;
    gridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle16.ForeColor = SystemColors.ControlText;
    gridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle16.WrapMode = DataGridViewTriState.False;
    this.DataGridView8.DefaultCellStyle = gridViewCellStyle16;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(22, 35);
    Point point14 = point1;
    dataGridView8_1.Location = point14;
    this.DataGridView8.Name = "DataGridView8";
    this.DataGridView8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size14 = size1;
    dataGridView8_2.Size = size14;
    this.DataGridView8.TabIndex = 7;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView6);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtPassword);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.DataGridView5);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCheckDiff);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Check Difference";
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
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

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
    }
  }

  internal virtual DataGridView DataGridView4
  {
    [DebuggerNonUserCode] get => this._DataGridView4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView4 = value;
    }
  }

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual Button btnExit
  {
    [DebuggerNonUserCode] get => this._btnExit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnExit_Click);
      if (this._btnExit != null)
        this._btnExit.Click -= eventHandler;
      this._btnExit = value;
      if (this._btnExit == null)
        return;
      this._btnExit.Click += eventHandler;
    }
  }

  internal virtual Button btnDelete
  {
    [DebuggerNonUserCode] get => this._btnDelete;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDelete_Click);
      if (this._btnDelete != null)
        this._btnDelete.Click -= eventHandler;
      this._btnDelete = value;
      if (this._btnDelete == null)
        return;
      this._btnDelete.Click += eventHandler;
    }
  }

  internal virtual TextBox txtPassword
  {
    [DebuggerNonUserCode] get => this._txtPassword;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPassword = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual DataGridView DataGridView6
  {
    [DebuggerNonUserCode] get => this._DataGridView6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView6 = value;
    }
  }

  internal virtual DataGridView DataGridView8
  {
    [DebuggerNonUserCode] get => this._DataGridView8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView8 = value;
    }
  }

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
    }
  }

  private void frmCheckDiff_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmCheckDiff_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.txtPassword.Visible = false;
    this.Label2.Visible = false;
    this.btnDelete.Visible = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    DataTable dataTable1 = new DataTable("SocTran");
    new OleDbDataAdapter("SELECT SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran WHERE(((SocTran.MainAccount) = 'Y')) GROUP BY SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo ORDER BY SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo", selectConnection).Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter();
    DataTable dataTable2 = new DataTable("SocTran");
    new OleDbDataAdapter("SELECT SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran WHERE(((SocTran.MainAccount) = 'N')) GROUP BY SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo ORDER BY SocTran.SocTranType, SocTran.SocTranNo, SocTran.SubTranType, SocTran.SubTranNo", selectConnection).Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.ColumnCount = 10;
    this.DataGridView3.RowCount = 0;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.ColumnCount = 10;
    this.DataGridView4.RowCount = 0;
    this.DataGridView5.RowHeadersVisible = false;
    this.DataGridView5.AllowUserToAddRows = false;
    this.DataGridView5.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
    this.DataGridView5.ColumnCount = 10;
    this.DataGridView5.RowCount = 0;
    this.DataGridView5.Columns[0].Visible = false;
    this.DataGridView5.Columns[1].HeaderText = "Type";
    this.DataGridView5.Columns[2].HeaderText = "No.";
    this.DataGridView5.Columns[3].HeaderText = "Sub Tpye";
    this.DataGridView5.Columns[4].HeaderText = "Sub No.";
    this.DataGridView5.Columns[5].HeaderText = "Amount";
    this.DataGridView5.Columns[6].HeaderText = "Main";
    this.DataGridView5.Columns[7].Visible = false;
    this.DataGridView5.Columns[8].Visible = false;
    this.DataGridView5.Columns[9].Visible = false;
    int num1 = checked (this.DataGridView2.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView3.Rows.Add();
      this.DataGridView3.Rows[index1].Cells[0].Value = (object) 0;
      this.DataGridView3.Rows[index1].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[0].Value);
      this.DataGridView3.Rows[index1].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[1].Value);
      this.DataGridView3.Rows[index1].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index1].Cells[2].Value.ToString(), "", false) != 0 ? RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[2].Value) : (object) "Blank";
      this.DataGridView3.Rows[index1].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index1].Cells[3].Value.ToString(), "", false) != 0 ? RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[3].Value) : (object) "0";
      this.DataGridView3.Rows[index1].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index1].Cells[4].Value);
      this.DataGridView3.Rows[index1].Cells[6].Value = (object) 0;
      checked { ++index1; }
    }
    int num2 = checked (this.DataGridView1.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      this.DataGridView4.Rows.Add();
      this.DataGridView4.Rows[index2].Cells[0].Value = (object) 0;
      this.DataGridView4.Rows[index2].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[0].Value);
      this.DataGridView4.Rows[index2].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[1].Value);
      this.DataGridView4.Rows[index2].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index2].Cells[2].Value.ToString(), "", false) != 0 ? RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[2].Value) : (object) "Blank";
      this.DataGridView4.Rows[index2].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index2].Cells[3].Value.ToString(), "", false) != 0 ? RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[3].Value) : (object) "0";
      this.DataGridView4.Rows[index2].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[4].Value);
      this.DataGridView4.Rows[index2].Cells[6].Value = (object) 0;
      checked { ++index2; }
    }
    int num3 = checked (this.DataGridView4.RowCount - 1);
    int index3 = 0;
    while (index3 <= num3)
    {
      int num4 = checked (this.DataGridView3.RowCount - 1);
      int index4 = 0;
      while (index4 <= num4)
      {
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index3].Cells[1].Value, this.DataGridView3.Rows[index4].Cells[1].Value, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index3].Cells[2].Value, this.DataGridView3.Rows[index4].Cells[2].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index3].Cells[3].Value, this.DataGridView3.Rows[index4].Cells[3].Value, false)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView4.Rows[index3].Cells[4].Value, this.DataGridView3.Rows[index4].Cells[4].Value, false)), (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index3].Cells[5].Value)) == -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index4].Cells[5].Value))))))
        {
          this.DataGridView4.Rows[index3].Cells[0].Value = (object) 1;
          this.DataGridView3.Rows[index4].Cells[0].Value = (object) 1;
        }
        checked { ++index4; }
      }
      checked { ++index3; }
    }
    int num5 = checked (this.DataGridView3.RowCount - 1);
    int index5 = 0;
    while (index5 <= num5)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index5].Cells[0].Value, (object) "0", false) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView3.Rows[index5].Cells[1].Value, (object) "OpBR", false))
      {
        this.DataGridView5.Rows.Add();
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[1].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[2].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[3].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[4].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[5].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index5].Cells[6].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = (object) "N";
      }
      checked { ++index5; }
    }
    int num6 = checked (this.DataGridView4.RowCount - 1);
    int index6 = 0;
    while (index6 <= num6)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index6].Cells[0].Value, (object) "0", false) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView4.Rows[index6].Cells[1].Value, (object) "OpBR", false))
      {
        this.DataGridView5.Rows.Add();
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[1].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[2].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[3].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[4].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[5].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[index6].Cells[6].Value);
        this.DataGridView5.Rows[checked (this.DataGridView5.RowCount - 1)].Cells[7].Value = (object) "Y";
      }
      checked { ++index6; }
    }
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    DataTable dataTable3 = new DataTable("SocTran");
    new OleDbDataAdapter("SELECT SocTran.SocTranType, SocTran.SocTranNo, SocTran.SocTranDate, SocTran.SocAccountMainId, SocAccount.AccName, SocTran.AccIndex, SocTran.SocTranAmount, SocTran.MainAccount FROM SocTran INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE (((SocTran.SocTranType)='MBil' Or (SocTran.SocTranType)='MDbn' Or (SocTran.SocTranType)='MCrn')) ORDER BY SocTran.SocTranType, SocTran.SocTranNo", selectConnection).Fill(dataTable3);
    this.DataGridView8.DataSource = (object) dataTable3;
    this.DataGridView8.ReadOnly = true;
    this.DataGridView8.RowHeadersVisible = false;
    this.DataGridView8.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter();
    DataTable dataTable4 = new DataTable("SocTran");
    new OleDbDataAdapter("SELECT SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocAccount.AccName FROM SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId ORDER BY SocBillSetting.AccIndex", selectConnection).Fill(dataTable4);
    this.DataGridView7.DataSource = (object) dataTable4;
    this.DataGridView7.ReadOnly = true;
    this.DataGridView7.RowHeadersVisible = false;
    this.DataGridView7.AllowUserToAddRows = false;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    this.DataGridView6.ColumnCount = 10;
    this.DataGridView6.RowCount = 0;
    this.DataGridView6.Columns[0].HeaderText = "Type";
    this.DataGridView6.Columns[1].HeaderText = "No.";
    this.DataGridView6.Columns[2].HeaderText = "Date";
    this.DataGridView6.Columns[3].HeaderText = "account id";
    this.DataGridView6.Columns[4].HeaderText = "Account Name";
    this.DataGridView6.Columns[5].HeaderText = "account id";
    this.DataGridView6.Columns[6].HeaderText = "Account Name";
    this.DataGridView6.Columns[7].HeaderText = "Index";
    this.DataGridView6.Columns[8].HeaderText = "Amount";
    this.DataGridView6.Columns[9].Visible = false;
    int num7 = checked (this.DataGridView7.RowCount - 1);
    int index7 = 0;
    while (index7 <= num7)
    {
      int num8 = checked (this.DataGridView8.RowCount - 1);
      int index8 = 0;
      while (index8 <= num8)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView7.Rows[index7].Cells[1].Value, this.DataGridView8.Rows[index8].Cells[5].Value, false) && Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView7.Rows[index7].Cells[0].Value, this.DataGridView8.Rows[index8].Cells[3].Value, false))
        {
          this.DataGridView6.Rows.Add();
          this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index8].Cells[0].Value);
          this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index8].Cells[1].Value);
          this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index8].Cells[2].Value);
          this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index8].Cells[3].Value);
          this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index8].Cells[4].Value);
          this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index7].Cells[0].Value);
          this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView7.Rows[index7].Cells[2].Value);
          this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index8].Cells[5].Value);
          this.DataGridView6.Rows[checked (this.DataGridView6.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView8.Rows[index8].Cells[6].Value);
        }
        checked { ++index8; }
      }
      checked { ++index7; }
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnDelete_Click(object sender, EventArgs e)
  {
  }
}
