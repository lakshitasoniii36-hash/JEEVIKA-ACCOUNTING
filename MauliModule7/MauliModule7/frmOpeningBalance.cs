// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmOpeningBalance
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmOpeningBalance : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("grpBalanceType")]
  private GroupBox _grpBalanceType;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("txtOpDebit")]
  private TextBox _txtOpDebit;
  [AccessedThroughProperty("txtOpCredit")]
  private TextBox _txtOpCredit;
  [AccessedThroughProperty("txtOpMemCredit")]
  private TextBox _txtOpMemCredit;
  [AccessedThroughProperty("txtOpMemDebit")]
  private TextBox _txtOpMemDebit;
  [AccessedThroughProperty("txtOpCreditDiff")]
  private TextBox _txtOpCreditDiff;
  [AccessedThroughProperty("txtOpDebitDiff")]
  private TextBox _txtOpDebitDiff;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("grpOpening")]
  private GroupBox _grpOpening;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("grpPrevious")]
  private GroupBox _grpPrevious;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("txtPrCredit")]
  private TextBox _txtPrCredit;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("txtPrDebit")]
  private TextBox _txtPrDebit;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("txtPrDebitDiff")]
  private TextBox _txtPrDebitDiff;
  [AccessedThroughProperty("txtPrCreditDiff")]
  private TextBox _txtPrCreditDiff;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("rb1")]
  private RadioButton _rb1;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("grpShowReport")]
  private GroupBox _grpShowReport;
  [AccessedThroughProperty("grpMember")]
  private GroupBox _grpMember;
  [AccessedThroughProperty("txtMemberInt")]
  private TextBox _txtMemberInt;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtMemberPrin")]
  private TextBox _txtMemberPrin;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtMemBalTotal")]
  private TextBox _txtMemBalTotal;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  [AccessedThroughProperty("btnAlter")]
  private Button _btnAlter;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("grpAccount")]
  private GroupBox _grpAccount;

  [DebuggerNonUserCode]
  static frmOpeningBalance()
  {
  }

  [DebuggerNonUserCode]
  public frmOpeningBalance()
  {
    this.KeyDown += new KeyEventHandler(this.frmOpeningBalance_KeyDown);
    this.Load += new EventHandler(this.frmOpeningBalance_Load);
    frmOpeningBalance.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmOpeningBalance.__ENCList)
    {
      if (frmOpeningBalance.__ENCList.Count == frmOpeningBalance.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmOpeningBalance.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmOpeningBalance.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmOpeningBalance.__ENCList[index1] = frmOpeningBalance.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmOpeningBalance.__ENCList.RemoveRange(index1, checked (frmOpeningBalance.__ENCList.Count - index1));
        frmOpeningBalance.__ENCList.Capacity = frmOpeningBalance.__ENCList.Count;
      }
      frmOpeningBalance.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmOpeningBalance));
    this.grpBalanceType = new GroupBox();
    this.rb3 = new RadioButton();
    this.rb2 = new RadioButton();
    this.rb1 = new RadioButton();
    this.btnSave = new Button();
    this.btnExit = new Button();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.txtOpDebit = new TextBox();
    this.txtOpCredit = new TextBox();
    this.txtOpMemCredit = new TextBox();
    this.txtOpMemDebit = new TextBox();
    this.txtOpCreditDiff = new TextBox();
    this.txtOpDebitDiff = new TextBox();
    this.DataGridView4 = new DataGridView();
    this.grpOpening = new GroupBox();
    this.Label13 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.grpPrevious = new GroupBox();
    this.Label6 = new Label();
    this.txtPrCredit = new TextBox();
    this.Label7 = new Label();
    this.txtPrDebit = new TextBox();
    this.Label8 = new Label();
    this.Label14 = new Label();
    this.txtPrDebitDiff = new TextBox();
    this.txtPrCreditDiff = new TextBox();
    this.grpVisible = new GroupBox();
    this.btnUpdate = new Button();
    this.btnCancel = new Button();
    this.grpShowReport = new GroupBox();
    this.grpMember = new GroupBox();
    this.txtMemBalTotal = new TextBox();
    this.txtMemberInt = new TextBox();
    this.Label2 = new Label();
    this.txtMemberPrin = new TextBox();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.btnAdd = new Button();
    this.btnAlter = new Button();
    this.btnDelete = new Button();
    this.grpAccount = new GroupBox();
    this.grpBalanceType.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.grpOpening.SuspendLayout();
    this.grpPrevious.SuspendLayout();
    this.grpVisible.SuspendLayout();
    this.grpShowReport.SuspendLayout();
    this.grpMember.SuspendLayout();
    this.grpAccount.SuspendLayout();
    this.SuspendLayout();
    this.grpBalanceType.Controls.Add((Control) this.rb3);
    this.grpBalanceType.Controls.Add((Control) this.rb2);
    this.grpBalanceType.Controls.Add((Control) this.rb1);
    GroupBox grpBalanceType1 = this.grpBalanceType;
    Point point1 = new Point(835, 25);
    Point point2 = point1;
    grpBalanceType1.Location = point2;
    this.grpBalanceType.Name = "grpBalanceType";
    GroupBox grpBalanceType2 = this.grpBalanceType;
    Size size1 = new Size(145, 139);
    Size size2 = size1;
    grpBalanceType2.Size = size2;
    this.grpBalanceType.TabIndex = 3;
    this.grpBalanceType.TabStop = false;
    this.grpBalanceType.Text = "Balance Type";
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(17, 97);
    Point point3 = point1;
    rb3_1.Location = point3;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(105, 17);
    Size size3 = size1;
    rb3_2.Size = size3;
    this.rb3.TabIndex = 10;
    this.rb3.TabStop = true;
    this.rb3.Text = "Member Balance";
    this.rb3.UseVisualStyleBackColor = true;
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(17, 61);
    Point point4 = point1;
    rb2_1.Location = point4;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(105, 17);
    Size size4 = size1;
    rb2_2.Size = size4;
    this.rb2.TabIndex = 9;
    this.rb2.TabStop = true;
    this.rb2.Text = "Income && Expen.";
    this.rb2.UseVisualStyleBackColor = true;
    this.rb1.AutoSize = true;
    RadioButton rb1_1 = this.rb1;
    point1 = new Point(17, 28);
    Point point5 = point1;
    rb1_1.Location = point5;
    this.rb1.Name = "rb1";
    RadioButton rb1_2 = this.rb1;
    size1 = new Size(95, 17);
    Size size5 = size1;
    rb1_2.Size = size5;
    this.rb1.TabIndex = 8;
    this.rb1.TabStop = true;
    this.rb1.Text = "Balance Sheet";
    this.rb1.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(24, 19);
    Point point6 = point1;
    btnSave1.Location = point6;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnSave2.Size = size6;
    this.btnSave.TabIndex = 14;
    this.btnSave.Text = "&Ok";
    this.btnSave.UseVisualStyleBackColor = true;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(24, 67);
    Point point7 = point1;
    btnExit1.Location = point7;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnExit2.Size = size7;
    this.btnExit.TabIndex = 15;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(23, 19);
    Point point8 = point1;
    dataGridView1_1.Location = point8;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size8 = size1;
    dataGridView1_2.Size = size8;
    this.DataGridView1.TabIndex = 16 /*0x10*/;
    this.DataGridView1.TabStop = false;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Control;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(1, 1);
    Point point9 = point1;
    dataGridView2_1.Location = point9;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(828, 410);
    Size size9 = size1;
    dataGridView2_2.Size = size9;
    this.DataGridView2.TabIndex = 17;
    this.DataGridView2.TabStop = false;
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(39, 19);
    Point point10 = point1;
    dataGridView3_1.Location = point10;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView3_2.Size = size10;
    this.DataGridView3.TabIndex = 18;
    this.DataGridView3.TabStop = false;
    this.txtOpDebit.Enabled = false;
    TextBox txtOpDebit1 = this.txtOpDebit;
    point1 = new Point(122, 26);
    Point point11 = point1;
    txtOpDebit1.Location = point11;
    this.txtOpDebit.MaxLength = 80 /*0x50*/;
    this.txtOpDebit.Name = "txtOpDebit";
    TextBox txtOpDebit2 = this.txtOpDebit;
    size1 = new Size(69, 20);
    Size size11 = size1;
    txtOpDebit2.Size = size11;
    this.txtOpDebit.TabIndex = 19;
    this.txtOpDebit.TabStop = false;
    this.txtOpDebit.Text = "0.00";
    this.txtOpDebit.TextAlign = HorizontalAlignment.Right;
    this.txtOpCredit.Enabled = false;
    TextBox txtOpCredit1 = this.txtOpCredit;
    point1 = new Point(219, 26);
    Point point12 = point1;
    txtOpCredit1.Location = point12;
    this.txtOpCredit.MaxLength = 80 /*0x50*/;
    this.txtOpCredit.Name = "txtOpCredit";
    TextBox txtOpCredit2 = this.txtOpCredit;
    size1 = new Size(69, 20);
    Size size12 = size1;
    txtOpCredit2.Size = size12;
    this.txtOpCredit.TabIndex = 20;
    this.txtOpCredit.TabStop = false;
    this.txtOpCredit.Text = "0.00";
    this.txtOpCredit.TextAlign = HorizontalAlignment.Right;
    this.txtOpMemCredit.Enabled = false;
    TextBox txtOpMemCredit1 = this.txtOpMemCredit;
    point1 = new Point(219, 52);
    Point point13 = point1;
    txtOpMemCredit1.Location = point13;
    this.txtOpMemCredit.MaxLength = 80 /*0x50*/;
    this.txtOpMemCredit.Name = "txtOpMemCredit";
    TextBox txtOpMemCredit2 = this.txtOpMemCredit;
    size1 = new Size(69, 20);
    Size size13 = size1;
    txtOpMemCredit2.Size = size13;
    this.txtOpMemCredit.TabIndex = 22;
    this.txtOpMemCredit.TabStop = false;
    this.txtOpMemCredit.Text = "0.00";
    this.txtOpMemCredit.TextAlign = HorizontalAlignment.Right;
    this.txtOpMemDebit.Enabled = false;
    TextBox txtOpMemDebit1 = this.txtOpMemDebit;
    point1 = new Point(122, 52);
    Point point14 = point1;
    txtOpMemDebit1.Location = point14;
    this.txtOpMemDebit.MaxLength = 80 /*0x50*/;
    this.txtOpMemDebit.Name = "txtOpMemDebit";
    TextBox txtOpMemDebit2 = this.txtOpMemDebit;
    size1 = new Size(69, 20);
    Size size14 = size1;
    txtOpMemDebit2.Size = size14;
    this.txtOpMemDebit.TabIndex = 21;
    this.txtOpMemDebit.TabStop = false;
    this.txtOpMemDebit.Text = "0.00";
    this.txtOpMemDebit.TextAlign = HorizontalAlignment.Right;
    this.txtOpCreditDiff.Enabled = false;
    TextBox txtOpCreditDiff1 = this.txtOpCreditDiff;
    point1 = new Point(219, 78);
    Point point15 = point1;
    txtOpCreditDiff1.Location = point15;
    this.txtOpCreditDiff.MaxLength = 80 /*0x50*/;
    this.txtOpCreditDiff.Name = "txtOpCreditDiff";
    TextBox txtOpCreditDiff2 = this.txtOpCreditDiff;
    size1 = new Size(69, 20);
    Size size15 = size1;
    txtOpCreditDiff2.Size = size15;
    this.txtOpCreditDiff.TabIndex = 24;
    this.txtOpCreditDiff.TabStop = false;
    this.txtOpCreditDiff.Text = "0.00";
    this.txtOpCreditDiff.TextAlign = HorizontalAlignment.Right;
    this.txtOpDebitDiff.Enabled = false;
    TextBox txtOpDebitDiff1 = this.txtOpDebitDiff;
    point1 = new Point(122, 78);
    Point point16 = point1;
    txtOpDebitDiff1.Location = point16;
    this.txtOpDebitDiff.MaxLength = 80 /*0x50*/;
    this.txtOpDebitDiff.Name = "txtOpDebitDiff";
    TextBox txtOpDebitDiff2 = this.txtOpDebitDiff;
    size1 = new Size(69, 20);
    Size size16 = size1;
    txtOpDebitDiff2.Size = size16;
    this.txtOpDebitDiff.TabIndex = 23;
    this.txtOpDebitDiff.TabStop = false;
    this.txtOpDebitDiff.Text = "0.00";
    this.txtOpDebitDiff.TextAlign = HorizontalAlignment.Right;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Control;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.WindowText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
    this.DataGridView4.ColumnHeadersDefaultCellStyle = gridViewCellStyle4;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(55, 19);
    Point point17 = point1;
    dataGridView4_1.Location = point17;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size17 = size1;
    dataGridView4_2.Size = size17;
    this.DataGridView4.TabIndex = 29;
    this.DataGridView4.TabStop = false;
    this.grpOpening.Controls.Add((Control) this.Label13);
    this.grpOpening.Controls.Add((Control) this.Label9);
    this.grpOpening.Controls.Add((Control) this.txtOpCredit);
    this.grpOpening.Controls.Add((Control) this.Label10);
    this.grpOpening.Controls.Add((Control) this.txtOpDebit);
    this.grpOpening.Controls.Add((Control) this.Label11);
    this.grpOpening.Controls.Add((Control) this.Label12);
    this.grpOpening.Controls.Add((Control) this.txtOpMemDebit);
    this.grpOpening.Controls.Add((Control) this.txtOpMemCredit);
    this.grpOpening.Controls.Add((Control) this.txtOpDebitDiff);
    this.grpOpening.Controls.Add((Control) this.txtOpCreditDiff);
    GroupBox grpOpening1 = this.grpOpening;
    point1 = new Point(381, 427);
    Point point18 = point1;
    grpOpening1.Location = point18;
    this.grpOpening.Name = "grpOpening";
    GroupBox grpOpening2 = this.grpOpening;
    size1 = new Size(310, 113);
    Size size18 = size1;
    grpOpening2.Size = size18;
    this.grpOpening.TabIndex = 30;
    this.grpOpening.TabStop = false;
    this.grpOpening.Text = "Opening Balance";
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(16 /*0x10*/, 55);
    Point point19 = point1;
    label13_1.Location = point19;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(87, 13);
    Size size19 = size1;
    label13_2.Size = size19;
    this.Label13.TabIndex = 37;
    this.Label13.Text = "Member Balance";
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(16 /*0x10*/, 81);
    Point point20 = point1;
    label9_1.Location = point20;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(56, 13);
    Size size20 = size1;
    label9_2.Size = size20;
    this.Label9.TabIndex = 36;
    this.Label9.Text = "Difference";
    this.Label10.AutoSize = true;
    Label label10_1 = this.Label10;
    point1 = new Point(16 /*0x10*/, 32 /*0x20*/);
    Point point21 = point1;
    label10_1.Location = point21;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size21 = size1;
    label10_2.Size = size21;
    this.Label10.TabIndex = 35;
    this.Label10.Text = "Total";
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(238, 0);
    Point point22 = point1;
    label11_1.Location = point22;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(34, 13);
    Size size22 = size1;
    label11_2.Size = size22;
    this.Label11.TabIndex = 34;
    this.Label11.Text = "Credit";
    this.Label12.AutoSize = true;
    Label label12_1 = this.Label12;
    point1 = new Point(159, 0);
    Point point23 = point1;
    label12_1.Location = point23;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(32 /*0x20*/, 13);
    Size size23 = size1;
    label12_2.Size = size23;
    this.Label12.TabIndex = 33;
    this.Label12.Text = "Debit";
    this.grpPrevious.Controls.Add((Control) this.Label6);
    this.grpPrevious.Controls.Add((Control) this.txtPrCredit);
    this.grpPrevious.Controls.Add((Control) this.Label7);
    this.grpPrevious.Controls.Add((Control) this.txtPrDebit);
    this.grpPrevious.Controls.Add((Control) this.Label8);
    this.grpPrevious.Controls.Add((Control) this.Label14);
    this.grpPrevious.Controls.Add((Control) this.txtPrDebitDiff);
    this.grpPrevious.Controls.Add((Control) this.txtPrCreditDiff);
    GroupBox grpPrevious1 = this.grpPrevious;
    point1 = new Point(381, 427);
    Point point24 = point1;
    grpPrevious1.Location = point24;
    this.grpPrevious.Name = "grpPrevious";
    GroupBox grpPrevious2 = this.grpPrevious;
    size1 = new Size(310, 113);
    Size size24 = size1;
    grpPrevious2.Size = size24;
    this.grpPrevious.TabIndex = 38;
    this.grpPrevious.TabStop = false;
    this.grpPrevious.Text = "Previous Balance";
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(16 /*0x10*/, 81);
    Point point25 = point1;
    label6_1.Location = point25;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(56, 13);
    Size size25 = size1;
    label6_2.Size = size25;
    this.Label6.TabIndex = 36;
    this.Label6.Text = "Difference";
    this.txtPrCredit.Enabled = false;
    TextBox txtPrCredit1 = this.txtPrCredit;
    point1 = new Point(219, 26);
    Point point26 = point1;
    txtPrCredit1.Location = point26;
    this.txtPrCredit.MaxLength = 80 /*0x50*/;
    this.txtPrCredit.Name = "txtPrCredit";
    TextBox txtPrCredit2 = this.txtPrCredit;
    size1 = new Size(69, 20);
    Size size26 = size1;
    txtPrCredit2.Size = size26;
    this.txtPrCredit.TabIndex = 20;
    this.txtPrCredit.TabStop = false;
    this.txtPrCredit.Text = "0.00";
    this.txtPrCredit.TextAlign = HorizontalAlignment.Right;
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(16 /*0x10*/, 32 /*0x20*/);
    Point point27 = point1;
    label7_1.Location = point27;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size27 = size1;
    label7_2.Size = size27;
    this.Label7.TabIndex = 35;
    this.Label7.Text = "Total";
    this.txtPrDebit.Enabled = false;
    TextBox txtPrDebit1 = this.txtPrDebit;
    point1 = new Point(122, 26);
    Point point28 = point1;
    txtPrDebit1.Location = point28;
    this.txtPrDebit.MaxLength = 80 /*0x50*/;
    this.txtPrDebit.Name = "txtPrDebit";
    TextBox txtPrDebit2 = this.txtPrDebit;
    size1 = new Size(69, 20);
    Size size28 = size1;
    txtPrDebit2.Size = size28;
    this.txtPrDebit.TabIndex = 19;
    this.txtPrDebit.TabStop = false;
    this.txtPrDebit.Text = "0.00";
    this.txtPrDebit.TextAlign = HorizontalAlignment.Right;
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(238, 0);
    Point point29 = point1;
    label8_1.Location = point29;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(34, 13);
    Size size29 = size1;
    label8_2.Size = size29;
    this.Label8.TabIndex = 34;
    this.Label8.Text = "Credit";
    this.Label14.AutoSize = true;
    Label label14_1 = this.Label14;
    point1 = new Point(159, 0);
    Point point30 = point1;
    label14_1.Location = point30;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(32 /*0x20*/, 13);
    Size size30 = size1;
    label14_2.Size = size30;
    this.Label14.TabIndex = 33;
    this.Label14.Text = "Debit";
    TextBox txtPrDebitDiff1 = this.txtPrDebitDiff;
    point1 = new Point(122, 78);
    Point point31 = point1;
    txtPrDebitDiff1.Location = point31;
    this.txtPrDebitDiff.MaxLength = 80 /*0x50*/;
    this.txtPrDebitDiff.Name = "txtPrDebitDiff";
    TextBox txtPrDebitDiff2 = this.txtPrDebitDiff;
    size1 = new Size(69, 20);
    Size size31 = size1;
    txtPrDebitDiff2.Size = size31;
    this.txtPrDebitDiff.TabIndex = 23;
    this.txtPrDebitDiff.TabStop = false;
    this.txtPrDebitDiff.Text = "0.00";
    this.txtPrDebitDiff.TextAlign = HorizontalAlignment.Right;
    this.txtPrCreditDiff.Enabled = false;
    TextBox txtPrCreditDiff1 = this.txtPrCreditDiff;
    point1 = new Point(219, 78);
    Point point32 = point1;
    txtPrCreditDiff1.Location = point32;
    this.txtPrCreditDiff.MaxLength = 80 /*0x50*/;
    this.txtPrCreditDiff.Name = "txtPrCreditDiff";
    TextBox txtPrCreditDiff2 = this.txtPrCreditDiff;
    size1 = new Size(69, 20);
    Size size32 = size1;
    txtPrCreditDiff2.Size = size32;
    this.txtPrCreditDiff.TabIndex = 24;
    this.txtPrCreditDiff.TabStop = false;
    this.txtPrCreditDiff.Text = "0.00";
    this.txtPrCreditDiff.TextAlign = HorizontalAlignment.Right;
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(12, 417);
    Point point33 = point1;
    grpVisible1.Location = point33;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(18, 10);
    Size size33 = size1;
    grpVisible2.Size = size33;
    this.grpVisible.TabIndex = 39;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(859, 459);
    Point point34 = point1;
    btnUpdate1.Location = point34;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size34 = size1;
    btnUpdate2.Size = size34;
    this.btnUpdate.TabIndex = 40;
    this.btnUpdate.Text = "&Update";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(859, 498);
    Point point35 = point1;
    btnCancel1.Location = point35;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size35 = size1;
    btnCancel2.Size = size35;
    this.btnCancel.TabIndex = 41;
    this.btnCancel.Text = "Cance&l";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.grpShowReport.Controls.Add((Control) this.btnSave);
    this.grpShowReport.Controls.Add((Control) this.btnExit);
    GroupBox grpShowReport1 = this.grpShowReport;
    point1 = new Point(835, 170);
    Point point36 = point1;
    grpShowReport1.Location = point36;
    this.grpShowReport.Name = "grpShowReport";
    GroupBox grpShowReport2 = this.grpShowReport;
    size1 = new Size(145, 115);
    Size size36 = size1;
    grpShowReport2.Size = size36;
    this.grpShowReport.TabIndex = 42;
    this.grpShowReport.TabStop = false;
    this.grpMember.Controls.Add((Control) this.txtMemBalTotal);
    this.grpMember.Controls.Add((Control) this.txtMemberInt);
    this.grpMember.Controls.Add((Control) this.Label2);
    this.grpMember.Controls.Add((Control) this.txtMemberPrin);
    this.grpMember.Controls.Add((Control) this.Label3);
    this.grpMember.Controls.Add((Control) this.Label4);
    GroupBox grpMember1 = this.grpMember;
    point1 = new Point(381, 427);
    Point point37 = point1;
    grpMember1.Location = point37;
    this.grpMember.Name = "grpMember";
    GroupBox grpMember2 = this.grpMember;
    size1 = new Size(417, 53);
    Size size37 = size1;
    grpMember2.Size = size37;
    this.grpMember.TabIndex = 39;
    this.grpMember.TabStop = false;
    this.grpMember.Text = "Member Balance Balance";
    this.txtMemBalTotal.Enabled = false;
    this.txtMemBalTotal.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtMemBalTotal.ForeColor = Color.Red;
    TextBox txtMemBalTotal1 = this.txtMemBalTotal;
    point1 = new Point(316, 26);
    Point point38 = point1;
    txtMemBalTotal1.Location = point38;
    this.txtMemBalTotal.MaxLength = 80 /*0x50*/;
    this.txtMemBalTotal.Name = "txtMemBalTotal";
    TextBox txtMemBalTotal2 = this.txtMemBalTotal;
    size1 = new Size(69, 20);
    Size size38 = size1;
    txtMemBalTotal2.Size = size38;
    this.txtMemBalTotal.TabIndex = 36;
    this.txtMemBalTotal.TabStop = false;
    this.txtMemBalTotal.Text = "0.00";
    this.txtMemBalTotal.TextAlign = HorizontalAlignment.Right;
    this.txtMemberInt.Enabled = false;
    this.txtMemberInt.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtMemberInt.ForeColor = Color.Red;
    TextBox txtMemberInt1 = this.txtMemberInt;
    point1 = new Point(219, 26);
    Point point39 = point1;
    txtMemberInt1.Location = point39;
    this.txtMemberInt.MaxLength = 80 /*0x50*/;
    this.txtMemberInt.Name = "txtMemberInt";
    TextBox txtMemberInt2 = this.txtMemberInt;
    size1 = new Size(69, 20);
    Size size39 = size1;
    txtMemberInt2.Size = size39;
    this.txtMemberInt.TabIndex = 20;
    this.txtMemberInt.TabStop = false;
    this.txtMemberInt.Text = "0.00";
    this.txtMemberInt.TextAlign = HorizontalAlignment.Right;
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(16 /*0x10*/, 32 /*0x20*/);
    Point point40 = point1;
    label2_1.Location = point40;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size40 = size1;
    label2_2.Size = size40;
    this.Label2.TabIndex = 35;
    this.Label2.Text = "Total";
    this.txtMemberPrin.Enabled = false;
    this.txtMemberPrin.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtMemberPrin.ForeColor = Color.Red;
    TextBox txtMemberPrin1 = this.txtMemberPrin;
    point1 = new Point(122, 26);
    Point point41 = point1;
    txtMemberPrin1.Location = point41;
    this.txtMemberPrin.MaxLength = 80 /*0x50*/;
    this.txtMemberPrin.Name = "txtMemberPrin";
    TextBox txtMemberPrin2 = this.txtMemberPrin;
    size1 = new Size(69, 20);
    Size size41 = size1;
    txtMemberPrin2.Size = size41;
    this.txtMemberPrin.TabIndex = 19;
    this.txtMemberPrin.TabStop = false;
    this.txtMemberPrin.Text = "0.00";
    this.txtMemberPrin.TextAlign = HorizontalAlignment.Right;
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(238, 0);
    Point point42 = point1;
    label3_1.Location = point42;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(42, 13);
    Size size42 = size1;
    label3_2.Size = size42;
    this.Label3.TabIndex = 34;
    this.Label3.Text = "Interest";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(144 /*0x90*/, 0);
    Point point43 = point1;
    label4_1.Location = point43;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(47, 13);
    Size size43 = size1;
    label4_2.Size = size43;
    this.Label4.TabIndex = 33;
    this.Label4.Text = "Principle";
    this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(26, 19);
    Point point44 = point1;
    btnAdd1.Location = point44;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size44 = size1;
    btnAdd2.Size = size44;
    this.btnAdd.TabIndex = 43;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.btnAlter.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAlter1 = this.btnAlter;
    point1 = new Point(26, 58);
    Point point45 = point1;
    btnAlter1.Location = point45;
    this.btnAlter.Name = "btnAlter";
    Button btnAlter2 = this.btnAlter;
    size1 = new Size(99, 33);
    Size size45 = size1;
    btnAlter2.Size = size45;
    this.btnAlter.TabIndex = 44;
    this.btnAlter.Text = "&Alter";
    this.btnAlter.UseVisualStyleBackColor = true;
    this.btnDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(26, 97);
    Point point46 = point1;
    btnDelete1.Location = point46;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size46 = size1;
    btnDelete2.Size = size46;
    this.btnDelete.TabIndex = 45;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    this.grpAccount.Controls.Add((Control) this.btnAdd);
    this.grpAccount.Controls.Add((Control) this.btnDelete);
    this.grpAccount.Controls.Add((Control) this.btnAlter);
    GroupBox grpAccount1 = this.grpAccount;
    point1 = new Point(835, 291);
    Point point47 = point1;
    grpAccount1.Location = point47;
    this.grpAccount.Name = "grpAccount";
    GroupBox grpAccount2 = this.grpAccount;
    size1 = new Size(145, 149);
    Size size47 = size1;
    grpAccount2.Size = size47;
    this.grpAccount.TabIndex = 46;
    this.grpAccount.TabStop = false;
    this.grpAccount.Text = "Account";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpAccount);
    this.Controls.Add((Control) this.grpMember);
    this.Controls.Add((Control) this.grpShowReport);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.grpPrevious);
    this.Controls.Add((Control) this.grpOpening);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.grpBalanceType);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmOpeningBalance);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Opening Balance";
    this.grpBalanceType.ResumeLayout(false);
    this.grpBalanceType.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.grpOpening.ResumeLayout(false);
    this.grpOpening.PerformLayout();
    this.grpPrevious.ResumeLayout(false);
    this.grpPrevious.PerformLayout();
    this.grpVisible.ResumeLayout(false);
    this.grpShowReport.ResumeLayout(false);
    this.grpMember.ResumeLayout(false);
    this.grpMember.PerformLayout();
    this.grpAccount.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual GroupBox grpBalanceType
  {
    [DebuggerNonUserCode] get => this._grpBalanceType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpBalanceType = value;
    }
  }

  internal virtual Button btnSave
  {
    [DebuggerNonUserCode] get => this._btnSave;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      if (this._btnSave != null)
        this._btnSave.Click -= eventHandler;
      this._btnSave = value;
      if (this._btnSave == null)
        return;
      this._btnSave.Click += eventHandler;
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellValidatingEventHandler validatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView2_CellValidating);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView2_CellEndEdit);
      if (this._DataGridView2 != null)
      {
        this._DataGridView2.CellValidating -= validatingEventHandler;
        this._DataGridView2.CellEndEdit -= cellEventHandler;
      }
      this._DataGridView2 = value;
      if (this._DataGridView2 == null)
        return;
      this._DataGridView2.CellValidating += validatingEventHandler;
      this._DataGridView2.CellEndEdit += cellEventHandler;
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

  internal virtual TextBox txtOpDebit
  {
    [DebuggerNonUserCode] get => this._txtOpDebit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtOpDebit = value;
    }
  }

  internal virtual TextBox txtOpCredit
  {
    [DebuggerNonUserCode] get => this._txtOpCredit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtOpCredit = value;
    }
  }

  internal virtual TextBox txtOpMemCredit
  {
    [DebuggerNonUserCode] get => this._txtOpMemCredit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtOpMemCredit = value;
    }
  }

  internal virtual TextBox txtOpMemDebit
  {
    [DebuggerNonUserCode] get => this._txtOpMemDebit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtOpMemDebit = value;
    }
  }

  internal virtual TextBox txtOpCreditDiff
  {
    [DebuggerNonUserCode] get => this._txtOpCreditDiff;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtOpCreditDiff = value;
    }
  }

  internal virtual TextBox txtOpDebitDiff
  {
    [DebuggerNonUserCode] get => this._txtOpDebitDiff;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtOpDebitDiff = value;
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

  internal virtual GroupBox grpOpening
  {
    [DebuggerNonUserCode] get => this._grpOpening;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpOpening = value;
    }
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual GroupBox grpPrevious
  {
    [DebuggerNonUserCode] get => this._grpPrevious;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpPrevious = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual TextBox txtPrCredit
  {
    [DebuggerNonUserCode] get => this._txtPrCredit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPrCredit = value;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual TextBox txtPrDebit
  {
    [DebuggerNonUserCode] get => this._txtPrDebit;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPrDebit = value;
    }
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual TextBox txtPrDebitDiff
  {
    [DebuggerNonUserCode] get => this._txtPrDebitDiff;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPrDebitDiff = value;
    }
  }

  internal virtual TextBox txtPrCreditDiff
  {
    [DebuggerNonUserCode] get => this._txtPrCreditDiff;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPrCreditDiff = value;
    }
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb3 = value;
  }

  internal virtual RadioButton rb2
  {
    [DebuggerNonUserCode] get => this._rb2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb2 = value;
  }

  internal virtual RadioButton rb1
  {
    [DebuggerNonUserCode] get => this._rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb1 = value;
  }

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual Button btnUpdate
  {
    [DebuggerNonUserCode] get => this._btnUpdate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUpdate_Click);
      if (this._btnUpdate != null)
        this._btnUpdate.Click -= eventHandler;
      this._btnUpdate = value;
      if (this._btnUpdate == null)
        return;
      this._btnUpdate.Click += eventHandler;
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

  internal virtual GroupBox grpShowReport
  {
    [DebuggerNonUserCode] get => this._grpShowReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpShowReport = value;
    }
  }

  internal virtual GroupBox grpMember
  {
    [DebuggerNonUserCode] get => this._grpMember;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpMember = value;
    }
  }

  internal virtual TextBox txtMemberInt
  {
    [DebuggerNonUserCode] get => this._txtMemberInt;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMemberInt = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual TextBox txtMemberPrin
  {
    [DebuggerNonUserCode] get => this._txtMemberPrin;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMemberPrin = value;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox txtMemBalTotal
  {
    [DebuggerNonUserCode] get => this._txtMemBalTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMemBalTotal = value;
    }
  }

  internal virtual Button btnAdd
  {
    [DebuggerNonUserCode] get => this._btnAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAdd_Click);
      if (this._btnAdd != null)
        this._btnAdd.Click -= eventHandler;
      this._btnAdd = value;
      if (this._btnAdd == null)
        return;
      this._btnAdd.Click += eventHandler;
    }
  }

  internal virtual Button btnAlter
  {
    [DebuggerNonUserCode] get => this._btnAlter;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAlter_Click);
      if (this._btnAlter != null)
        this._btnAlter.Click -= eventHandler;
      this._btnAlter = value;
      if (this._btnAlter == null)
        return;
      this._btnAlter.Click += eventHandler;
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

  internal virtual GroupBox grpAccount
  {
    [DebuggerNonUserCode] get => this._grpAccount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpAccount = value;
    }
  }

  private void frmOpeningBalance_KeyDown(object sender, KeyEventArgs e)
  {
  }

  private void frmOpeningBalance_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.rb1.Checked = true;
    if (this.rb1.Checked)
    {
      this.grpOpening.Visible = true;
      this.grpPrevious.Visible = false;
      this.grpMember.Visible = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "Y", false) == 0)
      this.rb3.Visible = false;
    else
      this.rb3.Visible = true;
    this.btnExit.Enabled = true;
    this.btnSave.Enabled = true;
    this.grpBalanceType.Enabled = true;
    this.btnAdd.Enabled = false;
    this.btnAlter.Enabled = false;
    this.btnDelete.Enabled = false;
    this.btnUpdate.Enabled = false;
    this.btnCancel.Enabled = false;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    this.GetFillGrid();
    this.GetTotal();
    if (this.rb1.Checked)
    {
      this.grpOpening.Visible = true;
      this.grpPrevious.Visible = false;
      this.grpMember.Visible = false;
    }
    if (this.rb2.Checked)
    {
      this.grpOpening.Visible = false;
      this.grpPrevious.Visible = true;
      this.grpMember.Visible = false;
    }
    if (this.rb3.Checked)
    {
      this.grpOpening.Visible = false;
      this.grpPrevious.Visible = false;
      this.grpMember.Visible = true;
    }
    this.btnExit.Enabled = false;
    this.btnSave.Enabled = false;
    this.grpBalanceType.Enabled = false;
    if (this.rb1.Checked | this.rb2.Checked)
    {
      this.btnAdd.Enabled = true;
      this.btnAlter.Enabled = true;
      this.btnDelete.Enabled = true;
    }
    this.btnUpdate.Enabled = true;
    this.btnCancel.Enabled = true;
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    if (this.rb1.Checked)
      oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocAccountMain.GrpMainId, SocMainGroup.MainGroupName, SocAccountMain.SocGroupId, SocGroup.GrpName, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal, SocAccount.Pr_Bal, SocAccount.Cl_Bal FROM ((SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocGroup ON SocAccountMain.SocGroupId = SocGroup.SocGroupId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId WHERE (((SocAccountMain.GrpMainId)=1 Or (SocAccountMain.GrpMainId)=2)) ORDER BY SocAccountMain.GrpMainId, SocGroup.GrpName, SocAccount.AccCode", selectConnection);
    if (this.rb2.Checked)
      oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocAccountMain.SocAccountMainId, SocAccountMain.GrpMainId, SocMainGroup.MainGroupName, SocAccountMain.SocGroupId, SocGroup.GrpName, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal, SocAccount.Pr_Bal, SocAccount.Cl_Bal FROM ((SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocGroup ON SocAccountMain.SocGroupId = SocGroup.SocGroupId) INNER JOIN SocMainGroup ON SocAccountMain.GrpMainId = SocMainGroup.GrpMainId WHERE (((SocAccountMain.GrpMainId)=3 Or (SocAccountMain.GrpMainId)=4)) ORDER BY SocAccountMain.GrpMainId, SocGroup.GrpName, SocAccount.AccCode", selectConnection);
    if (this.rb3.Checked)
      oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocMember.SocMemId, SocMember.MemCode, SocMember.MemName, SocMember.Op_Prin, SocMember.Op_Int, SocMember.Op_Prin+SocMember.Op_Int AS Expr1, SocMember.Cl_Prin, SocMember.Cl_Int FROM SocMember ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocAccountMain");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT Sum(SocMember.Op_Prin+SocMember.Op_Int) AS SumOfOp_Prin FROM SocMember WHERE (((SocMember.Op_Prin+SocMember.Op_Int)>=0))", selectConnection);
    DataTable dataTable2 = new DataTable("SocMember");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    this.txtOpMemDebit.Text = Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[0].Value)) ? "0.00" : Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[0].Cells[0].Value)));
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT Sum(SocMember.Op_Prin+SocMember.Op_Int) AS SumOfOp_Prin FROM SocMember WHERE (((SocMember.Op_Prin+SocMember.Op_Int)<0))", selectConnection);
    DataTable dataTable3 = new DataTable("SocMember");
    oleDbDataAdapter3.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    selectConnection.Close();
    this.txtOpMemCredit.Text = Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[0].Value)) ? "0.00" : Conversions.ToString(-Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView4.Rows[0].Cells[0].Value)));
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 15;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.Columns[5].HeaderText = "Code";
    this.DataGridView2.Columns[6].HeaderText = "Name";
    if (this.rb1.Checked | this.rb2.Checked)
    {
      this.DataGridView2.Columns[10].HeaderText = "Op.Debit";
      this.DataGridView2.Columns[11].HeaderText = "Op.Credit";
      this.DataGridView2.Columns[12].HeaderText = "Prev.Debit";
      this.DataGridView2.Columns[13].HeaderText = "Prev.Credit";
    }
    if (this.rb3.Checked)
    {
      this.DataGridView2.Columns[10].HeaderText = "Op.Prin.";
      this.DataGridView2.Columns[11].HeaderText = "Op.Int.";
      this.DataGridView2.Columns[12].HeaderText = "Total";
    }
    this.DataGridView2.Columns[10].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[11].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[12].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[13].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[10].ValueType = typeof (double);
    this.DataGridView2.Columns[11].ValueType = typeof (double);
    this.DataGridView2.Columns[12].ValueType = typeof (double);
    this.DataGridView2.Columns[13].ValueType = typeof (double);
    this.DataGridView2.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[0].Visible = false;
    this.DataGridView2.Columns[1].Visible = false;
    this.DataGridView2.Columns[2].Visible = false;
    this.DataGridView2.Columns[3].Visible = false;
    this.DataGridView2.Columns[4].Visible = false;
    this.DataGridView2.Columns[7].Visible = false;
    this.DataGridView2.Columns[8].Visible = false;
    this.DataGridView2.Columns[9].Visible = false;
    this.DataGridView2.Columns[14].Visible = false;
    this.DataGridView2.Columns[5].ReadOnly = true;
    this.DataGridView2.Columns[6].ReadOnly = true;
    if (this.rb1.Checked)
    {
      this.DataGridView2.Columns[12].ReadOnly = false;
      this.DataGridView2.Columns[10].Visible = true;
      this.DataGridView2.Columns[11].Visible = true;
      this.DataGridView2.Columns[12].Visible = false;
      this.DataGridView2.Columns[13].Visible = false;
    }
    if (this.rb2.Checked)
    {
      this.DataGridView2.Columns[12].ReadOnly = false;
      this.DataGridView2.Columns[10].Visible = false;
      this.DataGridView2.Columns[11].Visible = false;
      this.DataGridView2.Columns[12].Visible = true;
      this.DataGridView2.Columns[13].Visible = true;
    }
    if (this.rb3.Checked)
    {
      this.DataGridView2.Columns[12].ReadOnly = true;
      this.DataGridView2.Columns[10].Visible = true;
      this.DataGridView2.Columns[11].Visible = true;
      this.DataGridView2.Columns[12].Visible = true;
      this.DataGridView2.Columns[13].Visible = false;
    }
    this.DataGridView2.Columns[5].Width = 50;
    this.DataGridView2.Columns[6].Width = 450;
    if (this.rb3.Checked)
    {
      this.DataGridView2.Columns[10].Width = 100;
      this.DataGridView2.Columns[11].Width = 100;
      this.DataGridView2.Columns[12].Width = 100;
      this.DataGridView2.Columns[13].Width = 100;
    }
    else
    {
      this.DataGridView2.Columns[10].Width = 150;
      this.DataGridView2.Columns[11].Width = 150;
      this.DataGridView2.Columns[12].Width = 150;
      this.DataGridView2.Columns[13].Width = 150;
    }
    int Right = 0;
    if (this.rb1.Checked | this.rb2.Checked)
    {
      if (this.DataGridView1.RowCount >= 0)
      {
        Right = Conversions.ToInteger(this.DataGridView1.Rows[0].Cells[3].Value);
        this.DataGridView2.Rows.Add();
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[14].Value = (object) "O";
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[0].Cells[3].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[6].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) " ( ", this.DataGridView1.Rows[0].Cells[2].Value), (object) " ) "), this.DataGridView1.Rows[0].Cells[4].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 10f, FontStyle.Bold);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].ReadOnly = true;
      }
      int num = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.DataGridView1.Rows[index].Cells[3].Value, (object) Right, false) && index != 0)
        {
          this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[14].Value = (object) "C";
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[checked (index - 1)].Cells[3].Value);
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[6].Value = (object) "Group Total";
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].ReadOnly = true;
          this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[14].Value = (object) "O";
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[3].Value);
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[6].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) " ( ", this.DataGridView1.Rows[index].Cells[2].Value), (object) " ) "), this.DataGridView1.Rows[index].Cells[4].Value);
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].DefaultCellStyle.BackColor = Color.Yellow;
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Red;
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 10f, FontStyle.Bold);
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].ReadOnly = true;
        }
        this.DataGridView2.Rows.Add();
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[14].Value = (object) "T";
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[0].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[1].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[2].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[3].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[4].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[5].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[6].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[7].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[8].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[9].Value);
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[7].Value)) >= 0.0)
        {
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[7].Value);
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[11].Value = (object) 0;
        }
        else
        {
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[10].Value = (object) 0;
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[11].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index].Cells[7].Value);
        }
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[8].Value)) >= 0.0)
        {
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[8].Value);
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[13].Value = (object) 0;
        }
        else
        {
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[13].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index].Cells[8].Value);
          this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[12].Value = (object) 0;
        }
        Right = Conversions.ToInteger(this.DataGridView1.Rows[index].Cells[3].Value);
        checked { ++index; }
      }
      this.DataGridView2.Rows.Add();
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[14].Value = (object) "C";
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[3].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[6].Value = (object) "Group Total";
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].ReadOnly = true;
    }
    if (this.rb3.Checked)
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView2.Rows.Add();
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[14].Value = (object) "T";
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[0].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[1].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[2].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[3].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[4].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[6].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[7].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[3].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[4].Value);
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[5].Value);
        checked { ++index; }
      }
    }
    DataSet fillGrid;
    return fillGrid;
  }

  public DataSet GetTotal()
  {
    if (this.rb3.Checked)
    {
      double Expression1 = 0.0;
      double Expression2 = 0.0;
      int num = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        Expression1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value));
        Expression2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value));
        this.DataGridView2.Rows[index].Cells[12].Value = (object) (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)) + Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)));
        checked { ++index; }
      }
      this.txtMemberPrin.Text = Conversions.ToString(Expression1);
      this.txtMemberInt.Text = Conversions.ToString(Expression2);
      this.txtMemBalTotal.Text = Conversions.ToString(Conversion.Val((object) Expression1) + Conversion.Val((object) Expression2));
    }
    if (this.rb1.Checked | this.rb2.Checked)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      double num4 = 0.0;
      double num5 = 0.0;
      double num6 = 0.0;
      double num7 = 0.0;
      double num8 = 0.0;
      int num9 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num9)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index].Cells[14].Value.ToString(), "O", false) == 0)
        {
          num1 = 0.0;
          num2 = 0.0;
          num3 = 0.0;
          num4 = 0.0;
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index].Cells[14].Value.ToString(), "T", false) == 0)
        {
          num1 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value));
          num2 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value));
          num3 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[12].Value));
          num4 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[13].Value));
          num5 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value));
          num6 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value));
          num7 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[12].Value));
          num8 += Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[13].Value));
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index].Cells[14].Value.ToString(), "C", false) == 0)
        {
          this.DataGridView2.Rows[index].Cells[10].Value = (object) num1;
          this.DataGridView2.Rows[index].Cells[11].Value = (object) num2;
          this.DataGridView2.Rows[index].Cells[12].Value = (object) num3;
          this.DataGridView2.Rows[index].Cells[13].Value = (object) num4;
        }
        checked { ++index; }
      }
      this.txtOpDebit.Text = Conversions.ToString(num5);
      this.txtOpCredit.Text = Conversions.ToString(num6);
      this.txtPrDebit.Text = Conversions.ToString(num7);
      this.txtPrCredit.Text = Conversions.ToString(num8);
      double num10 = Conversion.Val(this.txtOpDebit.Text) - Conversion.Val(this.txtOpCredit.Text) + Conversion.Val(this.txtOpMemDebit.Text) - Conversion.Val(this.txtOpMemCredit.Text);
      double num11 = Conversion.Val(this.txtPrDebit.Text) - Conversion.Val(this.txtPrCredit.Text);
      if (num10 >= 0.0)
      {
        this.txtOpDebitDiff.Text = Conversions.ToString(0);
        this.txtOpCreditDiff.Text = Conversions.ToString(num10);
      }
      else
      {
        this.txtOpDebitDiff.Text = Conversions.ToString(-num10);
        this.txtOpCreditDiff.Text = Conversions.ToString(0);
      }
      if (num11 >= 0.0)
      {
        this.txtPrDebitDiff.Text = Conversions.ToString(0);
        this.txtPrCreditDiff.Text = Conversions.ToString(num11);
      }
      else
      {
        this.txtPrDebitDiff.Text = Conversions.ToString(-num11);
        this.txtPrCreditDiff.Text = Conversions.ToString(0);
      }
    }
    DataSet total;
    return total;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    string cmdText = "";
    OleDbCommand oleDbCommand1 = new OleDbCommand();
    int num = checked (this.DataGridView2.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)) != 0.0)
      {
        if (this.rb1.Checked)
          cmdText = $"update SocAccount set Op_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2))}', Cl_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[9].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[7].Value)), 2))}' where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)))}";
        if (this.rb2.Checked)
          cmdText = $"update SocAccount set Pr_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[12].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[13].Value)), 2))}' where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)))}";
        if (this.rb3.Checked)
          cmdText = $"update SocMember set Op_Prin = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)), 2))}', Op_Int = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2))}', Cl_Prin = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[3].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[1].Value)), 2))}', Cl_Int = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[4].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[2].Value)), 2))}' where SocMemId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)))}";
        OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText, connection);
        connection.Open();
        oleDbCommand2.ExecuteNonQuery();
        connection.Close();
      }
      checked { ++index; }
    }
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.rb1.Checked = true;
    if (this.rb1.Checked)
    {
      this.grpOpening.Visible = true;
      this.grpPrevious.Visible = false;
      this.grpMember.Visible = false;
    }
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 15;
    this.DataGridView2.RowCount = 0;
    this.btnExit.Enabled = true;
    this.btnSave.Enabled = true;
    this.grpBalanceType.Enabled = true;
    this.btnAdd.Enabled = false;
    this.btnAlter.Enabled = false;
    this.btnDelete.Enabled = false;
    this.btnUpdate.Enabled = false;
    this.btnCancel.Enabled = false;
  }

  private void DataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
  {
    this.GetTotal();
  }

  private void DataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
  {
    if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[e.RowIndex].Cells[14].Value, (object) "T", false) || !(e.ColumnIndex >= 10 & e.ColumnIndex <= 13))
      return;
    if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.FormattedValue)))
    {
      this.DataGridView2.Rows[e.RowIndex].ErrorText = "only numeric value.";
      this.btnAdd.Enabled = false;
      this.btnAlter.Enabled = false;
      this.btnDelete.Enabled = false;
      this.btnUpdate.Enabled = false;
      this.btnCancel.Enabled = false;
      e.Cancel = true;
    }
    else
    {
      if (this.rb1.Checked | this.rb2.Checked)
      {
        this.btnAdd.Enabled = true;
        this.btnAlter.Enabled = true;
        this.btnDelete.Enabled = true;
      }
      this.btnUpdate.Enabled = true;
      this.btnCancel.Enabled = true;
    }
  }

  private void btnAlter_Click(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedCells.Count != 1)
      return;
    int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
    int num1 = (int) MyProject.Forms.UpdateChangesDialog.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.UpdateChangesDialog.lblResult.Text, "1", false) == 0)
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      string cmdText = "";
      OleDbCommand oleDbCommand1 = new OleDbCommand();
      int num2 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num2)
      {
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)) != 0.0)
        {
          if (this.rb1.Checked)
            cmdText = $"update SocAccount set Op_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2))}', Cl_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[9].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[7].Value)), 2))}' where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)))}";
          if (this.rb2.Checked)
            cmdText = $"update SocAccount set Pr_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[12].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[13].Value)), 2))}' where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)))}";
          if (this.rb3.Checked)
            cmdText = $"update SocMember set Op_Prin = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)), 2))}', Op_Int = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2))}', Cl_Prin = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[3].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[1].Value)), 2))}', Cl_Int = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[4].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[2].Value)), 2))}' where SocMemId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)))}";
          OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText, connection);
          connection.Open();
          oleDbCommand2.ExecuteNonQuery();
          connection.Close();
        }
        checked { ++index; }
      }
    }
    this.DataGridView2.Rows[rowIndex].Cells[columnIndex].Selected = true;
    this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, rowIndex];
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.CurrentRow.Cells[14].Value.ToString().Trim(), "T", false) == 0)
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView2.CurrentRow.Cells[5].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Update ";
      accountDetailDirect.btnSave.Text = "&Update";
      int num3 = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.Refresh();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.GetFillGrid();
      this.GetTotal();
      this.DataGridView2.Rows[rowIndex].Cells[columnIndex].Selected = true;
      this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, rowIndex];
    }
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    int num1 = (int) MyProject.Forms.UpdateChangesDialog.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.UpdateChangesDialog.lblResult.Text, "1", false) == 0)
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      string cmdText = "";
      OleDbCommand oleDbCommand1 = new OleDbCommand();
      int num2 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num2)
      {
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)) != 0.0)
        {
          if (this.rb1.Checked)
            cmdText = $"update SocAccount set Op_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2))}', Cl_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[9].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[7].Value)), 2))}' where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)))}";
          if (this.rb2.Checked)
            cmdText = $"update SocAccount set Pr_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[12].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[13].Value)), 2))}' where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)))}";
          if (this.rb3.Checked)
            cmdText = $"update SocMember set Op_Prin = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)), 2))}', Op_Int = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2))}', Cl_Prin = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[3].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[1].Value)), 2))}', Cl_Int = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[4].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[2].Value)), 2))}' where SocMemId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)))}";
          OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText, connection);
          connection.Open();
          oleDbCommand2.ExecuteNonQuery();
          connection.Close();
        }
        checked { ++index; }
      }
    }
    frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
    accountDetailDirect.Text = " New Account Creation ";
    accountDetailDirect.btnSave.Text = "&Save";
    int num3 = (int) accountDetailDirect.ShowDialog();
    MyProject.Forms.frmConstantGrid.Refresh();
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    this.GetFillGrid();
    this.GetTotal();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedCells.Count != 1)
      return;
    int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
    int num1 = (int) MyProject.Forms.UpdateChangesDialog.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.UpdateChangesDialog.lblResult.Text, "1", false) == 0)
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
      string cmdText = "";
      OleDbCommand oleDbCommand1 = new OleDbCommand();
      int num2 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num2)
      {
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)) != 0.0)
        {
          if (this.rb1.Checked)
            cmdText = $"update SocAccount set Op_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2))}', Cl_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[9].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[7].Value)), 2))}' where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)))}";
          if (this.rb2.Checked)
            cmdText = $"update SocAccount set Pr_Bal = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[12].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[13].Value)), 2))}' where SocAccountMainId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)))}";
          if (this.rb3.Checked)
            cmdText = $"update SocMember set Op_Prin = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)), 2))}', Op_Int = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2))}', Cl_Prin = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[3].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[1].Value)), 2))}', Cl_Int = '{Conversions.ToString(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[4].Value)), 2) + Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)), 2) - Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[2].Value)), 2))}' where SocMemId ={Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)))}";
          OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText, connection);
          connection.Open();
          oleDbCommand2.ExecuteNonQuery();
          connection.Close();
        }
        checked { ++index; }
      }
    }
    this.DataGridView2.Rows[rowIndex].Cells[columnIndex].Selected = true;
    this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, rowIndex];
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.CurrentRow.Cells[14].Value.ToString().Trim(), "T", false) == 0)
    {
      frmAccountDetailDirect accountDetailDirect = new frmAccountDetailDirect();
      accountDetailDirect.lblAccountCode.Text = this.DataGridView2.CurrentRow.Cells[5].Value.ToString().Trim();
      accountDetailDirect.Text = " Account Delete ";
      accountDetailDirect.btnSave.Text = "&Delete";
      int num3 = (int) accountDetailDirect.ShowDialog();
      MyProject.Forms.frmConstantGrid.Refresh();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.GetFillGrid();
      this.GetTotal();
    }
  }
}
