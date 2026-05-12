// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmRenumber
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
public class frmRenumber : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("cmbType")]
  private ComboBox _cmbType;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("cmbSubTranType")]
  private ComboBox _cmbSubTranType;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;

  [DebuggerNonUserCode]
  static frmRenumber()
  {
  }

  [DebuggerNonUserCode]
  public frmRenumber()
  {
    this.KeyDown += new KeyEventHandler(this.frmRenumber_KeyDown);
    this.Load += new EventHandler(this.frmRenumber_Load);
    frmRenumber.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmRenumber.__ENCList)
    {
      if (frmRenumber.__ENCList.Count == frmRenumber.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmRenumber.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmRenumber.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmRenumber.__ENCList[index1] = frmRenumber.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmRenumber.__ENCList.RemoveRange(index1, checked (frmRenumber.__ENCList.Count - index1));
        frmRenumber.__ENCList.Capacity = frmRenumber.__ENCList.Count;
      }
      frmRenumber.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmRenumber));
    this.txtNo = new TextBox();
    this.Label1 = new Label();
    this.DataGridView1 = new DataGridView();
    this.cmbType = new ComboBox();
    this.Label2 = new Label();
    this.btnExit = new Button();
    this.btnUpdate = new Button();
    this.DataGridView2 = new DataGridView();
    this.lblType = new Label();
    this.DataGridView3 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.DataGridView4 = new DataGridView();
    this.Label4 = new Label();
    this.pb1 = new ProgressBar();
    this.Button2 = new Button();
    this.Label3 = new Label();
    this.cmbSubTranType = new ComboBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.SuspendLayout();
    TextBox txtNo1 = this.txtNo;
    Point point1 = new Point(184, 159);
    Point point2 = point1;
    txtNo1.Location = point2;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    Size size1 = new Size(121, 20);
    Size size2 = size1;
    txtNo2.Size = size2;
    this.txtNo.TabIndex = 1;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(38, 164);
    Point point3 = point1;
    label1_1.Location = point3;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(77, 16 /*0x10*/);
    Size size3 = size1;
    label1_2.Size = size3;
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Starting No.";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(47, 16 /*0x10*/);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 2;
    this.cmbType.FormattingEnabled = true;
    this.cmbType.Items.AddRange(new object[4]
    {
      (object) "Payment",
      (object) "Receipt",
      (object) "Contra",
      (object) "Journal"
    });
    ComboBox cmbType1 = this.cmbType;
    point1 = new Point(184, 68);
    Point point5 = point1;
    cmbType1.Location = point5;
    this.cmbType.Name = "cmbType";
    ComboBox cmbType2 = this.cmbType;
    size1 = new Size(121, 21);
    Size size5 = size1;
    cmbType2.Size = size5;
    this.cmbType.TabIndex = 0;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(38, 73);
    Point point6 = point1;
    label2_1.Location = point6;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(114, 16 /*0x10*/);
    Size size6 = size1;
    label2_2.Size = size6;
    this.Label2.TabIndex = 4;
    this.Label2.Text = "Transaction Type";
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(167, 260);
    Point point7 = point1;
    btnExit1.Location = point7;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnExit2.Size = size7;
    this.btnExit.TabIndex = 3;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(51, 260);
    Point point8 = point1;
    btnUpdate1.Location = point8;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnUpdate2.Size = size8;
    this.btnUpdate.TabIndex = 2;
    this.btnUpdate.Text = "&Renumber";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(63 /*0x3F*/, 16 /*0x10*/);
    Point point9 = point1;
    dataGridView2_1.Location = point9;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size9 = size1;
    dataGridView2_2.Size = size9;
    this.DataGridView2.TabIndex = 3;
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(11, 16 /*0x10*/);
    Point point10 = point1;
    lblType1.Location = point10;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(30, 13);
    Size size10 = size1;
    lblType2.Size = size10;
    this.lblType.TabIndex = 21;
    this.lblType.Text = "Pymt";
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(79, 16 /*0x10*/);
    Point point11 = point1;
    dataGridView3_1.Location = point11;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 10);
    Size size11 = size1;
    dataGridView3_2.Size = size11;
    this.DataGridView3.TabIndex = 22;
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    this.grpVisible.Controls.Add((Control) this.lblType);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(26, 206);
    Point point12 = point1;
    grpVisible1.Location = point12;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(113, 37);
    Size size12 = size1;
    grpVisible2.Size = size12;
    this.grpVisible.TabIndex = 23;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(95, 16 /*0x10*/);
    Point point13 = point1;
    dataGridView4_1.Location = point13;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 10);
    Size size13 = size1;
    dataGridView4_2.Size = size13;
    this.DataGridView4.TabIndex = 23;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Blue;
    Label label4_1 = this.Label4;
    point1 = new Point(63 /*0x3F*/, 36);
    Point point14 = point1;
    label4_1.Location = point14;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(191, 20);
    Size size14 = size1;
    label4_2.Size = size14;
    this.Label4.TabIndex = 74;
    this.Label4.Text = "Transaction Renumber";
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(-1, 343);
    Point point15 = point1;
    pb1_1.Location = point15;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(319, 23);
    Size size15 = size1;
    pb1_2.Size = size15;
    this.pb1.TabIndex = 75;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(228, 260);
    Point point16 = point1;
    button2_1.Location = point16;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size16 = size1;
    button2_2.Size = size16;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(38, 114);
    Point point17 = point1;
    label3_1.Location = point17;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(141, 16 /*0x10*/);
    Size size17 = size1;
    label3_2.Size = size17;
    this.Label3.TabIndex = 85;
    this.Label3.Text = "Sub Transaction Type";
    this.cmbSubTranType.FormattingEnabled = true;
    this.cmbSubTranType.Items.AddRange(new object[4]
    {
      (object) "Payment",
      (object) "Receipt",
      (object) "Contra",
      (object) "Journal"
    });
    ComboBox cmbSubTranType1 = this.cmbSubTranType;
    point1 = new Point(184, 111);
    Point point18 = point1;
    cmbSubTranType1.Location = point18;
    this.cmbSubTranType.Name = "cmbSubTranType";
    ComboBox cmbSubTranType2 = this.cmbSubTranType;
    size1 = new Size(121, 21);
    Size size18 = size1;
    cmbSubTranType2.Size = size18;
    this.cmbSubTranType.TabIndex = 84;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.cmbSubTranType);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cmbType);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtNo);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmRenumber);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TextBox txtNo
  {
    [DebuggerNonUserCode] get => this._txtNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtNo_TextChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtNo_LostFocus);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtNo_KeyDown);
      if (this._txtNo != null)
      {
        this._txtNo.TextChanged -= eventHandler1;
        this._txtNo.LostFocus -= eventHandler2;
        this._txtNo.KeyDown -= keyEventHandler;
      }
      this._txtNo = value;
      if (this._txtNo == null)
        return;
      this._txtNo.TextChanged += eventHandler1;
      this._txtNo.LostFocus += eventHandler2;
      this._txtNo.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual ComboBox cmbType
  {
    [DebuggerNonUserCode] get => this._cmbType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbType_SelectedIndexChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbType_KeyDown);
      if (this._cmbType != null)
      {
        this._cmbType.SelectedIndexChanged -= eventHandler;
        this._cmbType.KeyDown -= keyEventHandler;
      }
      this._cmbType = value;
      if (this._cmbType == null)
        return;
      this._cmbType.SelectedIndexChanged += eventHandler;
      this._cmbType.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
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

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
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

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual ComboBox cmbSubTranType
  {
    [DebuggerNonUserCode] get => this._cmbSubTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbSubTranType = value;
    }
  }

  internal virtual DataGridView DataGridView4
  {
    [DebuggerNonUserCode] get => this._DataGridView4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView4 = value;
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void frmRenumber_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmRenumber_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.txtNo.Text = Conversions.ToString(1);
    this.cmbSubTranType.Enabled = false;
    this.pb1.Visible = false;
  }

  private void cmbType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtNo.Focus();
  }

  private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.cmbType.SelectedIndex == 0)
    {
      this.lblType.Text = "Pymt";
      this.GetFillSubTranType();
    }
    if (this.cmbType.SelectedIndex == 1)
    {
      this.lblType.Text = "Rcpt";
      this.GetFillSubTranType();
    }
    if (this.cmbType.SelectedIndex == 2)
    {
      this.lblType.Text = "Ctra";
      this.GetFillSubTranType();
    }
    if (this.cmbType.SelectedIndex != 3)
      return;
    this.lblType.Text = "Jrnl";
    this.cmbSubTranType.DataSource = (object) null;
    this.cmbSubTranType.Text = "";
    this.cmbSubTranType.Enabled = false;
  }

  private void txtNo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnUpdate.Focus();
  }

  private void txtNo_LostFocus(object sender, EventArgs e)
  {
    if (!(!Versioned.IsNumeric((object) this.txtNo.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNo.Text, "", false) != 0))
      return;
    this.txtNo.Focus();
  }

  private void txtNo_TextChanged(object sender, EventArgs e)
  {
    if (!(!Versioned.IsNumeric((object) this.txtNo.Text) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtNo.Text, "", false) != 0))
      return;
    int num = (int) Interaction.MsgBox((object) Constant.SMsgNumValid);
    this.txtNo.Focus();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    int num1 = (int) MyProject.Forms.frmRenumberConfirmDialog.ShowDialog();
    if (Conversions.ToDouble(MyProject.Forms.frmRenumberConfirmDialog.lblResult.Text) == 1.0)
    {
      this.pb1.Visible = true;
      this.pb1.Value = 0;
      if (!Versioned.IsNumeric((object) this.txtNo.Text) | Conversion.Val(this.txtNo.Text) == 0.0)
      {
        int num2 = (int) Interaction.MsgBox((object) Constant.SMsgNumValid);
        this.txtNo.Focus();
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbType.Text.Trim(), "", false) == 0)
      {
        int num3 = (int) Interaction.MsgBox((object) Constant.SMsgBlankValid, Title: (object) Constant.SIMsgWarn);
        this.cmbType.Focus();
      }
      else
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0)
          this.GetFillGrid();
        else
          this.GetFillGridSubType();
        int num4 = checked (this.DataGridView1.RowCount - 1);
        int index1 = 0;
        while (index1 <= num4)
        {
          int num5 = checked (this.DataGridView2.RowCount - 1);
          int index2 = 0;
          while (index2 <= num5)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[index2].Cells[8].Value, this.DataGridView1.Rows[index1].Cells[7].Value, false))
              this.DataGridView2.Rows[index2].Cells[0].Value = (object) (Conversion.Val(this.txtNo.Text) + (double) index1);
            checked { ++index2; }
          }
          this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index1 / (double) checked (this.DataGridView1.RowCount + 1) * 100.0)));
          checked { ++index1; }
        }
        this.pb1.Value = 0;
        int num6 = checked (this.DataGridView2.RowCount - 1);
        int index3 = 0;
        while (index3 <= num6)
        {
          string cmdText;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "Jrnl", false) == 0)
            cmdText = $"update SocTran set SocTranNo = {Conversions.ToString(Conversion.Val(this.DataGridView2.Rows[index3].Cells[0].Value.ToString().Trim()))} where SocTranId ={Conversions.ToString(Conversion.Val(this.DataGridView2.Rows[index3].Cells[1].Value.ToString().Trim()))}";
          else
            cmdText = $"update SocTran set SocTranNo = {Conversions.ToString(Conversion.Val(this.DataGridView2.Rows[index3].Cells[0].Value.ToString().Trim()))}, SubTranNo = {Conversions.ToString(Conversion.Val(this.DataGridView2.Rows[index3].Cells[0].Value.ToString().Trim()))} where SocTranId ={Conversions.ToString(Conversion.Val(this.DataGridView2.Rows[index3].Cells[1].Value.ToString().Trim()))}";
          OleDbCommand oleDbCommand = new OleDbCommand(cmdText, connection);
          connection.Open();
          oleDbCommand.ExecuteNonQuery();
          connection.Close();
          this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index3 / (double) checked (this.DataGridView2.RowCount + 1) * 100.0)));
          checked { ++index3; }
        }
        int num7 = (int) Interaction.MsgBox((object) "Renumber is complete Please Use Rebuild Facility after complete all Renumber");
        this.Close();
      }
    }
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='{this.lblType.Text}' and SocTran.MainAccount='Y' order by SocTran.SocTranDate,SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='{this.lblType.Text}' order by SocTran.SocTranDate,SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 27;
    this.DataGridView2.RowCount = 0;
    int num = checked (this.DataGridView3.RowCount - 1);
    int index1 = 0;
    while (index1 <= num)
    {
      this.DataGridView2.Rows.Add();
      int index2 = 0;
      do
      {
        this.DataGridView2.Rows[index1].Cells[checked (index2 + 1)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[index2].Value);
        checked { ++index2; }
      }
      while (index2 <= 25);
      checked { ++index1; }
    }
    this.DataGridView2.ClearSelection();
    if (this.DataGridView2.RowCount == 0)
      this.btnUpdate.Enabled = false;
    else
      this.btnUpdate.Enabled = true;
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  public DataSet GetFillSubTranType()
  {
    this.cmbSubTranType.Enabled = true;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocTranType WHERE SocTranType.Main_Abr='{this.lblType.Text}' order by SocTranType.Sub_Abr asc", selectConnection);
    DataTable dataTable = new DataTable("SocTranType");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView4.DataSource = (object) dataTable;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    this.cmbSubTranType.DataSource = (object) dataTable;
    this.cmbSubTranType.DisplayMember = "Sub_Abr";
    this.cmbSubTranType.ValueMember = "ID";
    selectConnection.Close();
    if (this.DataGridView4.RowCount >= 2)
      this.cmbSubTranType.Enabled = true;
    else
      this.cmbSubTranType.Enabled = false;
    DataSet fillSubTranType;
    return fillSubTranType;
  }

  public DataSet GetFillGridSubType()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='{this.lblType.Text}' and SocTran.SubTranType='{this.cmbSubTranType.Text}' and SocTran.MainAccount='Y' order by SocTran.SocTranDate,SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable1 = new DataTable("SocTran");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='{this.lblType.Text}' and SocTran.SubTranType='{this.cmbSubTranType.Text}' order by SocTran.SocTranDate,SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 29;
    this.DataGridView2.RowCount = 0;
    int num = checked (this.DataGridView3.RowCount - 1);
    int index1 = 0;
    while (index1 <= num)
    {
      this.DataGridView2.Rows.Add();
      int index2 = 0;
      do
      {
        this.DataGridView2.Rows[index1].Cells[checked (index2 + 1)].Value = RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[index1].Cells[index2].Value);
        checked { ++index2; }
      }
      while (index2 <= 27);
      checked { ++index1; }
    }
    this.DataGridView2.ClearSelection();
    if (this.DataGridView2.RowCount == 0)
      this.btnUpdate.Enabled = false;
    else
      this.btnUpdate.Enabled = true;
    selectConnection.Close();
    DataSet fillGridSubType;
    return fillGridSubType;
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }
}
