// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmYearBf
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmYearBf : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("mtxtDateTo")]
  private MaskedTextBox _mtxtDateTo;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("cmbMemberBalance")]
  private ComboBox _cmbMemberBalance;
  [AccessedThroughProperty("cmbAccountBalance")]
  private ComboBox _cmbAccountBalance;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("grpvisible")]
  private GroupBox _grpvisible;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("lblAccountMainId")]
  private Label _lblAccountMainId;
  [AccessedThroughProperty("lblAccountId")]
  private Label _lblAccountId;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;

  [DebuggerNonUserCode]
  static frmYearBf()
  {
  }

  [DebuggerNonUserCode]
  public frmYearBf()
  {
    this.KeyDown += new KeyEventHandler(this.frmYearBf_KeyDown);
    this.Load += new EventHandler(this.frmYearBf_Load);
    frmYearBf.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmYearBf.__ENCList)
    {
      if (frmYearBf.__ENCList.Count == frmYearBf.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmYearBf.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmYearBf.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmYearBf.__ENCList[index1] = frmYearBf.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmYearBf.__ENCList.RemoveRange(index1, checked (frmYearBf.__ENCList.Count - index1));
        frmYearBf.__ENCList.Capacity = frmYearBf.__ENCList.Count;
      }
      frmYearBf.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmYearBf));
    this.btnOk = new Button();
    this.btnCancel = new Button();
    this.Label1 = new Label();
    this.mtxtDateTo = new MaskedTextBox();
    this.mtxtDateFrom = new MaskedTextBox();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.DataGridView1 = new DataGridView();
    this.Label4 = new Label();
    this.cmbMemberBalance = new ComboBox();
    this.cmbAccountBalance = new ComboBox();
    this.DataGridView2 = new DataGridView();
    this.grpvisible = new GroupBox();
    this.DataGridView7 = new DataGridView();
    this.DataGridView6 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.pb1 = new ProgressBar();
    this.Button2 = new Button();
    this.Label5 = new Label();
    this.DataGridView8 = new DataGridView();
    this.lblAccountMainId = new Label();
    this.lblAccountId = new Label();
    this.DataGridView9 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.grpvisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    this.SuspendLayout();
    this.btnOk.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnOk1 = this.btnOk;
    Point point1 = new Point(55, 290);
    Point point2 = point1;
    btnOk1.Location = point2;
    this.btnOk.Name = "btnOk";
    Button btnOk2 = this.btnOk;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnOk2.Size = size2;
    this.btnOk.TabIndex = 4;
    this.btnOk.Text = "O&k";
    this.btnOk.UseVisualStyleBackColor = true;
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(160 /*0xA0*/, 290);
    Point point3 = point1;
    btnCancel1.Location = point3;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnCancel2.Size = size3;
    this.btnCancel.TabIndex = 5;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(25, 138);
    Point point4 = point1;
    label1_1.Location = point4;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(130, 16 /*0x10*/);
    Size size4 = size1;
    label1_2.Size = size4;
    this.Label1.TabIndex = 8;
    this.Label1.Text = "C/f Member Balance";
    this.mtxtDateTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateTo.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateTo1 = this.mtxtDateTo;
    point1 = new Point(215, 72);
    Point point5 = point1;
    mtxtDateTo1.Location = point5;
    this.mtxtDateTo.Mask = "00/00/0000";
    this.mtxtDateTo.Name = "mtxtDateTo";
    MaskedTextBox mtxtDateTo2 = this.mtxtDateTo;
    size1 = new Size(77, 22);
    Size size5 = size1;
    mtxtDateTo2.Size = size5;
    this.mtxtDateTo.TabIndex = 1;
    this.mtxtDateTo.ValidatingType = typeof (DateTime);
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(89, 72);
    Point point6 = point1;
    mtxtDateFrom1.Location = point6;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size6 = size1;
    mtxtDateFrom2.Size = size6;
    this.mtxtDateFrom.TabIndex = 0;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(172, 72);
    Point point7 = point1;
    label2_1.Location = point7;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(25, 16 /*0x10*/);
    Size size7 = size1;
    label2_2.Size = size7;
    this.Label2.TabIndex = 12;
    this.Label2.Text = "To";
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(26, 75);
    Point point8 = point1;
    label3_1.Location = point8;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(39, 16 /*0x10*/);
    Size size8 = size1;
    label3_2.Size = size8;
    this.Label3.TabIndex = 10;
    this.Label3.Text = "From";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(15, 19);
    Point point9 = point1;
    dataGridView1_1.Location = point9;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 13);
    Size size9 = size1;
    dataGridView1_2.Size = size9;
    this.DataGridView1.TabIndex = 13;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(25, 165);
    Point point10 = point1;
    label4_1.Location = point10;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(128 /*0x80*/, 16 /*0x10*/);
    Size size10 = size1;
    label4_2.Size = size10;
    this.Label4.TabIndex = 16 /*0x10*/;
    this.Label4.Text = "C/f Account Balance";
    this.cmbMemberBalance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbMemberBalance.FormattingEnabled = true;
    this.cmbMemberBalance.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbMemberBalance1 = this.cmbMemberBalance;
    point1 = new Point(195, 133);
    Point point11 = point1;
    cmbMemberBalance1.Location = point11;
    this.cmbMemberBalance.Name = "cmbMemberBalance";
    ComboBox cmbMemberBalance2 = this.cmbMemberBalance;
    size1 = new Size(76, 24);
    Size size11 = size1;
    cmbMemberBalance2.Size = size11;
    this.cmbMemberBalance.TabIndex = 2;
    this.cmbMemberBalance.Text = "No";
    this.cmbAccountBalance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbAccountBalance.FormattingEnabled = true;
    this.cmbAccountBalance.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbAccountBalance1 = this.cmbAccountBalance;
    point1 = new Point(195, 163);
    Point point12 = point1;
    cmbAccountBalance1.Location = point12;
    this.cmbAccountBalance.Name = "cmbAccountBalance";
    ComboBox cmbAccountBalance2 = this.cmbAccountBalance;
    size1 = new Size(76, 24);
    Size size12 = size1;
    cmbAccountBalance2.Size = size12;
    this.cmbAccountBalance.TabIndex = 3;
    this.cmbAccountBalance.Text = "Yes";
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(31 /*0x1F*/, 19);
    Point point13 = point1;
    dataGridView2_1.Location = point13;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 13);
    Size size13 = size1;
    dataGridView2_2.Size = size13;
    this.DataGridView2.TabIndex = 21;
    this.grpvisible.Controls.Add((Control) this.DataGridView9);
    this.grpvisible.Controls.Add((Control) this.lblAccountId);
    this.grpvisible.Controls.Add((Control) this.lblAccountMainId);
    this.grpvisible.Controls.Add((Control) this.DataGridView8);
    this.grpvisible.Controls.Add((Control) this.DataGridView7);
    this.grpvisible.Controls.Add((Control) this.DataGridView6);
    this.grpvisible.Controls.Add((Control) this.DataGridView5);
    this.grpvisible.Controls.Add((Control) this.DataGridView4);
    this.grpvisible.Controls.Add((Control) this.DataGridView3);
    this.grpvisible.Controls.Add((Control) this.DataGridView2);
    this.grpvisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpvisible1 = this.grpvisible;
    point1 = new Point(88, 212);
    Point point14 = point1;
    grpvisible1.Location = point14;
    this.grpvisible.Name = "grpvisible";
    GroupBox grpvisible2 = this.grpvisible;
    size1 = new Size(118, 58);
    Size size14 = size1;
    grpvisible2.Size = size14;
    this.grpvisible.TabIndex = 22;
    this.grpvisible.TabStop = false;
    this.grpvisible.Text = "GroupBox1";
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(63 /*0x3F*/, 19);
    Point point15 = point1;
    dataGridView7_1.Location = point15;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 13);
    Size size15 = size1;
    dataGridView7_2.Size = size15;
    this.DataGridView7.TabIndex = 26;
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(47, 38);
    Point point16 = point1;
    dataGridView6_1.Location = point16;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 13);
    Size size16 = size1;
    dataGridView6_2.Size = size16;
    this.DataGridView6.TabIndex = 25;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(47, 19);
    Point point17 = point1;
    dataGridView5_1.Location = point17;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 13);
    Size size17 = size1;
    dataGridView5_2.Size = size17;
    this.DataGridView5.TabIndex = 24;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(31 /*0x1F*/, 39);
    Point point18 = point1;
    dataGridView4_1.Location = point18;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 13);
    Size size18 = size1;
    dataGridView4_2.Size = size18;
    this.DataGridView4.TabIndex = 23;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(15, 39);
    Point point19 = point1;
    dataGridView3_1.Location = point19;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 13);
    Size size19 = size1;
    dataGridView3_2.Size = size19;
    this.DataGridView3.TabIndex = 22;
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(1, 331);
    Point point20 = point1;
    pb1_1.Location = point20;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(311, 23);
    Size size20 = size1;
    pb1_2.Size = size20;
    this.pb1.TabIndex = 23;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(233, 290);
    Point point21 = point1;
    button2_1.Location = point21;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size21 = size1;
    button2_2.Size = size21;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.Red;
    Label label5_1 = this.Label5;
    point1 = new Point(12, 18);
    Point point22 = point1;
    label5_1.Location = point22;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(300, 16 /*0x10*/);
    Size size22 = size1;
    label5_2.Size = size22;
    this.Label5.TabIndex = 84;
    this.Label5.Text = "Please Use Rebuild before use this option";
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(63 /*0x3F*/, 38);
    Point point23 = point1;
    dataGridView8_1.Location = point23;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 13);
    Size size23 = size1;
    dataGridView8_2.Size = size23;
    this.DataGridView8.TabIndex = 27;
    this.lblAccountMainId.AutoSize = true;
    this.lblAccountMainId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblAccountMainId1 = this.lblAccountMainId;
    point1 = new Point(79, 18);
    Point point24 = point1;
    lblAccountMainId1.Location = point24;
    this.lblAccountMainId.Name = "lblAccountMainId";
    Label lblAccountMainId2 = this.lblAccountMainId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size24 = size1;
    lblAccountMainId2.Size = size24;
    this.lblAccountMainId.TabIndex = 85;
    this.lblAccountMainId.Text = "0";
    this.lblAccountId.AutoSize = true;
    this.lblAccountId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblAccountId1 = this.lblAccountId;
    point1 = new Point(79, 35);
    Point point25 = point1;
    lblAccountId1.Location = point25;
    this.lblAccountId.Name = "lblAccountId";
    Label lblAccountId2 = this.lblAccountId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size25 = size1;
    lblAccountId2.Size = size25;
    this.lblAccountId.TabIndex = 86;
    this.lblAccountId.Text = "0";
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new Point(99, 19);
    Point point26 = point1;
    dataGridView9_1.Location = point26;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 13);
    Size size26 = size1;
    dataGridView9_2.Size = size26;
    this.DataGridView9.TabIndex = 87;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.grpvisible);
    this.Controls.Add((Control) this.cmbAccountBalance);
    this.Controls.Add((Control) this.cmbMemberBalance);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.mtxtDateTo);
    this.Controls.Add((Control) this.mtxtDateFrom);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmYearBf);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Last Year Balance Forward";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.grpvisible.ResumeLayout(false);
    this.grpvisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnOk
  {
    [DebuggerNonUserCode] get => this._btnOk;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOk_Click);
      if (this._btnOk != null)
        this._btnOk.Click -= eventHandler;
      this._btnOk = value;
      if (this._btnOk == null)
        return;
      this._btnOk.Click += eventHandler;
    }
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual MaskedTextBox mtxtDateTo
  {
    [DebuggerNonUserCode] get => this._mtxtDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtDateTo_GotFocus);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDateTo_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDateTo_KeyDown);
      if (this._mtxtDateTo != null)
      {
        this._mtxtDateTo.GotFocus -= eventHandler1;
        this._mtxtDateTo.Validated -= eventHandler2;
        this._mtxtDateTo.KeyDown -= keyEventHandler;
      }
      this._mtxtDateTo = value;
      if (this._mtxtDateTo == null)
        return;
      this._mtxtDateTo.GotFocus += eventHandler1;
      this._mtxtDateTo.Validated += eventHandler2;
      this._mtxtDateTo.KeyDown += keyEventHandler;
    }
  }

  internal virtual MaskedTextBox mtxtDateFrom
  {
    [DebuggerNonUserCode] get => this._mtxtDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.mtxtDateFrom_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDateFrom_KeyDown);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDateFrom_GotFocus);
      if (this._mtxtDateFrom != null)
      {
        this._mtxtDateFrom.Validated -= eventHandler1;
        this._mtxtDateFrom.KeyDown -= keyEventHandler;
        this._mtxtDateFrom.GotFocus -= eventHandler2;
      }
      this._mtxtDateFrom = value;
      if (this._mtxtDateFrom == null)
        return;
      this._mtxtDateFrom.Validated += eventHandler1;
      this._mtxtDateFrom.KeyDown += keyEventHandler;
      this._mtxtDateFrom.GotFocus += eventHandler2;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual ComboBox cmbMemberBalance
  {
    [DebuggerNonUserCode] get => this._cmbMemberBalance;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbMemberBalance_KeyDown);
      if (this._cmbMemberBalance != null)
        this._cmbMemberBalance.KeyDown -= keyEventHandler;
      this._cmbMemberBalance = value;
      if (this._cmbMemberBalance == null)
        return;
      this._cmbMemberBalance.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbAccountBalance
  {
    [DebuggerNonUserCode] get => this._cmbAccountBalance;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbAccountBalance_KeyDown);
      if (this._cmbAccountBalance != null)
        this._cmbAccountBalance.KeyDown -= keyEventHandler;
      this._cmbAccountBalance = value;
      if (this._cmbAccountBalance == null)
        return;
      this._cmbAccountBalance.KeyDown += keyEventHandler;
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

  internal virtual GroupBox grpvisible
  {
    [DebuggerNonUserCode] get => this._grpvisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpvisible = value;
    }
  }

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
  }

  internal virtual Button Button2
  {
    [DebuggerNonUserCode] get => this._Button2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button2_Click);
      if (this._Button2 != null)
        this._Button2.Click -= eventHandler;
      this._Button2 = value;
      if (this._Button2 == null)
        return;
      this._Button2.Click += eventHandler;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
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

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
    }
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

  internal virtual Label lblAccountMainId
  {
    [DebuggerNonUserCode] get => this._lblAccountMainId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountMainId = value;
    }
  }

  internal virtual Label lblAccountId
  {
    [DebuggerNonUserCode] get => this._lblAccountId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountId = value;
    }
  }

  internal virtual DataGridView DataGridView9
  {
    [DebuggerNonUserCode] get => this._DataGridView9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView9 = value;
    }
  }

  private void frmYearBf_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmYearBf_Load(object sender, EventArgs e)
  {
    this.grpvisible.Visible = false;
    this.mtxtDateFrom.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Interaction.IIf(Microsoft.VisualBasic.Strings.Len(Constant.socFYSTART.Day.ToString()) == 1, (object) ("0" + Constant.socFYSTART.Day.ToString()), (object) Constant.socFYSTART.Day.ToString()), (object) "/"), Interaction.IIf(Microsoft.VisualBasic.Strings.Len(Constant.socFYSTART.Month.ToString()) == 1, (object) ("0" + Constant.socFYSTART.Month.ToString()), (object) Constant.socFYSTART.Month.ToString())), (object) "/"), (object) checked (Constant.socFYSTART.Year - 1).ToString()));
    this.mtxtDateTo.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Interaction.IIf(Microsoft.VisualBasic.Strings.Len(Constant.socFYEND.Day.ToString()) == 1, (object) ("0" + Constant.socFYEND.Day.ToString()), (object) Constant.socFYEND.Day.ToString()), (object) "/"), Interaction.IIf(Microsoft.VisualBasic.Strings.Len(Constant.socFYEND.Month.ToString()) == 1, (object) ("0" + Constant.socFYEND.Month.ToString()), (object) Constant.socFYEND.Month.ToString())), (object) "/"), (object) checked (Constant.socFYEND.Year - 1).ToString()));
  }

  private void mtxtDateFrom_GotFocus(object sender, EventArgs e) => this.mtxtDateFrom.Select(0, 0);

  private void mtxtDateFrom_Validated(object sender, EventArgs e)
  {
    if (new GeneralValidation().Vdate(this.mtxtDateFrom.Text.ToString()))
      return;
    this.mtxtDateFrom.Focus();
  }

  private void mtxtDateTo_GotFocus(object sender, EventArgs e) => this.mtxtDateTo.Select(0, 0);

  private void mtxtDateTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbMemberBalance.Focus();
  }

  private void mtxtDateTo_Validated(object sender, EventArgs e)
  {
    if (new GeneralValidation().Vdate(this.mtxtDateTo.Text.ToString()))
      return;
    this.mtxtDateTo.Focus();
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    int num1 = (int) MyProject.Forms.SocietyBfDialog.ShowDialog();
    if (Conversions.ToDouble(MyProject.Forms.SocietyBfDialog.lblResult.Text) == 1.0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.SocietyBfDialog.txtDeletePassword.Text, "MSC", false) == 0)
    {
      string str1 = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Conversions.ToDate(this.mtxtDateFrom.Text))).Trim()}{Conversion.Str((object) DateAndTime.Year(Conversions.ToDate(this.mtxtDateTo.Text))).Trim()}.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
      string str2 = $"\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Conversions.ToDate(this.mtxtDateFrom.Text))).Trim()}{Conversion.Str((object) DateAndTime.Year(Conversions.ToDate(this.mtxtDateTo.Text))).Trim()}.accdb";
      this.mtxtDateFrom.Text = MyProject.Forms.frmSocietyDetail.Chdate(this.mtxtDateFrom.Text);
      this.mtxtDateTo.Text = MyProject.Forms.frmSocietyDetail.Chdate(this.mtxtDateTo.Text);
      if (File.Exists(Constant.socDataPath + str2))
      {
        this.pb1.Value = 0;
        OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{str1}");
        OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        string cmdText1;
        OleDbCommand oleDbCommand1 = new OleDbCommand(cmdText1, oleDbConnection);
        OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocGroup.SocGroupId, SocGroup.GrpName, SocGroup.GrpMainId, SocGroup.GrpPrimaryId, SocGroup.GrpType, SocGroup.GrpPrimaryName FROM SocGroup ORDER BY SocGroup.SocGroupId", selectConnection);
        DataTable dataTable1 = new DataTable("SocTran");
        oleDbDataAdapter1.Fill(dataTable1);
        this.DataGridView4.DataSource = (object) dataTable1;
        this.DataGridView4.ReadOnly = true;
        this.DataGridView4.RowHeadersVisible = false;
        this.DataGridView4.AllowUserToAddRows = false;
        selectConnection.Close();
        OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocGroup.SocGroupId, SocGroup.GrpName, SocGroup.GrpMainId, SocGroup.GrpPrimaryId, SocGroup.GrpType, SocGroup.GrpPrimaryName FROM SocGroup ORDER BY SocGroup.SocGroupId", oleDbConnection);
        DataTable dataTable2 = new DataTable("SocTran");
        oleDbDataAdapter2.Fill(dataTable2);
        this.DataGridView5.DataSource = (object) dataTable2;
        this.DataGridView5.ReadOnly = true;
        this.DataGridView5.RowHeadersVisible = false;
        this.DataGridView5.AllowUserToAddRows = false;
        selectConnection.Close();
        int num2 = checked (this.DataGridView4.RowCount - 1);
        int index1 = 0;
        while (index1 <= num2)
        {
          int num3 = 0;
          int num4 = checked (this.DataGridView5.RowCount - 1);
          int index2 = 0;
          while (index2 <= num4)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView4.Rows[index1].Cells[3].Value, this.DataGridView5.Rows[index2].Cells[3].Value, false))
              num3 = 1;
            checked { ++index2; }
          }
          string cmdText2;
          if (num3 == 0)
          {
            this.DataGridView4.Rows[index1].Cells[5].Value = (object) this.DataGridView4.Rows[index1].Cells[5].Value.ToString().Replace("'", "''");
            this.DataGridView4.Rows[index1].Cells[1].Value = (object) this.DataGridView4.Rows[index1].Cells[1].Value.ToString().Replace("'", "''");
            cmdText2 = $"Insert Into SocGroup (SocGroupId, GrpName, GrpMainId , GrpPrimaryId, GrpType, GrpPrimaryName) values ('{this.DataGridView4.Rows[index1].Cells[0].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[1].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[2].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[3].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[4].Value.ToString()}','{this.DataGridView4.Rows[index1].Cells[5].Value.ToString()}')";
          }
          else
          {
            this.DataGridView4.Rows[index1].Cells[5].Value = (object) this.DataGridView4.Rows[index1].Cells[5].Value.ToString().Replace("'", "''");
            this.DataGridView4.Rows[index1].Cells[1].Value = (object) this.DataGridView4.Rows[index1].Cells[1].Value.ToString().Replace("'", "''");
            cmdText2 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocGroup set GrpName = '" + this.DataGridView4.Rows[index1].Cells[1].Value.ToString() + "', GrpPrimaryName = '" + this.DataGridView4.Rows[index1].Cells[5].Value.ToString() + "' where SocGroupId ="), this.DataGridView4.Rows[index1].Cells[0].Value), (object) ""));
          }
          OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText2, oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand2.ExecuteNonQuery();
          oleDbConnection.Close();
          checked { ++index1; }
        }
        OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT SocAccount.SocAccId, SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId, SocAccount.AccName, SocAccount.AccName1, SocAccount.AccName2, SocAccount.Op_Bal, SocAccount.Tr_Db, SocAccount.Tr_Cr, SocAccount.Cl_Bal, SocAccount.Pr_Bal, SocAccount.AccAdd, SocAccount.AccPAN, SocAccount.AccTAN, SocAccount.AccSTAX, SocAccount.AccVAT, SocAccount.AccContact, SocAccount.AccEmail FROM SocAccount INNER JOIN SocAccountMain ON SocAccount.SocAccountMainId = SocAccountMain.SocAccountMainId ORDER BY SocAccount.AccCode", selectConnection);
        DataTable dataTable3 = new DataTable("SocTran");
        oleDbDataAdapter3.Fill(dataTable3);
        this.DataGridView6.DataSource = (object) dataTable3;
        this.DataGridView6.ReadOnly = true;
        this.DataGridView6.RowHeadersVisible = false;
        this.DataGridView6.AllowUserToAddRows = false;
        selectConnection.Close();
        OleDbDataAdapter oleDbDataAdapter4 = new OleDbDataAdapter("SELECT SocAccount.SocAccId, SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.AccName1, SocAccount.AccName2, SocAccount.Op_Bal, SocAccount.Tr_Db, SocAccount.Tr_Cr, SocAccount.Cl_Bal, SocAccount.Pr_Bal, SocAccount.AccAdd, SocAccount.AccPAN, SocAccount.AccTAN, SocAccount.AccSTAX, SocAccount.AccVAT, SocAccount.AccContact, SocAccount.AccEmail FROM SocAccount ORDER BY SocAccount.AccCode", oleDbConnection);
        DataTable dataTable4 = new DataTable("SocTran");
        oleDbDataAdapter4.Fill(dataTable4);
        this.DataGridView7.DataSource = (object) dataTable4;
        this.DataGridView7.ReadOnly = true;
        this.DataGridView7.RowHeadersVisible = false;
        this.DataGridView7.AllowUserToAddRows = false;
        selectConnection.Close();
        int num5 = checked (this.DataGridView6.RowCount - 1);
        int index3 = 0;
        while (index3 <= num5)
        {
          int num6 = 0;
          int num7 = checked (this.DataGridView7.RowCount - 1);
          int index4 = 0;
          while (index4 <= num7)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView6.Rows[index3].Cells[2].Value, this.DataGridView7.Rows[index4].Cells[2].Value, false))
              num6 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView6.Rows[index3].Cells[8].Value.ToString().Trim(), this.DataGridView7.Rows[index4].Cells[3].Value.ToString().Trim(), false) != 0 ? 1 : 2;
            checked { ++index4; }
          }
          if (num6 == 2)
          {
            OleDbCommand oleDbCommand3 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocAccountMain set SocSubGroupId = '", this.DataGridView6.Rows[index3].Cells[5].Value), (object) "', SocGroupId = '"), this.DataGridView6.Rows[index3].Cells[6].Value), (object) "', GrpMainId = '"), this.DataGridView6.Rows[index3].Cells[7].Value), (object) "'  where SocAccountMainId ="), (object) Conversion.Val(this.DataGridView6.Rows[index3].Cells[3].Value.ToString())), (object) "")), oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand3.ExecuteNonQuery();
            oleDbConnection.Close();
          }
          if (num6 == 0)
          {
            this.DataGridView6.Rows[index3].Cells[2].Value = (object) this.DataGridView6.Rows[index3].Cells[2].Value.ToString().Replace("'", "''");
            this.DataGridView6.Rows[index3].Cells[8].Value = (object) this.DataGridView6.Rows[index3].Cells[8].Value.ToString().Replace("'", "''");
            this.DataGridView6.Rows[index3].Cells[9].Value = (object) this.DataGridView6.Rows[index3].Cells[9].Value.ToString().Replace("'", "''");
            this.DataGridView6.Rows[index3].Cells[10].Value = (object) this.DataGridView6.Rows[index3].Cells[10].Value.ToString().Replace("'", "''");
            this.DataGridView6.Rows[index3].Cells[16 /*0x10*/].Value = (object) this.DataGridView6.Rows[index3].Cells[16 /*0x10*/].Value.ToString().Replace("'", "''");
            this.DataGridView6.Rows[index3].Cells[17].Value = (object) this.DataGridView6.Rows[index3].Cells[17].Value.ToString().Replace("'", "''");
            this.DataGridView6.Rows[index3].Cells[18].Value = (object) this.DataGridView6.Rows[index3].Cells[18].Value.ToString().Replace("'", "''");
            this.DataGridView6.Rows[index3].Cells[19].Value = (object) this.DataGridView6.Rows[index3].Cells[19].Value.ToString().Replace("'", "''");
            this.DataGridView6.Rows[index3].Cells[20].Value = (object) this.DataGridView6.Rows[index3].Cells[20].Value.ToString().Replace("'", "''");
            this.DataGridView6.Rows[index3].Cells[21].Value = (object) this.DataGridView6.Rows[index3].Cells[21].Value.ToString().Replace("'", "''");
            this.DataGridView6.Rows[index3].Cells[22].Value = (object) this.DataGridView6.Rows[index3].Cells[22].Value.ToString().Replace("'", "''");
            OleDbCommand oleDbCommand4 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocAccountMain (SocAccountType, SocSubGroupId, SocGroupId, GrpMainId) values (1,'", this.DataGridView6.Rows[index3].Cells[5].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[6].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[7].Value), (object) "')")), oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand4.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbCommand oleDbCommand5 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Insert Into SocAccount (AccCode, AccName, AccName1, AccName2, Op_Bal, Tr_Db, Tr_Cr, Cl_Bal, Pr_Bal, AccAdd, AccPAN, AccTAN, AccSTAX, AccVAT, AccContact, AccEmail ) values ('", this.DataGridView6.Rows[index3].Cells[2].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[8].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[9].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[10].Value), (object) "',0,0,0,0,0,'"), this.DataGridView6.Rows[index3].Cells[16 /*0x10*/].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[17].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[18].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[19].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[20].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[21].Value), (object) "','"), this.DataGridView6.Rows[index3].Cells[22].Value), (object) "')")), oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand5.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter("SELECT * FROM SocAccountMain order by SocAccountMainId asc", oleDbConnection);
            DataTable dataTable5 = new DataTable("SocAccountMain");
            oleDbDataAdapter5.Fill(dataTable5);
            this.DataGridView8.DataSource = (object) dataTable5;
            this.lblAccountMainId.Text = Conversions.ToString(this.DataGridView8.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocAccountMainId"].Value))).Max());
            OleDbDataAdapter oleDbDataAdapter6 = new OleDbDataAdapter("SELECT * FROM SocAccount order by SocAccId asc", oleDbConnection);
            DataTable dataTable6 = new DataTable("SocAccount");
            oleDbDataAdapter6.Fill(dataTable6);
            this.DataGridView9.DataSource = (object) dataTable6;
            this.lblAccountId.Text = Conversions.ToString(this.DataGridView9.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocAccId"].Value))).Max());
            OleDbCommand oleDbCommand6 = new OleDbCommand($"update SocAccount set SocAccountMainId = {Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text.Trim()))} where SocAccId ={Conversions.ToString(Conversion.Val(this.lblAccountId.Text.Trim()))}", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand6.ExecuteNonQuery();
            oleDbConnection.Close();
            OleDbCommand oleDbCommand7 = new OleDbCommand($"Insert Into SocDescRep (AccId) values ({Conversions.ToString(Conversion.Val(this.lblAccountMainId.Text.Trim()))})", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand7.ExecuteNonQuery();
            oleDbConnection.Close();
          }
          checked { ++index3; }
        }
        OleDbDataAdapter oleDbDataAdapter7 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocAccountMain.GrpMainId, SocAccount.AccCode, SocAccount.Op_Bal, SocMember.MemCode, SocMember.Op_Prin, SocMember.Op_Int, Sum(SocTran.SocTranPrin) AS SumOfSocTranPrin, Sum(SocTran.SocTranInt) AS SumOfSocTranInt, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount, SocAccount.AccName FROM ((SocAccountMain LEFT JOIN SocTran ON SocAccountMain.SocAccountMainId = SocTran.SocAccountMainId) LEFT JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) LEFT JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId GROUP BY SocAccountMain.SocAccountMainId, SocAccountMain.SocAccountType, SocAccountMain.GrpMainId, SocAccount.AccCode, SocAccount.Op_Bal, SocMember.MemCode, SocMember.Op_Prin, SocMember.Op_Int, SocAccount.AccName", selectConnection);
        DataTable dataTable7 = new DataTable("SocAccountMain");
        oleDbDataAdapter7.Fill(dataTable7);
        this.DataGridView1.DataSource = (object) dataTable7;
        this.DataGridView1.ReadOnly = true;
        this.DataGridView1.RowHeadersVisible = false;
        this.DataGridView1.AllowUserToAddRows = false;
        selectConnection.Close();
        OleDbDataAdapter oleDbDataAdapter8 = new OleDbDataAdapter("SELECT SocTran.SocAccountMainId, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran WHERE(((SocTran.SocTranType) = 'OpBR')) GROUP BY SocTran.SocAccountMainId", selectConnection);
        DataTable dataTable8 = new DataTable("SocTran");
        oleDbDataAdapter8.Fill(dataTable8);
        this.DataGridView2.DataSource = (object) dataTable8;
        this.DataGridView2.ReadOnly = true;
        this.DataGridView2.RowHeadersVisible = false;
        this.DataGridView2.AllowUserToAddRows = false;
        selectConnection.Close();
        OleDbDataAdapter oleDbDataAdapter9 = new OleDbDataAdapter("SELECT RctBif.MemId, SocMember.MemCode, Sum(RctBif.BAmt1) AS SumOfBAmt1, Sum(RctBif.BAmt2) AS SumOfBAmt2, Sum(RctBif.BAmt3) AS SumOfBAmt3, Sum(RctBif.BAmt4) AS SumOfBAmt4, Sum(RctBif.BAmt5) AS SumOfBAmt5, Sum(RctBif.BAmt6) AS SumOfBAmt6, Sum(RctBif.BAmt7) AS SumOfBAmt7, Sum(RctBif.BAmt8) AS SumOfBAmt8, Sum(RctBif.BAmt9) AS SumOfBAmt9, Sum(RctBif.BAmt10) AS SumOfBAmt10, Sum(RctBif.BAmt11) AS SumOfBAmt11, Sum(RctBif.BAmt12) AS SumOfBAmt12, Sum(RctBif.BAmt13) AS SumOfBAmt13, Sum(RctBif.BAmt14) AS SumOfBAmt14, Sum(RctBif.BAmt15) AS SumOfBAmt15, Sum(RctBif.BAmt16) AS SumOfBAmt16, Sum(RctBif.BAmt17) AS SumOfBAmt17, Sum(RctBif.BAmt18) AS SumOfBAmt18, Sum(RctBif.BAmt19) AS SumOfBAmt19, Sum(RctBif.BAmt20) AS SumOfBAmt20, Sum(RctBif.BAmt21) AS SumOfBAmt21, Sum(RctBif.BAmt22) AS SumOfBAmt22, Sum(RctBif.BTotal) AS SumOfBTotal FROM RctBif INNER JOIN (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) ON RctBif.MemId = SocAccountMain.SocAccountMainId GROUP BY RctBif.MemId, SocMember.MemCode ORDER BY RctBif.MemId", selectConnection);
        DataTable dataTable9 = new DataTable("RctBif");
        oleDbDataAdapter9.Fill(dataTable9);
        this.DataGridView3.DataSource = (object) dataTable9;
        this.DataGridView3.ReadOnly = true;
        this.DataGridView3.RowHeadersVisible = false;
        this.DataGridView3.AllowUserToAddRows = false;
        selectConnection.Close();
        this.pb1.Value = 20;
        this.pb1.Value = 40;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbAccountBalance.Text, "Yes", false) == 0)
        {
          int num8 = checked (this.DataGridView1.RowCount - 1);
          int index5 = 0;
          while (index5 <= num8)
          {
            this.DataGridView1.Rows[index5].Cells[11].Value = (object) this.DataGridView1.Rows[index5].Cells[11].Value.ToString().Replace("'", "''");
            OleDbCommand oleDbCommand8 = new OleDbCommand($"update SocAccount set Op_Bal = 0, Pr_Bal = 0  where AccCode = '{this.DataGridView1.Rows[index5].Cells[3].Value.ToString().Trim()}'", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand8.ExecuteNonQuery();
            oleDbConnection.Close();
            checked { ++index5; }
          }
        }
        int num9 = checked (this.DataGridView1.RowCount - 1);
        int index6 = 0;
        while (index6 <= num9)
        {
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[4].Value)))
            this.DataGridView1.Rows[index6].Cells[4].Value = (object) "0";
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[6].Value)))
            this.DataGridView1.Rows[index6].Cells[6].Value = (object) "0";
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[7].Value)))
            this.DataGridView1.Rows[index6].Cells[7].Value = (object) "0";
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[8].Value)))
            this.DataGridView1.Rows[index6].Cells[8].Value = (object) "0";
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[9].Value)))
            this.DataGridView1.Rows[index6].Cells[9].Value = (object) "0";
          if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[10].Value)))
            this.DataGridView1.Rows[index6].Cells[10].Value = (object) "0";
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index6].Cells[1].Value, (object) 1, false))
          {
            double num10 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[4].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[10].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbAccountBalance.Text, "Yes", false) == 0)
            {
              string cmdText3;
              if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index6].Cells[2].Value, (object) 1, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.DataGridView1.Rows[index6].Cells[2].Value, (object) 2, false))))
                cmdText3 = $"update SocAccount set Op_Bal = {Conversions.ToString(num10)}, Pr_Bal = {Conversions.ToString(num10)} where AccCode = '{this.DataGridView1.Rows[index6].Cells[3].Value.ToString().Trim()}' and AccName = '{this.DataGridView1.Rows[index6].Cells[11].Value.ToString().Trim()}'";
              else
                cmdText3 = $"update SocAccount set Pr_Bal = {Conversions.ToString(num10)} where AccCode = '{this.DataGridView1.Rows[index6].Cells[3].Value.ToString().Trim()}' and AccName = '{this.DataGridView1.Rows[index6].Cells[11].Value.ToString().Trim()}'";
              OleDbCommand oleDbCommand9 = new OleDbCommand(cmdText3, oleDbConnection);
              oleDbConnection.Open();
              oleDbCommand9.ExecuteNonQuery();
              oleDbConnection.Close();
            }
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index6].Cells[1].Value, (object) 2, false))
          {
            double num11 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[6].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[8].Value));
            double num12 = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[7].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[9].Value));
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMemberBalance.Text, "Yes", false) == 0)
            {
              OleDbCommand oleDbCommand10 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocMember set Op_Prin = " + Conversions.ToString(num11) + ", Op_Int = " + Conversions.ToString(num12) + ",Cl_Prin = " + Conversions.ToString(num11) + ", Cl_Int = " + Conversions.ToString(num12) + " where SocAccountMainId ="), this.DataGridView1.Rows[index6].Cells[0].Value), (object) "")), oleDbConnection);
              oleDbConnection.Open();
              oleDbCommand10.ExecuteNonQuery();
              oleDbConnection.Close();
            }
          }
          checked { ++index6; }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbMemberBalance.Text, "Yes", false) == 0)
        {
          int num13 = checked (this.DataGridView3.RowCount - 1);
          int index7 = 0;
          while (index7 <= num13)
          {
            OleDbCommand oleDbCommand11 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update RctBif set BAmt1 = '" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[2].Value)), 2)) + "', BAmt2 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[3].Value)), 2)) + "', BAmt3 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[4].Value)), 2)) + "', BAmt4 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[5].Value)), 2)) + "', BAmt5 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[6].Value)), 2)) + "', BAmt6 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[7].Value)), 2)) + "', BAmt7 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[8].Value)), 2)) + "', BAmt8 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[9].Value)), 2)) + "', BAmt9 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[10].Value)), 2)) + "', BAmt10 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[11].Value)), 2)) + "', BAmt11 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[12].Value)), 2)) + "', BAmt12 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[13].Value)), 2)) + "', BAmt13 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[14].Value)), 2)) + "', BAmt14 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[15].Value)), 2)) + "', BAmt15 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[16 /*0x10*/].Value)), 2)) + "', BAmt16 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[17].Value)), 2)) + "', BAmt17 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[18].Value)), 2)) + "', BAmt18 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[19].Value)), 2)) + "', BAmt19 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[20].Value)), 2)) + "', BAmt20 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[21].Value)), 2)) + "', BAmt21 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[22].Value)), 2)) + "', BAmt22 = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[23].Value)), 2)) + "', BTotal = " + "'" + Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index7].Cells[24].Value)), 2)) + "' where MemId = "), this.DataGridView3.Rows[index7].Cells[0].Value), (object) " and Tran_Type = '(Opening)'")), oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand11.ExecuteNonQuery();
            oleDbConnection.Close();
            checked { ++index7; }
          }
        }
        this.pb1.Value = 60;
        int num14 = checked (this.DataGridView2.RowCount - 1);
        int index8 = 0;
        while (index8 <= num14)
        {
          int num15 = checked (this.DataGridView1.RowCount - 1);
          int index9 = 0;
          while (index9 <= num15)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index8].Cells[0].Value, this.DataGridView1.Rows[index9].Cells[0].Value, false))
            {
              OleDbCommand oleDbCommand12 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocAccount set Op_Bal = Op_Bal - " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index8].Cells[1].Value))) + ", Pr_Bal = Pr_Bal - " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index8].Cells[1].Value))) + " where SocAccountMainId ="), this.DataGridView2.Rows[index8].Cells[0].Value), (object) "")), oleDbConnection);
              oleDbConnection.Open();
              oleDbCommand12.ExecuteNonQuery();
              oleDbConnection.Close();
            }
            checked { ++index9; }
          }
          checked { ++index8; }
        }
        this.pb1.Value = 80 /*0x50*/;
        Constant.societyname = Constant.societyname.ToString().Replace("'", "''");
        this.pb1.Value = 95;
      }
      this.Close();
      MyProject.Forms.frmMenu.Close();
    }
    else if (Conversions.ToDouble(MyProject.Forms.SocietyBfDialog.lblResult.Text) == 1.0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.SocietyBfDialog.txtDeletePassword.Text, "MSC", false) != 0)
    {
      int num16 = (int) Interaction.MsgBox((object) "Wrong Password");
    }
  }

  public DataSet CommaConvert()
  {
    DataSet dataSet;
    return dataSet;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void mtxtDateFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDateTo.Focus();
  }

  private void cmbAccountBalance_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnOk.Focus();
  }

  private void cmbMemberBalance_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbAccountBalance.Focus();
  }
}
