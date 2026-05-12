// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmPayment
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
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmPayment : Form
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
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("cmbSearch")]
  private ComboBox _cmbSearch;
  [AccessedThroughProperty("txtSearch")]
  private TextBox _txtSearch;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("btnPrintRegister")]
  private Button _btnPrintRegister;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("lblTrType")]
  private Label _lblTrType;
  [AccessedThroughProperty("GroupBox3")]
  private GroupBox _GroupBox3;
  [AccessedThroughProperty("GroupBox4")]
  private GroupBox _GroupBox4;
  [AccessedThroughProperty("btnPrintVoucher")]
  private Button _btnPrintVoucher;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  private int cmpColumnNo;

  [DebuggerNonUserCode]
  static frmPayment()
  {
  }

  [DebuggerNonUserCode]
  public frmPayment()
  {
    this.KeyDown += new KeyEventHandler(this.frmPayment_KeyDown);
    this.Load += new EventHandler(this.frmPayment_Load);
    frmPayment.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmPayment.__ENCList)
    {
      if (frmPayment.__ENCList.Count == frmPayment.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmPayment.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmPayment.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmPayment.__ENCList[index1] = frmPayment.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmPayment.__ENCList.RemoveRange(index1, checked (frmPayment.__ENCList.Count - index1));
        frmPayment.__ENCList.Capacity = frmPayment.__ENCList.Count;
      }
      frmPayment.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPayment));
    this.btnExit = new Button();
    this.btnDelete = new Button();
    this.btnUpdate = new Button();
    this.btnAdd = new Button();
    this.DataGridView1 = new DataGridView();
    this.GroupBox2 = new GroupBox();
    this.lblTrType = new Label();
    this.cmbSearch = new ComboBox();
    this.txtSearch = new TextBox();
    this.DataGridView2 = new DataGridView();
    this.btnPrintRegister = new Button();
    this.GroupBox1 = new GroupBox();
    this.GroupBox3 = new GroupBox();
    this.GroupBox4 = new GroupBox();
    this.btnPrintVoucher = new Button();
    this.Button2 = new Button();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.GroupBox3.SuspendLayout();
    this.GroupBox4.SuspendLayout();
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
    this.btnExit.TabIndex = 10;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(6, 117);
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
    point1 = new Point(6, 70);
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
    point1 = new Point(6, 23);
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
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(6, 19);
    Point point6 = point1;
    dataGridView1_1.Location = point6;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(13, 17);
    Size size6 = size1;
    dataGridView1_2.Size = size6;
    this.DataGridView1.TabIndex = 13;
    this.DataGridView1.TabStop = false;
    this.GroupBox2.Controls.Add((Control) this.lblTrType);
    this.GroupBox2.Controls.Add((Control) this.DataGridView1);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(894, 476);
    Point point7 = point1;
    groupBox2_1.Location = point7;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(86, 40);
    Size size7 = size1;
    groupBox2_2.Size = size7;
    this.GroupBox2.TabIndex = 23;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "    Alter Voucher ";
    this.GroupBox2.Visible = false;
    this.lblTrType.AutoSize = true;
    Label lblTrType1 = this.lblTrType;
    point1 = new Point(25, 19);
    Point point8 = point1;
    lblTrType1.Location = point8;
    this.lblTrType.Name = "lblTrType";
    Label lblTrType2 = this.lblTrType;
    size1 = new Size(30, 13);
    Size size8 = size1;
    lblTrType2.Size = size8;
    this.lblTrType.TabIndex = 29;
    this.lblTrType.Text = "Pymt";
    this.cmbSearch.FormattingEnabled = true;
    this.cmbSearch.Items.AddRange(new object[8]
    {
      (object) "Amount",
      (object) "Cheque No.",
      (object) "Bill No.",
      (object) "Person Name",
      (object) "Particular",
      (object) "Particular1",
      (object) "Cash/Bank",
      (object) "Voucher No."
    });
    ComboBox cmbSearch1 = this.cmbSearch;
    point1 = new Point(4, 19);
    Point point9 = point1;
    cmbSearch1.Location = point9;
    this.cmbSearch.Name = "cmbSearch";
    ComboBox cmbSearch2 = this.cmbSearch;
    size1 = new Size(102, 21);
    Size size9 = size1;
    cmbSearch2.Size = size9;
    this.cmbSearch.TabIndex = 5;
    TextBox txtSearch1 = this.txtSearch;
    point1 = new Point(4, 54);
    Point point10 = point1;
    txtSearch1.Location = point10;
    this.txtSearch.Name = "txtSearch";
    TextBox txtSearch2 = this.txtSearch;
    size1 = new Size(102, 20);
    Size size10 = size1;
    txtSearch2.Size = size10;
    this.txtSearch.TabIndex = 6;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Control;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle2;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(0, 1);
    Point point11 = point1;
    dataGridView2_1.Location = point11;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(875, 570);
    Size size11 = size1;
    dataGridView2_2.Size = size11;
    this.DataGridView2.TabIndex = 11;
    this.btnPrintRegister.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrintRegister1 = this.btnPrintRegister;
    point1 = new Point(6, 32 /*0x20*/);
    Point point12 = point1;
    btnPrintRegister1.Location = point12;
    this.btnPrintRegister.Name = "btnPrintRegister";
    Button btnPrintRegister2 = this.btnPrintRegister;
    size1 = new Size(99, 33);
    Size size12 = size1;
    btnPrintRegister2.Size = size12;
    this.btnPrintRegister.TabIndex = 8;
    this.btnPrintRegister.Text = "&Print Register";
    this.btnPrintRegister.UseVisualStyleBackColor = true;
    this.GroupBox1.Controls.Add((Control) this.cmbSearch);
    this.GroupBox1.Controls.Add((Control) this.txtSearch);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(877, 211);
    Point point13 = point1;
    groupBox1_1.Location = point13;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(110, 90);
    Size size13 = size1;
    groupBox1_2.Size = size13;
    this.GroupBox1.TabIndex = 4;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Search By";
    this.GroupBox3.Controls.Add((Control) this.btnAdd);
    this.GroupBox3.Controls.Add((Control) this.btnUpdate);
    this.GroupBox3.Controls.Add((Control) this.btnDelete);
    GroupBox groupBox3_1 = this.GroupBox3;
    point1 = new Point(878, 12);
    Point point14 = point1;
    groupBox3_1.Location = point14;
    this.GroupBox3.Name = "GroupBox3";
    GroupBox groupBox3_2 = this.GroupBox3;
    size1 = new Size(110, 170);
    Size size14 = size1;
    groupBox3_2.Size = size14;
    this.GroupBox3.TabIndex = 0;
    this.GroupBox3.TabStop = false;
    this.GroupBox4.Controls.Add((Control) this.btnPrintVoucher);
    this.GroupBox4.Controls.Add((Control) this.btnPrintRegister);
    GroupBox groupBox4_1 = this.GroupBox4;
    point1 = new Point(878, 330);
    Point point15 = point1;
    groupBox4_1.Location = point15;
    this.GroupBox4.Name = "GroupBox4";
    GroupBox groupBox4_2 = this.GroupBox4;
    size1 = new Size(110, 140);
    Size size15 = size1;
    groupBox4_2.Size = size15;
    this.GroupBox4.TabIndex = 7;
    this.GroupBox4.TabStop = false;
    this.btnPrintVoucher.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrintVoucher1 = this.btnPrintVoucher;
    point1 = new Point(6, 84);
    Point point16 = point1;
    btnPrintVoucher1.Location = point16;
    this.btnPrintVoucher.Name = "btnPrintVoucher";
    Button btnPrintVoucher2 = this.btnPrintVoucher;
    size1 = new Size(99, 33);
    Size size16 = size1;
    btnPrintVoucher2.Size = size16;
    this.btnPrintVoucher.TabIndex = 9;
    this.btnPrintVoucher.Text = "Print &Voucher";
    this.btnPrintVoucher.UseVisualStyleBackColor = true;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(954, 523);
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
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.GroupBox4);
    this.Controls.Add((Control) this.GroupBox3);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmPayment);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Payment Voucher List";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    this.GroupBox3.ResumeLayout(false);
    this.GroupBox4.ResumeLayout(false);
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

  internal virtual GroupBox GroupBox2
  {
    [DebuggerNonUserCode] get => this._GroupBox2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox2 = value;
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

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
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

  internal virtual GroupBox GroupBox3
  {
    [DebuggerNonUserCode] get => this._GroupBox3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox3 = value;
    }
  }

  internal virtual GroupBox GroupBox4
  {
    [DebuggerNonUserCode] get => this._GroupBox4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox4 = value;
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

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    DataTable dataTable = new DataTable("SocTran");
    (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0) ? (DbDataAdapter) new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='{this.lblTrType.Text}' and SocTran.MainAccount='Y' order by SocTran.SocTranNo asc", selectConnection) : (DbDataAdapter) new OleDbDataAdapter($"SELECT * FROM SocTran WHERE SocTran.SocTranType='{this.lblTrType.Text}' and SocTran.MainAccount='Y' order by SocTran.SubTranType,SocTran.SubTranNo asc", selectConnection)).Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 30;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.Columns[14].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[14].ValueType = typeof (double);
    this.DataGridView2.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    int num = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num)
    {
      this.DataGridView2.Rows.Add();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
      {
        int index2 = 0;
        do
        {
          this.DataGridView2.Rows[index1].Cells[index2].Value = (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim();
          checked { ++index2; }
        }
        while (index2 <= 6);
        this.DataGridView2.Rows[index1].Cells[7].Value = (object) $"{this.DataGridView1.Rows[index1].Cells[27].Value.ToString().Trim()}-{this.DataGridView1.Rows[index1].Cells[28].Value.ToString().Trim()}";
        this.DataGridView2.Rows[index1].Cells[8].Value = (object) this.DataGridView1.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
        this.DataGridView2.Rows[index1].Cells[29].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[7].Value);
        int index3 = 9;
        do
        {
          this.DataGridView2.Rows[index1].Cells[index3].Value = index3 != 14 ? (object) this.DataGridView1.Rows[index1].Cells[index3].Value.ToString().Trim() : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) != 0 ? (object) Conversion.Val(this.DataGridView1.Rows[index1].Cells[index3].Value.ToString().Trim()) : (object) Conversion.Val(this.DataGridView1.Rows[index1].Cells[checked (index3 - 1)].Value.ToString().Trim()));
          checked { ++index3; }
        }
        while (index3 <= 27);
      }
      else
      {
        int index4 = 0;
        do
        {
          this.DataGridView2.Rows[index1].Cells[index4].Value = index4 == 8 ? (object) this.DataGridView1.Rows[index1].Cells[index4].Value.ToString().Substring(0, 10) : (object) this.DataGridView1.Rows[index1].Cells[index4].Value.ToString().Trim();
          if (index4 == 14)
            this.DataGridView2.Rows[index1].Cells[index4].Value = !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "OpBR", false) == 0) ? (object) Conversion.Val(this.DataGridView1.Rows[index1].Cells[index4].Value.ToString().Trim()) : (object) Conversion.Val(this.DataGridView1.Rows[index1].Cells[checked (index4 - 1)].Value.ToString().Trim());
          checked { ++index4; }
        }
        while (index4 <= 27);
      }
      checked { ++index1; }
    }
    this.DataGridView2.Columns[0].Visible = false;
    this.DataGridView2.Columns[1].Visible = false;
    this.DataGridView2.Columns[2].Visible = false;
    this.DataGridView2.Columns[3].Visible = false;
    this.DataGridView2.Columns[4].Visible = false;
    this.DataGridView2.Columns[5].Visible = false;
    this.DataGridView2.Columns[6].Visible = false;
    this.DataGridView2.Columns[7].Width = 70;
    this.DataGridView2.Columns[8].Width = 75;
    this.DataGridView2.Columns[9].Width = 200;
    this.DataGridView2.Columns[10].Visible = false;
    this.DataGridView2.Columns[11].Visible = false;
    this.DataGridView2.Columns[12].Visible = false;
    this.DataGridView2.Columns[13].Visible = false;
    this.DataGridView2.Columns[14].Width = 100;
    this.DataGridView2.Columns[15].Visible = false;
    this.DataGridView2.Columns[16 /*0x10*/].Width = 70;
    this.DataGridView2.Columns[17].Width = 100;
    this.DataGridView2.Columns[18].Width = 100;
    this.DataGridView2.Columns[19].Width = 300;
    this.DataGridView2.Columns[20].Width = 300;
    this.DataGridView2.Columns[21].Width = 300;
    this.DataGridView2.Columns[22].Visible = false;
    this.DataGridView2.Columns[23].Visible = false;
    this.DataGridView2.Columns[24].Visible = false;
    this.DataGridView2.Columns[25].Visible = false;
    this.DataGridView2.Columns[6].HeaderText = "Type";
    this.DataGridView2.Columns[7].HeaderText = "Vou.No.";
    this.DataGridView2.Columns[8].HeaderText = "Vou.Date";
    this.DataGridView2.Columns[9].HeaderText = "Cash/Bank";
    this.DataGridView2.Columns[14].HeaderText = "Amount";
    this.DataGridView2.Columns[16 /*0x10*/].HeaderText = "Chq.No.";
    this.DataGridView2.Columns[17].HeaderText = "Chq.Date";
    this.DataGridView2.Columns[18].HeaderText = "Bill No.";
    this.DataGridView2.Columns[19].HeaderText = "Paid To";
    this.DataGridView2.Columns[20].HeaderText = "Particular1";
    this.DataGridView2.Columns[21].HeaderText = "Particular2";
    this.DataGridView2.ClearSelection();
    if (this.DataGridView2.RowCount == 0)
    {
      this.btnUpdate.Enabled = false;
      this.btnDelete.Enabled = false;
    }
    else
    {
      this.btnUpdate.Enabled = true;
      this.btnDelete.Enabled = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "4", false) == 0)
      this.btnDelete.Enabled = false;
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void frmPayment_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmPayment_Load(object sender, EventArgs e)
  {
    this.txtSearch.Text = "";
    this.GetFillGrid();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Jrnl", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "OpBR", false) == 0)
      this.btnPrintVoucher.Visible = false;
    else
      this.btnPrintVoucher.Visible = true;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
    {
      frmPaymentDetails frmPaymentDetails = new frmPaymentDetails();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0)
      {
        frmPaymentDetails.lblType.Text = "Pymt";
        frmPaymentDetails.Text = " Payment Voucher Add ";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0)
      {
        frmPaymentDetails.lblType.Text = "Rcpt";
        frmPaymentDetails.Text = " Receipt Voucher Add ";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
      {
        frmPaymentDetails.lblType.Text = "Ctra";
        frmPaymentDetails.Text = " Contra Voucher Add ";
      }
      frmPaymentDetails.btnSave.Text = "&Save";
      frmPaymentDetails.txtNo.Text = this.DataGridView1.RowCount <= 0 ? Conversions.ToString(0) : Conversions.ToString(this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
      frmPaymentDetails.btnAddGrid.Visible = true;
      frmPaymentDetails.btnUpdateGrid.Visible = false;
      frmPaymentDetails.btnDeleteGrid.Visible = false;
      int num = (int) frmPaymentDetails.ShowDialog();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Jrnl", false) == 0)
    {
      frmJournalDetail frmJournalDetail = new frmJournalDetail();
      frmJournalDetail.Text = " Journal Voucher Add ";
      frmJournalDetail.btnSave.Text = "&Save";
      frmJournalDetail.txtNo.Text = this.DataGridView1.RowCount <= 0 ? Conversions.ToString(0) : Conversions.ToString(this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
      frmJournalDetail.btnAddGrid.Visible = true;
      frmJournalDetail.btnUpdateGrid.Visible = false;
      frmJournalDetail.btnDeleteGrid.Visible = false;
      int num = (int) frmJournalDetail.ShowDialog();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "OpBR", false) == 0)
    {
      frmOpeningRecoDetail openingRecoDetail = new frmOpeningRecoDetail();
      openingRecoDetail.Text = " Opening Bank Reco Voucher Add ";
      openingRecoDetail.btnSave.Text = "&Save";
      openingRecoDetail.txtNo.Text = this.DataGridView1.RowCount <= 0 ? Conversions.ToString(0) : Conversions.ToString(this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["SocTranNo"].Value))).Max());
      int num = (int) openingRecoDetail.ShowDialog();
    }
    this.GetFillGrid();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0)
      MyProject.Forms.frmAlterNo.Text = "Enter Payment Voucher No.";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0)
      MyProject.Forms.frmAlterNo.Text = "Enter Receipt Voucher No.";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
      MyProject.Forms.frmAlterNo.Text = "Enter Contra Voucher No.";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Jrnl", false) == 0)
      MyProject.Forms.frmAlterNo.Text = "Enter Journal Voucher No.";
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "OpBR", false) == 0)
      MyProject.Forms.frmAlterNo.Text = "Enter Op.Bank Reco Voucher No.";
    MyProject.Forms.frmAlterNo.lblAlterTranType.Text = this.lblTrType.Text;
    int num1 = (int) MyProject.Forms.frmAlterNo.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmAlterNo.lblBtnStatus.Text, "Y", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
      {
        int num2 = -1;
        frmPaymentDetails frmPaymentDetails = new frmPaymentDetails();
        int num3 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num3)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString($"{this.DataGridView1.Rows[index].Cells[27].Value.ToString().Trim()}-{this.DataGridView1.Rows[index].Cells[28].Value.ToString().Trim()}", $"{MyProject.Forms.frmAlterNo.cmbSubTranType.Text.Trim()}-{MyProject.Forms.frmAlterNo.txtNo.Text.ToString().Trim()}", false) == 0)
            num2 = index;
          checked { ++index; }
        }
        if (num2 != -1)
        {
          this.DataGridView1.Rows[num2].Selected = true;
          this.DataGridView1.CurrentCell = this.DataGridView1[7, num2];
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0)
          {
            frmPaymentDetails.lblType.Text = "Pymt";
            frmPaymentDetails.Text = " Payment Voucher Alter ";
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0)
          {
            frmPaymentDetails.lblType.Text = "Rcpt";
            frmPaymentDetails.Text = " Receipt Voucher Alter ";
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
          {
            frmPaymentDetails.lblType.Text = "Ctra";
            frmPaymentDetails.Text = " Contra Voucher Alter ";
          }
          frmPaymentDetails.btnSave.Text = "&Update";
          frmPaymentDetails.btnAddGrid.Visible = true;
          frmPaymentDetails.btnUpdateGrid.Visible = false;
          frmPaymentDetails.btnDeleteGrid.Visible = false;
          int num4 = (int) frmPaymentDetails.ShowDialog();
        }
        else
        {
          int num5 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Jrnl", false) == 0)
      {
        int num6 = -1;
        frmJournalDetail frmJournalDetail = new frmJournalDetail();
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
          frmJournalDetail.Text = " Journal Voucher Alter ";
          frmJournalDetail.btnSave.Text = "&Update";
          frmJournalDetail.btnAddGrid.Visible = true;
          frmJournalDetail.btnUpdateGrid.Visible = false;
          frmJournalDetail.btnDeleteGrid.Visible = false;
          int num8 = (int) frmJournalDetail.ShowDialog();
        }
        else
        {
          int num9 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
        }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "OpBR", false) == 0)
      {
        int num10 = -1;
        frmOpeningRecoDetail openingRecoDetail = new frmOpeningRecoDetail();
        int num11 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        while (index <= num11)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, (object) Conversion.Val(MyProject.Forms.frmAlterNo.txtNo.Text.ToString()), false))
            num10 = index;
          checked { ++index; }
        }
        if (num10 != -1)
        {
          this.DataGridView1.Rows[num10].Selected = true;
          this.DataGridView1.CurrentCell = this.DataGridView1[7, num10];
          openingRecoDetail.Text = " Opening Bank Reco Voucher Alter ";
          openingRecoDetail.btnSave.Text = "&Update";
          int num12 = (int) openingRecoDetail.ShowDialog();
        }
        else
        {
          int num13 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
        }
      }
      this.GetFillGrid();
    }
    MyProject.Forms.frmAlterNo = (frmAlterNo) null;
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
      int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
      {
        frmPaymentDetails frmPaymentDetails = new frmPaymentDetails();
        int num1 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        int num2;
        while (index <= num1)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString($"{this.DataGridView1.Rows[index].Cells[27].Value.ToString().Trim()}-{this.DataGridView1.Rows[index].Cells[28].Value.ToString().Trim()}", this.DataGridView2.CurrentRow.Cells[7].Value.ToString().Trim(), false) == 0)
            num2 = index;
          checked { ++index; }
        }
        this.DataGridView1.Rows[num2].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[7, num2];
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0)
        {
          frmPaymentDetails.lblType.Text = "Pymt";
          frmPaymentDetails.Text = " Payment Voucher Delete ";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0)
        {
          frmPaymentDetails.lblType.Text = "Rcpt";
          frmPaymentDetails.Text = " Receipt Voucher Delete ";
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
        {
          frmPaymentDetails.lblType.Text = "Ctra";
          frmPaymentDetails.Text = " Contra Voucher Delete ";
        }
        frmPaymentDetails.btnSave.Text = "&Delete";
        frmPaymentDetails.btnAddGrid.Visible = true;
        frmPaymentDetails.btnUpdateGrid.Visible = false;
        frmPaymentDetails.btnDeleteGrid.Visible = false;
        int num3 = (int) frmPaymentDetails.ShowDialog();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Jrnl", false) == 0)
      {
        frmJournalDetail frmJournalDetail = new frmJournalDetail();
        int num4 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        int num5;
        while (index <= num4)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[7].Value, false))
            num5 = index;
          checked { ++index; }
        }
        this.DataGridView1.Rows[num5].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[7, num5];
        frmJournalDetail.Text = " Journal Voucher Delete ";
        frmJournalDetail.btnSave.Text = "&Delete";
        frmJournalDetail.btnAddGrid.Visible = true;
        frmJournalDetail.btnUpdateGrid.Visible = false;
        frmJournalDetail.btnDeleteGrid.Visible = false;
        int num6 = (int) frmJournalDetail.ShowDialog();
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "OpBR", false) == 0)
      {
        frmOpeningRecoDetail openingRecoDetail = new frmOpeningRecoDetail();
        int num7 = checked (this.DataGridView1.RowCount - 1);
        int index = 0;
        int num8;
        while (index <= num7)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[7].Value, false))
            num8 = index;
          checked { ++index; }
        }
        this.DataGridView1.Rows[num8].Selected = true;
        this.DataGridView1.CurrentCell = this.DataGridView1[7, num8];
        openingRecoDetail.Text = " Opening Bank Reco Voucher Delete ";
        openingRecoDetail.btnSave.Text = "&Delete";
        int num9 = (int) openingRecoDetail.ShowDialog();
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
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0)
        MyProject.Forms.frmAlterNo.Text = "Enter Payment Voucher No.";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0)
        MyProject.Forms.frmAlterNo.Text = "Enter Receipt Voucher No.";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
        MyProject.Forms.frmAlterNo.Text = "Enter Contra Voucher No.";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Jrnl", false) == 0)
        MyProject.Forms.frmAlterNo.Text = "Enter Journal Voucher No.";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "OpBR", false) == 0)
        MyProject.Forms.frmAlterNo.Text = "Enter Op.Bank Reco Voucher No.";
      MyProject.Forms.frmAlterNo.lblAlterTranType.Text = this.lblTrType.Text;
      int num10 = (int) MyProject.Forms.frmAlterNo.ShowDialog();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmAlterNo.lblBtnStatus.Text, "Y", false) == 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
        {
          int num11 = -1;
          frmPaymentDetails frmPaymentDetails = new frmPaymentDetails();
          int num12 = checked (this.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num12)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString($"{this.DataGridView1.Rows[index].Cells[27].Value.ToString().Trim()}-{this.DataGridView1.Rows[index].Cells[28].Value.ToString().Trim()}", $"{MyProject.Forms.frmAlterNo.cmbSubTranType.Text.Trim()}-{MyProject.Forms.frmAlterNo.txtNo.Text.ToString().Trim()}", false) == 0)
              num11 = index;
            checked { ++index; }
          }
          if (num11 != -1)
          {
            this.DataGridView1.Rows[num11].Selected = true;
            this.DataGridView1.CurrentCell = this.DataGridView1[7, num11];
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0)
            {
              frmPaymentDetails.lblType.Text = "Pymt";
              frmPaymentDetails.Text = " Payment Voucher Delete ";
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0)
            {
              frmPaymentDetails.lblType.Text = "Rcpt";
              frmPaymentDetails.Text = " Receipt Voucher Delete ";
            }
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
            {
              frmPaymentDetails.lblType.Text = "Ctra";
              frmPaymentDetails.Text = " Contra Voucher Delete ";
            }
            frmPaymentDetails.btnSave.Text = "&Delete";
            frmPaymentDetails.btnAddGrid.Visible = false;
            frmPaymentDetails.btnUpdateGrid.Visible = false;
            frmPaymentDetails.btnDeleteGrid.Visible = false;
            int num13 = (int) frmPaymentDetails.ShowDialog();
          }
          else
          {
            int num14 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Jrnl", false) == 0)
        {
          int num15 = -1;
          frmJournalDetail frmJournalDetail = new frmJournalDetail();
          int num16 = checked (this.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num16)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, (object) Conversion.Val(MyProject.Forms.frmAlterNo.txtNo.Text.ToString()), false))
              num15 = index;
            checked { ++index; }
          }
          if (num15 != -1)
          {
            this.DataGridView1.Rows[num15].Selected = true;
            this.DataGridView1.CurrentCell = this.DataGridView1[7, num15];
            frmJournalDetail.Text = " Journal Voucher Delete ";
            frmJournalDetail.btnSave.Text = "&Delete";
            frmJournalDetail.btnAddGrid.Visible = false;
            frmJournalDetail.btnUpdateGrid.Visible = false;
            frmJournalDetail.btnDeleteGrid.Visible = false;
            int num17 = (int) frmJournalDetail.ShowDialog();
          }
          else
          {
            int num18 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "OpBR", false) == 0)
        {
          int num19 = -1;
          frmOpeningRecoDetail openingRecoDetail = new frmOpeningRecoDetail();
          int num20 = checked (this.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num20)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, (object) Conversion.Val(MyProject.Forms.frmAlterNo.txtNo.Text.ToString()), false))
              num19 = index;
            checked { ++index; }
          }
          if (num19 != -1)
          {
            this.DataGridView1.Rows[num19].Selected = true;
            this.DataGridView1.CurrentCell = this.DataGridView1[7, num19];
            openingRecoDetail.Text = " Opening Bank Reco Voucher Delete ";
            openingRecoDetail.btnSave.Text = "&Delete";
            int num21 = (int) openingRecoDetail.ShowDialog();
          }
          else
          {
            int num22 = (int) Interaction.MsgBox((object) "Document No. Does not exist");
          }
        }
        this.GetFillGrid();
      }
      MyProject.Forms.frmAlterNo = (frmAlterNo) null;
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void txtSearch_TextChanged(object sender, EventArgs e)
  {
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 30;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.Columns[14].DefaultCellStyle.Format = "N2";
    this.DataGridView2.Columns[14].ValueType = typeof (double);
    this.DataGridView2.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearch.Text, "", false) == 0)
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index1 = 0;
      while (index1 <= num)
      {
        this.DataGridView2.Rows.Add();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
        {
          int index2 = 0;
          do
          {
            this.DataGridView2.Rows[index1].Cells[index2].Value = (object) this.DataGridView1.Rows[index1].Cells[index2].Value.ToString().Trim();
            checked { ++index2; }
          }
          while (index2 <= 6);
          this.DataGridView2.Rows[index1].Cells[7].Value = (object) $"{this.DataGridView1.Rows[index1].Cells[27].Value.ToString().Trim()}-{this.DataGridView1.Rows[index1].Cells[28].Value.ToString().Trim()}";
          this.DataGridView2.Rows[index1].Cells[8].Value = (object) this.DataGridView1.Rows[index1].Cells[8].Value.ToString().Substring(0, 10);
          this.DataGridView2.Rows[index1].Cells[29].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[7].Value);
          int index3 = 9;
          do
          {
            this.DataGridView2.Rows[index1].Cells[index3].Value = index3 != 14 ? (object) this.DataGridView1.Rows[index1].Cells[index3].Value.ToString().Trim() : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) != 0 ? (object) Conversion.Val(this.DataGridView1.Rows[index1].Cells[index3].Value.ToString().Trim()) : (object) Conversion.Val(this.DataGridView1.Rows[index1].Cells[checked (index3 - 1)].Value.ToString().Trim()));
            checked { ++index3; }
          }
          while (index3 <= 27);
        }
        else
        {
          int index4 = 0;
          do
          {
            this.DataGridView2.Rows[index1].Cells[index4].Value = index4 == 8 ? (object) this.DataGridView1.Rows[index1].Cells[index4].Value.ToString().Substring(0, 10) : (object) this.DataGridView1.Rows[index1].Cells[index4].Value.ToString().Trim();
            if (index4 == 14)
              this.DataGridView2.Rows[index1].Cells[index4].Value = !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "OpBR", false) == 0) ? (object) Conversion.Val(this.DataGridView1.Rows[index1].Cells[index4].Value.ToString().Trim()) : (object) Conversion.Val(this.DataGridView1.Rows[index1].Cells[checked (index4 - 1)].Value.ToString().Trim());
            checked { ++index4; }
          }
          while (index4 <= 27);
        }
        checked { ++index1; }
      }
    }
    else
    {
      int index5 = 0;
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index6 = 0;
      while (index6 <= num1)
      {
        int num2 = Microsoft.VisualBasic.Strings.Len(this.DataGridView1.Rows[index6].Cells[this.cmpColumnNo].Value.ToString().Trim());
        int Start = 1;
        while (Start <= num2)
        {
          if (Microsoft.VisualBasic.Strings.InStr(Microsoft.VisualBasic.Strings.UCase(Microsoft.VisualBasic.Strings.Mid(this.DataGridView1.Rows[index6].Cells[this.cmpColumnNo].Value.ToString().Trim(), Start, Microsoft.VisualBasic.Strings.Len(this.txtSearch.Text.Trim()))), Microsoft.VisualBasic.Strings.UCase(Microsoft.VisualBasic.Strings.Trim(this.txtSearch.Text.Trim()))) == 1)
          {
            this.DataGridView2.Rows.Add();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
            {
              int index7 = 0;
              do
              {
                this.DataGridView2.Rows[index5].Cells[index7].Value = (object) this.DataGridView1.Rows[index6].Cells[index7].Value.ToString().Trim();
                checked { ++index7; }
              }
              while (index7 <= 6);
              this.DataGridView2.Rows[index5].Cells[7].Value = (object) $"{this.DataGridView1.Rows[index6].Cells[27].Value.ToString().Trim()}-{this.DataGridView1.Rows[index6].Cells[28].Value.ToString().Trim()}";
              this.DataGridView2.Rows[index5].Cells[8].Value = (object) this.DataGridView1.Rows[index6].Cells[8].Value.ToString().Substring(0, 10);
              this.DataGridView2.Rows[index5].Cells[29].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index6].Cells[7].Value);
              int index8 = 9;
              do
              {
                this.DataGridView2.Rows[index5].Cells[index8].Value = index8 != 14 ? (object) this.DataGridView1.Rows[index6].Cells[index8].Value.ToString().Trim() : (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) != 0 ? (object) Conversion.Val(this.DataGridView1.Rows[index6].Cells[index8].Value.ToString().Trim()) : (object) Conversion.Val(this.DataGridView1.Rows[index6].Cells[checked (index8 - 1)].Value.ToString().Trim()));
                checked { ++index8; }
              }
              while (index8 <= 27);
            }
            else
            {
              int index9 = 0;
              do
              {
                this.DataGridView2.Rows[index5].Cells[index9].Value = index9 == 8 ? (object) this.DataGridView1.Rows[index6].Cells[index9].Value.ToString().Substring(0, 10) : (object) this.DataGridView1.Rows[index6].Cells[index9].Value.ToString().Trim();
                if (index9 == 14)
                  this.DataGridView2.Rows[index5].Cells[index9].Value = !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "OpBR", false) == 0) ? (object) Conversion.Val(this.DataGridView1.Rows[index6].Cells[index9].Value.ToString().Trim()) : (object) Conversion.Val(this.DataGridView1.Rows[index6].Cells[checked (index9 - 1)].Value.ToString().Trim());
                checked { ++index9; }
              }
              while (index9 <= 27);
            }
            checked { ++index5; }
          }
          checked { ++Start; }
        }
        checked { ++index6; }
      }
    }
    this.DataGridView2.Columns[0].Visible = false;
    this.DataGridView2.Columns[1].Visible = false;
    this.DataGridView2.Columns[2].Visible = false;
    this.DataGridView2.Columns[3].Visible = false;
    this.DataGridView2.Columns[4].Visible = false;
    this.DataGridView2.Columns[5].Visible = false;
    this.DataGridView2.Columns[6].Visible = false;
    this.DataGridView2.Columns[7].Width = 70;
    this.DataGridView2.Columns[8].Width = 75;
    this.DataGridView2.Columns[9].Width = 200;
    this.DataGridView2.Columns[10].Visible = false;
    this.DataGridView2.Columns[11].Visible = false;
    this.DataGridView2.Columns[12].Visible = false;
    this.DataGridView2.Columns[13].Visible = false;
    this.DataGridView2.Columns[14].Width = 100;
    this.DataGridView2.Columns[15].Visible = false;
    this.DataGridView2.Columns[16 /*0x10*/].Width = 70;
    this.DataGridView2.Columns[17].Width = 100;
    this.DataGridView2.Columns[18].Width = 100;
    this.DataGridView2.Columns[19].Width = 300;
    this.DataGridView2.Columns[20].Width = 300;
    this.DataGridView2.Columns[21].Width = 300;
    this.DataGridView2.Columns[22].Visible = false;
    this.DataGridView2.Columns[23].Visible = false;
    this.DataGridView2.Columns[24].Visible = false;
    this.DataGridView2.Columns[25].Visible = false;
    this.DataGridView2.Columns[6].HeaderText = "Type";
    this.DataGridView2.Columns[7].HeaderText = "Vou.No.";
    this.DataGridView2.Columns[8].HeaderText = "Vou.Date";
    this.DataGridView2.Columns[9].HeaderText = "Cash/Bank";
    this.DataGridView2.Columns[14].HeaderText = "Amount";
    this.DataGridView2.Columns[16 /*0x10*/].HeaderText = "Chq.No.";
    this.DataGridView2.Columns[17].HeaderText = "Chq.Date";
    this.DataGridView2.Columns[18].HeaderText = "Bill No.";
    this.DataGridView2.Columns[19].HeaderText = "Paid To";
    this.DataGridView2.Columns[20].HeaderText = "Particular1";
    this.DataGridView2.Columns[21].HeaderText = "Particular2";
    this.DataGridView2.ClearSelection();
  }

  private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
  {
    if (this.cmbSearch.SelectedIndex == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0)
      this.cmpColumnNo = 14;
    if (this.cmbSearch.SelectedIndex == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
      this.cmpColumnNo = 14;
    if (this.cmbSearch.SelectedIndex == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0)
      this.cmpColumnNo = 13;
    if (this.cmbSearch.SelectedIndex == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "OpBR", false) == 0)
      this.cmpColumnNo = 13;
    if (this.cmbSearch.SelectedIndex == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Jrnl", false) == 0)
      this.cmpColumnNo = 14;
    if (this.cmbSearch.SelectedIndex == 1)
      this.cmpColumnNo = 16 /*0x10*/;
    if (this.cmbSearch.SelectedIndex == 2)
      this.cmpColumnNo = 18;
    if (this.cmbSearch.SelectedIndex == 3)
      this.cmpColumnNo = 19;
    if (this.cmbSearch.SelectedIndex == 4)
      this.cmpColumnNo = 20;
    if (this.cmbSearch.SelectedIndex == 5)
      this.cmpColumnNo = 21;
    if (this.cmbSearch.SelectedIndex == 6)
      this.cmpColumnNo = 9;
    if (this.cmbSearch.SelectedIndex != 7)
      return;
    this.cmpColumnNo = 28;
  }

  private void btnPrintRegister_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPVRegister.lblType.Text = this.lblTrType.Text;
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
  }

  private void btnPrintVoucher_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPayment.lblType.Text = this.lblTrType.Text;
    int num = (int) MyProject.Forms.frmReportPayment.ShowDialog();
  }

  private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    int rowIndex = this.DataGridView2.CurrentCell.RowIndex;
    int columnIndex = this.DataGridView2.CurrentCell.ColumnIndex;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
    {
      frmPaymentDetails frmPaymentDetails = new frmPaymentDetails();
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num2;
      while (index <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString($"{this.DataGridView1.Rows[index].Cells[27].Value.ToString().Trim()}-{this.DataGridView1.Rows[index].Cells[28].Value.ToString().Trim()}", this.DataGridView2.CurrentRow.Cells[7].Value.ToString().Trim(), false) == 0)
          num2 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num2].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[7, num2];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0)
      {
        frmPaymentDetails.lblType.Text = "Pymt";
        frmPaymentDetails.Text = " Payment Voucher Alter ";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0)
      {
        frmPaymentDetails.lblType.Text = "Rcpt";
        frmPaymentDetails.Text = " Receipt Voucher Alter ";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
      {
        frmPaymentDetails.lblType.Text = "Ctra";
        frmPaymentDetails.Text = " Contra Voucher Alter ";
      }
      frmPaymentDetails.btnSave.Text = "&Update";
      frmPaymentDetails.btnAddGrid.Visible = true;
      frmPaymentDetails.btnUpdateGrid.Visible = false;
      frmPaymentDetails.btnDeleteGrid.Visible = false;
      int num3 = (int) frmPaymentDetails.ShowDialog();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Jrnl", false) == 0)
    {
      frmJournalDetail frmJournalDetail = new frmJournalDetail();
      int num4 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num5;
      while (index <= num4)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[7].Value, false))
          num5 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num5].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[7, num5];
      frmJournalDetail.Text = " Journal Voucher Alter ";
      frmJournalDetail.btnSave.Text = "&Update";
      frmJournalDetail.btnAddGrid.Visible = true;
      frmJournalDetail.btnUpdateGrid.Visible = false;
      frmJournalDetail.btnDeleteGrid.Visible = false;
      int num6 = (int) frmJournalDetail.ShowDialog();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "OpBR", false) == 0)
    {
      frmOpeningRecoDetail openingRecoDetail = new frmOpeningRecoDetail();
      int num7 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num8;
      while (index <= num7)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[7].Value, false))
          num8 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num8].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[7, num8];
      openingRecoDetail.Text = " Opening Bank Reco Voucher Alter ";
      openingRecoDetail.btnSave.Text = "&Update";
      int num9 = (int) openingRecoDetail.ShowDialog();
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
    {
      frmPaymentDetails frmPaymentDetails = new frmPaymentDetails();
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num2;
      while (index <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString($"{this.DataGridView1.Rows[index].Cells[27].Value.ToString().Trim()}-{this.DataGridView1.Rows[index].Cells[28].Value.ToString().Trim()}", this.DataGridView2.CurrentRow.Cells[7].Value.ToString().Trim(), false) == 0)
          num2 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num2].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[7, num2];
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Pymt", false) == 0)
      {
        frmPaymentDetails.lblType.Text = "Pymt";
        frmPaymentDetails.Text = " Payment Voucher Alter ";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Rcpt", false) == 0)
      {
        frmPaymentDetails.lblType.Text = "Rcpt";
        frmPaymentDetails.Text = " Receipt Voucher Alter ";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Ctra", false) == 0)
      {
        frmPaymentDetails.lblType.Text = "Ctra";
        frmPaymentDetails.Text = " Contra Voucher Alter ";
      }
      frmPaymentDetails.btnSave.Text = "&Update";
      frmPaymentDetails.btnAddGrid.Visible = true;
      frmPaymentDetails.btnUpdateGrid.Visible = false;
      frmPaymentDetails.btnDeleteGrid.Visible = false;
      int num3 = (int) frmPaymentDetails.ShowDialog();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "Jrnl", false) == 0)
    {
      frmJournalDetail frmJournalDetail = new frmJournalDetail();
      int num4 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num5;
      while (index <= num4)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[7].Value, false))
          num5 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num5].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[7, num5];
      frmJournalDetail.Text = " Journal Voucher Alter ";
      frmJournalDetail.btnSave.Text = "&Update";
      frmJournalDetail.btnAddGrid.Visible = true;
      frmJournalDetail.btnUpdateGrid.Visible = false;
      frmJournalDetail.btnDeleteGrid.Visible = false;
      int num6 = (int) frmJournalDetail.ShowDialog();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblTrType.Text, "OpBR", false) == 0)
    {
      frmOpeningRecoDetail openingRecoDetail = new frmOpeningRecoDetail();
      int num7 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      int num8;
      while (index <= num7)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[7].Value, this.DataGridView2.CurrentRow.Cells[7].Value, false))
          num8 = index;
        checked { ++index; }
      }
      this.DataGridView1.Rows[num8].Selected = true;
      this.DataGridView1.CurrentCell = this.DataGridView1[7, num8];
      openingRecoDetail.Text = " Opening Bank Reco Voucher Alter ";
      openingRecoDetail.btnSave.Text = "&Update";
      int num9 = (int) openingRecoDetail.ShowDialog();
    }
    this.GetFillGrid();
    this.DataGridView2.Focus();
    this.DataGridView2.Rows[rowIndex].Cells[columnIndex].Selected = true;
    this.DataGridView2.CurrentCell = this.DataGridView2[columnIndex, rowIndex];
  }
}
