// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmEmailCommittee
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

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
public class frmEmailCommittee : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("btnEmail")]
  private Button _btnEmail;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;
  [AccessedThroughProperty("lblMailError")]
  private Label _lblMailError;
  [AccessedThroughProperty("DataGridView6")]
  private DataGridView _DataGridView6;
  [AccessedThroughProperty("DataGridView7")]
  private DataGridView _DataGridView7;
  [AccessedThroughProperty("lblDateFrom")]
  private Label _lblDateFrom;
  [AccessedThroughProperty("lblDateTo")]
  private Label _lblDateTo;
  [AccessedThroughProperty("DataGridView8")]
  private DataGridView _DataGridView8;
  [AccessedThroughProperty("DataGridView9")]
  private DataGridView _DataGridView9;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("txtbody")]
  private TextBox _txtbody;
  [AccessedThroughProperty("txtSubject")]
  private TextBox _txtSubject;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("btnSelectAll")]
  private Button _btnSelectAll;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("cmbShowCashBank")]
  private ComboBox _cmbShowCashBank;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("lblReportType")]
  private Label _lblReportType;
  [AccessedThroughProperty("rb9")]
  private RadioButton _rb9;
  [AccessedThroughProperty("rb4")]
  private RadioButton _rb4;
  [AccessedThroughProperty("rb3")]
  private RadioButton _rb3;
  [AccessedThroughProperty("DataGridView10")]
  private DataGridView _DataGridView10;
  [AccessedThroughProperty("DataGridView11")]
  private DataGridView _DataGridView11;
  [AccessedThroughProperty("grpMail")]
  private GroupBox _grpMail;
  [AccessedThroughProperty("rb5")]
  private RadioButton _rb5;
  [AccessedThroughProperty("rb6")]
  private RadioButton _rb6;
  [AccessedThroughProperty("rb10")]
  private RadioButton _rb10;
  [AccessedThroughProperty("rb11")]
  private RadioButton _rb11;
  [AccessedThroughProperty("rb7")]
  private RadioButton _rb7;
  [AccessedThroughProperty("rb8")]
  private RadioButton _rb8;
  [AccessedThroughProperty("DataGridView12")]
  private DataGridView _DataGridView12;
  [AccessedThroughProperty("rb12")]
  private RadioButton _rb12;
  [AccessedThroughProperty("rb13")]
  private RadioButton _rb13;
  [AccessedThroughProperty("rb15")]
  private RadioButton _rb15;
  [AccessedThroughProperty("rb16")]
  private RadioButton _rb16;
  [AccessedThroughProperty("OpenFileDialog1")]
  private OpenFileDialog _OpenFileDialog1;
  [AccessedThroughProperty("DataGridView13")]
  private DataGridView _DataGridView13;
  [AccessedThroughProperty("rb17")]
  private RadioButton _rb17;
  [AccessedThroughProperty("rb18")]
  private RadioButton _rb18;
  [AccessedThroughProperty("lblMemCodeFrom")]
  private Label _lblMemCodeFrom;
  [AccessedThroughProperty("lblMemNameFrom")]
  private Label _lblMemNameFrom;
  [AccessedThroughProperty("lblMemIdFrom")]
  private Label _lblMemIdFrom;
  [AccessedThroughProperty("lblMemCodeTo")]
  private Label _lblMemCodeTo;
  [AccessedThroughProperty("lblMemNameTo")]
  private Label _lblMemNameTo;
  [AccessedThroughProperty("lblMemIdTo")]
  private Label _lblMemIdTo;
  [AccessedThroughProperty("txtSocMailId")]
  private TextBox _txtSocMailId;
  [AccessedThroughProperty("txtSocMailPass")]
  private TextBox _txtSocMailPass;
  [AccessedThroughProperty("txtSendStatus")]
  private TextBox _txtSendStatus;
  private int rk;
  private string btext;
  private string mailidto;
  private string mailidfrom;
  private string mailidpassword;
  private string mailidto1;
  private string mailidto2;
  private DataTable dt1;

  [DebuggerNonUserCode]
  static frmEmailCommittee()
  {
  }

  public frmEmailCommittee()
  {
    this.KeyDown += new KeyEventHandler(this.frmEmailCommittee_KeyDown);
    this.Load += new EventHandler(this.frmEmailCommittee_Load);
    frmEmailCommittee.__ENCAddToList((object) this);
    this.dt1 = new DataTable();
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmEmailCommittee.__ENCList)
    {
      if (frmEmailCommittee.__ENCList.Count == frmEmailCommittee.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmEmailCommittee.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmEmailCommittee.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmEmailCommittee.__ENCList[index1] = frmEmailCommittee.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmEmailCommittee.__ENCList.RemoveRange(index1, checked (frmEmailCommittee.__ENCList.Count - index1));
        frmEmailCommittee.__ENCList.Capacity = frmEmailCommittee.__ENCList.Count;
      }
      frmEmailCommittee.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEmailCommittee));
    this.DataGridView2 = new DataGridView();
    this.lblType = new Label();
    this.btnEmail = new Button();
    this.DataGridView1 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView4 = new DataGridView();
    this.DataGridView5 = new DataGridView();
    this.lblMailError = new Label();
    this.DataGridView6 = new DataGridView();
    this.DataGridView7 = new DataGridView();
    this.lblDateFrom = new Label();
    this.lblDateTo = new Label();
    this.DataGridView8 = new DataGridView();
    this.DataGridView9 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.lblMemIdTo = new Label();
    this.rb18 = new RadioButton();
    this.lblMemNameTo = new Label();
    this.rb17 = new RadioButton();
    this.lblMemCodeTo = new Label();
    this.DataGridView13 = new DataGridView();
    this.lblMemIdFrom = new Label();
    this.rb16 = new RadioButton();
    this.lblMemNameFrom = new Label();
    this.rb15 = new RadioButton();
    this.lblMemCodeFrom = new Label();
    this.rb13 = new RadioButton();
    this.rb12 = new RadioButton();
    this.DataGridView12 = new DataGridView();
    this.rb8 = new RadioButton();
    this.rb7 = new RadioButton();
    this.rb10 = new RadioButton();
    this.DataGridView11 = new DataGridView();
    this.lblReportType = new Label();
    this.rb11 = new RadioButton();
    this.DataGridView10 = new DataGridView();
    this.Label6 = new Label();
    this.rb5 = new RadioButton();
    this.cmbShowCashBank = new ComboBox();
    this.rb6 = new RadioButton();
    this.rb9 = new RadioButton();
    this.rb4 = new RadioButton();
    this.rb3 = new RadioButton();
    this.pb1 = new ProgressBar();
    this.txtbody = new TextBox();
    this.txtSubject = new TextBox();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.btnSelectAll = new Button();
    this.Button2 = new Button();
    this.btnCancel = new Button();
    this.grpMail = new GroupBox();
    this.OpenFileDialog1 = new OpenFileDialog();
    this.txtSocMailId = new TextBox();
    this.txtSocMailPass = new TextBox();
    this.txtSendStatus = new TextBox();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    ((ISupportInitialize) this.DataGridView6).BeginInit();
    ((ISupportInitialize) this.DataGridView7).BeginInit();
    ((ISupportInitialize) this.DataGridView8).BeginInit();
    ((ISupportInitialize) this.DataGridView9).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView13).BeginInit();
    ((ISupportInitialize) this.DataGridView12).BeginInit();
    ((ISupportInitialize) this.DataGridView11).BeginInit();
    ((ISupportInitialize) this.DataGridView10).BeginInit();
    this.grpMail.SuspendLayout();
    this.SuspendLayout();
    gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle.BackColor = SystemColors.Control;
    gridViewCellStyle.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle.ForeColor = SystemColors.WindowText;
    gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    Point point1 = new Point(0, 9);
    Point point2 = point1;
    dataGridView2_1.Location = point2;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    Size size1 = new Size(694, 572);
    Size size2 = size1;
    dataGridView2_2.Size = size2;
    this.DataGridView2.TabIndex = 7;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(10, 58);
    Point point3 = point1;
    lblType1.Location = point3;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size3 = size1;
    lblType2.Size = size3;
    this.lblType.TabIndex = 29;
    this.lblType.Text = "Type";
    this.btnEmail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnEmail1 = this.btnEmail;
    point1 = new Point(25, 219);
    Point point4 = point1;
    btnEmail1.Location = point4;
    this.btnEmail.Name = "btnEmail";
    Button btnEmail2 = this.btnEmail;
    size1 = new Size(119, 33);
    Size size4 = size1;
    btnEmail2.Size = size4;
    this.btnEmail.TabIndex = 8;
    this.btnEmail.Text = "Send Mail";
    this.btnEmail.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(33, 45);
    Point point5 = point1;
    dataGridView1_1.Location = point5;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 13);
    Size size5 = size1;
    dataGridView1_2.Size = size5;
    this.DataGridView1.TabIndex = 33;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(31 /*0x1F*/, 27);
    Point point6 = point1;
    dataGridView3_1.Location = point6;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 11);
    Size size6 = size1;
    dataGridView3_2.Size = size6;
    this.DataGridView3.TabIndex = 34;
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(31 /*0x1F*/, 12);
    Point point7 = point1;
    dataGridView4_1.Location = point7;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(12, 10);
    Size size7 = size1;
    dataGridView4_2.Size = size7;
    this.DataGridView4.TabIndex = 35;
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(43, 28);
    Point point8 = point1;
    dataGridView5_1.Location = point8;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(10, 11);
    Size size8 = size1;
    dataGridView5_2.Size = size8;
    this.DataGridView5.TabIndex = 36;
    this.lblMailError.AutoSize = true;
    Label lblMailError1 = this.lblMailError;
    point1 = new Point(7, 32 /*0x20*/);
    Point point9 = point1;
    lblMailError1.Location = point9;
    this.lblMailError.Name = "lblMailError";
    Label lblMailError2 = this.lblMailError;
    size1 = new Size(21, 13);
    Size size9 = size1;
    lblMailError2.Size = size9;
    this.lblMailError.TabIndex = 37;
    this.lblMailError.Text = "No";
    this.DataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView6_1 = this.DataGridView6;
    point1 = new Point(10, 28);
    Point point10 = point1;
    dataGridView6_1.Location = point10;
    this.DataGridView6.Name = "DataGridView6";
    DataGridView dataGridView6_2 = this.DataGridView6;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView6_2.Size = size10;
    this.DataGridView6.TabIndex = 40;
    this.DataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView7_1 = this.DataGridView7;
    point1 = new Point(10, 45);
    Point point11 = point1;
    dataGridView7_1.Location = point11;
    this.DataGridView7.Name = "DataGridView7";
    DataGridView dataGridView7_2 = this.DataGridView7;
    size1 = new Size(10, 10);
    Size size11 = size1;
    dataGridView7_2.Size = size11;
    this.DataGridView7.TabIndex = 41;
    this.lblDateFrom.AutoSize = true;
    Label lblDateFrom1 = this.lblDateFrom;
    point1 = new Point(10, 76);
    Point point12 = point1;
    lblDateFrom1.Location = point12;
    this.lblDateFrom.Name = "lblDateFrom";
    Label lblDateFrom2 = this.lblDateFrom;
    size1 = new Size(39, 13);
    Size size12 = size1;
    lblDateFrom2.Size = size12;
    this.lblDateFrom.TabIndex = 42;
    this.lblDateFrom.Text = "Label4";
    this.lblDateTo.AutoSize = true;
    Label lblDateTo1 = this.lblDateTo;
    point1 = new Point(6, 45);
    Point point13 = point1;
    lblDateTo1.Location = point13;
    this.lblDateTo.Name = "lblDateTo";
    Label lblDateTo2 = this.lblDateTo;
    size1 = new Size(39, 13);
    Size size13 = size1;
    lblDateTo2.Size = size13;
    this.lblDateTo.TabIndex = 43;
    this.lblDateTo.Text = "Label4";
    this.DataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView8_1 = this.DataGridView8;
    point1 = new Point(10, 12);
    Point point14 = point1;
    dataGridView8_1.Location = point14;
    this.DataGridView8.Name = "DataGridView8";
    DataGridView dataGridView8_2 = this.DataGridView8;
    size1 = new Size(10, 10);
    Size size14 = size1;
    dataGridView8_2.Size = size14;
    this.DataGridView8.TabIndex = 44;
    this.DataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView9_1 = this.DataGridView9;
    point1 = new Point(86, 68);
    Point point15 = point1;
    dataGridView9_1.Location = point15;
    this.DataGridView9.Name = "DataGridView9";
    DataGridView dataGridView9_2 = this.DataGridView9;
    size1 = new Size(10, 11);
    Size size15 = size1;
    dataGridView9_2.Size = size15;
    this.DataGridView9.TabIndex = 45;
    this.grpVisible.Controls.Add((Control) this.txtSendStatus);
    this.grpVisible.Controls.Add((Control) this.txtSocMailPass);
    this.grpVisible.Controls.Add((Control) this.lblMemIdTo);
    this.grpVisible.Controls.Add((Control) this.txtSocMailId);
    this.grpVisible.Controls.Add((Control) this.rb18);
    this.grpVisible.Controls.Add((Control) this.lblMemNameTo);
    this.grpVisible.Controls.Add((Control) this.rb17);
    this.grpVisible.Controls.Add((Control) this.lblMemCodeTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView13);
    this.grpVisible.Controls.Add((Control) this.lblMemIdFrom);
    this.grpVisible.Controls.Add((Control) this.rb16);
    this.grpVisible.Controls.Add((Control) this.lblMemNameFrom);
    this.grpVisible.Controls.Add((Control) this.rb15);
    this.grpVisible.Controls.Add((Control) this.lblMemCodeFrom);
    this.grpVisible.Controls.Add((Control) this.rb13);
    this.grpVisible.Controls.Add((Control) this.rb12);
    this.grpVisible.Controls.Add((Control) this.DataGridView12);
    this.grpVisible.Controls.Add((Control) this.rb8);
    this.grpVisible.Controls.Add((Control) this.rb7);
    this.grpVisible.Controls.Add((Control) this.rb10);
    this.grpVisible.Controls.Add((Control) this.DataGridView11);
    this.grpVisible.Controls.Add((Control) this.DataGridView9);
    this.grpVisible.Controls.Add((Control) this.lblReportType);
    this.grpVisible.Controls.Add((Control) this.rb11);
    this.grpVisible.Controls.Add((Control) this.DataGridView10);
    this.grpVisible.Controls.Add((Control) this.Label6);
    this.grpVisible.Controls.Add((Control) this.rb5);
    this.grpVisible.Controls.Add((Control) this.cmbShowCashBank);
    this.grpVisible.Controls.Add((Control) this.rb6);
    this.grpVisible.Controls.Add((Control) this.lblDateTo);
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.DataGridView8);
    this.grpVisible.Controls.Add((Control) this.lblDateFrom);
    this.grpVisible.Controls.Add((Control) this.lblMailError);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.DataGridView7);
    this.grpVisible.Controls.Add((Control) this.rb9);
    this.grpVisible.Controls.Add((Control) this.DataGridView6);
    this.grpVisible.Controls.Add((Control) this.rb4);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.rb3);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(33, 44);
    Point point16 = point1;
    grpVisible1.Location = point16;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(190, 515);
    Size size16 = size1;
    grpVisible2.Size = size16;
    this.grpVisible.TabIndex = 46;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.lblMemIdTo.AutoSize = true;
    this.lblMemIdTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemIdTo.ForeColor = Color.Black;
    Label lblMemIdTo1 = this.lblMemIdTo;
    point1 = new Point(76, 122);
    Point point17 = point1;
    lblMemIdTo1.Location = point17;
    this.lblMemIdTo.Name = "lblMemIdTo";
    Label lblMemIdTo2 = this.lblMemIdTo;
    size1 = new Size(45, 16 /*0x10*/);
    Size size17 = size1;
    lblMemIdTo2.Size = size17;
    this.lblMemIdTo.TabIndex = 123;
    this.lblMemIdTo.Text = "Code";
    this.rb18.AutoSize = true;
    RadioButton rb18_1 = this.rb18;
    point1 = new Point(6, 462);
    Point point18 = point1;
    rb18_1.Location = point18;
    this.rb18.Name = "rb18";
    RadioButton rb18_2 = this.rb18;
    size1 = new Size(262, 17);
    Size size18 = size1;
    rb18_2.Size = size18;
    this.rb18.TabIndex = 116;
    this.rb18.TabStop = true;
    this.rb18.Text = "12.Full Page - 21 Head (Bill with Receipt) Format-2";
    this.rb18.UseVisualStyleBackColor = true;
    this.lblMemNameTo.AutoSize = true;
    this.lblMemNameTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemNameTo.ForeColor = Color.Black;
    Label lblMemNameTo1 = this.lblMemNameTo;
    point1 = new Point(76, 104);
    Point point19 = point1;
    lblMemNameTo1.Location = point19;
    this.lblMemNameTo.Name = "lblMemNameTo";
    Label lblMemNameTo2 = this.lblMemNameTo;
    size1 = new Size(12, 16 /*0x10*/);
    Size size19 = size1;
    lblMemNameTo2.Size = size19;
    this.lblMemNameTo.TabIndex = 122;
    this.lblMemNameTo.Text = ".";
    this.rb17.AutoSize = true;
    RadioButton rb17_1 = this.rb17;
    point1 = new Point(6, 444);
    Point point20 = point1;
    rb17_1.Location = point20;
    this.rb17.Name = "rb17";
    RadioButton rb17_2 = this.rb17;
    size1 = new Size(262, 17);
    Size size20 = size1;
    rb17_2.Size = size20;
    this.rb17.TabIndex = 115;
    this.rb17.TabStop = true;
    this.rb17.Text = "11.Full Page - 21 Head (Bill with Receipt) Format-1";
    this.rb17.UseVisualStyleBackColor = true;
    this.lblMemCodeTo.AutoSize = true;
    this.lblMemCodeTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCodeTo.ForeColor = Color.Black;
    Label lblMemCodeTo1 = this.lblMemCodeTo;
    point1 = new Point(76, 88);
    Point point21 = point1;
    lblMemCodeTo1.Location = point21;
    this.lblMemCodeTo.Name = "lblMemCodeTo";
    Label lblMemCodeTo2 = this.lblMemCodeTo;
    size1 = new Size(45, 16 /*0x10*/);
    Size size21 = size1;
    lblMemCodeTo2.Size = size21;
    this.lblMemCodeTo.TabIndex = 121;
    this.lblMemCodeTo.Text = "Code";
    this.DataGridView13.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView13_1 = this.DataGridView13;
    point1 = new Point(123, 28);
    Point point22 = point1;
    dataGridView13_1.Location = point22;
    this.DataGridView13.Name = "DataGridView13";
    DataGridView dataGridView13_2 = this.DataGridView13;
    size1 = new Size(10, 10);
    Size size22 = size1;
    dataGridView13_2.Size = size22;
    this.DataGridView13.TabIndex = 114;
    this.lblMemIdFrom.AutoSize = true;
    this.lblMemIdFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemIdFrom.ForeColor = Color.Black;
    Label lblMemIdFrom1 = this.lblMemIdFrom;
    point1 = new Point(123, 123);
    Point point23 = point1;
    lblMemIdFrom1.Location = point23;
    this.lblMemIdFrom.Name = "lblMemIdFrom";
    Label lblMemIdFrom2 = this.lblMemIdFrom;
    size1 = new Size(45, 16 /*0x10*/);
    Size size23 = size1;
    lblMemIdFrom2.Size = size23;
    this.lblMemIdFrom.TabIndex = 120;
    this.lblMemIdFrom.Text = "Code";
    this.rb16.AutoSize = true;
    RadioButton rb16_1 = this.rb16;
    point1 = new Point(6, 421);
    Point point24 = point1;
    rb16_1.Location = point24;
    this.rb16.Name = "rb16";
    RadioButton rb16_2 = this.rb16;
    size1 = new Size(274, 17);
    Size size24 = size1;
    rb16_2.Size = size24;
    this.rb16.TabIndex = 113;
    this.rb16.TabStop = true;
    this.rb16.Text = "12. Full Page - 21 Head New GST WITH ADDRESS";
    this.rb16.UseVisualStyleBackColor = true;
    this.lblMemNameFrom.AutoSize = true;
    this.lblMemNameFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemNameFrom.ForeColor = Color.Black;
    Label lblMemNameFrom1 = this.lblMemNameFrom;
    point1 = new Point(123, 102);
    Point point25 = point1;
    lblMemNameFrom1.Location = point25;
    this.lblMemNameFrom.Name = "lblMemNameFrom";
    Label lblMemNameFrom2 = this.lblMemNameFrom;
    size1 = new Size(12, 16 /*0x10*/);
    Size size25 = size1;
    lblMemNameFrom2.Size = size25;
    this.lblMemNameFrom.TabIndex = 119;
    this.lblMemNameFrom.Text = ".";
    this.rb15.AutoSize = true;
    RadioButton rb15_1 = this.rb15;
    point1 = new Point(6, 399);
    Point point26 = point1;
    rb15_1.Location = point26;
    this.rb15.Name = "rb15";
    RadioButton rb15_2 = this.rb15;
    size1 = new Size(287, 17);
    Size size26 = size1;
    rb15_2.Size = size26;
    this.rb15.TabIndex = 112 /*0x70*/;
    this.rb15.TabStop = true;
    this.rb15.Text = "12. Full Page - 21 Head New (Bill with Receipt)(Marathi)";
    this.rb15.UseVisualStyleBackColor = true;
    this.lblMemCodeFrom.AutoSize = true;
    this.lblMemCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblMemCodeFrom.ForeColor = Color.Black;
    Label lblMemCodeFrom1 = this.lblMemCodeFrom;
    point1 = new Point(123, 87);
    Point point27 = point1;
    lblMemCodeFrom1.Location = point27;
    this.lblMemCodeFrom.Name = "lblMemCodeFrom";
    Label lblMemCodeFrom2 = this.lblMemCodeFrom;
    size1 = new Size(45, 16 /*0x10*/);
    Size size27 = size1;
    lblMemCodeFrom2.Size = size27;
    this.lblMemCodeFrom.TabIndex = 98;
    this.lblMemCodeFrom.Text = "Code";
    this.rb13.AutoSize = true;
    RadioButton rb13_1 = this.rb13;
    point1 = new Point(6, 376);
    Point point28 = point1;
    rb13_1.Location = point28;
    this.rb13.Name = "rb13";
    RadioButton rb13_2 = this.rb13;
    size1 = new Size(162, 17);
    Size size28 = size1;
    rb13_2.Size = size28;
    this.rb13.TabIndex = 111;
    this.rb13.TabStop = true;
    this.rb13.Text = "Full Page 21 Heads (Marathi)";
    this.rb13.UseVisualStyleBackColor = true;
    this.rb12.AutoSize = true;
    RadioButton rb12_1 = this.rb12;
    point1 = new Point(6, 357);
    Point point29 = point1;
    rb12_1.Location = point29;
    this.rb12.Name = "rb12";
    RadioButton rb12_2 = this.rb12;
    size1 = new Size(166, 17);
    Size size29 = size1;
    rb12_2.Size = size29;
    this.rb12.TabIndex = 110;
    this.rb12.TabStop = true;
    this.rb12.Text = "Full Page with receipt 21 New";
    this.rb12.UseVisualStyleBackColor = true;
    this.DataGridView12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView12_1 = this.DataGridView12;
    point1 = new Point(107, 29);
    Point point30 = point1;
    dataGridView12_1.Location = point30;
    this.DataGridView12.Name = "DataGridView12";
    DataGridView dataGridView12_2 = this.DataGridView12;
    size1 = new Size(10, 10);
    Size size30 = size1;
    dataGridView12_2.Size = size30;
    this.DataGridView12.TabIndex = 109;
    this.rb8.AutoSize = true;
    RadioButton rb8_1 = this.rb8;
    point1 = new Point(8, 334);
    Point point31 = point1;
    rb8_1.Location = point31;
    this.rb8.Name = "rb8";
    RadioButton rb8_2 = this.rb8;
    size1 = new Size(104, 17);
    Size size31 = size1;
    rb8_2.Size = size31;
    this.rb8.TabIndex = 108;
    this.rb8.TabStop = true;
    this.rb8.Text = "GST1 Bill Format";
    this.rb8.UseVisualStyleBackColor = true;
    this.rb7.AutoSize = true;
    RadioButton rb7_1 = this.rb7;
    point1 = new Point(9, 311);
    Point point32 = point1;
    rb7_1.Location = point32;
    this.rb7.Name = "rb7";
    RadioButton rb7_2 = this.rb7;
    size1 = new Size(98, 17);
    Size size32 = size1;
    rb7_2.Size = size32;
    this.rb7.TabIndex = 107;
    this.rb7.TabStop = true;
    this.rb7.Text = "GST Bill Format";
    this.rb7.UseVisualStyleBackColor = true;
    this.rb10.AutoSize = true;
    RadioButton rb10_1 = this.rb10;
    point1 = new Point(10, 165);
    Point point33 = point1;
    rb10_1.Location = point33;
    this.rb10.Name = "rb10";
    RadioButton rb10_2 = this.rb10;
    size1 = new Size(118, 17);
    Size size33 = size1;
    rb10_2.Size = size33;
    this.rb10.TabIndex = 105;
    this.rb10.TabStop = true;
    this.rb10.Text = "Full Page 21 Heads";
    this.rb10.UseVisualStyleBackColor = true;
    this.DataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView11_1 = this.DataGridView11;
    point1 = new Point(32 /*0x20*/, 67);
    Point point34 = point1;
    dataGridView11_1.Location = point34;
    this.DataGridView11.Name = "DataGridView11";
    DataGridView dataGridView11_2 = this.DataGridView11;
    size1 = new Size(11, 10);
    Size size34 = size1;
    dataGridView11_2.Size = size34;
    this.DataGridView11.TabIndex = 90;
    this.lblReportType.AutoSize = true;
    Label lblReportType1 = this.lblReportType;
    point1 = new Point(-1, 59);
    Point point35 = point1;
    lblReportType1.Location = point35;
    this.lblReportType.Name = "lblReportType";
    Label lblReportType2 = this.lblReportType;
    size1 = new Size(73, 13);
    Size size35 = size1;
    lblReportType2.Size = size35;
    this.lblReportType.TabIndex = 89;
    this.lblReportType.Text = "lblReportType";
    this.rb11.AutoSize = true;
    RadioButton rb11_1 = this.rb11;
    point1 = new Point(9, 237);
    Point point36 = point1;
    rb11_1.Location = point36;
    this.rb11.Name = "rb11";
    RadioButton rb11_2 = this.rb11;
    size1 = new Size(118, 17);
    Size size36 = size1;
    rb11_2.Size = size36;
    this.rb11.TabIndex = 106;
    this.rb11.TabStop = true;
    this.rb11.Text = "Full Page 21 Heads";
    this.rb11.UseVisualStyleBackColor = true;
    this.DataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView10_1 = this.DataGridView10;
    point1 = new Point(24, 59);
    Point point37 = point1;
    dataGridView10_1.Location = point37;
    this.DataGridView10.Name = "DataGridView10";
    DataGridView dataGridView10_2 = this.DataGridView10;
    size1 = new Size(11, 10);
    Size size37 = size1;
    dataGridView10_2.Size = size37;
    this.DataGridView10.TabIndex = 46;
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(-11, 58);
    Point point38 = point1;
    label6_1.Location = point38;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(91, 13);
    Size size38 = size1;
    label6_2.Size = size38;
    this.Label6.TabIndex = 45;
    this.Label6.Text = "Show Cash/Bank";
    this.rb5.AutoSize = true;
    RadioButton rb5_1 = this.rb5;
    point1 = new Point(10, 191);
    Point point39 = point1;
    rb5_1.Location = point39;
    this.rb5.Name = "rb5";
    RadioButton rb5_2 = this.rb5;
    size1 = new Size(154, 17);
    Size size39 = size1;
    rb5_2.Size = size39;
    this.rb5.TabIndex = 103;
    this.rb5.TabStop = true;
    this.rb5.Text = "Half Page 14 Head Vertical";
    this.rb5.UseVisualStyleBackColor = true;
    this.cmbShowCashBank.FormattingEnabled = true;
    this.cmbShowCashBank.Items.AddRange(new object[2]
    {
      (object) "No",
      (object) "Yes"
    });
    ComboBox cmbShowCashBank1 = this.cmbShowCashBank;
    point1 = new Point(2, 101);
    Point point40 = point1;
    cmbShowCashBank1.Location = point40;
    this.cmbShowCashBank.Name = "cmbShowCashBank";
    ComboBox cmbShowCashBank2 = this.cmbShowCashBank;
    size1 = new Size(57, 21);
    Size size40 = size1;
    cmbShowCashBank2.Size = size40;
    this.cmbShowCashBank.TabIndex = 16 /*0x10*/;
    this.cmbShowCashBank.Text = "No";
    this.rb6.AutoSize = true;
    RadioButton rb6_1 = this.rb6;
    point1 = new Point(9, 214);
    Point point41 = point1;
    rb6_1.Location = point41;
    this.rb6.Name = "rb6";
    RadioButton rb6_2 = this.rb6;
    size1 = new Size(154, 17);
    Size size41 = size1;
    rb6_2.Size = size41;
    this.rb6.TabIndex = 104;
    this.rb6.TabStop = true;
    this.rb6.Text = "Half Page 14 Head Vertical";
    this.rb6.UseVisualStyleBackColor = true;
    this.rb9.AutoSize = true;
    RadioButton rb9_1 = this.rb9;
    point1 = new Point(9, 288);
    Point point42 = point1;
    rb9_1.Location = point42;
    this.rb9.Name = "rb9";
    RadioButton rb9_2 = this.rb9;
    size1 = new Size(118, 17);
    Size size42 = size1;
    rb9_2.Size = size42;
    this.rb9.TabIndex = 17;
    this.rb9.TabStop = true;
    this.rb9.Text = "Full Page 21 Heads";
    this.rb9.UseVisualStyleBackColor = true;
    this.rb4.AutoSize = true;
    RadioButton rb4_1 = this.rb4;
    point1 = new Point(9, 260);
    Point point43 = point1;
    rb4_1.Location = point43;
    this.rb4.Name = "rb4";
    RadioButton rb4_2 = this.rb4;
    size1 = new Size(118, 17);
    Size size43 = size1;
    rb4_2.Size = size43;
    this.rb4.TabIndex = 16 /*0x10*/;
    this.rb4.TabStop = true;
    this.rb4.Text = "Full Page 14 Heads";
    this.rb4.UseVisualStyleBackColor = true;
    this.rb3.AutoSize = true;
    RadioButton rb3_1 = this.rb3;
    point1 = new Point(9, 137);
    Point point44 = point1;
    rb3_1.Location = point44;
    this.rb3.Name = "rb3";
    RadioButton rb3_2 = this.rb3;
    size1 = new Size(121, 17);
    Size size44 = size1;
    rb3_2.Size = size44;
    this.rb3.TabIndex = 15;
    this.rb3.TabStop = true;
    this.rb3.Text = "Half Page 14 Heads";
    this.rb3.UseVisualStyleBackColor = true;
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(6, 250);
    Point point45 = point1;
    pb1_1.Location = point45;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(279, 23);
    Size size45 = size1;
    pb1_2.Size = size45;
    this.pb1.TabIndex = 47;
    TextBox txtbody1 = this.txtbody;
    point1 = new Point(9, 108);
    Point point46 = point1;
    txtbody1.Location = point46;
    this.txtbody.Multiline = true;
    this.txtbody.Name = "txtbody";
    TextBox txtbody2 = this.txtbody;
    size1 = new Size(277, 80 /*0x50*/);
    Size size46 = size1;
    txtbody2.Size = size46;
    this.txtbody.TabIndex = 6;
    TextBox txtSubject1 = this.txtSubject;
    point1 = new Point(10, 67);
    Point point47 = point1;
    txtSubject1.Location = point47;
    this.txtSubject.MaxLength = 200;
    this.txtSubject.Name = "txtSubject";
    TextBox txtSubject2 = this.txtSubject;
    size1 = new Size(276, 20);
    Size size47 = size1;
    txtSubject2.Size = size47;
    this.txtSubject.TabIndex = 5;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(113, 49);
    Point point48 = point1;
    label1_1.Location = point48;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(65, 13);
    Size size48 = size1;
    label1_2.Size = size48;
    this.Label1.TabIndex = 50;
    this.Label1.Text = "Mail Subject";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(89, 90);
    Point point49 = point1;
    label3_1.Location = point49;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(99, 13);
    Size size49 = size1;
    label3_2.Size = size49;
    this.Label3.TabIndex = 51;
    this.Label3.Text = "Mail Body Message";
    Button btnSelectAll1 = this.btnSelectAll;
    point1 = new Point(38, 14);
    Point point50 = point1;
    btnSelectAll1.Location = point50;
    this.btnSelectAll.Name = "btnSelectAll";
    Button btnSelectAll2 = this.btnSelectAll;
    size1 = new Size(222, 33);
    Size size50 = size1;
    btnSelectAll2.Size = size50;
    this.btnSelectAll.TabIndex = 7;
    this.btnSelectAll.Text = "Selecte All Member";
    this.btnSelectAll.UseVisualStyleBackColor = true;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(483, 333);
    Point point51 = point1;
    button2_1.Location = point51;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size51 = size1;
    button2_2.Size = size51;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(163, 219);
    Point point52 = point1;
    btnCancel1.Location = point52;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(119, 33);
    Size size52 = size1;
    btnCancel2.Size = size52;
    this.btnCancel.TabIndex = 86;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.grpMail.Controls.Add((Control) this.btnSelectAll);
    this.grpMail.Controls.Add((Control) this.Label3);
    this.grpMail.Controls.Add((Control) this.btnEmail);
    this.grpMail.Controls.Add((Control) this.txtSubject);
    this.grpMail.Controls.Add((Control) this.Label1);
    this.grpMail.Controls.Add((Control) this.btnCancel);
    this.grpMail.Controls.Add((Control) this.pb1);
    this.grpMail.Controls.Add((Control) this.txtbody);
    GroupBox grpMail1 = this.grpMail;
    point1 = new Point(700, 304);
    Point point53 = point1;
    grpMail1.Location = point53;
    this.grpMail.Name = "grpMail";
    GroupBox grpMail2 = this.grpMail;
    size1 = new Size(289, 266);
    Size size53 = size1;
    grpMail2.Size = size53;
    this.grpMail.TabIndex = 88;
    this.grpMail.TabStop = false;
    this.OpenFileDialog1.FileName = "OpenFileDialog1";
    TextBox txtSocMailId1 = this.txtSocMailId;
    point1 = new Point(82, 42);
    Point point54 = point1;
    txtSocMailId1.Location = point54;
    this.txtSocMailId.Name = "txtSocMailId";
    TextBox txtSocMailId2 = this.txtSocMailId;
    size1 = new Size(16 /*0x10*/, 20);
    Size size54 = size1;
    txtSocMailId2.Size = size54;
    this.txtSocMailId.TabIndex = 89;
    TextBox txtSocMailPass1 = this.txtSocMailPass;
    point1 = new Point(104, 42);
    Point point55 = point1;
    txtSocMailPass1.Location = point55;
    this.txtSocMailPass.Name = "txtSocMailPass";
    TextBox txtSocMailPass2 = this.txtSocMailPass;
    size1 = new Size(16 /*0x10*/, 20);
    Size size55 = size1;
    txtSocMailPass2.Size = size55;
    this.txtSocMailPass.TabIndex = 90;
    TextBox txtSendStatus1 = this.txtSendStatus;
    point1 = new Point(126, 42);
    Point point56 = point1;
    txtSendStatus1.Location = point56;
    this.txtSendStatus.Name = "txtSendStatus";
    TextBox txtSendStatus2 = this.txtSendStatus;
    size1 = new Size(23, 20);
    Size size56 = size1;
    txtSendStatus2.Size = size56;
    this.txtSendStatus.TabIndex = 91;
    this.txtSendStatus.Text = "No";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpMail);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmEmailCommittee);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmEmailCommittee);
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    ((ISupportInitialize) this.DataGridView6).EndInit();
    ((ISupportInitialize) this.DataGridView7).EndInit();
    ((ISupportInitialize) this.DataGridView8).EndInit();
    ((ISupportInitialize) this.DataGridView9).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView13).EndInit();
    ((ISupportInitialize) this.DataGridView12).EndInit();
    ((ISupportInitialize) this.DataGridView11).EndInit();
    ((ISupportInitialize) this.DataGridView10).EndInit();
    this.grpMail.ResumeLayout(false);
    this.grpMail.PerformLayout();
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

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual Button btnEmail
  {
    [DebuggerNonUserCode] get => this._btnEmail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnEmail_Click);
      if (this._btnEmail != null)
        this._btnEmail.Click -= eventHandler;
      this._btnEmail = value;
      if (this._btnEmail == null)
        return;
      this._btnEmail.Click += eventHandler;
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

  internal virtual Label lblMailError
  {
    [DebuggerNonUserCode] get => this._lblMailError;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMailError = value;
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

  internal virtual DataGridView DataGridView7
  {
    [DebuggerNonUserCode] get => this._DataGridView7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView7 = value;
    }
  }

  internal virtual Label lblDateFrom
  {
    [DebuggerNonUserCode] get => this._lblDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateFrom = value;
    }
  }

  internal virtual Label lblDateTo
  {
    [DebuggerNonUserCode] get => this._lblDateTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDateTo = value;
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

  internal virtual DataGridView DataGridView9
  {
    [DebuggerNonUserCode] get => this._DataGridView9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView9 = value;
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

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
  }

  internal virtual TextBox txtbody
  {
    [DebuggerNonUserCode] get => this._txtbody;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtbody = value;
  }

  internal virtual TextBox txtSubject
  {
    [DebuggerNonUserCode] get => this._txtSubject;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtSubject = value;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Button btnSelectAll
  {
    [DebuggerNonUserCode] get => this._btnSelectAll;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelectAll_Click);
      if (this._btnSelectAll != null)
        this._btnSelectAll.Click -= eventHandler;
      this._btnSelectAll = value;
      if (this._btnSelectAll == null)
        return;
      this._btnSelectAll.Click += eventHandler;
    }
  }

  internal virtual Button Button2
  {
    [DebuggerNonUserCode] get => this._Button2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Button2 = value;
  }

  internal virtual ComboBox cmbShowCashBank
  {
    [DebuggerNonUserCode] get => this._cmbShowCashBank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbShowCashBank = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
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

  internal virtual Label lblReportType
  {
    [DebuggerNonUserCode] get => this._lblReportType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblReportType = value;
    }
  }

  internal virtual RadioButton rb9
  {
    [DebuggerNonUserCode] get => this._rb9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb9 = value;
  }

  internal virtual RadioButton rb4
  {
    [DebuggerNonUserCode] get => this._rb4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb4 = value;
  }

  internal virtual RadioButton rb3
  {
    [DebuggerNonUserCode] get => this._rb3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb3 = value;
  }

  internal virtual DataGridView DataGridView10
  {
    [DebuggerNonUserCode] get => this._DataGridView10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView10 = value;
    }
  }

  internal virtual DataGridView DataGridView11
  {
    [DebuggerNonUserCode] get => this._DataGridView11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView11 = value;
    }
  }

  internal virtual GroupBox grpMail
  {
    [DebuggerNonUserCode] get => this._grpMail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpMail = value;
  }

  internal virtual RadioButton rb5
  {
    [DebuggerNonUserCode] get => this._rb5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb5 = value;
  }

  internal virtual RadioButton rb6
  {
    [DebuggerNonUserCode] get => this._rb6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb6 = value;
  }

  internal virtual RadioButton rb10
  {
    [DebuggerNonUserCode] get => this._rb10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb10 = value;
  }

  internal virtual RadioButton rb11
  {
    [DebuggerNonUserCode] get => this._rb11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb11 = value;
  }

  internal virtual RadioButton rb7
  {
    [DebuggerNonUserCode] get => this._rb7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb7 = value;
  }

  internal virtual RadioButton rb8
  {
    [DebuggerNonUserCode] get => this._rb8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb8 = value;
  }

  internal virtual DataGridView DataGridView12
  {
    [DebuggerNonUserCode] get => this._DataGridView12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView12 = value;
    }
  }

  internal virtual RadioButton rb12
  {
    [DebuggerNonUserCode] get => this._rb12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb12 = value;
  }

  internal virtual RadioButton rb13
  {
    [DebuggerNonUserCode] get => this._rb13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb13 = value;
  }

  internal virtual RadioButton rb15
  {
    [DebuggerNonUserCode] get => this._rb15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb15 = value;
  }

  internal virtual RadioButton rb16
  {
    [DebuggerNonUserCode] get => this._rb16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb16 = value;
  }

  internal virtual OpenFileDialog OpenFileDialog1
  {
    [DebuggerNonUserCode] get => this._OpenFileDialog1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._OpenFileDialog1 = value;
    }
  }

  internal virtual DataGridView DataGridView13
  {
    [DebuggerNonUserCode] get => this._DataGridView13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView13 = value;
    }
  }

  internal virtual RadioButton rb17
  {
    [DebuggerNonUserCode] get => this._rb17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb17 = value;
  }

  internal virtual RadioButton rb18
  {
    [DebuggerNonUserCode] get => this._rb18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._rb18 = value;
  }

  internal virtual Label lblMemCodeFrom
  {
    [DebuggerNonUserCode] get => this._lblMemCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemCodeFrom = value;
    }
  }

  internal virtual Label lblMemNameFrom
  {
    [DebuggerNonUserCode] get => this._lblMemNameFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemNameFrom = value;
    }
  }

  internal virtual Label lblMemIdFrom
  {
    [DebuggerNonUserCode] get => this._lblMemIdFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemIdFrom = value;
    }
  }

  internal virtual Label lblMemCodeTo
  {
    [DebuggerNonUserCode] get => this._lblMemCodeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemCodeTo = value;
    }
  }

  internal virtual Label lblMemNameTo
  {
    [DebuggerNonUserCode] get => this._lblMemNameTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemNameTo = value;
    }
  }

  internal virtual Label lblMemIdTo
  {
    [DebuggerNonUserCode] get => this._lblMemIdTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemIdTo = value;
    }
  }

  internal virtual TextBox txtSocMailId
  {
    [DebuggerNonUserCode] get => this._txtSocMailId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtSocMailId = value;
    }
  }

  internal virtual TextBox txtSocMailPass
  {
    [DebuggerNonUserCode] get => this._txtSocMailPass;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtSocMailPass = value;
    }
  }

  internal virtual TextBox txtSendStatus
  {
    [DebuggerNonUserCode] get => this._txtSendStatus;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtSendStatus = value;
    }
  }

  private void frmEmailCommittee_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmEmailCommittee_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.txtbody.Text = "";
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocComm.ID, SocComm.C_MemberName, SocComm.C_MemberDesignation, SocComm.C_FlatNo, SocComm.C_ContactNo, SocComm.C_EmailId FROM SocComm ORDER BY SocComm.C_MemberName", selectConnection);
    DataTable dataTable1 = new DataTable("SocComm");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT * FROM SocEmail", selectConnection);
    DataTable dataTable2 = new DataTable("SocEmail");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView6.DataSource = (object) dataTable2;
    this.DataGridView6.ReadOnly = true;
    this.DataGridView6.RowHeadersVisible = false;
    this.DataGridView6.AllowUserToAddRows = false;
    if (this.DataGridView6.RowCount > 0)
    {
      this.txtSocMailId.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[1].Value);
      this.txtSocMailPass.Text = Conversions.ToString(this.DataGridView6.Rows[0].Cells[2].Value);
      this.txtSendStatus.Text = "No";
    }
    this.DataGridView2.ReadOnly = false;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.Columns.Add((DataGridViewColumn) new DataGridViewCheckBoxColumn());
    this.DataGridView2.ColumnCount = 13;
    this.DataGridView2.Columns[0].HeaderText = "Select";
    this.DataGridView2.Columns[1].HeaderText = "Mail Status";
    this.DataGridView2.Columns[2].HeaderText = "Id";
    this.DataGridView2.Columns[3].HeaderText = "Member Name";
    this.DataGridView2.Columns[4].HeaderText = "Designation";
    this.DataGridView2.Columns[5].HeaderText = "Flat No.";
    this.DataGridView2.Columns[6].HeaderText = "Contact";
    this.DataGridView2.Columns[7].HeaderText = "Email Id";
    this.rk = 0;
    int num = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num)
    {
      this.DataGridView2.Rows.Add();
      int index2 = 0;
      do
      {
        this.DataGridView2.Rows[this.rk].Cells[checked (index2 + 2)].Value = (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim();
        checked { ++index2; }
      }
      while (index2 <= 5);
      checked { ++this.rk; }
      checked { ++index1; }
    }
    int index3 = 1;
    do
    {
      this.DataGridView2.Columns[index3].ReadOnly = true;
      checked { ++index3; }
    }
    while (index3 <= 12);
    this.DataGridView2.ClearSelection();
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnEmail_Click(object sender, EventArgs e)
  {
    this.txtSendStatus.Text = "Yes";
    this.Close();
  }

  private void btnSelectAll_Click(object sender, EventArgs e)
  {
    int num = checked (this.DataGridView2.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView2.Rows[index].Cells[0].Value = (object) true;
      checked { ++index; }
    }
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.txtSendStatus.Text = "No";
    this.Close();
  }
}
