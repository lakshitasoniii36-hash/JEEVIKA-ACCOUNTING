// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmBackUp
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.MyServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmBackUp : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnBackup")]
  private Button _btnBackup;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("pb1")]
  private ProgressBar _pb1;
  [AccessedThroughProperty("txtImportFrom")]
  private TextBox _txtImportFrom;
  [AccessedThroughProperty("txtImportTo")]
  private TextBox _txtImportTo;
  [AccessedThroughProperty("txtClientSrNo")]
  private TextBox _txtClientSrNo;
  [AccessedThroughProperty("btnImportFrom")]
  private Button _btnImportFrom;
  [AccessedThroughProperty("btnImportTo")]
  private Button _btnImportTo;
  [AccessedThroughProperty("FolderBrowserDialog1")]
  private FolderBrowserDialog _FolderBrowserDialog1;
  [AccessedThroughProperty("FolderBrowserDialog2")]
  private FolderBrowserDialog _FolderBrowserDialog2;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("txtSrnoImportFrom")]
  private TextBox _txtSrnoImportFrom;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;

  [DebuggerNonUserCode]
  static frmBackUp()
  {
  }

  [DebuggerNonUserCode]
  public frmBackUp()
  {
    this.Load += new EventHandler(this.frmBackUp_Load);
    frmBackUp.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmBackUp.__ENCList)
    {
      if (frmBackUp.__ENCList.Count == frmBackUp.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmBackUp.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmBackUp.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmBackUp.__ENCList[index1] = frmBackUp.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmBackUp.__ENCList.RemoveRange(index1, checked (frmBackUp.__ENCList.Count - index1));
        frmBackUp.__ENCList.Capacity = frmBackUp.__ENCList.Count;
      }
      frmBackUp.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBackUp));
    this.btnBackup = new Button();
    this.btnExit = new Button();
    this.pb1 = new ProgressBar();
    this.txtImportFrom = new TextBox();
    this.txtImportTo = new TextBox();
    this.txtClientSrNo = new TextBox();
    this.btnImportFrom = new Button();
    this.btnImportTo = new Button();
    this.FolderBrowserDialog1 = new FolderBrowserDialog();
    this.FolderBrowserDialog2 = new FolderBrowserDialog();
    this.DataGridView1 = new DataGridView();
    this.txtSrnoImportFrom = new TextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.SuspendLayout();
    this.btnBackup.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnBackup1 = this.btnBackup;
    Point point1 = new Point(179, 201);
    Point point2 = point1;
    btnBackup1.Location = point2;
    this.btnBackup.Name = "btnBackup";
    Button btnBackup2 = this.btnBackup;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnBackup2.Size = size2;
    this.btnBackup.TabIndex = 10;
    this.btnBackup.Text = "&Start Import";
    this.btnBackup.UseVisualStyleBackColor = true;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(284, 201);
    Point point3 = point1;
    btnExit1.Location = point3;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnExit2.Size = size3;
    this.btnExit.TabIndex = 11;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    ProgressBar pb1_1 = this.pb1;
    point1 = new Point(1, 240 /*0xF0*/);
    Point point4 = point1;
    pb1_1.Location = point4;
    this.pb1.Name = "pb1";
    ProgressBar pb1_2 = this.pb1;
    size1 = new Size(561, 23);
    Size size4 = size1;
    pb1_2.Size = size4;
    this.pb1.TabIndex = 12;
    TextBox txtImportFrom1 = this.txtImportFrom;
    point1 = new Point(131, 34);
    Point point5 = point1;
    txtImportFrom1.Location = point5;
    this.txtImportFrom.Name = "txtImportFrom";
    TextBox txtImportFrom2 = this.txtImportFrom;
    size1 = new Size(361, 20);
    Size size5 = size1;
    txtImportFrom2.Size = size5;
    this.txtImportFrom.TabIndex = 13;
    TextBox txtImportTo1 = this.txtImportTo;
    point1 = new Point(131, 131);
    Point point6 = point1;
    txtImportTo1.Location = point6;
    this.txtImportTo.Name = "txtImportTo";
    TextBox txtImportTo2 = this.txtImportTo;
    size1 = new Size(361, 20);
    Size size6 = size1;
    txtImportTo2.Size = size6;
    this.txtImportTo.TabIndex = 14;
    TextBox txtClientSrNo1 = this.txtClientSrNo;
    point1 = new Point(131, 166);
    Point point7 = point1;
    txtClientSrNo1.Location = point7;
    this.txtClientSrNo.Name = "txtClientSrNo";
    TextBox txtClientSrNo2 = this.txtClientSrNo;
    size1 = new Size(139, 20);
    Size size7 = size1;
    txtClientSrNo2.Size = size7;
    this.txtClientSrNo.TabIndex = 15;
    Button btnImportFrom1 = this.btnImportFrom;
    point1 = new Point(26, 27);
    Point point8 = point1;
    btnImportFrom1.Location = point8;
    this.btnImportFrom.Name = "btnImportFrom";
    Button btnImportFrom2 = this.btnImportFrom;
    size1 = new Size(99, 33);
    Size size8 = size1;
    btnImportFrom2.Size = size8;
    this.btnImportFrom.TabIndex = 16 /*0x10*/;
    this.btnImportFrom.Text = "Import From";
    this.btnImportFrom.UseVisualStyleBackColor = true;
    Button btnImportTo1 = this.btnImportTo;
    point1 = new Point(26, 124);
    Point point9 = point1;
    btnImportTo1.Location = point9;
    this.btnImportTo.Name = "btnImportTo";
    Button btnImportTo2 = this.btnImportTo;
    size1 = new Size(99, 33);
    Size size9 = size1;
    btnImportTo2.Size = size9;
    this.btnImportTo.TabIndex = 17;
    this.btnImportTo.Text = "Import To";
    this.btnImportTo.UseVisualStyleBackColor = true;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(537, 173);
    Point point10 = point1;
    dataGridView1_1.Location = point10;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView1_2.Size = size10;
    this.DataGridView1.TabIndex = 18;
    TextBox txtSrnoImportFrom1 = this.txtSrnoImportFrom;
    point1 = new Point(131, 71);
    Point point11 = point1;
    txtSrnoImportFrom1.Location = point11;
    this.txtSrnoImportFrom.Name = "txtSrnoImportFrom";
    TextBox txtSrnoImportFrom2 = this.txtSrnoImportFrom;
    size1 = new Size(139, 20);
    Size size11 = size1;
    txtSrnoImportFrom2.Size = size11;
    this.txtSrnoImportFrom.TabIndex = 19;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(30, 74);
    Point point12 = point1;
    label1_1.Location = point12;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(95, 13);
    Size size12 = size1;
    label1_2.Size = size12;
    this.Label1.TabIndex = 20;
    this.Label1.Text = "Import From Sr.No.";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(223, 9);
    Point point13 = point1;
    label2_1.Location = point13;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(80 /*0x50*/, 13);
    Size size13 = size1;
    label2_2.Size = size13;
    this.Label2.TabIndex = 21;
    this.Label2.Text = "Other PC Detail";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(223, 104);
    Point point14 = point1;
    label3_1.Location = point14;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(76, 13);
    Size size14 = size1;
    label3_2.Size = size14;
    this.Label3.TabIndex = 22;
    this.Label3.Text = "Your PC Detail";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(30, 173);
    Point point15 = point1;
    label4_1.Location = point15;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(81, 13);
    Size size15 = size1;
    label4_2.Size = size15;
    this.Label4.TabIndex = 23;
    this.Label4.Text = "Import to Sr.No.";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(559, 266);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtSrnoImportFrom);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.btnImportTo);
    this.Controls.Add((Control) this.btnImportFrom);
    this.Controls.Add((Control) this.txtClientSrNo);
    this.Controls.Add((Control) this.txtImportTo);
    this.Controls.Add((Control) this.txtImportFrom);
    this.Controls.Add((Control) this.pb1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnBackup);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmBackUp);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Import Data from Other PC";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnBackup
  {
    [DebuggerNonUserCode] get => this._btnBackup;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnBackup_Click);
      if (this._btnBackup != null)
        this._btnBackup.Click -= eventHandler;
      this._btnBackup = value;
      if (this._btnBackup == null)
        return;
      this._btnBackup.Click += eventHandler;
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

  internal virtual ProgressBar pb1
  {
    [DebuggerNonUserCode] get => this._pb1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._pb1 = value;
  }

  internal virtual TextBox txtImportFrom
  {
    [DebuggerNonUserCode] get => this._txtImportFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtImportFrom = value;
    }
  }

  internal virtual TextBox txtImportTo
  {
    [DebuggerNonUserCode] get => this._txtImportTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtImportTo = value;
    }
  }

  internal virtual TextBox txtClientSrNo
  {
    [DebuggerNonUserCode] get => this._txtClientSrNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtClientSrNo = value;
    }
  }

  internal virtual Button btnImportFrom
  {
    [DebuggerNonUserCode] get => this._btnImportFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnImportFrom_Click);
      if (this._btnImportFrom != null)
        this._btnImportFrom.Click -= eventHandler;
      this._btnImportFrom = value;
      if (this._btnImportFrom == null)
        return;
      this._btnImportFrom.Click += eventHandler;
    }
  }

  internal virtual Button btnImportTo
  {
    [DebuggerNonUserCode] get => this._btnImportTo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnImportTo_Click);
      if (this._btnImportTo != null)
        this._btnImportTo.Click -= eventHandler;
      this._btnImportTo = value;
      if (this._btnImportTo == null)
        return;
      this._btnImportTo.Click += eventHandler;
    }
  }

  internal virtual FolderBrowserDialog FolderBrowserDialog1
  {
    [DebuggerNonUserCode] get => this._FolderBrowserDialog1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._FolderBrowserDialog1 = value;
    }
  }

  internal virtual FolderBrowserDialog FolderBrowserDialog2
  {
    [DebuggerNonUserCode] get => this._FolderBrowserDialog2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._FolderBrowserDialog2 = value;
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

  internal virtual TextBox txtSrnoImportFrom
  {
    [DebuggerNonUserCode] get => this._txtSrnoImportFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtSrnoImportFrom = value;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnImportFrom_Click(object sender, EventArgs e)
  {
    int num = (int) this.FolderBrowserDialog1.ShowDialog();
    this.txtImportFrom.Text = this.FolderBrowserDialog1.SelectedPath;
  }

  private void btnImportTo_Click(object sender, EventArgs e)
  {
    int num = (int) this.FolderBrowserDialog2.ShowDialog();
    this.txtImportTo.Text = this.FolderBrowserDialog2.SelectedPath;
  }

  private void frmBackUp_Load(object sender, EventArgs e)
  {
    this.txtClientSrNo.Text = Constant.Clientcode;
  }

  private void btnBackup_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtImportFrom.Text, "", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Select Import From Path");
      this.btnImportFrom.Focus();
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtImportTo.Text, "", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Select Import From Path");
      this.btnImportTo.Focus();
    }
    else if (Strings.Len(this.txtSrnoImportFrom.Text.Trim()) != 5)
    {
      int num = (int) Interaction.MsgBox((object) "Enter the 5 digit client code of other pc");
      this.txtSrnoImportFrom.Focus();
    }
    else if (Conversions.ToDouble(Conversions.ToString((int) Interaction.MsgBox((object) " Confirm Import Data ???", MsgBoxStyle.YesNo))) == 6.0)
    {
      if (!MyProject.Computer.FileSystem.DirectoryExists(this.txtImportTo.Text + "\\TEMP"))
        MyProject.Computer.FileSystem.CreateDirectory(this.txtImportTo.Text + "\\TEMP");
      MyProject.Computer.FileSystem.CopyDirectory(this.txtImportFrom.Text, this.txtImportTo.Text + "\\TEMP", true);
      OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocietyInfo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={this.txtImportTo.Text}\\TEMP\\society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}"));
      DataTable dataTable = new DataTable("SocietyInfo");
      oleDbDataAdapter.Fill(dataTable);
      this.DataGridView1.DataSource = (object) dataTable;
      this.DataGridView1.ReadOnly = true;
      this.DataGridView1.RowHeadersVisible = false;
      this.DataGridView1.AllowUserToAddRows = false;
      int num1 = checked (this.DataGridView1.RowCount - 1);
      int index = 0;
      while (index <= num1)
      {
        object Left1 = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) (this.txtClientSrNo.Text.Trim() + "_"), this.DataGridView1.Rows[index].Cells[1].Value), (object) "_"), (object) DateAndTime.Year(Conversions.ToDate(this.DataGridView1.Rows[index].Cells[3].Value)).ToString());
        int num2 = DateAndTime.Year(Conversions.ToDate(this.DataGridView1.Rows[index].Cells[4].Value));
        string Right1 = num2.ToString();
        string str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Left1, (object) Right1), (object) ".accdb"));
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtClientSrNo.Text.Trim(), this.txtSrnoImportFrom.Text.Trim(), false) != 0)
        {
          if (MyProject.Computer.FileSystem.FileExists($"{this.txtImportTo.Text}\\TEMP\\{str}"))
            MyProject.Computer.FileSystem.DeleteFile($"{this.txtImportTo.Text}\\TEMP\\{str}");
          FileSystemProxy fileSystem = MyProject.Computer.FileSystem;
          object Left2 = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) (this.txtImportTo.Text + "\\TEMP\\" + this.txtSrnoImportFrom.Text.Trim() + "_"), this.DataGridView1.Rows[index].Cells[1].Value), (object) "_");
          num2 = DateAndTime.Year(Conversions.ToDate(this.DataGridView1.Rows[index].Cells[3].Value));
          string Right2 = num2.ToString();
          string file = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Left2, (object) Right2), (object) DateAndTime.Year(Conversions.ToDate(this.DataGridView1.Rows[index].Cells[4].Value)).ToString()), (object) ".accdb"));
          string newName = str;
          fileSystem.RenameFile(file, newName);
        }
        File.Copy($"{this.txtImportTo.Text}\\TEMP\\{str}", $"{this.txtImportTo.Text}\\{str}", true);
        checked { ++index; }
      }
      File.Copy(this.txtImportTo.Text + "\\TEMP\\society.accdb", this.txtImportTo.Text + "\\society.accdb", true);
      MyProject.Computer.FileSystem.DeleteDirectory(this.txtImportTo.Text + "\\TEMP", DeleteDirectoryOption.DeleteAllContents);
    }
  }
}
