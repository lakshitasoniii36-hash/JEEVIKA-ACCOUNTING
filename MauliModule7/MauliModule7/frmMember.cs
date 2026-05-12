// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMember
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
public class frmMember : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("txtSearchbox")]
  private TextBox _txtSearchbox;
  [AccessedThroughProperty("btnok")]
  private Button _btnok;
  [AccessedThroughProperty("lblSearchType")]
  private Label _lblSearchType;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("btnShowDetail")]
  private Button _btnShowDetail;
  private int SearchType;

  [DebuggerNonUserCode]
  static frmMember()
  {
  }

  public frmMember()
  {
    this.Load += new EventHandler(this.frmMember_Load);
    this.KeyDown += new KeyEventHandler(this.frmMember_KeyDown);
    frmMember.__ENCAddToList((object) this);
    this.SearchType = 7;
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMember.__ENCList)
    {
      if (frmMember.__ENCList.Count == frmMember.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMember.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMember.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMember.__ENCList[index1] = frmMember.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMember.__ENCList.RemoveRange(index1, checked (frmMember.__ENCList.Count - index1));
        frmMember.__ENCList.Capacity = frmMember.__ENCList.Count;
      }
      frmMember.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMember));
    this.btnAdd = new Button();
    this.btnUpdate = new Button();
    this.btnDelete = new Button();
    this.btnExit = new Button();
    this.txtSearchbox = new TextBox();
    this.btnok = new Button();
    this.lblSearchType = new Label();
    this.DataGridView2 = new DataGridView();
    this.btnPrint = new Button();
    this.Label1 = new Label();
    this.Button2 = new Button();
    this.btnShowDetail = new Button();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.SuspendLayout();
    this.btnAdd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnAdd1 = this.btnAdd;
    Point point1 = new Point(227, 530);
    Point point2 = point1;
    btnAdd1.Location = point2;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnAdd2.Size = size2;
    this.btnAdd.TabIndex = 3;
    this.btnAdd.Text = "&Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(332, 531);
    Point point3 = point1;
    btnUpdate1.Location = point3;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnUpdate2.Size = size3;
    this.btnUpdate.TabIndex = 4;
    this.btnUpdate.Text = "A&lter";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.btnDelete.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(437, 531);
    Point point4 = point1;
    btnDelete1.Location = point4;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnDelete2.Size = size4;
    this.btnDelete.TabIndex = 5;
    this.btnDelete.Text = "&Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(749, 531);
    Point point5 = point1;
    btnExit1.Location = point5;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnExit2.Size = size5;
    this.btnExit.TabIndex = 7;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.txtSearchbox.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtSearchbox1 = this.txtSearchbox;
    point1 = new Point(153, 14);
    Point point6 = point1;
    txtSearchbox1.Location = point6;
    this.txtSearchbox.Name = "txtSearchbox";
    TextBox txtSearchbox2 = this.txtSearchbox;
    size1 = new Size(84, 21);
    Size size6 = size1;
    txtSearchbox2.Size = size6;
    this.txtSearchbox.TabIndex = 0;
    this.btnok.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnok1 = this.btnok;
    point1 = new Point(123, 530);
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
    this.lblSearchType.AutoSize = true;
    this.lblSearchType.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblSearchType1 = this.lblSearchType;
    point1 = new Point(45, 17);
    Point point8 = point1;
    lblSearchType1.Location = point8;
    this.lblSearchType.Name = "lblSearchType";
    Label lblSearchType2 = this.lblSearchType;
    size1 = new Size(94, 15);
    Size size8 = size1;
    lblSearchType2.Size = size8;
    this.lblSearchType.TabIndex = 7;
    this.lblSearchType.Text = "Search By Code";
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
    point1 = new Point(46, 49);
    Point point9 = point1;
    dataGridView2_1.Location = point9;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(900, 474);
    Size size9 = size1;
    dataGridView2_2.Size = size9;
    this.DataGridView2.TabIndex = 1;
    this.btnPrint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(542, 531);
    Point point10 = point1;
    btnPrint1.Location = point10;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size10 = size1;
    btnPrint2.Size = size10;
    this.btnPrint.TabIndex = 6;
    this.btnPrint.Text = "&Print List";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = SystemColors.Desktop;
    Label label1_1 = this.Label1;
    point1 = new Point(283, 16 /*0x10*/);
    Point point11 = point1;
    label1_1.Location = point11;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(660, 15);
    Size size11 = size1;
    label1_2.Size = size11;
    this.Label1.TabIndex = 20;
    this.Label1.Text = " F3 - Namewise List   ||   F4 - CodeWise List    ||   Tab - Next Field  ||  Shift + Tab - Prev. Field    ||   Ctrl + Tab - Exit from Grid";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(783, 422);
    Point point12 = point1;
    button2_1.Location = point12;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(35, 30);
    Size size12 = size1;
    button2_2.Size = size12;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.btnShowDetail.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnShowDetail1 = this.btnShowDetail;
    point1 = new Point(644, 531);
    Point point13 = point1;
    btnShowDetail1.Location = point13;
    this.btnShowDetail.Name = "btnShowDetail";
    Button btnShowDetail2 = this.btnShowDetail;
    size1 = new Size(99, 33);
    Size size13 = size1;
    btnShowDetail2.Size = size13;
    this.btnShowDetail.TabIndex = 84;
    this.btnShowDetail.Text = "S&how Detail";
    this.btnShowDetail.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 571);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.btnShowDetail);
    this.Controls.Add((Control) this.Label1);
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
    this.Name = nameof (frmMember);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Master";
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual Label lblSearchType
  {
    [DebuggerNonUserCode] get => this._lblSearchType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSearchType = value;
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

  internal virtual Button btnShowDetail
  {
    [DebuggerNonUserCode] get => this._btnShowDetail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnShowDetail_Click);
      if (this._btnShowDetail != null)
        this._btnShowDetail.Click -= eventHandler;
      this._btnShowDetail = value;
      if (this._btnShowDetail == null)
        return;
      this._btnShowDetail.Click += eventHandler;
    }
  }

  private void frmMember_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmMember_Load(object sender, EventArgs e)
  {
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
    if (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount == 0)
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
    this.DataGridView2.ColumnCount = 13;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.Columns[0].Visible = false;
    this.SearchType = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSearchType.Text, "Search By Name", false) != 0 ? 7 : 14;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchbox.Text, "", false) == 0)
    {
      int num = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        this.DataGridView2.Rows.Add();
        this.DataGridView2.Rows[index].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[0].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[7].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[8].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[9].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[10].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[11].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[14].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[15].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[16 /*0x10*/].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[2].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[10].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[3].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[11].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[4].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[12].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[34].Value, MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[35].Value);
        checked { ++index; }
      }
      this.DataGridView2.ClearSelection();
    }
    else
    {
      int num = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index1 = 0;
      while (index1 <= num)
      {
        if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[this.SearchType].Value.ToString().Trim(), 1, Strings.Len(this.txtSearchbox.Text)))) == 1)
        {
          this.DataGridView2.Rows.Add();
          int index2;
          this.DataGridView2.Rows[index2].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[8].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[9].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[10].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[11].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[14].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[15].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[16 /*0x10*/].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[2].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[10].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[3].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[11].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[4].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[12].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[34].Value, MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[35].Value);
          checked { ++index2; }
          if (index2 == 1)
            ;
        }
        checked { ++index1; }
      }
    }
    this.DataGridView2.Columns[1].HeaderText = "Code";
    this.DataGridView2.Columns[2].HeaderText = "Bldg.";
    this.DataGridView2.Columns[3].HeaderText = "Wing";
    this.DataGridView2.Columns[4].HeaderText = "Type";
    this.DataGridView2.Columns[5].HeaderText = "No.";
    this.DataGridView2.Columns[6].HeaderText = "Name1";
    this.DataGridView2.Columns[7].HeaderText = "Name2";
    this.DataGridView2.Columns[8].HeaderText = "Name3";
    this.DataGridView2.Columns[12].HeaderText = "Balance";
    this.DataGridView2.Columns[2].Width = 100;
    this.DataGridView2.Columns[3].Width = 50;
    this.DataGridView2.Columns[4].Width = 100;
    this.DataGridView2.Columns[5].Width = 100;
    this.DataGridView2.Columns[6].Width = 500;
    this.DataGridView2.Columns[7].Visible = false;
    this.DataGridView2.Columns[8].Visible = false;
    this.DataGridView2.Columns[9].Visible = false;
    this.DataGridView2.Columns[10].Visible = false;
    this.DataGridView2.Columns[11].Visible = false;
    this.DataGridView2.Columns[12].Visible = false;
    this.DataGridView2.ClearSelection();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    frmMemberdetails frmMemberdetails = new frmMemberdetails();
    frmMemberdetails.Text = " New Member Creation ";
    frmMemberdetails.btnSave.Text = "&Save";
    int num = (int) frmMemberdetails.ShowDialog();
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
      frmMemberdetails frmMemberdetails = new frmMemberdetails();
      frmMemberdetails.Text = " Member Update ";
      frmMemberdetails.btnSave.Text = "&Update";
      int num = (int) frmMemberdetails.ShowDialog();
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
      frmMemberdetails frmMemberdetails = new frmMemberdetails();
      frmMemberdetails.Text = " Member Delete ";
      frmMemberdetails.btnSave.Text = "&Delete";
      int num = (int) frmMemberdetails.ShowDialog();
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
      this.lblSearchType.Text = "Search By Code";
    if (e.KeyCode == Keys.F3)
      this.lblSearchType.Text = "Search By Name";
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
    this.SearchType = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblSearchType.Text, "Search By Name", false) != 0 ? 7 : 14;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtSearchbox.Text, "", false) == 0)
    {
      int num4 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index = 0;
      while (index <= num4)
      {
        this.DataGridView2.Rows.Add();
        this.DataGridView2.Rows[index].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[0].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[7].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[8].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[9].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[10].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[11].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[14].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[15].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[16 /*0x10*/].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[2].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[10].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[3].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[11].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[4].Value.ToString().Trim();
        this.DataGridView2.Rows[index].Cells[12].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[34].Value, MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index].Cells[35].Value);
        checked { ++index; }
      }
      this.DataGridView2.ClearSelection();
    }
    else
    {
      int num5 = checked (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount - 1);
      int index1 = 0;
      while (index1 <= num5)
      {
        int index2;
        if (this.SearchType == 14)
        {
          int num6 = checked (Strings.Len(MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[this.SearchType].Value.ToString().Trim()) - 1);
          int Start = 1;
          while (Start <= num6)
          {
            if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[this.SearchType].Value.ToString().Trim(), Start, Strings.Len(this.txtSearchbox.Text)))) == 1)
            {
              this.DataGridView2.Rows.Add();
              this.DataGridView2.Rows[index2].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[0].Value.ToString().Trim();
              this.DataGridView2.Rows[index2].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[7].Value.ToString().Trim();
              this.DataGridView2.Rows[index2].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[8].Value.ToString().Trim();
              this.DataGridView2.Rows[index2].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[9].Value.ToString().Trim();
              this.DataGridView2.Rows[index2].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[10].Value.ToString().Trim();
              this.DataGridView2.Rows[index2].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[11].Value.ToString().Trim();
              this.DataGridView2.Rows[index2].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[14].Value.ToString().Trim();
              this.DataGridView2.Rows[index2].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[15].Value.ToString().Trim();
              this.DataGridView2.Rows[index2].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[16 /*0x10*/].Value.ToString().Trim();
              this.DataGridView2.Rows[index2].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[2].Value.ToString().Trim();
              this.DataGridView2.Rows[index2].Cells[10].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[3].Value.ToString().Trim();
              this.DataGridView2.Rows[index2].Cells[11].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[4].Value.ToString().Trim();
              this.DataGridView2.Rows[index2].Cells[12].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[34].Value, MyProject.Forms.frmConstantGrid.DataGridViewMemberName.Rows[index1].Cells[35].Value);
              checked { ++index2; }
              if (index2 == 1)
                num3 = index1;
            }
            checked { ++Start; }
          }
        }
        else if (Strings.InStr(Strings.UCase(Strings.Trim(this.txtSearchbox.Text)), Strings.UCase(Strings.Mid(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[this.SearchType].Value.ToString().Trim(), 1, Strings.Len(this.txtSearchbox.Text)))) == 1)
        {
          this.DataGridView2.Rows.Add();
          this.DataGridView2.Rows[index2].Cells[0].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[0].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[1].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[7].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[2].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[8].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[3].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[9].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[4].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[10].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[5].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[11].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[6].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[14].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[7].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[15].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[8].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[16 /*0x10*/].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[9].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[2].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[10].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[3].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[11].Value = (object) MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[4].Value.ToString().Trim();
          this.DataGridView2.Rows[index2].Cells[12].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[34].Value, MyProject.Forms.frmConstantGrid.DataGridViewMember.Rows[index1].Cells[35].Value);
          checked { ++index2; }
          if (index2 == 1)
            num3 = index1;
        }
        checked { ++index1; }
      }
      if (num3 == -1)
        this.DataGridView2.ClearSelection();
      else
        this.DataGridView2.Rows[0].Selected = true;
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
    int num = (int) MyProject.Forms.frmReportMemSignList.ShowDialog();
    MyProject.Forms.frmReportMemSignList = (frmReportMemSignList) null;
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
        frmMemberdetails frmMemberdetails = new frmMemberdetails();
        frmMemberdetails.Text = " Member Update ";
        frmMemberdetails.btnSave.Text = "&Update";
        int num = (int) frmMemberdetails.ShowDialog();
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
        frmMemberdetails frmMemberdetails = new frmMemberdetails();
        frmMemberdetails.Text = " Member Update ";
        frmMemberdetails.btnSave.Text = "&Update";
        int num = (int) frmMemberdetails.ShowDialog();
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

  private void btnShowDetail_Click(object sender, EventArgs e)
  {
    if (this.DataGridView2.SelectedRows.Count == 1)
    {
      frmMemberShowdetails memberShowdetails = new frmMemberShowdetails();
      memberShowdetails.Text = " Member Details ";
      memberShowdetails.btnSave.Text = "&Update";
      int num = (int) memberShowdetails.ShowDialog();
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
