// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmAboutUs
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
public class frmAboutUs : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtProductVersion")]
  private TextBox _txtProductVersion;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("mtxtTestDate")]
  private MaskedTextBox _mtxtTestDate;
  [AccessedThroughProperty("txtClientCode")]
  private TextBox _txtClientCode;
  [AccessedThroughProperty("txtClientName")]
  private TextBox _txtClientName;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Panel1")]
  private Panel _Panel1;
  [AccessedThroughProperty("Panel2")]
  private Panel _Panel2;
  [AccessedThroughProperty("Panel3")]
  private Panel _Panel3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("MaskedTextBox1")]
  private MaskedTextBox _MaskedTextBox1;
  [AccessedThroughProperty("txtMobileNo")]
  private TextBox _txtMobileNo;
  [AccessedThroughProperty("txtEmailId")]
  private TextBox _txtEmailId;
  [AccessedThroughProperty("txtAddress")]
  private TextBox _txtAddress;
  [AccessedThroughProperty("txtHardDiskNo")]
  private TextBox _txtHardDiskNo;
  [AccessedThroughProperty("txtServicePriod")]
  private TextBox _txtServicePriod;
  [AccessedThroughProperty("TextBox1")]
  private TextBox _TextBox1;
  [AccessedThroughProperty("TextBox2")]
  private TextBox _TextBox2;
  [AccessedThroughProperty("TextBox3")]
  private TextBox _TextBox3;
  [AccessedThroughProperty("TextBox4")]
  private TextBox _TextBox4;
  [AccessedThroughProperty("TextBox5")]
  private TextBox _TextBox5;
  [AccessedThroughProperty("TextBox6")]
  private TextBox _TextBox6;

  [DebuggerNonUserCode]
  static frmAboutUs()
  {
  }

  [DebuggerNonUserCode]
  public frmAboutUs()
  {
    this.Load += new EventHandler(this.frmAboutUs_Load);
    this.KeyDown += new KeyEventHandler(this.frmAboutUs_KeyDown);
    frmAboutUs.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmAboutUs.__ENCList)
    {
      if (frmAboutUs.__ENCList.Count == frmAboutUs.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmAboutUs.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmAboutUs.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmAboutUs.__ENCList[index1] = frmAboutUs.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmAboutUs.__ENCList.RemoveRange(index1, checked (frmAboutUs.__ENCList.Count - index1));
        frmAboutUs.__ENCList.Capacity = frmAboutUs.__ENCList.Count;
      }
      frmAboutUs.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAboutUs));
    this.txtProductVersion = new TextBox();
    this.Label1 = new Label();
    this.mtxtTestDate = new MaskedTextBox();
    this.txtClientCode = new TextBox();
    this.txtClientName = new TextBox();
    this.Label5 = new Label();
    this.Label3 = new Label();
    this.Label6 = new Label();
    this.Label2 = new Label();
    this.Panel1 = new Panel();
    this.Panel2 = new Panel();
    this.Panel3 = new Panel();
    this.Label4 = new Label();
    this.MaskedTextBox1 = new MaskedTextBox();
    this.txtMobileNo = new TextBox();
    this.txtEmailId = new TextBox();
    this.txtAddress = new TextBox();
    this.txtHardDiskNo = new TextBox();
    this.txtServicePriod = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    this.Panel3.SuspendLayout();
    this.SuspendLayout();
    this.txtProductVersion.BackColor = SystemColors.InactiveCaption;
    this.txtProductVersion.BorderStyle = BorderStyle.None;
    this.txtProductVersion.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtProductVersion.ForeColor = Color.Gold;
    TextBox txtProductVersion1 = this.txtProductVersion;
    Point point1 = new Point(88, 157);
    Point point2 = point1;
    txtProductVersion1.Location = point2;
    this.txtProductVersion.Name = "txtProductVersion";
    TextBox txtProductVersion2 = this.txtProductVersion;
    Size size1 = new Size(413, 22);
    Size size2 = size1;
    txtProductVersion2.Size = size2;
    this.txtProductVersion.TabIndex = 101;
    this.txtProductVersion.TabStop = false;
    this.txtProductVersion.Text = "Version : 2025.26";
    this.txtProductVersion.TextAlign = HorizontalAlignment.Center;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = SystemColors.Desktop;
    this.Label1.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.GhostWhite;
    Label label1_1 = this.Label1;
    point1 = new Point(181, 12);
    Point point3 = point1;
    label1_1.Location = point3;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(232, 26);
    Size size3 = size1;
    label1_2.Size = size3;
    this.Label1.TabIndex = 76;
    this.Label1.Text = "MAULI SOFTWARE";
    this.mtxtTestDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtTestDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtTestDate1 = this.mtxtTestDate;
    point1 = new Point(267, 13);
    Point point4 = point1;
    mtxtTestDate1.Location = point4;
    this.mtxtTestDate.Mask = "00/00/0000";
    this.mtxtTestDate.Name = "mtxtTestDate";
    MaskedTextBox mtxtTestDate2 = this.mtxtTestDate;
    size1 = new Size(77, 22);
    Size size4 = size1;
    mtxtTestDate2.Size = size4;
    this.mtxtTestDate.TabIndex = 87;
    this.mtxtTestDate.Text = "01042014";
    this.mtxtTestDate.ValidatingType = typeof (DateTime);
    this.txtClientCode.BackColor = SystemColors.InactiveCaption;
    this.txtClientCode.BorderStyle = BorderStyle.None;
    this.txtClientCode.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtClientCode.ForeColor = Color.Gold;
    TextBox txtClientCode1 = this.txtClientCode;
    point1 = new Point(88, 128 /*0x80*/);
    Point point5 = point1;
    txtClientCode1.Location = point5;
    this.txtClientCode.Name = "txtClientCode";
    TextBox txtClientCode2 = this.txtClientCode;
    size1 = new Size(413, 22);
    Size size5 = size1;
    txtClientCode2.Size = size5;
    this.txtClientCode.TabIndex = 100;
    this.txtClientCode.TabStop = false;
    this.txtClientCode.Text = "00000";
    this.txtClientCode.TextAlign = HorizontalAlignment.Center;
    this.txtClientName.BackColor = SystemColors.InactiveCaption;
    this.txtClientName.BorderStyle = BorderStyle.None;
    this.txtClientName.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtClientName.ForeColor = Color.Gold;
    TextBox txtClientName1 = this.txtClientName;
    point1 = new Point(89, 97);
    Point point6 = point1;
    txtClientName1.Location = point6;
    this.txtClientName.Name = "txtClientName";
    TextBox txtClientName2 = this.txtClientName;
    size1 = new Size(413, 22);
    Size size6 = size1;
    txtClientName2.Size = size6;
    this.txtClientName.TabIndex = 99;
    this.txtClientName.TabStop = false;
    this.txtClientName.Text = "DEMO";
    this.txtClientName.TextAlign = HorizontalAlignment.Center;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = SystemColors.Desktop;
    this.Label5.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.GhostWhite;
    Label label5_1 = this.Label5;
    point1 = new Point(26, 500);
    Point point7 = point1;
    label5_1.Location = point7;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(530, 15);
    Size size7 = size1;
    label5_2.Size = size7;
    this.Label5.TabIndex = 95;
    this.Label5.Text = "379/D-43(Part-2), Sugam Co-op. Hsg. Soc. Ltd, Sector-3, Charkop, Kandiwali (W), Mumbai - 400 067.";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = SystemColors.Desktop;
    this.Label3.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.GhostWhite;
    Label label3_1 = this.Label3;
    point1 = new Point(100, 478);
    Point point8 = point1;
    label3_1.Location = point8;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(392, 24);
    Size size8 = size1;
    label3_2.Size = size8;
    this.Label3.TabIndex = 94;
    this.Label3.Text = "MAULI SOFTWARE && ACCOUNTS LLP";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = SystemColors.Desktop;
    this.Label6.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.GhostWhite;
    Label label6_1 = this.Label6;
    point1 = new Point(107, 51);
    Point point9 = point1;
    label6_1.Location = point9;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(348, 15);
    Size size9 = size1;
    label6_2.Size = size9;
    this.Label6.TabIndex = 81;
    this.Label6.Text = "9869045370 / 9969507742 Email ID : maulisoftware07@gmail.com";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = SystemColors.Desktop;
    this.Label2.Font = new Font("Times New Roman", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.GhostWhite;
    Label label2_1 = this.Label2;
    point1 = new Point(4, 466);
    Point point10 = point1;
    label2_1.Location = point10;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(146, 13);
    Size size10 = size1;
    label2_2.Size = size10;
    this.Label2.TabIndex = 93;
    this.Label2.Text = "Developed &&  Marketed by ";
    this.Panel1.BackColor = SystemColors.Desktop;
    this.Panel1.Controls.Add((Control) this.Label1);
    this.Panel1.Controls.Add((Control) this.mtxtTestDate);
    Panel panel1_1 = this.Panel1;
    point1 = new Point(-2, 19);
    Point point11 = point1;
    panel1_1.Location = point11;
    this.Panel1.Name = "Panel1";
    Panel panel1_2 = this.Panel1;
    size1 = new Size(597, 50);
    Size size11 = size1;
    panel1_2.Size = size11;
    this.Panel1.TabIndex = 96 /*0x60*/;
    this.Panel2.BackColor = SystemColors.Desktop;
    this.Panel2.Controls.Add((Control) this.Label6);
    Panel panel2_1 = this.Panel2;
    point1 = new Point(-1, 463);
    Point point12 = point1;
    panel2_1.Location = point12;
    this.Panel2.Name = "Panel2";
    Panel panel2_2 = this.Panel2;
    size1 = new Size(595, 79);
    Size size12 = size1;
    panel2_2.Size = size12;
    this.Panel2.TabIndex = 97;
    this.Panel3.BackColor = SystemColors.Desktop;
    this.Panel3.Controls.Add((Control) this.Label4);
    this.Panel3.Controls.Add((Control) this.MaskedTextBox1);
    Panel panel3_1 = this.Panel3;
    point1 = new Point(-1, 208 /*0xD0*/);
    Point point13 = point1;
    panel3_1.Location = point13;
    this.Panel3.Name = "Panel3";
    Panel panel3_2 = this.Panel3;
    size1 = new Size(597, 263);
    Size size13 = size1;
    panel3_2.Size = size13;
    this.Panel3.TabIndex = 102;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = SystemColors.Desktop;
    this.Label4.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.GhostWhite;
    Label label4_1 = this.Label4;
    point1 = new Point(181, 12);
    Point point14 = point1;
    label4_1.Location = point14;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(209, 26);
    Size size14 = size1;
    label4_2.Size = size14;
    this.Label4.TabIndex = 76;
    this.Label4.Text = "CLIENT DETAILS";
    this.MaskedTextBox1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.MaskedTextBox1.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox maskedTextBox1_1 = this.MaskedTextBox1;
    point1 = new Point(267, 13);
    Point point15 = point1;
    maskedTextBox1_1.Location = point15;
    this.MaskedTextBox1.Mask = "00/00/0000";
    this.MaskedTextBox1.Name = "MaskedTextBox1";
    MaskedTextBox maskedTextBox1_2 = this.MaskedTextBox1;
    size1 = new Size(77, 22);
    Size size15 = size1;
    maskedTextBox1_2.Size = size15;
    this.MaskedTextBox1.TabIndex = 87;
    this.MaskedTextBox1.Text = "01042014";
    this.MaskedTextBox1.ValidatingType = typeof (DateTime);
    this.txtMobileNo.BackColor = SystemColors.Desktop;
    this.txtMobileNo.BorderStyle = BorderStyle.None;
    this.txtMobileNo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtMobileNo.ForeColor = Color.GhostWhite;
    TextBox txtMobileNo1 = this.txtMobileNo;
    point1 = new Point(154, 276);
    Point point16 = point1;
    txtMobileNo1.Location = point16;
    this.txtMobileNo.Name = "txtMobileNo";
    TextBox txtMobileNo2 = this.txtMobileNo;
    size1 = new Size(277, 19);
    Size size16 = size1;
    txtMobileNo2.Size = size16;
    this.txtMobileNo.TabIndex = 103;
    this.txtMobileNo.TabStop = false;
    this.txtMobileNo.Text = "0000000000";
    this.txtEmailId.BackColor = SystemColors.Desktop;
    this.txtEmailId.BorderStyle = BorderStyle.None;
    this.txtEmailId.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtEmailId.ForeColor = Color.GhostWhite;
    TextBox txtEmailId1 = this.txtEmailId;
    point1 = new Point(154, 309);
    Point point17 = point1;
    txtEmailId1.Location = point17;
    this.txtEmailId.Name = "txtEmailId";
    TextBox txtEmailId2 = this.txtEmailId;
    size1 = new Size(432, 19);
    Size size17 = size1;
    txtEmailId2.Size = size17;
    this.txtEmailId.TabIndex = 104;
    this.txtEmailId.TabStop = false;
    this.txtEmailId.Text = "samcomputers07@gmail.com";
    this.txtAddress.BackColor = SystemColors.Desktop;
    this.txtAddress.BorderStyle = BorderStyle.None;
    this.txtAddress.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtAddress.ForeColor = Color.GhostWhite;
    TextBox txtAddress1 = this.txtAddress;
    point1 = new Point(154, 344);
    Point point18 = point1;
    txtAddress1.Location = point18;
    this.txtAddress.Multiline = true;
    this.txtAddress.Name = "txtAddress";
    TextBox txtAddress2 = this.txtAddress;
    size1 = new Size(432, 49);
    Size size18 = size1;
    txtAddress2.Size = size18;
    this.txtAddress.TabIndex = 105;
    this.txtAddress.TabStop = false;
    this.txtAddress.Text = "-------";
    this.txtHardDiskNo.BackColor = SystemColors.Desktop;
    this.txtHardDiskNo.BorderStyle = BorderStyle.None;
    this.txtHardDiskNo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtHardDiskNo.ForeColor = Color.GhostWhite;
    TextBox txtHardDiskNo1 = this.txtHardDiskNo;
    point1 = new Point(154, 399);
    Point point19 = point1;
    txtHardDiskNo1.Location = point19;
    this.txtHardDiskNo.Name = "txtHardDiskNo";
    TextBox txtHardDiskNo2 = this.txtHardDiskNo;
    size1 = new Size(432, 19);
    Size size19 = size1;
    txtHardDiskNo2.Size = size19;
    this.txtHardDiskNo.TabIndex = 106;
    this.txtHardDiskNo.TabStop = false;
    this.txtHardDiskNo.Text = "00000000";
    this.txtServicePriod.BackColor = SystemColors.Desktop;
    this.txtServicePriod.BorderStyle = BorderStyle.None;
    this.txtServicePriod.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtServicePriod.ForeColor = Color.GhostWhite;
    TextBox txtServicePriod1 = this.txtServicePriod;
    point1 = new Point(155, 432);
    Point point20 = point1;
    txtServicePriod1.Location = point20;
    this.txtServicePriod.Name = "txtServicePriod";
    TextBox txtServicePriod2 = this.txtServicePriod;
    size1 = new Size(432, 19);
    Size size20 = size1;
    txtServicePriod2.Size = size20;
    this.txtServicePriod.TabIndex = 107;
    this.txtServicePriod.Text = "00/00/0000";
    this.TextBox1.BackColor = SystemColors.Desktop;
    this.TextBox1.BorderStyle = BorderStyle.None;
    this.TextBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.Yellow;
    TextBox textBox1_1 = this.TextBox1;
    point1 = new Point(25, 432);
    Point point21 = point1;
    textBox1_1.Location = point21;
    this.TextBox1.Name = "TextBox1";
    TextBox textBox1_2 = this.TextBox1;
    size1 = new Size(123, 19);
    Size size21 = size1;
    textBox1_2.Size = size21;
    this.TextBox1.TabIndex = 112 /*0x70*/;
    this.TextBox1.Text = "AMC Expire";
    this.TextBox2.BackColor = SystemColors.Desktop;
    this.TextBox2.BorderStyle = BorderStyle.None;
    this.TextBox2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.Yellow;
    TextBox textBox2_1 = this.TextBox2;
    point1 = new Point(25, 399);
    Point point22 = point1;
    textBox2_1.Location = point22;
    this.TextBox2.Name = "TextBox2";
    TextBox textBox2_2 = this.TextBox2;
    size1 = new Size(123, 19);
    Size size22 = size1;
    textBox2_2.Size = size22;
    this.TextBox2.TabIndex = 111;
    this.TextBox2.TabStop = false;
    this.TextBox2.Text = "H.Disk No.";
    this.TextBox3.BackColor = SystemColors.Desktop;
    this.TextBox3.BorderStyle = BorderStyle.None;
    this.TextBox3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox3.ForeColor = Color.Yellow;
    TextBox textBox3_1 = this.TextBox3;
    point1 = new Point(25, 344);
    Point point23 = point1;
    textBox3_1.Location = point23;
    this.TextBox3.Name = "TextBox3";
    TextBox textBox3_2 = this.TextBox3;
    size1 = new Size(123, 19);
    Size size23 = size1;
    textBox3_2.Size = size23;
    this.TextBox3.TabIndex = 110;
    this.TextBox3.TabStop = false;
    this.TextBox3.Text = "Address";
    this.TextBox4.BackColor = SystemColors.Desktop;
    this.TextBox4.BorderStyle = BorderStyle.None;
    this.TextBox4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox4.ForeColor = Color.Yellow;
    TextBox textBox4_1 = this.TextBox4;
    point1 = new Point(25, 309);
    Point point24 = point1;
    textBox4_1.Location = point24;
    this.TextBox4.Name = "TextBox4";
    TextBox textBox4_2 = this.TextBox4;
    size1 = new Size(123, 19);
    Size size24 = size1;
    textBox4_2.Size = size24;
    this.TextBox4.TabIndex = 109;
    this.TextBox4.TabStop = false;
    this.TextBox4.Text = "EmailId";
    this.TextBox5.BackColor = SystemColors.Desktop;
    this.TextBox5.BorderStyle = BorderStyle.None;
    this.TextBox5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox5.ForeColor = Color.Yellow;
    TextBox textBox5_1 = this.TextBox5;
    point1 = new Point(25, 276);
    Point point25 = point1;
    textBox5_1.Location = point25;
    this.TextBox5.Name = "TextBox5";
    TextBox textBox5_2 = this.TextBox5;
    size1 = new Size(123, 19);
    Size size25 = size1;
    textBox5_2.Size = size25;
    this.TextBox5.TabIndex = 108;
    this.TextBox5.TabStop = false;
    this.TextBox5.Text = "Contact No.";
    this.TextBox6.BackColor = SystemColors.InactiveCaption;
    this.TextBox6.BorderStyle = BorderStyle.None;
    this.TextBox6.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox6.ForeColor = Color.Gold;
    TextBox textBox6_1 = this.TextBox6;
    point1 = new Point(468, 157);
    Point point26 = point1;
    textBox6_1.Location = point26;
    this.TextBox6.Name = "TextBox6";
    TextBox textBox6_2 = this.TextBox6;
    size1 = new Size(118, 22);
    Size size26 = size1;
    textBox6_2.Size = size26;
    this.TextBox6.TabIndex = 113;
    this.TextBox6.TabStop = false;
    this.TextBox6.Text = "(Statutory)";
    this.TextBox6.TextAlign = HorizontalAlignment.Center;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.InactiveCaption;
    size1 = new Size(595, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.TextBox6);
    this.Controls.Add((Control) this.TextBox1);
    this.Controls.Add((Control) this.TextBox2);
    this.Controls.Add((Control) this.TextBox3);
    this.Controls.Add((Control) this.TextBox4);
    this.Controls.Add((Control) this.TextBox5);
    this.Controls.Add((Control) this.txtServicePriod);
    this.Controls.Add((Control) this.txtHardDiskNo);
    this.Controls.Add((Control) this.txtAddress);
    this.Controls.Add((Control) this.txtEmailId);
    this.Controls.Add((Control) this.txtMobileNo);
    this.Controls.Add((Control) this.Panel3);
    this.Controls.Add((Control) this.txtProductVersion);
    this.Controls.Add((Control) this.txtClientCode);
    this.Controls.Add((Control) this.txtClientName);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.Panel2);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAboutUs);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "About Us";
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    this.Panel3.ResumeLayout(false);
    this.Panel3.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox txtProductVersion
  {
    [DebuggerNonUserCode] get => this._txtProductVersion;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtProductVersion = value;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual MaskedTextBox mtxtTestDate
  {
    [DebuggerNonUserCode] get => this._mtxtTestDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtTestDate = value;
    }
  }

  internal virtual TextBox txtClientCode
  {
    [DebuggerNonUserCode] get => this._txtClientCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtClientCode = value;
    }
  }

  internal virtual TextBox txtClientName
  {
    [DebuggerNonUserCode] get => this._txtClientName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtClientName = value;
    }
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual Panel Panel1
  {
    [DebuggerNonUserCode] get => this._Panel1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel1 = value;
  }

  internal virtual Panel Panel2
  {
    [DebuggerNonUserCode] get => this._Panel2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel2 = value;
  }

  internal virtual Panel Panel3
  {
    [DebuggerNonUserCode] get => this._Panel3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel3 = value;
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual MaskedTextBox MaskedTextBox1
  {
    [DebuggerNonUserCode] get => this._MaskedTextBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._MaskedTextBox1 = value;
    }
  }

  internal virtual TextBox txtMobileNo
  {
    [DebuggerNonUserCode] get => this._txtMobileNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMobileNo = value;
    }
  }

  internal virtual TextBox txtEmailId
  {
    [DebuggerNonUserCode] get => this._txtEmailId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtEmailId = value;
    }
  }

  internal virtual TextBox txtAddress
  {
    [DebuggerNonUserCode] get => this._txtAddress;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtAddress = value;
    }
  }

  internal virtual TextBox txtHardDiskNo
  {
    [DebuggerNonUserCode] get => this._txtHardDiskNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtHardDiskNo = value;
    }
  }

  internal virtual TextBox txtServicePriod
  {
    [DebuggerNonUserCode] get => this._txtServicePriod;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtServicePriod = value;
    }
  }

  internal virtual TextBox TextBox1
  {
    [DebuggerNonUserCode] get => this._TextBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox1 = value;
  }

  internal virtual TextBox TextBox2
  {
    [DebuggerNonUserCode] get => this._TextBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox2 = value;
  }

  internal virtual TextBox TextBox3
  {
    [DebuggerNonUserCode] get => this._TextBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox3 = value;
  }

  internal virtual TextBox TextBox4
  {
    [DebuggerNonUserCode] get => this._TextBox4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox4 = value;
  }

  internal virtual TextBox TextBox5
  {
    [DebuggerNonUserCode] get => this._TextBox5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox5 = value;
  }

  internal virtual TextBox TextBox6
  {
    [DebuggerNonUserCode] get => this._TextBox6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TextBox6 = value;
  }

  private void frmAboutUs_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmAboutUs_Load(object sender, EventArgs e)
  {
    this.txtClientCode.Text = Constant.SoftSrno.Trim();
    this.txtClientName.Text = Constant.vCliName.Trim();
    this.txtMobileNo.Text = Constant.ClientMobile.Trim();
    this.txtEmailId.Text = Constant.ClientEmail.Trim();
    this.txtAddress.Text = Constant.ClientAddress.Trim();
    this.txtHardDiskNo.Text = Constant.ClientHDNO.Trim();
    this.txtServicePriod.Text = Constant.ClientAMCEnd.Trim();
  }
}
