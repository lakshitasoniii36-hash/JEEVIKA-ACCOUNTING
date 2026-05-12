// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMemberListTransferReport
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
public class frmMemberListTransferReport : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("rb6")]
  private RadioButton _rb6;
  [AccessedThroughProperty("rb5")]
  private RadioButton _rb5;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("btnShowReport")]
  private Button _btnShowReport;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("chkFirstName")]
  private CheckBox _chkFirstName;
  [AccessedThroughProperty("grpShowReport")]
  private GroupBox _grpShowReport;
  [AccessedThroughProperty("grpReport")]
  private GroupBox _grpReport;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("rb9")]
  private RadioButton _rb9;
  [AccessedThroughProperty("rb7")]
  private RadioButton _rb7;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;

  [DebuggerNonUserCode]
  static frmMemberListTransferReport()
  {
  }

  [DebuggerNonUserCode]
  public frmMemberListTransferReport()
  {
    this.Load += new EventHandler(this.frmMemberListTransferReport_Load);
    frmMemberListTransferReport.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMemberListTransferReport.__ENCList)
    {
      if (frmMemberListTransferReport.__ENCList.Count == frmMemberListTransferReport.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMemberListTransferReport.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMemberListTransferReport.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMemberListTransferReport.__ENCList[index1] = frmMemberListTransferReport.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMemberListTransferReport.__ENCList.RemoveRange(index1, checked (frmMemberListTransferReport.__ENCList.Count - index1));
        frmMemberListTransferReport.__ENCList.Capacity = frmMemberListTransferReport.__ENCList.Count;
      }
      frmMemberListTransferReport.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMemberListTransferReport));
    this.DataGridView2 = new DataGridView();
    this.GroupBox2 = new GroupBox();
    this.rb6 = new RadioButton();
    this.rb5 = new RadioButton();
    this.mtxtDateFrom = new MaskedTextBox();
    this.btnCancel = new Button();
    this.btnShowReport = new Button();
    this.btnPrint = new Button();
    this.DataGridView1 = new DataGridView();
    this.chkFirstName = new CheckBox();
    this.grpShowReport = new GroupBox();
    this.GroupBox3 = new GroupBox();
    this.mtxtDateTo = new MaskedTextBox();
    this.rb9 = new RadioButton();
    this.rb7 = new RadioButton();
    this.grpReport = new GroupBox();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpShowReport.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.grpReport.SuspendLayout();
    this.SuspendLayout();
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView2_1 = this.DataGridView2;
    Point point1 = new Point(0, 3);
    Point point2 = point1;
    dataGridView2_1.Location = point2;
    this.DataGridView2.Name = "DataGridView2";
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.RowHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    Size size1 = new Size(792, 559);
    Size size2 = size1;
    dataGridView2_2.Size = size2;
    this.DataGridView2.TabIndex = 32 /*0x20*/;
    this.GroupBox2.Controls.Add((Control) this.rb6);
    this.GroupBox2.Controls.Add((Control) this.rb5);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(6, 19);
    Point point3 = point1;
    groupBox2_1.Location = point3;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(180, 70);
    Size size3 = size1;
    groupBox2_2.Size = size3;
    this.GroupBox2.TabIndex = 34;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Transfer Type";
    this.rb6.AutoSize = true;
    RadioButton rb6_1 = this.rb6;
    point1 = new Point(27, 42);
    Point point4 = point1;
    rb6_1.Location = point4;
    this.rb6.Name = "rb6";
    RadioButton rb6_2 = this.rb6;
    size1 = new Size(87, 17);
    Size size4 = size1;
    rb6_2.Size = size4;
    this.rb6.TabIndex = 2;
    this.rb6.TabStop = true;
    this.rb6.Text = "Non Transfer";
    this.rb6.UseVisualStyleBackColor = true;
    this.rb5.AutoSize = true;
    RadioButton rb5_1 = this.rb5;
    point1 = new Point(27, 19);
    Point point5 = point1;
    rb5_1.Location = point5;
    this.rb5.Name = "rb5";
    RadioButton rb5_2 = this.rb5;
    size1 = new Size(64 /*0x40*/, 17);
    Size size5 = size1;
    rb5_2.Size = size5;
    this.rb5.TabIndex = 1;
    this.rb5.TabStop = true;
    this.rb5.Text = "Transfer";
    this.rb5.UseVisualStyleBackColor = true;
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(14, 42);
    Point point6 = point1;
    mtxtDateFrom1.Location = point6;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size6 = size1;
    mtxtDateFrom2.Size = size6;
    this.mtxtDateFrom.TabIndex = 57;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(46, 61);
    Point point7 = point1;
    btnCancel1.Location = point7;
    Button btnCancel2 = this.btnCancel;
    Padding padding1 = new Padding(4);
    Padding padding2 = padding1;
    btnCancel2.Margin = padding2;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel3 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnCancel3.Size = size7;
    this.btnCancel.TabIndex = 35;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    Button btnShowReport1 = this.btnShowReport;
    point1 = new Point(46, 259);
    Point point8 = point1;
    btnShowReport1.Location = point8;
    Button btnShowReport2 = this.btnShowReport;
    padding1 = new Padding(4);
    Padding padding3 = padding1;
    btnShowReport2.Margin = padding3;
    this.btnShowReport.Name = "btnShowReport";
    Button btnShowReport3 = this.btnShowReport;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnShowReport3.Size = size8;
    this.btnShowReport.TabIndex = 36;
    this.btnShowReport.Text = "Show Report";
    this.btnShowReport.UseVisualStyleBackColor = true;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(46, 20);
    Point point9 = point1;
    btnPrint1.Location = point9;
    Button btnPrint2 = this.btnPrint;
    padding1 = new Padding(4);
    Padding padding4 = padding1;
    btnPrint2.Margin = padding4;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint3 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size9 = size1;
    btnPrint3.Size = size9;
    this.btnPrint.TabIndex = 37;
    this.btnPrint.Text = "Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle4.BackColor = SystemColors.Control;
    gridViewCellStyle4.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.WindowText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle4;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Window;
    gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.ControlText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle5;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(970, 544);
    Point point10 = point1;
    dataGridView1_1.Location = point10;
    this.DataGridView1.MultiSelect = false;
    this.DataGridView1.Name = "DataGridView1";
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Control;
    gridViewCellStyle6.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.WindowText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.RowHeadersDefaultCellStyle = gridViewCellStyle6;
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView1_2.Size = size10;
    this.DataGridView1.TabIndex = 38;
    this.chkFirstName.AutoSize = true;
    CheckBox chkFirstName1 = this.chkFirstName;
    point1 = new Point(33, 222);
    Point point11 = point1;
    chkFirstName1.Location = point11;
    this.chkFirstName.Name = "chkFirstName";
    CheckBox chkFirstName2 = this.chkFirstName;
    size1 = new Size(130, 17);
    Size size11 = size1;
    chkFirstName2.Size = size11;
    this.chkFirstName.TabIndex = 39;
    this.chkFirstName.Text = "Show First Name Only";
    this.chkFirstName.UseVisualStyleBackColor = true;
    this.grpShowReport.Controls.Add((Control) this.GroupBox3);
    this.grpShowReport.Controls.Add((Control) this.chkFirstName);
    this.grpShowReport.Controls.Add((Control) this.GroupBox2);
    this.grpShowReport.Controls.Add((Control) this.btnShowReport);
    GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new Point(798, 2);
    Point point12 = point1;
    grpShowReport1.Location = point12;
    this.grpShowReport.Name = "grpShowReport";
    GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(191, 308);
    Size size12 = size1;
    grpShowReport2.Size = size12;
    this.grpShowReport.TabIndex = 40;
    this.grpShowReport.TabStop = false;
    this.GroupBox3.Controls.Add((Control) this.mtxtDateTo);
    this.GroupBox3.Controls.Add((Control) this.rb9);
    this.GroupBox3.Controls.Add((Control) this.mtxtDateFrom);
    this.GroupBox3.Controls.Add((Control) this.rb7);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(6, 104);
    Point point13 = point1;
    groupBox3_1.Location = point13;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(180, 85);
    Size size13 = size1;
    groupBox3_2.Size = size13;
    this.GroupBox3.TabIndex = 58;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Period";
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(97, 42);
    Point point14 = point1;
    mtxtDateTo1.Location = point14;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size14 = size1;
    mtxtDateTo2.Size = size14;
    this.mtxtDateTo.TabIndex = 58;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.rb9.AutoSize = true;
    RadioButton rb9_1 = this.rb9;
    point1 = new Point(100, 19);
    Point point15 = point1;
    rb9_1.Location = point15;
    this.rb9.Name = "rb9";
    RadioButton rb9_2 = this.rb9;
    size1 = new Size(57, 17);
    Size size15 = size1;
    rb9_2.Size = size15;
    this.rb9.TabIndex = 2;
    this.rb9.TabStop = true;
    this.rb9.Text = "Range";
    this.rb9.UseVisualStyleBackColor = true;
    this.rb7.AutoSize = true;
    RadioButton rb7_1 = this.rb7;
    point1 = new Point(27, 19);
    Point point16 = point1;
    rb7_1.Location = point16;
    this.rb7.Name = "rb7";
    RadioButton rb7_2 = this.rb7;
    size1 = new Size(36, 17);
    Size size16 = size1;
    rb7_2.Size = size16;
    this.rb7.TabIndex = 0;
    this.rb7.TabStop = true;
    this.rb7.Text = "All";
    this.rb7.UseVisualStyleBackColor = true;
    this.grpReport.Controls.Add((Control) this.btnPrint);
    this.grpReport.Controls.Add((Control) this.btnCancel);
    GroupBox grpReport1 = this.grpReport;
    point1 = new Point(798, 339);
    Point point17 = point1;
    grpReport1.Location = point17;
    this.grpReport.Name = "grpReport";
    GroupBox grpReport2 = this.grpReport;
    size1 = new Size(191, 109);
    Size size17 = size1;
    grpReport2.Size = size17;
    this.grpReport.TabIndex = 41;
    this.grpReport.TabStop = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpReport);
    this.Controls.Add((Control) this.grpShowReport);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.DataGridView2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMemberListTransferReport);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "frmMemberListReport";
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpShowReport.ResumeLayout(false);
    this.grpShowReport.PerformLayout();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox3.PerformLayout();
    this.grpReport.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual RadioButton rb6
  {
    [DebuggerNonUserCode] get => this._rb6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb6 = value;
  }

  internal virtual RadioButton rb5
  {
    [DebuggerNonUserCode] get => this._rb5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb5 = value;
  }

  internal virtual Button btnCancel
  {
    [DebuggerNonUserCode] get => this._btnCancel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      if (this._btnCancel != null)
        this._btnCancel.Click -= eventHandler;
      this._btnCancel = value;
      if (this._btnCancel == null)
        return;
      this._btnCancel.Click += eventHandler;
    }
  }

  internal virtual Button btnShowReport
  {
    [DebuggerNonUserCode] get => this._btnShowReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnShowReport_Click);
      if (this._btnShowReport != null)
        this._btnShowReport.Click -= eventHandler;
      this._btnShowReport = value;
      if (this._btnShowReport == null)
        return;
      this._btnShowReport.Click += eventHandler;
    }
  }

  internal virtual Button btnPrint
  {
    [DebuggerNonUserCode] get => this._btnPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrint_Click);
      if (this._btnPrint != null)
        this._btnPrint.Click -= eventHandler;
      this._btnPrint = value;
      if (this._btnPrint == null)
        return;
      this._btnPrint.Click += eventHandler;
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

  internal virtual MaskedTextBox mtxtDateFrom
  {
    [DebuggerNonUserCode] get => this._mtxtDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtDateFrom = value;
    }
  }

  internal virtual CheckBox chkFirstName
  {
    [DebuggerNonUserCode] get => this._chkFirstName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkFirstName = value;
    }
  }

  internal virtual GroupBox grpShowReport
  {
    [DebuggerNonUserCode] get => this._grpShowReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpShowReport = value;
    }
  }

  internal virtual GroupBox grpReport
  {
    [DebuggerNonUserCode] get => this._grpReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpReport = value;
    }
  }

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
    }
  }

  internal virtual RadioButton rb9
  {
    [DebuggerNonUserCode] get => this._rb9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb9_Click);
      if (this._rb9 != null)
        this._rb9.Click -= eventHandler;
      this._rb9 = value;
      if (this._rb9 == null)
        return;
      this._rb9.Click += eventHandler;
    }
  }

  internal virtual RadioButton rb7
  {
    [DebuggerNonUserCode] get => this._rb7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb7_Click);
      if (this._rb7 != null)
        this._rb7.Click -= eventHandler;
      this._rb7 = value;
      if (this._rb7 == null)
        return;
      this._rb7.Click += eventHandler;
    }
  }

  internal virtual MaskedTextBox mtxtDateTo
  {
    [DebuggerNonUserCode] get => this._mtxtDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtDateTo = value;
    }
  }

  private void frmMemberListTransferReport_Load(object sender, EventArgs e)
  {
    this.DataGridView1.Visible = false;
    this.rb5.Checked = true;
    this.rb7.Checked = true;
    this.mtxtDateFrom.Enabled = false;
    this.mtxtDateTo.Enabled = false;
    this.chkFirstName.Checked = false;
    this.grpShowReport.Enabled = true;
    this.grpReport.Enabled = false;
  }

  private void btnShowReport_Click(object sender, EventArgs e)
  {
    string str1;
    string str2;
    if (this.rb9.Checked)
    {
      if (!Information.IsDate((object) this.mtxtDateFrom.Text))
      {
        int num = (int) Interaction.MsgBox((object) "Invalid Date");
        this.mtxtDateFrom.Focus();
        return;
      }
      if (!Information.IsDate((object) this.mtxtDateTo.Text))
      {
        int num = (int) Interaction.MsgBox((object) "Invalid Date");
        this.mtxtDateTo.Focus();
        return;
      }
      str1 = MyProject.Forms.frmMemberElectionListReport.Chdate(this.mtxtDateFrom.Text);
      str2 = MyProject.Forms.frmMemberElectionListReport.Chdate(this.mtxtDateTo.Text);
    }
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    if (this.rb5.Checked)
    {
      if (this.rb7.Checked)
        oleDbDataAdapter = new OleDbDataAdapter("SELECT Member.* FROM Member WHERE(((Member.IsTransfer) = 'Y')) ORDER BY Member.MemRegn", selectConnection);
      if (this.rb9.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT Member.*, Member.DOT FROM Member WHERE (((Member.IsTransfer)='Y') AND ((Member.DOT)>=#{str1}# And (Member.DOT)<=#{str2}#)) ORDER BY Member.MemRegn", selectConnection);
    }
    if (this.rb6.Checked)
    {
      if (this.rb7.Checked)
        oleDbDataAdapter = new OleDbDataAdapter("SELECT Member.* FROM Member WHERE(((Member.IsTransfer) = 'N' Or (Member.IsTransfer) Is Null)) ORDER BY Member.MemRegn", selectConnection);
      if (this.rb9.Checked)
        oleDbDataAdapter = new OleDbDataAdapter($"SELECT Member.* FROM Member WHERE (((Member.IsTransfer)= 'N' Or (Member.IsTransfer) Is Null) AND ((Member.DOA)>=#{str1}# And (Member.DOA)<=#{str2}#)) ORDER BY Member.MemRegn", selectConnection);
    }
    DataTable dataTable = new DataTable("Member");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 9;
    this.DataGridView2.RowCount = 0;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index = 0;
    while (index <= num1)
    {
      this.DataGridView2.Rows.Add();
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[0].Value = (object) checked (index + 1);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[1].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[8].Value);
      string str3;
      if (!this.chkFirstName.Checked)
      {
        str3 = this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
        if (Strings.Len(this.DataGridView1.Rows[index].Cells[3].Value.ToString().Trim()) > 0)
          str3 = $"{str3}, {this.DataGridView1.Rows[index].Cells[3].Value.ToString().Trim()}";
        if (Strings.Len(this.DataGridView1.Rows[index].Cells[4].Value.ToString().Trim()) > 0)
          str3 = $"{str3}, {this.DataGridView1.Rows[index].Cells[4].Value.ToString().Trim()}";
        if (Strings.Len(this.DataGridView1.Rows[index].Cells[5].Value.ToString().Trim()) > 0)
          str3 = $"{str3}, {this.DataGridView1.Rows[index].Cells[5].Value.ToString().Trim()}";
      }
      else
        str3 = this.DataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[3].Value = (object) str3;
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[6].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[6].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[14].Value.ToString().Trim(), "Y", false) != 0 ? (object) "No" : (object) "Yes";
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[5].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[15].Value.ToString().Trim(), "N", false) != 0 ? (object) "Yes" : (object) "No";
      if (Information.IsDate(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[12].Value)))
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[7].Value = (object) this.DataGridView1.Rows[index].Cells[12].Value.ToString().Substring(0, 10);
      if (Information.IsDate(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[13].Value)))
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[8].Value = (object) this.DataGridView1.Rows[index].Cells[13].Value.ToString().Substring(0, 10);
      checked { ++index; }
    }
    this.DataGridView2.Columns[0].HeaderText = "Sr.No.";
    this.DataGridView2.Columns[1].HeaderText = "Member Regn.No.";
    this.DataGridView2.Columns[2].HeaderText = "Flat No.";
    this.DataGridView2.Columns[3].HeaderText = "Member Name";
    this.DataGridView2.Columns[4].HeaderText = "Address";
    this.DataGridView2.Columns[5].HeaderText = "Active";
    this.DataGridView2.Columns[6].HeaderText = "Transfer";
    this.DataGridView2.Columns[7].HeaderText = "Admission Date";
    this.DataGridView2.Columns[8].HeaderText = "Transfer Date";
    this.DataGridView2.Columns[0].Width = 70;
    this.DataGridView2.Columns[1].Width = 100;
    this.DataGridView2.Columns[2].Width = 100;
    this.DataGridView2.Columns[3].Width = 200;
    this.DataGridView2.Columns[4].Width = 200;
    this.DataGridView2.Columns[5].Width = 100;
    this.DataGridView2.Columns[6].Width = 100;
    this.DataGridView2.Columns[7].Width = 100;
    this.DataGridView2.Columns[8].Width = 100;
    this.DataGridView2.Columns[0].Name = "DC1";
    this.DataGridView2.Columns[1].Name = "DC2";
    this.DataGridView2.Columns[2].Name = "DC3";
    this.DataGridView2.Columns[3].Name = "DC4";
    this.DataGridView2.Columns[4].Name = "DC5";
    this.DataGridView2.Columns[5].Name = "DC6";
    this.DataGridView2.Columns[6].Name = "DC7";
    this.DataGridView2.Columns[7].Name = "DC8";
    this.DataGridView2.Columns[8].Name = "DC9";
    this.DataGridView2.ClearSelection();
    selectConnection.Close();
    this.grpShowReport.Enabled = false;
    this.grpReport.Enabled = true;
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.grpReport.Enabled = false;
    this.grpShowReport.Enabled = true;
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    DataSet1 dataSet1 = new DataSet1();
    DataTable dataTable1 = new DataTable("IR");
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("DC1");
    dataTable2.Columns.Add("DC2");
    dataTable2.Columns.Add("DC3");
    dataTable2.Columns.Add("DC4");
    dataTable2.Columns.Add("DC5");
    dataTable2.Columns.Add("DC6");
    dataTable2.Columns.Add("DC7");
    dataTable2.Columns.Add("DC8");
    dataTable2.Columns.Add("DC9");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView2.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["DC1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["DC9"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    string str;
    if (this.rb5.Checked)
      str = "Transfer";
    if (this.rb6.Checked)
      str = "Non-Transfer";
    string val;
    if (this.rb9.Checked)
      val = $"{str} Member List for period {this.mtxtDateFrom.Text} to {this.mtxtDateTo.Text}";
    if (this.rb7.Checked)
      val = str + " Member List ";
    MemberListReport memberListReport = new MemberListReport();
    frmCRShow frmCrShow = new frmCRShow();
    memberListReport.SetDataSource(dataTable1);
    memberListReport.SetParameterValue("societyname", (object) Constant.societyname);
    memberListReport.SetParameterValue("t1", (object) val);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) memberListReport;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void rb7_Click(object sender, EventArgs e)
  {
    if (this.rb7.Checked)
    {
      this.mtxtDateFrom.Enabled = false;
      this.mtxtDateTo.Enabled = false;
    }
    else
    {
      this.mtxtDateFrom.Enabled = true;
      this.mtxtDateTo.Enabled = true;
    }
  }

  private void rb9_Click(object sender, EventArgs e)
  {
    if (this.rb7.Checked)
    {
      this.mtxtDateFrom.Enabled = false;
      this.mtxtDateTo.Enabled = false;
    }
    else
    {
      this.mtxtDateFrom.Enabled = true;
      this.mtxtDateTo.Enabled = true;
    }
  }
}
