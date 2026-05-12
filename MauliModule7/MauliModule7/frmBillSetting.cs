// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmBillSetting
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
public class frmBillSetting : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("btnSelect1")]
  private Button _btnSelect1;
  [AccessedThroughProperty("Label1")]
  private Label _Label1;
  [AccessedThroughProperty("Label18")]
  private Label _Label18;
  [AccessedThroughProperty("Label30")]
  private Label _Label30;
  [AccessedThroughProperty("Label14")]
  private Label _Label14;
  [AccessedThroughProperty("Label38")]
  private Label _Label38;
  [AccessedThroughProperty("Label12")]
  private Label _Label12;
  [AccessedThroughProperty("btnSelect14")]
  private Button _btnSelect14;
  [AccessedThroughProperty("btnSelect4")]
  private Button _btnSelect4;
  [AccessedThroughProperty("Label20")]
  private Label _Label20;
  [AccessedThroughProperty("btnSelect3")]
  private Button _btnSelect3;
  [AccessedThroughProperty("Label16")]
  private Label _Label16;
  [AccessedThroughProperty("btnSelect9")]
  private Button _btnSelect9;
  [AccessedThroughProperty("Label40")]
  private Label _Label40;
  [AccessedThroughProperty("btnSelect21")]
  private Button _btnSelect21;
  [AccessedThroughProperty("btnSelect20")]
  private Button _btnSelect20;
  [AccessedThroughProperty("btnSelect16")]
  private Button _btnSelect16;
  [AccessedThroughProperty("Label34")]
  private Label _Label34;
  [AccessedThroughProperty("btnSelect7")]
  private Button _btnSelect7;
  [AccessedThroughProperty("btnSelect15")]
  private Button _btnSelect15;
  [AccessedThroughProperty("Label42")]
  private Label _Label42;
  [AccessedThroughProperty("btnSelect2")]
  private Button _btnSelect2;
  [AccessedThroughProperty("Label32")]
  private Label _Label32;
  [AccessedThroughProperty("Label4")]
  private Label _Label4;
  [AccessedThroughProperty("Label10")]
  private Label _Label10;
  [AccessedThroughProperty("btnSelect8")]
  private Button _btnSelect8;
  [AccessedThroughProperty("btnSelect13")]
  private Button _btnSelect13;
  [AccessedThroughProperty("Label24")]
  private Label _Label24;
  [AccessedThroughProperty("btnSelect10")]
  private Button _btnSelect10;
  [AccessedThroughProperty("btnSelect19")]
  private Button _btnSelect19;
  [AccessedThroughProperty("Label36")]
  private Label _Label36;
  [AccessedThroughProperty("Label8")]
  private Label _Label8;
  [AccessedThroughProperty("Label22")]
  private Label _Label22;
  [AccessedThroughProperty("Label28")]
  private Label _Label28;
  [AccessedThroughProperty("btnSelect17")]
  private Button _btnSelect17;
  [AccessedThroughProperty("btnSelect12")]
  private Button _btnSelect12;
  [AccessedThroughProperty("btnSelect11")]
  private Button _btnSelect11;
  [AccessedThroughProperty("btnSelect18")]
  private Button _btnSelect18;
  [AccessedThroughProperty("btnSelect6")]
  private Button _btnSelect6;
  [AccessedThroughProperty("Label26")]
  private Label _Label26;
  [AccessedThroughProperty("btnSelect5")]
  private Button _btnSelect5;
  [AccessedThroughProperty("Label6")]
  private Label _Label6;
  [AccessedThroughProperty("txtShname1")]
  private TextBox _txtShname1;
  [AccessedThroughProperty("lblName1")]
  private Label _lblName1;
  [AccessedThroughProperty("txtShname2")]
  private TextBox _txtShname2;
  [AccessedThroughProperty("lblName2")]
  private Label _lblName2;
  [AccessedThroughProperty("txtShname3")]
  private TextBox _txtShname3;
  [AccessedThroughProperty("lblName3")]
  private Label _lblName3;
  [AccessedThroughProperty("txtShname4")]
  private TextBox _txtShname4;
  [AccessedThroughProperty("lblName4")]
  private Label _lblName4;
  [AccessedThroughProperty("txtShname5")]
  private TextBox _txtShname5;
  [AccessedThroughProperty("lblName5")]
  private Label _lblName5;
  [AccessedThroughProperty("txtShname6")]
  private TextBox _txtShname6;
  [AccessedThroughProperty("lblName6")]
  private Label _lblName6;
  [AccessedThroughProperty("txtShname7")]
  private TextBox _txtShname7;
  [AccessedThroughProperty("lblName7")]
  private Label _lblName7;
  [AccessedThroughProperty("txtShname8")]
  private TextBox _txtShname8;
  [AccessedThroughProperty("lblName8")]
  private Label _lblName8;
  [AccessedThroughProperty("txtShname9")]
  private TextBox _txtShname9;
  [AccessedThroughProperty("lblName9")]
  private Label _lblName9;
  [AccessedThroughProperty("txtShname10")]
  private TextBox _txtShname10;
  [AccessedThroughProperty("lblName10")]
  private Label _lblName10;
  [AccessedThroughProperty("txtShname11")]
  private TextBox _txtShname11;
  [AccessedThroughProperty("lblName11")]
  private Label _lblName11;
  [AccessedThroughProperty("txtShname12")]
  private TextBox _txtShname12;
  [AccessedThroughProperty("lblName12")]
  private Label _lblName12;
  [AccessedThroughProperty("txtShname13")]
  private TextBox _txtShname13;
  [AccessedThroughProperty("lblName13")]
  private Label _lblName13;
  [AccessedThroughProperty("txtShname14")]
  private TextBox _txtShname14;
  [AccessedThroughProperty("lblName14")]
  private Label _lblName14;
  [AccessedThroughProperty("txtShname15")]
  private TextBox _txtShname15;
  [AccessedThroughProperty("lblName15")]
  private Label _lblName15;
  [AccessedThroughProperty("txtShname16")]
  private TextBox _txtShname16;
  [AccessedThroughProperty("lblName16")]
  private Label _lblName16;
  [AccessedThroughProperty("txtShname17")]
  private TextBox _txtShname17;
  [AccessedThroughProperty("lblName17")]
  private Label _lblName17;
  [AccessedThroughProperty("txtShname18")]
  private TextBox _txtShname18;
  [AccessedThroughProperty("lblName18")]
  private Label _lblName18;
  [AccessedThroughProperty("txtShname19")]
  private TextBox _txtShname19;
  [AccessedThroughProperty("lblName19")]
  private Label _lblName19;
  [AccessedThroughProperty("txtShname20")]
  private TextBox _txtShname20;
  [AccessedThroughProperty("lblName20")]
  private Label _lblName20;
  [AccessedThroughProperty("txtShname21")]
  private TextBox _txtShname21;
  [AccessedThroughProperty("lblName21")]
  private Label _lblName21;
  [AccessedThroughProperty("btnExit")]
  private Button _btnExit;
  [AccessedThroughProperty("btnUpdate")]
  private Button _btnUpdate;
  [AccessedThroughProperty("txtCode21")]
  private TextBox _txtCode21;
  [AccessedThroughProperty("txtCode20")]
  private TextBox _txtCode20;
  [AccessedThroughProperty("txtCode19")]
  private TextBox _txtCode19;
  [AccessedThroughProperty("txtCode18")]
  private TextBox _txtCode18;
  [AccessedThroughProperty("txtCode17")]
  private TextBox _txtCode17;
  [AccessedThroughProperty("txtCode16")]
  private TextBox _txtCode16;
  [AccessedThroughProperty("txtCode15")]
  private TextBox _txtCode15;
  [AccessedThroughProperty("txtCode14")]
  private TextBox _txtCode14;
  [AccessedThroughProperty("txtCode13")]
  private TextBox _txtCode13;
  [AccessedThroughProperty("txtCode12")]
  private TextBox _txtCode12;
  [AccessedThroughProperty("txtCode11")]
  private TextBox _txtCode11;
  [AccessedThroughProperty("txtCode10")]
  private TextBox _txtCode10;
  [AccessedThroughProperty("txtCode9")]
  private TextBox _txtCode9;
  [AccessedThroughProperty("txtCode8")]
  private TextBox _txtCode8;
  [AccessedThroughProperty("txtCode7")]
  private TextBox _txtCode7;
  [AccessedThroughProperty("txtCode6")]
  private TextBox _txtCode6;
  [AccessedThroughProperty("txtCode5")]
  private TextBox _txtCode5;
  [AccessedThroughProperty("txtCode4")]
  private TextBox _txtCode4;
  [AccessedThroughProperty("txtCode3")]
  private TextBox _txtCode3;
  [AccessedThroughProperty("txtCode2")]
  private TextBox _txtCode2;
  [AccessedThroughProperty("txtCode1")]
  private TextBox _txtCode1;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("lblAccCode21")]
  private Label _lblAccCode21;
  [AccessedThroughProperty("lblAccCode20")]
  private Label _lblAccCode20;
  [AccessedThroughProperty("lblAccCode19")]
  private Label _lblAccCode19;
  [AccessedThroughProperty("lblAccCode18")]
  private Label _lblAccCode18;
  [AccessedThroughProperty("lblAccCode17")]
  private Label _lblAccCode17;
  [AccessedThroughProperty("lblAccCode16")]
  private Label _lblAccCode16;
  [AccessedThroughProperty("lblAccCode15")]
  private Label _lblAccCode15;
  [AccessedThroughProperty("lblAccCode14")]
  private Label _lblAccCode14;
  [AccessedThroughProperty("lblAccCode13")]
  private Label _lblAccCode13;
  [AccessedThroughProperty("lblAccCode12")]
  private Label _lblAccCode12;
  [AccessedThroughProperty("lblAccCode11")]
  private Label _lblAccCode11;
  [AccessedThroughProperty("lblAccCode10")]
  private Label _lblAccCode10;
  [AccessedThroughProperty("lblAccCode9")]
  private Label _lblAccCode9;
  [AccessedThroughProperty("lblAccCode8")]
  private Label _lblAccCode8;
  [AccessedThroughProperty("lblAccCode7")]
  private Label _lblAccCode7;
  [AccessedThroughProperty("lblAccCode6")]
  private Label _lblAccCode6;
  [AccessedThroughProperty("lblAccCode5")]
  private Label _lblAccCode5;
  [AccessedThroughProperty("lblAccCode4")]
  private Label _lblAccCode4;
  [AccessedThroughProperty("lblAccCode3")]
  private Label _lblAccCode3;
  [AccessedThroughProperty("lblAccCode2")]
  private Label _lblAccCode2;
  [AccessedThroughProperty("lblAccCode1")]
  private Label _lblAccCode1;
  [AccessedThroughProperty("grpVisible")]
  private GroupBox _grpVisible;
  [AccessedThroughProperty("Label2")]
  private Label _Label2;
  [AccessedThroughProperty("Label3")]
  private Label _Label3;
  [AccessedThroughProperty("Label5")]
  private Label _Label5;
  [AccessedThroughProperty("Button2")]
  private Button _Button2;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("Label7")]
  private Label _Label7;
  [AccessedThroughProperty("Label9")]
  private Label _Label9;
  [AccessedThroughProperty("grpGSTApplicable")]
  private GroupBox _grpGSTApplicable;
  [AccessedThroughProperty("chk21")]
  private CheckBox _chk21;
  [AccessedThroughProperty("chk20")]
  private CheckBox _chk20;
  [AccessedThroughProperty("chk19")]
  private CheckBox _chk19;
  [AccessedThroughProperty("chk18")]
  private CheckBox _chk18;
  [AccessedThroughProperty("chk17")]
  private CheckBox _chk17;
  [AccessedThroughProperty("chk16")]
  private CheckBox _chk16;
  [AccessedThroughProperty("chk15")]
  private CheckBox _chk15;
  [AccessedThroughProperty("chk14")]
  private CheckBox _chk14;
  [AccessedThroughProperty("chk13")]
  private CheckBox _chk13;
  [AccessedThroughProperty("chk12")]
  private CheckBox _chk12;
  [AccessedThroughProperty("chk11")]
  private CheckBox _chk11;
  [AccessedThroughProperty("chk10")]
  private CheckBox _chk10;
  [AccessedThroughProperty("chk9")]
  private CheckBox _chk9;
  [AccessedThroughProperty("chk8")]
  private CheckBox _chk8;
  [AccessedThroughProperty("chk7")]
  private CheckBox _chk7;
  [AccessedThroughProperty("chk6")]
  private CheckBox _chk6;
  [AccessedThroughProperty("chk5")]
  private CheckBox _chk5;
  [AccessedThroughProperty("chk4")]
  private CheckBox _chk4;
  [AccessedThroughProperty("chk3")]
  private CheckBox _chk3;
  [AccessedThroughProperty("chk2")]
  private CheckBox _chk2;
  [AccessedThroughProperty("chk1")]
  private CheckBox _chk1;
  [AccessedThroughProperty("Label15")]
  private Label _Label15;
  [AccessedThroughProperty("Label13")]
  private Label _Label13;
  [AccessedThroughProperty("Label11")]
  private Label _Label11;
  [AccessedThroughProperty("txtRate21")]
  private TextBox _txtRate21;
  [AccessedThroughProperty("txtRate20")]
  private TextBox _txtRate20;
  [AccessedThroughProperty("txtRate19")]
  private TextBox _txtRate19;
  [AccessedThroughProperty("txtRate18")]
  private TextBox _txtRate18;
  [AccessedThroughProperty("txtRate17")]
  private TextBox _txtRate17;
  [AccessedThroughProperty("txtRate16")]
  private TextBox _txtRate16;
  [AccessedThroughProperty("txtRate15")]
  private TextBox _txtRate15;
  [AccessedThroughProperty("txtRate14")]
  private TextBox _txtRate14;
  [AccessedThroughProperty("txtRate13")]
  private TextBox _txtRate13;
  [AccessedThroughProperty("txtRate12")]
  private TextBox _txtRate12;
  [AccessedThroughProperty("txtRate11")]
  private TextBox _txtRate11;
  [AccessedThroughProperty("txtRate10")]
  private TextBox _txtRate10;
  [AccessedThroughProperty("txtRate9")]
  private TextBox _txtRate9;
  [AccessedThroughProperty("txtRate8")]
  private TextBox _txtRate8;
  [AccessedThroughProperty("txtRate7")]
  private TextBox _txtRate7;
  [AccessedThroughProperty("txtRate6")]
  private TextBox _txtRate6;
  [AccessedThroughProperty("txtRate5")]
  private TextBox _txtRate5;
  [AccessedThroughProperty("txtRate4")]
  private TextBox _txtRate4;
  [AccessedThroughProperty("txtRate3")]
  private TextBox _txtRate3;
  [AccessedThroughProperty("txtRate2")]
  private TextBox _txtRate2;
  [AccessedThroughProperty("txtRate1")]
  private TextBox _txtRate1;
  [AccessedThroughProperty("txtRound21")]
  private TextBox _txtRound21;
  [AccessedThroughProperty("txtRound20")]
  private TextBox _txtRound20;
  [AccessedThroughProperty("txtRound19")]
  private TextBox _txtRound19;
  [AccessedThroughProperty("txtRound18")]
  private TextBox _txtRound18;
  [AccessedThroughProperty("txtRound17")]
  private TextBox _txtRound17;
  [AccessedThroughProperty("txtRound16")]
  private TextBox _txtRound16;
  [AccessedThroughProperty("txtRound15")]
  private TextBox _txtRound15;
  [AccessedThroughProperty("txtRound14")]
  private TextBox _txtRound14;
  [AccessedThroughProperty("txtRound13")]
  private TextBox _txtRound13;
  [AccessedThroughProperty("txtRound12")]
  private TextBox _txtRound12;
  [AccessedThroughProperty("txtRound11")]
  private TextBox _txtRound11;
  [AccessedThroughProperty("txtRound10")]
  private TextBox _txtRound10;
  [AccessedThroughProperty("txtRound9")]
  private TextBox _txtRound9;
  [AccessedThroughProperty("txtRound8")]
  private TextBox _txtRound8;
  [AccessedThroughProperty("txtRound7")]
  private TextBox _txtRound7;
  [AccessedThroughProperty("txtRound6")]
  private TextBox _txtRound6;
  [AccessedThroughProperty("txtRound5")]
  private TextBox _txtRound5;
  [AccessedThroughProperty("txtRound4")]
  private TextBox _txtRound4;
  [AccessedThroughProperty("txtRound3")]
  private TextBox _txtRound3;
  [AccessedThroughProperty("txtRound2")]
  private TextBox _txtRound2;
  [AccessedThroughProperty("txtRound1")]
  private TextBox _txtRound1;
  [AccessedThroughProperty("grpGSTRate")]
  private GroupBox _grpGSTRate;
  [AccessedThroughProperty("Label17")]
  private Label _Label17;
  [AccessedThroughProperty("Label19")]
  private Label _Label19;
  [AccessedThroughProperty("GroupBox1")]
  private GroupBox _GroupBox1;
  [AccessedThroughProperty("txtRound021")]
  private TextBox _txtRound021;
  [AccessedThroughProperty("Label21")]
  private Label _Label21;
  [AccessedThroughProperty("txtRound020")]
  private TextBox _txtRound020;
  [AccessedThroughProperty("Label23")]
  private Label _Label23;
  [AccessedThroughProperty("txtRound019")]
  private TextBox _txtRound019;
  [AccessedThroughProperty("txtRate01")]
  private TextBox _txtRate01;
  [AccessedThroughProperty("txtRound018")]
  private TextBox _txtRound018;
  [AccessedThroughProperty("txtRate02")]
  private TextBox _txtRate02;
  [AccessedThroughProperty("txtRound017")]
  private TextBox _txtRound017;
  [AccessedThroughProperty("txtRate03")]
  private TextBox _txtRate03;
  [AccessedThroughProperty("txtRound016")]
  private TextBox _txtRound016;
  [AccessedThroughProperty("txtRate04")]
  private TextBox _txtRate04;
  [AccessedThroughProperty("txtRound015")]
  private TextBox _txtRound015;
  [AccessedThroughProperty("txtRate05")]
  private TextBox _txtRate05;
  [AccessedThroughProperty("txtRound014")]
  private TextBox _txtRound014;
  [AccessedThroughProperty("txtRate06")]
  private TextBox _txtRate06;
  [AccessedThroughProperty("txtRound013")]
  private TextBox _txtRound013;
  [AccessedThroughProperty("txtRate07")]
  private TextBox _txtRate07;
  [AccessedThroughProperty("txtRound012")]
  private TextBox _txtRound012;
  [AccessedThroughProperty("txtRate08")]
  private TextBox _txtRate08;
  [AccessedThroughProperty("txtRound011")]
  private TextBox _txtRound011;
  [AccessedThroughProperty("txtRate09")]
  private TextBox _txtRate09;
  [AccessedThroughProperty("txtRound010")]
  private TextBox _txtRound010;
  [AccessedThroughProperty("txtRate010")]
  private TextBox _txtRate010;
  [AccessedThroughProperty("txtRound09")]
  private TextBox _txtRound09;
  [AccessedThroughProperty("txtRate011")]
  private TextBox _txtRate011;
  [AccessedThroughProperty("txtRound08")]
  private TextBox _txtRound08;
  [AccessedThroughProperty("txtRate012")]
  private TextBox _txtRate012;
  [AccessedThroughProperty("txtRound07")]
  private TextBox _txtRound07;
  [AccessedThroughProperty("txtRate013")]
  private TextBox _txtRate013;
  [AccessedThroughProperty("txtRound06")]
  private TextBox _txtRound06;
  [AccessedThroughProperty("txtRate014")]
  private TextBox _txtRate014;
  [AccessedThroughProperty("txtRound05")]
  private TextBox _txtRound05;
  [AccessedThroughProperty("txtRate015")]
  private TextBox _txtRate015;
  [AccessedThroughProperty("txtRound04")]
  private TextBox _txtRound04;
  [AccessedThroughProperty("txtRate016")]
  private TextBox _txtRate016;
  [AccessedThroughProperty("txtRound03")]
  private TextBox _txtRound03;
  [AccessedThroughProperty("txtRate017")]
  private TextBox _txtRate017;
  [AccessedThroughProperty("txtRound02")]
  private TextBox _txtRound02;
  [AccessedThroughProperty("txtRate018")]
  private TextBox _txtRate018;
  [AccessedThroughProperty("txtRound01")]
  private TextBox _txtRound01;
  [AccessedThroughProperty("txtRate019")]
  private TextBox _txtRate019;
  [AccessedThroughProperty("txtRate021")]
  private TextBox _txtRate021;
  [AccessedThroughProperty("txtRate020")]
  private TextBox _txtRate020;
  [AccessedThroughProperty("grpLimitApplicable")]
  private GroupBox _grpLimitApplicable;
  [AccessedThroughProperty("chkl21")]
  private CheckBox _chkl21;
  [AccessedThroughProperty("chkl20")]
  private CheckBox _chkl20;
  [AccessedThroughProperty("chkl19")]
  private CheckBox _chkl19;
  [AccessedThroughProperty("chkl18")]
  private CheckBox _chkl18;
  [AccessedThroughProperty("chkl17")]
  private CheckBox _chkl17;
  [AccessedThroughProperty("chkl16")]
  private CheckBox _chkl16;
  [AccessedThroughProperty("chkl15")]
  private CheckBox _chkl15;
  [AccessedThroughProperty("chkl14")]
  private CheckBox _chkl14;
  [AccessedThroughProperty("chkl13")]
  private CheckBox _chkl13;
  [AccessedThroughProperty("chkl12")]
  private CheckBox _chkl12;
  [AccessedThroughProperty("chkl11")]
  private CheckBox _chkl11;
  [AccessedThroughProperty("chkl10")]
  private CheckBox _chkl10;
  [AccessedThroughProperty("chkl9")]
  private CheckBox _chkl9;
  [AccessedThroughProperty("chkl8")]
  private CheckBox _chkl8;
  [AccessedThroughProperty("chkl7")]
  private CheckBox _chkl7;
  [AccessedThroughProperty("chkl6")]
  private CheckBox _chkl6;
  [AccessedThroughProperty("chkl5")]
  private CheckBox _chkl5;
  [AccessedThroughProperty("chkl4")]
  private CheckBox _chkl4;
  [AccessedThroughProperty("chkl3")]
  private CheckBox _chkl3;
  [AccessedThroughProperty("chkl2")]
  private CheckBox _chkl2;
  [AccessedThroughProperty("chkl1")]
  private CheckBox _chkl1;
  [AccessedThroughProperty("Label25")]
  private Label _Label25;

  [DebuggerNonUserCode]
  static frmBillSetting()
  {
  }

  [DebuggerNonUserCode]
  public frmBillSetting()
  {
    this.Load += new EventHandler(this.frmBillSetting_Load);
    frmBillSetting.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmBillSetting.__ENCList)
    {
      if (frmBillSetting.__ENCList.Count == frmBillSetting.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmBillSetting.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmBillSetting.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmBillSetting.__ENCList[index1] = frmBillSetting.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmBillSetting.__ENCList.RemoveRange(index1, checked (frmBillSetting.__ENCList.Count - index1));
        frmBillSetting.__ENCList.Capacity = frmBillSetting.__ENCList.Count;
      }
      frmBillSetting.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBillSetting));
    this.Label1 = new Label();
    this.btnSelect1 = new Button();
    this.Label18 = new Label();
    this.Label30 = new Label();
    this.Label14 = new Label();
    this.Label38 = new Label();
    this.Label12 = new Label();
    this.btnSelect14 = new Button();
    this.btnSelect4 = new Button();
    this.Label20 = new Label();
    this.btnSelect3 = new Button();
    this.Label16 = new Label();
    this.btnSelect9 = new Button();
    this.Label40 = new Label();
    this.btnSelect21 = new Button();
    this.btnSelect20 = new Button();
    this.btnSelect16 = new Button();
    this.Label34 = new Label();
    this.btnSelect7 = new Button();
    this.btnSelect15 = new Button();
    this.Label42 = new Label();
    this.btnSelect2 = new Button();
    this.Label32 = new Label();
    this.Label4 = new Label();
    this.Label10 = new Label();
    this.btnSelect8 = new Button();
    this.btnSelect13 = new Button();
    this.Label24 = new Label();
    this.btnSelect10 = new Button();
    this.btnSelect19 = new Button();
    this.Label36 = new Label();
    this.Label8 = new Label();
    this.Label22 = new Label();
    this.Label28 = new Label();
    this.btnSelect17 = new Button();
    this.btnSelect12 = new Button();
    this.btnSelect11 = new Button();
    this.btnSelect18 = new Button();
    this.btnSelect6 = new Button();
    this.Label26 = new Label();
    this.btnSelect5 = new Button();
    this.Label6 = new Label();
    this.txtShname1 = new TextBox();
    this.lblName1 = new Label();
    this.txtShname2 = new TextBox();
    this.lblName2 = new Label();
    this.txtShname3 = new TextBox();
    this.lblName3 = new Label();
    this.txtShname4 = new TextBox();
    this.lblName4 = new Label();
    this.txtShname5 = new TextBox();
    this.lblName5 = new Label();
    this.txtShname6 = new TextBox();
    this.lblName6 = new Label();
    this.txtShname7 = new TextBox();
    this.lblName7 = new Label();
    this.txtShname8 = new TextBox();
    this.lblName8 = new Label();
    this.txtShname9 = new TextBox();
    this.lblName9 = new Label();
    this.txtShname10 = new TextBox();
    this.lblName10 = new Label();
    this.txtShname11 = new TextBox();
    this.lblName11 = new Label();
    this.txtShname12 = new TextBox();
    this.lblName12 = new Label();
    this.txtShname13 = new TextBox();
    this.lblName13 = new Label();
    this.txtShname14 = new TextBox();
    this.lblName14 = new Label();
    this.txtShname15 = new TextBox();
    this.lblName15 = new Label();
    this.txtShname16 = new TextBox();
    this.lblName16 = new Label();
    this.txtShname17 = new TextBox();
    this.lblName17 = new Label();
    this.txtShname18 = new TextBox();
    this.lblName18 = new Label();
    this.txtShname19 = new TextBox();
    this.lblName19 = new Label();
    this.txtShname20 = new TextBox();
    this.lblName20 = new Label();
    this.txtShname21 = new TextBox();
    this.lblName21 = new Label();
    this.btnExit = new Button();
    this.btnUpdate = new Button();
    this.txtCode21 = new TextBox();
    this.txtCode20 = new TextBox();
    this.txtCode19 = new TextBox();
    this.txtCode18 = new TextBox();
    this.txtCode17 = new TextBox();
    this.txtCode16 = new TextBox();
    this.txtCode15 = new TextBox();
    this.txtCode14 = new TextBox();
    this.txtCode13 = new TextBox();
    this.txtCode12 = new TextBox();
    this.txtCode11 = new TextBox();
    this.txtCode10 = new TextBox();
    this.txtCode9 = new TextBox();
    this.txtCode8 = new TextBox();
    this.txtCode7 = new TextBox();
    this.txtCode6 = new TextBox();
    this.txtCode5 = new TextBox();
    this.txtCode4 = new TextBox();
    this.txtCode3 = new TextBox();
    this.txtCode2 = new TextBox();
    this.txtCode1 = new TextBox();
    this.DataGridView1 = new DataGridView();
    this.lblAccCode21 = new Label();
    this.lblAccCode20 = new Label();
    this.lblAccCode19 = new Label();
    this.lblAccCode18 = new Label();
    this.lblAccCode17 = new Label();
    this.lblAccCode16 = new Label();
    this.lblAccCode15 = new Label();
    this.lblAccCode14 = new Label();
    this.lblAccCode13 = new Label();
    this.lblAccCode12 = new Label();
    this.lblAccCode11 = new Label();
    this.lblAccCode10 = new Label();
    this.lblAccCode9 = new Label();
    this.lblAccCode8 = new Label();
    this.lblAccCode7 = new Label();
    this.lblAccCode6 = new Label();
    this.lblAccCode5 = new Label();
    this.lblAccCode4 = new Label();
    this.lblAccCode3 = new Label();
    this.lblAccCode2 = new Label();
    this.lblAccCode1 = new Label();
    this.grpVisible = new GroupBox();
    this.GroupBox1 = new GroupBox();
    this.txtRound021 = new TextBox();
    this.Label21 = new Label();
    this.txtRound020 = new TextBox();
    this.Label23 = new Label();
    this.txtRound019 = new TextBox();
    this.txtRate01 = new TextBox();
    this.txtRound018 = new TextBox();
    this.txtRate02 = new TextBox();
    this.txtRound017 = new TextBox();
    this.txtRate03 = new TextBox();
    this.txtRound016 = new TextBox();
    this.txtRate04 = new TextBox();
    this.txtRound015 = new TextBox();
    this.txtRate05 = new TextBox();
    this.txtRound014 = new TextBox();
    this.txtRate06 = new TextBox();
    this.txtRound013 = new TextBox();
    this.txtRate07 = new TextBox();
    this.txtRound012 = new TextBox();
    this.txtRate08 = new TextBox();
    this.txtRound011 = new TextBox();
    this.txtRate09 = new TextBox();
    this.txtRound010 = new TextBox();
    this.txtRate010 = new TextBox();
    this.txtRound09 = new TextBox();
    this.txtRate011 = new TextBox();
    this.txtRound08 = new TextBox();
    this.txtRate012 = new TextBox();
    this.txtRound07 = new TextBox();
    this.txtRate013 = new TextBox();
    this.txtRound06 = new TextBox();
    this.txtRate014 = new TextBox();
    this.txtRound05 = new TextBox();
    this.txtRate015 = new TextBox();
    this.txtRound04 = new TextBox();
    this.txtRate016 = new TextBox();
    this.txtRound03 = new TextBox();
    this.txtRate017 = new TextBox();
    this.txtRound02 = new TextBox();
    this.txtRate018 = new TextBox();
    this.txtRound01 = new TextBox();
    this.txtRate019 = new TextBox();
    this.txtRate021 = new TextBox();
    this.txtRate020 = new TextBox();
    this.DataGridView2 = new DataGridView();
    this.grpGSTRate = new GroupBox();
    this.txtRound21 = new TextBox();
    this.Label15 = new Label();
    this.txtRound20 = new TextBox();
    this.Label13 = new Label();
    this.txtRound19 = new TextBox();
    this.txtRate1 = new TextBox();
    this.txtRound18 = new TextBox();
    this.txtRate2 = new TextBox();
    this.txtRound17 = new TextBox();
    this.txtRate3 = new TextBox();
    this.txtRound16 = new TextBox();
    this.txtRate4 = new TextBox();
    this.txtRound15 = new TextBox();
    this.txtRate5 = new TextBox();
    this.txtRound14 = new TextBox();
    this.txtRate6 = new TextBox();
    this.txtRound13 = new TextBox();
    this.txtRate7 = new TextBox();
    this.txtRound12 = new TextBox();
    this.txtRate8 = new TextBox();
    this.txtRound11 = new TextBox();
    this.txtRate9 = new TextBox();
    this.txtRound10 = new TextBox();
    this.txtRate10 = new TextBox();
    this.txtRound9 = new TextBox();
    this.txtRate11 = new TextBox();
    this.txtRound8 = new TextBox();
    this.txtRate12 = new TextBox();
    this.txtRound7 = new TextBox();
    this.txtRate13 = new TextBox();
    this.txtRound6 = new TextBox();
    this.txtRate14 = new TextBox();
    this.txtRound5 = new TextBox();
    this.txtRate15 = new TextBox();
    this.txtRound4 = new TextBox();
    this.txtRate16 = new TextBox();
    this.txtRound3 = new TextBox();
    this.txtRate17 = new TextBox();
    this.txtRound2 = new TextBox();
    this.txtRate18 = new TextBox();
    this.txtRound1 = new TextBox();
    this.txtRate19 = new TextBox();
    this.txtRate21 = new TextBox();
    this.txtRate20 = new TextBox();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label5 = new Label();
    this.Button2 = new Button();
    this.Label7 = new Label();
    this.Label9 = new Label();
    this.grpGSTApplicable = new GroupBox();
    this.chk21 = new CheckBox();
    this.chk20 = new CheckBox();
    this.chk19 = new CheckBox();
    this.chk18 = new CheckBox();
    this.chk17 = new CheckBox();
    this.chk16 = new CheckBox();
    this.chk15 = new CheckBox();
    this.chk14 = new CheckBox();
    this.chk13 = new CheckBox();
    this.chk12 = new CheckBox();
    this.chk11 = new CheckBox();
    this.chk10 = new CheckBox();
    this.chk9 = new CheckBox();
    this.chk8 = new CheckBox();
    this.chk7 = new CheckBox();
    this.chk6 = new CheckBox();
    this.chk5 = new CheckBox();
    this.chk4 = new CheckBox();
    this.chk3 = new CheckBox();
    this.chk2 = new CheckBox();
    this.chk1 = new CheckBox();
    this.Label11 = new Label();
    this.Label17 = new Label();
    this.Label19 = new Label();
    this.grpLimitApplicable = new GroupBox();
    this.chkl21 = new CheckBox();
    this.chkl20 = new CheckBox();
    this.chkl19 = new CheckBox();
    this.chkl18 = new CheckBox();
    this.chkl17 = new CheckBox();
    this.chkl16 = new CheckBox();
    this.chkl15 = new CheckBox();
    this.chkl14 = new CheckBox();
    this.chkl13 = new CheckBox();
    this.chkl12 = new CheckBox();
    this.chkl11 = new CheckBox();
    this.chkl10 = new CheckBox();
    this.chkl9 = new CheckBox();
    this.chkl8 = new CheckBox();
    this.chkl7 = new CheckBox();
    this.chkl6 = new CheckBox();
    this.chkl5 = new CheckBox();
    this.chkl4 = new CheckBox();
    this.chkl3 = new CheckBox();
    this.chkl2 = new CheckBox();
    this.chkl1 = new CheckBox();
    this.Label25 = new Label();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    this.grpVisible.SuspendLayout();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.grpGSTRate.SuspendLayout();
    this.grpGSTApplicable.SuspendLayout();
    this.grpLimitApplicable.SuspendLayout();
    this.SuspendLayout();
    this.Label1.AutoSize = true;
    Label label1_1 = this.Label1;
    Point point1 = new Point(49, 30);
    Point point2 = point1;
    label1_1.Location = point2;
    Label label1_2 = this.Label1;
    Padding padding1 = new Padding(4, 0, 4, 0);
    Padding padding2 = padding1;
    label1_2.Margin = padding2;
    this.Label1.Name = "Label1";
    Label label1_3 = this.Label1;
    Size size1 = new Size(18, 16 /*0x10*/);
    Size size2 = size1;
    label1_3.Size = size2;
    this.Label1.TabIndex = 11;
    this.Label1.Text = "1.";
    Button btnSelect1_1 = this.btnSelect1;
    point1 = new Point(69, 23);
    Point point3 = point1;
    btnSelect1_1.Location = point3;
    Button btnSelect1_2 = this.btnSelect1;
    padding1 = new Padding(4);
    Padding padding3 = padding1;
    btnSelect1_2.Margin = padding3;
    this.btnSelect1.Name = "btnSelect1";
    Button btnSelect1_3 = this.btnSelect1;
    size1 = new Size(111, 28);
    Size size3 = size1;
    btnSelect1_3.Size = size3;
    this.btnSelect1.TabIndex = 0;
    this.btnSelect1.Text = "Account List";
    this.btnSelect1.UseVisualStyleBackColor = true;
    this.Label18.AutoSize = true;
    Label label18_1 = this.Label18;
    point1 = new Point(49, 257);
    Point point4 = point1;
    label18_1.Location = point4;
    Label label18_2 = this.Label18;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding4 = padding1;
    label18_2.Margin = padding4;
    this.Label18.Name = "Label18";
    Label label18_3 = this.Label18;
    size1 = new Size(18, 16 /*0x10*/);
    Size size4 = size1;
    label18_3.Size = size4;
    this.Label18.TabIndex = 35;
    this.Label18.Text = "9.";
    this.Label30.AutoSize = true;
    Label label30_1 = this.Label30;
    point1 = new Point(41, 516);
    Point point5 = point1;
    label30_1.Location = point5;
    Label label30_2 = this.Label30;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding5 = padding1;
    label30_2.Margin = padding5;
    this.Label30.Name = "Label30";
    Label label30_3 = this.Label30;
    size1 = new Size(25, 16 /*0x10*/);
    Size size5 = size1;
    label30_3.Size = size5;
    this.Label30.TabIndex = 72;
    this.Label30.Text = "18.";
    this.Label14.AutoSize = true;
    Label label14_1 = this.Label14;
    point1 = new Point(49, 201);
    Point point6 = point1;
    label14_1.Location = point6;
    Label label14_2 = this.Label14;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding6 = padding1;
    label14_2.Margin = padding6;
    this.Label14.Name = "Label14";
    Label label14_3 = this.Label14;
    size1 = new Size(18, 16 /*0x10*/);
    Size size6 = size1;
    label14_3.Size = size6;
    this.Label14.TabIndex = 29;
    this.Label14.Text = "7.";
    this.Label38.AutoSize = true;
    Label label38_1 = this.Label38;
    point1 = new Point(41, 401);
    Point point7 = point1;
    label38_1.Location = point7;
    Label label38_2 = this.Label38;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding7 = padding1;
    label38_2.Margin = padding7;
    this.Label38.Name = "Label38";
    Label label38_3 = this.Label38;
    size1 = new Size(25, 16 /*0x10*/);
    Size size7 = size1;
    label38_3.Size = size7;
    this.Label38.TabIndex = 60;
    this.Label38.Text = "14.";
    this.Label12.AutoSize = true;
    Label label12_1 = this.Label12;
    point1 = new Point(49, 172);
    Point point8 = point1;
    label12_1.Location = point8;
    Label label12_2 = this.Label12;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding8 = padding1;
    label12_2.Margin = padding8;
    this.Label12.Name = "Label12";
    Label label12_3 = this.Label12;
    size1 = new Size(18, 16 /*0x10*/);
    Size size8 = size1;
    label12_3.Size = size8;
    this.Label12.TabIndex = 26;
    this.Label12.Text = "6.";
    Button btnSelect14_1 = this.btnSelect14;
    point1 = new Point(69, 395);
    Point point9 = point1;
    btnSelect14_1.Location = point9;
    Button btnSelect14_2 = this.btnSelect14;
    padding1 = new Padding(4);
    Padding padding9 = padding1;
    btnSelect14_2.Margin = padding9;
    this.btnSelect14.Name = "btnSelect14";
    Button btnSelect14_3 = this.btnSelect14;
    size1 = new Size(111, 28);
    Size size9 = size1;
    btnSelect14_3.Size = size9;
    this.btnSelect14.TabIndex = 26;
    this.btnSelect14.Text = "Account List";
    this.btnSelect14.UseVisualStyleBackColor = true;
    Button btnSelect4_1 = this.btnSelect4;
    point1 = new Point(69, 108);
    Point point10 = point1;
    btnSelect4_1.Location = point10;
    Button btnSelect4_2 = this.btnSelect4;
    padding1 = new Padding(4);
    Padding padding10 = padding1;
    btnSelect4_2.Margin = padding10;
    this.btnSelect4.Name = "btnSelect4";
    Button btnSelect4_3 = this.btnSelect4;
    size1 = new Size(111, 28);
    Size size10 = size1;
    btnSelect4_3.Size = size10;
    this.btnSelect4.TabIndex = 6;
    this.btnSelect4.Text = "Account List";
    this.btnSelect4.UseVisualStyleBackColor = true;
    this.Label20.AutoSize = true;
    Label label20_1 = this.Label20;
    point1 = new Point(41, 286);
    Point point11 = point1;
    label20_1.Location = point11;
    Label label20_2 = this.Label20;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding11 = padding1;
    label20_2.Margin = padding11;
    this.Label20.Name = "Label20";
    Label label20_3 = this.Label20;
    size1 = new Size(25, 16 /*0x10*/);
    Size size11 = size1;
    label20_3.Size = size11;
    this.Label20.TabIndex = 38;
    this.Label20.Text = "10.";
    Button btnSelect3_1 = this.btnSelect3;
    point1 = new Point(69, 80 /*0x50*/);
    Point point12 = point1;
    btnSelect3_1.Location = point12;
    Button btnSelect3_2 = this.btnSelect3;
    padding1 = new Padding(4);
    Padding padding12 = padding1;
    btnSelect3_2.Margin = padding12;
    this.btnSelect3.Name = "btnSelect3";
    Button btnSelect3_3 = this.btnSelect3;
    size1 = new Size(111, 28);
    Size size12 = size1;
    btnSelect3_3.Size = size12;
    this.btnSelect3.TabIndex = 4;
    this.btnSelect3.Text = "Account List";
    this.btnSelect3.UseVisualStyleBackColor = true;
    this.Label16.AutoSize = true;
    Label label16_1 = this.Label16;
    point1 = new Point(49, 229);
    Point point13 = point1;
    label16_1.Location = point13;
    Label label16_2 = this.Label16;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding13 = padding1;
    label16_2.Margin = padding13;
    this.Label16.Name = "Label16";
    Label label16_3 = this.Label16;
    size1 = new Size(18, 16 /*0x10*/);
    Size size13 = size1;
    label16_3.Size = size13;
    this.Label16.TabIndex = 32 /*0x20*/;
    this.Label16.Text = "8.";
    Button btnSelect9_1 = this.btnSelect9;
    point1 = new Point(69, 251);
    Point point14 = point1;
    btnSelect9_1.Location = point14;
    Button btnSelect9_2 = this.btnSelect9;
    padding1 = new Padding(4);
    Padding padding14 = padding1;
    btnSelect9_2.Margin = padding14;
    this.btnSelect9.Name = "btnSelect9";
    Button btnSelect9_3 = this.btnSelect9;
    size1 = new Size(111, 28);
    Size size14 = size1;
    btnSelect9_3.Size = size14;
    this.btnSelect9.TabIndex = 16 /*0x10*/;
    this.btnSelect9.Text = "Account List";
    this.btnSelect9.UseVisualStyleBackColor = true;
    this.Label40.AutoSize = true;
    Label label40_1 = this.Label40;
    point1 = new Point(41, 372);
    Point point15 = point1;
    label40_1.Location = point15;
    Label label40_2 = this.Label40;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding15 = padding1;
    label40_2.Margin = padding15;
    this.Label40.Name = "Label40";
    Label label40_3 = this.Label40;
    size1 = new Size(25, 16 /*0x10*/);
    Size size15 = size1;
    label40_3.Size = size15;
    this.Label40.TabIndex = 57;
    this.Label40.Text = "13.";
    Button btnSelect21_1 = this.btnSelect21;
    point1 = new Point(69, 595);
    Point point16 = point1;
    btnSelect21_1.Location = point16;
    Button btnSelect21_2 = this.btnSelect21;
    padding1 = new Padding(4);
    Padding padding16 = padding1;
    btnSelect21_2.Margin = padding16;
    this.btnSelect21.Name = "btnSelect21";
    Button btnSelect21_3 = this.btnSelect21;
    size1 = new Size(111, 28);
    Size size16 = size1;
    btnSelect21_3.Size = size16;
    this.btnSelect21.TabIndex = 40;
    this.btnSelect21.Text = "Account List";
    this.btnSelect21.UseVisualStyleBackColor = true;
    Button btnSelect20_1 = this.btnSelect20;
    point1 = new Point(69, 566);
    Point point17 = point1;
    btnSelect20_1.Location = point17;
    Button btnSelect20_2 = this.btnSelect20;
    padding1 = new Padding(4);
    Padding padding17 = padding1;
    btnSelect20_2.Margin = padding17;
    this.btnSelect20.Name = "btnSelect20";
    Button btnSelect20_3 = this.btnSelect20;
    size1 = new Size(111, 28);
    Size size17 = size1;
    btnSelect20_3.Size = size17;
    this.btnSelect20.TabIndex = 38;
    this.btnSelect20.Text = "Account List";
    this.btnSelect20.UseVisualStyleBackColor = true;
    Button btnSelect16_1 = this.btnSelect16;
    point1 = new Point(69, 453);
    Point point18 = point1;
    btnSelect16_1.Location = point18;
    Button btnSelect16_2 = this.btnSelect16;
    padding1 = new Padding(4);
    Padding padding18 = padding1;
    btnSelect16_2.Margin = padding18;
    this.btnSelect16.Name = "btnSelect16";
    Button btnSelect16_3 = this.btnSelect16;
    size1 = new Size(111, 28);
    Size size18 = size1;
    btnSelect16_3.Size = size18;
    this.btnSelect16.TabIndex = 30;
    this.btnSelect16.Text = "Account List";
    this.btnSelect16.UseVisualStyleBackColor = true;
    this.Label34.AutoSize = true;
    Label label34_1 = this.Label34;
    point1 = new Point(41, 459);
    Point point19 = point1;
    label34_1.Location = point19;
    Label label34_2 = this.Label34;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding19 = padding1;
    label34_2.Margin = padding19;
    this.Label34.Name = "Label34";
    Label label34_3 = this.Label34;
    size1 = new Size(25, 16 /*0x10*/);
    Size size19 = size1;
    label34_3.Size = size19;
    this.Label34.TabIndex = 66;
    this.Label34.Text = "16.";
    Button btnSelect7_1 = this.btnSelect7;
    point1 = new Point(69, 194);
    Point point20 = point1;
    btnSelect7_1.Location = point20;
    Button btnSelect7_2 = this.btnSelect7;
    padding1 = new Padding(4);
    Padding padding20 = padding1;
    btnSelect7_2.Margin = padding20;
    this.btnSelect7.Name = "btnSelect7";
    Button btnSelect7_3 = this.btnSelect7;
    size1 = new Size(111, 28);
    Size size20 = size1;
    btnSelect7_3.Size = size20;
    this.btnSelect7.TabIndex = 12;
    this.btnSelect7.Text = "Account List";
    this.btnSelect7.UseVisualStyleBackColor = true;
    Button btnSelect15_1 = this.btnSelect15;
    point1 = new Point(69, 425);
    Point point21 = point1;
    btnSelect15_1.Location = point21;
    Button btnSelect15_2 = this.btnSelect15;
    padding1 = new Padding(4);
    Padding padding21 = padding1;
    btnSelect15_2.Margin = padding21;
    this.btnSelect15.Name = "btnSelect15";
    Button btnSelect15_3 = this.btnSelect15;
    size1 = new Size(111, 28);
    Size size21 = size1;
    btnSelect15_3.Size = size21;
    this.btnSelect15.TabIndex = 28;
    this.btnSelect15.Text = "Account List";
    this.btnSelect15.UseVisualStyleBackColor = true;
    this.Label42.AutoSize = true;
    Label label42_1 = this.Label42;
    point1 = new Point(41, 342);
    Point point22 = point1;
    label42_1.Location = point22;
    Label label42_2 = this.Label42;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding22 = padding1;
    label42_2.Margin = padding22;
    this.Label42.Name = "Label42";
    Label label42_3 = this.Label42;
    size1 = new Size(25, 16 /*0x10*/);
    Size size22 = size1;
    label42_3.Size = size22;
    this.Label42.TabIndex = 54;
    this.Label42.Text = "12.";
    Button btnSelect2_1 = this.btnSelect2;
    point1 = new Point(69, 52);
    Point point23 = point1;
    btnSelect2_1.Location = point23;
    Button btnSelect2_2 = this.btnSelect2;
    padding1 = new Padding(4);
    Padding padding23 = padding1;
    btnSelect2_2.Margin = padding23;
    this.btnSelect2.Name = "btnSelect2";
    Button btnSelect2_3 = this.btnSelect2;
    size1 = new Size(111, 28);
    Size size23 = size1;
    btnSelect2_3.Size = size23;
    this.btnSelect2.TabIndex = 2;
    this.btnSelect2.Text = "Account List";
    this.btnSelect2.UseVisualStyleBackColor = true;
    this.Label32.AutoSize = true;
    Label label32_1 = this.Label32;
    point1 = new Point(41, 487);
    Point point24 = point1;
    label32_1.Location = point24;
    Label label32_2 = this.Label32;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding24 = padding1;
    label32_2.Margin = padding24;
    this.Label32.Name = "Label32";
    Label label32_3 = this.Label32;
    size1 = new Size(25, 16 /*0x10*/);
    Size size24 = size1;
    label32_3.Size = size24;
    this.Label32.TabIndex = 69;
    this.Label32.Text = "17.";
    this.Label4.AutoSize = true;
    Label label4_1 = this.Label4;
    point1 = new Point(49, 58);
    Point point25 = point1;
    label4_1.Location = point25;
    Label label4_2 = this.Label4;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding25 = padding1;
    label4_2.Margin = padding25;
    this.Label4.Name = "Label4";
    Label label4_3 = this.Label4;
    size1 = new Size(18, 16 /*0x10*/);
    Size size25 = size1;
    label4_3.Size = size25;
    this.Label4.TabIndex = 14;
    this.Label4.Text = "2.";
    this.Label10.AutoSize = true;
    Label label10_1 = this.Label10;
    point1 = new Point(49, 143);
    Point point26 = point1;
    label10_1.Location = point26;
    Label label10_2 = this.Label10;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding26 = padding1;
    label10_2.Margin = padding26;
    this.Label10.Name = "Label10";
    Label label10_3 = this.Label10;
    size1 = new Size(18, 16 /*0x10*/);
    Size size26 = size1;
    label10_3.Size = size26;
    this.Label10.TabIndex = 23;
    this.Label10.Text = "5.";
    Button btnSelect8_1 = this.btnSelect8;
    point1 = new Point(69, 223);
    Point point27 = point1;
    btnSelect8_1.Location = point27;
    Button btnSelect8_2 = this.btnSelect8;
    padding1 = new Padding(4);
    Padding padding27 = padding1;
    btnSelect8_2.Margin = padding27;
    this.btnSelect8.Name = "btnSelect8";
    Button btnSelect8_3 = this.btnSelect8;
    size1 = new Size(111, 28);
    Size size27 = size1;
    btnSelect8_3.Size = size27;
    this.btnSelect8.TabIndex = 14;
    this.btnSelect8.Text = "Account List";
    this.btnSelect8.UseVisualStyleBackColor = true;
    Button btnSelect13_1 = this.btnSelect13;
    point1 = new Point(69, 366);
    Point point28 = point1;
    btnSelect13_1.Location = point28;
    Button btnSelect13_2 = this.btnSelect13;
    padding1 = new Padding(4);
    Padding padding28 = padding1;
    btnSelect13_2.Margin = padding28;
    this.btnSelect13.Name = "btnSelect13";
    Button btnSelect13_3 = this.btnSelect13;
    size1 = new Size(111, 28);
    Size size28 = size1;
    btnSelect13_3.Size = size28;
    this.btnSelect13.TabIndex = 24;
    this.btnSelect13.Text = "Account List";
    this.btnSelect13.UseVisualStyleBackColor = true;
    this.Label24.AutoSize = true;
    Label label24_1 = this.Label24;
    point1 = new Point(41, 601);
    Point point29 = point1;
    label24_1.Location = point29;
    Label label24_2 = this.Label24;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding29 = padding1;
    label24_2.Margin = padding29;
    this.Label24.Name = "Label24";
    Label label24_3 = this.Label24;
    size1 = new Size(25, 16 /*0x10*/);
    Size size29 = size1;
    label24_3.Size = size29;
    this.Label24.TabIndex = 81;
    this.Label24.Text = "21.";
    Button btnSelect10_1 = this.btnSelect10;
    point1 = new Point(69, 279);
    Point point30 = point1;
    btnSelect10_1.Location = point30;
    Button btnSelect10_2 = this.btnSelect10;
    padding1 = new Padding(4);
    Padding padding30 = padding1;
    btnSelect10_2.Margin = padding30;
    this.btnSelect10.Name = "btnSelect10";
    Button btnSelect10_3 = this.btnSelect10;
    size1 = new Size(111, 28);
    Size size30 = size1;
    btnSelect10_3.Size = size30;
    this.btnSelect10.TabIndex = 18;
    this.btnSelect10.Text = "Account List";
    this.btnSelect10.UseVisualStyleBackColor = true;
    Button btnSelect19_1 = this.btnSelect19;
    point1 = new Point(69, 538);
    Point point31 = point1;
    btnSelect19_1.Location = point31;
    Button btnSelect19_2 = this.btnSelect19;
    padding1 = new Padding(4);
    Padding padding31 = padding1;
    btnSelect19_2.Margin = padding31;
    this.btnSelect19.Name = "btnSelect19";
    Button btnSelect19_3 = this.btnSelect19;
    size1 = new Size(111, 28);
    Size size31 = size1;
    btnSelect19_3.Size = size31;
    this.btnSelect19.TabIndex = 36;
    this.btnSelect19.Text = "Account List";
    this.btnSelect19.UseVisualStyleBackColor = true;
    this.Label36.AutoSize = true;
    Label label36_1 = this.Label36;
    point1 = new Point(41, 431);
    Point point32 = point1;
    label36_1.Location = point32;
    Label label36_2 = this.Label36;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding32 = padding1;
    label36_2.Margin = padding32;
    this.Label36.Name = "Label36";
    Label label36_3 = this.Label36;
    size1 = new Size(25, 16 /*0x10*/);
    Size size32 = size1;
    label36_3.Size = size32;
    this.Label36.TabIndex = 63 /*0x3F*/;
    this.Label36.Text = "15.";
    this.Label8.AutoSize = true;
    Label label8_1 = this.Label8;
    point1 = new Point(49, 114);
    Point point33 = point1;
    label8_1.Location = point33;
    Label label8_2 = this.Label8;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding33 = padding1;
    label8_2.Margin = padding33;
    this.Label8.Name = "Label8";
    Label label8_3 = this.Label8;
    size1 = new Size(18, 16 /*0x10*/);
    Size size33 = size1;
    label8_3.Size = size33;
    this.Label8.TabIndex = 20;
    this.Label8.Text = "4.";
    this.Label22.AutoSize = true;
    Label label22_1 = this.Label22;
    point1 = new Point(41, 314);
    Point point34 = point1;
    label22_1.Location = point34;
    Label label22_2 = this.Label22;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding34 = padding1;
    label22_2.Margin = padding34;
    this.Label22.Name = "Label22";
    Label label22_3 = this.Label22;
    size1 = new Size(25, 16 /*0x10*/);
    Size size34 = size1;
    label22_3.Size = size34;
    this.Label22.TabIndex = 41;
    this.Label22.Text = "11.";
    this.Label28.AutoSize = true;
    Label label28_1 = this.Label28;
    point1 = new Point(41, 544);
    Point point35 = point1;
    label28_1.Location = point35;
    Label label28_2 = this.Label28;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding35 = padding1;
    label28_2.Margin = padding35;
    this.Label28.Name = "Label28";
    Label label28_3 = this.Label28;
    size1 = new Size(25, 16 /*0x10*/);
    Size size35 = size1;
    label28_3.Size = size35;
    this.Label28.TabIndex = 75;
    this.Label28.Text = "19.";
    Button btnSelect17_1 = this.btnSelect17;
    point1 = new Point(69, 481);
    Point point36 = point1;
    btnSelect17_1.Location = point36;
    Button btnSelect17_2 = this.btnSelect17;
    padding1 = new Padding(4);
    Padding padding36 = padding1;
    btnSelect17_2.Margin = padding36;
    this.btnSelect17.Name = "btnSelect17";
    Button btnSelect17_3 = this.btnSelect17;
    size1 = new Size(111, 28);
    Size size36 = size1;
    btnSelect17_3.Size = size36;
    this.btnSelect17.TabIndex = 32 /*0x20*/;
    this.btnSelect17.Text = "Account List";
    this.btnSelect17.UseVisualStyleBackColor = true;
    Button btnSelect12_1 = this.btnSelect12;
    point1 = new Point(69, 336);
    Point point37 = point1;
    btnSelect12_1.Location = point37;
    Button btnSelect12_2 = this.btnSelect12;
    padding1 = new Padding(4);
    Padding padding37 = padding1;
    btnSelect12_2.Margin = padding37;
    this.btnSelect12.Name = "btnSelect12";
    Button btnSelect12_3 = this.btnSelect12;
    size1 = new Size(111, 28);
    Size size37 = size1;
    btnSelect12_3.Size = size37;
    this.btnSelect12.TabIndex = 22;
    this.btnSelect12.Text = "Account List";
    this.btnSelect12.UseVisualStyleBackColor = true;
    Button btnSelect11_1 = this.btnSelect11;
    point1 = new Point(69, 308);
    Point point38 = point1;
    btnSelect11_1.Location = point38;
    Button btnSelect11_2 = this.btnSelect11;
    padding1 = new Padding(4);
    Padding padding38 = padding1;
    btnSelect11_2.Margin = padding38;
    this.btnSelect11.Name = "btnSelect11";
    Button btnSelect11_3 = this.btnSelect11;
    size1 = new Size(111, 28);
    Size size38 = size1;
    btnSelect11_3.Size = size38;
    this.btnSelect11.TabIndex = 20;
    this.btnSelect11.Text = "Account List";
    this.btnSelect11.UseVisualStyleBackColor = true;
    Button btnSelect18_1 = this.btnSelect18;
    point1 = new Point(69, 510);
    Point point39 = point1;
    btnSelect18_1.Location = point39;
    Button btnSelect18_2 = this.btnSelect18;
    padding1 = new Padding(4);
    Padding padding39 = padding1;
    btnSelect18_2.Margin = padding39;
    this.btnSelect18.Name = "btnSelect18";
    Button btnSelect18_3 = this.btnSelect18;
    size1 = new Size(111, 28);
    Size size39 = size1;
    btnSelect18_3.Size = size39;
    this.btnSelect18.TabIndex = 34;
    this.btnSelect18.Text = "Account List";
    this.btnSelect18.UseVisualStyleBackColor = true;
    Button btnSelect6_1 = this.btnSelect6;
    point1 = new Point(69, 166);
    Point point40 = point1;
    btnSelect6_1.Location = point40;
    Button btnSelect6_2 = this.btnSelect6;
    padding1 = new Padding(4);
    Padding padding40 = padding1;
    btnSelect6_2.Margin = padding40;
    this.btnSelect6.Name = "btnSelect6";
    Button btnSelect6_3 = this.btnSelect6;
    size1 = new Size(111, 28);
    Size size40 = size1;
    btnSelect6_3.Size = size40;
    this.btnSelect6.TabIndex = 10;
    this.btnSelect6.Text = "Account List";
    this.btnSelect6.UseVisualStyleBackColor = true;
    this.Label26.AutoSize = true;
    Label label26_1 = this.Label26;
    point1 = new Point(41, 572);
    Point point41 = point1;
    label26_1.Location = point41;
    Label label26_2 = this.Label26;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding41 = padding1;
    label26_2.Margin = padding41;
    this.Label26.Name = "Label26";
    Label label26_3 = this.Label26;
    size1 = new Size(25, 16 /*0x10*/);
    Size size41 = size1;
    label26_3.Size = size41;
    this.Label26.TabIndex = 78;
    this.Label26.Text = "20.";
    Button btnSelect5_1 = this.btnSelect5;
    point1 = new Point(69, 137);
    Point point42 = point1;
    btnSelect5_1.Location = point42;
    Button btnSelect5_2 = this.btnSelect5;
    padding1 = new Padding(4);
    Padding padding42 = padding1;
    btnSelect5_2.Margin = padding42;
    this.btnSelect5.Name = "btnSelect5";
    Button btnSelect5_3 = this.btnSelect5;
    size1 = new Size(111, 28);
    Size size42 = size1;
    btnSelect5_3.Size = size42;
    this.btnSelect5.TabIndex = 8;
    this.btnSelect5.Text = "Account List";
    this.btnSelect5.UseVisualStyleBackColor = true;
    this.Label6.AutoSize = true;
    Label label6_1 = this.Label6;
    point1 = new Point(49, 86);
    Point point43 = point1;
    label6_1.Location = point43;
    Label label6_2 = this.Label6;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding43 = padding1;
    label6_2.Margin = padding43;
    this.Label6.Name = "Label6";
    Label label6_3 = this.Label6;
    size1 = new Size(18, 16 /*0x10*/);
    Size size43 = size1;
    label6_3.Size = size43;
    this.Label6.TabIndex = 17;
    this.Label6.Text = "3.";
    TextBox txtShname1_1 = this.txtShname1;
    point1 = new Point(188, 26);
    Point point44 = point1;
    txtShname1_1.Location = point44;
    TextBox txtShname1_2 = this.txtShname1;
    padding1 = new Padding(4);
    Padding padding44 = padding1;
    txtShname1_2.Margin = padding44;
    this.txtShname1.MaxLength = 10;
    this.txtShname1.Name = "txtShname1";
    TextBox txtShname1_3 = this.txtShname1;
    size1 = new Size(143, 22);
    Size size44 = size1;
    txtShname1_3.Size = size44;
    this.txtShname1.TabIndex = 1;
    this.lblName1.AutoSize = true;
    Label lblName1_1 = this.lblName1;
    point1 = new Point(338, 30);
    Point point45 = point1;
    lblName1_1.Location = point45;
    Label lblName1_2 = this.lblName1;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding45 = padding1;
    lblName1_2.Margin = padding45;
    this.lblName1.Name = "lblName1";
    Label lblName1_3 = this.lblName1;
    size1 = new Size(12, 16 /*0x10*/);
    Size size45 = size1;
    lblName1_3.Size = size45;
    this.lblName1.TabIndex = 13;
    this.lblName1.Text = "-";
    TextBox txtShname2_1 = this.txtShname2;
    point1 = new Point(188, 54);
    Point point46 = point1;
    txtShname2_1.Location = point46;
    TextBox txtShname2_2 = this.txtShname2;
    padding1 = new Padding(4);
    Padding padding46 = padding1;
    txtShname2_2.Margin = padding46;
    this.txtShname2.MaxLength = 10;
    this.txtShname2.Name = "txtShname2";
    TextBox txtShname2_3 = this.txtShname2;
    size1 = new Size(143, 22);
    Size size46 = size1;
    txtShname2_3.Size = size46;
    this.txtShname2.TabIndex = 3;
    this.lblName2.AutoSize = true;
    Label lblName2_1 = this.lblName2;
    point1 = new Point(338, 58);
    Point point47 = point1;
    lblName2_1.Location = point47;
    Label lblName2_2 = this.lblName2;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding47 = padding1;
    lblName2_2.Margin = padding47;
    this.lblName2.Name = "lblName2";
    Label lblName2_3 = this.lblName2;
    size1 = new Size(12, 16 /*0x10*/);
    Size size47 = size1;
    lblName2_3.Size = size47;
    this.lblName2.TabIndex = 16 /*0x10*/;
    this.lblName2.Text = "-";
    TextBox txtShname3_1 = this.txtShname3;
    point1 = new Point(188, 82);
    Point point48 = point1;
    txtShname3_1.Location = point48;
    TextBox txtShname3_2 = this.txtShname3;
    padding1 = new Padding(4);
    Padding padding48 = padding1;
    txtShname3_2.Margin = padding48;
    this.txtShname3.MaxLength = 10;
    this.txtShname3.Name = "txtShname3";
    TextBox txtShname3_3 = this.txtShname3;
    size1 = new Size(143, 22);
    Size size48 = size1;
    txtShname3_3.Size = size48;
    this.txtShname3.TabIndex = 5;
    this.lblName3.AutoSize = true;
    Label lblName3_1 = this.lblName3;
    point1 = new Point(338, 86);
    Point point49 = point1;
    lblName3_1.Location = point49;
    Label lblName3_2 = this.lblName3;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding49 = padding1;
    lblName3_2.Margin = padding49;
    this.lblName3.Name = "lblName3";
    Label lblName3_3 = this.lblName3;
    size1 = new Size(12, 16 /*0x10*/);
    Size size49 = size1;
    lblName3_3.Size = size49;
    this.lblName3.TabIndex = 19;
    this.lblName3.Text = "-";
    TextBox txtShname4_1 = this.txtShname4;
    point1 = new Point(188, 111);
    Point point50 = point1;
    txtShname4_1.Location = point50;
    TextBox txtShname4_2 = this.txtShname4;
    padding1 = new Padding(4);
    Padding padding50 = padding1;
    txtShname4_2.Margin = padding50;
    this.txtShname4.MaxLength = 10;
    this.txtShname4.Name = "txtShname4";
    TextBox txtShname4_3 = this.txtShname4;
    size1 = new Size(143, 22);
    Size size50 = size1;
    txtShname4_3.Size = size50;
    this.txtShname4.TabIndex = 7;
    this.lblName4.AutoSize = true;
    Label lblName4_1 = this.lblName4;
    point1 = new Point(338, 114);
    Point point51 = point1;
    lblName4_1.Location = point51;
    Label lblName4_2 = this.lblName4;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding51 = padding1;
    lblName4_2.Margin = padding51;
    this.lblName4.Name = "lblName4";
    Label lblName4_3 = this.lblName4;
    size1 = new Size(12, 16 /*0x10*/);
    Size size51 = size1;
    lblName4_3.Size = size51;
    this.lblName4.TabIndex = 22;
    this.lblName4.Text = "-";
    TextBox txtShname5_1 = this.txtShname5;
    point1 = new Point(188, 139);
    Point point52 = point1;
    txtShname5_1.Location = point52;
    TextBox txtShname5_2 = this.txtShname5;
    padding1 = new Padding(4);
    Padding padding52 = padding1;
    txtShname5_2.Margin = padding52;
    this.txtShname5.MaxLength = 10;
    this.txtShname5.Name = "txtShname5";
    TextBox txtShname5_3 = this.txtShname5;
    size1 = new Size(143, 22);
    Size size52 = size1;
    txtShname5_3.Size = size52;
    this.txtShname5.TabIndex = 9;
    this.lblName5.AutoSize = true;
    Label lblName5_1 = this.lblName5;
    point1 = new Point(338, 143);
    Point point53 = point1;
    lblName5_1.Location = point53;
    Label lblName5_2 = this.lblName5;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding53 = padding1;
    lblName5_2.Margin = padding53;
    this.lblName5.Name = "lblName5";
    Label lblName5_3 = this.lblName5;
    size1 = new Size(12, 16 /*0x10*/);
    Size size53 = size1;
    lblName5_3.Size = size53;
    this.lblName5.TabIndex = 25;
    this.lblName5.Text = "-";
    TextBox txtShname6_1 = this.txtShname6;
    point1 = new Point(188, 169);
    Point point54 = point1;
    txtShname6_1.Location = point54;
    TextBox txtShname6_2 = this.txtShname6;
    padding1 = new Padding(4);
    Padding padding54 = padding1;
    txtShname6_2.Margin = padding54;
    this.txtShname6.MaxLength = 10;
    this.txtShname6.Name = "txtShname6";
    TextBox txtShname6_3 = this.txtShname6;
    size1 = new Size(143, 22);
    Size size54 = size1;
    txtShname6_3.Size = size54;
    this.txtShname6.TabIndex = 11;
    this.lblName6.AutoSize = true;
    Label lblName6_1 = this.lblName6;
    point1 = new Point(338, 172);
    Point point55 = point1;
    lblName6_1.Location = point55;
    Label lblName6_2 = this.lblName6;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding55 = padding1;
    lblName6_2.Margin = padding55;
    this.lblName6.Name = "lblName6";
    Label lblName6_3 = this.lblName6;
    size1 = new Size(12, 16 /*0x10*/);
    Size size55 = size1;
    lblName6_3.Size = size55;
    this.lblName6.TabIndex = 28;
    this.lblName6.Text = "-";
    TextBox txtShname7_1 = this.txtShname7;
    point1 = new Point(188, 197);
    Point point56 = point1;
    txtShname7_1.Location = point56;
    TextBox txtShname7_2 = this.txtShname7;
    padding1 = new Padding(4);
    Padding padding56 = padding1;
    txtShname7_2.Margin = padding56;
    this.txtShname7.MaxLength = 10;
    this.txtShname7.Name = "txtShname7";
    TextBox txtShname7_3 = this.txtShname7;
    size1 = new Size(143, 22);
    Size size56 = size1;
    txtShname7_3.Size = size56;
    this.txtShname7.TabIndex = 13;
    this.lblName7.AutoSize = true;
    Label lblName7_1 = this.lblName7;
    point1 = new Point(338, 201);
    Point point57 = point1;
    lblName7_1.Location = point57;
    Label lblName7_2 = this.lblName7;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding57 = padding1;
    lblName7_2.Margin = padding57;
    this.lblName7.Name = "lblName7";
    Label lblName7_3 = this.lblName7;
    size1 = new Size(12, 16 /*0x10*/);
    Size size57 = size1;
    lblName7_3.Size = size57;
    this.lblName7.TabIndex = 31 /*0x1F*/;
    this.lblName7.Text = "-";
    TextBox txtShname8_1 = this.txtShname8;
    point1 = new Point(188, 225);
    Point point58 = point1;
    txtShname8_1.Location = point58;
    TextBox txtShname8_2 = this.txtShname8;
    padding1 = new Padding(4);
    Padding padding58 = padding1;
    txtShname8_2.Margin = padding58;
    this.txtShname8.MaxLength = 10;
    this.txtShname8.Name = "txtShname8";
    TextBox txtShname8_3 = this.txtShname8;
    size1 = new Size(143, 22);
    Size size58 = size1;
    txtShname8_3.Size = size58;
    this.txtShname8.TabIndex = 15;
    this.lblName8.AutoSize = true;
    Label lblName8_1 = this.lblName8;
    point1 = new Point(338, 229);
    Point point59 = point1;
    lblName8_1.Location = point59;
    Label lblName8_2 = this.lblName8;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding59 = padding1;
    lblName8_2.Margin = padding59;
    this.lblName8.Name = "lblName8";
    Label lblName8_3 = this.lblName8;
    size1 = new Size(12, 16 /*0x10*/);
    Size size59 = size1;
    lblName8_3.Size = size59;
    this.lblName8.TabIndex = 34;
    this.lblName8.Text = "-";
    TextBox txtShname9_1 = this.txtShname9;
    point1 = new Point(188, 254);
    Point point60 = point1;
    txtShname9_1.Location = point60;
    TextBox txtShname9_2 = this.txtShname9;
    padding1 = new Padding(4);
    Padding padding60 = padding1;
    txtShname9_2.Margin = padding60;
    this.txtShname9.MaxLength = 10;
    this.txtShname9.Name = "txtShname9";
    TextBox txtShname9_3 = this.txtShname9;
    size1 = new Size(143, 22);
    Size size60 = size1;
    txtShname9_3.Size = size60;
    this.txtShname9.TabIndex = 17;
    this.lblName9.AutoSize = true;
    Label lblName9_1 = this.lblName9;
    point1 = new Point(338, 257);
    Point point61 = point1;
    lblName9_1.Location = point61;
    Label lblName9_2 = this.lblName9;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding61 = padding1;
    lblName9_2.Margin = padding61;
    this.lblName9.Name = "lblName9";
    Label lblName9_3 = this.lblName9;
    size1 = new Size(12, 16 /*0x10*/);
    Size size61 = size1;
    lblName9_3.Size = size61;
    this.lblName9.TabIndex = 37;
    this.lblName9.Text = "-";
    TextBox txtShname10_1 = this.txtShname10;
    point1 = new Point(188, 282);
    Point point62 = point1;
    txtShname10_1.Location = point62;
    TextBox txtShname10_2 = this.txtShname10;
    padding1 = new Padding(4);
    Padding padding62 = padding1;
    txtShname10_2.Margin = padding62;
    this.txtShname10.MaxLength = 10;
    this.txtShname10.Name = "txtShname10";
    TextBox txtShname10_3 = this.txtShname10;
    size1 = new Size(143, 22);
    Size size62 = size1;
    txtShname10_3.Size = size62;
    this.txtShname10.TabIndex = 19;
    this.lblName10.AutoSize = true;
    Label lblName10_1 = this.lblName10;
    point1 = new Point(338, 286);
    Point point63 = point1;
    lblName10_1.Location = point63;
    Label lblName10_2 = this.lblName10;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding63 = padding1;
    lblName10_2.Margin = padding63;
    this.lblName10.Name = "lblName10";
    Label lblName10_3 = this.lblName10;
    size1 = new Size(12, 16 /*0x10*/);
    Size size63 = size1;
    lblName10_3.Size = size63;
    this.lblName10.TabIndex = 40;
    this.lblName10.Text = "-";
    TextBox txtShname11_1 = this.txtShname11;
    point1 = new Point(188, 310);
    Point point64 = point1;
    txtShname11_1.Location = point64;
    TextBox txtShname11_2 = this.txtShname11;
    padding1 = new Padding(4);
    Padding padding64 = padding1;
    txtShname11_2.Margin = padding64;
    this.txtShname11.MaxLength = 10;
    this.txtShname11.Name = "txtShname11";
    TextBox txtShname11_3 = this.txtShname11;
    size1 = new Size(143, 22);
    Size size64 = size1;
    txtShname11_3.Size = size64;
    this.txtShname11.TabIndex = 21;
    this.lblName11.AutoSize = true;
    Label lblName11_1 = this.lblName11;
    point1 = new Point(338, 314);
    Point point65 = point1;
    lblName11_1.Location = point65;
    Label lblName11_2 = this.lblName11;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding65 = padding1;
    lblName11_2.Margin = padding65;
    this.lblName11.Name = "lblName11";
    Label lblName11_3 = this.lblName11;
    size1 = new Size(12, 16 /*0x10*/);
    Size size65 = size1;
    lblName11_3.Size = size65;
    this.lblName11.TabIndex = 43;
    this.lblName11.Text = "-";
    TextBox txtShname12_1 = this.txtShname12;
    point1 = new Point(188, 338);
    Point point66 = point1;
    txtShname12_1.Location = point66;
    TextBox txtShname12_2 = this.txtShname12;
    padding1 = new Padding(4);
    Padding padding66 = padding1;
    txtShname12_2.Margin = padding66;
    this.txtShname12.MaxLength = 10;
    this.txtShname12.Name = "txtShname12";
    TextBox txtShname12_3 = this.txtShname12;
    size1 = new Size(143, 22);
    Size size66 = size1;
    txtShname12_3.Size = size66;
    this.txtShname12.TabIndex = 23;
    this.lblName12.AutoSize = true;
    Label lblName12_1 = this.lblName12;
    point1 = new Point(338, 342);
    Point point67 = point1;
    lblName12_1.Location = point67;
    Label lblName12_2 = this.lblName12;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding67 = padding1;
    lblName12_2.Margin = padding67;
    this.lblName12.Name = "lblName12";
    Label lblName12_3 = this.lblName12;
    size1 = new Size(12, 16 /*0x10*/);
    Size size67 = size1;
    lblName12_3.Size = size67;
    this.lblName12.TabIndex = 56;
    this.lblName12.Text = "-";
    TextBox txtShname13_1 = this.txtShname13;
    point1 = new Point(188, 368);
    Point point68 = point1;
    txtShname13_1.Location = point68;
    TextBox txtShname13_2 = this.txtShname13;
    padding1 = new Padding(4);
    Padding padding68 = padding1;
    txtShname13_2.Margin = padding68;
    this.txtShname13.MaxLength = 10;
    this.txtShname13.Name = "txtShname13";
    TextBox txtShname13_3 = this.txtShname13;
    size1 = new Size(143, 22);
    Size size68 = size1;
    txtShname13_3.Size = size68;
    this.txtShname13.TabIndex = 25;
    this.lblName13.AutoSize = true;
    Label lblName13_1 = this.lblName13;
    point1 = new Point(338, 372);
    Point point69 = point1;
    lblName13_1.Location = point69;
    Label lblName13_2 = this.lblName13;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding69 = padding1;
    lblName13_2.Margin = padding69;
    this.lblName13.Name = "lblName13";
    Label lblName13_3 = this.lblName13;
    size1 = new Size(12, 16 /*0x10*/);
    Size size69 = size1;
    lblName13_3.Size = size69;
    this.lblName13.TabIndex = 59;
    this.lblName13.Text = "-";
    TextBox txtShname14_1 = this.txtShname14;
    point1 = new Point(188, 398);
    Point point70 = point1;
    txtShname14_1.Location = point70;
    TextBox txtShname14_2 = this.txtShname14;
    padding1 = new Padding(4);
    Padding padding70 = padding1;
    txtShname14_2.Margin = padding70;
    this.txtShname14.MaxLength = 10;
    this.txtShname14.Name = "txtShname14";
    TextBox txtShname14_3 = this.txtShname14;
    size1 = new Size(143, 22);
    Size size70 = size1;
    txtShname14_3.Size = size70;
    this.txtShname14.TabIndex = 27;
    this.lblName14.AutoSize = true;
    Label lblName14_1 = this.lblName14;
    point1 = new Point(338, 401);
    Point point71 = point1;
    lblName14_1.Location = point71;
    Label lblName14_2 = this.lblName14;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding71 = padding1;
    lblName14_2.Margin = padding71;
    this.lblName14.Name = "lblName14";
    Label lblName14_3 = this.lblName14;
    size1 = new Size(12, 16 /*0x10*/);
    Size size71 = size1;
    lblName14_3.Size = size71;
    this.lblName14.TabIndex = 62;
    this.lblName14.Text = "-";
    TextBox txtShname15_1 = this.txtShname15;
    point1 = new Point(188, 427);
    Point point72 = point1;
    txtShname15_1.Location = point72;
    TextBox txtShname15_2 = this.txtShname15;
    padding1 = new Padding(4);
    Padding padding72 = padding1;
    txtShname15_2.Margin = padding72;
    this.txtShname15.MaxLength = 10;
    this.txtShname15.Name = "txtShname15";
    TextBox txtShname15_3 = this.txtShname15;
    size1 = new Size(143, 22);
    Size size72 = size1;
    txtShname15_3.Size = size72;
    this.txtShname15.TabIndex = 29;
    this.lblName15.AutoSize = true;
    Label lblName15_1 = this.lblName15;
    point1 = new Point(338, 431);
    Point point73 = point1;
    lblName15_1.Location = point73;
    Label lblName15_2 = this.lblName15;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding73 = padding1;
    lblName15_2.Margin = padding73;
    this.lblName15.Name = "lblName15";
    Label lblName15_3 = this.lblName15;
    size1 = new Size(12, 16 /*0x10*/);
    Size size73 = size1;
    lblName15_3.Size = size73;
    this.lblName15.TabIndex = 65;
    this.lblName15.Text = "-";
    TextBox txtShname16_1 = this.txtShname16;
    point1 = new Point(188, 455);
    Point point74 = point1;
    txtShname16_1.Location = point74;
    TextBox txtShname16_2 = this.txtShname16;
    padding1 = new Padding(4);
    Padding padding74 = padding1;
    txtShname16_2.Margin = padding74;
    this.txtShname16.MaxLength = 10;
    this.txtShname16.Name = "txtShname16";
    TextBox txtShname16_3 = this.txtShname16;
    size1 = new Size(143, 22);
    Size size74 = size1;
    txtShname16_3.Size = size74;
    this.txtShname16.TabIndex = 31 /*0x1F*/;
    this.lblName16.AutoSize = true;
    Label lblName16_1 = this.lblName16;
    point1 = new Point(338, 459);
    Point point75 = point1;
    lblName16_1.Location = point75;
    Label lblName16_2 = this.lblName16;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding75 = padding1;
    lblName16_2.Margin = padding75;
    this.lblName16.Name = "lblName16";
    Label lblName16_3 = this.lblName16;
    size1 = new Size(12, 16 /*0x10*/);
    Size size75 = size1;
    lblName16_3.Size = size75;
    this.lblName16.TabIndex = 68;
    this.lblName16.Text = "-";
    TextBox txtShname17_1 = this.txtShname17;
    point1 = new Point(188, 484);
    Point point76 = point1;
    txtShname17_1.Location = point76;
    TextBox txtShname17_2 = this.txtShname17;
    padding1 = new Padding(4);
    Padding padding76 = padding1;
    txtShname17_2.Margin = padding76;
    this.txtShname17.MaxLength = 10;
    this.txtShname17.Name = "txtShname17";
    TextBox txtShname17_3 = this.txtShname17;
    size1 = new Size(143, 22);
    Size size76 = size1;
    txtShname17_3.Size = size76;
    this.txtShname17.TabIndex = 33;
    this.lblName17.AutoSize = true;
    Label lblName17_1 = this.lblName17;
    point1 = new Point(338, 487);
    Point point77 = point1;
    lblName17_1.Location = point77;
    Label lblName17_2 = this.lblName17;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding77 = padding1;
    lblName17_2.Margin = padding77;
    this.lblName17.Name = "lblName17";
    Label lblName17_3 = this.lblName17;
    size1 = new Size(12, 16 /*0x10*/);
    Size size77 = size1;
    lblName17_3.Size = size77;
    this.lblName17.TabIndex = 71;
    this.lblName17.Text = "-";
    TextBox txtShname18_1 = this.txtShname18;
    point1 = new Point(188, 512 /*0x0200*/);
    Point point78 = point1;
    txtShname18_1.Location = point78;
    TextBox txtShname18_2 = this.txtShname18;
    padding1 = new Padding(4);
    Padding padding78 = padding1;
    txtShname18_2.Margin = padding78;
    this.txtShname18.MaxLength = 10;
    this.txtShname18.Name = "txtShname18";
    TextBox txtShname18_3 = this.txtShname18;
    size1 = new Size(143, 22);
    Size size78 = size1;
    txtShname18_3.Size = size78;
    this.txtShname18.TabIndex = 35;
    this.lblName18.AutoSize = true;
    Label lblName18_1 = this.lblName18;
    point1 = new Point(338, 516);
    Point point79 = point1;
    lblName18_1.Location = point79;
    Label lblName18_2 = this.lblName18;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding79 = padding1;
    lblName18_2.Margin = padding79;
    this.lblName18.Name = "lblName18";
    Label lblName18_3 = this.lblName18;
    size1 = new Size(12, 16 /*0x10*/);
    Size size79 = size1;
    lblName18_3.Size = size79;
    this.lblName18.TabIndex = 74;
    this.lblName18.Text = "-";
    TextBox txtShname19_1 = this.txtShname19;
    point1 = new Point(188, 540);
    Point point80 = point1;
    txtShname19_1.Location = point80;
    TextBox txtShname19_2 = this.txtShname19;
    padding1 = new Padding(4);
    Padding padding80 = padding1;
    txtShname19_2.Margin = padding80;
    this.txtShname19.MaxLength = 10;
    this.txtShname19.Name = "txtShname19";
    TextBox txtShname19_3 = this.txtShname19;
    size1 = new Size(143, 22);
    Size size80 = size1;
    txtShname19_3.Size = size80;
    this.txtShname19.TabIndex = 37;
    this.lblName19.AutoSize = true;
    Label lblName19_1 = this.lblName19;
    point1 = new Point(338, 544);
    Point point81 = point1;
    lblName19_1.Location = point81;
    Label lblName19_2 = this.lblName19;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding81 = padding1;
    lblName19_2.Margin = padding81;
    this.lblName19.Name = "lblName19";
    Label lblName19_3 = this.lblName19;
    size1 = new Size(12, 16 /*0x10*/);
    Size size81 = size1;
    lblName19_3.Size = size81;
    this.lblName19.TabIndex = 77;
    this.lblName19.Text = "-";
    TextBox txtShname20_1 = this.txtShname20;
    point1 = new Point(188, 569);
    Point point82 = point1;
    txtShname20_1.Location = point82;
    TextBox txtShname20_2 = this.txtShname20;
    padding1 = new Padding(4);
    Padding padding82 = padding1;
    txtShname20_2.Margin = padding82;
    this.txtShname20.MaxLength = 10;
    this.txtShname20.Name = "txtShname20";
    TextBox txtShname20_3 = this.txtShname20;
    size1 = new Size(143, 22);
    Size size82 = size1;
    txtShname20_3.Size = size82;
    this.txtShname20.TabIndex = 39;
    this.lblName20.AutoSize = true;
    Label lblName20_1 = this.lblName20;
    point1 = new Point(338, 572);
    Point point83 = point1;
    lblName20_1.Location = point83;
    Label lblName20_2 = this.lblName20;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding83 = padding1;
    lblName20_2.Margin = padding83;
    this.lblName20.Name = "lblName20";
    Label lblName20_3 = this.lblName20;
    size1 = new Size(12, 16 /*0x10*/);
    Size size83 = size1;
    lblName20_3.Size = size83;
    this.lblName20.TabIndex = 80 /*0x50*/;
    this.lblName20.Text = "-";
    TextBox txtShname21_1 = this.txtShname21;
    point1 = new Point(188, 597);
    Point point84 = point1;
    txtShname21_1.Location = point84;
    TextBox txtShname21_2 = this.txtShname21;
    padding1 = new Padding(4);
    Padding padding84 = padding1;
    txtShname21_2.Margin = padding84;
    this.txtShname21.MaxLength = 10;
    this.txtShname21.Name = "txtShname21";
    TextBox txtShname21_3 = this.txtShname21;
    size1 = new Size(143, 22);
    Size size84 = size1;
    txtShname21_3.Size = size84;
    this.txtShname21.TabIndex = 41;
    this.lblName21.AutoSize = true;
    Label lblName21_1 = this.lblName21;
    point1 = new Point(338, 601);
    Point point85 = point1;
    lblName21_1.Location = point85;
    Label lblName21_2 = this.lblName21;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding85 = padding1;
    lblName21_2.Margin = padding85;
    this.lblName21.Name = "lblName21";
    Label lblName21_3 = this.lblName21;
    size1 = new Size(12, 16 /*0x10*/);
    Size size85 = size1;
    lblName21_3.Size = size85;
    this.lblName21.TabIndex = 83;
    this.lblName21.Text = "-";
    Button btnExit1 = this.btnExit;
    point1 = new Point(490, 628);
    Point point86 = point1;
    btnExit1.Location = point86;
    Button btnExit2 = this.btnExit;
    padding1 = new Padding(4);
    Padding padding86 = padding1;
    btnExit2.Margin = padding86;
    this.btnExit.Name = "btnExit";
    Button btnExit3 = this.btnExit;
    size1 = new Size(132, 41);
    Size size86 = size1;
    btnExit3.Size = size86;
    this.btnExit.TabIndex = 43;
    this.btnExit.Text = "E&xit";
    this.btnExit.UseVisualStyleBackColor = true;
    Button btnUpdate1 = this.btnUpdate;
    point1 = new Point(350, 628);
    Point point87 = point1;
    btnUpdate1.Location = point87;
    Button btnUpdate2 = this.btnUpdate;
    padding1 = new Padding(4);
    Padding padding87 = padding1;
    btnUpdate2.Margin = padding87;
    this.btnUpdate.Name = "btnUpdate";
    Button btnUpdate3 = this.btnUpdate;
    size1 = new Size(132, 41);
    Size size87 = size1;
    btnUpdate3.Size = size87;
    this.btnUpdate.TabIndex = 42;
    this.btnUpdate.Text = "&Update";
    this.btnUpdate.UseVisualStyleBackColor = true;
    TextBox txtCode21_1 = this.txtCode21;
    point1 = new Point(29, 599);
    Point point88 = point1;
    txtCode21_1.Location = point88;
    TextBox txtCode21_2 = this.txtCode21;
    padding1 = new Padding(4);
    Padding padding88 = padding1;
    txtCode21_2.Margin = padding88;
    this.txtCode21.Name = "txtCode21";
    TextBox txtCode21_3 = this.txtCode21;
    size1 = new Size(40, 22);
    Size size88 = size1;
    txtCode21_3.Size = size88;
    this.txtCode21.TabIndex = 106;
    TextBox txtCode20_1 = this.txtCode20;
    point1 = new Point(29, 571);
    Point point89 = point1;
    txtCode20_1.Location = point89;
    TextBox txtCode20_2 = this.txtCode20;
    padding1 = new Padding(4);
    Padding padding89 = padding1;
    txtCode20_2.Margin = padding89;
    this.txtCode20.Name = "txtCode20";
    TextBox txtCode20_3 = this.txtCode20;
    size1 = new Size(40, 22);
    Size size89 = size1;
    txtCode20_3.Size = size89;
    this.txtCode20.TabIndex = 105;
    TextBox txtCode19_1 = this.txtCode19;
    point1 = new Point(29, 543);
    Point point90 = point1;
    txtCode19_1.Location = point90;
    TextBox txtCode19_2 = this.txtCode19;
    padding1 = new Padding(4);
    Padding padding90 = padding1;
    txtCode19_2.Margin = padding90;
    this.txtCode19.Name = "txtCode19";
    TextBox txtCode19_3 = this.txtCode19;
    size1 = new Size(40, 22);
    Size size90 = size1;
    txtCode19_3.Size = size90;
    this.txtCode19.TabIndex = 104;
    TextBox txtCode18_1 = this.txtCode18;
    point1 = new Point(29, 514);
    Point point91 = point1;
    txtCode18_1.Location = point91;
    TextBox txtCode18_2 = this.txtCode18;
    padding1 = new Padding(4);
    Padding padding91 = padding1;
    txtCode18_2.Margin = padding91;
    this.txtCode18.Name = "txtCode18";
    TextBox txtCode18_3 = this.txtCode18;
    size1 = new Size(40, 22);
    Size size91 = size1;
    txtCode18_3.Size = size91;
    this.txtCode18.TabIndex = 103;
    TextBox txtCode17_1 = this.txtCode17;
    point1 = new Point(29, 486);
    Point point92 = point1;
    txtCode17_1.Location = point92;
    TextBox txtCode17_2 = this.txtCode17;
    padding1 = new Padding(4);
    Padding padding92 = padding1;
    txtCode17_2.Margin = padding92;
    this.txtCode17.Name = "txtCode17";
    TextBox txtCode17_3 = this.txtCode17;
    size1 = new Size(40, 22);
    Size size92 = size1;
    txtCode17_3.Size = size92;
    this.txtCode17.TabIndex = 102;
    TextBox txtCode16_1 = this.txtCode16;
    point1 = new Point(29, 458);
    Point point93 = point1;
    txtCode16_1.Location = point93;
    TextBox txtCode16_2 = this.txtCode16;
    padding1 = new Padding(4);
    Padding padding93 = padding1;
    txtCode16_2.Margin = padding93;
    this.txtCode16.Name = "txtCode16";
    TextBox txtCode16_3 = this.txtCode16;
    size1 = new Size(40, 22);
    Size size93 = size1;
    txtCode16_3.Size = size93;
    this.txtCode16.TabIndex = 101;
    TextBox txtCode15_1 = this.txtCode15;
    point1 = new Point(29, 430);
    Point point94 = point1;
    txtCode15_1.Location = point94;
    TextBox txtCode15_2 = this.txtCode15;
    padding1 = new Padding(4);
    Padding padding94 = padding1;
    txtCode15_2.Margin = padding94;
    this.txtCode15.Name = "txtCode15";
    TextBox txtCode15_3 = this.txtCode15;
    size1 = new Size(40, 22);
    Size size94 = size1;
    txtCode15_3.Size = size94;
    this.txtCode15.TabIndex = 100;
    TextBox txtCode14_1 = this.txtCode14;
    point1 = new Point(29, 400);
    Point point95 = point1;
    txtCode14_1.Location = point95;
    TextBox txtCode14_2 = this.txtCode14;
    padding1 = new Padding(4);
    Padding padding95 = padding1;
    txtCode14_2.Margin = padding95;
    this.txtCode14.Name = "txtCode14";
    TextBox txtCode14_3 = this.txtCode14;
    size1 = new Size(40, 22);
    Size size95 = size1;
    txtCode14_3.Size = size95;
    this.txtCode14.TabIndex = 99;
    TextBox txtCode13_1 = this.txtCode13;
    point1 = new Point(29, 370);
    Point point96 = point1;
    txtCode13_1.Location = point96;
    TextBox txtCode13_2 = this.txtCode13;
    padding1 = new Padding(4);
    Padding padding96 = padding1;
    txtCode13_2.Margin = padding96;
    this.txtCode13.Name = "txtCode13";
    TextBox txtCode13_3 = this.txtCode13;
    size1 = new Size(40, 22);
    Size size96 = size1;
    txtCode13_3.Size = size96;
    this.txtCode13.TabIndex = 98;
    TextBox txtCode12_1 = this.txtCode12;
    point1 = new Point(29, 341);
    Point point97 = point1;
    txtCode12_1.Location = point97;
    TextBox txtCode12_2 = this.txtCode12;
    padding1 = new Padding(4);
    Padding padding97 = padding1;
    txtCode12_2.Margin = padding97;
    this.txtCode12.Name = "txtCode12";
    TextBox txtCode12_3 = this.txtCode12;
    size1 = new Size(40, 22);
    Size size97 = size1;
    txtCode12_3.Size = size97;
    this.txtCode12.TabIndex = 97;
    TextBox txtCode11_1 = this.txtCode11;
    point1 = new Point(29, 313);
    Point point98 = point1;
    txtCode11_1.Location = point98;
    TextBox txtCode11_2 = this.txtCode11;
    padding1 = new Padding(4);
    Padding padding98 = padding1;
    txtCode11_2.Margin = padding98;
    this.txtCode11.Name = "txtCode11";
    TextBox txtCode11_3 = this.txtCode11;
    size1 = new Size(40, 22);
    Size size98 = size1;
    txtCode11_3.Size = size98;
    this.txtCode11.TabIndex = 96 /*0x60*/;
    TextBox txtCode10_1 = this.txtCode10;
    point1 = new Point(29, 284);
    Point point99 = point1;
    txtCode10_1.Location = point99;
    TextBox txtCode10_2 = this.txtCode10;
    padding1 = new Padding(4);
    Padding padding99 = padding1;
    txtCode10_2.Margin = padding99;
    this.txtCode10.Name = "txtCode10";
    TextBox txtCode10_3 = this.txtCode10;
    size1 = new Size(40, 22);
    Size size99 = size1;
    txtCode10_3.Size = size99;
    this.txtCode10.TabIndex = 95;
    TextBox txtCode9_1 = this.txtCode9;
    point1 = new Point(29, 256 /*0x0100*/);
    Point point100 = point1;
    txtCode9_1.Location = point100;
    TextBox txtCode9_2 = this.txtCode9;
    padding1 = new Padding(4);
    Padding padding100 = padding1;
    txtCode9_2.Margin = padding100;
    this.txtCode9.Name = "txtCode9";
    TextBox txtCode9_3 = this.txtCode9;
    size1 = new Size(40, 22);
    Size size100 = size1;
    txtCode9_3.Size = size100;
    this.txtCode9.TabIndex = 94;
    TextBox txtCode8_1 = this.txtCode8;
    point1 = new Point(29, 228);
    Point point101 = point1;
    txtCode8_1.Location = point101;
    TextBox txtCode8_2 = this.txtCode8;
    padding1 = new Padding(4);
    Padding padding101 = padding1;
    txtCode8_2.Margin = padding101;
    this.txtCode8.Name = "txtCode8";
    TextBox txtCode8_3 = this.txtCode8;
    size1 = new Size(40, 22);
    Size size101 = size1;
    txtCode8_3.Size = size101;
    this.txtCode8.TabIndex = 93;
    TextBox txtCode7_1 = this.txtCode7;
    point1 = new Point(29, 199);
    Point point102 = point1;
    txtCode7_1.Location = point102;
    TextBox txtCode7_2 = this.txtCode7;
    padding1 = new Padding(4);
    Padding padding102 = padding1;
    txtCode7_2.Margin = padding102;
    this.txtCode7.Name = "txtCode7";
    TextBox txtCode7_3 = this.txtCode7;
    size1 = new Size(40, 22);
    Size size102 = size1;
    txtCode7_3.Size = size102;
    this.txtCode7.TabIndex = 92;
    TextBox txtCode6_1 = this.txtCode6;
    point1 = new Point(29, 171);
    Point point103 = point1;
    txtCode6_1.Location = point103;
    TextBox txtCode6_2 = this.txtCode6;
    padding1 = new Padding(4);
    Padding padding103 = padding1;
    txtCode6_2.Margin = padding103;
    this.txtCode6.Name = "txtCode6";
    TextBox txtCode6_3 = this.txtCode6;
    size1 = new Size(40, 22);
    Size size103 = size1;
    txtCode6_3.Size = size103;
    this.txtCode6.TabIndex = 91;
    TextBox txtCode5_1 = this.txtCode5;
    point1 = new Point(29, 142);
    Point point104 = point1;
    txtCode5_1.Location = point104;
    TextBox txtCode5_2 = this.txtCode5;
    padding1 = new Padding(4);
    Padding padding104 = padding1;
    txtCode5_2.Margin = padding104;
    this.txtCode5.Name = "txtCode5";
    TextBox txtCode5_3 = this.txtCode5;
    size1 = new Size(40, 22);
    Size size104 = size1;
    txtCode5_3.Size = size104;
    this.txtCode5.TabIndex = 90;
    TextBox txtCode4_1 = this.txtCode4;
    point1 = new Point(29, 113);
    Point point105 = point1;
    txtCode4_1.Location = point105;
    TextBox txtCode4_2 = this.txtCode4;
    padding1 = new Padding(4);
    Padding padding105 = padding1;
    txtCode4_2.Margin = padding105;
    this.txtCode4.Name = "txtCode4";
    TextBox txtCode4_3 = this.txtCode4;
    size1 = new Size(40, 22);
    Size size105 = size1;
    txtCode4_3.Size = size105;
    this.txtCode4.TabIndex = 89;
    TextBox txtCode3_1 = this.txtCode3;
    point1 = new Point(29, 85);
    Point point106 = point1;
    txtCode3_1.Location = point106;
    TextBox txtCode3_2 = this.txtCode3;
    padding1 = new Padding(4);
    Padding padding106 = padding1;
    txtCode3_2.Margin = padding106;
    this.txtCode3.Name = "txtCode3";
    TextBox txtCode3_3 = this.txtCode3;
    size1 = new Size(40, 22);
    Size size106 = size1;
    txtCode3_3.Size = size106;
    this.txtCode3.TabIndex = 88;
    TextBox txtCode2_1 = this.txtCode2;
    point1 = new Point(29, 57);
    Point point107 = point1;
    txtCode2_1.Location = point107;
    TextBox txtCode2_2 = this.txtCode2;
    padding1 = new Padding(4);
    Padding padding107 = padding1;
    txtCode2_2.Margin = padding107;
    this.txtCode2.Name = "txtCode2";
    TextBox txtCode2_3 = this.txtCode2;
    size1 = new Size(40, 22);
    Size size107 = size1;
    txtCode2_3.Size = size107;
    this.txtCode2.TabIndex = 87;
    TextBox txtCode1_1 = this.txtCode1;
    point1 = new Point(29, 28);
    Point point108 = point1;
    txtCode1_1.Location = point108;
    TextBox txtCode1_2 = this.txtCode1;
    padding1 = new Padding(4);
    Padding padding108 = padding1;
    txtCode1_2.Margin = padding108;
    this.txtCode1.Name = "txtCode1";
    TextBox txtCode1_3 = this.txtCode1;
    size1 = new Size(40, 22);
    Size size108 = size1;
    txtCode1_3.Size = size108;
    this.txtCode1.TabIndex = 86;
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new Point(87, 388);
    Point point109 = point1;
    dataGridView1_1.Location = point109;
    DataGridView dataGridView1_2 = this.DataGridView1;
    padding1 = new Padding(4);
    Padding padding109 = padding1;
    dataGridView1_2.Margin = padding109;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_3 = this.DataGridView1;
    size1 = new Size(13, 12);
    Size size109 = size1;
    dataGridView1_3.Size = size109;
    this.DataGridView1.TabIndex = 107;
    this.lblAccCode21.AutoSize = true;
    Label lblAccCode21_1 = this.lblAccCode21;
    point1 = new Point(8, 599);
    Point point110 = point1;
    lblAccCode21_1.Location = point110;
    Label lblAccCode21_2 = this.lblAccCode21;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding110 = padding1;
    lblAccCode21_2.Margin = padding110;
    this.lblAccCode21.Name = "lblAccCode21";
    Label lblAccCode21_3 = this.lblAccCode21;
    size1 = new Size(12, 16 /*0x10*/);
    Size size110 = size1;
    lblAccCode21_3.Size = size110;
    this.lblAccCode21.TabIndex = 128 /*0x80*/;
    this.lblAccCode21.Text = "-";
    this.lblAccCode20.AutoSize = true;
    Label lblAccCode20_1 = this.lblAccCode20;
    point1 = new Point(8, 571);
    Point point111 = point1;
    lblAccCode20_1.Location = point111;
    Label lblAccCode20_2 = this.lblAccCode20;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding111 = padding1;
    lblAccCode20_2.Margin = padding111;
    this.lblAccCode20.Name = "lblAccCode20";
    Label lblAccCode20_3 = this.lblAccCode20;
    size1 = new Size(12, 16 /*0x10*/);
    Size size111 = size1;
    lblAccCode20_3.Size = size111;
    this.lblAccCode20.TabIndex = (int) sbyte.MaxValue;
    this.lblAccCode20.Text = "-";
    this.lblAccCode19.AutoSize = true;
    Label lblAccCode19_1 = this.lblAccCode19;
    point1 = new Point(8, 543);
    Point point112 = point1;
    lblAccCode19_1.Location = point112;
    Label lblAccCode19_2 = this.lblAccCode19;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding112 = padding1;
    lblAccCode19_2.Margin = padding112;
    this.lblAccCode19.Name = "lblAccCode19";
    Label lblAccCode19_3 = this.lblAccCode19;
    size1 = new Size(12, 16 /*0x10*/);
    Size size112 = size1;
    lblAccCode19_3.Size = size112;
    this.lblAccCode19.TabIndex = 126;
    this.lblAccCode19.Text = "-";
    this.lblAccCode18.AutoSize = true;
    Label lblAccCode18_1 = this.lblAccCode18;
    point1 = new Point(8, 514);
    Point point113 = point1;
    lblAccCode18_1.Location = point113;
    Label lblAccCode18_2 = this.lblAccCode18;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding113 = padding1;
    lblAccCode18_2.Margin = padding113;
    this.lblAccCode18.Name = "lblAccCode18";
    Label lblAccCode18_3 = this.lblAccCode18;
    size1 = new Size(12, 16 /*0x10*/);
    Size size113 = size1;
    lblAccCode18_3.Size = size113;
    this.lblAccCode18.TabIndex = 125;
    this.lblAccCode18.Text = "-";
    this.lblAccCode17.AutoSize = true;
    Label lblAccCode17_1 = this.lblAccCode17;
    point1 = new Point(8, 486);
    Point point114 = point1;
    lblAccCode17_1.Location = point114;
    Label lblAccCode17_2 = this.lblAccCode17;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding114 = padding1;
    lblAccCode17_2.Margin = padding114;
    this.lblAccCode17.Name = "lblAccCode17";
    Label lblAccCode17_3 = this.lblAccCode17;
    size1 = new Size(12, 16 /*0x10*/);
    Size size114 = size1;
    lblAccCode17_3.Size = size114;
    this.lblAccCode17.TabIndex = 124;
    this.lblAccCode17.Text = "-";
    this.lblAccCode16.AutoSize = true;
    Label lblAccCode16_1 = this.lblAccCode16;
    point1 = new Point(8, 458);
    Point point115 = point1;
    lblAccCode16_1.Location = point115;
    Label lblAccCode16_2 = this.lblAccCode16;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding115 = padding1;
    lblAccCode16_2.Margin = padding115;
    this.lblAccCode16.Name = "lblAccCode16";
    Label lblAccCode16_3 = this.lblAccCode16;
    size1 = new Size(12, 16 /*0x10*/);
    Size size115 = size1;
    lblAccCode16_3.Size = size115;
    this.lblAccCode16.TabIndex = 123;
    this.lblAccCode16.Text = "-";
    this.lblAccCode15.AutoSize = true;
    Label lblAccCode15_1 = this.lblAccCode15;
    point1 = new Point(8, 430);
    Point point116 = point1;
    lblAccCode15_1.Location = point116;
    Label lblAccCode15_2 = this.lblAccCode15;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding116 = padding1;
    lblAccCode15_2.Margin = padding116;
    this.lblAccCode15.Name = "lblAccCode15";
    Label lblAccCode15_3 = this.lblAccCode15;
    size1 = new Size(12, 16 /*0x10*/);
    Size size116 = size1;
    lblAccCode15_3.Size = size116;
    this.lblAccCode15.TabIndex = 122;
    this.lblAccCode15.Text = "-";
    this.lblAccCode14.AutoSize = true;
    Label lblAccCode14_1 = this.lblAccCode14;
    point1 = new Point(8, 400);
    Point point117 = point1;
    lblAccCode14_1.Location = point117;
    Label lblAccCode14_2 = this.lblAccCode14;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding117 = padding1;
    lblAccCode14_2.Margin = padding117;
    this.lblAccCode14.Name = "lblAccCode14";
    Label lblAccCode14_3 = this.lblAccCode14;
    size1 = new Size(12, 16 /*0x10*/);
    Size size117 = size1;
    lblAccCode14_3.Size = size117;
    this.lblAccCode14.TabIndex = 121;
    this.lblAccCode14.Text = "-";
    this.lblAccCode13.AutoSize = true;
    Label lblAccCode13_1 = this.lblAccCode13;
    point1 = new Point(8, 370);
    Point point118 = point1;
    lblAccCode13_1.Location = point118;
    Label lblAccCode13_2 = this.lblAccCode13;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding118 = padding1;
    lblAccCode13_2.Margin = padding118;
    this.lblAccCode13.Name = "lblAccCode13";
    Label lblAccCode13_3 = this.lblAccCode13;
    size1 = new Size(12, 16 /*0x10*/);
    Size size118 = size1;
    lblAccCode13_3.Size = size118;
    this.lblAccCode13.TabIndex = 120;
    this.lblAccCode13.Text = "-";
    this.lblAccCode12.AutoSize = true;
    Label lblAccCode12_1 = this.lblAccCode12;
    point1 = new Point(8, 341);
    Point point119 = point1;
    lblAccCode12_1.Location = point119;
    Label lblAccCode12_2 = this.lblAccCode12;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding119 = padding1;
    lblAccCode12_2.Margin = padding119;
    this.lblAccCode12.Name = "lblAccCode12";
    Label lblAccCode12_3 = this.lblAccCode12;
    size1 = new Size(12, 16 /*0x10*/);
    Size size119 = size1;
    lblAccCode12_3.Size = size119;
    this.lblAccCode12.TabIndex = 119;
    this.lblAccCode12.Text = "-";
    this.lblAccCode11.AutoSize = true;
    Label lblAccCode11_1 = this.lblAccCode11;
    point1 = new Point(8, 313);
    Point point120 = point1;
    lblAccCode11_1.Location = point120;
    Label lblAccCode11_2 = this.lblAccCode11;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding120 = padding1;
    lblAccCode11_2.Margin = padding120;
    this.lblAccCode11.Name = "lblAccCode11";
    Label lblAccCode11_3 = this.lblAccCode11;
    size1 = new Size(12, 16 /*0x10*/);
    Size size120 = size1;
    lblAccCode11_3.Size = size120;
    this.lblAccCode11.TabIndex = 118;
    this.lblAccCode11.Text = "-";
    this.lblAccCode10.AutoSize = true;
    Label lblAccCode10_1 = this.lblAccCode10;
    point1 = new Point(8, 284);
    Point point121 = point1;
    lblAccCode10_1.Location = point121;
    Label lblAccCode10_2 = this.lblAccCode10;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding121 = padding1;
    lblAccCode10_2.Margin = padding121;
    this.lblAccCode10.Name = "lblAccCode10";
    Label lblAccCode10_3 = this.lblAccCode10;
    size1 = new Size(12, 16 /*0x10*/);
    Size size121 = size1;
    lblAccCode10_3.Size = size121;
    this.lblAccCode10.TabIndex = 117;
    this.lblAccCode10.Text = "-";
    this.lblAccCode9.AutoSize = true;
    Label lblAccCode9_1 = this.lblAccCode9;
    point1 = new Point(8, 256 /*0x0100*/);
    Point point122 = point1;
    lblAccCode9_1.Location = point122;
    Label lblAccCode9_2 = this.lblAccCode9;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding122 = padding1;
    lblAccCode9_2.Margin = padding122;
    this.lblAccCode9.Name = "lblAccCode9";
    Label lblAccCode9_3 = this.lblAccCode9;
    size1 = new Size(12, 16 /*0x10*/);
    Size size122 = size1;
    lblAccCode9_3.Size = size122;
    this.lblAccCode9.TabIndex = 116;
    this.lblAccCode9.Text = "-";
    this.lblAccCode8.AutoSize = true;
    Label lblAccCode8_1 = this.lblAccCode8;
    point1 = new Point(8, 228);
    Point point123 = point1;
    lblAccCode8_1.Location = point123;
    Label lblAccCode8_2 = this.lblAccCode8;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding123 = padding1;
    lblAccCode8_2.Margin = padding123;
    this.lblAccCode8.Name = "lblAccCode8";
    Label lblAccCode8_3 = this.lblAccCode8;
    size1 = new Size(12, 16 /*0x10*/);
    Size size123 = size1;
    lblAccCode8_3.Size = size123;
    this.lblAccCode8.TabIndex = 115;
    this.lblAccCode8.Text = "-";
    this.lblAccCode7.AutoSize = true;
    Label lblAccCode7_1 = this.lblAccCode7;
    point1 = new Point(8, 199);
    Point point124 = point1;
    lblAccCode7_1.Location = point124;
    Label lblAccCode7_2 = this.lblAccCode7;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding124 = padding1;
    lblAccCode7_2.Margin = padding124;
    this.lblAccCode7.Name = "lblAccCode7";
    Label lblAccCode7_3 = this.lblAccCode7;
    size1 = new Size(12, 16 /*0x10*/);
    Size size124 = size1;
    lblAccCode7_3.Size = size124;
    this.lblAccCode7.TabIndex = 114;
    this.lblAccCode7.Text = "-";
    this.lblAccCode6.AutoSize = true;
    Label lblAccCode6_1 = this.lblAccCode6;
    point1 = new Point(8, 171);
    Point point125 = point1;
    lblAccCode6_1.Location = point125;
    Label lblAccCode6_2 = this.lblAccCode6;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding125 = padding1;
    lblAccCode6_2.Margin = padding125;
    this.lblAccCode6.Name = "lblAccCode6";
    Label lblAccCode6_3 = this.lblAccCode6;
    size1 = new Size(12, 16 /*0x10*/);
    Size size125 = size1;
    lblAccCode6_3.Size = size125;
    this.lblAccCode6.TabIndex = 113;
    this.lblAccCode6.Text = "-";
    this.lblAccCode5.AutoSize = true;
    Label lblAccCode5_1 = this.lblAccCode5;
    point1 = new Point(8, 142);
    Point point126 = point1;
    lblAccCode5_1.Location = point126;
    Label lblAccCode5_2 = this.lblAccCode5;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding126 = padding1;
    lblAccCode5_2.Margin = padding126;
    this.lblAccCode5.Name = "lblAccCode5";
    Label lblAccCode5_3 = this.lblAccCode5;
    size1 = new Size(12, 16 /*0x10*/);
    Size size126 = size1;
    lblAccCode5_3.Size = size126;
    this.lblAccCode5.TabIndex = 112 /*0x70*/;
    this.lblAccCode5.Text = "-";
    this.lblAccCode4.AutoSize = true;
    Label lblAccCode4_1 = this.lblAccCode4;
    point1 = new Point(8, 113);
    Point point127 = point1;
    lblAccCode4_1.Location = point127;
    Label lblAccCode4_2 = this.lblAccCode4;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding127 = padding1;
    lblAccCode4_2.Margin = padding127;
    this.lblAccCode4.Name = "lblAccCode4";
    Label lblAccCode4_3 = this.lblAccCode4;
    size1 = new Size(12, 16 /*0x10*/);
    Size size127 = size1;
    lblAccCode4_3.Size = size127;
    this.lblAccCode4.TabIndex = 111;
    this.lblAccCode4.Text = "-";
    this.lblAccCode3.AutoSize = true;
    Label lblAccCode3_1 = this.lblAccCode3;
    point1 = new Point(8, 85);
    Point point128 = point1;
    lblAccCode3_1.Location = point128;
    Label lblAccCode3_2 = this.lblAccCode3;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding128 = padding1;
    lblAccCode3_2.Margin = padding128;
    this.lblAccCode3.Name = "lblAccCode3";
    Label lblAccCode3_3 = this.lblAccCode3;
    size1 = new Size(12, 16 /*0x10*/);
    Size size128 = size1;
    lblAccCode3_3.Size = size128;
    this.lblAccCode3.TabIndex = 110;
    this.lblAccCode3.Text = "-";
    this.lblAccCode2.AutoSize = true;
    Label lblAccCode2_1 = this.lblAccCode2;
    point1 = new Point(8, 57);
    Point point129 = point1;
    lblAccCode2_1.Location = point129;
    Label lblAccCode2_2 = this.lblAccCode2;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding129 = padding1;
    lblAccCode2_2.Margin = padding129;
    this.lblAccCode2.Name = "lblAccCode2";
    Label lblAccCode2_3 = this.lblAccCode2;
    size1 = new Size(12, 16 /*0x10*/);
    Size size129 = size1;
    lblAccCode2_3.Size = size129;
    this.lblAccCode2.TabIndex = 109;
    this.lblAccCode2.Text = "-";
    this.lblAccCode1.AutoSize = true;
    Label lblAccCode1_1 = this.lblAccCode1;
    point1 = new Point(8, 28);
    Point point130 = point1;
    lblAccCode1_1.Location = point130;
    Label lblAccCode1_2 = this.lblAccCode1;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding130 = padding1;
    lblAccCode1_2.Margin = padding130;
    this.lblAccCode1.Name = "lblAccCode1";
    Label lblAccCode1_3 = this.lblAccCode1;
    size1 = new Size(12, 16 /*0x10*/);
    Size size130 = size1;
    lblAccCode1_3.Size = size130;
    this.lblAccCode1.TabIndex = 108;
    this.lblAccCode1.Text = "-";
    this.grpVisible.Controls.Add((Control) this.GroupBox1);
    this.grpVisible.Controls.Add((Control) this.DataGridView2);
    this.grpVisible.Controls.Add((Control) this.grpGSTRate);
    this.grpVisible.Controls.Add((Control) this.lblAccCode1);
    this.grpVisible.Controls.Add((Control) this.DataGridView1);
    this.grpVisible.Controls.Add((Control) this.lblAccCode21);
    this.grpVisible.Controls.Add((Control) this.txtCode21);
    this.grpVisible.Controls.Add((Control) this.lblAccCode2);
    this.grpVisible.Controls.Add((Control) this.txtCode20);
    this.grpVisible.Controls.Add((Control) this.lblAccCode20);
    this.grpVisible.Controls.Add((Control) this.txtCode19);
    this.grpVisible.Controls.Add((Control) this.lblAccCode3);
    this.grpVisible.Controls.Add((Control) this.txtCode18);
    this.grpVisible.Controls.Add((Control) this.lblAccCode19);
    this.grpVisible.Controls.Add((Control) this.txtCode17);
    this.grpVisible.Controls.Add((Control) this.lblAccCode4);
    this.grpVisible.Controls.Add((Control) this.txtCode16);
    this.grpVisible.Controls.Add((Control) this.lblAccCode18);
    this.grpVisible.Controls.Add((Control) this.txtCode15);
    this.grpVisible.Controls.Add((Control) this.lblAccCode5);
    this.grpVisible.Controls.Add((Control) this.txtCode14);
    this.grpVisible.Controls.Add((Control) this.lblAccCode17);
    this.grpVisible.Controls.Add((Control) this.txtCode13);
    this.grpVisible.Controls.Add((Control) this.lblAccCode6);
    this.grpVisible.Controls.Add((Control) this.txtCode12);
    this.grpVisible.Controls.Add((Control) this.lblAccCode16);
    this.grpVisible.Controls.Add((Control) this.txtCode11);
    this.grpVisible.Controls.Add((Control) this.lblAccCode7);
    this.grpVisible.Controls.Add((Control) this.txtCode10);
    this.grpVisible.Controls.Add((Control) this.lblAccCode15);
    this.grpVisible.Controls.Add((Control) this.txtCode9);
    this.grpVisible.Controls.Add((Control) this.lblAccCode8);
    this.grpVisible.Controls.Add((Control) this.txtCode8);
    this.grpVisible.Controls.Add((Control) this.lblAccCode14);
    this.grpVisible.Controls.Add((Control) this.txtCode7);
    this.grpVisible.Controls.Add((Control) this.lblAccCode9);
    this.grpVisible.Controls.Add((Control) this.txtCode6);
    this.grpVisible.Controls.Add((Control) this.lblAccCode13);
    this.grpVisible.Controls.Add((Control) this.txtCode5);
    this.grpVisible.Controls.Add((Control) this.lblAccCode10);
    this.grpVisible.Controls.Add((Control) this.txtCode4);
    this.grpVisible.Controls.Add((Control) this.lblAccCode12);
    this.grpVisible.Controls.Add((Control) this.txtCode3);
    this.grpVisible.Controls.Add((Control) this.lblAccCode11);
    this.grpVisible.Controls.Add((Control) this.txtCode2);
    this.grpVisible.Controls.Add((Control) this.txtCode1);
    GroupBox grpVisible1 = this.grpVisible;
    point1 = new Point(658, 643);
    Point point131 = point1;
    grpVisible1.Location = point131;
    GroupBox grpVisible2 = this.grpVisible;
    padding1 = new Padding(4);
    Padding padding131 = padding1;
    grpVisible2.Margin = padding131;
    this.grpVisible.Name = "grpVisible";
    GroupBox grpVisible3 = this.grpVisible;
    padding1 = new Padding(4);
    Padding padding132 = padding1;
    grpVisible3.Padding = padding132;
    GroupBox grpVisible4 = this.grpVisible;
    size1 = new Size(103, 41);
    Size size131 = size1;
    grpVisible4.Size = size131;
    this.grpVisible.TabIndex = 129;
    this.grpVisible.TabStop = false;
    this.grpVisible.Text = "GroupBox1";
    this.GroupBox1.Controls.Add((Control) this.txtRound021);
    this.GroupBox1.Controls.Add((Control) this.Label21);
    this.GroupBox1.Controls.Add((Control) this.txtRound020);
    this.GroupBox1.Controls.Add((Control) this.Label23);
    this.GroupBox1.Controls.Add((Control) this.txtRound019);
    this.GroupBox1.Controls.Add((Control) this.txtRate01);
    this.GroupBox1.Controls.Add((Control) this.txtRound018);
    this.GroupBox1.Controls.Add((Control) this.txtRate02);
    this.GroupBox1.Controls.Add((Control) this.txtRound017);
    this.GroupBox1.Controls.Add((Control) this.txtRate03);
    this.GroupBox1.Controls.Add((Control) this.txtRound016);
    this.GroupBox1.Controls.Add((Control) this.txtRate04);
    this.GroupBox1.Controls.Add((Control) this.txtRound015);
    this.GroupBox1.Controls.Add((Control) this.txtRate05);
    this.GroupBox1.Controls.Add((Control) this.txtRound014);
    this.GroupBox1.Controls.Add((Control) this.txtRate06);
    this.GroupBox1.Controls.Add((Control) this.txtRound013);
    this.GroupBox1.Controls.Add((Control) this.txtRate07);
    this.GroupBox1.Controls.Add((Control) this.txtRound012);
    this.GroupBox1.Controls.Add((Control) this.txtRate08);
    this.GroupBox1.Controls.Add((Control) this.txtRound011);
    this.GroupBox1.Controls.Add((Control) this.txtRate09);
    this.GroupBox1.Controls.Add((Control) this.txtRound010);
    this.GroupBox1.Controls.Add((Control) this.txtRate010);
    this.GroupBox1.Controls.Add((Control) this.txtRound09);
    this.GroupBox1.Controls.Add((Control) this.txtRate011);
    this.GroupBox1.Controls.Add((Control) this.txtRound08);
    this.GroupBox1.Controls.Add((Control) this.txtRate012);
    this.GroupBox1.Controls.Add((Control) this.txtRound07);
    this.GroupBox1.Controls.Add((Control) this.txtRate013);
    this.GroupBox1.Controls.Add((Control) this.txtRound06);
    this.GroupBox1.Controls.Add((Control) this.txtRate014);
    this.GroupBox1.Controls.Add((Control) this.txtRound05);
    this.GroupBox1.Controls.Add((Control) this.txtRate015);
    this.GroupBox1.Controls.Add((Control) this.txtRound04);
    this.GroupBox1.Controls.Add((Control) this.txtRate016);
    this.GroupBox1.Controls.Add((Control) this.txtRound03);
    this.GroupBox1.Controls.Add((Control) this.txtRate017);
    this.GroupBox1.Controls.Add((Control) this.txtRound02);
    this.GroupBox1.Controls.Add((Control) this.txtRate018);
    this.GroupBox1.Controls.Add((Control) this.txtRound01);
    this.GroupBox1.Controls.Add((Control) this.txtRate019);
    this.GroupBox1.Controls.Add((Control) this.txtRate021);
    this.GroupBox1.Controls.Add((Control) this.txtRate020);
    GroupBox groupBox1_1 = this.GroupBox1;
    point1 = new Point(11, 209);
    Point point132 = point1;
    groupBox1_1.Location = point132;
    this.GroupBox1.Name = "GroupBox1";
    GroupBox groupBox1_2 = this.GroupBox1;
    size1 = new Size(68, 35);
    Size size132 = size1;
    groupBox1_2.Size = size132;
    this.GroupBox1.TabIndex = 203;
    this.GroupBox1.TabStop = false;
    TextBox txtRound021_1 = this.txtRound021;
    point1 = new Point(83, 595);
    Point point133 = point1;
    txtRound021_1.Location = point133;
    TextBox txtRound021_2 = this.txtRound021;
    padding1 = new Padding(4);
    Padding padding133 = padding1;
    txtRound021_2.Margin = padding133;
    this.txtRound021.MaxLength = 10;
    this.txtRound021.Name = "txtRound021";
    TextBox txtRound021_3 = this.txtRound021;
    size1 = new Size(61, 22);
    Size size133 = size1;
    txtRound021_3.Size = size133;
    this.txtRound021.TabIndex = 202;
    this.Label21.AutoSize = true;
    this.Label21.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label21_1 = this.Label21;
    point1 = new Point(80 /*0x50*/, 7);
    Point point134 = point1;
    label21_1.Location = point134;
    Label label21_2 = this.Label21;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding134 = padding1;
    label21_2.Margin = padding134;
    this.Label21.Name = "Label21";
    Label label21_3 = this.Label21;
    size1 = new Size(71, 16 /*0x10*/);
    Size size134 = size1;
    label21_3.Size = size134;
    this.Label21.TabIndex = 139;
    this.Label21.Text = "Rounded";
    TextBox txtRound020_1 = this.txtRound020;
    point1 = new Point(83, 567);
    Point point135 = point1;
    txtRound020_1.Location = point135;
    TextBox txtRound020_2 = this.txtRound020;
    padding1 = new Padding(4);
    Padding padding135 = padding1;
    txtRound020_2.Margin = padding135;
    this.txtRound020.MaxLength = 10;
    this.txtRound020.Name = "txtRound020";
    TextBox txtRound020_3 = this.txtRound020;
    size1 = new Size(61, 22);
    Size size135 = size1;
    txtRound020_3.Size = size135;
    this.txtRound020.TabIndex = 201;
    this.Label23.AutoSize = true;
    this.Label23.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label23_1 = this.Label23;
    point1 = new Point(8, 7);
    Point point136 = point1;
    label23_1.Location = point136;
    Label label23_2 = this.Label23;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding136 = padding1;
    label23_2.Margin = padding136;
    this.Label23.Name = "Label23";
    Label label23_3 = this.Label23;
    size1 = new Size(76, 16 /*0x10*/);
    Size size136 = size1;
    label23_3.Size = size136;
    this.Label23.TabIndex = 138;
    this.Label23.Text = "GST Rate";
    TextBox txtRound019_1 = this.txtRound019;
    point1 = new Point(83, 538);
    Point point137 = point1;
    txtRound019_1.Location = point137;
    TextBox txtRound019_2 = this.txtRound019;
    padding1 = new Padding(4);
    Padding padding137 = padding1;
    txtRound019_2.Margin = padding137;
    this.txtRound019.MaxLength = 10;
    this.txtRound019.Name = "txtRound019";
    TextBox txtRound019_3 = this.txtRound019;
    size1 = new Size(61, 22);
    Size size137 = size1;
    txtRound019_3.Size = size137;
    this.txtRound019.TabIndex = 200;
    TextBox txtRate01_1 = this.txtRate01;
    point1 = new Point(11, 26);
    Point point138 = point1;
    txtRate01_1.Location = point138;
    TextBox txtRate01_2 = this.txtRate01;
    padding1 = new Padding(4);
    Padding padding138 = padding1;
    txtRate01_2.Margin = padding138;
    this.txtRate01.MaxLength = 10;
    this.txtRate01.Name = "txtRate01";
    TextBox txtRate01_3 = this.txtRate01;
    size1 = new Size(61, 22);
    Size size138 = size1;
    txtRate01_3.Size = size138;
    this.txtRate01.TabIndex = 161;
    TextBox txtRound018_1 = this.txtRound018;
    point1 = new Point(83, 510);
    Point point139 = point1;
    txtRound018_1.Location = point139;
    TextBox txtRound018_2 = this.txtRound018;
    padding1 = new Padding(4);
    Padding padding139 = padding1;
    txtRound018_2.Margin = padding139;
    this.txtRound018.MaxLength = 10;
    this.txtRound018.Name = "txtRound018";
    TextBox txtRound018_3 = this.txtRound018;
    size1 = new Size(61, 22);
    Size size139 = size1;
    txtRound018_3.Size = size139;
    this.txtRound018.TabIndex = 199;
    TextBox txtRate02_1 = this.txtRate02;
    point1 = new Point(11, 54);
    Point point140 = point1;
    txtRate02_1.Location = point140;
    TextBox txtRate02_2 = this.txtRate02;
    padding1 = new Padding(4);
    Padding padding140 = padding1;
    txtRate02_2.Margin = padding140;
    this.txtRate02.MaxLength = 10;
    this.txtRate02.Name = "txtRate02";
    TextBox txtRate02_3 = this.txtRate02;
    size1 = new Size(61, 22);
    Size size140 = size1;
    txtRate02_3.Size = size140;
    this.txtRate02.TabIndex = 162;
    TextBox txtRound017_1 = this.txtRound017;
    point1 = new Point(83, 482);
    Point point141 = point1;
    txtRound017_1.Location = point141;
    TextBox txtRound017_2 = this.txtRound017;
    padding1 = new Padding(4);
    Padding padding141 = padding1;
    txtRound017_2.Margin = padding141;
    this.txtRound017.MaxLength = 10;
    this.txtRound017.Name = "txtRound017";
    TextBox txtRound017_3 = this.txtRound017;
    size1 = new Size(61, 22);
    Size size141 = size1;
    txtRound017_3.Size = size141;
    this.txtRound017.TabIndex = 198;
    TextBox txtRate03_1 = this.txtRate03;
    point1 = new Point(11, 82);
    Point point142 = point1;
    txtRate03_1.Location = point142;
    TextBox txtRate03_2 = this.txtRate03;
    padding1 = new Padding(4);
    Padding padding142 = padding1;
    txtRate03_2.Margin = padding142;
    this.txtRate03.MaxLength = 10;
    this.txtRate03.Name = "txtRate03";
    TextBox txtRate03_3 = this.txtRate03;
    size1 = new Size(61, 22);
    Size size142 = size1;
    txtRate03_3.Size = size142;
    this.txtRate03.TabIndex = 163;
    TextBox txtRound016_1 = this.txtRound016;
    point1 = new Point(83, 453);
    Point point143 = point1;
    txtRound016_1.Location = point143;
    TextBox txtRound016_2 = this.txtRound016;
    padding1 = new Padding(4);
    Padding padding143 = padding1;
    txtRound016_2.Margin = padding143;
    this.txtRound016.MaxLength = 10;
    this.txtRound016.Name = "txtRound016";
    TextBox txtRound016_3 = this.txtRound016;
    size1 = new Size(61, 22);
    Size size143 = size1;
    txtRound016_3.Size = size143;
    this.txtRound016.TabIndex = 197;
    TextBox txtRate04_1 = this.txtRate04;
    point1 = new Point(11, 111);
    Point point144 = point1;
    txtRate04_1.Location = point144;
    TextBox txtRate04_2 = this.txtRate04;
    padding1 = new Padding(4);
    Padding padding144 = padding1;
    txtRate04_2.Margin = padding144;
    this.txtRate04.MaxLength = 10;
    this.txtRate04.Name = "txtRate04";
    TextBox txtRate04_3 = this.txtRate04;
    size1 = new Size(61, 22);
    Size size144 = size1;
    txtRate04_3.Size = size144;
    this.txtRate04.TabIndex = 164;
    TextBox txtRound015_1 = this.txtRound015;
    point1 = new Point(83, 425);
    Point point145 = point1;
    txtRound015_1.Location = point145;
    TextBox txtRound015_2 = this.txtRound015;
    padding1 = new Padding(4);
    Padding padding145 = padding1;
    txtRound015_2.Margin = padding145;
    this.txtRound015.MaxLength = 10;
    this.txtRound015.Name = "txtRound015";
    TextBox txtRound015_3 = this.txtRound015;
    size1 = new Size(61, 22);
    Size size145 = size1;
    txtRound015_3.Size = size145;
    this.txtRound015.TabIndex = 196;
    TextBox txtRate05_1 = this.txtRate05;
    point1 = new Point(11, 139);
    Point point146 = point1;
    txtRate05_1.Location = point146;
    TextBox txtRate05_2 = this.txtRate05;
    padding1 = new Padding(4);
    Padding padding146 = padding1;
    txtRate05_2.Margin = padding146;
    this.txtRate05.MaxLength = 10;
    this.txtRate05.Name = "txtRate05";
    TextBox txtRate05_3 = this.txtRate05;
    size1 = new Size(61, 22);
    Size size146 = size1;
    txtRate05_3.Size = size146;
    this.txtRate05.TabIndex = 165;
    TextBox txtRound014_1 = this.txtRound014;
    point1 = new Point(83, 396);
    Point point147 = point1;
    txtRound014_1.Location = point147;
    TextBox txtRound014_2 = this.txtRound014;
    padding1 = new Padding(4);
    Padding padding147 = padding1;
    txtRound014_2.Margin = padding147;
    this.txtRound014.MaxLength = 10;
    this.txtRound014.Name = "txtRound014";
    TextBox txtRound014_3 = this.txtRound014;
    size1 = new Size(61, 22);
    Size size147 = size1;
    txtRound014_3.Size = size147;
    this.txtRound014.TabIndex = 195;
    TextBox txtRate06_1 = this.txtRate06;
    point1 = new Point(11, 169);
    Point point148 = point1;
    txtRate06_1.Location = point148;
    TextBox txtRate06_2 = this.txtRate06;
    padding1 = new Padding(4);
    Padding padding148 = padding1;
    txtRate06_2.Margin = padding148;
    this.txtRate06.MaxLength = 10;
    this.txtRate06.Name = "txtRate06";
    TextBox txtRate06_3 = this.txtRate06;
    size1 = new Size(61, 22);
    Size size148 = size1;
    txtRate06_3.Size = size148;
    this.txtRate06.TabIndex = 166;
    TextBox txtRound013_1 = this.txtRound013;
    point1 = new Point(83, 366);
    Point point149 = point1;
    txtRound013_1.Location = point149;
    TextBox txtRound013_2 = this.txtRound013;
    padding1 = new Padding(4);
    Padding padding149 = padding1;
    txtRound013_2.Margin = padding149;
    this.txtRound013.MaxLength = 10;
    this.txtRound013.Name = "txtRound013";
    TextBox txtRound013_3 = this.txtRound013;
    size1 = new Size(61, 22);
    Size size149 = size1;
    txtRound013_3.Size = size149;
    this.txtRound013.TabIndex = 194;
    TextBox txtRate07_1 = this.txtRate07;
    point1 = new Point(11, 197);
    Point point150 = point1;
    txtRate07_1.Location = point150;
    TextBox txtRate07_2 = this.txtRate07;
    padding1 = new Padding(4);
    Padding padding150 = padding1;
    txtRate07_2.Margin = padding150;
    this.txtRate07.MaxLength = 10;
    this.txtRate07.Name = "txtRate07";
    TextBox txtRate07_3 = this.txtRate07;
    size1 = new Size(61, 22);
    Size size150 = size1;
    txtRate07_3.Size = size150;
    this.txtRate07.TabIndex = 167;
    TextBox txtRound012_1 = this.txtRound012;
    point1 = new Point(83, 336);
    Point point151 = point1;
    txtRound012_1.Location = point151;
    TextBox txtRound012_2 = this.txtRound012;
    padding1 = new Padding(4);
    Padding padding151 = padding1;
    txtRound012_2.Margin = padding151;
    this.txtRound012.MaxLength = 10;
    this.txtRound012.Name = "txtRound012";
    TextBox txtRound012_3 = this.txtRound012;
    size1 = new Size(61, 22);
    Size size151 = size1;
    txtRound012_3.Size = size151;
    this.txtRound012.TabIndex = 193;
    TextBox txtRate08_1 = this.txtRate08;
    point1 = new Point(11, 225);
    Point point152 = point1;
    txtRate08_1.Location = point152;
    TextBox txtRate08_2 = this.txtRate08;
    padding1 = new Padding(4);
    Padding padding152 = padding1;
    txtRate08_2.Margin = padding152;
    this.txtRate08.MaxLength = 10;
    this.txtRate08.Name = "txtRate08";
    TextBox txtRate08_3 = this.txtRate08;
    size1 = new Size(61, 22);
    Size size152 = size1;
    txtRate08_3.Size = size152;
    this.txtRate08.TabIndex = 168;
    TextBox txtRound011_1 = this.txtRound011;
    point1 = new Point(83, 308);
    Point point153 = point1;
    txtRound011_1.Location = point153;
    TextBox txtRound011_2 = this.txtRound011;
    padding1 = new Padding(4);
    Padding padding153 = padding1;
    txtRound011_2.Margin = padding153;
    this.txtRound011.MaxLength = 10;
    this.txtRound011.Name = "txtRound011";
    TextBox txtRound011_3 = this.txtRound011;
    size1 = new Size(61, 22);
    Size size153 = size1;
    txtRound011_3.Size = size153;
    this.txtRound011.TabIndex = 192 /*0xC0*/;
    TextBox txtRate09_1 = this.txtRate09;
    point1 = new Point(11, 254);
    Point point154 = point1;
    txtRate09_1.Location = point154;
    TextBox txtRate09_2 = this.txtRate09;
    padding1 = new Padding(4);
    Padding padding154 = padding1;
    txtRate09_2.Margin = padding154;
    this.txtRate09.MaxLength = 10;
    this.txtRate09.Name = "txtRate09";
    TextBox txtRate09_3 = this.txtRate09;
    size1 = new Size(61, 22);
    Size size154 = size1;
    txtRate09_3.Size = size154;
    this.txtRate09.TabIndex = 169;
    TextBox txtRound010_1 = this.txtRound010;
    point1 = new Point(83, 280);
    Point point155 = point1;
    txtRound010_1.Location = point155;
    TextBox txtRound010_2 = this.txtRound010;
    padding1 = new Padding(4);
    Padding padding155 = padding1;
    txtRound010_2.Margin = padding155;
    this.txtRound010.MaxLength = 10;
    this.txtRound010.Name = "txtRound010";
    TextBox txtRound010_3 = this.txtRound010;
    size1 = new Size(61, 22);
    Size size155 = size1;
    txtRound010_3.Size = size155;
    this.txtRound010.TabIndex = 191;
    TextBox txtRate010_1 = this.txtRate010;
    point1 = new Point(11, 282);
    Point point156 = point1;
    txtRate010_1.Location = point156;
    TextBox txtRate010_2 = this.txtRate010;
    padding1 = new Padding(4);
    Padding padding156 = padding1;
    txtRate010_2.Margin = padding156;
    this.txtRate010.MaxLength = 10;
    this.txtRate010.Name = "txtRate010";
    TextBox txtRate010_3 = this.txtRate010;
    size1 = new Size(61, 22);
    Size size156 = size1;
    txtRate010_3.Size = size156;
    this.txtRate010.TabIndex = 170;
    TextBox txtRound09_1 = this.txtRound09;
    point1 = new Point(83, 252);
    Point point157 = point1;
    txtRound09_1.Location = point157;
    TextBox txtRound09_2 = this.txtRound09;
    padding1 = new Padding(4);
    Padding padding157 = padding1;
    txtRound09_2.Margin = padding157;
    this.txtRound09.MaxLength = 10;
    this.txtRound09.Name = "txtRound09";
    TextBox txtRound09_3 = this.txtRound09;
    size1 = new Size(61, 22);
    Size size157 = size1;
    txtRound09_3.Size = size157;
    this.txtRound09.TabIndex = 190;
    TextBox txtRate011_1 = this.txtRate011;
    point1 = new Point(11, 310);
    Point point158 = point1;
    txtRate011_1.Location = point158;
    TextBox txtRate011_2 = this.txtRate011;
    padding1 = new Padding(4);
    Padding padding158 = padding1;
    txtRate011_2.Margin = padding158;
    this.txtRate011.MaxLength = 10;
    this.txtRate011.Name = "txtRate011";
    TextBox txtRate011_3 = this.txtRate011;
    size1 = new Size(61, 22);
    Size size158 = size1;
    txtRate011_3.Size = size158;
    this.txtRate011.TabIndex = 171;
    TextBox txtRound08_1 = this.txtRound08;
    point1 = new Point(83, 223);
    Point point159 = point1;
    txtRound08_1.Location = point159;
    TextBox txtRound08_2 = this.txtRound08;
    padding1 = new Padding(4);
    Padding padding159 = padding1;
    txtRound08_2.Margin = padding159;
    this.txtRound08.MaxLength = 10;
    this.txtRound08.Name = "txtRound08";
    TextBox txtRound08_3 = this.txtRound08;
    size1 = new Size(61, 22);
    Size size159 = size1;
    txtRound08_3.Size = size159;
    this.txtRound08.TabIndex = 189;
    TextBox txtRate012_1 = this.txtRate012;
    point1 = new Point(11, 338);
    Point point160 = point1;
    txtRate012_1.Location = point160;
    TextBox txtRate012_2 = this.txtRate012;
    padding1 = new Padding(4);
    Padding padding160 = padding1;
    txtRate012_2.Margin = padding160;
    this.txtRate012.MaxLength = 10;
    this.txtRate012.Name = "txtRate012";
    TextBox txtRate012_3 = this.txtRate012;
    size1 = new Size(61, 22);
    Size size160 = size1;
    txtRate012_3.Size = size160;
    this.txtRate012.TabIndex = 172;
    TextBox txtRound07_1 = this.txtRound07;
    point1 = new Point(83, 195);
    Point point161 = point1;
    txtRound07_1.Location = point161;
    TextBox txtRound07_2 = this.txtRound07;
    padding1 = new Padding(4);
    Padding padding161 = padding1;
    txtRound07_2.Margin = padding161;
    this.txtRound07.MaxLength = 10;
    this.txtRound07.Name = "txtRound07";
    TextBox txtRound07_3 = this.txtRound07;
    size1 = new Size(61, 22);
    Size size161 = size1;
    txtRound07_3.Size = size161;
    this.txtRound07.TabIndex = 188;
    TextBox txtRate013_1 = this.txtRate013;
    point1 = new Point(11, 368);
    Point point162 = point1;
    txtRate013_1.Location = point162;
    TextBox txtRate013_2 = this.txtRate013;
    padding1 = new Padding(4);
    Padding padding162 = padding1;
    txtRate013_2.Margin = padding162;
    this.txtRate013.MaxLength = 10;
    this.txtRate013.Name = "txtRate013";
    TextBox txtRate013_3 = this.txtRate013;
    size1 = new Size(61, 22);
    Size size162 = size1;
    txtRate013_3.Size = size162;
    this.txtRate013.TabIndex = 173;
    TextBox txtRound06_1 = this.txtRound06;
    point1 = new Point(83, 167);
    Point point163 = point1;
    txtRound06_1.Location = point163;
    TextBox txtRound06_2 = this.txtRound06;
    padding1 = new Padding(4);
    Padding padding163 = padding1;
    txtRound06_2.Margin = padding163;
    this.txtRound06.MaxLength = 10;
    this.txtRound06.Name = "txtRound06";
    TextBox txtRound06_3 = this.txtRound06;
    size1 = new Size(61, 22);
    Size size163 = size1;
    txtRound06_3.Size = size163;
    this.txtRound06.TabIndex = 187;
    TextBox txtRate014_1 = this.txtRate014;
    point1 = new Point(11, 398);
    Point point164 = point1;
    txtRate014_1.Location = point164;
    TextBox txtRate014_2 = this.txtRate014;
    padding1 = new Padding(4);
    Padding padding164 = padding1;
    txtRate014_2.Margin = padding164;
    this.txtRate014.MaxLength = 10;
    this.txtRate014.Name = "txtRate014";
    TextBox txtRate014_3 = this.txtRate014;
    size1 = new Size(61, 22);
    Size size164 = size1;
    txtRate014_3.Size = size164;
    this.txtRate014.TabIndex = 174;
    TextBox txtRound05_1 = this.txtRound05;
    point1 = new Point(83, 137);
    Point point165 = point1;
    txtRound05_1.Location = point165;
    TextBox txtRound05_2 = this.txtRound05;
    padding1 = new Padding(4);
    Padding padding165 = padding1;
    txtRound05_2.Margin = padding165;
    this.txtRound05.MaxLength = 10;
    this.txtRound05.Name = "txtRound05";
    TextBox txtRound05_3 = this.txtRound05;
    size1 = new Size(61, 22);
    Size size165 = size1;
    txtRound05_3.Size = size165;
    this.txtRound05.TabIndex = 186;
    TextBox txtRate015_1 = this.txtRate015;
    point1 = new Point(11, 427);
    Point point166 = point1;
    txtRate015_1.Location = point166;
    TextBox txtRate015_2 = this.txtRate015;
    padding1 = new Padding(4);
    Padding padding166 = padding1;
    txtRate015_2.Margin = padding166;
    this.txtRate015.MaxLength = 10;
    this.txtRate015.Name = "txtRate015";
    TextBox txtRate015_3 = this.txtRate015;
    size1 = new Size(61, 22);
    Size size166 = size1;
    txtRate015_3.Size = size166;
    this.txtRate015.TabIndex = 175;
    TextBox txtRound04_1 = this.txtRound04;
    point1 = new Point(83, 109);
    Point point167 = point1;
    txtRound04_1.Location = point167;
    TextBox txtRound04_2 = this.txtRound04;
    padding1 = new Padding(4);
    Padding padding167 = padding1;
    txtRound04_2.Margin = padding167;
    this.txtRound04.MaxLength = 10;
    this.txtRound04.Name = "txtRound04";
    TextBox txtRound04_3 = this.txtRound04;
    size1 = new Size(61, 22);
    Size size167 = size1;
    txtRound04_3.Size = size167;
    this.txtRound04.TabIndex = 185;
    TextBox txtRate016_1 = this.txtRate016;
    point1 = new Point(11, 455);
    Point point168 = point1;
    txtRate016_1.Location = point168;
    TextBox txtRate016_2 = this.txtRate016;
    padding1 = new Padding(4);
    Padding padding168 = padding1;
    txtRate016_2.Margin = padding168;
    this.txtRate016.MaxLength = 10;
    this.txtRate016.Name = "txtRate016";
    TextBox txtRate016_3 = this.txtRate016;
    size1 = new Size(61, 22);
    Size size168 = size1;
    txtRate016_3.Size = size168;
    this.txtRate016.TabIndex = 176 /*0xB0*/;
    TextBox txtRound03_1 = this.txtRound03;
    point1 = new Point(83, 80 /*0x50*/);
    Point point169 = point1;
    txtRound03_1.Location = point169;
    TextBox txtRound03_2 = this.txtRound03;
    padding1 = new Padding(4);
    Padding padding169 = padding1;
    txtRound03_2.Margin = padding169;
    this.txtRound03.MaxLength = 10;
    this.txtRound03.Name = "txtRound03";
    TextBox txtRound03_3 = this.txtRound03;
    size1 = new Size(61, 22);
    Size size169 = size1;
    txtRound03_3.Size = size169;
    this.txtRound03.TabIndex = 184;
    TextBox txtRate017_1 = this.txtRate017;
    point1 = new Point(11, 484);
    Point point170 = point1;
    txtRate017_1.Location = point170;
    TextBox txtRate017_2 = this.txtRate017;
    padding1 = new Padding(4);
    Padding padding170 = padding1;
    txtRate017_2.Margin = padding170;
    this.txtRate017.MaxLength = 10;
    this.txtRate017.Name = "txtRate017";
    TextBox txtRate017_3 = this.txtRate017;
    size1 = new Size(61, 22);
    Size size170 = size1;
    txtRate017_3.Size = size170;
    this.txtRate017.TabIndex = 177;
    TextBox txtRound02_1 = this.txtRound02;
    point1 = new Point(83, 52);
    Point point171 = point1;
    txtRound02_1.Location = point171;
    TextBox txtRound02_2 = this.txtRound02;
    padding1 = new Padding(4);
    Padding padding171 = padding1;
    txtRound02_2.Margin = padding171;
    this.txtRound02.MaxLength = 10;
    this.txtRound02.Name = "txtRound02";
    TextBox txtRound02_3 = this.txtRound02;
    size1 = new Size(61, 22);
    Size size171 = size1;
    txtRound02_3.Size = size171;
    this.txtRound02.TabIndex = 183;
    TextBox txtRate018_1 = this.txtRate018;
    point1 = new Point(11, 512 /*0x0200*/);
    Point point172 = point1;
    txtRate018_1.Location = point172;
    TextBox txtRate018_2 = this.txtRate018;
    padding1 = new Padding(4);
    Padding padding172 = padding1;
    txtRate018_2.Margin = padding172;
    this.txtRate018.MaxLength = 10;
    this.txtRate018.Name = "txtRate018";
    TextBox txtRate018_3 = this.txtRate018;
    size1 = new Size(61, 22);
    Size size172 = size1;
    txtRate018_3.Size = size172;
    this.txtRate018.TabIndex = 178;
    TextBox txtRound01_1 = this.txtRound01;
    point1 = new Point(83, 24);
    Point point173 = point1;
    txtRound01_1.Location = point173;
    TextBox txtRound01_2 = this.txtRound01;
    padding1 = new Padding(4);
    Padding padding173 = padding1;
    txtRound01_2.Margin = padding173;
    this.txtRound01.MaxLength = 10;
    this.txtRound01.Name = "txtRound01";
    TextBox txtRound01_3 = this.txtRound01;
    size1 = new Size(61, 22);
    Size size173 = size1;
    txtRound01_3.Size = size173;
    this.txtRound01.TabIndex = 182;
    TextBox txtRate019_1 = this.txtRate019;
    point1 = new Point(11, 540);
    Point point174 = point1;
    txtRate019_1.Location = point174;
    TextBox txtRate019_2 = this.txtRate019;
    padding1 = new Padding(4);
    Padding padding174 = padding1;
    txtRate019_2.Margin = padding174;
    this.txtRate019.MaxLength = 10;
    this.txtRate019.Name = "txtRate019";
    TextBox txtRate019_3 = this.txtRate019;
    size1 = new Size(61, 22);
    Size size174 = size1;
    txtRate019_3.Size = size174;
    this.txtRate019.TabIndex = 179;
    TextBox txtRate021_1 = this.txtRate021;
    point1 = new Point(11, 597);
    Point point175 = point1;
    txtRate021_1.Location = point175;
    TextBox txtRate021_2 = this.txtRate021;
    padding1 = new Padding(4);
    Padding padding175 = padding1;
    txtRate021_2.Margin = padding175;
    this.txtRate021.MaxLength = 10;
    this.txtRate021.Name = "txtRate021";
    TextBox txtRate021_3 = this.txtRate021;
    size1 = new Size(61, 22);
    Size size175 = size1;
    txtRate021_3.Size = size175;
    this.txtRate021.TabIndex = 181;
    TextBox txtRate020_1 = this.txtRate020;
    point1 = new Point(11, 569);
    Point point176 = point1;
    txtRate020_1.Location = point176;
    TextBox txtRate020_2 = this.txtRate020;
    padding1 = new Padding(4);
    Padding padding176 = padding1;
    txtRate020_2.Margin = padding176;
    this.txtRate020.MaxLength = 10;
    this.txtRate020.Name = "txtRate020";
    TextBox txtRate020_3 = this.txtRate020;
    size1 = new Size(61, 22);
    Size size176 = size1;
    txtRate020_3.Size = size176;
    this.txtRate020.TabIndex = 180;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new Point(87, 412);
    Point point177 = point1;
    dataGridView2_1.Location = point177;
    DataGridView dataGridView2_2 = this.DataGridView2;
    padding1 = new Padding(4);
    Padding padding177 = padding1;
    dataGridView2_2.Margin = padding177;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_3 = this.DataGridView2;
    size1 = new Size(13, 12);
    Size size177 = size1;
    dataGridView2_3.Size = size177;
    this.DataGridView2.TabIndex = 129;
    this.grpGSTRate.Controls.Add((Control) this.txtRound21);
    this.grpGSTRate.Controls.Add((Control) this.Label15);
    this.grpGSTRate.Controls.Add((Control) this.txtRound20);
    this.grpGSTRate.Controls.Add((Control) this.Label13);
    this.grpGSTRate.Controls.Add((Control) this.txtRound19);
    this.grpGSTRate.Controls.Add((Control) this.txtRate1);
    this.grpGSTRate.Controls.Add((Control) this.txtRound18);
    this.grpGSTRate.Controls.Add((Control) this.txtRate2);
    this.grpGSTRate.Controls.Add((Control) this.txtRound17);
    this.grpGSTRate.Controls.Add((Control) this.txtRate3);
    this.grpGSTRate.Controls.Add((Control) this.txtRound16);
    this.grpGSTRate.Controls.Add((Control) this.txtRate4);
    this.grpGSTRate.Controls.Add((Control) this.txtRound15);
    this.grpGSTRate.Controls.Add((Control) this.txtRate5);
    this.grpGSTRate.Controls.Add((Control) this.txtRound14);
    this.grpGSTRate.Controls.Add((Control) this.txtRate6);
    this.grpGSTRate.Controls.Add((Control) this.txtRound13);
    this.grpGSTRate.Controls.Add((Control) this.txtRate7);
    this.grpGSTRate.Controls.Add((Control) this.txtRound12);
    this.grpGSTRate.Controls.Add((Control) this.txtRate8);
    this.grpGSTRate.Controls.Add((Control) this.txtRound11);
    this.grpGSTRate.Controls.Add((Control) this.txtRate9);
    this.grpGSTRate.Controls.Add((Control) this.txtRound10);
    this.grpGSTRate.Controls.Add((Control) this.txtRate10);
    this.grpGSTRate.Controls.Add((Control) this.txtRound9);
    this.grpGSTRate.Controls.Add((Control) this.txtRate11);
    this.grpGSTRate.Controls.Add((Control) this.txtRound8);
    this.grpGSTRate.Controls.Add((Control) this.txtRate12);
    this.grpGSTRate.Controls.Add((Control) this.txtRound7);
    this.grpGSTRate.Controls.Add((Control) this.txtRate13);
    this.grpGSTRate.Controls.Add((Control) this.txtRound6);
    this.grpGSTRate.Controls.Add((Control) this.txtRate14);
    this.grpGSTRate.Controls.Add((Control) this.txtRound5);
    this.grpGSTRate.Controls.Add((Control) this.txtRate15);
    this.grpGSTRate.Controls.Add((Control) this.txtRound4);
    this.grpGSTRate.Controls.Add((Control) this.txtRate16);
    this.grpGSTRate.Controls.Add((Control) this.txtRound3);
    this.grpGSTRate.Controls.Add((Control) this.txtRate17);
    this.grpGSTRate.Controls.Add((Control) this.txtRound2);
    this.grpGSTRate.Controls.Add((Control) this.txtRate18);
    this.grpGSTRate.Controls.Add((Control) this.txtRound1);
    this.grpGSTRate.Controls.Add((Control) this.txtRate19);
    this.grpGSTRate.Controls.Add((Control) this.txtRate21);
    this.grpGSTRate.Controls.Add((Control) this.txtRate20);
    GroupBox grpGstRate1 = this.grpGSTRate;
    point1 = new Point(43, 17);
    Point point178 = point1;
    grpGstRate1.Location = point178;
    this.grpGSTRate.Name = "grpGSTRate";
    GroupBox grpGstRate2 = this.grpGSTRate;
    size1 = new Size(49, 17);
    Size size178 = size1;
    grpGstRate2.Size = size178;
    this.grpGSTRate.TabIndex = 137;
    this.grpGSTRate.TabStop = false;
    TextBox txtRound21_1 = this.txtRound21;
    point1 = new Point(83, 595);
    Point point179 = point1;
    txtRound21_1.Location = point179;
    TextBox txtRound21_2 = this.txtRound21;
    padding1 = new Padding(4);
    Padding padding178 = padding1;
    txtRound21_2.Margin = padding178;
    this.txtRound21.MaxLength = 10;
    this.txtRound21.Name = "txtRound21";
    TextBox txtRound21_3 = this.txtRound21;
    size1 = new Size(61, 22);
    Size size179 = size1;
    txtRound21_3.Size = size179;
    this.txtRound21.TabIndex = 202;
    this.Label15.AutoSize = true;
    this.Label15.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label15_1 = this.Label15;
    point1 = new Point(80 /*0x50*/, 7);
    Point point180 = point1;
    label15_1.Location = point180;
    Label label15_2 = this.Label15;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding179 = padding1;
    label15_2.Margin = padding179;
    this.Label15.Name = "Label15";
    Label label15_3 = this.Label15;
    size1 = new Size(71, 16 /*0x10*/);
    Size size180 = size1;
    label15_3.Size = size180;
    this.Label15.TabIndex = 139;
    this.Label15.Text = "Rounded";
    TextBox txtRound20_1 = this.txtRound20;
    point1 = new Point(83, 567);
    Point point181 = point1;
    txtRound20_1.Location = point181;
    TextBox txtRound20_2 = this.txtRound20;
    padding1 = new Padding(4);
    Padding padding180 = padding1;
    txtRound20_2.Margin = padding180;
    this.txtRound20.MaxLength = 10;
    this.txtRound20.Name = "txtRound20";
    TextBox txtRound20_3 = this.txtRound20;
    size1 = new Size(61, 22);
    Size size181 = size1;
    txtRound20_3.Size = size181;
    this.txtRound20.TabIndex = 201;
    this.Label13.AutoSize = true;
    this.Label13.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label13_1 = this.Label13;
    point1 = new Point(8, 7);
    Point point182 = point1;
    label13_1.Location = point182;
    Label label13_2 = this.Label13;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding181 = padding1;
    label13_2.Margin = padding181;
    this.Label13.Name = "Label13";
    Label label13_3 = this.Label13;
    size1 = new Size(76, 16 /*0x10*/);
    Size size182 = size1;
    label13_3.Size = size182;
    this.Label13.TabIndex = 138;
    this.Label13.Text = "GST Rate";
    TextBox txtRound19_1 = this.txtRound19;
    point1 = new Point(83, 538);
    Point point183 = point1;
    txtRound19_1.Location = point183;
    TextBox txtRound19_2 = this.txtRound19;
    padding1 = new Padding(4);
    Padding padding182 = padding1;
    txtRound19_2.Margin = padding182;
    this.txtRound19.MaxLength = 10;
    this.txtRound19.Name = "txtRound19";
    TextBox txtRound19_3 = this.txtRound19;
    size1 = new Size(61, 22);
    Size size183 = size1;
    txtRound19_3.Size = size183;
    this.txtRound19.TabIndex = 200;
    TextBox txtRate1_1 = this.txtRate1;
    point1 = new Point(11, 26);
    Point point184 = point1;
    txtRate1_1.Location = point184;
    TextBox txtRate1_2 = this.txtRate1;
    padding1 = new Padding(4);
    Padding padding183 = padding1;
    txtRate1_2.Margin = padding183;
    this.txtRate1.MaxLength = 10;
    this.txtRate1.Name = "txtRate1";
    TextBox txtRate1_3 = this.txtRate1;
    size1 = new Size(61, 22);
    Size size184 = size1;
    txtRate1_3.Size = size184;
    this.txtRate1.TabIndex = 161;
    TextBox txtRound18_1 = this.txtRound18;
    point1 = new Point(83, 510);
    Point point185 = point1;
    txtRound18_1.Location = point185;
    TextBox txtRound18_2 = this.txtRound18;
    padding1 = new Padding(4);
    Padding padding184 = padding1;
    txtRound18_2.Margin = padding184;
    this.txtRound18.MaxLength = 10;
    this.txtRound18.Name = "txtRound18";
    TextBox txtRound18_3 = this.txtRound18;
    size1 = new Size(61, 22);
    Size size185 = size1;
    txtRound18_3.Size = size185;
    this.txtRound18.TabIndex = 199;
    TextBox txtRate2_1 = this.txtRate2;
    point1 = new Point(11, 54);
    Point point186 = point1;
    txtRate2_1.Location = point186;
    TextBox txtRate2_2 = this.txtRate2;
    padding1 = new Padding(4);
    Padding padding185 = padding1;
    txtRate2_2.Margin = padding185;
    this.txtRate2.MaxLength = 10;
    this.txtRate2.Name = "txtRate2";
    TextBox txtRate2_3 = this.txtRate2;
    size1 = new Size(61, 22);
    Size size186 = size1;
    txtRate2_3.Size = size186;
    this.txtRate2.TabIndex = 162;
    TextBox txtRound17_1 = this.txtRound17;
    point1 = new Point(83, 482);
    Point point187 = point1;
    txtRound17_1.Location = point187;
    TextBox txtRound17_2 = this.txtRound17;
    padding1 = new Padding(4);
    Padding padding186 = padding1;
    txtRound17_2.Margin = padding186;
    this.txtRound17.MaxLength = 10;
    this.txtRound17.Name = "txtRound17";
    TextBox txtRound17_3 = this.txtRound17;
    size1 = new Size(61, 22);
    Size size187 = size1;
    txtRound17_3.Size = size187;
    this.txtRound17.TabIndex = 198;
    TextBox txtRate3_1 = this.txtRate3;
    point1 = new Point(11, 82);
    Point point188 = point1;
    txtRate3_1.Location = point188;
    TextBox txtRate3_2 = this.txtRate3;
    padding1 = new Padding(4);
    Padding padding187 = padding1;
    txtRate3_2.Margin = padding187;
    this.txtRate3.MaxLength = 10;
    this.txtRate3.Name = "txtRate3";
    TextBox txtRate3_3 = this.txtRate3;
    size1 = new Size(61, 22);
    Size size188 = size1;
    txtRate3_3.Size = size188;
    this.txtRate3.TabIndex = 163;
    TextBox txtRound16_1 = this.txtRound16;
    point1 = new Point(83, 453);
    Point point189 = point1;
    txtRound16_1.Location = point189;
    TextBox txtRound16_2 = this.txtRound16;
    padding1 = new Padding(4);
    Padding padding188 = padding1;
    txtRound16_2.Margin = padding188;
    this.txtRound16.MaxLength = 10;
    this.txtRound16.Name = "txtRound16";
    TextBox txtRound16_3 = this.txtRound16;
    size1 = new Size(61, 22);
    Size size189 = size1;
    txtRound16_3.Size = size189;
    this.txtRound16.TabIndex = 197;
    TextBox txtRate4_1 = this.txtRate4;
    point1 = new Point(11, 111);
    Point point190 = point1;
    txtRate4_1.Location = point190;
    TextBox txtRate4_2 = this.txtRate4;
    padding1 = new Padding(4);
    Padding padding189 = padding1;
    txtRate4_2.Margin = padding189;
    this.txtRate4.MaxLength = 10;
    this.txtRate4.Name = "txtRate4";
    TextBox txtRate4_3 = this.txtRate4;
    size1 = new Size(61, 22);
    Size size190 = size1;
    txtRate4_3.Size = size190;
    this.txtRate4.TabIndex = 164;
    TextBox txtRound15_1 = this.txtRound15;
    point1 = new Point(83, 425);
    Point point191 = point1;
    txtRound15_1.Location = point191;
    TextBox txtRound15_2 = this.txtRound15;
    padding1 = new Padding(4);
    Padding padding190 = padding1;
    txtRound15_2.Margin = padding190;
    this.txtRound15.MaxLength = 10;
    this.txtRound15.Name = "txtRound15";
    TextBox txtRound15_3 = this.txtRound15;
    size1 = new Size(61, 22);
    Size size191 = size1;
    txtRound15_3.Size = size191;
    this.txtRound15.TabIndex = 196;
    TextBox txtRate5_1 = this.txtRate5;
    point1 = new Point(11, 139);
    Point point192 = point1;
    txtRate5_1.Location = point192;
    TextBox txtRate5_2 = this.txtRate5;
    padding1 = new Padding(4);
    Padding padding191 = padding1;
    txtRate5_2.Margin = padding191;
    this.txtRate5.MaxLength = 10;
    this.txtRate5.Name = "txtRate5";
    TextBox txtRate5_3 = this.txtRate5;
    size1 = new Size(61, 22);
    Size size192 = size1;
    txtRate5_3.Size = size192;
    this.txtRate5.TabIndex = 165;
    TextBox txtRound14_1 = this.txtRound14;
    point1 = new Point(83, 396);
    Point point193 = point1;
    txtRound14_1.Location = point193;
    TextBox txtRound14_2 = this.txtRound14;
    padding1 = new Padding(4);
    Padding padding192 = padding1;
    txtRound14_2.Margin = padding192;
    this.txtRound14.MaxLength = 10;
    this.txtRound14.Name = "txtRound14";
    TextBox txtRound14_3 = this.txtRound14;
    size1 = new Size(61, 22);
    Size size193 = size1;
    txtRound14_3.Size = size193;
    this.txtRound14.TabIndex = 195;
    TextBox txtRate6_1 = this.txtRate6;
    point1 = new Point(11, 169);
    Point point194 = point1;
    txtRate6_1.Location = point194;
    TextBox txtRate6_2 = this.txtRate6;
    padding1 = new Padding(4);
    Padding padding193 = padding1;
    txtRate6_2.Margin = padding193;
    this.txtRate6.MaxLength = 10;
    this.txtRate6.Name = "txtRate6";
    TextBox txtRate6_3 = this.txtRate6;
    size1 = new Size(61, 22);
    Size size194 = size1;
    txtRate6_3.Size = size194;
    this.txtRate6.TabIndex = 166;
    TextBox txtRound13_1 = this.txtRound13;
    point1 = new Point(83, 366);
    Point point195 = point1;
    txtRound13_1.Location = point195;
    TextBox txtRound13_2 = this.txtRound13;
    padding1 = new Padding(4);
    Padding padding194 = padding1;
    txtRound13_2.Margin = padding194;
    this.txtRound13.MaxLength = 10;
    this.txtRound13.Name = "txtRound13";
    TextBox txtRound13_3 = this.txtRound13;
    size1 = new Size(61, 22);
    Size size195 = size1;
    txtRound13_3.Size = size195;
    this.txtRound13.TabIndex = 194;
    TextBox txtRate7_1 = this.txtRate7;
    point1 = new Point(11, 197);
    Point point196 = point1;
    txtRate7_1.Location = point196;
    TextBox txtRate7_2 = this.txtRate7;
    padding1 = new Padding(4);
    Padding padding195 = padding1;
    txtRate7_2.Margin = padding195;
    this.txtRate7.MaxLength = 10;
    this.txtRate7.Name = "txtRate7";
    TextBox txtRate7_3 = this.txtRate7;
    size1 = new Size(61, 22);
    Size size196 = size1;
    txtRate7_3.Size = size196;
    this.txtRate7.TabIndex = 167;
    TextBox txtRound12_1 = this.txtRound12;
    point1 = new Point(83, 336);
    Point point197 = point1;
    txtRound12_1.Location = point197;
    TextBox txtRound12_2 = this.txtRound12;
    padding1 = new Padding(4);
    Padding padding196 = padding1;
    txtRound12_2.Margin = padding196;
    this.txtRound12.MaxLength = 10;
    this.txtRound12.Name = "txtRound12";
    TextBox txtRound12_3 = this.txtRound12;
    size1 = new Size(61, 22);
    Size size197 = size1;
    txtRound12_3.Size = size197;
    this.txtRound12.TabIndex = 193;
    TextBox txtRate8_1 = this.txtRate8;
    point1 = new Point(11, 225);
    Point point198 = point1;
    txtRate8_1.Location = point198;
    TextBox txtRate8_2 = this.txtRate8;
    padding1 = new Padding(4);
    Padding padding197 = padding1;
    txtRate8_2.Margin = padding197;
    this.txtRate8.MaxLength = 10;
    this.txtRate8.Name = "txtRate8";
    TextBox txtRate8_3 = this.txtRate8;
    size1 = new Size(61, 22);
    Size size198 = size1;
    txtRate8_3.Size = size198;
    this.txtRate8.TabIndex = 168;
    TextBox txtRound11_1 = this.txtRound11;
    point1 = new Point(83, 308);
    Point point199 = point1;
    txtRound11_1.Location = point199;
    TextBox txtRound11_2 = this.txtRound11;
    padding1 = new Padding(4);
    Padding padding198 = padding1;
    txtRound11_2.Margin = padding198;
    this.txtRound11.MaxLength = 10;
    this.txtRound11.Name = "txtRound11";
    TextBox txtRound11_3 = this.txtRound11;
    size1 = new Size(61, 22);
    Size size199 = size1;
    txtRound11_3.Size = size199;
    this.txtRound11.TabIndex = 192 /*0xC0*/;
    TextBox txtRate9_1 = this.txtRate9;
    point1 = new Point(11, 254);
    Point point200 = point1;
    txtRate9_1.Location = point200;
    TextBox txtRate9_2 = this.txtRate9;
    padding1 = new Padding(4);
    Padding padding199 = padding1;
    txtRate9_2.Margin = padding199;
    this.txtRate9.MaxLength = 10;
    this.txtRate9.Name = "txtRate9";
    TextBox txtRate9_3 = this.txtRate9;
    size1 = new Size(61, 22);
    Size size200 = size1;
    txtRate9_3.Size = size200;
    this.txtRate9.TabIndex = 169;
    TextBox txtRound10_1 = this.txtRound10;
    point1 = new Point(83, 280);
    Point point201 = point1;
    txtRound10_1.Location = point201;
    TextBox txtRound10_2 = this.txtRound10;
    padding1 = new Padding(4);
    Padding padding200 = padding1;
    txtRound10_2.Margin = padding200;
    this.txtRound10.MaxLength = 10;
    this.txtRound10.Name = "txtRound10";
    TextBox txtRound10_3 = this.txtRound10;
    size1 = new Size(61, 22);
    Size size201 = size1;
    txtRound10_3.Size = size201;
    this.txtRound10.TabIndex = 191;
    TextBox txtRate10_1 = this.txtRate10;
    point1 = new Point(11, 282);
    Point point202 = point1;
    txtRate10_1.Location = point202;
    TextBox txtRate10_2 = this.txtRate10;
    padding1 = new Padding(4);
    Padding padding201 = padding1;
    txtRate10_2.Margin = padding201;
    this.txtRate10.MaxLength = 10;
    this.txtRate10.Name = "txtRate10";
    TextBox txtRate10_3 = this.txtRate10;
    size1 = new Size(61, 22);
    Size size202 = size1;
    txtRate10_3.Size = size202;
    this.txtRate10.TabIndex = 170;
    TextBox txtRound9_1 = this.txtRound9;
    point1 = new Point(83, 252);
    Point point203 = point1;
    txtRound9_1.Location = point203;
    TextBox txtRound9_2 = this.txtRound9;
    padding1 = new Padding(4);
    Padding padding202 = padding1;
    txtRound9_2.Margin = padding202;
    this.txtRound9.MaxLength = 10;
    this.txtRound9.Name = "txtRound9";
    TextBox txtRound9_3 = this.txtRound9;
    size1 = new Size(61, 22);
    Size size203 = size1;
    txtRound9_3.Size = size203;
    this.txtRound9.TabIndex = 190;
    TextBox txtRate11_1 = this.txtRate11;
    point1 = new Point(11, 310);
    Point point204 = point1;
    txtRate11_1.Location = point204;
    TextBox txtRate11_2 = this.txtRate11;
    padding1 = new Padding(4);
    Padding padding203 = padding1;
    txtRate11_2.Margin = padding203;
    this.txtRate11.MaxLength = 10;
    this.txtRate11.Name = "txtRate11";
    TextBox txtRate11_3 = this.txtRate11;
    size1 = new Size(61, 22);
    Size size204 = size1;
    txtRate11_3.Size = size204;
    this.txtRate11.TabIndex = 171;
    TextBox txtRound8_1 = this.txtRound8;
    point1 = new Point(83, 223);
    Point point205 = point1;
    txtRound8_1.Location = point205;
    TextBox txtRound8_2 = this.txtRound8;
    padding1 = new Padding(4);
    Padding padding204 = padding1;
    txtRound8_2.Margin = padding204;
    this.txtRound8.MaxLength = 10;
    this.txtRound8.Name = "txtRound8";
    TextBox txtRound8_3 = this.txtRound8;
    size1 = new Size(61, 22);
    Size size205 = size1;
    txtRound8_3.Size = size205;
    this.txtRound8.TabIndex = 189;
    TextBox txtRate12_1 = this.txtRate12;
    point1 = new Point(11, 338);
    Point point206 = point1;
    txtRate12_1.Location = point206;
    TextBox txtRate12_2 = this.txtRate12;
    padding1 = new Padding(4);
    Padding padding205 = padding1;
    txtRate12_2.Margin = padding205;
    this.txtRate12.MaxLength = 10;
    this.txtRate12.Name = "txtRate12";
    TextBox txtRate12_3 = this.txtRate12;
    size1 = new Size(61, 22);
    Size size206 = size1;
    txtRate12_3.Size = size206;
    this.txtRate12.TabIndex = 172;
    TextBox txtRound7_1 = this.txtRound7;
    point1 = new Point(83, 195);
    Point point207 = point1;
    txtRound7_1.Location = point207;
    TextBox txtRound7_2 = this.txtRound7;
    padding1 = new Padding(4);
    Padding padding206 = padding1;
    txtRound7_2.Margin = padding206;
    this.txtRound7.MaxLength = 10;
    this.txtRound7.Name = "txtRound7";
    TextBox txtRound7_3 = this.txtRound7;
    size1 = new Size(61, 22);
    Size size207 = size1;
    txtRound7_3.Size = size207;
    this.txtRound7.TabIndex = 188;
    TextBox txtRate13_1 = this.txtRate13;
    point1 = new Point(11, 368);
    Point point208 = point1;
    txtRate13_1.Location = point208;
    TextBox txtRate13_2 = this.txtRate13;
    padding1 = new Padding(4);
    Padding padding207 = padding1;
    txtRate13_2.Margin = padding207;
    this.txtRate13.MaxLength = 10;
    this.txtRate13.Name = "txtRate13";
    TextBox txtRate13_3 = this.txtRate13;
    size1 = new Size(61, 22);
    Size size208 = size1;
    txtRate13_3.Size = size208;
    this.txtRate13.TabIndex = 173;
    TextBox txtRound6_1 = this.txtRound6;
    point1 = new Point(83, 167);
    Point point209 = point1;
    txtRound6_1.Location = point209;
    TextBox txtRound6_2 = this.txtRound6;
    padding1 = new Padding(4);
    Padding padding208 = padding1;
    txtRound6_2.Margin = padding208;
    this.txtRound6.MaxLength = 10;
    this.txtRound6.Name = "txtRound6";
    TextBox txtRound6_3 = this.txtRound6;
    size1 = new Size(61, 22);
    Size size209 = size1;
    txtRound6_3.Size = size209;
    this.txtRound6.TabIndex = 187;
    TextBox txtRate14_1 = this.txtRate14;
    point1 = new Point(11, 398);
    Point point210 = point1;
    txtRate14_1.Location = point210;
    TextBox txtRate14_2 = this.txtRate14;
    padding1 = new Padding(4);
    Padding padding209 = padding1;
    txtRate14_2.Margin = padding209;
    this.txtRate14.MaxLength = 10;
    this.txtRate14.Name = "txtRate14";
    TextBox txtRate14_3 = this.txtRate14;
    size1 = new Size(61, 22);
    Size size210 = size1;
    txtRate14_3.Size = size210;
    this.txtRate14.TabIndex = 174;
    TextBox txtRound5_1 = this.txtRound5;
    point1 = new Point(83, 137);
    Point point211 = point1;
    txtRound5_1.Location = point211;
    TextBox txtRound5_2 = this.txtRound5;
    padding1 = new Padding(4);
    Padding padding210 = padding1;
    txtRound5_2.Margin = padding210;
    this.txtRound5.MaxLength = 10;
    this.txtRound5.Name = "txtRound5";
    TextBox txtRound5_3 = this.txtRound5;
    size1 = new Size(61, 22);
    Size size211 = size1;
    txtRound5_3.Size = size211;
    this.txtRound5.TabIndex = 186;
    TextBox txtRate15_1 = this.txtRate15;
    point1 = new Point(11, 427);
    Point point212 = point1;
    txtRate15_1.Location = point212;
    TextBox txtRate15_2 = this.txtRate15;
    padding1 = new Padding(4);
    Padding padding211 = padding1;
    txtRate15_2.Margin = padding211;
    this.txtRate15.MaxLength = 10;
    this.txtRate15.Name = "txtRate15";
    TextBox txtRate15_3 = this.txtRate15;
    size1 = new Size(61, 22);
    Size size212 = size1;
    txtRate15_3.Size = size212;
    this.txtRate15.TabIndex = 175;
    TextBox txtRound4_1 = this.txtRound4;
    point1 = new Point(83, 109);
    Point point213 = point1;
    txtRound4_1.Location = point213;
    TextBox txtRound4_2 = this.txtRound4;
    padding1 = new Padding(4);
    Padding padding212 = padding1;
    txtRound4_2.Margin = padding212;
    this.txtRound4.MaxLength = 10;
    this.txtRound4.Name = "txtRound4";
    TextBox txtRound4_3 = this.txtRound4;
    size1 = new Size(61, 22);
    Size size213 = size1;
    txtRound4_3.Size = size213;
    this.txtRound4.TabIndex = 185;
    TextBox txtRate16_1 = this.txtRate16;
    point1 = new Point(11, 455);
    Point point214 = point1;
    txtRate16_1.Location = point214;
    TextBox txtRate16_2 = this.txtRate16;
    padding1 = new Padding(4);
    Padding padding213 = padding1;
    txtRate16_2.Margin = padding213;
    this.txtRate16.MaxLength = 10;
    this.txtRate16.Name = "txtRate16";
    TextBox txtRate16_3 = this.txtRate16;
    size1 = new Size(61, 22);
    Size size214 = size1;
    txtRate16_3.Size = size214;
    this.txtRate16.TabIndex = 176 /*0xB0*/;
    TextBox txtRound3_1 = this.txtRound3;
    point1 = new Point(83, 80 /*0x50*/);
    Point point215 = point1;
    txtRound3_1.Location = point215;
    TextBox txtRound3_2 = this.txtRound3;
    padding1 = new Padding(4);
    Padding padding214 = padding1;
    txtRound3_2.Margin = padding214;
    this.txtRound3.MaxLength = 10;
    this.txtRound3.Name = "txtRound3";
    TextBox txtRound3_3 = this.txtRound3;
    size1 = new Size(61, 22);
    Size size215 = size1;
    txtRound3_3.Size = size215;
    this.txtRound3.TabIndex = 184;
    TextBox txtRate17_1 = this.txtRate17;
    point1 = new Point(11, 484);
    Point point216 = point1;
    txtRate17_1.Location = point216;
    TextBox txtRate17_2 = this.txtRate17;
    padding1 = new Padding(4);
    Padding padding215 = padding1;
    txtRate17_2.Margin = padding215;
    this.txtRate17.MaxLength = 10;
    this.txtRate17.Name = "txtRate17";
    TextBox txtRate17_3 = this.txtRate17;
    size1 = new Size(61, 22);
    Size size216 = size1;
    txtRate17_3.Size = size216;
    this.txtRate17.TabIndex = 177;
    TextBox txtRound2_1 = this.txtRound2;
    point1 = new Point(83, 52);
    Point point217 = point1;
    txtRound2_1.Location = point217;
    TextBox txtRound2_2 = this.txtRound2;
    padding1 = new Padding(4);
    Padding padding216 = padding1;
    txtRound2_2.Margin = padding216;
    this.txtRound2.MaxLength = 10;
    this.txtRound2.Name = "txtRound2";
    TextBox txtRound2_3 = this.txtRound2;
    size1 = new Size(61, 22);
    Size size217 = size1;
    txtRound2_3.Size = size217;
    this.txtRound2.TabIndex = 183;
    TextBox txtRate18_1 = this.txtRate18;
    point1 = new Point(11, 512 /*0x0200*/);
    Point point218 = point1;
    txtRate18_1.Location = point218;
    TextBox txtRate18_2 = this.txtRate18;
    padding1 = new Padding(4);
    Padding padding217 = padding1;
    txtRate18_2.Margin = padding217;
    this.txtRate18.MaxLength = 10;
    this.txtRate18.Name = "txtRate18";
    TextBox txtRate18_3 = this.txtRate18;
    size1 = new Size(61, 22);
    Size size218 = size1;
    txtRate18_3.Size = size218;
    this.txtRate18.TabIndex = 178;
    TextBox txtRound1_1 = this.txtRound1;
    point1 = new Point(83, 24);
    Point point219 = point1;
    txtRound1_1.Location = point219;
    TextBox txtRound1_2 = this.txtRound1;
    padding1 = new Padding(4);
    Padding padding218 = padding1;
    txtRound1_2.Margin = padding218;
    this.txtRound1.MaxLength = 10;
    this.txtRound1.Name = "txtRound1";
    TextBox txtRound1_3 = this.txtRound1;
    size1 = new Size(61, 22);
    Size size219 = size1;
    txtRound1_3.Size = size219;
    this.txtRound1.TabIndex = 182;
    TextBox txtRate19_1 = this.txtRate19;
    point1 = new Point(11, 540);
    Point point220 = point1;
    txtRate19_1.Location = point220;
    TextBox txtRate19_2 = this.txtRate19;
    padding1 = new Padding(4);
    Padding padding219 = padding1;
    txtRate19_2.Margin = padding219;
    this.txtRate19.MaxLength = 10;
    this.txtRate19.Name = "txtRate19";
    TextBox txtRate19_3 = this.txtRate19;
    size1 = new Size(61, 22);
    Size size220 = size1;
    txtRate19_3.Size = size220;
    this.txtRate19.TabIndex = 179;
    TextBox txtRate21_1 = this.txtRate21;
    point1 = new Point(11, 597);
    Point point221 = point1;
    txtRate21_1.Location = point221;
    TextBox txtRate21_2 = this.txtRate21;
    padding1 = new Padding(4);
    Padding padding220 = padding1;
    txtRate21_2.Margin = padding220;
    this.txtRate21.MaxLength = 10;
    this.txtRate21.Name = "txtRate21";
    TextBox txtRate21_3 = this.txtRate21;
    size1 = new Size(61, 22);
    Size size221 = size1;
    txtRate21_3.Size = size221;
    this.txtRate21.TabIndex = 181;
    TextBox txtRate20_1 = this.txtRate20;
    point1 = new Point(11, 569);
    Point point222 = point1;
    txtRate20_1.Location = point222;
    TextBox txtRate20_2 = this.txtRate20;
    padding1 = new Padding(4);
    Padding padding221 = padding1;
    txtRate20_2.Margin = padding221;
    this.txtRate20.MaxLength = 10;
    this.txtRate20.Name = "txtRate20";
    TextBox txtRate20_3 = this.txtRate20;
    size1 = new Size(61, 22);
    Size size222 = size1;
    txtRate20_3.Size = size222;
    this.txtRate20.TabIndex = 180;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label2_1 = this.Label2;
    point1 = new Point(67, 4);
    Point point223 = point1;
    label2_1.Location = point223;
    Label label2_2 = this.Label2;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding222 = padding1;
    label2_2.Margin = padding222;
    this.Label2.Name = "Label2";
    Label label2_3 = this.Label2;
    size1 = new Size(120, 16 /*0x10*/);
    Size size223 = size1;
    label2_3.Size = size223;
    this.Label2.TabIndex = 130;
    this.Label2.Text = "Selecet Account";
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label3_1 = this.Label3;
    point1 = new Point(338, 4);
    Point point224 = point1;
    label3_1.Location = point224;
    Label label3_2 = this.Label3;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding223 = padding1;
    label3_2.Margin = padding223;
    this.Label3.Name = "Label3";
    Label label3_3 = this.Label3;
    size1 = new Size(108, 16 /*0x10*/);
    Size size224 = size1;
    label3_3.Size = size224;
    this.Label3.TabIndex = 131;
    this.Label3.Text = "Account Name";
    this.Label5.AutoSize = true;
    this.Label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label5_1 = this.Label5;
    point1 = new Point(207, 4);
    Point point225 = point1;
    label5_1.Location = point225;
    Label label5_2 = this.Label5;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding224 = padding1;
    label5_2.Margin = padding224;
    this.Label5.Name = "Label5";
    Label label5_3 = this.Label5;
    size1 = new Size(89, 16 /*0x10*/);
    Size size225 = size1;
    label5_3.Size = size225;
    this.Label5.TabIndex = 132;
    this.Label5.Text = "Short Name";
    this.Button2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    Button button2_1 = this.Button2;
    point1 = new Point(521, 634);
    Point point226 = point1;
    button2_1.Location = point226;
    this.Button2.Name = "Button2";
    Button button2_2 = this.Button2;
    size1 = new Size(26, 30);
    Size size226 = size1;
    button2_2.Size = size226;
    this.Button2.TabIndex = 133;
    this.Button2.TabStop = false;
    this.Button2.Text = "&Calculator";
    this.Button2.UseVisualStyleBackColor = true;
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.Red;
    Label label7_1 = this.Label7;
    point1 = new Point(13, 641);
    Point point227 = point1;
    label7_1.Location = point227;
    Label label7_2 = this.Label7;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding225 = padding1;
    label7_2.Margin = padding225;
    this.Label7.Name = "Label7";
    Label label7_3 = this.Label7;
    size1 = new Size(275, 16 /*0x10*/);
    Size size227 = size1;
    label7_3.Size = size227;
    this.Label7.TabIndex = 134;
    this.Label7.Text = "\"Please Do Not Skip Bill Setting Index\"";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.Red;
    Label label9_1 = this.Label9;
    point1 = new Point(13, 672);
    Point point228 = point1;
    label9_1.Location = point228;
    Label label9_2 = this.Label9;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding226 = padding1;
    label9_2.Margin = padding226;
    this.Label9.Name = "Label9";
    Label label9_3 = this.Label9;
    size1 = new Size(367, 16 /*0x10*/);
    Size size228 = size1;
    label9_3.Size = size228;
    this.Label9.TabIndex = 135;
    this.Label9.Text = "\"Please Do not Delete the Bill Index during the year\"";
    this.grpGSTApplicable.Controls.Add((Control) this.chk21);
    this.grpGSTApplicable.Controls.Add((Control) this.chk20);
    this.grpGSTApplicable.Controls.Add((Control) this.chk19);
    this.grpGSTApplicable.Controls.Add((Control) this.chk18);
    this.grpGSTApplicable.Controls.Add((Control) this.chk17);
    this.grpGSTApplicable.Controls.Add((Control) this.chk16);
    this.grpGSTApplicable.Controls.Add((Control) this.chk15);
    this.grpGSTApplicable.Controls.Add((Control) this.chk14);
    this.grpGSTApplicable.Controls.Add((Control) this.chk13);
    this.grpGSTApplicable.Controls.Add((Control) this.chk12);
    this.grpGSTApplicable.Controls.Add((Control) this.chk11);
    this.grpGSTApplicable.Controls.Add((Control) this.chk10);
    this.grpGSTApplicable.Controls.Add((Control) this.chk9);
    this.grpGSTApplicable.Controls.Add((Control) this.chk8);
    this.grpGSTApplicable.Controls.Add((Control) this.chk7);
    this.grpGSTApplicable.Controls.Add((Control) this.chk6);
    this.grpGSTApplicable.Controls.Add((Control) this.chk5);
    this.grpGSTApplicable.Controls.Add((Control) this.chk4);
    this.grpGSTApplicable.Controls.Add((Control) this.chk3);
    this.grpGSTApplicable.Controls.Add((Control) this.chk2);
    this.grpGSTApplicable.Controls.Add((Control) this.chk1);
    this.grpGSTApplicable.Controls.Add((Control) this.Label11);
    GroupBox grpGstApplicable1 = this.grpGSTApplicable;
    point1 = new Point(524, -1);
    Point point229 = point1;
    grpGstApplicable1.Location = point229;
    this.grpGSTApplicable.Name = "grpGSTApplicable";
    GroupBox grpGstApplicable2 = this.grpGSTApplicable;
    size1 = new Size(121, 625);
    Size size229 = size1;
    grpGstApplicable2.Size = size229;
    this.grpGSTApplicable.TabIndex = 136;
    this.grpGSTApplicable.TabStop = false;
    this.chk21.AutoSize = true;
    CheckBox chk21_1 = this.chk21;
    point1 = new Point(58, 602);
    Point point230 = point1;
    chk21_1.Location = point230;
    this.chk21.Name = "chk21";
    CheckBox chk21_2 = this.chk21;
    size1 = new Size(15, 14);
    Size size230 = size1;
    chk21_2.Size = size230;
    this.chk21.TabIndex = 160 /*0xA0*/;
    this.chk21.UseVisualStyleBackColor = true;
    this.chk20.AutoSize = true;
    CheckBox chk20_1 = this.chk20;
    point1 = new Point(58, 573);
    Point point231 = point1;
    chk20_1.Location = point231;
    this.chk20.Name = "chk20";
    CheckBox chk20_2 = this.chk20;
    size1 = new Size(15, 14);
    Size size231 = size1;
    chk20_2.Size = size231;
    this.chk20.TabIndex = 159;
    this.chk20.UseVisualStyleBackColor = true;
    this.chk19.AutoSize = true;
    CheckBox chk19_1 = this.chk19;
    point1 = new Point(58, 545);
    Point point232 = point1;
    chk19_1.Location = point232;
    this.chk19.Name = "chk19";
    CheckBox chk19_2 = this.chk19;
    size1 = new Size(15, 14);
    Size size232 = size1;
    chk19_2.Size = size232;
    this.chk19.TabIndex = 158;
    this.chk19.UseVisualStyleBackColor = true;
    this.chk18.AutoSize = true;
    CheckBox chk18_1 = this.chk18;
    point1 = new Point(58, 517);
    Point point233 = point1;
    chk18_1.Location = point233;
    this.chk18.Name = "chk18";
    CheckBox chk18_2 = this.chk18;
    size1 = new Size(15, 14);
    Size size233 = size1;
    chk18_2.Size = size233;
    this.chk18.TabIndex = 157;
    this.chk18.UseVisualStyleBackColor = true;
    this.chk17.AutoSize = true;
    CheckBox chk17_1 = this.chk17;
    point1 = new Point(58, 489);
    Point point234 = point1;
    chk17_1.Location = point234;
    this.chk17.Name = "chk17";
    CheckBox chk17_2 = this.chk17;
    size1 = new Size(15, 14);
    Size size234 = size1;
    chk17_2.Size = size234;
    this.chk17.TabIndex = 156;
    this.chk17.UseVisualStyleBackColor = true;
    this.chk16.AutoSize = true;
    CheckBox chk16_1 = this.chk16;
    point1 = new Point(58, 456);
    Point point235 = point1;
    chk16_1.Location = point235;
    this.chk16.Name = "chk16";
    CheckBox chk16_2 = this.chk16;
    size1 = new Size(15, 14);
    Size size235 = size1;
    chk16_2.Size = size235;
    this.chk16.TabIndex = 155;
    this.chk16.UseVisualStyleBackColor = true;
    this.chk15.AutoSize = true;
    CheckBox chk15_1 = this.chk15;
    point1 = new Point(58, 428);
    Point point236 = point1;
    chk15_1.Location = point236;
    this.chk15.Name = "chk15";
    CheckBox chk15_2 = this.chk15;
    size1 = new Size(15, 14);
    Size size236 = size1;
    chk15_2.Size = size236;
    this.chk15.TabIndex = 154;
    this.chk15.UseVisualStyleBackColor = true;
    this.chk14.AutoSize = true;
    CheckBox chk14_1 = this.chk14;
    point1 = new Point(58, 400);
    Point point237 = point1;
    chk14_1.Location = point237;
    this.chk14.Name = "chk14";
    CheckBox chk14_2 = this.chk14;
    size1 = new Size(15, 14);
    Size size237 = size1;
    chk14_2.Size = size237;
    this.chk14.TabIndex = 153;
    this.chk14.UseVisualStyleBackColor = true;
    this.chk13.AutoSize = true;
    CheckBox chk13_1 = this.chk13;
    point1 = new Point(58, 372);
    Point point238 = point1;
    chk13_1.Location = point238;
    this.chk13.Name = "chk13";
    CheckBox chk13_2 = this.chk13;
    size1 = new Size(15, 14);
    Size size238 = size1;
    chk13_2.Size = size238;
    this.chk13.TabIndex = 152;
    this.chk13.UseVisualStyleBackColor = true;
    this.chk12.AutoSize = true;
    CheckBox chk12_1 = this.chk12;
    point1 = new Point(58, 343);
    Point point239 = point1;
    chk12_1.Location = point239;
    this.chk12.Name = "chk12";
    CheckBox chk12_2 = this.chk12;
    size1 = new Size(15, 14);
    Size size239 = size1;
    chk12_2.Size = size239;
    this.chk12.TabIndex = 151;
    this.chk12.UseVisualStyleBackColor = true;
    this.chk11.AutoSize = true;
    CheckBox chk11_1 = this.chk11;
    point1 = new Point(58, 315);
    Point point240 = point1;
    chk11_1.Location = point240;
    this.chk11.Name = "chk11";
    CheckBox chk11_2 = this.chk11;
    size1 = new Size(15, 14);
    Size size240 = size1;
    chk11_2.Size = size240;
    this.chk11.TabIndex = 150;
    this.chk11.UseVisualStyleBackColor = true;
    this.chk10.AutoSize = true;
    CheckBox chk10_1 = this.chk10;
    point1 = new Point(58, 287);
    Point point241 = point1;
    chk10_1.Location = point241;
    this.chk10.Name = "chk10";
    CheckBox chk10_2 = this.chk10;
    size1 = new Size(15, 14);
    Size size241 = size1;
    chk10_2.Size = size241;
    this.chk10.TabIndex = 149;
    this.chk10.UseVisualStyleBackColor = true;
    this.chk9.AutoSize = true;
    CheckBox chk9_1 = this.chk9;
    point1 = new Point(58, 259);
    Point point242 = point1;
    chk9_1.Location = point242;
    this.chk9.Name = "chk9";
    CheckBox chk9_2 = this.chk9;
    size1 = new Size(15, 14);
    Size size242 = size1;
    chk9_2.Size = size242;
    this.chk9.TabIndex = 148;
    this.chk9.UseVisualStyleBackColor = true;
    this.chk8.AutoSize = true;
    CheckBox chk8_1 = this.chk8;
    point1 = new Point(58, 229);
    Point point243 = point1;
    chk8_1.Location = point243;
    this.chk8.Name = "chk8";
    CheckBox chk8_2 = this.chk8;
    size1 = new Size(15, 14);
    Size size243 = size1;
    chk8_2.Size = size243;
    this.chk8.TabIndex = 147;
    this.chk8.UseVisualStyleBackColor = true;
    this.chk7.AutoSize = true;
    CheckBox chk7_1 = this.chk7;
    point1 = new Point(58, 201);
    Point point244 = point1;
    chk7_1.Location = point244;
    this.chk7.Name = "chk7";
    CheckBox chk7_2 = this.chk7;
    size1 = new Size(15, 14);
    Size size244 = size1;
    chk7_2.Size = size244;
    this.chk7.TabIndex = 146;
    this.chk7.UseVisualStyleBackColor = true;
    this.chk6.AutoSize = true;
    CheckBox chk6_1 = this.chk6;
    point1 = new Point(58, 173);
    Point point245 = point1;
    chk6_1.Location = point245;
    this.chk6.Name = "chk6";
    CheckBox chk6_2 = this.chk6;
    size1 = new Size(15, 14);
    Size size245 = size1;
    chk6_2.Size = size245;
    this.chk6.TabIndex = 145;
    this.chk6.UseVisualStyleBackColor = true;
    this.chk5.AutoSize = true;
    CheckBox chk5_1 = this.chk5;
    point1 = new Point(58, 145);
    Point point246 = point1;
    chk5_1.Location = point246;
    this.chk5.Name = "chk5";
    CheckBox chk5_2 = this.chk5;
    size1 = new Size(15, 14);
    Size size246 = size1;
    chk5_2.Size = size246;
    this.chk5.TabIndex = 144 /*0x90*/;
    this.chk5.UseVisualStyleBackColor = true;
    this.chk4.AutoSize = true;
    CheckBox chk4_1 = this.chk4;
    point1 = new Point(58, 116);
    Point point247 = point1;
    chk4_1.Location = point247;
    this.chk4.Name = "chk4";
    CheckBox chk4_2 = this.chk4;
    size1 = new Size(15, 14);
    Size size247 = size1;
    chk4_2.Size = size247;
    this.chk4.TabIndex = 143;
    this.chk4.UseVisualStyleBackColor = true;
    this.chk3.AutoSize = true;
    CheckBox chk3_1 = this.chk3;
    point1 = new Point(58, 88);
    Point point248 = point1;
    chk3_1.Location = point248;
    this.chk3.Name = "chk3";
    CheckBox chk3_2 = this.chk3;
    size1 = new Size(15, 14);
    Size size248 = size1;
    chk3_2.Size = size248;
    this.chk3.TabIndex = 142;
    this.chk3.UseVisualStyleBackColor = true;
    this.chk2.AutoSize = true;
    CheckBox chk2_1 = this.chk2;
    point1 = new Point(58, 60);
    Point point249 = point1;
    chk2_1.Location = point249;
    this.chk2.Name = "chk2";
    CheckBox chk2_2 = this.chk2;
    size1 = new Size(15, 14);
    Size size249 = size1;
    chk2_2.Size = size249;
    this.chk2.TabIndex = 141;
    this.chk2.UseVisualStyleBackColor = true;
    this.chk1.AutoSize = true;
    CheckBox chk1_1 = this.chk1;
    point1 = new Point(58, 32 /*0x20*/);
    Point point250 = point1;
    chk1_1.Location = point250;
    this.chk1.Name = "chk1";
    CheckBox chk1_2 = this.chk1;
    size1 = new Size(15, 14);
    Size size250 = size1;
    chk1_2.Size = size250;
    this.chk1.TabIndex = 140;
    this.chk1.UseVisualStyleBackColor = true;
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label11_1 = this.Label11;
    point1 = new Point(7, 7);
    Point point251 = point1;
    label11_1.Location = point251;
    Label label11_2 = this.Label11;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding227 = padding1;
    label11_2.Margin = padding227;
    this.Label11.Name = "Label11";
    Label label11_3 = this.Label11;
    size1 = new Size(118, 16 /*0x10*/);
    Size size251 = size1;
    label11_3.Size = size251;
    this.Label11.TabIndex = 137;
    this.Label11.Text = "GST Applicable";
    this.Label17.AutoSize = true;
    this.Label17.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label17.ForeColor = Color.Red;
    Label label17_1 = this.Label17;
    point1 = new Point(80 /*0x50*/, 600);
    Point point252 = point1;
    label17_1.Location = point252;
    Label label17_2 = this.Label17;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding228 = padding1;
    label17_2.Margin = padding228;
    this.Label17.Name = "Label17";
    Label label17_3 = this.Label17;
    size1 = new Size(87, 16 /*0x10*/);
    Size size252 = size1;
    label17_3.Size = size252;
    this.Label17.TabIndex = 138;
    this.Label17.Text = "GST Account";
    this.Label19.AutoSize = true;
    this.Label19.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label19.ForeColor = Color.Red;
    Label label19_1 = this.Label19;
    point1 = new Point(80 /*0x50*/, 571);
    Point point253 = point1;
    label19_1.Location = point253;
    Label label19_2 = this.Label19;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding229 = padding1;
    label19_2.Margin = padding229;
    this.Label19.Name = "Label19";
    Label label19_3 = this.Label19;
    size1 = new Size(87, 16 /*0x10*/);
    Size size253 = size1;
    label19_3.Size = size253;
    this.Label19.TabIndex = 139;
    this.Label19.Text = "GST Account";
    this.grpLimitApplicable.Controls.Add((Control) this.chkl21);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl20);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl19);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl18);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl17);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl16);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl15);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl14);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl13);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl12);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl11);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl10);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl9);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl8);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl7);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl6);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl5);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl4);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl3);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl2);
    this.grpLimitApplicable.Controls.Add((Control) this.chkl1);
    this.grpLimitApplicable.Controls.Add((Control) this.Label25);
    GroupBox grpLimitApplicable1 = this.grpLimitApplicable;
    point1 = new Point(648, 0);
    Point point254 = point1;
    grpLimitApplicable1.Location = point254;
    this.grpLimitApplicable.Name = "grpLimitApplicable";
    GroupBox grpLimitApplicable2 = this.grpLimitApplicable;
    size1 = new Size(108, 625);
    Size size254 = size1;
    grpLimitApplicable2.Size = size254;
    this.grpLimitApplicable.TabIndex = 140;
    this.grpLimitApplicable.TabStop = false;
    this.chkl21.AutoSize = true;
    CheckBox chkl21_1 = this.chkl21;
    point1 = new Point(52, 602);
    Point point255 = point1;
    chkl21_1.Location = point255;
    this.chkl21.Name = "chkl21";
    CheckBox chkl21_2 = this.chkl21;
    size1 = new Size(15, 14);
    Size size255 = size1;
    chkl21_2.Size = size255;
    this.chkl21.TabIndex = 160 /*0xA0*/;
    this.chkl21.UseVisualStyleBackColor = true;
    this.chkl20.AutoSize = true;
    CheckBox chkl20_1 = this.chkl20;
    point1 = new Point(52, 573);
    Point point256 = point1;
    chkl20_1.Location = point256;
    this.chkl20.Name = "chkl20";
    CheckBox chkl20_2 = this.chkl20;
    size1 = new Size(15, 14);
    Size size256 = size1;
    chkl20_2.Size = size256;
    this.chkl20.TabIndex = 159;
    this.chkl20.UseVisualStyleBackColor = true;
    this.chkl19.AutoSize = true;
    CheckBox chkl19_1 = this.chkl19;
    point1 = new Point(52, 545);
    Point point257 = point1;
    chkl19_1.Location = point257;
    this.chkl19.Name = "chkl19";
    CheckBox chkl19_2 = this.chkl19;
    size1 = new Size(15, 14);
    Size size257 = size1;
    chkl19_2.Size = size257;
    this.chkl19.TabIndex = 158;
    this.chkl19.UseVisualStyleBackColor = true;
    this.chkl18.AutoSize = true;
    CheckBox chkl18_1 = this.chkl18;
    point1 = new Point(52, 517);
    Point point258 = point1;
    chkl18_1.Location = point258;
    this.chkl18.Name = "chkl18";
    CheckBox chkl18_2 = this.chkl18;
    size1 = new Size(15, 14);
    Size size258 = size1;
    chkl18_2.Size = size258;
    this.chkl18.TabIndex = 157;
    this.chkl18.UseVisualStyleBackColor = true;
    this.chkl17.AutoSize = true;
    CheckBox chkl17_1 = this.chkl17;
    point1 = new Point(52, 489);
    Point point259 = point1;
    chkl17_1.Location = point259;
    this.chkl17.Name = "chkl17";
    CheckBox chkl17_2 = this.chkl17;
    size1 = new Size(15, 14);
    Size size259 = size1;
    chkl17_2.Size = size259;
    this.chkl17.TabIndex = 156;
    this.chkl17.UseVisualStyleBackColor = true;
    this.chkl16.AutoSize = true;
    CheckBox chkl16_1 = this.chkl16;
    point1 = new Point(52, 456);
    Point point260 = point1;
    chkl16_1.Location = point260;
    this.chkl16.Name = "chkl16";
    CheckBox chkl16_2 = this.chkl16;
    size1 = new Size(15, 14);
    Size size260 = size1;
    chkl16_2.Size = size260;
    this.chkl16.TabIndex = 155;
    this.chkl16.UseVisualStyleBackColor = true;
    this.chkl15.AutoSize = true;
    CheckBox chkl15_1 = this.chkl15;
    point1 = new Point(52, 428);
    Point point261 = point1;
    chkl15_1.Location = point261;
    this.chkl15.Name = "chkl15";
    CheckBox chkl15_2 = this.chkl15;
    size1 = new Size(15, 14);
    Size size261 = size1;
    chkl15_2.Size = size261;
    this.chkl15.TabIndex = 154;
    this.chkl15.UseVisualStyleBackColor = true;
    this.chkl14.AutoSize = true;
    CheckBox chkl14_1 = this.chkl14;
    point1 = new Point(52, 400);
    Point point262 = point1;
    chkl14_1.Location = point262;
    this.chkl14.Name = "chkl14";
    CheckBox chkl14_2 = this.chkl14;
    size1 = new Size(15, 14);
    Size size262 = size1;
    chkl14_2.Size = size262;
    this.chkl14.TabIndex = 153;
    this.chkl14.UseVisualStyleBackColor = true;
    this.chkl13.AutoSize = true;
    CheckBox chkl13_1 = this.chkl13;
    point1 = new Point(52, 372);
    Point point263 = point1;
    chkl13_1.Location = point263;
    this.chkl13.Name = "chkl13";
    CheckBox chkl13_2 = this.chkl13;
    size1 = new Size(15, 14);
    Size size263 = size1;
    chkl13_2.Size = size263;
    this.chkl13.TabIndex = 152;
    this.chkl13.UseVisualStyleBackColor = true;
    this.chkl12.AutoSize = true;
    CheckBox chkl12_1 = this.chkl12;
    point1 = new Point(52, 343);
    Point point264 = point1;
    chkl12_1.Location = point264;
    this.chkl12.Name = "chkl12";
    CheckBox chkl12_2 = this.chkl12;
    size1 = new Size(15, 14);
    Size size264 = size1;
    chkl12_2.Size = size264;
    this.chkl12.TabIndex = 151;
    this.chkl12.UseVisualStyleBackColor = true;
    this.chkl11.AutoSize = true;
    CheckBox chkl11_1 = this.chkl11;
    point1 = new Point(52, 315);
    Point point265 = point1;
    chkl11_1.Location = point265;
    this.chkl11.Name = "chkl11";
    CheckBox chkl11_2 = this.chkl11;
    size1 = new Size(15, 14);
    Size size265 = size1;
    chkl11_2.Size = size265;
    this.chkl11.TabIndex = 150;
    this.chkl11.UseVisualStyleBackColor = true;
    this.chkl10.AutoSize = true;
    CheckBox chkl10_1 = this.chkl10;
    point1 = new Point(52, 287);
    Point point266 = point1;
    chkl10_1.Location = point266;
    this.chkl10.Name = "chkl10";
    CheckBox chkl10_2 = this.chkl10;
    size1 = new Size(15, 14);
    Size size266 = size1;
    chkl10_2.Size = size266;
    this.chkl10.TabIndex = 149;
    this.chkl10.UseVisualStyleBackColor = true;
    this.chkl9.AutoSize = true;
    CheckBox chkl9_1 = this.chkl9;
    point1 = new Point(52, 259);
    Point point267 = point1;
    chkl9_1.Location = point267;
    this.chkl9.Name = "chkl9";
    CheckBox chkl9_2 = this.chkl9;
    size1 = new Size(15, 14);
    Size size267 = size1;
    chkl9_2.Size = size267;
    this.chkl9.TabIndex = 148;
    this.chkl9.UseVisualStyleBackColor = true;
    this.chkl8.AutoSize = true;
    CheckBox chkl8_1 = this.chkl8;
    point1 = new Point(52, 229);
    Point point268 = point1;
    chkl8_1.Location = point268;
    this.chkl8.Name = "chkl8";
    CheckBox chkl8_2 = this.chkl8;
    size1 = new Size(15, 14);
    Size size268 = size1;
    chkl8_2.Size = size268;
    this.chkl8.TabIndex = 147;
    this.chkl8.UseVisualStyleBackColor = true;
    this.chkl7.AutoSize = true;
    CheckBox chkl7_1 = this.chkl7;
    point1 = new Point(52, 201);
    Point point269 = point1;
    chkl7_1.Location = point269;
    this.chkl7.Name = "chkl7";
    CheckBox chkl7_2 = this.chkl7;
    size1 = new Size(15, 14);
    Size size269 = size1;
    chkl7_2.Size = size269;
    this.chkl7.TabIndex = 146;
    this.chkl7.UseVisualStyleBackColor = true;
    this.chkl6.AutoSize = true;
    CheckBox chkl6_1 = this.chkl6;
    point1 = new Point(52, 173);
    Point point270 = point1;
    chkl6_1.Location = point270;
    this.chkl6.Name = "chkl6";
    CheckBox chkl6_2 = this.chkl6;
    size1 = new Size(15, 14);
    Size size270 = size1;
    chkl6_2.Size = size270;
    this.chkl6.TabIndex = 145;
    this.chkl6.UseVisualStyleBackColor = true;
    this.chkl5.AutoSize = true;
    CheckBox chkl5_1 = this.chkl5;
    point1 = new Point(52, 145);
    Point point271 = point1;
    chkl5_1.Location = point271;
    this.chkl5.Name = "chkl5";
    CheckBox chkl5_2 = this.chkl5;
    size1 = new Size(15, 14);
    Size size271 = size1;
    chkl5_2.Size = size271;
    this.chkl5.TabIndex = 144 /*0x90*/;
    this.chkl5.UseVisualStyleBackColor = true;
    this.chkl4.AutoSize = true;
    CheckBox chkl4_1 = this.chkl4;
    point1 = new Point(52, 116);
    Point point272 = point1;
    chkl4_1.Location = point272;
    this.chkl4.Name = "chkl4";
    CheckBox chkl4_2 = this.chkl4;
    size1 = new Size(15, 14);
    Size size272 = size1;
    chkl4_2.Size = size272;
    this.chkl4.TabIndex = 143;
    this.chkl4.UseVisualStyleBackColor = true;
    this.chkl3.AutoSize = true;
    CheckBox chkl3_1 = this.chkl3;
    point1 = new Point(52, 88);
    Point point273 = point1;
    chkl3_1.Location = point273;
    this.chkl3.Name = "chkl3";
    CheckBox chkl3_2 = this.chkl3;
    size1 = new Size(15, 14);
    Size size273 = size1;
    chkl3_2.Size = size273;
    this.chkl3.TabIndex = 142;
    this.chkl3.UseVisualStyleBackColor = true;
    this.chkl2.AutoSize = true;
    CheckBox chkl2_1 = this.chkl2;
    point1 = new Point(52, 60);
    Point point274 = point1;
    chkl2_1.Location = point274;
    this.chkl2.Name = "chkl2";
    CheckBox chkl2_2 = this.chkl2;
    size1 = new Size(15, 14);
    Size size274 = size1;
    chkl2_2.Size = size274;
    this.chkl2.TabIndex = 141;
    this.chkl2.UseVisualStyleBackColor = true;
    this.chkl1.AutoSize = true;
    CheckBox chkl1_1 = this.chkl1;
    point1 = new Point(52, 32 /*0x20*/);
    Point point275 = point1;
    chkl1_1.Location = point275;
    this.chkl1.Name = "chkl1";
    CheckBox chkl1_2 = this.chkl1;
    size1 = new Size(15, 14);
    Size size275 = size1;
    chkl1_2.Size = size275;
    this.chkl1.TabIndex = 140;
    this.chkl1.UseVisualStyleBackColor = true;
    this.Label25.AutoSize = true;
    this.Label25.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    Label label25_1 = this.Label25;
    point1 = new Point(7, 7);
    Point point276 = point1;
    label25_1.Location = point276;
    Label label25_2 = this.Label25;
    padding1 = new Padding(4, 0, 4, 0);
    Padding padding230 = padding1;
    label25_2.Margin = padding230;
    this.Label25.Name = "Label25";
    Label label25_3 = this.Label25;
    size1 = new Size(94, 16 /*0x10*/);
    Size size276 = size1;
    label25_3.Size = size276;
    this.Label25.TabIndex = 137;
    this.Label25.Text = "GST Exampt";
    this.AutoScaleDimensions = new SizeF(8f, 16f);
    this.AutoScaleMode = AutoScaleMode.Font;
    size1 = new Size(789, 697);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.grpLimitApplicable);
    this.Controls.Add((Control) this.grpGSTApplicable);
    this.Controls.Add((Control) this.Label9);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.grpVisible);
    this.Controls.Add((Control) this.btnExit);
    this.Controls.Add((Control) this.btnUpdate);
    this.Controls.Add((Control) this.lblName21);
    this.Controls.Add((Control) this.txtShname21);
    this.Controls.Add((Control) this.lblName20);
    this.Controls.Add((Control) this.Label24);
    this.Controls.Add((Control) this.txtShname20);
    this.Controls.Add((Control) this.lblName19);
    this.Controls.Add((Control) this.Label26);
    this.Controls.Add((Control) this.txtShname19);
    this.Controls.Add((Control) this.lblName18);
    this.Controls.Add((Control) this.Label28);
    this.Controls.Add((Control) this.txtShname18);
    this.Controls.Add((Control) this.lblName17);
    this.Controls.Add((Control) this.Label30);
    this.Controls.Add((Control) this.txtShname17);
    this.Controls.Add((Control) this.lblName16);
    this.Controls.Add((Control) this.Label32);
    this.Controls.Add((Control) this.txtShname16);
    this.Controls.Add((Control) this.lblName15);
    this.Controls.Add((Control) this.Label34);
    this.Controls.Add((Control) this.txtShname15);
    this.Controls.Add((Control) this.lblName14);
    this.Controls.Add((Control) this.Label36);
    this.Controls.Add((Control) this.txtShname14);
    this.Controls.Add((Control) this.lblName13);
    this.Controls.Add((Control) this.Label38);
    this.Controls.Add((Control) this.txtShname13);
    this.Controls.Add((Control) this.lblName12);
    this.Controls.Add((Control) this.Label40);
    this.Controls.Add((Control) this.txtShname12);
    this.Controls.Add((Control) this.Label42);
    this.Controls.Add((Control) this.btnSelect21);
    this.Controls.Add((Control) this.btnSelect20);
    this.Controls.Add((Control) this.btnSelect19);
    this.Controls.Add((Control) this.btnSelect18);
    this.Controls.Add((Control) this.btnSelect17);
    this.Controls.Add((Control) this.btnSelect16);
    this.Controls.Add((Control) this.btnSelect15);
    this.Controls.Add((Control) this.btnSelect14);
    this.Controls.Add((Control) this.btnSelect13);
    this.Controls.Add((Control) this.lblName11);
    this.Controls.Add((Control) this.btnSelect12);
    this.Controls.Add((Control) this.txtShname11);
    this.Controls.Add((Control) this.lblName10);
    this.Controls.Add((Control) this.Label22);
    this.Controls.Add((Control) this.txtShname10);
    this.Controls.Add((Control) this.lblName9);
    this.Controls.Add((Control) this.Label20);
    this.Controls.Add((Control) this.txtShname9);
    this.Controls.Add((Control) this.lblName8);
    this.Controls.Add((Control) this.Label18);
    this.Controls.Add((Control) this.txtShname8);
    this.Controls.Add((Control) this.lblName7);
    this.Controls.Add((Control) this.Label16);
    this.Controls.Add((Control) this.txtShname7);
    this.Controls.Add((Control) this.lblName6);
    this.Controls.Add((Control) this.Label14);
    this.Controls.Add((Control) this.txtShname6);
    this.Controls.Add((Control) this.lblName5);
    this.Controls.Add((Control) this.Label12);
    this.Controls.Add((Control) this.txtShname5);
    this.Controls.Add((Control) this.lblName4);
    this.Controls.Add((Control) this.Label10);
    this.Controls.Add((Control) this.txtShname4);
    this.Controls.Add((Control) this.lblName3);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.txtShname3);
    this.Controls.Add((Control) this.lblName2);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.txtShname2);
    this.Controls.Add((Control) this.lblName1);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.txtShname1);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.btnSelect11);
    this.Controls.Add((Control) this.btnSelect10);
    this.Controls.Add((Control) this.btnSelect9);
    this.Controls.Add((Control) this.btnSelect8);
    this.Controls.Add((Control) this.btnSelect7);
    this.Controls.Add((Control) this.btnSelect6);
    this.Controls.Add((Control) this.btnSelect5);
    this.Controls.Add((Control) this.btnSelect4);
    this.Controls.Add((Control) this.btnSelect3);
    this.Controls.Add((Control) this.btnSelect2);
    this.Controls.Add((Control) this.btnSelect1);
    this.Controls.Add((Control) this.Button2);
    this.Controls.Add((Control) this.Label17);
    this.Controls.Add((Control) this.Label19);
    this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    padding1 = new Padding(4);
    this.Margin = padding1;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmBillSetting);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = nameof (frmBillSetting);
    ((ISupportInitialize) this.DataGridView1).EndInit();
    this.grpVisible.ResumeLayout(false);
    this.grpVisible.PerformLayout();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.grpGSTRate.ResumeLayout(false);
    this.grpGSTRate.PerformLayout();
    this.grpGSTApplicable.ResumeLayout(false);
    this.grpGSTApplicable.PerformLayout();
    this.grpLimitApplicable.ResumeLayout(false);
    this.grpLimitApplicable.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnSelect1
  {
    [DebuggerNonUserCode] get => this._btnSelect1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Button1_Click);
      if (this._btnSelect1 != null)
        this._btnSelect1.Click -= eventHandler;
      this._btnSelect1 = value;
      if (this._btnSelect1 == null)
        return;
      this._btnSelect1.Click += eventHandler;
    }
  }

  internal virtual Label Label1
  {
    [DebuggerNonUserCode] get => this._Label1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
  }

  internal virtual Label Label18
  {
    [DebuggerNonUserCode] get => this._Label18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
  }

  internal virtual Label Label30
  {
    [DebuggerNonUserCode] get => this._Label30;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label30 = value;
  }

  internal virtual Label Label14
  {
    [DebuggerNonUserCode] get => this._Label14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
  }

  internal virtual Label Label38
  {
    [DebuggerNonUserCode] get => this._Label38;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label38 = value;
  }

  internal virtual Label Label12
  {
    [DebuggerNonUserCode] get => this._Label12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
  }

  internal virtual Button btnSelect14
  {
    [DebuggerNonUserCode] get => this._btnSelect14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect14_Click);
      if (this._btnSelect14 != null)
        this._btnSelect14.Click -= eventHandler;
      this._btnSelect14 = value;
      if (this._btnSelect14 == null)
        return;
      this._btnSelect14.Click += eventHandler;
    }
  }

  internal virtual Button btnSelect4
  {
    [DebuggerNonUserCode] get => this._btnSelect4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect4_Click);
      if (this._btnSelect4 != null)
        this._btnSelect4.Click -= eventHandler;
      this._btnSelect4 = value;
      if (this._btnSelect4 == null)
        return;
      this._btnSelect4.Click += eventHandler;
    }
  }

  internal virtual Label Label20
  {
    [DebuggerNonUserCode] get => this._Label20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
  }

  internal virtual Button btnSelect3
  {
    [DebuggerNonUserCode] get => this._btnSelect3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect3_Click);
      if (this._btnSelect3 != null)
        this._btnSelect3.Click -= eventHandler;
      this._btnSelect3 = value;
      if (this._btnSelect3 == null)
        return;
      this._btnSelect3.Click += eventHandler;
    }
  }

  internal virtual Label Label16
  {
    [DebuggerNonUserCode] get => this._Label16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
  }

  internal virtual Button btnSelect9
  {
    [DebuggerNonUserCode] get => this._btnSelect9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect9_Click);
      if (this._btnSelect9 != null)
        this._btnSelect9.Click -= eventHandler;
      this._btnSelect9 = value;
      if (this._btnSelect9 == null)
        return;
      this._btnSelect9.Click += eventHandler;
    }
  }

  internal virtual Label Label40
  {
    [DebuggerNonUserCode] get => this._Label40;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label40 = value;
  }

  internal virtual Button btnSelect21
  {
    [DebuggerNonUserCode] get => this._btnSelect21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect21_Click);
      if (this._btnSelect21 != null)
        this._btnSelect21.Click -= eventHandler;
      this._btnSelect21 = value;
      if (this._btnSelect21 == null)
        return;
      this._btnSelect21.Click += eventHandler;
    }
  }

  internal virtual Button btnSelect20
  {
    [DebuggerNonUserCode] get => this._btnSelect20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect20_Click);
      if (this._btnSelect20 != null)
        this._btnSelect20.Click -= eventHandler;
      this._btnSelect20 = value;
      if (this._btnSelect20 == null)
        return;
      this._btnSelect20.Click += eventHandler;
    }
  }

  internal virtual Button btnSelect16
  {
    [DebuggerNonUserCode] get => this._btnSelect16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect16_Click);
      if (this._btnSelect16 != null)
        this._btnSelect16.Click -= eventHandler;
      this._btnSelect16 = value;
      if (this._btnSelect16 == null)
        return;
      this._btnSelect16.Click += eventHandler;
    }
  }

  internal virtual Label Label34
  {
    [DebuggerNonUserCode] get => this._Label34;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label34 = value;
  }

  internal virtual Button btnSelect7
  {
    [DebuggerNonUserCode] get => this._btnSelect7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect7_Click);
      if (this._btnSelect7 != null)
        this._btnSelect7.Click -= eventHandler;
      this._btnSelect7 = value;
      if (this._btnSelect7 == null)
        return;
      this._btnSelect7.Click += eventHandler;
    }
  }

  internal virtual Button btnSelect15
  {
    [DebuggerNonUserCode] get => this._btnSelect15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect15_Click);
      if (this._btnSelect15 != null)
        this._btnSelect15.Click -= eventHandler;
      this._btnSelect15 = value;
      if (this._btnSelect15 == null)
        return;
      this._btnSelect15.Click += eventHandler;
    }
  }

  internal virtual Label Label42
  {
    [DebuggerNonUserCode] get => this._Label42;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label42 = value;
  }

  internal virtual Button btnSelect2
  {
    [DebuggerNonUserCode] get => this._btnSelect2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect2_Click);
      if (this._btnSelect2 != null)
        this._btnSelect2.Click -= eventHandler;
      this._btnSelect2 = value;
      if (this._btnSelect2 == null)
        return;
      this._btnSelect2.Click += eventHandler;
    }
  }

  internal virtual Label Label32
  {
    [DebuggerNonUserCode] get => this._Label32;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label32 = value;
  }

  internal virtual Label Label4
  {
    [DebuggerNonUserCode] get => this._Label4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
  }

  internal virtual Label Label10
  {
    [DebuggerNonUserCode] get => this._Label10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
  }

  internal virtual Button btnSelect8
  {
    [DebuggerNonUserCode] get => this._btnSelect8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect8_Click);
      if (this._btnSelect8 != null)
        this._btnSelect8.Click -= eventHandler;
      this._btnSelect8 = value;
      if (this._btnSelect8 == null)
        return;
      this._btnSelect8.Click += eventHandler;
    }
  }

  internal virtual Button btnSelect13
  {
    [DebuggerNonUserCode] get => this._btnSelect13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect13_Click);
      if (this._btnSelect13 != null)
        this._btnSelect13.Click -= eventHandler;
      this._btnSelect13 = value;
      if (this._btnSelect13 == null)
        return;
      this._btnSelect13.Click += eventHandler;
    }
  }

  internal virtual Label Label24
  {
    [DebuggerNonUserCode] get => this._Label24;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label24 = value;
  }

  internal virtual Button btnSelect10
  {
    [DebuggerNonUserCode] get => this._btnSelect10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect10_Click);
      if (this._btnSelect10 != null)
        this._btnSelect10.Click -= eventHandler;
      this._btnSelect10 = value;
      if (this._btnSelect10 == null)
        return;
      this._btnSelect10.Click += eventHandler;
    }
  }

  internal virtual Button btnSelect19
  {
    [DebuggerNonUserCode] get => this._btnSelect19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect19_Click);
      if (this._btnSelect19 != null)
        this._btnSelect19.Click -= eventHandler;
      this._btnSelect19 = value;
      if (this._btnSelect19 == null)
        return;
      this._btnSelect19.Click += eventHandler;
    }
  }

  internal virtual Label Label36
  {
    [DebuggerNonUserCode] get => this._Label36;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label36 = value;
  }

  internal virtual Label Label8
  {
    [DebuggerNonUserCode] get => this._Label8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
  }

  internal virtual Label Label22
  {
    [DebuggerNonUserCode] get => this._Label22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
  }

  internal virtual Label Label28
  {
    [DebuggerNonUserCode] get => this._Label28;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label28 = value;
  }

  internal virtual Button btnSelect17
  {
    [DebuggerNonUserCode] get => this._btnSelect17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect17_Click);
      if (this._btnSelect17 != null)
        this._btnSelect17.Click -= eventHandler;
      this._btnSelect17 = value;
      if (this._btnSelect17 == null)
        return;
      this._btnSelect17.Click += eventHandler;
    }
  }

  internal virtual Button btnSelect12
  {
    [DebuggerNonUserCode] get => this._btnSelect12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect12_Click);
      if (this._btnSelect12 != null)
        this._btnSelect12.Click -= eventHandler;
      this._btnSelect12 = value;
      if (this._btnSelect12 == null)
        return;
      this._btnSelect12.Click += eventHandler;
    }
  }

  internal virtual Button btnSelect11
  {
    [DebuggerNonUserCode] get => this._btnSelect11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect11_Click);
      if (this._btnSelect11 != null)
        this._btnSelect11.Click -= eventHandler;
      this._btnSelect11 = value;
      if (this._btnSelect11 == null)
        return;
      this._btnSelect11.Click += eventHandler;
    }
  }

  internal virtual Button btnSelect18
  {
    [DebuggerNonUserCode] get => this._btnSelect18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect18_Click);
      if (this._btnSelect18 != null)
        this._btnSelect18.Click -= eventHandler;
      this._btnSelect18 = value;
      if (this._btnSelect18 == null)
        return;
      this._btnSelect18.Click += eventHandler;
    }
  }

  internal virtual Button btnSelect6
  {
    [DebuggerNonUserCode] get => this._btnSelect6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect6_Click);
      if (this._btnSelect6 != null)
        this._btnSelect6.Click -= eventHandler;
      this._btnSelect6 = value;
      if (this._btnSelect6 == null)
        return;
      this._btnSelect6.Click += eventHandler;
    }
  }

  internal virtual Label Label26
  {
    [DebuggerNonUserCode] get => this._Label26;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label26 = value;
  }

  internal virtual Button btnSelect5
  {
    [DebuggerNonUserCode] get => this._btnSelect5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect5_Click);
      if (this._btnSelect5 != null)
        this._btnSelect5.Click -= eventHandler;
      this._btnSelect5 = value;
      if (this._btnSelect5 == null)
        return;
      this._btnSelect5.Click += eventHandler;
    }
  }

  internal virtual Label Label6
  {
    [DebuggerNonUserCode] get => this._Label6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
  }

  internal virtual TextBox txtShname1
  {
    [DebuggerNonUserCode] get => this._txtShname1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname1 = value;
    }
  }

  internal virtual Label lblName1
  {
    [DebuggerNonUserCode] get => this._lblName1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblName1 = value;
  }

  internal virtual TextBox txtShname2
  {
    [DebuggerNonUserCode] get => this._txtShname2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname2 = value;
    }
  }

  internal virtual Label lblName2
  {
    [DebuggerNonUserCode] get => this._lblName2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblName2 = value;
  }

  internal virtual TextBox txtShname3
  {
    [DebuggerNonUserCode] get => this._txtShname3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname3 = value;
    }
  }

  internal virtual Label lblName3
  {
    [DebuggerNonUserCode] get => this._lblName3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblName3 = value;
  }

  internal virtual TextBox txtShname4
  {
    [DebuggerNonUserCode] get => this._txtShname4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname4 = value;
    }
  }

  internal virtual Label lblName4
  {
    [DebuggerNonUserCode] get => this._lblName4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblName4 = value;
  }

  internal virtual TextBox txtShname5
  {
    [DebuggerNonUserCode] get => this._txtShname5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname5 = value;
    }
  }

  internal virtual Label lblName5
  {
    [DebuggerNonUserCode] get => this._lblName5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblName5 = value;
  }

  internal virtual TextBox txtShname6
  {
    [DebuggerNonUserCode] get => this._txtShname6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname6 = value;
    }
  }

  internal virtual Label lblName6
  {
    [DebuggerNonUserCode] get => this._lblName6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblName6 = value;
  }

  internal virtual TextBox txtShname7
  {
    [DebuggerNonUserCode] get => this._txtShname7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname7 = value;
    }
  }

  internal virtual Label lblName7
  {
    [DebuggerNonUserCode] get => this._lblName7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblName7 = value;
  }

  internal virtual TextBox txtShname8
  {
    [DebuggerNonUserCode] get => this._txtShname8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname8 = value;
    }
  }

  internal virtual Label lblName8
  {
    [DebuggerNonUserCode] get => this._lblName8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblName8 = value;
  }

  internal virtual TextBox txtShname9
  {
    [DebuggerNonUserCode] get => this._txtShname9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname9 = value;
    }
  }

  internal virtual Label lblName9
  {
    [DebuggerNonUserCode] get => this._lblName9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblName9 = value;
  }

  internal virtual TextBox txtShname10
  {
    [DebuggerNonUserCode] get => this._txtShname10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname10 = value;
    }
  }

  internal virtual Label lblName10
  {
    [DebuggerNonUserCode] get => this._lblName10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblName10 = value;
    }
  }

  internal virtual TextBox txtShname11
  {
    [DebuggerNonUserCode] get => this._txtShname11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname11 = value;
    }
  }

  internal virtual Label lblName11
  {
    [DebuggerNonUserCode] get => this._lblName11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblName11 = value;
    }
  }

  internal virtual TextBox txtShname12
  {
    [DebuggerNonUserCode] get => this._txtShname12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname12 = value;
    }
  }

  internal virtual Label lblName12
  {
    [DebuggerNonUserCode] get => this._lblName12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblName12 = value;
    }
  }

  internal virtual TextBox txtShname13
  {
    [DebuggerNonUserCode] get => this._txtShname13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname13 = value;
    }
  }

  internal virtual Label lblName13
  {
    [DebuggerNonUserCode] get => this._lblName13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblName13 = value;
    }
  }

  internal virtual TextBox txtShname14
  {
    [DebuggerNonUserCode] get => this._txtShname14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname14 = value;
    }
  }

  internal virtual Label lblName14
  {
    [DebuggerNonUserCode] get => this._lblName14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblName14 = value;
    }
  }

  internal virtual TextBox txtShname15
  {
    [DebuggerNonUserCode] get => this._txtShname15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname15 = value;
    }
  }

  internal virtual Label lblName15
  {
    [DebuggerNonUserCode] get => this._lblName15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblName15 = value;
    }
  }

  internal virtual TextBox txtShname16
  {
    [DebuggerNonUserCode] get => this._txtShname16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname16 = value;
    }
  }

  internal virtual Label lblName16
  {
    [DebuggerNonUserCode] get => this._lblName16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblName16 = value;
    }
  }

  internal virtual TextBox txtShname17
  {
    [DebuggerNonUserCode] get => this._txtShname17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname17 = value;
    }
  }

  internal virtual Label lblName17
  {
    [DebuggerNonUserCode] get => this._lblName17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblName17 = value;
    }
  }

  internal virtual TextBox txtShname18
  {
    [DebuggerNonUserCode] get => this._txtShname18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname18 = value;
    }
  }

  internal virtual Label lblName18
  {
    [DebuggerNonUserCode] get => this._lblName18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblName18 = value;
    }
  }

  internal virtual TextBox txtShname19
  {
    [DebuggerNonUserCode] get => this._txtShname19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname19 = value;
    }
  }

  internal virtual Label lblName19
  {
    [DebuggerNonUserCode] get => this._lblName19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblName19 = value;
    }
  }

  internal virtual TextBox txtShname20
  {
    [DebuggerNonUserCode] get => this._txtShname20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname20 = value;
    }
  }

  internal virtual Label lblName20
  {
    [DebuggerNonUserCode] get => this._lblName20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblName20 = value;
    }
  }

  internal virtual TextBox txtShname21
  {
    [DebuggerNonUserCode] get => this._txtShname21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtShname21 = value;
    }
  }

  internal virtual Label lblName21
  {
    [DebuggerNonUserCode] get => this._lblName21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblName21 = value;
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

  internal virtual TextBox txtCode21
  {
    [DebuggerNonUserCode] get => this._txtCode21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCode21 = value;
    }
  }

  internal virtual TextBox txtCode20
  {
    [DebuggerNonUserCode] get => this._txtCode20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCode20 = value;
    }
  }

  internal virtual TextBox txtCode19
  {
    [DebuggerNonUserCode] get => this._txtCode19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCode19 = value;
    }
  }

  internal virtual TextBox txtCode18
  {
    [DebuggerNonUserCode] get => this._txtCode18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCode18 = value;
    }
  }

  internal virtual TextBox txtCode17
  {
    [DebuggerNonUserCode] get => this._txtCode17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCode17 = value;
    }
  }

  internal virtual TextBox txtCode16
  {
    [DebuggerNonUserCode] get => this._txtCode16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCode16 = value;
    }
  }

  internal virtual TextBox txtCode15
  {
    [DebuggerNonUserCode] get => this._txtCode15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCode15 = value;
    }
  }

  internal virtual TextBox txtCode14
  {
    [DebuggerNonUserCode] get => this._txtCode14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCode14 = value;
    }
  }

  internal virtual TextBox txtCode13
  {
    [DebuggerNonUserCode] get => this._txtCode13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCode13 = value;
    }
  }

  internal virtual TextBox txtCode12
  {
    [DebuggerNonUserCode] get => this._txtCode12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCode12 = value;
    }
  }

  internal virtual TextBox txtCode11
  {
    [DebuggerNonUserCode] get => this._txtCode11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCode11 = value;
    }
  }

  internal virtual TextBox txtCode10
  {
    [DebuggerNonUserCode] get => this._txtCode10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtCode10 = value;
    }
  }

  internal virtual TextBox txtCode9
  {
    [DebuggerNonUserCode] get => this._txtCode9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtCode9 = value;
  }

  internal virtual TextBox txtCode8
  {
    [DebuggerNonUserCode] get => this._txtCode8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtCode8 = value;
  }

  internal virtual TextBox txtCode7
  {
    [DebuggerNonUserCode] get => this._txtCode7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtCode7 = value;
  }

  internal virtual TextBox txtCode6
  {
    [DebuggerNonUserCode] get => this._txtCode6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtCode6 = value;
  }

  internal virtual TextBox txtCode5
  {
    [DebuggerNonUserCode] get => this._txtCode5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtCode5 = value;
  }

  internal virtual TextBox txtCode4
  {
    [DebuggerNonUserCode] get => this._txtCode4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtCode4 = value;
  }

  internal virtual TextBox txtCode3
  {
    [DebuggerNonUserCode] get => this._txtCode3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtCode3 = value;
  }

  internal virtual TextBox txtCode2
  {
    [DebuggerNonUserCode] get => this._txtCode2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtCode2 = value;
  }

  internal virtual TextBox txtCode1
  {
    [DebuggerNonUserCode] get => this._txtCode1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtCode1 = value;
  }

  internal virtual DataGridView DataGridView1
  {
    [DebuggerNonUserCode] get => this._DataGridView1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView1 = value;
    }
  }

  internal virtual Label lblAccCode21
  {
    [DebuggerNonUserCode] get => this._lblAccCode21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode21 = value;
    }
  }

  internal virtual Label lblAccCode20
  {
    [DebuggerNonUserCode] get => this._lblAccCode20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode20 = value;
    }
  }

  internal virtual Label lblAccCode19
  {
    [DebuggerNonUserCode] get => this._lblAccCode19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode19 = value;
    }
  }

  internal virtual Label lblAccCode18
  {
    [DebuggerNonUserCode] get => this._lblAccCode18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode18 = value;
    }
  }

  internal virtual Label lblAccCode17
  {
    [DebuggerNonUserCode] get => this._lblAccCode17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode17 = value;
    }
  }

  internal virtual Label lblAccCode16
  {
    [DebuggerNonUserCode] get => this._lblAccCode16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode16 = value;
    }
  }

  internal virtual Label lblAccCode15
  {
    [DebuggerNonUserCode] get => this._lblAccCode15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode15 = value;
    }
  }

  internal virtual Label lblAccCode14
  {
    [DebuggerNonUserCode] get => this._lblAccCode14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode14 = value;
    }
  }

  internal virtual Label lblAccCode13
  {
    [DebuggerNonUserCode] get => this._lblAccCode13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode13 = value;
    }
  }

  internal virtual Label lblAccCode12
  {
    [DebuggerNonUserCode] get => this._lblAccCode12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode12 = value;
    }
  }

  internal virtual Label lblAccCode11
  {
    [DebuggerNonUserCode] get => this._lblAccCode11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode11 = value;
    }
  }

  internal virtual Label lblAccCode10
  {
    [DebuggerNonUserCode] get => this._lblAccCode10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode10 = value;
    }
  }

  internal virtual Label lblAccCode9
  {
    [DebuggerNonUserCode] get => this._lblAccCode9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode9 = value;
    }
  }

  internal virtual Label lblAccCode8
  {
    [DebuggerNonUserCode] get => this._lblAccCode8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode8 = value;
    }
  }

  internal virtual Label lblAccCode7
  {
    [DebuggerNonUserCode] get => this._lblAccCode7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode7 = value;
    }
  }

  internal virtual Label lblAccCode6
  {
    [DebuggerNonUserCode] get => this._lblAccCode6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode6 = value;
    }
  }

  internal virtual Label lblAccCode5
  {
    [DebuggerNonUserCode] get => this._lblAccCode5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode5 = value;
    }
  }

  internal virtual Label lblAccCode4
  {
    [DebuggerNonUserCode] get => this._lblAccCode4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode4 = value;
    }
  }

  internal virtual Label lblAccCode3
  {
    [DebuggerNonUserCode] get => this._lblAccCode3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode3 = value;
    }
  }

  internal virtual Label lblAccCode2
  {
    [DebuggerNonUserCode] get => this._lblAccCode2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode2 = value;
    }
  }

  internal virtual Label lblAccCode1
  {
    [DebuggerNonUserCode] get => this._lblAccCode1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._lblAccCode1 = value;
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

  internal virtual Label Label5
  {
    [DebuggerNonUserCode] get => this._Label5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
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

  internal virtual DataGridView DataGridView2
  {
    [DebuggerNonUserCode] get => this._DataGridView2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._DataGridView2 = value;
    }
  }

  internal virtual Label Label7
  {
    [DebuggerNonUserCode] get => this._Label7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
  }

  internal virtual Label Label9
  {
    [DebuggerNonUserCode] get => this._Label9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
  }

  internal virtual GroupBox grpGSTApplicable
  {
    [DebuggerNonUserCode] get => this._grpGSTApplicable;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpGSTApplicable = value;
    }
  }

  internal virtual CheckBox chk21
  {
    [DebuggerNonUserCode] get => this._chk21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk21 = value;
  }

  internal virtual CheckBox chk20
  {
    [DebuggerNonUserCode] get => this._chk20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk20 = value;
  }

  internal virtual CheckBox chk19
  {
    [DebuggerNonUserCode] get => this._chk19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk19 = value;
  }

  internal virtual CheckBox chk18
  {
    [DebuggerNonUserCode] get => this._chk18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk18 = value;
  }

  internal virtual CheckBox chk17
  {
    [DebuggerNonUserCode] get => this._chk17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk17 = value;
  }

  internal virtual CheckBox chk16
  {
    [DebuggerNonUserCode] get => this._chk16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk16 = value;
  }

  internal virtual CheckBox chk15
  {
    [DebuggerNonUserCode] get => this._chk15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk15 = value;
  }

  internal virtual CheckBox chk14
  {
    [DebuggerNonUserCode] get => this._chk14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk14 = value;
  }

  internal virtual CheckBox chk13
  {
    [DebuggerNonUserCode] get => this._chk13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk13 = value;
  }

  internal virtual CheckBox chk12
  {
    [DebuggerNonUserCode] get => this._chk12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk12 = value;
  }

  internal virtual CheckBox chk11
  {
    [DebuggerNonUserCode] get => this._chk11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk11 = value;
  }

  internal virtual CheckBox chk10
  {
    [DebuggerNonUserCode] get => this._chk10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk10 = value;
  }

  internal virtual CheckBox chk9
  {
    [DebuggerNonUserCode] get => this._chk9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk9 = value;
  }

  internal virtual CheckBox chk8
  {
    [DebuggerNonUserCode] get => this._chk8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk8 = value;
  }

  internal virtual CheckBox chk7
  {
    [DebuggerNonUserCode] get => this._chk7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk7 = value;
  }

  internal virtual CheckBox chk6
  {
    [DebuggerNonUserCode] get => this._chk6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk6 = value;
  }

  internal virtual CheckBox chk5
  {
    [DebuggerNonUserCode] get => this._chk5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk5 = value;
  }

  internal virtual CheckBox chk4
  {
    [DebuggerNonUserCode] get => this._chk4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk4 = value;
  }

  internal virtual CheckBox chk3
  {
    [DebuggerNonUserCode] get => this._chk3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk3 = value;
  }

  internal virtual CheckBox chk2
  {
    [DebuggerNonUserCode] get => this._chk2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk2 = value;
  }

  internal virtual CheckBox chk1
  {
    [DebuggerNonUserCode] get => this._chk1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chk1 = value;
  }

  internal virtual Label Label15
  {
    [DebuggerNonUserCode] get => this._Label15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
  }

  internal virtual Label Label13
  {
    [DebuggerNonUserCode] get => this._Label13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
  }

  internal virtual Label Label11
  {
    [DebuggerNonUserCode] get => this._Label11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
  }

  internal virtual TextBox txtRate21
  {
    [DebuggerNonUserCode] get => this._txtRate21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate21 = value;
    }
  }

  internal virtual TextBox txtRate20
  {
    [DebuggerNonUserCode] get => this._txtRate20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate20 = value;
    }
  }

  internal virtual TextBox txtRate19
  {
    [DebuggerNonUserCode] get => this._txtRate19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate19 = value;
    }
  }

  internal virtual TextBox txtRate18
  {
    [DebuggerNonUserCode] get => this._txtRate18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate18 = value;
    }
  }

  internal virtual TextBox txtRate17
  {
    [DebuggerNonUserCode] get => this._txtRate17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate17 = value;
    }
  }

  internal virtual TextBox txtRate16
  {
    [DebuggerNonUserCode] get => this._txtRate16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate16 = value;
    }
  }

  internal virtual TextBox txtRate15
  {
    [DebuggerNonUserCode] get => this._txtRate15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate15 = value;
    }
  }

  internal virtual TextBox txtRate14
  {
    [DebuggerNonUserCode] get => this._txtRate14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate14 = value;
    }
  }

  internal virtual TextBox txtRate13
  {
    [DebuggerNonUserCode] get => this._txtRate13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate13 = value;
    }
  }

  internal virtual TextBox txtRate12
  {
    [DebuggerNonUserCode] get => this._txtRate12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate12 = value;
    }
  }

  internal virtual TextBox txtRate11
  {
    [DebuggerNonUserCode] get => this._txtRate11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate11 = value;
    }
  }

  internal virtual TextBox txtRate10
  {
    [DebuggerNonUserCode] get => this._txtRate10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate10 = value;
    }
  }

  internal virtual TextBox txtRate9
  {
    [DebuggerNonUserCode] get => this._txtRate9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtRate9 = value;
  }

  internal virtual TextBox txtRate8
  {
    [DebuggerNonUserCode] get => this._txtRate8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtRate8 = value;
  }

  internal virtual TextBox txtRate7
  {
    [DebuggerNonUserCode] get => this._txtRate7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtRate7 = value;
  }

  internal virtual TextBox txtRate6
  {
    [DebuggerNonUserCode] get => this._txtRate6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtRate6 = value;
  }

  internal virtual TextBox txtRate5
  {
    [DebuggerNonUserCode] get => this._txtRate5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtRate5 = value;
  }

  internal virtual TextBox txtRate4
  {
    [DebuggerNonUserCode] get => this._txtRate4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtRate4 = value;
  }

  internal virtual TextBox txtRate3
  {
    [DebuggerNonUserCode] get => this._txtRate3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtRate3 = value;
  }

  internal virtual TextBox txtRate2
  {
    [DebuggerNonUserCode] get => this._txtRate2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtRate2 = value;
  }

  internal virtual TextBox txtRate1
  {
    [DebuggerNonUserCode] get => this._txtRate1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._txtRate1 = value;
  }

  internal virtual TextBox txtRound21
  {
    [DebuggerNonUserCode] get => this._txtRound21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound21 = value;
    }
  }

  internal virtual TextBox txtRound20
  {
    [DebuggerNonUserCode] get => this._txtRound20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound20 = value;
    }
  }

  internal virtual TextBox txtRound19
  {
    [DebuggerNonUserCode] get => this._txtRound19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound19 = value;
    }
  }

  internal virtual TextBox txtRound18
  {
    [DebuggerNonUserCode] get => this._txtRound18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound18 = value;
    }
  }

  internal virtual TextBox txtRound17
  {
    [DebuggerNonUserCode] get => this._txtRound17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound17 = value;
    }
  }

  internal virtual TextBox txtRound16
  {
    [DebuggerNonUserCode] get => this._txtRound16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound16 = value;
    }
  }

  internal virtual TextBox txtRound15
  {
    [DebuggerNonUserCode] get => this._txtRound15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound15 = value;
    }
  }

  internal virtual TextBox txtRound14
  {
    [DebuggerNonUserCode] get => this._txtRound14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound14 = value;
    }
  }

  internal virtual TextBox txtRound13
  {
    [DebuggerNonUserCode] get => this._txtRound13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound13 = value;
    }
  }

  internal virtual TextBox txtRound12
  {
    [DebuggerNonUserCode] get => this._txtRound12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound12 = value;
    }
  }

  internal virtual TextBox txtRound11
  {
    [DebuggerNonUserCode] get => this._txtRound11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound11 = value;
    }
  }

  internal virtual TextBox txtRound10
  {
    [DebuggerNonUserCode] get => this._txtRound10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound10 = value;
    }
  }

  internal virtual TextBox txtRound9
  {
    [DebuggerNonUserCode] get => this._txtRound9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound9 = value;
    }
  }

  internal virtual TextBox txtRound8
  {
    [DebuggerNonUserCode] get => this._txtRound8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound8 = value;
    }
  }

  internal virtual TextBox txtRound7
  {
    [DebuggerNonUserCode] get => this._txtRound7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound7 = value;
    }
  }

  internal virtual TextBox txtRound6
  {
    [DebuggerNonUserCode] get => this._txtRound6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound6 = value;
    }
  }

  internal virtual TextBox txtRound5
  {
    [DebuggerNonUserCode] get => this._txtRound5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound5 = value;
    }
  }

  internal virtual TextBox txtRound4
  {
    [DebuggerNonUserCode] get => this._txtRound4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound4 = value;
    }
  }

  internal virtual TextBox txtRound3
  {
    [DebuggerNonUserCode] get => this._txtRound3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound3 = value;
    }
  }

  internal virtual TextBox txtRound2
  {
    [DebuggerNonUserCode] get => this._txtRound2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound2 = value;
    }
  }

  internal virtual TextBox txtRound1
  {
    [DebuggerNonUserCode] get => this._txtRound1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound1 = value;
    }
  }

  internal virtual GroupBox grpGSTRate
  {
    [DebuggerNonUserCode] get => this._grpGSTRate;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpGSTRate = value;
    }
  }

  internal virtual Label Label17
  {
    [DebuggerNonUserCode] get => this._Label17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
  }

  internal virtual Label Label19
  {
    [DebuggerNonUserCode] get => this._Label19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
  }

  internal virtual GroupBox GroupBox1
  {
    [DebuggerNonUserCode] get => this._GroupBox1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._GroupBox1 = value;
    }
  }

  internal virtual TextBox txtRound021
  {
    [DebuggerNonUserCode] get => this._txtRound021;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound021 = value;
    }
  }

  internal virtual Label Label21
  {
    [DebuggerNonUserCode] get => this._Label21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label21 = value;
  }

  internal virtual TextBox txtRound020
  {
    [DebuggerNonUserCode] get => this._txtRound020;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound020 = value;
    }
  }

  internal virtual Label Label23
  {
    [DebuggerNonUserCode] get => this._Label23;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label23 = value;
  }

  internal virtual TextBox txtRound019
  {
    [DebuggerNonUserCode] get => this._txtRound019;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound019 = value;
    }
  }

  internal virtual TextBox txtRate01
  {
    [DebuggerNonUserCode] get => this._txtRate01;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate01 = value;
    }
  }

  internal virtual TextBox txtRound018
  {
    [DebuggerNonUserCode] get => this._txtRound018;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound018 = value;
    }
  }

  internal virtual TextBox txtRate02
  {
    [DebuggerNonUserCode] get => this._txtRate02;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate02 = value;
    }
  }

  internal virtual TextBox txtRound017
  {
    [DebuggerNonUserCode] get => this._txtRound017;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound017 = value;
    }
  }

  internal virtual TextBox txtRate03
  {
    [DebuggerNonUserCode] get => this._txtRate03;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate03 = value;
    }
  }

  internal virtual TextBox txtRound016
  {
    [DebuggerNonUserCode] get => this._txtRound016;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound016 = value;
    }
  }

  internal virtual TextBox txtRate04
  {
    [DebuggerNonUserCode] get => this._txtRate04;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate04 = value;
    }
  }

  internal virtual TextBox txtRound015
  {
    [DebuggerNonUserCode] get => this._txtRound015;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound015 = value;
    }
  }

  internal virtual TextBox txtRate05
  {
    [DebuggerNonUserCode] get => this._txtRate05;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate05 = value;
    }
  }

  internal virtual TextBox txtRound014
  {
    [DebuggerNonUserCode] get => this._txtRound014;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound014 = value;
    }
  }

  internal virtual TextBox txtRate06
  {
    [DebuggerNonUserCode] get => this._txtRate06;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate06 = value;
    }
  }

  internal virtual TextBox txtRound013
  {
    [DebuggerNonUserCode] get => this._txtRound013;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound013 = value;
    }
  }

  internal virtual TextBox txtRate07
  {
    [DebuggerNonUserCode] get => this._txtRate07;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate07 = value;
    }
  }

  internal virtual TextBox txtRound012
  {
    [DebuggerNonUserCode] get => this._txtRound012;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound012 = value;
    }
  }

  internal virtual TextBox txtRate08
  {
    [DebuggerNonUserCode] get => this._txtRate08;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate08 = value;
    }
  }

  internal virtual TextBox txtRound011
  {
    [DebuggerNonUserCode] get => this._txtRound011;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound011 = value;
    }
  }

  internal virtual TextBox txtRate09
  {
    [DebuggerNonUserCode] get => this._txtRate09;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate09 = value;
    }
  }

  internal virtual TextBox txtRound010
  {
    [DebuggerNonUserCode] get => this._txtRound010;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound010 = value;
    }
  }

  internal virtual TextBox txtRate010
  {
    [DebuggerNonUserCode] get => this._txtRate010;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate010 = value;
    }
  }

  internal virtual TextBox txtRound09
  {
    [DebuggerNonUserCode] get => this._txtRound09;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound09 = value;
    }
  }

  internal virtual TextBox txtRate011
  {
    [DebuggerNonUserCode] get => this._txtRate011;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate011 = value;
    }
  }

  internal virtual TextBox txtRound08
  {
    [DebuggerNonUserCode] get => this._txtRound08;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound08 = value;
    }
  }

  internal virtual TextBox txtRate012
  {
    [DebuggerNonUserCode] get => this._txtRate012;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate012 = value;
    }
  }

  internal virtual TextBox txtRound07
  {
    [DebuggerNonUserCode] get => this._txtRound07;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound07 = value;
    }
  }

  internal virtual TextBox txtRate013
  {
    [DebuggerNonUserCode] get => this._txtRate013;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate013 = value;
    }
  }

  internal virtual TextBox txtRound06
  {
    [DebuggerNonUserCode] get => this._txtRound06;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound06 = value;
    }
  }

  internal virtual TextBox txtRate014
  {
    [DebuggerNonUserCode] get => this._txtRate014;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate014 = value;
    }
  }

  internal virtual TextBox txtRound05
  {
    [DebuggerNonUserCode] get => this._txtRound05;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound05 = value;
    }
  }

  internal virtual TextBox txtRate015
  {
    [DebuggerNonUserCode] get => this._txtRate015;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate015 = value;
    }
  }

  internal virtual TextBox txtRound04
  {
    [DebuggerNonUserCode] get => this._txtRound04;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound04 = value;
    }
  }

  internal virtual TextBox txtRate016
  {
    [DebuggerNonUserCode] get => this._txtRate016;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate016 = value;
    }
  }

  internal virtual TextBox txtRound03
  {
    [DebuggerNonUserCode] get => this._txtRound03;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound03 = value;
    }
  }

  internal virtual TextBox txtRate017
  {
    [DebuggerNonUserCode] get => this._txtRate017;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate017 = value;
    }
  }

  internal virtual TextBox txtRound02
  {
    [DebuggerNonUserCode] get => this._txtRound02;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound02 = value;
    }
  }

  internal virtual TextBox txtRate018
  {
    [DebuggerNonUserCode] get => this._txtRate018;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate018 = value;
    }
  }

  internal virtual TextBox txtRound01
  {
    [DebuggerNonUserCode] get => this._txtRound01;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRound01 = value;
    }
  }

  internal virtual TextBox txtRate019
  {
    [DebuggerNonUserCode] get => this._txtRate019;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate019 = value;
    }
  }

  internal virtual TextBox txtRate021
  {
    [DebuggerNonUserCode] get => this._txtRate021;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate021 = value;
    }
  }

  internal virtual TextBox txtRate020
  {
    [DebuggerNonUserCode] get => this._txtRate020;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._txtRate020 = value;
    }
  }

  internal virtual GroupBox grpLimitApplicable
  {
    [DebuggerNonUserCode] get => this._grpLimitApplicable;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._grpLimitApplicable = value;
    }
  }

  internal virtual CheckBox chkl21
  {
    [DebuggerNonUserCode] get => this._chkl21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl21 = value;
  }

  internal virtual CheckBox chkl20
  {
    [DebuggerNonUserCode] get => this._chkl20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl20 = value;
  }

  internal virtual CheckBox chkl19
  {
    [DebuggerNonUserCode] get => this._chkl19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl19 = value;
  }

  internal virtual CheckBox chkl18
  {
    [DebuggerNonUserCode] get => this._chkl18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl18 = value;
  }

  internal virtual CheckBox chkl17
  {
    [DebuggerNonUserCode] get => this._chkl17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl17 = value;
  }

  internal virtual CheckBox chkl16
  {
    [DebuggerNonUserCode] get => this._chkl16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl16 = value;
  }

  internal virtual CheckBox chkl15
  {
    [DebuggerNonUserCode] get => this._chkl15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl15 = value;
  }

  internal virtual CheckBox chkl14
  {
    [DebuggerNonUserCode] get => this._chkl14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl14 = value;
  }

  internal virtual CheckBox chkl13
  {
    [DebuggerNonUserCode] get => this._chkl13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl13 = value;
  }

  internal virtual CheckBox chkl12
  {
    [DebuggerNonUserCode] get => this._chkl12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl12 = value;
  }

  internal virtual CheckBox chkl11
  {
    [DebuggerNonUserCode] get => this._chkl11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl11 = value;
  }

  internal virtual CheckBox chkl10
  {
    [DebuggerNonUserCode] get => this._chkl10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl10 = value;
  }

  internal virtual CheckBox chkl9
  {
    [DebuggerNonUserCode] get => this._chkl9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl9 = value;
  }

  internal virtual CheckBox chkl8
  {
    [DebuggerNonUserCode] get => this._chkl8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl8 = value;
  }

  internal virtual CheckBox chkl7
  {
    [DebuggerNonUserCode] get => this._chkl7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl7 = value;
  }

  internal virtual CheckBox chkl6
  {
    [DebuggerNonUserCode] get => this._chkl6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl6 = value;
  }

  internal virtual CheckBox chkl5
  {
    [DebuggerNonUserCode] get => this._chkl5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl5 = value;
  }

  internal virtual CheckBox chkl4
  {
    [DebuggerNonUserCode] get => this._chkl4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl4 = value;
  }

  internal virtual CheckBox chkl3
  {
    [DebuggerNonUserCode] get => this._chkl3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl3 = value;
  }

  internal virtual CheckBox chkl2
  {
    [DebuggerNonUserCode] get => this._chkl2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl2 = value;
  }

  internal virtual CheckBox chkl1
  {
    [DebuggerNonUserCode] get => this._chkl1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._chkl1 = value;
  }

  internal virtual Label Label25
  {
    [DebuggerNonUserCode] get => this._Label25;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label25 = value;
  }

  private void frmBillSetting_Load(object sender, EventArgs e)
  {
    this.lblAccCode1.Text = "-";
    this.lblAccCode2.Text = "-";
    this.lblAccCode3.Text = "-";
    this.lblAccCode4.Text = "-";
    this.lblAccCode5.Text = "-";
    this.lblAccCode6.Text = "-";
    this.lblAccCode7.Text = "-";
    this.lblAccCode8.Text = "-";
    this.lblAccCode9.Text = "-";
    this.lblAccCode10.Text = "-";
    this.lblAccCode11.Text = "-";
    this.lblAccCode12.Text = "-";
    this.lblAccCode13.Text = "-";
    this.lblAccCode14.Text = "-";
    this.lblAccCode15.Text = "-";
    this.lblAccCode16.Text = "-";
    this.lblAccCode17.Text = "-";
    this.lblAccCode18.Text = "-";
    this.lblAccCode19.Text = "-";
    this.lblAccCode20.Text = "-";
    this.lblAccCode21.Text = "-";
    this.lblName1.Text = "-";
    this.lblName2.Text = "-";
    this.lblName3.Text = "-";
    this.lblName4.Text = "-";
    this.lblName5.Text = "-";
    this.lblName6.Text = "-";
    this.lblName7.Text = "-";
    this.lblName8.Text = "-";
    this.lblName9.Text = "-";
    this.lblName10.Text = "-";
    this.lblName11.Text = "-";
    this.lblName12.Text = "-";
    this.lblName13.Text = "-";
    this.lblName14.Text = "-";
    this.lblName15.Text = "-";
    this.lblName16.Text = "-";
    this.lblName17.Text = "-";
    this.lblName18.Text = "-";
    this.lblName19.Text = "-";
    this.lblName20.Text = "-";
    this.lblName21.Text = "-";
    this.txtCode1.Text = "0";
    this.txtCode2.Text = "0";
    this.txtCode3.Text = "0";
    this.txtCode4.Text = "0";
    this.txtCode5.Text = "0";
    this.txtCode6.Text = "0";
    this.txtCode7.Text = "0";
    this.txtCode8.Text = "0";
    this.txtCode9.Text = "0";
    this.txtCode10.Text = "0";
    this.txtCode11.Text = "0";
    this.txtCode12.Text = "0";
    this.txtCode13.Text = "0";
    this.txtCode14.Text = "0";
    this.txtCode15.Text = "0";
    this.txtCode16.Text = "0";
    this.txtCode17.Text = "0";
    this.txtCode18.Text = "0";
    this.txtCode19.Text = "0";
    this.txtCode20.Text = "0";
    this.txtCode21.Text = "0";
    OleDbConnection selectConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbDataAdapter oleDbDataAdapter1 = new OleDbDataAdapter("SELECT SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccount.AccName, SocAccount.AccCode, SocBillSetting.IsGST, SocBillSetting.GSTRate, SocBillSetting.GSTRoundedupto, SocBillSetting.GSTRate0, SocBillSetting.GSTRoundedupto0, SocBillSetting.IsGSTLimit FROM (SocAccountMain INNER JOIN SocAccount ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId) INNER JOIN SocBillSetting ON SocAccount.SocAccountMainId = SocBillSetting.SocAccountMainId ORDER BY SocBillSetting.AccIndex", selectConnection);
    DataTable dataTable1 = new DataTable("SocBillSetting");
    oleDbDataAdapter1.Fill(dataTable1);
    this.DataGridView1.DataSource = (object) dataTable1;
    this.DataGridView1.ReadOnly = true;
    this.DataGridView1.RowHeadersVisible = false;
    this.DataGridView1.AllowUserToAddRows = false;
    OleDbDataAdapter oleDbDataAdapter2 = new OleDbDataAdapter("SELECT SocBillMaster.Amt01, SocBillMaster.Amt02, SocBillMaster.Amt03, SocBillMaster.Amt04, SocBillMaster.Amt05, SocBillMaster.Amt06, SocBillMaster.Amt07, SocBillMaster.Amt08, SocBillMaster.Amt09, SocBillMaster.Amt10, SocBillMaster.Amt11, SocBillMaster.Amt12, SocBillMaster.Amt13, SocBillMaster.Amt14, SocBillMaster.Amt15, SocBillMaster.Amt16, SocBillMaster.Amt17, SocBillMaster.Amt18, SocBillMaster.Amt19, SocBillMaster.Amt20, SocBillMaster.Amt21 FROM SocBillMaster", selectConnection);
    DataTable dataTable2 = new DataTable("SocBillMaster");
    oleDbDataAdapter2.Fill(dataTable2);
    this.DataGridView2.DataSource = (object) dataTable2;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    int num = checked (this.DataGridView1.RowCount - 1);
    int index = 0;
    while (index <= num)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 1, false))
      {
        this.txtCode1.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname1.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName1.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode1.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk1.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate1.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound1.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate01.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound01.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl1.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 2, false))
      {
        this.txtCode2.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname2.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName2.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode2.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk2.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate2.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound2.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate02.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound02.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl2.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 3, false))
      {
        this.txtCode3.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname3.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName3.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode3.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk3.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate3.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound3.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate03.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound03.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl3.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 4, false))
      {
        this.txtCode4.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname4.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName4.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode4.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk4.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate4.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound4.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate04.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound04.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl4.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 5, false))
      {
        this.txtCode5.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname5.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName5.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode5.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk5.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate5.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound5.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate05.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound05.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl5.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 6, false))
      {
        this.txtCode6.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname6.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName6.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode6.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk6.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate6.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound6.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate06.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound06.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl6.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 7, false))
      {
        this.txtCode7.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname7.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName7.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode7.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk7.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate7.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound7.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate07.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound07.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl7.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 8, false))
      {
        this.txtCode8.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname8.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName8.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode8.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk8.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate8.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound8.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate08.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound08.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl8.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 9, false))
      {
        this.txtCode9.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname9.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName9.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode9.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk9.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate9.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound9.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate09.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound09.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl9.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 10, false))
      {
        this.txtCode10.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname10.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName10.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode10.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk10.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate10.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound10.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate010.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound010.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl10.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 11, false))
      {
        this.txtCode11.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname11.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName11.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode11.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk11.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate11.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound11.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate011.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound011.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl11.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 12, false))
      {
        this.txtCode12.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname12.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName12.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode12.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk12.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate12.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound12.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate012.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound012.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl12.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 13, false))
      {
        this.txtCode13.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname13.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName13.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode13.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk13.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate13.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound13.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate013.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound013.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl13.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 14, false))
      {
        this.txtCode14.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname14.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName14.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode14.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk14.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate14.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound14.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate014.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound014.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl14.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 15, false))
      {
        this.txtCode15.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname15.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName15.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode15.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk15.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate15.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound15.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate015.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound015.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl15.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 16 /*0x10*/, false))
      {
        this.txtCode16.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname16.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName16.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode16.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk16.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate16.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound16.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate016.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound016.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl16.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 17, false))
      {
        this.txtCode17.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname17.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName17.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode17.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk17.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate17.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound17.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate017.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound017.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl17.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 18, false))
      {
        this.txtCode18.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname18.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName18.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode18.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk18.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate18.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound18.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate018.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound018.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl18.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 19, false))
      {
        this.txtCode19.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname19.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName19.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode19.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk19.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate19.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound19.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate019.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound019.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl19.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 20, false))
      {
        this.txtCode20.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname20.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName20.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode20.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk20.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate20.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound20.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate020.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound020.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl20.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.DataGridView1.Rows[index].Cells[1].Value, (object) 21, false))
      {
        this.txtCode21.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[0].Value);
        this.txtShname21.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[2].Value);
        this.lblName21.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[3].Value);
        this.lblAccCode21.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[4].Value);
        this.chk21.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[5].Value);
        this.txtRate21.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[6].Value);
        this.txtRound21.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[7].Value);
        this.txtRate021.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[8].Value);
        this.txtRound021.Text = Conversions.ToString(this.DataGridView1.Rows[index].Cells[9].Value);
        this.chkl21.Checked = Conversions.ToBoolean(this.DataGridView1.Rows[index].Cells[10].Value);
      }
      checked { ++index; }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.soconlinesrno.Trim().Substring(15, 3), "777", false) == 0)
    {
      this.grpLimitApplicable.Visible = true;
      this.grpGSTApplicable.Visible = true;
      this.grpGSTRate.Visible = true;
      this.btnSelect20.Visible = false;
      this.chk20.Visible = false;
      this.txtRate20.Visible = false;
      this.txtRound20.Visible = false;
      this.txtRate020.Visible = false;
      this.txtRound020.Visible = false;
      this.btnSelect21.Visible = false;
      this.chk21.Visible = false;
      this.txtRate21.Visible = false;
      this.txtRound21.Visible = false;
      this.txtRate021.Visible = false;
      this.txtRound021.Visible = false;
      this.chkl20.Visible = false;
      this.chkl21.Visible = false;
    }
    else
    {
      this.grpLimitApplicable.Visible = false;
      this.grpGSTApplicable.Visible = false;
      this.grpGSTRate.Visible = false;
      this.btnSelect20.Visible = true;
      this.btnSelect21.Visible = true;
    }
    this.grpVisible.Visible = false;
  }

  private void btnExit_Click(object sender, EventArgs e) => this.Close();

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode1.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname1.Text.Trim(), "", false) == 0)
    {
      int num1 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num1)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[0].Value)) != 0.0)
        {
          int num2 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.1 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode2.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname2.Text.Trim(), "", false) == 0)
    {
      int num3 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num3)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[1].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[1].Value)) != 0.0)
        {
          int num4 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.2 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode3.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname3.Text.Trim(), "", false) == 0)
    {
      int num5 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num5)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[2].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[2].Value)) != 0.0)
        {
          int num6 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.3 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode4.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname4.Text.Trim(), "", false) == 0)
    {
      int num7 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num7)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[3].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[3].Value)) != 0.0)
        {
          int num8 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.4 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode5.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname5.Text.Trim(), "", false) == 0)
    {
      int num9 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num9)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[4].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[4].Value)) != 0.0)
        {
          int num10 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.5 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode6.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname6.Text.Trim(), "", false) == 0)
    {
      int num11 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num11)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[5].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[5].Value)) != 0.0)
        {
          int num12 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.6 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode7.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname7.Text.Trim(), "", false) == 0)
    {
      int num13 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num13)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[6].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[6].Value)) != 0.0)
        {
          int num14 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.7 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode8.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname8.Text.Trim(), "", false) == 0)
    {
      int num15 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num15)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[7].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[7].Value)) != 0.0)
        {
          int num16 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.8 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode9.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname9.Text.Trim(), "", false) == 0)
    {
      int num17 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num17)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[8].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[8].Value)) != 0.0)
        {
          int num18 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.9 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode10.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname10.Text.Trim(), "", false) == 0)
    {
      int num19 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num19)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[9].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[9].Value)) != 0.0)
        {
          int num20 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.10 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode11.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname11.Text.Trim(), "", false) == 0)
    {
      int num21 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num21)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[10].Value)) != 0.0)
        {
          int num22 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.11 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode12.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname12.Text.Trim(), "", false) == 0)
    {
      int num23 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num23)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[11].Value)) != 0.0)
        {
          int num24 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.12 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode13.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname13.Text.Trim(), "", false) == 0)
    {
      int num25 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num25)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[12].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[12].Value)) != 0.0)
        {
          int num26 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.13 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode14.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname14.Text.Trim(), "", false) == 0)
    {
      int num27 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num27)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[13].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[13].Value)) != 0.0)
        {
          int num28 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.14 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode15.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname15.Text.Trim(), "", false) == 0)
    {
      int num29 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num29)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[14].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[14].Value)) != 0.0)
        {
          int num30 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.15 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode16.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname16.Text.Trim(), "", false) == 0)
    {
      int num31 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num31)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[15].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[15].Value)) != 0.0)
        {
          int num32 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.16 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode17.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname17.Text.Trim(), "", false) == 0)
    {
      int num33 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num33)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[16 /*0x10*/].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[16 /*0x10*/].Value)) != 0.0)
        {
          int num34 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.17 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode18.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname18.Text.Trim(), "", false) == 0)
    {
      int num35 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num35)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[17].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[17].Value)) != 0.0)
        {
          int num36 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.18 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode19.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname19.Text.Trim(), "", false) == 0)
    {
      int num37 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num37)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[18].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[18].Value)) != 0.0)
        {
          int num38 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.19 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode20.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname20.Text.Trim(), "", false) == 0)
    {
      int num39 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num39)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[19].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[19].Value)) != 0.0)
        {
          int num40 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.20 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode21.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname21.Text.Trim(), "", false) == 0)
    {
      int num41 = checked (this.DataGridView2.RowCount - 1);
      int index = 0;
      while (index <= num41)
      {
        if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[20].Value)) && Conversion.Val(RuntimeHelpers.GetObjectValue(this.DataGridView2.Rows[index].Cells[20].Value)) != 0.0)
        {
          int num42 = (int) Interaction.MsgBox((object) "Cannot Delete Bill Head No.21 First zero master");
          return;
        }
        checked { ++index; }
      }
    }
    if (!this.chk1.Checked)
      this.chkl1.Checked = false;
    if (!this.chk2.Checked)
      this.chkl2.Checked = false;
    if (!this.chk3.Checked)
      this.chkl3.Checked = false;
    if (!this.chk4.Checked)
      this.chkl4.Checked = false;
    if (!this.chk5.Checked)
      this.chkl5.Checked = false;
    if (!this.chk6.Checked)
      this.chkl6.Checked = false;
    if (!this.chk7.Checked)
      this.chkl7.Checked = false;
    if (!this.chk8.Checked)
      this.chkl8.Checked = false;
    if (!this.chk9.Checked)
      this.chkl9.Checked = false;
    if (!this.chk10.Checked)
      this.chkl10.Checked = false;
    if (!this.chk11.Checked)
      this.chkl11.Checked = false;
    if (!this.chk12.Checked)
      this.chkl12.Checked = false;
    if (!this.chk13.Checked)
      this.chkl13.Checked = false;
    if (!this.chk14.Checked)
      this.chkl14.Checked = false;
    if (!this.chk15.Checked)
      this.chkl15.Checked = false;
    if (!this.chk16.Checked)
      this.chkl16.Checked = false;
    if (!this.chk17.Checked)
      this.chkl17.Checked = false;
    if (!this.chk18.Checked)
      this.chkl18.Checked = false;
    if (!this.chk19.Checked)
      this.chkl19.Checked = false;
    if (!this.chk20.Checked)
      this.chkl20.Checked = false;
    if (!this.chk21.Checked)
      this.chkl21.Checked = false;
    OleDbConnection connection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}");
    OleDbCommand oleDbCommand1 = new OleDbCommand("Delete * FROM SocBillSetting", connection);
    connection.Open();
    oleDbCommand1.ExecuteNonQuery();
    connection.Close();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode1.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname1.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand2 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode1.Text))}',1,'{this.txtShname1.Text}',{Conversions.ToString(this.chk1.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate1.Text))},{Conversions.ToString(Conversion.Val(this.txtRound1.Text))},{Conversions.ToString(Conversion.Val(this.txtRate01.Text))},{Conversions.ToString(Conversion.Val(this.txtRound01.Text))},{Conversions.ToString(this.chkl1.Checked)})", connection);
      connection.Open();
      oleDbCommand2.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode2.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname2.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand3 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode2.Text))}',2,'{this.txtShname2.Text}',{Conversions.ToString(this.chk2.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate2.Text))},{Conversions.ToString(Conversion.Val(this.txtRound2.Text))},{Conversions.ToString(Conversion.Val(this.txtRate02.Text))},{Conversions.ToString(Conversion.Val(this.txtRound02.Text))},{Conversions.ToString(this.chkl2.Checked)})", connection);
      connection.Open();
      oleDbCommand3.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode3.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname3.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand4 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode3.Text))}',3,'{this.txtShname3.Text}',{Conversions.ToString(this.chk3.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate3.Text))},{Conversions.ToString(Conversion.Val(this.txtRound3.Text))},{Conversions.ToString(Conversion.Val(this.txtRate03.Text))},{Conversions.ToString(Conversion.Val(this.txtRound03.Text))},{Conversions.ToString(this.chkl3.Checked)})", connection);
      connection.Open();
      oleDbCommand4.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode4.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname4.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand5 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode4.Text))}',4,'{this.txtShname4.Text}',{Conversions.ToString(this.chk4.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate4.Text))},{Conversions.ToString(Conversion.Val(this.txtRound4.Text))},{Conversions.ToString(Conversion.Val(this.txtRate04.Text))},{Conversions.ToString(Conversion.Val(this.txtRound04.Text))},{Conversions.ToString(this.chkl4.Checked)})", connection);
      connection.Open();
      oleDbCommand5.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode5.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname5.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand6 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode5.Text))}',5,'{this.txtShname5.Text}',{Conversions.ToString(this.chk5.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate5.Text))},{Conversions.ToString(Conversion.Val(this.txtRound5.Text))},{Conversions.ToString(Conversion.Val(this.txtRate05.Text))},{Conversions.ToString(Conversion.Val(this.txtRound05.Text))},{Conversions.ToString(this.chkl5.Checked)})", connection);
      connection.Open();
      oleDbCommand6.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode6.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname6.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand7 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode6.Text))}',6,'{this.txtShname6.Text}',{Conversions.ToString(this.chk6.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate6.Text))},{Conversions.ToString(Conversion.Val(this.txtRound6.Text))},{Conversions.ToString(Conversion.Val(this.txtRate06.Text))},{Conversions.ToString(Conversion.Val(this.txtRound06.Text))},{Conversions.ToString(this.chkl6.Checked)})", connection);
      connection.Open();
      oleDbCommand7.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode7.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname7.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand8 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode7.Text))}',7,'{this.txtShname7.Text}',{Conversions.ToString(this.chk7.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate7.Text))},{Conversions.ToString(Conversion.Val(this.txtRound7.Text))},{Conversions.ToString(Conversion.Val(this.txtRate07.Text))},{Conversions.ToString(Conversion.Val(this.txtRound07.Text))},{Conversions.ToString(this.chkl7.Checked)})", connection);
      connection.Open();
      oleDbCommand8.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode8.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname8.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand9 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode8.Text))}',8,'{this.txtShname8.Text}',{Conversions.ToString(this.chk8.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate8.Text))},{Conversions.ToString(Conversion.Val(this.txtRound8.Text))},{Conversions.ToString(Conversion.Val(this.txtRate08.Text))},{Conversions.ToString(Conversion.Val(this.txtRound08.Text))},{Conversions.ToString(this.chkl8.Checked)})", connection);
      connection.Open();
      oleDbCommand9.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode9.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname9.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand10 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode9.Text))}',9,'{this.txtShname9.Text}',{Conversions.ToString(this.chk9.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate9.Text))},{Conversions.ToString(Conversion.Val(this.txtRound9.Text))},{Conversions.ToString(Conversion.Val(this.txtRate09.Text))},{Conversions.ToString(Conversion.Val(this.txtRound09.Text))},{Conversions.ToString(this.chkl9.Checked)})", connection);
      connection.Open();
      oleDbCommand10.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode10.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname10.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand11 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode10.Text))}',10,'{this.txtShname10.Text}',{Conversions.ToString(this.chk10.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate10.Text))},{Conversions.ToString(Conversion.Val(this.txtRound10.Text))},{Conversions.ToString(Conversion.Val(this.txtRate010.Text))},{Conversions.ToString(Conversion.Val(this.txtRound010.Text))},{Conversions.ToString(this.chkl10.Checked)})", connection);
      connection.Open();
      oleDbCommand11.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode11.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname11.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand12 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode11.Text))}',11,'{this.txtShname11.Text}',{Conversions.ToString(this.chk11.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate11.Text))},{Conversions.ToString(Conversion.Val(this.txtRound11.Text))},{Conversions.ToString(Conversion.Val(this.txtRate011.Text))},{Conversions.ToString(Conversion.Val(this.txtRound011.Text))},{Conversions.ToString(this.chkl11.Checked)})", connection);
      connection.Open();
      oleDbCommand12.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode12.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname12.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand13 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode12.Text))}',12,'{this.txtShname12.Text}',{Conversions.ToString(this.chk12.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate12.Text))},{Conversions.ToString(Conversion.Val(this.txtRound12.Text))},{Conversions.ToString(Conversion.Val(this.txtRate012.Text))},{Conversions.ToString(Conversion.Val(this.txtRound012.Text))},{Conversions.ToString(this.chkl12.Checked)})", connection);
      connection.Open();
      oleDbCommand13.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode13.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname13.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand14 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode13.Text))}',13,'{this.txtShname13.Text}',{Conversions.ToString(this.chk13.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate13.Text))},{Conversions.ToString(Conversion.Val(this.txtRound13.Text))},{Conversions.ToString(Conversion.Val(this.txtRate013.Text))},{Conversions.ToString(Conversion.Val(this.txtRound013.Text))},{Conversions.ToString(this.chkl13.Checked)})", connection);
      connection.Open();
      oleDbCommand14.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode14.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname14.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand15 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode14.Text))}',14,'{this.txtShname14.Text}',{Conversions.ToString(this.chk14.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate14.Text))},{Conversions.ToString(Conversion.Val(this.txtRound14.Text))},{Conversions.ToString(Conversion.Val(this.txtRate014.Text))},{Conversions.ToString(Conversion.Val(this.txtRound014.Text))},{Conversions.ToString(this.chkl14.Checked)})", connection);
      connection.Open();
      oleDbCommand15.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode15.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname15.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand16 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode15.Text))}',15,'{this.txtShname15.Text}',{Conversions.ToString(this.chk15.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate15.Text))},{Conversions.ToString(Conversion.Val(this.txtRound15.Text))},{Conversions.ToString(Conversion.Val(this.txtRate015.Text))},{Conversions.ToString(Conversion.Val(this.txtRound015.Text))},{Conversions.ToString(this.chkl15.Checked)})", connection);
      connection.Open();
      oleDbCommand16.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode16.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname16.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand17 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode16.Text))}',16,'{this.txtShname16.Text}',{Conversions.ToString(this.chk16.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate16.Text))},{Conversions.ToString(Conversion.Val(this.txtRound16.Text))},{Conversions.ToString(Conversion.Val(this.txtRate016.Text))},{Conversions.ToString(Conversion.Val(this.txtRound016.Text))},{Conversions.ToString(this.chkl16.Checked)})", connection);
      connection.Open();
      oleDbCommand17.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode17.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname17.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand18 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode17.Text))}',17,'{this.txtShname17.Text}',{Conversions.ToString(this.chk17.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate17.Text))},{Conversions.ToString(Conversion.Val(this.txtRound17.Text))},{Conversions.ToString(Conversion.Val(this.txtRate017.Text))},{Conversions.ToString(Conversion.Val(this.txtRound017.Text))},{Conversions.ToString(this.chkl17.Checked)})", connection);
      connection.Open();
      oleDbCommand18.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode18.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname18.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand19 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode18.Text))}',18,'{this.txtShname18.Text}',{Conversions.ToString(this.chk18.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate18.Text))},{Conversions.ToString(Conversion.Val(this.txtRound18.Text))},{Conversions.ToString(Conversion.Val(this.txtRate018.Text))},{Conversions.ToString(Conversion.Val(this.txtRound018.Text))},{Conversions.ToString(this.chkl18.Checked)})", connection);
      connection.Open();
      oleDbCommand19.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode19.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname19.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand20 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode19.Text))}',19,'{this.txtShname19.Text}',{Conversions.ToString(this.chk19.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate19.Text))},{Conversions.ToString(Conversion.Val(this.txtRound19.Text))},{Conversions.ToString(Conversion.Val(this.txtRate019.Text))},{Conversions.ToString(Conversion.Val(this.txtRound019.Text))},{Conversions.ToString(this.chkl19.Checked)})", connection);
      connection.Open();
      oleDbCommand20.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode20.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname20.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand21 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode20.Text))}',20,'{this.txtShname20.Text}',{Conversions.ToString(this.chk20.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate20.Text))},{Conversions.ToString(Conversion.Val(this.txtRound20.Text))},{Conversions.ToString(Conversion.Val(this.txtRate020.Text))},{Conversions.ToString(Conversion.Val(this.txtRound020.Text))},{Conversions.ToString(this.chkl20.Checked)})", connection);
      connection.Open();
      oleDbCommand21.ExecuteNonQuery();
      connection.Close();
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCode21.Text, "0", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtShname21.Text.Trim(), "", false) != 0)
    {
      OleDbCommand oleDbCommand22 = new OleDbCommand($"Insert Into SocBillSetting (SocAccountMainId, AccIndex, AccShortName, IsGST, GSTRate, GSTRoundedupto, GSTRate0, GSTRoundedupto0, IsGSTLimit ) values ('{Conversions.ToString(Conversion.Val(this.txtCode21.Text))}',21,'{this.txtShname21.Text}',{Conversions.ToString(this.chk21.Checked)},{Conversions.ToString(Conversion.Val(this.txtRate21.Text))},{Conversions.ToString(Conversion.Val(this.txtRound21.Text))},{Conversions.ToString(Conversion.Val(this.txtRate021.Text))},{Conversions.ToString(Conversion.Val(this.txtRound021.Text))},{Conversions.ToString(this.chkl21.Checked)})", connection);
      connection.Open();
      oleDbCommand22.ExecuteNonQuery();
      connection.Close();
    }
    connection.Close();
    this.Close();
  }

  private void Button1_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName1.Text, "-", false) == 0 ? "" : this.lblAccCode1.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode1.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName1.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect2_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName2.Text, "-", false) == 0 ? "" : this.lblAccCode2.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode2.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName2.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect3_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName3.Text, "-", false) == 0 ? "" : this.lblAccCode3.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode3.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName3.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect4_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName4.Text, "-", false) == 0 ? "" : this.lblAccCode4.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode4.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName4.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect5_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName5.Text, "-", false) == 0 ? "" : this.lblAccCode5.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode5.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName5.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect6_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName6.Text, "-", false) == 0 ? "" : this.lblAccCode6.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode6.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName6.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect7_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName7.Text, "-", false) == 0 ? "" : this.lblAccCode7.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode7.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName7.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect8_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName8.Text, "-", false) == 0 ? "" : this.lblAccCode8.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode8.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName8.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect9_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName9.Text, "-", false) == 0 ? "" : this.lblAccCode9.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode9.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName9.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect10_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName10.Text, "-", false) == 0 ? "" : this.lblAccCode10.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode10.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName10.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect11_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName11.Text, "-", false) == 0 ? "" : this.lblAccCode11.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode11.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName11.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect12_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName12.Text, "-", false) == 0 ? "" : this.lblAccCode12.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode12.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName12.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect13_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName13.Text, "-", false) == 0 ? "" : this.lblAccCode13.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode13.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName13.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect14_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName14.Text, "-", false) == 0 ? "" : this.lblAccCode14.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode14.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName14.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect15_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName15.Text, "-", false) == 0 ? "" : this.lblAccCode15.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode15.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName15.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect16_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName16.Text, "-", false) == 0 ? "" : this.lblAccCode16.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode16.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName16.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect17_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName17.Text, "-", false) == 0 ? "" : this.lblAccCode17.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode17.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName17.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect18_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName18.Text, "-", false) == 0 ? "" : this.lblAccCode18.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode18.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName18.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect19_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName19.Text, "-", false) == 0 ? "" : this.lblAccCode19.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode19.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName19.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect20_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName20.Text, "-", false) == 0 ? "" : this.lblAccCode20.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode20.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName20.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void btnSelect21_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "P";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) - 1.0);
    Constant.SearchStr = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblName21.Text, "-", false) == 0 ? "" : this.lblAccCode21.Text;
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    if (Constant.SearchStat & MyProject.Forms.frmAccount.DataGridView2.SelectedRows.Count == 1)
    {
      this.txtCode21.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[0].Value);
      this.lblName21.Text = Conversions.ToString(MyProject.Forms.frmAccount.DataGridView2.CurrentRow.Cells[2].Value);
    }
    Constant.SearchStat = false;
    Constant.SearchStr = "";
  }

  private void Button2_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }
}
