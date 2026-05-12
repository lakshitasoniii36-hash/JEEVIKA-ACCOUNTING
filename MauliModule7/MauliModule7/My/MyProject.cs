// Decompiled with JetBrains decompiler
// Type: MauliModule7.My.MyProject
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7.My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class MyProject
{
  private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
  private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
  private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
  private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

  [DebuggerNonUserCode]
  static MyProject()
  {
  }

  [HelpKeyword("My.Computer")]
  internal static MyComputer Computer
  {
    [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
  }

  [HelpKeyword("My.Application")]
  internal static MyApplication Application
  {
    [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
  }

  [HelpKeyword("My.User")]
  internal static User User
  {
    [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
  }

  [HelpKeyword("My.Forms")]
  internal static MyProject.MyForms Forms
  {
    [DebuggerHidden] get => MyProject.m_MyFormsObjectProvider.GetInstance;
  }

  [HelpKeyword("My.WebServices")]
  internal static MyProject.MyWebServices WebServices
  {
    [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
  internal sealed class MyForms
  {
    public DeleteDialog m_DeleteDialog;
    public Dialog1 m_Dialog1;
    public frmAboutUs m_frmAboutUs;
    public frmAboutUsMenu m_frmAboutUsMenu;
    public frmAccount m_frmAccount;
    public frmAccountDetail m_frmAccountDetail;
    public frmAccountDetailDirect m_frmAccountDetailDirect;
    public frmAllGroup m_frmAllGroup;
    public frmAlterNo m_frmAlterNo;
    public frmAlterNoVendor m_frmAlterNoVendor;
    public frmAutoBill m_frmAutoBill;
    public frmAutoBillChange m_frmAutoBillChange;
    public frmAutoBillDelete m_frmAutoBillDelete;
    public frmBackUp m_frmBackUp;
    public frmBankReco m_frmBankReco;
    public frmBillMasterOnOff m_frmBillMasterOnOff;
    public frmBillSetting m_frmBillSetting;
    public frmBOA m_frmBOA;
    public frmBOADetail m_frmBOADetail;
    public frmCalculate m_frmCalculate;
    public frmCalculateDayWise m_frmCalculateDayWise;
    public frmCheckDiff m_frmCheckDiff;
    public frmCloseConfirm m_frmCloseConfirm;
    public frmCommittee m_frmCommittee;
    public frmCommitteeDetail m_frmCommitteeDetail;
    public frmCommitteeList m_frmCommitteeList;
    public frmConstantGrid m_frmConstantGrid;
    public frmCRShow m_frmCRShow;
    public frmDefaultGroupSetting m_frmDefaultGroupSetting;
    public frmDeleteFolder m_frmDeleteFolder;
    public frmDigAccountSelection m_frmDigAccountSelection;
    public frmDigAutoMasterAdd m_frmDigAutoMasterAdd;
    public frmDigMemberSelection m_frmDigMemberSelection;
    public frmDigMemberSelection1 m_frmDigMemberSelection1;
    public frmDigNumber m_frmDigNumber;
    public frmDigNumberJreg m_frmDigNumberJreg;
    public frmDigNumberRange m_frmDigNumberRange;
    public frmDigNumberStat m_frmDigNumberStat;
    public frmDigPeriodRange m_frmDigPeriodRange;
    public frmDigPeriodRangeRec m_frmDigPeriodRangeRec;
    public frmDigPeriodRangeUpto m_frmDigPeriodRangeUpto;
    public frmDigSearch m_frmDigSearch;
    public frmEmailCommittee m_frmEmailCommittee;
    public frmEmailMember m_frmEmailMember;
    public frmEmailMemberAccount m_frmEmailMemberAccount;
    public frmEmailSetting m_frmEmailSetting;
    public frmFDRDetail m_frmFDRDetail;
    public frmFDRReminder m_frmFDRReminder;
    public frmFlatTransfer m_frmFlatTransfer;
    public frmFlatTransferDetail m_frmFlatTransferDetail;
    public frmGroup m_frmGroup;
    public frmGroupDetail m_frmGroupDetail;
    public frmGroupDetailDirect m_frmGroupDetailDirect;
    public frmGSTCalculate m_frmGSTCalculate;
    public frmImportBankList m_frmImportBankList;
    public frmImportMemberMaster m_frmImportMemberMaster;
    public frmImportMemberReceipt m_frmImportMemberReceipt;
    public frmImportPayment m_frmImportPayment;
    public frmImportReceipt m_frmImportReceipt;
    public frmImportStatMaster m_frmImportStatMaster;
    public frmJournal m_frmJournal;
    public frmJournalDetail m_frmJournalDetail;
    public frmJournalDetailDirect m_frmJournalDetailDirect;
    public frmListCall m_frmListCall;
    public frmListcashaccount m_frmListcashaccount;
    public frmListGroup m_frmListGroup;
    public frmListMember m_frmListMember;
    public frmMember m_frmMember;
    public frmMember1 m_frmMember1;
    public frmMemberBillMaster m_frmMemberBillMaster;
    public frmMemberBillMasterSelect m_frmMemberBillMasterSelect;
    public frmMemberdetails m_frmMemberdetails;
    public frmMemberdetailsDirect m_frmMemberdetailsDirect;
    public frmMemberElectionListReport m_frmMemberElectionListReport;
    public frmMemberExportList m_frmMemberExportList;
    public frmMemberJournalDetail m_frmMemberJournalDetail;
    public frmMemberListReport m_frmMemberListReport;
    public frmMemberListTransferReport m_frmMemberListTransferReport;
    public frmMemberMaster m_frmMemberMaster;
    public frmMemberMasterSelected m_frmMemberMasterSelected;
    public frmMemberShowdetails m_frmMemberShowdetails;
    public frmMemBilldetail m_frmMemBilldetail;
    public frmMemBilldetailDirect m_frmMemBilldetailDirect;
    public frmMemBilling m_frmMemBilling;
    public frmMemReceipt m_frmMemReceipt;
    public frmMemReceiptDetail m_frmMemReceiptDetail;
    public frmMemReceiptDetailBif m_frmMemReceiptDetailBif;
    public frmMemReceiptDetailBifDirect m_frmMemReceiptDetailBifDirect;
    public frmMemReceiptDetailDirect m_frmMemReceiptDetailDirect;
    public frmMenu m_frmMenu;
    public frmMultiReceiptMaster m_frmMultiReceiptMaster;
    public frmMultiReceiptMaster1 m_frmMultiReceiptMaster1;
    public frmMultiReceiptMemberSelect m_frmMultiReceiptMemberSelect;
    public frmMultiReceiptMemberSelect1 m_frmMultiReceiptMemberSelect1;
    public frmOpeningBalance m_frmOpeningBalance;
    public frmOpeningRecoDetail m_frmOpeningRecoDetail;
    public frmPartList m_frmPartList;
    public frmPath m_frmPath;
    public frmPathListAdd m_frmPathListAdd;
    public frmPayment m_frmPayment;
    public frmPaymentDetails m_frmPaymentDetails;
    public frmPaymentDetailsDirect m_frmPaymentDetailsDirect;
    public frmPaymentVerify m_frmPaymentVerify;
    public frmRebuild m_frmRebuild;
    public frmReceipt m_frmReceipt;
    public frmReceiptDetails m_frmReceiptDetails;
    public frmRenumber m_frmRenumber;
    public frmRenumberConfirmDialog m_frmRenumberConfirmDialog;
    public frmReportAccountCashBank m_frmReportAccountCashBank;
    public frmReportAccountLedger m_frmReportAccountLedger;
    public frmReportAccountLedgerNew m_frmReportAccountLedgerNew;
    public frmReportAccountLedgerNewGroup m_frmReportAccountLedgerNewGroup;
    public frmReportAccountLedgerShow m_frmReportAccountLedgerShow;
    public frmreportAccountList m_frmreportAccountList;
    public frmReportBalanceSheet m_frmReportBalanceSheet;
    public frmReportBalanceSheetMarathi m_frmReportBalanceSheetMarathi;
    public frmReportBankReco m_frmReportBankReco;
    public frmReportBillDetail m_frmReportBillDetail;
    public frmReportBillFullPage m_frmReportBillFullPage;
    public frmReportBillWithReceipt m_frmReportBillWithReceipt;
    public frmReportFundRegister m_frmReportFundRegister;
    public frmReportGroupList m_frmReportGroupList;
    public frmReportIncomeExpenditure m_frmReportIncomeExpenditure;
    public frmReportIncomeExpenditureMarathi m_frmReportIncomeExpenditureMarathi;
    public frmReportMemAcc m_frmReportMemAcc;
    public frmReportMemberAccountNew m_frmReportMemberAccountNew;
    public frmReportMemberAdjustmentPrint m_frmReportMemberAdjustmentPrint;
    public frmReportMemberBillRegisterNew m_frmReportMemberBillRegisterNew;
    public frmReportMemberBillRegisterNewGST m_frmReportMemberBillRegisterNewGST;
    public frmReportMemberBillRegisterNewReceipt m_frmReportMemberBillRegisterNewReceipt;
    public frmReportMemberConfirmationNew m_frmReportMemberConfirmationNew;
    public frmReportMemberControlAccount m_frmReportMemberControlAccount;
    public frmReportMemberMemberRegisterNew m_frmReportMemberMemberRegisterNew;
    public frmReportMemberOutstandingNew m_frmReportMemberOutstandingNew;
    public frmReportMemberReceipt m_frmReportMemberReceipt;
    public frmReportMemberReceiptPrint m_frmReportMemberReceiptPrint;
    public frmReportMemHeadwiseList m_frmReportMemHeadwiseList;
    public frmReportMemList m_frmReportMemList;
    public frmReportMemSignList m_frmReportMemSignList;
    public frmReportMonthly m_frmReportMonthly;
    public frmReportPayment m_frmReportPayment;
    public frmReportPVRegister m_frmReportPVRegister;
    public frmReportReceiptPayment m_frmReportReceiptPayment;
    public frmReportReceiptPaymentGroup m_frmReportReceiptPaymentGroup;
    public frmReportReceiptPaymentMarathi m_frmReportReceiptPaymentMarathi;
    public frmReportSchedule m_frmReportSchedule;
    public FrmReportTrialBalance m_FrmReportTrialBalance;
    public frmReportUpload m_frmReportUpload;
    public frmReportVoucherCheck m_frmReportVoucherCheck;
    public frmServantDetail m_frmServantDetail;
    public frmSocietyDetail m_frmSocietyDetail;
    public frmSocietyMaster m_frmSocietyMaster;
    public frmSocietyMasterBillPrintSet m_frmSocietyMasterBillPrintSet;
    public frmSocietyMasterGST m_frmSocietyMasterGST;
    public frmSocietyMasterReceipt m_frmSocietyMasterReceipt;
    public frmSocietyMasterRecRek m_frmSocietyMasterRecRek;
    public frmSocLockInfo m_frmSocLockInfo;
    public frmSocLoginInfo m_frmSocLoginInfo;
    public frmSocSelection m_frmSocSelection;
    public frmSocSelectionChange m_frmSocSelectionChange;
    public frmStatIDetail m_frmStatIDetail;
    public frmStatIList m_frmStatIList;
    public frmStatINDetail m_frmStatINDetail;
    public frmStatINList m_frmStatINList;
    public frmStatJDetails m_frmStatJDetails;
    public frmStatJList m_frmStatJList;
    public frmStatMemberDetail m_frmStatMemberDetail;
    public frmStatMemberList m_frmStatMemberList;
    public frmStatNDetail m_frmStatNDetail;
    public frmStatNList m_frmStatNList;
    public frmStatPDetail m_frmStatPDetail;
    public frmStatPList m_frmStatPList;
    public frmStatSDetail m_frmStatSDetail;
    public frmStatSIDetail m_frmStatSIDetail;
    public frmStatSIList m_frmStatSIList;
    public frmStatSList m_frmStatSList;
    public frmStatSocietyDetail m_frmStatSocietyDetail;
    public frmSubGroup m_frmSubGroup;
    public frmSubGroupDetail m_frmSubGroupDetail;
    public frmTEST m_frmTEST;
    public frmtest1 m_frmtest1;
    public frmTransfer m_frmTransfer;
    public frmTranType m_frmTranType;
    public frmTranTypeAdd m_frmTranTypeAdd;
    public frmTranTypeDetail m_frmTranTypeDetail;
    public frmVendor m_frmVendor;
    public frmVendorDetail m_frmVendorDetail;
    public frmWhatsupCommittee m_frmWhatsupCommittee;
    public frmWhatsupMemberAccount m_frmWhatsupMemberAccount;
    public frmWhatsupSetting m_frmWhatsupSetting;
    public frmYearBf m_frmYearBf;
    public frmYearcf m_frmYearcf;
    public frmYearExten m_frmYearExten;
    public frmZerowise m_frmZerowise;
    public ILISTMultiple m_ILISTMultiple;
    public JLISTMulti m_JLISTMulti;
    public LoginDetails m_LoginDetails;
    public LoginForm1 m_LoginForm1;
    public OverwirteDialog m_OverwirteDialog;
    public SLISTMultiple m_SLISTMultiple;
    public SocietyBfDialog m_SocietyBfDialog;
    public SocietyDeleteDialog m_SocietyDeleteDialog;
    public SplashScreen1 m_SplashScreen1;
    public UpdateChangesDialog m_UpdateChangesDialog;
    public WarningDialog m_WarningDialog;
    [ThreadStatic]
    private static Hashtable m_FormBeingCreated;

    public DeleteDialog DeleteDialog
    {
      [DebuggerNonUserCode] get
      {
        this.m_DeleteDialog = MyProject.MyForms.Create__Instance__<DeleteDialog>(this.m_DeleteDialog);
        return this.m_DeleteDialog;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_DeleteDialog)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<DeleteDialog>(ref this.m_DeleteDialog);
      }
    }

    public Dialog1 Dialog1
    {
      [DebuggerNonUserCode] get
      {
        this.m_Dialog1 = MyProject.MyForms.Create__Instance__<Dialog1>(this.m_Dialog1);
        return this.m_Dialog1;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_Dialog1)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<Dialog1>(ref this.m_Dialog1);
      }
    }

    public frmAboutUs frmAboutUs
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmAboutUs = MyProject.MyForms.Create__Instance__<frmAboutUs>(this.m_frmAboutUs);
        return this.m_frmAboutUs;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmAboutUs)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmAboutUs>(ref this.m_frmAboutUs);
      }
    }

    public frmAboutUsMenu frmAboutUsMenu
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmAboutUsMenu = MyProject.MyForms.Create__Instance__<frmAboutUsMenu>(this.m_frmAboutUsMenu);
        return this.m_frmAboutUsMenu;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmAboutUsMenu)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmAboutUsMenu>(ref this.m_frmAboutUsMenu);
      }
    }

    public frmAccount frmAccount
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmAccount = MyProject.MyForms.Create__Instance__<frmAccount>(this.m_frmAccount);
        return this.m_frmAccount;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmAccount)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmAccount>(ref this.m_frmAccount);
      }
    }

    public frmAccountDetail frmAccountDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmAccountDetail = MyProject.MyForms.Create__Instance__<frmAccountDetail>(this.m_frmAccountDetail);
        return this.m_frmAccountDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmAccountDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmAccountDetail>(ref this.m_frmAccountDetail);
      }
    }

    public frmAccountDetailDirect frmAccountDetailDirect
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmAccountDetailDirect = MyProject.MyForms.Create__Instance__<frmAccountDetailDirect>(this.m_frmAccountDetailDirect);
        return this.m_frmAccountDetailDirect;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmAccountDetailDirect)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmAccountDetailDirect>(ref this.m_frmAccountDetailDirect);
      }
    }

    public frmAllGroup frmAllGroup
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmAllGroup = MyProject.MyForms.Create__Instance__<frmAllGroup>(this.m_frmAllGroup);
        return this.m_frmAllGroup;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmAllGroup)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmAllGroup>(ref this.m_frmAllGroup);
      }
    }

    public frmAlterNo frmAlterNo
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmAlterNo = MyProject.MyForms.Create__Instance__<frmAlterNo>(this.m_frmAlterNo);
        return this.m_frmAlterNo;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmAlterNo)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmAlterNo>(ref this.m_frmAlterNo);
      }
    }

    public frmAlterNoVendor frmAlterNoVendor
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmAlterNoVendor = MyProject.MyForms.Create__Instance__<frmAlterNoVendor>(this.m_frmAlterNoVendor);
        return this.m_frmAlterNoVendor;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmAlterNoVendor)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmAlterNoVendor>(ref this.m_frmAlterNoVendor);
      }
    }

    public frmAutoBill frmAutoBill
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmAutoBill = MyProject.MyForms.Create__Instance__<frmAutoBill>(this.m_frmAutoBill);
        return this.m_frmAutoBill;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmAutoBill)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmAutoBill>(ref this.m_frmAutoBill);
      }
    }

    public frmAutoBillChange frmAutoBillChange
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmAutoBillChange = MyProject.MyForms.Create__Instance__<frmAutoBillChange>(this.m_frmAutoBillChange);
        return this.m_frmAutoBillChange;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmAutoBillChange)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmAutoBillChange>(ref this.m_frmAutoBillChange);
      }
    }

    public frmAutoBillDelete frmAutoBillDelete
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmAutoBillDelete = MyProject.MyForms.Create__Instance__<frmAutoBillDelete>(this.m_frmAutoBillDelete);
        return this.m_frmAutoBillDelete;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmAutoBillDelete)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmAutoBillDelete>(ref this.m_frmAutoBillDelete);
      }
    }

    public frmBackUp frmBackUp
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmBackUp = MyProject.MyForms.Create__Instance__<frmBackUp>(this.m_frmBackUp);
        return this.m_frmBackUp;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmBackUp)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmBackUp>(ref this.m_frmBackUp);
      }
    }

    public frmBankReco frmBankReco
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmBankReco = MyProject.MyForms.Create__Instance__<frmBankReco>(this.m_frmBankReco);
        return this.m_frmBankReco;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmBankReco)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmBankReco>(ref this.m_frmBankReco);
      }
    }

    public frmBillMasterOnOff frmBillMasterOnOff
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmBillMasterOnOff = MyProject.MyForms.Create__Instance__<frmBillMasterOnOff>(this.m_frmBillMasterOnOff);
        return this.m_frmBillMasterOnOff;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmBillMasterOnOff)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmBillMasterOnOff>(ref this.m_frmBillMasterOnOff);
      }
    }

    public frmBillSetting frmBillSetting
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmBillSetting = MyProject.MyForms.Create__Instance__<frmBillSetting>(this.m_frmBillSetting);
        return this.m_frmBillSetting;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmBillSetting)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmBillSetting>(ref this.m_frmBillSetting);
      }
    }

    public frmBOA frmBOA
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmBOA = MyProject.MyForms.Create__Instance__<frmBOA>(this.m_frmBOA);
        return this.m_frmBOA;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmBOA)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmBOA>(ref this.m_frmBOA);
      }
    }

    public frmBOADetail frmBOADetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmBOADetail = MyProject.MyForms.Create__Instance__<frmBOADetail>(this.m_frmBOADetail);
        return this.m_frmBOADetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmBOADetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmBOADetail>(ref this.m_frmBOADetail);
      }
    }

    public frmCalculate frmCalculate
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmCalculate = MyProject.MyForms.Create__Instance__<frmCalculate>(this.m_frmCalculate);
        return this.m_frmCalculate;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmCalculate)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmCalculate>(ref this.m_frmCalculate);
      }
    }

    public frmCalculateDayWise frmCalculateDayWise
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmCalculateDayWise = MyProject.MyForms.Create__Instance__<frmCalculateDayWise>(this.m_frmCalculateDayWise);
        return this.m_frmCalculateDayWise;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmCalculateDayWise)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmCalculateDayWise>(ref this.m_frmCalculateDayWise);
      }
    }

    public frmCheckDiff frmCheckDiff
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmCheckDiff = MyProject.MyForms.Create__Instance__<frmCheckDiff>(this.m_frmCheckDiff);
        return this.m_frmCheckDiff;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmCheckDiff)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmCheckDiff>(ref this.m_frmCheckDiff);
      }
    }

    public frmCloseConfirm frmCloseConfirm
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmCloseConfirm = MyProject.MyForms.Create__Instance__<frmCloseConfirm>(this.m_frmCloseConfirm);
        return this.m_frmCloseConfirm;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmCloseConfirm)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmCloseConfirm>(ref this.m_frmCloseConfirm);
      }
    }

    public frmCommittee frmCommittee
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmCommittee = MyProject.MyForms.Create__Instance__<frmCommittee>(this.m_frmCommittee);
        return this.m_frmCommittee;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmCommittee)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmCommittee>(ref this.m_frmCommittee);
      }
    }

    public frmCommitteeDetail frmCommitteeDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmCommitteeDetail = MyProject.MyForms.Create__Instance__<frmCommitteeDetail>(this.m_frmCommitteeDetail);
        return this.m_frmCommitteeDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmCommitteeDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmCommitteeDetail>(ref this.m_frmCommitteeDetail);
      }
    }

    public frmCommitteeList frmCommitteeList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmCommitteeList = MyProject.MyForms.Create__Instance__<frmCommitteeList>(this.m_frmCommitteeList);
        return this.m_frmCommitteeList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmCommitteeList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmCommitteeList>(ref this.m_frmCommitteeList);
      }
    }

    public frmConstantGrid frmConstantGrid
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmConstantGrid = MyProject.MyForms.Create__Instance__<frmConstantGrid>(this.m_frmConstantGrid);
        return this.m_frmConstantGrid;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmConstantGrid)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmConstantGrid>(ref this.m_frmConstantGrid);
      }
    }

    public frmCRShow frmCRShow
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmCRShow = MyProject.MyForms.Create__Instance__<frmCRShow>(this.m_frmCRShow);
        return this.m_frmCRShow;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmCRShow)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmCRShow>(ref this.m_frmCRShow);
      }
    }

    public frmDefaultGroupSetting frmDefaultGroupSetting
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDefaultGroupSetting = MyProject.MyForms.Create__Instance__<frmDefaultGroupSetting>(this.m_frmDefaultGroupSetting);
        return this.m_frmDefaultGroupSetting;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDefaultGroupSetting)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDefaultGroupSetting>(ref this.m_frmDefaultGroupSetting);
      }
    }

    public frmDeleteFolder frmDeleteFolder
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDeleteFolder = MyProject.MyForms.Create__Instance__<frmDeleteFolder>(this.m_frmDeleteFolder);
        return this.m_frmDeleteFolder;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDeleteFolder)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDeleteFolder>(ref this.m_frmDeleteFolder);
      }
    }

    public frmDigAccountSelection frmDigAccountSelection
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDigAccountSelection = MyProject.MyForms.Create__Instance__<frmDigAccountSelection>(this.m_frmDigAccountSelection);
        return this.m_frmDigAccountSelection;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDigAccountSelection)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDigAccountSelection>(ref this.m_frmDigAccountSelection);
      }
    }

    public frmDigAutoMasterAdd frmDigAutoMasterAdd
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDigAutoMasterAdd = MyProject.MyForms.Create__Instance__<frmDigAutoMasterAdd>(this.m_frmDigAutoMasterAdd);
        return this.m_frmDigAutoMasterAdd;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDigAutoMasterAdd)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDigAutoMasterAdd>(ref this.m_frmDigAutoMasterAdd);
      }
    }

    public frmDigMemberSelection frmDigMemberSelection
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDigMemberSelection = MyProject.MyForms.Create__Instance__<frmDigMemberSelection>(this.m_frmDigMemberSelection);
        return this.m_frmDigMemberSelection;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDigMemberSelection)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDigMemberSelection>(ref this.m_frmDigMemberSelection);
      }
    }

    public frmDigMemberSelection1 frmDigMemberSelection1
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDigMemberSelection1 = MyProject.MyForms.Create__Instance__<frmDigMemberSelection1>(this.m_frmDigMemberSelection1);
        return this.m_frmDigMemberSelection1;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDigMemberSelection1)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDigMemberSelection1>(ref this.m_frmDigMemberSelection1);
      }
    }

    public frmDigNumber frmDigNumber
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDigNumber = MyProject.MyForms.Create__Instance__<frmDigNumber>(this.m_frmDigNumber);
        return this.m_frmDigNumber;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDigNumber)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDigNumber>(ref this.m_frmDigNumber);
      }
    }

    public frmDigNumberJreg frmDigNumberJreg
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDigNumberJreg = MyProject.MyForms.Create__Instance__<frmDigNumberJreg>(this.m_frmDigNumberJreg);
        return this.m_frmDigNumberJreg;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDigNumberJreg)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDigNumberJreg>(ref this.m_frmDigNumberJreg);
      }
    }

    public frmDigNumberRange frmDigNumberRange
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDigNumberRange = MyProject.MyForms.Create__Instance__<frmDigNumberRange>(this.m_frmDigNumberRange);
        return this.m_frmDigNumberRange;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDigNumberRange)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDigNumberRange>(ref this.m_frmDigNumberRange);
      }
    }

    public frmDigNumberStat frmDigNumberStat
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDigNumberStat = MyProject.MyForms.Create__Instance__<frmDigNumberStat>(this.m_frmDigNumberStat);
        return this.m_frmDigNumberStat;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDigNumberStat)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDigNumberStat>(ref this.m_frmDigNumberStat);
      }
    }

    public frmDigPeriodRange frmDigPeriodRange
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDigPeriodRange = MyProject.MyForms.Create__Instance__<frmDigPeriodRange>(this.m_frmDigPeriodRange);
        return this.m_frmDigPeriodRange;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDigPeriodRange)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDigPeriodRange>(ref this.m_frmDigPeriodRange);
      }
    }

    public frmDigPeriodRangeRec frmDigPeriodRangeRec
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDigPeriodRangeRec = MyProject.MyForms.Create__Instance__<frmDigPeriodRangeRec>(this.m_frmDigPeriodRangeRec);
        return this.m_frmDigPeriodRangeRec;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDigPeriodRangeRec)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDigPeriodRangeRec>(ref this.m_frmDigPeriodRangeRec);
      }
    }

    public frmDigPeriodRangeUpto frmDigPeriodRangeUpto
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDigPeriodRangeUpto = MyProject.MyForms.Create__Instance__<frmDigPeriodRangeUpto>(this.m_frmDigPeriodRangeUpto);
        return this.m_frmDigPeriodRangeUpto;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDigPeriodRangeUpto)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDigPeriodRangeUpto>(ref this.m_frmDigPeriodRangeUpto);
      }
    }

    public frmDigSearch frmDigSearch
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmDigSearch = MyProject.MyForms.Create__Instance__<frmDigSearch>(this.m_frmDigSearch);
        return this.m_frmDigSearch;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmDigSearch)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmDigSearch>(ref this.m_frmDigSearch);
      }
    }

    public frmEmailCommittee frmEmailCommittee
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmEmailCommittee = MyProject.MyForms.Create__Instance__<frmEmailCommittee>(this.m_frmEmailCommittee);
        return this.m_frmEmailCommittee;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmEmailCommittee)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmEmailCommittee>(ref this.m_frmEmailCommittee);
      }
    }

    public frmEmailMember frmEmailMember
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmEmailMember = MyProject.MyForms.Create__Instance__<frmEmailMember>(this.m_frmEmailMember);
        return this.m_frmEmailMember;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmEmailMember)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmEmailMember>(ref this.m_frmEmailMember);
      }
    }

    public frmEmailMemberAccount frmEmailMemberAccount
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmEmailMemberAccount = MyProject.MyForms.Create__Instance__<frmEmailMemberAccount>(this.m_frmEmailMemberAccount);
        return this.m_frmEmailMemberAccount;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmEmailMemberAccount)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmEmailMemberAccount>(ref this.m_frmEmailMemberAccount);
      }
    }

    public frmEmailSetting frmEmailSetting
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmEmailSetting = MyProject.MyForms.Create__Instance__<frmEmailSetting>(this.m_frmEmailSetting);
        return this.m_frmEmailSetting;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmEmailSetting)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmEmailSetting>(ref this.m_frmEmailSetting);
      }
    }

    public frmFDRDetail frmFDRDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmFDRDetail = MyProject.MyForms.Create__Instance__<frmFDRDetail>(this.m_frmFDRDetail);
        return this.m_frmFDRDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmFDRDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmFDRDetail>(ref this.m_frmFDRDetail);
      }
    }

    public frmFDRReminder frmFDRReminder
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmFDRReminder = MyProject.MyForms.Create__Instance__<frmFDRReminder>(this.m_frmFDRReminder);
        return this.m_frmFDRReminder;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmFDRReminder)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmFDRReminder>(ref this.m_frmFDRReminder);
      }
    }

    public frmFlatTransfer frmFlatTransfer
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmFlatTransfer = MyProject.MyForms.Create__Instance__<frmFlatTransfer>(this.m_frmFlatTransfer);
        return this.m_frmFlatTransfer;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmFlatTransfer)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmFlatTransfer>(ref this.m_frmFlatTransfer);
      }
    }

    public frmFlatTransferDetail frmFlatTransferDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmFlatTransferDetail = MyProject.MyForms.Create__Instance__<frmFlatTransferDetail>(this.m_frmFlatTransferDetail);
        return this.m_frmFlatTransferDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmFlatTransferDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmFlatTransferDetail>(ref this.m_frmFlatTransferDetail);
      }
    }

    public frmGroup frmGroup
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmGroup = MyProject.MyForms.Create__Instance__<frmGroup>(this.m_frmGroup);
        return this.m_frmGroup;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmGroup)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmGroup>(ref this.m_frmGroup);
      }
    }

    public frmGroupDetail frmGroupDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmGroupDetail = MyProject.MyForms.Create__Instance__<frmGroupDetail>(this.m_frmGroupDetail);
        return this.m_frmGroupDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmGroupDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmGroupDetail>(ref this.m_frmGroupDetail);
      }
    }

    public frmGroupDetailDirect frmGroupDetailDirect
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmGroupDetailDirect = MyProject.MyForms.Create__Instance__<frmGroupDetailDirect>(this.m_frmGroupDetailDirect);
        return this.m_frmGroupDetailDirect;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmGroupDetailDirect)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmGroupDetailDirect>(ref this.m_frmGroupDetailDirect);
      }
    }

    public frmGSTCalculate frmGSTCalculate
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmGSTCalculate = MyProject.MyForms.Create__Instance__<frmGSTCalculate>(this.m_frmGSTCalculate);
        return this.m_frmGSTCalculate;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmGSTCalculate)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmGSTCalculate>(ref this.m_frmGSTCalculate);
      }
    }

    public frmImportBankList frmImportBankList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmImportBankList = MyProject.MyForms.Create__Instance__<frmImportBankList>(this.m_frmImportBankList);
        return this.m_frmImportBankList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmImportBankList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmImportBankList>(ref this.m_frmImportBankList);
      }
    }

    public frmImportMemberMaster frmImportMemberMaster
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmImportMemberMaster = MyProject.MyForms.Create__Instance__<frmImportMemberMaster>(this.m_frmImportMemberMaster);
        return this.m_frmImportMemberMaster;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmImportMemberMaster)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmImportMemberMaster>(ref this.m_frmImportMemberMaster);
      }
    }

    public frmImportMemberReceipt frmImportMemberReceipt
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmImportMemberReceipt = MyProject.MyForms.Create__Instance__<frmImportMemberReceipt>(this.m_frmImportMemberReceipt);
        return this.m_frmImportMemberReceipt;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmImportMemberReceipt)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmImportMemberReceipt>(ref this.m_frmImportMemberReceipt);
      }
    }

    public frmImportPayment frmImportPayment
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmImportPayment = MyProject.MyForms.Create__Instance__<frmImportPayment>(this.m_frmImportPayment);
        return this.m_frmImportPayment;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmImportPayment)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmImportPayment>(ref this.m_frmImportPayment);
      }
    }

    public frmImportReceipt frmImportReceipt
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmImportReceipt = MyProject.MyForms.Create__Instance__<frmImportReceipt>(this.m_frmImportReceipt);
        return this.m_frmImportReceipt;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmImportReceipt)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmImportReceipt>(ref this.m_frmImportReceipt);
      }
    }

    public frmImportStatMaster frmImportStatMaster
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmImportStatMaster = MyProject.MyForms.Create__Instance__<frmImportStatMaster>(this.m_frmImportStatMaster);
        return this.m_frmImportStatMaster;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmImportStatMaster)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmImportStatMaster>(ref this.m_frmImportStatMaster);
      }
    }

    public frmJournal frmJournal
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmJournal = MyProject.MyForms.Create__Instance__<frmJournal>(this.m_frmJournal);
        return this.m_frmJournal;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmJournal)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmJournal>(ref this.m_frmJournal);
      }
    }

    public frmJournalDetail frmJournalDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmJournalDetail = MyProject.MyForms.Create__Instance__<frmJournalDetail>(this.m_frmJournalDetail);
        return this.m_frmJournalDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmJournalDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmJournalDetail>(ref this.m_frmJournalDetail);
      }
    }

    public frmJournalDetailDirect frmJournalDetailDirect
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmJournalDetailDirect = MyProject.MyForms.Create__Instance__<frmJournalDetailDirect>(this.m_frmJournalDetailDirect);
        return this.m_frmJournalDetailDirect;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmJournalDetailDirect)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmJournalDetailDirect>(ref this.m_frmJournalDetailDirect);
      }
    }

    public frmListCall frmListCall
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmListCall = MyProject.MyForms.Create__Instance__<frmListCall>(this.m_frmListCall);
        return this.m_frmListCall;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmListCall)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmListCall>(ref this.m_frmListCall);
      }
    }

    public frmListcashaccount frmListcashaccount
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmListcashaccount = MyProject.MyForms.Create__Instance__<frmListcashaccount>(this.m_frmListcashaccount);
        return this.m_frmListcashaccount;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmListcashaccount)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmListcashaccount>(ref this.m_frmListcashaccount);
      }
    }

    public frmListGroup frmListGroup
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmListGroup = MyProject.MyForms.Create__Instance__<frmListGroup>(this.m_frmListGroup);
        return this.m_frmListGroup;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmListGroup)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmListGroup>(ref this.m_frmListGroup);
      }
    }

    public frmListMember frmListMember
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmListMember = MyProject.MyForms.Create__Instance__<frmListMember>(this.m_frmListMember);
        return this.m_frmListMember;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmListMember)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmListMember>(ref this.m_frmListMember);
      }
    }

    public frmMember frmMember
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMember = MyProject.MyForms.Create__Instance__<frmMember>(this.m_frmMember);
        return this.m_frmMember;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMember)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMember>(ref this.m_frmMember);
      }
    }

    public frmMember1 frmMember1
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMember1 = MyProject.MyForms.Create__Instance__<frmMember1>(this.m_frmMember1);
        return this.m_frmMember1;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMember1)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMember1>(ref this.m_frmMember1);
      }
    }

    public frmMemberBillMaster frmMemberBillMaster
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemberBillMaster = MyProject.MyForms.Create__Instance__<frmMemberBillMaster>(this.m_frmMemberBillMaster);
        return this.m_frmMemberBillMaster;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemberBillMaster)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemberBillMaster>(ref this.m_frmMemberBillMaster);
      }
    }

    public frmMemberBillMasterSelect frmMemberBillMasterSelect
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemberBillMasterSelect = MyProject.MyForms.Create__Instance__<frmMemberBillMasterSelect>(this.m_frmMemberBillMasterSelect);
        return this.m_frmMemberBillMasterSelect;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemberBillMasterSelect)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemberBillMasterSelect>(ref this.m_frmMemberBillMasterSelect);
      }
    }

    public frmMemberdetails frmMemberdetails
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemberdetails = MyProject.MyForms.Create__Instance__<frmMemberdetails>(this.m_frmMemberdetails);
        return this.m_frmMemberdetails;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemberdetails)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemberdetails>(ref this.m_frmMemberdetails);
      }
    }

    public frmMemberdetailsDirect frmMemberdetailsDirect
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemberdetailsDirect = MyProject.MyForms.Create__Instance__<frmMemberdetailsDirect>(this.m_frmMemberdetailsDirect);
        return this.m_frmMemberdetailsDirect;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemberdetailsDirect)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemberdetailsDirect>(ref this.m_frmMemberdetailsDirect);
      }
    }

    public frmMemberElectionListReport frmMemberElectionListReport
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemberElectionListReport = MyProject.MyForms.Create__Instance__<frmMemberElectionListReport>(this.m_frmMemberElectionListReport);
        return this.m_frmMemberElectionListReport;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemberElectionListReport)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemberElectionListReport>(ref this.m_frmMemberElectionListReport);
      }
    }

    public frmMemberExportList frmMemberExportList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemberExportList = MyProject.MyForms.Create__Instance__<frmMemberExportList>(this.m_frmMemberExportList);
        return this.m_frmMemberExportList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemberExportList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemberExportList>(ref this.m_frmMemberExportList);
      }
    }

    public frmMemberJournalDetail frmMemberJournalDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemberJournalDetail = MyProject.MyForms.Create__Instance__<frmMemberJournalDetail>(this.m_frmMemberJournalDetail);
        return this.m_frmMemberJournalDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemberJournalDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemberJournalDetail>(ref this.m_frmMemberJournalDetail);
      }
    }

    public frmMemberListReport frmMemberListReport
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemberListReport = MyProject.MyForms.Create__Instance__<frmMemberListReport>(this.m_frmMemberListReport);
        return this.m_frmMemberListReport;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemberListReport)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemberListReport>(ref this.m_frmMemberListReport);
      }
    }

    public frmMemberListTransferReport frmMemberListTransferReport
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemberListTransferReport = MyProject.MyForms.Create__Instance__<frmMemberListTransferReport>(this.m_frmMemberListTransferReport);
        return this.m_frmMemberListTransferReport;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemberListTransferReport)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemberListTransferReport>(ref this.m_frmMemberListTransferReport);
      }
    }

    public frmMemberMaster frmMemberMaster
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemberMaster = MyProject.MyForms.Create__Instance__<frmMemberMaster>(this.m_frmMemberMaster);
        return this.m_frmMemberMaster;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemberMaster)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemberMaster>(ref this.m_frmMemberMaster);
      }
    }

    public frmMemberMasterSelected frmMemberMasterSelected
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemberMasterSelected = MyProject.MyForms.Create__Instance__<frmMemberMasterSelected>(this.m_frmMemberMasterSelected);
        return this.m_frmMemberMasterSelected;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemberMasterSelected)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemberMasterSelected>(ref this.m_frmMemberMasterSelected);
      }
    }

    public frmMemberShowdetails frmMemberShowdetails
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemberShowdetails = MyProject.MyForms.Create__Instance__<frmMemberShowdetails>(this.m_frmMemberShowdetails);
        return this.m_frmMemberShowdetails;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemberShowdetails)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemberShowdetails>(ref this.m_frmMemberShowdetails);
      }
    }

    public frmMemBilldetail frmMemBilldetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemBilldetail = MyProject.MyForms.Create__Instance__<frmMemBilldetail>(this.m_frmMemBilldetail);
        return this.m_frmMemBilldetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemBilldetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemBilldetail>(ref this.m_frmMemBilldetail);
      }
    }

    public frmMemBilldetailDirect frmMemBilldetailDirect
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemBilldetailDirect = MyProject.MyForms.Create__Instance__<frmMemBilldetailDirect>(this.m_frmMemBilldetailDirect);
        return this.m_frmMemBilldetailDirect;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemBilldetailDirect)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemBilldetailDirect>(ref this.m_frmMemBilldetailDirect);
      }
    }

    public frmMemBilling frmMemBilling
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemBilling = MyProject.MyForms.Create__Instance__<frmMemBilling>(this.m_frmMemBilling);
        return this.m_frmMemBilling;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemBilling)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemBilling>(ref this.m_frmMemBilling);
      }
    }

    public frmMemReceipt frmMemReceipt
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemReceipt = MyProject.MyForms.Create__Instance__<frmMemReceipt>(this.m_frmMemReceipt);
        return this.m_frmMemReceipt;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemReceipt)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemReceipt>(ref this.m_frmMemReceipt);
      }
    }

    public frmMemReceiptDetail frmMemReceiptDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemReceiptDetail = MyProject.MyForms.Create__Instance__<frmMemReceiptDetail>(this.m_frmMemReceiptDetail);
        return this.m_frmMemReceiptDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemReceiptDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemReceiptDetail>(ref this.m_frmMemReceiptDetail);
      }
    }

    public frmMemReceiptDetailBif frmMemReceiptDetailBif
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemReceiptDetailBif = MyProject.MyForms.Create__Instance__<frmMemReceiptDetailBif>(this.m_frmMemReceiptDetailBif);
        return this.m_frmMemReceiptDetailBif;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemReceiptDetailBif)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemReceiptDetailBif>(ref this.m_frmMemReceiptDetailBif);
      }
    }

    public frmMemReceiptDetailBifDirect frmMemReceiptDetailBifDirect
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemReceiptDetailBifDirect = MyProject.MyForms.Create__Instance__<frmMemReceiptDetailBifDirect>(this.m_frmMemReceiptDetailBifDirect);
        return this.m_frmMemReceiptDetailBifDirect;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemReceiptDetailBifDirect)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemReceiptDetailBifDirect>(ref this.m_frmMemReceiptDetailBifDirect);
      }
    }

    public frmMemReceiptDetailDirect frmMemReceiptDetailDirect
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMemReceiptDetailDirect = MyProject.MyForms.Create__Instance__<frmMemReceiptDetailDirect>(this.m_frmMemReceiptDetailDirect);
        return this.m_frmMemReceiptDetailDirect;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMemReceiptDetailDirect)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMemReceiptDetailDirect>(ref this.m_frmMemReceiptDetailDirect);
      }
    }

    public frmMenu frmMenu
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMenu = MyProject.MyForms.Create__Instance__<frmMenu>(this.m_frmMenu);
        return this.m_frmMenu;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMenu)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMenu>(ref this.m_frmMenu);
      }
    }

    public frmMultiReceiptMaster frmMultiReceiptMaster
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMultiReceiptMaster = MyProject.MyForms.Create__Instance__<frmMultiReceiptMaster>(this.m_frmMultiReceiptMaster);
        return this.m_frmMultiReceiptMaster;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMultiReceiptMaster)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMultiReceiptMaster>(ref this.m_frmMultiReceiptMaster);
      }
    }

    public frmMultiReceiptMaster1 frmMultiReceiptMaster1
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMultiReceiptMaster1 = MyProject.MyForms.Create__Instance__<frmMultiReceiptMaster1>(this.m_frmMultiReceiptMaster1);
        return this.m_frmMultiReceiptMaster1;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMultiReceiptMaster1)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMultiReceiptMaster1>(ref this.m_frmMultiReceiptMaster1);
      }
    }

    public frmMultiReceiptMemberSelect frmMultiReceiptMemberSelect
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMultiReceiptMemberSelect = MyProject.MyForms.Create__Instance__<frmMultiReceiptMemberSelect>(this.m_frmMultiReceiptMemberSelect);
        return this.m_frmMultiReceiptMemberSelect;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMultiReceiptMemberSelect)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMultiReceiptMemberSelect>(ref this.m_frmMultiReceiptMemberSelect);
      }
    }

    public frmMultiReceiptMemberSelect1 frmMultiReceiptMemberSelect1
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmMultiReceiptMemberSelect1 = MyProject.MyForms.Create__Instance__<frmMultiReceiptMemberSelect1>(this.m_frmMultiReceiptMemberSelect1);
        return this.m_frmMultiReceiptMemberSelect1;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmMultiReceiptMemberSelect1)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmMultiReceiptMemberSelect1>(ref this.m_frmMultiReceiptMemberSelect1);
      }
    }

    public frmOpeningBalance frmOpeningBalance
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmOpeningBalance = MyProject.MyForms.Create__Instance__<frmOpeningBalance>(this.m_frmOpeningBalance);
        return this.m_frmOpeningBalance;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmOpeningBalance)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmOpeningBalance>(ref this.m_frmOpeningBalance);
      }
    }

    public frmOpeningRecoDetail frmOpeningRecoDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmOpeningRecoDetail = MyProject.MyForms.Create__Instance__<frmOpeningRecoDetail>(this.m_frmOpeningRecoDetail);
        return this.m_frmOpeningRecoDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmOpeningRecoDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmOpeningRecoDetail>(ref this.m_frmOpeningRecoDetail);
      }
    }

    public frmPartList frmPartList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmPartList = MyProject.MyForms.Create__Instance__<frmPartList>(this.m_frmPartList);
        return this.m_frmPartList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmPartList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmPartList>(ref this.m_frmPartList);
      }
    }

    public frmPath frmPath
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmPath = MyProject.MyForms.Create__Instance__<frmPath>(this.m_frmPath);
        return this.m_frmPath;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmPath)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmPath>(ref this.m_frmPath);
      }
    }

    public frmPathListAdd frmPathListAdd
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmPathListAdd = MyProject.MyForms.Create__Instance__<frmPathListAdd>(this.m_frmPathListAdd);
        return this.m_frmPathListAdd;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmPathListAdd)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmPathListAdd>(ref this.m_frmPathListAdd);
      }
    }

    public frmPayment frmPayment
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmPayment = MyProject.MyForms.Create__Instance__<frmPayment>(this.m_frmPayment);
        return this.m_frmPayment;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmPayment)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmPayment>(ref this.m_frmPayment);
      }
    }

    public frmPaymentDetails frmPaymentDetails
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmPaymentDetails = MyProject.MyForms.Create__Instance__<frmPaymentDetails>(this.m_frmPaymentDetails);
        return this.m_frmPaymentDetails;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmPaymentDetails)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmPaymentDetails>(ref this.m_frmPaymentDetails);
      }
    }

    public frmPaymentDetailsDirect frmPaymentDetailsDirect
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmPaymentDetailsDirect = MyProject.MyForms.Create__Instance__<frmPaymentDetailsDirect>(this.m_frmPaymentDetailsDirect);
        return this.m_frmPaymentDetailsDirect;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmPaymentDetailsDirect)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmPaymentDetailsDirect>(ref this.m_frmPaymentDetailsDirect);
      }
    }

    public frmPaymentVerify frmPaymentVerify
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmPaymentVerify = MyProject.MyForms.Create__Instance__<frmPaymentVerify>(this.m_frmPaymentVerify);
        return this.m_frmPaymentVerify;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmPaymentVerify)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmPaymentVerify>(ref this.m_frmPaymentVerify);
      }
    }

    public frmRebuild frmRebuild
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmRebuild = MyProject.MyForms.Create__Instance__<frmRebuild>(this.m_frmRebuild);
        return this.m_frmRebuild;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmRebuild)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmRebuild>(ref this.m_frmRebuild);
      }
    }

    public frmReceipt frmReceipt
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReceipt = MyProject.MyForms.Create__Instance__<frmReceipt>(this.m_frmReceipt);
        return this.m_frmReceipt;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReceipt)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReceipt>(ref this.m_frmReceipt);
      }
    }

    public frmReceiptDetails frmReceiptDetails
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReceiptDetails = MyProject.MyForms.Create__Instance__<frmReceiptDetails>(this.m_frmReceiptDetails);
        return this.m_frmReceiptDetails;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReceiptDetails)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReceiptDetails>(ref this.m_frmReceiptDetails);
      }
    }

    public frmRenumber frmRenumber
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmRenumber = MyProject.MyForms.Create__Instance__<frmRenumber>(this.m_frmRenumber);
        return this.m_frmRenumber;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmRenumber)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmRenumber>(ref this.m_frmRenumber);
      }
    }

    public frmRenumberConfirmDialog frmRenumberConfirmDialog
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmRenumberConfirmDialog = MyProject.MyForms.Create__Instance__<frmRenumberConfirmDialog>(this.m_frmRenumberConfirmDialog);
        return this.m_frmRenumberConfirmDialog;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmRenumberConfirmDialog)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmRenumberConfirmDialog>(ref this.m_frmRenumberConfirmDialog);
      }
    }

    public frmReportAccountCashBank frmReportAccountCashBank
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportAccountCashBank = MyProject.MyForms.Create__Instance__<frmReportAccountCashBank>(this.m_frmReportAccountCashBank);
        return this.m_frmReportAccountCashBank;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportAccountCashBank)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportAccountCashBank>(ref this.m_frmReportAccountCashBank);
      }
    }

    public frmReportAccountLedger frmReportAccountLedger
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportAccountLedger = MyProject.MyForms.Create__Instance__<frmReportAccountLedger>(this.m_frmReportAccountLedger);
        return this.m_frmReportAccountLedger;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportAccountLedger)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportAccountLedger>(ref this.m_frmReportAccountLedger);
      }
    }

    public frmReportAccountLedgerNew frmReportAccountLedgerNew
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportAccountLedgerNew = MyProject.MyForms.Create__Instance__<frmReportAccountLedgerNew>(this.m_frmReportAccountLedgerNew);
        return this.m_frmReportAccountLedgerNew;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportAccountLedgerNew)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportAccountLedgerNew>(ref this.m_frmReportAccountLedgerNew);
      }
    }

    public frmReportAccountLedgerNewGroup frmReportAccountLedgerNewGroup
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportAccountLedgerNewGroup = MyProject.MyForms.Create__Instance__<frmReportAccountLedgerNewGroup>(this.m_frmReportAccountLedgerNewGroup);
        return this.m_frmReportAccountLedgerNewGroup;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportAccountLedgerNewGroup)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportAccountLedgerNewGroup>(ref this.m_frmReportAccountLedgerNewGroup);
      }
    }

    public frmReportAccountLedgerShow frmReportAccountLedgerShow
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportAccountLedgerShow = MyProject.MyForms.Create__Instance__<frmReportAccountLedgerShow>(this.m_frmReportAccountLedgerShow);
        return this.m_frmReportAccountLedgerShow;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportAccountLedgerShow)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportAccountLedgerShow>(ref this.m_frmReportAccountLedgerShow);
      }
    }

    public frmreportAccountList frmreportAccountList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmreportAccountList = MyProject.MyForms.Create__Instance__<frmreportAccountList>(this.m_frmreportAccountList);
        return this.m_frmreportAccountList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmreportAccountList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmreportAccountList>(ref this.m_frmreportAccountList);
      }
    }

    public frmReportBalanceSheet frmReportBalanceSheet
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportBalanceSheet = MyProject.MyForms.Create__Instance__<frmReportBalanceSheet>(this.m_frmReportBalanceSheet);
        return this.m_frmReportBalanceSheet;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportBalanceSheet)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportBalanceSheet>(ref this.m_frmReportBalanceSheet);
      }
    }

    public frmReportBalanceSheetMarathi frmReportBalanceSheetMarathi
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportBalanceSheetMarathi = MyProject.MyForms.Create__Instance__<frmReportBalanceSheetMarathi>(this.m_frmReportBalanceSheetMarathi);
        return this.m_frmReportBalanceSheetMarathi;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportBalanceSheetMarathi)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportBalanceSheetMarathi>(ref this.m_frmReportBalanceSheetMarathi);
      }
    }

    public frmReportBankReco frmReportBankReco
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportBankReco = MyProject.MyForms.Create__Instance__<frmReportBankReco>(this.m_frmReportBankReco);
        return this.m_frmReportBankReco;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportBankReco)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportBankReco>(ref this.m_frmReportBankReco);
      }
    }

    public frmReportBillDetail frmReportBillDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportBillDetail = MyProject.MyForms.Create__Instance__<frmReportBillDetail>(this.m_frmReportBillDetail);
        return this.m_frmReportBillDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportBillDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportBillDetail>(ref this.m_frmReportBillDetail);
      }
    }

    public frmReportBillFullPage frmReportBillFullPage
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportBillFullPage = MyProject.MyForms.Create__Instance__<frmReportBillFullPage>(this.m_frmReportBillFullPage);
        return this.m_frmReportBillFullPage;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportBillFullPage)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportBillFullPage>(ref this.m_frmReportBillFullPage);
      }
    }

    public frmReportBillWithReceipt frmReportBillWithReceipt
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportBillWithReceipt = MyProject.MyForms.Create__Instance__<frmReportBillWithReceipt>(this.m_frmReportBillWithReceipt);
        return this.m_frmReportBillWithReceipt;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportBillWithReceipt)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportBillWithReceipt>(ref this.m_frmReportBillWithReceipt);
      }
    }

    public frmReportFundRegister frmReportFundRegister
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportFundRegister = MyProject.MyForms.Create__Instance__<frmReportFundRegister>(this.m_frmReportFundRegister);
        return this.m_frmReportFundRegister;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportFundRegister)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportFundRegister>(ref this.m_frmReportFundRegister);
      }
    }

    public frmReportGroupList frmReportGroupList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportGroupList = MyProject.MyForms.Create__Instance__<frmReportGroupList>(this.m_frmReportGroupList);
        return this.m_frmReportGroupList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportGroupList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportGroupList>(ref this.m_frmReportGroupList);
      }
    }

    public frmReportIncomeExpenditure frmReportIncomeExpenditure
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportIncomeExpenditure = MyProject.MyForms.Create__Instance__<frmReportIncomeExpenditure>(this.m_frmReportIncomeExpenditure);
        return this.m_frmReportIncomeExpenditure;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportIncomeExpenditure)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportIncomeExpenditure>(ref this.m_frmReportIncomeExpenditure);
      }
    }

    public frmReportIncomeExpenditureMarathi frmReportIncomeExpenditureMarathi
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportIncomeExpenditureMarathi = MyProject.MyForms.Create__Instance__<frmReportIncomeExpenditureMarathi>(this.m_frmReportIncomeExpenditureMarathi);
        return this.m_frmReportIncomeExpenditureMarathi;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportIncomeExpenditureMarathi)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportIncomeExpenditureMarathi>(ref this.m_frmReportIncomeExpenditureMarathi);
      }
    }

    public frmReportMemAcc frmReportMemAcc
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemAcc = MyProject.MyForms.Create__Instance__<frmReportMemAcc>(this.m_frmReportMemAcc);
        return this.m_frmReportMemAcc;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemAcc)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemAcc>(ref this.m_frmReportMemAcc);
      }
    }

    public frmReportMemberAccountNew frmReportMemberAccountNew
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemberAccountNew = MyProject.MyForms.Create__Instance__<frmReportMemberAccountNew>(this.m_frmReportMemberAccountNew);
        return this.m_frmReportMemberAccountNew;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemberAccountNew)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemberAccountNew>(ref this.m_frmReportMemberAccountNew);
      }
    }

    public frmReportMemberAdjustmentPrint frmReportMemberAdjustmentPrint
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemberAdjustmentPrint = MyProject.MyForms.Create__Instance__<frmReportMemberAdjustmentPrint>(this.m_frmReportMemberAdjustmentPrint);
        return this.m_frmReportMemberAdjustmentPrint;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemberAdjustmentPrint)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemberAdjustmentPrint>(ref this.m_frmReportMemberAdjustmentPrint);
      }
    }

    public frmReportMemberBillRegisterNew frmReportMemberBillRegisterNew
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemberBillRegisterNew = MyProject.MyForms.Create__Instance__<frmReportMemberBillRegisterNew>(this.m_frmReportMemberBillRegisterNew);
        return this.m_frmReportMemberBillRegisterNew;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemberBillRegisterNew)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemberBillRegisterNew>(ref this.m_frmReportMemberBillRegisterNew);
      }
    }

    public frmReportMemberBillRegisterNewGST frmReportMemberBillRegisterNewGST
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemberBillRegisterNewGST = MyProject.MyForms.Create__Instance__<frmReportMemberBillRegisterNewGST>(this.m_frmReportMemberBillRegisterNewGST);
        return this.m_frmReportMemberBillRegisterNewGST;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemberBillRegisterNewGST)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemberBillRegisterNewGST>(ref this.m_frmReportMemberBillRegisterNewGST);
      }
    }

    public frmReportMemberBillRegisterNewReceipt frmReportMemberBillRegisterNewReceipt
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemberBillRegisterNewReceipt = MyProject.MyForms.Create__Instance__<frmReportMemberBillRegisterNewReceipt>(this.m_frmReportMemberBillRegisterNewReceipt);
        return this.m_frmReportMemberBillRegisterNewReceipt;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemberBillRegisterNewReceipt)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemberBillRegisterNewReceipt>(ref this.m_frmReportMemberBillRegisterNewReceipt);
      }
    }

    public frmReportMemberConfirmationNew frmReportMemberConfirmationNew
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemberConfirmationNew = MyProject.MyForms.Create__Instance__<frmReportMemberConfirmationNew>(this.m_frmReportMemberConfirmationNew);
        return this.m_frmReportMemberConfirmationNew;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemberConfirmationNew)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemberConfirmationNew>(ref this.m_frmReportMemberConfirmationNew);
      }
    }

    public frmReportMemberControlAccount frmReportMemberControlAccount
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemberControlAccount = MyProject.MyForms.Create__Instance__<frmReportMemberControlAccount>(this.m_frmReportMemberControlAccount);
        return this.m_frmReportMemberControlAccount;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemberControlAccount)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemberControlAccount>(ref this.m_frmReportMemberControlAccount);
      }
    }

    public frmReportMemberMemberRegisterNew frmReportMemberMemberRegisterNew
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemberMemberRegisterNew = MyProject.MyForms.Create__Instance__<frmReportMemberMemberRegisterNew>(this.m_frmReportMemberMemberRegisterNew);
        return this.m_frmReportMemberMemberRegisterNew;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemberMemberRegisterNew)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemberMemberRegisterNew>(ref this.m_frmReportMemberMemberRegisterNew);
      }
    }

    public frmReportMemberOutstandingNew frmReportMemberOutstandingNew
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemberOutstandingNew = MyProject.MyForms.Create__Instance__<frmReportMemberOutstandingNew>(this.m_frmReportMemberOutstandingNew);
        return this.m_frmReportMemberOutstandingNew;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemberOutstandingNew)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemberOutstandingNew>(ref this.m_frmReportMemberOutstandingNew);
      }
    }

    public frmReportMemberReceipt frmReportMemberReceipt
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemberReceipt = MyProject.MyForms.Create__Instance__<frmReportMemberReceipt>(this.m_frmReportMemberReceipt);
        return this.m_frmReportMemberReceipt;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemberReceipt)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemberReceipt>(ref this.m_frmReportMemberReceipt);
      }
    }

    public frmReportMemberReceiptPrint frmReportMemberReceiptPrint
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemberReceiptPrint = MyProject.MyForms.Create__Instance__<frmReportMemberReceiptPrint>(this.m_frmReportMemberReceiptPrint);
        return this.m_frmReportMemberReceiptPrint;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemberReceiptPrint)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemberReceiptPrint>(ref this.m_frmReportMemberReceiptPrint);
      }
    }

    public frmReportMemHeadwiseList frmReportMemHeadwiseList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemHeadwiseList = MyProject.MyForms.Create__Instance__<frmReportMemHeadwiseList>(this.m_frmReportMemHeadwiseList);
        return this.m_frmReportMemHeadwiseList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemHeadwiseList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemHeadwiseList>(ref this.m_frmReportMemHeadwiseList);
      }
    }

    public frmReportMemList frmReportMemList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemList = MyProject.MyForms.Create__Instance__<frmReportMemList>(this.m_frmReportMemList);
        return this.m_frmReportMemList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemList>(ref this.m_frmReportMemList);
      }
    }

    public frmReportMemSignList frmReportMemSignList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMemSignList = MyProject.MyForms.Create__Instance__<frmReportMemSignList>(this.m_frmReportMemSignList);
        return this.m_frmReportMemSignList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMemSignList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMemSignList>(ref this.m_frmReportMemSignList);
      }
    }

    public frmReportMonthly frmReportMonthly
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportMonthly = MyProject.MyForms.Create__Instance__<frmReportMonthly>(this.m_frmReportMonthly);
        return this.m_frmReportMonthly;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportMonthly)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportMonthly>(ref this.m_frmReportMonthly);
      }
    }

    public frmReportPayment frmReportPayment
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportPayment = MyProject.MyForms.Create__Instance__<frmReportPayment>(this.m_frmReportPayment);
        return this.m_frmReportPayment;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportPayment)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportPayment>(ref this.m_frmReportPayment);
      }
    }

    public frmReportPVRegister frmReportPVRegister
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportPVRegister = MyProject.MyForms.Create__Instance__<frmReportPVRegister>(this.m_frmReportPVRegister);
        return this.m_frmReportPVRegister;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportPVRegister)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportPVRegister>(ref this.m_frmReportPVRegister);
      }
    }

    public frmReportReceiptPayment frmReportReceiptPayment
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportReceiptPayment = MyProject.MyForms.Create__Instance__<frmReportReceiptPayment>(this.m_frmReportReceiptPayment);
        return this.m_frmReportReceiptPayment;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportReceiptPayment)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportReceiptPayment>(ref this.m_frmReportReceiptPayment);
      }
    }

    public frmReportReceiptPaymentGroup frmReportReceiptPaymentGroup
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportReceiptPaymentGroup = MyProject.MyForms.Create__Instance__<frmReportReceiptPaymentGroup>(this.m_frmReportReceiptPaymentGroup);
        return this.m_frmReportReceiptPaymentGroup;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportReceiptPaymentGroup)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportReceiptPaymentGroup>(ref this.m_frmReportReceiptPaymentGroup);
      }
    }

    public frmReportReceiptPaymentMarathi frmReportReceiptPaymentMarathi
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportReceiptPaymentMarathi = MyProject.MyForms.Create__Instance__<frmReportReceiptPaymentMarathi>(this.m_frmReportReceiptPaymentMarathi);
        return this.m_frmReportReceiptPaymentMarathi;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportReceiptPaymentMarathi)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportReceiptPaymentMarathi>(ref this.m_frmReportReceiptPaymentMarathi);
      }
    }

    public frmReportSchedule frmReportSchedule
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportSchedule = MyProject.MyForms.Create__Instance__<frmReportSchedule>(this.m_frmReportSchedule);
        return this.m_frmReportSchedule;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportSchedule)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportSchedule>(ref this.m_frmReportSchedule);
      }
    }

    public FrmReportTrialBalance FrmReportTrialBalance
    {
      [DebuggerNonUserCode] get
      {
        this.m_FrmReportTrialBalance = MyProject.MyForms.Create__Instance__<FrmReportTrialBalance>(this.m_FrmReportTrialBalance);
        return this.m_FrmReportTrialBalance;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_FrmReportTrialBalance)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<FrmReportTrialBalance>(ref this.m_FrmReportTrialBalance);
      }
    }

    public frmReportUpload frmReportUpload
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportUpload = MyProject.MyForms.Create__Instance__<frmReportUpload>(this.m_frmReportUpload);
        return this.m_frmReportUpload;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportUpload)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportUpload>(ref this.m_frmReportUpload);
      }
    }

    public frmReportVoucherCheck frmReportVoucherCheck
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmReportVoucherCheck = MyProject.MyForms.Create__Instance__<frmReportVoucherCheck>(this.m_frmReportVoucherCheck);
        return this.m_frmReportVoucherCheck;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmReportVoucherCheck)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmReportVoucherCheck>(ref this.m_frmReportVoucherCheck);
      }
    }

    public frmServantDetail frmServantDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmServantDetail = MyProject.MyForms.Create__Instance__<frmServantDetail>(this.m_frmServantDetail);
        return this.m_frmServantDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmServantDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmServantDetail>(ref this.m_frmServantDetail);
      }
    }

    public frmSocietyDetail frmSocietyDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSocietyDetail = MyProject.MyForms.Create__Instance__<frmSocietyDetail>(this.m_frmSocietyDetail);
        return this.m_frmSocietyDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSocietyDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSocietyDetail>(ref this.m_frmSocietyDetail);
      }
    }

    public frmSocietyMaster frmSocietyMaster
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSocietyMaster = MyProject.MyForms.Create__Instance__<frmSocietyMaster>(this.m_frmSocietyMaster);
        return this.m_frmSocietyMaster;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSocietyMaster)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSocietyMaster>(ref this.m_frmSocietyMaster);
      }
    }

    public frmSocietyMasterBillPrintSet frmSocietyMasterBillPrintSet
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSocietyMasterBillPrintSet = MyProject.MyForms.Create__Instance__<frmSocietyMasterBillPrintSet>(this.m_frmSocietyMasterBillPrintSet);
        return this.m_frmSocietyMasterBillPrintSet;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSocietyMasterBillPrintSet)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSocietyMasterBillPrintSet>(ref this.m_frmSocietyMasterBillPrintSet);
      }
    }

    public frmSocietyMasterGST frmSocietyMasterGST
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSocietyMasterGST = MyProject.MyForms.Create__Instance__<frmSocietyMasterGST>(this.m_frmSocietyMasterGST);
        return this.m_frmSocietyMasterGST;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSocietyMasterGST)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSocietyMasterGST>(ref this.m_frmSocietyMasterGST);
      }
    }

    public frmSocietyMasterReceipt frmSocietyMasterReceipt
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSocietyMasterReceipt = MyProject.MyForms.Create__Instance__<frmSocietyMasterReceipt>(this.m_frmSocietyMasterReceipt);
        return this.m_frmSocietyMasterReceipt;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSocietyMasterReceipt)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSocietyMasterReceipt>(ref this.m_frmSocietyMasterReceipt);
      }
    }

    public frmSocietyMasterRecRek frmSocietyMasterRecRek
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSocietyMasterRecRek = MyProject.MyForms.Create__Instance__<frmSocietyMasterRecRek>(this.m_frmSocietyMasterRecRek);
        return this.m_frmSocietyMasterRecRek;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSocietyMasterRecRek)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSocietyMasterRecRek>(ref this.m_frmSocietyMasterRecRek);
      }
    }

    public frmSocLockInfo frmSocLockInfo
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSocLockInfo = MyProject.MyForms.Create__Instance__<frmSocLockInfo>(this.m_frmSocLockInfo);
        return this.m_frmSocLockInfo;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSocLockInfo)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSocLockInfo>(ref this.m_frmSocLockInfo);
      }
    }

    public frmSocLoginInfo frmSocLoginInfo
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSocLoginInfo = MyProject.MyForms.Create__Instance__<frmSocLoginInfo>(this.m_frmSocLoginInfo);
        return this.m_frmSocLoginInfo;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSocLoginInfo)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSocLoginInfo>(ref this.m_frmSocLoginInfo);
      }
    }

    public frmSocSelection frmSocSelection
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSocSelection = MyProject.MyForms.Create__Instance__<frmSocSelection>(this.m_frmSocSelection);
        return this.m_frmSocSelection;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSocSelection)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSocSelection>(ref this.m_frmSocSelection);
      }
    }

    public frmSocSelectionChange frmSocSelectionChange
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSocSelectionChange = MyProject.MyForms.Create__Instance__<frmSocSelectionChange>(this.m_frmSocSelectionChange);
        return this.m_frmSocSelectionChange;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSocSelectionChange)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSocSelectionChange>(ref this.m_frmSocSelectionChange);
      }
    }

    public frmStatIDetail frmStatIDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatIDetail = MyProject.MyForms.Create__Instance__<frmStatIDetail>(this.m_frmStatIDetail);
        return this.m_frmStatIDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatIDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatIDetail>(ref this.m_frmStatIDetail);
      }
    }

    public frmStatIList frmStatIList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatIList = MyProject.MyForms.Create__Instance__<frmStatIList>(this.m_frmStatIList);
        return this.m_frmStatIList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatIList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatIList>(ref this.m_frmStatIList);
      }
    }

    public frmStatINDetail frmStatINDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatINDetail = MyProject.MyForms.Create__Instance__<frmStatINDetail>(this.m_frmStatINDetail);
        return this.m_frmStatINDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatINDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatINDetail>(ref this.m_frmStatINDetail);
      }
    }

    public frmStatINList frmStatINList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatINList = MyProject.MyForms.Create__Instance__<frmStatINList>(this.m_frmStatINList);
        return this.m_frmStatINList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatINList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatINList>(ref this.m_frmStatINList);
      }
    }

    public frmStatJDetails frmStatJDetails
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatJDetails = MyProject.MyForms.Create__Instance__<frmStatJDetails>(this.m_frmStatJDetails);
        return this.m_frmStatJDetails;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatJDetails)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatJDetails>(ref this.m_frmStatJDetails);
      }
    }

    public frmStatJList frmStatJList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatJList = MyProject.MyForms.Create__Instance__<frmStatJList>(this.m_frmStatJList);
        return this.m_frmStatJList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatJList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatJList>(ref this.m_frmStatJList);
      }
    }

    public frmStatMemberDetail frmStatMemberDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatMemberDetail = MyProject.MyForms.Create__Instance__<frmStatMemberDetail>(this.m_frmStatMemberDetail);
        return this.m_frmStatMemberDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatMemberDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatMemberDetail>(ref this.m_frmStatMemberDetail);
      }
    }

    public frmStatMemberList frmStatMemberList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatMemberList = MyProject.MyForms.Create__Instance__<frmStatMemberList>(this.m_frmStatMemberList);
        return this.m_frmStatMemberList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatMemberList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatMemberList>(ref this.m_frmStatMemberList);
      }
    }

    public frmStatNDetail frmStatNDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatNDetail = MyProject.MyForms.Create__Instance__<frmStatNDetail>(this.m_frmStatNDetail);
        return this.m_frmStatNDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatNDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatNDetail>(ref this.m_frmStatNDetail);
      }
    }

    public frmStatNList frmStatNList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatNList = MyProject.MyForms.Create__Instance__<frmStatNList>(this.m_frmStatNList);
        return this.m_frmStatNList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatNList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatNList>(ref this.m_frmStatNList);
      }
    }

    public frmStatPDetail frmStatPDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatPDetail = MyProject.MyForms.Create__Instance__<frmStatPDetail>(this.m_frmStatPDetail);
        return this.m_frmStatPDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatPDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatPDetail>(ref this.m_frmStatPDetail);
      }
    }

    public frmStatPList frmStatPList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatPList = MyProject.MyForms.Create__Instance__<frmStatPList>(this.m_frmStatPList);
        return this.m_frmStatPList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatPList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatPList>(ref this.m_frmStatPList);
      }
    }

    public frmStatSDetail frmStatSDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatSDetail = MyProject.MyForms.Create__Instance__<frmStatSDetail>(this.m_frmStatSDetail);
        return this.m_frmStatSDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatSDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatSDetail>(ref this.m_frmStatSDetail);
      }
    }

    public frmStatSIDetail frmStatSIDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatSIDetail = MyProject.MyForms.Create__Instance__<frmStatSIDetail>(this.m_frmStatSIDetail);
        return this.m_frmStatSIDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatSIDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatSIDetail>(ref this.m_frmStatSIDetail);
      }
    }

    public frmStatSIList frmStatSIList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatSIList = MyProject.MyForms.Create__Instance__<frmStatSIList>(this.m_frmStatSIList);
        return this.m_frmStatSIList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatSIList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatSIList>(ref this.m_frmStatSIList);
      }
    }

    public frmStatSList frmStatSList
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatSList = MyProject.MyForms.Create__Instance__<frmStatSList>(this.m_frmStatSList);
        return this.m_frmStatSList;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatSList)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatSList>(ref this.m_frmStatSList);
      }
    }

    public frmStatSocietyDetail frmStatSocietyDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmStatSocietyDetail = MyProject.MyForms.Create__Instance__<frmStatSocietyDetail>(this.m_frmStatSocietyDetail);
        return this.m_frmStatSocietyDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmStatSocietyDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmStatSocietyDetail>(ref this.m_frmStatSocietyDetail);
      }
    }

    public frmSubGroup frmSubGroup
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSubGroup = MyProject.MyForms.Create__Instance__<frmSubGroup>(this.m_frmSubGroup);
        return this.m_frmSubGroup;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSubGroup)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSubGroup>(ref this.m_frmSubGroup);
      }
    }

    public frmSubGroupDetail frmSubGroupDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmSubGroupDetail = MyProject.MyForms.Create__Instance__<frmSubGroupDetail>(this.m_frmSubGroupDetail);
        return this.m_frmSubGroupDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmSubGroupDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmSubGroupDetail>(ref this.m_frmSubGroupDetail);
      }
    }

    public frmTEST frmTEST
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmTEST = MyProject.MyForms.Create__Instance__<frmTEST>(this.m_frmTEST);
        return this.m_frmTEST;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmTEST)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmTEST>(ref this.m_frmTEST);
      }
    }

    public frmtest1 frmtest1
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmtest1 = MyProject.MyForms.Create__Instance__<frmtest1>(this.m_frmtest1);
        return this.m_frmtest1;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmtest1)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmtest1>(ref this.m_frmtest1);
      }
    }

    public frmTransfer frmTransfer
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmTransfer = MyProject.MyForms.Create__Instance__<frmTransfer>(this.m_frmTransfer);
        return this.m_frmTransfer;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmTransfer)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmTransfer>(ref this.m_frmTransfer);
      }
    }

    public frmTranType frmTranType
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmTranType = MyProject.MyForms.Create__Instance__<frmTranType>(this.m_frmTranType);
        return this.m_frmTranType;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmTranType)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmTranType>(ref this.m_frmTranType);
      }
    }

    public frmTranTypeAdd frmTranTypeAdd
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmTranTypeAdd = MyProject.MyForms.Create__Instance__<frmTranTypeAdd>(this.m_frmTranTypeAdd);
        return this.m_frmTranTypeAdd;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmTranTypeAdd)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmTranTypeAdd>(ref this.m_frmTranTypeAdd);
      }
    }

    public frmTranTypeDetail frmTranTypeDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmTranTypeDetail = MyProject.MyForms.Create__Instance__<frmTranTypeDetail>(this.m_frmTranTypeDetail);
        return this.m_frmTranTypeDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmTranTypeDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmTranTypeDetail>(ref this.m_frmTranTypeDetail);
      }
    }

    public frmVendor frmVendor
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmVendor = MyProject.MyForms.Create__Instance__<frmVendor>(this.m_frmVendor);
        return this.m_frmVendor;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmVendor)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmVendor>(ref this.m_frmVendor);
      }
    }

    public frmVendorDetail frmVendorDetail
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmVendorDetail = MyProject.MyForms.Create__Instance__<frmVendorDetail>(this.m_frmVendorDetail);
        return this.m_frmVendorDetail;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmVendorDetail)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmVendorDetail>(ref this.m_frmVendorDetail);
      }
    }

    public frmWhatsupCommittee frmWhatsupCommittee
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmWhatsupCommittee = MyProject.MyForms.Create__Instance__<frmWhatsupCommittee>(this.m_frmWhatsupCommittee);
        return this.m_frmWhatsupCommittee;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmWhatsupCommittee)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmWhatsupCommittee>(ref this.m_frmWhatsupCommittee);
      }
    }

    public frmWhatsupMemberAccount frmWhatsupMemberAccount
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmWhatsupMemberAccount = MyProject.MyForms.Create__Instance__<frmWhatsupMemberAccount>(this.m_frmWhatsupMemberAccount);
        return this.m_frmWhatsupMemberAccount;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmWhatsupMemberAccount)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmWhatsupMemberAccount>(ref this.m_frmWhatsupMemberAccount);
      }
    }

    public frmWhatsupSetting frmWhatsupSetting
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmWhatsupSetting = MyProject.MyForms.Create__Instance__<frmWhatsupSetting>(this.m_frmWhatsupSetting);
        return this.m_frmWhatsupSetting;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmWhatsupSetting)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmWhatsupSetting>(ref this.m_frmWhatsupSetting);
      }
    }

    public frmYearBf frmYearBf
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmYearBf = MyProject.MyForms.Create__Instance__<frmYearBf>(this.m_frmYearBf);
        return this.m_frmYearBf;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmYearBf)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmYearBf>(ref this.m_frmYearBf);
      }
    }

    public frmYearcf frmYearcf
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmYearcf = MyProject.MyForms.Create__Instance__<frmYearcf>(this.m_frmYearcf);
        return this.m_frmYearcf;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmYearcf)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmYearcf>(ref this.m_frmYearcf);
      }
    }

    public frmYearExten frmYearExten
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmYearExten = MyProject.MyForms.Create__Instance__<frmYearExten>(this.m_frmYearExten);
        return this.m_frmYearExten;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmYearExten)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmYearExten>(ref this.m_frmYearExten);
      }
    }

    public frmZerowise frmZerowise
    {
      [DebuggerNonUserCode] get
      {
        this.m_frmZerowise = MyProject.MyForms.Create__Instance__<frmZerowise>(this.m_frmZerowise);
        return this.m_frmZerowise;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_frmZerowise)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<frmZerowise>(ref this.m_frmZerowise);
      }
    }

    public ILISTMultiple ILISTMultiple
    {
      [DebuggerNonUserCode] get
      {
        this.m_ILISTMultiple = MyProject.MyForms.Create__Instance__<ILISTMultiple>(this.m_ILISTMultiple);
        return this.m_ILISTMultiple;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_ILISTMultiple)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<ILISTMultiple>(ref this.m_ILISTMultiple);
      }
    }

    public JLISTMulti JLISTMulti
    {
      [DebuggerNonUserCode] get
      {
        this.m_JLISTMulti = MyProject.MyForms.Create__Instance__<JLISTMulti>(this.m_JLISTMulti);
        return this.m_JLISTMulti;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_JLISTMulti)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<JLISTMulti>(ref this.m_JLISTMulti);
      }
    }

    public LoginDetails LoginDetails
    {
      [DebuggerNonUserCode] get
      {
        this.m_LoginDetails = MyProject.MyForms.Create__Instance__<LoginDetails>(this.m_LoginDetails);
        return this.m_LoginDetails;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_LoginDetails)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<LoginDetails>(ref this.m_LoginDetails);
      }
    }

    public LoginForm1 LoginForm1
    {
      [DebuggerNonUserCode] get
      {
        this.m_LoginForm1 = MyProject.MyForms.Create__Instance__<LoginForm1>(this.m_LoginForm1);
        return this.m_LoginForm1;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_LoginForm1)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<LoginForm1>(ref this.m_LoginForm1);
      }
    }

    public OverwirteDialog OverwirteDialog
    {
      [DebuggerNonUserCode] get
      {
        this.m_OverwirteDialog = MyProject.MyForms.Create__Instance__<OverwirteDialog>(this.m_OverwirteDialog);
        return this.m_OverwirteDialog;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_OverwirteDialog)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<OverwirteDialog>(ref this.m_OverwirteDialog);
      }
    }

    public SLISTMultiple SLISTMultiple
    {
      [DebuggerNonUserCode] get
      {
        this.m_SLISTMultiple = MyProject.MyForms.Create__Instance__<SLISTMultiple>(this.m_SLISTMultiple);
        return this.m_SLISTMultiple;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_SLISTMultiple)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<SLISTMultiple>(ref this.m_SLISTMultiple);
      }
    }

    public SocietyBfDialog SocietyBfDialog
    {
      [DebuggerNonUserCode] get
      {
        this.m_SocietyBfDialog = MyProject.MyForms.Create__Instance__<SocietyBfDialog>(this.m_SocietyBfDialog);
        return this.m_SocietyBfDialog;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_SocietyBfDialog)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<SocietyBfDialog>(ref this.m_SocietyBfDialog);
      }
    }

    public SocietyDeleteDialog SocietyDeleteDialog
    {
      [DebuggerNonUserCode] get
      {
        this.m_SocietyDeleteDialog = MyProject.MyForms.Create__Instance__<SocietyDeleteDialog>(this.m_SocietyDeleteDialog);
        return this.m_SocietyDeleteDialog;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_SocietyDeleteDialog)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<SocietyDeleteDialog>(ref this.m_SocietyDeleteDialog);
      }
    }

    public SplashScreen1 SplashScreen1
    {
      [DebuggerNonUserCode] get
      {
        this.m_SplashScreen1 = MyProject.MyForms.Create__Instance__<SplashScreen1>(this.m_SplashScreen1);
        return this.m_SplashScreen1;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_SplashScreen1)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<SplashScreen1>(ref this.m_SplashScreen1);
      }
    }

    public UpdateChangesDialog UpdateChangesDialog
    {
      [DebuggerNonUserCode] get
      {
        this.m_UpdateChangesDialog = MyProject.MyForms.Create__Instance__<UpdateChangesDialog>(this.m_UpdateChangesDialog);
        return this.m_UpdateChangesDialog;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_UpdateChangesDialog)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<UpdateChangesDialog>(ref this.m_UpdateChangesDialog);
      }
    }

    public WarningDialog WarningDialog
    {
      [DebuggerNonUserCode] get
      {
        this.m_WarningDialog = MyProject.MyForms.Create__Instance__<WarningDialog>(this.m_WarningDialog);
        return this.m_WarningDialog;
      }
      [DebuggerNonUserCode] set
      {
        if (value == this.m_WarningDialog)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        this.Dispose__Instance__<WarningDialog>(ref this.m_WarningDialog);
      }
    }

    [DebuggerHidden]
    private static T Create__Instance__<T>(T Instance) where T : Form, new()
    {
      if ((object) Instance != null && !Instance.IsDisposed)
        return Instance;
      if (MyProject.MyForms.m_FormBeingCreated != null)
      {
        if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
      }
      else
        MyProject.MyForms.m_FormBeingCreated = new Hashtable();
      MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
      try
      {
        return new T();
      }
      catch (TargetInvocationException ex) when (
      {
        // ISSUE: unable to correctly present filter
        ProjectData.SetProjectError((Exception) ex);
        if (ex.InnerException != null)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
      }
      finally
      {
        MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
      }
    }

    [DebuggerHidden]
    private void Dispose__Instance__<T>(ref T instance) where T : Form
    {
      instance.Dispose();
      instance = default (T);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public MyForms()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => base.GetHashCode();

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal new System.Type GetType() => typeof (MyProject.MyForms);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() => base.ToString();
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
  internal sealed class MyWebServices
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public override int GetHashCode() => base.GetHashCode();

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    internal new System.Type GetType() => typeof (MyProject.MyWebServices);

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() => base.ToString();

    [DebuggerHidden]
    private static T Create__Instance__<T>(T instance) where T : new()
    {
      return (object) instance == null ? new T() : instance;
    }

    [DebuggerHidden]
    private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public MyWebServices()
    {
    }
  }

  [ComVisible(false)]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal sealed class ThreadSafeObjectProvider<T> where T : new()
  {
    internal T GetInstance
    {
      [DebuggerHidden] get
      {
        if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
          MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
        return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
      }
    }

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ThreadSafeObjectProvider()
    {
    }
  }
}
