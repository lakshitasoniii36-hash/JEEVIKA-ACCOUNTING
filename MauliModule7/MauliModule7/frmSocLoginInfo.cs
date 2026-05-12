// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmSocLoginInfo
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

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
public class frmSocLoginInfo : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("btnModify")]
  private Button _btnModify;
  [AccessedThroughProperty("txtMaxSocCode")]
  private TextBox _txtMaxSocCode;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnDelete")]
  private Button _btnDelete;
  [AccessedThroughProperty("btnAdd")]
  private Button _btnAdd;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Panel1")]
  private Panel _Panel1;
  [AccessedThroughProperty("Panel2")]
  private Panel _Panel2;
  [AccessedThroughProperty("lblSrno")]
  private Label _lblSrno;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;

  [DebuggerNonUserCode]
  static frmSocLoginInfo()
  {
  }

  [DebuggerNonUserCode]
  public frmSocLoginInfo()
  {
    this.Load += new EventHandler(this.frmSocLoginInfo_Load);
    frmSocLoginInfo.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmSocLoginInfo.__ENCList)
    {
      if (frmSocLoginInfo.__ENCList.Count == frmSocLoginInfo.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmSocLoginInfo.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmSocLoginInfo.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmSocLoginInfo.__ENCList[index1] = frmSocLoginInfo.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmSocLoginInfo.__ENCList.RemoveRange(index1, checked (frmSocLoginInfo.__ENCList.Count - index1));
        frmSocLoginInfo.__ENCList.Capacity = frmSocLoginInfo.__ENCList.Count;
      }
      frmSocLoginInfo.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSocLoginInfo));
    this.DataGridView1 = new DataGridView();
    this.btnModify = new Button();
    this.txtMaxSocCode = new TextBox();
    this.btnExit = new Button();
    this.btnDelete = new Button();
    this.btnAdd = new Button();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Panel1 = new Panel();
    this.Label1 = new Label();
    this.Panel2 = new Panel();
    this.lblSrno = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    this.SuspendLayout();
    this.DataGridView1.BackgroundColor = SystemColors.InactiveCaption;
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.Padding = new Padding(5, 0, 0, 0);
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.WindowText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView1_1 = this.DataGridView1;
    Point point1 = new Point(12, 65);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
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
    Size size1 = new Size(568, 329);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 5;
    Button btnModify1 = this.btnModify;
    point1 = new Point(197, 412);
    Point point3 = point1;
    btnModify1.Location = point3;
    this.btnModify.Name = "btnModify";
    Button btnModify2 = this.btnModify;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnModify2.Size = size3;
    this.btnModify.TabIndex = 2;
    this.btnModify.Text = "Update";
    this.btnModify.UseVisualStyleBackColor = true;
    TextBox txtMaxSocCode1 = this.txtMaxSocCode;
    point1 = new Point(12, 418);
    Point point4 = point1;
    txtMaxSocCode1.Location = point4;
    this.txtMaxSocCode.Name = "txtMaxSocCode";
    TextBox txtMaxSocCode2 = this.txtMaxSocCode;
    size1 = new Size(56, 20);
    Size size4 = size1;
    txtMaxSocCode2.Size = size4;
    this.txtMaxSocCode.TabIndex = 76;
    this.txtMaxSocCode.Text = "0";
    this.txtMaxSocCode.Visible = false;
    Button btnExit1 = this.btnExit;
    point1 = new Point(302, 411);
    Point point5 = point1;
    btnExit1.Location = point5;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size5 = size1;
    btnExit2.Size = size5;
    this.btnExit.TabIndex = 4;
    this.btnExit.Text = "Exit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnDelete1 = this.btnDelete;
    point1 = new Point(407, 411);
    Point point6 = point1;
    btnDelete1.Location = point6;
    this.btnDelete.Name = "btnDelete";
    Button btnDelete2 = this.btnDelete;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnDelete2.Size = size6;
    this.btnDelete.TabIndex = 3;
    this.btnDelete.Text = "Delete";
    this.btnDelete.UseVisualStyleBackColor = true;
    Button btnAdd1 = this.btnAdd;
    point1 = new Point(92, 412);
    Point point7 = point1;
    btnAdd1.Location = point7;
    this.btnAdd.Name = "btnAdd";
    Button btnAdd2 = this.btnAdd;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnAdd2.Size = size7;
    this.btnAdd.TabIndex = 1;
    this.btnAdd.Text = "Add";
    this.btnAdd.UseVisualStyleBackColor = true;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = SystemColors.Desktop;
    this.Label6.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.GhostWhite;
    Label label6_1 = this.Label6;
    point1 = new Point(120, 513);
    Point point8 = point1;
    label6_1.Location = point8;
    this.Label6.Name = "Label6";
    Label label6_2 = this.Label6;
    size1 = new Size(348, 15);
    Size size8 = size1;
    label6_2.Size = size8;
    this.Label6.TabIndex = 87;
    this.Label6.Text = "9869045370 / 9969507742 Email ID : maulisoftware07@gmail.com";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = SystemColors.Desktop;
    this.Label5.Font = new Font("Times New Roman", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.GhostWhite;
    Label label5_1 = this.Label5;
    point1 = new Point(32 /*0x20*/, 36);
    Point point9 = point1;
    label5_1.Location = point9;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(530, 15);
    Size size9 = size1;
    label5_2.Size = size9;
    this.Label5.TabIndex = 86;
    this.Label5.Text = "379/D-43(Part-2), Sugam Co-op. Hsg. Soc. Ltd, Sector-3, Charkop, Kandiwali (W), Mumbai - 400 067.";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = SystemColors.Desktop;
    this.Label3.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.GhostWhite;
    Label label3_1 = this.Label3;
    point1 = new Point(114, 475);
    Point point10 = point1;
    label3_1.Location = point10;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(374, 24);
    Size size10 = size1;
    label3_2.Size = size10;
    this.Label3.TabIndex = 85;
    this.Label3.Text = "MAULI SOFTWARE & ACCOUNTS LLP";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = SystemColors.Desktop;
    this.Label2.Font = new Font("Times New Roman", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.GhostWhite;
    Label label2_1 = this.Label2;
    point1 = new Point(1, 462);
    Point point11 = point1;
    label2_1.Location = point11;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(134, 13);
    Size size11 = size1;
    label2_2.Size = size11;
    this.Label2.TabIndex = 84;
    this.Label2.Text = "Developed && Markted by";
    this.Panel1.BackColor = SystemColors.Desktop;
    this.Panel1.Controls.Add((Control) this.Label1);
    Panel panel1_1 = this.Panel1;
    point1 = new Point(-2, 9);
    Point point12 = point1;
    panel1_1.Location = point12;
    this.Panel1.Name = "Panel1";
    Panel panel1_2 = this.Panel1;
    size1 = new Size(594, 50);
    Size size12 = size1;
    panel1_2.Size = size12;
    this.Panel1.TabIndex = 88;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = SystemColors.Desktop;
    this.Label1.Font = new Font("Times New Roman", 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.GhostWhite;
    Label label1_1 = this.Label1;
    point1 = new Point(180, 12);
    Point point13 = point1;
    label1_1.Location = point13;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(232, 26);
    Size size13 = size1;
    label1_2.Size = size13;
    this.Label1.TabIndex = 90;
    this.Label1.Text = "MAULI SOFTWARE";
    this.Panel2.BackColor = SystemColors.Desktop;
    this.Panel2.Controls.Add((Control) this.Label5);
    Panel panel2_1 = this.Panel2;
    point1 = new Point(-2, 462);
    Point point14 = point1;
    panel2_1.Location = point14;
    this.Panel2.Name = "Panel2";
    Panel panel2_2 = this.Panel2;
    size1 = new Size(594, 79);
    Size size14 = size1;
    panel2_2.Size = size14;
    this.Panel2.TabIndex = 89;
    this.lblSrno.AutoSize = true;
    Label lblSrno1 = this.lblSrno;
    point1 = new Point(401, 544);
    Point point15 = point1;
    lblSrno1.Location = point15;
    this.lblSrno.Name = "lblSrno";
    Label lblSrno2 = this.lblSrno;
    size1 = new Size(39, 13);
    Size size15 = size1;
    lblSrno2.Size = size15;
    this.lblSrno.TabIndex = 86;
    this.lblSrno.Text = "Label2";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.InactiveCaption;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblSrno);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.Panel2);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnModify);
    this.Controls.Add((Control) this.txtMaxSocCode);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnDelete);
    this.Controls.Add((Control) this.btnAdd);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSocLoginInfo);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Login Master ";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
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

  internal virtual TextBox txtMaxSocCode
  {
    [DebuggerNonUserCode] get => this._txtMaxSocCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMaxSocCode = value;
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

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual Panel Panel1
  {
    [DebuggerNonUserCode] get => this._Panel1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel1 = value;
  }

  internal virtual Panel Panel2
  {
    [DebuggerNonUserCode] get => this._Panel2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Panel2 = value;
  }

  internal virtual Label lblSrno
  {
    [DebuggerNonUserCode] get => this._lblSrno;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblSrno = value;
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  private void frmSocLoginInfo_Load(object sender, EventArgs e) => this.GetFillGrid();

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection(Constant.CnString3);
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginStatus, "A", false) == 0)
    {
      this.btnAdd.Visible = true;
      this.btnDelete.Visible = true;
      oleDbDataAdapter2 = new OleDbDataAdapter("select * from SoftUser order by LogID asc", selectConnection);
    }
    else
    {
      this.btnAdd.Visible = false;
      this.btnDelete.Visible = false;
      oleDbDataAdapter2 = new OleDbDataAdapter($"select * from SoftUser WHERE USERNAME = '{Constant.loginUser}' order by LogID asc", selectConnection);
    }
    DataTable dataTable = new DataTable("User");
    oleDbDataAdapter2.Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.ColumnHeadersVisible = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.Columns[0].HeaderText = "LoginId";
    this.DataGridView1.Columns[1].HeaderText = "User Name";
    this.DataGridView1.Columns[2].HeaderText = "Password";
    this.DataGridView1.Columns[3].HeaderText = "Type";
    this.DataGridView1.Columns[4].HeaderText = "Level";
    this.DataGridView1.Columns[0].Visible = false;
    this.DataGridView1.Columns[1].Width = 350;
    this.DataGridView1.Columns[2].Width = 350;
    this.DataGridView1.Columns[3].Width = 100;
    this.DataGridView1.Columns[4].Width = 100;
    this.DataGridView1.Columns[2].Visible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    int num;
    if (this.DataGridView1.RowCount != 0)
    {
      num = this.DataGridView1.Rows.Cast<DataGridViewRow>().Select<DataGridViewRow, int>((System.Func<DataGridViewRow, int>) ([SpecialName] (T) => Conversions.ToInteger(T.Cells["LogId"].Value))).Max();
    }
    else
    {
      this.btnDelete.Enabled = false;
      this.btnModify.Enabled = false;
    }
    this.txtMaxSocCode.Text = Conversions.ToString(checked (num + 1));
    selectConnection.Close();
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    LoginDetails loginDetails = new LoginDetails();
    loginDetails.Text = " New User Creation";
    loginDetails.lblLogId.Text = this.txtMaxSocCode.Text;
    loginDetails.btnSave.Text = "Save";
    loginDetails.txtUserType.Text = "USER";
    int num = (int) loginDetails.ShowDialog();
    this.GetFillGrid();
  }

  private void btnModify_Click(object sender, EventArgs e)
  {
    LoginDetails loginDetails = new LoginDetails();
    loginDetails.Text = " User Update ";
    loginDetails.btnSave.Text = "Update";
    loginDetails.lblLogId.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
    loginDetails.txtUserName.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    loginDetails.txtUserPassword.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    loginDetails.txtUserType.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    loginDetails.txtUserLevel.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.CurrentRow.Cells[3].Value.ToString(), "ADMIN", false) == 0)
      loginDetails.txtUserLevel.Enabled = false;
    else
      loginDetails.txtUserLevel.Enabled = true;
    int num = (int) loginDetails.ShowDialog();
    this.GetFillGrid();
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnDelete_Click(object sender, EventArgs e)
  {
    LoginDetails loginDetails = new LoginDetails();
    loginDetails.Text = " User Delete ";
    loginDetails.btnSave.Text = "Delete";
    loginDetails.lblLogId.Text = Conversions.ToString(this.DataGridView1.CurrentRow.Cells[0].Value);
    loginDetails.txtUserName.Text = this.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    loginDetails.txtUserPassword.Text = this.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    loginDetails.txtUserType.Text = this.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    loginDetails.txtUserLevel.Text = this.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    int num = (int) loginDetails.ShowDialog();
    this.GetFillGrid();
  }
}
