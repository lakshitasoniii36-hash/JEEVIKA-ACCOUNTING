// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMemReceipt
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
public class frmMemReceipt : Form
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
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("cmbSearch")]
  private ComboBox _cmbSearch;
  [AccessedThroughProperty("txtSearch")]
  private TextBox _txtSearch;
  [AccessedThroughProperty("btnPrintRegister")]
  private Button _btnPrintRegister;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("lblTrType")]
  private Label _lblTrType;
  [AccessedThroughProperty("btnPrintVoucher")]
  private Button _btnPrintVoucher;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("btnMultiDelete")]
  private Button _btnMultiDelete;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static frmMemReceipt()
  {
  }

  [DebuggerNonUserCode]
  public frmMemReceipt()
  {
    this.Load += new EventHandler(this.frmMemReceipt_Load);
    this.KeyDown += new KeyEventHandler(this.frmMemReceipt_KeyDown);
    frmMemReceipt.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMemReceipt.__ENCList)
    {
      if (frmMemReceipt.__ENCList.Count == frmMemReceipt.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMemReceipt.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMemReceipt.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMemReceipt.__ENCList[index1] = frmMemReceipt.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMemReceipt.__ENCList.RemoveRange(index1, checked (frmMemReceipt.__ENCList.Count - index1));
        frmMemReceipt.__ENCList.Capacity = frmMemReceipt.__ENCList.Count;
      }
      frmMemReceipt.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMemReceipt));
    this.btnExit = new Button();
    this.btnDelete = new Button();
    this.btnUpdate = new Button();
    this.btnAdd = new Button();
    this.DataGridView1 = new DataGridView();
    this.GroupBox1 = new GroupBox();
    this.cmbSearch = new ComboBox();
    this.txtSearch = new TextBox();
    this.btnPrintRegister = new Button();
    this.DataGridView2 = new DataGridView();
    this.lblTrType = new Label();
    this.btnPrintVoucher = new Button();
    this.GroupBox2 = new GroupBox();
    this.btnMultiDelete = new Button();
    this.GroupBox3 = new GroupBox();
    this.grpVisible = new GroupBox();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GroupBox2.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(884, 497);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 10;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(6, 97);
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
    point1 = new Point(6, 58);
    Point point4 = point1;
    btnUpdate1.Location = point4;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnUpdate2.Size = size4;
    this.btnUpdate.TabIndex = 2;
    this.btnUpdate.Text = "A&lter";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(6, 19);
    Point point5 = point1;
    btnAdd1.Location = point5;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnAdd2.Size = size5;
    this.btnAdd.TabIndex = 1;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(0, 0);
    Point point6 = point1;
    dataGridView1_1.Location = point6;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(856, 196);
    Size size6 = size1;
    dataGridView1_2.Size = size6;
    this.DataGridView1.TabIndex = 18;
    this.GroupBox1.Controls.Add((Control) this.cmbSearch);
    this.GroupBox1.Controls.Add((Control) this.txtSearch);
    this.GroupBox1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(877, 233);
    Point point7 = point1;
    groupBox1_1.Location = point7;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(110, 90);
    Size size7 = size1;
    groupBox1_2.Size = size7;
    this.GroupBox1.TabIndex = 4;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Search By";
    this.cmbSearch.FormattingEnabled = true;
    this.cmbSearch.Items.AddRange(new object[8]
    {
      (object) "Amount",
      (object) "Cheque No.",
      (object) "Bank Name",
      (object) "Member Name",
      (object) "Flat No.",
      (object) "Particular",
      (object) "Cash/Bank",
      (object) "Receipt No."
    });
    ComboBox cmbSearch1 = this.cmbSearch;
    point1 = new Point(6, 19);
    Point point8 = point1;
    cmbSearch1.Location = point8;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(102, 21);
    Size size8 = size1;
    cmbSearch2.Size = size8;
    this.cmbSearch.TabIndex = 5;
    TextBox txtSearch1 = this.txtSearch;
    point1 = new Point(6, 54);
    Point point9 = point1;
    txtSearch1.Location = point9;
    this.txtSearch.Name = "txtSearch";
    TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(102, 20);
    Size size9 = size1;
    txtSearch2.Size = size9;
    this.txtSearch.TabIndex = 6;
    this.btnPrintRegister.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new Point(6, 32 /*0x20*/);
    Point point10 = point1;
    btnPrintRegister1.Location = point10;
    this.btnPrintRegister.Name = "btnPrintRegister";
    Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(99, 33);
    Size size10 = size1;
    btnPrintRegister2.Size = size10;
    this.btnPrintRegister.TabIndex = 8;
    this.btnPrintRegister.Text = "&Print Register";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
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
    Point point11 = point1;
    dataGridView2_1.Location = point11;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(871, 566);
    Size size11 = size1;
    dataGridView2_2.Size = size11;
    this.DataGridView2.TabIndex = 11;
    this.lblTrType.AutoSize = true;
    Label lblTrType1 = this.lblTrType;
    point1 = new Point(6, 16 /*0x10*/);
    Point point12 = point1;
    lblTrType1.Location = point12;
    this.lblTrType.Name = "lblTrType";
    Label lblTrType2 = this.lblTrType;
    size1 = new Size(39, 13);
    Size size12 = size1;
    lblTrType2.Size = size12;
    this.lblTrType.TabIndex = 32 /*0x20*/;
    this.lblTrType.Text = "Label1";
    this.btnPrintVoucher.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrintVoucher1 = this.btnPrintVoucher;
    point1 = new Point(5, 86);
    Point point13 = point1;
    btnPrintVoucher1.Location = point13;
    this.btnPrintVoucher.Name = "btnPrintVoucher";
    Button btnPrintVoucher2 = this.btnPrintVoucher;
    size1 = new Size(99, 33);
    Size size13 = size1;
    btnPrintVoucher2.Size = size13;
    this.btnPrintVoucher.TabIndex = 9;
    this.btnPrintVoucher.Text = "Print &Receipt";
    this.btnPrintVoucher.UseVisualStyleBackColor = true;
    this.GroupBox2.Controls.Add((Control) this.btnMultiDelete);
    this.GroupBox2.Controls.Add((Control) this.btnAdd);
    this.GroupBox2.Controls.Add((Control) this.btnUpdate);
    this.GroupBox2.Controls.Add((Control) this.btnDelete);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(878, 12);
    Point point14 = point1;
    groupBox2_1.Location = point14;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(110, 184);
    Size size14 = size1;
    groupBox2_2.Size = size14;
    this.GroupBox2.TabIndex = 0;
    this.GroupBox2.TabStop = false;
    this.btnMultiDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnMultiDelete1 = this.btnMultiDelete;
    point1 = new Point(6, 136);
    Point point15 = point1;
    btnMultiDelete1.Location = point15;
    this.btnMultiDelete.Name = "btnMultiDelete";
    Button btnMultiDelete2 = this.btnMultiDelete;
    size1 = new Size(99, 33);
    Size size15 = size1;
    btnMultiDelete2.Size = size15;
    this.btnMultiDelete.TabIndex = 4;
    this.btnMultiDelete.Text = "&Multi Delete";
    this.btnMultiDelete.UseVisualStyleBackColor = true;
    this.GroupBox3.Controls.Add((Control) this.btnPrintRegister);
    this.GroupBox3.Controls.Add((Control) this.btnPrintVoucher);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(878, 330);
    Point point16 = point1;
    groupBox3_1.Location = point16;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(110, 140);
    Size size16 = size1;
    groupBox3_2.Size = size16;
    this.GroupBox3.TabIndex = 7;
    this.GroupBox3.TabStop = false;
    this.grpVisible.Controls.Add((Control) this.lblTrType);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(908, 530);
    Point point17 = point1;
    grpVisible1.Location = point17;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(55, 36);
    Size size17 = size1;
    grpVisible2.Size = size17;
    this.grpVisible.TabIndex = 36;
    this.grpVisible.TabStop = false;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(749, 271);
    Point point18 = point1;
    button2_1.Location = point18;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size18 = size1;
    button2_2.Size = size18;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMemReceipt);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Receipt List";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox3.ResumeLayout(false);
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.ResumeLayout(false);
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView2_KeyDown);
      DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView2_CellDoubleClick);
      if (this._DataGridView2 != null)
      {
        this._DataGridView2.KeyDown -= keyEventHandler;
        this._DataGridView2.CellDoubleClick -= cellEventHandler;
      }
      this._DataGridView2 = value;
      if (this._DataGridView2 == null)
        return;
      this._DataGridView2.KeyDown += keyEventHandler;
      this._DataGridView2.CellDoubleClick += cellEventHandler;
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

  internal virtual Button btnPrintVoucher
  {
    [DebuggerNonUserCode] get => this._btnPrintVoucher;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrintVoucher_Click);
      if (this._btnPrintVoucher != null)
        this._btnPrintVoucher.Click -= eventHandler;
      this._btnPrintVoucher = value;
      if (this._btnPrintVoucher == null)
        return;
      this._btnPrintVoucher.Click += eventHandler;
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

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
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

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MJnl", false) != 0 ? new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranType)='{this.lblTrType.Text}') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", selectConnection) : new OleDbDataAdapter($"SELECT * FROM SocTran INNER JOIN SocMember ON SocTran.SocAccountMainId = SocMember.SocAccountMainId WHERE (((SocTran.SocTranType)='{this.lblTrType.Text}') AND ((SocTran.MainAccount)='Y')) ORDER BY SocTran.SocTranNo", selectConnection);
    DataTable dataTable = new DataTable("SocTran");
    oleDbDataAdapter2.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.ColumnCount = 14;
    this.DataGridView2.Columns[5].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[5].ValueType = typeof (double);
    this.DataGridView2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index = 0;
    while (index <= num1)
    {
      this.DataGridView2.Rows.Add();
      this.DataGridView2.Rows[index].Cells[0].Value = (object) this.DataGridView1.Rows[index].Cells[7].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[1].Value = (object) this.DataGridView1.Rows[index].Cells[8].Value.ToString().Substring(0, 10);
      this.DataGridView2.Rows[index].Cells[2].Value = (object) this.DataGridView1.Rows[index].Cells[9].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[3].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MJnl", false) != 0 ? (object) this.DataGridView1.Rows[index].Cells[10].Value.ToString().Trim() : (object) this.DataGridView1.Rows[index].Cells[31 /*0x1F*/].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[4].Value = (object) this.DataGridView1.Rows[index].Cells[38].Value.ToString().Trim();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
        this.DataGridView2.Rows[index].Cells[5].Value = (object) Conversion.Val(this.DataGridView1.Rows[index].Cells[13].Value.ToString().Trim());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
        this.DataGridView2.Rows[index].Cells[5].Value = (object) -Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[13].Value));
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MJnl", false) == 0)
        this.DataGridView2.Rows[index].Cells[5].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index].Cells[13].Value));
      this.DataGridView2.Rows[index].Cells[6].Value = (object) this.DataGridView1.Rows[index].Cells[16 /*0x10*/].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[7].Value = (object) this.DataGridView1.Rows[index].Cells[17].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[8].Value = (object) this.DataGridView1.Rows[index].Cells[18].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[9].Value = (object) this.DataGridView1.Rows[index].Cells[19].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[10].Value = (object) this.DataGridView1.Rows[index].Cells[20].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[11].Value = (object) this.DataGridView1.Rows[index].Cells[21].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[12].Value = (object) this.DataGridView1.Rows[index].Cells[22].Value.ToString().Trim();
      this.DataGridView2.Rows[index].Cells[13].Value = (object) this.DataGridView1.Rows[index].Cells[15].Value.ToString().Trim();
      checked { ++index; }
    }
    this.DataGridView2.Columns[0].HeaderText = "No.";
    this.DataGridView2.Columns[1].HeaderText = "Date";
    this.DataGridView2.Columns[2].HeaderText = "Cash/Bank";
    this.DataGridView2.Columns[3].HeaderText = "Flat No";
    this.DataGridView2.Columns[4].HeaderText = "Mem.Name";
    this.DataGridView2.Columns[5].HeaderText = "Amount";
    this.DataGridView2.Columns[6].HeaderText = "Chq. No.";
    this.DataGridView2.Columns[7].HeaderText = "Chq.Date";
    this.DataGridView2.Columns[8].HeaderText = "Bank";
    this.DataGridView2.Columns[9].HeaderText = "Bill No.";
    this.DataGridView2.Columns[10].HeaderText = "Particular1";
    this.DataGridView2.Columns[11].HeaderText = "Particular2";
    this.DataGridView2.Columns[12].HeaderText = "Particular3";
    this.DataGridView2.Columns[13].HeaderText = "Clear Date";
    this.DataGridView2.Columns[0].Width = 70;
    this.DataGridView2.Columns[1].Width = 70;
    this.DataGridView2.Columns[2].Width = 200;
    this.DataGridView2.Columns[3].Width = 100;
    this.DataGridView2.Columns[4].Width = 200;
    this.DataGridView2.Columns[5].Width = 100;
    this.DataGridView2.Columns[6].Width = 100;
    this.DataGridView2.Columns[13].Width = 110;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MJnl", false) == 0)
      this.DataGridView2.Columns[2].Visible = false;
    this.DataGridView2.ClearSelection();
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
      this.btnMultiDelete.Enabled = false;
    }
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void frmMemReceipt_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmMemReceipt_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.txtSearch.Text = "";
    this.GetFillGrid();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
      this.btnPrintVoucher.Visible = false;
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MJnl", false) == 0)
    {
      this.btnMultiDelete.Visible = false;
      this.btnPrintRegister.Visible = false;
      this.btnPrintVoucher.Visible = false;
      this.GroupBox1.Visible = false;
    }
    else
    {
      this.btnMultiDelete.Visible = true;
      this.btnPrintRegister.Visible = true;
      this.btnPrintVoucher.Visible = true;
      this.GroupBox1.Visible = true;
    }
    this.btnAdd.Focus();
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "Y", false) == 0)
    {
      frmMemReceiptDetailBif receiptDetailBif = new frmMemReceiptDetailBif();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
      {
        receiptDetailBif.lblType.Text = "MRct";
        receiptDetailBif.Text = " Member Receipt (Bifurcation) Add ";
        receiptDetailBif.lblTranStat.Text = "No";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
      {
        receiptDetailBif.lblType.Text = "MAdj";
        receiptDetailBif.Text = " Member Adjustment Add ";
        receiptDetailBif.lblTranStat.Text = "Yes";
      }
      receiptDetailBif.btnSave.Text = "&Save";
      receiptDetailBif.txtNo.Text = this.DataGridView1.RowCount <= 0 ? Conversions.ToString(0) : Conversions.ToString(this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
      int num = (int) receiptDetailBif.ShowDialog();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MJnl", false) == 0)
    {
      frmMemberJournalDetail memberJournalDetail = new frmMemberJournalDetail();
      memberJournalDetail.Text = " Member Journal Add ";
      memberJournalDetail.btnSave.Text = "&Save";
      memberJournalDetail.txtNo.Text = this.DataGridView1.RowCount <= 0 ? Conversions.ToString(0) : Conversions.ToString(this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
      memberJournalDetail.btnAddGrid.Visible = true;
      memberJournalDetail.btnUpdateGrid.Visible = false;
      memberJournalDetail.btnDeleteGrid.Visible = false;
      int num = (int) memberJournalDetail.ShowDialog();
    }
    else
    {
      frmMemReceiptDetail memReceiptDetail = new frmMemReceiptDetail();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
      {
        memReceiptDetail.lblType.Text = "MRct";
        memReceiptDetail.Text = " Member Receipt Add ";
        memReceiptDetail.lblTranStat.Text = "No";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
      {
        memReceiptDetail.lblType.Text = "MAdj";
        memReceiptDetail.Text = " Member Adjustment Add ";
        memReceiptDetail.lblTranStat.Text = "Yes";
      }
      memReceiptDetail.btnSave.Text = "&Save";
      memReceiptDetail.txtNo.Text = this.DataGridView1.RowCount <= 0 ? Conversions.ToString(0) : Conversions.ToString(this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
      int num = (int) memReceiptDetail.ShowDialog();
    }
    this.GetFillGrid();
    this.btnAdd.Focus();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
      MyProject.Forms.frmAlterNo.Text = "Enter Member Receipt No.";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
      MyProject.Forms.frmAlterNo.Text = "Enter Member Adjustment No.";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MJnl", false) == 0)
      MyProject.Forms.frmAlterNo.Text = "Enter Member Journal No.";
    int num1 = (int) MyProject.Forms.frmAlterNo.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmAlterNo.lblBtnStatus.Text, "Y", false) == 0)
    {
      int num2 = -1;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "Y", false) == 0)
      {
        frmMemReceiptDetailBif receiptDetailBif = new frmMemReceiptDetailBif();
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
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
          {
            receiptDetailBif.lblType.Text = "MRct";
            receiptDetailBif.Text = " Member Receipt Update ";
            receiptDetailBif.lblTranStat.Text = "No";
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
          {
            receiptDetailBif.lblType.Text = "MAdj";
            receiptDetailBif.Text = " Member Adjustment Update ";
            receiptDetailBif.lblTranStat.Text = "No";
          }
          receiptDetailBif.btnSave.Text = "&Update";
          int num4 = (int) receiptDetailBif.ShowDialog();
        }
        else
        {
          int num5 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
        }
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MJnl", false) == 0)
      {
        frmMemberJournalDetail memberJournalDetail = new frmMemberJournalDetail();
        int num6 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num6)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, (object) Conversion.Val(MyProject.Forms.frmAlterNo.txtNo.Text.ToString()), false))
            num2 = index;
          checked { ++index; }
        }
        if (num2 != -1)
        {
          this.DataGridView1.Rows[num2].Selected = true;
          this.DataGridView1.CurrentCell = this.DataGridView1[7, num2];
          memberJournalDetail.Text = " Member Journal Update ";
          memberJournalDetail.btnSave.Text = "&Update";
          int num7 = (int) memberJournalDetail.ShowDialog();
        }
        else
        {
          int num8 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
        }
      }
      else
      {
        frmMemReceiptDetail memReceiptDetail = new frmMemReceiptDetail();
        int num9 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num9)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, (object) Conversion.Val(MyProject.Forms.frmAlterNo.txtNo.Text.ToString()), false))
            num2 = index;
          checked { ++index; }
        }
        if (num2 != -1)
        {
          this.DataGridView1.Rows[num2].Selected = true;
          this.DataGridView1.CurrentCell = this.DataGridView1[7, num2];
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
          {
            memReceiptDetail.lblType.Text = "MRct";
            memReceiptDetail.Text = " Member Receipt Update ";
            memReceiptDetail.lblTranStat.Text = "No";
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
          {
            memReceiptDetail.lblType.Text = "MAdj";
            memReceiptDetail.Text = " Member Adjustment Update ";
            memReceiptDetail.lblTranStat.Text = "No";
          }
          memReceiptDetail.btnSave.Text = "&Update";
          int num10 = (int) memReceiptDetail.ShowDialog();
        }
        else
        {
          int num11 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
        }
      }
      this.GetFillGrid();
    }
    MyProject.Forms.frmAlterNo = (frmAlterNo) null;
    this.btnUpdate.Focus();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedRows.Count != 1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
        MyProject.Forms.frmAlterNo.Text = "Enter Member Receipt No.";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
        MyProject.Forms.frmAlterNo.Text = "Enter Member Adjustment No.";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MJnl", false) == 0)
        MyProject.Forms.frmAlterNo.Text = "Enter Member Journal No.";
      int num1 = (int) MyProject.Forms.frmAlterNo.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmAlterNo.lblBtnStatus.Text, "Y", false) == 0)
      {
        int num2 = -1;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "Y", false) == 0)
        {
          frmMemReceiptDetailBif receiptDetailBif = new frmMemReceiptDetailBif();
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
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
            {
              receiptDetailBif.lblType.Text = "MRct";
              receiptDetailBif.Text = " Member Receipt Delete ";
              receiptDetailBif.lblTranStat.Text = "No";
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
            {
              receiptDetailBif.lblType.Text = "MAdj";
              receiptDetailBif.Text = " Member Adjustment Delete ";
              receiptDetailBif.lblTranStat.Text = "No";
            }
            receiptDetailBif.btnSave.Text = "&Delete";
            int num4 = (int) receiptDetailBif.ShowDialog();
          }
          else
          {
            int num5 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
          }
        }
        else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MJnl", false) == 0)
        {
          frmMemberJournalDetail memberJournalDetail = new frmMemberJournalDetail();
          int num6 = checked (this.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num6)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, (object) Conversion.Val(MyProject.Forms.frmAlterNo.txtNo.Text.ToString()), false))
              num2 = index;
            checked { ++index; }
          }
          if (num2 != -1)
          {
            this.DataGridView1.Rows[num2].Selected = true;
            this.DataGridView1.CurrentCell = this.DataGridView1[7, num2];
            memberJournalDetail.Text = " Member Journal Update ";
            memberJournalDetail.btnSave.Text = "&Delete";
            int num7 = (int) memberJournalDetail.ShowDialog();
          }
          else
          {
            int num8 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
          }
        }
        else
        {
          frmMemReceiptDetail memReceiptDetail = new frmMemReceiptDetail();
          int num9 = checked (this.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num9)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, (object) Conversion.Val(MyProject.Forms.frmAlterNo.txtNo.Text.ToString()), false))
              num2 = index;
            checked { ++index; }
          }
          if (num2 != -1)
          {
            this.DataGridView1.Rows[num2].Selected = true;
            this.DataGridView1.CurrentCell = this.DataGridView1[7, num2];
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
            {
              memReceiptDetail.lblType.Text = "MRct";
              memReceiptDetail.Text = " Member Receipt Delete ";
              memReceiptDetail.lblTranStat.Text = "No";
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
            {
              memReceiptDetail.lblType.Text = "MAdj";
              memReceiptDetail.Text = " Member Adjustment Delete ";
              memReceiptDetail.lblTranStat.Text = "No";
            }
            memReceiptDetail.btnSave.Text = "&Delete";
            int num10 = (int) memReceiptDetail.ShowDialog();
          }
          else
          {
            int num11 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
          }
        }
        this.GetFillGrid();
      }
      MyProject.Forms.frmAlterNo = (frmAlterNo) null;
      this.btnDelete.Focus();
    }
    if (this.DataGridView2.SelectedRows.Count != 1)
      return;
    int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "Y", false) == 0)
    {
      frmMemReceiptDetailBif receiptDetailBif = new frmMemReceiptDetailBif();
      int num12 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num13;
      while (index <= num12)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[0].Value, false))
          num13 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num13].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[7, num13];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
      {
        receiptDetailBif.lblType.Text = "MRct";
        receiptDetailBif.Text = " Member Receipt Delete ";
        receiptDetailBif.lblTranStat.Text = "No";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
      {
        receiptDetailBif.lblType.Text = "MAdj";
        receiptDetailBif.Text = " Member Adjustment Delete ";
        receiptDetailBif.lblTranStat.Text = "No";
      }
      receiptDetailBif.btnSave.Text = "&Delete";
      int num14 = (int) receiptDetailBif.ShowDialog();
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
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MJnl", false) == 0)
    {
      frmMemberJournalDetail memberJournalDetail = new frmMemberJournalDetail();
      int num15 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num16;
      while (index <= num15)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[0].Value, false))
          num16 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num16].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[7, num16];
      memberJournalDetail.Text = " Member Journal Delete ";
      memberJournalDetail.btnSave.Text = "&Delete";
      int num17 = (int) memberJournalDetail.ShowDialog();
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
      frmMemReceiptDetail memReceiptDetail = new frmMemReceiptDetail();
      int num18 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num19;
      while (index <= num18)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[0].Value, false))
          num19 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num19].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[7, num19];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
      {
        memReceiptDetail.lblType.Text = "MRct";
        memReceiptDetail.Text = " Member Receipt Delete ";
        memReceiptDetail.lblTranStat.Text = "No";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
      {
        memReceiptDetail.lblType.Text = "MAdj";
        memReceiptDetail.Text = " Member Adjustment Delete ";
        memReceiptDetail.lblTranStat.Text = "No";
      }
      memReceiptDetail.btnSave.Text = "&Delete";
      int num20 = (int) memReceiptDetail.ShowDialog();
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
  }

  private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.cmbSearch.SelectedIndex == 0)
      this.cmpColumnNo = 13;
    if (this.cmbSearch.SelectedIndex == 1)
      this.cmpColumnNo = 16 /*0x10*/;
    if (this.cmbSearch.SelectedIndex == 2)
      this.cmpColumnNo = 18;
    if (this.cmbSearch.SelectedIndex == 3)
      this.cmpColumnNo = 38;
    if (this.cmbSearch.SelectedIndex == 4)
      this.cmpColumnNo = 10;
    if (this.cmbSearch.SelectedIndex == 5)
      this.cmpColumnNo = 20;
    if (this.cmbSearch.SelectedIndex == 6)
      this.cmpColumnNo = 9;
    if (this.cmbSearch.SelectedIndex != 7)
      return;
    this.cmpColumnNo = 7;
  }

  private void txtSearch_TextChanged(object sender, EventArgs e)
  {
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 14;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.Columns[5].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[5].ValueType = typeof (double);
    this.DataGridView2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) == 0)
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView2.Rows.Add();
        this.DataGridView2.Rows[index].Cells[0].Value = (object) this.DataGridView1.Rows[index].Cells[7].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[1].Value = (object) this.DataGridView1.Rows[index].Cells[8].Value.ToString().Substring(0, 10);
        this.DataGridView2.Rows[index].Cells[2].Value = (object) this.DataGridView1.Rows[index].Cells[9].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[3].Value = (object) this.DataGridView1.Rows[index].Cells[10].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[4].Value = (object) this.DataGridView1.Rows[index].Cells[38].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[5].Value = (object) Conversion.Val(this.DataGridView1.Rows[index].Cells[13].Value.ToString().Trim());
        this.DataGridView2.Rows[index].Cells[6].Value = (object) this.DataGridView1.Rows[index].Cells[16 /*0x10*/].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[7].Value = (object) this.DataGridView1.Rows[index].Cells[17].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[8].Value = (object) this.DataGridView1.Rows[index].Cells[18].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[9].Value = (object) this.DataGridView1.Rows[index].Cells[19].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[10].Value = (object) this.DataGridView1.Rows[index].Cells[20].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[11].Value = (object) this.DataGridView1.Rows[index].Cells[21].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[12].Value = (object) this.DataGridView1.Rows[index].Cells[22].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[13].Value = (object) this.DataGridView1.Rows[index].Cells[15].Value.ToString().Trim();
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
            this.DataGridView2.Rows[index1].Cells[1].Value = (object) this.DataGridView1.Rows[index2].Cells[8].Value.ToString().Substring(0, 10);
            this.DataGridView2.Rows[index1].Cells[2].Value = (object) this.DataGridView1.Rows[index2].Cells[9].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[3].Value = (object) this.DataGridView1.Rows[index2].Cells[10].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[4].Value = (object) this.DataGridView1.Rows[index2].Cells[38].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[5].Value = (object) Conversion.Val(this.DataGridView1.Rows[index2].Cells[13].Value.ToString().Trim());
            this.DataGridView2.Rows[index1].Cells[6].Value = (object) this.DataGridView1.Rows[index2].Cells[16 /*0x10*/].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[7].Value = (object) this.DataGridView1.Rows[index2].Cells[17].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[8].Value = (object) this.DataGridView1.Rows[index2].Cells[18].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[9].Value = (object) this.DataGridView1.Rows[index2].Cells[19].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[10].Value = (object) this.DataGridView1.Rows[index2].Cells[20].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[11].Value = (object) this.DataGridView1.Rows[index2].Cells[21].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[12].Value = (object) this.DataGridView1.Rows[index2].Cells[22].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[13].Value = (object) this.DataGridView1.Rows[index2].Cells[15].Value.ToString().Trim();
            checked { ++index1; }
          }
          checked { ++Start; }
        }
        checked { ++index2; }
      }
    }
    this.DataGridView2.Columns[0].HeaderText = "No.";
    this.DataGridView2.Columns[1].HeaderText = "Date";
    this.DataGridView2.Columns[2].HeaderText = "Cash/Bank";
    this.DataGridView2.Columns[3].HeaderText = "Flat No";
    this.DataGridView2.Columns[4].HeaderText = "Mem.Name";
    this.DataGridView2.Columns[5].HeaderText = "Amount";
    this.DataGridView2.Columns[6].HeaderText = "Chq. No.";
    this.DataGridView2.Columns[7].HeaderText = "Chq.Date";
    this.DataGridView2.Columns[8].HeaderText = "Bank";
    this.DataGridView2.Columns[9].HeaderText = "Bill No.";
    this.DataGridView2.Columns[10].HeaderText = "Particular1";
    this.DataGridView2.Columns[11].HeaderText = "Particular2";
    this.DataGridView2.Columns[12].HeaderText = "Particular3";
    this.DataGridView2.Columns[13].HeaderText = "Clear Date";
    this.DataGridView2.Columns[0].Width = 70;
    this.DataGridView2.Columns[1].Width = 70;
    this.DataGridView2.Columns[2].Width = 200;
    this.DataGridView2.Columns[3].Width = 100;
    this.DataGridView2.Columns[4].Width = 200;
    this.DataGridView2.Columns[5].Width = 100;
    this.DataGridView2.Columns[6].Width = 100;
    this.DataGridView2.Columns[13].Width = 110;
    this.DataGridView2.ClearSelection();
  }

  private void btnPrintRegister_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPVRegister.lblType.Text = this.lblTrType.Text;
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
    MyProject.Forms.frmReportPVRegister = (frmReportPVRegister) null;
  }

  private void btnPrintVoucher_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportMemberReceiptPrint.lblType.Text = "MRct";
    int num = (int) MyProject.Forms.frmReportMemberReceiptPrint.ShowDialog();
    MyProject.Forms.frmReportMemberReceiptPrint = (frmReportMemberReceiptPrint) null;
  }

  private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "Y", false) == 0)
    {
      frmMemReceiptDetailBif receiptDetailBif = new frmMemReceiptDetailBif();
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
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
        {
          receiptDetailBif.lblType.Text = "MRct";
          receiptDetailBif.Text = " Member Receipt Update ";
          receiptDetailBif.lblTranStat.Text = "No";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
        {
          receiptDetailBif.lblType.Text = "MAdj";
          receiptDetailBif.Text = " Member Adjustment Update ";
          receiptDetailBif.lblTranStat.Text = "No";
        }
        receiptDetailBif.btnSave.Text = "&Update";
        int num3 = (int) receiptDetailBif.ShowDialog();
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "Document No. Does not exist");
      }
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MJnl", false) == 0)
    {
      frmMemberJournalDetail memberJournalDetail = new frmMemberJournalDetail();
      int num4 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num5;
      while (index <= num4)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[0].Value, false))
          num5 = index;
        checked { ++index; }
      }
      if (num5 != -1)
      {
        this.DataGridView1.Rows[num5].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[7, num5];
        memberJournalDetail.Text = " Member Journal Update ";
        memberJournalDetail.btnSave.Text = "&Update";
        int num6 = (int) memberJournalDetail.ShowDialog();
      }
      else
      {
        int num7 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
      }
    }
    else
    {
      frmMemReceiptDetail memReceiptDetail = new frmMemReceiptDetail();
      if (this.DataGridView2.SelectedRows.Count == 1)
      {
        int num8 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        int num9;
        while (index <= num8)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[0].Value, false))
            num9 = index;
          checked { ++index; }
        }
        this.DataGridView1.Rows[num9].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[7, num9];
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
        {
          memReceiptDetail.lblType.Text = "MRct";
          memReceiptDetail.Text = " Member Receipt Update ";
          memReceiptDetail.lblTranStat.Text = "No";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
        {
          memReceiptDetail.lblType.Text = "MAdj";
          memReceiptDetail.Text = " Member Adjustment Update ";
          memReceiptDetail.lblTranStat.Text = "No";
        }
        memReceiptDetail.btnSave.Text = "&Update";
        int num10 = (int) memReceiptDetail.ShowDialog();
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "Document No. Does not exist");
      }
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
    int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.RecBifurcation, "Y", false) == 0)
    {
      frmMemReceiptDetailBif receiptDetailBif = new frmMemReceiptDetailBif();
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
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
        {
          receiptDetailBif.lblType.Text = "MRct";
          receiptDetailBif.Text = " Member Receipt Update ";
          receiptDetailBif.lblTranStat.Text = "No";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
        {
          receiptDetailBif.lblType.Text = "MAdj";
          receiptDetailBif.Text = " Member Adjustment Update ";
          receiptDetailBif.lblTranStat.Text = "No";
        }
        receiptDetailBif.btnSave.Text = "&Update";
        int num3 = (int) receiptDetailBif.ShowDialog();
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "Document No. Does not exist");
      }
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MJnl", false) == 0)
    {
      frmMemberJournalDetail memberJournalDetail = new frmMemberJournalDetail();
      if (this.DataGridView2.SelectedRows.Count == 1)
      {
        int num4 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        int num5;
        while (index <= num4)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[0].Value, false))
            num5 = index;
          checked { ++index; }
        }
        this.DataGridView1.Rows[num5].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[7, num5];
        memberJournalDetail.Text = " Member Journal Update ";
        memberJournalDetail.btnSave.Text = "&Update";
        int num6 = (int) memberJournalDetail.ShowDialog();
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "Document No. Does not exist");
      }
    }
    else
    {
      frmMemReceiptDetail memReceiptDetail = new frmMemReceiptDetail();
      if (this.DataGridView2.SelectedRows.Count == 1)
      {
        int num7 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        int num8;
        while (index <= num7)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[0].Value, false))
            num8 = index;
          checked { ++index; }
        }
        this.DataGridView1.Rows[num8].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[7, num8];
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MRct", false) == 0)
        {
          memReceiptDetail.lblType.Text = "MRct";
          memReceiptDetail.Text = " Member Receipt Update ";
          memReceiptDetail.lblTranStat.Text = "No";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "MAdj", false) == 0)
        {
          memReceiptDetail.lblType.Text = "MAdj";
          memReceiptDetail.Text = " Member Adjustment Update ";
          memReceiptDetail.lblTranStat.Text = "No";
        }
        memReceiptDetail.btnSave.Text = "&Update";
        int num9 = (int) memReceiptDetail.ShowDialog();
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "Document No. Does not exist");
      }
    }
    this.GetFillGrid();
    this.DataGridView2.Focus();
    this.DataGridView2.Rows[rowIndex].Cells[columnIndex].Selected = true;
    this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, rowIndex];
  }

  private void btnMultiDelete_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmAutoBillDelete.lblTitle.Text = "Auto Receipt Delete";
    MyProject.Forms.frmAutoBillDelete.lblType.Text = "MRct";
    int num = (int) MyProject.Forms.frmAutoBillDelete.ShowDialog();
    MyProject.Forms.frmAutoBillDelete = (frmAutoBillDelete) null;
    this.GetFillGrid();
  }
}
