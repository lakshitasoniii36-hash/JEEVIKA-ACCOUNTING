// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMemberBillMasterSelect
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
public class frmMemberBillMasterSelect : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("lblHeading")]
  private Label _lblHeading;
  [AccessedThroughProperty("btnOk")]
  private Button _btnOk;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("chkPark")]
  private CheckBox _chkPark;
  [AccessedThroughProperty("chkNoc")]
  private CheckBox _chkNoc;
  [AccessedThroughProperty("cmbSubTranType")]
  private ComboBox _cmbSubTranType;
  [AccessedThroughProperty("lblcashbank")]
  private Label _lblcashbank;
  [AccessedThroughProperty("DataGridView5")]
  private DataGridView _DataGridView5;

  [DebuggerNonUserCode]
  static frmMemberBillMasterSelect()
  {
  }

  [DebuggerNonUserCode]
  public frmMemberBillMasterSelect()
  {
    this.KeyDown += new KeyEventHandler(this.frmMemberBillMasterSelect_KeyDown);
    this.Load += new EventHandler(this.frmMemberBillMasterSelect_Load);
    frmMemberBillMasterSelect.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMemberBillMasterSelect.__ENCList)
    {
      if (frmMemberBillMasterSelect.__ENCList.Count == frmMemberBillMasterSelect.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMemberBillMasterSelect.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMemberBillMasterSelect.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMemberBillMasterSelect.__ENCList[index1] = frmMemberBillMasterSelect.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMemberBillMasterSelect.__ENCList.RemoveRange(index1, checked (frmMemberBillMasterSelect.__ENCList.Count - index1));
        frmMemberBillMasterSelect.__ENCList.Capacity = frmMemberBillMasterSelect.__ENCList.Count;
      }
      frmMemberBillMasterSelect.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMemberBillMasterSelect));
    this.lblHeading = new Label();
    this.btnOk = new Button();
    this.btnExit = new Button();
    this.GroupBox2 = new GroupBox();
    this.Label9 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label10 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.Button2 = new Button();
    this.lblType = new Label();
    this.chkPark = new CheckBox();
    this.chkNoc = new CheckBox();
    this.cmbSubTranType = new ComboBox();
    this.lblcashbank = new Label();
    this.DataGridView5 = new DataGridView();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView5).BeginInit();
    this.SuspendLayout();
    this.lblHeading.AutoSize = true;
    this.lblHeading.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblHeading.ForeColor = Color.Blue;
    Label lblHeading1 = this.lblHeading;
    Point point1 = new Point(77, 32 /*0x20*/);
    Point point2 = point1;
    lblHeading1.Location = point2;
    this.lblHeading.Name = "lblHeading";
    Label lblHeading2 = this.lblHeading;
    Size size1 = new Size(162, 20);
    Size size2 = size1;
    lblHeading2.Size = size2;
    this.lblHeading.TabIndex = 30;
    this.lblHeading.Text = "Member Bill Master";
    Button btnOk1 = this.btnOk;
    point1 = new Point(51, 258);
    Point point3 = point1;
    btnOk1.Location = point3;
    this.btnOk.Name = "btnOk";
    Button btnOk2 = this.btnOk;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnOk2.Size = size3;
    this.btnOk.TabIndex = 5;
    this.btnOk.Text = "O&k";
    this.btnOk.UseVisualStyleBackColor = true;
    Button btnExit1 = this.btnExit;
    point1 = new Point(152, 258);
    Point point4 = point1;
    btnExit1.Location = point4;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnExit2.Size = size4;
    this.btnExit.TabIndex = 6;
    this.btnExit.Text = "&Cancel";
    this.btnExit.UseVisualStyleBackColor = true;
    this.GroupBox2.Controls.Add((Control) this.Label9);
    this.GroupBox2.Controls.Add((Control) this.txtMemCodeFrom);
    this.GroupBox2.Controls.Add((Control) this.Label10);
    this.GroupBox2.Controls.Add((Control) this.btnListTo);
    this.GroupBox2.Controls.Add((Control) this.txtMemCodeTo);
    this.GroupBox2.Controls.Add((Control) this.btnListFrom);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(30, 137);
    Point point5 = point1;
    groupBox2_1.Location = point5;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(261, 52);
    Size size5 = size1;
    groupBox2_2.Size = size5;
    this.GroupBox2.TabIndex = 0;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Member Range";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.Black;
    Label label9_1 = this.Label9;
    point1 = new Point(139, 22);
    Point point6 = point1;
    label9_1.Location = point6;
    this.Label9.Name = "Label9";
    Label label9_2 = this.Label9;
    size1 = new Size(20, 13);
    Size size6 = size1;
    label9_2.Size = size6;
    this.Label9.TabIndex = 97;
    this.Label9.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(47, 19);
    Point point7 = point1;
    txtMemCodeFrom1.Location = point7;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(70, 20);
    Size size7 = size1;
    txtMemCodeFrom2.Size = size7;
    this.txtMemCodeFrom.TabIndex = 1;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.Black;
    Label label10_1 = this.Label10;
    point1 = new Point(10, 22);
    Point point8 = point1;
    label10_1.Location = point8;
    this.Label10.Name = "Label10";
    Label label10_2 = this.Label10;
    size1 = new Size(30, 13);
    Size size8 = size1;
    label10_2.Size = size8;
    this.Label10.TabIndex = 96 /*0x60*/;
    this.Label10.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(231, 17);
    Point point9 = point1;
    btnListTo1.Location = point9;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size9 = size1;
    btnListTo2.Size = size9;
    this.btnListTo.TabIndex = 4;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(162, 19);
    Point point10 = point1;
    txtMemCodeTo1.Location = point10;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(70, 20);
    Size size10 = size1;
    txtMemCodeTo2.Size = size10;
    this.txtMemCodeTo.TabIndex = 3;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(116, 17);
    Point point11 = point1;
    btnListFrom1.Location = point11;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size11 = size1;
    btnListFrom2.Size = size11;
    this.btnListFrom.TabIndex = 2;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(228, 260);
    Point point12 = point1;
    button2_1.Location = point12;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 30);
    Size size12 = size1;
    button2_2.Size = size12;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.lblType.AutoSize = true;
    this.lblType.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblType.ForeColor = Color.Blue;
    Label lblType1 = this.lblType;
    point1 = new Point(297, 9);
    Point point13 = point1;
    lblType1.Location = point13;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(19, 20);
    Size size13 = size1;
    lblType2.Size = size13;
    this.lblType.TabIndex = 84;
    this.lblType.Text = "0";
    this.chkPark.AutoSize = true;
    CheckBox chkPark1 = this.chkPark;
    point1 = new Point(155, 208 /*0xD0*/);
    Point point14 = point1;
    chkPark1.Location = point14;
    this.chkPark.Name = "chkPark";
    CheckBox chkPark2 = this.chkPark;
    size1 = new Size(153, 17);
    Size size14 = size1;
    chkPark2.Size = size14;
    this.chkPark.TabIndex = 94;
    this.chkPark.Text = "Show Park Details Remark";
    this.chkPark.UseVisualStyleBackColor = true;
    this.chkNoc.AutoSize = true;
    CheckBox chkNoc1 = this.chkNoc;
    point1 = new Point(30, 208 /*0xD0*/);
    Point point15 = point1;
    chkNoc1.Location = point15;
    this.chkNoc.Name = "chkNoc";
    CheckBox chkNoc2 = this.chkNoc;
    size1 = new Size(119, 17);
    Size size15 = size1;
    chkNoc2.Size = size15;
    this.chkNoc.TabIndex = 93;
    this.chkNoc.Text = "Show NOC Remark";
    this.chkNoc.UseVisualStyleBackColor = true;
    this.cmbSubTranType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbSubTranType.FormattingEnabled = true;
    ComboBox cmbSubTranType1 = this.cmbSubTranType;
    point1 = new Point(160 /*0xA0*/, 99);
    Point point16 = point1;
    cmbSubTranType1.Location = point16;
    this.cmbSubTranType.Name = "cmbSubTranType";
    ComboBox cmbSubTranType2 = this.cmbSubTranType;
    size1 = new Size(112 /*0x70*/, 24);
    Size size16 = size1;
    cmbSubTranType2.Size = size16;
    this.cmbSubTranType.TabIndex = 95;
    this.lblcashbank.AutoSize = true;
    this.lblcashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblcashbank1 = this.lblcashbank;
    point1 = new Point(42, 102);
    Point point17 = point1;
    lblcashbank1.Location = point17;
    this.lblcashbank.Name = "lblcashbank";
    Label lblcashbank2 = this.lblcashbank;
    size1 = new Size(111, 16 /*0x10*/);
    Size size17 = size1;
    lblcashbank2.Size = size17;
    this.lblcashbank.TabIndex = 96 /*0x60*/;
    this.lblcashbank.Text = "Select Bill Master";
    this.DataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView5_1 = this.DataGridView5;
    point1 = new Point(270, 38);
    Point point18 = point1;
    dataGridView5_1.Location = point18;
    this.DataGridView5.Name = "DataGridView5";
    DataGridView dataGridView5_2 = this.DataGridView5;
    size1 = new Size(14, 14);
    Size size18 = size1;
    dataGridView5_2.Size = size18;
    this.DataGridView5.TabIndex = 104;
    this.DataGridView5.Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView5);
    this.Controls.Add((Control) this.cmbSubTranType);
    this.Controls.Add((Control) this.lblcashbank);
    this.Controls.Add((Control) this.chkPark);
    this.Controls.Add((Control) this.chkNoc);
    this.Controls.Add((Control) this.lblType);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.lblHeading);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMemberBillMasterSelect);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Bill Master";
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView5).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label lblHeading
  {
    [DebuggerNonUserCode] get => this._lblHeading;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblHeading = value;
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

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
    }
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual TextBox txtMemCodeFrom
  {
    [DebuggerNonUserCode] get => this._txtMemCodeFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtMemCodeFrom_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeFrom_KeyDown);
      if (this._txtMemCodeFrom != null)
      {
        this._txtMemCodeFrom.Validated -= eventHandler;
        this._txtMemCodeFrom.KeyDown -= keyEventHandler;
      }
      this._txtMemCodeFrom = value;
      if (this._txtMemCodeFrom == null)
        return;
      this._txtMemCodeFrom.Validated += eventHandler;
      this._txtMemCodeFrom.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual Button btnListTo
  {
    [DebuggerNonUserCode] get => this._btnListTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnListTo_Click);
      if (this._btnListTo != null)
        this._btnListTo.Click -= eventHandler;
      this._btnListTo = value;
      if (this._btnListTo == null)
        return;
      this._btnListTo.Click += eventHandler;
    }
  }

  internal virtual TextBox txtMemCodeTo
  {
    [DebuggerNonUserCode] get => this._txtMemCodeTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtMemCodeTo_Validated);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtMemCodeTo_KeyDown);
      if (this._txtMemCodeTo != null)
      {
        this._txtMemCodeTo.Validated -= eventHandler;
        this._txtMemCodeTo.KeyDown -= keyEventHandler;
      }
      this._txtMemCodeTo = value;
      if (this._txtMemCodeTo == null)
        return;
      this._txtMemCodeTo.Validated += eventHandler;
      this._txtMemCodeTo.KeyDown += keyEventHandler;
    }
  }

  internal virtual Button btnListFrom
  {
    [DebuggerNonUserCode] get => this._btnListFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnListFrom_Click);
      if (this._btnListFrom != null)
        this._btnListFrom.Click -= eventHandler;
      this._btnListFrom = value;
      if (this._btnListFrom == null)
        return;
      this._btnListFrom.Click += eventHandler;
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

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
  }

  internal virtual CheckBox chkPark
  {
    [DebuggerNonUserCode] get => this._chkPark;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkPark = value;
  }

  internal virtual CheckBox chkNoc
  {
    [DebuggerNonUserCode] get => this._chkNoc;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkNoc = value;
  }

  internal virtual ComboBox cmbSubTranType
  {
    [DebuggerNonUserCode] get => this._cmbSubTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbSubTranType = value;
    }
  }

  internal virtual Label lblcashbank
  {
    [DebuggerNonUserCode] get => this._lblcashbank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblcashbank = value;
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

  private void frmMemberBillMasterSelect_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmMemberBillMasterSelect_Load(object sender, EventArgs e)
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTranType WHERE (SocTranType.Main_Abr= 'Bill' ) order by Sub_Abr asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
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
    MyProject.Forms.frmMemberBillMaster.lblMemForm.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    MyProject.Forms.frmMemberBillMaster.lblMemTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.txtMemCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    this.txtMemCodeTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.lblType.Visible = false;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnOk_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmMemberBillMaster.lblType.Text = this.lblType.Text;
    MyProject.Forms.frmMemberBillMaster.lblBillMasterNo.Text = this.cmbSubTranType.Text.Trim();
    MyProject.Forms.frmMemberBillMaster.lblMemForm.Text = this.txtMemCodeFrom.Text;
    MyProject.Forms.frmMemberBillMaster.lblMemTo.Text = this.txtMemCodeTo.Text;
    int num = (int) MyProject.Forms.frmMemberBillMaster.ShowDialog();
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = this.txtMemCodeFrom.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.txtMemCodeTo.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnListTo_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = this.txtMemCodeTo.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      this.btnOk.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void txtMemCodeFrom_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtMemCodeTo.Focus();
  }

  private void txtMemCodeFrom_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeFrom.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      Constant.SearchStr = this.txtMemCodeFrom.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
        this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void txtMemCodeTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnOk.Focus();
  }

  private void txtMemCodeTo_Validated(object sender, EventArgs e)
  {
    int num1 = 0;
    int index1 = -1;
    int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
    int index2 = 0;
    while (index2 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtMemCodeTo.Text.Trim(), MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index2].Cells[7].Value.ToString().Trim(), false) == 0)
      {
        checked { ++num1; }
        index1 = index2;
      }
      checked { ++index2; }
    }
    if (num1 == 1)
    {
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value);
    }
    else
    {
      MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      Constant.SearchStr = this.txtMemCodeTo.Text;
      MyProject.Forms.frmMember.Visible = false;
      MyProject.Forms.frmMember.Close();
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
        this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }
}
