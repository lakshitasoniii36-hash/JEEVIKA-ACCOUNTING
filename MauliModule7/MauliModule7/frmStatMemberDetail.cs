// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatMemberDetail
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
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
public class frmStatMemberDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtElectionName3")]
  private TextBox _txtElectionName3;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("txtElectionName2")]
  private TextBox _txtElectionName2;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("txtElectionName1")]
  private TextBox _txtElectionName1;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("mtxtDOB")]
  private MaskedTextBox _mtxtDOB;
  [AccessedThroughProperty("txtGender")]
  private TextBox _txtGender;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("cmbActive")]
  private ComboBox _cmbActive;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("txtElectionName")]
  private TextBox _txtElectionName;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("cmbMemberType")]
  private ComboBox _cmbMemberType;
  [AccessedThroughProperty("txtConstCost")]
  private TextBox _txtConstCost;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("txtSFCont")]
  private TextBox _txtSFCont;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("txtCostofFlat")]
  private TextBox _txtCostofFlat;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("txtRAdd")]
  private TextBox _txtRAdd;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("txtPAdd")]
  private TextBox _txtPAdd;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("lblId")]
  private Label _lblId;
  [AccessedThroughProperty("txtFlatNo")]
  private TextBox _txtFlatNo;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("txtName3")]
  private TextBox _txtName3;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("txtName2")]
  private TextBox _txtName2;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("txtName1")]
  private TextBox _txtName1;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtName")]
  private TextBox _txtName;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("txtMemId")]
  private TextBox _txtMemId;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Button3")]
  private Button _Button3;
  [AccessedThroughProperty("Button4")]
  private Button _Button4;

  [DebuggerNonUserCode]
  static frmStatMemberDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmStatMemberDetail()
  {
    frmStatMemberDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatMemberDetail.__ENCList)
    {
      if (frmStatMemberDetail.__ENCList.Count == frmStatMemberDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatMemberDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatMemberDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatMemberDetail.__ENCList[index1] = frmStatMemberDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatMemberDetail.__ENCList.RemoveRange(index1, checked (frmStatMemberDetail.__ENCList.Count - index1));
        frmStatMemberDetail.__ENCList.Capacity = frmStatMemberDetail.__ENCList.Count;
      }
      frmStatMemberDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatMemberDetail));
    this.txtElectionName3 = new TextBox();
    this.Label20 = new Label();
    this.txtElectionName2 = new TextBox();
    this.Label19 = new Label();
    this.txtElectionName1 = new TextBox();
    this.Label18 = new Label();
    this.Label17 = new Label();
    this.mtxtDOB = new MaskedTextBox();
    this.txtGender = new TextBox();
    this.Label16 = new Label();
    this.cmbActive = new ComboBox();
    this.Label15 = new Label();
    this.Label14 = new Label();
    this.mtxtDateFrom = new MaskedTextBox();
    this.txtElectionName = new TextBox();
    this.Label13 = new Label();
    this.Label11 = new Label();
    this.cmbMemberType = new ComboBox();
    this.txtConstCost = new TextBox();
    this.Label6 = new Label();
    this.txtSFCont = new TextBox();
    this.Label10 = new Label();
    this.txtCostofFlat = new TextBox();
    this.Label12 = new Label();
    this.btnUpdate = new Button();
    this.btnDelete = new Button();
    this.txtRAdd = new TextBox();
    this.Label9 = new Label();
    this.txtPAdd = new TextBox();
    this.Label8 = new Label();
    this.lblId = new Label();
    this.txtFlatNo = new TextBox();
    this.Label7 = new Label();
    this.txtName3 = new TextBox();
    this.Label5 = new Label();
    this.txtName2 = new TextBox();
    this.Label4 = new Label();
    this.txtName1 = new TextBox();
    this.Label3 = new Label();
    this.txtName = new TextBox();
    this.Label2 = new Label();
    this.btnCancel = new Button();
    this.txtMemId = new TextBox();
    this.btnSave = new Button();
    this.Label1 = new Label();
    this.Button1 = new Button();
    this.Button2 = new Button();
    this.Button3 = new Button();
    this.Button4 = new Button();
    this.SuspendLayout();
    this.txtElectionName3.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtElectionName3_1 = this.txtElectionName3;
    Point point1 = new Point(222, 246);
    Point point2 = point1;
    txtElectionName3_1.Location = point2;
    TextBox txtElectionName3_2 = this.txtElectionName3;
    Padding padding1 = new Padding(4);
    Padding padding2 = padding1;
    txtElectionName3_2.Margin = padding2;
    this.txtElectionName3.MaxLength = (int) byte.MaxValue;
    this.txtElectionName3.Name = "txtElectionName3";
    TextBox txtElectionName3_3 = this.txtElectionName3;
    Size size1 = new Size(303, 23);
    Size size2 = size1;
    txtElectionName3_3.Size = size2;
    this.txtElectionName3.TabIndex = 8;
    this.Label20.AutoSize = true;
    this.Label20.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label20_1 = this.Label20;
    point1 = new Point(81, 249);
    Point point3 = point1;
    label20_1.Location = point3;
    Label label20_2 = this.Label20;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding3 = padding1;
    label20_2.Margin = padding3;
    this.Label20.Name = "Label20";
    Label label20_3 = this.Label20;
    size1 = new Size(142, 16 /*0x10*/);
    Size size3 = size1;
    label20_3.Size = size3;
    this.Label20.TabIndex = 114;
    this.Label20.Text = "Election List Name 4";
    this.txtElectionName2.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtElectionName2_1 = this.txtElectionName2;
    point1 = new Point(222, 220);
    Point point4 = point1;
    txtElectionName2_1.Location = point4;
    TextBox txtElectionName2_2 = this.txtElectionName2;
    padding1 = new Padding(4);
    Padding padding4 = padding1;
    txtElectionName2_2.Margin = padding4;
    this.txtElectionName2.MaxLength = (int) byte.MaxValue;
    this.txtElectionName2.Name = "txtElectionName2";
    TextBox txtElectionName2_3 = this.txtElectionName2;
    size1 = new Size(303, 23);
    Size size4 = size1;
    txtElectionName2_3.Size = size4;
    this.txtElectionName2.TabIndex = 7;
    this.Label19.AutoSize = true;
    this.Label19.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label19_1 = this.Label19;
    point1 = new Point(81, 223);
    Point point5 = point1;
    label19_1.Location = point5;
    Label label19_2 = this.Label19;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding5 = padding1;
    label19_2.Margin = padding5;
    this.Label19.Name = "Label19";
    Label label19_3 = this.Label19;
    size1 = new Size(142, 16 /*0x10*/);
    Size size5 = size1;
    label19_3.Size = size5;
    this.Label19.TabIndex = 112 /*0x70*/;
    this.Label19.Text = "Election List Name 3";
    this.txtElectionName1.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtElectionName1_1 = this.txtElectionName1;
    point1 = new Point(223, 194);
    Point point6 = point1;
    txtElectionName1_1.Location = point6;
    TextBox txtElectionName1_2 = this.txtElectionName1;
    padding1 = new Padding(4);
    Padding padding6 = padding1;
    txtElectionName1_2.Margin = padding6;
    this.txtElectionName1.MaxLength = (int) byte.MaxValue;
    this.txtElectionName1.Name = "txtElectionName1";
    TextBox txtElectionName1_3 = this.txtElectionName1;
    size1 = new Size(303, 23);
    Size size6 = size1;
    txtElectionName1_3.Size = size6;
    this.txtElectionName1.TabIndex = 6;
    this.Label18.AutoSize = true;
    this.Label18.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label18_1 = this.Label18;
    point1 = new Point(82, 197);
    Point point7 = point1;
    label18_1.Location = point7;
    Label label18_2 = this.Label18;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding7 = padding1;
    label18_2.Margin = padding7;
    this.Label18.Name = "Label18";
    Label label18_3 = this.Label18;
    size1 = new Size(142, 16 /*0x10*/);
    Size size7 = size1;
    label18_3.Size = size7;
    this.Label18.TabIndex = 110;
    this.Label18.Text = "Election List Name 2";
    this.Label17.AutoSize = true;
    this.Label17.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label17_1 = this.Label17;
    point1 = new Point(350, 429);
    Point point8 = point1;
    label17_1.Location = point8;
    Label label17_2 = this.Label17;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding8 = padding1;
    label17_2.Margin = padding8;
    this.Label17.Name = "Label17";
    Label label17_3 = this.Label17;
    size1 = new Size(92, 16 /*0x10*/);
    Size size8 = size1;
    label17_3.Size = size8;
    this.Label17.TabIndex = 108;
    this.Label17.Text = "Date of Birth";
    this.mtxtDOB.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDOB.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDob1 = this.mtxtDOB;
    point1 = new Point(449, 426);
    Point point9 = point1;
    mtxtDob1.Location = point9;
    this.mtxtDOB.Mask = "00/00/0000";
    this.mtxtDOB.Name = "mtxtDOB";
    MaskedTextBox mtxtDob2 = this.mtxtDOB;
    size1 = new Size(77, 22);
    Size size9 = size1;
    mtxtDob2.Size = size9;
    this.mtxtDOB.TabIndex = 17;
    this.mtxtDOB.ValidatingType = typeof (DateTime);
    this.txtGender.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtGender1 = this.txtGender;
    point1 = new Point(223, 278);
    Point point10 = point1;
    txtGender1.Location = point10;
    TextBox txtGender2 = this.txtGender;
    padding1 = new Padding(4);
    Padding padding9 = padding1;
    txtGender2.Margin = padding9;
    this.txtGender.MaxLength = 10;
    this.txtGender.Name = "txtGender";
    TextBox txtGender3 = this.txtGender;
    size1 = new Size(303, 23);
    Size size10 = size1;
    txtGender3.Size = size10;
    this.txtGender.TabIndex = 9;
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label16_1 = this.Label16;
    point1 = new Point(82, 284);
    Point point11 = point1;
    label16_1.Location = point11;
    Label label16_2 = this.Label16;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding10 = padding1;
    label16_2.Margin = padding10;
    this.Label16.Name = "Label16";
    Label label16_3 = this.Label16;
    size1 = new Size(54, 16 /*0x10*/);
    Size size11 = size1;
    label16_3.Size = size11;
    this.Label16.TabIndex = 107;
    this.Label16.Text = "Gender";
    this.cmbActive.FormattingEnabled = true;
    this.cmbActive.Items.AddRange(new object[2]
    {
      (object) "Active",
      (object) "InActive"
    });
    ComboBox cmbActive1 = this.cmbActive;
    point1 = new Point(300, 453);
    Point point12 = point1;
    cmbActive1.Location = point12;
    this.cmbActive.Name = "cmbActive";
    ComboBox cmbActive2 = this.cmbActive;
    size1 = new Size(226, 21);
    Size size12 = size1;
    cmbActive2.Size = size12;
    this.cmbActive.TabIndex = 18;
    this.cmbActive.Text = "Active";
    this.Label15.AutoSize = true;
    this.Label15.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label15_1 = this.Label15;
    point1 = new Point(82, 462);
    Point point13 = point1;
    label15_1.Location = point13;
    Label label15_2 = this.Label15;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding11 = padding1;
    label15_2.Margin = padding11;
    this.Label15.Name = "Label15";
    Label label15_3 = this.Label15;
    size1 = new Size(97, 16 /*0x10*/);
    Size size13 = size1;
    label15_3.Size = size13;
    this.Label15.TabIndex = 106;
    this.Label15.Text = "Member Type";
    this.Label14.AutoSize = true;
    this.Label14.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label14_1 = this.Label14;
    point1 = new Point(82, 429);
    Point point14 = point1;
    label14_1.Location = point14;
    Label label14_2 = this.Label14;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding12 = padding1;
    label14_2.Margin = padding12;
    this.Label14.Name = "Label14";
    Label label14_3 = this.Label14;
    size1 = new Size(126, 16 /*0x10*/);
    Size size14 = size1;
    label14_3.Size = size14;
    this.Label14.TabIndex = 105;
    this.Label14.Text = "Date of Admission";
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(223, 426);
    Point point15 = point1;
    mtxtDateFrom1.Location = point15;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size15 = size1;
    mtxtDateFrom2.Size = size15;
    this.mtxtDateFrom.TabIndex = 16 /*0x10*/;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    this.txtElectionName.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtElectionName1 = this.txtElectionName;
    point1 = new Point(223, 168);
    Point point16 = point1;
    txtElectionName1.Location = point16;
    TextBox txtElectionName2 = this.txtElectionName;
    padding1 = new Padding(4);
    Padding padding13 = padding1;
    txtElectionName2.Margin = padding13;
    this.txtElectionName.MaxLength = (int) byte.MaxValue;
    this.txtElectionName.Name = "txtElectionName";
    TextBox txtElectionName3 = this.txtElectionName;
    size1 = new Size(303, 23);
    Size size16 = size1;
    txtElectionName3.Size = size16;
    this.txtElectionName.TabIndex = 5;
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label13_1 = this.Label13;
    point1 = new Point(82, 171);
    Point point17 = point1;
    label13_1.Location = point17;
    Label label13_2 = this.Label13;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding14 = padding1;
    label13_2.Margin = padding14;
    this.Label13.Name = "Label13";
    Label label13_3 = this.Label13;
    size1 = new Size(142, 16 /*0x10*/);
    Size size17 = size1;
    label13_3.Size = size17;
    this.Label13.TabIndex = 104;
    this.Label13.Text = "Election List Name 1";
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(82, 485);
    Point point18 = point1;
    label11_1.Location = point18;
    Label label11_2 = this.Label11;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding15 = padding1;
    label11_2.Margin = padding15;
    this.Label11.Name = "Label11";
    Label label11_3 = this.Label11;
    size1 = new Size(182, 16 /*0x10*/);
    Size size18 = size1;
    label11_3.Size = size18;
    this.Label11.TabIndex = 103;
    this.Label11.Text = "Add Member in all Register";
    this.cmbMemberType.FormattingEnabled = true;
    this.cmbMemberType.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbMemberType1 = this.cmbMemberType;
    point1 = new Point(300, 482);
    Point point19 = point1;
    cmbMemberType1.Location = point19;
    this.cmbMemberType.Name = "cmbMemberType";
    ComboBox cmbMemberType2 = this.cmbMemberType;
    size1 = new Size(226, 21);
    Size size19 = size1;
    cmbMemberType2.Size = size19;
    this.cmbMemberType.TabIndex = 19;
    this.cmbMemberType.Text = "Yes";
    this.txtConstCost.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtConstCost1 = this.txtConstCost;
    point1 = new Point(223, 396);
    Point point20 = point1;
    txtConstCost1.Location = point20;
    TextBox txtConstCost2 = this.txtConstCost;
    padding1 = new Padding(4);
    Padding padding16 = padding1;
    txtConstCost2.Margin = padding16;
    this.txtConstCost.MaxLength = 25;
    this.txtConstCost.Name = "txtConstCost";
    TextBox txtConstCost3 = this.txtConstCost;
    size1 = new Size(76, 23);
    Size size20 = size1;
    txtConstCost3.Size = size20;
    this.txtConstCost.TabIndex = 14;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(82, 402);
    Point point21 = point1;
    label6_1.Location = point21;
    Label label6_2 = this.Label6;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding17 = padding1;
    label6_2.Margin = padding17;
    this.Label6.Name = "Label6";
    Label label6_3 = this.Label6;
    size1 = new Size(86, 16 /*0x10*/);
    Size size21 = size1;
    label6_3.Size = size21;
    this.Label6.TabIndex = 102;
    this.Label6.Text = "Const. Cost";
    this.txtSFCont.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtSfCont1 = this.txtSFCont;
    point1 = new Point(451, 396);
    Point point22 = point1;
    txtSfCont1.Location = point22;
    TextBox txtSfCont2 = this.txtSFCont;
    padding1 = new Padding(4);
    Padding padding18 = padding1;
    txtSfCont2.Margin = padding18;
    this.txtSFCont.MaxLength = 25;
    this.txtSFCont.Name = "txtSFCont";
    TextBox txtSfCont3 = this.txtSFCont;
    size1 = new Size(74, 23);
    Size size22 = size1;
    txtSfCont3.Size = size22;
    this.txtSFCont.TabIndex = 15;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label10_1 = this.Label10;
    point1 = new Point(329, 399);
    Point point23 = point1;
    label10_1.Location = point23;
    Label label10_2 = this.Label10;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding19 = padding1;
    label10_2.Margin = padding19;
    this.Label10.Name = "Label10";
    Label label10_3 = this.Label10;
    size1 = new Size(113, 16 /*0x10*/);
    Size size23 = size1;
    label10_3.Size = size23;
    this.Label10.TabIndex = 101;
    this.Label10.Text = "Sink Fund Cont.";
    this.txtCostofFlat.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtCostofFlat1 = this.txtCostofFlat;
    point1 = new Point(451, 367);
    Point point24 = point1;
    txtCostofFlat1.Location = point24;
    TextBox txtCostofFlat2 = this.txtCostofFlat;
    padding1 = new Padding(4);
    Padding padding20 = padding1;
    txtCostofFlat2.Margin = padding20;
    this.txtCostofFlat.MaxLength = 25;
    this.txtCostofFlat.Name = "txtCostofFlat";
    TextBox txtCostofFlat3 = this.txtCostofFlat;
    size1 = new Size(74, 23);
    Size size24 = size1;
    txtCostofFlat3.Size = size24;
    this.txtCostofFlat.TabIndex = 13;
    this.Label12.AutoSize = true;
    this.Label12.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label12_1 = this.Label12;
    point1 = new Point(350, 370);
    Point point25 = point1;
    label12_1.Location = point25;
    Label label12_2 = this.Label12;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding21 = padding1;
    label12_2.Margin = padding21;
    this.Label12.Name = "Label12";
    Label label12_3 = this.Label12;
    size1 = new Size(88, 16 /*0x10*/);
    Size size25 = size1;
    label12_3.Size = size25;
    this.Label12.TabIndex = 100;
    this.Label12.Text = "Cost Of Flat";
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(203, 508);
    Point point26 = point1;
    btnUpdate1.Location = point26;
    Button btnUpdate2 = this.btnUpdate;
    padding1 = new Padding(4);
    Padding padding22 = padding1;
    btnUpdate2.Margin = padding22;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate3 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size26 = size1;
    btnUpdate3.Size = size26;
    this.btnUpdate.TabIndex = 20;
    this.btnUpdate.Text = "Update";
    this.btnUpdate.UseVisualStyleBackColor = true;
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(203, 508);
    Point point27 = point1;
    btnDelete1.Location = point27;
    Button btnDelete2 = this.btnDelete;
    padding1 = new Padding(4);
    Padding padding23 = padding1;
    btnDelete2.Margin = padding23;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete3 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size27 = size1;
    btnDelete3.Size = size27;
    this.btnDelete.TabIndex = 21;
    this.btnDelete.Text = "Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    this.txtRAdd.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRadd1 = this.txtRAdd;
    point1 = new Point(223, 308);
    Point point28 = point1;
    txtRadd1.Location = point28;
    TextBox txtRadd2 = this.txtRAdd;
    padding1 = new Padding(4);
    Padding padding24 = padding1;
    txtRadd2.Margin = padding24;
    this.txtRAdd.MaxLength = (int) byte.MaxValue;
    this.txtRAdd.Name = "txtRAdd";
    TextBox txtRadd3 = this.txtRAdd;
    size1 = new Size(303, 23);
    Size size28 = size1;
    txtRadd3.Size = size28;
    this.txtRAdd.TabIndex = 10;
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label9_1 = this.Label9;
    point1 = new Point(82, 344);
    Point point29 = point1;
    label9_1.Location = point29;
    Label label9_2 = this.Label9;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding25 = padding1;
    label9_2.Margin = padding25;
    this.Label9.Name = "Label9";
    Label label9_3 = this.Label9;
    size1 = new Size(91, 16 /*0x10*/);
    Size size29 = size1;
    label9_3.Size = size29;
    this.Label9.TabIndex = 99;
    this.Label9.Text = "Resi Address";
    this.txtPAdd.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPadd1 = this.txtPAdd;
    point1 = new Point(223, 338);
    Point point30 = point1;
    txtPadd1.Location = point30;
    TextBox txtPadd2 = this.txtPAdd;
    padding1 = new Padding(4);
    Padding padding26 = padding1;
    txtPadd2.Margin = padding26;
    this.txtPAdd.MaxLength = (int) byte.MaxValue;
    this.txtPAdd.Name = "txtPAdd";
    TextBox txtPadd3 = this.txtPAdd;
    size1 = new Size(303, 23);
    Size size30 = size1;
    txtPadd3.Size = size30;
    this.txtPAdd.TabIndex = 11;
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(82, 311);
    Point point31 = point1;
    label8_1.Location = point31;
    Label label8_2 = this.Label8;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding27 = padding1;
    label8_2.Margin = padding27;
    this.Label8.Name = "Label8";
    Label label8_3 = this.Label8;
    size1 = new Size(108, 16 /*0x10*/);
    Size size31 = size1;
    label8_3.Size = size31;
    this.Label8.TabIndex = 98;
    this.Label8.Text = "Permanent Add";
    this.lblId.AutoSize = true;
    Label lblId1 = this.lblId;
    point1 = new Point(67, 522);
    Point point32 = point1;
    lblId1.Location = point32;
    Label lblId2 = this.lblId;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding28 = padding1;
    lblId2.Margin = padding28;
    this.lblId.Name = "lblId";
    Label lblId3 = this.lblId;
    size1 = new Size(39, 13);
    Size size32 = size1;
    lblId3.Size = size32;
    this.lblId.TabIndex = 97;
    this.lblId.Text = "Label8";
    this.lblId.Visible = false;
    this.txtFlatNo.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtFlatNo1 = this.txtFlatNo;
    point1 = new Point(223, 368);
    Point point33 = point1;
    txtFlatNo1.Location = point33;
    TextBox txtFlatNo2 = this.txtFlatNo;
    padding1 = new Padding(4);
    Padding padding29 = padding1;
    txtFlatNo2.Margin = padding29;
    this.txtFlatNo.MaxLength = 25;
    this.txtFlatNo.Name = "txtFlatNo";
    TextBox txtFlatNo3 = this.txtFlatNo;
    size1 = new Size(76, 23);
    Size size33 = size1;
    txtFlatNo3.Size = size33;
    this.txtFlatNo.TabIndex = 12;
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(82, 374);
    Point point34 = point1;
    label7_1.Location = point34;
    Label label7_2 = this.Label7;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding30 = padding1;
    label7_2.Margin = padding30;
    this.Label7.Name = "Label7";
    Label label7_3 = this.Label7;
    size1 = new Size(55, 16 /*0x10*/);
    Size size34 = size1;
    label7_3.Size = size34;
    this.Label7.TabIndex = 96 /*0x60*/;
    this.Label7.Text = "Flat No";
    this.txtName3.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtName3_1 = this.txtName3;
    point1 = new Point(223, 131);
    Point point35 = point1;
    txtName3_1.Location = point35;
    TextBox txtName3_2 = this.txtName3;
    padding1 = new Padding(4);
    Padding padding31 = padding1;
    txtName3_2.Margin = padding31;
    this.txtName3.MaxLength = (int) byte.MaxValue;
    this.txtName3.Name = "txtName3";
    TextBox txtName3_3 = this.txtName3;
    size1 = new Size(303, 23);
    Size size35 = size1;
    txtName3_3.Size = size35;
    this.txtName3.TabIndex = 4;
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(82, 134);
    Point point36 = point1;
    label5_1.Location = point36;
    Label label5_2 = this.Label5;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding32 = padding1;
    label5_2.Margin = padding32;
    this.Label5.Name = "Label5";
    Label label5_3 = this.Label5;
    size1 = new Size(57, 16 /*0x10*/);
    Size size36 = size1;
    label5_3.Size = size36;
    this.Label5.TabIndex = 95;
    this.Label5.Text = "Name 4";
    this.txtName2.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtName2_1 = this.txtName2;
    point1 = new Point(223, 106);
    Point point37 = point1;
    txtName2_1.Location = point37;
    TextBox txtName2_2 = this.txtName2;
    padding1 = new Padding(4);
    Padding padding33 = padding1;
    txtName2_2.Margin = padding33;
    this.txtName2.MaxLength = (int) byte.MaxValue;
    this.txtName2.Name = "txtName2";
    TextBox txtName2_3 = this.txtName2;
    size1 = new Size(303, 23);
    Size size37 = size1;
    txtName2_3.Size = size37;
    this.txtName2.TabIndex = 3;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(81, 109);
    Point point38 = point1;
    label4_1.Location = point38;
    Label label4_2 = this.Label4;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding34 = padding1;
    label4_2.Margin = padding34;
    this.Label4.Name = "Label4";
    Label label4_3 = this.Label4;
    size1 = new Size(57, 16 /*0x10*/);
    Size size38 = size1;
    label4_3.Size = size38;
    this.Label4.TabIndex = 94;
    this.Label4.Text = "Name 3";
    this.txtName1.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtName1_1 = this.txtName1;
    point1 = new Point(223, 80 /*0x50*/);
    Point point39 = point1;
    txtName1_1.Location = point39;
    TextBox txtName1_2 = this.txtName1;
    padding1 = new Padding(4);
    Padding padding35 = padding1;
    txtName1_2.Margin = padding35;
    this.txtName1.MaxLength = (int) byte.MaxValue;
    this.txtName1.Name = "txtName1";
    TextBox txtName1_3 = this.txtName1;
    size1 = new Size(303, 23);
    Size size39 = size1;
    txtName1_3.Size = size39;
    this.txtName1.TabIndex = 2;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(81, 83);
    Point point40 = point1;
    label3_1.Location = point40;
    Label label3_2 = this.Label3;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding36 = padding1;
    label3_2.Margin = padding36;
    this.Label3.Name = "Label3";
    Label label3_3 = this.Label3;
    size1 = new Size(57, 16 /*0x10*/);
    Size size40 = size1;
    label3_3.Size = size40;
    this.Label3.TabIndex = 93;
    this.Label3.Text = "Name 2";
    this.txtName.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtName1 = this.txtName;
    point1 = new Point(223, 55);
    Point point41 = point1;
    txtName1.Location = point41;
    TextBox txtName2 = this.txtName;
    padding1 = new Padding(4);
    Padding padding37 = padding1;
    txtName2.Margin = padding37;
    this.txtName.MaxLength = (int) byte.MaxValue;
    this.txtName.Name = "txtName";
    TextBox txtName3 = this.txtName;
    size1 = new Size(303, 23);
    Size size41 = size1;
    txtName3.Size = size41;
    this.txtName.TabIndex = 1;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(82, 58);
    Point point42 = point1;
    label2_1.Location = point42;
    Label label2_2 = this.Label2;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding38 = padding1;
    label2_2.Margin = padding38;
    this.Label2.Name = "Label2";
    Label label2_3 = this.Label2;
    size1 = new Size(57, 16 /*0x10*/);
    Size size42 = size1;
    label2_3.Size = size42;
    this.Label2.TabIndex = 92;
    this.Label2.Text = "Name 1";
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(310, 508);
    Point point43 = point1;
    btnCancel1.Location = point43;
    Button btnCancel2 = this.btnCancel;
    padding1 = new Padding(4);
    Padding padding39 = padding1;
    btnCancel2.Margin = padding39;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel3 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size43 = size1;
    btnCancel3.Size = size43;
    this.btnCancel.TabIndex = 23;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.txtMemId.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemId1 = this.txtMemId;
    point1 = new Point(223, 25);
    Point point44 = point1;
    txtMemId1.Location = point44;
    TextBox txtMemId2 = this.txtMemId;
    padding1 = new Padding(4);
    Padding padding40 = padding1;
    txtMemId2.Margin = padding40;
    this.txtMemId.Name = "txtMemId";
    TextBox txtMemId3 = this.txtMemId;
    size1 = new Size(303, 23);
    Size size44 = size1;
    txtMemId3.Size = size44;
    this.txtMemId.TabIndex = 0;
    Button btnSave1 = this.btnSave;
    point1 = new Point(203, 508);
    Point point45 = point1;
    btnSave1.Location = point45;
    Button btnSave2 = this.btnSave;
    padding1 = new Padding(4);
    Padding padding41 = padding1;
    btnSave2.Margin = padding41;
    this.btnSave.Name = "btnSave";
    Button btnSave3 = this.btnSave;
    size1 = new Size(99, 33);
    Size size45 = size1;
    btnSave3.Size = size45;
    this.btnSave.TabIndex = 22;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(82, 28);
    Point point46 = point1;
    label1_1.Location = point46;
    Label label1_2 = this.Label1;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding42 = padding1;
    label1_2.Margin = padding42;
    this.Label1.Name = "Label1";
    Label label1_3 = this.Label1;
    size1 = new Size(107, 16 /*0x10*/);
    Size size46 = size1;
    label1_3.Size = size46;
    this.Label1.TabIndex = 91;
    this.Label1.Text = "Mem Regn. No.";
    Button button1_1 = this.Button1;
    point1 = new Point(4, 168);
    Point point47 = point1;
    button1_1.Location = point47;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(76, 23);
    Size size47 = size1;
    button1_2.Size = size47;
    this.Button1.TabIndex = 115;
    this.Button1.Text = "Copy Name1";
    this.Button1.UseVisualStyleBackColor = true;
    Button button2_1 = this.Button2;
    point1 = new Point(4, 194);
    Point point48 = point1;
    button2_1.Location = point48;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(76, 23);
    Size size48 = size1;
    button2_2.Size = size48;
    this.Button2.TabIndex = 116;
    this.Button2.Text = "Copy Name2";
    this.Button2.UseVisualStyleBackColor = true;
    Button button3_1 = this.Button3;
    point1 = new Point(4, 220);
    Point point49 = point1;
    button3_1.Location = point49;
    this.Button3.Name = "Button3";
    Button button3_2 = this.Button3;
    size1 = new Size(76, 23);
    Size size49 = size1;
    button3_2.Size = size49;
    this.Button3.TabIndex = 117;
    this.Button3.Text = "Copy Name3";
    this.Button3.UseVisualStyleBackColor = true;
    Button button4_1 = this.Button4;
    point1 = new Point(4, 246);
    Point point50 = point1;
    button4_1.Location = point50;
    this.Button4.Name = "Button4";
    Button button4_2 = this.Button4;
    size1 = new Size(76, 23);
    Size size50 = size1;
    button4_2.Size = size50;
    this.Button4.TabIndex = 118;
    this.Button4.Text = "Copy Name4";
    this.Button4.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Button4);
    this.Controls.Add((Control) this.Button3);
    this.Controls.Add((Control) this.Button2);
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.txtElectionName3);
    this.Controls.Add((Control) this.Label20);
    this.Controls.Add((Control) this.txtElectionName2);
    this.Controls.Add((Control) this.Label19);
    this.Controls.Add((Control) this.txtElectionName1);
    this.Controls.Add((Control) this.Label18);
    this.Controls.Add((Control) this.Label17);
    this.Controls.Add((Control) this.mtxtDOB);
    this.Controls.Add((Control) this.txtGender);
    this.Controls.Add((Control) this.Label16);
    this.Controls.Add((Control) this.cmbActive);
    this.Controls.Add((Control) this.Label15);
    this.Controls.Add((Control) this.Label14);
    this.Controls.Add((Control) this.mtxtDateFrom);
    this.Controls.Add((Control) this.txtElectionName);
    this.Controls.Add((Control) this.Label13);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.cmbMemberType);
    this.Controls.Add((Control) this.txtConstCost);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.txtSFCont);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.txtCostofFlat);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.txtRAdd);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.txtPAdd);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.lblId);
    this.Controls.Add((Control) this.txtFlatNo);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.txtName3);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtName2);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtName1);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.txtName);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.txtMemId);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatMemberDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmStatMemberDetail);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox txtElectionName3
  {
    [DebuggerNonUserCode] get => this._txtElectionName3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtElectionName3 = value;
    }
  }

  internal virtual Label Label20
  {
    [DebuggerNonUserCode] get => this._Label20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
  }

  internal virtual TextBox txtElectionName2
  {
    [DebuggerNonUserCode] get => this._txtElectionName2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtElectionName2 = value;
    }
  }

  internal virtual Label Label19
  {
    [DebuggerNonUserCode] get => this._Label19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
  }

  internal virtual TextBox txtElectionName1
  {
    [DebuggerNonUserCode] get => this._txtElectionName1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtElectionName1 = value;
    }
  }

  internal virtual Label Label18
  {
    [DebuggerNonUserCode] get => this._Label18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
  }

  internal virtual Label Label17
  {
    [DebuggerNonUserCode] get => this._Label17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
  }

  internal virtual MaskedTextBox mtxtDOB
  {
    [DebuggerNonUserCode] get => this._mtxtDOB;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._mtxtDOB = value;
  }

  internal virtual TextBox txtGender
  {
    [DebuggerNonUserCode] get => this._txtGender;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtGender = value;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual ComboBox cmbActive
  {
    [DebuggerNonUserCode] get => this._cmbActive;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbActive = value;
    }
  }

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual MaskedTextBox mtxtDateFrom
  {
    [DebuggerNonUserCode] get => this._mtxtDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtDateFrom = value;
    }
  }

  internal virtual TextBox txtElectionName
  {
    [DebuggerNonUserCode] get => this._txtElectionName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtElectionName = value;
    }
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual ComboBox cmbMemberType
  {
    [DebuggerNonUserCode] get => this._cmbMemberType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbMemberType = value;
    }
  }

  internal virtual TextBox txtConstCost
  {
    [DebuggerNonUserCode] get => this._txtConstCost;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtConstCost = value;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual TextBox txtSFCont
  {
    [DebuggerNonUserCode] get => this._txtSFCont;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtSFCont = value;
    }
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual TextBox txtCostofFlat
  {
    [DebuggerNonUserCode] get => this._txtCostofFlat;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCostofFlat = value;
    }
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
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

  internal virtual TextBox txtRAdd
  {
    [DebuggerNonUserCode] get => this._txtRAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtRAdd = value;
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual TextBox txtPAdd
  {
    [DebuggerNonUserCode] get => this._txtPAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtPAdd = value;
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual Label lblId
  {
    [DebuggerNonUserCode] get => this._lblId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblId = value;
  }

  internal virtual TextBox txtFlatNo
  {
    [DebuggerNonUserCode] get => this._txtFlatNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtFlatNo = value;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual TextBox txtName3
  {
    [DebuggerNonUserCode] get => this._txtName3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtName3 = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual TextBox txtName2
  {
    [DebuggerNonUserCode] get => this._txtName2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtName2 = value;
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual TextBox txtName1
  {
    [DebuggerNonUserCode] get => this._txtName1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtName1 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual TextBox txtName
  {
    [DebuggerNonUserCode] get => this._txtName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtName = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
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

  internal virtual Button Button3
  {
    [DebuggerNonUserCode] get => this._Button3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button3_Click);
      if (this._Button3 != null)
        this._Button3.Click -= eventHandler;
      this._Button3 = value;
      if (this._Button3 == null)
        return;
      this._Button3.Click += eventHandler;
    }
  }

  internal virtual Button Button4
  {
    [DebuggerNonUserCode] get => this._Button4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button4_Click);
      if (this._Button4 != null)
        this._Button4.Click -= eventHandler;
      this._Button4 = value;
      if (this._Button4 == null)
        return;
      this._Button4.Click += eventHandler;
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    int num1 = 0;
    if (Operators.CompareString(this.txtMemId.Text.Trim(), "", false) == 0)
    {
      int num2 = (int) Interaction.MsgBox((object) "Member Id Cannot not Blank");
      this.txtMemId.Focus();
    }
    else if (Operators.CompareString(this.txtName.Text.Trim(), "", false) == 0)
    {
      int num3 = (int) Interaction.MsgBox((object) "Member Name Cannot not Blank");
      this.txtName.Focus();
    }
    else
    {
      this.txtMemId.Text = this.txtMemId.Text.ToString().Replace("'", "''");
      this.txtName.Text = this.txtName.Text.ToString().Replace("'", "''");
      this.txtName1.Text = this.txtName1.Text.ToString().Replace("'", "''");
      this.txtName2.Text = this.txtName2.Text.ToString().Replace("'", "''");
      this.txtName3.Text = this.txtName3.Text.ToString().Replace("'", "''");
      this.txtElectionName.Text = this.txtElectionName.Text.ToString().Replace("'", "''");
      this.txtElectionName1.Text = this.txtElectionName1.Text.ToString().Replace("'", "''");
      this.txtElectionName2.Text = this.txtElectionName2.Text.ToString().Replace("'", "''");
      this.txtElectionName3.Text = this.txtElectionName3.Text.ToString().Replace("'", "''");
      this.txtRAdd.Text = this.txtRAdd.Text.ToString().Replace("'", "''");
      this.txtPAdd.Text = this.txtPAdd.Text.ToString().Replace("'", "''");
      this.txtFlatNo.Text = this.txtFlatNo.Text.ToString().Replace("'", "''");
      this.txtCostofFlat.Text = this.txtCostofFlat.Text.ToString().Replace("'", "''");
      this.txtConstCost.Text = this.txtConstCost.Text.ToString().Replace("'", "''");
      this.txtSFCont.Text = this.txtSFCont.Text.ToString().Replace("'", "''");
      this.txtGender.Text = this.txtGender.Text.ToString().Replace("'", "''");
      string str = Operators.CompareString(this.cmbActive.Text, "Active", false) != 0 ? "N" : "Y";
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      connection.Open();
      int num4 = checked (MyProject.Forms.frmStatMemberList.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num4)
      {
        if (Strings.InStr(Strings.Trim(this.txtMemId.Text), MyProject.Forms.frmStatMemberList.DataGridView1.Rows[index].Cells[1].Value.ToString()) == 1)
          checked { ++num1; }
        checked { ++index; }
      }
      if (num1 >= 1)
      {
        int num5 = (int) Interaction.MsgBox((object) "Duplicate Member Registration No.");
      }
      string cmdText1;
      if (Information.IsDate((object) this.mtxtDateFrom.Text))
      {
        if (Information.IsDate((object) this.mtxtDOB.Text))
          cmdText1 = $"Insert Into Member (MemID, MemRegn, MemName, MemName1, MemName2, MemName3, Raddress, Paddress, FlatNo, CostofFlat, Constcost, SFCont, DOA, IsTransfer, IsActive, MemElecName, Gender, DOB, MemElecName1, MemElecName2, MemElecName3) values ('{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}','{this.txtMemId.Text.Trim()}','{this.txtName.Text.Trim()}','{this.txtName1.Text.Trim()}','{this.txtName2.Text.Trim()}','{this.txtName3.Text.Trim()}','{this.txtRAdd.Text.Trim()}','{this.txtPAdd.Text.Trim()}','{this.txtFlatNo.Text.Trim()}','{this.txtCostofFlat.Text.Trim()}','{this.txtConstCost.Text.Trim()}','{this.txtSFCont.Text.Trim()}','{this.mtxtDateFrom.Text}','N','{str}','{this.txtElectionName.Text.Trim()}','{this.txtGender.Text.Trim()}','{this.mtxtDOB.Text}','{this.txtElectionName1.Text.Trim()}','{this.txtElectionName2.Text.Trim()}','{this.txtElectionName3.Text.Trim()}')";
        else
          cmdText1 = $"Insert Into Member (MemID, MemRegn, MemName, MemName1, MemName2, MemName3, Raddress, Paddress, FlatNo, CostofFlat, Constcost, SFCont, DOA, IsTransfer, IsActive, MemElecName, Gender, DOB, MemElecName1, MemElecName2, MemElecName3) values ('{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}','{this.txtMemId.Text.Trim()}','{this.txtName.Text.Trim()}','{this.txtName1.Text.Trim()}','{this.txtName2.Text.Trim()}','{this.txtName3.Text.Trim()}','{this.txtRAdd.Text.Trim()}','{this.txtPAdd.Text.Trim()}','{this.txtFlatNo.Text.Trim()}','{this.txtCostofFlat.Text.Trim()}','{this.txtConstCost.Text.Trim()}','{this.txtSFCont.Text.Trim()}','{this.mtxtDateFrom.Text}','N','{str}','{this.txtElectionName.Text.Trim()}','{this.txtGender.Text.Trim()}',NULL,'{this.txtElectionName1.Text.Trim()}','{this.txtElectionName2.Text.Trim()}','{this.txtElectionName3.Text.Trim()}')";
      }
      else if (Information.IsDate((object) this.mtxtDOB.Text))
        cmdText1 = $"Insert Into Member (MemID, MemRegn, MemName, MemName1, MemName2, MemName3, Raddress, Paddress, FlatNo, CostofFlat, Constcost, SFCont, DOA, IsTransfer, IsActive, MemElecName, Gender, DOB, MemElecName1, MemElecName2, MemElecName3) values ('{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}','{this.txtMemId.Text.Trim()}','{this.txtName.Text.Trim()}','{this.txtName1.Text.Trim()}','{this.txtName2.Text.Trim()}','{this.txtName3.Text.Trim()}','{this.txtRAdd.Text.Trim()}','{this.txtPAdd.Text.Trim()}','{this.txtFlatNo.Text.Trim()}','{this.txtCostofFlat.Text.Trim()}','{this.txtConstCost.Text.Trim()}','{this.txtSFCont.Text.Trim()}',NULL,'N','{str}','{this.txtElectionName.Text.Trim()}','{this.txtGender.Text.Trim()}','{this.mtxtDOB.Text}','{this.txtElectionName1.Text.Trim()}','{this.txtElectionName2.Text.Trim()}','{this.txtElectionName3.Text.Trim()}')";
      else
        cmdText1 = $"Insert Into Member (MemID, MemRegn, MemName, MemName1, MemName2, MemName3, Raddress, Paddress, FlatNo, CostofFlat, Constcost, SFCont, DOA, IsTransfer, IsActive, MemElecName, Gender, DOB, MemElecName1, MemElecName2, MemElecName3) values ('{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}','{this.txtMemId.Text.Trim()}','{this.txtName.Text.Trim()}','{this.txtName1.Text.Trim()}','{this.txtName2.Text.Trim()}','{this.txtName3.Text.Trim()}','{this.txtRAdd.Text.Trim()}','{this.txtPAdd.Text.Trim()}','{this.txtFlatNo.Text.Trim()}','{this.txtCostofFlat.Text.Trim()}','{this.txtConstCost.Text.Trim()}','{this.txtSFCont.Text.Trim()}',NULL,'N','{str}','{this.txtElectionName.Text.Trim()}','{this.txtGender.Text.Trim()}',NULL,'{this.txtElectionName1.Text.Trim()}','{this.txtElectionName2.Text.Trim()}','{this.txtElectionName3.Text.Trim()}')";
      new OleDbCommand(cmdText1, connection).ExecuteNonQuery();
      new OleDbCommand($"Insert Into JReg (MemID) values ('{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}')", connection).ExecuteNonQuery();
      string cmdText2;
      if (Information.IsDate((object) this.mtxtDateFrom.Text))
        cmdText2 = $"Insert Into IReg (MemID,ENTAMT) values ('{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}','{this.mtxtDateFrom.Text.Trim()}')";
      else
        cmdText2 = $"Insert Into IReg (MemID) values ('{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}')";
      new OleDbCommand(cmdText2, connection).ExecuteNonQuery();
      new OleDbCommand($"Insert Into PReg (MemID) values ('{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}')", connection).ExecuteNonQuery();
      if (Operators.CompareString(this.cmbMemberType.Text, "Yes", false) == 0)
      {
        new OleDbCommand($"Insert Into SReg (MemID) values ('{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}')", connection).ExecuteNonQuery();
        new OleDbCommand($"Insert Into SFLed (MemID) values ('{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}')", connection).ExecuteNonQuery();
      }
      connection.Close();
      this.Close();
    }
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    int num1 = 0;
    if (Operators.CompareString(this.txtMemId.Text.Trim(), "", false) == 0)
    {
      int num2 = (int) Interaction.MsgBox((object) "Member Id Cannot not Blank");
      this.txtMemId.Focus();
    }
    else if (Operators.CompareString(this.txtName.Text.Trim(), "", false) == 0)
    {
      int num3 = (int) Interaction.MsgBox((object) "Member Name Cannot not Blank");
      this.txtName.Focus();
    }
    else
    {
      this.txtMemId.Text = this.txtMemId.Text.ToString().Replace("'", "''");
      this.txtName.Text = this.txtName.Text.ToString().Replace("'", "''");
      this.txtName1.Text = this.txtName1.Text.ToString().Replace("'", "''");
      this.txtName2.Text = this.txtName2.Text.ToString().Replace("'", "''");
      this.txtName3.Text = this.txtName3.Text.ToString().Replace("'", "''");
      this.txtElectionName.Text = this.txtElectionName.Text.ToString().Replace("'", "''");
      this.txtElectionName1.Text = this.txtElectionName1.Text.ToString().Replace("'", "''");
      this.txtElectionName2.Text = this.txtElectionName2.Text.ToString().Replace("'", "''");
      this.txtElectionName3.Text = this.txtElectionName3.Text.ToString().Replace("'", "''");
      this.txtRAdd.Text = this.txtRAdd.Text.ToString().Replace("'", "''");
      this.txtPAdd.Text = this.txtPAdd.Text.ToString().Replace("'", "''");
      this.txtFlatNo.Text = this.txtFlatNo.Text.ToString().Replace("'", "''");
      this.txtCostofFlat.Text = this.txtCostofFlat.Text.ToString().Replace("'", "''");
      this.txtConstCost.Text = this.txtConstCost.Text.ToString().Replace("'", "''");
      this.txtSFCont.Text = this.txtSFCont.Text.ToString().Replace("'", "''");
      this.txtGender.Text = this.txtGender.Text.ToString().Replace("'", "''");
      string str = Operators.CompareString(this.cmbActive.Text, "Active", false) != 0 ? "N" : "Y";
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      connection.Open();
      int num4 = checked (MyProject.Forms.frmStatMemberList.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num4)
      {
        if (Strings.InStr(Strings.Trim(this.txtMemId.Text), MyProject.Forms.frmStatMemberList.DataGridView1.Rows[index].Cells[1].Value.ToString()) == 1 && Operators.CompareString(Strings.Trim(this.lblId.Text), MyProject.Forms.frmStatMemberList.DataGridView1.Rows[index].Cells[0].Value.ToString(), false) != 0)
          checked { ++num1; }
        checked { ++index; }
      }
      if (num1 >= 1)
      {
        int num5 = (int) Interaction.MsgBox((object) "Duplicate Member Registration No.");
      }
      string cmdText;
      if (Information.IsDate((object) this.mtxtDateFrom.Text))
      {
        if (Information.IsDate((object) this.mtxtDOB.Text))
          cmdText = $"update Member set MemId = '{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}',MemRegn ='{this.txtMemId.Text.Trim()}' ,MemName ='{this.txtName.Text.Trim()}',MemName1 ='{this.txtName1.Text.Trim()}',MemName2 ='{this.txtName2.Text.Trim()}',MemName3 ='{this.txtName3.Text.Trim()}',Raddress ='{this.txtRAdd.Text.Trim()}',Paddress ='{this.txtPAdd.Text.Trim()}',FlatNo ='{this.txtFlatNo.Text.Trim()}',CostofFlat ='{this.txtCostofFlat.Text.Trim()}',Constcost ='{this.txtConstCost.Text.Trim()}',SFCont ='{this.txtSFCont.Text.Trim()}',DOA ='{this.mtxtDateFrom.Text}',IsActive ='{str}',MemElecName ='{this.txtElectionName.Text}',Gender ='{this.txtGender.Text}',DOB ='{this.mtxtDOB.Text}', MemElecName1 ='{this.txtElectionName1.Text}', MemElecName2 ='{this.txtElectionName2.Text}', MemElecName3 ='{this.txtElectionName3.Text}' where MemId ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}";
        else
          cmdText = $"update Member set MemId = '{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}',MemRegn ='{this.txtMemId.Text.Trim()}' ,MemName ='{this.txtName.Text.Trim()}',MemName1 ='{this.txtName1.Text.Trim()}',MemName2 ='{this.txtName2.Text.Trim()}',MemName3 ='{this.txtName3.Text.Trim()}',Raddress ='{this.txtRAdd.Text.Trim()}',Paddress ='{this.txtPAdd.Text.Trim()}',FlatNo ='{this.txtFlatNo.Text.Trim()}',CostofFlat ='{this.txtCostofFlat.Text.Trim()}',Constcost ='{this.txtConstCost.Text.Trim()}',SFCont ='{this.txtSFCont.Text.Trim()}',DOA ='{this.mtxtDateFrom.Text}',IsActive ='{str}',MemElecName ='{this.txtElectionName.Text}',Gender ='{this.txtGender.Text}',DOB =NULL,MemElecName1 ='{this.txtElectionName1.Text}', MemElecName2 ='{this.txtElectionName2.Text}', MemElecName3 ='{this.txtElectionName3.Text}' where MemId ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}";
      }
      else if (Information.IsDate((object) this.mtxtDOB.Text))
        cmdText = $"update Member set MemId = '{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}',MemRegn ='{this.txtMemId.Text.Trim()}' ,MemName ='{this.txtName.Text.Trim()}',MemName1 ='{this.txtName1.Text.Trim()}',MemName2 ='{this.txtName2.Text.Trim()}',MemName3 ='{this.txtName3.Text.Trim()}',Raddress ='{this.txtRAdd.Text.Trim()}',Paddress ='{this.txtPAdd.Text.Trim()}',FlatNo ='{this.txtFlatNo.Text.Trim()}',CostofFlat ='{this.txtCostofFlat.Text.Trim()}',Constcost ='{this.txtConstCost.Text.Trim()}',SFCont ='{this.txtSFCont.Text.Trim()}',DOA =NULL,IsActive ='{str}',MemElecName ='{this.txtElectionName.Text}',Gender ='{this.txtGender.Text}',DOB ='{this.mtxtDOB.Text}',MemElecName1 ='{this.txtElectionName1.Text}', MemElecName2 ='{this.txtElectionName2.Text}', MemElecName3 ='{this.txtElectionName3.Text}' where MemId ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}";
      else
        cmdText = $"update Member set MemId = '{Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}',MemRegn ='{this.txtMemId.Text.Trim()}' ,MemName ='{this.txtName.Text.Trim()}',MemName1 ='{this.txtName1.Text.Trim()}',MemName2 ='{this.txtName2.Text.Trim()}',MemName3 ='{this.txtName3.Text.Trim()}',Raddress ='{this.txtRAdd.Text.Trim()}',Paddress ='{this.txtPAdd.Text.Trim()}',FlatNo ='{this.txtFlatNo.Text.Trim()}',CostofFlat ='{this.txtCostofFlat.Text.Trim()}',Constcost ='{this.txtConstCost.Text.Trim()}',SFCont ='{this.txtSFCont.Text.Trim()}',DOA =NULL,IsActive ='{str}',MemElecName ='{this.txtElectionName.Text}',Gender ='{this.txtGender.Text}',DOB =NULL, MemElecName1 ='{this.txtElectionName1.Text}', MemElecName2 ='{this.txtElectionName2.Text}', MemElecName3 ='{this.txtElectionName3.Text}' where MemId ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}";
      new OleDbCommand(cmdText, connection).ExecuteNonQuery();
      connection.Close();
      this.Close();
    }
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (Interaction.MsgBox((object) ("Are you Sure you want to Delete Member with All Transaction? Cannot Recall " + this.txtName.Text), MsgBoxStyle.YesNo, (object) "!!! WARNING... !!!") == MsgBoxResult.Yes)
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
      connection.Open();
      new OleDbCommand($"Delete From Member where MemId ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}", connection).ExecuteNonQuery();
      new OleDbCommand($"Delete From JReg where MemId ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}", connection).ExecuteNonQuery();
      new OleDbCommand($"Delete From SReg where MemId ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}", connection).ExecuteNonQuery();
      new OleDbCommand($"Delete From NReg where MemId ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}", connection).ExecuteNonQuery();
      new OleDbCommand($"Delete From IReg where MemId ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}", connection).ExecuteNonQuery();
      new OleDbCommand($"Delete From PReg where MemId ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}", connection).ExecuteNonQuery();
      new OleDbCommand($"Delete From SFLed where MemId ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}", connection).ExecuteNonQuery();
      connection.Close();
    }
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void Button1_Click(object sender, EventArgs e)
  {
    this.txtElectionName.Text = this.txtName.Text;
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    this.txtElectionName1.Text = this.txtName1.Text;
  }

  private void Button3_Click(object sender, EventArgs e)
  {
    this.txtElectionName2.Text = this.txtName2.Text;
  }

  private void Button4_Click(object sender, EventArgs e)
  {
    this.txtElectionName3.Text = this.txtName3.Text;
  }
}
