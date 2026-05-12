// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMemberBillMaster
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
public class frmMemberBillMaster : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("btnAutoMasterAdd")]
  private Button _btnAutoMasterAdd;
  [AccessedThroughProperty("btnAutoMasterMultiply")]
  private Button _btnAutoMasterMultiply;
  [AccessedThroughProperty("lblMemForm")]
  private Label _lblMemForm;
  [AccessedThroughProperty("lblMemTo")]
  private Label _lblMemTo;
  [AccessedThroughProperty("grpvisible")]
  private GroupBox _grpvisible;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("GroupBox2")]
  private GroupBox _GroupBox2;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("lblType")]
  private Label _lblType;
  [AccessedThroughProperty("lblBillMasterNo")]
  private Label _lblBillMasterNo;
  private int i;
  private int j;
  private int vlcell;
  private double htot;
  private double vtot;

  [DebuggerNonUserCode]
  static frmMemberBillMaster()
  {
  }

  [DebuggerNonUserCode]
  public frmMemberBillMaster()
  {
    this.Load += new EventHandler(this.frmMemberBillMaster_Load);
    frmMemberBillMaster.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMemberBillMaster.__ENCList)
    {
      if (frmMemberBillMaster.__ENCList.Count == frmMemberBillMaster.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMemberBillMaster.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMemberBillMaster.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMemberBillMaster.__ENCList[index1] = frmMemberBillMaster.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMemberBillMaster.__ENCList.RemoveRange(index1, checked (frmMemberBillMaster.__ENCList.Count - index1));
        frmMemberBillMaster.__ENCList.Capacity = frmMemberBillMaster.__ENCList.Count;
      }
      frmMemberBillMaster.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.btnExit = new Button();
    this.btnUpdate = new Button();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.btnAutoMasterAdd = new Button();
    this.btnAutoMasterMultiply = new Button();
    this.lblMemForm = new Label();
    this.lblMemTo = new Label();
    this.grpvisible = new GroupBox();
    this.lblType = new Label();
    this.DataGridView4 = new DataGridView();
    this.btnPrint = new Button();
    this.GroupBox1 = new GroupBox();
    this.GroupBox2 = new GroupBox();
    this.Button2 = new Button();
    this.lblBillMasterNo = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpvisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.GroupBox1.SuspendLayout();
    this.GroupBox2.SuspendLayout();
    this.SuspendLayout();
    Button btnExit1 = this.btnExit;
    Point point1 = new Point(130, 13);
    Point point2 = point1;
    btnExit1.Location = point2;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnExit2.Size = size2;
    this.btnExit.TabIndex = 2;
    this.btnExit.Text = "&Cancel";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(25, 12);
    Point point3 = point1;
    btnUpdate1.Location = point3;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnUpdate2.Size = size3;
    this.btnUpdate.TabIndex = 1;
    this.btnUpdate.Text = "&Save";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(48 /*0x30*/, 10);
    Point point4 = point1;
    dataGridView1_1.Location = point4;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(19, 24);
    Size size4 = size1;
    dataGridView1_2.Size = size4;
    this.DataGridView1.TabIndex = 5;
    this.DataGridView1.Visible = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(22, 10);
    Point point5 = point1;
    dataGridView2_1.Location = point5;
    this.DataGridView2.Name = "DataGridView2";
    this.DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(20, 24);
    Size size5 = size1;
    dataGridView2_2.Size = size5;
    this.DataGridView2.TabIndex = 10;
    this.DataGridView2.Visible = false;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView3.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Arial", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView3.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(0, 0);
    Point point6 = point1;
    dataGridView3_1.Location = point6;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(994, 500);
    Size size6 = size1;
    dataGridView3_2.Size = size6;
    this.DataGridView3.TabIndex = 0;
    Button btnAutoMasterAdd1 = this.btnAutoMasterAdd;
    point1 = new Point(12, 11);
    Point point7 = point1;
    btnAutoMasterAdd1.Location = point7;
    this.btnAutoMasterAdd.Name = "btnAutoMasterAdd";
    Button btnAutoMasterAdd2 = this.btnAutoMasterAdd;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnAutoMasterAdd2.Size = size7;
    this.btnAutoMasterAdd.TabIndex = 12;
    this.btnAutoMasterAdd.Text = "Auto Master &Add";
    this.btnAutoMasterAdd.UseVisualStyleBackColor = true;
    Button autoMasterMultiply1 = this.btnAutoMasterMultiply;
    point1 = new Point(117, 11);
    Point point8 = point1;
    autoMasterMultiply1.Location = point8;
    this.btnAutoMasterMultiply.Name = "btnAutoMasterMultiply";
    Button autoMasterMultiply2 = this.btnAutoMasterMultiply;
    size1 = new Size(111, 33);
    Size size8 = size1;
    autoMasterMultiply2.Size = size8;
    this.btnAutoMasterMultiply.TabIndex = 13;
    this.btnAutoMasterMultiply.Text = "Auto Master &Multiply";
    this.btnAutoMasterMultiply.UseVisualStyleBackColor = true;
    this.lblMemForm.AutoSize = true;
    Label lblMemForm1 = this.lblMemForm;
    point1 = new Point(130, 16 /*0x10*/);
    Point point9 = point1;
    lblMemForm1.Location = point9;
    this.lblMemForm.Name = "lblMemForm";
    Label lblMemForm2 = this.lblMemForm;
    size1 = new Size(13, 13);
    Size size9 = size1;
    lblMemForm2.Size = size9;
    this.lblMemForm.TabIndex = 14;
    this.lblMemForm.Text = "0";
    this.lblMemTo.AutoSize = true;
    Label lblMemTo1 = this.lblMemTo;
    point1 = new Point(73, 14);
    Point point10 = point1;
    lblMemTo1.Location = point10;
    this.lblMemTo.Name = "lblMemTo";
    Label lblMemTo2 = this.lblMemTo;
    size1 = new Size(13, 13);
    Size size10 = size1;
    lblMemTo2.Size = size10;
    this.lblMemTo.TabIndex = 15;
    this.lblMemTo.Text = "0";
    this.grpvisible.Controls.Add((Control) this.lblBillMasterNo);
    this.grpvisible.Controls.Add((Control) this.lblType);
    this.grpvisible.Controls.Add((Control) this.DataGridView4);
    this.grpvisible.Controls.Add((Control) this.lblMemForm);
    this.grpvisible.Controls.Add((Control) this.lblMemTo);
    this.grpvisible.Controls.Add((Control) this.DataGridView1);
    this.grpvisible.Controls.Add((Control) this.DataGridView2);
    GroupBox grpvisible1 = this.grpvisible;
    point1 = new Point(797, 511 /*0x01FF*/);
    Point point11 = point1;
    grpvisible1.Location = point11;
    this.grpvisible.Name = "grpvisible";
    GroupBox grpvisible2 = this.grpvisible;
    size1 = new Size(149, 37);
    Size size11 = size1;
    grpvisible2.Size = size11;
    this.grpvisible.TabIndex = 16 /*0x10*/;
    this.grpvisible.TabStop = false;
    this.grpvisible.Text = "GroupBox2";
    this.lblType.AutoSize = true;
    Label lblType1 = this.lblType;
    point1 = new Point(111, 16 /*0x10*/);
    Point point12 = point1;
    lblType1.Location = point12;
    this.lblType.Name = "lblType";
    Label lblType2 = this.lblType;
    size1 = new Size(13, 13);
    Size size12 = size1;
    lblType2.Size = size12;
    this.lblType.TabIndex = 17;
    this.lblType.Text = "0";
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(73, 10);
    Point point13 = point1;
    dataGridView4_1.Location = point13;
    this.DataGridView4.Name = "DataGridView4";
    this.DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(20, 24);
    Size size13 = size1;
    dataGridView4_2.Size = size13;
    this.DataGridView4.TabIndex = 16 /*0x10*/;
    this.DataGridView4.Visible = false;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(234, 11);
    Point point14 = point1;
    btnPrint1.Location = point14;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size14 = size1;
    btnPrint2.Size = size14;
    this.btnPrint.TabIndex = 17;
    this.btnPrint.Text = "&Print List";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.GroupBox1.Controls.Add((Control) this.btnAutoMasterAdd);
    this.GroupBox1.Controls.Add((Control) this.btnPrint);
    this.GroupBox1.Controls.Add((Control) this.btnAutoMasterMultiply);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(12, 513);
    Point point15 = point1;
    groupBox1_1.Location = point15;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(341, 47);
    Size size15 = size1;
    groupBox1_2.Size = size15;
    this.GroupBox1.TabIndex = 18;
    this.GroupBox1.TabStop = false;
    this.GroupBox2.Controls.Add((Control) this.btnUpdate);
    this.GroupBox2.Controls.Add((Control) this.btnExit);
    this.GroupBox2.Controls.Add((Control) this.Button2);
    GroupBox groupBox2_1 = this.GroupBox2;
    point1 = new Point(368, 512 /*0x0200*/);
    Point point16 = point1;
    groupBox2_1.Location = point16;
    this.GroupBox2.Name = "GroupBox2";
    GroupBox groupBox2_2 = this.GroupBox2;
    size1 = new Size(256 /*0x0100*/, 48 /*0x30*/);
    Size size16 = size1;
    groupBox2_2.Size = size16;
    this.GroupBox2.TabIndex = 19;
    this.GroupBox2.TabStop = false;
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(203, 14);
    Point point17 = point1;
    button2_1.Location = point17;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 30);
    Size size17 = size1;
    button2_2.Size = size17;
    this.Button2.TabIndex = 83;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.lblBillMasterNo.AutoSize = true;
    Label lblBillMasterNo1 = this.lblBillMasterNo;
    point1 = new Point(68, 12);
    Point point18 = point1;
    lblBillMasterNo1.Location = point18;
    this.lblBillMasterNo.Name = "lblBillMasterNo";
    Label lblBillMasterNo2 = this.lblBillMasterNo;
    size1 = new Size(13, 13);
    Size size18 = size1;
    lblBillMasterNo2.Size = size18;
    this.lblBillMasterNo.TabIndex = 18;
    this.lblBillMasterNo.Text = "0";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(992, 569);
    this.ClientSize = size1;
    this.ControlBox = false;
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.grpvisible);
    this.Controls.Add((Control) this.DataGridView3);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmMemberBillMaster);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Member Bill Master";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpvisible.ResumeLayout(false);
    this.grpvisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox2.ResumeLayout(false);
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
      this._DataGridView2 = value;
    }
  }

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      DataGridViewCellEventHandler cellEventHandler1 = new DataGridViewCellEventHandler(this.DataGridView3_CellContentClick);
      DataGridViewCellValidatingEventHandler validatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView3_CellValidating);
      DataGridViewCellEventHandler cellEventHandler2 = new DataGridViewCellEventHandler(this.DataGridView3_CellEndEdit);
      if (this._DataGridView3 != null)
      {
        this._DataGridView3.CellContentClick -= cellEventHandler1;
        this._DataGridView3.CellValidating -= validatingEventHandler;
        this._DataGridView3.CellEndEdit -= cellEventHandler2;
      }
      this._DataGridView3 = value;
      if (this._DataGridView3 == null)
        return;
      this._DataGridView3.CellContentClick += cellEventHandler1;
      this._DataGridView3.CellValidating += validatingEventHandler;
      this._DataGridView3.CellEndEdit += cellEventHandler2;
    }
  }

  internal virtual Button btnAutoMasterAdd
  {
    [DebuggerNonUserCode] get => this._btnAutoMasterAdd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAutoMasterAdd_Click);
      if (this._btnAutoMasterAdd != null)
        this._btnAutoMasterAdd.Click -= eventHandler;
      this._btnAutoMasterAdd = value;
      if (this._btnAutoMasterAdd == null)
        return;
      this._btnAutoMasterAdd.Click += eventHandler;
    }
  }

  internal virtual Button btnAutoMasterMultiply
  {
    [DebuggerNonUserCode] get => this._btnAutoMasterMultiply;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAutoMasterMultiply_Click);
      if (this._btnAutoMasterMultiply != null)
        this._btnAutoMasterMultiply.Click -= eventHandler;
      this._btnAutoMasterMultiply = value;
      if (this._btnAutoMasterMultiply == null)
        return;
      this._btnAutoMasterMultiply.Click += eventHandler;
    }
  }

  internal virtual Label lblMemForm
  {
    [DebuggerNonUserCode] get => this._lblMemForm;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemForm = value;
    }
  }

  internal virtual Label lblMemTo
  {
    [DebuggerNonUserCode] get => this._lblMemTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblMemTo = value;
  }

  internal virtual GroupBox grpvisible
  {
    [DebuggerNonUserCode] get => this._grpvisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpvisible = value;
    }
  }

  internal virtual DataGridView DataGridView4
  {
    [DebuggerNonUserCode] get => this._DataGridView4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView4 = value;
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

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
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

  internal virtual Label lblBillMasterNo
  {
    [DebuggerNonUserCode] get => this._lblBillMasterNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblBillMasterNo = value;
    }
  }

  private void frmMemberBillMaster_Load(object sender, EventArgs e)
  {
    this.grpvisible.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "1", false) == 0)
    {
      this.GroupBox1.Visible = true;
      this.GetFillGrid();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "2", false) == 0)
    {
      this.GroupBox1.Visible = false;
      this.GetFillGridOpening();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "3", false) != 0)
      return;
    this.GroupBox1.Visible = false;
    this.GetFillGridSqft();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemForm.Text, "", false) == 0)
      oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocMember.SocMemId,SocMember.MemCode,SocMember.Bldg,SocMember.Wing,SocMember.FlatType,SocMember.FlatNo,SocMember.MemName,SocMember.Sqft,SocMember.NocDetail,SocMember.ParkDetail, SocBillMaster.* FROM SocBillMaster INNER JOIN SocMember ON SocBillMaster.SocMemId = SocMember.SocMemId WHERE (((SocBillMaster.BMasterNo)='{this.lblBillMasterNo.Text.Trim()}')) order by SocMember.MemCode asc", selectConnection);
    else
      oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocMember.SocMemId,SocMember.MemCode,SocMember.Bldg,SocMember.Wing,SocMember.FlatType,SocMember.FlatNo,SocMember.MemName,SocMember.Sqft,SocMember.NocDetail,SocMember.ParkDetail, SocBillMaster.* FROM SocBillMaster INNER JOIN SocMember ON SocBillMaster.SocMemId = SocMember.SocMemId WHERE (((SocMember.MemCode)>= '{this.lblMemForm.Text.Trim()}' AND (SocMember.MemCode)<='{this.lblMemTo.Text.Trim()}' AND (SocBillMaster.BMasterNo)='{this.lblBillMasterNo.Text.Trim()}')) order by SocMember.MemCode asc", selectConnection);
    DataTable dataTable1 = new DataTable("SocBillMaster");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Width = 100;
    this.DataGridView1.Columns[1].Width = 400;
    if (this.DataGridView1.RowCount == 0)
    {
      int num = (int) Interaction.MsgBox((object) "No Record");
      this.btnUpdate.Enabled = false;
    }
    else
      this.btnUpdate.Enabled = true;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId,SocAccount.AccCode,SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocBillSetting");
    oleDbDataAdapter3.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    selectConnection.Close();
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.ColumnCount = checked (this.DataGridView2.RowCount + 12);
    this.vlcell = checked (this.DataGridView2.RowCount + 11);
    this.DataGridView3.RowCount = this.DataGridView1.RowCount;
    this.DataGridView3.Columns[0].Visible = false;
    this.DataGridView3.Columns[1].HeaderText = " Code ";
    this.DataGridView3.Columns[1].Width = 70;
    this.DataGridView3.Columns[1].Frozen = true;
    this.DataGridView3.Columns[2].Visible = false;
    this.DataGridView3.Columns[3].Visible = false;
    this.DataGridView3.Columns[4].Visible = false;
    this.DataGridView3.Columns[5].Visible = false;
    this.DataGridView3.Columns[6].HeaderText = " Name ";
    this.DataGridView3.Columns[9].Frozen = true;
    this.DataGridView3.Columns[7].HeaderText = " Sq.ft. ";
    this.DataGridView3.Columns[8].HeaderText = " NOC Det.";
    this.DataGridView3.Columns[9].HeaderText = " Park Det.";
    this.DataGridView3.Columns[0].ReadOnly = true;
    this.DataGridView3.Columns[1].ReadOnly = true;
    this.DataGridView3.Columns[2].ReadOnly = true;
    this.DataGridView3.Columns[3].ReadOnly = true;
    this.DataGridView3.Columns[4].ReadOnly = true;
    this.DataGridView3.Columns[5].ReadOnly = true;
    this.DataGridView3.Columns[6].ReadOnly = true;
    this.DataGridView3.Columns[7].ReadOnly = true;
    this.DataGridView3.Columns[8].ReadOnly = false;
    this.DataGridView3.Columns[9].ReadOnly = false;
    int num1 = checked (this.DataGridView2.RowCount - 2);
    this.i = 0;
    while (this.i <= num1)
    {
      this.DataGridView3.Columns[checked (this.i + 10)].DefaultCellStyle.Format = "N2";
      this.DataGridView3.Columns[checked (this.i + 10)].ValueType = typeof (double);
      this.DataGridView3.Columns[checked (this.i + 10)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.DataGridView3.Columns[checked (this.i + 10)].HeaderText = this.DataGridView2.Rows[this.i].Cells[6].Value.ToString();
      this.DataGridView3.Columns[checked (this.i + 10)].Width = 70;
      checked { ++this.i; }
    }
    this.DataGridView3.Columns[checked (this.i + 10)].DefaultCellStyle.Format = "N2";
    this.DataGridView3.Columns[checked (this.i + 10)].ValueType = typeof (double);
    this.DataGridView3.Columns[checked (this.i + 10)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView3.Columns[checked (this.i + 10)].HeaderText = " Interest ";
    this.DataGridView3.Columns[checked (this.i + 11)].DefaultCellStyle.Format = "N2";
    this.DataGridView3.Columns[checked (this.i + 11)].ValueType = typeof (double);
    this.DataGridView3.Columns[checked (this.i + 11)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView3.Columns[checked (this.i + 11)].HeaderText = " Total ";
    this.DataGridView3.Columns[checked (this.i + 12)].Width = 5;
    int num2 = checked (this.DataGridView1.RowCount - 1);
    this.i = 0;
    while (this.i <= num2)
    {
      this.htot = 0.0;
      this.DataGridView3.Rows[this.i].Cells[0].Value = (object) this.DataGridView1.Rows[this.i].Cells[0].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[1].Value = (object) this.DataGridView1.Rows[this.i].Cells[1].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[2].Value = (object) this.DataGridView1.Rows[this.i].Cells[2].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[3].Value = (object) this.DataGridView1.Rows[this.i].Cells[3].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[4].Value = (object) this.DataGridView1.Rows[this.i].Cells[4].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[5].Value = (object) this.DataGridView1.Rows[this.i].Cells[5].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[6].Value = (object) this.DataGridView1.Rows[this.i].Cells[6].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[7].Value = (object) this.DataGridView1.Rows[this.i].Cells[7].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[8].Value = (object) this.DataGridView1.Rows[this.i].Cells[8].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[9].Value = (object) this.DataGridView1.Rows[this.i].Cells[9].Value.ToString();
      int num3 = checked (this.DataGridView2.RowCount - 1);
      this.j = 1;
      while (this.j <= num3)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.i].Cells[checked (this.j + 11)].Value.ToString(), "", false) == 0)
          this.DataGridView1.Rows[this.i].Cells[checked (this.j + 11)].Value = (object) 0;
        this.DataGridView3.Rows[this.i].Cells[checked (this.j + 9)].Value = (object) Math.Round(Conversion.Val(this.DataGridView1.Rows[this.i].Cells[checked (this.j + 11)].Value.ToString()), 2);
        this.htot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.htot, this.DataGridView1.Rows[this.i].Cells[checked (this.j + 11)].Value));
        checked { ++this.j; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.i].Cells[33].Value.ToString(), "", false) == 0)
        this.DataGridView1.Rows[this.i].Cells[33].Value = (object) 0;
      this.DataGridView3.Rows[this.i].Cells[checked (this.j + 9)].Value = (object) Math.Round(Conversion.Val(this.DataGridView1.Rows[this.i].Cells[33].Value.ToString()), 2);
      this.htot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.htot, this.DataGridView1.Rows[this.i].Cells[33].Value));
      this.DataGridView3.Rows[this.i].Cells[checked (this.j + 10)].Value = (object) Math.Round(Conversion.Val(this.htot.ToString()), 2);
      this.DataGridView3.Columns[checked (this.j + 10)].ReadOnly = true;
      checked { ++this.i; }
    }
    this.vtot = 0.0;
    this.DataGridView3.Rows.Add();
    int num4 = checked (this.DataGridView3.ColumnCount - 1);
    this.i = 10;
    while (this.i <= num4)
    {
      int num5 = checked (this.DataGridView3.RowCount - 2);
      this.j = 0;
      while (this.j <= num5)
      {
        this.vtot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vtot, this.DataGridView3.Rows[this.j].Cells[this.i].Value));
        checked { ++this.j; }
      }
      this.DataGridView3.Rows[this.j].Cells[this.i].Value = (object) Math.Round(this.vtot, 2);
      this.vtot = 0.0;
      checked { ++this.i; }
    }
    int num6 = checked (this.DataGridView3.RowCount - 1);
    this.i = 0;
    while (this.i <= num6)
    {
      this.DataGridView3.Rows[this.i].ReadOnly = false;
      checked { ++this.i; }
    }
    this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].ReadOnly = true;
    this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[8].Value = (object) "Total";
    this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
    this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
    this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.DataGridView3.Columns[8].Visible = false;
    this.DataGridView3.Columns[9].Visible = false;
    if (MyProject.Forms.frmMemberBillMasterSelect.chkNoc.Checked)
      this.DataGridView3.Columns[8].Visible = true;
    if (MyProject.Forms.frmMemberBillMasterSelect.chkPark.Checked)
      this.DataGridView3.Columns[9].Visible = true;
    DataSet fillGrid;
    return fillGrid;
  }

  private void DataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "3", false) == 0)
      return;
    this.htot = 0.0;
    int num1 = checked (this.vlcell - 2);
    this.j = 10;
    while (this.j <= num1)
    {
      if (Versioned.IsNumeric((object) this.DataGridView3.CurrentRow.Cells[this.j].Value.ToString()))
        this.htot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.htot, this.DataGridView3.CurrentRow.Cells[this.j].Value));
      checked { ++this.j; }
    }
    this.DataGridView3.CurrentRow.Cells[checked (this.vlcell - 1)].Value = (object) Math.Round(Conversion.Val(this.htot.ToString()), 2);
    this.vtot = 0.0;
    int num2 = checked (this.DataGridView3.ColumnCount - 1);
    this.i = 10;
    while (this.i <= num2)
    {
      int num3 = checked (this.DataGridView3.RowCount - 2);
      this.j = 0;
      while (this.j <= num3)
      {
        this.vtot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vtot, this.DataGridView3.Rows[this.j].Cells[this.i].Value));
        checked { ++this.j; }
      }
      this.DataGridView3.Rows[this.j].Cells[this.i].Value = (object) Math.Round(Conversion.Val((object) this.vtot), 2);
      this.vtot = 0.0;
      checked { ++this.i; }
    }
  }

  private void DataGridView3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "3", false) == 0 || !(e.ColumnIndex >= 10 & e.ColumnIndex < this.vlcell))
      return;
    if (!Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(e.FormattedValue)))
    {
      this.DataGridView3.Rows[e.RowIndex].ErrorText = "only numeric value.";
      this.btnUpdate.Enabled = false;
      this.btnExit.Enabled = false;
      e.Cancel = true;
    }
    else
    {
      this.btnUpdate.Enabled = true;
      this.btnExit.Enabled = true;
    }
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "3", false) != 0)
    {
      int num1 = checked (this.DataGridView3.RowCount - 2);
      this.j = 0;
      while (this.j <= num1)
      {
        int vlcell = this.vlcell;
        this.i = 11;
        while (this.i <= vlcell)
        {
          if (!Versioned.IsNumeric((object) this.DataGridView3.Rows[this.j].Cells[checked (this.i - 1)].Value.ToString()))
          {
            this.DataGridView3.Focus();
            this.DataGridView3.Rows[this.j].Cells[checked (this.i - 1)].Selected = true;
            int num2 = (int) Interaction.MsgBox((object) "Not Numeric");
            return;
          }
          checked { ++this.i; }
        }
        checked { ++this.j; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "1", false) == 0)
    {
      int num3 = checked (this.DataGridView3.RowCount - 2);
      this.j = 0;
      while (this.j <= num3)
      {
        string str1 = "update SocBillMaster set ";
        int num4 = checked (this.vlcell - 2);
        this.i = 11;
        while (this.i <= num4)
        {
          str1 = this.i >= 20 ? Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str1 + " Amt" + Strings.Trim(Conversion.Str((object) checked (this.i - 10))) + " = "), this.DataGridView3.Rows[this.j].Cells[checked (this.i - 1)].Value), (object) ",")) : Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str1 + " Amt0" + Strings.Trim(Conversion.Str((object) checked (this.i - 10))) + " = "), this.DataGridView3.Rows[this.j].Cells[checked (this.i - 1)].Value), (object) ","));
          checked { ++this.i; }
        }
        OleDbCommand oleDbCommand1 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str1 + " AmtInt = "), this.DataGridView3.Rows[this.j].Cells[checked (this.i - 1)].Value), (object) ",")) + " AmtTotal = "), this.DataGridView3.Rows[this.j].Cells[this.i].Value), (object) "")) + " where SocMemId ="), this.DataGridView3.Rows[this.j].Cells[0].Value), (object) "")), connection);
        connection.Open();
        oleDbCommand1.ExecuteNonQuery();
        connection.Close();
        string str2 = "";
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.j].Cells[8].Value)))
          this.DataGridView3.Rows[this.j].Cells[8].Value = (object) this.DataGridView3.Rows[this.j].Cells[8].Value.ToString().Replace("'", "''");
        if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.j].Cells[9].Value)))
          this.DataGridView3.Rows[this.j].Cells[9].Value = (object) this.DataGridView3.Rows[this.j].Cells[9].Value.ToString().Replace("'", "''");
        OleDbCommand oleDbCommand2 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "update SocMember set NocDetail = '", this.DataGridView3.Rows[this.j].Cells[8].Value), (object) "', ParkDetail = '"), this.DataGridView3.Rows[this.j].Cells[9].Value), (object) "' where SocMemId ="), this.DataGridView3.Rows[this.j].Cells[0].Value), (object) "")), connection);
        connection.Open();
        oleDbCommand2.ExecuteNonQuery();
        connection.Close();
        str2 = "";
        checked { ++this.j; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "2", false) == 0)
    {
      int num5 = checked (this.DataGridView3.RowCount - 2);
      this.j = 0;
      while (this.j <= num5)
      {
        string str3 = "update RctBif set ";
        int num6 = checked (this.vlcell - 2);
        this.i = 11;
        while (this.i <= num6)
        {
          str3 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str3 + " BAmt" + Strings.Trim(Conversion.Str((object) checked (this.i - 10))) + " = "), this.DataGridView3.Rows[this.j].Cells[checked (this.i - 1)].Value), (object) ", "));
          checked { ++this.i; }
        }
        OleDbCommand oleDbCommand3 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str3 + " BAmt22 = "), this.DataGridView3.Rows[this.j].Cells[checked (this.i - 1)].Value), (object) ", ")) + " BTotal = "), this.DataGridView3.Rows[this.j].Cells[this.i].Value), (object) "")) + " where MemId = "), this.DataGridView3.Rows[this.j].Cells[0].Value), (object) " and Tran_Type = '(Opening)'")), connection);
        connection.Open();
        oleDbCommand3.ExecuteNonQuery();
        connection.Close();
        string str4 = "";
        double num7 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.j].Cells[this.i].Value)) - Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.j].Cells[checked (this.i - 1)].Value)), 2);
        double num8 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.j].Cells[checked (this.i - 1)].Value)), 2);
        double num9 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.j].Cells[2].Value)), 2);
        double num10 = Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.j].Cells[3].Value)), 2);
        OleDbCommand oleDbCommand4 = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocMember set Op_Prin = " + Conversions.ToString(num7) + ", Op_Int = " + Conversions.ToString(num8) + ", Cl_Prin = Cl_Prin + " + Conversions.ToString(num7 - num9) + ", Cl_Int = Cl_Int + " + Conversions.ToString(num8 - num10) + " where SocAccountMainId = "), this.DataGridView3.Rows[this.j].Cells[0].Value), (object) "")), connection);
        connection.Open();
        oleDbCommand4.ExecuteNonQuery();
        connection.Close();
        str4 = "";
        checked { ++this.j; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblType.Text, "3", false) == 0)
    {
      int num = checked (this.DataGridView3.RowCount - 1);
      this.j = 0;
      while (this.j <= num)
      {
        if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(this.DataGridView3.Rows[this.j].Cells[7].Value)))
        {
          OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update SocMember set " + " Sqft = "), this.DataGridView3.Rows[this.j].Cells[7].Value), (object) " ")) + " where SocMemId ="), this.DataGridView3.Rows[this.j].Cells[0].Value), (object) "")), connection);
          connection.Open();
          oleDbCommand.ExecuteNonQuery();
          connection.Close();
        }
        checked { ++this.j; }
      }
    }
    int num11 = (int) Interaction.MsgBox((object) "Updated Sucessfully");
    this.Close();
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnAutoMasterAdd_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmDigAutoMasterAdd.lblHeading.Text = "   AutoMaster Add  ";
    int num1 = (int) MyProject.Forms.frmDigAutoMasterAdd.ShowDialog();
    if (MyProject.Forms.frmDigAutoMasterAdd.DialogResult != DialogResult.OK)
      return;
    int index = 0;
    int num2 = checked (this.DataGridView2.RowCount - 2);
    this.i = 0;
    while (this.i <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[this.i].Cells[0].Value, MyProject.Forms.frmDigAutoMasterAdd.cmbBillSetting.SelectedValue, false))
        index = checked (this.i + 10);
      checked { ++this.i; }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmDigAutoMasterAdd.txtAmount.Text.Trim(), "", false) != 0)
    {
      int num3 = checked (this.DataGridView3.RowCount - 1);
      this.i = 0;
      while (this.i <= num3)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmDigAutoMasterAdd.cmbType.Text.Trim(), "By Amount", false) == 0)
        {
          this.DataGridView3.Rows[this.i].Cells[index].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[this.i].Cells[index].Value, (object) Conversion.Val(MyProject.Forms.frmDigAutoMasterAdd.txtAmount.Text));
          this.DataGridView3.Rows[this.i].Cells[checked (this.DataGridView2.RowCount + 10)].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[this.i].Cells[checked (this.DataGridView2.RowCount + 10)].Value, (object) Conversion.Val(MyProject.Forms.frmDigAutoMasterAdd.txtAmount.Text));
        }
        else
        {
          double Right = Conversions.ToDouble(this.DataGridView3.Rows[this.i].Cells[index].Value);
          this.DataGridView3.Rows[this.i].Cells[index].Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[this.i].Cells[7].Value, (object) Conversion.Val(MyProject.Forms.frmDigAutoMasterAdd.txtAmount.Text));
          this.DataGridView3.Rows[this.i].Cells[checked (this.DataGridView2.RowCount + 10)].Value = Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[this.i].Cells[checked (this.DataGridView2.RowCount + 10)].Value, this.DataGridView3.Rows[this.i].Cells[7].Value), (object) Conversion.Val(MyProject.Forms.frmDigAutoMasterAdd.txtAmount.Text)), (object) Right);
        }
        checked { ++this.i; }
      }
    }
    this.vtot = 0.0;
    int num4 = checked (this.DataGridView3.ColumnCount - 1);
    this.i = 10;
    while (this.i <= num4)
    {
      int num5 = checked (this.DataGridView3.RowCount - 2);
      this.j = 0;
      while (this.j <= num5)
      {
        this.vtot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vtot, this.DataGridView3.Rows[this.j].Cells[this.i].Value));
        checked { ++this.j; }
      }
      this.DataGridView3.Rows[this.j].Cells[this.i].Value = (object) this.vtot;
      this.vtot = 0.0;
      checked { ++this.i; }
    }
  }

  private void btnAutoMasterMultiply_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmDigAutoMasterAdd.lblHeading.Text = "AutoMaster Multiply";
    int num1 = (int) MyProject.Forms.frmDigAutoMasterAdd.ShowDialog();
    if (MyProject.Forms.frmDigAutoMasterAdd.DialogResult != DialogResult.OK)
      return;
    int index = 0;
    int num2 = checked (this.DataGridView2.RowCount - 2);
    this.i = 0;
    while (this.i <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView2.Rows[this.i].Cells[0].Value, MyProject.Forms.frmDigAutoMasterAdd.cmbBillSetting.SelectedValue, false))
        index = checked (this.i + 10);
      checked { ++this.i; }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmDigAutoMasterAdd.txtAmount.Text.Trim(), "", false) != 0)
    {
      int num3 = checked (this.DataGridView3.RowCount - 1);
      this.i = 0;
      while (this.i <= num3)
      {
        double Right = Conversions.ToDouble(this.DataGridView3.Rows[this.i].Cells[index].Value);
        this.DataGridView3.Rows[this.i].Cells[index].Value = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmDigAutoMasterAdd.cmbType.Text.Trim(), "By Amount", false) != 0 ? Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject(this.DataGridView3.Rows[this.i].Cells[7].Value, (object) Conversion.Val(MyProject.Forms.frmDigAutoMasterAdd.txtAmount.Text)) : Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject(this.DataGridView3.Rows[this.i].Cells[index].Value, (object) Conversion.Val(MyProject.Forms.frmDigAutoMasterAdd.txtAmount.Text));
        this.DataGridView3.Rows[this.i].Cells[checked (this.DataGridView2.RowCount + 10)].Value = Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[this.i].Cells[checked (this.DataGridView2.RowCount + 10)].Value, this.DataGridView3.Rows[this.i].Cells[index].Value), (object) Right);
        checked { ++this.i; }
      }
    }
    this.vtot = 0.0;
    int num4 = checked (this.DataGridView3.ColumnCount - 1);
    this.i = 10;
    while (this.i <= num4)
    {
      int num5 = checked (this.DataGridView3.RowCount - 2);
      this.j = 0;
      while (this.j <= num5)
      {
        this.vtot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vtot, this.DataGridView3.Rows[this.j].Cells[this.i].Value));
        checked { ++this.j; }
      }
      this.DataGridView3.Rows[this.j].Cells[this.i].Value = (object) this.vtot;
      this.vtot = 0.0;
      checked { ++this.i; }
    }
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportMemHeadwiseList.ShowDialog();
    MyProject.Forms.frmReportMemHeadwiseList = (frmReportMemHeadwiseList) null;
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  public DataSet GetFillGridOpening()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemForm.Text, "", false) == 0)
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocMember.SocAccountMainId, SocMember.MemCode, SocMember.Op_Prin, SocMember.Op_Int, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.Sqft, RctBif.MemId, RctBif.Tran_Type, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal FROM SocMember INNER JOIN RctBif ON SocMember.SocAccountMainId = RctBif.MemId WHERE(((RctBif.Tran_Type) = '(Opening)')) ORDER BY SocMember.MemCode", selectConnection);
    else
      oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocMember.SocAccountMainId, SocMember.MemCode, SocMember.Op_Prin, SocMember.Op_Int, SocMember.FlatType, SocMember.FlatNo, SocMember.MemName, SocMember.Sqft, RctBif.MemId, RctBif.Tran_Type, RctBif.BAmt1, RctBif.BAmt2, RctBif.BAmt3, RctBif.BAmt4, RctBif.BAmt5, RctBif.BAmt6, RctBif.BAmt7, RctBif.BAmt8, RctBif.BAmt9, RctBif.BAmt10, RctBif.BAmt11, RctBif.BAmt12, RctBif.BAmt13, RctBif.BAmt14, RctBif.BAmt15, RctBif.BAmt16, RctBif.BAmt17, RctBif.BAmt18, RctBif.BAmt19, RctBif.BAmt20, RctBif.BAmt21, RctBif.BAmt22, RctBif.BTotal FROM SocMember INNER JOIN RctBif ON SocMember.SocAccountMainId = RctBif.MemId WHERE (((SocMember.MemCode)>='{this.lblMemForm.Text.Trim()}' And (SocMember.MemCode)<='{this.lblMemTo.Text.Trim()}') AND ((RctBif.Tran_Type)='(Opening)')) ORDER BY SocMember.MemCode", selectConnection);
    DataTable dataTable1 = new DataTable("SocMember");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Width = 100;
    this.DataGridView1.Columns[1].Width = 400;
    if (this.DataGridView1.RowCount == 0)
    {
      int num = (int) Interaction.MsgBox((object) "No Record");
      this.btnUpdate.Enabled = false;
    }
    else
      this.btnUpdate.Enabled = true;
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId,SocAccount.AccCode,SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
    DataTable dataTable2 = new DataTable("SocBillSetting");
    oleDbDataAdapter3.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    selectConnection.Close();
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.ColumnCount = checked (this.DataGridView2.RowCount + 10);
    this.vlcell = checked (this.DataGridView2.RowCount + 9);
    this.DataGridView3.RowCount = this.DataGridView1.RowCount;
    this.DataGridView3.Columns[0].Visible = false;
    this.DataGridView3.Columns[1].HeaderText = " Code ";
    this.DataGridView3.Columns[1].Width = 70;
    this.DataGridView3.Columns[1].Frozen = true;
    this.DataGridView3.Columns[2].Visible = true;
    this.DataGridView3.Columns[3].Visible = true;
    this.DataGridView3.Columns[4].Visible = false;
    this.DataGridView3.Columns[5].Visible = false;
    this.DataGridView3.Columns[6].HeaderText = " Name ";
    this.DataGridView3.Columns[6].Frozen = true;
    this.DataGridView3.Columns[7].HeaderText = " Sq.ft. ";
    this.DataGridView3.Columns[0].ReadOnly = true;
    this.DataGridView3.Columns[1].ReadOnly = true;
    this.DataGridView3.Columns[2].ReadOnly = true;
    this.DataGridView3.Columns[3].ReadOnly = true;
    this.DataGridView3.Columns[4].ReadOnly = true;
    this.DataGridView3.Columns[5].ReadOnly = true;
    this.DataGridView3.Columns[6].ReadOnly = true;
    this.DataGridView3.Columns[7].ReadOnly = true;
    int num1 = checked (this.DataGridView2.RowCount - 2);
    this.i = 0;
    while (this.i <= num1)
    {
      this.DataGridView3.Columns[checked (this.i + 8)].DefaultCellStyle.Format = "N2";
      this.DataGridView3.Columns[checked (this.i + 8)].ValueType = typeof (double);
      this.DataGridView3.Columns[checked (this.i + 8)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.DataGridView3.Columns[checked (this.i + 8)].HeaderText = this.DataGridView2.Rows[this.i].Cells[6].Value.ToString();
      this.DataGridView3.Columns[checked (this.i + 8)].Width = 70;
      checked { ++this.i; }
    }
    this.DataGridView3.Columns[checked (this.i + 8)].DefaultCellStyle.Format = "N2";
    this.DataGridView3.Columns[checked (this.i + 8)].ValueType = typeof (double);
    this.DataGridView3.Columns[checked (this.i + 8)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView3.Columns[checked (this.i + 8)].HeaderText = " Interest ";
    this.DataGridView3.Columns[checked (this.i + 9)].DefaultCellStyle.Format = "N2";
    this.DataGridView3.Columns[checked (this.i + 9)].ValueType = typeof (double);
    this.DataGridView3.Columns[checked (this.i + 9)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    this.DataGridView3.Columns[checked (this.i + 9)].HeaderText = " Total ";
    this.DataGridView3.Columns[checked (this.i + 10)].Width = 5;
    int num2 = checked (this.DataGridView1.RowCount - 1);
    this.i = 0;
    while (this.i <= num2)
    {
      this.htot = 0.0;
      this.DataGridView3.Rows[this.i].Cells[0].Value = (object) this.DataGridView1.Rows[this.i].Cells[0].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[1].Value = (object) this.DataGridView1.Rows[this.i].Cells[1].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[2].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.i].Cells[2].Value));
      this.DataGridView3.Rows[this.i].Cells[3].Value = (object) Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[this.i].Cells[3].Value));
      this.DataGridView3.Rows[this.i].Cells[4].Value = (object) this.DataGridView1.Rows[this.i].Cells[4].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[5].Value = (object) this.DataGridView1.Rows[this.i].Cells[5].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[6].Value = (object) this.DataGridView1.Rows[this.i].Cells[6].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[7].Value = (object) this.DataGridView1.Rows[this.i].Cells[7].Value.ToString();
      int num3 = checked (this.DataGridView2.RowCount - 1);
      this.j = 1;
      while (this.j <= num3)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.i].Cells[checked (this.j + 9)].Value.ToString(), "", false) == 0)
          this.DataGridView1.Rows[this.i].Cells[checked (this.j + 9)].Value = (object) 0;
        this.DataGridView3.Rows[this.i].Cells[checked (this.j + 7)].Value = (object) Math.Round(Conversion.Val(this.DataGridView1.Rows[this.i].Cells[checked (this.j + 9)].Value.ToString()), 2);
        this.htot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.htot, this.DataGridView1.Rows[this.i].Cells[checked (this.j + 9)].Value));
        checked { ++this.j; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value.ToString(), "", false) == 0)
        this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value = (object) 0;
      this.DataGridView3.Rows[this.i].Cells[checked (this.j + 7)].Value = (object) Math.Round(Conversion.Val(this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value.ToString()), 2);
      this.htot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.htot, this.DataGridView1.Rows[this.i].Cells[31 /*0x1F*/].Value));
      this.DataGridView3.Rows[this.i].Cells[checked (this.j + 8)].Value = (object) Math.Round(Conversion.Val(this.htot.ToString()), 2);
      this.DataGridView3.Columns[checked (this.j + 8)].ReadOnly = true;
      checked { ++this.i; }
    }
    this.vtot = 0.0;
    this.DataGridView3.Rows.Add();
    int num4 = checked (this.DataGridView3.ColumnCount - 1);
    this.i = 8;
    while (this.i <= num4)
    {
      int num5 = checked (this.DataGridView3.RowCount - 2);
      this.j = 0;
      while (this.j <= num5)
      {
        this.vtot = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.vtot, this.DataGridView3.Rows[this.j].Cells[this.i].Value));
        checked { ++this.j; }
      }
      this.DataGridView3.Rows[this.j].Cells[this.i].Value = (object) Math.Round(this.vtot, 2);
      this.vtot = 0.0;
      checked { ++this.i; }
    }
    int num6 = checked (this.DataGridView3.RowCount - 1);
    this.i = 0;
    while (this.i <= num6)
    {
      this.DataGridView3.Rows[this.i].ReadOnly = false;
      checked { ++this.i; }
    }
    this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].ReadOnly = true;
    this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].Cells[6].Value = (object) "Total";
    this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].DefaultCellStyle.BackColor = Color.Brown;
    this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].DefaultCellStyle.ForeColor = Color.Yellow;
    this.DataGridView3.Rows[checked (this.DataGridView3.RowCount - 1)].DefaultCellStyle.Font = new Font("Arial", 9f, FontStyle.Bold);
    DataSet fillGridOpening;
    return fillGridOpening;
  }

  public DataSet GetFillGridSqft()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblMemForm.Text, "", false) == 0)
      oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocMember.SocMemId,SocMember.MemCode,SocMember.Bldg,SocMember.Wing,SocMember.FlatType,SocMember.FlatNo,SocMember.MemName,SocMember.Sqft, SocBillMaster.* FROM SocBillMaster INNER JOIN SocMember ON SocBillMaster.SocMemId = SocMember.SocMemId order by SocMember.MemCode asc", selectConnection);
    else
      oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocMember.SocMemId,SocMember.MemCode,SocMember.Bldg,SocMember.Wing,SocMember.FlatType,SocMember.FlatNo,SocMember.MemName,SocMember.Sqft, SocBillMaster.* FROM SocBillMaster INNER JOIN SocMember ON SocBillMaster.SocMemId = SocMember.SocMemId WHERE (((SocMember.MemCode)>= '{this.lblMemForm.Text.Trim()}' AND (SocMember.MemCode)<='{this.lblMemTo.Text.Trim()}')) order by SocMember.MemCode asc", selectConnection);
    DataTable dataTable = new DataTable("SocBillMaster");
    oleDbDataAdapter2.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    this.DataGridView1.Columns[0].Width = 100;
    this.DataGridView1.Columns[1].Width = 400;
    if (this.DataGridView1.RowCount == 0)
    {
      int num = (int) Interaction.MsgBox((object) "No Record");
      this.btnUpdate.Enabled = false;
    }
    else
      this.btnUpdate.Enabled = true;
    this.DataGridView3.AllowUserToAddRows = false;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.ColumnCount = 8;
    this.DataGridView3.RowCount = this.DataGridView1.RowCount;
    this.DataGridView3.Columns[0].Visible = false;
    this.DataGridView3.Columns[1].HeaderText = " Code ";
    this.DataGridView3.Columns[1].Width = 70;
    this.DataGridView3.Columns[1].Frozen = true;
    this.DataGridView3.Columns[2].Visible = false;
    this.DataGridView3.Columns[3].Visible = false;
    this.DataGridView3.Columns[4].Visible = false;
    this.DataGridView3.Columns[5].Visible = false;
    this.DataGridView3.Columns[6].HeaderText = " Name ";
    this.DataGridView3.Columns[6].Width = 400;
    this.DataGridView3.Columns[6].Frozen = true;
    this.DataGridView3.Columns[7].HeaderText = " Sq.ft. ";
    this.DataGridView3.Columns[7].HeaderText = " Sq.ft. ";
    this.DataGridView3.Columns[7].HeaderText = " Sq.ft. ";
    this.DataGridView3.Columns[0].ReadOnly = true;
    this.DataGridView3.Columns[1].ReadOnly = true;
    this.DataGridView3.Columns[2].ReadOnly = true;
    this.DataGridView3.Columns[3].ReadOnly = true;
    this.DataGridView3.Columns[4].ReadOnly = true;
    this.DataGridView3.Columns[5].ReadOnly = true;
    this.DataGridView3.Columns[6].ReadOnly = true;
    this.DataGridView3.Columns[7].ReadOnly = false;
    int num1 = checked (this.DataGridView1.RowCount - 1);
    this.i = 0;
    while (this.i <= num1)
    {
      this.htot = 0.0;
      this.DataGridView3.Rows[this.i].Cells[0].Value = (object) this.DataGridView1.Rows[this.i].Cells[0].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[1].Value = (object) this.DataGridView1.Rows[this.i].Cells[1].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[2].Value = (object) this.DataGridView1.Rows[this.i].Cells[2].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[3].Value = (object) this.DataGridView1.Rows[this.i].Cells[3].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[4].Value = (object) this.DataGridView1.Rows[this.i].Cells[4].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[5].Value = (object) this.DataGridView1.Rows[this.i].Cells[5].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[6].Value = (object) this.DataGridView1.Rows[this.i].Cells[6].Value.ToString();
      this.DataGridView3.Rows[this.i].Cells[7].Value = (object) this.DataGridView1.Rows[this.i].Cells[7].Value.ToString();
      checked { ++this.i; }
    }
    DataSet fillGridSqft;
    return fillGridSqft;
  }

  private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
  {
  }
}
