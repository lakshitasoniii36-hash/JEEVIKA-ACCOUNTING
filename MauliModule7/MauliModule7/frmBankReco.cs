// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmBankReco
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
public class frmBankReco : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("cmbCashbank")]
  private ComboBox _cmbCashbank;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("rb2")]
  private RadioButton _rb2;
  [AccessedThroughProperty("rb1")]
  private RadioButton _rb1;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("GrpEnable1")]
  private GroupBox _GrpEnable1;
  [AccessedThroughProperty("GrpEnable2")]
  private GroupBox _GrpEnable2;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("cmbTranType")]
  private ComboBox _cmbTranType;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
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
  [AccessedThroughProperty("txtAmountTo")]
  private TextBox _txtAmountTo;
  [AccessedThroughProperty("txtAmountFrom")]
  private TextBox _txtAmountFrom;
  [AccessedThroughProperty("txtChqNo")]
  private TextBox _txtChqNo;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtChqDate")]
  private TextBox _txtChqDate;
  [AccessedThroughProperty("txtBankName")]
  private TextBox _txtBankName;
  [AccessedThroughProperty("txtPerson")]
  private TextBox _txtPerson;
  [AccessedThroughProperty("txtParticular2")]
  private TextBox _txtParticular2;
  [AccessedThroughProperty("txtParticular3")]
  private TextBox _txtParticular3;
  [AccessedThroughProperty("txtParticular4")]
  private TextBox _txtParticular4;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("cmbClearType")]
  private ComboBox _cmbClearType;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("grpSearch")]
  private GroupBox _grpSearch;
  [AccessedThroughProperty("cmbSearch")]
  private ComboBox _cmbSearch;
  [AccessedThroughProperty("txtSearch")]
  private TextBox _txtSearch;
  [AccessedThroughProperty("Column1")]
  private DataGridViewTextBoxColumn _Column1;
  [AccessedThroughProperty("Column8")]
  private DataGridViewTextBoxColumn _Column8;
  [AccessedThroughProperty("Column9")]
  private DataGridViewTextBoxColumn _Column9;
  [AccessedThroughProperty("Column5")]
  private DataGridViewTextBoxColumn _Column5;
  [AccessedThroughProperty("Column6")]
  private DataGridViewTextBoxColumn _Column6;
  [AccessedThroughProperty("Column2")]
  private DataGridViewTextBoxColumn _Column2;
  [AccessedThroughProperty("Column17")]
  private DataGridViewTextBoxColumn _Column17;
  [AccessedThroughProperty("Column29")]
  private DataGridViewTextBoxColumn _Column29;
  [AccessedThroughProperty("Column7")]
  private DataGridViewTextBoxColumn _Column7;
  [AccessedThroughProperty("Column10")]
  private DataGridViewTextBoxColumn _Column10;
  [AccessedThroughProperty("Column11")]
  private DataGridViewTextBoxColumn _Column11;
  [AccessedThroughProperty("Column15")]
  private DataGridViewTextBoxColumn _Column15;
  [AccessedThroughProperty("Column16")]
  private DataGridViewTextBoxColumn _Column16;
  [AccessedThroughProperty("Column30")]
  private DataGridViewTextBoxColumn _Column30;
  [AccessedThroughProperty("Column3")]
  private DataGridViewTextBoxColumn _Column3;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static frmBankReco()
  {
  }

  [DebuggerNonUserCode]
  public frmBankReco()
  {
    this.Load += new EventHandler(this.frmBankReco_Load);
    frmBankReco.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmBankReco.__ENCList)
    {
      if (frmBankReco.__ENCList.Count == frmBankReco.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmBankReco.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmBankReco.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmBankReco.__ENCList[index1] = frmBankReco.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmBankReco.__ENCList.RemoveRange(index1, checked (frmBankReco.__ENCList.Count - index1));
        frmBankReco.__ENCList.Capacity = frmBankReco.__ENCList.Count;
      }
      frmBankReco.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBankReco));
    this.cmbCashbank = new ComboBox();
    this.GroupBox1 = new GroupBox();
    this.rb3 = new RadioButton();
    this.rb2 = new RadioButton();
    this.rb1 = new RadioButton();
    this.btnPrint = new Button();
    this.mtxtDate = new MaskedTextBox();
    this.btnUpdate = new Button();
    this.DataGridView1 = new DataGridView();
    this.GrpEnable1 = new GroupBox();
    this.Label13 = new Label();
    this.cmbClearType = new ComboBox();
    this.GroupBox2 = new GroupBox();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.txtAmountTo = new TextBox();
    this.txtAmountFrom = new TextBox();
    this.txtChqNo = new TextBox();
    this.Label4 = new Label();
    this.Label2 = new Label();
    this.cmbTranType = new ComboBox();
    this.Label1 = new Label();
    this.btnOk = new Button();
    this.GrpEnable2 = new GroupBox();
    this.btnExit = new Button();
    this.grpVisible = new GroupBox();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.txtChqDate = new TextBox();
    this.txtBankName = new TextBox();
    this.txtPerson = new TextBox();
    this.txtParticular2 = new TextBox();
    this.txtParticular3 = new TextBox();
    this.txtParticular4 = new TextBox();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Button2 = new Button();
    this.grpSearch = new GroupBox();
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
    this.Column1 = new DataGridViewTextBoxColumn();
    this.Column8 = new DataGridViewTextBoxColumn();
    this.Column9 = new DataGridViewTextBoxColumn();
    this.Column5 = new DataGridViewTextBoxColumn();
    this.Column6 = new DataGridViewTextBoxColumn();
    this.Column2 = new DataGridViewTextBoxColumn();
    this.Column17 = new DataGridViewTextBoxColumn();
    this.Column29 = new DataGridViewTextBoxColumn();
    this.Column7 = new DataGridViewTextBoxColumn();
    this.Column10 = new DataGridViewTextBoxColumn();
    this.Column11 = new DataGridViewTextBoxColumn();
    this.Column15 = new DataGridViewTextBoxColumn();
    this.Column16 = new DataGridViewTextBoxColumn();
    this.Column30 = new DataGridViewTextBoxColumn();
    this.Column3 = new DataGridViewTextBoxColumn();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GrpEnable1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.GrpEnable2.SuspendLayout();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpSearch.SuspendLayout();
    this.SuspendLayout();
    this.cmbCashbank.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbCashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashbank.FormattingEnabled = true;
    ComboBox cmbCashbank1 = this.cmbCashbank;
    Point point1 = new Point(71, 31 /*0x1F*/);
    Point point2 = point1;
    cmbCashbank1.Location = point2;
    this.cmbCashbank.Name = "cmbCashbank";
    ComboBox cmbCashbank2 = this.cmbCashbank;
    Size size1 = new Size(188, 24);
    Size size2 = size1;
    cmbCashbank2.Size = size2;
    this.cmbCashbank.TabIndex = 1;
    this.GroupBox1.Controls.Add((Control) this.rb3);
    this.GroupBox1.Controls.Add((Control) this.rb2);
    this.GroupBox1.Controls.Add((Control) this.rb1);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(137, 151);
    Point point3 = point1;
    groupBox1_1.Location = point3;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(96 /*0x60*/, 106);
    Size size3 = size1;
    groupBox1_2.Size = size3;
    this.GroupBox1.TabIndex = 7;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Period";
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(22, 45);
    Point point4 = point1;
    rb3_1.Location = point4;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(48 /*0x30*/, 17);
    Size size4 = size1;
    rb3_2.Size = size4;
    this.rb3.TabIndex = 9;
    this.rb3.TabStop = true;
    this.rb3.Text = "&Upto";
    this.rb3.UseVisualStyleBackColor = true;
    this.rb2.AutoSize = true;
    RadioButton rb2_1 = this.rb2;
    point1 = new Point(22, 74);
    Point point5 = point1;
    rb2_1.Location = point5;
    this.rb2.Name = "rb2";
    RadioButton rb2_2 = this.rb2;
    size1 = new Size(67, 17);
    Size size5 = size1;
    rb2_2.Size = size5;
    this.rb2.TabIndex = 10;
    this.rb2.TabStop = true;
    this.rb2.Text = "&Selected";
    this.rb2.UseVisualStyleBackColor = true;
    this.rb1.AutoSize = true;
    RadioButton rb1_1 = this.rb1;
    point1 = new Point(22, 17);
    Point point6 = point1;
    rb1_1.Location = point6;
    this.rb1.Name = "rb1";
    RadioButton rb1_2 = this.rb1;
    size1 = new Size(36, 17);
    Size size6 = size1;
    rb1_2.Size = size6;
    this.rb1.TabIndex = 8;
    this.rb1.TabStop = true;
    this.rb1.Text = "A&ll";
    this.rb1.UseVisualStyleBackColor = true;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(810, 391);
    Point point7 = point1;
    btnPrint1.Location = point7;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnPrint2.Size = size7;
    this.btnPrint.TabIndex = 15;
    this.btnPrint.Text = "&Report Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    point1 = new Point(35, 4);
    Point point8 = point1;
    mtxtDate1.Location = point8;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    size1 = new Size(77, 22);
    Size size8 = size1;
    mtxtDate2.Size = size8;
    this.mtxtDate.TabIndex = 13;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(40, 44);
    Point point9 = point1;
    btnUpdate1.Location = point9;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size9 = size1;
    btnUpdate2.Size = size9;
    this.btnUpdate.TabIndex = 14;
    this.btnUpdate.Text = "&Save";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(135, 0);
    Point point10 = point1;
    dataGridView1_1.Location = point10;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 17);
    Size size10 = size1;
    dataGridView1_2.Size = size10;
    this.DataGridView1.TabIndex = 11;
    this.GrpEnable1.Controls.Add((Control) this.Label13);
    this.GrpEnable1.Controls.Add((Control) this.cmbClearType);
    this.GrpEnable1.Controls.Add((Control) this.GroupBox2);
    this.GrpEnable1.Controls.Add((Control) this.Label2);
    this.GrpEnable1.Controls.Add((Control) this.cmbTranType);
    this.GrpEnable1.Controls.Add((Control) this.Label1);
    this.GrpEnable1.Controls.Add((Control) this.btnOk);
    this.GrpEnable1.Controls.Add((Control) this.cmbCashbank);
    this.GrpEnable1.Controls.Add((Control) this.GroupBox1);
    GroupBox grpEnable1_1 = this.GrpEnable1;
    point1 = new Point(719, 12);
    Point point11 = point1;
    grpEnable1_1.Location = point11;
    this.GrpEnable1.Name = "GrpEnable1";
    GroupBox grpEnable1_2 = this.GrpEnable1;
    size1 = new Size(267, 310);
    Size size11 = size1;
    grpEnable1_2.Size = size11;
    this.GrpEnable1.TabIndex = 0;
    this.GrpEnable1.TabStop = false;
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(3, 114);
    Point point12 = point1;
    label13_1.Location = point12;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(72, 13);
    Size size12 = size1;
    label13_2.Size = size12;
    this.Label13.TabIndex = 21;
    this.Label13.Text = "Clearing Type";
    this.cmbClearType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbClearType.FormattingEnabled = true;
    this.cmbClearType.Items.AddRange(new object[2]
    {
      (object) "Unclear",
      (object) "All"
    });
    ComboBox cmbClearType1 = this.cmbClearType;
    point1 = new Point(94, 109);
    Point point13 = point1;
    cmbClearType1.Location = point13;
    this.cmbClearType.Name = "cmbClearType";
    ComboBox cmbClearType2 = this.cmbClearType;
    size1 = new Size(160 /*0xA0*/, 24);
    Size size13 = size1;
    cmbClearType2.Size = size13;
    this.cmbClearType.TabIndex = 3;
    this.cmbClearType.Text = "Unclear";
    this.GroupBox2.Controls.Add((Control) this.Label6);
    this.GroupBox2.Controls.Add((Control) this.Label5);
    this.GroupBox2.Controls.Add((Control) this.txtAmountTo);
    this.GroupBox2.Controls.Add((Control) this.txtAmountFrom);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(3, 151);
    Point point14 = point1;
    groupBox2_1.Location = point14;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(128 /*0x80*/, 106);
    Size size14 = size1;
    groupBox2_2.Size = size14;
    this.GroupBox2.TabIndex = 4;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Amount Range";
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(6, 62);
    Point point15 = point1;
    label6_1.Location = point15;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(20, 13);
    Size size15 = size1;
    label6_2.Size = size15;
    this.Label6.TabIndex = 22;
    this.Label6.Text = "To";
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(6, 31 /*0x1F*/);
    Point point16 = point1;
    label5_1.Location = point16;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(30, 13);
    Size size16 = size1;
    label5_2.Size = size16;
    this.Label5.TabIndex = 20;
    this.Label5.Text = "From";
    TextBox txtAmountTo1 = this.txtAmountTo;
    point1 = new Point(40, 57);
    Point point17 = point1;
    txtAmountTo1.Location = point17;
    this.txtAmountTo.Name = "txtAmountTo";
    TextBox txtAmountTo2 = this.txtAmountTo;
    size1 = new Size(82, 20);
    Size size17 = size1;
    txtAmountTo2.Size = size17;
    this.txtAmountTo.TabIndex = 6;
    this.txtAmountTo.Text = "999999999.99";
    this.txtAmountTo.TextAlign = HorizontalAlignment.Right;
    TextBox txtAmountFrom1 = this.txtAmountFrom;
    point1 = new Point(40, 28);
    Point point18 = point1;
    txtAmountFrom1.Location = point18;
    this.txtAmountFrom.Name = "txtAmountFrom";
    TextBox txtAmountFrom2 = this.txtAmountFrom;
    size1 = new Size(82, 20);
    Size size18 = size1;
    txtAmountFrom2.Size = size18;
    this.txtAmountFrom.TabIndex = 5;
    this.txtAmountFrom.Text = "-999999999.99";
    this.txtAmountFrom.TextAlign = HorizontalAlignment.Right;
    TextBox txtChqNo1 = this.txtChqNo;
    point1 = new Point(119, 6);
    Point point19 = point1;
    txtChqNo1.Location = point19;
    this.txtChqNo.Name = "txtChqNo";
    TextBox txtChqNo2 = this.txtChqNo;
    size1 = new Size(10, 20);
    Size size19 = size1;
    txtChqNo2.Size = size19;
    this.txtChqNo.TabIndex = 11;
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(13, 9);
    Point point20 = point1;
    label4_1.Location = point20;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(64 /*0x40*/, 13);
    Size size20 = size1;
    label4_2.Size = size20;
    this.Label4.TabIndex = 18;
    this.Label4.Text = "Cheque No.";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(3, 75);
    Point point21 = point1;
    label2_1.Location = point21;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(90, 13);
    Size size21 = size1;
    label2_2.Size = size21;
    this.Label2.TabIndex = 17;
    this.Label2.Text = "Transaction Type";
    this.cmbTranType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbTranType.FormattingEnabled = true;
    this.cmbTranType.Items.AddRange(new object[7]
    {
      (object) "All Transaction",
      (object) "Member Receipt",
      (object) "Member Adjustment",
      (object) "Receipt",
      (object) "Payment",
      (object) "Contra",
      (object) "Openig Reco Transaction"
    });
    ComboBox cmbTranType1 = this.cmbTranType;
    point1 = new Point(94, 70);
    Point point22 = point1;
    cmbTranType1.Location = point22;
    this.cmbTranType.Name = "cmbTranType";
    ComboBox cmbTranType2 = this.cmbTranType;
    size1 = new Size(160 /*0xA0*/, 24);
    Size size22 = size1;
    cmbTranType2.Size = size22;
    this.cmbTranType.TabIndex = 2;
    this.cmbTranType.Text = "All Transaction";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(3, 36);
    Point point23 = point1;
    label1_1.Location = point23;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(65, 13);
    Size size23 = size1;
    label1_2.Size = size23;
    this.Label1.TabIndex = 15;
    this.Label1.Text = "Select Bank";
    Button btnOk1 = this.btnOk;
    point1 = new Point(91, 263);
    Point point24 = point1;
    btnOk1.Location = point24;
    this.btnOk.Name = "btnOk";
    Button btnOk2 = this.btnOk;
    size1 = new Size(99, 33);
    Size size24 = size1;
    btnOk2.Size = size24;
    this.btnOk.TabIndex = 12;
    this.btnOk.Text = "&Ok";
    this.btnOk.UseVisualStyleBackColor = true;
    this.GrpEnable2.Controls.Add((Control) this.btnExit);
    this.GrpEnable2.Controls.Add((Control) this.btnUpdate);
    GroupBox grpEnable2_1 = this.GrpEnable2;
    point1 = new Point(719, 433);
    Point point25 = point1;
    grpEnable2_1.Location = point25;
    this.GrpEnable2.Name = "GrpEnable2";
    GroupBox grpEnable2_2 = this.GrpEnable2;
    size1 = new Size(267, 94);
    Size size25 = size1;
    grpEnable2_2.Size = size25;
    this.GrpEnable2.TabIndex = 13;
    this.GrpEnable2.TabStop = false;
    Button btnExit1 = this.btnExit;
    point1 = new Point(142, 44);
    Point point26 = point1;
    btnExit1.Location = point26;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size26 = size1;
    btnExit2.Size = size26;
    this.btnExit.TabIndex = 16 /*0x10*/;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.mtxtDate);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.txtChqNo);
    this.grpVisible.Controls.Add((Control) this.Label4);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(797, 544);
    Point point27 = point1;
    grpVisible1.Location = point27;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(155, 26);
    Size size27 = size1;
    grpVisible2.Size = size27;
    this.grpVisible.TabIndex = 16 /*0x10*/;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox2";
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(135, 10);
    Point point28 = point1;
    dataGridView2_1.Location = point28;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size28 = size1;
    dataGridView2_2.Size = size28;
    this.DataGridView2.TabIndex = 14;
    this.DataGridView3.AllowUserToAddRows = false;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.DataGridView3.Columns.AddRange((DataGridViewColumn) this.Column1, (DataGridViewColumn) this.Column8, (DataGridViewColumn) this.Column9, (DataGridViewColumn) this.Column5, (DataGridViewColumn) this.Column6, (DataGridViewColumn) this.Column2, (DataGridViewColumn) this.Column17, (DataGridViewColumn) this.Column29, (DataGridViewColumn) this.Column7, (DataGridViewColumn) this.Column10, (DataGridViewColumn) this.Column11, (DataGridViewColumn) this.Column15, (DataGridViewColumn) this.Column16, (DataGridViewColumn) this.Column30, (DataGridViewColumn) this.Column3);
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView3.DefaultCellStyle = gridViewCellStyle2;
    this.DataGridView3.EditMode = DataGridViewEditMode.EditOnEnter;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(-1, 1);
    Point point29 = point1;
    dataGridView3_1.Location = point29;
    this.DataGridView3.Name = "DataGridView3";
    this.DataGridView3.RowHeadersVisible = false;
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(684, 384);
    Size size29 = size1;
    dataGridView3_2.Size = size29;
    this.DataGridView3.TabIndex = 17;
    TextBox txtChqDate1 = this.txtChqDate;
    point1 = new Point(104, 398);
    Point point30 = point1;
    txtChqDate1.Location = point30;
    this.txtChqDate.Name = "txtChqDate";
    this.txtChqDate.ReadOnly = true;
    TextBox txtChqDate2 = this.txtChqDate;
    size1 = new Size(502, 20);
    Size size30 = size1;
    txtChqDate2.Size = size30;
    this.txtChqDate.TabIndex = 18;
    this.txtChqDate.TabStop = false;
    TextBox txtBankName1 = this.txtBankName;
    point1 = new Point(104, 424);
    Point point31 = point1;
    txtBankName1.Location = point31;
    this.txtBankName.Name = "txtBankName";
    this.txtBankName.ReadOnly = true;
    TextBox txtBankName2 = this.txtBankName;
    size1 = new Size(502, 20);
    Size size31 = size1;
    txtBankName2.Size = size31;
    this.txtBankName.TabIndex = 19;
    this.txtBankName.TabStop = false;
    TextBox txtPerson1 = this.txtPerson;
    point1 = new Point(104, 450);
    Point point32 = point1;
    txtPerson1.Location = point32;
    this.txtPerson.Name = "txtPerson";
    this.txtPerson.ReadOnly = true;
    TextBox txtPerson2 = this.txtPerson;
    size1 = new Size(502, 20);
    Size size32 = size1;
    txtPerson2.Size = size32;
    this.txtPerson.TabIndex = 20;
    this.txtPerson.TabStop = false;
    TextBox txtParticular2_1 = this.txtParticular2;
    point1 = new Point(104, 476);
    Point point33 = point1;
    txtParticular2_1.Location = point33;
    this.txtParticular2.Name = "txtParticular2";
    this.txtParticular2.ReadOnly = true;
    TextBox txtParticular2_2 = this.txtParticular2;
    size1 = new Size(502, 20);
    Size size33 = size1;
    txtParticular2_2.Size = size33;
    this.txtParticular2.TabIndex = 21;
    this.txtParticular2.TabStop = false;
    TextBox txtParticular3_1 = this.txtParticular3;
    point1 = new Point(104, 502);
    Point point34 = point1;
    txtParticular3_1.Location = point34;
    this.txtParticular3.Name = "txtParticular3";
    this.txtParticular3.ReadOnly = true;
    TextBox txtParticular3_2 = this.txtParticular3;
    size1 = new Size(502, 20);
    Size size34 = size1;
    txtParticular3_2.Size = size34;
    this.txtParticular3.TabIndex = 22;
    this.txtParticular3.TabStop = false;
    TextBox txtParticular4_1 = this.txtParticular4;
    point1 = new Point(104, 528);
    Point point35 = point1;
    txtParticular4_1.Location = point35;
    this.txtParticular4.Name = "txtParticular4";
    this.txtParticular4.ReadOnly = true;
    TextBox txtParticular4_2 = this.txtParticular4;
    size1 = new Size(502, 20);
    Size size35 = size1;
    txtParticular4_2.Size = size35;
    this.txtParticular4.TabIndex = 23;
    this.txtParticular4.TabStop = false;
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(20, 401);
    Point point36 = point1;
    label7_1.Location = point36;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(70, 13);
    Size size36 = size1;
    label7_2.Size = size36;
    this.Label7.TabIndex = 24;
    this.Label7.Text = "Cheque Date";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(20, 427);
    Point point37 = point1;
    label8_1.Location = point37;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(63 /*0x3F*/, 13);
    Size size37 = size1;
    label8_2.Size = size37;
    this.Label8.TabIndex = 25;
    this.Label8.Text = "Bank Name";
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(20, 453);
    Point point38 = point1;
    label9_1.Location = point38;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(40, 13);
    Size size38 = size1;
    label9_2.Size = size38;
    this.Label9.TabIndex = 26;
    this.Label9.Text = "Person";
    this.Label10.AutoSize = true;
    Label label10_1 = this.Label10;
    point1 = new Point(20, 479);
    Point point39 = point1;
    label10_1.Location = point39;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(51, 13);
    Size size39 = size1;
    label10_2.Size = size39;
    this.Label10.TabIndex = 27;
    this.Label10.Text = "Particular";
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(20, 505);
    Point point40 = point1;
    label11_1.Location = point40;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(51, 13);
    Size size40 = size1;
    label11_2.Size = size40;
    this.Label11.TabIndex = 28;
    this.Label11.Text = "Particular";
    this.Label12.AutoSize = true;
    Label label12_1 = this.Label12;
    point1 = new Point(20, 531);
    Point point41 = point1;
    label12_1.Location = point41;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(51, 13);
    Size size41 = size1;
    label12_2.Size = size41;
    this.Label12.TabIndex = 29;
    this.Label12.Text = "Particular";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(632, 315);
    Point point42 = point1;
    button2_1.Location = point42;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size42 = size1;
    button2_2.Size = size42;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.grpSearch.Controls.Add((Control) this.cmbSearch);
    this.grpSearch.Controls.Add((Control) this.txtSearch);
    this.grpSearch.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    GroupBox grpSearch1 = this.grpSearch;
    point1 = new Point(722, 328);
    Point point43 = point1;
    grpSearch1.Location = point43;
    this.grpSearch.Name = "grpSearch";
    GroupBox grpSearch2 = this.grpSearch;
    size1 = new Size(264, 57);
    Size size43 = size1;
    grpSearch2.Size = size43;
    this.grpSearch.TabIndex = 84;
    this.grpSearch.TabStop = false;
    this.grpSearch.Text = "Search By";
    this.cmbSearch.FormattingEnabled = true;
    this.cmbSearch.Items.AddRange(new object[8]
    {
      (object) "Cheque No.",
      (object) "Cheque Date",
      (object) "Bank Name",
      (object) "Member Code",
      (object) "Debit Amount",
      (object) "Credit Amount",
      (object) "Particular",
      (object) "Particular1"
    });
    ComboBox cmbSearch1 = this.cmbSearch;
    point1 = new Point(6, 19);
    Point point44 = point1;
    cmbSearch1.Location = point44;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(102, 21);
    Size size44 = size1;
    cmbSearch2.Size = size44;
    this.cmbSearch.TabIndex = 5;
    TextBox txtSearch1 = this.txtSearch;
    point1 = new Point(134, 19);
    Point point45 = point1;
    txtSearch1.Location = point45;
    this.txtSearch.Name = "txtSearch";
    TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(102, 20);
    Size size45 = size1;
    txtSearch2.Size = size45;
    this.txtSearch.TabIndex = 6;
    this.DataGridViewTextBoxColumn1.Frozen = true;
    this.DataGridViewTextBoxColumn1.HeaderText = "Transaction Id";
    this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
    this.DataGridViewTextBoxColumn1.Visible = false;
    gridViewCellStyle3.Format = "d";
    gridViewCellStyle3.NullValue = (object) null;
    this.DataGridViewTextBoxColumn2.DefaultCellStyle = gridViewCellStyle3;
    this.DataGridViewTextBoxColumn2.Frozen = true;
    this.DataGridViewTextBoxColumn2.HeaderText = "Clearing Date";
    this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
    this.DataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.True;
    this.DataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.DataGridViewTextBoxColumn3.Frozen = true;
    this.DataGridViewTextBoxColumn3.HeaderText = "Type";
    this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
    this.DataGridViewTextBoxColumn3.Width = 70;
    gridViewCellStyle4.NullValue = (object) null;
    this.DataGridViewTextBoxColumn4.DefaultCellStyle = gridViewCellStyle4;
    this.DataGridViewTextBoxColumn4.Frozen = true;
    this.DataGridViewTextBoxColumn4.HeaderText = "No.";
    this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
    this.DataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle5.Format = "N2";
    gridViewCellStyle5.NullValue = (object) null;
    this.DataGridViewTextBoxColumn5.DefaultCellStyle = gridViewCellStyle5;
    this.DataGridViewTextBoxColumn5.Frozen = true;
    this.DataGridViewTextBoxColumn5.HeaderText = "Date";
    this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
    this.DataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.False;
    this.DataGridViewTextBoxColumn6.Frozen = true;
    this.DataGridViewTextBoxColumn6.HeaderText = "Member Code";
    this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
    this.DataGridViewTextBoxColumn6.Width = 70;
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle6.Format = "N2";
    gridViewCellStyle6.NullValue = (object) null;
    this.DataGridViewTextBoxColumn7.DefaultCellStyle = gridViewCellStyle6;
    this.DataGridViewTextBoxColumn7.Frozen = true;
    this.DataGridViewTextBoxColumn7.HeaderText = "Debit";
    this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
    this.DataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.False;
    this.DataGridViewTextBoxColumn7.Width = 70;
    gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle7.Format = "N2";
    gridViewCellStyle7.NullValue = (object) null;
    this.DataGridViewTextBoxColumn8.DefaultCellStyle = gridViewCellStyle7;
    this.DataGridViewTextBoxColumn8.Frozen = true;
    this.DataGridViewTextBoxColumn8.HeaderText = "Credit";
    this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
    this.DataGridViewTextBoxColumn8.Resizable = DataGridViewTriState.False;
    this.DataGridViewTextBoxColumn8.Width = 70;
    this.DataGridViewTextBoxColumn9.Frozen = true;
    this.DataGridViewTextBoxColumn9.HeaderText = "Cheque No.";
    this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
    this.DataGridViewTextBoxColumn10.HeaderText = "Cheque Date";
    this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
    this.DataGridViewTextBoxColumn10.Visible = false;
    this.DataGridViewTextBoxColumn11.HeaderText = "Bank Name";
    this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
    this.DataGridViewTextBoxColumn11.Visible = false;
    this.DataGridViewTextBoxColumn12.HeaderText = "Particular1";
    this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
    this.DataGridViewTextBoxColumn12.Visible = false;
    this.DataGridViewTextBoxColumn13.HeaderText = "Particular2";
    this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
    this.DataGridViewTextBoxColumn13.Visible = false;
    this.DataGridViewTextBoxColumn14.HeaderText = "Particular3";
    this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
    this.DataGridViewTextBoxColumn14.Visible = false;
    this.DataGridViewTextBoxColumn15.HeaderText = "Particular4";
    this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
    this.DataGridViewTextBoxColumn15.Visible = false;
    this.Column1.Frozen = true;
    this.Column1.HeaderText = "Transaction Id";
    this.Column1.Name = "Column1";
    this.Column1.Visible = false;
    gridViewCellStyle8.Format = "d";
    gridViewCellStyle8.NullValue = (object) null;
    this.Column8.DefaultCellStyle = gridViewCellStyle8;
    this.Column8.Frozen = true;
    this.Column8.HeaderText = "Clearing Date";
    this.Column8.Name = "Column8";
    this.Column8.Resizable = DataGridViewTriState.True;
    this.Column8.SortMode = DataGridViewColumnSortMode.NotSortable;
    this.Column9.Frozen = true;
    this.Column9.HeaderText = "Date";
    this.Column9.Name = "Column9";
    this.Column9.Width = 70;
    gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle9.Format = "N2";
    gridViewCellStyle9.NullValue = (object) null;
    this.Column5.DefaultCellStyle = gridViewCellStyle9;
    this.Column5.Frozen = true;
    this.Column5.HeaderText = "Debit";
    this.Column5.Name = "Column5";
    this.Column5.Resizable = DataGridViewTriState.False;
    gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
    gridViewCellStyle10.Format = "N2";
    gridViewCellStyle10.NullValue = (object) null;
    this.Column6.DefaultCellStyle = gridViewCellStyle10;
    this.Column6.Frozen = true;
    this.Column6.HeaderText = "Credit";
    this.Column6.Name = "Column6";
    this.Column6.Resizable = DataGridViewTriState.False;
    this.Column2.Frozen = true;
    this.Column2.HeaderText = "Type";
    this.Column2.Name = "Column2";
    this.Column2.Width = 70;
    gridViewCellStyle11.NullValue = (object) null;
    this.Column17.DefaultCellStyle = gridViewCellStyle11;
    this.Column17.Frozen = true;
    this.Column17.HeaderText = "No.";
    this.Column17.Name = "Column17";
    this.Column17.Width = 70;
    this.Column29.Frozen = true;
    this.Column29.HeaderText = "Member Code";
    this.Column29.Name = "Column29";
    this.Column29.Width = 70;
    this.Column7.Frozen = true;
    this.Column7.HeaderText = "Cheque No.";
    this.Column7.Name = "Column7";
    this.Column10.HeaderText = "Cheque Date";
    this.Column10.Name = "Column10";
    this.Column10.Visible = false;
    this.Column11.HeaderText = "Bank Name";
    this.Column11.Name = "Column11";
    this.Column11.Visible = false;
    this.Column15.HeaderText = "Person";
    this.Column15.Name = "Column15";
    this.Column16.HeaderText = "Particular2";
    this.Column16.Name = "Column16";
    this.Column16.Visible = false;
    this.Column30.HeaderText = "Particular3";
    this.Column30.Name = "Column30";
    this.Column30.Visible = false;
    this.Column3.HeaderText = "Particular4";
    this.Column3.Name = "Column3";
    this.Column3.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpSearch);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.txtParticular4);
    this.Controls.Add((Control) this.txtParticular3);
    this.Controls.Add((Control) this.txtParticular2);
    this.Controls.Add((Control) this.txtPerson);
    this.Controls.Add((Control) this.txtBankName);
    this.Controls.Add((Control) this.txtChqDate);
    this.Controls.Add((Control) this.DataGridView3);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.GrpEnable2);
    this.Controls.Add((Control) this.GrpEnable1);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmBankReco);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Bank Reco";
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GrpEnable1.ResumeLayout(false);
    this.GrpEnable1.PerformLayout();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    this.GrpEnable2.ResumeLayout(false);
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpSearch.ResumeLayout(false);
    this.grpSearch.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual RadioButton rb2
  {
    [DebuggerNonUserCode] get => this._rb2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb2_Click);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb2_KeyDown);
      if (this._rb2 != null)
      {
        this._rb2.Click -= eventHandler;
        this._rb2.KeyDown -= keyEventHandler;
      }
      this._rb2 = value;
      if (this._rb2 == null)
        return;
      this._rb2.Click += eventHandler;
      this._rb2.KeyDown += keyEventHandler;
    }
  }

  internal virtual RadioButton rb1
  {
    [DebuggerNonUserCode] get => this._rb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb1_KeyDown);
      if (this._rb1 != null)
        this._rb1.KeyDown -= keyEventHandler;
      this._rb1 = value;
      if (this._rb1 == null)
        return;
      this._rb1.KeyDown += keyEventHandler;
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

  internal virtual MaskedTextBox mtxtDate
  {
    [DebuggerNonUserCode] get => this._mtxtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._mtxtDate = value;
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

  internal virtual GroupBox GrpEnable1
  {
    [DebuggerNonUserCode] get => this._GrpEnable1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GrpEnable1 = value;
    }
  }

  internal virtual GroupBox GrpEnable2
  {
    [DebuggerNonUserCode] get => this._GrpEnable2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GrpEnable2 = value;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rb3_Click);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.rb3_KeyDown);
      if (this._rb3 != null)
      {
        this._rb3.Click -= eventHandler;
        this._rb3.KeyDown -= keyEventHandler;
      }
      this._rb3 = value;
      if (this._rb3 == null)
        return;
      this._rb3.Click += eventHandler;
      this._rb3.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbTranType
  {
    [DebuggerNonUserCode] get => this._cmbTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbTranType_KeyDown);
      if (this._cmbTranType != null)
        this._cmbTranType.KeyDown -= keyEventHandler;
      this._cmbTranType = value;
      if (this._cmbTranType == null)
        return;
      this._cmbTranType.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellValidatingEventHandler validatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView3_CellValidating);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView3_CellEnter);
      if (this._DataGridView3 != null)
      {
        this._DataGridView3.CellValidating -= validatingEventHandler;
        this._DataGridView3.CellEnter -= cellEventHandler;
      }
      this._DataGridView3 = value;
      if (this._DataGridView3 == null)
        return;
      this._DataGridView3.CellValidating += validatingEventHandler;
      this._DataGridView3.CellEnter += cellEventHandler;
    }
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

  internal virtual TextBox txtAmountTo
  {
    [DebuggerNonUserCode] get => this._txtAmountTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAmountTo_KeyDown);
      if (this._txtAmountTo != null)
        this._txtAmountTo.KeyDown -= keyEventHandler;
      this._txtAmountTo = value;
      if (this._txtAmountTo == null)
        return;
      this._txtAmountTo.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtAmountFrom
  {
    [DebuggerNonUserCode] get => this._txtAmountFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAmountFrom_KeyDown);
      if (this._txtAmountFrom != null)
        this._txtAmountFrom.KeyDown -= keyEventHandler;
      this._txtAmountFrom = value;
      if (this._txtAmountFrom == null)
        return;
      this._txtAmountFrom.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtChqNo
  {
    [DebuggerNonUserCode] get => this._txtChqNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtChqNo_KeyDown);
      if (this._txtChqNo != null)
        this._txtChqNo.KeyDown -= keyEventHandler;
      this._txtChqNo = value;
      if (this._txtChqNo == null)
        return;
      this._txtChqNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox txtChqDate
  {
    [DebuggerNonUserCode] get => this._txtChqDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtChqDate = value;
    }
  }

  internal virtual TextBox txtBankName
  {
    [DebuggerNonUserCode] get => this._txtBankName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtBankName = value;
    }
  }

  internal virtual TextBox txtPerson
  {
    [DebuggerNonUserCode] get => this._txtPerson;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtPerson = value;
    }
  }

  internal virtual TextBox txtParticular2
  {
    [DebuggerNonUserCode] get => this._txtParticular2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtParticular2 = value;
    }
  }

  internal virtual TextBox txtParticular3
  {
    [DebuggerNonUserCode] get => this._txtParticular3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtParticular3 = value;
    }
  }

  internal virtual TextBox txtParticular4
  {
    [DebuggerNonUserCode] get => this._txtParticular4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtParticular4 = value;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
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

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual ComboBox cmbClearType
  {
    [DebuggerNonUserCode] get => this._cmbClearType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbClearType_KeyDown);
      if (this._cmbClearType != null)
        this._cmbClearType.KeyDown -= keyEventHandler;
      this._cmbClearType = value;
      if (this._cmbClearType == null)
        return;
      this._cmbClearType.KeyDown += keyEventHandler;
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

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  internal virtual GroupBox grpSearch
  {
    [DebuggerNonUserCode] get => this._grpSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpSearch = value;
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

  internal virtual DataGridViewTextBoxColumn Column1
  {
    [DebuggerNonUserCode] get => this._Column1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column1 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column8
  {
    [DebuggerNonUserCode] get => this._Column8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column8 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column9
  {
    [DebuggerNonUserCode] get => this._Column9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column9 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column5
  {
    [DebuggerNonUserCode] get => this._Column5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column5 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column6
  {
    [DebuggerNonUserCode] get => this._Column6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column6 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column2
  {
    [DebuggerNonUserCode] get => this._Column2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column2 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column17
  {
    [DebuggerNonUserCode] get => this._Column17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column17 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column29
  {
    [DebuggerNonUserCode] get => this._Column29;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column29 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column7
  {
    [DebuggerNonUserCode] get => this._Column7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column7 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column10
  {
    [DebuggerNonUserCode] get => this._Column10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column10 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column11
  {
    [DebuggerNonUserCode] get => this._Column11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column11 = value;
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

  internal virtual DataGridViewTextBoxColumn Column30
  {
    [DebuggerNonUserCode] get => this._Column30;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column30 = value;
  }

  internal virtual DataGridViewTextBoxColumn Column3
  {
    [DebuggerNonUserCode] get => this._Column3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column3 = value;
  }

  private void frmBankReco_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.grpSearch.Visible = false;
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    this.GetFillCashCmb();
    this.GetFillMember();
    this.GrpEnable1.Enabled = true;
    this.btnUpdate.Enabled = false;
    this.btnPrint.Enabled = true;
    this.rb1.Checked = true;
    this.DataGridView1.DataSource = (object) null;
    this.DataGridView1.ReadOnly = false;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.RowCount = 0;
  }

  public DataSet GetFillCashCmb()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection);
    DataTable dataTable = new DataTable("SocAccountMain");
    oleDbDataAdapter.Fill(dataTable);
    this.cmbCashbank.DataSource = (object) dataTable;
    this.cmbCashbank.DisplayMember = "AccName";
    this.cmbCashbank.ValueMember = "SocAccountMainId";
    selectConnection.Close();
    DataSet fillCashCmb;
    return fillCashCmb;
  }

  public DataSet GetFillMember()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocMember.* FROM SocMember order by MemCode asc", selectConnection);
    DataTable dataTable = new DataTable("SocMember");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.ReadOnly = false;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    selectConnection.Close();
    DataSet fillMember;
    return fillMember;
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtAmountFrom.Text))
    {
      int num = (int) Interaction.MsgBox((object) "Required Numeric Value");
      this.txtAmountFrom.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtAmountTo.Text))
    {
      int num = (int) Interaction.MsgBox((object) "Required Numeric Value");
      this.txtAmountTo.Focus();
    }
    else
    {
      this.GetFillGrid();
      this.btnPrint.Enabled = false;
      this.GrpEnable1.Enabled = false;
      this.btnUpdate.Enabled = true;
      this.DataGridView3.Focus();
      this.grpSearch.Visible = true;
    }
  }

  private void rb2_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmDigPeriodRange.ShowDialog();
    if (MyProject.Forms.frmDigPeriodRange.DialogResult != DialogResult.OK)
      return;
    Constant.dateRangeFrom = MyProject.Forms.frmDigPeriodRange.mtxtDateFrom.Text;
    Constant.dateRangeto = MyProject.Forms.frmDigPeriodRange.mtxtDateTo.Text;
    if (MyProject.Forms.frmDigPeriodRange.mtxtDateFrom.Text.Length < 10)
      Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    if (MyProject.Forms.frmDigPeriodRange.mtxtDateTo.Text.Length < 10)
      Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeFrom);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
  }

  public DataSet GetFillGrid()
  {
    Constant.dateRangeFrom = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeFrom);
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdate(Constant.dateRangeto);
    string Left = "";
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbTranType.Text, "All Transaction", false) == 0)
      Left = "";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbTranType.Text, "Member Receipt", false) == 0)
      Left = "MRct";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbTranType.Text, "Member Adjustment", false) == 0)
      Left = "MAdj";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbTranType.Text, "Receipt", false) == 0)
      Left = "Rcpt";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbTranType.Text, "Payment", false) == 0)
      Left = "Pymt";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbTranType.Text, "Contra", false) == 0)
      Left = "Ctra";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbTranType.Text, "Openig Reco Transaction", false) == 0)
      Left = "OpBr";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtChqNo.Text, "", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbClearType.Text, "All", false) == 0)
        {
          if (this.rb1.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='Pymt' or  SocTran.SocTranType='Rcpt' or SocTran.SocTranType='Ctra' or SocTran.SocTranType='MRct' or SocTran.SocTranType='MAdj' or SocTran.SocTranType='OpBR') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb2.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='Pymt' or  SocTran.SocTranType='Rcpt' or SocTran.SocTranType='Ctra' or SocTran.SocTranType='MRct' or SocTran.SocTranType='MAdj' or SocTran.SocTranType='OpBR') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate >= #"), (object) Constant.dateRangeFrom), (object) "# and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb3.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='Pymt' or  SocTran.SocTranType='Rcpt' or SocTran.SocTranType='Ctra' or SocTran.SocTranType='MRct' or SocTran.SocTranType='MAdj' or SocTran.SocTranType='OpBR') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbClearType.Text, "Unclear", false) == 0)
        {
          if (this.rb1.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='Pymt' or  SocTran.SocTranType='Rcpt' or SocTran.SocTranType='Ctra' or SocTran.SocTranType='MRct' or SocTran.SocTranType='MAdj' or SocTran.SocTranType='OpBR') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " AND ((SocTran.SocTranbcr) Is Null) order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb2.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='Pymt' or  SocTran.SocTranType='Rcpt' or SocTran.SocTranType='Ctra' or SocTran.SocTranType='MRct' or SocTran.SocTranType='MAdj' or SocTran.SocTranType='OpBR') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate >= #"), (object) Constant.dateRangeFrom), (object) "# and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# AND ((SocTran.SocTranbcr) Is Null) order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb3.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='Pymt' or  SocTran.SocTranType='Rcpt' or SocTran.SocTranType='Ctra' or SocTran.SocTranType='MRct' or SocTran.SocTranType='MAdj' or SocTran.SocTranType='OpBR') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# AND ((SocTran.SocTranbcr) Is Null) order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbClearType.Text, "All", false) == 0)
        {
          if (this.rb1.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='" + Left + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb2.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='" + Left + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate >= #"), (object) Constant.dateRangeFrom), (object) "# and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb3.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='" + Left + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbClearType.Text, "Unclear", false) == 0)
        {
          if (this.rb1.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='" + Left + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " AND ((SocTran.SocTranbcr) Is Null) order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb2.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='" + Left + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate >= #"), (object) Constant.dateRangeFrom), (object) "# and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# AND ((SocTran.SocTranbcr) Is Null) order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb3.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='" + Left + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# AND ((SocTran.SocTranbcr) Is Null) order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
        }
      }
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbClearType.Text, "All", false) == 0)
        {
          if (this.rb1.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='Pymt' or  SocTran.SocTranType='Rcpt' or SocTran.SocTranType='Ctra' or SocTran.SocTranType='MRct' or SocTran.SocTranType='MAdj' or SocTran.SocTranType='OpBR') AND (SocTran.ChqNo = '" + this.txtChqNo.Text + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb2.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='Pymt' or  SocTran.SocTranType='Rcpt' or SocTran.SocTranType='Ctra' or SocTran.SocTranType='MRct' or SocTran.SocTranType='MAdj' or SocTran.SocTranType='OpBR') AND (SocTran.ChqNo = '" + this.txtChqNo.Text + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate >= #"), (object) Constant.dateRangeFrom), (object) "# and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb3.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='Pymt' or  SocTran.SocTranType='Rcpt' or SocTran.SocTranType='Ctra' or SocTran.SocTranType='MRct' or SocTran.SocTranType='MAdj' or SocTran.SocTranType='OpBR') AND (SocTran.ChqNo = '" + this.txtChqNo.Text + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbClearType.Text, "Unclear", false) == 0)
        {
          if (this.rb1.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='Pymt' or  SocTran.SocTranType='Rcpt' or SocTran.SocTranType='Ctra' or SocTran.SocTranType='MRct' or SocTran.SocTranType='MAdj' or SocTran.SocTranType='OpBR') AND (SocTran.ChqNo = '" + this.txtChqNo.Text + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " AND ((SocTran.SocTranbcr) Is Null) order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb2.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='Pymt' or  SocTran.SocTranType='Rcpt' or SocTran.SocTranType='Ctra' or SocTran.SocTranType='MRct' or SocTran.SocTranType='MAdj' or SocTran.SocTranType='OpBR') AND (SocTran.ChqNo = '" + this.txtChqNo.Text + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate >= #"), (object) Constant.dateRangeFrom), (object) "# and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# AND ((SocTran.SocTranbcr) Is Null) order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb3.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='Pymt' or  SocTran.SocTranType='Rcpt' or SocTran.SocTranType='Ctra' or SocTran.SocTranType='MRct' or SocTran.SocTranType='MAdj' or SocTran.SocTranType='OpBR') AND (SocTran.ChqNo = '" + this.txtChqNo.Text + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# AND ((SocTran.SocTranbcr) Is Null) order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbClearType.Text, "All", false) == 0)
        {
          if (this.rb1.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='" + Left + "') AND (SocTran.ChqNo = '" + this.txtChqNo.Text + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb2.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='" + Left + "') AND (SocTran.ChqNo = '" + this.txtChqNo.Text + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate >= #"), (object) Constant.dateRangeFrom), (object) "# and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb3.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='" + Left + "') AND (SocTran.ChqNo = '" + this.txtChqNo.Text + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbClearType.Text, "Unclear", false) == 0)
        {
          if (this.rb1.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='" + Left + "') AND (SocTran.ChqNo = '" + this.txtChqNo.Text + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " AND ((SocTran.SocTranbcr) Is Null) order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb2.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='" + Left + "') AND (SocTran.ChqNo = '" + this.txtChqNo.Text + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate >= #"), (object) Constant.dateRangeFrom), (object) "# and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# AND ((SocTran.SocTranbcr) Is Null) order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
          if (this.rb3.Checked)
            oleDbDataAdapter = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran WHERE (SocTran.SocTranType='" + Left + "') AND (SocTran.ChqNo = '" + this.txtChqNo.Text + "') AND (SocTran.SocTranAmount >= " + Conversions.ToString(Conversion.Val(this.txtAmountFrom.Text)) + " AND SocTran.SocTranAmount <= " + Conversions.ToString(Conversion.Val(this.txtAmountTo.Text)) + ") AND SocTran.SocAccountMainId="), this.cmbCashbank.SelectedValue), (object) " and SocTran.SocTranDate <= #"), (object) Constant.dateRangeto), (object) "# AND ((SocTran.SocTranbcr) Is Null) order by SocTran.SocTranDate,SocTran.SocTranType,SocTran.SocTranNo asc")), selectConnection);
        }
      }
    }
    DataTable dataTable = new DataTable("SocTran");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = false;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    int num1 = checked (this.DataGridView1.ColumnCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView1.Columns[index1].Visible = true;
      checked { ++index1; }
    }
    this.DataGridView1.Columns[0].HeaderText = "Clearing Date";
    this.DataGridView1.Columns[7].HeaderText = "Vou.Type";
    this.DataGridView1.Columns[8].HeaderText = "Vou.No.";
    this.DataGridView1.Columns[9].HeaderText = "Vou.Date";
    this.DataGridView1.Columns[11].HeaderText = "Mem.Code";
    this.DataGridView1.Columns[14].HeaderText = "Amount Debit/Credit(-)";
    this.DataGridView1.Columns[16 /*0x10*/].HeaderText = "Chq.No.";
    this.DataGridView1.Columns[17].HeaderText = "Chq.Dt.";
    this.DataGridView1.Columns[18].HeaderText = "Bank Name";
    this.DataGridView1.Columns[19].HeaderText = "Particular";
    this.DataGridView1.Columns[20].HeaderText = "Particular";
    this.DataGridView1.Columns[21].HeaderText = "Particular";
    this.DataGridView1.Columns[22].HeaderText = "Particular";
    this.DataGridView1.Columns[0].Width = 70;
    this.DataGridView1.Columns[7].Width = 50;
    this.DataGridView1.Columns[8].Width = 50;
    this.DataGridView1.Columns[9].Width = 70;
    this.DataGridView1.Columns[11].Width = 70;
    this.DataGridView1.Columns[14].Width = 85;
    this.DataGridView1.Columns[16 /*0x10*/].Width = 70;
    this.DataGridView1.Columns[17].Width = 70;
    this.DataGridView1.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    this.DataGridView3.RowCount = 0;
    int num2 = checked (this.DataGridView1.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      this.DataGridView3.Rows.Add();
      this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[1].Value);
      this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[0].Value);
      this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value = (object) this.DataGridView1.Rows[index2].Cells[9].Value.ToString().Substring(0, 10);
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[14].Value)) >= 0.0)
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[14].Value);
      if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[14].Value)) < 0.0)
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index2].Cells[14].Value);
      this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[7].Value);
      this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[8].Value);
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[1].Value)))
        this.DataGridView1.Rows[index2].Cells[1].Value = (object) "";
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[11].Value)))
        this.DataGridView1.Rows[index2].Cells[11].Value = (object) "";
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[17].Value)))
        this.DataGridView1.Rows[index2].Cells[17].Value = (object) "";
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[18].Value)))
        this.DataGridView1.Rows[index2].Cells[18].Value = (object) "";
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[19].Value)))
        this.DataGridView1.Rows[index2].Cells[19].Value = (object) "";
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[20].Value)))
        this.DataGridView1.Rows[index2].Cells[20].Value = (object) "";
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[21].Value)))
        this.DataGridView1.Rows[index2].Cells[21].Value = (object) "";
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[22].Value)))
        this.DataGridView1.Rows[index2].Cells[22].Value = (object) "";
      this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[11].Value);
      this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[16 /*0x10*/].Value);
      this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[17].Value);
      this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[18].Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index2].Cells[7].Value.ToString(), "MRct", false) == 0)
      {
        string str = "";
        int num3 = checked (this.DataGridView2.RowCount - 1);
        int index3 = 0;
        while (index3 <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index3].Cells[2].Value.ToString().Trim(), this.DataGridView1.Rows[index2].Cells[11].Value.ToString().Trim(), false) == 0)
            str = this.DataGridView2.Rows[index3].Cells[9].Value.ToString().Trim();
          checked { ++index3; }
        }
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[11].Value = (object) str;
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[19].Value);
      }
      else
      {
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[19].Value);
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[22].Value);
      }
      this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[20].Value);
      this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[21].Value);
      checked { ++index2; }
    }
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    int num1 = checked (this.DataGridView3.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      if (Information.IsDate(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[1].Value)))
      {
        int num2 = checked (this.DataGridView1.RowCount - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index1].Cells[0].Value, this.DataGridView1.Rows[index2].Cells[1].Value, false))
            this.DataGridView1.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[1].Value);
          checked { ++index2; }
        }
      }
      else
      {
        int num3 = checked (this.DataGridView1.RowCount - 1);
        int index3 = 0;
        while (index3 <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index1].Cells[0].Value, this.DataGridView1.Rows[index3].Cells[1].Value, false))
            this.DataGridView1.Rows[index3].Cells[0].Value = (object) "01/01/1810";
          checked { ++index3; }
        }
      }
      checked { ++index1; }
    }
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    int num4 = checked (this.DataGridView1.RowCount - 1);
    int index4 = 0;
    while (index4 <= num4)
    {
      string cmdText;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index4].Cells[0].Value)))
        cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "UPDATE SocTran SET SocTran.SocTranbcr = Null WHERE SocTran.SocTranId=", this.DataGridView1.Rows[index4].Cells[1].Value), (object) ""));
      else if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index4].Cells[0].Value, (object) "01/01/1810", false))
      {
        cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "UPDATE SocTran SET SocTran.SocTranbcr = Null WHERE SocTran.SocTranId=", this.DataGridView1.Rows[index4].Cells[1].Value), (object) ""));
      }
      else
      {
        this.mtxtDate.Text = this.DataGridView1.Rows[index4].Cells[0].Value.ToString();
        this.mtxtDate.Text = MyProject.Forms.frmSocietyDetail.Chdate(this.mtxtDate.Text);
        cmdText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocTran set SocTranbcr = '" + this.mtxtDate.Text + "' where SocTranId ="), this.DataGridView1.Rows[index4].Cells[1].Value), (object) ""));
      }
      OleDbCommand oleDbCommand = new OleDbCommand(cmdText, connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
      checked { ++index4; }
    }
    Constant.dateRangeFrom = Constant.socFYSTART.ToString();
    Constant.dateRangeto = Constant.socFYEND.ToString();
    this.GetFillCashCmb();
    this.GrpEnable1.Enabled = true;
    this.btnUpdate.Enabled = false;
    this.btnPrint.Enabled = true;
    this.rb1.Checked = true;
    this.DataGridView1.DataSource = (object) null;
    this.DataGridView1.ReadOnly = false;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.RowCount = 0;
    this.DataGridView3.RowCount = 0;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnPrint_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportBankReco.ShowDialog();
    MyProject.Forms.frmReportBankReco = (frmReportBankReco) null;
  }

  private void rb3_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmDigPeriodRangeUpto.ShowDialog();
    if (MyProject.Forms.frmDigPeriodRangeUpto.DialogResult != DialogResult.OK)
      return;
    Constant.dateRangeto = MyProject.Forms.frmDigPeriodRangeUpto.mtxtDateTo.Text;
    if (MyProject.Forms.frmDigPeriodRangeUpto.mtxtDateTo.Text.Length < 10)
      Constant.dateRangeto = Constant.socFYEND.ToString();
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
  }

  private void DataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
  {
    this.txtChqDate.Text = Conversions.ToString(this.DataGridView3.Rows[e.RowIndex].Cells[9].Value);
    this.txtBankName.Text = Conversions.ToString(this.DataGridView3.Rows[e.RowIndex].Cells[10].Value);
    this.txtPerson.Text = Conversions.ToString(this.DataGridView3.Rows[e.RowIndex].Cells[11].Value);
    this.txtParticular4.Text = Conversions.ToString(this.DataGridView3.Rows[e.RowIndex].Cells[14].Value);
    this.txtParticular2.Text = Conversions.ToString(this.DataGridView3.Rows[e.RowIndex].Cells[12].Value);
    this.txtParticular3.Text = Conversions.ToString(this.DataGridView3.Rows[e.RowIndex].Cells[13].Value);
  }

  private void DataGridView3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
  {
    if (e.ColumnIndex != 1 || !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(e.FormattedValue, (object) "", false))
      return;
    if (!Information.IsDate(RuntimeHelpers.GetObjectValue(e.FormattedValue)))
    {
      this.DataGridView3.Rows[e.RowIndex].ErrorText = "only date value.";
      e.Cancel = true;
    }
    else if (!new GeneralValidation().VdateRangeLower(Conversions.ToDate(e.FormattedValue)))
      e.Cancel = true;
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void cmbCashbank_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbTranType.Focus();
  }

  private void cmbTranType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbClearType.Focus();
  }

  private void cmbClearType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAmountFrom.Focus();
  }

  private void txtAmountFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAmountTo.Focus();
  }

  private void txtAmountTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.rb1.Focus();
  }

  private void rb1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.rb2.Focus();
  }

  private void rb2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.rb3.Focus();
  }

  private void rb3_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtChqNo.Focus();
  }

  private void txtChqNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnOk.Focus();
  }

  private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.cmbSearch.SelectedIndex == 0)
      this.cmpColumnNo = 16 /*0x10*/;
    if (this.cmbSearch.SelectedIndex == 1)
      this.cmpColumnNo = 17;
    if (this.cmbSearch.SelectedIndex == 2)
      this.cmpColumnNo = 18;
    if (this.cmbSearch.SelectedIndex == 3)
      this.cmpColumnNo = 11;
    if (this.cmbSearch.SelectedIndex == 4)
      this.cmpColumnNo = 14;
    if (this.cmbSearch.SelectedIndex == 5)
      this.cmpColumnNo = 15;
    if (this.cmbSearch.SelectedIndex == 6)
      this.cmpColumnNo = 20;
    if (this.cmbSearch.SelectedIndex != 7)
      return;
    this.cmpColumnNo = 21;
  }

  private void txtSearch_TextChanged(object sender, EventArgs e)
  {
    int num1 = checked (this.DataGridView3.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      if (Information.IsDate(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[1].Value)))
      {
        int num2 = checked (this.DataGridView1.RowCount - 1);
        int index2 = 0;
        while (index2 <= num2)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView3.Rows[index1].Cells[0].Value, this.DataGridView1.Rows[index2].Cells[1].Value, false))
            this.DataGridView1.Rows[index2].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[1].Value);
          checked { ++index2; }
        }
      }
      checked { ++index1; }
    }
    this.DataGridView3.RowCount = 0;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) == 0)
    {
      int num3 = checked (this.DataGridView1.RowCount - 1);
      int index3 = 0;
      while (index3 <= num3)
      {
        this.DataGridView3.Rows.Add();
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[1].Value);
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[0].Value);
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value = (object) this.DataGridView1.Rows[index3].Cells[9].Value.ToString().Substring(0, 10);
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[14].Value)) >= 0.0)
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[14].Value);
        if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[14].Value)) < 0.0)
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index3].Cells[14].Value);
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[7].Value);
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[8].Value);
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[1].Value)))
          this.DataGridView1.Rows[index3].Cells[1].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[11].Value)))
          this.DataGridView1.Rows[index3].Cells[11].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[17].Value)))
          this.DataGridView1.Rows[index3].Cells[17].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[18].Value)))
          this.DataGridView1.Rows[index3].Cells[18].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[19].Value)))
          this.DataGridView1.Rows[index3].Cells[19].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[20].Value)))
          this.DataGridView1.Rows[index3].Cells[20].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[21].Value)))
          this.DataGridView1.Rows[index3].Cells[21].Value = (object) "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[22].Value)))
          this.DataGridView1.Rows[index3].Cells[22].Value = (object) "";
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[11].Value);
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[16 /*0x10*/].Value);
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[17].Value);
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[18].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index3].Cells[7].Value.ToString(), "MRct", false) == 0)
        {
          string str = "";
          int num4 = checked (this.DataGridView2.RowCount - 1);
          int index4 = 0;
          while (index4 <= num4)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index4].Cells[2].Value.ToString().Trim(), this.DataGridView1.Rows[index3].Cells[11].Value.ToString().Trim(), false) == 0)
              str = this.DataGridView2.Rows[index4].Cells[9].Value.ToString().Trim();
            checked { ++index4; }
          }
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[11].Value = (object) str;
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[19].Value);
        }
        else
        {
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[19].Value);
          this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[22].Value);
        }
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[20].Value);
        this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[21].Value);
        checked { ++index3; }
      }
    }
    else
    {
      int num5 = checked (this.DataGridView1.RowCount - 1);
      int index5 = 0;
      while (index5 <= num5)
      {
        int num6 = Strings.Len(this.DataGridView1.Rows[index5].Cells[this.cmpColumnNo].Value.ToString().Trim());
        int Start = 1;
        while (Start <= num6)
        {
          if (Strings.InStr(Strings.UCase(Strings.Mid(this.DataGridView1.Rows[index5].Cells[this.cmpColumnNo].Value.ToString().Trim(), Start, Strings.Len(this.txtSearch.Text.Trim()))), Strings.UCase(Strings.Trim(this.txtSearch.Text.Trim()))) == 1)
          {
            this.DataGridView3.Rows.Add();
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[1].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[0].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[2].Value = (object) this.DataGridView1.Rows[index5].Cells[9].Value.ToString().Substring(0, 10);
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[14].Value)) >= 0.0)
              this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[3].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[14].Value);
            if (Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[14].Value)) < 0.0)
              this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[4].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index5].Cells[14].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[5].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[7].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[6].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[8].Value);
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[1].Value)))
              this.DataGridView1.Rows[index5].Cells[1].Value = (object) "";
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[11].Value)))
              this.DataGridView1.Rows[index5].Cells[11].Value = (object) "";
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[17].Value)))
              this.DataGridView1.Rows[index5].Cells[17].Value = (object) "";
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[18].Value)))
              this.DataGridView1.Rows[index5].Cells[18].Value = (object) "";
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[19].Value)))
              this.DataGridView1.Rows[index5].Cells[19].Value = (object) "";
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[20].Value)))
              this.DataGridView1.Rows[index5].Cells[20].Value = (object) "";
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[21].Value)))
              this.DataGridView1.Rows[index5].Cells[21].Value = (object) "";
            if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[22].Value)))
              this.DataGridView1.Rows[index5].Cells[22].Value = (object) "";
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[7].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[11].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[8].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[16 /*0x10*/].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[9].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[17].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[10].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[18].Value);
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index5].Cells[7].Value.ToString(), "MRct", false) == 0)
            {
              string str = "";
              int num7 = checked (this.DataGridView2.RowCount - 1);
              int index6 = 0;
              while (index6 <= num7)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[index6].Cells[2].Value.ToString().Trim(), this.DataGridView1.Rows[index5].Cells[11].Value.ToString().Trim(), false) == 0)
                  str = this.DataGridView2.Rows[index6].Cells[9].Value.ToString().Trim();
                checked { ++index6; }
              }
              this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[11].Value = (object) str;
              this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[19].Value);
            }
            else
            {
              this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[11].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[19].Value);
              this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[14].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[22].Value);
            }
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[12].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[20].Value);
            this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[13].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index5].Cells[21].Value);
          }
          checked { ++Start; }
        }
        checked { ++index5; }
      }
    }
  }
}
