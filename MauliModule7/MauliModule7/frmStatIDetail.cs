// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmStatIDetail
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
public class frmStatIDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("lblMname")]
  private Label _lblMname;
  [AccessedThroughProperty("lblMno")]
  private Label _lblMno;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtremark")]
  private TextBox _txtremark;
  [AccessedThroughProperty("txtCReason")]
  private TextBox _txtCReason;
  [AccessedThroughProperty("txtDOC")]
  private TextBox _txtDOC;
  [AccessedThroughProperty("txtAge")]
  private TextBox _txtAge;
  [AccessedThroughProperty("TxtOCCUPATION")]
  private TextBox _TxtOCCUPATION;
  [AccessedThroughProperty("txtDTENTPAY")]
  private TextBox _txtDTENTPAY;
  [AccessedThroughProperty("lblId")]
  private Label _lblId;
  [AccessedThroughProperty("txtDOA")]
  private TextBox _txtDOA;
  [AccessedThroughProperty("txtIsrno")]
  private TextBox _txtIsrno;
  [AccessedThroughProperty("txtMemId")]
  private TextBox _txtMemId;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;

  [DebuggerNonUserCode]
  static frmStatIDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmStatIDetail()
  {
    frmStatIDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmStatIDetail.__ENCList)
    {
      if (frmStatIDetail.__ENCList.Count == frmStatIDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmStatIDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmStatIDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmStatIDetail.__ENCList[index1] = frmStatIDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmStatIDetail.__ENCList.RemoveRange(index1, checked (frmStatIDetail.__ENCList.Count - index1));
        frmStatIDetail.__ENCList.Capacity = frmStatIDetail.__ENCList.Count;
      }
      frmStatIDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmStatIDetail));
    this.btnCancel = new Button();
    this.btnSave = new Button();
    this.lblMname = new Label();
    this.lblMno = new Label();
    this.Label9 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.txtremark = new TextBox();
    this.txtCReason = new TextBox();
    this.txtDOC = new TextBox();
    this.txtAge = new TextBox();
    this.TxtOCCUPATION = new TextBox();
    this.txtDTENTPAY = new TextBox();
    this.lblId = new Label();
    this.txtDOA = new TextBox();
    this.txtIsrno = new TextBox();
    this.txtMemId = new TextBox();
    this.Label1 = new Label();
    this.SuspendLayout();
    this.btnCancel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnCancel1 = this.btnCancel;
    Point point1 = new Point(296, 492);
    Point point2 = point1;
    btnCancel1.Location = point2;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnCancel2.Size = size2;
    this.btnCancel.TabIndex = 157;
    this.btnCancel.Text = "Ca&ncel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(191, 492);
    Point point3 = point1;
    btnSave1.Location = point3;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnSave2.Size = size3;
    this.btnSave.TabIndex = 156;
    this.btnSave.Text = "&Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.lblMname.AutoSize = true;
    Label lblMname1 = this.lblMname;
    point1 = new Point(207, 109);
    Point point4 = point1;
    lblMname1.Location = point4;
    this.lblMname.Name = "lblMname";
    Label lblMname2 = this.lblMname;
    size1 = new Size(39, 13);
    Size size4 = size1;
    lblMname2.Size = size4;
    this.lblMname.TabIndex = 155;
    this.lblMname.Text = "Label8";
    this.lblMno.AutoSize = true;
    Label lblMno1 = this.lblMno;
    point1 = new Point(207, 89);
    Point point5 = point1;
    lblMno1.Location = point5;
    this.lblMno.Name = "lblMno";
    Label lblMno2 = this.lblMno;
    size1 = new Size(39, 13);
    Size size5 = size1;
    lblMno2.Size = size5;
    this.lblMno.TabIndex = 154;
    this.lblMno.Text = "Label8";
    this.Label9.AutoSize = true;
    Label label9_1 = this.Label9;
    point1 = new Point(83, 441);
    Point point6 = point1;
    label9_1.Location = point6;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(49, 13);
    Size size6 = size1;
    label9_2.Size = size6;
    this.Label9.TabIndex = 153;
    this.Label9.Text = "Remarks";
    this.Label5.AutoSize = true;
    Label label5_1 = this.Label5;
    point1 = new Point(83, 397);
    Point point7 = point1;
    label5_1.Location = point7;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(108, 13);
    Size size7 = size1;
    label5_2.Size = size7;
    this.Label5.TabIndex = 152;
    this.Label5.Text = "Reason for Cessation";
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(83, 353);
    Point point8 = point1;
    label6_1.Location = point8;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(91, 13);
    Size size8 = size1;
    label6_2.Size = size8;
    this.Label6.TabIndex = 151;
    this.Label6.Text = "Date of Cessation";
    this.Label7.AutoSize = true;
    Label label7_1 = this.Label7;
    point1 = new Point(83, 309);
    Point point9 = point1;
    label7_1.Location = point9;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(26, 13);
    Size size9 = size1;
    label7_2.Size = size9;
    this.Label7.TabIndex = 150;
    this.Label7.Text = "Age";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(83, 265);
    Point point10 = point1;
    label8_1.Location = point10;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(62, 13);
    Size size10 = size1;
    label8_2.Size = size10;
    this.Label8.TabIndex = 149;
    this.Label8.Text = "Occupation";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(83, 221);
    Point point11 = point1;
    label4_1.Location = point11;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(121, 13);
    Size size11 = size1;
    label4_2.Size = size11;
    this.Label4.TabIndex = 148;
    this.Label4.Text = "Entrance Fee Paid Date";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(83, 177);
    Point point12 = point1;
    label3_1.Location = point12;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(92, 13);
    Size size12 = size1;
    label3_2.Size = size12;
    this.Label3.TabIndex = 147;
    this.Label3.Text = "Date of Admission";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(83, 133);
    Point point13 = point1;
    label2_1.Location = point13;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(46, 13);
    Size size13 = size1;
    label2_2.Size = size13;
    this.Label2.TabIndex = 146;
    this.Label2.Text = "I Sr. No.";
    TextBox txtremark1 = this.txtremark;
    point1 = new Point(206, 438);
    Point point14 = point1;
    txtremark1.Location = point14;
    this.txtremark.Name = "txtremark";
    TextBox txtremark2 = this.txtremark;
    size1 = new Size(303, 20);
    Size size14 = size1;
    txtremark2.Size = size14;
    this.txtremark.TabIndex = 145;
    TextBox txtCreason1 = this.txtCReason;
    point1 = new Point(206, 394);
    Point point15 = point1;
    txtCreason1.Location = point15;
    this.txtCReason.Name = "txtCReason";
    TextBox txtCreason2 = this.txtCReason;
    size1 = new Size(303, 20);
    Size size15 = size1;
    txtCreason2.Size = size15;
    this.txtCReason.TabIndex = 144 /*0x90*/;
    TextBox txtDoc1 = this.txtDOC;
    point1 = new Point(206, 350);
    Point point16 = point1;
    txtDoc1.Location = point16;
    this.txtDOC.Name = "txtDOC";
    TextBox txtDoc2 = this.txtDOC;
    size1 = new Size(303, 20);
    Size size16 = size1;
    txtDoc2.Size = size16;
    this.txtDOC.TabIndex = 143;
    TextBox txtAge1 = this.txtAge;
    point1 = new Point(206, 306);
    Point point17 = point1;
    txtAge1.Location = point17;
    this.txtAge.Name = "txtAge";
    TextBox txtAge2 = this.txtAge;
    size1 = new Size(303, 20);
    Size size17 = size1;
    txtAge2.Size = size17;
    this.txtAge.TabIndex = 142;
    TextBox txtOccupation1 = this.TxtOCCUPATION;
    point1 = new Point(206, 262);
    Point point18 = point1;
    txtOccupation1.Location = point18;
    this.TxtOCCUPATION.Name = "TxtOCCUPATION";
    TextBox txtOccupation2 = this.TxtOCCUPATION;
    size1 = new Size(303, 20);
    Size size18 = size1;
    txtOccupation2.Size = size18;
    this.TxtOCCUPATION.TabIndex = 141;
    TextBox txtDtentpay1 = this.txtDTENTPAY;
    point1 = new Point(206, 218);
    Point point19 = point1;
    txtDtentpay1.Location = point19;
    this.txtDTENTPAY.Name = "txtDTENTPAY";
    TextBox txtDtentpay2 = this.txtDTENTPAY;
    size1 = new Size(303, 20);
    Size size19 = size1;
    txtDtentpay2.Size = size19;
    this.txtDTENTPAY.TabIndex = 140;
    this.lblId.AutoSize = true;
    Label lblId1 = this.lblId;
    point1 = new Point(299, 41);
    Point point20 = point1;
    lblId1.Location = point20;
    this.lblId.Name = "lblId";
    Label lblId2 = this.lblId;
    size1 = new Size(39, 13);
    Size size20 = size1;
    lblId2.Size = size20;
    this.lblId.TabIndex = 139;
    this.lblId.Text = "Label8";
    TextBox txtDoa1 = this.txtDOA;
    point1 = new Point(206, 174);
    Point point21 = point1;
    txtDoa1.Location = point21;
    this.txtDOA.Name = "txtDOA";
    TextBox txtDoa2 = this.txtDOA;
    size1 = new Size(303, 20);
    Size size21 = size1;
    txtDoa2.Size = size21;
    this.txtDOA.TabIndex = 138;
    TextBox txtIsrno1 = this.txtIsrno;
    point1 = new Point(206, 130);
    Point point22 = point1;
    txtIsrno1.Location = point22;
    this.txtIsrno.Name = "txtIsrno";
    TextBox txtIsrno2 = this.txtIsrno;
    size1 = new Size(303, 20);
    Size size22 = size1;
    txtIsrno2.Size = size22;
    this.txtIsrno.TabIndex = 137;
    TextBox txtMemId1 = this.txtMemId;
    point1 = new Point(206, 86);
    Point point23 = point1;
    txtMemId1.Location = point23;
    this.txtMemId.Name = "txtMemId";
    TextBox txtMemId2 = this.txtMemId;
    size1 = new Size(303, 20);
    Size size23 = size1;
    txtMemId2.Size = size23;
    this.txtMemId.TabIndex = 136;
    this.txtMemId.TabStop = false;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(83, 89);
    Point point24 = point1;
    label1_1.Location = point24;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(50, 13);
    Size size24 = size1;
    label1_2.Size = size24;
    this.Label1.TabIndex = 135;
    this.Label1.Text = "Mem No.";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lblMname);
    this.Controls.Add((Control) this.lblMno);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtremark);
    this.Controls.Add((Control) this.txtCReason);
    this.Controls.Add((Control) this.txtDOC);
    this.Controls.Add((Control) this.txtAge);
    this.Controls.Add((Control) this.TxtOCCUPATION);
    this.Controls.Add((Control) this.txtDTENTPAY);
    this.Controls.Add((Control) this.lblId);
    this.Controls.Add((Control) this.txtDOA);
    this.Controls.Add((Control) this.txtIsrno);
    this.Controls.Add((Control) this.txtMemId);
    this.Controls.Add((Control) this.Label1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmStatIDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmStatIDetail);
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
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

  internal virtual TextBox txtremark
  {
    [DebuggerNonUserCode] get => this._txtremark;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtremark_KeyDown);
      if (this._txtremark != null)
        this._txtremark.KeyDown -= keyEventHandler;
      this._txtremark = value;
      if (this._txtremark == null)
        return;
      this._txtremark.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtCReason
  {
    [DebuggerNonUserCode] get => this._txtCReason;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtCReason_KeyDown);
      if (this._txtCReason != null)
        this._txtCReason.KeyDown -= keyEventHandler;
      this._txtCReason = value;
      if (this._txtCReason == null)
        return;
      this._txtCReason.KeyDown += keyEventHandler;
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

  internal virtual TextBox txtAge
  {
    [DebuggerNonUserCode] get => this._txtAge;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAge_KeyDown);
      if (this._txtAge != null)
        this._txtAge.KeyDown -= keyEventHandler;
      this._txtAge = value;
      if (this._txtAge == null)
        return;
      this._txtAge.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox TxtOCCUPATION
  {
    [DebuggerNonUserCode] get => this._TxtOCCUPATION;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.TxtOCCUPATION_KeyDown);
      if (this._TxtOCCUPATION != null)
        this._TxtOCCUPATION.KeyDown -= keyEventHandler;
      this._TxtOCCUPATION = value;
      if (this._TxtOCCUPATION == null)
        return;
      this._TxtOCCUPATION.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtDTENTPAY
  {
    [DebuggerNonUserCode] get => this._txtDTENTPAY;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDTENTPAY_KeyDown);
      if (this._txtDTENTPAY != null)
        this._txtDTENTPAY.KeyDown -= keyEventHandler;
      this._txtDTENTPAY = value;
      if (this._txtDTENTPAY == null)
        return;
      this._txtDTENTPAY.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label lblId
  {
    [DebuggerNonUserCode] get => this._lblId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblId = value;
  }

  internal virtual TextBox txtDOA
  {
    [DebuggerNonUserCode] get => this._txtDOA;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDOA_KeyDown);
      if (this._txtDOA != null)
        this._txtDOA.KeyDown -= keyEventHandler;
      this._txtDOA = value;
      if (this._txtDOA == null)
        return;
      this._txtDOA.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtIsrno
  {
    [DebuggerNonUserCode] get => this._txtIsrno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtIsrno_KeyDown);
      if (this._txtIsrno != null)
        this._txtIsrno.KeyDown -= keyEventHandler;
      this._txtIsrno = value;
      if (this._txtIsrno == null)
        return;
      this._txtIsrno.KeyDown += keyEventHandler;
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

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtIsrno.Text) & Operators.CompareString(this.txtIsrno.Text, "", false) != 0)
    {
      int num = (int) Interaction.MsgBox((object) "Not a Numeric Input! Try again.");
      this.txtIsrno.Focus();
    }
    else
    {
      this.txtDTENTPAY.Text = this.txtDTENTPAY.Text.ToString().Replace("'", "''");
      this.txtDOA.Text = this.txtDOA.Text.ToString().Replace("'", "''");
      this.TxtOCCUPATION.Text = this.TxtOCCUPATION.Text.ToString().Replace("'", "''");
      this.txtAge.Text = this.txtAge.Text.ToString().Replace("'", "''");
      this.txtDOC.Text = this.txtDOC.Text.ToString().Replace("'", "''");
      this.txtCReason.Text = this.txtCReason.Text.ToString().Replace("'", "''");
      this.txtremark.Text = this.txtremark.Text.ToString().Replace("'", "''");
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
      connection.Open();
      new OleDbCommand($"update IReg set Isrno ='{Conversions.ToString(Conversion.Val(this.txtIsrno.Text.Trim()))}' ,DTENTPAY ='{this.txtDTENTPAY.Text.Trim()}' ,ENTAMT ='{this.txtDOA.Text.Trim()}' ,OCCUPATION ='{this.TxtOCCUPATION.Text.Trim()}' ,Age ='{this.txtAge.Text.Trim()}' ,DOC ='{this.txtDOC.Text.Trim()}' ,CReason ='{this.txtCReason.Text.Trim()}' ,remark ='{this.txtremark.Text.Trim()}'  where Id ={Conversions.ToString(Conversion.Val(this.lblId.Text.Trim()))}", connection).ExecuteNonQuery();
      int num = (int) Interaction.MsgBox((object) "Updated Successful");
      connection.Close();
      this.Close();
    }
  }

  private void txtIsrno_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtDOA.Focus();
  }

  private void txtDOA_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtDTENTPAY.Focus();
  }

  private void txtDTENTPAY_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.TxtOCCUPATION.Focus();
  }

  private void TxtOCCUPATION_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAge.Focus();
  }

  private void txtAge_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtDOC.Focus();
  }

  private void txtDOC_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtCReason.Focus();
  }

  private void txtCReason_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtremark.Focus();
  }

  private void txtremark_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }

  private void txtMemId_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtIsrno.Focus();
  }
}
