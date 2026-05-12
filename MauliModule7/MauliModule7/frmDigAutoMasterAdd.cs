// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmDigAutoMasterAdd
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
public class frmDigAutoMasterAdd : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("TableLayoutPanel1")]
  private TableLayoutPanel _TableLayoutPanel1;
  [AccessedThroughProperty("OK_Button")]
  private Button _OK_Button;
  [AccessedThroughProperty("Cancel_Button")]
  private Button _Cancel_Button;
  [AccessedThroughProperty("cmbBillSetting")]
  private ComboBox _cmbBillSetting;
  [AccessedThroughProperty("txtAmount")]
  private TextBox _txtAmount;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("cmbType")]
  private ComboBox _cmbType;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("lblHeading")]
  private Label _lblHeading;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;

  [DebuggerNonUserCode]
  static frmDigAutoMasterAdd()
  {
  }

  [DebuggerNonUserCode]
  public frmDigAutoMasterAdd()
  {
    this.Load += new EventHandler(this.frmDigAutoMasterAdd_Load);
    frmDigAutoMasterAdd.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmDigAutoMasterAdd.__ENCList)
    {
      if (frmDigAutoMasterAdd.__ENCList.Count == frmDigAutoMasterAdd.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmDigAutoMasterAdd.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmDigAutoMasterAdd.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmDigAutoMasterAdd.__ENCList[index1] = frmDigAutoMasterAdd.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmDigAutoMasterAdd.__ENCList.RemoveRange(index1, checked (frmDigAutoMasterAdd.__ENCList.Count - index1));
        frmDigAutoMasterAdd.__ENCList.Capacity = frmDigAutoMasterAdd.__ENCList.Count;
      }
      frmDigAutoMasterAdd.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.TableLayoutPanel1 = new TableLayoutPanel();
    this.OK_Button = new Button();
    this.Cancel_Button = new Button();
    this.cmbBillSetting = new ComboBox();
    this.txtAmount = new TextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.cmbType = new ComboBox();
    this.Label3 = new Label();
    this.lblHeading = new Label();
    this.Button2 = new Button();
    this.TableLayoutPanel1.SuspendLayout();
    this.SuspendLayout();
    this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.TableLayoutPanel1.ColumnCount = 2;
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
    this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
    this.TableLayoutPanel1.Controls.Add((Control) this.OK_Button, 0, 0);
    this.TableLayoutPanel1.Controls.Add((Control) this.Cancel_Button, 1, 0);
    TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
    Point point1 = new Point(86, 294);
    Point point2 = point1;
    tableLayoutPanel1_1.Location = point2;
    this.TableLayoutPanel1.Name = "TableLayoutPanel1";
    this.TableLayoutPanel1.RowCount = 1;
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
    this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29f));
    TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
    Size size1 = new Size(146, 29);
    Size size2 = size1;
    tableLayoutPanel1_2.Size = size2;
    this.TableLayoutPanel1.TabIndex = 4;
    this.OK_Button.Anchor = AnchorStyles.None;
    Button okButton1 = this.OK_Button;
    point1 = new Point(3, 3);
    Point point3 = point1;
    okButton1.Location = point3;
    this.OK_Button.Name = "OK_Button";
    Button okButton2 = this.OK_Button;
    size1 = new Size(67, 23);
    Size size3 = size1;
    okButton2.Size = size3;
    this.OK_Button.TabIndex = 5;
    this.OK_Button.Text = "OK";
    this.Cancel_Button.Anchor = AnchorStyles.None;
    this.Cancel_Button.DialogResult = DialogResult.Cancel;
    Button cancelButton1 = this.Cancel_Button;
    point1 = new Point(76, 3);
    Point point4 = point1;
    cancelButton1.Location = point4;
    this.Cancel_Button.Name = "Cancel_Button";
    Button cancelButton2 = this.Cancel_Button;
    size1 = new Size(67, 23);
    Size size4 = size1;
    cancelButton2.Size = size4;
    this.Cancel_Button.TabIndex = 6;
    this.Cancel_Button.Text = "Cancel";
    this.cmbBillSetting.FormattingEnabled = true;
    ComboBox cmbBillSetting1 = this.cmbBillSetting;
    point1 = new Point(126, 94);
    Point point5 = point1;
    cmbBillSetting1.Location = point5;
    this.cmbBillSetting.Name = "cmbBillSetting";
    ComboBox cmbBillSetting2 = this.cmbBillSetting;
    size1 = new Size(165, 21);
    Size size5 = size1;
    cmbBillSetting2.Size = size5;
    this.cmbBillSetting.TabIndex = 0;
    TextBox txtAmount1 = this.txtAmount;
    point1 = new Point(126, 218);
    Point point6 = point1;
    txtAmount1.Location = point6;
    this.txtAmount.Name = "txtAmount";
    TextBox txtAmount2 = this.txtAmount;
    size1 = new Size(70, 20);
    Size size6 = size1;
    txtAmount2.Size = size6;
    this.txtAmount.TabIndex = 3;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(27, 97);
    Point point7 = point1;
    label1_1.Location = point7;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(80 /*0x50*/, 13);
    Size size7 = size1;
    label1_2.Size = size7;
    this.Label1.TabIndex = 3;
    this.Label1.Text = "Select Account";
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(27, 222);
    Point point8 = point1;
    label2_1.Location = point8;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(43, 13);
    Size size8 = size1;
    label2_2.Size = size8;
    this.Label2.TabIndex = 4;
    this.Label2.Text = "Amount";
    this.cmbType.FormattingEnabled = true;
    this.cmbType.Items.AddRange(new object[2]
    {
      (object) "By Amount",
      (object) "By Sq.ft."
    });
    ComboBox cmbType1 = this.cmbType;
    point1 = new Point(126, 157);
    Point point9 = point1;
    cmbType1.Location = point9;
    this.cmbType.Name = "cmbType";
    ComboBox cmbType2 = this.cmbType;
    size1 = new Size(165, 21);
    Size size9 = size1;
    cmbType2.Size = size9;
    this.cmbType.TabIndex = 2;
    this.cmbType.Text = "By Amount";
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(27, 160 /*0xA0*/);
    Point point10 = point1;
    label3_1.Location = point10;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(64 /*0x40*/, 13);
    Size size10 = size1;
    label3_2.Size = size10;
    this.Label3.TabIndex = 6;
    this.Label3.Text = "Select Type";
    this.lblHeading.AutoSize = true;
    this.lblHeading.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblHeading.ForeColor = Color.Blue;
    Label lblHeading1 = this.lblHeading;
    point1 = new Point(73, 35);
    Point point11 = point1;
    lblHeading1.Location = point11;
    this.lblHeading.Name = "lblHeading";
    Label lblHeading2 = this.lblHeading;
    size1 = new Size(172, 20);
    Size size11 = size1;
    lblHeading2.Size = size11;
    this.lblHeading.TabIndex = 29;
    this.lblHeading.Text = "Auto Master Multiply";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(153, 157);
    Point point12 = point1;
    button2_1.Location = point12;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(23, 21);
    Size size12 = size1;
    button2_2.Size = size12;
    this.Button2.TabIndex = 84;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.AcceptButton = (IButtonControl) this.OK_Button;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.Cancel_Button;
    size1 = new Size(319, 368);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.lblHeading);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.cmbType);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtAmount);
    this.Controls.Add((Control) this.cmbBillSetting);
    this.Controls.Add((Control) this.TableLayoutPanel1);
    this.Controls.Add((Control) this.Button2);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmDigAutoMasterAdd);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "AutoMaster";
    this.TableLayoutPanel1.ResumeLayout(false);
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual TableLayoutPanel TableLayoutPanel1
  {
    [DebuggerNonUserCode] get => this._TableLayoutPanel1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._TableLayoutPanel1 = value;
    }
  }

  internal virtual Button OK_Button
  {
    [DebuggerNonUserCode] get => this._OK_Button;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OK_Button_Click);
      if (this._OK_Button != null)
        this._OK_Button.Click -= eventHandler;
      this._OK_Button = value;
      if (this._OK_Button == null)
        return;
      this._OK_Button.Click += eventHandler;
    }
  }

  internal virtual Button Cancel_Button
  {
    [DebuggerNonUserCode] get => this._Cancel_Button;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Cancel_Button_Click);
      if (this._Cancel_Button != null)
        this._Cancel_Button.Click -= eventHandler;
      this._Cancel_Button = value;
      if (this._Cancel_Button == null)
        return;
      this._Cancel_Button.Click += eventHandler;
    }
  }

  internal virtual ComboBox cmbBillSetting
  {
    [DebuggerNonUserCode] get => this._cmbBillSetting;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._cmbBillSetting = value;
    }
  }

  internal virtual TextBox txtAmount
  {
    [DebuggerNonUserCode] get => this._txtAmount;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtAmount = value;
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

  internal virtual ComboBox cmbType
  {
    [DebuggerNonUserCode] get => this._cmbType;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._cmbType = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual Label lblHeading
  {
    [DebuggerNonUserCode] get => this._lblHeading;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblHeading = value;
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

  private void OK_Button_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void Cancel_Button_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void frmDigAutoMasterAdd_Load(object sender, EventArgs e)
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocAccount.AccCode,SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName FROM SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", selectConnection);
    DataTable dataTable = new DataTable("SocBillSetting");
    oleDbDataAdapter.Fill(dataTable);
    this.cmbBillSetting.DataSource = (object) dataTable;
    this.cmbBillSetting.DisplayMember = "AccName";
    this.cmbBillSetting.ValueMember = "SocAccountMainId";
    selectConnection.Close();
    this.cmbBillSetting.Focus();
    this.txtAmount.Text = "0";
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }
}
