// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMultiReceiptMemberSelect
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmMultiReceiptMemberSelect : Form
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
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtNo")]
  private TextBox _txtNo;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("grpvisible")]
  private GroupBox _grpvisible;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmMultiReceiptMemberSelect()
  {
  }

  [DebuggerNonUserCode]
  public frmMultiReceiptMemberSelect()
  {
    this.Load += new EventHandler(this.frmMultiReceiptMemberSelect_Load);
    frmMultiReceiptMemberSelect.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMultiReceiptMemberSelect.__ENCList)
    {
      if (frmMultiReceiptMemberSelect.__ENCList.Count == frmMultiReceiptMemberSelect.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMultiReceiptMemberSelect.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMultiReceiptMemberSelect.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMultiReceiptMemberSelect.__ENCList[index1] = frmMultiReceiptMemberSelect.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMultiReceiptMemberSelect.__ENCList.RemoveRange(index1, checked (frmMultiReceiptMemberSelect.__ENCList.Count - index1));
        frmMultiReceiptMemberSelect.__ENCList.Capacity = frmMultiReceiptMemberSelect.__ENCList.Count;
      }
      frmMultiReceiptMemberSelect.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMultiReceiptMemberSelect));
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
    this.Label1 = new Label();
    this.txtNo = new TextBox();
    this.DataGridView1 = new DataGridView();
    this.grpvisible = new GroupBox();
    this.lblType = new Label();
    this.Button2 = new Button();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpvisible.SuspendLayout();
    this.SuspendLayout();
    this.lblHeading.AutoSize = true;
    this.lblHeading.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblHeading.ForeColor = Color.Blue;
    Label lblHeading1 = this.lblHeading;
    Point point1 = new Point(26, 76);
    Point point2 = point1;
    lblHeading1.Location = point2;
    this.lblHeading.Name = "lblHeading";
    Label lblHeading2 = this.lblHeading;
    Size size1 = new Size(273, 20);
    Size size2 = size1;
    lblHeading2.Size = size2;
    this.lblHeading.TabIndex = 30;
    this.lblHeading.Text = "Member Range For Multi Receipt";
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
    point1 = new Point(156, 258);
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
    point1 = new Point(136, 22);
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
    size1 = new Size(62, 20);
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
    point1 = new Point(219, 17);
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
    point1 = new Point(159, 19);
    Point point10 = point1;
    txtMemCodeTo1.Location = point10;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(62, 20);
    Size size10 = size1;
    txtMemCodeTo2.Size = size10;
    this.txtMemCodeTo.TabIndex = 3;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(108, 17);
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
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(40, 208 /*0xD0*/);
    Point point12 = point1;
    label1_1.Location = point12;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(103, 13);
    Size size12 = size1;
    label1_2.Size = size12;
    this.Label1.TabIndex = 31 /*0x1F*/;
    this.Label1.Text = "Starting Receipt No.";
    TextBox txtNo1 = this.txtNo;
    point1 = new Point(189, 205);
    Point point13 = point1;
    txtNo1.Location = point13;
    this.txtNo.Name = "txtNo";
    TextBox txtNo2 = this.txtNo;
    size1 = new Size(83, 20);
    Size size13 = size1;
    txtNo2.Size = size13;
    this.txtNo.TabIndex = 32 /*0x20*/;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(15, 22);
    Point point14 = point1;
    dataGridView1_1.Location = point14;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size14 = size1;
    dataGridView1_2.Size = size14;
    this.DataGridView1.TabIndex = 33;
    this.grpvisible.Controls.Add((Control) this.lblType);
    this.grpvisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpvisible1 = this.grpvisible;
    point1 = new Point(174, 316);
    Point point15 = point1;
    grpvisible1.Location = point15;
    this.grpvisible.Name = "grpvisible";
    GroupBox grpvisible2 = this.grpvisible;
    size1 = new Size(131, 38);
    Size size15 = size1;
    grpvisible2.Size = size15;
    this.grpvisible.TabIndex = 34;
    this.grpvisible.TabStop = false;
    this.grpvisible.Text = "GroupBox1";
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(59, 19);
    Point point16 = point1;
    lblType1.Location = point16;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(45, 13);
    Size size16 = size1;
    lblType2.Size = size16;
    this.lblType.TabIndex = 35;
    this.lblType.Text = "Format1";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(225, 259);
    Point point17 = point1;
    button2_1.Location = point17;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size17 = size1;
    button2_2.Size = size17;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpvisible);
    this.Controls.Add((Control) this.txtNo);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnOk);
    this.Controls.Add((Control) this.lblHeading);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMultiReceiptMemberSelect);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Multi Receipt Member Select";
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpvisible.ResumeLayout(false);
    this.grpvisible.PerformLayout();
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
      if (this._txtMemCodeFrom != null)
        this._txtMemCodeFrom.Validated -= eventHandler;
      this._txtMemCodeFrom = value;
      if (this._txtMemCodeFrom == null)
        return;
      this._txtMemCodeFrom.Validated += eventHandler;
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
      if (this._txtMemCodeTo != null)
        this._txtMemCodeTo.Validated -= eventHandler;
      this._txtMemCodeTo = value;
      if (this._txtMemCodeTo == null)
        return;
      this._txtMemCodeTo.Validated += eventHandler;
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox txtNo
  {
    [DebuggerNonUserCode] get => this._txtNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNo = value;
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual GroupBox grpvisible
  {
    [DebuggerNonUserCode] get => this._grpvisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpvisible = value;
    }
  }

  internal virtual Label lblType
  {
    [DebuggerNonUserCode] get => this._lblType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblType = value;
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

  private void frmMultiReceiptMemberSelect_Load(object sender, EventArgs e)
  {
    this.grpvisible.Visible = false;
    this.GetFillGrid();
    this.txtNo.Text = Conversions.ToString(checked (this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max() + 1));
    MyProject.Forms.frmMultiReceiptMaster.lblMemForm.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    MyProject.Forms.frmMultiReceiptMaster.lblMemTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.txtMemCodeFrom.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    this.txtMemCodeTo.Text = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
  }

  public DataSet GetFillGrid()
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='MRct') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    DataTable dataTable = new DataTable("SocTran");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnOk_Click(object sender, EventArgs e)
  {
    if (!Versioned.IsNumeric((object) this.txtNo.Text))
    {
      int num = (int) Interaction.MsgBox((object) "Numeric Only");
      this.txtNo.Focus();
    }
    else
    {
      MyProject.Forms.frmMultiReceiptMaster.lblMemForm.Text = this.txtMemCodeFrom.Text;
      MyProject.Forms.frmMultiReceiptMaster.lblMemTo.Text = this.txtMemCodeTo.Text;
      int num = (int) MyProject.Forms.frmMultiReceiptMaster.ShowDialog();
      this.GetFillGrid();
      MyProject.Forms.frmMultiReceiptMaster = (frmMultiReceiptMaster) null;
    }
  }

  private void btnListFrom_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "R";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    Constant.SearchStr = this.txtMemCodeFrom.Text;
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
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
      this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
    Constant.SearchStat = false;
    Constant.SearchStr = "";
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
