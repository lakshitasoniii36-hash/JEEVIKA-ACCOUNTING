// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmPaymentVerify
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
public class frmPaymentVerify : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("lblTrType")]
  private Label _lblTrType;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("DataGridViewTextBoxColumn1")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn1;
  [AccessedThroughProperty("DataGridViewTextBoxColumn2")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn2;
  [AccessedThroughProperty("DataGridViewTextBoxColumn3")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn3;
  [AccessedThroughProperty("DataGridViewTextBoxColumn4")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn4;
  [AccessedThroughProperty("DataGridViewTextBoxColumn5")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn5;
  [AccessedThroughProperty("DataGridViewTextBoxColumn6")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn6;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("grpVouDetails")]
  private GroupBox _grpVouDetails;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("txtChqNo")]
  private TextBox _txtChqNo;
  [AccessedThroughProperty("txtBillNo")]
  private TextBox _txtBillNo;
  [AccessedThroughProperty("txtChqDate")]
  private TextBox _txtChqDate;
  [AccessedThroughProperty("txtPart1")]
  private TextBox _txtPart1;
  [AccessedThroughProperty("txtPart2")]
  private TextBox _txtPart2;
  [AccessedThroughProperty("txtPerson")]
  private TextBox _txtPerson;
  [AccessedThroughProperty("Column15")]
  private DataGridViewTextBoxColumn _Column15;
  [AccessedThroughProperty("Column16")]
  private DataGridViewTextBoxColumn _Column16;
  [AccessedThroughProperty("Column17")]
  private DataGridViewTextBoxColumn _Column17;
  [AccessedThroughProperty("Column18")]
  private DataGridViewTextBoxColumn _Column18;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("cmbSearch")]
  private ComboBox _cmbSearch;
  [AccessedThroughProperty("txtSearch")]
  private TextBox _txtSearch;
  [AccessedThroughProperty("DataGridViewTextBoxColumn7")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn7;
  [AccessedThroughProperty("DataGridViewTextBoxColumn8")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn8;
  [AccessedThroughProperty("DataGridViewTextBoxColumn9")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn9;
  [AccessedThroughProperty("DataGridViewTextBoxColumn10")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn10;
  [AccessedThroughProperty("DataGridViewTextBoxColumn11")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn11;
  [AccessedThroughProperty("DataGridViewTextBoxColumn12")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn12;
  [AccessedThroughProperty("DataGridViewTextBoxColumn13")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn13;
  [AccessedThroughProperty("DataGridViewTextBoxColumn14")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn14;
  [AccessedThroughProperty("DataGridViewTextBoxColumn15")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn15;
  [AccessedThroughProperty("DataGridViewTextBoxColumn16")]
  private DataGridViewTextBoxColumn _DataGridViewTextBoxColumn16;
  [AccessedThroughProperty("Column1")]
  private DataGridViewTextBoxColumn _Column1;
  [AccessedThroughProperty("Column2")]
  private DataGridViewTextBoxColumn _Column2;
  [AccessedThroughProperty("Column3")]
  private DataGridViewTextBoxColumn _Column3;
  [AccessedThroughProperty("Column4")]
  private DataGridViewTextBoxColumn _Column4;
  [AccessedThroughProperty("Column5")]
  private DataGridViewCheckBoxColumn _Column5;
  [AccessedThroughProperty("Column6")]
  private DataGridViewCheckBoxColumn _Column6;
  [AccessedThroughProperty("Column7")]
  private DataGridViewCheckBoxColumn _Column7;
  [AccessedThroughProperty("Column8")]
  private DataGridViewCheckBoxColumn _Column8;
  [AccessedThroughProperty("Column9")]
  private DataGridViewCheckBoxColumn _Column9;
  [AccessedThroughProperty("Column10")]
  private DataGridViewCheckBoxColumn _Column10;
  [AccessedThroughProperty("Column11")]
  private DataGridViewCheckBoxColumn _Column11;
  [AccessedThroughProperty("Column12")]
  private DataGridViewCheckBoxColumn _Column12;
  [AccessedThroughProperty("Column13")]
  private DataGridViewTextBoxColumn _Column13;
  [AccessedThroughProperty("Column14")]
  private DataGridViewTextBoxColumn _Column14;
  [AccessedThroughProperty("Column19")]
  private DataGridViewTextBoxColumn _Column19;
  [AccessedThroughProperty("Column20")]
  private DataGridViewTextBoxColumn _Column20;
  [AccessedThroughProperty("Column21")]
  private DataGridViewTextBoxColumn _Column21;
  [AccessedThroughProperty("Column22")]
  private DataGridViewTextBoxColumn _Column22;
  [AccessedThroughProperty("Column23")]
  private DataGridViewTextBoxColumn _Column23;
  [AccessedThroughProperty("Column24")]
  private DataGridViewTextBoxColumn _Column24;
  [AccessedThroughProperty("lblAllCheckUncheck")]
  private Label _lblAllCheckUncheck;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static frmPaymentVerify()
  {
  }

  [DebuggerNonUserCode]
  public frmPaymentVerify()
  {
    this.KeyDown += new KeyEventHandler(this.frmPaymentVerify_KeyDown);
    this.Load += new EventHandler(this.frmPaymentVerify_Load);
    frmPaymentVerify.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmPaymentVerify.__ENCList)
    {
      if (frmPaymentVerify.__ENCList.Count == frmPaymentVerify.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmPaymentVerify.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmPaymentVerify.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmPaymentVerify.__ENCList[index1] = frmPaymentVerify.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmPaymentVerify.__ENCList.RemoveRange(index1, checked (frmPaymentVerify.__ENCList.Count - index1));
        frmPaymentVerify.__ENCList.Capacity = frmPaymentVerify.__ENCList.Count;
      }
      frmPaymentVerify.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPaymentVerify));
    this.btnExit = new Button();
    this.btnUpdate = new Button();
    this.DataGridView1 = new DataGridView();
    this.GroupBox2 = new GroupBox();
    this.DataGridView3 = new DataGridView();
    this.lblTrType = new Label();
    this.DataGridView2 = new DataGridView();
    this.Column1 = new DataGridViewTextBoxColumn();
    this.Column2 = new DataGridViewTextBoxColumn();
    this.Column3 = new DataGridViewTextBoxColumn();
    this.Column4 = new DataGridViewTextBoxColumn();
    this.Column5 = new DataGridViewCheckBoxColumn();
    this.Column6 = new DataGridViewCheckBoxColumn();
    this.Column7 = new DataGridViewCheckBoxColumn();
    this.Column8 = new DataGridViewCheckBoxColumn();
    this.Column9 = new DataGridViewCheckBoxColumn();
    this.Column10 = new DataGridViewCheckBoxColumn();
    this.Column11 = new DataGridViewCheckBoxColumn();
    this.Column12 = new DataGridViewCheckBoxColumn();
    this.Column13 = new DataGridViewTextBoxColumn();
    this.Column14 = new DataGridViewTextBoxColumn();
    this.Column19 = new DataGridViewTextBoxColumn();
    this.Column20 = new DataGridViewTextBoxColumn();
    this.Column21 = new DataGridViewTextBoxColumn();
    this.Column22 = new DataGridViewTextBoxColumn();
    this.Column23 = new DataGridViewTextBoxColumn();
    this.Column24 = new DataGridViewTextBoxColumn();
    this.Button2 = new Button();
    this.DataGridView4 = new DataGridView();
    this.Column15 = new DataGridViewTextBoxColumn();
    this.Column16 = new DataGridViewTextBoxColumn();
    this.Column17 = new DataGridViewTextBoxColumn();
    this.Column18 = new DataGridViewTextBoxColumn();
    this.grpVouDetails = new GroupBox();
    this.txtPerson = new TextBox();
    this.txtPart2 = new TextBox();
    this.txtPart1 = new TextBox();
    this.txtChqNo = new TextBox();
    this.txtBillNo = new TextBox();
    this.txtChqDate = new TextBox();
    this.Label11 = new Label();
    this.Label10 = new Label();
    this.Label9 = new Label();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.GroupBox1 = new GroupBox();
    this.cmbSearch = new ComboBox();
    this.txtSearch = new TextBox();
    this.DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
    this.DataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
    this.lblAllCheckUncheck = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.grpVouDetails.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.SuspendLayout();
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(463, 526);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 10;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(346, 526);
    Point point3 = point1;
    btnUpdate1.Location = point3;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnUpdate2.Size = size3;
    this.btnUpdate.TabIndex = 2;
    this.btnUpdate.Text = "&Update";
    this.btnUpdate.UseVisualStyleBackColor = true;
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
    point1 = new Point(38, 16 /*0x10*/);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(13, 17);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 13;
    this.DataGridView1.TabStop = false;
    this.GroupBox2.Controls.Add((Control) this.lblAllCheckUncheck);
    this.GroupBox2.Controls.Add((Control) this.DataGridView3);
    this.GroupBox2.Controls.Add((Control) this.lblTrType);
    this.GroupBox2.Controls.Add((Control) this.DataGridView1);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(735, 526);
    Point point5 = point1;
    groupBox2_1.Location = point5;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(245, 38);
    Size size5 = size1;
    groupBox2_2.Size = size5;
    this.GroupBox2.TabIndex = 23;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "    Alter Voucher ";
    this.GroupBox2.Visible = false;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Control;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(57, 18);
    Point point6 = point1;
    dataGridView3_1.Location = point6;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(23, 14);
    Size size6 = size1;
    dataGridView3_2.Size = size6;
    this.DataGridView3.TabIndex = 30;
    this.DataGridView3.TabStop = false;
    this.lblTrType.AutoSize = true;
    Label lblTrType1 = this.lblTrType;
    point1 = new Point(6, 16 /*0x10*/);
    Point point7 = point1;
    lblTrType1.Location = point7;
    this.lblTrType.Name = "lblTrType";
    Label lblTrType2 = this.lblTrType;
    size1 = new Size(30, 13);
    Size size7 = size1;
    lblTrType2.Size = size7;
    this.lblTrType.TabIndex = 29;
    this.lblTrType.Text = "Pymt";
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DataGridView2.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column3, (DataGridViewColumn) this.Column4, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column7, (DataGridViewColumn) this.Column8, (DataGridViewColumn) this.Column9, (DataGridViewColumn) this.Column10, (DataGridViewColumn) this.Column11, (DataGridViewColumn) this.Column12, (DataGridViewColumn) this.Column13, (DataGridViewColumn) this.Column14, (DataGridViewColumn) this.Column19, (DataGridViewColumn) this.Column20, (DataGridViewColumn) this.Column21, (DataGridViewColumn) this.Column22, (DataGridViewColumn) this.Column23, (DataGridViewColumn) this.Column24);
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(0, -1);
    Point point8 = point1;
    dataGridView2_1.Location = point8;
    this.DataGridView2.MultiSelect = false;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(873, 316);
    Size size8 = size1;
    dataGridView2_2.Size = size8;
    this.DataGridView2.TabIndex = 11;
    this.Column1.HeaderText = "Type";
    this.Column1.Name = "Column1";
    this.Column1.Width = 70;
    this.Column2.HeaderText = "No";
    this.Column2.Name = "Column2";
    this.Column2.Width = 80 /*0x50*/;
    this.Column3.HeaderText = "Date";
    this.Column3.Name = "Column3";
    this.Column3.Width = 80 /*0x50*/;
    this.Column4.HeaderText = "Amount";
    this.Column4.Name = "Column4";
    this.Column5.HeaderText = "Check";
    this.Column5.Name = "Column5";
    this.Column5.Width = 50;
    this.Column6.HeaderText = "No Committee sign";
    this.Column6.Name = "Column6";
    this.Column6.Resizable = DataGridViewTriState.True;
    this.Column6.SortMode = DataGridViewColumnSortMode.Automatic;
    this.Column6.Width = 50;
    this.Column7.HeaderText = "No Receiver Sign";
    this.Column7.Name = "Column7";
    this.Column7.Resizable = DataGridViewTriState.True;
    this.Column7.SortMode = DataGridViewColumnSortMode.Automatic;
    this.Column7.Width = 50;
    this.Column8.HeaderText = "No Supporting";
    this.Column8.Name = "Column8";
    this.Column8.Resizable = DataGridViewTriState.True;
    this.Column8.SortMode = DataGridViewColumnSortMode.Automatic;
    this.Column8.Width = 50;
    this.Column9.HeaderText = "No Meeting Approve";
    this.Column9.Name = "Column9";
    this.Column9.Resizable = DataGridViewTriState.True;
    this.Column9.SortMode = DataGridViewColumnSortMode.Automatic;
    this.Column9.Width = 50;
    this.Column10.HeaderText = "No TDS Deduct";
    this.Column10.Name = "Column10";
    this.Column10.Width = 50;
    this.Column11.HeaderText = "No Voucher";
    this.Column11.Name = "Column11";
    this.Column11.Width = 50;
    this.Column12.HeaderText = "Excess Cash";
    this.Column12.Name = "Column12";
    this.Column12.Width = 50;
    this.Column13.HeaderText = "Remark";
    this.Column13.Name = "Column13";
    this.Column14.HeaderText = "Remark1";
    this.Column14.Name = "Column14";
    this.Column19.HeaderText = "Chq No.";
    this.Column19.Name = "Column19";
    this.Column20.HeaderText = "Bill No.";
    this.Column20.Name = "Column20";
    this.Column21.HeaderText = "Person Name";
    this.Column21.Name = "Column21";
    this.Column22.HeaderText = "Particular";
    this.Column22.Name = "Column22";
    this.Column23.HeaderText = "Particular1";
    this.Column23.Name = "Column23";
    this.Column24.HeaderText = "Cash / Bank";
    this.Column24.Name = "Column24";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(536, 527);
    Point point9 = point1;
    button2_1.Location = point9;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size9 = size1;
    button2_2.Size = size9;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Control;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.WindowText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
    this.DataGridView4.ColumnHeadersDefaultCellStyle = gridViewCellStyle4;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DataGridView4.Columns.AddRange((DataGridViewColumn) this.Column15, (DataGridViewColumn) this.Column16, (DataGridViewColumn) this.Column17, (DataGridViewColumn) this.Column18);
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(15, 16 /*0x10*/);
    Point point10 = point1;
    dataGridView4_1.Location = point10;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(399, 163);
    Size size10 = size1;
    dataGridView4_2.Size = size10;
    this.DataGridView4.TabIndex = 84;
    this.DataGridView4.TabStop = false;
    this.Column15.HeaderText = "Code";
    this.Column15.Name = "Column15";
    this.Column15.Width = 50;
    this.Column16.HeaderText = "Account Name";
    this.Column16.Name = "Column16";
    this.Column16.Width = 200;
    this.Column17.HeaderText = "Debit";
    this.Column17.Name = "Column17";
    this.Column17.Width = 70;
    this.Column18.HeaderText = "Credit";
    this.Column18.Name = "Column18";
    this.Column18.Width = 70;
    this.grpVouDetails.Controls.Add((Control) this.txtPerson);
    this.grpVouDetails.Controls.Add((Control) this.txtPart2);
    this.grpVouDetails.Controls.Add((Control) this.txtPart1);
    this.grpVouDetails.Controls.Add((Control) this.txtChqNo);
    this.grpVouDetails.Controls.Add((Control) this.txtBillNo);
    this.grpVouDetails.Controls.Add((Control) this.txtChqDate);
    this.grpVouDetails.Controls.Add((Control) this.Label11);
    this.grpVouDetails.Controls.Add((Control) this.Label10);
    this.grpVouDetails.Controls.Add((Control) this.Label9);
    this.grpVouDetails.Controls.Add((Control) this.Label8);
    this.grpVouDetails.Controls.Add((Control) this.Label7);
    this.grpVouDetails.Controls.Add((Control) this.DataGridView4);
    GroupBox grpVouDetails1 = this.grpVouDetails;
    point1 = new Point(12, 324);
    Point point11 = point1;
    grpVouDetails1.Location = point11;
    this.grpVouDetails.Name = "grpVouDetails";
    GroupBox grpVouDetails2 = this.grpVouDetails;
    size1 = new Size(968, 192 /*0xC0*/);
    Size size11 = size1;
    grpVouDetails2.Size = size11;
    this.grpVouDetails.TabIndex = 85;
    this.grpVouDetails.TabStop = false;
    this.grpVouDetails.Text = "Voucher Details";
    this.txtPerson.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPerson1 = this.txtPerson;
    point1 = new Point(493, 148);
    Point point12 = point1;
    txtPerson1.Location = point12;
    this.txtPerson.MaxLength = 80 /*0x50*/;
    this.txtPerson.Multiline = true;
    this.txtPerson.Name = "txtPerson";
    TextBox txtPerson2 = this.txtPerson;
    size1 = new Size(469, 36);
    Size size12 = size1;
    txtPerson2.Size = size12;
    this.txtPerson.TabIndex = 103;
    this.txtPart2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart2_1 = this.txtPart2;
    point1 = new Point(493, 103);
    Point point13 = point1;
    txtPart2_1.Location = point13;
    this.txtPart2.MaxLength = 80 /*0x50*/;
    this.txtPart2.Multiline = true;
    this.txtPart2.Name = "txtPart2";
    TextBox txtPart2_2 = this.txtPart2;
    size1 = new Size(469, 36);
    Size size13 = size1;
    txtPart2_2.Size = size13;
    this.txtPart2.TabIndex = 102;
    this.txtPart1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPart1_1 = this.txtPart1;
    point1 = new Point(493, 64 /*0x40*/);
    Point point14 = point1;
    txtPart1_1.Location = point14;
    this.txtPart1.MaxLength = 80 /*0x50*/;
    this.txtPart1.Multiline = true;
    this.txtPart1.Name = "txtPart1";
    TextBox txtPart1_2 = this.txtPart1;
    size1 = new Size(469, 36);
    Size size14 = size1;
    txtPart1_2.Size = size14;
    this.txtPart1.TabIndex = 101;
    this.txtChqNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChqNo1 = this.txtChqNo;
    point1 = new Point(493, 16 /*0x10*/);
    Point point15 = point1;
    txtChqNo1.Location = point15;
    this.txtChqNo.MaxLength = 25;
    this.txtChqNo.Name = "txtChqNo";
    TextBox txtChqNo2 = this.txtChqNo;
    size1 = new Size(196, 22);
    Size size15 = size1;
    txtChqNo2.Size = size15;
    this.txtChqNo.TabIndex = 98;
    this.txtBillNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtBillNo1 = this.txtBillNo;
    point1 = new Point(493, 39);
    Point point16 = point1;
    txtBillNo1.Location = point16;
    this.txtBillNo.MaxLength = 80 /*0x50*/;
    this.txtBillNo.Name = "txtBillNo";
    TextBox txtBillNo2 = this.txtBillNo;
    size1 = new Size(469, 22);
    Size size16 = size1;
    txtBillNo2.Size = size16;
    this.txtBillNo.TabIndex = 100;
    this.txtChqDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtChqDate1 = this.txtChqDate;
    point1 = new Point(765, 16 /*0x10*/);
    Point point17 = point1;
    txtChqDate1.Location = point17;
    this.txtChqDate.MaxLength = 20;
    this.txtChqDate.Name = "txtChqDate";
    TextBox txtChqDate2 = this.txtChqDate;
    size1 = new Size(197, 22);
    Size size17 = size1;
    txtChqDate2.Size = size17;
    this.txtChqDate.TabIndex = 99;
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(430, 61);
    Point point18 = point1;
    label11_1.Location = point18;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size18 = size1;
    label11_2.Size = size18;
    this.Label11.TabIndex = 97;
    this.Label11.Text = "Particular";
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label10_1 = this.Label10;
    point1 = new Point(430, 154);
    Point point19 = point1;
    label10_1.Location = point19;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(54, 16 /*0x10*/);
    Size size19 = size1;
    label10_2.Size = size19;
    this.Label10.TabIndex = 96 /*0x60*/;
    this.Label10.Text = "Person ";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label9_1 = this.Label9;
    point1 = new Point(430, 39);
    Point point20 = point1;
    label9_1.Location = point20;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(50, 16 /*0x10*/);
    Size size20 = size1;
    label9_2.Size = size20;
    this.Label9.TabIndex = 95;
    this.Label9.Text = "Bill No.";
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(695, 19);
    Point point21 = point1;
    label8_1.Location = point21;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(64 /*0x40*/, 16 /*0x10*/);
    Size size21 = size1;
    label8_2.Size = size21;
    this.Label8.TabIndex = 94;
    this.Label8.Text = "Chq.Date";
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(430, 18);
    Point point22 = point1;
    label7_1.Location = point22;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(56, 16 /*0x10*/);
    Size size22 = size1;
    label7_2.Size = size22;
    this.Label7.TabIndex = 93;
    this.Label7.Text = "Chq.No.";
    this.GroupBox1.Controls.Add((Control) this.cmbSearch);
    this.GroupBox1.Controls.Add((Control) this.txtSearch);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(879, 118);
    Point point23 = point1;
    groupBox1_1.Location = point23;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(110, 90);
    Size size23 = size1;
    groupBox1_2.Size = size23;
    this.GroupBox1.TabIndex = 86;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Search By";
    this.cmbSearch.FormattingEnabled = true;
    this.cmbSearch.Items.AddRange(new object[8]
    {
      (object) "Amount",
      (object) "Cheque No.",
      (object) "Bill No.",
      (object) "Person Name",
      (object) "Particular",
      (object) "Particular1",
      (object) "Cash/Bank",
      (object) "Voucher No."
    });
    ComboBox cmbSearch1 = this.cmbSearch;
    point1 = new Point(4, 19);
    Point point24 = point1;
    cmbSearch1.Location = point24;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(102, 21);
    Size size24 = size1;
    cmbSearch2.Size = size24;
    this.cmbSearch.TabIndex = 5;
    TextBox txtSearch1 = this.txtSearch;
    point1 = new Point(4, 54);
    Point point25 = point1;
    txtSearch1.Location = point25;
    this.txtSearch.Name = "txtSearch";
    TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(102, 20);
    Size size25 = size1;
    txtSearch2.Size = size25;
    this.txtSearch.TabIndex = 6;
    this.DataGridViewTextBoxColumn1.HeaderText = "Type";
    this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
    this.DataGridViewTextBoxColumn1.Width = 70;
    this.DataGridViewTextBoxColumn2.HeaderText = "No";
    this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
    this.DataGridViewTextBoxColumn2.Width = 80 /*0x50*/;
    this.DataGridViewTextBoxColumn3.HeaderText = "Amount";
    this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
    this.DataGridViewTextBoxColumn3.Width = 70;
    this.DataGridViewTextBoxColumn4.HeaderText = "Amount";
    this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
    this.DataGridViewTextBoxColumn5.HeaderText = "Remark";
    this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
    this.DataGridViewTextBoxColumn6.HeaderText = "Remark1";
    this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
    this.DataGridViewTextBoxColumn7.HeaderText = "Code";
    this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
    this.DataGridViewTextBoxColumn7.Width = 50;
    this.DataGridViewTextBoxColumn8.HeaderText = "Account Name";
    this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
    this.DataGridViewTextBoxColumn8.Width = 200;
    this.DataGridViewTextBoxColumn9.HeaderText = "Debit";
    this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
    this.DataGridViewTextBoxColumn9.Width = 70;
    this.DataGridViewTextBoxColumn10.HeaderText = "Credit";
    this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
    this.DataGridViewTextBoxColumn10.Width = 70;
    this.DataGridViewTextBoxColumn11.HeaderText = "Particular1";
    this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
    this.DataGridViewTextBoxColumn12.HeaderText = "Cash / Bank";
    this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
    this.DataGridViewTextBoxColumn13.HeaderText = "Code";
    this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
    this.DataGridViewTextBoxColumn13.Width = 50;
    this.DataGridViewTextBoxColumn14.HeaderText = "Account Name";
    this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
    this.DataGridViewTextBoxColumn14.Width = 200;
    this.DataGridViewTextBoxColumn15.HeaderText = "Debit";
    this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
    this.DataGridViewTextBoxColumn15.Width = 70;
    this.DataGridViewTextBoxColumn16.HeaderText = "Credit";
    this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
    this.DataGridViewTextBoxColumn16.Width = 70;
    this.lblAllCheckUncheck.AutoSize = true;
    Label lblAllCheckUncheck1 = this.lblAllCheckUncheck;
    point1 = new Point(107, 13);
    Point point26 = point1;
    lblAllCheckUncheck1.Location = point26;
    this.lblAllCheckUncheck.Name = "lblAllCheckUncheck";
    Label lblAllCheckUncheck2 = this.lblAllCheckUncheck;
    size1 = new Size(26, 13);
    Size size26 = size1;
    lblAllCheckUncheck2.Size = size26;
    this.lblAllCheckUncheck.TabIndex = 31 /*0x1F*/;
    this.lblAllCheckUncheck.Text = "ALL";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.grpVouDetails);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPaymentVerify);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Payment Voucher List";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.grpVouDetails.ResumeLayout(false);
    this.grpVouDetails.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.ResumeLayout(false);
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DataGridView2_SelectionChanged);
      if (this._DataGridView2 != null)
        this._DataGridView2.SelectionChanged -= eventHandler;
      this._DataGridView2 = value;
      if (this._DataGridView2 == null)
        return;
      this._DataGridView2.SelectionChanged += eventHandler;
    }
  }

  internal virtual Label lblTrType
  {
    [DebuggerNonUserCode] get => this._lblTrType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTrType = value;
    }
  }

  internal virtual Button Button2
  {
    [DebuggerNonUserCode] get => this._Button2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Button2 = value;
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn1 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn2 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn3 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn4 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn5 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn6 = value;
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

  internal virtual GroupBox grpVouDetails
  {
    [DebuggerNonUserCode] get => this._grpVouDetails;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVouDetails = value;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual TextBox txtChqNo
  {
    [DebuggerNonUserCode] get => this._txtChqNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtChqNo = value;
  }

  internal virtual TextBox txtBillNo
  {
    [DebuggerNonUserCode] get => this._txtBillNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtBillNo = value;
    }
  }

  internal virtual TextBox txtChqDate
  {
    [DebuggerNonUserCode] get => this._txtChqDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtChqDate = value;
    }
  }

  internal virtual TextBox txtPart1
  {
    [DebuggerNonUserCode] get => this._txtPart1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtPart1 = value;
  }

  internal virtual TextBox txtPart2
  {
    [DebuggerNonUserCode] get => this._txtPart2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtPart2 = value;
  }

  internal virtual TextBox txtPerson
  {
    [DebuggerNonUserCode] get => this._txtPerson;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPerson = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn Column15
  {
    [DebuggerNonUserCode] get => this._Column15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column15 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column16
  {
    [DebuggerNonUserCode] get => this._Column16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column16 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column17
  {
    [DebuggerNonUserCode] get => this._Column17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column17 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column18
  {
    [DebuggerNonUserCode] get => this._Column18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column18 = value;
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual ComboBox cmbSearch
  {
    [DebuggerNonUserCode] get => this._cmbSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbSearch_SelectedIndexChanged);
      if (this._cmbSearch != null)
        this._cmbSearch.SelectedIndexChanged -= eventHandler;
      this._cmbSearch = value;
      if (this._cmbSearch == null)
        return;
      this._cmbSearch.SelectedIndexChanged += eventHandler;
    }
  }

  internal virtual TextBox txtSearch
  {
    [DebuggerNonUserCode] get => this._txtSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSearch_TextChanged);
      if (this._txtSearch != null)
        this._txtSearch.TextChanged -= eventHandler;
      this._txtSearch = value;
      if (this._txtSearch == null)
        return;
      this._txtSearch.TextChanged += eventHandler;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn7 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn8 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn9 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn10
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn10 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn11
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn11 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn12
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn12 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn13
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn13 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn14
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn14 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn15
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn15 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn16
  {
    [DebuggerNonUserCode] get => this._DataGridViewTextBoxColumn16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridViewTextBoxColumn16 = value;
    }
  }

  internal virtual DataGridViewTextBoxColumn Column1
  {
    [DebuggerNonUserCode] get => this._Column1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column1 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column2
  {
    [DebuggerNonUserCode] get => this._Column2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column2 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column3
  {
    [DebuggerNonUserCode] get => this._Column3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column3 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column4
  {
    [DebuggerNonUserCode] get => this._Column4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column4 = value;
  }

  internal virtual DataGridViewCheckBoxColumn Column5
  {
    [DebuggerNonUserCode] get => this._Column5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column5 = value;
  }

  internal virtual DataGridViewCheckBoxColumn Column6
  {
    [DebuggerNonUserCode] get => this._Column6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column6 = value;
  }

  internal virtual DataGridViewCheckBoxColumn Column7
  {
    [DebuggerNonUserCode] get => this._Column7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column7 = value;
  }

  internal virtual DataGridViewCheckBoxColumn Column8
  {
    [DebuggerNonUserCode] get => this._Column8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column8 = value;
  }

  internal virtual DataGridViewCheckBoxColumn Column9
  {
    [DebuggerNonUserCode] get => this._Column9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column9 = value;
  }

  internal virtual DataGridViewCheckBoxColumn Column10
  {
    [DebuggerNonUserCode] get => this._Column10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column10 = value;
  }

  internal virtual DataGridViewCheckBoxColumn Column11
  {
    [DebuggerNonUserCode] get => this._Column11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column11 = value;
  }

  internal virtual DataGridViewCheckBoxColumn Column12
  {
    [DebuggerNonUserCode] get => this._Column12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column12 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column13
  {
    [DebuggerNonUserCode] get => this._Column13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column13 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column14
  {
    [DebuggerNonUserCode] get => this._Column14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column14 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column19
  {
    [DebuggerNonUserCode] get => this._Column19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column19 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column20
  {
    [DebuggerNonUserCode] get => this._Column20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column20 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column21
  {
    [DebuggerNonUserCode] get => this._Column21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column21 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column22
  {
    [DebuggerNonUserCode] get => this._Column22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column22 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column23
  {
    [DebuggerNonUserCode] get => this._Column23;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column23 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column24
  {
    [DebuggerNonUserCode] get => this._Column24;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column24 = value;
  }

  internal virtual Label lblAllCheckUncheck
  {
    [DebuggerNonUserCode] get => this._lblAllCheckUncheck;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAllCheckUncheck = value;
    }
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    DataTable dataTable = new DataTable("SocTran");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAllCheckUncheck.Text, "ALL", false) == 0)
      oleDbDataAdapter = new OleDbDataAdapter("SELECT SocAuditLog.TranSubType, SocAuditLog.TranNo, SocAuditLog.TranDate, SocAuditLog.TranAmount, SocAuditLog.AllOk, SocAuditLog.NoCommitteeSign, SocAuditLog.NoReceiverSign, SocAuditLog.NoSupporting, SocAuditLog.NoMeetingApprov, SocAuditLog.NoTDS, SocAuditLog.NoVoucher, SocAuditLog.ExcessCash, SocAuditLog.AuditRem, SocAuditLog.AuditRem1, SocTran.ChqNo, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccName, SocTran.MainAccount, SocAuditLog.ID FROM SocAuditLog INNER JOIN SocTran ON (SocAuditLog.TranNo = SocTran.SubTranNo) AND (SocAuditLog.TranSubType = SocTran.SubTranType) WHERE(((SocTran.MainAccount) = 'Y')) ORDER BY SocAuditLog.TranSubType, SocAuditLog.TranNo", selectConnection);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAllCheckUncheck.Text, "CHECK", false) == 0)
      oleDbDataAdapter = new OleDbDataAdapter("SELECT SocAuditLog.TranSubType, SocAuditLog.TranNo, SocAuditLog.TranDate, SocAuditLog.TranAmount, SocAuditLog.AllOk, SocAuditLog.NoCommitteeSign, SocAuditLog.NoReceiverSign, SocAuditLog.NoSupporting, SocAuditLog.NoMeetingApprov, SocAuditLog.NoTDS, SocAuditLog.NoVoucher, SocAuditLog.ExcessCash, SocAuditLog.AuditRem, SocAuditLog.AuditRem1, SocTran.ChqNo, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccName, SocTran.MainAccount, SocAuditLog.ID FROM SocAuditLog INNER JOIN SocTran ON (SocAuditLog.TranNo = SocTran.SubTranNo) AND (SocAuditLog.TranSubType = SocTran.SubTranType) WHERE(((SocTran.MainAccount) = 'Y') AND SocAuditLog.AllOk = True) ORDER BY SocAuditLog.TranSubType, SocAuditLog.TranNo", selectConnection);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAllCheckUncheck.Text, "UNCHECK", false) == 0)
      oleDbDataAdapter = new OleDbDataAdapter("SELECT SocAuditLog.TranSubType, SocAuditLog.TranNo, SocAuditLog.TranDate, SocAuditLog.TranAmount, SocAuditLog.AllOk, SocAuditLog.NoCommitteeSign, SocAuditLog.NoReceiverSign, SocAuditLog.NoSupporting, SocAuditLog.NoMeetingApprov, SocAuditLog.NoTDS, SocAuditLog.NoVoucher, SocAuditLog.ExcessCash, SocAuditLog.AuditRem, SocAuditLog.AuditRem1, SocTran.ChqNo, SocTran.BankName, SocTran.PartyName, SocTran.AccPart, SocTran.AccPart1, SocTran.AccName, SocTran.MainAccount, SocAuditLog.ID FROM SocAuditLog INNER JOIN SocTran ON (SocAuditLog.TranNo = SocTran.SubTranNo) AND (SocAuditLog.TranSubType = SocTran.SubTranType) WHERE(((SocTran.MainAccount) = 'Y') AND SocAuditLog.AllOk = False) ORDER BY SocAuditLog.TranSubType, SocAuditLog.TranNo", selectConnection);
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 22;
    this.DataGridView2.RowCount = 0;
    int num = checked (this.DataGridView1.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView2.Rows.Add();
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
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[10].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[11].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[12].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[13].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[14].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[15].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[15].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[16 /*0x10*/].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[16 /*0x10*/].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[17].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[17].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[18].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[18].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[19].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[19].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[20].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[20].Value);
      this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[21].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[21].Value);
      checked { ++index; }
    }
    this.DataGridView2.ClearSelection();
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void frmPaymentVerify_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmPaymentVerify_Load(object sender, EventArgs e) => this.GetFillGrid();

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  public DataSet GetFillGrid2()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    DataTable dataTable = new DataTable("SocTran");
    new OleDbDataAdapter($"SELECT SocTran.SubTranType, SocTran.SubTranNo, SocTran.SocTranAmount, SocTran.SocTranAmountR, SocAccount.AccCode, SocAccount.AccName, SocTran.MainAccount, SocTran.ChqNo, SocTran.ChqDt, SocTran.BankName, SocTran.AccPart, SocTran.AccPart1, SocTran.PartyName FROM SocTran INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE(((SocTran.SocTranType) = 'Pymt') And ((SocTran.SubTranType) = '{this.DataGridView2.CurrentRow.Cells[0].Value.ToString().Trim()}') And ((SocTran.SubTranNo) = {this.DataGridView2.CurrentRow.Cells[1].Value.ToString().Trim()})) ORDER BY SocTran.MainAccount DESC", selectConnection).Fill(dataTable);
    this.DataGridView3.DataSource = (object) dataTable;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.DataGridView4.ColumnCount = 4;
    this.DataGridView4.RowCount = 0;
    int num = checked (this.DataGridView3.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView4.Rows.Add();
      this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[4].Value);
      this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[5].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView3.Rows[index].Cells[6].Value.ToString().Trim(), "Y", false) == 0)
      {
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[2].Value = (object) "";
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[3].Value);
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
        this.DataGridView4.Rows.Add();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectLess(this.DataGridView3.Rows[index].Cells[2].Value, (object) 0, false))
      {
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[2].Value = (object) "";
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView3.Rows[index].Cells[2].Value);
      }
      else
      {
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index].Cells[2].Value);
        this.DataGridView4.Rows[checked (this.DataGridView4.RowCount - 1)].Cells[3].Value = (object) "";
      }
      checked { ++index; }
    }
    this.txtChqNo.Text = this.DataGridView3.Rows[0].Cells[7].Value.ToString();
    this.txtChqDate.Text = this.DataGridView3.Rows[0].Cells[8].Value.ToString();
    this.txtBillNo.Text = this.DataGridView3.Rows[0].Cells[9].Value.ToString();
    this.txtPart1.Text = this.DataGridView3.Rows[0].Cells[10].Value.ToString();
    this.txtPart2.Text = this.DataGridView3.Rows[0].Cells[11].Value.ToString();
    this.txtPerson.Text = this.DataGridView3.Rows[0].Cells[12].Value.ToString();
    this.DataGridView4.ClearSelection();
    selectConnection.Close();
    DataSet fillGrid2;
    return fillGrid2;
  }

  private void DataGridView2_SelectionChanged(object sender, EventArgs e)
  {
    if (this.DataGridView2.CurrentCell.RowIndex == 0 & this.DataGridView2.CurrentCell.ColumnIndex == 0)
    {
      this.DataGridView4.ReadOnly = true;
      this.DataGridView4.RowHeadersVisible = false;
      this.DataGridView4.AllowUserToAddRows = false;
      this.DataGridView4.ColumnCount = 10;
      this.DataGridView4.RowCount = 0;
    }
    else
      this.GetFillGrid2();
  }

  private void txtSearch_TextChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) == 0)
    {
      int num = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView2.Rows[index].Visible = true;
        checked { ++index; }
      }
    }
    else
    {
      int num1 = checked (this.DataGridView2.RowCount - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        this.DataGridView2.Rows[index1].Visible = false;
        checked { ++index1; }
      }
      int num2 = checked (this.DataGridView2.RowCount - 1);
      int index2 = 0;
      while (index2 <= num2)
      {
        int num3 = Strings.Len(this.DataGridView2.Rows[index2].Cells[this.cmpColumnNo].Value.ToString().Trim());
        int Start = 1;
        while (Start <= num3)
        {
          if (Strings.InStr(Strings.UCase(Strings.Mid(this.DataGridView2.Rows[index2].Cells[this.cmpColumnNo].Value.ToString().Trim(), Start, Strings.Len(this.txtSearch.Text.Trim()))), Strings.UCase(Strings.Trim(this.txtSearch.Text.Trim()))) == 1)
            this.DataGridView2.Rows[index2].Visible = true;
          checked { ++Start; }
        }
        checked { ++index2; }
      }
    }
  }

  private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.cmbSearch.SelectedIndex == 0)
      this.cmpColumnNo = 3;
    if (this.cmbSearch.SelectedIndex == 1)
      this.cmpColumnNo = 14;
    if (this.cmbSearch.SelectedIndex == 2)
      this.cmpColumnNo = 15;
    if (this.cmbSearch.SelectedIndex == 3)
      this.cmpColumnNo = 16 /*0x10*/;
    if (this.cmbSearch.SelectedIndex == 4)
      this.cmpColumnNo = 17;
    if (this.cmbSearch.SelectedIndex == 5)
      this.cmpColumnNo = 18;
    if (this.cmbSearch.SelectedIndex == 6)
      this.cmpColumnNo = 19;
    if (this.cmbSearch.SelectedIndex != 7)
      return;
    this.cmpColumnNo = 2;
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    int num = checked (this.DataGridView2.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView2.Rows[index].Cells[12].Value = (object) this.DataGridView2.Rows[index].Cells[12].Value.ToString().Replace("'", "''");
      this.DataGridView2.Rows[index].Cells[13].Value = (object) this.DataGridView2.Rows[index].Cells[13].Value.ToString().Replace("'", "''");
      string cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocAuditLog set AllOk = ", this.DataGridView2.Rows[index].Cells[4].Value), (object) ","), (object) "NoCommitteeSign = "), this.DataGridView2.Rows[index].Cells[5].Value), (object) ","), (object) "NoReceiverSign = "), this.DataGridView2.Rows[index].Cells[6].Value), (object) ","), (object) "NoSupporting = "), this.DataGridView2.Rows[index].Cells[7].Value), (object) ","), (object) "NoMeetingApprov = "), this.DataGridView2.Rows[index].Cells[8].Value), (object) ","), (object) "NoTDS = "), this.DataGridView2.Rows[index].Cells[9].Value), (object) ","), (object) "NoVoucher = "), this.DataGridView2.Rows[index].Cells[10].Value), (object) ","), (object) "ExcessCash = "), this.DataGridView2.Rows[index].Cells[11].Value), (object) ","), (object) "AuditRem = '"), (object) this.DataGridView2.Rows[index].Cells[12].Value.ToString()), (object) "',"), (object) "AuditRem1 = '"), (object) this.DataGridView2.Rows[index].Cells[13].Value.ToString()), (object) "'"), (object) " where ID ="), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[21].Value))), (object) ""));
      OleDbCommand oleDbCommand1 = new OleDbCommand(cmdText, connection);
      connection.Open();
      oleDbCommand1.ExecuteNonQuery();
      connection.Close();
      OleDbCommand oleDbCommand2 = new OleDbCommand(cmdText, connection);
      connection.Open();
      oleDbCommand2.ExecuteNonQuery();
      connection.Close();
      checked { ++index; }
    }
    this.Close();
  }
}
