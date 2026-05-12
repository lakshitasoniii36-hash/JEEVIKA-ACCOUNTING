// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatSDetail
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
public class frmStatSDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("txtSdot")]
  private TextBox _txtSdot;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("lblFlatNo")]
  private Label _lblFlatNo;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("lblMname")]
  private Label _lblMname;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("btnList")]
  private Button _btnList;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtspart")]
  private TextBox _txtspart;
  [AccessedThroughProperty("txtsrnotrf")]
  private TextBox _txtsrnotrf;
  [AccessedThroughProperty("txtsamountbal")]
  private TextBox _txtsamountbal;
  [AccessedThroughProperty("txtSharetrf")]
  private TextBox _txtSharetrf;
  [AccessedThroughProperty("txtSamount")]
  private TextBox _txtSamount;
  [AccessedThroughProperty("txtSdop")]
  private TextBox _txtSdop;
  [AccessedThroughProperty("txtshareto")]
  private TextBox _txtshareto;
  [AccessedThroughProperty("txtSharefrom")]
  private TextBox _txtSharefrom;
  [AccessedThroughProperty("txtSDOI")]
  private TextBox _txtSDOI;
  [AccessedThroughProperty("lblId")]
  private Label _lblId;
  [AccessedThroughProperty("txtScertno")]
  private TextBox _txtScertno;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtSsrno")]
  private TextBox _txtSsrno;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtMemId")]
  private TextBox _txtMemId;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtnMemId")]
  private TextBox _txtnMemId;

  [DebuggerNonUserCode]
  static frmStatSDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmStatSDetail()
  {
    this.Load += new EventHandler(this.frmStatSDetail_Load);
    frmStatSDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatSDetail.__ENCList)
    {
      if (frmStatSDetail.__ENCList.Count == frmStatSDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatSDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatSDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatSDetail.__ENCList[index1] = frmStatSDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatSDetail.__ENCList.RemoveRange(index1, checked (frmStatSDetail.__ENCList.Count - index1));
        frmStatSDetail.__ENCList.Capacity = frmStatSDetail.__ENCList.Count;
      }
      frmStatSDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatSDetail));
    this.Label15 = new Label();
    this.txtSdot = new TextBox();
    this.GroupBox1 = new GroupBox();
    this.lblFlatNo = new Label();
    this.Label14 = new Label();
    this.lblMname = new Label();
    this.Label13 = new Label();
    this.btnList = new Button();
    this.DataGridView1 = new DataGridView();
    this.btnCancel = new Button();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label10 = new Label();
    this.Label9 = new Label();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.txtspart = new TextBox();
    this.txtsrnotrf = new TextBox();
    this.txtsamountbal = new TextBox();
    this.txtSharetrf = new TextBox();
    this.txtSamount = new TextBox();
    this.txtSdop = new TextBox();
    this.txtshareto = new TextBox();
    this.txtSharefrom = new TextBox();
    this.txtSDOI = new TextBox();
    this.lblId = new Label();
    this.txtScertno = new TextBox();
    this.Label3 = new Label();
    this.txtSsrno = new TextBox();
    this.Label2 = new Label();
    this.txtMemId = new TextBox();
    this.btnSave = new Button();
    this.Label1 = new Label();
    this.txtnMemId = new TextBox();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.Label15.AutoSize = true;
    Label label15_1 = this.Label15;
    Point point1 = new Point(88, 407);
    Point point2 = point1;
    label15_1.Location = point2;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    Size size1 = new Size(90, 13);
    Size size2 = size1;
    label15_2.Size = size2;
    this.Label15.TabIndex = 210;
    this.Label15.Text = "date of Share Trf.";
    TextBox txtSdot1 = this.txtSdot;
    point1 = new Point(197, 402);
    Point point3 = point1;
    txtSdot1.Location = point3;
    this.txtSdot.Name = "txtSdot";
    TextBox txtSdot2 = this.txtSdot;
    size1 = new Size(303, 20);
    Size size3 = size1;
    txtSdot2.Size = size3;
    this.txtSdot.TabIndex = 188;
    this.GroupBox1.Controls.Add((Control) this.lblFlatNo);
    this.GroupBox1.Controls.Add((Control) this.Label14);
    this.GroupBox1.Controls.Add((Control) this.lblMname);
    this.GroupBox1.Controls.Add((Control) this.Label13);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(197, 96 /*0x60*/);
    Point point4 = point1;
    groupBox1_1.Location = point4;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(303, 39);
    Size size4 = size1;
    groupBox1_2.Size = size4;
    this.GroupBox1.TabIndex = 209;
    this.GroupBox1.TabStop = false;
    this.lblFlatNo.AutoSize = true;
    Label lblFlatNo1 = this.lblFlatNo;
    point1 = new Point(6, 16 /*0x10*/);
    Point point5 = point1;
    lblFlatNo1.Location = point5;
    this.lblFlatNo.Name = "lblFlatNo";
    Label lblFlatNo2 = this.lblFlatNo;
    size1 = new Size(10, 13);
    Size size5 = size1;
    lblFlatNo2.Size = size5;
    this.lblFlatNo.TabIndex = 172;
    this.lblFlatNo.Text = "-";
    this.Label14.AutoSize = true;
    Label label14_1 = this.Label14;
    point1 = new Point(77, 2);
    Point point6 = point1;
    label14_1.Location = point6;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(35, 13);
    Size size6 = size1;
    label14_2.Size = size6;
    this.Label14.TabIndex = 174;
    this.Label14.Text = "Name";
    this.lblMname.AutoSize = true;
    Label lblMname1 = this.lblMname;
    point1 = new Point(78, 16 /*0x10*/);
    Point point7 = point1;
    lblMname1.Location = point7;
    this.lblMname.Name = "lblMname";
    Label lblMname2 = this.lblMname;
    size1 = new Size(10, 13);
    Size size7 = size1;
    lblMname2.Size = size7;
    this.lblMname.TabIndex = 171;
    this.lblMname.Text = "-";
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(6, 2);
    Point point8 = point1;
    label13_1.Location = point8;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(44, 13);
    Size size8 = size1;
    label13_2.Size = size8;
    this.Label13.TabIndex = 173;
    this.Label13.Text = "Flat No.";
    this.btnList.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnList1 = this.btnList;
    point1 = new Point(482, 75);
    Point point9 = point1;
    btnList1.Location = point9;
    this.btnList.Name = "btnList";
    Button btnList2 = this.btnList;
    size1 = new Size(18, 21);
    Size size9 = size1;
    btnList2.Size = size9;
    this.btnList.TabIndex = 179;
    this.btnList.Text = "v";
    this.btnList.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(124, 30);
    Point point10 = point1;
    dataGridView1_1.Location = point10;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 14);
    Size size10 = size1;
    dataGridView1_2.Size = size10;
    this.DataGridView1.TabIndex = 208 /*0xD0*/;
    this.DataGridView1.Visible = false;
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(307, 504);
    Point point11 = point1;
    btnCancel1.Location = point11;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size11 = size1;
    btnCancel2.Size = size11;
    this.btnCancel.TabIndex = 193;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(88, 312);
    Point point12 = point1;
    label11_1.Location = point12;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(86, 13);
    Size size12 = size1;
    label11_2.Size = size12;
    this.Label11.TabIndex = 207;
    this.Label11.Text = "Date of Payment";
    this.Label12.AutoSize = true;
    Label label12_1 = this.Label12;
    point1 = new Point(88, 482);
    Point point13 = point1;
    label12_1.Location = point13;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(44, 13);
    Size size13 = size1;
    label12_2.Size = size13;
    this.Label12.TabIndex = 206;
    this.Label12.Text = "Remark";
    this.Label10.AutoSize = true;
    Label label10_1 = this.Label10;
    point1 = new Point(88, 427);
    Point point14 = point1;
    label10_1.Location = point14;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(86, 13);
    Size size14 = size1;
    label10_2.Size = size14;
    this.Label10.TabIndex = 205;
    this.Label10.Text = "No. of Share Trf.";
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(88, 375);
    Point point15 = point1;
    label9_1.Location = point15;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(85, 13);
    Size size15 = size1;
    label9_2.Size = size15;
    this.Label9.TabIndex = 204;
    this.Label9.Text = "Amount Balance";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(88, 448);
    Point point16 = point1;
    label8_1.Location = point16;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(74, 13);
    Size size16 = size1;
    label8_2.Size = size16;
    this.Label8.TabIndex = 203;
    this.Label8.Text = "Trf. Share No.";
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(88, 346);
    Point point17 = point1;
    label7_1.Location = point17;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(43, 13);
    Size size17 = size1;
    label7_2.Size = size17;
    this.Label7.TabIndex = 202;
    this.Label7.Text = "Amount";
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(88, 278);
    Point point18 = point1;
    label6_1.Location = point18;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(40, 13);
    Size size18 = size1;
    label6_2.Size = size18;
    this.Label6.TabIndex = 201;
    this.Label6.Text = "No. To";
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(88, 244);
    Point point19 = point1;
    label5_1.Location = point19;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(50, 13);
    Size size19 = size1;
    label5_2.Size = size19;
    this.Label5.TabIndex = 200;
    this.Label5.Text = "No. From";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(88, 210);
    Point point20 = point1;
    label4_1.Location = point20;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(58, 13);
    Size size20 = size1;
    label4_2.Size = size20;
    this.Label4.TabIndex = 199;
    this.Label4.Text = "Issue Date";
    TextBox txtspart1 = this.txtspart;
    point1 = new Point(197, 479);
    Point point21 = point1;
    txtspart1.Location = point21;
    this.txtspart.Name = "txtspart";
    TextBox txtspart2 = this.txtspart;
    size1 = new Size(303, 20);
    Size size21 = size1;
    txtspart2.Size = size21;
    this.txtspart.TabIndex = 191;
    TextBox txtsrnotrf1 = this.txtsrnotrf;
    point1 = new Point(197, 445);
    Point point22 = point1;
    txtsrnotrf1.Location = point22;
    this.txtsrnotrf.Name = "txtsrnotrf";
    TextBox txtsrnotrf2 = this.txtsrnotrf;
    size1 = new Size(303, 20);
    Size size22 = size1;
    txtsrnotrf2.Size = size22;
    this.txtsrnotrf.TabIndex = 190;
    this.txtsrnotrf.Text = "0";
    TextBox txtsamountbal1 = this.txtsamountbal;
    point1 = new Point(197, 372);
    Point point23 = point1;
    txtsamountbal1.Location = point23;
    this.txtsamountbal.Name = "txtsamountbal";
    TextBox txtsamountbal2 = this.txtsamountbal;
    size1 = new Size(303, 20);
    Size size23 = size1;
    txtsamountbal2.Size = size23;
    this.txtsamountbal.TabIndex = 187;
    this.txtsamountbal.Text = "0";
    TextBox txtSharetrf1 = this.txtSharetrf;
    point1 = new Point(197, 424);
    Point point24 = point1;
    txtSharetrf1.Location = point24;
    this.txtSharetrf.Name = "txtSharetrf";
    TextBox txtSharetrf2 = this.txtSharetrf;
    size1 = new Size(303, 20);
    Size size24 = size1;
    txtSharetrf2.Size = size24;
    this.txtSharetrf.TabIndex = 189;
    TextBox txtSamount1 = this.txtSamount;
    point1 = new Point(197, 343);
    Point point25 = point1;
    txtSamount1.Location = point25;
    this.txtSamount.Name = "txtSamount";
    TextBox txtSamount2 = this.txtSamount;
    size1 = new Size(303, 20);
    Size size25 = size1;
    txtSamount2.Size = size25;
    this.txtSamount.TabIndex = 186;
    this.txtSamount.Text = "0";
    TextBox txtSdop1 = this.txtSdop;
    point1 = new Point(197, 309);
    Point point26 = point1;
    txtSdop1.Location = point26;
    this.txtSdop.Name = "txtSdop";
    TextBox txtSdop2 = this.txtSdop;
    size1 = new Size(303, 20);
    Size size26 = size1;
    txtSdop2.Size = size26;
    this.txtSdop.TabIndex = 185;
    TextBox txtshareto1 = this.txtshareto;
    point1 = new Point(197, 275);
    Point point27 = point1;
    txtshareto1.Location = point27;
    this.txtshareto.Name = "txtshareto";
    TextBox txtshareto2 = this.txtshareto;
    size1 = new Size(303, 20);
    Size size27 = size1;
    txtshareto2.Size = size27;
    this.txtshareto.TabIndex = 184;
    this.txtshareto.Text = "0";
    TextBox txtSharefrom1 = this.txtSharefrom;
    point1 = new Point(197, 241);
    Point point28 = point1;
    txtSharefrom1.Location = point28;
    this.txtSharefrom.Name = "txtSharefrom";
    TextBox txtSharefrom2 = this.txtSharefrom;
    size1 = new Size(303, 20);
    Size size28 = size1;
    txtSharefrom2.Size = size28;
    this.txtSharefrom.TabIndex = 183;
    this.txtSharefrom.Text = "0";
    TextBox txtSdoi1 = this.txtSDOI;
    point1 = new Point(197, 207);
    Point point29 = point1;
    txtSdoi1.Location = point29;
    this.txtSDOI.Name = "txtSDOI";
    TextBox txtSdoi2 = this.txtSDOI;
    size1 = new Size(303, 20);
    Size size29 = size1;
    txtSdoi2.Size = size29;
    this.txtSDOI.TabIndex = 182;
    this.lblId.AutoSize = true;
    Label lblId1 = this.lblId;
    point1 = new Point(304, 38);
    Point point30 = point1;
    lblId1.Location = point30;
    this.lblId.Name = "lblId";
    Label lblId2 = this.lblId;
    size1 = new Size(39, 13);
    Size size30 = size1;
    lblId2.Size = size30;
    this.lblId.TabIndex = 198;
    this.lblId.Text = "Label8";
    this.lblId.Visible = false;
    TextBox txtScertno1 = this.txtScertno;
    point1 = new Point(197, 173);
    Point point31 = point1;
    txtScertno1.Location = point31;
    this.txtScertno.Name = "txtScertno";
    TextBox txtScertno2 = this.txtScertno;
    size1 = new Size(303, 20);
    Size size31 = size1;
    txtScertno2.Size = size31;
    this.txtScertno.TabIndex = 181;
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(88, 176 /*0xB0*/);
    Point point32 = point1;
    label3_1.Location = point32;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(77, 13);
    Size size32 = size1;
    label3_2.Size = size32;
    this.Label3.TabIndex = 197;
    this.Label3.Text = "Share Cert.No.";
    TextBox txtSsrno1 = this.txtSsrno;
    point1 = new Point(197, 139);
    Point point33 = point1;
    txtSsrno1.Location = point33;
    this.txtSsrno.Name = "txtSsrno";
    TextBox txtSsrno2 = this.txtSsrno;
    size1 = new Size(303, 20);
    Size size33 = size1;
    txtSsrno2.Size = size33;
    this.txtSsrno.TabIndex = 180;
    this.txtSsrno.Text = "0";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(88, 142);
    Point point34 = point1;
    label2_1.Location = point34;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(68, 13);
    Size size34 = size1;
    label2_2.Size = size34;
    this.Label2.TabIndex = 196;
    this.Label2.Text = "Share Sr.No.";
    TextBox txtMemId1 = this.txtMemId;
    point1 = new Point(482, 53);
    Point point35 = point1;
    txtMemId1.Location = point35;
    this.txtMemId.Name = "txtMemId";
    TextBox txtMemId2 = this.txtMemId;
    size1 = new Size(22, 20);
    Size size35 = size1;
    txtMemId2.Size = size35;
    this.txtMemId.TabIndex = 195;
    this.txtMemId.Visible = false;
    Button btnSave1 = this.btnSave;
    point1 = new Point(188, 504);
    Point point36 = point1;
    btnSave1.Location = point36;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size36 = size1;
    btnSave2.Size = size36;
    this.btnSave.TabIndex = 192 /*0xC0*/;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(88, 75);
    Point point37 = point1;
    label1_1.Location = point37;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(50, 13);
    Size size37 = size1;
    label1_2.Size = size37;
    this.Label1.TabIndex = 194;
    this.Label1.Text = "Mem No.";
    this.txtnMemId.Enabled = false;
    TextBox txtnMemId1 = this.txtnMemId;
    point1 = new Point(197, 75);
    Point point38 = point1;
    txtnMemId1.Location = point38;
    this.txtnMemId.Name = "txtnMemId";
    TextBox txtnMemId2 = this.txtnMemId;
    size1 = new Size(303, 20);
    Size size38 = size1;
    txtnMemId2.Size = size38;
    this.txtnMemId.TabIndex = 178;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label15);
    this.Controls.Add((Control) this.txtSdot);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.btnList);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtspart);
    this.Controls.Add((Control) this.txtsrnotrf);
    this.Controls.Add((Control) this.txtsamountbal);
    this.Controls.Add((Control) this.txtSharetrf);
    this.Controls.Add((Control) this.txtSamount);
    this.Controls.Add((Control) this.txtSdop);
    this.Controls.Add((Control) this.txtshareto);
    this.Controls.Add((Control) this.txtSharefrom);
    this.Controls.Add((Control) this.txtSDOI);
    this.Controls.Add((Control) this.lblId);
    this.Controls.Add((Control) this.txtScertno);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.txtSsrno);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtMemId);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtnMemId);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatSDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmStatSDetail);
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual TextBox txtSdot
  {
    [DebuggerNonUserCode] get => this._txtSdot;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSdot_KeyDown);
      if (this._txtSdot != null)
        this._txtSdot.KeyDown -= keyEventHandler;
      this._txtSdot = value;
      if (this._txtSdot == null)
        return;
      this._txtSdot.KeyDown += keyEventHandler;
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

  internal virtual Label lblFlatNo
  {
    [DebuggerNonUserCode] get => this._lblFlatNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFlatNo = value;
    }
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual Label lblMname
  {
    [DebuggerNonUserCode] get => this._lblMname;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMname = value;
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Button btnList
  {
    [DebuggerNonUserCode] get => this._btnList;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnList_Click);
      if (this._btnList != null)
        this._btnList.Click -= eventHandler;
      this._btnList = value;
      if (this._btnList == null)
        return;
      this._btnList.Click += eventHandler;
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

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox txtspart
  {
    [DebuggerNonUserCode] get => this._txtspart;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtspart_KeyDown);
      if (this._txtspart != null)
        this._txtspart.KeyDown -= keyEventHandler;
      this._txtspart = value;
      if (this._txtspart == null)
        return;
      this._txtspart.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtsrnotrf
  {
    [DebuggerNonUserCode] get => this._txtsrnotrf;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtsrnotrf_KeyDown);
      if (this._txtsrnotrf != null)
        this._txtsrnotrf.KeyDown -= keyEventHandler;
      this._txtsrnotrf = value;
      if (this._txtsrnotrf == null)
        return;
      this._txtsrnotrf.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtsamountbal
  {
    [DebuggerNonUserCode] get => this._txtsamountbal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtsamountbal_KeyDown);
      if (this._txtsamountbal != null)
        this._txtsamountbal.KeyDown -= keyEventHandler;
      this._txtsamountbal = value;
      if (this._txtsamountbal == null)
        return;
      this._txtsamountbal.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtSharetrf
  {
    [DebuggerNonUserCode] get => this._txtSharetrf;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSharetrf_KeyDown);
      if (this._txtSharetrf != null)
        this._txtSharetrf.KeyDown -= keyEventHandler;
      this._txtSharetrf = value;
      if (this._txtSharetrf == null)
        return;
      this._txtSharetrf.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtSamount
  {
    [DebuggerNonUserCode] get => this._txtSamount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSamount_KeyDown);
      if (this._txtSamount != null)
        this._txtSamount.KeyDown -= keyEventHandler;
      this._txtSamount = value;
      if (this._txtSamount == null)
        return;
      this._txtSamount.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtSdop
  {
    [DebuggerNonUserCode] get => this._txtSdop;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSdop_KeyDown);
      if (this._txtSdop != null)
        this._txtSdop.KeyDown -= keyEventHandler;
      this._txtSdop = value;
      if (this._txtSdop == null)
        return;
      this._txtSdop.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtshareto
  {
    [DebuggerNonUserCode] get => this._txtshareto;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtshareto_KeyDown);
      if (this._txtshareto != null)
        this._txtshareto.KeyDown -= keyEventHandler;
      this._txtshareto = value;
      if (this._txtshareto == null)
        return;
      this._txtshareto.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtSharefrom
  {
    [DebuggerNonUserCode] get => this._txtSharefrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSharefrom_KeyDown);
      if (this._txtSharefrom != null)
        this._txtSharefrom.KeyDown -= keyEventHandler;
      this._txtSharefrom = value;
      if (this._txtSharefrom == null)
        return;
      this._txtSharefrom.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtSDOI
  {
    [DebuggerNonUserCode] get => this._txtSDOI;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSDOI_KeyDown);
      if (this._txtSDOI != null)
        this._txtSDOI.KeyDown -= keyEventHandler;
      this._txtSDOI = value;
      if (this._txtSDOI == null)
        return;
      this._txtSDOI.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label lblId
  {
    [DebuggerNonUserCode] get => this._lblId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblId = value;
  }

  internal virtual TextBox txtScertno
  {
    [DebuggerNonUserCode] get => this._txtScertno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtScertno_KeyDown);
      if (this._txtScertno != null)
        this._txtScertno.KeyDown -= keyEventHandler;
      this._txtScertno = value;
      if (this._txtScertno == null)
        return;
      this._txtScertno.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual TextBox txtSsrno
  {
    [DebuggerNonUserCode] get => this._txtSsrno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSsrno_KeyDown);
      if (this._txtSsrno != null)
        this._txtSsrno.KeyDown -= keyEventHandler;
      this._txtSsrno = value;
      if (this._txtSsrno == null)
        return;
      this._txtSsrno.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual TextBox txtMemId
  {
    [DebuggerNonUserCode] get => this._txtMemId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtMemId = value;
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox txtnMemId
  {
    [DebuggerNonUserCode] get => this._txtnMemId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtnMemId_KeyDown);
      if (this._txtnMemId != null)
        this._txtnMemId.KeyDown -= keyEventHandler;
      this._txtnMemId = value;
      if (this._txtnMemId == null)
        return;
      this._txtnMemId.KeyDown += keyEventHandler;
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    string cmdText = "";
    string Prompt = "";
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    connection.Open();
    if (!Versioned.IsNumeric((object) this.txtSsrno.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSsrno.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtSsrno.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtSharefrom.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSharefrom.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtSharefrom.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtshareto.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtshareto.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtshareto.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtSamount.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSamount.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtSamount.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtsamountbal.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtsamountbal.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtsamountbal.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtsrnotrf.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtsrnotrf.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtsrnotrf.Focus();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemId.Text.Trim(), "", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Member Name not Matched or Blank");
      this.txtnMemId.Focus();
    }
    else
    {
      this.txtScertno.Text = this.txtScertno.Text.ToString().Replace("'", "''");
      this.txtSDOI.Text = this.txtSDOI.Text.ToString().Replace("'", "''");
      this.txtSdop.Text = this.txtSdop.Text.ToString().Replace("'", "''");
      this.txtSharetrf.Text = this.txtSharetrf.Text.ToString().Replace("'", "''");
      this.txtspart.Text = this.txtspart.Text.ToString().Replace("'", "''");
      this.txtSdot.Text = this.txtSdot.Text.ToString().Replace("'", "''");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        cmdText = $"Insert Into SReg (Ssrno, MemId, Scertno, SDOI, Sharefrom, shareto, Sdop, Samount, Sharetrf, samountbal, srnotrf, spart, sdot ) values ('{Conversions.ToString(Conversion.Val(this.txtSsrno.Text.Trim()))}','{Conversions.ToString(Conversion.Val(this.txtMemId.Text.Trim()))}','{this.txtScertno.Text.Trim()}','{this.txtSDOI.Text.Trim()}','{Conversions.ToString(Conversion.Val(this.txtSharefrom.Text.Trim()))}','{Conversions.ToString(Conversion.Val(this.txtshareto.Text.Trim()))}','{this.txtSdop.Text.Trim()}','{Conversions.ToString(Conversion.Val(this.txtSamount.Text.Trim()))}','{this.txtSharetrf.Text.Trim()}','{Conversions.ToString(Conversion.Val(this.txtsamountbal.Text.Trim()))}','{Conversions.ToString(Conversion.Val(this.txtsrnotrf.Text.Trim()))}','{this.txtspart.Text.Trim()}','{this.txtSdot.Text.Trim()}')";
        Prompt = "Share Entry Added Successful";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        cmdText = $"update SReg set Ssrno ='{Conversions.ToString(Conversion.Val(this.txtSsrno.Text.Trim()))}' ,MemId ='{Conversions.ToString(Conversion.Val(this.txtMemId.Text.Trim()))}' ,Scertno ='{this.txtScertno.Text.Trim()}',SDOI ='{this.txtSDOI.Text.Trim()}',Sharefrom ='{Conversions.ToString(Conversion.Val(this.txtSharefrom.Text.Trim()))}',shareto ='{Conversions.ToString(Conversion.Val(this.txtshareto.Text.Trim()))}',Sdop ='{this.txtSdop.Text.Trim()}',Samount ='{Conversions.ToString(Conversion.Val(this.txtSamount.Text.Trim()))}',Sharetrf ='{this.txtSharetrf.Text.Trim()}',samountbal ='{Conversions.ToString(Conversion.Val(this.txtsamountbal.Text.Trim()))}',srnotrf ='{Conversions.ToString(Conversion.Val(this.txtsrnotrf.Text.Trim()))}',spart ='{this.txtspart.Text.Trim()}',sdot ='{this.txtSdot.Text.Trim()}'   where Id ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}";
        Prompt = "Share Entry Updated Successful";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 && Interaction.MsgBox((object) ("Are you Sure you want to Delete Share Entry " + this.txtSsrno.Text), MsgBoxStyle.YesNo, (object) "!!! WARNING... !!!") == MsgBoxResult.Yes)
      {
        cmdText = $"Delete From SReg where Id ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}";
        Prompt = "Share Entry deleted Successful";
      }
      OleDbCommand oleDbCommand = new OleDbCommand(cmdText, connection);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Prompt.ToString(), "", false) != 0)
      {
        oleDbCommand.ExecuteNonQuery();
        int num = (int) Interaction.MsgBox((object) Prompt);
      }
      connection.Close();
      this.Close();
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void frmStatSDetail_Load(object sender, EventArgs e)
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select MemRegn,FlatNo,MemName,MemId from Member order by MemId asc", selectConnection);
    DataTable dataTable = new DataTable("Member");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.Columns[0].Width = 100;
    this.DataGridView1.Columns[1].Width = 100;
    this.DataGridView1.Columns[2].Width = 200;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
  }

  private void btnList_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmListCall.txtComMemcode.Text = this.txtnMemId.Text;
    MyProject.Forms.frmListCall.lblStatus.Text = "Exit";
    int num = (int) MyProject.Forms.frmListCall.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmListCall.lblStatus.Text, "Select", false) == 0)
    {
      this.txtnMemId.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[0].Value.ToString();
      this.txtMemId.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[3].Value.ToString();
      this.lblFlatNo.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[1].Value.ToString();
      this.lblMname.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    }
    MyProject.Forms.frmListCall = (frmListCall) null;
    this.txtSsrno.Focus();
  }

  private void txtnMemId_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.F5)
      return;
    int num = (int) MyProject.Forms.frmListCall.ShowDialog();
    this.txtnMemId.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    this.txtMemId.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    this.lblFlatNo.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    this.lblMname.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    MyProject.Forms.frmListCall = (frmListCall) null;
    this.txtSsrno.Focus();
  }

  private void txtSsrno_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtScertno.Focus();
  }

  private void txtScertno_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSDOI.Focus();
  }

  private void txtSDOI_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSharefrom.Focus();
  }

  private void txtSharefrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtshareto.Focus();
  }

  private void txtshareto_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSdop.Focus();
  }

  private void txtSdop_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSamount.Focus();
  }

  private void txtSamount_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtsamountbal.Focus();
  }

  private void txtsamountbal_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSdot.Focus();
  }

  private void txtSdot_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSharetrf.Focus();
  }

  private void txtSharetrf_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtsrnotrf.Focus();
  }

  private void txtsrnotrf_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtspart.Focus();
  }

  private void txtspart_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
