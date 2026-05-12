// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatINDetail
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmStatINDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("txtInvSrno")]
  private TextBox _txtInvSrno;
  [AccessedThroughProperty("lblID")]
  private Label _lblID;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
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
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("txtIntTotal")]
  private TextBox _txtIntTotal;
  [AccessedThroughProperty("txtIntTax")]
  private TextBox _txtIntTax;
  [AccessedThroughProperty("txtIntAccrued")]
  private TextBox _txtIntAccrued;
  [AccessedThroughProperty("txtIntEarned")]
  private TextBox _txtIntEarned;
  [AccessedThroughProperty("txtIntDate")]
  private TextBox _txtIntDate;
  [AccessedThroughProperty("txtSaleTotal")]
  private TextBox _txtSaleTotal;
  [AccessedThroughProperty("txtSalePrice")]
  private TextBox _txtSalePrice;
  [AccessedThroughProperty("txtSalePart")]
  private TextBox _txtSalePart;
  [AccessedThroughProperty("txtSaleNo")]
  private TextBox _txtSaleNo;
  [AccessedThroughProperty("txtSaleDate")]
  private TextBox _txtSaleDate;
  [AccessedThroughProperty("txtPurTotal")]
  private TextBox _txtPurTotal;
  [AccessedThroughProperty("txtPurPrice")]
  private TextBox _txtPurPrice;
  [AccessedThroughProperty("txtPurPart")]
  private TextBox _txtPurPart;
  [AccessedThroughProperty("txtPurNo")]
  private TextBox _txtPurNo;
  [AccessedThroughProperty("txtPurDate")]
  private TextBox _txtPurDate;

  [DebuggerNonUserCode]
  static frmStatINDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmStatINDetail()
  {
    frmStatINDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatINDetail.__ENCList)
    {
      if (frmStatINDetail.__ENCList.Count == frmStatINDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatINDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatINDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatINDetail.__ENCList[index1] = frmStatINDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatINDetail.__ENCList.RemoveRange(index1, checked (frmStatINDetail.__ENCList.Count - index1));
        frmStatINDetail.__ENCList.Capacity = frmStatINDetail.__ENCList.Count;
      }
      frmStatINDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.Label19 = new Label();
    this.txtInvSrno = new TextBox();
    this.lblID = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.Label13 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.btnExit = new Button();
    this.btnSave = new Button();
    this.txtIntTotal = new TextBox();
    this.txtIntTax = new TextBox();
    this.txtIntAccrued = new TextBox();
    this.txtIntEarned = new TextBox();
    this.txtIntDate = new TextBox();
    this.txtSaleTotal = new TextBox();
    this.txtSalePrice = new TextBox();
    this.txtSalePart = new TextBox();
    this.txtSaleNo = new TextBox();
    this.txtSaleDate = new TextBox();
    this.txtPurTotal = new TextBox();
    this.txtPurPrice = new TextBox();
    this.txtPurPart = new TextBox();
    this.txtPurNo = new TextBox();
    this.txtPurDate = new TextBox();
    this.SuspendLayout();
    this.Label19.AutoSize = true;
    Label label19_1 = this.Label19;
    Point point1 = new Point(81, 65);
    Point point2 = point1;
    label19_1.Location = point2;
    this.Label19.Name = "Label19";
    Label label19_2 = this.Label19;
    Size size1 = new Size(29, 13);
    Size size2 = size1;
    label19_2.Size = size2;
    this.Label19.TabIndex = 235;
    this.Label19.Text = "Srno";
    TextBox txtInvSrno1 = this.txtInvSrno;
    point1 = new Point(165, 62);
    Point point3 = point1;
    txtInvSrno1.Location = point3;
    this.txtInvSrno.Name = "txtInvSrno";
    TextBox txtInvSrno2 = this.txtInvSrno;
    size1 = new Size(303, 20);
    Size size3 = size1;
    txtInvSrno2.Size = size3;
    this.txtInvSrno.TabIndex = 198;
    this.lblID.AutoSize = true;
    Label lblId1 = this.lblID;
    point1 = new Point(62, 32 /*0x20*/);
    Point point4 = point1;
    lblId1.Location = point4;
    this.lblID.Name = "lblID";
    Label lblId2 = this.lblID;
    size1 = new Size(45, 13);
    Size size4 = size1;
    lblId2.Size = size4;
    this.lblID.TabIndex = 234;
    this.lblID.Text = "Label19";
    this.lblID.Visible = false;
    this.Label14.AutoSize = true;
    Label label14_1 = this.Label14;
    point1 = new Point(81, 466);
    Point point5 = point1;
    label14_1.Location = point5;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(70, 13);
    Size size5 = size1;
    label14_2.Size = size5;
    this.Label14.TabIndex = 233;
    this.Label14.Text = "Total Amount";
    this.Label15.AutoSize = true;
    Label label15_1 = this.Label15;
    point1 = new Point(81, 440);
    Point point6 = point1;
    label15_1.Location = point6;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(63 /*0x3F*/, 13);
    Size size6 = size1;
    label15_2.Size = size6;
    this.Label15.TabIndex = 232;
    this.Label15.Text = "Income Tax";
    this.Label16.AutoSize = true;
    Label label16_1 = this.Label16;
    point1 = new Point(81, 414);
    Point point7 = point1;
    label16_1.Location = point7;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(47, 13);
    Size size7 = size1;
    label16_2.Size = size7;
    this.Label16.TabIndex = 231;
    this.Label16.Text = "Accrued";
    this.Label17.AutoSize = true;
    Label label17_1 = this.Label17;
    point1 = new Point(81, 388);
    Point point8 = point1;
    label17_1.Location = point8;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(41, 13);
    Size size8 = size1;
    label17_2.Size = size8;
    this.Label17.TabIndex = 230;
    this.Label17.Text = "Earned";
    this.Label18.AutoSize = true;
    Label label18_1 = this.Label18;
    point1 = new Point(81, 362);
    Point point9 = point1;
    label18_1.Location = point9;
    this.Label18.Name = "Label18";
    Label label18_2 = this.Label18;
    size1 = new Size(30, 13);
    Size size9 = size1;
    label18_2.Size = size9;
    this.Label18.TabIndex = 229;
    this.Label18.Text = "Date";
    this.Label13.AutoSize = true;
    Label label13_1 = this.Label13;
    point1 = new Point(257, 343);
    Point point10 = point1;
    label13_1.Location = point10;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(77, 13);
    Size size10 = size1;
    label13_2.Size = size10;
    this.Label13.TabIndex = 228;
    this.Label13.Text = "Interest Details";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(81, 311);
    Point point11 = point1;
    label8_1.Location = point11;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(70, 13);
    Size size11 = size1;
    label8_2.Size = size11;
    this.Label8.TabIndex = 227;
    this.Label8.Text = "Total Amount";
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(81, 285);
    Point point12 = point1;
    label9_1.Location = point12;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size12 = size1;
    label9_2.Size = size12;
    this.Label9.TabIndex = 226;
    this.Label9.Text = "Price";
    this.Label10.AutoSize = true;
    Label label10_1 = this.Label10;
    point1 = new Point(485, 437);
    Point point13 = point1;
    label10_1.Location = point13;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(39, 13);
    Size size13 = size1;
    label10_2.Size = size13;
    this.Label10.TabIndex = 225;
    this.Label10.Text = "Details";
    this.Label10.Visible = false;
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(485, 522);
    Point point14 = point1;
    label11_1.Location = point14;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(46, 13);
    Size size14 = size1;
    label11_2.Size = size14;
    this.Label11.TabIndex = 224 /*0xE0*/;
    this.Label11.Text = "Quantity";
    this.Label11.Visible = false;
    this.Label12.AutoSize = true;
    Label label12_1 = this.Label12;
    point1 = new Point(81, 259);
    Point point15 = point1;
    label12_1.Location = point15;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(30, 13);
    Size size15 = size1;
    label12_2.Size = size15;
    this.Label12.TabIndex = 223;
    this.Label12.Text = "Date";
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(264, 241);
    Point point16 = point1;
    label7_1.Location = point16;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(63 /*0x3F*/, 13);
    Size size16 = size1;
    label7_2.Size = size16;
    this.Label7.TabIndex = 222;
    this.Label7.Text = "Sale Details";
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(81, 216);
    Point point17 = point1;
    label6_1.Location = point17;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(70, 13);
    Size size17 = size1;
    label6_2.Size = size17;
    this.Label6.TabIndex = 221;
    this.Label6.Text = "Total Amount";
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(81, 190);
    Point point18 = point1;
    label5_1.Location = point18;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(31 /*0x1F*/, 13);
    Size size18 = size1;
    label5_2.Size = size18;
    this.Label5.TabIndex = 220;
    this.Label5.Text = "Price";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(81, 91);
    Point point19 = point1;
    label4_1.Location = point19;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(63 /*0x3F*/, 13);
    Size size19 = size1;
    label4_2.Size = size19;
    this.Label4.TabIndex = 219;
    this.Label4.Text = "Deposit No.";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(252, 145);
    Point point20 = point1;
    label3_1.Location = point20;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(87, 13);
    Size size20 = size1;
    label3_2.Size = size20;
    this.Label3.TabIndex = 218;
    this.Label3.Text = "Purchase Details";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(81, 117);
    Point point21 = point1;
    label2_1.Location = point21;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(46, 13);
    Size size21 = size1;
    label2_2.Size = size21;
    this.Label2.TabIndex = 217;
    this.Label2.Text = "Quantity";
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(81, 164);
    Point point22 = point1;
    label1_1.Location = point22;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(30, 13);
    Size size22 = size1;
    label1_2.Size = size22;
    this.Label1.TabIndex = 216;
    this.Label1.Text = "Date";
    Button btnExit1 = this.btnExit;
    point1 = new Point(301, 500);
    Point point23 = point1;
    btnExit1.Location = point23;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size23 = size1;
    btnExit2.Size = size23;
    this.btnExit.TabIndex = 215;
    this.btnExit.Text = "Cancel";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnSave1 = this.btnSave;
    point1 = new Point(196, 500);
    Point point24 = point1;
    btnSave1.Location = point24;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size24 = size1;
    btnSave2.Size = size24;
    this.btnSave.TabIndex = 214;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    TextBox txtIntTotal1 = this.txtIntTotal;
    point1 = new Point(165, 463);
    Point point25 = point1;
    txtIntTotal1.Location = point25;
    this.txtIntTotal.Name = "txtIntTotal";
    TextBox txtIntTotal2 = this.txtIntTotal;
    size1 = new Size(303, 20);
    Size size25 = size1;
    txtIntTotal2.Size = size25;
    this.txtIntTotal.TabIndex = 211;
    this.txtIntTotal.Text = "0";
    TextBox txtIntTax1 = this.txtIntTax;
    point1 = new Point(165, 437);
    Point point26 = point1;
    txtIntTax1.Location = point26;
    this.txtIntTax.Name = "txtIntTax";
    TextBox txtIntTax2 = this.txtIntTax;
    size1 = new Size(303, 20);
    Size size26 = size1;
    txtIntTax2.Size = size26;
    this.txtIntTax.TabIndex = 210;
    this.txtIntTax.Text = "0";
    TextBox txtIntAccrued1 = this.txtIntAccrued;
    point1 = new Point(165, 411);
    Point point27 = point1;
    txtIntAccrued1.Location = point27;
    this.txtIntAccrued.Name = "txtIntAccrued";
    TextBox txtIntAccrued2 = this.txtIntAccrued;
    size1 = new Size(303, 20);
    Size size27 = size1;
    txtIntAccrued2.Size = size27;
    this.txtIntAccrued.TabIndex = 209;
    this.txtIntAccrued.Text = "0";
    TextBox txtIntEarned1 = this.txtIntEarned;
    point1 = new Point(165, 385);
    Point point28 = point1;
    txtIntEarned1.Location = point28;
    this.txtIntEarned.Name = "txtIntEarned";
    TextBox txtIntEarned2 = this.txtIntEarned;
    size1 = new Size(303, 20);
    Size size28 = size1;
    txtIntEarned2.Size = size28;
    this.txtIntEarned.TabIndex = 208 /*0xD0*/;
    this.txtIntEarned.Text = "0";
    TextBox txtIntDate1 = this.txtIntDate;
    point1 = new Point(165, 359);
    Point point29 = point1;
    txtIntDate1.Location = point29;
    this.txtIntDate.Name = "txtIntDate";
    TextBox txtIntDate2 = this.txtIntDate;
    size1 = new Size(303, 20);
    Size size29 = size1;
    txtIntDate2.Size = size29;
    this.txtIntDate.TabIndex = 207;
    TextBox txtSaleTotal1 = this.txtSaleTotal;
    point1 = new Point(165, 308);
    Point point30 = point1;
    txtSaleTotal1.Location = point30;
    this.txtSaleTotal.Name = "txtSaleTotal";
    TextBox txtSaleTotal2 = this.txtSaleTotal;
    size1 = new Size(303, 20);
    Size size30 = size1;
    txtSaleTotal2.Size = size30;
    this.txtSaleTotal.TabIndex = 206;
    this.txtSaleTotal.Text = "0";
    TextBox txtSalePrice1 = this.txtSalePrice;
    point1 = new Point(165, 282);
    Point point31 = point1;
    txtSalePrice1.Location = point31;
    this.txtSalePrice.Name = "txtSalePrice";
    TextBox txtSalePrice2 = this.txtSalePrice;
    size1 = new Size(303, 20);
    Size size31 = size1;
    txtSalePrice2.Size = size31;
    this.txtSalePrice.TabIndex = 205;
    TextBox txtSalePart1 = this.txtSalePart;
    point1 = new Point(504, 388);
    Point point32 = point1;
    txtSalePart1.Location = point32;
    this.txtSalePart.Name = "txtSalePart";
    TextBox txtSalePart2 = this.txtSalePart;
    size1 = new Size(20, 20);
    Size size32 = size1;
    txtSalePart2.Size = size32;
    this.txtSalePart.TabIndex = 213;
    this.txtSalePart.Visible = false;
    TextBox txtSaleNo1 = this.txtSaleNo;
    point1 = new Point(498, 485);
    Point point33 = point1;
    txtSaleNo1.Location = point33;
    this.txtSaleNo.Name = "txtSaleNo";
    TextBox txtSaleNo2 = this.txtSaleNo;
    size1 = new Size(26, 20);
    Size size33 = size1;
    txtSaleNo2.Size = size33;
    this.txtSaleNo.TabIndex = 212;
    this.txtSaleNo.Visible = false;
    TextBox txtSaleDate1 = this.txtSaleDate;
    point1 = new Point(165, 256 /*0x0100*/);
    Point point34 = point1;
    txtSaleDate1.Location = point34;
    this.txtSaleDate.Name = "txtSaleDate";
    TextBox txtSaleDate2 = this.txtSaleDate;
    size1 = new Size(303, 20);
    Size size34 = size1;
    txtSaleDate2.Size = size34;
    this.txtSaleDate.TabIndex = 204;
    TextBox txtPurTotal1 = this.txtPurTotal;
    point1 = new Point(165, 213);
    Point point35 = point1;
    txtPurTotal1.Location = point35;
    this.txtPurTotal.Name = "txtPurTotal";
    TextBox txtPurTotal2 = this.txtPurTotal;
    size1 = new Size(303, 20);
    Size size35 = size1;
    txtPurTotal2.Size = size35;
    this.txtPurTotal.TabIndex = 203;
    this.txtPurTotal.Text = "0";
    TextBox txtPurPrice1 = this.txtPurPrice;
    point1 = new Point(165, 187);
    Point point36 = point1;
    txtPurPrice1.Location = point36;
    this.txtPurPrice.Name = "txtPurPrice";
    TextBox txtPurPrice2 = this.txtPurPrice;
    size1 = new Size(303, 20);
    Size size36 = size1;
    txtPurPrice2.Size = size36;
    this.txtPurPrice.TabIndex = 202;
    TextBox txtPurPart1 = this.txtPurPart;
    point1 = new Point(165, 88);
    Point point37 = point1;
    txtPurPart1.Location = point37;
    this.txtPurPart.Name = "txtPurPart";
    TextBox txtPurPart2 = this.txtPurPart;
    size1 = new Size(303, 20);
    Size size37 = size1;
    txtPurPart2.Size = size37;
    this.txtPurPart.TabIndex = 199;
    TextBox txtPurNo1 = this.txtPurNo;
    point1 = new Point(165, 114);
    Point point38 = point1;
    txtPurNo1.Location = point38;
    this.txtPurNo.Name = "txtPurNo";
    TextBox txtPurNo2 = this.txtPurNo;
    size1 = new Size(303, 20);
    Size size38 = size1;
    txtPurNo2.Size = size38;
    this.txtPurNo.TabIndex = 200;
    TextBox txtPurDate1 = this.txtPurDate;
    point1 = new Point(165, 161);
    Point point39 = point1;
    txtPurDate1.Location = point39;
    this.txtPurDate.Name = "txtPurDate";
    TextBox txtPurDate2 = this.txtPurDate;
    size1 = new Size(303, 20);
    Size size39 = size1;
    txtPurDate2.Size = size39;
    this.txtPurDate.TabIndex = 201;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label19);
    this.Controls.Add((Control) this.txtInvSrno);
    this.Controls.Add((Control) this.lblID);
    this.Controls.Add((Control) this.Label14);
    this.Controls.Add((Control) this.Label15);
    this.Controls.Add((Control) this.Label16);
    this.Controls.Add((Control) this.Label17);
    this.Controls.Add((Control) this.Label18);
    this.Controls.Add((Control) this.Label13);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.txtIntTotal);
    this.Controls.Add((Control) this.txtIntTax);
    this.Controls.Add((Control) this.txtIntAccrued);
    this.Controls.Add((Control) this.txtIntEarned);
    this.Controls.Add((Control) this.txtIntDate);
    this.Controls.Add((Control) this.txtSaleTotal);
    this.Controls.Add((Control) this.txtSalePrice);
    this.Controls.Add((Control) this.txtSalePart);
    this.Controls.Add((Control) this.txtSaleNo);
    this.Controls.Add((Control) this.txtSaleDate);
    this.Controls.Add((Control) this.txtPurTotal);
    this.Controls.Add((Control) this.txtPurPrice);
    this.Controls.Add((Control) this.txtPurPart);
    this.Controls.Add((Control) this.txtPurNo);
    this.Controls.Add((Control) this.txtPurDate);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatINDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmStatINDetail);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label Label19
  {
    [DebuggerNonUserCode] get => this._Label19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
  }

  internal virtual TextBox txtInvSrno
  {
    [DebuggerNonUserCode] get => this._txtInvSrno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtInvSrno_KeyDown);
      if (this._txtInvSrno != null)
        this._txtInvSrno.KeyDown -= keyEventHandler;
      this._txtInvSrno = value;
      if (this._txtInvSrno == null)
        return;
      this._txtInvSrno.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label lblID
  {
    [DebuggerNonUserCode] get => this._lblID;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblID = value;
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

  internal virtual Label Label18
  {
    [DebuggerNonUserCode] get => this._Label18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  internal virtual TextBox txtIntTotal
  {
    [DebuggerNonUserCode] get => this._txtIntTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtIntTotal_KeyDown);
      if (this._txtIntTotal != null)
        this._txtIntTotal.KeyDown -= keyEventHandler;
      this._txtIntTotal = value;
      if (this._txtIntTotal == null)
        return;
      this._txtIntTotal.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtIntTax
  {
    [DebuggerNonUserCode] get => this._txtIntTax;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtIntTax_KeyDown);
      if (this._txtIntTax != null)
        this._txtIntTax.KeyDown -= keyEventHandler;
      this._txtIntTax = value;
      if (this._txtIntTax == null)
        return;
      this._txtIntTax.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtIntAccrued
  {
    [DebuggerNonUserCode] get => this._txtIntAccrued;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtIntAccrued_KeyDown);
      if (this._txtIntAccrued != null)
        this._txtIntAccrued.KeyDown -= keyEventHandler;
      this._txtIntAccrued = value;
      if (this._txtIntAccrued == null)
        return;
      this._txtIntAccrued.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtIntEarned
  {
    [DebuggerNonUserCode] get => this._txtIntEarned;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtIntEarned_KeyDown);
      if (this._txtIntEarned != null)
        this._txtIntEarned.KeyDown -= keyEventHandler;
      this._txtIntEarned = value;
      if (this._txtIntEarned == null)
        return;
      this._txtIntEarned.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtIntDate
  {
    [DebuggerNonUserCode] get => this._txtIntDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtIntDate_KeyDown);
      if (this._txtIntDate != null)
        this._txtIntDate.KeyDown -= keyEventHandler;
      this._txtIntDate = value;
      if (this._txtIntDate == null)
        return;
      this._txtIntDate.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtSaleTotal
  {
    [DebuggerNonUserCode] get => this._txtSaleTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSaleTotal_KeyDown);
      if (this._txtSaleTotal != null)
        this._txtSaleTotal.KeyDown -= keyEventHandler;
      this._txtSaleTotal = value;
      if (this._txtSaleTotal == null)
        return;
      this._txtSaleTotal.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtSalePrice
  {
    [DebuggerNonUserCode] get => this._txtSalePrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSalePrice_KeyDown);
      if (this._txtSalePrice != null)
        this._txtSalePrice.KeyDown -= keyEventHandler;
      this._txtSalePrice = value;
      if (this._txtSalePrice == null)
        return;
      this._txtSalePrice.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtSalePart
  {
    [DebuggerNonUserCode] get => this._txtSalePart;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtSalePart = value;
    }
  }

  internal virtual TextBox txtSaleNo
  {
    [DebuggerNonUserCode] get => this._txtSaleNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtSaleNo = value;
    }
  }

  internal virtual TextBox txtSaleDate
  {
    [DebuggerNonUserCode] get => this._txtSaleDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSaleDate_KeyDown);
      if (this._txtSaleDate != null)
        this._txtSaleDate.KeyDown -= keyEventHandler;
      this._txtSaleDate = value;
      if (this._txtSaleDate == null)
        return;
      this._txtSaleDate.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtPurTotal
  {
    [DebuggerNonUserCode] get => this._txtPurTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPurTotal_KeyDown);
      if (this._txtPurTotal != null)
        this._txtPurTotal.KeyDown -= keyEventHandler;
      this._txtPurTotal = value;
      if (this._txtPurTotal == null)
        return;
      this._txtPurTotal.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtPurPrice
  {
    [DebuggerNonUserCode] get => this._txtPurPrice;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPurPrice_KeyDown);
      if (this._txtPurPrice != null)
        this._txtPurPrice.KeyDown -= keyEventHandler;
      this._txtPurPrice = value;
      if (this._txtPurPrice == null)
        return;
      this._txtPurPrice.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtPurPart
  {
    [DebuggerNonUserCode] get => this._txtPurPart;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPurPart_KeyDown);
      if (this._txtPurPart != null)
        this._txtPurPart.KeyDown -= keyEventHandler;
      this._txtPurPart = value;
      if (this._txtPurPart == null)
        return;
      this._txtPurPart.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtPurNo
  {
    [DebuggerNonUserCode] get => this._txtPurNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPurNo_KeyDown);
      if (this._txtPurNo != null)
        this._txtPurNo.KeyDown -= keyEventHandler;
      this._txtPurNo = value;
      if (this._txtPurNo == null)
        return;
      this._txtPurNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtPurDate
  {
    [DebuggerNonUserCode] get => this._txtPurDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPurDate_KeyDown);
      if (this._txtPurDate != null)
        this._txtPurDate.KeyDown -= keyEventHandler;
      this._txtPurDate = value;
      if (this._txtPurDate == null)
        return;
      this._txtPurDate.KeyDown += keyEventHandler;
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtInvSrno.Text) & Operators.CompareString(this.txtInvSrno.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtInvSrno.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtPurTotal.Text) & Operators.CompareString(this.txtPurTotal.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtPurTotal.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtSaleTotal.Text) & Operators.CompareString(this.txtSaleTotal.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtSaleTotal.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtIntEarned.Text) & Operators.CompareString(this.txtIntEarned.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtIntEarned.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtIntAccrued.Text) & Operators.CompareString(this.txtIntAccrued.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtIntAccrued.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtIntTax.Text) & Operators.CompareString(this.txtIntTax.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtIntTax.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtIntTotal.Text) & Operators.CompareString(this.txtIntTotal.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtIntTotal.Focus();
    }
    else
    {
      if (Operators.CompareString(this.txtInvSrno.Text, "", false) == 0)
        this.txtInvSrno.Text = "0";
      if (Operators.CompareString(this.txtPurTotal.Text, "", false) == 0)
        this.txtPurTotal.Text = "0";
      if (Operators.CompareString(this.txtSaleTotal.Text, "", false) == 0)
        this.txtSaleTotal.Text = "0";
      if (Operators.CompareString(this.txtIntEarned.Text, "", false) == 0)
        this.txtIntEarned.Text = "0";
      if (Operators.CompareString(this.txtIntAccrued.Text, "", false) == 0)
        this.txtIntAccrued.Text = "0";
      if (Operators.CompareString(this.txtIntTax.Text, "", false) == 0)
        this.txtIntTax.Text = "0";
      if (Operators.CompareString(this.txtIntTotal.Text, "", false) == 0)
        this.txtIntTotal.Text = "0";
      this.txtPurDate.Text = this.txtPurDate.Text.ToString().Replace("'", "''");
      this.txtPurNo.Text = this.txtPurNo.Text.ToString().Replace("'", "''");
      this.txtPurPart.Text = this.txtPurPart.Text.ToString().Replace("'", "''");
      this.txtPurPrice.Text = this.txtPurPrice.Text.ToString().Replace("'", "''");
      this.txtSaleDate.Text = this.txtSaleDate.Text.ToString().Replace("'", "''");
      this.txtSaleNo.Text = this.txtSaleNo.Text.ToString().Replace("'", "''");
      this.txtSalePart.Text = this.txtSalePart.Text.ToString().Replace("'", "''");
      this.txtSalePrice.Text = this.txtSalePrice.Text.ToString().Replace("'", "''");
      this.txtIntDate.Text = this.txtIntDate.Text.ToString().Replace("'", "''");
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
      connection.Open();
      string cmdText;
      string str;
      if (Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        cmdText = $"Insert Into InvReg (InvSrno, PurDate, PurNo, PurPart, PurPrice, PurTotal, SaleDate, SaleNo, SalePart, SalePrice, SaleTotal, IntDate, IntEarned, IntAccrued, IntTax, IntTotal ) values ('{Conversions.ToString(Conversion.Val(this.txtInvSrno.Text.Trim()))}','{this.txtPurDate.Text.Trim()}','{this.txtPurNo.Text.Trim()}','{this.txtPurPart.Text.Trim()}','{this.txtPurPrice.Text.Trim()}','{Conversions.ToString(Conversion.Val(this.txtPurTotal.Text.Trim()))}','{this.txtSaleDate.Text.Trim()}','{this.txtSaleNo.Text.Trim()}','{this.txtSalePart.Text.Trim()}','{this.txtSalePrice.Text.Trim()}','{Conversions.ToString(Conversion.Val(this.txtSaleTotal.Text.Trim()))}','{this.txtIntDate.Text.Trim()}','{Conversions.ToString(Conversion.Val(this.txtIntEarned.Text.Trim()))}','{Conversions.ToString(Conversion.Val(this.txtIntAccrued.Text.Trim()))}','{Conversions.ToString(Conversion.Val(this.txtIntTax.Text.Trim()))}','{Conversions.ToString(Conversion.Val(this.txtIntTotal.Text.Trim()))}')";
        str = "Add Successful";
      }
      if (Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        cmdText = $"update InvReg set InvSrno ='{Conversions.ToString(Conversion.Val(this.txtInvSrno.Text.Trim()))}' ,PurDate ='{this.txtPurDate.Text.Trim()}' ,PurNo ='{this.txtPurNo.Text.Trim()}',PurPart ='{this.txtPurPart.Text.Trim()}',PurPrice ='{this.txtPurPrice.Text.Trim()}',PurTotal ='{Conversions.ToString(Conversion.Val(this.txtPurTotal.Text.Trim()))}',SaleDate ='{this.txtSaleDate.Text.Trim()}',SaleNo ='{this.txtSaleNo.Text.Trim()}',SalePart ='{this.txtSalePart.Text.Trim()}',SalePrice ='{this.txtSalePrice.Text.Trim()}',SaleTotal ='{Conversions.ToString(Conversion.Val(this.txtSaleTotal.Text.Trim()))}',IntDate ='{this.txtIntDate.Text.Trim()}',IntEarned ='{this.txtIntEarned.Text.Trim()}',IntAccrued ='{this.txtIntAccrued.Text.Trim()}',IntTax ='{this.txtIntTax.Text.Trim()}',IntTotal ='{Conversions.ToString(Conversion.Val(this.txtIntTotal.Text.Trim()))}'   where Id ={Conversions.ToString(Conversion.Val(this.lblID.Text.Trim()))}";
        str = "Update Successful";
      }
      if (Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 && Interaction.MsgBox((object) ("Are you Sure you want to Delete Investment Entry " + this.txtInvSrno.Text), MsgBoxStyle.YesNo, (object) "!!! WARNING... !!!") == MsgBoxResult.Yes)
      {
        cmdText = $"Delete From InvReg where Id ={Conversions.ToString(Conversion.Val(this.lblID.Text.Trim()))}";
        str = "delete Successful";
      }
      OleDbCommand oleDbCommand = new OleDbCommand(cmdText, connection);
      if (Operators.CompareString(str, "", false) != 0)
      {
        oleDbCommand.ExecuteNonQuery();
        int num = (int) Interaction.MsgBox((object) str);
      }
      connection.Close();
      this.Close();
    }
  }

  private void txtInvSrno_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPurPart.Focus();
  }

  private void txtPurPart_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPurNo.Focus();
  }

  private void txtPurNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPurDate.Focus();
  }

  private void txtPurDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPurPrice.Focus();
  }

  private void txtPurPrice_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPurTotal.Focus();
  }

  private void txtPurTotal_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSaleDate.Focus();
  }

  private void txtSaleDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSalePrice.Focus();
  }

  private void txtSalePrice_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtSaleTotal.Focus();
  }

  private void txtSaleTotal_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtIntDate.Focus();
  }

  private void txtIntDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtIntEarned.Focus();
  }

  private void txtIntEarned_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtIntAccrued.Focus();
  }

  private void txtIntAccrued_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtIntTax.Focus();
  }

  private void txtIntTax_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtIntTotal.Focus();
  }

  private void txtIntTotal_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
