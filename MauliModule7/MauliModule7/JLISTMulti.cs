// Decompiled with JetBrains decompiler
// Type: MauliModule7.JLISTMulti
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
public class JLISTMulti : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnModify")]
  private Button _btnModify;
  [AccessedThroughProperty("txtMaxMemCode")]
  private TextBox _txtMaxMemCode;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnJReport")]
  private Button _btnJReport;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnWord")]
  private Button _btnWord;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("cmbSearch")]
  private ComboBox _cmbSearch;
  [AccessedThroughProperty("txtSearch")]
  private TextBox _txtSearch;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static JLISTMulti()
  {
  }

  [DebuggerNonUserCode]
  public JLISTMulti()
  {
    this.Load += new EventHandler(this.JLISTMulti_Load);
    JLISTMulti.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (JLISTMulti.__ENCList)
    {
      if (JLISTMulti.__ENCList.Count == JLISTMulti.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (JLISTMulti.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (JLISTMulti.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              JLISTMulti.__ENCList[index1] = JLISTMulti.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        JLISTMulti.__ENCList.RemoveRange(index1, checked (JLISTMulti.__ENCList.Count - index1));
        JLISTMulti.__ENCList.Capacity = JLISTMulti.__ENCList.Count;
      }
      JLISTMulti.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
    DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (JLISTMulti));
    this.btnModify = new Button();
    this.txtMaxMemCode = new TextBox();
    this.btnExit = new Button();
    this.btnJReport = new Button();
    this.DataGridView1 = new DataGridView();
    this.btnWord = new Button();
    this.GroupBox1 = new GroupBox();
    this.cmbSearch = new ComboBox();
    this.txtSearch = new TextBox();
    this.DataGridView2 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.SuspendLayout();
    Button btnModify1 = this.btnModify;
    Point point1 = new Point(343, 535);
    Point point2 = point1;
    btnModify1.Location = point2;
    this.btnModify.Name = "btnModify";
    Button btnModify2 = this.btnModify;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnModify2.Size = size2;
    this.btnModify.TabIndex = 1;
    this.btnModify.Text = "Update";
    this.btnModify.UseVisualStyleBackColor = true;
    TextBox txtMaxMemCode1 = this.txtMaxMemCode;
    point1 = new Point(785, 541);
    Point point3 = point1;
    txtMaxMemCode1.Location = point3;
    this.txtMaxMemCode.Name = "txtMaxMemCode";
    TextBox txtMaxMemCode2 = this.txtMaxMemCode;
    size1 = new Size(56, 20);
    Size size3 = size1;
    txtMaxMemCode2.Size = size3;
    this.txtMaxMemCode.TabIndex = 20;
    this.txtMaxMemCode.Text = "0";
    this.txtMaxMemCode.Visible = false;
    Button btnExit1 = this.btnExit;
    point1 = new Point(467, 535);
    Point point4 = point1;
    btnExit1.Location = point4;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnExit2.Size = size4;
    this.btnExit.TabIndex = 2;
    this.btnExit.Text = "Exit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnJreport1 = this.btnJReport;
    point1 = new Point(658, 535);
    Point point5 = point1;
    btnJreport1.Location = point5;
    this.btnJReport.Name = "btnJReport";
    Button btnJreport2 = this.btnJReport;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnJreport2.Size = size5;
    this.btnJReport.TabIndex = 3;
    this.btnJReport.Text = "Print Preview";
    this.btnJReport.UseVisualStyleBackColor = true;
    this.btnJReport.Visible = false;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(766, 541);
    Point point6 = point1;
    dataGridView1_1.Location = point6;
    this.DataGridView1.MultiSelect = false;
    this.DataGridView1.Name = "DataGridView1";
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.RowHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(13, 20);
    Size size6 = size1;
    dataGridView1_2.Size = size6;
    this.DataGridView1.TabIndex = 0;
    Button btnWord1 = this.btnWord;
    point1 = new Point(884, 535);
    Point point7 = point1;
    btnWord1.Location = point7;
    this.btnWord.Name = "btnWord";
    Button btnWord2 = this.btnWord;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnWord2.Size = size7;
    this.btnWord.TabIndex = 23;
    this.btnWord.Text = "export to word";
    this.btnWord.UseVisualStyleBackColor = true;
    this.btnWord.Visible = false;
    this.GroupBox1.Controls.Add((Control) this.cmbSearch);
    this.GroupBox1.Controls.Add((Control) this.txtSearch);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(31 /*0x1F*/, 530);
    Point point8 = point1;
    groupBox1_1.Location = point8;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(235, 43);
    Size size8 = size1;
    groupBox1_2.Size = size8;
    this.GroupBox1.TabIndex = 30;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Search By";
    this.GroupBox1.Visible = false;
    this.cmbSearch.FormattingEnabled = true;
    this.cmbSearch.Items.AddRange(new object[4]
    {
      (object) "Sr.No.",
      (object) "Regn No.",
      (object) "Member Name",
      (object) "Class of Member"
    });
    ComboBox cmbSearch1 = this.cmbSearch;
    point1 = new Point(4, 16 /*0x10*/);
    Point point9 = point1;
    cmbSearch1.Location = point9;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(102, 21);
    Size size9 = size1;
    cmbSearch2.Size = size9;
    this.cmbSearch.TabIndex = 24;
    TextBox txtSearch1 = this.txtSearch;
    point1 = new Point(116, 16 /*0x10*/);
    Point point10 = point1;
    txtSearch1.Location = point10;
    this.txtSearch.Name = "txtSearch";
    TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(102, 20);
    Size size10 = size1;
    txtSearch2.Size = size10;
    this.txtSearch.TabIndex = 25;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle4.BackColor = SystemColors.Control;
    gridViewCellStyle4.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.WindowText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle4;
    gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle5.BackColor = SystemColors.Window;
    gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle5.ForeColor = SystemColors.ControlText;
    gridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle5.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle5;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(0, 0);
    Point point11 = point1;
    dataGridView2_1.Location = point11;
    this.DataGridView2.MultiSelect = false;
    this.DataGridView2.Name = "DataGridView2";
    gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle6.BackColor = SystemColors.Control;
    gridViewCellStyle6.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle6.ForeColor = SystemColors.WindowText;
    gridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle6.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.RowHeadersDefaultCellStyle = gridViewCellStyle6;
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(995, 524);
    Size size11 = size1;
    dataGridView2_2.Size = size11;
    this.DataGridView2.TabIndex = 31 /*0x1F*/;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(994, 575);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.btnWord);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnJReport);
    this.Controls.Add((Control) this.btnModify);
    this.Controls.Add((Control) this.txtMaxMemCode);
    this.Controls.Add((Control) this.btnExit);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (JLISTMulti);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "\"J\" Register Master";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnModify
  {
    [DebuggerNonUserCode] get => this._btnModify;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnModify_Click);
      if (this._btnModify != null)
        this._btnModify.Click -= eventHandler;
      this._btnModify = value;
      if (this._btnModify == null)
        return;
      this._btnModify.Click += eventHandler;
    }
  }

  internal virtual TextBox txtMaxMemCode
  {
    [DebuggerNonUserCode] get => this._txtMaxMemCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMaxMemCode = value;
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

  internal virtual Button btnJReport
  {
    [DebuggerNonUserCode] get => this._btnJReport;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._btnJReport = value;
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

  internal virtual Button btnWord
  {
    [DebuggerNonUserCode] get => this._btnWord;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._btnWord = value;
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual ComboBox cmbSearch
  {
    [DebuggerNonUserCode] get => this._cmbSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbSearch_SelectedIndexChanged);
      if (this._cmbSearch != null)
        this._cmbSearch.SelectedIndexChanged -= eventHandler;
      this._cmbSearch = value;
      if (this._cmbSearch == null)
        return;
      this._cmbSearch.SelectedIndexChanged += eventHandler;
    }
  }

  internal virtual TextBox txtSearch
  {
    [DebuggerNonUserCode] get => this._txtSearch;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSearch_TextChanged);
      if (this._txtSearch != null)
        this._txtSearch.TextChanged -= eventHandler;
      this._txtSearch = value;
      if (this._txtSearch == null)
        return;
      this._txtSearch.TextChanged += eventHandler;
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

  private void JLISTMulti_Load(object sender, EventArgs e)
  {
    this.DataGridView1.Visible = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT JReg.*,Member.MemRegn,Member.MemName,JReg.Mclass FROM Jreg INNER JOIN Member ON Member.MemID = JReg.MemId order by Member.MemRegn asc", selectConnection);
    DataTable dataTable = new DataTable("JReg");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 7;
    this.DataGridView2.RowCount = 0;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      this.DataGridView2.Rows.Add();
      int index2 = 0;
      do
      {
        this.DataGridView2.Rows[index1].Cells[index2].Value = (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim();
        checked { ++index2; }
      }
      while (index2 <= 6);
      checked { ++index1; }
    }
    this.DataGridView2.Columns[2].HeaderText = "'J' Sr.No.";
    this.DataGridView2.Columns[4].HeaderText = "Member Regn.No.";
    this.DataGridView2.Columns[5].HeaderText = "Member Name";
    this.DataGridView2.Columns[3].HeaderText = "Class of Member";
    this.DataGridView2.Columns[0].Visible = false;
    this.DataGridView2.Columns[1].Visible = false;
    this.DataGridView2.Columns[6].Visible = false;
    this.DataGridView2.Columns[2].Width = 150;
    this.DataGridView2.Columns[4].Width = 150;
    this.DataGridView2.Columns[5].Width = 500;
    this.DataGridView2.Columns[4].ReadOnly = true;
    this.DataGridView2.Columns[5].ReadOnly = true;
    this.DataGridView2.Columns[3].Width = 200;
    this.DataGridView2.ClearSelection();
    if (this.DataGridView1.RowCount == 0)
    {
      int num2 = (int) Interaction.MsgBox((object) "No Record");
      selectConnection.Close();
      this.Close();
    }
    else
      this.DataGridView1.Rows[0].Selected = true;
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnModify_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_statmaster.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
    int num = checked (this.DataGridView2.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      this.DataGridView2.Rows[index].Cells[3].Value = (object) this.DataGridView2.Rows[index].Cells[3].Value.ToString().Replace("'", "''");
      string cmdText = Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[2].Value)) == 0.0 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update JReg set Jsrno =NULL ,Mclass ='", this.DataGridView2.Rows[index].Cells[3].Value), (object) "'  where Id ="), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value))), (object) "")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update JReg set Jsrno ='" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[2].Value))) + "' ,Mclass ='"), this.DataGridView2.Rows[index].Cells[3].Value), (object) "'  where Id ="), (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value))), (object) ""));
      connection.Open();
      new OleDbCommand(cmdText, connection).ExecuteNonQuery();
      connection.Close();
      this.Close();
      checked { ++index; }
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void txtSearch_TextChanged(object sender, EventArgs e)
  {
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 7;
    this.DataGridView2.RowCount = 0;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) == 0)
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index1 = 0;
      while (index1 <= num)
      {
        this.DataGridView2.Rows.Add();
        int index2 = 0;
        do
        {
          this.DataGridView2.Rows[index1].Cells[index2].Value = (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim();
          checked { ++index2; }
        }
        while (index2 <= 6);
        checked { ++index1; }
      }
    }
    else
    {
      int index3 = 0;
      int num = checked (this.DataGridView1.RowCount - 1);
      int index4 = 0;
      while (index4 <= num)
      {
        if (Strings.InStr(Strings.UCase(Strings.Mid(this.DataGridView1.Rows[index4].Cells[this.cmpColumnNo].Value.ToString().Trim(), 1, Strings.Len(this.txtSearch.Text.Trim()))), Strings.UCase(Strings.Trim(this.txtSearch.Text.Trim()))) == 1)
        {
          this.DataGridView2.Rows.Add();
          int index5 = 0;
          do
          {
            this.DataGridView2.Rows[index3].Cells[index5].Value = (object) this.DataGridView1.Rows[index4].Cells[index5].Value.ToString().Trim();
            checked { ++index5; }
          }
          while (index5 <= 6);
          checked { ++index3; }
        }
        checked { ++index4; }
      }
    }
    this.DataGridView2.Columns[2].HeaderText = "'J' Sr.No.";
    this.DataGridView2.Columns[4].HeaderText = "Member Regn.No.";
    this.DataGridView2.Columns[5].HeaderText = "Member Name";
    this.DataGridView2.Columns[6].HeaderText = "Class of Member";
    this.DataGridView2.Columns[0].Visible = false;
    this.DataGridView2.Columns[1].Visible = false;
    this.DataGridView2.Columns[3].Visible = false;
    this.DataGridView2.Columns[2].Width = 150;
    this.DataGridView2.Columns[4].Width = 150;
    this.DataGridView2.Columns[5].Width = 500;
    this.DataGridView2.Columns[6].Width = 200;
    this.DataGridView2.ClearSelection();
  }

  private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.cmbSearch.SelectedIndex == 0)
      this.cmpColumnNo = 2;
    if (this.cmbSearch.SelectedIndex == 1)
      this.cmpColumnNo = 4;
    if (this.cmbSearch.SelectedIndex == 2)
      this.cmpColumnNo = 5;
    if (this.cmbSearch.SelectedIndex != 3)
      return;
    this.cmpColumnNo = 6;
  }
}
