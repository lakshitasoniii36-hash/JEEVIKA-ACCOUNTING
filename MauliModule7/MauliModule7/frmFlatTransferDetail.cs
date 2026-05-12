// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmFlatTransferDetail
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmFlatTransferDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("lblMemberId")]
  private Label _lblMemberId;
  [AccessedThroughProperty("txtMemberName")]
  private TextBox _txtMemberName;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("mtxtDateFrom")]
  private MaskedTextBox _mtxtDateFrom;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("btnCancel")]
  private Button _btnCancel;
  [AccessedThroughProperty("txtFlatNo")]
  private TextBox _txtFlatNo;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("txtMemberRegn")]
  private TextBox _txtMemberRegn;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("lblShareId")]
  private Label _lblShareId;
  [AccessedThroughProperty("txtSregtrfDate")]
  private TextBox _txtSregtrfDate;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;

  [DebuggerNonUserCode]
  static frmFlatTransferDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmFlatTransferDetail()
  {
    this.Load += new EventHandler(this.frmFlatTransferDetail_Load);
    frmFlatTransferDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmFlatTransferDetail.__ENCList)
    {
      if (frmFlatTransferDetail.__ENCList.Count == frmFlatTransferDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmFlatTransferDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmFlatTransferDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmFlatTransferDetail.__ENCList[index1] = frmFlatTransferDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmFlatTransferDetail.__ENCList.RemoveRange(index1, checked (frmFlatTransferDetail.__ENCList.Count - index1));
        frmFlatTransferDetail.__ENCList.Capacity = frmFlatTransferDetail.__ENCList.Count;
      }
      frmFlatTransferDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmFlatTransferDetail));
    this.lblMemberId = new Label();
    this.txtMemberName = new TextBox();
    this.Label2 = new Label();
    this.mtxtDateFrom = new MaskedTextBox();
    this.btnUpdate = new Button();
    this.btnCancel = new Button();
    this.txtFlatNo = new TextBox();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.txtMemberRegn = new TextBox();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.DataGridView1 = new DataGridView();
    this.lblShareId = new Label();
    this.txtSregtrfDate = new TextBox();
    this.grpVisible = new GroupBox();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpVisible.SuspendLayout();
    this.SuspendLayout();
    this.lblMemberId.AutoSize = true;
    this.lblMemberId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblMemberId1 = this.lblMemberId;
    Point point1 = new Point(35, 32 /*0x20*/);
    Point point2 = point1;
    lblMemberId1.Location = point2;
    this.lblMemberId.Name = "lblMemberId";
    Label lblMemberId2 = this.lblMemberId;
    Size size1 = new Size(15, 16 /*0x10*/);
    Size size2 = size1;
    lblMemberId2.Size = size2;
    this.lblMemberId.TabIndex = 0;
    this.lblMemberId.Text = "0";
    this.txtMemberName.Enabled = false;
    this.txtMemberName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemberName1 = this.txtMemberName;
    point1 = new Point(188, 148);
    Point point3 = point1;
    txtMemberName1.Location = point3;
    this.txtMemberName.Name = "txtMemberName";
    TextBox txtMemberName2 = this.txtMemberName;
    size1 = new Size(268, 22);
    Size size3 = size1;
    txtMemberName2.Size = size3;
    this.txtMemberName.TabIndex = 52;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(57, 153);
    Point point4 = point1;
    label2_1.Location = point4;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(98, 16 /*0x10*/);
    Size size4 = size1;
    label2_2.Size = size4;
    this.Label2.TabIndex = 53;
    this.Label2.Text = "Member Name";
    this.mtxtDateFrom.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.mtxtDateFrom.InsertKeyMode = InsertKeyMode.Overwrite;
    MaskedTextBox mtxtDateFrom1 = this.mtxtDateFrom;
    point1 = new Point(188, 220);
    Point point5 = point1;
    mtxtDateFrom1.Location = point5;
    this.mtxtDateFrom.Mask = "00/00/0000";
    this.mtxtDateFrom.Name = "mtxtDateFrom";
    MaskedTextBox mtxtDateFrom2 = this.mtxtDateFrom;
    size1 = new Size(77, 22);
    Size size5 = size1;
    mtxtDateFrom2.Size = size5;
    this.mtxtDateFrom.TabIndex = 58;
    this.mtxtDateFrom.ValidatingType = typeof (DateTime);
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(112 /*0x70*/, 360);
    Point point6 = point1;
    btnUpdate1.Location = point6;
    Button btnUpdate2 = this.btnUpdate;
    Padding padding1 = new Padding(4);
    Padding padding2 = padding1;
    btnUpdate2.Margin = padding2;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate3 = this.btnUpdate;
    size1 = new Size(125, 33);
    Size size6 = size1;
    btnUpdate3.Size = size6;
    this.btnUpdate.TabIndex = 60;
    this.btnUpdate.Text = "Cancel Transfer";
    this.btnUpdate.UseVisualStyleBackColor = true;
    Button btnCancel1 = this.btnCancel;
    point1 = new Point(253, 360);
    Point point7 = point1;
    btnCancel1.Location = point7;
    Button btnCancel2 = this.btnCancel;
    padding1 = new Padding(4);
    Padding padding3 = padding1;
    btnCancel2.Margin = padding3;
    this.btnCancel.Name = "btnCancel";
    Button btnCancel3 = this.btnCancel;
    size1 = new Size(125, 33);
    Size size7 = size1;
    btnCancel3.Size = size7;
    this.btnCancel.TabIndex = 61;
    this.btnCancel.Text = "Cancel";
    this.btnCancel.UseVisualStyleBackColor = true;
    this.txtFlatNo.Enabled = false;
    this.txtFlatNo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtFlatNo1 = this.txtFlatNo;
    point1 = new Point(188, 184);
    Point point8 = point1;
    txtFlatNo1.Location = point8;
    this.txtFlatNo.Name = "txtFlatNo";
    TextBox txtFlatNo2 = this.txtFlatNo;
    size1 = new Size(268, 22);
    Size size8 = size1;
    txtFlatNo2.Size = size8;
    this.txtFlatNo.TabIndex = 62;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(57, 188);
    Point point9 = point1;
    label1_1.Location = point9;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(54, 16 /*0x10*/);
    Size size9 = size1;
    label1_2.Size = size9;
    this.Label1.TabIndex = 63 /*0x3F*/;
    this.Label1.Text = "Flat No.";
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(3, 44);
    Point point10 = point1;
    label3_1.Location = point10;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(72, 16 /*0x10*/);
    Size size10 = size1;
    label3_2.Size = size10;
    this.Label3.TabIndex = 64 /*0x40*/;
    this.Label3.Text = "Member Id";
    this.txtMemberRegn.Enabled = false;
    this.txtMemberRegn.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtMemberRegn1 = this.txtMemberRegn;
    point1 = new Point(188, 112 /*0x70*/);
    Point point11 = point1;
    txtMemberRegn1.Location = point11;
    this.txtMemberRegn.Name = "txtMemberRegn";
    TextBox txtMemberRegn2 = this.txtMemberRegn;
    size1 = new Size(268, 22);
    Size size11 = size1;
    txtMemberRegn2.Size = size11;
    this.txtMemberRegn.TabIndex = 65;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(57, 118);
    Point point12 = point1;
    label4_1.Location = point12;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(118, 16 /*0x10*/);
    Size size12 = size1;
    label4_2.Size = size12;
    this.Label4.TabIndex = 66;
    this.Label4.Text = "Member Regn.No.";
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(56, 223);
    Point point13 = point1;
    label5_1.Location = point13;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(90, 16 /*0x10*/);
    Size size13 = size1;
    label5_2.Size = size13;
    this.Label5.TabIndex = 67;
    this.Label5.Text = "Transfer Date";
    gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
    gridViewCellStyle1.BackColor = SystemColors.Control;
    gridViewCellStyle1.Font = new Font("Arial", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle1.ForeColor = SystemColors.WindowText;
    gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
    this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
    gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
    gridViewCellStyle2.BackColor = SystemColors.Window;
    gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    gridViewCellStyle2.ForeColor = SystemColors.ControlText;
    gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
    gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
    gridViewCellStyle2.WrapMode = DataGridViewTriState.False;
    this.DataGridView1.DefaultCellStyle = gridViewCellStyle2;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(17, 30);
    Point point14 = point1;
    dataGridView1_1.Location = point14;
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
    size1 = new Size(12, 16 /*0x10*/);
    Size size14 = size1;
    dataGridView1_2.Size = size14;
    this.DataGridView1.TabIndex = 68;
    this.lblShareId.AutoSize = true;
    this.lblShareId.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label lblShareId1 = this.lblShareId;
    point1 = new Point(35, 16 /*0x10*/);
    Point point15 = point1;
    lblShareId1.Location = point15;
    this.lblShareId.Name = "lblShareId";
    Label lblShareId2 = this.lblShareId;
    size1 = new Size(15, 16 /*0x10*/);
    Size size15 = size1;
    lblShareId2.Size = size15;
    this.lblShareId.TabIndex = 69;
    this.lblShareId.Text = "0";
    this.txtSregtrfDate.Enabled = false;
    this.txtSregtrfDate.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtSregtrfDate1 = this.txtSregtrfDate;
    point1 = new Point(6, 63 /*0x3F*/);
    Point point16 = point1;
    txtSregtrfDate1.Location = point16;
    this.txtSregtrfDate.Name = "txtSregtrfDate";
    TextBox txtSregtrfDate2 = this.txtSregtrfDate;
    size1 = new Size(70, 22);
    Size size16 = size1;
    txtSregtrfDate2.Size = size16;
    this.txtSregtrfDate.TabIndex = 70;
    this.grpVisible.Controls.Add((Control) this.txtSregtrfDate);
    this.grpVisible.Controls.Add((Control) this.lblShareId);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.lblMemberId);
    this.grpVisible.Controls.Add((Control) this.Label3);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(392, 251);
    Point point17 = point1;
    grpVisible1.Location = point17;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible2 = this.grpVisible;
    size1 = new Size(64 /*0x40*/, 110);
    Size size17 = size1;
    grpVisible2.Size = size17;
    this.grpVisible.TabIndex = 71;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(492, 466);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.txtMemberRegn);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.txtFlatNo);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.btnCancel);
    this.Controls.Add((Control) this.mtxtDateFrom);
    this.Controls.Add((Control) this.txtMemberName);
    this.Controls.Add((Control) this.Label2);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmFlatTransferDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmFlatTransferDetail);
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Label lblMemberId
  {
    [DebuggerNonUserCode] get => this._lblMemberId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblMemberId = value;
    }
  }

  internal virtual TextBox txtMemberName
  {
    [DebuggerNonUserCode] get => this._txtMemberName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMemberName = value;
    }
  }

  internal virtual Label Label2
  {
    [DebuggerNonUserCode] get => this._Label2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
  }

  internal virtual MaskedTextBox mtxtDateFrom
  {
    [DebuggerNonUserCode] get => this._mtxtDateFrom;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._mtxtDateFrom = value;
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

  internal virtual Button btnCancel
  {
    [DebuggerNonUserCode] get => this._btnCancel;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      if (this._btnCancel != null)
        this._btnCancel.Click -= eventHandler;
      this._btnCancel = value;
      if (this._btnCancel == null)
        return;
      this._btnCancel.Click += eventHandler;
    }
  }

  internal virtual TextBox txtFlatNo
  {
    [DebuggerNonUserCode] get => this._txtFlatNo;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtFlatNo = value;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Label Label3
  {
    [DebuggerNonUserCode] get => this._Label3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
  }

  internal virtual TextBox txtMemberRegn
  {
    [DebuggerNonUserCode] get => this._txtMemberRegn;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtMemberRegn = value;
    }
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual Label lblShareId
  {
    [DebuggerNonUserCode] get => this._lblShareId;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblShareId = value;
    }
  }

  internal virtual TextBox txtSregtrfDate
  {
    [DebuggerNonUserCode] get => this._txtSregtrfDate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtSregtrfDate = value;
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

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocStatMaster}");
    if (Operators.CompareString(this.btnUpdate.Text, "Transfer", false) == 0)
    {
      if (!Information.IsDate((object) this.mtxtDateFrom.Text) | Operators.CompareString(this.mtxtDateFrom.Text, "  /  /", false) == 0)
      {
        int num = (int) Interaction.MsgBox((object) "Invalid Date");
        this.mtxtDateFrom.Focus();
        return;
      }
      string cmdText1 = $"update Member set DOT ='{this.mtxtDateFrom.Text}' ,IsTransfer ='Y'  where MemID ={Conversions.ToString(Conversion.Val(this.lblMemberId.Text.Trim()))}";
      connection.Open();
      new OleDbCommand(cmdText1, connection).ExecuteNonQuery();
      connection.Close();
      if (Operators.CompareString(this.txtSregtrfDate.Text, "", false) == 0)
      {
        string cmdText2 = $"update SReg set sdot ='{this.mtxtDateFrom.Text.Substring(0, 10)}' where MemId ={Conversions.ToString(Conversion.Val(this.lblMemberId.Text.Trim()))}";
        connection.Open();
        new OleDbCommand(cmdText2, connection).ExecuteNonQuery();
        connection.Close();
      }
      this.Close();
    }
    if (Operators.CompareString(this.btnUpdate.Text, "Cancel Transfer", false) == 0)
    {
      string cmdText = $"update Member set DOT =NULL ,IsTransfer ='N'  where MemID ={Conversions.ToString(Conversion.Val(this.lblMemberId.Text.Trim()))}";
      connection.Open();
      new OleDbCommand(cmdText, connection).ExecuteNonQuery();
      connection.Close();
      this.Close();
    }
  }

  private void frmFlatTransferDetail_Load(object sender, EventArgs e)
  {
    this.grpVisible.Visible = false;
  }
}
