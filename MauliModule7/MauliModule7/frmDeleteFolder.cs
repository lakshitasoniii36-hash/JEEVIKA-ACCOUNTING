// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmDeleteFolder
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmDeleteFolder : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("chkpdfemail")]
  private CheckBox _chkpdfemail;
  [AccessedThroughProperty("chkpdfbillfile")]
  private CheckBox _chkpdfbillfile;
  [AccessedThroughProperty("chkpdfreceiptfile")]
  private CheckBox _chkpdfreceiptfile;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("lblDataPath")]
  private Label _lblDataPath;

  [DebuggerNonUserCode]
  static frmDeleteFolder()
  {
  }

  [DebuggerNonUserCode]
  public frmDeleteFolder()
  {
    this.KeyDown += new KeyEventHandler(this.frmDeleteFolder_KeyDown);
    this.Load += new EventHandler(this.frmDeleteFolder_Load);
    frmDeleteFolder.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmDeleteFolder.__ENCList)
    {
      if (frmDeleteFolder.__ENCList.Count == frmDeleteFolder.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmDeleteFolder.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmDeleteFolder.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmDeleteFolder.__ENCList[index1] = frmDeleteFolder.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmDeleteFolder.__ENCList.RemoveRange(index1, checked (frmDeleteFolder.__ENCList.Count - index1));
        frmDeleteFolder.__ENCList.Capacity = frmDeleteFolder.__ENCList.Count;
      }
      frmDeleteFolder.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmDeleteFolder));
    this.DataGridView1 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.btnExit = new Button();
    this.chkpdfemail = new CheckBox();
    this.chkpdfbillfile = new CheckBox();
    this.chkpdfreceiptfile = new CheckBox();
    this.GroupBox1 = new GroupBox();
    this.btnUpdate = new Button();
    this.lblDataPath = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpVisible.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    this.SuspendLayout();
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
    Point point1 = new Point(24, 19);
    Point point2 = point1;
    dataGridView1_1.Location = point2;
    this.DataGridView1.Name = "DataGridView1";
    this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    DataGridView dataGridView1_2 = this.DataGridView1;
    Size size1 = new Size(10, 13);
    Size size2 = size1;
    dataGridView1_2.Size = size2;
    this.DataGridView1.TabIndex = 3;
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(64 /*0x40*/, 240 /*0xF0*/);
    Point point3 = point1;
    grpVisible1.Location = point3;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(41, 66);
    Size size3 = size1;
    grpVisible2.Size = size3;
    this.grpVisible.TabIndex = 7;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    Button btnExit1 = this.btnExit;
    point1 = new Point(133, 201);
    Point point4 = point1;
    btnExit1.Location = point4;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(111, 33);
    Size size4 = size1;
    btnExit2.Size = size4;
    this.btnExit.TabIndex = 11;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.chkpdfemail.AutoSize = true;
    CheckBox chkpdfemail1 = this.chkpdfemail;
    point1 = new Point(54, 29);
    Point point5 = point1;
    chkpdfemail1.Location = point5;
    this.chkpdfemail.Name = "chkpdfemail";
    CheckBox chkpdfemail2 = this.chkpdfemail;
    size1 = new Size(65, 17);
    Size size5 = size1;
    chkpdfemail2.Size = size5;
    this.chkpdfemail.TabIndex = 42;
    this.chkpdfemail.Text = "pdfemail";
    this.chkpdfemail.UseVisualStyleBackColor = true;
    this.chkpdfbillfile.AutoSize = true;
    CheckBox chkpdfbillfile1 = this.chkpdfbillfile;
    point1 = new Point(54, 65);
    Point point6 = point1;
    chkpdfbillfile1.Location = point6;
    this.chkpdfbillfile.Name = "chkpdfbillfile";
    CheckBox chkpdfbillfile2 = this.chkpdfbillfile;
    size1 = new Size(70, 17);
    Size size6 = size1;
    chkpdfbillfile2.Size = size6;
    this.chkpdfbillfile.TabIndex = 43;
    this.chkpdfbillfile.Text = "pdfBillFile";
    this.chkpdfbillfile.UseVisualStyleBackColor = true;
    this.chkpdfreceiptfile.AutoSize = true;
    CheckBox chkpdfreceiptfile1 = this.chkpdfreceiptfile;
    point1 = new Point(54, 102);
    Point point7 = point1;
    chkpdfreceiptfile1.Location = point7;
    this.chkpdfreceiptfile.Name = "chkpdfreceiptfile";
    CheckBox chkpdfreceiptfile2 = this.chkpdfreceiptfile;
    size1 = new Size(94, 17);
    Size size7 = size1;
    chkpdfreceiptfile2.Size = size7;
    this.chkpdfreceiptfile.TabIndex = 44;
    this.chkpdfreceiptfile.Text = "pdfReceiptFile";
    this.chkpdfreceiptfile.UseVisualStyleBackColor = true;
    this.GroupBox1.Controls.Add((Control) this.chkpdfemail);
    this.GroupBox1.Controls.Add((Control) this.chkpdfreceiptfile);
    this.GroupBox1.Controls.Add((Control) this.chkpdfbillfile);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(36, 32 /*0x20*/);
    Point point8 = point1;
    groupBox1_1.Location = point8;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(182, 143);
    Size size8 = size1;
    groupBox1_2.Size = size8;
    this.GroupBox1.TabIndex = 45;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Clear Folder";
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(12, 201);
    Point point9 = point1;
    btnUpdate1.Location = point9;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate2 = this.btnUpdate;
    size1 = new Size(111, 33);
    Size size9 = size1;
    btnUpdate2.Size = size9;
    this.btnUpdate.TabIndex = 46;
    this.btnUpdate.Text = "&Update";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.lblDataPath.AutoSize = true;
    Label lblDataPath1 = this.lblDataPath;
    point1 = new Point(15, 9);
    Point point10 = point1;
    lblDataPath1.Location = point10;
    this.lblDataPath.Name = "lblDataPath";
    Label lblDataPath2 = this.lblDataPath;
    size1 = new Size(55, 13);
    Size size10 = size1;
    lblDataPath2.Size = size10;
    this.lblDataPath.TabIndex = 47;
    this.lblDataPath.Text = "Data Path";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(254, 267);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblDataPath);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.grpVisible);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmDeleteFolder);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Check Difference";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
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

  internal virtual GroupBox grpVisible
  {
    [DebuggerNonUserCode] get => this._grpVisible;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpVisible = value;
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

  internal virtual CheckBox chkpdfemail
  {
    [DebuggerNonUserCode] get => this._chkpdfemail;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkpdfemail = value;
    }
  }

  internal virtual CheckBox chkpdfbillfile
  {
    [DebuggerNonUserCode] get => this._chkpdfbillfile;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkpdfbillfile = value;
    }
  }

  internal virtual CheckBox chkpdfreceiptfile
  {
    [DebuggerNonUserCode] get => this._chkpdfreceiptfile;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkpdfreceiptfile = value;
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

  internal virtual Label lblDataPath
  {
    [DebuggerNonUserCode] get => this._lblDataPath;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblDataPath = value;
    }
  }

  private void frmDeleteFolder_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmDeleteFolder_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.GetFillGrid();
  }

  public DataSet GetFillGrid()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
    DataTable dataTable = new DataTable("DeleteFolder");
    new OleDbDataAdapter($"SELECT DeleteFolder.ID, DeleteFolder.SrNo, DeleteFolder.FolderName, DeleteFolder.PathName, DeleteFolder.Opt1, DeleteFolder.Opt2 FROM DeleteFolder WHERE (DeleteFolder.PathName ='{this.lblDataPath.Text.Trim()}') ORDER BY DeleteFolder.SrNo", selectConnection).Fill(dataTable);
    this.DataGridView1.DataSource = (object) dataTable;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    if (this.DataGridView1.RowCount == 0)
    {
      this.chkpdfemail.Checked = false;
      this.chkpdfbillfile.Checked = false;
      this.chkpdfreceiptfile.Checked = false;
      this.btnUpdate.Text = "Save";
    }
    else
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString(), "pdfemail", false) == 0)
          this.chkpdfemail.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[4].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString(), "pdfBillFile", false) == 0)
          this.chkpdfbillfile.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[4].Value);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString(), "pdfReceiptFile", false) == 0)
          this.chkpdfreceiptfile.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[4].Value);
        checked { ++index; }
      }
      this.btnUpdate.Text = "Update";
    }
    DataSet fillGrid;
    return fillGrid;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnUpdate.Text, "Save", false) == 0)
    {
      OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
      OleDbCommand oleDbCommand1 = new OleDbCommand();
      string[] strArray1 = new string[5]
      {
        "Insert Into DeleteFolder (SrNo, FolderName, PathName, Opt1, Opt2) values ('1','pdfemail','",
        this.lblDataPath.Text.Trim(),
        "', '",
        null,
        null
      };
      string[] strArray2 = strArray1;
      bool flag = this.chkpdfemail.Checked;
      string str1 = flag.ToString();
      strArray2[3] = str1;
      strArray1[4] = "', '')";
      OleDbCommand oleDbCommand2 = new OleDbCommand(string.Concat(strArray1), connection);
      connection.Open();
      oleDbCommand2.ExecuteNonQuery();
      connection.Close();
      string[] strArray3 = new string[5]
      {
        "Insert Into DeleteFolder (SrNo, FolderName, PathName, Opt1, Opt2) values ('2','pdfBillFile','",
        this.lblDataPath.Text.Trim(),
        "', '",
        null,
        null
      };
      string[] strArray4 = strArray3;
      flag = this.chkpdfbillfile.Checked;
      string str2 = flag.ToString();
      strArray4[3] = str2;
      strArray3[4] = "', '')";
      OleDbCommand oleDbCommand3 = new OleDbCommand(string.Concat(strArray3), connection);
      connection.Open();
      oleDbCommand3.ExecuteNonQuery();
      connection.Close();
      string[] strArray5 = new string[5]
      {
        "Insert Into DeleteFolder (SrNo, FolderName, PathName, Opt1, Opt2) values ('2','pdfReceiptFile','",
        this.lblDataPath.Text.Trim(),
        "', '",
        null,
        null
      };
      string[] strArray6 = strArray5;
      flag = this.chkpdfreceiptfile.Checked;
      string str3 = flag.ToString();
      strArray6[3] = str3;
      strArray5[4] = "', '')";
      OleDbCommand oleDbCommand4 = new OleDbCommand(string.Concat(strArray5), connection);
      connection.Open();
      oleDbCommand4.ExecuteNonQuery();
      connection.Close();
    }
    else
    {
      int num = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num)
      {
        bool flag;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString(), "pdfemail", false) == 0)
        {
          OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
          flag = this.chkpdfemail.Checked;
          OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update DeleteFolder set Opt1 = '" + flag.ToString() + "' where Id ="), this.DataGridView1.Rows[index].Cells[0].Value), (object) "")), connection);
          connection.Open();
          oleDbCommand.ExecuteNonQuery();
          connection.Close();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString(), "pdfBillFile", false) == 0)
        {
          OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
          flag = this.chkpdfbillfile.Checked;
          OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update DeleteFolder set Opt1 = '" + flag.ToString() + "' where Id ="), this.DataGridView1.Rows[index].Cells[0].Value), (object) "")), connection);
          connection.Open();
          oleDbCommand.ExecuteNonQuery();
          connection.Close();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index].Cells[2].Value.ToString(), "pdfReceiptFile", false) == 0)
        {
          OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socAppDataPath}SocGeneral.accdb");
          flag = this.chkpdfreceiptfile.Checked;
          OleDbCommand oleDbCommand = new OleDbCommand(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("update DeleteFolder set Opt1 = '" + flag.ToString() + "' where Id ="), this.DataGridView1.Rows[index].Cells[0].Value), (object) "")), connection);
          connection.Open();
          oleDbCommand.ExecuteNonQuery();
          connection.Close();
        }
        checked { ++index; }
      }
    }
    this.Close();
  }
}
