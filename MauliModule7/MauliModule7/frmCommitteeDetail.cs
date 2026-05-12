// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmCommitteeDetail
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
public class frmCommitteeDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("txtName")]
  private TextBox _txtName;
  [AccessedThroughProperty("txtFlatNo")]
  private TextBox _txtFlatNo;
  [AccessedThroughProperty("txtDesign")]
  private TextBox _txtDesign;
  [AccessedThroughProperty("txtContactNo")]
  private TextBox _txtContactNo;
  [AccessedThroughProperty("txtEmailId")]
  private TextBox _txtEmailId;
  [AccessedThroughProperty("txtPeriod")]
  private TextBox _txtPeriod;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("txtRemark")]
  private TextBox _txtRemark;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("txtAddress")]
  private TextBox _txtAddress;

  [DebuggerNonUserCode]
  static frmCommitteeDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmCommitteeDetail()
  {
    this.Load += new EventHandler(this.frmCommitteeDetail_Load);
    this.KeyDown += new KeyEventHandler(this.frmCommitteeDetail_KeyDown);
    frmCommitteeDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmCommitteeDetail.__ENCList)
    {
      if (frmCommitteeDetail.__ENCList.Count == frmCommitteeDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmCommitteeDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmCommitteeDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmCommitteeDetail.__ENCList[index1] = frmCommitteeDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmCommitteeDetail.__ENCList.RemoveRange(index1, checked (frmCommitteeDetail.__ENCList.Count - index1));
        frmCommitteeDetail.__ENCList.Capacity = frmCommitteeDetail.__ENCList.Count;
      }
      frmCommitteeDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmCommitteeDetail));
    this.btnSave = new Button();
    this.btnExit = new Button();
    this.txtNo = new TextBox();
    this.txtName = new TextBox();
    this.txtFlatNo = new TextBox();
    this.txtDesign = new TextBox();
    this.txtContactNo = new TextBox();
    this.txtEmailId = new TextBox();
    this.txtPeriod = new TextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.grpVisible = new GroupBox();
    this.Label7 = new Label();
    this.txtRemark = new TextBox();
    this.Label8 = new Label();
    this.txtAddress = new TextBox();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    Point point1 = new Point(182, 492);
    Point point2 = point1;
    btnSave1.Location = point2;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnSave2.Size = size2;
    this.btnSave.TabIndex = 8;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(295, 492);
    Point point3 = point1;
    btnExit1.Location = point3;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnExit2.Size = size3;
    this.btnExit.TabIndex = 9;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.txtNo.Enabled = false;
    this.txtNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(65, 17);
    Point point4 = point1;
    txtNo1.Location = point4;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(26, 22);
    Size size4 = size1;
    txtNo2.Size = size4;
    this.txtNo.TabIndex = 21;
    this.txtNo.TabStop = false;
    this.txtName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtName1 = this.txtName;
    point1 = new Point(172, 121);
    Point point5 = point1;
    txtName1.Location = point5;
    this.txtName.Name = "txtName";
    TextBox txtName2 = this.txtName;
    size1 = new Size(307, 22);
    Size size5 = size1;
    txtName2.Size = size5;
    this.txtName.TabIndex = 0;
    this.txtFlatNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtFlatNo1 = this.txtFlatNo;
    point1 = new Point(172, 166);
    Point point6 = point1;
    txtFlatNo1.Location = point6;
    this.txtFlatNo.Name = "txtFlatNo";
    TextBox txtFlatNo2 = this.txtFlatNo;
    size1 = new Size(307, 22);
    Size size6 = size1;
    txtFlatNo2.Size = size6;
    this.txtFlatNo.TabIndex = 1;
    this.txtDesign.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtDesign1 = this.txtDesign;
    point1 = new Point(172, 210);
    Point point7 = point1;
    txtDesign1.Location = point7;
    this.txtDesign.Name = "txtDesign";
    TextBox txtDesign2 = this.txtDesign;
    size1 = new Size(307, 22);
    Size size7 = size1;
    txtDesign2.Size = size7;
    this.txtDesign.TabIndex = 2;
    this.txtContactNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtContactNo1 = this.txtContactNo;
    point1 = new Point(172, 254);
    Point point8 = point1;
    txtContactNo1.Location = point8;
    this.txtContactNo.Name = "txtContactNo";
    TextBox txtContactNo2 = this.txtContactNo;
    size1 = new Size(307, 22);
    Size size8 = size1;
    txtContactNo2.Size = size8;
    this.txtContactNo.TabIndex = 3;
    this.txtEmailId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtEmailId1 = this.txtEmailId;
    point1 = new Point(172, 300);
    Point point9 = point1;
    txtEmailId1.Location = point9;
    this.txtEmailId.Name = "txtEmailId";
    TextBox txtEmailId2 = this.txtEmailId;
    size1 = new Size(307, 22);
    Size size9 = size1;
    txtEmailId2.Size = size9;
    this.txtEmailId.TabIndex = 4;
    this.txtPeriod.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPeriod1 = this.txtPeriod;
    point1 = new Point(172, 348);
    Point point10 = point1;
    txtPeriod1.Location = point10;
    this.txtPeriod.Name = "txtPeriod";
    TextBox txtPeriod2 = this.txtPeriod;
    size1 = new Size(307, 22);
    Size size10 = size1;
    txtPeriod2.Size = size10;
    this.txtPeriod.TabIndex = 5;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(68, 124);
    Point point11 = point1;
    label1_1.Location = point11;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(98, 16 /*0x10*/);
    Size size11 = size1;
    label1_2.Size = size11;
    this.Label1.TabIndex = 96 /*0x60*/;
    this.Label1.Text = "Member Name";
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(68, 213);
    Point point12 = point1;
    label2_1.Location = point12;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(80 /*0x50*/, 16 /*0x10*/);
    Size size12 = size1;
    label2_2.Size = size12;
    this.Label2.TabIndex = 97;
    this.Label2.Text = "Designation";
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(68, 257);
    Point point13 = point1;
    label3_1.Location = point13;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(77, 16 /*0x10*/);
    Size size13 = size1;
    label3_2.Size = size13;
    this.Label3.TabIndex = 98;
    this.Label3.Text = "Contact No.";
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(68, 304);
    Point point14 = point1;
    label4_1.Location = point14;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(60, 16 /*0x10*/);
    Size size14 = size1;
    label4_2.Size = size14;
    this.Label4.TabIndex = 99;
    this.Label4.Text = "Email_Id";
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(68, 169);
    Point point15 = point1;
    label5_1.Location = point15;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(54, 16 /*0x10*/);
    Size size15 = size1;
    label5_2.Size = size15;
    this.Label5.TabIndex = 100;
    this.Label5.Text = "Flat No.";
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label6_1 = this.Label6;
    point1 = new Point(68, 351);
    Point point16 = point1;
    label6_1.Location = point16;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(101, 16 /*0x10*/);
    Size size16 = size1;
    label6_2.Size = size16;
    this.Label6.TabIndex = 101;
    this.Label6.Text = "Working Period";
    this.grpVisible.Controls.Add((Control) this.txtNo);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(418, 35);
    Point point17 = point1;
    grpVisible1.Location = point17;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(107, 45);
    Size size17 = size1;
    grpVisible2.Size = size17;
    this.grpVisible.TabIndex = 102;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label7_1 = this.Label7;
    point1 = new Point(68, 440);
    Point point18 = point1;
    label7_1.Location = point18;
    this.Label7.Name = "Label7";
    Label label7_2 = this.Label7;
    size1 = new Size(56, 16 /*0x10*/);
    Size size18 = size1;
    label7_2.Size = size18;
    this.Label7.TabIndex = 104;
    this.Label7.Text = "Remark";
    this.txtRemark.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtRemark1 = this.txtRemark;
    point1 = new Point(172, 437);
    Point point19 = point1;
    txtRemark1.Location = point19;
    this.txtRemark.Name = "txtRemark";
    TextBox txtRemark2 = this.txtRemark;
    size1 = new Size(307, 22);
    Size size19 = size1;
    txtRemark2.Size = size19;
    this.txtRemark.TabIndex = 7;
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label8_1 = this.Label8;
    point1 = new Point(68, 397);
    Point point20 = point1;
    label8_1.Location = point20;
    this.Label8.Name = "Label8";
    Label label8_2 = this.Label8;
    size1 = new Size(59, 16 /*0x10*/);
    Size size20 = size1;
    label8_2.Size = size20;
    this.Label8.TabIndex = 106;
    this.Label8.Text = "Address";
    this.txtAddress.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAddress1 = this.txtAddress;
    point1 = new Point(172, 394);
    Point point21 = point1;
    txtAddress1.Location = point21;
    this.txtAddress.Name = "txtAddress";
    TextBox txtAddress2 = this.txtAddress;
    size1 = new Size(307, 22);
    Size size21 = size1;
    txtAddress2.Size = size21;
    this.txtAddress.TabIndex = 6;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.txtAddress);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.txtRemark);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtPeriod);
    this.Controls.Add((Control) this.txtEmailId);
    this.Controls.Add((Control) this.txtContactNo);
    this.Controls.Add((Control) this.txtDesign);
    this.Controls.Add((Control) this.txtFlatNo);
    this.Controls.Add((Control) this.txtName);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.btnExit);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCommitteeDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Committee Member Add";
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
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

  internal virtual TextBox txtNo
  {
    [DebuggerNonUserCode] get => this._txtNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNo = value;
  }

  internal virtual TextBox txtName
  {
    [DebuggerNonUserCode] get => this._txtName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtName_KeyDown);
      if (this._txtName != null)
        this._txtName.KeyDown -= keyEventHandler;
      this._txtName = value;
      if (this._txtName == null)
        return;
      this._txtName.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtFlatNo
  {
    [DebuggerNonUserCode] get => this._txtFlatNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtFlatNo_KeyDown);
      if (this._txtFlatNo != null)
        this._txtFlatNo.KeyDown -= keyEventHandler;
      this._txtFlatNo = value;
      if (this._txtFlatNo == null)
        return;
      this._txtFlatNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtDesign
  {
    [DebuggerNonUserCode] get => this._txtDesign;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtDesign_KeyDown);
      if (this._txtDesign != null)
        this._txtDesign.KeyDown -= keyEventHandler;
      this._txtDesign = value;
      if (this._txtDesign == null)
        return;
      this._txtDesign.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtContactNo
  {
    [DebuggerNonUserCode] get => this._txtContactNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtContactNo_KeyDown);
      if (this._txtContactNo != null)
        this._txtContactNo.KeyDown -= keyEventHandler;
      this._txtContactNo = value;
      if (this._txtContactNo == null)
        return;
      this._txtContactNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtEmailId
  {
    [DebuggerNonUserCode] get => this._txtEmailId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtEmailId_KeyDown);
      if (this._txtEmailId != null)
        this._txtEmailId.KeyDown -= keyEventHandler;
      this._txtEmailId = value;
      if (this._txtEmailId == null)
        return;
      this._txtEmailId.KeyDown += keyEventHandler;
    }
  }

  internal virtual TextBox txtPeriod
  {
    [DebuggerNonUserCode] get => this._txtPeriod;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtPeriod_KeyDown);
      if (this._txtPeriod != null)
        this._txtPeriod.KeyDown -= keyEventHandler;
      this._txtPeriod = value;
      if (this._txtPeriod == null)
        return;
      this._txtPeriod.KeyDown += keyEventHandler;
    }
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
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

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual TextBox txtAddress
  {
    [DebuggerNonUserCode] get => this._txtAddress;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtAddress_KeyDown);
      if (this._txtAddress != null)
        this._txtAddress.KeyDown -= keyEventHandler;
      this._txtAddress = value;
      if (this._txtAddress == null)
        return;
      this._txtAddress.KeyDown += keyEventHandler;
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      int num1 = (int) MyProject.Forms.DeleteDialog.ShowDialog();
    }
    if (Conversions.ToDouble(MyProject.Forms.DeleteDialog.lblResult.Text) == 1.0)
    {
      if (Operators.CompareString(this.txtName.Text.ToString(), "", false) == 0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Cannot not Blank");
        this.txtName.Focus();
        return;
      }
      if (Operators.CompareString(this.txtDesign.Text.ToString(), "", false) == 0)
      {
        int num3 = (int) Interaction.MsgBox((object) "Cannot not Blank");
        this.txtDesign.Focus();
        return;
      }
      if (Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand = new OleDbCommand($"Delete From SocComm where Id ={Conversions.ToString(Conversion.Val(this.txtNo.Text))}", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
      if (Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        this.txtName.Text = this.txtName.Text.ToString().Replace("'", "''");
        this.txtDesign.Text = this.txtDesign.Text.ToString().Replace("'", "''");
        this.txtFlatNo.Text = this.txtFlatNo.Text.ToString().Replace("'", "''");
        this.txtContactNo.Text = this.txtContactNo.Text.ToString().Replace("'", "''");
        this.txtEmailId.Text = this.txtEmailId.Text.ToString().Replace("'", "''");
        this.txtPeriod.Text = this.txtPeriod.Text.ToString().Replace("'", "''");
        this.txtAddress.Text = this.txtAddress.Text.ToString().Replace("'", "''");
        this.txtRemark.Text = this.txtRemark.Text.ToString().Replace("'", "''");
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand = new OleDbCommand($"Insert Into SocComm (C_MemberName, C_MemberDesignation, C_FlatNo, C_ContactNo, C_EmailId, C_Period, C_Address, C_Remark) values ('{this.txtName.Text}','{this.txtDesign.Text}','{this.txtFlatNo.Text}','{this.txtContactNo.Text}','{this.txtEmailId.Text}','{this.txtPeriod.Text}','{this.txtAddress.Text}','{this.txtRemark.Text}')", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
      if (Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        this.txtName.Text = this.txtName.Text.ToString().Replace("'", "''");
        this.txtDesign.Text = this.txtDesign.Text.ToString().Replace("'", "''");
        this.txtFlatNo.Text = this.txtFlatNo.Text.ToString().Replace("'", "''");
        this.txtContactNo.Text = this.txtContactNo.Text.ToString().Replace("'", "''");
        this.txtEmailId.Text = this.txtEmailId.Text.ToString().Replace("'", "''");
        this.txtPeriod.Text = this.txtPeriod.Text.ToString().Replace("'", "''");
        this.txtAddress.Text = this.txtAddress.Text.ToString().Replace("'", "''");
        this.txtRemark.Text = this.txtRemark.Text.ToString().Replace("'", "''");
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        OleDbCommand oleDbCommand = new OleDbCommand($"update SocComm set C_MemberName = '{this.txtName.Text}', C_MemberDesignation = '{this.txtDesign.Text}', C_FlatNo = '{this.txtFlatNo.Text}', C_ContactNo = '{this.txtContactNo.Text}', C_EmailId = '{this.txtEmailId.Text}', C_Period = '{this.txtPeriod.Text}', C_Address ='{this.txtAddress.Text}', C_Remark ='{this.txtRemark.Text}' where ID ={Conversions.ToString(Conversion.Val(this.txtNo.Text.Trim()))}", connection);
        connection.Open();
        oleDbCommand.ExecuteNonQuery();
        connection.Close();
      }
    }
    this.Close();
  }

  private void frmCommitteeDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmCommitteeDetail_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    if (Operators.CompareString(this.btnSave.Text, "&Update", false) == 0 | Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      this.txtNo.Text = Conversions.ToString(MyProject.Forms.frmCommittee.DataGridView2.CurrentRow.Cells[0].Value);
      this.txtName.Text = Conversions.ToString(MyProject.Forms.frmCommittee.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtDesign.Text = Conversions.ToString(MyProject.Forms.frmCommittee.DataGridView2.CurrentRow.Cells[2].Value);
      this.txtFlatNo.Text = Conversions.ToString(MyProject.Forms.frmCommittee.DataGridView2.CurrentRow.Cells[3].Value);
      this.txtContactNo.Text = Conversions.ToString(MyProject.Forms.frmCommittee.DataGridView2.CurrentRow.Cells[4].Value);
      this.txtEmailId.Text = Conversions.ToString(MyProject.Forms.frmCommittee.DataGridView2.CurrentRow.Cells[5].Value);
      this.txtPeriod.Text = Conversions.ToString(MyProject.Forms.frmCommittee.DataGridView2.CurrentRow.Cells[6].Value);
      this.txtAddress.Text = Conversions.ToString(MyProject.Forms.frmCommittee.DataGridView2.CurrentRow.Cells[7].Value);
      this.txtRemark.Text = Conversions.ToString(MyProject.Forms.frmCommittee.DataGridView2.CurrentRow.Cells[8].Value);
    }
    if (Operators.CompareString(this.btnSave.Text, "&Delete", false) != 0)
      return;
    this.txtName.Enabled = false;
    this.txtDesign.Enabled = false;
    this.txtFlatNo.Enabled = false;
    this.txtContactNo.Enabled = false;
    this.txtEmailId.Enabled = false;
    this.txtPeriod.Enabled = false;
    this.txtAddress.Enabled = false;
    this.txtRemark.Enabled = false;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void txtName_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtFlatNo.Focus();
  }

  private void txtFlatNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtDesign.Focus();
  }

  private void txtDesign_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtContactNo.Focus();
  }

  private void txtContactNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtEmailId.Focus();
  }

  private void txtEmailId_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtPeriod.Focus();
  }

  private void txtPeriod_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtAddress.Focus();
  }

  private void txtRemark_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }

  private void txtAddress_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtRemark.Focus();
  }
}
