// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmAlterNo
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

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
public class frmAlterNo : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("lblBtnStatus")]
  private Label _lblBtnStatus;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("lblAlterTranType")]
  private Label _lblAlterTranType;
  [AccessedThroughProperty("cmbSubTranType")]
  private ComboBox _cmbSubTranType;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;

  [DebuggerNonUserCode]
  static frmAlterNo()
  {
  }

  [DebuggerNonUserCode]
  public frmAlterNo()
  {
    this.KeyDown += new KeyEventHandler(this.frmAlterNo_KeyDown);
    this.Load += new EventHandler(this.frmAlterNo_Load);
    frmAlterNo.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmAlterNo.__ENCList)
    {
      if (frmAlterNo.__ENCList.Count == frmAlterNo.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmAlterNo.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmAlterNo.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmAlterNo.__ENCList[index1] = frmAlterNo.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmAlterNo.__ENCList.RemoveRange(index1, checked (frmAlterNo.__ENCList.Count - index1));
        frmAlterNo.__ENCList.Capacity = frmAlterNo.__ENCList.Count;
      }
      frmAlterNo.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAlterNo));
    this.Label1 = new Label();
    this.txtNo = new TextBox();
    this.btnExit = new Button();
    this.btnOk = new Button();
    this.lblBtnStatus = new Label();
    this.grpVisible = new GroupBox();
    this.DataGridView5 = new DataGridView();
    this.lblAlterTranType = new Label();
    this.cmbSubTranType = new ComboBox();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    Point point1 = new Point(90, 8);
    Point point2 = point1;
    label1_1.Location = point2;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    Size size1 = new Size(63 /*0x3F*/, 16 /*0x10*/);
    Size size2 = size1;
    label1_2.Size = size2;
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Enter No.";
    this.txtNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(66, 57);
    Point point3 = point1;
    txtNo1.Location = point3;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(111, 22);
    Size size3 = size1;
    txtNo2.Size = size3;
    this.txtNo.TabIndex = 1;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(124, 105);
    Point point4 = point1;
    btnExit1.Location = point4;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnExit2.Size = size4;
    this.btnExit.TabIndex = 3;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnOk.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnOk1 = this.btnOk;
    point1 = new Point(19, 105);
    Point point5 = point1;
    btnOk1.Location = point5;
    this.btnOk.Name = "btnOk";
    Button btnOk2 = this.btnOk;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnOk2.Size = size5;
    this.btnOk.TabIndex = 2;
    this.btnOk.Text = "&Ok";
    this.btnOk.UseVisualStyleBackColor = true;
    this.lblBtnStatus.AutoSize = true;
    Label lblBtnStatus1 = this.lblBtnStatus;
    point1 = new Point(0, 16 /*0x10*/);
    Point point6 = point1;
    lblBtnStatus1.Location = point6;
    this.lblBtnStatus.Name = "lblBtnStatus";
    Label lblBtnStatus2 = this.lblBtnStatus;
    size1 = new Size(39, 13);
    Size size6 = size1;
    lblBtnStatus2.Size = size6;
    this.lblBtnStatus.TabIndex = 14;
    this.lblBtnStatus.Text = "Label2";
    this.grpVisible.Controls.Add((Control) this.DataGridView5);
    this.grpVisible.Controls.Add((Control) this.lblAlterTranType);
    this.grpVisible.Controls.Add((Control) this.lblBtnStatus);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(2, 8);
    Point point7 = point1;
    grpVisible1.Location = point7;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(57, 71);
    Size size7 = size1;
    grpVisible2.Size = size7;
    this.grpVisible.TabIndex = 15;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(25, 32 /*0x20*/);
    Point point8 = point1;
    dataGridView5_1.Location = point8;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(14, 14);
    Size size8 = size1;
    dataGridView5_2.Size = size8;
    this.DataGridView5.TabIndex = 104;
    this.DataGridView5.TabStop = false;
    this.lblAlterTranType.AutoSize = true;
    Label lblAlterTranType1 = this.lblAlterTranType;
    point1 = new Point(6, 49);
    Point point9 = point1;
    lblAlterTranType1.Location = point9;
    this.lblAlterTranType.Name = "lblAlterTranType";
    Label lblAlterTranType2 = this.lblAlterTranType;
    size1 = new Size(41, 13);
    Size size9 = size1;
    lblAlterTranType2.Size = size9;
    this.lblAlterTranType.TabIndex = 15;
    this.lblAlterTranType.Text = "Default";
    this.cmbSubTranType.FormattingEnabled = true;
    ComboBox cmbSubTranType1 = this.cmbSubTranType;
    point1 = new Point(83, 30);
    Point point10 = point1;
    cmbSubTranType1.Location = point10;
    this.cmbSubTranType.Name = "cmbSubTranType";
    ComboBox cmbSubTranType2 = this.cmbSubTranType;
    size1 = new Size(75, 21);
    Size size10 = size1;
    cmbSubTranType2.Size = size10;
    this.cmbSubTranType.TabIndex = 0;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(242, 166);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.cmbSubTranType);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.txtNo);
    this.Controls.Add((Control) this.Label1);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAlterNo);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Select Document No.";
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox txtNo
  {
    [DebuggerNonUserCode] get => this._txtNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNo_KeyDown);
      if (this._txtNo != null)
        this._txtNo.KeyDown -= keyEventHandler;
      this._txtNo = value;
      if (this._txtNo == null)
        return;
      this._txtNo.KeyDown += keyEventHandler;
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

  internal virtual Label lblBtnStatus
  {
    [DebuggerNonUserCode] get => this._lblBtnStatus;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblBtnStatus = value;
    }
  }

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
    }
  }

  internal virtual Label lblAlterTranType
  {
    [DebuggerNonUserCode] get => this._lblAlterTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAlterTranType = value;
    }
  }

  internal virtual ComboBox cmbSubTranType
  {
    [DebuggerNonUserCode] get => this._cmbSubTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbSubTranType = value;
    }
  }

  internal virtual DataGridView DataGridView5
  {
    [DebuggerNonUserCode] get => this._DataGridView5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView5 = value;
    }
  }

  private void btnOk_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtNo.Text) | Conversion.Val(this.txtNo.Text) == 0.0)
    {
      int num = (int) Interaction.MsgBox((object) "No. is Not a Numeric Input! Try again.");
      this.txtNo.Focus();
    }
    else
    {
      this.lblBtnStatus.Text = "Y";
      this.Close();
    }
  }

  private void frmAlterNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmAlterNo_Load(object sender, EventArgs e)
  {
    this.lblBtnStatus.Text = "N";
    this.txtNo.Text = "0";
    this.grpVisible.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAlterTranType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAlterTranType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAlterTranType.Text, "Ctra", false) == 0)
    {
      this.cmbSubTranType.Visible = true;
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocTranType WHERE (SocTranType.Main_Abr= '{this.lblAlterTranType.Text}' ) order by Sub_Abr asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
      DataTable dataTable = new DataTable("SocTranType");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView5.DataSource = (object) dataTable;
      this.DataGridView5.ReadOnly = true;
      this.DataGridView5.RowHeadersVisible = false;
      this.DataGridView5.AllowUserToAddRows = false;
      this.DataGridView5.Rows[0].Selected = true;
      this.cmbSubTranType.DataSource = (object) dataTable;
      this.cmbSubTranType.DisplayMember = "Sub_Abr";
      this.cmbSubTranType.ValueMember = "ID";
      if (this.DataGridView5.RowCount == 1)
        this.cmbSubTranType.Enabled = false;
      else
        this.cmbSubTranType.Enabled = true;
      this.cmbSubTranType.Focus();
    }
    else
    {
      this.cmbSubTranType.Visible = false;
      this.txtNo.Focus();
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void txtNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnOk.Focus();
  }
}
