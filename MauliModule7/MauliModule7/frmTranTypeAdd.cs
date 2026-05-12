// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmTranTypeAdd
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
public class frmTranTypeAdd : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("cmbMemberTransaction")]
  private ComboBox _cmbMemberTransaction;
  [AccessedThroughProperty("cmbAllTransaction")]
  private ComboBox _cmbAllTransaction;
  [AccessedThroughProperty("cmbCashBankTran")]
  private ComboBox _cmbCashBankTran;
  [AccessedThroughProperty("lblTranTypeSelect")]
  private Label _lblTranTypeSelect;
  [AccessedThroughProperty("lblCallFrom")]
  private Label _lblCallFrom;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;

  [DebuggerNonUserCode]
  static frmTranTypeAdd()
  {
  }

  [DebuggerNonUserCode]
  public frmTranTypeAdd()
  {
    this.KeyDown += new KeyEventHandler(this.frmTranTypeAdd_KeyDown);
    this.Load += new EventHandler(this.frmTranTypeAdd_Load);
    frmTranTypeAdd.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmTranTypeAdd.__ENCList)
    {
      if (frmTranTypeAdd.__ENCList.Count == frmTranTypeAdd.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmTranTypeAdd.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmTranTypeAdd.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmTranTypeAdd.__ENCList[index1] = frmTranTypeAdd.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmTranTypeAdd.__ENCList.RemoveRange(index1, checked (frmTranTypeAdd.__ENCList.Count - index1));
        frmTranTypeAdd.__ENCList.Capacity = frmTranTypeAdd.__ENCList.Count;
      }
      frmTranTypeAdd.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmTranTypeAdd));
    this.btnOk = new Button();
    this.btnExit = new Button();
    this.cmbMemberTransaction = new ComboBox();
    this.cmbAllTransaction = new ComboBox();
    this.cmbCashBankTran = new ComboBox();
    this.lblTranTypeSelect = new Label();
    this.lblCallFrom = new Label();
    this.Label1 = new Label();
    this.grpVisible = new GroupBox();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    this.btnOk.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnOk1 = this.btnOk;
    Point point1 = new Point(44, 199);
    Point point2 = point1;
    btnOk1.Location = point2;
    this.btnOk.Name = "btnOk";
    Button btnOk2 = this.btnOk;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnOk2.Size = size2;
    this.btnOk.TabIndex = 3;
    this.btnOk.Text = "&Ok";
    this.btnOk.UseVisualStyleBackColor = true;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(149, 199);
    Point point3 = point1;
    btnExit1.Location = point3;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnExit2.Size = size3;
    this.btnExit.TabIndex = 4;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.cmbMemberTransaction.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbMemberTransaction.FormattingEnabled = true;
    this.cmbMemberTransaction.Items.AddRange(new object[5]
    {
      (object) "Member Receipt",
      (object) "Member Bill",
      (object) "Member Adjustment",
      (object) "Member Debit Note",
      (object) "Member Credit Note"
    });
    ComboBox memberTransaction1 = this.cmbMemberTransaction;
    point1 = new Point(44, 89);
    Point point4 = point1;
    memberTransaction1.Location = point4;
    this.cmbMemberTransaction.Name = "cmbMemberTransaction";
    ComboBox memberTransaction2 = this.cmbMemberTransaction;
    size1 = new Size(204, 24);
    Size size4 = size1;
    memberTransaction2.Size = size4;
    this.cmbMemberTransaction.TabIndex = 0;
    this.cmbMemberTransaction.Text = "Member Receipt";
    this.cmbAllTransaction.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbAllTransaction.FormattingEnabled = true;
    this.cmbAllTransaction.Items.AddRange(new object[9]
    {
      (object) "Payment",
      (object) "Receipt",
      (object) "Contra",
      (object) "Journal",
      (object) "Member Receipt",
      (object) "Member Bill",
      (object) "Member Adjustment",
      (object) "Member Debit Note",
      (object) "Member Credit Note"
    });
    ComboBox cmbAllTransaction1 = this.cmbAllTransaction;
    point1 = new Point(44, 89);
    Point point5 = point1;
    cmbAllTransaction1.Location = point5;
    this.cmbAllTransaction.Name = "cmbAllTransaction";
    ComboBox cmbAllTransaction2 = this.cmbAllTransaction;
    size1 = new Size(204, 24);
    Size size5 = size1;
    cmbAllTransaction2.Size = size5;
    this.cmbAllTransaction.TabIndex = 1;
    this.cmbAllTransaction.Text = "Payment";
    this.cmbCashBankTran.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashBankTran.FormattingEnabled = true;
    this.cmbCashBankTran.Items.AddRange(new object[5]
    {
      (object) "Payment",
      (object) "Receipt",
      (object) "Contra",
      (object) "Member Receipt",
      (object) "Member Adjustment"
    });
    ComboBox cmbCashBankTran1 = this.cmbCashBankTran;
    point1 = new Point(44, 89);
    Point point6 = point1;
    cmbCashBankTran1.Location = point6;
    this.cmbCashBankTran.Name = "cmbCashBankTran";
    ComboBox cmbCashBankTran2 = this.cmbCashBankTran;
    size1 = new Size(204, 24);
    Size size6 = size1;
    cmbCashBankTran2.Size = size6;
    this.cmbCashBankTran.TabIndex = 2;
    this.cmbCashBankTran.Text = "Payment";
    this.lblTranTypeSelect.AutoSize = true;
    Label lblTranTypeSelect1 = this.lblTranTypeSelect;
    point1 = new Point(6, 16 /*0x10*/);
    Point point7 = point1;
    lblTranTypeSelect1.Location = point7;
    this.lblTranTypeSelect.Name = "lblTranTypeSelect";
    Label lblTranTypeSelect2 = this.lblTranTypeSelect;
    size1 = new Size(33, 13);
    Size size7 = size1;
    lblTranTypeSelect2.Size = size7;
    this.lblTranTypeSelect.TabIndex = 9;
    this.lblTranTypeSelect.Text = "None";
    this.lblCallFrom.AutoSize = true;
    Label lblCallFrom1 = this.lblCallFrom;
    point1 = new Point(11, 29);
    Point point8 = point1;
    lblCallFrom1.Location = point8;
    this.lblCallFrom.Name = "lblCallFrom";
    Label lblCallFrom2 = this.lblCallFrom;
    size1 = new Size(88, 13);
    Size size8 = size1;
    lblCallFrom2.Size = size8;
    this.lblCallFrom.TabIndex = 10;
    this.lblCallFrom.Text = "Member Account";
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(57, 56);
    Point point9 = point1;
    label1_1.Location = point9;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(178, 16 /*0x10*/);
    Size size9 = size1;
    label1_2.Size = size9;
    this.Label1.TabIndex = 11;
    this.Label1.Text = "Select Transaction Type";
    this.grpVisible.Controls.Add((Control) this.lblTranTypeSelect);
    this.grpVisible.Controls.Add((Control) this.lblCallFrom);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(44, 139);
    Point point10 = point1;
    grpVisible1.Location = point10;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(112 /*0x70*/, 54);
    Size size10 = size1;
    grpVisible2.Size = size10;
    this.grpVisible.TabIndex = 12;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(292, 266);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cmbCashBankTran);
    this.Controls.Add((Control) this.cmbAllTransaction);
    this.Controls.Add((Control) this.cmbMemberTransaction);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnExit);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmTranTypeAdd);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Select Transaction Type";
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnOk
  {
    [DebuggerNonUserCode] get => this._btnOk;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOk_Click);
      if (this._btnOk != null)
        this._btnOk.Click -= eventHandler;
      this._btnOk = value;
      if (this._btnOk == null)
        return;
      this._btnOk.Click += eventHandler;
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

  internal virtual ComboBox cmbMemberTransaction
  {
    [DebuggerNonUserCode] get => this._cmbMemberTransaction;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbMemberTransaction_KeyDown);
      if (this._cmbMemberTransaction != null)
        this._cmbMemberTransaction.KeyDown -= keyEventHandler;
      this._cmbMemberTransaction = value;
      if (this._cmbMemberTransaction == null)
        return;
      this._cmbMemberTransaction.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbAllTransaction
  {
    [DebuggerNonUserCode] get => this._cmbAllTransaction;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbAllTransaction_KeyDown);
      if (this._cmbAllTransaction != null)
        this._cmbAllTransaction.KeyDown -= keyEventHandler;
      this._cmbAllTransaction = value;
      if (this._cmbAllTransaction == null)
        return;
      this._cmbAllTransaction.KeyDown += keyEventHandler;
    }
  }

  internal virtual ComboBox cmbCashBankTran
  {
    [DebuggerNonUserCode] get => this._cmbCashBankTran;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbCashBankTran_KeyDown);
      if (this._cmbCashBankTran != null)
        this._cmbCashBankTran.KeyDown -= keyEventHandler;
      this._cmbCashBankTran = value;
      if (this._cmbCashBankTran == null)
        return;
      this._cmbCashBankTran.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label lblTranTypeSelect
  {
    [DebuggerNonUserCode] get => this._lblTranTypeSelect;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTranTypeSelect = value;
    }
  }

  internal virtual Label lblCallFrom
  {
    [DebuggerNonUserCode] get => this._lblCallFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblCallFrom = value;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  private void frmTranTypeAdd_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.lblTranTypeSelect.Text = "None";
    this.Close();
  }

  private void frmTranTypeAdd_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    if (Operators.CompareString(this.lblCallFrom.Text, "Member Account", false) == 0)
    {
      this.cmbAllTransaction.Visible = false;
      this.cmbCashBankTran.Visible = false;
      this.cmbMemberTransaction.Visible = true;
    }
    if (Operators.CompareString(this.lblCallFrom.Text, "Cash Bank Book", false) == 0)
    {
      this.cmbAllTransaction.Visible = false;
      this.cmbCashBankTran.Visible = true;
      this.cmbMemberTransaction.Visible = false;
    }
    if (Operators.CompareString(this.lblCallFrom.Text, "Ledger Account", false) != 0)
      return;
    this.cmbAllTransaction.Visible = true;
    this.cmbCashBankTran.Visible = false;
    this.cmbMemberTransaction.Visible = false;
  }

  private void btnExit_Click(object sender, EventArgs e)
  {
    this.lblTranTypeSelect.Text = "None";
    this.Close();
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    if (Operators.CompareString(this.lblCallFrom.Text, "Member Account", false) == 0)
    {
      if (Operators.CompareString(this.cmbMemberTransaction.Text, "Member Receipt", false) == 0)
        this.lblTranTypeSelect.Text = "MRct";
      if (Operators.CompareString(this.cmbMemberTransaction.Text, "Member Bill", false) == 0)
        this.lblTranTypeSelect.Text = "MBil";
      if (Operators.CompareString(this.cmbMemberTransaction.Text, "Member Adjustment", false) == 0)
        this.lblTranTypeSelect.Text = "MAdj";
      if (Operators.CompareString(this.cmbMemberTransaction.Text, "Member Debit Note", false) == 0)
        this.lblTranTypeSelect.Text = "MDbn";
      if (Operators.CompareString(this.cmbMemberTransaction.Text, "Member Credit Note", false) == 0)
        this.lblTranTypeSelect.Text = "MCrn";
    }
    if (Operators.CompareString(this.lblCallFrom.Text, "Cash Bank Book", false) == 0)
    {
      if (Operators.CompareString(this.cmbCashBankTran.Text, "Payment", false) == 0)
        this.lblTranTypeSelect.Text = "Pymt";
      if (Operators.CompareString(this.cmbCashBankTran.Text, "Receipt", false) == 0)
        this.lblTranTypeSelect.Text = "Rcpt";
      if (Operators.CompareString(this.cmbCashBankTran.Text, "Contra", false) == 0)
        this.lblTranTypeSelect.Text = "Ctra";
      if (Operators.CompareString(this.cmbCashBankTran.Text, "Member Receipt", false) == 0)
        this.lblTranTypeSelect.Text = "MRct";
      if (Operators.CompareString(this.cmbCashBankTran.Text, "Member Adjustment", false) == 0)
        this.lblTranTypeSelect.Text = "MAdj";
    }
    if (Operators.CompareString(this.lblCallFrom.Text, "Ledger Account", false) == 0)
    {
      if (Operators.CompareString(this.cmbAllTransaction.Text, "Payment", false) == 0)
        this.lblTranTypeSelect.Text = "Pymt";
      if (Operators.CompareString(this.cmbAllTransaction.Text, "Receipt", false) == 0)
        this.lblTranTypeSelect.Text = "Rcpt";
      if (Operators.CompareString(this.cmbAllTransaction.Text, "Contra", false) == 0)
        this.lblTranTypeSelect.Text = "Ctra";
      if (Operators.CompareString(this.cmbAllTransaction.Text, "Journal", false) == 0)
        this.lblTranTypeSelect.Text = "Jrnl";
      if (Operators.CompareString(this.cmbAllTransaction.Text, "Member Receipt", false) == 0)
        this.lblTranTypeSelect.Text = "MRct";
      if (Operators.CompareString(this.cmbAllTransaction.Text, "Member Adjustment", false) == 0)
        this.lblTranTypeSelect.Text = "MAdj";
      if (Operators.CompareString(this.cmbAllTransaction.Text, "Member Bill", false) == 0)
        this.lblTranTypeSelect.Text = "MBil";
      if (Operators.CompareString(this.cmbAllTransaction.Text, "Member Debit Note", false) == 0)
        this.lblTranTypeSelect.Text = "MDbn";
      if (Operators.CompareString(this.cmbAllTransaction.Text, "Member Credit Note", false) == 0)
        this.lblTranTypeSelect.Text = "MCrn";
    }
    this.Close();
  }

  private void cmbCashBankTran_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnOk.Focus();
  }

  private void cmbAllTransaction_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnOk.Focus();
  }

  private void cmbMemberTransaction_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnOk.Focus();
  }
}
