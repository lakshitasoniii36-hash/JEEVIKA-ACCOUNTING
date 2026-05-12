// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatSIDetail
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
public class frmStatSIDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("lblFlatNo")]
  private Label _lblFlatNo;
  [AccessedThroughProperty("lblMname")]
  private Label _lblMname;
  [AccessedThroughProperty("btnList")]
  private Button _btnList;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
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
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtRemark")]
  private TextBox _txtRemark;
  [AccessedThroughProperty("txtCamount")]
  private TextBox _txtCamount;
  [AccessedThroughProperty("txtCSRNO")]
  private TextBox _txtCSRNO;
  [AccessedThroughProperty("txtCDOI")]
  private TextBox _txtCDOI;
  [AccessedThroughProperty("txtTotal")]
  private TextBox _txtTotal;
  [AccessedThroughProperty("txtCont")]
  private TextBox _txtCont;
  [AccessedThroughProperty("txtno")]
  private TextBox _txtno;
  [AccessedThroughProperty("lblId")]
  private Label _lblId;
  [AccessedThroughProperty("txtDate")]
  private TextBox _txtDate;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("txtMemId")]
  private TextBox _txtMemId;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtnMemId")]
  private TextBox _txtnMemId;

  [DebuggerNonUserCode]
  static frmStatSIDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmStatSIDetail()
  {
    this.Load += new EventHandler(this.frmStatSIDetail_Load);
    frmStatSIDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatSIDetail.__ENCList)
    {
      if (frmStatSIDetail.__ENCList.Count == frmStatSIDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatSIDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatSIDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatSIDetail.__ENCList[index1] = frmStatSIDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatSIDetail.__ENCList.RemoveRange(index1, checked (frmStatSIDetail.__ENCList.Count - index1));
        frmStatSIDetail.__ENCList.Capacity = frmStatSIDetail.__ENCList.Count;
      }
      frmStatSIDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatSIDetail));
    this.btnSave = new Button();
    this.lblFlatNo = new Label();
    this.lblMname = new Label();
    this.btnList = new Button();
    this.DataGridView1 = new DataGridView();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label2 = new Label();
    this.txtRemark = new TextBox();
    this.txtCamount = new TextBox();
    this.txtCSRNO = new TextBox();
    this.txtCDOI = new TextBox();
    this.txtTotal = new TextBox();
    this.txtCont = new TextBox();
    this.txtno = new TextBox();
    this.lblId = new Label();
    this.txtDate = new TextBox();
    this.btnCancel = new Button();
    this.txtMemId = new TextBox();
    this.Label1 = new Label();
    this.txtnMemId = new TextBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    Button btnSave1 = this.btnSave;
    Point point1 = new Point(201, 502);
    Point point2 = point1;
    btnSave1.Location = point2;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnSave2.Size = size2;
    this.btnSave.TabIndex = 208 /*0xD0*/;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.lblFlatNo.AutoSize = true;
    Label lblFlatNo1 = this.lblFlatNo;
    point1 = new Point(242, 62);
    Point point3 = point1;
    lblFlatNo1.Location = point3;
    this.lblFlatNo.Name = "lblFlatNo";
    Label lblFlatNo2 = this.lblFlatNo;
    size1 = new Size(39, 13);
    Size size3 = size1;
    lblFlatNo2.Size = size3;
    this.lblFlatNo.TabIndex = 206;
    this.lblFlatNo.Text = "Label8";
    this.lblFlatNo.Visible = false;
    this.lblMname.AutoSize = true;
    Label lblMname1 = this.lblMname;
    point1 = new Point(287, 88);
    Point point4 = point1;
    lblMname1.Location = point4;
    this.lblMname.Name = "lblMname";
    Label lblMname2 = this.lblMname;
    size1 = new Size(39, 13);
    Size size4 = size1;
    lblMname2.Size = size4;
    this.lblMname.TabIndex = 205;
    this.lblMname.Text = "Label8";
    this.btnList.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnList1 = this.btnList;
    point1 = new Point(263, 83);
    Point point5 = point1;
    btnList1.Location = point5;
    this.btnList.Name = "btnList";
    Button btnList2 = this.btnList;
    size1 = new Size(18, 22);
    Size size5 = size1;
    btnList2.Size = size5;
    this.btnList.TabIndex = 204;
    this.btnList.Text = "v";
    this.btnList.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(134, 31 /*0x1F*/);
    Point point6 = point1;
    dataGridView1_1.Location = point6;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(70, 21);
    Size size6 = size1;
    dataGridView1_2.Size = size6;
    this.DataGridView1.TabIndex = 203;
    this.DataGridView1.Visible = false;
    this.Label11.AutoSize = true;
    Label label11_1 = this.Label11;
    point1 = new Point(82, 360);
    Point point7 = point1;
    label11_1.Location = point7;
    this.Label11.Name = "Label11";
    Label label11_2 = this.Label11;
    size1 = new Size(49, 13);
    Size size7 = size1;
    label11_2.Size = size7;
    this.Label11.TabIndex = 202;
    this.Label11.Text = "Remarks";
    this.Label12.AutoSize = true;
    Label label12_1 = this.Label12;
    point1 = new Point(82, 326);
    Point point8 = point1;
    label12_1.Location = point8;
    this.Label12.Name = "Label12";
    Label label12_2 = this.Label12;
    size1 = new Size(93, 13);
    Size size8 = size1;
    label12_2.Size = size8;
    this.Label12.TabIndex = 201;
    this.Label12.Text = "Certificate Amount";
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(82, 292);
    Point point9 = point1;
    label6_1.Location = point9;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(74, 13);
    Size size9 = size1;
    label6_2.Size = size9;
    this.Label6.TabIndex = 200;
    this.Label6.Text = "Certificate No.";
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(82, 262);
    Point point10 = point1;
    label7_1.Location = point10;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(70, 13);
    Size size10 = size1;
    label7_2.Size = size10;
    this.Label7.TabIndex = 199;
    this.Label7.Text = "Date of Issue";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(82, 224 /*0xE0*/);
    Point point11 = point1;
    label8_1.Location = point11;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(34, 13);
    Size size11 = size1;
    label8_2.Size = size11;
    this.Label8.TabIndex = 198;
    this.Label8.Text = "Total.";
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(82, 190);
    Point point12 = point1;
    label9_1.Location = point12;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(43, 13);
    Size size12 = size1;
    label9_2.Size = size12;
    this.Label9.TabIndex = 197;
    this.Label9.Text = "Amount";
    this.Label10.AutoSize = true;
    Label label10_1 = this.Label10;
    point1 = new Point(82, 156);
    Point point13 = point1;
    label10_1.Location = point13;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(67, 13);
    Size size13 = size1;
    label10_2.Size = size13;
    this.Label10.TabIndex = 196;
    this.Label10.Text = "B.No./R.No.";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(82, 120);
    Point point14 = point1;
    label2_1.Location = point14;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(30, 13);
    Size size14 = size1;
    label2_2.Size = size14;
    this.Label2.TabIndex = 195;
    this.Label2.Text = "Date";
    TextBox txtRemark1 = this.txtRemark;
    point1 = new Point(207, 357);
    Point point15 = point1;
    txtRemark1.Location = point15;
    this.txtRemark.Name = "txtRemark";
    TextBox txtRemark2 = this.txtRemark;
    size1 = new Size(303, 20);
    Size size15 = size1;
    txtRemark2.Size = size15;
    this.txtRemark.TabIndex = 194;
    TextBox txtCamount1 = this.txtCamount;
    point1 = new Point(207, 323);
    Point point16 = point1;
    txtCamount1.Location = point16;
    this.txtCamount.Name = "txtCamount";
    TextBox txtCamount2 = this.txtCamount;
    size1 = new Size(303, 20);
    Size size16 = size1;
    txtCamount2.Size = size16;
    this.txtCamount.TabIndex = 193;
    TextBox txtCsrno1 = this.txtCSRNO;
    point1 = new Point(207, 289);
    Point point17 = point1;
    txtCsrno1.Location = point17;
    this.txtCSRNO.Name = "txtCSRNO";
    TextBox txtCsrno2 = this.txtCSRNO;
    size1 = new Size(303, 20);
    Size size17 = size1;
    txtCsrno2.Size = size17;
    this.txtCSRNO.TabIndex = 192 /*0xC0*/;
    TextBox txtCdoi1 = this.txtCDOI;
    point1 = new Point(207, (int) byte.MaxValue);
    Point point18 = point1;
    txtCdoi1.Location = point18;
    this.txtCDOI.Name = "txtCDOI";
    TextBox txtCdoi2 = this.txtCDOI;
    size1 = new Size(303, 20);
    Size size18 = size1;
    txtCdoi2.Size = size18;
    this.txtCDOI.TabIndex = 191;
    TextBox txtTotal1 = this.txtTotal;
    point1 = new Point(207, 221);
    Point point19 = point1;
    txtTotal1.Location = point19;
    this.txtTotal.Name = "txtTotal";
    TextBox txtTotal2 = this.txtTotal;
    size1 = new Size(303, 20);
    Size size19 = size1;
    txtTotal2.Size = size19;
    this.txtTotal.TabIndex = 190;
    TextBox txtCont1 = this.txtCont;
    point1 = new Point(207, 187);
    Point point20 = point1;
    txtCont1.Location = point20;
    this.txtCont.Name = "txtCont";
    TextBox txtCont2 = this.txtCont;
    size1 = new Size(303, 20);
    Size size20 = size1;
    txtCont2.Size = size20;
    this.txtCont.TabIndex = 189;
    TextBox txtno1 = this.txtno;
    point1 = new Point(207, 153);
    Point point21 = point1;
    txtno1.Location = point21;
    this.txtno.Name = "txtno";
    TextBox txtno2 = this.txtno;
    size1 = new Size(303, 20);
    Size size21 = size1;
    txtno2.Size = size21;
    this.txtno.TabIndex = 188;
    this.lblId.AutoSize = true;
    Label lblId1 = this.lblId;
    point1 = new Point(287, 39);
    Point point22 = point1;
    lblId1.Location = point22;
    this.lblId.Name = "lblId";
    Label lblId2 = this.lblId;
    size1 = new Size(39, 13);
    Size size22 = size1;
    lblId2.Size = size22;
    this.lblId.TabIndex = 187;
    this.lblId.Text = "Label8";
    this.lblId.Visible = false;
    TextBox txtDate1 = this.txtDate;
    point1 = new Point(207, 117);
    Point point23 = point1;
    txtDate1.Location = point23;
    this.txtDate.Name = "txtDate";
    TextBox txtDate2 = this.txtDate;
    size1 = new Size(303, 20);
    Size size23 = size1;
    txtDate2.Size = size23;
    this.txtDate.TabIndex = 186;
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(306, 502);
    Point point24 = point1;
    btnCancel1.Location = point24;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size24 = size1;
    btnCancel2.Size = size24;
    this.btnCancel.TabIndex = 185;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    TextBox txtMemId1 = this.txtMemId;
    point1 = new Point(207, 59);
    Point point25 = point1;
    txtMemId1.Location = point25;
    this.txtMemId.Name = "txtMemId";
    TextBox txtMemId2 = this.txtMemId;
    size1 = new Size(27, 20);
    Size size25 = size1;
    txtMemId2.Size = size25;
    this.txtMemId.TabIndex = 184;
    this.txtMemId.Visible = false;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(82, 86);
    Point point26 = point1;
    label1_1.Location = point26;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(50, 13);
    Size size26 = size1;
    label1_2.Size = size26;
    this.Label1.TabIndex = 183;
    this.Label1.Text = "Mem No.";
    this.txtnMemId.Enabled = false;
    TextBox txtnMemId1 = this.txtnMemId;
    point1 = new Point(207, 85);
    Point point27 = point1;
    txtnMemId1.Location = point27;
    this.txtnMemId.Name = "txtnMemId";
    TextBox txtnMemId2 = this.txtnMemId;
    size1 = new Size(74, 20);
    Size size27 = size1;
    txtnMemId2.Size = size27;
    this.txtnMemId.TabIndex = 207;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lblFlatNo);
    this.Controls.Add((Control) this.lblMname);
    this.Controls.Add((Control) this.btnList);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.Label11);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtRemark);
    this.Controls.Add((Control) this.txtCamount);
    this.Controls.Add((Control) this.txtCSRNO);
    this.Controls.Add((Control) this.txtCDOI);
    this.Controls.Add((Control) this.txtTotal);
    this.Controls.Add((Control) this.txtCont);
    this.Controls.Add((Control) this.txtno);
    this.Controls.Add((Control) this.lblId);
    this.Controls.Add((Control) this.txtDate);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.txtMemId);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtnMemId);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatSIDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmStatSIDetail);
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Label lblFlatNo
  {
    [DebuggerNonUserCode] get => this._lblFlatNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFlatNo = value;
    }
  }

  internal virtual Label lblMname
  {
    [DebuggerNonUserCode] get => this._lblMname;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMname = value;
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

  internal virtual TextBox txtCamount
  {
    [DebuggerNonUserCode] get => this._txtCamount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtCamount_KeyDown);
      if (this._txtCamount != null)
        this._txtCamount.KeyDown -= keyEventHandler;
      this._txtCamount = value;
      if (this._txtCamount == null)
        return;
      this._txtCamount.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtCSRNO
  {
    [DebuggerNonUserCode] get => this._txtCSRNO;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtCSRNO_KeyDown);
      if (this._txtCSRNO != null)
        this._txtCSRNO.KeyDown -= keyEventHandler;
      this._txtCSRNO = value;
      if (this._txtCSRNO == null)
        return;
      this._txtCSRNO.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtCDOI
  {
    [DebuggerNonUserCode] get => this._txtCDOI;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtCDOI_KeyDown);
      if (this._txtCDOI != null)
        this._txtCDOI.KeyDown -= keyEventHandler;
      this._txtCDOI = value;
      if (this._txtCDOI == null)
        return;
      this._txtCDOI.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtTotal
  {
    [DebuggerNonUserCode] get => this._txtTotal;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtTotal_KeyDown);
      if (this._txtTotal != null)
        this._txtTotal.KeyDown -= keyEventHandler;
      this._txtTotal = value;
      if (this._txtTotal == null)
        return;
      this._txtTotal.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtCont
  {
    [DebuggerNonUserCode] get => this._txtCont;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtCont_KeyDown);
      if (this._txtCont != null)
        this._txtCont.KeyDown -= keyEventHandler;
      this._txtCont = value;
      if (this._txtCont == null)
        return;
      this._txtCont.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtno
  {
    [DebuggerNonUserCode] get => this._txtno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtno_KeyDown);
      if (this._txtno != null)
        this._txtno.KeyDown -= keyEventHandler;
      this._txtno = value;
      if (this._txtno == null)
        return;
      this._txtno.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label lblId
  {
    [DebuggerNonUserCode] get => this._lblId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblId = value;
  }

  internal virtual TextBox txtDate
  {
    [DebuggerNonUserCode] get => this._txtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDate_KeyDown);
      if (this._txtDate != null)
        this._txtDate.KeyDown -= keyEventHandler;
      this._txtDate = value;
      if (this._txtDate == null)
        return;
      this._txtDate.KeyDown += keyEventHandler;
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
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtMemId = value;
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

  private void frmStatSIDetail_Load(object sender, EventArgs e)
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
    this.txtDate.Focus();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void txtnMemId_KeyDown(object sender, KeyEventArgs e)
  {
    int num = (int) MyProject.Forms.frmListCall.ShowDialog();
    this.txtnMemId.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[0].Value.ToString();
    this.txtMemId.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    this.lblFlatNo.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    this.lblMname.Text = MyProject.Forms.frmListCall.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    MyProject.Forms.frmListCall = (frmListCall) null;
    this.txtDate.Focus();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtCont.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCont.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtCont.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtTotal.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtTotal.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtTotal.Focus();
    }
    else if (!Versioned.IsNumeric((object) this.txtCamount.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCamount.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtCamount.Focus();
    }
    else
    {
      this.txtMemId.Text = this.txtMemId.Text.ToString().Replace("'", "''");
      this.txtDate.Text = this.txtDate.Text.ToString().Replace("'", "''");
      this.txtno.Text = this.txtno.Text.ToString().Replace("'", "''");
      this.txtCDOI.Text = this.txtCDOI.Text.ToString().Replace("'", "''");
      this.txtCSRNO.Text = this.txtCSRNO.Text.ToString().Replace("'", "''");
      this.txtRemark.Text = this.txtRemark.Text.ToString().Replace("'", "''");
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
      connection.Open();
      string cmdText;
      string str;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        cmdText = $"Insert Into SFLed (MemId, SFDate, SFno, Cont, SFTotal, CDOI, CSRNO, Camount, Remark ) values ('{Conversions.ToString(Conversion.Val(this.txtMemId.Text.Trim()))}','{this.txtDate.Text.Trim()}','{this.txtno.Text.Trim()}','{Conversions.ToString(Conversion.Val(this.txtCont.Text.Trim()))}','{Conversions.ToString(Conversion.Val(this.txtTotal.Text.Trim()))}','{this.txtCDOI.Text.Trim()}','{this.txtCSRNO.Text.Trim()}','{Conversions.ToString(Conversion.Val(this.txtCamount.Text.Trim()))}','{this.txtRemark.Text.Trim()}')";
        str = "Record Added Successful";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        cmdText = $"update SFLed set MemId ='{Conversions.ToString(Conversion.Val(this.txtMemId.Text.Trim()))}' ,SFDate ='{this.txtDate.Text.Trim()}',SFno ='{this.txtno.Text.Trim()}',Cont ='{Conversions.ToString(Conversion.Val(this.txtCont.Text.Trim()))}',SFTotal ='{Conversions.ToString(Conversion.Val(this.txtTotal.Text.Trim()))}',CDOI ='{this.txtCDOI.Text.Trim()}',CSRNO ='{this.txtCSRNO.Text.Trim()}',Camount ='{Conversions.ToString(Conversion.Val(this.txtCamount.Text.Trim()))}',Remark ='{this.txtRemark.Text.Trim()}'   where Id ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}";
        str = "Record Updated Successful";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0 && Interaction.MsgBox((object) "Are you Sure you want to Delete Record ", MsgBoxStyle.YesNo, (object) "!!! WARNING... !!!") == MsgBoxResult.Yes)
      {
        cmdText = $"Delete From SFLed where Id ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}";
        str = "Record Delete Successful";
      }
      OleDbCommand oleDbCommand = new OleDbCommand(cmdText, connection);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "", false) != 0)
      {
        oleDbCommand.ExecuteNonQuery();
        int num = (int) Interaction.MsgBox((object) str);
      }
      connection.Close();
      this.Close();
    }
  }

  private void txtDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtno.Focus();
  }

  private void txtno_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtCont.Focus();
  }

  private void txtCont_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtTotal.Focus();
  }

  private void txtTotal_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtCDOI.Focus();
  }

  private void txtCDOI_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtCSRNO.Focus();
  }

  private void txtCSRNO_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtCamount.Focus();
  }

  private void txtCamount_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemark.Focus();
  }

  private void txtRemark_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
