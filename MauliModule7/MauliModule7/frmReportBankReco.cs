// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmReportBankReco
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MauliModule7.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
public class frmReportBankReco : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("mtxtDate")]
  private MaskedTextBox _mtxtDate;
  [AccessedThroughProperty("cmbCashbank")]
  private ComboBox _cmbCashbank;
  [AccessedThroughProperty("btnPrint")]
  private Button _btnPrint;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("cmbNarration")]
  private ComboBox _cmbNarration;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("DataGridView4")]
  private DataGridView _DataGridView4;
  [AccessedThroughProperty("lblBOA")]
  private Label _lblBOA;
  [AccessedThroughProperty("lblFileName")]
  private Label _lblFileName;
  [AccessedThroughProperty("lblSelectedvalue")]
  private Label _lblSelectedvalue;
  private int rk;

  [DebuggerNonUserCode]
  static frmReportBankReco()
  {
  }

  [DebuggerNonUserCode]
  public frmReportBankReco()
  {
    this.KeyDown += new KeyEventHandler(this.frmReportBankReco_KeyDown);
    this.Load += new EventHandler(this.frmReportBankReco_Load);
    frmReportBankReco.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmReportBankReco.__ENCList)
    {
      if (frmReportBankReco.__ENCList.Count == frmReportBankReco.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmReportBankReco.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmReportBankReco.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmReportBankReco.__ENCList[index1] = frmReportBankReco.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmReportBankReco.__ENCList.RemoveRange(index1, checked (frmReportBankReco.__ENCList.Count - index1));
        frmReportBankReco.__ENCList.Capacity = frmReportBankReco.__ENCList.Count;
      }
      frmReportBankReco.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmReportBankReco));
    this.mtxtDate = new MaskedTextBox();
    this.cmbCashbank = new ComboBox();
    this.btnPrint = new Button();
    this.Label1 = new Label();
    this.DataGridView1 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.Label2 = new Label();
    this.cmbNarration = new ComboBox();
    this.DataGridView3 = new DataGridView();
    this.grpVisible = new GroupBox();
    this.DataGridView4 = new DataGridView();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.lblBOA = new Label();
    this.lblFileName = new Label();
    this.lblSelectedvalue = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    this.grpVisible.SuspendLayout();
    ((ISupportInitialize) this.DataGridView4).BeginInit();
    this.SuspendLayout();
    this.mtxtDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDate.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDate1 = this.mtxtDate;
    Point point1 = new Point(79, 143);
    Point point2 = point1;
    mtxtDate1.Location = point2;
    this.mtxtDate.Mask = "00/00/0000";
    this.mtxtDate.Name = "mtxtDate";
    MaskedTextBox mtxtDate2 = this.mtxtDate;
    Size size1 = new Size(77, 22);
    Size size2 = size1;
    mtxtDate2.Size = size2;
    this.mtxtDate.TabIndex = 1;
    this.mtxtDate.ValidatingType = typeof (DateTime);
    this.cmbCashbank.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbCashbank.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.cmbCashbank.FormattingEnabled = true;
    ComboBox cmbCashbank1 = this.cmbCashbank;
    point1 = new Point(78, 91);
    Point point3 = point1;
    cmbCashbank1.Location = point3;
    this.cmbCashbank.Name = "cmbCashbank";
    ComboBox cmbCashbank2 = this.cmbCashbank;
    size1 = new Size(221, 24);
    Size size3 = size1;
    cmbCashbank2.Size = size3;
    this.cmbCashbank.TabIndex = 0;
    Button btnPrint1 = this.btnPrint;
    point1 = new Point(111, 289);
    Point point4 = point1;
    btnPrint1.Location = point4;
    this.btnPrint.Name = "btnPrint";
    Button btnPrint2 = this.btnPrint;
    size1 = new Size(99, 33);
    Size size4 = size1;
    btnPrint2.Size = size4;
    this.btnPrint.TabIndex = 4;
    this.btnPrint.Text = "&Preview";
    this.btnPrint.UseVisualStyleBackColor = true;
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    point1 = new Point(8, 96 /*0x60*/);
    Point point5 = point1;
    label1_1.Location = point5;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(65, 13);
    Size size5 = size1;
    label1_2.Size = size5;
    this.Label1.TabIndex = 19;
    this.Label1.Text = "Select Bank";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(5, 48 /*0x30*/);
    Point point6 = point1;
    dataGridView1_1.Location = point6;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(10, 10);
    Size size6 = size1;
    dataGridView1_2.Size = size6;
    this.DataGridView1.TabIndex = 20;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(6, 64 /*0x40*/);
    Point point7 = point1;
    dataGridView2_1.Location = point7;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(10, 10);
    Size size7 = size1;
    dataGridView2_2.Size = size7;
    this.DataGridView2.TabIndex = 21;
    this.Label2.AutoSize = true;
    Label label2_1 = this.Label2;
    point1 = new Point(8, 205);
    Point point8 = point1;
    label2_1.Location = point8;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(50, 13);
    Size size8 = size1;
    label2_2.Size = size8;
    this.Label2.TabIndex = 23;
    this.Label2.Text = "Narration";
    this.cmbNarration.FormattingEnabled = true;
    this.cmbNarration.Items.AddRange(new object[2]
    {
      (object) "Yes",
      (object) "No"
    });
    ComboBox cmbNarration1 = this.cmbNarration;
    point1 = new Point(79, 202);
    Point point9 = point1;
    cmbNarration1.Location = point9;
    this.cmbNarration.Name = "cmbNarration";
    ComboBox cmbNarration2 = this.cmbNarration;
    size1 = new Size(66, 21);
    Size size9 = size1;
    cmbNarration2.Size = size9;
    this.cmbNarration.TabIndex = 3;
    this.cmbNarration.Text = "No";
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new Point(5, 15);
    Point point10 = point1;
    dataGridView3_1.Location = point10;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(10, 10);
    Size size10 = size1;
    dataGridView3_2.Size = size10;
    this.DataGridView3.TabIndex = 24;
    this.grpVisible.Controls.Add((Control) this.lblSelectedvalue);
    this.grpVisible.Controls.Add((Control) this.lblFileName);
    this.grpVisible.Controls.Add((Control) this.lblBOA);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.DataGridView3);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.DataGridView4);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(256 /*0x0100*/, 202);
    Point point11 = point1;
    grpVisible1.Location = point11;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(43, 120);
    Size size11 = size1;
    grpVisible2.Size = size11;
    this.grpVisible.TabIndex = 25;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView4_1 = this.DataGridView4;
    point1 = new Point(5, 31 /*0x1F*/);
    Point point12 = point1;
    dataGridView4_1.Location = point12;
    this.DataGridView4.Name = "DataGridView4";
    DataGridView dataGridView4_2 = this.DataGridView4;
    size1 = new Size(10, 11);
    Size size12 = size1;
    dataGridView4_2.Size = size12;
    this.DataGridView4.TabIndex = 25;
    this.Label3.AutoSize = true;
    Label label3_1 = this.Label3;
    point1 = new Point(8, 148);
    Point point13 = point1;
    label3_1.Location = point13;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(34, 13);
    Size size13 = size1;
    label3_2.Size = size13;
    this.Label3.TabIndex = 26;
    this.Label3.Text = "As on";
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Blue;
    Label label4_1 = this.Label4;
    point1 = new Point(37, 26);
    Point point14 = point1;
    label4_1.Location = point14;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(257, 20);
    Size size14 = size1;
    label4_2.Size = size14;
    this.Label4.TabIndex = 27;
    this.Label4.Text = "Bank Reconciliation Statement";
    this.lblBOA.AutoSize = true;
    Label lblBoa1 = this.lblBOA;
    point1 = new Point(7, 54);
    Point point15 = point1;
    lblBoa1.Location = point15;
    this.lblBOA.Name = "lblBOA";
    Label lblBoa2 = this.lblBOA;
    size1 = new Size(28, 13);
    Size size15 = size1;
    lblBoa2.Size = size15;
    this.lblBOA.TabIndex = 34;
    this.lblBOA.Text = "Print";
    this.lblFileName.AutoSize = true;
    Label lblFileName1 = this.lblFileName;
    point1 = new Point(2, 82);
    Point point16 = point1;
    lblFileName1.Location = point16;
    this.lblFileName.Name = "lblFileName";
    Label lblFileName2 = this.lblFileName;
    size1 = new Size(51, 13);
    Size size16 = size1;
    lblFileName2.Size = size16;
    this.lblFileName.TabIndex = 35;
    this.lblFileName.Text = "FileName";
    this.lblSelectedvalue.AutoSize = true;
    Label lblSelectedvalue1 = this.lblSelectedvalue;
    point1 = new Point(22, 95);
    Point point17 = point1;
    lblSelectedvalue1.Location = point17;
    this.lblSelectedvalue.Name = "lblSelectedvalue";
    Label lblSelectedvalue2 = this.lblSelectedvalue;
    size1 = new Size(13, 13);
    Size size17 = size1;
    lblSelectedvalue2.Size = size17;
    this.lblSelectedvalue.TabIndex = 36;
    this.lblSelectedvalue.Text = "0";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(317, 366);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.mtxtDate);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.cmbNarration);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnPrint);
    this.Controls.Add((Control) this.cmbCashbank);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.KeyPreview = true;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmReportBankReco);
    this.ShowIcon = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Bank Reco Print";
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    ((ISupportInitialize) this.DataGridView4).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual MaskedTextBox mtxtDate
  {
    [DebuggerNonUserCode] get => this._mtxtDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtDate_KeyDown);
      EventHandler eventHandler1 = new EventHandler(this.mtxtDate_Validated);
      EventHandler eventHandler2 = new EventHandler(this.mtxtDate_GotFocus);
      if (this._mtxtDate != null)
      {
        this._mtxtDate.KeyDown -= keyEventHandler;
        this._mtxtDate.Validated -= eventHandler1;
        this._mtxtDate.GotFocus -= eventHandler2;
      }
      this._mtxtDate = value;
      if (this._mtxtDate == null)
        return;
      this._mtxtDate.KeyDown += keyEventHandler;
      this._mtxtDate.Validated += eventHandler1;
      this._mtxtDate.GotFocus += eventHandler2;
    }
  }

  internal virtual ComboBox cmbCashbank
  {
    [DebuggerNonUserCode] get => this._cmbCashbank;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbCashbank_KeyDown);
      if (this._cmbCashbank != null)
        this._cmbCashbank.KeyDown -= keyEventHandler;
      this._cmbCashbank = value;
      if (this._cmbCashbank == null)
        return;
      this._cmbCashbank.KeyDown += keyEventHandler;
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

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual ComboBox cmbNarration
  {
    [DebuggerNonUserCode] get => this._cmbNarration;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.cmbNarration_KeyDown);
      if (this._cmbNarration != null)
        this._cmbNarration.KeyDown -= keyEventHandler;
      this._cmbNarration = value;
      if (this._cmbNarration == null)
        return;
      this._cmbNarration.KeyDown += keyEventHandler;
    }
  }

  internal virtual DataGridView DataGridView3
  {
    [DebuggerNonUserCode] get => this._DataGridView3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView3 = value;
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

  internal virtual DataGridView DataGridView4
  {
    [DebuggerNonUserCode] get => this._DataGridView4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView4 = value;
    }
  }

  internal virtual Label lblBOA
  {
    [DebuggerNonUserCode] get => this._lblBOA;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblBOA = value;
  }

  internal virtual Label lblFileName
  {
    [DebuggerNonUserCode] get => this._lblFileName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblFileName = value;
    }
  }

  internal virtual Label lblSelectedvalue
  {
    [DebuggerNonUserCode] get => this._lblSelectedvalue;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblSelectedvalue = value;
    }
  }

  private void frmReportBankReco_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape)
      return;
    this.Close();
  }

  private void frmReportBankReco_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
    this.GetFillCashCmb();
    this.cmbNarration.Text = "No";
    this.mtxtDate.Text = Conversions.ToString(Constant.socFYEND);
  }

  public DataSet GetFillCashCmb()
  {
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter($"SELECT SocAccount.*,SocAccountMain.SocSubGroupId,SocAccountMain.SocGroupId,SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId WHERE (SocAccountMain.SocAccountType=1 AND SocAccountMain.SocGroupId={Conversions.ToString(Constant.SocCashBank)} ) order by AccName asc", selectConnection);
    DataTable dataTable = new DataTable("SocAccountMain");
    oleDbDataAdapter.Fill(dataTable);
    this.cmbCashbank.DataSource = (object) dataTable;
    this.cmbCashbank.DisplayMember = "AccName";
    this.cmbCashbank.ValueMember = "SocAccountMainId";
    selectConnection.Close();
    DataSet fillCashCmb;
    return fillCashCmb;
  }

  public DataSet GetFillGrid()
  {
    Constant.dateRangeto = this.mtxtDate.Text;
    Constant.dateRangeto = MyProject.Forms.frmSocietyDetail.Chdatesql(Constant.dateRangeto);
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter2;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBOA.Text, "BOA", false) == 0)
      oleDbDataAdapter2 = new OleDbDataAdapter($"SELECT SocTran.SocTranbcr, * FROM SocTran LEFT JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranbcr)>#{Constant.dateRangeto}# Or (SocTran.SocTranbcr) Is Null) AND ((SocTran.SocTranDate)<=#{Constant.dateRangeto}#) AND ((SocTran.SocTranType)='Pymt' Or (SocTran.SocTranType)='Rcpt' Or (SocTran.SocTranType)='Ctra' Or (SocTran.SocTranType)='MRct'  Or (SocTran.SocTranType)='MAdj' Or (SocTran.SocTranType)='OpBR') AND ((SocTran.SocAccountMainId)={Conversions.ToString(Conversion.Val(this.lblSelectedvalue.Text))})) ORDER BY SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo", selectConnection);
    else
      oleDbDataAdapter2 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocTranbcr, * FROM SocTran LEFT JOIN SocMember ON SocTran.AccName1 = SocMember.MemCode WHERE (((SocTran.SocTranbcr)>#" + Constant.dateRangeto + "# Or (SocTran.SocTranbcr) Is Null) AND ((SocTran.SocTranDate)<=#" + Constant.dateRangeto + "#) AND ((SocTran.SocTranType)='Pymt' Or (SocTran.SocTranType)='Rcpt' Or (SocTran.SocTranType)='Ctra' Or (SocTran.SocTranType)='MRct'  Or (SocTran.SocTranType)='MAdj' Or (SocTran.SocTranType)='OpBR') AND ((SocTran.SocAccountMainId)="), this.cmbCashbank.SelectedValue), (object) ")) ORDER BY SocTran.SocTranDate, SocTran.SocTranType, SocTran.SocTranNo")), selectConnection);
    DataTable dataTable1 = new DataTable("SocAccountMain");
    oleDbDataAdapter2.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter3 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter4;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBOA.Text, "BOA", false) == 0)
      oleDbDataAdapter4 = new OleDbDataAdapter($"SELECT SocTran.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE(((SocTran.SocTranType)<>'OpBR') AND ((SocTran.SocTranDate)<=#{Constant.dateRangeto}#)) GROUP BY SocTran.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal HAVING (((SocTran.SocAccountMainId)={Conversions.ToString(Conversion.Val(this.lblSelectedvalue.Text))}))", selectConnection);
    else
      oleDbDataAdapter4 = new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT SocTran.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, Sum(SocTran.SocTranAmount) AS SumOfSocTranAmount FROM SocTran INNER JOIN SocAccount ON SocTran.SocAccountMainId = SocAccount.SocAccountMainId WHERE(((SocTran.SocTranType)<>'OpBR') AND ((SocTran.SocTranDate)<=#" + Constant.dateRangeto + "#)) GROUP BY SocTran.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal HAVING (((SocTran.SocAccountMainId)="), this.cmbCashbank.SelectedValue), (object) "))")), selectConnection);
    DataTable dataTable2 = new DataTable("SocAccountMain");
    oleDbDataAdapter4.Fill(dataTable2);
    this.DataGridView3.DataSource = (object) dataTable2;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
    selectConnection.Close();
    OleDbDataAdapter oleDbDataAdapter5 = new OleDbDataAdapter();
    OleDbDataAdapter oleDbDataAdapter6 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBOA.Text, "BOA", false) != 0 ? new OleDbDataAdapter(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal FROM SocAccount WHERE (((SocAccount.SocAccountMainId)=", this.cmbCashbank.SelectedValue), (object) "))")), selectConnection) : new OleDbDataAdapter($"SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocAccount.Op_Bal FROM SocAccount WHERE (((SocAccount.SocAccountMainId)={Conversions.ToString(Conversion.Val(this.lblSelectedvalue.Text))}))", selectConnection);
    DataTable dataTable3 = new DataTable("SocAccountMain");
    oleDbDataAdapter6.Fill(dataTable3);
    this.DataGridView4.DataSource = (object) dataTable3;
    this.DataGridView4.ReadOnly = true;
    this.DataGridView4.RowHeadersVisible = false;
    this.DataGridView4.AllowUserToAddRows = false;
    selectConnection.Close();
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    this.DataGridView2.RowCount = 0;
    this.DataGridView2.ColumnCount = 24;
    this.rk = 0;
    this.DataGridView2.Rows.Add();
    this.DataGridView2.Rows[this.rk].Cells[8].Value = (object) "Add";
    checked { ++this.rk; }
    int num1 = checked (this.DataGridView1.RowCount - 1);
    int index1 = 0;
    while (index1 <= num1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectLess(this.DataGridView1.Rows[index1].Cells[14].Value, (object) 0, false))
      {
        this.DataGridView2.Rows.Add();
        int index2 = 0;
        do
        {
          if (index2 == 14)
            this.DataGridView2.Rows[this.rk].Cells[14].Value = Microsoft.VisualBasic.CompilerServices.Operators.NegateObject(this.DataGridView1.Rows[index1].Cells[index2].Value);
          else
            this.DataGridView2.Rows[this.rk].Cells[index2].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index1].Cells[index2].Value);
          checked { ++index2; }
        }
        while (index2 <= 21);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index1].Cells[7].Value.ToString().Trim(), "MRct", false) == 0)
          this.DataGridView2.Rows[this.rk].Cells[23].Value = (object) $"{this.DataGridView1.Rows[index1].Cells[31 /*0x1F*/].Value.ToString().Trim()} {this.DataGridView1.Rows[index1].Cells[38].Value.ToString().Trim()}";
        else
          this.DataGridView2.Rows[this.rk].Cells[23].Value = (object) $"{this.DataGridView1.Rows[index1].Cells[31 /*0x1F*/].Value.ToString().Trim()} {this.DataGridView1.Rows[index1].Cells[38].Value.ToString().Trim()} {this.DataGridView1.Rows[index1].Cells[19].Value.ToString().Trim()}";
        checked { ++this.rk; }
      }
      checked { ++index1; }
    }
    this.DataGridView2.Rows.Add();
    this.DataGridView2.Rows[this.rk].Cells[8].Value = (object) "Less";
    checked { ++this.rk; }
    int num2 = checked (this.DataGridView1.RowCount - 1);
    int index3 = 0;
    while (index3 <= num2)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.DataGridView1.Rows[index3].Cells[14].Value, (object) 0, false))
      {
        this.DataGridView2.Rows.Add();
        int index4 = 0;
        do
        {
          if (index4 == 14)
            this.DataGridView2.Rows[this.rk].Cells[22].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[index4].Value);
          else
            this.DataGridView2.Rows[this.rk].Cells[index4].Value = RuntimeHelpers.GetObjectValue(this.DataGridView1.Rows[index3].Cells[index4].Value);
          checked { ++index4; }
        }
        while (index4 <= 21);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView1.Rows[index3].Cells[7].Value.ToString().Trim(), "MRct", false) == 0)
          this.DataGridView2.Rows[this.rk].Cells[23].Value = (object) $"{this.DataGridView1.Rows[index3].Cells[31 /*0x1F*/].Value.ToString().Trim()} {this.DataGridView1.Rows[index3].Cells[38].Value.ToString().Trim()}";
        else
          this.DataGridView2.Rows[this.rk].Cells[23].Value = (object) $"{this.DataGridView1.Rows[index3].Cells[31 /*0x1F*/].Value.ToString().Trim()} {this.DataGridView1.Rows[index3].Cells[38].Value.ToString().Trim()} {this.DataGridView1.Rows[index3].Cells[19].Value.ToString().Trim()}";
        checked { ++this.rk; }
      }
      checked { ++index3; }
    }
    double Left1 = 0.0;
    double Left2 = 0.0;
    int num3 = checked (this.DataGridView2.RowCount - 1);
    int index5 = 0;
    while (index5 <= num3)
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[14].Value)))
        this.DataGridView2.Rows[index5].Cells[14].Value = (object) 0;
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index5].Cells[22].Value)))
        this.DataGridView2.Rows[index5].Cells[22].Value = (object) 0;
      Left1 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left1, this.DataGridView2.Rows[index5].Cells[14].Value));
      Left2 = Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) Left2, this.DataGridView2.Rows[index5].Cells[22].Value));
      checked { ++index5; }
    }
    this.DataGridView2.Rows.Add();
    this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[14].Value = (object) 0;
    this.DataGridView2.Rows[checked (this.DataGridView2.RowCount - 1)].Cells[22].Value = (object) 0;
    this.DataGridView2.Columns[0].Name = "C1";
    this.DataGridView2.Columns[1].Name = "C2";
    this.DataGridView2.Columns[2].Name = "C3";
    this.DataGridView2.Columns[3].Name = "C4";
    this.DataGridView2.Columns[4].Name = "C5";
    this.DataGridView2.Columns[5].Name = "C6";
    this.DataGridView2.Columns[6].Name = "C7";
    this.DataGridView2.Columns[7].Name = "C8";
    this.DataGridView2.Columns[8].Name = "C9";
    this.DataGridView2.Columns[9].Name = "C10";
    this.DataGridView2.Columns[10].Name = "C11";
    this.DataGridView2.Columns[11].Name = "C12";
    this.DataGridView2.Columns[12].Name = "C13";
    this.DataGridView2.Columns[13].Name = "C14";
    this.DataGridView2.Columns[14].Name = "C15";
    this.DataGridView2.Columns[15].Name = "C16";
    this.DataGridView2.Columns[16 /*0x10*/].Name = "C17";
    this.DataGridView2.Columns[17].Name = "C18";
    this.DataGridView2.Columns[18].Name = "C19";
    this.DataGridView2.Columns[19].Name = "C20";
    this.DataGridView2.Columns[20].Name = "C21";
    this.DataGridView2.Columns[21].Name = "C22";
    this.DataGridView2.Columns[22].Name = "C23";
    this.DataGridView2.Columns[23].Name = "C24";
    DataSet fillGrid;
    return fillGrid;
  }

  private void mtxtDate_GotFocus(object sender, EventArgs e) => this.mtxtDate.Select(0, 0);

  private void mtxtDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.cmbNarration.Focus();
  }

  private void mtxtDate_Validated(object sender, EventArgs e)
  {
    GeneralValidation generalValidation = new GeneralValidation();
    if (!generalValidation.Vdate(this.mtxtDate.Text.ToString()))
      this.mtxtDate.Focus();
    else if (!generalValidation.VdateRange(Conversions.ToDate(this.mtxtDate.Text)))
      this.mtxtDate.Focus();
  }

  private void btnPrint_Click(object sender, EventArgs e) => this.PrintBOAbr();

  private void cmbCashbank_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.mtxtDate.Focus();
  }

  private void cmbNarration_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnPrint.Focus();
  }

  public DataSet PrintBOAbr()
  {
    this.GetFillGrid();
    DataTable dataTable1 = new DataTable();
    DataTable dataTable2 = dataTable1;
    dataTable2.Columns.Add("C1");
    dataTable2.Columns.Add("C2");
    dataTable2.Columns.Add("C3");
    dataTable2.Columns.Add("C4");
    dataTable2.Columns.Add("C5");
    dataTable2.Columns.Add("C6");
    dataTable2.Columns.Add("C7");
    dataTable2.Columns.Add("C8");
    dataTable2.Columns.Add("C9");
    dataTable2.Columns.Add("C10");
    dataTable2.Columns.Add("C11");
    dataTable2.Columns.Add("C12");
    dataTable2.Columns.Add("C13");
    dataTable2.Columns.Add("C14");
    dataTable2.Columns.Add("C15");
    dataTable2.Columns.Add("C16");
    dataTable2.Columns.Add("C17");
    dataTable2.Columns.Add("C18");
    dataTable2.Columns.Add("C19");
    dataTable2.Columns.Add("C20");
    dataTable2.Columns.Add("C21");
    dataTable2.Columns.Add("C22");
    dataTable2.Columns.Add("C23");
    dataTable2.Columns.Add("C24");
    try
    {
      foreach (DataGridViewRow row in (IEnumerable) this.DataGridView2.Rows)
        dataTable1.Rows.Add(RuntimeHelpers.GetObjectValue(row.Cells["C1"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C2"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C3"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C4"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C5"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C6"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C7"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C8"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C9"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C10"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C11"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C12"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C13"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C14"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C15"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C16"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C17"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C18"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C19"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C20"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C21"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C22"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C23"].Value), RuntimeHelpers.GetObjectValue(row.Cells["C24"].Value));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ReportDocument reportDocument = (ReportDocument) new CReportBankReco();
    string val1 = "Bank Reconciliation statement as on :" + this.mtxtDate.Text;
    string val2;
    string text;
    string val3;
    if (checked (this.DataGridView3.RowCount - 1) >= 0)
    {
      val2 = this.DataGridView3.Rows[0].Cells[1].Value.ToString();
      text = this.DataGridView3.Rows[0].Cells[2].Value.ToString();
      val3 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.DataGridView3.Rows[0].Cells[3].Value, this.DataGridView4.Rows[0].Cells[3].Value));
    }
    else
    {
      val2 = " ";
      text = this.cmbCashbank.Text;
      val3 = Conversions.ToString(0);
    }
    reportDocument.SetDataSource(dataTable1);
    reportDocument.SetParameterValue("SocietyName", (object) Constant.societyname);
    reportDocument.SetParameterValue("TitleLine1", (object) val1);
    reportDocument.SetParameterValue("TitleLine2", (object) val2);
    reportDocument.SetParameterValue("TitleLine3", (object) text);
    reportDocument.SetParameterValue("TitleLine4", (object) val3);
    reportDocument.SetParameterValue("FYEAR", (object) $"F.Y. :{Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}");
    reportDocument.SetParameterValue("PNarration", (object) this.cmbNarration.Text.Trim());
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) reportDocument;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblBOA.Text, "BOA", false) == 0)
    {
      try
      {
        DiskFileDestinationOptions destinationOptions = new DiskFileDestinationOptions();
        PdfRtfWordFormatOptions wordFormatOptions = new PdfRtfWordFormatOptions();
        destinationOptions.DiskFileName = $"{Constant.socDataPath.Trim()}\\Booksofaccount\\{this.lblFileName.Text}.pdf";
        ExportOptions exportOptions = reportDocument.ExportOptions;
        exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
        exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
        exportOptions.DestinationOptions = (object) destinationOptions;
        exportOptions.FormatOptions = (object) wordFormatOptions;
        reportDocument.Export();
        reportDocument.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ex.ToString());
        ProjectData.ClearProjectError();
      }
    }
    else
    {
      int num1 = (int) MyProject.Forms.frmCRShow.ShowDialog();
    }
    MyProject.Forms.frmCRShow.Dispose();
    DataSet dataSet;
    return dataSet;
  }
}
