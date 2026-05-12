// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMultiReceiptMemberSelect1
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmMultiReceiptMemberSelect1 : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("lblHeading")]
  private Label _lblHeading;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("grpvisible")]
  private GroupBox _grpvisible;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("cmbCashbank")]
  private ComboBox _cmbCashbank;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("lblDateOk")]
  private Label _lblDateOk;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("mtxtRecDate")]
  private MaskedTextBox _mtxtRecDate;

  [DebuggerNonUserCode]
  static frmMultiReceiptMemberSelect1()
  {
  }

  [DebuggerNonUserCode]
  public frmMultiReceiptMemberSelect1()
  {
    this.KeyDown += new KeyEventHandler(this.frmMultiReceiptMemberSelect1_KeyDown);
    this.Load += new EventHandler(this.frmMultiReceiptMemberSelect1_Load);
    frmMultiReceiptMemberSelect1.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMultiReceiptMemberSelect1.__ENCList)
    {
      if (frmMultiReceiptMemberSelect1.__ENCList.Count == frmMultiReceiptMemberSelect1.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMultiReceiptMemberSelect1.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMultiReceiptMemberSelect1.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMultiReceiptMemberSelect1.__ENCList[index1] = frmMultiReceiptMemberSelect1.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMultiReceiptMemberSelect1.__ENCList.RemoveRange(index1, checked (frmMultiReceiptMemberSelect1.__ENCList.Count - index1));
        frmMultiReceiptMemberSelect1.__ENCList.Capacity = frmMultiReceiptMemberSelect1.__ENCList.Count;
      }
      frmMultiReceiptMemberSelect1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMultiReceiptMemberSelect1));
    this.lblHeading = new Label();
    this.btnOk = new Button();
    this.btnExit = new Button();
    this.GroupBox2 = new GroupBox();
    this.Label9 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label10 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.Label1 = new Label();
    this.txtNo = new TextBox();
    this.DataGridView1 = new DataGridView();
    this.grpvisible = new GroupBox();
    this.lblDateOk = new Label();
    this.DataGridView2 = new DataGridView();
    this.lblType = new Label();
    this.GroupBox1 = new GroupBox();
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.cmbCashbank = new ComboBox();
    this.Label2 = new Label();
    this.mtxtDate = new MaskedTextBox();
    this.Label3 = new Label();
    this.Button2 = new Button();
    this.Label4 = new Label();
    this.mtxtRecDate = new MaskedTextBox();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpvisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.SuspendLayout();
    this.lblHeading.AutoSize = true;
    this.lblHeading.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblHeading.ForeColor = Color.Blue;
    Label lblHeading1 = this.lblHeading;
    Point point1 = new Point(26, 19);
    Point point2 = point1;
    lblHeading1.Location = point2;
    this.lblHeading.Name = "lblHeading";
    Label lblHeading2 = this.lblHeading;
    Size size1 = new Size(273, 20);
    Size size2 = size1;
    lblHeading2.Size = size2;
    this.lblHeading.TabIndex = 30;
    this.lblHeading.Text = "Member Range For Multi Receipt";
    Button btnOk1 = this.btnOk;
    point1 = new Point(49, 269);
    Point point3 = point1;
    btnOk1.Location = point3;
    this.btnOk.Name = "btnOk";
    Button btnOk2 = this.btnOk;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnOk2.Size = size3;
    this.btnOk.TabIndex = 12;
    this.btnOk.Text = "O&k";
    this.btnOk.UseVisualStyleBackColor = true;
    Button btnExit1 = this.btnExit;
    point1 = new Point(154, 269);
    Point point4 = point1;
    btnExit1.Location = point4;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnExit2.Size = size4;
    this.btnExit.TabIndex = 13;
    this.btnExit.Text = "Ca&ncel";
    this.btnExit.UseVisualStyleBackColor = true;
    this.GroupBox2.Controls.Add((Control) this.Label9);
    this.GroupBox2.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox2.Controls.Add((Control) this.Label10);
    this.GroupBox2.Controls.Add((Control) this.btnListTo);
    this.GroupBox2.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox2.Controls.Add((Control) this.btnListFrom);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(30, 93);
    Point point5 = point1;
    groupBox2_1.Location = point5;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(269, 52);
    Size size5 = size1;
    groupBox2_2.Size = size5;
    this.GroupBox2.TabIndex = 1;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Member Range";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.Black;
    Label label9_1 = this.Label9;
    point1 = new Point(151, 22);
    Point point6 = point1;
    label9_1.Location = point6;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(20, 13);
    Size size6 = size1;
    label9_2.Size = size6;
    this.Label9.TabIndex = 97;
    this.Label9.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(41, 19);
    Point point7 = point1;
    txtMemCodeFrom1.Location = point7;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(70, 20);
    Size size7 = size1;
    txtMemCodeFrom2.Size = size7;
    this.txtMemCodeFrom.TabIndex = 2;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.Black;
    Label label10_1 = this.Label10;
    point1 = new Point(4, 22);
    Point point8 = point1;
    label10_1.Location = point8;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(30, 13);
    Size size8 = size1;
    label10_2.Size = size8;
    this.Label10.TabIndex = 96 /*0x60*/;
    this.Label10.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(243, 17);
    Point point9 = point1;
    btnListTo1.Location = point9;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size9 = size1;
    btnListTo2.Size = size9;
    this.btnListTo.TabIndex = 5;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(174, 19);
    Point point10 = point1;
    txtMemCodeTo1.Location = point10;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(70, 20);
    Size size10 = size1;
    txtMemCodeTo2.Size = size10;
    this.txtMemCodeTo.TabIndex = 4;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(110, 17);
    Point point11 = point1;
    btnListFrom1.Location = point11;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size11 = size1;
    btnListFrom2.Size = size11;
    this.btnListFrom.TabIndex = 3;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(27, 63 /*0x3F*/);
    Point point12 = point1;
    label1_1.Location = point12;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(103, 13);
    Size size12 = size1;
    label1_2.Size = size12;
    this.Label1.TabIndex = 31 /*0x1F*/;
    this.Label1.Text = "Starting Receipt No.";
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(133, 60);
    Point point13 = point1;
    txtNo1.Location = point13;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(153, 20);
    Size size13 = size1;
    txtNo2.Size = size13;
    this.txtNo.TabIndex = 0;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(15, 22);
    Point point14 = point1;
    dataGridView1_1.Location = point14;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size14 = size1;
    dataGridView1_2.Size = size14;
    this.DataGridView1.TabIndex = 33;
    this.grpvisible.Controls.Add((Control) this.lblDateOk);
    this.grpvisible.Controls.Add((Control) this.DataGridView2);
    this.grpvisible.Controls.Add((Control) this.lblType);
    this.grpvisible.Controls.Add((Control) this.DataGridView1);
    this.grpvisible.Controls.Add((Control) this.GroupBox1);
    GroupBox grpvisible1 = this.grpvisible;
    point1 = new Point(264, 316);
    Point point15 = point1;
    grpvisible1.Location = point15;
    this.grpvisible.Name = "grpvisible";
    GroupBox grpvisible2 = this.grpvisible;
    size1 = new Size(41, 38);
    Size size15 = size1;
    grpvisible2.Size = size15;
    this.grpvisible.TabIndex = 34;
    this.grpvisible.TabStop = false;
    this.grpvisible.Text = "GroupBox1";
    this.lblDateOk.AutoSize = true;
    Label lblDateOk1 = this.lblDateOk;
    point1 = new Point(74, 16 /*0x10*/);
    Point point16 = point1;
    lblDateOk1.Location = point16;
    this.lblDateOk.Name = "lblDateOk";
    Label lblDateOk2 = this.lblDateOk;
    size1 = new Size(21, 13);
    Size size16 = size1;
    lblDateOk2.Size = size16;
    this.lblDateOk.TabIndex = 37;
    this.lblDateOk.Text = "No";
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(30, 22);
    Point point17 = point1;
    dataGridView2_1.Location = point17;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size17 = size1;
    dataGridView2_2.Size = size17;
    this.DataGridView2.TabIndex = 36;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(59, 19);
    Point point18 = point1;
    lblType1.Location = point18;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(45, 13);
    Size size18 = size1;
    lblType2.Size = size18;
    this.lblType.TabIndex = 35;
    this.lblType.Text = "Format1";
    this.GroupBox1.Controls.Add((Control) this.rb4);
    this.GroupBox1.Controls.Add((Control) this.rb3);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(15, 16 /*0x10*/);
    Point point19 = point1;
    groupBox1_1.Location = point19;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(10, 13);
    Size size19 = size1;
    groupBox1_2.Size = size19;
    this.GroupBox1.TabIndex = 8;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Cash / Bank";
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(144 /*0x90*/, 15);
    Point point20 = point1;
    rb4_1.Location = point20;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(67, 17);
    Size size20 = size1;
    rb4_2.Size = size20;
    this.rb4.TabIndex = 10;
    this.rb4.TabStop = true;
    this.rb4.Text = "Selected";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(55, 15);
    Point point21 = point1;
    rb3_1.Location = point21;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(36, 17);
    Size size21 = size1;
    rb3_2.Size = size21;
    this.rb3.TabIndex = 9;
    this.rb3.TabStop = true;
    this.rb3.Text = "All";
    this.rb3.UseVisualStyleBackColor = true;
    this.cmbCashbank.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbCashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashbank.FormattingEnabled = true;
    ComboBox cmbCashbank1 = this.cmbCashbank;
    point1 = new Point(133, 189);
    Point point22 = point1;
    cmbCashbank1.Location = point22;
    this.cmbCashbank.Name = "cmbCashbank";
    ComboBox cmbCashbank2 = this.cmbCashbank;
    size1 = new Size(153, 24);
    Size size22 = size1;
    cmbCashbank2.Size = size22;
    this.cmbCashbank.TabIndex = 7;
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(27, 194);
    Point point23 = point1;
    label2_1.Location = point23;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(96 /*0x60*/, 13);
    Size size23 = size1;
    label2_2.Size = size23;
    this.Label2.TabIndex = 36;
    this.Label2.Text = "default Cash/Bank";
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(133, 230);
    Point point24 = point1;
    mtxtDate1.Location = point24;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size24 = size1;
    mtxtDate2.Size = size24;
    this.mtxtDate.TabIndex = 11;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(28, 235);
    Point point25 = point1;
    label3_1.Location = point25;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(69, 13);
    Size size25 = size1;
    label3_2.Size = size25;
    this.Label3.TabIndex = 38;
    this.Label3.Text = "Last Bill Date";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(227, 270);
    Point point26 = point1;
    button2_1.Location = point26;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size26 = size1;
    button2_2.Size = size26;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(28, 156);
    Point point27 = point1;
    label4_1.Location = point27;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(70, 13);
    Size size27 = size1;
    label4_2.Size = size27;
    this.Label4.TabIndex = 85;
    this.Label4.Text = "Receipt Date";
    this.mtxtRecDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtRecDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtRecDate1 = this.mtxtRecDate;
    point1 = new Point(133, 151);
    Point point28 = point1;
    mtxtRecDate1.Location = point28;
    this.mtxtRecDate.Mask = "00/00/0000";
    this.mtxtRecDate.Name = "mtxtRecDate";
    MaskedTextBox mtxtRecDate2 = this.mtxtRecDate;
    size1 = new Size(77, 22);
    Size size28 = size1;
    mtxtRecDate2.Size = size28;
    this.mtxtRecDate.TabIndex = 6;
    this.mtxtRecDate.ValidatingType = typeof (DateTime);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.mtxtRecDate);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.mtxtDate);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cmbCashbank);
    this.Controls.Add((Control) this.grpvisible);
    this.Controls.Add((Control) this.txtNo);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.lblHeading);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMultiReceiptMemberSelect1);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Multi Receipt Member Select";
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpvisible.ResumeLayout(false);
    this.grpvisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label lblHeading
  {
    [DebuggerNonUserCode] get => this._lblHeading;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblHeading = value;
    }
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

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual TextBox txtMemCodeFrom
  {
    [DebuggerNonUserCode] get => this._txtMemCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeFrom_KeyDown);
      EventHandler eventHandler = new EventHandler(this.txtMemCodeFrom_Validated);
      if (this._txtMemCodeFrom != null)
      {
        this._txtMemCodeFrom.KeyDown -= keyEventHandler;
        this._txtMemCodeFrom.Validated -= eventHandler;
      }
      this._txtMemCodeFrom = value;
      if (this._txtMemCodeFrom == null)
        return;
      this._txtMemCodeFrom.KeyDown += keyEventHandler;
      this._txtMemCodeFrom.Validated += eventHandler;
    }
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual Button btnListTo
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

  internal virtual TextBox txtMemCodeTo
  {
    [DebuggerNonUserCode] get => this._txtMemCodeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeTo_KeyDown);
      EventHandler eventHandler = new EventHandler(this.txtMemCodeTo_Validated);
      if (this._txtMemCodeTo != null)
      {
        this._txtMemCodeTo.KeyDown -= keyEventHandler;
        this._txtMemCodeTo.Validated -= eventHandler;
      }
      this._txtMemCodeTo = value;
      if (this._txtMemCodeTo == null)
        return;
      this._txtMemCodeTo.KeyDown += keyEventHandler;
      this._txtMemCodeTo.Validated += eventHandler;
    }
  }

  internal virtual Button btnListFrom
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox txtNo
  {
    [DebuggerNonUserCode] get => this._txtNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNo_KeyDown);
      if (this._txtNo != null)
        this._txtNo.KeyDown -= keyEventHandler;
      this._txtNo = value;
      if (this._txtNo == null)
        return;
      this._txtNo.KeyDown += keyEventHandler;
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

  internal virtual GroupBox grpvisible
  {
    [DebuggerNonUserCode] get => this._grpvisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpvisible = value;
    }
  }

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual RadioButton rb4
  {
    [DebuggerNonUserCode] get => this._rb4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb4 = value;
  }

  internal virtual ComboBox cmbCashbank
  {
    [DebuggerNonUserCode] get => this._cmbCashbank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbCashbank_KeyDown);
      if (this._cmbCashbank != null)
        this._cmbCashbank.KeyDown -= keyEventHandler;
      this._cmbCashbank = value;
      if (this._cmbCashbank == null)
        return;
      this._cmbCashbank.KeyDown += keyEventHandler;
    }
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb3 = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  internal virtual MaskedTextBox mtxtDate
  {
    [DebuggerNonUserCode] get => this._mtxtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDate_KeyDown);
      EventHandler eventHandler = new EventHandler(this.mtxtDate_Validated);
      if (this._mtxtDate != null)
      {
        this._mtxtDate.KeyDown -= keyEventHandler;
        this._mtxtDate.Validated -= eventHandler;
      }
      this._mtxtDate = value;
      if (this._mtxtDate == null)
        return;
      this._mtxtDate.KeyDown += keyEventHandler;
      this._mtxtDate.Validated += eventHandler;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label lblDateOk
  {
    [DebuggerNonUserCode] get => this._lblDateOk;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateOk = value;
    }
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual MaskedTextBox mtxtRecDate
  {
    [DebuggerNonUserCode] get => this._mtxtRecDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mtxtRecDate_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtRecDate_KeyDown);
      if (this._mtxtRecDate != null)
      {
        this._mtxtRecDate.Validated -= eventHandler;
        this._mtxtRecDate.KeyDown -= keyEventHandler;
      }
      this._mtxtRecDate = value;
      if (this._mtxtRecDate == null)
        return;
      this._mtxtRecDate.Validated += eventHandler;
      this._mtxtRecDate.KeyDown += keyEventHandler;
    }
  }

  private void frmMultiReceiptMemberSelect1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmMultiReceiptMemberSelect1_Load(object sender, EventArgs e)
  {
    this.grpvisible.Visible = false;
    this.rb3.Checked = true;
    this.cmbCashbank.Enabled = true;
    this.GetFillCashCmb();
    this.GetFillGrid();
    this.txtNo.Text = Conversions.ToString(checked (this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max() + 1));
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Format1", false) == 0)
    {
      MyProject.Forms.frmMultiReceiptMaster.lblMemForm.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
      MyProject.Forms.frmMultiReceiptMaster.lblMemTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Format2", false) == 0)
    {
      MyProject.Forms.frmMultiReceiptMaster1.lblMemForm.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
      MyProject.Forms.frmMultiReceiptMaster1.lblMemTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    }
    this.txtMemCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    this.txtMemCodeTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
  }

  public DataSet GetFillCashCmb()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection);
    DataTable dataTable = new DataTable("SocAccountMain");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.cmbCashbank.DataSource = (object) dataTable;
    this.cmbCashbank.DisplayMember = "AccName";
    this.cmbCashbank.ValueMember = "SocAccountMainId";
    selectConnection.Close();
    DataSet fillCashCmb;
    return fillCashCmb;
  }

  public DataSet GetFillGrid()
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='MRct') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    DataTable dataTable = new DataTable("SocTran");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnOk_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtNo.Text))
    {
      int num = (int) Interaction.MsgBox((object) "Numeric Only");
      this.txtNo.Focus();
    }
    else if (!Information.IsDate((object) this.mtxtRecDate.Text) | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtRecDate.Text, "  /  /", false) == 0)
    {
      this.mtxtRecDate.Focus();
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.mtxtDate.Text, "  /  /", false) == 0)
        this.lblDateOk.Text = "No";
      else if (Information.IsDate((object) this.mtxtDate.Text))
      {
        if (!new GeneralValidation().VdateRange(Conversions.ToDate(this.mtxtDate.Text)))
        {
          this.mtxtDate.Focus();
          return;
        }
        this.lblDateOk.Text = "Yes";
      }
      else
        this.lblDateOk.Text = "No";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Format1", false) == 0)
      {
        MyProject.Forms.frmMultiReceiptMaster.lblMemForm.Text = this.txtMemCodeFrom.Text;
        MyProject.Forms.frmMultiReceiptMaster.lblMemTo.Text = this.txtMemCodeTo.Text;
        int num = (int) MyProject.Forms.frmMultiReceiptMaster.ShowDialog();
        this.GetFillGrid();
        MyProject.Forms.frmMultiReceiptMaster = (frmMultiReceiptMaster) null;
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Format2", false) == 0)
      {
        MyProject.Forms.frmMultiReceiptMaster1.lblMemForm.Text = this.txtMemCodeFrom.Text;
        MyProject.Forms.frmMultiReceiptMaster1.lblMemTo.Text = this.txtMemCodeTo.Text;
        int num = (int) MyProject.Forms.frmMultiReceiptMaster1.ShowDialog();
        this.GetFillGrid();
        MyProject.Forms.frmMultiReceiptMaster1 = (frmMultiReceiptMaster1) null;
      }
    }
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = this.txtMemCodeFrom.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
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
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
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
    this.mtxtRecDate.Focus();
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

  private void mtxtDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnOk.Focus();
  }

  private void mtxtDate_Validated(object sender, EventArgs e)
  {
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void mtxtRecDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbCashbank.Focus();
  }

  private void mtxtRecDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtRecDate.Text.ToString()))
      this.mtxtRecDate.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtRecDate.Text)))
      this.mtxtRecDate.Focus();
  }

  private void txtNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCodeFrom.Focus();
  }

  private void cmbCashbank_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDate.Focus();
  }
}
