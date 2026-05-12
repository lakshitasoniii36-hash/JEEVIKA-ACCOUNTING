// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmSocietyDetail
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using ADOX;
using MauliModule7.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmSocietyDetail : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnSave")]
  private Button _btnSave;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("txtSocietyCode")]
  private TextBox _txtSocietyCode;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("txtSocietyName")]
  private TextBox _txtSocietyName;
  [AccessedThroughProperty("mtxtFYYearStart")]
  private MaskedTextBox _mtxtFYYearStart;
  [AccessedThroughProperty("MtxtFYYearEnd")]
  private MaskedTextBox _MtxtFYYearEnd;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("chkRctBifucation")]
  private CheckBox _chkRctBifucation;
  [AccessedThroughProperty("chkGSTApplicable")]
  private CheckBox _chkGSTApplicable;

  [DebuggerNonUserCode]
  static frmSocietyDetail()
  {
  }

  [DebuggerNonUserCode]
  public frmSocietyDetail()
  {
    this.Load += new EventHandler(this.frmSocietyDetail_Load);
    frmSocietyDetail.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmSocietyDetail.__ENCList)
    {
      if (frmSocietyDetail.__ENCList.Count == frmSocietyDetail.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmSocietyDetail.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmSocietyDetail.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmSocietyDetail.__ENCList[index1] = frmSocietyDetail.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmSocietyDetail.__ENCList.RemoveRange(index1, checked (frmSocietyDetail.__ENCList.Count - index1));
        frmSocietyDetail.__ENCList.Capacity = frmSocietyDetail.__ENCList.Count;
      }
      frmSocietyDetail.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSocietyDetail));
    this.btnSave = new Button();
    this.btnExit = new Button();
    this.txtSocietyCode = new TextBox();
    this.Label1 = new Label();
    this.txtSocietyName = new TextBox();
    this.mtxtFYYearStart = new MaskedTextBox();
    this.MtxtFYYearEnd = new MaskedTextBox();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.chkRctBifucation = new CheckBox();
    this.chkGSTApplicable = new CheckBox();
    this.SuspendLayout();
    this.btnSave.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnSave1 = this.btnSave;
    Point point1 = new Point(175, 472);
    Point point2 = point1;
    btnSave1.Location = point2;
    this.btnSave.Name = "btnSave";
    Button btnSave2 = this.btnSave;
    Size size1 = new Size(99, 33);
    Size size2 = size1;
    btnSave2.Size = size2;
    this.btnSave.TabIndex = 4;
    this.btnSave.Text = "&Save";
    this.btnSave.UseVisualStyleBackColor = true;
    this.btnExit.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button btnExit1 = this.btnExit;
    point1 = new Point(318, 472);
    Point point3 = point1;
    btnExit1.Location = point3;
    this.btnExit.Name = "btnExit";
    Button btnExit2 = this.btnExit;
    size1 = new Size(99, 33);
    Size size3 = size1;
    btnExit2.Size = size3;
    this.btnExit.TabIndex = 5;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    this.txtSocietyCode.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtSocietyCode1 = this.txtSocietyCode;
    point1 = new Point(175, 170);
    Point point4 = point1;
    txtSocietyCode1.Location = point4;
    this.txtSocietyCode.MaxLength = 3;
    this.txtSocietyCode.Name = "txtSocietyCode";
    TextBox txtSocietyCode2 = this.txtSocietyCode;
    size1 = new Size(69, 22);
    Size size4 = size1;
    txtSocietyCode2.Size = size4;
    this.txtSocietyCode.TabIndex = 0;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label1_1 = this.Label1;
    point1 = new Point(74, 177);
    Point point5 = point1;
    label1_1.Location = point5;
    this.Label1.Name = "Label1";
    Label label1_2 = this.Label1;
    size1 = new Size(41, 16 /*0x10*/);
    Size size5 = size1;
    label1_2.Size = size5;
    this.Label1.TabIndex = 5;
    this.Label1.Text = "Code";
    this.txtSocietyName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtSocietyName1 = this.txtSocietyName;
    point1 = new Point(175, 222);
    Point point6 = point1;
    txtSocietyName1.Location = point6;
    this.txtSocietyName.MaxLength = 150;
    this.txtSocietyName.Name = "txtSocietyName";
    TextBox txtSocietyName2 = this.txtSocietyName;
    size1 = new Size(333, 22);
    Size size6 = size1;
    txtSocietyName2.Size = size6;
    this.txtSocietyName.TabIndex = 1;
    this.mtxtFYYearStart.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    MaskedTextBox mtxtFyYearStart1 = this.mtxtFYYearStart;
    point1 = new Point(228, 276);
    Point point7 = point1;
    mtxtFyYearStart1.Location = point7;
    this.mtxtFYYearStart.Mask = "00/00/0000";
    this.mtxtFYYearStart.Name = "mtxtFYYearStart";
    MaskedTextBox mtxtFyYearStart2 = this.mtxtFYYearStart;
    size1 = new Size(85, 22);
    Size size7 = size1;
    mtxtFyYearStart2.Size = size7;
    this.mtxtFYYearStart.TabIndex = 2;
    this.MtxtFYYearEnd.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    MaskedTextBox mtxtFyYearEnd1 = this.MtxtFYYearEnd;
    point1 = new Point(420, 276);
    Point point8 = point1;
    mtxtFyYearEnd1.Location = point8;
    this.MtxtFYYearEnd.Mask = "00/00/0000";
    this.MtxtFYYearEnd.Name = "MtxtFYYearEnd";
    MaskedTextBox mtxtFyYearEnd2 = this.MtxtFYYearEnd;
    size1 = new Size(88, 22);
    Size size8 = size1;
    mtxtFyYearEnd2.Size = size8;
    this.MtxtFYYearEnd.TabIndex = 3;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(74, 229);
    Point point9 = point1;
    label2_1.Location = point9;
    this.Label2.Name = "Label2";
    Label label2_2 = this.Label2;
    size1 = new Size(45, 16 /*0x10*/);
    Size size9 = size1;
    label2_2.Size = size9;
    this.Label2.TabIndex = 10;
    this.Label2.Text = "Name";
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(169, 282);
    Point point10 = point1;
    label3_1.Location = point10;
    this.Label3.Name = "Label3";
    Label label3_2 = this.Label3;
    size1 = new Size(39, 16 /*0x10*/);
    Size size10 = size1;
    label3_2.Size = size10;
    this.Label3.TabIndex = 11;
    this.Label3.Text = "From";
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label4_1 = this.Label4;
    point1 = new Point(376, 279);
    Point point11 = point1;
    label4_1.Location = point11;
    this.Label4.Name = "Label4";
    Label label4_2 = this.Label4;
    size1 = new Size(25, 16 /*0x10*/);
    Size size11 = size1;
    label4_2.Size = size11;
    this.Label4.TabIndex = 12;
    this.Label4.Text = "To";
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(74, 282);
    Point point12 = point1;
    label5_1.Location = point12;
    this.Label5.Name = "Label5";
    Label label5_2 = this.Label5;
    size1 = new Size(94, 16 /*0x10*/);
    Size size12 = size1;
    label5_2.Size = size12;
    this.Label5.TabIndex = 13;
    this.Label5.Text = "Financial Year";
    this.chkRctBifucation.AutoSize = true;
    this.chkRctBifucation.CheckAlign = ContentAlignment.MiddleRight;
    this.chkRctBifucation.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    CheckBox chkRctBifucation1 = this.chkRctBifucation;
    point1 = new Point(356, 338);
    Point point13 = point1;
    chkRctBifucation1.Location = point13;
    this.chkRctBifucation.Name = "chkRctBifucation";
    CheckBox chkRctBifucation2 = this.chkRctBifucation;
    size1 = new Size(139, 20);
    Size size13 = size1;
    chkRctBifucation2.Size = size13;
    this.chkRctBifucation.TabIndex = 16 /*0x10*/;
    this.chkRctBifucation.Text = "Receipt Bifurcation";
    this.chkRctBifucation.UseVisualStyleBackColor = true;
    this.chkGSTApplicable.AutoSize = true;
    this.chkGSTApplicable.CheckAlign = ContentAlignment.MiddleRight;
    this.chkGSTApplicable.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    CheckBox chkGstApplicable1 = this.chkGSTApplicable;
    point1 = new Point(77, 338);
    Point point14 = point1;
    chkGstApplicable1.Location = point14;
    this.chkGSTApplicable.Name = "chkGSTApplicable";
    CheckBox chkGstApplicable2 = this.chkGSTApplicable;
    size1 = new Size(123, 20);
    Size size14 = size1;
    chkGstApplicable2.Size = size14;
    this.chkGSTApplicable.TabIndex = 17;
    this.chkGSTApplicable.Text = "GST Applicable";
    this.chkGSTApplicable.UseVisualStyleBackColor = true;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(592, 566);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.chkGSTApplicable);
    this.Controls.Add((Control) this.chkRctBifucation);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.MtxtFYYearEnd);
    this.Controls.Add((Control) this.mtxtFYYearStart);
    this.Controls.Add((Control) this.txtSocietyName);
    this.Controls.Add((Control) this.txtSocietyCode);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnSave);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmSocietyDetail);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Society Master";
    this.ResumeLayout(false);
    this.PerformLayout();
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

  internal virtual TextBox txtSocietyCode
  {
    [DebuggerNonUserCode] get => this._txtSocietyCode;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSocietyCode_KeyDown);
      if (this._txtSocietyCode != null)
        this._txtSocietyCode.KeyDown -= keyEventHandler;
      this._txtSocietyCode = value;
      if (this._txtSocietyCode == null)
        return;
      this._txtSocietyCode.KeyDown += keyEventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual TextBox txtSocietyName
  {
    [DebuggerNonUserCode] get => this._txtSocietyName;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSocietyName_KeyDown);
      if (this._txtSocietyName != null)
        this._txtSocietyName.KeyDown -= keyEventHandler;
      this._txtSocietyName = value;
      if (this._txtSocietyName == null)
        return;
      this._txtSocietyName.KeyDown += keyEventHandler;
    }
  }

  internal virtual MaskedTextBox mtxtFYYearStart
  {
    [DebuggerNonUserCode] get => this._mtxtFYYearStart;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.mtxtFYYearStart_KeyDown);
      if (this._mtxtFYYearStart != null)
        this._mtxtFYYearStart.KeyDown -= keyEventHandler;
      this._mtxtFYYearStart = value;
      if (this._mtxtFYYearStart == null)
        return;
      this._mtxtFYYearStart.KeyDown += keyEventHandler;
    }
  }

  internal virtual MaskedTextBox MtxtFYYearEnd
  {
    [DebuggerNonUserCode] get => this._MtxtFYYearEnd;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.MtxtFYYearEnd_KeyDown);
      if (this._MtxtFYYearEnd != null)
        this._MtxtFYYearEnd.KeyDown -= keyEventHandler;
      this._MtxtFYYearEnd = value;
      if (this._MtxtFYYearEnd == null)
        return;
      this._MtxtFYYearEnd.KeyDown += keyEventHandler;
    }
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

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
  }

  internal virtual CheckBox chkRctBifucation
  {
    [DebuggerNonUserCode] get => this._chkRctBifucation;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkRctBifucation = value;
    }
  }

  internal virtual CheckBox chkGSTApplicable
  {
    [DebuggerNonUserCode] get => this._chkGSTApplicable;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._chkGSTApplicable = value;
    }
  }

  [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
  private void btnSave_Click(object sender, EventArgs e)
  {
    string str1 = "N";
    if (Operators.CompareString(this.txtSocietyCode.Text.Trim(), "", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Code cannot Balnk");
      this.txtSocietyCode.Focus();
    }
    else if (Operators.CompareString(this.txtSocietyName.Text.Trim(), "", false) == 0)
    {
      int num = (int) Interaction.MsgBox((object) "Code cannot Balnk");
      this.txtSocietyName.Focus();
    }
    else if (!Information.IsDate((object) this.mtxtFYYearStart.Text.Trim()))
    {
      int num = (int) Interaction.MsgBox((object) "Not Valid Date");
      this.mtxtFYYearStart.Focus();
    }
    else if (!Information.IsDate((object) this.MtxtFYYearEnd.Text.Trim()))
    {
      int num = (int) Interaction.MsgBox((object) "Not Valid Date");
      this.MtxtFYYearEnd.Focus();
    }
    else
    {
      string str2 = $"\\{Constant.Clientcode.Trim()}_{this.txtSocietyCode.Text.Trim()}_{Conversion.Str((object) DateAndTime.Year(Conversions.ToDate(this.mtxtFYYearStart.Text))).Trim()}{Conversion.Str((object) DateAndTime.Year(Conversions.ToDate(this.MtxtFYYearEnd.Text))).Trim()}.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}";
      string str3 = $"\\{Constant.Clientcode.Trim()}_{this.txtSocietyCode.Text.Trim()}_{Conversion.Str((object) DateAndTime.Year(Conversions.ToDate(this.mtxtFYYearStart.Text))).Trim()}{Conversion.Str((object) DateAndTime.Year(Conversions.ToDate(this.MtxtFYYearEnd.Text))).Trim()}.accdb";
      this.txtSocietyName.Text = this.txtSocietyName.Text.ToString().Replace("'", "''");
      if (this.chkRctBifucation.Checked)
        str1 = "Y";
      if (Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
      {
        if (Operators.CompareString(FileSystem.Dir(Constant.socDataPath + str3), "", false) == 0)
        {
          this.mtxtFYYearStart.Text = this.Chdate(this.mtxtFYYearStart.Text);
          this.MtxtFYYearEnd.Text = this.Chdate(this.MtxtFYYearEnd.Text);
          OleDbConnection connection1 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
          OleDbCommand oleDbCommand = new OleDbCommand($"Insert Into SocietyInfo (SocietyCode, SocietyName, FYYearStart, FYYearEnd, IsOnline, OnlineSrNo) values ('{this.txtSocietyCode.Text.Trim()}','{this.txtSocietyName.Text.Trim()}','{this.mtxtFYYearStart.Text.ToString()}','{this.MtxtFYYearEnd.Text.ToString()}','{str1}','00000_000_00000000')", connection1);
          connection1.Open();
          oleDbCommand.ExecuteNonQuery();
          connection1.Close();
          Catalog catalog = (Catalog) new CatalogClass();
          try
          {
            catalog.Create($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{str2}");
          }
          catch (COMException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            int num = (int) MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            ProjectData.ClearProjectError();
          }
          finally
          {
          }
          OleDbConnection connection2 = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{str2}");
          connection2.Open();
          new OleDbCommand("CREATE TABLE SocGroup (SocGroupId AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,GrpName varchar(80),GrpMainId Integer,GrpPrimaryId Long,GrpType Integer,GrpPrimaryName varchar(80));", connection2).ExecuteNonQuery();
          new OleDbCommand("CREATE TABLE SocAccount (SocAccId AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocAccountMainId Long,AccCode varchar(10),AccName varchar(80),AccName1 varchar(80),AccName2 varchar(80),Op_Bal Double,Tr_Db Double,Tr_Cr Double,Cl_Bal Double,Pr_Bal Double,AccAdd varchar(255),AccPAN varchar(20),AccTAN varchar(20),AccSTAX varchar(25),AccVAT varchar(25),AccContact varchar(80),AccEmail varchar(80));", connection2).ExecuteNonQuery();
          new OleDbCommand("CREATE TABLE SocMember (SocMemId AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocAccountMainId Long,MemCode varchar(25),Bldg varchar(20),Wing varchar(20),FlatType varchar(15),FlatNo varchar(10),Floor varchar(20),Sqft Double,MemName varchar(80),MemName1 varchar(80),MemName2 varchar(80),MemName3 varchar(80),NocDetail varchar(80),ParkDetail varchar(80),LaonDetail varchar(80),Poss_Date varchar(25),MemEmail varchar(40),MemMobile varchar(25),FamilyDetail varchar(255),ServantDetail varchar(255),BankName varchar(80),DefaPart varchar(80),Op_Prin Double,Op_Int Double,DrTR_Prin Double,DrTR_Int Double,CrTR_Prin Double,CrTR_Int Double,Cl_Prin Double,Cl_Int  Double,IsTransfer varchar(1),MemAddress varchar(255));", connection2).ExecuteNonQuery();
          new OleDbCommand("CREATE TABLE SocBillSetting (SocBSAccId AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocAccountMainId Long,AccIndex Integer,AccShortName varchar(40));", connection2).ExecuteNonQuery();
          new OleDbCommand("CREATE TABLE SocDesc (Id AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,Particular varchar(80),ParType varchar(10));", connection2).ExecuteNonQuery();
          new OleDbCommand("CREATE TABLE SocInfo (SId AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocName varchar(150),SocRegnno varchar(80),DefaCash Long,Defaint Long,DefaDebtor Long,DefaCreditor Long,IntType varchar(10),IntRate Double,IntPriority varchar(20),IntRounded Integer,Rec_Signature varchar(80),Voucher_Signature varchar(80),Remarks varchar(255),Remarks1 varchar(255),Zero varchar(1),AuthoLed varchar(80),AuthoAmt Double,SocAddress varchar(255),PAN varchar(50),TAN varchar(50),STAX varchar(50),PTAX varchar(50),SocEmail varchar(80),SocTelephone varchar(80),IntMethod varchar(20),SocMessage varchar(80),Areatype varchar(10),Remarks2 varchar(255),Remarks3 varchar(255),Remarks4 varchar(255),Remarks5 varchar(255),Remarks6 varchar(255),Remarks7 varchar(3));", connection2).ExecuteNonQuery();
          new OleDbCommand("CREATE TABLE SocMainGroup (GrpMainId AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,MainGroupName varchar(25));", connection2).ExecuteNonQuery();
          new OleDbCommand("CREATE TABLE SocBillMaster (SocBillMasteId AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocMemId Long,Amt01 Double,Amt02 Double,Amt03 Double,Amt04 Double,Amt05 Double,Amt06 Double,Amt07 Double,Amt08 Double,Amt09 Double,Amt10 Double,Amt11 Double,Amt12 Double,Amt13 Double,Amt14 Double,Amt15 Double,Amt16 Double,Amt17 Double,Amt18 Double,Amt19 Double,Amt20 Double,Amt21 Double,AmtInt Double,AmtSTax Double,AmtTotal Double);", connection2).ExecuteNonQuery();
          new OleDbCommand("CREATE TABLE SocAccountMain (SocAccountMainId AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocAccountType Integer,SocSubGroupId Long,SocGroupId Long,GrpMainId Long);", connection2).ExecuteNonQuery();
          new OleDbCommand("CREATE TABLE SocTran (SocTranId AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,SocTranClass Integer,SocAccountMainId Long,SocSubGroupId Long,SocGroupId Long,GrpMainId Long,SocTranType varchar(10),SocTranNo Long,SocTranDate TIMESTAMP,AccName varchar(80),AccName1 varchar(80),SocTranInt Double,SocTranPrin Double,SocTranAmount Double,SocTranAmountR Double,SocTranbcr TIMESTAMP,ChqNo varchar(25),ChqDt varchar(20),BankName varchar(80),PartyName varchar(80),AccPart varchar(80),AccPart1 varchar(80),AccPart2 varchar(80),MainAccount varchar(1),DueDate varchar(25),AccIndex Integer,InstName varchar(20),SubTranType varchar(4),SubTranNo Long);", connection2).ExecuteNonQuery();
          new OleDbCommand("CREATE TABLE SocCashBook (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,ledgerIndex Long,DateIndex TIMESTAMP,TranTypeIndex Long,TranNoIndex Long,LineNo Long,NarrationYN varchar(10),Tran_Date TIMESTAMP,Tran_Type varchar(10),Tran_No Long,Tran_AccCode varchar(10),Tran_Particular varchar(255),Tran_ChqNo varchar(25),Amount_Debit Double,Amount_Credit Double,Tran_Narration1 varchar(255),Tran_Narration2 varchar(255),Tran_Narration3 varchar(255),SubTranType varchar(4),SubTranNo Long)", connection2).ExecuteNonQuery();
          new OleDbCommand("CREATE TABLE SocMemberLedger (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,ledgerIndex Long,DateIndex TIMESTAMP,TranTypeIndex Long,TranNoIndex Long,Tran_Date TIMESTAMP,Tran_Type varchar(10),Tran_No Long,Tran_AccCode varchar(10),Tran_Particular varchar(255),Amount_Principle Double,Amount_Interest Double,Amount_Debit Double,Amount_Credit Double,Tran_ChqNo varchar(25),Tran_ChqDate varchar(20),Tran_BankName varchar(80),Tran_DueDate varchar(25),Tran_PartyName varchar(255),Tran_Narration1 varchar(255),Tran_Narration2 varchar(255),Tran_Narration3 varchar(255),Tran_Amt1 Double,Tran_Amt2 Double,Tran_Amt3 Double,Tran_Amt4 Double,Tran_Amt5 Double,Tran_Amt6 Double,Tran_Amt7 Double,Tran_Amt8 Double,Tran_Amt9 Double,Tran_Amt10 Double,Tran_Amt11 Double,Tran_Amt12 Double,Tran_Amt13 Double,Tran_Amt14 Double,Tran_Amt15 Double,Tran_Amt16 Double,Tran_Amt17 Double,Tran_Amt18 Double,Tran_Amt19 Double,Tran_Amt20 Double,Tran_Amt21 Double)", connection2).ExecuteNonQuery();
          new OleDbCommand("CREATE TABLE SocEmail (Id AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,EmailAdd varchar(80),EmailPassword varchar(25));", connection2).ExecuteNonQuery();
          new OleDbCommand("CREATE TABLE SocTranType (ID AUTOINCREMENT NOT NULL PRIMARY KEY NONCLUSTERED,Transaction_Name varchar(25),Main_Abr varchar(4),Sub_Abr varchar(4),Type_Type varchar(1))", connection2).ExecuteNonQuery();
          string[,] strArray = new string[31 /*0x1F*/, 4];
          strArray[0, 0] = "Rent & Taxes";
          strArray[1, 0] = "Maintenance & Service Charges";
          strArray[2, 0] = "Interest Received From";
          strArray[3, 0] = "Other Sources";
          strArray[4, 0] = "Rent, Rates & Taxes";
          strArray[5, 0] = "Establishment Expenses";
          strArray[6, 0] = "Maintenance";
          strArray[7, 0] = "Others";
          strArray[8, 0] = "Cash & Bank Balance";
          strArray[9, 0] = "Investments";
          strArray[10, 0] = "Sundry Debtors";
          strArray[11, 0] = "Dues from Members";
          strArray[12, 0] = "Fixed Assets";
          strArray[13, 0] = "Current Assets";
          strArray[14, 0] = "Advance & Deposit";
          strArray[15, 0] = "Cost of Construction";
          strArray[16 /*0x10*/, 0] = "Cost of Land";
          strArray[17, 0] = "Misc.Assets";
          strArray[18, 0] = "Accrued Interest";
          strArray[19, 0] = "Income & Expenditure";
          strArray[20, 0] = "Issued, Sub. & Paid Up Captial";
          strArray[21, 0] = "Reserve Fund";
          strArray[22, 0] = "Sinking Fund";
          strArray[23, 0] = "Building Repair Fund";
          strArray[24, 0] = "Ammenity Fund";
          strArray[25, 0] = "Common Welfare Fund";
          strArray[26, 0] = "Cost of Construction";
          strArray[27, 0] = "Current Liabilities & Provisions";
          strArray[28, 0] = "Advances & Deposits";
          strArray[29, 0] = "Sundry Creditors";
          strArray[30, 0] = "Income & Expenditure";
          strArray[0, 1] = "3";
          strArray[1, 1] = "3";
          strArray[2, 1] = "3";
          strArray[3, 1] = "3";
          strArray[4, 1] = "4";
          strArray[5, 1] = "4";
          strArray[6, 1] = "4";
          strArray[7, 1] = "4";
          strArray[8, 1] = "1";
          strArray[9, 1] = "1";
          strArray[10, 1] = "1";
          strArray[11, 1] = "1";
          strArray[12, 1] = "1";
          strArray[13, 1] = "1";
          strArray[14, 1] = "1";
          strArray[15, 1] = "1";
          strArray[15, 1] = "1";
          strArray[16 /*0x10*/, 1] = "1";
          strArray[17, 1] = "1";
          strArray[18, 1] = "1";
          strArray[19, 1] = "1";
          strArray[20, 1] = "2";
          strArray[21, 1] = "2";
          strArray[22, 1] = "2";
          strArray[23, 1] = "2";
          strArray[24, 1] = "2";
          strArray[25, 1] = "2";
          strArray[26, 1] = "2";
          strArray[27, 1] = "2";
          strArray[28, 1] = "2";
          strArray[29, 1] = "2";
          strArray[30, 1] = "2";
          int index = 0;
          do
          {
            new OleDbCommand($"Insert Into SocGroup (GrpName, GrpMainId, GrpPrimaryId, GrpType, GrpPrimaryName) values ('{strArray[index, 0].Trim()}','{Conversions.ToString(Conversion.Val(strArray[index, 1].Trim()))}','{Conversions.ToString(Conversion.Val((object) checked (index + 1)))}','1','{strArray[index, 0].Trim()}')", connection2).ExecuteNonQuery();
            checked { ++index; }
          }
          while (index <= 30);
          new OleDbCommand("Insert Into SocAccountMain (SocAccountType, SocSubGroupId, SocGroupId, GrpMainId) values ('1','3','3','3')", connection2).ExecuteNonQuery();
          new OleDbCommand("Insert Into SocAccount (SocAccountMainId, AccCode, AccName, AccName1, AccName2, Op_Bal, Tr_Db, Tr_Cr, Cl_Bal, Pr_Bal) values ('1','022','Interest From Member','Interest From Member','Interest From Member',0,0,0,0,0)", connection2).ExecuteNonQuery();
          new OleDbCommand("Insert Into SocInfo (DefaCash, Defaint, DefaDebtor, DefaCreditor, Zero, IntType, IntPriority, IntRate, IntRounded, AuthoAmt,IntMethod,Remarks7 ) values (9,1,12,30,'Y','Simple','Interest First', 0, 0, 0,'Monthly','Yes')", connection2).ExecuteNonQuery();
          new OleDbCommand("Insert Into SocMainGroup (MainGroupName) values ('Assets')", connection2).ExecuteNonQuery();
          new OleDbCommand("Insert Into SocMainGroup (MainGroupName) values ('Liabilities')", connection2).ExecuteNonQuery();
          new OleDbCommand("Insert Into SocMainGroup (MainGroupName) values ('Income')", connection2).ExecuteNonQuery();
          new OleDbCommand("Insert Into SocMainGroup (MainGroupName) values ('Expenditure')", connection2).ExecuteNonQuery();
          new OleDbCommand("Insert Into SocEmail (EmailAdd,EmailPassword) values ('samhelpline07@gmail.com','helpline07')", connection2).ExecuteNonQuery();
          new OleDbCommand("Insert Into SocTranType (Transaction_Name, Main_Abr, Sub_Abr, Type_Type) values ('Payment','Pymt','Pymt','M')", connection2).ExecuteNonQuery();
          new OleDbCommand("Insert Into SocTranType (Transaction_Name, Main_Abr, Sub_Abr, Type_Type) values ('Receipt','Rcpt','Rcpt','M')", connection2).ExecuteNonQuery();
          new OleDbCommand("Insert Into SocTranType (Transaction_Name, Main_Abr, Sub_Abr, Type_Type) values ('Contra','Ctra','Ctra','M')", connection2).ExecuteNonQuery();
        }
        else
        {
          int num1 = (int) Interaction.MsgBox((object) "Already Exist");
        }
      }
      if (Operators.CompareString(this.btnSave.Text, "&Update", false) == 0)
      {
        OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}\\Society.accdb;Jet OLEDB:Database Password={Constant.CnPassdb.Trim()}");
        OleDbCommand oleDbCommand1 = new OleDbCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) ("update SocietyInfo set SocietyName = '" + this.txtSocietyName.Text.Trim() + "', IsOnline = '" + str1 + "' where Id ="), MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[0].Value), (object) "")), connection);
        connection.Open();
        oleDbCommand1.ExecuteNonQuery();
        connection.Close();
        if (this.chkGSTApplicable.Checked)
        {
          OleDbCommand oleDbCommand2 = new OleDbCommand(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) ("update SocietyInfo set OnlineSrNo = '" + MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[8].Value.ToString().Trim().Substring(0, 15) + "777' where Id ="), MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[0].Value), (object) "")), connection);
          connection.Open();
          oleDbCommand2.ExecuteNonQuery();
          connection.Close();
        }
      }
      this.Close();
    }
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void frmSocietyDetail_Load(object sender, EventArgs e)
  {
    if (Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
    {
      this.chkGSTApplicable.Checked = false;
      this.chkGSTApplicable.Visible = false;
    }
    if (Operators.CompareString(Constant.SoftType.ToString().Trim(), "4", false) == 0)
      this.chkRctBifucation.Visible = true;
    else
      this.chkRctBifucation.Visible = false;
    if (Operators.CompareString(this.btnSave.Text, "&Update", false) != 0)
      return;
    this.txtSocietyCode.Text = MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[1].Value.ToString();
    this.txtSocietyName.Text = MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[2].Value.ToString();
    this.mtxtFYYearStart.Text = MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[3].Value.ToString();
    this.MtxtFYYearEnd.Text = MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[4].Value.ToString();
    if (Operators.CompareString(MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[7].Value.ToString(), "Y", false) == 0)
      this.chkRctBifucation.Checked = true;
    this.txtSocietyCode.Enabled = false;
    this.mtxtFYYearStart.Enabled = false;
    this.MtxtFYYearEnd.Enabled = false;
    if (Operators.CompareString(MyProject.Forms.frmSocSelection.DataGridView1.CurrentRow.Cells[8].Value.ToString().Trim().Substring(15, 3), "777", false) == 0)
      this.chkGSTApplicable.Visible = false;
  }

  public string Chdate(string vd)
  {
    if (Operators.CompareString(Constant.defaDate, "12/13/2012 12:00:00 AM", false) == 0)
      vd = $"{vd.Substring(3, 2)}/{vd.Substring(0, 2)}/{vd.Substring(6, 4)}";
    return vd;
  }

  public string Chdatesql(string vd)
  {
    if (Operators.CompareString(Constant.defaDate, "12/13/2012 12:00:00 AM", false) != 0)
      vd = $"{vd.Substring(3, 2)}/{vd.Substring(0, 2)}/{vd.Substring(6, 4)}";
    return vd;
  }

  private void txtSocietyCode_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != System.Windows.Forms.Keys.Return)
      return;
    this.txtSocietyName.Focus();
  }

  private void txtSocietyName_KeyDown(object sender, KeyEventArgs e)
  {
    if (Operators.CompareString(this.btnSave.Text, "&Save", false) == 0)
    {
      if (e.KeyCode != System.Windows.Forms.Keys.Return)
        return;
      this.mtxtFYYearStart.Focus();
    }
    else if (e.KeyCode == System.Windows.Forms.Keys.Return)
      this.btnSave.Focus();
  }

  private void mtxtFYYearStart_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != System.Windows.Forms.Keys.Return)
      return;
    this.MtxtFYYearEnd.Focus();
  }

  private void MtxtFYYearEnd_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != System.Windows.Forms.Keys.Return)
      return;
    this.btnSave.Focus();
  }
}
