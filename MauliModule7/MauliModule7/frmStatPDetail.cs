// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatPDetail
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
public class frmStatPDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnList")]
  private Button _btnList;
  [AccessedThroughProperty("lblFlatNo")]
  private Label _lblFlatNo;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("lblMname")]
  private Label _lblMname;
  [AccessedThroughProperty("lblMno")]
  private Label _lblMno;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("txtTitleOccupancy")]
  private TextBox _txtTitleOccupancy;
  [AccessedThroughProperty("txtDOC")]
  private TextBox _txtDOC;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtRemark")]
  private TextBox _txtRemark;
  [AccessedThroughProperty("txtDOM")]
  private TextBox _txtDOM;
  [AccessedThroughProperty("txtcostsize")]
  private TextBox _txtcostsize;
  [AccessedThroughProperty("txtcostbldg")]
  private TextBox _txtcostbldg;
  [AccessedThroughProperty("txtAnnualRent")]
  private TextBox _txtAnnualRent;
  [AccessedThroughProperty("txtOccupancy")]
  private TextBox _txtOccupancy;
  [AccessedThroughProperty("txtDisFloor")]
  private TextBox _txtDisFloor;
  [AccessedThroughProperty("txtDisNo")]
  private TextBox _txtDisNo;
  [AccessedThroughProperty("txtAnnualgrrent")]
  private TextBox _txtAnnualgrrent;
  [AccessedThroughProperty("txtrentpaidyear")]
  private TextBox _txtrentpaidyear;
  [AccessedThroughProperty("TxtTenure")]
  private TextBox _TxtTenure;
  [AccessedThroughProperty("txtcitySurveyno")]
  private TextBox _txtcitySurveyno;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("lblId")]
  private Label _lblId;
  [AccessedThroughProperty("txtsurveyno")]
  private TextBox _txtsurveyno;
  [AccessedThroughProperty("txtPsrno")]
  private TextBox _txtPsrno;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("txtMemId")]
  private TextBox _txtMemId;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;

  [DebuggerNonUserCode]
  static frmStatPDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmStatPDetail()
  {
    this.Load += new EventHandler(this.frmStatPDetail_Load);
    frmStatPDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatPDetail.__ENCList)
    {
      if (frmStatPDetail.__ENCList.Count == frmStatPDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatPDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatPDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatPDetail.__ENCList[index1] = frmStatPDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatPDetail.__ENCList.RemoveRange(index1, checked (frmStatPDetail.__ENCList.Count - index1));
        frmStatPDetail.__ENCList.Capacity = frmStatPDetail.__ENCList.Count;
      }
      frmStatPDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatPDetail));
    this.btnList = new Button();
    this.lblFlatNo = new Label();
    this.DataGridView1 = new DataGridView();
    this.lblMname = new Label();
    this.lblMno = new Label();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.txtTitleOccupancy = new TextBox();
    this.txtDOC = new TextBox();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.txtRemark = new TextBox();
    this.txtDOM = new TextBox();
    this.txtcostsize = new TextBox();
    this.txtcostbldg = new TextBox();
    this.txtAnnualRent = new TextBox();
    this.txtOccupancy = new TextBox();
    this.txtDisFloor = new TextBox();
    this.txtDisNo = new TextBox();
    this.txtAnnualgrrent = new TextBox();
    this.txtrentpaidyear = new TextBox();
    this.TxtTenure = new TextBox();
    this.txtcitySurveyno = new TextBox();
    this.btnUpdate = new Button();
    this.lblId = new Label();
    this.txtsurveyno = new TextBox();
    this.txtPsrno = new TextBox();
    this.btnCancel = new Button();
    this.txtMemId = new TextBox();
    this.Label1 = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.btnList.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnList1 = this.btnList;
    Point point1 = new Point(471, 68);
    Point point2 = point1;
    btnList1.Location = point2;
    this.btnList.Name = "btnList";
    Button btnList2 = this.btnList;
    Size size1 = new Size(18, 22);
    Size size2 = size1;
    btnList2.Size = size2;
    this.btnList.TabIndex = 169;
    this.btnList.Text = "v";
    this.btnList.UseVisualStyleBackColor = true;
    this.lblFlatNo.AutoSize = true;
    Label lblFlatNo1 = this.lblFlatNo;
    point1 = new Point(184, 93);
    Point point3 = point1;
    lblFlatNo1.Location = point3;
    this.lblFlatNo.Name = "lblFlatNo";
    Label lblFlatNo2 = this.lblFlatNo;
    size1 = new Size(39, 13);
    Size size3 = size1;
    lblFlatNo2.Size = size3;
    this.lblFlatNo.TabIndex = 209;
    this.lblFlatNo.Text = "Label8";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(110, 33);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(57, 24);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 208 /*0xD0*/;
    this.DataGridView1.Visible = false;
    this.lblMname.AutoSize = true;
    Label lblMname1 = this.lblMname;
    point1 = new Point(229, 93);
    Point point5 = point1;
    lblMname1.Location = point5;
    this.lblMname.Name = "lblMname";
    Label lblMname2 = this.lblMname;
    size1 = new Size(39, 13);
    Size size5 = size1;
    lblMname2.Size = size5;
    this.lblMname.TabIndex = 207;
    this.lblMname.Text = "Label8";
    this.lblMno.AutoSize = true;
    Label lblMno1 = this.lblMno;
    point1 = new Point(491, 77);
    Point point6 = point1;
    lblMno1.Location = point6;
    this.lblMno.Name = "lblMno";
    Label lblMno2 = this.lblMno;
    size1 = new Size(39, 13);
    Size size6 = size1;
    lblMno2.Size = size6;
    this.lblMno.TabIndex = 206;
    this.lblMno.Text = "Label8";
    this.Label16.AutoSize = true;
    Label label16_1 = this.Label16;
    point1 = new Point(63 /*0x3F*/, 313);
    Point point7 = point1;
    label16_1.Location = point7;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(97, 13);
    Size size7 = size1;
    label16_2.Size = size7;
    this.Label16.TabIndex = 205;
    this.Label16.Text = "Title of Occupancy";
    this.Label17.AutoSize = true;
    Label label17_1 = this.Label17;
    point1 = new Point(63 /*0x3F*/, 413);
    Point point8 = point1;
    label17_1.Location = point8;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(95, 13);
    Size size8 = size1;
    label17_2.Size = size8;
    this.Label17.TabIndex = 204;
    this.Label17.Text = "Date of Completed";
    TextBox txtTitleOccupancy1 = this.txtTitleOccupancy;
    point1 = new Point(186, 310);
    Point point9 = point1;
    txtTitleOccupancy1.Location = point9;
    this.txtTitleOccupancy.Name = "txtTitleOccupancy";
    TextBox txtTitleOccupancy2 = this.txtTitleOccupancy;
    size1 = new Size(303, 20);
    Size size9 = size1;
    txtTitleOccupancy2.Size = size9;
    this.txtTitleOccupancy.TabIndex = 178;
    TextBox txtDoc1 = this.txtDOC;
    point1 = new Point(186, 410);
    Point point10 = point1;
    txtDoc1.Location = point10;
    this.txtDOC.Name = "txtDOC";
    TextBox txtDoc2 = this.txtDOC;
    size1 = new Size(303, 20);
    Size size10 = size1;
    txtDoc2.Size = size10;
    this.txtDOC.TabIndex = 182;
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(63 /*0x3F*/, 463);
    Point point11 = point1;
    label11_1.Location = point11;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(49, 13);
    Size size11 = size1;
    label11_2.Size = size11;
    this.Label11.TabIndex = 203;
    this.Label11.Text = "Remarks";
    this.Label12.AutoSize = true;
    Label label12_1 = this.Label12;
    point1 = new Point(63 /*0x3F*/, 438);
    Point point12 = point1;
    label12_1.Location = point12;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(92, 13);
    Size size12 = size1;
    label12_2.Size = size12;
    this.Label12.TabIndex = 202;
    this.Label12.Text = "Date of Mutuation";
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(63 /*0x3F*/, 388);
    Point point13 = point1;
    label13_1.Location = point13;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(61, 13);
    Size size13 = size1;
    label13_2.Size = size13;
    this.Label13.TabIndex = 201;
    this.Label13.Text = "House Size";
    this.Label14.AutoSize = true;
    Label label14_1 = this.Label14;
    point1 = new Point(63 /*0x3F*/, 363);
    Point point14 = point1;
    label14_1.Location = point14;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(62, 13);
    Size size14 = size1;
    label14_2.Size = size14;
    this.Label14.TabIndex = 200;
    this.Label14.Text = "House Cost";
    this.Label15.AutoSize = true;
    Label label15_1 = this.Label15;
    point1 = new Point(63 /*0x3F*/, 338);
    Point point15 = point1;
    label15_1.Location = point15;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(69, 13);
    Size size15 = size1;
    label15_2.Size = size15;
    this.Label15.TabIndex = 199;
    this.Label15.Text = "Annual Rent.";
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(63 /*0x3F*/, 288);
    Point point16 = point1;
    label6_1.Location = point16;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(92, 13);
    Size size16 = size1;
    label6_2.Size = size16;
    this.Label6.TabIndex = 198;
    this.Label6.Text = "Occupant's Name";
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(63 /*0x3F*/, 263);
    Point point17 = point1;
    label7_1.Location = point17;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(30, 13);
    Size size17 = size1;
    label7_2.Size = size17;
    this.Label7.TabIndex = 197;
    this.Label7.Text = "Floor";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(63 /*0x3F*/, 238);
    Point point18 = point1;
    label8_1.Location = point18;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(44, 13);
    Size size18 = size1;
    label8_2.Size = size18;
    this.Label8.TabIndex = 196;
    this.Label8.Text = "Flat No.";
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(63 /*0x3F*/, 213);
    Point point19 = point1;
    label9_1.Location = point19;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(104, 13);
    Size size19 = size1;
    label9_2.Size = size19;
    this.Label9.TabIndex = 195;
    this.Label9.Text = "Annual Ground Rent";
    this.Label10.AutoSize = true;
    Label label10_1 = this.Label10;
    point1 = new Point(63 /*0x3F*/, 188);
    Point point20 = point1;
    label10_1.Location = point20;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(77, 13);
    Size size20 = size1;
    label10_2.Size = size20;
    this.Label10.TabIndex = 194;
    this.Label10.Text = "Rent Paid from";
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(63 /*0x3F*/, 163);
    Point point21 = point1;
    label5_1.Location = point21;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(41, 13);
    Size size21 = size1;
    label5_2.Size = size21;
    this.Label5.TabIndex = 193;
    this.Label5.Text = "Tenure";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(63 /*0x3F*/, 138);
    Point point22 = point1;
    label4_1.Location = point22;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(80 /*0x50*/, 13);
    Size size22 = size1;
    label4_2.Size = size22;
    this.Label4.TabIndex = 192 /*0xC0*/;
    this.Label4.Text = "City Survey No.";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(63 /*0x3F*/, 113);
    Point point23 = point1;
    label3_1.Location = point23;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(60, 13);
    Size size23 = size1;
    label3_2.Size = size23;
    this.Label3.TabIndex = 191;
    this.Label3.Text = "Survey No.";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(63 /*0x3F*/, 49);
    Point point24 = point1;
    label2_1.Location = point24;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(47, 13);
    Size size24 = size1;
    label2_2.Size = size24;
    this.Label2.TabIndex = 190;
    this.Label2.Text = "P.Sr.No.";
    TextBox txtRemark1 = this.txtRemark;
    point1 = new Point(186, 460);
    Point point25 = point1;
    txtRemark1.Location = point25;
    this.txtRemark.Name = "txtRemark";
    TextBox txtRemark2 = this.txtRemark;
    size1 = new Size(303, 20);
    Size size25 = size1;
    txtRemark2.Size = size25;
    this.txtRemark.TabIndex = 184;
    TextBox txtDom1 = this.txtDOM;
    point1 = new Point(186, 435);
    Point point26 = point1;
    txtDom1.Location = point26;
    this.txtDOM.Name = "txtDOM";
    TextBox txtDom2 = this.txtDOM;
    size1 = new Size(303, 20);
    Size size26 = size1;
    txtDom2.Size = size26;
    this.txtDOM.TabIndex = 183;
    TextBox txtcostsize1 = this.txtcostsize;
    point1 = new Point(186, 385);
    Point point27 = point1;
    txtcostsize1.Location = point27;
    this.txtcostsize.Name = "txtcostsize";
    TextBox txtcostsize2 = this.txtcostsize;
    size1 = new Size(303, 20);
    Size size27 = size1;
    txtcostsize2.Size = size27;
    this.txtcostsize.TabIndex = 181;
    TextBox txtcostbldg1 = this.txtcostbldg;
    point1 = new Point(186, 360);
    Point point28 = point1;
    txtcostbldg1.Location = point28;
    this.txtcostbldg.Name = "txtcostbldg";
    TextBox txtcostbldg2 = this.txtcostbldg;
    size1 = new Size(303, 20);
    Size size28 = size1;
    txtcostbldg2.Size = size28;
    this.txtcostbldg.TabIndex = 180;
    TextBox txtAnnualRent1 = this.txtAnnualRent;
    point1 = new Point(186, 335);
    Point point29 = point1;
    txtAnnualRent1.Location = point29;
    this.txtAnnualRent.Name = "txtAnnualRent";
    TextBox txtAnnualRent2 = this.txtAnnualRent;
    size1 = new Size(303, 20);
    Size size29 = size1;
    txtAnnualRent2.Size = size29;
    this.txtAnnualRent.TabIndex = 179;
    TextBox txtOccupancy1 = this.txtOccupancy;
    point1 = new Point(186, 285);
    Point point30 = point1;
    txtOccupancy1.Location = point30;
    this.txtOccupancy.Name = "txtOccupancy";
    TextBox txtOccupancy2 = this.txtOccupancy;
    size1 = new Size(303, 20);
    Size size30 = size1;
    txtOccupancy2.Size = size30;
    this.txtOccupancy.TabIndex = 177;
    TextBox txtDisFloor1 = this.txtDisFloor;
    point1 = new Point(186, 260);
    Point point31 = point1;
    txtDisFloor1.Location = point31;
    this.txtDisFloor.Name = "txtDisFloor";
    TextBox txtDisFloor2 = this.txtDisFloor;
    size1 = new Size(303, 20);
    Size size31 = size1;
    txtDisFloor2.Size = size31;
    this.txtDisFloor.TabIndex = 176 /*0xB0*/;
    TextBox txtDisNo1 = this.txtDisNo;
    point1 = new Point(186, 235);
    Point point32 = point1;
    txtDisNo1.Location = point32;
    this.txtDisNo.Name = "txtDisNo";
    TextBox txtDisNo2 = this.txtDisNo;
    size1 = new Size(303, 20);
    Size size32 = size1;
    txtDisNo2.Size = size32;
    this.txtDisNo.TabIndex = 175;
    TextBox txtAnnualgrrent1 = this.txtAnnualgrrent;
    point1 = new Point(186, 210);
    Point point33 = point1;
    txtAnnualgrrent1.Location = point33;
    this.txtAnnualgrrent.Name = "txtAnnualgrrent";
    TextBox txtAnnualgrrent2 = this.txtAnnualgrrent;
    size1 = new Size(303, 20);
    Size size33 = size1;
    txtAnnualgrrent2.Size = size33;
    this.txtAnnualgrrent.TabIndex = 174;
    TextBox txtrentpaidyear1 = this.txtrentpaidyear;
    point1 = new Point(186, 185);
    Point point34 = point1;
    txtrentpaidyear1.Location = point34;
    this.txtrentpaidyear.Name = "txtrentpaidyear";
    TextBox txtrentpaidyear2 = this.txtrentpaidyear;
    size1 = new Size(303, 20);
    Size size34 = size1;
    txtrentpaidyear2.Size = size34;
    this.txtrentpaidyear.TabIndex = 173;
    TextBox txtTenure1 = this.TxtTenure;
    point1 = new Point(186, 160 /*0xA0*/);
    Point point35 = point1;
    txtTenure1.Location = point35;
    this.TxtTenure.Name = "TxtTenure";
    TextBox txtTenure2 = this.TxtTenure;
    size1 = new Size(303, 20);
    Size size35 = size1;
    txtTenure2.Size = size35;
    this.TxtTenure.TabIndex = 172;
    TextBox txtcitySurveyno1 = this.txtcitySurveyno;
    point1 = new Point(186, 135);
    Point point36 = point1;
    txtcitySurveyno1.Location = point36;
    this.txtcitySurveyno.Name = "txtcitySurveyno";
    TextBox txtcitySurveyno2 = this.txtcitySurveyno;
    size1 = new Size(303, 20);
    Size size36 = size1;
    txtcitySurveyno2.Size = size36;
    this.txtcitySurveyno.TabIndex = 171;
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(217, 508);
    Point point37 = point1;
    btnUpdate1.Location = point37;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(61, 26);
    Size size37 = size1;
    btnUpdate2.Size = size37;
    this.btnUpdate.TabIndex = 185;
    this.btnUpdate.Text = "&Update";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.lblId.AutoSize = true;
    Label lblId1 = this.lblId;
    point1 = new Point(65, 33);
    Point point38 = point1;
    lblId1.Location = point38;
    this.lblId.Name = "lblId";
    Label lblId2 = this.lblId;
    size1 = new Size(39, 13);
    Size size38 = size1;
    lblId2.Size = size38;
    this.lblId.TabIndex = 189;
    this.lblId.Text = "Label8";
    this.lblId.Visible = false;
    TextBox txtsurveyno1 = this.txtsurveyno;
    point1 = new Point(186, 110);
    Point point39 = point1;
    txtsurveyno1.Location = point39;
    this.txtsurveyno.Name = "txtsurveyno";
    TextBox txtsurveyno2 = this.txtsurveyno;
    size1 = new Size(303, 20);
    Size size39 = size1;
    txtsurveyno2.Size = size39;
    this.txtsurveyno.TabIndex = 170;
    TextBox txtPsrno1 = this.txtPsrno;
    point1 = new Point(186, 46);
    Point point40 = point1;
    txtPsrno1.Location = point40;
    this.txtPsrno.Name = "txtPsrno";
    TextBox txtPsrno2 = this.txtPsrno;
    size1 = new Size(303, 20);
    Size size40 = size1;
    txtPsrno2.Size = size40;
    this.txtPsrno.TabIndex = 168;
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(296, 508);
    Point point41 = point1;
    btnCancel1.Location = point41;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(61, 26);
    Size size41 = size1;
    btnCancel2.Size = size41;
    this.btnCancel.TabIndex = 186;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.txtMemId.Enabled = false;
    TextBox txtMemId1 = this.txtMemId;
    point1 = new Point(186, 70);
    Point point42 = point1;
    txtMemId1.Location = point42;
    this.txtMemId.Name = "txtMemId";
    TextBox txtMemId2 = this.txtMemId;
    size1 = new Size(303, 20);
    Size size42 = size1;
    txtMemId2.Size = size42;
    this.txtMemId.TabIndex = 188;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(63 /*0x3F*/, 73);
    Point point43 = point1;
    label1_1.Location = point43;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(50, 13);
    Size size43 = size1;
    label1_2.Size = size43;
    this.Label1.TabIndex = 187;
    this.Label1.Text = "Mem No.";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnList);
    this.Controls.Add((Control) this.lblFlatNo);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.lblMname);
    this.Controls.Add((Control) this.lblMno);
    this.Controls.Add((Control) this.Label16);
    this.Controls.Add((Control) this.Label17);
    this.Controls.Add((Control) this.txtTitleOccupancy);
    this.Controls.Add((Control) this.txtDOC);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.Label13);
    this.Controls.Add((Control) this.Label14);
    this.Controls.Add((Control) this.Label15);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtRemark);
    this.Controls.Add((Control) this.txtDOM);
    this.Controls.Add((Control) this.txtcostsize);
    this.Controls.Add((Control) this.txtcostbldg);
    this.Controls.Add((Control) this.txtAnnualRent);
    this.Controls.Add((Control) this.txtOccupancy);
    this.Controls.Add((Control) this.txtDisFloor);
    this.Controls.Add((Control) this.txtDisNo);
    this.Controls.Add((Control) this.txtAnnualgrrent);
    this.Controls.Add((Control) this.txtrentpaidyear);
    this.Controls.Add((Control) this.TxtTenure);
    this.Controls.Add((Control) this.txtcitySurveyno);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.lblId);
    this.Controls.Add((Control) this.txtsurveyno);
    this.Controls.Add((Control) this.txtPsrno);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.txtMemId);
    this.Controls.Add((Control) this.Label1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatPDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmStatPDetail);
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Label lblFlatNo
  {
    [DebuggerNonUserCode] get => this._lblFlatNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFlatNo = value;
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

  internal virtual Label lblMname
  {
    [DebuggerNonUserCode] get => this._lblMname;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMname = value;
  }

  internal virtual Label lblMno
  {
    [DebuggerNonUserCode] get => this._lblMno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMno = value;
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual Label Label17
  {
    [DebuggerNonUserCode] get => this._Label17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
  }

  internal virtual TextBox txtTitleOccupancy
  {
    [DebuggerNonUserCode] get => this._txtTitleOccupancy;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtTitleOccupancy_KeyDown);
      if (this._txtTitleOccupancy != null)
        this._txtTitleOccupancy.KeyDown -= keyEventHandler;
      this._txtTitleOccupancy = value;
      if (this._txtTitleOccupancy == null)
        return;
      this._txtTitleOccupancy.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtDOC
  {
    [DebuggerNonUserCode] get => this._txtDOC;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDOC_KeyDown);
      if (this._txtDOC != null)
        this._txtDOC.KeyDown -= keyEventHandler;
      this._txtDOC = value;
      if (this._txtDOC == null)
        return;
      this._txtDOC.KeyDown += keyEventHandler;
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

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
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

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual TextBox txtRemark
  {
    [DebuggerNonUserCode] get => this._txtRemark;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtRemark_KeyDown);
      if (this._txtRemark != null)
        this._txtRemark.KeyDown -= keyEventHandler;
      this._txtRemark = value;
      if (this._txtRemark == null)
        return;
      this._txtRemark.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtDOM
  {
    [DebuggerNonUserCode] get => this._txtDOM;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDOM_KeyDown);
      if (this._txtDOM != null)
        this._txtDOM.KeyDown -= keyEventHandler;
      this._txtDOM = value;
      if (this._txtDOM == null)
        return;
      this._txtDOM.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtcostsize
  {
    [DebuggerNonUserCode] get => this._txtcostsize;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtcostsize_KeyDown);
      if (this._txtcostsize != null)
        this._txtcostsize.KeyDown -= keyEventHandler;
      this._txtcostsize = value;
      if (this._txtcostsize == null)
        return;
      this._txtcostsize.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtcostbldg
  {
    [DebuggerNonUserCode] get => this._txtcostbldg;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtcostbldg_KeyDown);
      if (this._txtcostbldg != null)
        this._txtcostbldg.KeyDown -= keyEventHandler;
      this._txtcostbldg = value;
      if (this._txtcostbldg == null)
        return;
      this._txtcostbldg.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtAnnualRent
  {
    [DebuggerNonUserCode] get => this._txtAnnualRent;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAnnualRent_KeyDown);
      if (this._txtAnnualRent != null)
        this._txtAnnualRent.KeyDown -= keyEventHandler;
      this._txtAnnualRent = value;
      if (this._txtAnnualRent == null)
        return;
      this._txtAnnualRent.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtOccupancy
  {
    [DebuggerNonUserCode] get => this._txtOccupancy;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtOccupancy_KeyDown);
      if (this._txtOccupancy != null)
        this._txtOccupancy.KeyDown -= keyEventHandler;
      this._txtOccupancy = value;
      if (this._txtOccupancy == null)
        return;
      this._txtOccupancy.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtDisFloor
  {
    [DebuggerNonUserCode] get => this._txtDisFloor;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDisFloor_KeyDown);
      if (this._txtDisFloor != null)
        this._txtDisFloor.KeyDown -= keyEventHandler;
      this._txtDisFloor = value;
      if (this._txtDisFloor == null)
        return;
      this._txtDisFloor.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtDisNo
  {
    [DebuggerNonUserCode] get => this._txtDisNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDisNo_KeyDown);
      if (this._txtDisNo != null)
        this._txtDisNo.KeyDown -= keyEventHandler;
      this._txtDisNo = value;
      if (this._txtDisNo == null)
        return;
      this._txtDisNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtAnnualgrrent
  {
    [DebuggerNonUserCode] get => this._txtAnnualgrrent;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAnnualgrrent_KeyDown);
      if (this._txtAnnualgrrent != null)
        this._txtAnnualgrrent.KeyDown -= keyEventHandler;
      this._txtAnnualgrrent = value;
      if (this._txtAnnualgrrent == null)
        return;
      this._txtAnnualgrrent.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtrentpaidyear
  {
    [DebuggerNonUserCode] get => this._txtrentpaidyear;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtrentpaidyear_KeyDown);
      if (this._txtrentpaidyear != null)
        this._txtrentpaidyear.KeyDown -= keyEventHandler;
      this._txtrentpaidyear = value;
      if (this._txtrentpaidyear == null)
        return;
      this._txtrentpaidyear.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox TxtTenure
  {
    [DebuggerNonUserCode] get => this._TxtTenure;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.TxtTenure_KeyDown);
      if (this._TxtTenure != null)
        this._TxtTenure.KeyDown -= keyEventHandler;
      this._TxtTenure = value;
      if (this._TxtTenure == null)
        return;
      this._TxtTenure.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtcitySurveyno
  {
    [DebuggerNonUserCode] get => this._txtcitySurveyno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtcitySurveyno_KeyDown);
      if (this._txtcitySurveyno != null)
        this._txtcitySurveyno.KeyDown -= keyEventHandler;
      this._txtcitySurveyno = value;
      if (this._txtcitySurveyno == null)
        return;
      this._txtcitySurveyno.KeyDown += keyEventHandler;
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

  internal virtual Label lblId
  {
    [DebuggerNonUserCode] get => this._lblId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblId = value;
  }

  internal virtual TextBox txtsurveyno
  {
    [DebuggerNonUserCode] get => this._txtsurveyno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtsurveyno_KeyDown);
      if (this._txtsurveyno != null)
        this._txtsurveyno.KeyDown -= keyEventHandler;
      this._txtsurveyno = value;
      if (this._txtsurveyno == null)
        return;
      this._txtsurveyno.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtPsrno
  {
    [DebuggerNonUserCode] get => this._txtPsrno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtPsrno_TextChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtPsrno_LostFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPsrno_KeyDown);
      if (this._txtPsrno != null)
      {
        this._txtPsrno.TextChanged -= eventHandler1;
        this._txtPsrno.LostFocus -= eventHandler2;
        this._txtPsrno.KeyDown -= keyEventHandler;
      }
      this._txtPsrno = value;
      if (this._txtPsrno == null)
        return;
      this._txtPsrno.TextChanged += eventHandler1;
      this._txtPsrno.LostFocus += eventHandler2;
      this._txtPsrno.KeyDown += keyEventHandler;
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

  internal virtual TextBox txtMemId
  {
    [DebuggerNonUserCode] get => this._txtMemId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemId_KeyDown);
      if (this._txtMemId != null)
        this._txtMemId.KeyDown -= keyEventHandler;
      this._txtMemId = value;
      if (this._txtMemId == null)
        return;
      this._txtMemId.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  private void frmStatPDetail_Load(object sender, EventArgs e)
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

  private void txtMemId_KeyDown(object sender, KeyEventArgs e)
  {
    int num = (int) MyProject.Forms.frmListCall.ShowDialog();
    this.txtMemId.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    this.lblMno.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    this.lblFlatNo.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    this.lblMname.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    MyProject.Forms.frmListCall = (frmListCall) null;
    this.txtsurveyno.Focus();
  }

  private void txtPsrno_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnList.Focus();
  }

  private void txtPsrno_LostFocus(object sender, EventArgs e)
  {
    if (!(!Versioned.IsNumeric((object) this.txtPsrno.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPsrno.Text, "", false) != 0))
      return;
    this.txtPsrno.Focus();
  }

  private void txtPsrno_TextChanged(object sender, EventArgs e)
  {
    if (!(!Versioned.IsNumeric((object) this.txtPsrno.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPsrno.Text, "", false) != 0))
      return;
    int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
    this.txtPsrno.Focus();
  }

  private void btnList_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmListCall.txtComMemcode.Text = this.txtMemId.Text;
    MyProject.Forms.frmListCall.lblStatus.Text = "Exit";
    int num = (int) MyProject.Forms.frmListCall.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmListCall.lblStatus.Text, "Select", false) == 0)
    {
      this.txtMemId.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[0].Value.ToString();
      this.lblMno.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[3].Value.ToString();
      this.lblFlatNo.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[1].Value.ToString();
      this.lblMname.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    }
    MyProject.Forms.frmListCall = (frmListCall) null;
    this.txtsurveyno.Focus();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtPsrno.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPsrno.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtPsrno.Focus();
    }
    else
    {
      bool flag = false;
      if (Strings.Len(Strings.Trim(this.txtMemId.Text)) == 0)
      {
        int num = (int) Interaction.MsgBox((object) "Blank Member");
        this.txtMemId.Focus();
      }
      else
      {
        int num1 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num1)
        {
          if (Strings.InStr(Strings.Trim(this.lblMno.Text), this.DataGridView1.Rows[index].Cells[3].Value.ToString()) == 1)
            flag = true;
          checked { ++index; }
        }
        if (!flag)
        {
          int num2 = (int) Interaction.MsgBox((object) "Member Regn No. Not matched");
          this.txtMemId.Focus();
        }
        else
        {
          this.txtsurveyno.Text = this.txtsurveyno.Text.ToString().Replace("'", "''");
          this.txtcitySurveyno.Text = this.txtcitySurveyno.Text.ToString().Replace("'", "''");
          this.TxtTenure.Text = this.TxtTenure.Text.ToString().Replace("'", "''");
          this.txtrentpaidyear.Text = this.txtrentpaidyear.Text.ToString().Replace("'", "''");
          this.txtAnnualgrrent.Text = this.txtAnnualgrrent.Text.ToString().Replace("'", "''");
          this.txtDisNo.Text = this.txtDisNo.Text.ToString().Replace("'", "''");
          this.txtDisFloor.Text = this.txtDisFloor.Text.ToString().Replace("'", "''");
          this.txtOccupancy.Text = this.txtOccupancy.Text.ToString().Replace("'", "''");
          this.txtTitleOccupancy.Text = this.txtTitleOccupancy.Text.ToString().Replace("'", "''");
          this.txtAnnualRent.Text = this.txtAnnualRent.Text.ToString().Replace("'", "''");
          this.txtcostbldg.Text = this.txtcostbldg.Text.ToString().Replace("'", "''");
          this.txtcostsize.Text = this.txtcostsize.Text.ToString().Replace("'", "''");
          this.txtDOC.Text = this.txtDOC.Text.ToString().Replace("'", "''");
          this.txtDOM.Text = this.txtDOM.Text.ToString().Replace("'", "''");
          this.txtRemark.Text = this.txtRemark.Text.ToString().Replace("'", "''");
          OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
          connection.Open();
          new OleDbCommand($"update PReg set MemId ='{Conversions.ToString(Conversion.Val(this.lblMno.Text.Trim()))}' ,Psrno ='{Conversions.ToString(Conversion.Val(this.txtPsrno.Text.Trim()))}' ,surveyno ='{this.txtsurveyno.Text.Trim()}' ,citySurveno ='{this.txtcitySurveyno.Text.Trim()}' ,Tenure ='{this.TxtTenure.Text.Trim()}' ,rentpaidyear ='{this.txtrentpaidyear.Text.Trim()}' ,Annualgrrent ='{this.txtAnnualgrrent.Text.Trim()}' ,DisNo ='{this.txtDisNo.Text.Trim()}' ,DisFloor ='{this.txtDisFloor.Text.Trim()}' ,Occupancy ='{this.txtOccupancy.Text.Trim()}' ,TitalOccupancy ='{this.txtTitleOccupancy.Text.Trim()}' ,AnnualRent ='{this.txtAnnualRent.Text.Trim()}' ,costbldg ='{this.txtcostbldg.Text.Trim()}' ,costsize ='{this.txtcostsize.Text.Trim()}' ,DOC ='{this.txtDOC.Text.Trim()}' ,DOM ='{this.txtDOM.Text.Trim()}' ,Remark ='{this.txtRemark.Text.Trim()}'  where Id ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}", connection).ExecuteNonQuery();
          connection.Close();
          this.Close();
        }
      }
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void txtsurveyno_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtcitySurveyno.Focus();
  }

  private void txtcitySurveyno_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.TxtTenure.Focus();
  }

  private void TxtTenure_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtrentpaidyear.Focus();
  }

  private void txtrentpaidyear_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAnnualgrrent.Focus();
  }

  private void txtAnnualgrrent_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtDisNo.Focus();
  }

  private void txtDisNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtDisFloor.Focus();
  }

  private void txtDisFloor_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtOccupancy.Focus();
  }

  private void txtOccupancy_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtTitleOccupancy.Focus();
  }

  private void txtTitleOccupancy_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAnnualRent.Focus();
  }

  private void txtAnnualRent_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtcostbldg.Focus();
  }

  private void txtcostbldg_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtcostsize.Focus();
  }

  private void txtcostsize_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtDOC.Focus();
  }

  private void txtDOC_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtDOM.Focus();
  }

  private void txtDOM_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemark.Focus();
  }

  private void txtRemark_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnUpdate.Focus();
  }
}
