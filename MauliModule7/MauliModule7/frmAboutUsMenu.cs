// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmAboutUsMenu
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmAboutUsMenu : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Panel2")]
  private Panel _Panel2;
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
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("lblAMCPeriod")]
  private Label _lblAMCPeriod;
  [AccessedThroughProperty("lblHDNo")]
  private Label _lblHDNo;
  [AccessedThroughProperty("lblAddress")]
  private Label _lblAddress;
  [AccessedThroughProperty("lblEmailId")]
  private Label _lblEmailId;
  [AccessedThroughProperty("LblMobileNo")]
  private Label _LblMobileNo;
  [AccessedThroughProperty("LblClientCode")]
  private Label _LblClientCode;
  [AccessedThroughProperty("lblClientName")]
  private Label _lblClientName;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("grpInfo")]
  private GroupBox _grpInfo;

  [DebuggerNonUserCode]
  static frmAboutUsMenu()
  {
  }

  [DebuggerNonUserCode]
  public frmAboutUsMenu()
  {
    this.KeyDown += new KeyEventHandler(this.frmAboutUsMenu_KeyDown);
    this.Load += new EventHandler(this.frmAboutUsMenu_Load);
    frmAboutUsMenu.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmAboutUsMenu.__ENCList)
    {
      if (frmAboutUsMenu.__ENCList.Count == frmAboutUsMenu.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmAboutUsMenu.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmAboutUsMenu.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmAboutUsMenu.__ENCList[index1] = frmAboutUsMenu.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmAboutUsMenu.__ENCList.RemoveRange(index1, checked (frmAboutUsMenu.__ENCList.Count - index1));
        frmAboutUsMenu.__ENCList.Capacity = frmAboutUsMenu.__ENCList.Count;
      }
      frmAboutUsMenu.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAboutUsMenu));
    this.Label4 = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Panel2 = new Panel();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label9 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.Label19 = new Label();
    this.lblAMCPeriod = new Label();
    this.lblHDNo = new Label();
    this.lblAddress = new Label();
    this.lblEmailId = new Label();
    this.LblMobileNo = new Label();
    this.LblClientCode = new Label();
    this.lblClientName = new Label();
    this.Button1 = new Button();
    this.grpInfo = new GroupBox();
    this.Panel2.SuspendLayout();
    this.grpInfo.SuspendLayout();
    this.SuspendLayout();
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Black;
    Label label4_1 = this.Label4;
    Point point1 = new Point(98, 16 /*0x10*/);
    Point point2 = point1;
    label4_1.Location = point2;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    Size size1 = new Size(395, 26);
    Size size2 = size1;
    label4_2.Size = size2;
    this.Label4.TabIndex = 77;
    this.Label4.Text = "CLIENT REGISTRATION DETAILS";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.Black;
    Label label1_1 = this.Label1;
    point1 = new Point(29, 73);
    Point point3 = point1;
    label1_1.Location = point3;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(58, 22);
    Size size3 = size1;
    label1_2.Size = size3;
    this.Label1.TabIndex = 78;
    this.Label1.Text = "Name";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Black;
    Label label2_1 = this.Label2;
    point1 = new Point(29, 111);
    Point point4 = point1;
    label2_1.Location = point4;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(53, 22);
    Size size4 = size1;
    label2_2.Size = size4;
    this.Label2.TabIndex = 79;
    this.Label2.Text = "Code";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.Black;
    Label label3_1 = this.Label3;
    point1 = new Point(29, 149);
    Point point5 = point1;
    label3_1.Location = point5;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(104, 22);
    Size size5 = size1;
    label3_2.Size = size5;
    this.Label3.TabIndex = 80 /*0x50*/;
    this.Label3.Text = "Contact No";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.Black;
    Label label5_1 = this.Label5;
    point1 = new Point(29, 187);
    Point point6 = point1;
    label5_1.Location = point6;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(80 /*0x50*/, 22);
    Size size6 = size1;
    label5_2.Size = size6;
    this.Label5.TabIndex = 81;
    this.Label5.Text = "Email Id";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.Black;
    Label label6_1 = this.Label6;
    point1 = new Point(29, 301);
    Point point7 = point1;
    label6_1.Location = point7;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(76, 22);
    Size size7 = size1;
    label6_2.Size = size7;
    this.Label6.TabIndex = 82;
    this.Label6.Text = "Address";
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.Black;
    Label label7_1 = this.Label7;
    point1 = new Point(29, 225);
    Point point8 = point1;
    label7_1.Location = point8;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(77, 22);
    Size size8 = size1;
    label7_2.Size = size8;
    this.Label7.TabIndex = 83;
    this.Label7.Text = "H.D.No.";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label8.ForeColor = Color.Black;
    Label label8_1 = this.Label8;
    point1 = new Point(29, 263);
    Point point9 = point1;
    label8_1.Location = point9;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(129, 22);
    Size size9 = size1;
    label8_2.Size = size9;
    this.Label8.TabIndex = 84;
    this.Label8.Text = "Service Expire";
    this.Panel2.BackColor = Color.Transparent;
    this.Panel2.Controls.Add((Control) this.Label10);
    this.Panel2.Controls.Add((Control) this.Label11);
    this.Panel2.Controls.Add((Control) this.Label12);
    this.Panel2.Controls.Add((Control) this.Label9);
    this.Panel2.ForeColor = Color.Black;
    Panel panel2_1 = this.Panel2;
    point1 = new Point(2, 394);
    Point point10 = point1;
    panel2_1.Location = point10;
    this.Panel2.Name = "Panel2";
    Panel panel2_2 = this.Panel2;
    size1 = new Size(538, 79);
    Size size10 = size1;
    panel2_2.Size = size10;
    this.Panel2.TabIndex = 98;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.Black;
    Label label10_1 = this.Label10;
    point1 = new Point(5, 39);
    Point point11 = point1;
    label10_1.Location = point11;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(530, 15);
    Size size11 = size1;
    label10_2.Size = size11;
    this.Label10.TabIndex = 98;
    this.Label10.Text = "379/D-43(Part-2), Sugam Co-op. Hsg. Soc. Ltd, Sector-3, Charkop, Kandiwali (W), Mumbai - 400 067.";
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label11.ForeColor = Color.Black;
    Label label11_1 = this.Label11;
    point1 = new Point(73, 13);
    Point point12 = point1;
    label11_1.Location = point12;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(392, 24);
    Size size12 = size1;
    label11_2.Size = size12;
    this.Label11.TabIndex = 97;
    this.Label11.Text = "MAULI SOFTWARE && ACCOUNTS LLP";
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Font = new Font("Times New Roman", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label12.ForeColor = Color.Black;
    Label label12_1 = this.Label12;
    point1 = new Point(0, -2);
    Point point13 = point1;
    label12_1.Location = point13;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(146, 13);
    Size size13 = size1;
    label12_2.Size = size13;
    this.Label12.TabIndex = 96 /*0x60*/;
    this.Label12.Text = "Developed &&  Marketed by ";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.Black;
    Label label9_1 = this.Label9;
    point1 = new Point(79, 55);
    Point point14 = point1;
    label9_1.Location = point14;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(348, 15);
    Size size14 = size1;
    label9_2.Size = size14;
    this.Label9.TabIndex = 81;
    this.Label9.Text = "9869045370 / 9969507742 Email ID : maulisoftware07@gmail.com";
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label13.ForeColor = Color.Black;
    Label label13_1 = this.Label13;
    point1 = new Point(162, 73);
    Point point15 = point1;
    label13_1.Location = point15;
    this.Label13.Name = "Label13";
    Label label13_2 = this.Label13;
    size1 = new Size(15, 22);
    Size size15 = size1;
    label13_2.Size = size15;
    this.Label13.TabIndex = 99;
    this.Label13.Text = ":";
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label14.ForeColor = Color.Black;
    Label label14_1 = this.Label14;
    point1 = new Point(162, 111);
    Point point16 = point1;
    label14_1.Location = point16;
    this.Label14.Name = "Label14";
    Label label14_2 = this.Label14;
    size1 = new Size(15, 22);
    Size size16 = size1;
    label14_2.Size = size16;
    this.Label14.TabIndex = 100;
    this.Label14.Text = ":";
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label15.ForeColor = Color.Black;
    Label label15_1 = this.Label15;
    point1 = new Point(162, 149);
    Point point17 = point1;
    label15_1.Location = point17;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(15, 22);
    Size size17 = size1;
    label15_2.Size = size17;
    this.Label15.TabIndex = 101;
    this.Label15.Text = ":";
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label16.ForeColor = Color.Black;
    Label label16_1 = this.Label16;
    point1 = new Point(162, 187);
    Point point18 = point1;
    label16_1.Location = point18;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(15, 22);
    Size size18 = size1;
    label16_2.Size = size18;
    this.Label16.TabIndex = 102;
    this.Label16.Text = ":";
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label17.ForeColor = Color.Black;
    Label label17_1 = this.Label17;
    point1 = new Point(162, 301);
    Point point19 = point1;
    label17_1.Location = point19;
    this.Label17.Name = "Label17";
    Label label17_2 = this.Label17;
    size1 = new Size(15, 22);
    Size size19 = size1;
    label17_2.Size = size19;
    this.Label17.TabIndex = 103;
    this.Label17.Text = ":";
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label18.ForeColor = Color.Black;
    Label label18_1 = this.Label18;
    point1 = new Point(162, 225);
    Point point20 = point1;
    label18_1.Location = point20;
    this.Label18.Name = "Label18";
    Label label18_2 = this.Label18;
    size1 = new Size(15, 22);
    Size size20 = size1;
    label18_2.Size = size20;
    this.Label18.TabIndex = 104;
    this.Label18.Text = ":";
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label19.ForeColor = Color.Black;
    Label label19_1 = this.Label19;
    point1 = new Point(162, 263);
    Point point21 = point1;
    label19_1.Location = point21;
    this.Label19.Name = "Label19";
    Label label19_2 = this.Label19;
    size1 = new Size(15, 22);
    Size size21 = size1;
    label19_2.Size = size21;
    this.Label19.TabIndex = 105;
    this.Label19.Text = ":";
    this.lblAMCPeriod.AutoSize = true;
    this.lblAMCPeriod.BackColor = Color.Transparent;
    this.lblAMCPeriod.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblAMCPeriod.ForeColor = Color.Black;
    Label lblAmcPeriod1 = this.lblAMCPeriod;
    point1 = new Point(190, 263);
    Point point22 = point1;
    lblAmcPeriod1.Location = point22;
    this.lblAMCPeriod.Name = "lblAMCPeriod";
    Label lblAmcPeriod2 = this.lblAMCPeriod;
    size1 = new Size(58, 22);
    Size size22 = size1;
    lblAmcPeriod2.Size = size22;
    this.lblAMCPeriod.TabIndex = 112 /*0x70*/;
    this.lblAMCPeriod.Text = "Name";
    this.lblHDNo.AutoSize = true;
    this.lblHDNo.BackColor = Color.Transparent;
    this.lblHDNo.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblHDNo.ForeColor = Color.Black;
    Label lblHdNo1 = this.lblHDNo;
    point1 = new Point(190, 225);
    Point point23 = point1;
    lblHdNo1.Location = point23;
    this.lblHDNo.Name = "lblHDNo";
    Label lblHdNo2 = this.lblHDNo;
    size1 = new Size(58, 22);
    Size size23 = size1;
    lblHdNo2.Size = size23;
    this.lblHDNo.TabIndex = 111;
    this.lblHDNo.Text = "Name";
    this.lblAddress.AutoSize = true;
    this.lblAddress.BackColor = Color.Transparent;
    this.lblAddress.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblAddress.ForeColor = Color.Black;
    Label lblAddress1 = this.lblAddress;
    point1 = new Point(190, 301);
    Point point24 = point1;
    lblAddress1.Location = point24;
    Label lblAddress2 = this.lblAddress;
    size1 = new Size(325, 100);
    Size size24 = size1;
    lblAddress2.MaximumSize = size24;
    this.lblAddress.Name = "lblAddress";
    Label lblAddress3 = this.lblAddress;
    size1 = new Size(58, 22);
    Size size25 = size1;
    lblAddress3.Size = size25;
    this.lblAddress.TabIndex = 110;
    this.lblAddress.Text = "Name";
    this.lblEmailId.AutoSize = true;
    this.lblEmailId.BackColor = Color.Transparent;
    this.lblEmailId.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblEmailId.ForeColor = Color.Black;
    Label lblEmailId1 = this.lblEmailId;
    point1 = new Point(190, 187);
    Point point25 = point1;
    lblEmailId1.Location = point25;
    this.lblEmailId.Name = "lblEmailId";
    Label lblEmailId2 = this.lblEmailId;
    size1 = new Size(58, 22);
    Size size26 = size1;
    lblEmailId2.Size = size26;
    this.lblEmailId.TabIndex = 109;
    this.lblEmailId.Text = "Name";
    this.LblMobileNo.AutoSize = true;
    this.LblMobileNo.BackColor = Color.Transparent;
    this.LblMobileNo.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.LblMobileNo.ForeColor = Color.Black;
    Label lblMobileNo1 = this.LblMobileNo;
    point1 = new Point(190, 149);
    Point point26 = point1;
    lblMobileNo1.Location = point26;
    this.LblMobileNo.Name = "LblMobileNo";
    Label lblMobileNo2 = this.LblMobileNo;
    size1 = new Size(58, 22);
    Size size27 = size1;
    lblMobileNo2.Size = size27;
    this.LblMobileNo.TabIndex = 108;
    this.LblMobileNo.Text = "Name";
    this.LblClientCode.AutoSize = true;
    this.LblClientCode.BackColor = Color.Transparent;
    this.LblClientCode.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.LblClientCode.ForeColor = Color.Black;
    Label lblClientCode1 = this.LblClientCode;
    point1 = new Point(190, 111);
    Point point27 = point1;
    lblClientCode1.Location = point27;
    this.LblClientCode.Name = "LblClientCode";
    Label lblClientCode2 = this.LblClientCode;
    size1 = new Size(58, 22);
    Size size28 = size1;
    lblClientCode2.Size = size28;
    this.LblClientCode.TabIndex = 107;
    this.LblClientCode.Text = "Name";
    this.lblClientName.AutoSize = true;
    this.lblClientName.BackColor = Color.Transparent;
    this.lblClientName.Font = new Font("Times New Roman", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblClientName.ForeColor = Color.Black;
    Label lblClientName1 = this.lblClientName;
    point1 = new Point(190, 73);
    Point point28 = point1;
    lblClientName1.Location = point28;
    this.lblClientName.Name = "lblClientName";
    Label lblClientName2 = this.lblClientName;
    size1 = new Size(58, 22);
    Size size29 = size1;
    lblClientName2.Size = size29;
    this.lblClientName.TabIndex = 106;
    this.lblClientName.Text = "Name";
    this.Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button1_1 = this.Button1;
    point1 = new Point(192 /*0xC0*/, 482);
    Point point29 = point1;
    button1_1.Location = point29;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(168, 64 /*0x40*/);
    Size size30 = size1;
    button1_2.Size = size30;
    this.Button1.TabIndex = 113;
    this.Button1.Text = "Registration Info on/off";
    this.Button1.UseVisualStyleBackColor = true;
    this.grpInfo.Controls.Add((Control) this.Label4);
    this.grpInfo.Controls.Add((Control) this.Label1);
    this.grpInfo.Controls.Add((Control) this.lblAMCPeriod);
    this.grpInfo.Controls.Add((Control) this.Label2);
    this.grpInfo.Controls.Add((Control) this.lblHDNo);
    this.grpInfo.Controls.Add((Control) this.Label3);
    this.grpInfo.Controls.Add((Control) this.lblAddress);
    this.grpInfo.Controls.Add((Control) this.Label5);
    this.grpInfo.Controls.Add((Control) this.lblEmailId);
    this.grpInfo.Controls.Add((Control) this.Label6);
    this.grpInfo.Controls.Add((Control) this.LblMobileNo);
    this.grpInfo.Controls.Add((Control) this.Label7);
    this.grpInfo.Controls.Add((Control) this.LblClientCode);
    this.grpInfo.Controls.Add((Control) this.Label8);
    this.grpInfo.Controls.Add((Control) this.lblClientName);
    this.grpInfo.Controls.Add((Control) this.Panel2);
    this.grpInfo.Controls.Add((Control) this.Label19);
    this.grpInfo.Controls.Add((Control) this.Label13);
    this.grpInfo.Controls.Add((Control) this.Label18);
    this.grpInfo.Controls.Add((Control) this.Label14);
    this.grpInfo.Controls.Add((Control) this.Label17);
    this.grpInfo.Controls.Add((Control) this.Label15);
    this.grpInfo.Controls.Add((Control) this.Label16);
    GroupBox grpInfo1 = this.grpInfo;
    point1 = new Point(0, 0);
    Point point30 = point1;
    grpInfo1.Location = point30;
    this.grpInfo.Name = "grpInfo";
    GroupBox grpInfo2 = this.grpInfo;
    size1 = new Size(540, 476);
    Size size31 = size1;
    grpInfo2.Size = size31;
    this.grpInfo.TabIndex = 114;
    this.grpInfo.TabStop = false;
    this.grpInfo.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.AppWorkspace;
    this.BackgroundImageLayout = ImageLayout.Stretch;
    size1 = new Size(540, 550);
    this.ClientSize = size1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.grpInfo);
    this.Controls.Add((Control) this.Button1);
    this.FormBorderStyle = FormBorderStyle.None;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAboutUsMenu);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "About Us";
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    this.grpInfo.ResumeLayout(false);
    this.grpInfo.PerformLayout();
    this.ResumeLayout(false);
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
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

  internal virtual Panel Panel2
  {
    [DebuggerNonUserCode] get => this._Panel2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel2 = value;
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

  internal virtual Label Label19
  {
    [DebuggerNonUserCode] get => this._Label19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
  }

  internal virtual Label lblAMCPeriod
  {
    [DebuggerNonUserCode] get => this._lblAMCPeriod;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAMCPeriod = value;
    }
  }

  internal virtual Label lblHDNo
  {
    [DebuggerNonUserCode] get => this._lblHDNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblHDNo = value;
  }

  internal virtual Label lblAddress
  {
    [DebuggerNonUserCode] get => this._lblAddress;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAddress = value;
    }
  }

  internal virtual Label lblEmailId
  {
    [DebuggerNonUserCode] get => this._lblEmailId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblEmailId = value;
    }
  }

  internal virtual Label LblMobileNo
  {
    [DebuggerNonUserCode] get => this._LblMobileNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._LblMobileNo = value;
    }
  }

  internal virtual Label LblClientCode
  {
    [DebuggerNonUserCode] get => this._LblClientCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._LblClientCode = value;
    }
  }

  internal virtual Label lblClientName
  {
    [DebuggerNonUserCode] get => this._lblClientName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblClientName = value;
    }
  }

  internal virtual Button Button1
  {
    [DebuggerNonUserCode] get => this._Button1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button1_Click);
      if (this._Button1 != null)
        this._Button1.Click -= eventHandler;
      this._Button1 = value;
      if (this._Button1 == null)
        return;
      this._Button1.Click += eventHandler;
    }
  }

  internal virtual GroupBox grpInfo
  {
    [DebuggerNonUserCode] get => this._grpInfo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._grpInfo = value;
  }

  private void frmAboutUsMenu_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmAboutUsMenu_Load(object sender, EventArgs e)
  {
    this.LblClientCode.Text = Constant.SoftSrno.Trim();
    this.lblClientName.Text = Constant.vCliName.Trim();
    this.LblMobileNo.Text = Constant.ClientMobile.Trim();
    this.lblEmailId.Text = Constant.ClientEmail.Trim();
    this.lblAddress.Text = Constant.ClientAddress.Trim();
    this.lblHDNo.Text = Constant.ClientHDNO.Trim();
    this.lblAMCPeriod.Text = Constant.ClientAMCEnd.Trim();
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    if (!this.grpInfo.Visible)
      this.grpInfo.Visible = true;
    else
      this.grpInfo.Visible = false;
  }
}
