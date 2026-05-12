// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatNDetail
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
public class frmStatNDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtNId")]
  private TextBox _txtNId;
  [AccessedThroughProperty("btnList")]
  private Button _btnList;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("txtAMemId")]
  private TextBox _txtAMemId;
  [AccessedThroughProperty("lblMemName")]
  private Label _lblMemName;
  [AccessedThroughProperty("lblFlatNo")]
  private Label _lblFlatNo;
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
  [AccessedThroughProperty("txtNPART")]
  private TextBox _txtNPART;
  [AccessedThroughProperty("txtNDOE")]
  private TextBox _txtNDOE;
  [AccessedThroughProperty("txtNDOC")]
  private TextBox _txtNDOC;
  [AccessedThroughProperty("txtNDOP")]
  private TextBox _txtNDOP;
  [AccessedThroughProperty("txtNage")]
  private TextBox _txtNage;
  [AccessedThroughProperty("txtNaddress")]
  private TextBox _txtNaddress;
  [AccessedThroughProperty("txtNName")]
  private TextBox _txtNName;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("lblId")]
  private Label _lblId;
  [AccessedThroughProperty("txtNDOR")]
  private TextBox _txtNDOR;
  [AccessedThroughProperty("txtNsrno")]
  private TextBox _txtNsrno;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("txtMemId")]
  private TextBox _txtMemId;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;

  [DebuggerNonUserCode]
  static frmStatNDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmStatNDetail()
  {
    this.Load += new EventHandler(this.frmStatNDetail_Load);
    frmStatNDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatNDetail.__ENCList)
    {
      if (frmStatNDetail.__ENCList.Count == frmStatNDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatNDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatNDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatNDetail.__ENCList[index1] = frmStatNDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatNDetail.__ENCList.RemoveRange(index1, checked (frmStatNDetail.__ENCList.Count - index1));
        frmStatNDetail.__ENCList.Capacity = frmStatNDetail.__ENCList.Count;
      }
      frmStatNDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatNDetail));
    this.txtNId = new TextBox();
    this.btnList = new Button();
    this.DataGridView1 = new DataGridView();
    this.txtAMemId = new TextBox();
    this.lblMemName = new Label();
    this.lblFlatNo = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.txtNPART = new TextBox();
    this.txtNDOE = new TextBox();
    this.txtNDOC = new TextBox();
    this.txtNDOP = new TextBox();
    this.txtNage = new TextBox();
    this.txtNaddress = new TextBox();
    this.txtNName = new TextBox();
    this.btnUpdate = new Button();
    this.btnDelete = new Button();
    this.lblId = new Label();
    this.txtNDOR = new TextBox();
    this.txtNsrno = new TextBox();
    this.btnCancel = new Button();
    this.txtMemId = new TextBox();
    this.btnSave = new Button();
    this.Label1 = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    TextBox txtNid1 = this.txtNId;
    Point point1 = new Point(505, 74);
    Point point2 = point1;
    txtNid1.Location = point2;
    this.txtNId.Name = "txtNId";
    TextBox txtNid2 = this.txtNId;
    Size size1 = new Size(21, 20);
    Size size2 = size1;
    txtNid2.Size = size2;
    this.txtNId.TabIndex = 152;
    this.txtNId.Visible = false;
    this.btnList.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnList1 = this.btnList;
    point1 = new Point(480, 112 /*0x70*/);
    Point point3 = point1;
    btnList1.Location = point3;
    this.btnList.Name = "btnList";
    Button btnList2 = this.btnList;
    size1 = new Size(18, 22);
    Size size3 = size1;
    btnList2.Size = size3;
    this.btnList.TabIndex = 123;
    this.btnList.Text = "v";
    this.btnList.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(70, 30);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(95, 44);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 151;
    this.DataGridView1.Visible = false;
    TextBox txtAmemId1 = this.txtAMemId;
    point1 = new Point(505, 114);
    Point point5 = point1;
    txtAmemId1.Location = point5;
    this.txtAMemId.Name = "txtAMemId";
    TextBox txtAmemId2 = this.txtAMemId;
    size1 = new Size(20, 20);
    Size size5 = size1;
    txtAmemId2.Size = size5;
    this.txtAMemId.TabIndex = 150;
    this.txtAMemId.Visible = false;
    this.lblMemName.AutoSize = true;
    Label lblMemName1 = this.lblMemName;
    point1 = new Point(282, 135);
    Point point6 = point1;
    lblMemName1.Location = point6;
    this.lblMemName.Name = "lblMemName";
    Label lblMemName2 = this.lblMemName;
    size1 = new Size(50, 13);
    Size size6 = size1;
    lblMemName2.Size = size6;
    this.lblMemName.TabIndex = 149;
    this.lblMemName.Text = "Mem No.";
    this.lblFlatNo.AutoSize = true;
    Label lblFlatNo1 = this.lblFlatNo;
    point1 = new Point(201, 135);
    Point point7 = point1;
    lblFlatNo1.Location = point7;
    this.lblFlatNo.Name = "lblFlatNo";
    Label lblFlatNo2 = this.lblFlatNo;
    size1 = new Size(50, 13);
    Size size7 = size1;
    lblFlatNo2.Size = size7;
    this.lblFlatNo.TabIndex = 148;
    this.lblFlatNo.Text = "Mem No.";
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(67, 452);
    Point point8 = point1;
    label6_1.Location = point8;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(49, 13);
    Size size8 = size1;
    label6_2.Size = size8;
    this.Label6.TabIndex = 147;
    this.Label6.Text = "Remarks";
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(67, 410);
    Point point9 = point1;
    label7_1.Location = point9;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(119, 13);
    Size size9 = size1;
    label7_2.Size = size9;
    this.Label7.TabIndex = 146;
    this.Label7.Text = "Cancellation Effect from";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(67, 368);
    Point point10 = point1;
    label8_1.Location = point10;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(78, 13);
    Size size10 = size1;
    label8_2.Size = size10;
    this.Label8.TabIndex = 145;
    this.Label8.Text = "Date of Cancel";
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(67, 326);
    Point point11 = point1;
    label9_1.Location = point11;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(80 /*0x50*/, 13);
    Size size11 = size1;
    label9_2.Size = size11;
    this.Label9.TabIndex = 144 /*0x90*/;
    this.Label9.Text = "Date of Passed";
    this.Label10.AutoSize = true;
    Label label10_1 = this.Label10;
    point1 = new Point(67, 284);
    Point point12 = point1;
    label10_1.Location = point12;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(26, 13);
    Size size12 = size1;
    label10_2.Size = size12;
    this.Label10.TabIndex = 143;
    this.Label10.Text = "Age";
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(67, 242);
    Point point13 = point1;
    label5_1.Location = point13;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(90, 13);
    Size size13 = size1;
    label5_2.Size = size13;
    this.Label5.TabIndex = 142;
    this.Label5.Text = "Nominee Address";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(67, 200);
    Point point14 = point1;
    label4_1.Location = point14;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(80 /*0x50*/, 13);
    Size size14 = size1;
    label4_2.Size = size14;
    this.Label4.TabIndex = 141;
    this.Label4.Text = "Nominee Name";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(67, 158);
    Point point15 = point1;
    label3_1.Location = point15;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(98, 13);
    Size size15 = size1;
    label3_2.Size = size15;
    this.Label3.TabIndex = 140;
    this.Label3.Text = "Date of Nomination";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(67, 77);
    Point point16 = point1;
    label2_1.Location = point16;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(93, 13);
    Size size16 = size1;
    label2_2.Size = size16;
    this.Label2.TabIndex = 139;
    this.Label2.Text = "Nomination Sr.No.";
    TextBox txtNpart1 = this.txtNPART;
    point1 = new Point(195, 449);
    Point point17 = point1;
    txtNpart1.Location = point17;
    this.txtNPART.Name = "txtNPART";
    TextBox txtNpart2 = this.txtNPART;
    size1 = new Size(303, 20);
    Size size17 = size1;
    txtNpart2.Size = size17;
    this.txtNPART.TabIndex = 131;
    TextBox txtNdoe1 = this.txtNDOE;
    point1 = new Point(195, 407);
    Point point18 = point1;
    txtNdoe1.Location = point18;
    this.txtNDOE.Name = "txtNDOE";
    TextBox txtNdoe2 = this.txtNDOE;
    size1 = new Size(303, 20);
    Size size18 = size1;
    txtNdoe2.Size = size18;
    this.txtNDOE.TabIndex = 130;
    TextBox txtNdoc1 = this.txtNDOC;
    point1 = new Point(195, 365);
    Point point19 = point1;
    txtNdoc1.Location = point19;
    this.txtNDOC.Name = "txtNDOC";
    TextBox txtNdoc2 = this.txtNDOC;
    size1 = new Size(303, 20);
    Size size19 = size1;
    txtNdoc2.Size = size19;
    this.txtNDOC.TabIndex = 129;
    TextBox txtNdop1 = this.txtNDOP;
    point1 = new Point(195, 323);
    Point point20 = point1;
    txtNdop1.Location = point20;
    this.txtNDOP.Name = "txtNDOP";
    TextBox txtNdop2 = this.txtNDOP;
    size1 = new Size(303, 20);
    Size size20 = size1;
    txtNdop2.Size = size20;
    this.txtNDOP.TabIndex = 128 /*0x80*/;
    TextBox txtNage1 = this.txtNage;
    point1 = new Point(195, 281);
    Point point21 = point1;
    txtNage1.Location = point21;
    this.txtNage.Name = "txtNage";
    TextBox txtNage2 = this.txtNage;
    size1 = new Size(303, 20);
    Size size21 = size1;
    txtNage2.Size = size21;
    this.txtNage.TabIndex = (int) sbyte.MaxValue;
    TextBox txtNaddress1 = this.txtNaddress;
    point1 = new Point(195, 239);
    Point point22 = point1;
    txtNaddress1.Location = point22;
    this.txtNaddress.Name = "txtNaddress";
    TextBox txtNaddress2 = this.txtNaddress;
    size1 = new Size(303, 20);
    Size size22 = size1;
    txtNaddress2.Size = size22;
    this.txtNaddress.TabIndex = 126;
    TextBox txtNname1 = this.txtNName;
    point1 = new Point(195, 197);
    Point point23 = point1;
    txtNname1.Location = point23;
    this.txtNName.Name = "txtNName";
    TextBox txtNname2 = this.txtNName;
    size1 = new Size(303, 20);
    Size size23 = size1;
    txtNname2.Size = size23;
    this.txtNName.TabIndex = 125;
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(194, 504);
    Point point24 = point1;
    btnUpdate1.Location = point24;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size24 = size1;
    btnUpdate2.Size = size24;
    this.btnUpdate.TabIndex = 134;
    this.btnUpdate.Text = "&Update";
    this.btnUpdate.UseVisualStyleBackColor = true;
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(194, 504);
    Point point25 = point1;
    btnDelete1.Location = point25;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size25 = size1;
    btnDelete2.Size = size25;
    this.btnDelete.TabIndex = 132;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    this.lblId.AutoSize = true;
    Label lblId1 = this.lblId;
    point1 = new Point(282, 41);
    Point point26 = point1;
    lblId1.Location = point26;
    this.lblId.Name = "lblId";
    Label lblId2 = this.lblId;
    size1 = new Size(39, 13);
    Size size26 = size1;
    lblId2.Size = size26;
    this.lblId.TabIndex = 138;
    this.lblId.Text = "Label8";
    this.lblId.Visible = false;
    TextBox txtNdor1 = this.txtNDOR;
    point1 = new Point(195, 155);
    Point point27 = point1;
    txtNdor1.Location = point27;
    this.txtNDOR.Name = "txtNDOR";
    TextBox txtNdor2 = this.txtNDOR;
    size1 = new Size(303, 20);
    Size size27 = size1;
    txtNdor2.Size = size27;
    this.txtNDOR.TabIndex = 124;
    TextBox txtNsrno1 = this.txtNsrno;
    point1 = new Point(195, 74);
    Point point28 = point1;
    txtNsrno1.Location = point28;
    this.txtNsrno.Name = "txtNsrno";
    TextBox txtNsrno2 = this.txtNsrno;
    size1 = new Size(303, 20);
    Size size28 = size1;
    txtNsrno2.Size = size28;
    this.txtNsrno.TabIndex = 122;
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(299, 504);
    Point point29 = point1;
    btnCancel1.Location = point29;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size29 = size1;
    btnCancel2.Size = size29;
    this.btnCancel.TabIndex = 135;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.txtMemId.Enabled = false;
    TextBox txtMemId1 = this.txtMemId;
    point1 = new Point(195, 112 /*0x70*/);
    Point point30 = point1;
    txtMemId1.Location = point30;
    this.txtMemId.Name = "txtMemId";
    TextBox txtMemId2 = this.txtMemId;
    size1 = new Size(303, 20);
    Size size30 = size1;
    txtMemId2.Size = size30;
    this.txtMemId.TabIndex = 137;
    this.txtMemId.TabStop = false;
    Button btnSave1 = this.btnSave;
    point1 = new Point(194, 504);
    Point point31 = point1;
    btnSave1.Location = point31;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size31 = size1;
    btnSave2.Size = size31;
    this.btnSave.TabIndex = 133;
    this.btnSave.Text = "&Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(67, 117);
    Point point32 = point1;
    label1_1.Location = point32;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(94, 13);
    Size size32 = size1;
    label1_2.Size = size32;
    this.Label1.TabIndex = 136;
    this.Label1.Text = "Member Regn.No.";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtNId);
    this.Controls.Add((Control) this.btnList);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.txtAMemId);
    this.Controls.Add((Control) this.lblMemName);
    this.Controls.Add((Control) this.lblFlatNo);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtNPART);
    this.Controls.Add((Control) this.txtNDOE);
    this.Controls.Add((Control) this.txtNDOC);
    this.Controls.Add((Control) this.txtNDOP);
    this.Controls.Add((Control) this.txtNage);
    this.Controls.Add((Control) this.txtNaddress);
    this.Controls.Add((Control) this.txtNName);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.lblId);
    this.Controls.Add((Control) this.txtNDOR);
    this.Controls.Add((Control) this.txtNsrno);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.txtMemId);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.Label1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatNDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmStatNDetail);
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox txtNId
  {
    [DebuggerNonUserCode] get => this._txtNId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNId = value;
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

  internal virtual TextBox txtAMemId
  {
    [DebuggerNonUserCode] get => this._txtAMemId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtAMemId = value;
    }
  }

  internal virtual Label lblMemName
  {
    [DebuggerNonUserCode] get => this._lblMemName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemName = value;
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

  internal virtual TextBox txtNPART
  {
    [DebuggerNonUserCode] get => this._txtNPART;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNPART_KeyDown);
      if (this._txtNPART != null)
        this._txtNPART.KeyDown -= keyEventHandler;
      this._txtNPART = value;
      if (this._txtNPART == null)
        return;
      this._txtNPART.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtNDOE
  {
    [DebuggerNonUserCode] get => this._txtNDOE;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNDOE_KeyDown);
      if (this._txtNDOE != null)
        this._txtNDOE.KeyDown -= keyEventHandler;
      this._txtNDOE = value;
      if (this._txtNDOE == null)
        return;
      this._txtNDOE.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtNDOC
  {
    [DebuggerNonUserCode] get => this._txtNDOC;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNDOC_KeyDown);
      if (this._txtNDOC != null)
        this._txtNDOC.KeyDown -= keyEventHandler;
      this._txtNDOC = value;
      if (this._txtNDOC == null)
        return;
      this._txtNDOC.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtNDOP
  {
    [DebuggerNonUserCode] get => this._txtNDOP;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNDOP_KeyDown);
      if (this._txtNDOP != null)
        this._txtNDOP.KeyDown -= keyEventHandler;
      this._txtNDOP = value;
      if (this._txtNDOP == null)
        return;
      this._txtNDOP.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtNage
  {
    [DebuggerNonUserCode] get => this._txtNage;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNage_KeyDown);
      if (this._txtNage != null)
        this._txtNage.KeyDown -= keyEventHandler;
      this._txtNage = value;
      if (this._txtNage == null)
        return;
      this._txtNage.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtNaddress
  {
    [DebuggerNonUserCode] get => this._txtNaddress;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNaddress_KeyDown);
      if (this._txtNaddress != null)
        this._txtNaddress.KeyDown -= keyEventHandler;
      this._txtNaddress = value;
      if (this._txtNaddress == null)
        return;
      this._txtNaddress.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtNName
  {
    [DebuggerNonUserCode] get => this._txtNName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNName_KeyDown);
      if (this._txtNName != null)
        this._txtNName.KeyDown -= keyEventHandler;
      this._txtNName = value;
      if (this._txtNName == null)
        return;
      this._txtNName.KeyDown += keyEventHandler;
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

  internal virtual Label lblId
  {
    [DebuggerNonUserCode] get => this._lblId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblId = value;
  }

  internal virtual TextBox txtNDOR
  {
    [DebuggerNonUserCode] get => this._txtNDOR;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNDOR_KeyDown);
      if (this._txtNDOR != null)
        this._txtNDOR.KeyDown -= keyEventHandler;
      this._txtNDOR = value;
      if (this._txtNDOR == null)
        return;
      this._txtNDOR.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtNsrno
  {
    [DebuggerNonUserCode] get => this._txtNsrno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtNsrno_TextChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtNsrno_LostFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNsrno_KeyDown);
      if (this._txtNsrno != null)
      {
        this._txtNsrno.TextChanged -= eventHandler1;
        this._txtNsrno.LostFocus -= eventHandler2;
        this._txtNsrno.KeyDown -= keyEventHandler;
      }
      this._txtNsrno = value;
      if (this._txtNsrno == null)
        return;
      this._txtNsrno.TextChanged += eventHandler1;
      this._txtNsrno.LostFocus += eventHandler2;
      this._txtNsrno.KeyDown += keyEventHandler;
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

  private void frmStatNDetail_Load(object sender, EventArgs e)
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
    if (e.KeyCode != Keys.F5)
      return;
    int num = (int) MyProject.Forms.frmListCall.ShowDialog();
    this.txtMemId.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    this.txtAMemId.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    this.lblFlatNo.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    this.lblMemName.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    MyProject.Forms.frmListCall = (frmListCall) null;
    this.txtNDOR.Focus();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    bool flag = false;
    if (!Versioned.IsNumeric((object) this.txtNsrno.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNsrno.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtNsrno.Focus();
    }
    else if (Strings.Len(Strings.Trim(this.txtMemId.Text)) == 0)
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
        if (Strings.InStr(Strings.Trim(this.txtAMemId.Text), this.DataGridView1.Rows[index].Cells[3].Value.ToString()) == 1)
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
        this.txtNDOR.Text = this.txtNDOR.Text.ToString().Replace("'", "''");
        this.txtNName.Text = this.txtNName.Text.ToString().Replace("'", "''");
        this.txtNaddress.Text = this.txtNaddress.Text.ToString().Replace("'", "''");
        this.txtNage.Text = this.txtNage.Text.ToString().Replace("'", "''");
        this.txtNDOP.Text = this.txtNDOP.Text.ToString().Replace("'", "''");
        this.txtNDOC.Text = this.txtNDOC.Text.ToString().Replace("'", "''");
        this.txtNDOE.Text = this.txtNDOE.Text.ToString().Replace("'", "''");
        this.txtNPART.Text = this.txtNPART.Text.ToString().Replace("'", "''");
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
        connection.Open();
        new OleDbCommand($"Insert Into Nreg (MemId, Nsrno, NDOR, NName, Naddress, Nage, NDOP, NDOC, NDOE, NPART) values ('{Conversions.ToString(Conversion.Val(this.txtAMemId.Text.Trim()))}','{Conversions.ToString(Conversion.Val(this.txtNsrno.Text.Trim()))}','{this.txtNDOR.Text.Trim()}','{this.txtNName.Text.Trim()}','{this.txtNaddress.Text.Trim()}','{this.txtNage.Text.Trim()}','{this.txtNDOP.Text.Trim()}','{this.txtNDOC.Text.Trim()}','{this.txtNDOE.Text.Trim()}','{this.txtNPART.Text.Trim()}')", connection).ExecuteNonQuery();
        connection.Close();
        this.Close();
      }
    }
  }

  private void txtNsrno_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnList.Focus();
  }

  private void txtNsrno_LostFocus(object sender, EventArgs e)
  {
    if (!(!Versioned.IsNumeric((object) this.txtNsrno.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNsrno.Text, "", false) != 0))
      return;
    this.txtNsrno.Focus();
  }

  private void txtNsrno_TextChanged(object sender, EventArgs e)
  {
    if (!(!Versioned.IsNumeric((object) this.txtNsrno.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNsrno.Text, "", false) != 0))
      return;
    int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
    this.txtNsrno.Focus();
  }

  private void btnList_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmListCall.txtComMemcode.Text = this.txtMemId.Text;
    MyProject.Forms.frmListCall.lblStatus.Text = "Exit";
    int num = (int) MyProject.Forms.frmListCall.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmListCall.lblStatus.Text, "Select", false) == 0)
    {
      this.txtMemId.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[0].Value.ToString();
      this.txtAMemId.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[3].Value.ToString();
      this.lblFlatNo.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[1].Value.ToString();
      this.lblMemName.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    }
    MyProject.Forms.frmListCall = (frmListCall) null;
    this.txtNDOR.Focus();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtNsrno.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNsrno.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtNsrno.Focus();
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
          if (Strings.InStr(Strings.Trim(this.txtAMemId.Text), this.DataGridView1.Rows[index].Cells[3].Value.ToString()) == 1)
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
          this.txtNDOR.Text = this.txtNDOR.Text.ToString().Replace("'", "''");
          this.txtNName.Text = this.txtNName.Text.ToString().Replace("'", "''");
          this.txtNaddress.Text = this.txtNaddress.Text.ToString().Replace("'", "''");
          this.txtNage.Text = this.txtNage.Text.ToString().Replace("'", "''");
          this.txtNDOP.Text = this.txtNDOP.Text.ToString().Replace("'", "''");
          this.txtNDOC.Text = this.txtNDOC.Text.ToString().Replace("'", "''");
          this.txtNDOE.Text = this.txtNDOE.Text.ToString().Replace("'", "''");
          this.txtNPART.Text = this.txtNPART.Text.ToString().Replace("'", "''");
          OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
          connection.Open();
          new OleDbCommand($"update NReg set MemId ='{Conversions.ToString(Conversion.Val(this.txtAMemId.Text.Trim()))}' ,Nsrno ='{Conversions.ToString(Conversion.Val(this.txtNsrno.Text.Trim()))}' ,NDOR ='{this.txtNDOR.Text.Trim()}' ,NName ='{this.txtNName.Text.Trim()}' ,Naddress ='{this.txtNaddress.Text.Trim()}' ,Nage ='{this.txtNage.Text.Trim()}' ,NDOP ='{this.txtNDOP.Text.Trim()}' ,NDOC ='{this.txtNDOC.Text.Trim()}' ,NDOE ='{this.txtNDOE.Text.Trim()}' ,NPART ='{this.txtNPART.Text.Trim()}'  where Id ={Conversions.ToString(Conversion.Val(this.txtNId.Text.Trim()))}", connection).ExecuteNonQuery();
          connection.Close();
          this.Close();
        }
      }
    }
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (Interaction.MsgBox((object) ("Are you Sure you want to Delete Nomination Entry " + this.txtNsrno.Text), MsgBoxStyle.YesNo, (object) "!!! WARNING... !!!") == MsgBoxResult.Yes)
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
      connection.Open();
      new OleDbCommand($"Delete From NReg where Id ={Conversions.ToString(Conversion.Val(this.txtNId.Text.Trim()))}", connection).ExecuteNonQuery();
      connection.Close();
    }
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void txtNDOR_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNName.Focus();
  }

  private void txtNName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNaddress.Focus();
  }

  private void txtNaddress_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNage.Focus();
  }

  private void txtNage_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNDOP.Focus();
  }

  private void txtNDOP_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNDOC.Focus();
  }

  private void txtNDOC_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNDOE.Focus();
  }

  private void txtNDOE_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNPART.Focus();
  }

  private void txtNPART_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    if (this.btnSave.Visible)
      this.btnSave.Focus();
    if (this.btnUpdate.Visible)
      this.btnUpdate.Focus();
    if (!this.btnDelete.Visible)
      return;
    this.btnDelete.Focus();
  }
}
