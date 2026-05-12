// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmZerowise
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
public class frmZerowise : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnZerowise")]
  private Button _btnZerowise;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("grpMemberList")]
  private GroupBox _grpMemberList;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("txtMemCodeFrom")]
  private TextBox _txtMemCodeFrom;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("btnListTo")]
  private Button _btnListTo;
  [AccessedThroughProperty("txtMemCodeTo")]
  private TextBox _txtMemCodeTo;
  [AccessedThroughProperty("btnListFrom")]
  private Button _btnListFrom;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmZerowise()
  {
  }

  [DebuggerNonUserCode]
  public frmZerowise()
  {
    this.KeyDown += new KeyEventHandler(this.frmZerowise_KeyDown);
    this.Load += new EventHandler(this.frmZerowise_Load);
    frmZerowise.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmZerowise.__ENCList)
    {
      if (frmZerowise.__ENCList.Count == frmZerowise.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmZerowise.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmZerowise.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmZerowise.__ENCList[index1] = frmZerowise.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmZerowise.__ENCList.RemoveRange(index1, checked (frmZerowise.__ENCList.Count - index1));
        frmZerowise.__ENCList.Capacity = frmZerowise.__ENCList.Count;
      }
      frmZerowise.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmZerowise));
    this.btnExit = new Button();
    this.btnZerowise = new Button();
    this.DataGridView1 = new DataGridView();
    this.Label4 = new Label();
    this.pb1 = new ProgressBar();
    this.grpMemberList = new GroupBox();
    this.Label15 = new Label();
    this.txtMemCodeFrom = new TextBox();
    this.Label16 = new Label();
    this.btnListTo = new Button();
    this.txtMemCodeTo = new TextBox();
    this.btnListFrom = new Button();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpMemberList.SuspendLayout();
    this.SuspendLayout();
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(161, 268);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 6;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnZerowise1 = this.btnZerowise;
    point1 = new Point(56, 268);
    Point point3 = point1;
    btnZerowise1.Location = point3;
    this.btnZerowise.Name = "btnZerowise";
    Button btnZerowise2 = this.btnZerowise;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnZerowise2.Size = size3;
    this.btnZerowise.TabIndex = 5;
    this.btnZerowise.Text = "&Zerowise";
    this.btnZerowise.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(12, 222);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 12;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Blue;
    Label label4_1 = this.Label4;
    point1 = new Point(84, 40);
    Point point5 = point1;
    label4_1.Location = point5;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(149, 20);
    Size size5 = size1;
    label4_2.Size = size5;
    this.Label4.TabIndex = 74;
    this.Label4.Text = "Interest Zerowise";
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(-3, 342);
    Point point6 = point1;
    pb1_1.Location = point6;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(319, 23);
    Size size6 = size1;
    pb1_2.Size = size6;
    this.pb1.TabIndex = 75;
    this.grpMemberList.Controls.Add((Control) this.Label15);
    this.grpMemberList.Controls.Add((Control) this.txtMemCodeFrom);
    this.grpMemberList.Controls.Add((Control) this.Label16);
    this.grpMemberList.Controls.Add((Control) this.btnListTo);
    this.grpMemberList.Controls.Add((Control) this.txtMemCodeTo);
    this.grpMemberList.Controls.Add((Control) this.btnListFrom);
    GroupBox grpMemberList1 = this.grpMemberList;
    point1 = new Point(14, 122);
    Point point7 = point1;
    grpMemberList1.Location = point7;
    this.grpMemberList.Name = "grpMemberList";
    GroupBox grpMemberList2 = this.grpMemberList;
    size1 = new Size(288, 72);
    Size size7 = size1;
    grpMemberList2.Size = size7;
    this.grpMemberList.TabIndex = 0;
    this.grpMemberList.TabStop = false;
    this.grpMemberList.Text = "Member Range";
    this.Label15.AutoSize = true;
    this.Label15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label15.ForeColor = Color.Black;
    Label label15_1 = this.Label15;
    point1 = new Point(151, 34);
    Point point8 = point1;
    label15_1.Location = point8;
    this.Label15.Name = "Label15";
    Label label15_2 = this.Label15;
    size1 = new Size(20, 13);
    Size size8 = size1;
    label15_2.Size = size8;
    this.Label15.TabIndex = 97;
    this.Label15.Text = "To";
    this.txtMemCodeFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeFrom1 = this.txtMemCodeFrom;
    point1 = new Point(50, 29);
    Point point9 = point1;
    txtMemCodeFrom1.Location = point9;
    this.txtMemCodeFrom.Name = "txtMemCodeFrom";
    TextBox txtMemCodeFrom2 = this.txtMemCodeFrom;
    size1 = new Size(76, 22);
    Size size9 = size1;
    txtMemCodeFrom2.Size = size9;
    this.txtMemCodeFrom.TabIndex = 1;
    this.Label16.AutoSize = true;
    this.Label16.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label16.ForeColor = Color.Black;
    Label label16_1 = this.Label16;
    point1 = new Point(14, 34);
    Point point10 = point1;
    label16_1.Location = point10;
    this.Label16.Name = "Label16";
    Label label16_2 = this.Label16;
    size1 = new Size(30, 13);
    Size size10 = size1;
    label16_2.Size = size10;
    this.Label16.TabIndex = 96 /*0x60*/;
    this.Label16.Text = "From";
    this.btnListTo.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListTo1 = this.btnListTo;
    point1 = new Point(252, 28);
    Point point11 = point1;
    btnListTo1.Location = point11;
    this.btnListTo.Name = "btnListTo";
    Button btnListTo2 = this.btnListTo;
    size1 = new Size(23, 24);
    Size size11 = size1;
    btnListTo2.Size = size11;
    this.btnListTo.TabIndex = 4;
    this.btnListTo.Text = "v";
    this.btnListTo.UseVisualStyleBackColor = false;
    this.txtMemCodeTo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemCodeTo1 = this.txtMemCodeTo;
    point1 = new Point(177, 29);
    Point point12 = point1;
    txtMemCodeTo1.Location = point12;
    this.txtMemCodeTo.Name = "txtMemCodeTo";
    TextBox txtMemCodeTo2 = this.txtMemCodeTo;
    size1 = new Size(76, 22);
    Size size12 = size1;
    txtMemCodeTo2.Size = size12;
    this.txtMemCodeTo.TabIndex = 3;
    this.btnListFrom.BackColor = Color.FromArgb(150, 200, 230);
    this.btnListFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Button btnListFrom1 = this.btnListFrom;
    point1 = new Point(125, 28);
    Point point13 = point1;
    btnListFrom1.Location = point13;
    this.btnListFrom.Name = "btnListFrom";
    Button btnListFrom2 = this.btnListFrom;
    size1 = new Size(23, 24);
    Size size13 = size1;
    btnListFrom2.Size = size13;
    this.btnListFrom.TabIndex = 2;
    this.btnListFrom.Text = "v";
    this.btnListFrom.UseVisualStyleBackColor = false;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(234, 269);
    Point point14 = point1;
    button2_1.Location = point14;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size14 = size1;
    button2_2.Size = size14;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpMemberList);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnZerowise);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmZerowise);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpMemberList.ResumeLayout(false);
    this.grpMemberList.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Button btnZerowise
  {
    [DebuggerNonUserCode] get => this._btnZerowise;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnZerowise_Click);
      if (this._btnZerowise != null)
        this._btnZerowise.Click -= eventHandler;
      this._btnZerowise = value;
      if (this._btnZerowise == null)
        return;
      this._btnZerowise.Click += eventHandler;
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

  internal virtual GroupBox grpMemberList
  {
    [DebuggerNonUserCode] get => this._grpMemberList;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpMemberList = value;
    }
  }

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
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

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
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

  private void frmZerowise_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmZerowise_Load(object sender, EventArgs e)
  {
    this.DataGridView1.Visible = false;
    Constant.MemberCodeRangeFrom = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value.ToString();
    Constant.MemberCodeRangeto = MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value.ToString();
    this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[0].Cells[7].Value);
    this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1)].Cells[7].Value);
    this.pb1.Visible = false;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnZerowise_Click(object sender, EventArgs e)
  {
    this.pb1.Visible = true;
    this.pb1.Value = 0;
    this.GetFillGrid();
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    int num = checked (this.DataGridView1.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocBillMaster set AmtInt = 0 where SocBillMasteId =", this.DataGridView1.Rows[index].Cells[0].Value), (object) "")), connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
      this.pb1.Value = checked ((int) Math.Round(unchecked ((double) index / (double) checked (this.DataGridView1.RowCount + 1) * 100.0)));
      checked { ++index; }
    }
    this.Close();
  }

  public DataSet GetFillGrid()
  {
    Constant.MemberCodeRangeFrom = this.txtMemCodeFrom.Text;
    Constant.MemberCodeRangeto = this.txtMemCodeTo.Text;
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocBillMaster.SocBillMasteId, SocMember.SocAccountMainId, SocMember.MemCode, SocBillMaster.AmtInt FROM (SocAccountMain INNER JOIN SocMember ON SocAccountMain.SocAccountMainId = SocMember.SocAccountMainId) INNER JOIN SocBillMaster ON SocMember.SocMemId = SocBillMaster.SocMemId WHERE (SocMember.MemCode >= '{Constant.MemberCodeRangeFrom.Trim()}' and SocMember.MemCode <= '{Constant.MemberCodeRangeto.Trim()}') ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable = new DataTable("SocMember");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    DataSet fillGrid;
    return fillGrid;
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
      MyProject.Forms.frmMember.Close();
      MyProject.Forms.frmMember.Visible = false;
      int num3 = (int) MyProject.Forms.frmMember.ShowDialog();
      if (Constant.SearchStat & MyProject.Forms.frmMember.DataGridView2.SelectedRows.Count == 1)
      {
        this.txtMemCodeFrom.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
      }
      else
      {
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
        this.txtMemCodeFrom.Focus();
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
  }

  private void txtMemCodeTo_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnZerowise.Focus();
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
      {
        this.txtMemCodeTo.Text = Conversions.ToString(MyProject.Forms.frmMember.DataGridView2.CurrentRow.Cells[1].Value);
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
      }
      else
      {
        MyProject.Forms.frmMember.Visible = false;
        MyProject.Forms.frmMember.Close();
        this.txtMemCodeTo.Focus();
      }
      Constant.SearchStat = false;
      Constant.SearchStr = "";
    }
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
      this.btnZerowise.Focus();
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }
}
