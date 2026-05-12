// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMemBilling
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
public class frmMemBilling : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("cmbSearch")]
  private ComboBox _cmbSearch;
  [AccessedThroughProperty("txtSearch")]
  private TextBox _txtSearch;
  [AccessedThroughProperty("btnPrintRegister")]
  private Button _btnPrintRegister;
  [AccessedThroughProperty("lblTrType")]
  private Label _lblTrType;
  [AccessedThroughProperty("btnAutoBill")]
  private Button _btnAutoBill;
  [AccessedThroughProperty("btnMultiDelete")]
  private Button _btnMultiDelete;
  [AccessedThroughProperty("btnMultiChange")]
  private Button _btnMultiChange;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static frmMemBilling()
  {
  }

  [DebuggerNonUserCode]
  public frmMemBilling()
  {
    this.KeyDown += new KeyEventHandler(this.frmMemBilling_KeyDown);
    this.Load += new EventHandler(this.frmMemBilling_Load);
    frmMemBilling.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMemBilling.__ENCList)
    {
      if (frmMemBilling.__ENCList.Count == frmMemBilling.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMemBilling.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMemBilling.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMemBilling.__ENCList[index1] = frmMemBilling.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMemBilling.__ENCList.RemoveRange(index1, checked (frmMemBilling.__ENCList.Count - index1));
        frmMemBilling.__ENCList.Capacity = frmMemBilling.__ENCList.Count;
      }
      frmMemBilling.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMemBilling));
    this.btnExit = new Button();
    this.btnDelete = new Button();
    this.btnUpdate = new Button();
    this.btnAdd = new Button();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.GroupBox1 = new GroupBox();
    this.cmbSearch = new ComboBox();
    this.txtSearch = new TextBox();
    this.btnPrintRegister = new Button();
    this.lblTrType = new Label();
    this.btnAutoBill = new Button();
    this.btnMultiDelete = new Button();
    this.btnMultiChange = new Button();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.SuspendLayout();
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(885, 522);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 11;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(885, 138);
    Point point3 = point1;
    btnDelete1.Location = point3;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnDelete2.Size = size3;
    this.btnDelete.TabIndex = 3;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    this.btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(885, 81);
    Point point4 = point1;
    btnUpdate1.Location = point4;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnUpdate2.Size = size4;
    this.btnUpdate.TabIndex = 1;
    this.btnUpdate.Text = "A&lter";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(885, 24);
    Point point5 = point1;
    btnAdd1.Location = point5;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnAdd2.Size = size5;
    this.btnAdd.TabIndex = 0;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(887, 149);
    Point point6 = point1;
    dataGridView1_1.Location = point6;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 11);
    Size size6 = size1;
    dataGridView1_2.Size = size6;
    this.DataGridView1.TabIndex = 18;
    this.DataGridView1.TabStop = false;
    this.DataGridView2.AllowDrop = true;
    gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle.BackColor = SystemColors.Control;
    gridViewCellStyle.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle.ForeColor = SystemColors.WindowText;
    gridViewCellStyle.Padding = new Padding(2, 0, 0, 0);
    gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(0, 0);
    Point point7 = point1;
    dataGridView2_1.Location = point7;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(875, 570);
    Size size7 = size1;
    dataGridView2_2.Size = size7;
    this.DataGridView2.TabIndex = 12;
    this.GroupBox1.Controls.Add((Control) this.cmbSearch);
    this.GroupBox1.Controls.Add((Control) this.txtSearch);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(879, 208 /*0xD0*/);
    Point point8 = point1;
    groupBox1_1.Location = point8;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(113, 90);
    Size size8 = size1;
    groupBox1_2.Size = size8;
    this.GroupBox1.TabIndex = 4;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Search By";
    this.cmbSearch.FormattingEnabled = true;
    this.cmbSearch.Items.AddRange(new object[7]
    {
      (object) "Amount",
      (object) "Member Code",
      (object) "Member Name",
      (object) "Period",
      (object) "Particular1",
      (object) "Particular2",
      (object) "Bill No."
    });
    ComboBox cmbSearch1 = this.cmbSearch;
    point1 = new Point(6, 19);
    Point point9 = point1;
    cmbSearch1.Location = point9;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(102, 21);
    Size size9 = size1;
    cmbSearch2.Size = size9;
    this.cmbSearch.TabIndex = 5;
    TextBox txtSearch1 = this.txtSearch;
    point1 = new Point(6, 54);
    Point point10 = point1;
    txtSearch1.Location = point10;
    this.txtSearch.Name = "txtSearch";
    TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(102, 20);
    Size size10 = size1;
    txtSearch2.Size = size10;
    this.txtSearch.TabIndex = 6;
    this.btnPrintRegister.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new Point(885, 483);
    Point point11 = point1;
    btnPrintRegister1.Location = point11;
    this.btnPrintRegister.Name = "btnPrintRegister";
    Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(99, 33);
    Size size11 = size1;
    btnPrintRegister2.Size = size11;
    this.btnPrintRegister.TabIndex = 10;
    this.btnPrintRegister.Text = "&Print Register";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
    this.lblTrType.AutoSize = true;
    Label lblTrType1 = this.lblTrType;
    point1 = new Point(930, 148);
    Point point12 = point1;
    lblTrType1.Location = point12;
    this.lblTrType.Name = "lblTrType";
    Label lblTrType2 = this.lblTrType;
    size1 = new Size(39, 13);
    Size size12 = size1;
    lblTrType2.Size = size12;
    this.lblTrType.TabIndex = 33;
    this.lblTrType.Text = "Label1";
    this.btnAutoBill.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAutoBill1 = this.btnAutoBill;
    point1 = new Point(885, 317);
    Point point13 = point1;
    btnAutoBill1.Location = point13;
    this.btnAutoBill.Name = "btnAutoBill";
    Button btnAutoBill2 = this.btnAutoBill;
    size1 = new Size(99, 53);
    Size size13 = size1;
    btnAutoBill2.Size = size13;
    this.btnAutoBill.TabIndex = 7;
    this.btnAutoBill.Text = "A&uto Generate Bill";
    this.btnAutoBill.UseVisualStyleBackColor = true;
    this.btnMultiDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnMultiDelete1 = this.btnMultiDelete;
    point1 = new Point(887, 376);
    Point point14 = point1;
    btnMultiDelete1.Location = point14;
    this.btnMultiDelete.Name = "btnMultiDelete";
    Button btnMultiDelete2 = this.btnMultiDelete;
    size1 = new Size(99, 35);
    Size size14 = size1;
    btnMultiDelete2.Size = size14;
    this.btnMultiDelete.TabIndex = 8;
    this.btnMultiDelete.Text = "&Multi Delete";
    this.btnMultiDelete.UseVisualStyleBackColor = true;
    this.btnMultiChange.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnMultiChange1 = this.btnMultiChange;
    point1 = new Point(887, 417);
    Point point15 = point1;
    btnMultiChange1.Location = point15;
    this.btnMultiChange.Name = "btnMultiChange";
    Button btnMultiChange2 = this.btnMultiChange;
    size1 = new Size(99, 35);
    Size size15 = size1;
    btnMultiChange2.Size = size15;
    this.btnMultiChange.TabIndex = 9;
    this.btnMultiChange.Text = "Multi C&hange";
    this.btnMultiChange.UseVisualStyleBackColor = true;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(954, 523);
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
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnMultiChange);
    this.Controls.Add((Control) this.btnMultiDelete);
    this.Controls.Add((Control) this.btnAutoBill);
    this.Controls.Add((Control) this.btnPrintRegister);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.lblTrType);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMemBilling);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Bill List";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
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

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView2_KeyDown);
      DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.DataGridView2_CellDoubleClick);
      if (this._DataGridView2 != null)
      {
        this._DataGridView2.CellContentClick -= cellEventHandler1;
        this._DataGridView2.KeyDown -= keyEventHandler;
        this._DataGridView2.CellDoubleClick -= cellEventHandler2;
      }
      this._DataGridView2 = value;
      if (this._DataGridView2 == null)
        return;
      this._DataGridView2.CellContentClick += cellEventHandler1;
      this._DataGridView2.KeyDown += keyEventHandler;
      this._DataGridView2.CellDoubleClick += cellEventHandler2;
    }
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

  internal virtual Button btnPrintRegister
  {
    [DebuggerNonUserCode] get => this._btnPrintRegister;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrintRegister_Click);
      if (this._btnPrintRegister != null)
        this._btnPrintRegister.Click -= eventHandler;
      this._btnPrintRegister = value;
      if (this._btnPrintRegister == null)
        return;
      this._btnPrintRegister.Click += eventHandler;
    }
  }

  internal virtual Label lblTrType
  {
    [DebuggerNonUserCode] get => this._lblTrType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTrType = value;
    }
  }

  internal virtual Button btnAutoBill
  {
    [DebuggerNonUserCode] get => this._btnAutoBill;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAutoBill_Click);
      if (this._btnAutoBill != null)
        this._btnAutoBill.Click -= eventHandler;
      this._btnAutoBill = value;
      if (this._btnAutoBill == null)
        return;
      this._btnAutoBill.Click += eventHandler;
    }
  }

  internal virtual Button btnMultiDelete
  {
    [DebuggerNonUserCode] get => this._btnMultiDelete;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMultiDelete_Click);
      if (this._btnMultiDelete != null)
        this._btnMultiDelete.Click -= eventHandler;
      this._btnMultiDelete = value;
      if (this._btnMultiDelete == null)
        return;
      this._btnMultiDelete.Click += eventHandler;
    }
  }

  internal virtual Button btnMultiChange
  {
    [DebuggerNonUserCode] get => this._btnMultiChange;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnMultiChange_Click);
      if (this._btnMultiChange != null)
        this._btnMultiChange.Click -= eventHandler;
      this._btnMultiChange = value;
      if (this._btnMultiChange == null)
        return;
      this._btnMultiChange.Click += eventHandler;
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

  private void frmMemBilling_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmMemBilling_Load(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0)
    {
      this.btnAutoBill.Visible = true;
      this.btnMultiDelete.Visible = true;
      this.btnMultiChange.Visible = true;
    }
    else
    {
      this.btnAutoBill.Visible = false;
      this.btnMultiDelete.Visible = false;
      this.btnMultiChange.Visible = false;
    }
    this.txtSearch.Text = "";
    this.GetFillGrid();
    this.btnAdd.Focus();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='{this.lblTrType.Text}' and SocTran.MainAccount='Y' order by SocTran.SocTranNo asc", selectConnection);
    DataTable dataTable = new DataTable("SocTran");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Width = 100;
    this.DataGridView1.Columns[1].Width = 400;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.ColumnCount = 11;
    this.DataGridView2.Columns[5].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[6].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[7].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[5].ValueType = typeof (double);
    this.DataGridView2.Columns[6].ValueType = typeof (double);
    this.DataGridView2.Columns[7].ValueType = typeof (double);
    this.DataGridView2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView2.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index = 0;
    while (index <= num1)
    {
      this.DataGridView2.Rows.Add();
      this.DataGridView2.Rows[index].Cells[0].Value = (object) this.DataGridView1.Rows[index].Cells[7].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[1].Value = (object) Microsoft.VisualBasic.Strings.Mid(this.DataGridView1.Rows[index].Cells[8].Value.ToString().Trim(), 1, 10);
      this.DataGridView2.Rows[index].Cells[2].Value = (object) this.DataGridView1.Rows[index].Cells[10].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[3].Value = (object) this.DataGridView1.Rows[index].Cells[9].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[4].Value = (object) this.DataGridView1.Rows[index].Cells[20].Value.ToString().Trim();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
        this.DataGridView2.Rows[index].Cells[5].Value = (object) Conversion.Val(this.DataGridView1.Rows[index].Cells[12].Value.ToString().Trim());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
        this.DataGridView2.Rows[index].Cells[6].Value = (object) Conversion.Val(this.DataGridView1.Rows[index].Cells[11].Value.ToString().Trim());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
        this.DataGridView2.Rows[index].Cells[7].Value = (object) Conversion.Val(this.DataGridView1.Rows[index].Cells[13].Value.ToString().Trim());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
        this.DataGridView2.Rows[index].Cells[5].Value = (object) -Conversion.Val(this.DataGridView1.Rows[index].Cells[12].Value.ToString().Trim());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
        this.DataGridView2.Rows[index].Cells[6].Value = (object) -Conversion.Val(this.DataGridView1.Rows[index].Cells[11].Value.ToString().Trim());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
        this.DataGridView2.Rows[index].Cells[7].Value = (object) -Conversion.Val(this.DataGridView1.Rows[index].Cells[13].Value.ToString().Trim());
      this.DataGridView2.Rows[index].Cells[8].Value = (object) this.DataGridView1.Rows[index].Cells[24].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[9].Value = (object) this.DataGridView1.Rows[index].Cells[21].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[10].Value = (object) this.DataGridView1.Rows[index].Cells[22].Value.ToString().Trim();
      checked { ++index; }
    }
    this.DataGridView2.Columns[0].HeaderText = "No.";
    this.DataGridView2.Columns[1].HeaderText = "Date";
    this.DataGridView2.Columns[2].HeaderText = "Mem Code";
    this.DataGridView2.Columns[3].HeaderText = "Mem.Name";
    this.DataGridView2.Columns[4].HeaderText = "Period";
    this.DataGridView2.Columns[5].HeaderText = "Principal";
    this.DataGridView2.Columns[6].HeaderText = "Interest";
    this.DataGridView2.Columns[7].HeaderText = "Total";
    this.DataGridView2.Columns[8].HeaderText = "Due Date";
    this.DataGridView2.Columns[9].HeaderText = "Particular1";
    this.DataGridView2.Columns[10].HeaderText = "Particular2";
    this.DataGridView2.ClearSelection();
    this.DataGridView2.Columns[0].Width = 70;
    this.DataGridView2.Columns[1].Width = 70;
    this.DataGridView2.Columns[2].Width = 70;
    this.DataGridView2.Columns[3].Width = 200;
    this.DataGridView2.Columns[4].Width = 150;
    this.DataGridView2.Columns[5].Width = 70;
    this.DataGridView2.Columns[6].Width = 70;
    this.DataGridView2.Columns[7].Width = 70;
    this.DataGridView2.Columns[8].Width = 70;
    this.DataGridView2.Columns[9].Width = 200;
    this.DataGridView2.Columns[10].Width = 200;
    if (this.DataGridView2.RowCount == 0)
    {
      int num2 = (int) Interaction.MsgBox((object) "No Record");
      this.btnUpdate.Enabled = false;
      this.btnDelete.Enabled = false;
    }
    else
    {
      this.btnUpdate.Enabled = true;
      this.btnDelete.Enabled = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "4", false) == 0)
    {
      this.btnDelete.Enabled = false;
      this.btnMultiChange.Enabled = false;
      this.btnMultiDelete.Enabled = false;
    }
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    frmMemBilldetail frmMemBilldetail = new frmMemBilldetail();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0)
    {
      frmMemBilldetail.lblType.Text = "MBil";
      frmMemBilldetail.Text = " Member Bill Add ";
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
    {
      frmMemBilldetail.lblType.Text = "MDbn";
      frmMemBilldetail.Text = " Member Debit Note Add ";
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
    {
      frmMemBilldetail.lblType.Text = "MCrn";
      frmMemBilldetail.Text = " Member Credit Note Add ";
    }
    frmMemBilldetail.btnSave.Text = "&Save";
    frmMemBilldetail.txtNo.Text = this.DataGridView1.RowCount <= 0 ? Conversions.ToString(0) : Conversions.ToString(this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
    int num = (int) frmMemBilldetail.ShowDialog();
    this.GetFillGrid();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0)
      MyProject.Forms.frmAlterNo.Text = "Enter Member Bill No.";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
      MyProject.Forms.frmAlterNo.Text = "Enter Member Debit Note No.";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
      MyProject.Forms.frmAlterNo.Text = "Enter Member Credit Note No.";
    int num1 = (int) MyProject.Forms.frmAlterNo.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmAlterNo.lblBtnStatus.Text, "Y", false) == 0)
    {
      int num2 = -1;
      frmMemBilldetail frmMemBilldetail = new frmMemBilldetail();
      int num3 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num3)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, (object) Conversion.Val(MyProject.Forms.frmAlterNo.txtNo.Text.ToString()), false))
          num2 = index;
        checked { ++index; }
      }
      if (num2 != -1)
      {
        this.DataGridView1.Rows[num2].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[7, num2];
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0)
        {
          frmMemBilldetail.lblType.Text = "MBil";
          frmMemBilldetail.Text = " Member Bill Update";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
        {
          frmMemBilldetail.lblType.Text = "MDbn";
          frmMemBilldetail.Text = " Member Debit Note Update";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
        {
          frmMemBilldetail.lblType.Text = "MCrn";
          frmMemBilldetail.Text = " Member Credit Note Update";
        }
        frmMemBilldetail.btnSave.Text = "&Update";
        int num4 = (int) frmMemBilldetail.ShowDialog();
      }
      else
      {
        int num5 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
      }
      this.GetFillGrid();
    }
    MyProject.Forms.frmAlterNo = (frmAlterNo) null;
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      frmMemBilldetail frmMemBilldetail = new frmMemBilldetail();
      int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
      int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
      int num1 = -1;
      int num2 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num2)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.CurrentRow.Cells[0].Value)), false))
          num1 = index;
        checked { ++index; }
      }
      if (num1 != -1)
      {
        this.DataGridView1.Rows[num1].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[7, num1];
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0)
        {
          frmMemBilldetail.lblType.Text = "MBil";
          frmMemBilldetail.Text = " Member Bill Delete";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
        {
          frmMemBilldetail.lblType.Text = "MDbn";
          frmMemBilldetail.Text = " Member Debit Note Delete";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
        {
          frmMemBilldetail.lblType.Text = "MCrn";
          frmMemBilldetail.Text = " Member Credit Note Delete";
        }
        frmMemBilldetail.btnSave.Text = "&Delete";
        int num3 = (int) frmMemBilldetail.ShowDialog();
      }
      else
      {
        int num4 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
      }
      this.GetFillGrid();
      this.DataGridView2.Focus();
      if (rowIndex <= checked (this.DataGridView2.RowCount - 1))
      {
        this.DataGridView2.Rows[rowIndex].Cells[columnIndex].Selected = true;
        this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, rowIndex];
      }
      else
      {
        this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[columnIndex].Selected = true;
        this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, checked (this.DataGridView2.RowCount - 1)];
      }
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0)
        MyProject.Forms.frmAlterNo.Text = "Enter Member Bill No.";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
        MyProject.Forms.frmAlterNo.Text = "Enter Member Debit Note No.";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
        MyProject.Forms.frmAlterNo.Text = "Enter Member Credit Note No.";
      int num5 = (int) MyProject.Forms.frmAlterNo.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmAlterNo.lblBtnStatus.Text, "Y", false) == 0)
      {
        frmMemBilldetail frmMemBilldetail = new frmMemBilldetail();
        int num6 = -1;
        int num7 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num7)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, (object) Conversion.Val(MyProject.Forms.frmAlterNo.txtNo.Text.ToString()), false))
            num6 = index;
          checked { ++index; }
        }
        if (num6 != -1)
        {
          this.DataGridView1.Rows[num6].Selected = true;
          this.DataGridView1.CurrentCell = this.DataGridView1[7, num6];
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0)
          {
            frmMemBilldetail.lblType.Text = "MBil";
            frmMemBilldetail.Text = " Member Bill Delete";
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
          {
            frmMemBilldetail.lblType.Text = "MDbn";
            frmMemBilldetail.Text = " Member Debit Note Delete";
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
          {
            frmMemBilldetail.lblType.Text = "MCrn";
            frmMemBilldetail.Text = " Member Credit Note Delete";
          }
          frmMemBilldetail.btnSave.Text = "&Delete";
          int num8 = (int) frmMemBilldetail.ShowDialog();
        }
        else
        {
          int num9 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
        }
        this.GetFillGrid();
      }
      MyProject.Forms.frmAlterNo = (frmAlterNo) null;
    }
  }

  private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.cmbSearch.SelectedIndex == 0)
      this.cmpColumnNo = 13;
    if (this.cmbSearch.SelectedIndex == 1)
      this.cmpColumnNo = 10;
    if (this.cmbSearch.SelectedIndex == 2)
      this.cmpColumnNo = 9;
    if (this.cmbSearch.SelectedIndex == 3)
      this.cmpColumnNo = 20;
    if (this.cmbSearch.SelectedIndex == 4)
      this.cmpColumnNo = 21;
    if (this.cmbSearch.SelectedIndex == 5)
      this.cmpColumnNo = 22;
    if (this.cmbSearch.SelectedIndex != 6)
      return;
    this.cmpColumnNo = 7;
  }

  private void txtSearch_TextChanged(object sender, EventArgs e)
  {
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 11;
    this.DataGridView2.RowCount = 0;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) == 0)
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView2.Rows.Add();
        this.DataGridView2.Rows[index].Cells[0].Value = (object) this.DataGridView1.Rows[index].Cells[7].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[8].Value);
        this.DataGridView2.Rows[index].Cells[2].Value = (object) this.DataGridView1.Rows[index].Cells[10].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[3].Value = (object) this.DataGridView1.Rows[index].Cells[9].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[4].Value = (object) this.DataGridView1.Rows[index].Cells[20].Value.ToString().Trim();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
          this.DataGridView2.Rows[index].Cells[5].Value = (object) Conversion.Val(this.DataGridView1.Rows[index].Cells[12].Value.ToString().Trim());
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
          this.DataGridView2.Rows[index].Cells[6].Value = (object) Conversion.Val(this.DataGridView1.Rows[index].Cells[11].Value.ToString().Trim());
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
          this.DataGridView2.Rows[index].Cells[7].Value = (object) Conversion.Val(this.DataGridView1.Rows[index].Cells[13].Value.ToString().Trim());
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index].Cells[5].Value = (object) -Conversion.Val(this.DataGridView1.Rows[index].Cells[12].Value.ToString().Trim());
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index].Cells[6].Value = (object) -Conversion.Val(this.DataGridView1.Rows[index].Cells[11].Value.ToString().Trim());
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
          this.DataGridView2.Rows[index].Cells[7].Value = (object) -Conversion.Val(this.DataGridView1.Rows[index].Cells[13].Value.ToString().Trim());
        this.DataGridView2.Rows[index].Cells[8].Value = (object) this.DataGridView1.Rows[index].Cells[24].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[9].Value = (object) this.DataGridView1.Rows[index].Cells[21].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[10].Value = (object) this.DataGridView1.Rows[index].Cells[22].Value.ToString().Trim();
        checked { ++index; }
      }
    }
    else
    {
      int index1 = 0;
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index2 = 0;
      while (index2 <= num1)
      {
        int num2 = Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index2].Cells[this.cmpColumnNo].Value.ToString().Trim());
        int Start = 1;
        while (Start <= num2)
        {
          if (Microsoft.VisualBasic.Strings.InStr(Microsoft.VisualBasic.Strings.UCase(Microsoft.VisualBasic.Strings.Mid(this.DataGridView1.Rows[index2].Cells[this.cmpColumnNo].Value.ToString().Trim(), Start, Microsoft.VisualBasic.Strings.Len(this.txtSearch.Text.Trim()))), Microsoft.VisualBasic.Strings.UCase(Microsoft.VisualBasic.Strings.Trim(this.txtSearch.Text.Trim()))) == 1)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index1].Cells[0].Value = (object) this.DataGridView1.Rows[index2].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[1].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index2].Cells[8].Value);
            this.DataGridView2.Rows[index1].Cells[2].Value = (object) this.DataGridView1.Rows[index2].Cells[10].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[3].Value = (object) this.DataGridView1.Rows[index2].Cells[9].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[4].Value = (object) this.DataGridView1.Rows[index2].Cells[20].Value.ToString().Trim();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
              this.DataGridView2.Rows[index1].Cells[5].Value = (object) Conversion.Val(this.DataGridView1.Rows[index2].Cells[12].Value.ToString().Trim());
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
              this.DataGridView2.Rows[index1].Cells[6].Value = (object) Conversion.Val(this.DataGridView1.Rows[index2].Cells[11].Value.ToString().Trim());
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
              this.DataGridView2.Rows[index1].Cells[7].Value = (object) Conversion.Val(this.DataGridView1.Rows[index2].Cells[13].Value.ToString().Trim());
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
              this.DataGridView2.Rows[index1].Cells[5].Value = (object) -Conversion.Val(this.DataGridView1.Rows[index2].Cells[12].Value.ToString().Trim());
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
              this.DataGridView2.Rows[index1].Cells[6].Value = (object) -Conversion.Val(this.DataGridView1.Rows[index2].Cells[11].Value.ToString().Trim());
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
              this.DataGridView2.Rows[index1].Cells[7].Value = (object) -Conversion.Val(this.DataGridView1.Rows[index2].Cells[13].Value.ToString().Trim());
            this.DataGridView2.Rows[index1].Cells[8].Value = (object) this.DataGridView1.Rows[index2].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[9].Value = (object) this.DataGridView1.Rows[index2].Cells[21].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[10].Value = (object) this.DataGridView1.Rows[index2].Cells[22].Value.ToString().Trim();
            checked { ++index1; }
          }
          checked { ++Start; }
        }
        checked { ++index2; }
      }
    }
    this.DataGridView2.Columns[0].HeaderText = "No.";
    this.DataGridView2.Columns[1].HeaderText = "Date";
    this.DataGridView2.Columns[2].HeaderText = "Mem Code";
    this.DataGridView2.Columns[3].HeaderText = "Mem.Name";
    this.DataGridView2.Columns[4].HeaderText = "Period";
    this.DataGridView2.Columns[5].HeaderText = "Principal";
    this.DataGridView2.Columns[6].HeaderText = "Interest";
    this.DataGridView2.Columns[7].HeaderText = "Total";
    this.DataGridView2.Columns[8].HeaderText = "Due Date";
    this.DataGridView2.Columns[9].HeaderText = "Particular1";
    this.DataGridView2.Columns[10].HeaderText = "Particular2";
    this.DataGridView2.ClearSelection();
  }

  private void btnPrintRegister_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportMemberBillRegisterNew.lblType.Text = this.lblTrType.Text;
    int num = (int) MyProject.Forms.frmReportMemberBillRegisterNew.ShowDialog();
    MyProject.Forms.frmReportMemberBillRegisterNew = (frmReportMemberBillRegisterNew) null;
  }

  private void btnAutoBill_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmAutoBill.txtBillNo.Text = this.DataGridView1.RowCount <= 0 ? Conversions.ToString(1) : Conversions.ToString(checked (this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max() + 1));
    int num = (int) MyProject.Forms.frmAutoBill.ShowDialog();
    MyProject.Forms.frmAutoBill = (frmAutoBill) null;
    this.GetFillGrid();
  }

  private void btnMultiDelete_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmAutoBillDelete.lblTitle.Text = "Auto Bill Delete";
    MyProject.Forms.frmAutoBillDelete.lblType.Text = "MBil";
    int num = (int) MyProject.Forms.frmAutoBillDelete.ShowDialog();
    MyProject.Forms.frmAutoBillDelete = (frmAutoBillDelete) null;
    this.GetFillGrid();
  }

  private void btnMultiChange_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmAutoBillChange.ShowDialog();
    MyProject.Forms.frmAutoBillChange = (frmAutoBillChange) null;
    this.GetFillGrid();
  }

  private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    frmMemBilldetail frmMemBilldetail = new frmMemBilldetail();
    int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num2;
      while (index <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[0].Value, false))
          num2 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num2].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[7, num2];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0)
      {
        frmMemBilldetail.lblType.Text = "MBil";
        frmMemBilldetail.Text = " Member Bill Update";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
      {
        frmMemBilldetail.lblType.Text = "MDbn";
        frmMemBilldetail.Text = " Member Debit Note Update";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
      {
        frmMemBilldetail.lblType.Text = "MCrn";
        frmMemBilldetail.Text = " Member Credit Note Update";
      }
      frmMemBilldetail.btnSave.Text = "&Update";
      int num3 = (int) frmMemBilldetail.ShowDialog();
    }
    else
    {
      int num = (int) Interaction.MsgBox((object) "Please Select the record");
    }
    this.GetFillGrid();
    this.DataGridView2.Focus();
    this.DataGridView2.Rows[rowIndex].Cells[columnIndex].Selected = true;
    this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, rowIndex];
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void DataGridView2_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    e.SuppressKeyPress = true;
    frmMemBilldetail frmMemBilldetail = new frmMemBilldetail();
    int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num2;
      while (index <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[0].Value, false))
          num2 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num2].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[7, num2];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MBil", false) == 0)
      {
        frmMemBilldetail.lblType.Text = "MBil";
        frmMemBilldetail.Text = " Member Bill Update";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MDbn", false) == 0)
      {
        frmMemBilldetail.lblType.Text = "MDbn";
        frmMemBilldetail.Text = " Member Debit Note Update";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MCrn", false) == 0)
      {
        frmMemBilldetail.lblType.Text = "MCrn";
        frmMemBilldetail.Text = " Member Credit Note Update";
      }
      frmMemBilldetail.btnSave.Text = "&Update";
      int num3 = (int) frmMemBilldetail.ShowDialog();
    }
    else
    {
      int num = (int) Interaction.MsgBox((object) "Please Select the record");
    }
    this.GetFillGrid();
    this.DataGridView2.Focus();
    this.DataGridView2.Rows[rowIndex].Cells[columnIndex].Selected = true;
    this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, rowIndex];
  }

  private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
  }
}
