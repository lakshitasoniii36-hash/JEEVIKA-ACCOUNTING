// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmAccount
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
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmAccount : Form
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
  [AccessedThroughProperty("lblSearchType")]
  private Label _lblSearchType;
  [AccessedThroughProperty("btnok")]
  private Button _btnok;
  [AccessedThroughProperty("txtSearchbox")]
  private TextBox _txtSearchbox;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("lblAccountType")]
  private Label _lblAccountType;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("Button1")]
  private Button _Button1;
  private int SearchType;

  [DebuggerNonUserCode]
  static frmAccount()
  {
  }

  public frmAccount()
  {
    this.KeyDown += new KeyEventHandler(this.frmAccount_KeyDown);
    this.Load += new EventHandler(this.frmAccount_Load);
    frmAccount.__ENCAddToList((object) this);
    this.SearchType = 7;
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmAccount.__ENCList)
    {
      if (frmAccount.__ENCList.Count == frmAccount.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmAccount.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmAccount.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmAccount.__ENCList[index1] = frmAccount.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmAccount.__ENCList.RemoveRange(index1, checked (frmAccount.__ENCList.Count - index1));
        frmAccount.__ENCList.Capacity = frmAccount.__ENCList.Count;
      }
      frmAccount.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAccount));
    this.btnExit = new Button();
    this.btnDelete = new Button();
    this.btnUpdate = new Button();
    this.btnAdd = new Button();
    this.lblSearchType = new Label();
    this.btnok = new Button();
    this.txtSearchbox = new TextBox();
    this.DataGridView2 = new DataGridView();
    this.lblAccountType = new Label();
    this.btnPrint = new Button();
    this.grpVisible = new GroupBox();
    this.Label1 = new Label();
    this.Button2 = new Button();
    this.Button1 = new Button();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(784, 530);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 7;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.btnDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(469, 529);
    Point point3 = point1;
    btnDelete1.Location = point3;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnDelete2.Size = size3;
    this.btnDelete.TabIndex = 5;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    this.btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(364, 529);
    Point point4 = point1;
    btnUpdate1.Location = point4;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnUpdate2.Size = size4;
    this.btnUpdate.TabIndex = 4;
    this.btnUpdate.Text = "A&lter";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(259, 529);
    Point point5 = point1;
    btnAdd1.Location = point5;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnAdd2.Size = size5;
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.lblSearchType.AutoSize = true;
    this.lblSearchType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblSearchType1 = this.lblSearchType;
    point1 = new Point(43, 13);
    Point point6 = point1;
    lblSearchType1.Location = point6;
    this.lblSearchType.Name = "lblSearchType";
    Label lblSearchType2 = this.lblSearchType;
    size1 = new Size(106, 16 /*0x10*/);
    Size size6 = size1;
    lblSearchType2.Size = size6;
    this.lblSearchType.TabIndex = 15;
    this.lblSearchType.Text = "Search By Code";
    this.btnok.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnok1 = this.btnok;
    point1 = new Point(155, 530);
    Point point7 = point1;
    btnok1.Location = point7;
    this.btnok.Name = "btnok";
    Button btnok2 = this.btnok;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnok2.Size = size7;
    this.btnok.TabIndex = 2;
    this.btnok.Text = "&Select";
    this.btnok.UseVisualStyleBackColor = true;
    this.txtSearchbox.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtSearchbox1 = this.txtSearchbox;
    point1 = new Point(155, 10);
    Point point8 = point1;
    txtSearchbox1.Location = point8;
    this.txtSearchbox.Name = "txtSearchbox";
    TextBox txtSearchbox2 = this.txtSearchbox;
    size1 = new Size(95, 22);
    Size size8 = size1;
    txtSearchbox2.Size = size8;
    this.txtSearchbox.TabIndex = 0;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView2.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView2.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(46, 45);
    Point point9 = point1;
    dataGridView2_1.Location = point9;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(900, 475);
    Size size9 = size1;
    dataGridView2_2.Size = size9;
    this.DataGridView2.TabIndex = 1;
    this.lblAccountType.AutoSize = true;
    Label lblAccountType1 = this.lblAccountType;
    point1 = new Point(3, 44);
    Point point10 = point1;
    lblAccountType1.Location = point10;
    this.lblAccountType.Name = "lblAccountType";
    Label lblAccountType2 = this.lblAccountType;
    size1 = new Size(18, 13);
    Size size10 = size1;
    lblAccountType2.Size = size10;
    this.lblAccountType.TabIndex = 16 /*0x10*/;
    this.lblAccountType.Text = "All";
    this.btnPrint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(574, 529);
    Point point11 = point1;
    btnPrint1.Location = point11;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size11 = size1;
    btnPrint2.Size = size11;
    this.btnPrint.TabIndex = 6;
    this.btnPrint.Text = "&Print List";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.grpVisible.Controls.Add((Control) this.lblAccountType);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(13, 382);
    Point point12 = point1;
    grpVisible1.Location = point12;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(27, 100);
    Size size12 = size1;
    grpVisible2.Size = size12;
    this.grpVisible.TabIndex = 18;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = SystemColors.Desktop;
    Label label1_1 = this.Label1;
    point1 = new Point(287, 12);
    Point point13 = point1;
    label1_1.Location = point13;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(672, 15);
    Size size13 = size1;
    label1_2.Size = size13;
    this.Label1.TabIndex = 19;
    this.Label1.Text = "    F3 - Namewise List   ||   F4 - CodeWise List    ||   Tab - Next Field  ||  Shift + Tab - Prev. Field    ||    Ctrl + Tab - Exit from Grid";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(615, 532);
    Point point14 = point1;
    button2_1.Location = point14;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 28);
    Size size14 = size1;
    button2_2.Size = size14;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.Button1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button1_1 = this.Button1;
    point1 = new Point(679, 530);
    Point point15 = point1;
    button1_1.Location = point15;
    this.Button1.Name = "Button1";
    Button button1_2 = this.Button1;
    size1 = new Size(99, 33);
    Size size15 = size1;
    button1_2.Size = size15;
    this.Button1.TabIndex = 84;
    this.Button1.Text = "S&how Ledger";
    this.Button1.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Button1);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.lblSearchType);
    this.Controls.Add((Control) this.btnok);
    this.Controls.Add((Control) this.txtSearchbox);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.btnAdd);
    this.Controls.Add((Control) this.Button2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmAccount);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Account Master";
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
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

  internal virtual Label lblSearchType
  {
    [DebuggerNonUserCode] get => this._lblSearchType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSearchType = value;
    }
  }

  internal virtual Button btnok
  {
    [DebuggerNonUserCode] get => this._btnok;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnok_Click);
      if (this._btnok != null)
        this._btnok.Click -= eventHandler;
      this._btnok = value;
      if (this._btnok == null)
        return;
      this._btnok.Click += eventHandler;
    }
  }

  internal virtual TextBox txtSearchbox
  {
    [DebuggerNonUserCode] get => this._txtSearchbox;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.txtSearchbox_TextChanged);
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSearchbox_KeyDown);
      if (this._txtSearchbox != null)
      {
        this._txtSearchbox.TextChanged -= eventHandler;
        this._txtSearchbox.KeyDown -= keyEventHandler;
      }
      this._txtSearchbox = value;
      if (this._txtSearchbox == null)
        return;
      this._txtSearchbox.TextChanged += eventHandler;
      this._txtSearchbox.KeyDown += keyEventHandler;
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

  internal virtual Label lblAccountType
  {
    [DebuggerNonUserCode] get => this._lblAccountType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccountType = value;
    }
  }

  internal virtual Button btnPrint
  {
    [DebuggerNonUserCode] get => this._btnPrint;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrint_Click);
      if (this._btnPrint != null)
        this._btnPrint.Click -= eventHandler;
      this._btnPrint = value;
      if (this._btnPrint == null)
        return;
      this._btnPrint.Click += eventHandler;
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

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
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

  internal virtual Button Button1
  {
    [DebuggerNonUserCode] get => this._Button1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button1_Click);
      if (this._Button1 != null)
        this._Button1.Click -= eventHandler;
      this._Button1 = value;
      if (this._Button1 == null)
        return;
      this._Button1.Click += eventHandler;
    }
  }

  private void frmAccount_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmAccount_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmConstantGrid.lblGridLocation.Text, "M", false) == 0)
    {
      this.btnok.Visible = false;
      this.btnExit.Visible = true;
    }
    else
    {
      this.btnok.Visible = true;
      this.btnExit.Visible = false;
    }
    this.txtSearchbox.Text = "";
    this.GetFillGrid();
    this.txtSearchbox.Text = Constant.SearchStr;
    this.txtSearchbox.Focus();
    this.txtSearchbox.Select(Strings.Len(this.txtSearchbox.Text.Trim()), 0);
  }

  public DataSet GetFillGrid()
  {
    if (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount == 0)
    {
      int num = (int) Interaction.MsgBox((object) "No Record");
      this.btnUpdate.Enabled = false;
      this.btnDelete.Enabled = false;
    }
    else
    {
      this.btnUpdate.Enabled = true;
      this.btnDelete.Enabled = true;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "1", false) == 0)
    {
      this.btnAdd.Enabled = true;
    }
    else
    {
      this.btnAdd.Enabled = false;
      this.btnUpdate.Enabled = false;
      this.btnDelete.Enabled = false;
    }
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.ColumnCount = 10;
    this.DataGridView2.RowCount = 0;
    this.SearchType = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSearchType.Text, "Search By Name", false) != 0 ? 7 : 8;
    int index1;
    int num1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountType.Text, "All", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchbox.Text, "", false) == 0)
      {
        if (this.SearchType == 7)
        {
          int num2 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1);
          int index2 = 0;
          while (index2 <= num2)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index2].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[14].Value.ToString().Trim();
            checked { ++index2; }
          }
        }
        else
        {
          int num3 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccountName.RowCount - 1);
          int index3 = 0;
          while (index3 <= num3)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index3].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[14].Value.ToString().Trim();
            checked { ++index3; }
          }
        }
      }
      else
      {
        int num4 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1);
        int index4 = 0;
        while (index4 <= num4)
        {
          if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[this.SearchType].Value.ToString().Trim(), 1, Strings.Len(this.txtSearchbox.Text)))) == 1)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index1].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[14].Value.ToString().Trim();
            checked { ++index1; }
            if (index1 == 1)
              num1 = index4;
          }
          checked { ++index4; }
        }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountType.Text, "Cash", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchbox.Text, "", false) == 0)
      {
        if (this.SearchType == 7)
        {
          int num5 = checked (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount - 1);
          int index5 = 0;
          while (index5 <= num5)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index5].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[14].Value.ToString().Trim();
            checked { ++index5; }
          }
        }
        else
        {
          int num6 = checked (MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.RowCount - 1);
          int index6 = 0;
          while (index6 <= num6)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index6].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[14].Value.ToString().Trim();
            checked { ++index6; }
          }
        }
      }
      else
      {
        int num7 = checked (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount - 1);
        int index7 = 0;
        while (index7 <= num7)
        {
          if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[this.SearchType].Value.ToString().Trim(), 1, Strings.Len(this.txtSearchbox.Text)))) == 1)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index1].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[14].Value.ToString().Trim();
            checked { ++index1; }
            if (index1 == 1)
              num1 = index7;
          }
          checked { ++index7; }
        }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountType.Text, "NonCash", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchbox.Text, "", false) == 0)
      {
        if (this.SearchType == 7)
        {
          int num8 = checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount - 1);
          int index8 = 0;
          while (index8 <= num8)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index8].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[14].Value.ToString().Trim();
            checked { ++index8; }
          }
        }
        else
        {
          int num9 = checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.RowCount - 1);
          int index9 = 0;
          while (index9 <= num9)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index9].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[14].Value.ToString().Trim();
            checked { ++index9; }
          }
        }
      }
      else
      {
        int num10 = checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount - 1);
        int index10 = 0;
        while (index10 <= num10)
        {
          if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[this.SearchType].Value.ToString().Trim(), 1, Strings.Len(this.txtSearchbox.Text)))) == 1)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index1].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[14].Value.ToString().Trim();
            checked { ++index1; }
            if (index1 == 1)
              num1 = index10;
          }
          checked { ++index10; }
        }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountType.Text, "Billing", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchbox.Text, "", false) == 0)
      {
        if (this.SearchType == 7)
        {
          int num11 = checked (MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.RowCount - 1);
          int index11 = 0;
          while (index11 <= num11)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index11].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[14].Value.ToString().Trim();
            checked { ++index11; }
          }
        }
        else
        {
          int num12 = checked (MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.RowCount - 1);
          int index12 = 0;
          while (index12 <= num12)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index12].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[14].Value.ToString().Trim();
            checked { ++index12; }
          }
        }
      }
      else
      {
        int num13 = checked (MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.RowCount - 1);
        int index13 = 0;
        while (index13 <= num13)
        {
          if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[this.SearchType].Value.ToString().Trim(), 1, Strings.Len(this.txtSearchbox.Text)))) == 1)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index1].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[14].Value.ToString().Trim();
            checked { ++index1; }
            if (index1 == 1)
              num1 = index13;
          }
          checked { ++index13; }
        }
      }
    }
    this.DataGridView2.Columns[0].Visible = false;
    this.DataGridView2.Columns[1].HeaderText = "Code";
    this.DataGridView2.Columns[2].HeaderText = "Account";
    this.DataGridView2.Columns[3].HeaderText = "Main Group";
    this.DataGridView2.Columns[4].HeaderText = "Group";
    this.DataGridView2.Columns[9].HeaderText = "Balance";
    this.DataGridView2.Columns[1].Width = 95;
    this.DataGridView2.Columns[2].Width = 350;
    this.DataGridView2.Columns[3].Width = 150;
    this.DataGridView2.Columns[4].Width = 350;
    this.DataGridView2.Columns[5].Visible = false;
    this.DataGridView2.Columns[6].Visible = false;
    this.DataGridView2.Columns[7].Visible = false;
    this.DataGridView2.Columns[8].Visible = false;
    this.DataGridView2.Columns[9].Visible = false;
    this.DataGridView2.ClearSelection();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    Constant.SearchStat = true;
    frmAccountDetail frmAccountDetail = new frmAccountDetail();
    frmAccountDetail.Text = " New Account Creation ";
    frmAccountDetail.btnSave.Text = "&Save";
    int num = (int) frmAccountDetail.ShowDialog();
    MyProject.Forms.frmConstantGrid.Refresh();
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    this.txtSearchbox.Text = "";
    this.GetFillGrid();
    this.txtSearchbox.Focus();
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      Constant.SearchStat = true;
      frmAccountDetail frmAccountDetail = new frmAccountDetail();
      frmAccountDetail.Text = " Account Update ";
      frmAccountDetail.btnSave.Text = "&Update";
      int num = (int) frmAccountDetail.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
      this.txtSearchbox.Text = "";
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
    }
    this.GetFillGrid();
    this.txtSearchbox.Focus();
  }

  private void btnDelete_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      Constant.SearchStat = true;
      frmAccountDetail frmAccountDetail = new frmAccountDetail();
      frmAccountDetail.Text = " Account Delete ";
      frmAccountDetail.btnSave.Text = "&Delete";
      int num = (int) frmAccountDetail.ShowDialog();
      MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
      this.txtSearchbox.Text = "";
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
    }
    this.GetFillGrid();
    this.txtSearchbox.Focus();
  }

  private void txtSearchbox_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode == Keys.F4)
    {
      this.lblSearchType.Text = "Search By Code";
      this.GetFillGrid();
    }
    if (e.KeyCode == Keys.F3)
    {
      this.lblSearchType.Text = "Search By Name";
      this.GetFillGrid();
    }
    if (e.KeyCode == Keys.Down && this.DataGridView2.RowCount > 0)
    {
      this.DataGridView2.Focus();
      this.DataGridView2.Rows[0].Selected = true;
    }
    if (e.KeyCode != Keys.Return)
      return;
    Constant.SearchStat = true;
    if (this.DataGridView2.RowCount > 0)
    {
      this.txtSearchbox.Focus();
      this.Close();
    }
  }

  private void txtSearchbox_TextChanged(object sender, EventArgs e)
  {
    int num1 = checked (this.DataGridView2.RowCount - 1);
    int num2 = 0;
    while (num2 <= num1)
    {
      this.DataGridView2.Rows.Clear();
      checked { ++num2; }
    }
    int num3 = -1;
    this.SearchType = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSearchType.Text, "Search By Name", false) != 0 ? 7 : 8;
    int index1;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountType.Text, "All", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchbox.Text, "", false) == 0)
      {
        if (this.SearchType == 7)
        {
          int num4 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1);
          int index2 = 0;
          while (index2 <= num4)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index2].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index2].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index2].Cells[14].Value.ToString().Trim();
            checked { ++index2; }
          }
          this.DataGridView2.ClearSelection();
        }
        else
        {
          int num5 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccountName.RowCount - 1);
          int index3 = 0;
          while (index3 <= num5)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index3].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index3].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index3].Cells[14].Value.ToString().Trim();
            checked { ++index3; }
          }
          this.DataGridView2.ClearSelection();
        }
      }
      else
      {
        int num6 = checked (MyProject.Forms.frmConstantGrid.DataGridViewAccount.RowCount - 1);
        int index4 = 0;
        while (index4 <= num6)
        {
          if (this.SearchType == 8)
          {
            int num7 = checked (Strings.Len(MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index4].Cells[this.SearchType].Value.ToString().Trim()) - 1);
            int Start = 1;
            while (Start <= num7)
            {
              if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index4].Cells[this.SearchType].Value.ToString().Trim(), Start, Strings.Len(this.txtSearchbox.Text)))) == 1)
              {
                this.DataGridView2.Rows.Add();
                this.DataGridView2.Rows[index1].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index4].Cells[0].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index4].Cells[7].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index4].Cells[8].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index4].Cells[23].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index4].Cells[24].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index4].Cells[25].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index4].Cells[2].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index4].Cells[3].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index4].Cells[4].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccountName.Rows[index4].Cells[14].Value.ToString().Trim();
                checked { ++index1; }
                if (index1 == 1)
                  num3 = index4;
              }
              checked { ++Start; }
            }
          }
          else if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[this.SearchType].Value.ToString().Trim(), 1, Strings.Len(this.txtSearchbox.Text)))) == 1)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index1].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewAccount.Rows[index4].Cells[14].Value.ToString().Trim();
            checked { ++index1; }
            if (index1 == 1)
              num3 = index4;
          }
          checked { ++index4; }
        }
        if (num3 == -1)
          this.DataGridView2.ClearSelection();
        else
          this.DataGridView2.Rows[0].Selected = true;
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountType.Text, "Cash", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchbox.Text, "", false) == 0)
      {
        if (this.SearchType == 7)
        {
          int num8 = checked (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount - 1);
          int index5 = 0;
          while (index5 <= num8)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index5].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index5].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index5].Cells[14].Value.ToString().Trim();
            checked { ++index5; }
          }
          this.DataGridView2.ClearSelection();
        }
        else
        {
          int num9 = checked (MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.RowCount - 1);
          int index6 = 0;
          while (index6 <= num9)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index6].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index6].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index6].Cells[14].Value.ToString().Trim();
            checked { ++index6; }
          }
          this.DataGridView2.ClearSelection();
        }
      }
      else
      {
        int num10 = checked (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount - 1);
        int index7 = 0;
        while (index7 <= num10)
        {
          if (this.SearchType == 8)
          {
            int num11 = checked (Strings.Len(MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index7].Cells[this.SearchType].Value.ToString().Trim()) - 1);
            int Start = 1;
            while (Start <= num11)
            {
              if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index7].Cells[this.SearchType].Value.ToString().Trim(), Start, Strings.Len(this.txtSearchbox.Text)))) == 1)
              {
                this.DataGridView2.Rows.Add();
                this.DataGridView2.Rows[index1].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index7].Cells[0].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index7].Cells[7].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index7].Cells[8].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index7].Cells[23].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index7].Cells[24].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index7].Cells[25].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index7].Cells[2].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index7].Cells[3].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index7].Cells[4].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccountName.Rows[index7].Cells[14].Value.ToString().Trim();
                checked { ++index1; }
                if (index1 == 1)
                  num3 = index7;
              }
              checked { ++Start; }
            }
          }
          else if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[this.SearchType].Value.ToString().Trim(), 1, Strings.Len(this.txtSearchbox.Text)))) == 1)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index1].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.Rows[index7].Cells[14].Value.ToString().Trim();
            checked { ++index1; }
            if (index1 == 1)
              num3 = index7;
          }
          checked { ++index7; }
        }
        if (num3 == -1)
          this.DataGridView2.ClearSelection();
        else
          this.DataGridView2.Rows[0].Selected = true;
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountType.Text, "NonCash", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchbox.Text, "", false) == 0)
      {
        if (this.SearchType == 7)
        {
          int num12 = checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount - 1);
          int index8 = 0;
          while (index8 <= num12)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index8].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index8].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index8].Cells[14].Value.ToString().Trim();
            checked { ++index8; }
          }
          this.DataGridView2.ClearSelection();
        }
        else
        {
          int num13 = checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.RowCount - 1);
          int index9 = 0;
          while (index9 <= num13)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index9].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index9].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index9].Cells[14].Value.ToString().Trim();
            checked { ++index9; }
          }
          this.DataGridView2.ClearSelection();
        }
      }
      else
      {
        int num14 = checked (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount - 1);
        int index10 = 0;
        while (index10 <= num14)
        {
          if (this.SearchType == 8)
          {
            int num15 = checked (Strings.Len(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index10].Cells[this.SearchType].Value.ToString().Trim()) - 1);
            int Start = 1;
            while (Start <= num15)
            {
              if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index10].Cells[this.SearchType].Value.ToString().Trim(), Start, Strings.Len(this.txtSearchbox.Text)))) == 1)
              {
                this.DataGridView2.Rows.Add();
                this.DataGridView2.Rows[index1].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index10].Cells[0].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index10].Cells[7].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index10].Cells[8].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index10].Cells[23].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index10].Cells[24].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index10].Cells[25].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index10].Cells[2].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index10].Cells[3].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index10].Cells[4].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccountName.Rows[index10].Cells[14].Value.ToString().Trim();
                checked { ++index1; }
                if (index1 == 1)
                  num3 = index10;
              }
              checked { ++Start; }
            }
          }
          else if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[this.SearchType].Value.ToString().Trim(), 1, Strings.Len(this.txtSearchbox.Text)))) == 1)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index1].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.Rows[index10].Cells[14].Value.ToString().Trim();
            checked { ++index1; }
            if (index1 == 1)
              num3 = index10;
          }
          checked { ++index10; }
        }
        if (num3 == -1)
          this.DataGridView2.ClearSelection();
        else
          this.DataGridView2.Rows[0].Selected = true;
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblAccountType.Text, "Billing", false) == 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchbox.Text, "", false) == 0)
      {
        if (this.SearchType == 7)
        {
          int num16 = checked (MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.RowCount - 1);
          int index11 = 0;
          while (index11 <= num16)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index11].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index11].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index11].Cells[14].Value.ToString().Trim();
            checked { ++index11; }
          }
          this.DataGridView2.ClearSelection();
        }
        else
        {
          int num17 = checked (MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.RowCount - 1);
          int index12 = 0;
          while (index12 <= num17)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index12].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index12].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index12].Cells[14].Value.ToString().Trim();
            checked { ++index12; }
          }
          this.DataGridView2.ClearSelection();
        }
      }
      else
      {
        int num18 = checked (MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.RowCount - 1);
        int index13 = 0;
        while (index13 <= num18)
        {
          if (this.SearchType == 8)
          {
            int num19 = checked (Strings.Len(MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[this.SearchType].Value.ToString().Trim()) - 1);
            int Start = 1;
            while (Start <= num19)
            {
              if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[this.SearchType].Value.ToString().Trim(), Start, Strings.Len(this.txtSearchbox.Text)))) == 1)
              {
                this.DataGridView2.Rows.Add();
                this.DataGridView2.Rows[index1].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[0].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[7].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[8].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[23].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[24].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[25].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[2].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[3].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[4].Value.ToString().Trim();
                this.DataGridView2.Rows[index1].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[14].Value.ToString().Trim();
                checked { ++index1; }
                if (index1 == 1)
                  num3 = index13;
              }
              checked { ++Start; }
            }
          }
          else if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[this.SearchType].Value.ToString().Trim(), 1, Strings.Len(this.txtSearchbox.Text)))) == 1)
          {
            this.DataGridView2.Rows.Add();
            this.DataGridView2.Rows[index1].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[0].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[7].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[8].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[23].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[24].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[25].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[2].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[3].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[4].Value.ToString().Trim();
            this.DataGridView2.Rows[index1].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewBillingAccount.Rows[index13].Cells[14].Value.ToString().Trim();
            checked { ++index1; }
            if (index1 == 1)
              num3 = index13;
          }
          checked { ++index13; }
        }
        if (num3 == -1)
          this.DataGridView2.ClearSelection();
        else
          this.DataGridView2.Rows[0].Selected = true;
      }
    }
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
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "1", false) == 0)
    {
      this.btnAdd.Enabled = true;
    }
    else
    {
      this.btnAdd.Enabled = false;
      this.btnUpdate.Enabled = false;
      this.btnDelete.Enabled = false;
    }
  }

  private void btnok_Click(object sender, EventArgs e)
  {
    Constant.SearchStat = true;
    if (this.DataGridView2.RowCount <= 0)
      return;
    this.txtSearchbox.Focus();
    this.Close();
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmreportAccountList.ShowDialog();
    MyProject.Forms.frmreportAccountList = (frmreportAccountList) null;
  }

  private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
  {
    if (this.btnok.Visible)
    {
      Constant.SearchStat = true;
      if (this.DataGridView2.RowCount <= 0)
        return;
      this.txtSearchbox.Focus();
      this.Close();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0)
    {
      if (this.DataGridView2.SelectedRows.Count == 1)
      {
        Constant.SearchStat = true;
        frmAccountDetail frmAccountDetail = new frmAccountDetail();
        frmAccountDetail.Text = " Account Update ";
        frmAccountDetail.btnSave.Text = "&Update";
        int num = (int) frmAccountDetail.ShowDialog();
        MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
        this.txtSearchbox.Text = "";
      }
      else
      {
        int num1 = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
      }
      this.GetFillGrid();
      this.txtSearchbox.Focus();
    }
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
    if (this.btnok.Visible)
    {
      Constant.SearchStat = true;
      if (this.DataGridView2.RowCount > 0)
      {
        this.txtSearchbox.Focus();
        this.Close();
      }
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0)
    {
      if (this.DataGridView2.SelectedRows.Count == 1)
      {
        Constant.SearchStat = true;
        frmAccountDetail frmAccountDetail = new frmAccountDetail();
        frmAccountDetail.Text = " Account Update ";
        frmAccountDetail.btnSave.Text = "&Update";
        int num = (int) frmAccountDetail.ShowDialog();
        MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
        this.txtSearchbox.Text = "";
      }
      else
      {
        int num1 = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
      }
      this.GetFillGrid();
      this.txtSearchbox.Focus();
    }
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      Constant.SearchStat = true;
      int num = (int) new frmReportAccountLedgerShow().ShowDialog();
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) Constant.SMsgSelectRecord, Title: (object) Constant.SIMsgInfo);
    }
  }
}
