// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmTranTypeDetail
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
public class frmTranTypeDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("cmbTransactionType")]
  private ComboBox _cmbTransactionType;
  [AccessedThroughProperty("lblcashbank")]
  private Label _lblcashbank;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("txtShortNameAbr")]
  private TextBox _txtShortNameAbr;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("lblTranId")]
  private Label _lblTranId;
  [AccessedThroughProperty("lblOldTranType")]
  private Label _lblOldTranType;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;

  [DebuggerNonUserCode]
  static frmTranTypeDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmTranTypeDetail()
  {
    this.KeyDown += new KeyEventHandler(this.frmTranTypeDetail_KeyDown);
    this.Load += new EventHandler(this.frmTranTypeDetail_Load);
    frmTranTypeDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmTranTypeDetail.__ENCList)
    {
      if (frmTranTypeDetail.__ENCList.Count == frmTranTypeDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmTranTypeDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmTranTypeDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmTranTypeDetail.__ENCList[index1] = frmTranTypeDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmTranTypeDetail.__ENCList.RemoveRange(index1, checked (frmTranTypeDetail.__ENCList.Count - index1));
        frmTranTypeDetail.__ENCList.Capacity = frmTranTypeDetail.__ENCList.Count;
      }
      frmTranTypeDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmTranTypeDetail));
    this.cmbTransactionType = new ComboBox();
    this.lblcashbank = new Label();
    this.Label2 = new Label();
    this.txtShortNameAbr = new TextBox();
    this.btnSave = new Button();
    this.btnExit = new Button();
    this.lblTranId = new Label();
    this.lblOldTranType = new Label();
    this.DataGridView1 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.DataGridView2 = new DataGridView();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.SuspendLayout();
    this.cmbTransactionType.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbTransactionType.FormattingEnabled = true;
    this.cmbTransactionType.Items.AddRange(new object[4]
    {
      (object) "Payment",
      (object) "Receipt",
      (object) "Contra",
      (object) "Bill"
    });
    ComboBox cmbTransactionType1 = this.cmbTransactionType;
    Point point1 = new Point(326, 199);
    Point point2 = point1;
    cmbTransactionType1.Location = point2;
    this.cmbTransactionType.Name = "cmbTransactionType";
    ComboBox cmbTransactionType2 = this.cmbTransactionType;
    Size size1 = new Size(143, 24);
    Size size2 = size1;
    cmbTransactionType2.Size = size2;
    this.cmbTransactionType.TabIndex = 0;
    this.cmbTransactionType.Text = "Payment";
    this.lblcashbank.AutoSize = true;
    this.lblcashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblcashbank1 = this.lblcashbank;
    point1 = new Point(125, 202);
    Point point3 = point1;
    lblcashbank1.Location = point3;
    this.lblcashbank.Name = "lblcashbank";
    Label lblcashbank2 = this.lblcashbank;
    size1 = new Size(155, 16 /*0x10*/);
    Size size3 = size1;
    lblcashbank2.Size = size3;
    this.lblcashbank.TabIndex = 77;
    this.lblcashbank.Text = "Select Transaction Type";
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(123, 262);
    Point point4 = point1;
    label2_1.Location = point4;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(153, 16 /*0x10*/);
    Size size4 = size1;
    label2_2.Size = size4;
    this.Label2.TabIndex = 79;
    this.Label2.Text = "Transaction Short Name";
    this.txtShortNameAbr.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtShortNameAbr1 = this.txtShortNameAbr;
    point1 = new Point(326, 256 /*0x0100*/);
    Point point5 = point1;
    txtShortNameAbr1.Location = point5;
    this.txtShortNameAbr.MaxLength = 4;
    this.txtShortNameAbr.Name = "txtShortNameAbr";
    TextBox txtShortNameAbr2 = this.txtShortNameAbr;
    size1 = new Size(143, 22);
    Size size5 = size1;
    txtShortNameAbr2.Size = size5;
    this.txtShortNameAbr.TabIndex = 1;
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    point1 = new Point(198, 412);
    Point point6 = point1;
    btnSave1.Location = point6;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    size1 = new Size(99, 33);
    Size size6 = size1;
    btnSave2.Size = size6;
    this.btnSave.TabIndex = 2;
    this.btnSave.Text = "Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(303, 412);
    Point point7 = point1;
    btnExit1.Location = point7;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size7 = size1;
    btnExit2.Size = size7;
    this.btnExit.TabIndex = 3;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.lblTranId.AutoSize = true;
    Label lblTranId1 = this.lblTranId;
    point1 = new Point(48 /*0x30*/, 57);
    Point point8 = point1;
    lblTranId1.Location = point8;
    this.lblTranId.Name = "lblTranId";
    Label lblTranId2 = this.lblTranId;
    size1 = new Size(13, 13);
    Size size8 = size1;
    lblTranId2.Size = size8;
    this.lblTranId.TabIndex = 82;
    this.lblTranId.Text = "0";
    this.lblOldTranType.AutoSize = true;
    Label lblOldTranType1 = this.lblOldTranType;
    point1 = new Point(48 /*0x30*/, 16 /*0x10*/);
    Point point9 = point1;
    lblOldTranType1.Location = point9;
    this.lblOldTranType.Name = "lblOldTranType";
    Label lblOldTranType2 = this.lblOldTranType;
    size1 = new Size(35, 13);
    Size size9 = size1;
    lblOldTranType2.Size = size9;
    this.lblOldTranType.TabIndex = 83;
    this.lblOldTranType.Text = "AAAA";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(51, 32 /*0x20*/);
    Point point10 = point1;
    dataGridView1_1.Location = point10;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView1_2.Size = size10;
    this.DataGridView1.TabIndex = 84;
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.lblOldTranType);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.lblTranId);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(75, 71);
    Point point11 = point1;
    grpVisible1.Location = point11;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(126, 75);
    Size size11 = size1;
    grpVisible2.Size = size11;
    this.grpVisible.TabIndex = 85;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(83, 32 /*0x20*/);
    Point point12 = point1;
    dataGridView2_1.Location = point12;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size12 = size1;
    dataGridView2_2.Size = size12;
    this.DataGridView2.TabIndex = 85;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtShortNameAbr);
    this.Controls.Add((Control) this.cmbTransactionType);
    this.Controls.Add((Control) this.lblcashbank);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmTranTypeDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Transaction Type Add";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual ComboBox cmbTransactionType
  {
    [DebuggerNonUserCode] get => this._cmbTransactionType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbTransactionType_KeyDown);
      if (this._cmbTransactionType != null)
        this._cmbTransactionType.KeyDown -= keyEventHandler;
      this._cmbTransactionType = value;
      if (this._cmbTransactionType == null)
        return;
      this._cmbTransactionType.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label lblcashbank
  {
    [DebuggerNonUserCode] get => this._lblcashbank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblcashbank = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual TextBox txtShortNameAbr
  {
    [DebuggerNonUserCode] get => this._txtShortNameAbr;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtShortNameAbr_KeyDown);
      if (this._txtShortNameAbr != null)
        this._txtShortNameAbr.KeyDown -= keyEventHandler;
      this._txtShortNameAbr = value;
      if (this._txtShortNameAbr == null)
        return;
      this._txtShortNameAbr.KeyDown += keyEventHandler;
    }
  }

  internal virtual Button btnSave
  {
    [DebuggerNonUserCode] get => this._btnSave;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      if (this._btnSave != null)
        this._btnSave.Click -= eventHandler;
      this._btnSave = value;
      if (this._btnSave == null)
        return;
      this._btnSave.Click += eventHandler;
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

  internal virtual Label lblTranId
  {
    [DebuggerNonUserCode] get => this._lblTranId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblTranId = value;
    }
  }

  internal virtual Label lblOldTranType
  {
    [DebuggerNonUserCode] get => this._lblOldTranType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblOldTranType = value;
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

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      int num1 = (int) MyProject.Forms.DeleteDialog.ShowDialog();
    }
    if (Conversions.ToDouble(MyProject.Forms.DeleteDialog.lblResult.Text) == 1.0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShortNameAbr.Text, "", false) == 0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Cannot Blank ! Try again.");
        this.txtShortNameAbr.Focus();
      }
      else if (Strings.Len(this.txtShortNameAbr.Text.Trim()) != 4)
      {
        int num3 = (int) Interaction.MsgBox((object) "Required 4 Charcter ! Try again.");
        this.txtShortNameAbr.Focus();
      }
      else
      {
        int num4;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
        {
          int num5 = checked (MyProject.Forms.frmTranType.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num5)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShortNameAbr.Text.Trim(), MyProject.Forms.frmTranType.DataGridView1.Rows[index].Cells[3].Value.ToString().Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbTransactionType.Text.Trim(), MyProject.Forms.frmTranType.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), false) == 0)
              checked { ++num4; }
            checked { ++index; }
          }
          if (num4 >= 1)
          {
            int num6 = (int) Interaction.MsgBox((object) "Duplicate Transaction");
            this.txtShortNameAbr.Focus();
            return;
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
        {
          int num7 = checked (MyProject.Forms.frmTranType.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num7)
          {
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject((object) (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShortNameAbr.Text.Trim(), MyProject.Forms.frmTranType.DataGridView1.Rows[index].Cells[3].Value.ToString().Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbTransactionType.Text.Trim(), MyProject.Forms.frmTranType.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), false) == 0), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual((object) Conversion.Val(this.lblTranId.Text), MyProject.Forms.frmTranType.DataGridView1.Rows[index].Cells[0].Value, false))))
              checked { ++num4; }
            checked { ++index; }
          }
          if (num4 >= 1)
          {
            int num8 = (int) Interaction.MsgBox((object) "Duplicate Transaction");
            this.txtShortNameAbr.Focus();
            return;
          }
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
        {
          string Left = "";
          int num9 = checked (MyProject.Forms.frmTranType.DataGridView1.RowCount - 1);
          int index1 = 0;
          while (index1 <= num9)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbTransactionType.Text.Trim(), MyProject.Forms.frmTranType.DataGridView1.Rows[index1].Cells[1].Value.ToString().Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmTranType.DataGridView1.Rows[index1].Cells[4].Value.ToString(), "M", false) == 0)
              Left = MyProject.Forms.frmTranType.DataGridView1.Rows[index1].Cells[2].Value.ToString();
            checked { ++index1; }
          }
          OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
          OleDbCommand oleDbCommand1 = new OleDbCommand($"Insert Into SocTranType (Transaction_Name, Main_Abr, Sub_Abr, Type_Type) values ('{this.cmbTransactionType.Text.Trim()} ','{Left}','{this.txtShortNameAbr.Text}','S')", oleDbConnection);
          oleDbConnection.Open();
          oleDbCommand1.ExecuteNonQuery();
          oleDbConnection.Close();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Bill", false) == 0)
          {
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocBillMaster WHERE (SocBillMaster.BMasterNo='BM01')", oleDbConnection);
            DataTable dataTable1 = new DataTable("SocBillMaster");
            DataTable dataTable2 = new DataTable("SocBillMaster");
            oleDbDataAdapter.Fill(dataTable2);
            this.DataGridView2.DataSource = (object) dataTable2;
            this.DataGridView2.ReadOnly = true;
            this.DataGridView2.RowHeadersVisible = false;
            this.DataGridView2.AllowUserToAddRows = false;
            int num10 = checked (this.DataGridView2.RowCount - 1);
            int index2 = 0;
            while (index2 <= num10)
            {
              OleDbCommand oleDbCommand2 = new OleDbCommand($"Insert Into SocBillMaster (SocMemId, Amt01, Amt02, Amt03, Amt04, Amt05, Amt06, Amt07, Amt08, Amt09, Amt10, Amt11, Amt12, Amt13, Amt14, Amt15, Amt16, Amt17, Amt18, Amt19, Amt20, Amt21, AmtInt, AmtSTax, AmtTotal, BMasterNo) values ({Conversions.ToString(Conversion.Val(this.DataGridView2.Rows[index2].Cells[1].Value.ToString()))} ,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,'{this.txtShortNameAbr.Text.Trim()}')", oleDbConnection);
              oleDbConnection.Open();
              oleDbCommand2.ExecuteNonQuery();
              oleDbConnection.Close();
              checked { ++index2; }
            }
          }
          this.Close();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
        {
          string Left = "";
          int num11 = checked (MyProject.Forms.frmTranType.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num11)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbTransactionType.Text.Trim(), MyProject.Forms.frmTranType.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmTranType.DataGridView1.Rows[index].Cells[4].Value.ToString(), "M", false) == 0)
              Left = MyProject.Forms.frmTranType.DataGridView1.Rows[index].Cells[2].Value.ToString();
            checked { ++index; }
          }
          OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
          OleDbCommand oleDbCommand3 = new OleDbCommand($"update SocTranType set Transaction_Name = '{this.cmbTransactionType.Text.Trim()} ', Main_Abr = '{Left}', Sub_Abr ='{this.txtShortNameAbr.Text}', Type_Type = 'S' where Id ={Conversions.ToString(Conversion.Val(this.lblTranId.Text))}", connection);
          connection.Open();
          oleDbCommand3.ExecuteNonQuery();
          connection.Close();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Bill", false) == 0)
          {
            OleDbCommand oleDbCommand4 = new OleDbCommand($"update SocBillMaster set BMasterNo = '{this.txtShortNameAbr.Text} 'where BMasterNo ='{this.lblOldTranType.Text}'", connection);
            connection.Open();
            oleDbCommand4.ExecuteNonQuery();
            connection.Close();
          }
          else
          {
            OleDbCommand oleDbCommand5 = new OleDbCommand($"update SocTran set SubTranType = '{this.txtShortNameAbr.Text} 'where SubTranType ='{this.lblOldTranType.Text}'", connection);
            connection.Open();
            oleDbCommand5.ExecuteNonQuery();
            connection.Close();
            OleDbCommand oleDbCommand6 = new OleDbCommand($"update SocCashBook set SubTranType = '{this.txtShortNameAbr.Text} 'where SubTranType ='{this.lblOldTranType.Text}'", connection);
            connection.Open();
            oleDbCommand6.ExecuteNonQuery();
            connection.Close();
          }
          this.Close();
        }
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
        {
          string Left = "";
          int num12 = checked (MyProject.Forms.frmTranType.DataGridView1.RowCount - 1);
          int index = 0;
          while (index <= num12)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbTransactionType.Text.Trim(), MyProject.Forms.frmTranType.DataGridView1.Rows[index].Cells[1].Value.ToString().Trim(), false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmTranType.DataGridView1.Rows[index].Cells[4].Value.ToString(), "M", false) == 0)
              Left = MyProject.Forms.frmTranType.DataGridView1.Rows[index].Cells[2].Value.ToString();
            checked { ++index; }
          }
          OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
          OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocTran.* FROM SocTran WHERE SubTranType = '{this.txtShortNameAbr.Text.Trim()}' order by SubTranType asc", oleDbConnection);
          DataTable dataTable = new DataTable("SocTran");
          oleDbDataAdapter.Fill(dataTable);
          this.DataGridView1.DataSource = (object) dataTable;
          this.DataGridView1.ReadOnly = true;
          this.DataGridView1.RowHeadersVisible = false;
          this.DataGridView1.AllowUserToAddRows = false;
          if (this.DataGridView1.RowCount >= 1)
          {
            int num13 = (int) Interaction.MsgBox((object) "Cannot Delete Transaction Type related with Transaction");
          }
          else
          {
            OleDbCommand oleDbCommand7 = new OleDbCommand($"Delete From SocTranType where Id ={Conversions.ToString(Conversion.Val(this.lblTranId.Text))}", oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand7.ExecuteNonQuery();
            oleDbConnection.Close();
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "Bill", false) == 0)
            {
              OleDbCommand oleDbCommand8 = new OleDbCommand($"Delete From SocBillMaster where BMasterNo = '{this.txtShortNameAbr.Text.Trim()}'", oleDbConnection);
              oleDbConnection.Open();
              oleDbCommand8.ExecuteNonQuery();
              oleDbConnection.Close();
            }
            this.Close();
          }
        }
      }
    }
  }

  private void frmTranTypeDetail_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmTranTypeDetail_Load(object sender, EventArgs e)
  {
    this.lblTranId.Text = "0";
    this.lblOldTranType.Text = "AAAA";
    this.grpVisible.Visible = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Update", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) == 0)
    {
      this.lblTranId.Text = MyProject.Forms.frmTranType.DataGridView2.CurrentRow.Cells[0].Value.ToString();
      this.cmbTransactionType.Text = MyProject.Forms.frmTranType.DataGridView2.CurrentRow.Cells[1].Value.ToString();
      this.txtShortNameAbr.Text = MyProject.Forms.frmTranType.DataGridView2.CurrentRow.Cells[3].Value.ToString();
      this.lblOldTranType.Text = MyProject.Forms.frmTranType.DataGridView2.CurrentRow.Cells[3].Value.ToString();
      this.cmbTransactionType.Enabled = false;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnSave.Text, "&Delete", false) != 0)
      return;
    this.lblTranId.Enabled = false;
    this.cmbTransactionType.Enabled = false;
    this.txtShortNameAbr.Enabled = false;
  }

  private void cmbTransactionType_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.txtShortNameAbr.Focus();
  }

  private void txtShortNameAbr_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
