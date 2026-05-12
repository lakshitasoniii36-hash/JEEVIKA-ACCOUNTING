// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMemberExportList
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using MauliModule7.My;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmMemberExportList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("GroupBox5")]
  private System.Windows.Forms.GroupBox _GroupBox5;
  [AccessedThroughProperty("Label6")]
  private System.Windows.Forms.Label _Label6;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private System.Windows.Forms.TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label7")]
  private System.Windows.Forms.Label _Label7;
  [AccessedThroughProperty("btnListTo")]
  private System.Windows.Forms.Button _btnListTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private System.Windows.Forms.TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListFrom")]
  private System.Windows.Forms.Button _btnListFrom;
  [AccessedThroughProperty("btnExport")]
  private System.Windows.Forms.Button _btnExport;
  [AccessedThroughProperty("grpVisible")]
  private System.Windows.Forms.GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnPreviewForm")]
  private System.Windows.Forms.Button _btnPreviewForm;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("btnCancle")]
  private System.Windows.Forms.Button _btnCancle;

  [DebuggerNonUserCode]
  static frmMemberExportList()
  {
  }

  [DebuggerNonUserCode]
  public frmMemberExportList()
  {
    this.Load += new EventHandler(this.frmMemberExportList_Load);
    frmMemberExportList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMemberExportList.__ENCList)
    {
      if (frmMemberExportList.__ENCList.Count == frmMemberExportList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMemberExportList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMemberExportList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMemberExportList.__ENCList[index1] = frmMemberExportList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMemberExportList.__ENCList.RemoveRange(index1, checked (frmMemberExportList.__ENCList.Count - index1));
        frmMemberExportList.__ENCList.Capacity = frmMemberExportList.__ENCList.Count;
      }
      frmMemberExportList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMemberExportList));
    this.GroupBox5 = new System.Windows.Forms.GroupBox();
    this.Label6 = new System.Windows.Forms.Label();
    this.txtMemCodeFrom = new System.Windows.Forms.TextBox();
    this.Label7 = new System.Windows.Forms.Label();
    this.btnListTo = new System.Windows.Forms.Button();
    this.txtMemCodeTo = new System.Windows.Forms.TextBox();
    this.btnListFrom = new System.Windows.Forms.Button();
    this.btnExport = new System.Windows.Forms.Button();
    this.grpVisible = new System.Windows.Forms.GroupBox();
    this.DataGridView3 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView1 = new DataGridView();
    this.btnPreviewForm = new System.Windows.Forms.Button();
    this.btnCancle = new System.Windows.Forms.Button();
    this.GroupBox5.SuspendLayout();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.GroupBox5.Controls.Add((Control) this.Label6);
    this.GroupBox5.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox5.Controls.Add((Control) this.Label7);
    this.GroupBox5.Controls.Add((Control) this.btnListTo);
    this.GroupBox5.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox5.Controls.Add((Control) this.btnListFrom);
    System.Windows.Forms.GroupBox groupBox5_1 = this.GroupBox5;
    System.Drawing.Point point1 = new System.Drawing.Point(12, 57);
    System.Drawing.Point point2 = point1;
    groupBox5_1.Location = point2;
    this.GroupBox5.Name = "GroupBox5";
    System.Windows.Forms.GroupBox groupBox5_2 = this.GroupBox5;
    Size size1 = new Size((int) byte.MaxValue, 51);
    Size size2 = size1;
    groupBox5_2.Size = size2;
    this.GroupBox5.TabIndex = 7;
    this.GroupBox5.TabStop = false;
    this.GroupBox5.Text = "Member Range";
    this.Label6.AutoSize = true;
    this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.Black;
    System.Windows.Forms.Label label6_1 = this.Label6;
    point1 = new System.Drawing.Point(139, 25);
    System.Drawing.Point point3 = point1;
    label6_1.Location = point3;
    this.Label6.Name = "Label6";
    System.Windows.Forms.Label label6_2 = this.Label6;
    size1 = new Size(20, 13);
    Size size3 = size1;
    label6_2.Size = size3;
    this.Label6.TabIndex = 97;
    this.Label6.Text = "To";
    this.txtMemCodeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new System.Drawing.Point(49, 20);
    System.Drawing.Point point4 = point1;
    txtMemCodeFrom1.Location = point4;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    System.Windows.Forms.TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(68, 20);
    Size size4 = size1;
    txtMemCodeFrom2.Size = size4;
    this.txtMemCodeFrom.TabIndex = 7;
    this.Label7.AutoSize = true;
    this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.Black;
    System.Windows.Forms.Label label7_1 = this.Label7;
    point1 = new System.Drawing.Point(10, 25);
    System.Drawing.Point point5 = point1;
    label7_1.Location = point5;
    this.Label7.Name = "Label7";
    System.Windows.Forms.Label label7_2 = this.Label7;
    size1 = new Size(30, 13);
    Size size5 = size1;
    label7_2.Size = size5;
    this.Label7.TabIndex = 96 /*0x60*/;
    this.Label7.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnListTo1 = this.btnListTo;
    point1 = new System.Drawing.Point(231, 21);
    System.Drawing.Point point6 = point1;
    btnListTo1.Location = point6;
    this.btnListTo.Name = "btnListTo";
    System.Windows.Forms.Button btnListTo2 = this.btnListTo;
    size1 = new Size(22, 21);
    Size size6 = size1;
    btnListTo2.Size = size6;
    this.btnListTo.TabIndex = 10;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new System.Drawing.Point(162, 22);
    System.Drawing.Point point7 = point1;
    txtMemCodeTo1.Location = point7;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    System.Windows.Forms.TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(70, 20);
    Size size7 = size1;
    txtMemCodeTo2.Size = size7;
    this.txtMemCodeTo.TabIndex = 9;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    System.Windows.Forms.Button btnListFrom1 = this.btnListFrom;
    point1 = new System.Drawing.Point(116, 19);
    System.Drawing.Point point8 = point1;
    btnListFrom1.Location = point8;
    this.btnListFrom.Name = "btnListFrom";
    System.Windows.Forms.Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 21);
    Size size8 = size1;
    btnListFrom2.Size = size8;
    this.btnListFrom.TabIndex = 8;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    System.Windows.Forms.Button btnExport1 = this.btnExport;
    point1 = new System.Drawing.Point(29, 211);
    System.Drawing.Point point9 = point1;
    btnExport1.Location = point9;
    this.btnExport.Name = "btnExport";
    System.Windows.Forms.Button btnExport2 = this.btnExport;
    size1 = new Size(99, 33);
    Size size9 = size1;
    btnExport2.Size = size9;
    this.btnExport.TabIndex = 98;
    this.btnExport.Text = "Export List";
    this.btnExport.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    System.Windows.Forms.GroupBox grpVisible1 = this.grpVisible;
    point1 = new System.Drawing.Point(12, 12);
    System.Drawing.Point point10 = point1;
    grpVisible1.Location = point10;
    this.grpVisible.Name = "grpVisible";
    System.Windows.Forms.GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(253, 36);
    Size size10 = size1;
    grpVisible2.Size = size10;
    this.grpVisible.TabIndex = 99;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new System.Drawing.Point(144 /*0x90*/, 12);
    System.Drawing.Point point11 = point1;
    dataGridView3_1.Location = point11;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(16 /*0x10*/, 19);
    Size size11 = size1;
    dataGridView3_2.Size = size11;
    this.DataGridView3.TabIndex = 102;
    this.DataGridView3.TabStop = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new System.Drawing.Point(118, 9);
    System.Drawing.Point point12 = point1;
    dataGridView2_1.Location = point12;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(16 /*0x10*/, 19);
    Size size12 = size1;
    dataGridView2_2.Size = size12;
    this.DataGridView2.TabIndex = 101;
    this.DataGridView2.TabStop = false;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new System.Drawing.Point(38, 11);
    System.Drawing.Point point13 = point1;
    dataGridView1_1.Location = point13;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(16 /*0x10*/, 19);
    Size size13 = size1;
    dataGridView1_2.Size = size13;
    this.DataGridView1.TabIndex = 100;
    this.DataGridView1.TabStop = false;
    System.Windows.Forms.Button btnPreviewForm1 = this.btnPreviewForm;
    point1 = new System.Drawing.Point(29, 211);
    System.Drawing.Point point14 = point1;
    btnPreviewForm1.Location = point14;
    this.btnPreviewForm.Name = "btnPreviewForm";
    System.Windows.Forms.Button btnPreviewForm2 = this.btnPreviewForm;
    size1 = new Size(99, 33);
    Size size14 = size1;
    btnPreviewForm2.Size = size14;
    this.btnPreviewForm.TabIndex = 100;
    this.btnPreviewForm.Text = "Preview Form";
    this.btnPreviewForm.UseVisualStyleBackColor = true;
    System.Windows.Forms.Button btnCancle1 = this.btnCancle;
    point1 = new System.Drawing.Point(134, 211);
    System.Drawing.Point point15 = point1;
    btnCancle1.Location = point15;
    this.btnCancle.Name = "btnCancle";
    System.Windows.Forms.Button btnCancle2 = this.btnCancle;
    size1 = new Size(99, 33);
    Size size15 = size1;
    btnCancle2.Size = size15;
    this.btnCancle.TabIndex = 101;
    this.btnCancle.Text = "Ca&ncel";
    this.btnCancle.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(284, 262);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnCancle);
    this.Controls.Add((Control) this.btnPreviewForm);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnExport);
    this.Controls.Add((Control) this.GroupBox5);
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMemberExportList);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Export List";
    this.GroupBox5.ResumeLayout(false);
    this.GroupBox5.PerformLayout();
    this.grpVisible.ResumeLayout(false);
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
  }

  internal virtual System.Windows.Forms.GroupBox GroupBox5
  {
    [DebuggerNonUserCode] get => this._GroupBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox5 = value;
    }
  }

  internal virtual System.Windows.Forms.Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual System.Windows.Forms.TextBox txtMemCodeFrom
  {
    [DebuggerNonUserCode] get => this._txtMemCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtMemCodeFrom_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeFrom_KeyDown);
      if (this._txtMemCodeFrom != null)
      {
        this._txtMemCodeFrom.Validated -= eventHandler;
        this._txtMemCodeFrom.KeyDown -= keyEventHandler;
      }
      this._txtMemCodeFrom = value;
      if (this._txtMemCodeFrom == null)
        return;
      this._txtMemCodeFrom.Validated += eventHandler;
      this._txtMemCodeFrom.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual System.Windows.Forms.Button btnListTo
  {
    [DebuggerNonUserCode] get => this._btnListTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnListTo_Click);
      if (this._btnListTo != null)
        this._btnListTo.Click -= eventHandler;
      this._btnListTo = value;
      if (this._btnListTo == null)
        return;
      this._btnListTo.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.TextBox txtMemCodeTo
  {
    [DebuggerNonUserCode] get => this._txtMemCodeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtMemCodeTo_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeTo_KeyDown);
      if (this._txtMemCodeTo != null)
      {
        this._txtMemCodeTo.Validated -= eventHandler;
        this._txtMemCodeTo.KeyDown -= keyEventHandler;
      }
      this._txtMemCodeTo = value;
      if (this._txtMemCodeTo == null)
        return;
      this._txtMemCodeTo.Validated += eventHandler;
      this._txtMemCodeTo.KeyDown += keyEventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button btnListFrom
  {
    [DebuggerNonUserCode] get => this._btnListFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnListFrom_Click);
      if (this._btnListFrom != null)
        this._btnListFrom.Click -= eventHandler;
      this._btnListFrom = value;
      if (this._btnListFrom == null)
        return;
      this._btnListFrom.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.Button btnExport
  {
    [DebuggerNonUserCode] get => this._btnExport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnExport_Click);
      if (this._btnExport != null)
        this._btnExport.Click -= eventHandler;
      this._btnExport = value;
      if (this._btnExport == null)
        return;
      this._btnExport.Click += eventHandler;
    }
  }

  internal virtual System.Windows.Forms.GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
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

  internal virtual System.Windows.Forms.Button btnPreviewForm
  {
    [DebuggerNonUserCode] get => this._btnPreviewForm;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPreviewForm_Click);
      if (this._btnPreviewForm != null)
        this._btnPreviewForm.Click -= eventHandler;
      this._btnPreviewForm = value;
      if (this._btnPreviewForm == null)
        return;
      this._btnPreviewForm.Click += eventHandler;
    }
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
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

  internal virtual System.Windows.Forms.Button btnCancle
  {
    [DebuggerNonUserCode] get => this._btnCancle;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancle_Click);
      if (this._btnCancle != null)
        this._btnCancle.Click -= eventHandler;
      this._btnCancle = value;
      if (this._btnCancle == null)
        return;
      this._btnCancle.Click += eventHandler;
    }
  }

  private void frmMemberExportList_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = this.txtMemCodeFrom.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtMemCodeTo.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnListTo_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = this.txtMemCodeTo.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.btnExport.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtMemCodeFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCodeTo.Focus();
  }

  private void txtMemCodeFrom_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeFrom.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      Constant.SearchStr = this.txtMemCodeFrom.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
        this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void txtMemCodeTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnExport.Focus();
  }

  private void txtMemCodeTo_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeTo.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      Constant.SearchStr = this.txtMemCodeTo.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
        this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void btnExport_Click(object sender, EventArgs e)
  {
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    System.Data.DataTable dataTable = new System.Data.DataTable("SocMember");
    new OleDbDataAdapter($"SELECT SocMemId,MemCode,Bldg,Wing,FlatType,FlatNo,Floor,Sqft,MemName,MemName1,MemName2,MemName3,MemMobile2,MemMobile,MemMobile1,MemEmail,MemEmail1,MemEmail2,MemAddress,Poss_Date,ParkDetail,NocDetail,LaonDetail,BankName,DefaPart,Op_Prin,Op_Int,[Op_Prin]+[op_Int] AS Expr1,IsTransfer FROM SocMember WHERE (SocMember.MemCode>='{Constant.MemberCodeRangeFrom.Trim()}' And SocMember.MemCode<='{Constant.MemberCodeRangeto.Trim()}') order by MemCode asc", selectConnection).Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].HeaderText = "Software Id No.";
    this.DataGridView1.Columns[1].HeaderText = "Member Code";
    this.DataGridView1.Columns[2].HeaderText = "Bldg";
    this.DataGridView1.Columns[3].HeaderText = "Wing";
    this.DataGridView1.Columns[4].HeaderText = "Flat Type";
    this.DataGridView1.Columns[5].HeaderText = "Flat No.";
    this.DataGridView1.Columns[6].HeaderText = "Floor";
    this.DataGridView1.Columns[7].HeaderText = "Sqft";
    this.DataGridView1.Columns[8].HeaderText = "Member Name1";
    this.DataGridView1.Columns[9].HeaderText = "Member Name2";
    this.DataGridView1.Columns[10].HeaderText = "Member Name3";
    this.DataGridView1.Columns[11].HeaderText = "Member Name4";
    this.DataGridView1.Columns[12].HeaderText = "GST No.";
    this.DataGridView1.Columns[13].HeaderText = "Contact No.";
    this.DataGridView1.Columns[14].HeaderText = "Contact No.1";
    this.DataGridView1.Columns[15].HeaderText = "Email Id";
    this.DataGridView1.Columns[16 /*0x10*/].HeaderText = "Email Id1";
    this.DataGridView1.Columns[17].HeaderText = "Email Id2";
    this.DataGridView1.Columns[18].HeaderText = "Address";
    this.DataGridView1.Columns[19].HeaderText = "Possession Date";
    this.DataGridView1.Columns[20].HeaderText = "Parking Details";
    this.DataGridView1.Columns[21].HeaderText = "Noc Details";
    this.DataGridView1.Columns[22].HeaderText = "Loan Details";
    this.DataGridView1.Columns[23].HeaderText = "Bank Name";
    this.DataGridView1.Columns[24].HeaderText = "Default Part";
    this.DataGridView1.Columns[25].HeaderText = "Op.Prin.";
    this.DataGridView1.Columns[26].HeaderText = "Op.Int.";
    this.DataGridView1.Columns[27].HeaderText = "Total Op.";
    this.DataGridView1.Columns[28].HeaderText = "Transfer";
    Cursor.Current = Cursors.WaitCursor;
    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new ApplicationClass();
    try
    {
      Worksheet worksheet1 = (Worksheet) application.Workbooks.Add((object) Missing.Value).Worksheets[(object) 1];
      application.Visible = true;
      short num1 = checked ((short) (this.DataGridView1.RowCount - 1));
      short num2 = checked ((short) (this.DataGridView1.Columns.Count - 1));
      Worksheet worksheet2 = worksheet1;
      worksheet2.Cells.Select();
      worksheet2.Cells.Delete((object) Missing.Value);
      short num3 = num2;
      short index1 = 0;
      while ((int) index1 <= (int) num3)
      {
        NewLateBinding.LateSetComplex(worksheet2.Cells[(object) 1, (object) checked ((int) index1 + 1)], (System.Type) null, "Value", new object[1]
        {
          (object) this.DataGridView1.Columns[(int) index1].HeaderText
        }, (string[]) null, (System.Type[]) null, false, true);
        checked { ++index1; }
      }
      short num4 = num1;
      short index2 = 0;
      while ((int) index2 <= (int) num4)
      {
        short num5 = num2;
        short index3 = 0;
        while ((int) index3 <= (int) num5)
        {
          NewLateBinding.LateSetComplex(worksheet2.Cells[(object) checked ((int) index2 + 2), (object) checked ((int) index3 + 1)], (System.Type) null, "value", new object[1]
          {
            RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[(int) index2].Cells[(int) index3].Value)
          }, (string[]) null, (System.Type[]) null, false, true);
          checked { ++index3; }
        }
        checked { ++index2; }
      }
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Rows[(object) "1:1", (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "FontStyle", new object[1]
      {
        (object) "Bold"
      }, (string[]) null, (System.Type[]) null, false, true);
      NewLateBinding.LateSetComplex(NewLateBinding.LateGet(worksheet2.Rows[(object) "1:1", (object) Missing.Value], (System.Type) null, "Font", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (System.Type) null, "Size", new object[1]
      {
        (object) 10
      }, (string[]) null, (System.Type[]) null, false, true);
      worksheet2.Cells.Columns.AutoFit();
      worksheet2.Cells.Select();
      worksheet2.Cells.EntireColumn.AutoFit();
      NewLateBinding.LateCall(worksheet2.Cells[(object) 1, (object) 1], (System.Type) null, "Select", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num = (int) Interaction.MsgBox((object) ("Export Excel Error " + ex.Message));
      ProjectData.ClearProjectError();
    }
    finally
    {
      Cursor.Current = Cursors.Default;
      int num = (int) Interaction.MsgBox((object) "Export Complete ");
    }
  }

  private void btnPreviewForm_Click(object sender, EventArgs e)
  {
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    System.Data.DataTable dataTable1 = new System.Data.DataTable("SocMember");
    new OleDbDataAdapter($"SELECT SocMemId,MemCode,Bldg,Wing,FlatType,FlatNo,Floor,Sqft,MemName,MemName1,MemName2,MemName3,MemMobile2,MemMobile,MemMobile1,MemEmail,MemEmail1,MemEmail2,MemAddress,Poss_Date,ParkDetail,NocDetail,LaonDetail,BankName,DefaPart,Op_Prin,Op_Int,[Op_Prin]+[op_Int] AS Expr1,IsTransfer FROM SocMember WHERE (SocMember.MemCode>='{Constant.MemberCodeRangeFrom.Trim()}' And SocMember.MemCode<='{Constant.MemberCodeRangeto.Trim()}') order by MemCode asc", selectConnection).Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocInfo", selectConnection);
    System.Data.DataTable dataTable2 = new System.Data.DataTable("SocInfo");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.RowCount = 0;
    this.DataGridView3.ColumnCount = this.DataGridView1.ColumnCount;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView3.Rows.Add();
      int num2 = checked (this.DataGridView1.ColumnCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        this.DataGridView3.Rows[index1].Cells[index2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[index2].Value);
        checked { ++index2; }
      }
      checked { ++index1; }
    }
    int index3 = 0;
    do
    {
      this.DataGridView3.Columns[index3].Name = "C" + checked (index3 + 1).ToString().Trim();
      checked { ++index3; }
    }
    while (index3 <= 28);
    System.Data.DataTable dataTable3 = new System.Data.DataTable();
    System.Data.DataTable dataTable4 = dataTable3;
    dataTable4.Columns.Add("C1");
    dataTable4.Columns.Add("C2");
    dataTable4.Columns.Add("C3");
    dataTable4.Columns.Add("C4");
    dataTable4.Columns.Add("C5");
    dataTable4.Columns.Add("C6");
    dataTable4.Columns.Add("C7");
    dataTable4.Columns.Add("C8");
    dataTable4.Columns.Add("C9");
    dataTable4.Columns.Add("C10");
    dataTable4.Columns.Add("C11");
    dataTable4.Columns.Add("C12");
    dataTable4.Columns.Add("C13");
    dataTable4.Columns.Add("C14");
    dataTable4.Columns.Add("C15");
    dataTable4.Columns.Add("C16");
    dataTable4.Columns.Add("C17");
    dataTable4.Columns.Add("C18");
    dataTable4.Columns.Add("C19");
    dataTable4.Columns.Add("C20");
    dataTable4.Columns.Add("C21");
    dataTable4.Columns.Add("C22");
    dataTable4.Columns.Add("C23");
    dataTable4.Columns.Add("C24");
    dataTable4.Columns.Add("C25");
    dataTable4.Columns.Add("C26");
    dataTable4.Columns.Add("C27");
    dataTable4.Columns.Add("C28");
    dataTable4.Columns.Add("C29");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView3.Rows)
        dataTable3.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C25"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C26"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C27"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C28"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C29"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportMemberFormExport();
    reportDocument.SetDataSource(dataTable3);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    int num3 = (int) MyProject.Forms.frmCRShow.ShowDialog();
    MyProject.Forms.frmCRShow.Dispose();
  }

  private void btnCancle_Click(object sender, EventArgs e) => this.Close();
}
