// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmPartList
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
public class frmPartList : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnSelect")]
  private Button _btnSelect;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("lblParType")]
  private Label _lblParType;
  [AccessedThroughProperty("lblPart")]
  private Label _lblPart;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("txtSearchbox")]
  private TextBox _txtSearchbox;

  [DebuggerNonUserCode]
  static frmPartList()
  {
  }

  [DebuggerNonUserCode]
  public frmPartList()
  {
    this.Load += new EventHandler(this.frmPartList_Load);
    frmPartList.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmPartList.__ENCList)
    {
      if (frmPartList.__ENCList.Count == frmPartList.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmPartList.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmPartList.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmPartList.__ENCList[index1] = frmPartList.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmPartList.__ENCList.RemoveRange(index1, checked (frmPartList.__ENCList.Count - index1));
        frmPartList.__ENCList.Capacity = frmPartList.__ENCList.Count;
      }
      frmPartList.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPartList));
    this.btnSelect = new Button();
    this.btnCancel = new Button();
    this.lblParType = new Label();
    this.lblPart = new Label();
    this.btnAdd = new Button();
    this.btnDelete = new Button();
    this.DataGridView1 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.DataGridView2 = new DataGridView();
    this.txtSearchbox = new TextBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.SuspendLayout();
    Button btnSelect1 = this.btnSelect;
    Point point1 = new Point(11, 490);
    Point point2 = point1;
    btnSelect1.Location = point2;
    this.btnSelect.Name = "btnSelect";
    Button btnSelect2 = this.btnSelect;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnSelect2.Size = size2;
    this.btnSelect.TabIndex = 2;
    this.btnSelect.Text = "&Select";
    this.btnSelect.UseVisualStyleBackColor = true;
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(330, 490);
    Point point3 = point1;
    btnCancel1.Location = point3;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel2 = this.btnCancel;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnCancel2.Size = size3;
    this.btnCancel.TabIndex = 5;
    this.btnCancel.Text = "&Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.lblParType.AutoSize = true;
    Label lblParType1 = this.lblParType;
    point1 = new Point(6, 16 /*0x10*/);
    Point point4 = point1;
    lblParType1.Location = point4;
    this.lblParType.Name = "lblParType";
    Label lblParType2 = this.lblParType;
    size1 = new Size(27, 13);
    Size size4 = size1;
    lblParType2.Size = size4;
    this.lblParType.TabIndex = 3;
    this.lblParType.Text = "type";
    this.lblPart.AutoSize = true;
    Label lblPart1 = this.lblPart;
    point1 = new Point(36, 16 /*0x10*/);
    Point point5 = point1;
    lblPart1.Location = point5;
    this.lblPart.Name = "lblPart";
    Label lblPart2 = this.lblPart;
    size1 = new Size(26, 13);
    Size size5 = size1;
    lblPart2.Size = size5;
    this.lblPart.TabIndex = 4;
    this.lblPart.Text = "Part";
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(117, 490);
    Point point6 = point1;
    btnAdd1.Location = point6;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnAdd2.Size = size6;
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(222, 490);
    Point point7 = point1;
    btnDelete1.Location = point7;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnDelete2.Size = size7;
    this.btnDelete.TabIndex = 4;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(0, 39);
    Point point8 = point1;
    dataGridView1_1.Location = point8;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(442, 445);
    Size size8 = size1;
    dataGridView1_2.Size = size8;
    this.DataGridView1.TabIndex = 1;
    this.grpVisible.Controls.Add((Control) this.lblParType);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.lblPart);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(117, 513);
    Point point9 = point1;
    grpVisible1.Location = point9;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(99, 31 /*0x1F*/);
    Size size9 = size1;
    grpVisible2.Size = size9;
    this.grpVisible.TabIndex = 8;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle3.BackColor = SystemColors.Control;
    gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle3.ForeColor = SystemColors.WindowText;
    gridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle3.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle3;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle4.BackColor = SystemColors.Window;
    gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle4.ForeColor = SystemColors.ControlText;
    gridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle4.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle4;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(68, 11);
    Point point10 = point1;
    dataGridView2_1.Location = point10;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView2_2.Size = size10;
    this.DataGridView2.TabIndex = 9;
    TextBox txtSearchbox1 = this.txtSearchbox;
    point1 = new Point(0, 13);
    Point point11 = point1;
    txtSearchbox1.Location = point11;
    this.txtSearchbox.Name = "txtSearchbox";
    TextBox txtSearchbox2 = this.txtSearchbox;
    size1 = new Size(442, 20);
    Size size11 = size1;
    txtSearchbox2.Size = size11;
    this.txtSearchbox.TabIndex = 0;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(442, 546);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.txtSearchbox);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.btnSelect);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPartList);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "List Form";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnSelect
  {
    [DebuggerNonUserCode] get => this._btnSelect;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect_Click);
      if (this._btnSelect != null)
        this._btnSelect.Click -= eventHandler;
      this._btnSelect = value;
      if (this._btnSelect == null)
        return;
      this._btnSelect.Click += eventHandler;
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

  internal virtual Label lblParType
  {
    [DebuggerNonUserCode] get => this._lblParType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblParType = value;
    }
  }

  internal virtual Label lblPart
  {
    [DebuggerNonUserCode] get => this._lblPart;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblPart = value;
  }

  internal virtual Button btnAdd
  {
    [DebuggerNonUserCode] get => this._btnAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAdd_Click);
      if (this._btnAdd != null)
        this._btnAdd.Click -= eventHandler;
      this._btnAdd = value;
      if (this._btnAdd == null)
        return;
      this._btnAdd.Click += eventHandler;
    }
  }

  internal virtual Button btnDelete
  {
    [DebuggerNonUserCode] get => this._btnDelete;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnDelete_Click);
      if (this._btnDelete != null)
        this._btnDelete.Click -= eventHandler;
      this._btnDelete = value;
      if (this._btnDelete == null)
        return;
      this._btnDelete.Click += eventHandler;
    }
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView1_KeyDown);
      if (this._DataGridView1 != null)
        this._DataGridView1.KeyDown -= keyEventHandler;
      this._DataGridView1 = value;
      if (this._DataGridView1 == null)
        return;
      this._DataGridView1.KeyDown += keyEventHandler;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  internal virtual TextBox txtSearchbox
  {
    [DebuggerNonUserCode] get => this._txtSearchbox;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSearchbox_KeyDown);
      EventHandler eventHandler = new EventHandler(this.txtSearchbox_TextChanged);
      if (this._txtSearchbox != null)
      {
        this._txtSearchbox.KeyDown -= keyEventHandler;
        this._txtSearchbox.TextChanged -= eventHandler;
      }
      this._txtSearchbox = value;
      if (this._txtSearchbox == null)
        return;
      this._txtSearchbox.KeyDown += keyEventHandler;
      this._txtSearchbox.TextChanged += eventHandler;
    }
  }

  private void frmPartList_Load(object sender, EventArgs e)
  {
    this.lblPart.Text = "Part";
    this.grpVisible.Visible = false;
    this.GetFillGrid();
    this.GetFillSearchBox();
  }

  public DataSet GetFillGrid()
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocDesc WHERE SocDesc.ParType='{this.lblParType.Text}' order by SocDesc.Particular asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    DataTable dataTable = new DataTable("SocDesc");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.Text = this.lblParType.Text + " List ";
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.RowCount = 0;
    this.DataGridView1.ColumnCount = 3;
    this.DataGridView1.Columns[0].Visible = false;
    this.DataGridView1.Columns[2].Visible = false;
    this.DataGridView1.Columns[1].Width = 450;
    this.DataGridView1.ColumnHeadersVisible = false;
    this.DataGridView1.ClearSelection();
    DataSet fillGrid;
    return fillGrid;
  }

  public DataSet GetFillSearchBox()
  {
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.RowCount = 0;
    this.DataGridView1.ColumnCount = 3;
    this.DataGridView1.Columns[0].Visible = false;
    this.DataGridView1.Columns[2].Visible = false;
    this.DataGridView1.Columns[1].Width = 450;
    this.DataGridView1.ColumnHeadersVisible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchbox.Text, "", false) == 0)
    {
      int num = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView1.Rows.Add();
        this.DataGridView1.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value);
        this.DataGridView1.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[1].Value);
        this.DataGridView1.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[2].Value);
        checked { ++index; }
      }
      this.DataGridView1.ClearSelection();
    }
    else
    {
      int num = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(this.DataGridView2.Rows[index].Cells[1].Value.ToString().Trim(), 1, Strings.Len(this.txtSearchbox.Text)))) == 1)
        {
          this.DataGridView1.Rows.Add();
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[0].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value);
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[1].Value);
          this.DataGridView1.Rows[checked (this.DataGridView1.RowCount - 1)].Cells[2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[2].Value);
        }
        checked { ++index; }
      }
    }
    if (this.DataGridView1.RowCount == 1)
    {
      this.DataGridView1.Rows[0].Selected = true;
    }
    else
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView1.Rows[index].Selected = false;
        checked { ++index; }
      }
      this.DataGridView1.ClearSelection();
    }
    DataSet fillSearchBox;
    return fillSearchBox;
  }

  private void btnSelect_Click(object sender, EventArgs e)
  {
    if (this.DataGridView1.SelectedRows.Count == 1)
    {
      this.lblPart.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
      this.DataGridView1.ClearSelection();
    }
    this.Close();
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.lblPart.Text = "Part";
    this.Close();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    if (this.DataGridView1.SelectedRows.Count == 1)
    {
      OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Delete From SocDesc where Id =", this.DataGridView1.CurrentRow.Cells[0].Value), (object) "")), connection);
      connection.Open();
      oleDbCommand.ExecuteNonQuery();
      connection.Close();
    }
    this.lblPart.Text = "Part";
    this.GetFillGrid();
    this.GetFillSearchBox();
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmPathListAdd.ShowDialog();
    this.lblPart.Text = "Part";
    this.GetFillGrid();
    this.GetFillSearchBox();
  }

  private void txtSearchbox_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.Down && this.DataGridView1.RowCount > 0)
    {
      this.DataGridView1.Focus();
      this.DataGridView1.Rows[0].Selected = true;
    }
    if (e.KeyCode != Keys.Return)
      return;
    Constant.SearchStat = true;
    if (this.DataGridView1.RowCount > 0)
      this.txtSearchbox.Focus();
    if (this.DataGridView1.SelectedRows.Count == 1)
    {
      this.lblPart.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
      this.DataGridView1.ClearSelection();
      this.Close();
    }
  }

  private void txtSearchbox_TextChanged(object sender, EventArgs e) => this.GetFillSearchBox();

  private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    this.lblPart.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    this.DataGridView1.ClearSelection();
    this.Close();
  }
}
