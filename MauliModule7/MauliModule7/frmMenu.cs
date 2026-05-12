// Decompiled with JetBrains decompiler
// Type: MauliModule7.frmMenu
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MauliModule7;

[DesignerGenerated]
public class frmMenu : Form
{
  private static List<WeakReference> __ENCList = new List<WeakReference>();
  private IContainer components;
  [AccessedThroughProperty("ToolTip")]
  private ToolTip _ToolTip;
  [AccessedThroughProperty("MS")]
  private MenuStrip _MS;
  [AccessedThroughProperty("MasterToolStripMenuItem")]
  private ToolStripMenuItem _MasterToolStripMenuItem;
  [AccessedThroughProperty("GroupToolStripMenuItem")]
  private ToolStripMenuItem _GroupToolStripMenuItem;
  [AccessedThroughProperty("AccountToolStripMenuItem")]
  private ToolStripMenuItem _AccountToolStripMenuItem;
  [AccessedThroughProperty("TransactionToolStripMenuItem")]
  private ToolStripMenuItem _TransactionToolStripMenuItem;
  [AccessedThroughProperty("UtilityToolStripMenuItem")]
  private ToolStripMenuItem _UtilityToolStripMenuItem;
  [AccessedThroughProperty("ExitToolStripMenuItem")]
  private ToolStripMenuItem _ExitToolStripMenuItem;
  [AccessedThroughProperty("MemberToolStripMenuItem")]
  private ToolStripMenuItem _MemberToolStripMenuItem;
  [AccessedThroughProperty("MemberBillingToolStripMenuItem")]
  private ToolStripMenuItem _MemberBillingToolStripMenuItem;
  [AccessedThroughProperty("PaymentToolStripMenuItem")]
  private ToolStripMenuItem _PaymentToolStripMenuItem;
  [AccessedThroughProperty("MemberReceiptToolStripMenuItem")]
  private ToolStripMenuItem _MemberReceiptToolStripMenuItem;
  [AccessedThroughProperty("MemberBillToolStripMenuItem")]
  private ToolStripMenuItem _MemberBillToolStripMenuItem;
  [AccessedThroughProperty("ReceiptToolStripMenuItem")]
  private ToolStripMenuItem _ReceiptToolStripMenuItem;
  [AccessedThroughProperty("JournalToolStripMenuItem")]
  private ToolStripMenuItem _JournalToolStripMenuItem;
  [AccessedThroughProperty("SocietyToolStripMenuItem")]
  private ToolStripMenuItem _SocietyToolStripMenuItem;
  [AccessedThroughProperty("ContraToolStripMenuItem1")]
  private ToolStripMenuItem _ContraToolStripMenuItem1;
  [AccessedThroughProperty("OpeningBankRecoToolStripMenuItem")]
  private ToolStripMenuItem _OpeningBankRecoToolStripMenuItem;
  [AccessedThroughProperty("RenumberToolStripMenuItem")]
  private ToolStripMenuItem _RenumberToolStripMenuItem;
  [AccessedThroughProperty("MemberAdjustmentToolStripMenuItem1")]
  private ToolStripMenuItem _MemberAdjustmentToolStripMenuItem1;
  [AccessedThroughProperty("MemberDebitNoteToolStripMenuItem1")]
  private ToolStripMenuItem _MemberDebitNoteToolStripMenuItem1;
  [AccessedThroughProperty("MemberCreditNoteToolStripMenuItem1")]
  private ToolStripMenuItem _MemberCreditNoteToolStripMenuItem1;
  [AccessedThroughProperty("BankRecoToolStripMenuItem")]
  private ToolStripMenuItem _BankRecoToolStripMenuItem;
  [AccessedThroughProperty("TranferToolStripMenuItem")]
  private ToolStripMenuItem _TranferToolStripMenuItem;
  [AccessedThroughProperty("ToolStripSeparator2")]
  private ToolStripSeparator _ToolStripSeparator2;
  [AccessedThroughProperty("ToolStripSeparator3")]
  private ToolStripSeparator _ToolStripSeparator3;
  [AccessedThroughProperty("ToolStripMenuItem2")]
  private ToolStripMenuItem _ToolStripMenuItem2;
  [AccessedThroughProperty("ToolStripMenuItem3")]
  private ToolStripMenuItem _ToolStripMenuItem3;
  [AccessedThroughProperty("MemberAccountToolStripMenuItem")]
  private ToolStripMenuItem _MemberAccountToolStripMenuItem;
  [AccessedThroughProperty("OutstandingListToolStripMenuItem")]
  private ToolStripMenuItem _OutstandingListToolStripMenuItem;
  [AccessedThroughProperty("TrialBalanceToolStripMenuItem3")]
  private ToolStripMenuItem _TrialBalanceToolStripMenuItem3;
  [AccessedThroughProperty("ReceiptPaymentAcToolStripMenuItem1")]
  private ToolStripMenuItem _ReceiptPaymentAcToolStripMenuItem1;
  [AccessedThroughProperty("IncomeExpenditureAcToolStripMenuItem")]
  private ToolStripMenuItem _IncomeExpenditureAcToolStripMenuItem;
  [AccessedThroughProperty("BalanceSheetToolStripMenuItem2")]
  private ToolStripMenuItem _BalanceSheetToolStripMenuItem2;
  [AccessedThroughProperty("BillToolStripMenuItem1")]
  private ToolStripMenuItem _BillToolStripMenuItem1;
  [AccessedThroughProperty("ReceiptToolStripMenuItem3")]
  private ToolStripMenuItem _ReceiptToolStripMenuItem3;
  [AccessedThroughProperty("DebitNoteToolStripMenuItem")]
  private ToolStripMenuItem _DebitNoteToolStripMenuItem;
  [AccessedThroughProperty("CreditNoteToolStripMenuItem")]
  private ToolStripMenuItem _CreditNoteToolStripMenuItem;
  [AccessedThroughProperty("ToolStripMenuItem5")]
  private ToolStripMenuItem _ToolStripMenuItem5;
  [AccessedThroughProperty("ReceiptVoucherToolStripMenuItem1")]
  private ToolStripMenuItem _ReceiptVoucherToolStripMenuItem1;
  [AccessedThroughProperty("PaymentVoucherToolStripMenuItem1")]
  private ToolStripMenuItem _PaymentVoucherToolStripMenuItem1;
  [AccessedThroughProperty("ContraVoucherToolStripMenuItem1")]
  private ToolStripMenuItem _ContraVoucherToolStripMenuItem1;
  [AccessedThroughProperty("TS")]
  private ToolStrip _TS;
  [AccessedThroughProperty("ToolStripButton1")]
  private ToolStripButton _ToolStripButton1;
  [AccessedThroughProperty("ToolStripSeparator17")]
  private ToolStripSeparator _ToolStripSeparator17;
  [AccessedThroughProperty("ToolStripSeparator5")]
  private ToolStripSeparator _ToolStripSeparator5;
  [AccessedThroughProperty("ToolStripButton7")]
  private ToolStripButton _ToolStripButton7;
  [AccessedThroughProperty("ToolStripButton5")]
  private ToolStripButton _ToolStripButton5;
  [AccessedThroughProperty("ToolStripButton4")]
  private ToolStripButton _ToolStripButton4;
  [AccessedThroughProperty("ToolStripButton8")]
  private ToolStripButton _ToolStripButton8;
  [AccessedThroughProperty("ToolStripButton14")]
  private ToolStripButton _ToolStripButton14;
  [AccessedThroughProperty("ToolStripButton11")]
  private ToolStripButton _ToolStripButton11;
  [AccessedThroughProperty("ToolStripButton2")]
  private ToolStripButton _ToolStripButton2;
  [AccessedThroughProperty("ToolStripButton10")]
  private ToolStripButton _ToolStripButton10;
  [AccessedThroughProperty("ToolStripButton9")]
  private ToolStripButton _ToolStripButton9;
  [AccessedThroughProperty("ToolStripButton6")]
  private ToolStripButton _ToolStripButton6;
  [AccessedThroughProperty("ToolStripButton3")]
  private ToolStripButton _ToolStripButton3;
  [AccessedThroughProperty("ToolStripButton12")]
  private ToolStripButton _ToolStripButton12;
  [AccessedThroughProperty("ToolStripSeparator6")]
  private ToolStripSeparator _ToolStripSeparator6;
  [AccessedThroughProperty("ToolStripButton13")]
  private ToolStripButton _ToolStripButton13;
  [AccessedThroughProperty("ToolStripButton15")]
  private ToolStripButton _ToolStripButton15;
  [AccessedThroughProperty("ToolStripButton16")]
  private ToolStripButton _ToolStripButton16;
  [AccessedThroughProperty("ToolStripButton17")]
  private ToolStripButton _ToolStripButton17;
  [AccessedThroughProperty("ToolStripSeparator7")]
  private ToolStripSeparator _ToolStripSeparator7;
  [AccessedThroughProperty("ToolStripButton18")]
  private ToolStripButton _ToolStripButton18;
  [AccessedThroughProperty("ScheduleToolStripMenuItem1")]
  private ToolStripMenuItem _ScheduleToolStripMenuItem1;
  [AccessedThroughProperty("ToolStripSeparator1")]
  private ToolStripSeparator _ToolStripSeparator1;
  [AccessedThroughProperty("ToolStripSeparator8")]
  private ToolStripSeparator _ToolStripSeparator8;
  [AccessedThroughProperty("ToolStripSeparator9")]
  private ToolStripSeparator _ToolStripSeparator9;
  [AccessedThroughProperty("YearCfToolStripMenuItem")]
  private ToolStripMenuItem _YearCfToolStripMenuItem;
  [AccessedThroughProperty("StatusStrip1")]
  private StatusStrip _StatusStrip1;
  [AccessedThroughProperty("lblTS1")]
  private ToolStripStatusLabel _lblTS1;
  [AccessedThroughProperty("GroupReceiptPaymentAcToolStripMenuItem")]
  private ToolStripMenuItem _GroupReceiptPaymentAcToolStripMenuItem;
  [AccessedThroughProperty("DefultGroupSettingToolStripMenuItem")]
  private ToolStripMenuItem _DefultGroupSettingToolStripMenuItem;
  [AccessedThroughProperty("QuickNoteToolStripMenuItem")]
  private ToolStripMenuItem _QuickNoteToolStripMenuItem;
  [AccessedThroughProperty("ExportTestToolStripMenuItem")]
  private ToolStripMenuItem _ExportTestToolStripMenuItem;
  [AccessedThroughProperty("DataGridView1")]
  private DataGridView _DataGridView1;
  [AccessedThroughProperty("CashBankBookToolStripMenuItem")]
  private ToolStripMenuItem _CashBankBookToolStripMenuItem;
  [AccessedThroughProperty("RebuildToolStripMenuItem")]
  private ToolStripMenuItem _RebuildToolStripMenuItem;
  [AccessedThroughProperty("ToolStripSeparator10")]
  private ToolStripSeparator _ToolStripSeparator10;
  [AccessedThroughProperty("BillRegisterToolStripMenuItem")]
  private ToolStripMenuItem _BillRegisterToolStripMenuItem;
  [AccessedThroughProperty("ReceiptRegisterToolStripMenuItem")]
  private ToolStripMenuItem _ReceiptRegisterToolStripMenuItem;
  [AccessedThroughProperty("DebitNoteRegisterToolStripMenuItem")]
  private ToolStripMenuItem _DebitNoteRegisterToolStripMenuItem;
  [AccessedThroughProperty("CreditNoteRegisterToolStripMenuItem")]
  private ToolStripMenuItem _CreditNoteRegisterToolStripMenuItem;
  [AccessedThroughProperty("AdjustmentRegisterToolStripMenuItem")]
  private ToolStripMenuItem _AdjustmentRegisterToolStripMenuItem;
  [AccessedThroughProperty("ToolStripSeparator11")]
  private ToolStripSeparator _ToolStripSeparator11;
  [AccessedThroughProperty("DataSheetToolStripMenuItem1")]
  private ToolStripMenuItem _DataSheetToolStripMenuItem1;
  [AccessedThroughProperty("BankDepositListToolStripMenuItem1")]
  private ToolStripMenuItem _BankDepositListToolStripMenuItem1;
  [AccessedThroughProperty("AccountLedgerToolStripMenuItem")]
  private ToolStripMenuItem _AccountLedgerToolStripMenuItem;
  [AccessedThroughProperty("ReceiptRegiToolStripMenuItem")]
  private ToolStripMenuItem _ReceiptRegiToolStripMenuItem;
  [AccessedThroughProperty("PaymentRegisterToolStripMenuItem")]
  private ToolStripMenuItem _PaymentRegisterToolStripMenuItem;
  [AccessedThroughProperty("ContraRegisterToolStripMenuItem")]
  private ToolStripMenuItem _ContraRegisterToolStripMenuItem;
  [AccessedThroughProperty("JournalRegisterToolStripMenuItem")]
  private ToolStripMenuItem _JournalRegisterToolStripMenuItem;
  [AccessedThroughProperty("ToolStripMenuItem1")]
  private ToolStripMenuItem _ToolStripMenuItem1;
  [AccessedThroughProperty("ToolStripSeparator4")]
  private ToolStripSeparator _ToolStripSeparator4;
  [AccessedThroughProperty("DataGridView3")]
  private DataGridView _DataGridView3;
  [AccessedThroughProperty("ToolStripButton19")]
  private ToolStripButton _ToolStripButton19;
  [AccessedThroughProperty("ChangeYearToolStripMenuItem")]
  private ToolStripMenuItem _ChangeYearToolStripMenuItem;
  [AccessedThroughProperty("ToolStripMenuItem4")]
  private ToolStripMenuItem _ToolStripMenuItem4;
  [AccessedThroughProperty("ToolStripMenuItem6")]
  private ToolStripMenuItem _ToolStripMenuItem6;
  [AccessedThroughProperty("ToolStripMenuItem7")]
  private ToolStripMenuItem _ToolStripMenuItem7;
  [AccessedThroughProperty("VendorToolStripMenuItem")]
  private ToolStripMenuItem _VendorToolStripMenuItem;
  [AccessedThroughProperty("ServantToolStripMenuItem")]
  private ToolStripMenuItem _ServantToolStripMenuItem;
  [AccessedThroughProperty("FToolStripMenuItem")]
  private ToolStripMenuItem _FToolStripMenuItem;
  [AccessedThroughProperty("MultiReceiptToolStripMenuItem")]
  private ToolStripMenuItem _MultiReceiptToolStripMenuItem;
  [AccessedThroughProperty("MULToolStripMenuItem")]
  private ToolStripMenuItem _MULToolStripMenuItem;
  [AccessedThroughProperty("ToolStripSeparator12")]
  private ToolStripSeparator _ToolStripSeparator12;
  [AccessedThroughProperty("ToolStripMenuItem8")]
  private ToolStripMenuItem _ToolStripMenuItem8;
  [AccessedThroughProperty("ToolStripSplitButton1")]
  private ToolStripSplitButton _ToolStripSplitButton1;
  [AccessedThroughProperty("CalculatorToolStripMenuItem")]
  private ToolStripMenuItem _CalculatorToolStripMenuItem;
  [AccessedThroughProperty("YearBfToolStripMenuItem")]
  private ToolStripMenuItem _YearBfToolStripMenuItem;
  [AccessedThroughProperty("NewTtanTypeToolStripMenuItem")]
  private ToolStripMenuItem _NewTtanTypeToolStripMenuItem;
  [AccessedThroughProperty("StatutoryToolStripMenuItem")]
  private ToolStripMenuItem _StatutoryToolStripMenuItem;
  [AccessedThroughProperty("MasterToolStripMenuItem1")]
  private ToolStripMenuItem _MasterToolStripMenuItem1;
  [AccessedThroughProperty("JRegisterToolStripMenuItem")]
  private ToolStripMenuItem _JRegisterToolStripMenuItem;
  [AccessedThroughProperty("ShareRegisterToolStripMenuItem")]
  private ToolStripMenuItem _ShareRegisterToolStripMenuItem;
  [AccessedThroughProperty("IRegisterToolStripMenuItem")]
  private ToolStripMenuItem _IRegisterToolStripMenuItem;
  [AccessedThroughProperty("IRegisterToolStripMenuItem1")]
  private ToolStripMenuItem _IRegisterToolStripMenuItem1;
  [AccessedThroughProperty("PropertyRegisterToolStripMenuItem")]
  private ToolStripMenuItem _PropertyRegisterToolStripMenuItem;
  [AccessedThroughProperty("SocietyStatMasterToolStripMenuItem")]
  private ToolStripMenuItem _SocietyStatMasterToolStripMenuItem;
  [AccessedThroughProperty("ToolStripSeparator13")]
  private ToolStripSeparator _ToolStripSeparator13;
  [AccessedThroughProperty("ToolStripSeparator14")]
  private ToolStripSeparator _ToolStripSeparator14;
  [AccessedThroughProperty("SinkingFundLedgerToolStripMenuItem")]
  private ToolStripMenuItem _SinkingFundLedgerToolStripMenuItem;
  [AccessedThroughProperty("InvestmentRegisterToolStripMenuItem")]
  private ToolStripMenuItem _InvestmentRegisterToolStripMenuItem;
  [AccessedThroughProperty("ToolStripMenuItem9")]
  private ToolStripMenuItem _ToolStripMenuItem9;
  [AccessedThroughProperty("AboutUsToolStripMenuItem")]
  private ToolStripMenuItem _AboutUsToolStripMenuItem;
  [AccessedThroughProperty("ToolStripSeparator15")]
  private ToolStripSeparator _ToolStripSeparator15;
  [AccessedThroughProperty("AuditFormNo28ToolStripMenuItem")]
  private ToolStripMenuItem _AuditFormNo28ToolStripMenuItem;
  [AccessedThroughProperty("AuditFormNo1ToolStripMenuItem")]
  private ToolStripMenuItem _AuditFormNo1ToolStripMenuItem;
  [AccessedThroughProperty("AuditGeneralRemarkToolStripMenuItem")]
  private ToolStripMenuItem _AuditGeneralRemarkToolStripMenuItem;
  [AccessedThroughProperty("AuditOFormToolStripMenuItem")]
  private ToolStripMenuItem _AuditOFormToolStripMenuItem;
  [AccessedThroughProperty("ToolStripSeparator16")]
  private ToolStripSeparator _ToolStripSeparator16;
  [AccessedThroughProperty("ByeLawsToolStripMenuItem")]
  private ToolStripMenuItem _ByeLawsToolStripMenuItem;
  [AccessedThroughProperty("CaclulatorToolStripMenuItem")]
  private ToolStripMenuItem _CaclulatorToolStripMenuItem;
  [AccessedThroughProperty("JRegisterToolStripMenuItem1")]
  private ToolStripMenuItem _JRegisterToolStripMenuItem1;
  [AccessedThroughProperty("ShareRegisterToolStripMenuItem1")]
  private ToolStripMenuItem _ShareRegisterToolStripMenuItem1;
  [AccessedThroughProperty("NominationRegisterToolStripMenuItem")]
  private ToolStripMenuItem _NominationRegisterToolStripMenuItem;
  [AccessedThroughProperty("IRegisterToolStripMenuItem2")]
  private ToolStripMenuItem _IRegisterToolStripMenuItem2;
  [AccessedThroughProperty("PropertyRegisterToolStripMenuItem1")]
  private ToolStripMenuItem _PropertyRegisterToolStripMenuItem1;
  [AccessedThroughProperty("InvestmentRegisterToolStripMenuItem1")]
  private ToolStripMenuItem _InvestmentRegisterToolStripMenuItem1;
  [AccessedThroughProperty("SinkingFundLedgerToolStripMenuItem1")]
  private ToolStripMenuItem _SinkingFundLedgerToolStripMenuItem1;
  [AccessedThroughProperty("NominationFormToolStripMenuItem")]
  private ToolStripMenuItem _NominationFormToolStripMenuItem;
  [AccessedThroughProperty("FlatTransferDocumentToolStripMenuItem")]
  private ToolStripMenuItem _FlatTransferDocumentToolStripMenuItem;
  [AccessedThroughProperty("ShareCertificateToolStripMenuItem")]
  private ToolStripMenuItem _ShareCertificateToolStripMenuItem;
  [AccessedThroughProperty("MemberDetailFormToolStripMenuItem")]
  private ToolStripMenuItem _MemberDetailFormToolStripMenuItem;
  [AccessedThroughProperty("SocietyDetailFormToolStripMenuItem")]
  private ToolStripMenuItem _SocietyDetailFormToolStripMenuItem;
  [AccessedThroughProperty("OtherFormatsToolStripMenuItem")]
  private ToolStripMenuItem _OtherFormatsToolStripMenuItem;
  [AccessedThroughProperty("ToolStripMenuItem10")]
  private ToolStripMenuItem _ToolStripMenuItem10;
  [AccessedThroughProperty("CommitteeMasterToolStripMenuItem")]
  private ToolStripMenuItem _CommitteeMasterToolStripMenuItem;
  [AccessedThroughProperty("CheckDifferenceToolStripMenuItem")]
  private ToolStripMenuItem _CheckDifferenceToolStripMenuItem;
  [AccessedThroughProperty("OpeningBalancesToolStripMenuItem")]
  private ToolStripMenuItem _OpeningBalancesToolStripMenuItem;
  [AccessedThroughProperty("IToolStripMenuItem")]
  private ToolStripMenuItem _IToolStripMenuItem;
  [AccessedThroughProperty("MultiJRegisterToolStripMenuItem")]
  private ToolStripMenuItem _MultiJRegisterToolStripMenuItem;
  [AccessedThroughProperty("ShareRegisterMultiUpdateToolStripMenuItem")]
  private ToolStripMenuItem _ShareRegisterMultiUpdateToolStripMenuItem;
  [AccessedThroughProperty("IRegisterMulitUpdateToolStripMenuItem")]
  private ToolStripMenuItem _IRegisterMulitUpdateToolStripMenuItem;
  [AccessedThroughProperty("TransferFlatToolStripMenuItem")]
  private ToolStripMenuItem _TransferFlatToolStripMenuItem;
  [AccessedThroughProperty("MemberListToolStripMenuItem")]
  private ToolStripMenuItem _MemberListToolStripMenuItem;
  [AccessedThroughProperty("ElectionListToolStripMenuItem")]
  private ToolStripMenuItem _ElectionListToolStripMenuItem;
  [AccessedThroughProperty("ToolStripMenuItem11")]
  private ToolStripMenuItem _ToolStripMenuItem11;
  [AccessedThroughProperty("ToolStripSeparator18")]
  private ToolStripSeparator _ToolStripSeparator18;
  [AccessedThroughProperty("MemberMasterFromExcelToolStripMenuItem")]
  private ToolStripMenuItem _MemberMasterFromExcelToolStripMenuItem;
  [AccessedThroughProperty("BankListFromOtherSocietyToolStripMenuItem")]
  private ToolStripMenuItem _BankListFromOtherSocietyToolStripMenuItem;
  [AccessedThroughProperty("PersonListFromOtherSocietyToolStripMenuItem")]
  private ToolStripMenuItem _PersonListFromOtherSocietyToolStripMenuItem;
  [AccessedThroughProperty("ToolStripMenuItem12")]
  private ToolStripMenuItem _ToolStripMenuItem12;
  [AccessedThroughProperty("GroupAccountMasterFromOtherSoceityToolStripMenuItem")]
  private ToolStripMenuItem _GroupAccountMasterFromOtherSoceityToolStripMenuItem;
  [AccessedThroughProperty("MemberOpeningBalanceBifurcationToolStripMenuItem")]
  private ToolStripMenuItem _MemberOpeningBalanceBifurcationToolStripMenuItem;
  [AccessedThroughProperty("SocietyMasterReceiptRemarkToolStripMenuItem")]
  private ToolStripMenuItem _SocietyMasterReceiptRemarkToolStripMenuItem;
  [AccessedThroughProperty("SetBillPrintingOptionToolStripMenuItem")]
  private ToolStripMenuItem _SetBillPrintingOptionToolStripMenuItem;
  [AccessedThroughProperty("DataGridView2")]
  private DataGridView _DataGridView2;
  [AccessedThroughProperty("HalfPageToolStripMenuItem")]
  private ToolStripMenuItem _HalfPageToolStripMenuItem;
  [AccessedThroughProperty("FullPage14HeadToolStripMenuItem")]
  private ToolStripMenuItem _FullPage14HeadToolStripMenuItem;
  [AccessedThroughProperty("FullPage21HeadToolStripMenuItem")]
  private ToolStripMenuItem _FullPage21HeadToolStripMenuItem;
  [AccessedThroughProperty("HalfPageToolStripMenuItem1")]
  private ToolStripMenuItem _HalfPageToolStripMenuItem1;
  [AccessedThroughProperty("FullPage14HeadToolStripMenuItem1")]
  private ToolStripMenuItem _FullPage14HeadToolStripMenuItem1;
  [AccessedThroughProperty("FullPage21HeadToolStripMenuItem1")]
  private ToolStripMenuItem _FullPage21HeadToolStripMenuItem1;
  [AccessedThroughProperty("GSTMasterToolStripMenuItem")]
  private ToolStripMenuItem _GSTMasterToolStripMenuItem;
  [AccessedThroughProperty("GSTCalculateToolStripMenuItem")]
  private ToolStripMenuItem _GSTCalculateToolStripMenuItem;
  [AccessedThroughProperty("HalfPageGSTVerticalDoubleBillToolStripMenuItem")]
  private ToolStripMenuItem _HalfPageGSTVerticalDoubleBillToolStripMenuItem;
  [AccessedThroughProperty("ListToolStripMenuItem")]
  private ToolStripMenuItem _ListToolStripMenuItem;
  [AccessedThroughProperty("FormToolStripMenuItem")]
  private ToolStripMenuItem _FormToolStripMenuItem;
  [AccessedThroughProperty("OtherInfoToolStripMenuItem")]
  private ToolStripMenuItem _OtherInfoToolStripMenuItem;
  [AccessedThroughProperty("MemberReceiptFromExcelToolStripMenuItem")]
  private ToolStripMenuItem _MemberReceiptFromExcelToolStripMenuItem;
  [AccessedThroughProperty("A4ToolStripMenuItem")]
  private ToolStripMenuItem _A4ToolStripMenuItem;
  [AccessedThroughProperty("LegalPaperToolStripMenuItem")]
  private ToolStripMenuItem _LegalPaperToolStripMenuItem;
  [AccessedThroughProperty("A4PaperToolStripMenuItem")]
  private ToolStripMenuItem _A4PaperToolStripMenuItem;
  [AccessedThroughProperty("LegalPaperToolStripMenuItem1")]
  private ToolStripMenuItem _LegalPaperToolStripMenuItem1;
  [AccessedThroughProperty("A4PaperToolStripMenuItem1")]
  private ToolStripMenuItem _A4PaperToolStripMenuItem1;
  [AccessedThroughProperty("LegalPaperToolStripMenuItem2")]
  private ToolStripMenuItem _LegalPaperToolStripMenuItem2;
  [AccessedThroughProperty("A4PaperToolStripMenuItem2")]
  private ToolStripMenuItem _A4PaperToolStripMenuItem2;
  [AccessedThroughProperty("LegalPaperToolStripMenuItem3")]
  private ToolStripMenuItem _LegalPaperToolStripMenuItem3;
  [AccessedThroughProperty("ToolStripMenuItem13")]
  private ToolStripMenuItem _ToolStripMenuItem13;
  [AccessedThroughProperty("ToolStripMenuItem16")]
  private ToolStripMenuItem _ToolStripMenuItem16;
  [AccessedThroughProperty("PaymentFromExcelToolStripMenuItem")]
  private ToolStripMenuItem _PaymentFromExcelToolStripMenuItem;
  [AccessedThroughProperty("ToolStripSeparator21")]
  private ToolStripSeparator _ToolStripSeparator21;
  [AccessedThroughProperty("ToolStripButton20")]
  private ToolStripButton _ToolStripButton20;
  [AccessedThroughProperty("ToolStripLabel1")]
  private ToolStripLabel _ToolStripLabel1;
  [AccessedThroughProperty("ToolStripButton21")]
  private ToolStripButton _ToolStripButton21;
  [AccessedThroughProperty("ToolStripButton22")]
  private ToolStripButton _ToolStripButton22;
  [AccessedThroughProperty("ToolStripButton23")]
  private ToolStripButton _ToolStripButton23;
  [AccessedThroughProperty("ToolStripButton24")]
  private ToolStripButton _ToolStripButton24;
  [AccessedThroughProperty("IncomeExpenditureAcMarathiToolStripMenuItem")]
  private ToolStripMenuItem _IncomeExpenditureAcMarathiToolStripMenuItem;
  [AccessedThroughProperty("BalanceSheetMarathiToolStripMenuItem")]
  private ToolStripMenuItem _BalanceSheetMarathiToolStripMenuItem;
  [AccessedThroughProperty("SelectedBillingMasterToolStripMenuItem")]
  private ToolStripMenuItem _SelectedBillingMasterToolStripMenuItem;
  [AccessedThroughProperty("JournalVoucherToolStripMenuItem")]
  private ToolStripMenuItem _JournalVoucherToolStripMenuItem;
  [AccessedThroughProperty("SocietyMasterReceiptRemarkToolStripMenuItem1")]
  private ToolStripMenuItem _SocietyMasterReceiptRemarkToolStripMenuItem1;
  [AccessedThroughProperty("ReceiptFromExcelToolStripMenuItem")]
  private ToolStripMenuItem _ReceiptFromExcelToolStripMenuItem;
  [AccessedThroughProperty("FundRegisterToolStripMenuItem")]
  private ToolStripMenuItem _FundRegisterToolStripMenuItem;
  [AccessedThroughProperty("ToolStripMenuItem20")]
  private ToolStripMenuItem _ToolStripMenuItem20;
  [AccessedThroughProperty("ToolStripMenuItem21")]
  private ToolStripMenuItem _ToolStripMenuItem21;
  [AccessedThroughProperty("NormalToolStripMenuItem")]
  private ToolStripMenuItem _NormalToolStripMenuItem;
  [AccessedThroughProperty("BillRegisgerWithReceiptToolStripMenuItem")]
  private ToolStripMenuItem _BillRegisgerWithReceiptToolStripMenuItem;
  [AccessedThroughProperty("GSTBillRegisterToolStripMenuItem1")]
  private ToolStripMenuItem _GSTBillRegisterToolStripMenuItem1;
  [AccessedThroughProperty("FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem")]
  private ToolStripMenuItem _FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem;
  [AccessedThroughProperty("PToolStripMenuItem")]
  private ToolStripMenuItem _PToolStripMenuItem;
  [AccessedThroughProperty("AllToolStripMenuItem")]
  private ToolStripMenuItem _AllToolStripMenuItem;
  [AccessedThroughProperty("OkToolStripMenuItem")]
  private ToolStripMenuItem _OkToolStripMenuItem;
  [AccessedThroughProperty("CheckToolStripMenuItem")]
  private ToolStripMenuItem _CheckToolStripMenuItem;
  [AccessedThroughProperty("VoucherCheckReportToolStripMenuItem")]
  private ToolStripMenuItem _VoucherCheckReportToolStripMenuItem;
  [AccessedThroughProperty("CodeWiseToolStripMenuItem")]
  private ToolStripMenuItem _CodeWiseToolStripMenuItem;
  [AccessedThroughProperty("GroupWiseToolStripMenuItem")]
  private ToolStripMenuItem _GroupWiseToolStripMenuItem;
  [AccessedThroughProperty("BooksOfAccountToolStripMenuItem")]
  private ToolStripMenuItem _BooksOfAccountToolStripMenuItem;
  [AccessedThroughProperty("BooksOfAccountTableFromOtherSocietyToolStripMenuItem")]
  private ToolStripMenuItem _BooksOfAccountTableFromOtherSocietyToolStripMenuItem;
  [AccessedThroughProperty("WhatsNewIn202425ToolStripMenuItem")]
  private ToolStripMenuItem _WhatsNewIn202425ToolStripMenuItem;
  [AccessedThroughProperty("ToolStripMenuItem14")]
  private ToolStripMenuItem _ToolStripMenuItem14;
  [AccessedThroughProperty("MailToMemberToolStripMenuItem")]
  private ToolStripMenuItem _MailToMemberToolStripMenuItem;
  [AccessedThroughProperty("MailToCommitteeToolStripMenuItem")]
  private ToolStripMenuItem _MailToCommitteeToolStripMenuItem;
  [AccessedThroughProperty("EmailIdSettingToolStripMenuItem")]
  private ToolStripMenuItem _EmailIdSettingToolStripMenuItem;
  [AccessedThroughProperty("WhatsupToMemberToolStripMenuItem")]
  private ToolStripMenuItem _WhatsupToMemberToolStripMenuItem;
  [AccessedThroughProperty("WhatsupToCommitteeToolStripMenuItem")]
  private ToolStripMenuItem _WhatsupToCommitteeToolStripMenuItem;
  [AccessedThroughProperty("WhatsupSettingToolStripMenuItem")]
  private ToolStripMenuItem _WhatsupSettingToolStripMenuItem;
  [AccessedThroughProperty("ToolStripMenuItem15")]
  private ToolStripMenuItem _ToolStripMenuItem15;
  [AccessedThroughProperty("InterestZerowiseToolStripMenuItem")]
  private ToolStripMenuItem _InterestZerowiseToolStripMenuItem;
  [AccessedThroughProperty("InterestCalculateToolStripMenuItem")]
  private ToolStripMenuItem _InterestCalculateToolStripMenuItem;
  [AccessedThroughProperty("DayWiseInterestCalculateToolStripMenuItem1")]
  private ToolStripMenuItem _DayWiseInterestCalculateToolStripMenuItem1;
  [AccessedThroughProperty("BillSettingToolStripMenuItem1")]
  private ToolStripMenuItem _BillSettingToolStripMenuItem1;
  [AccessedThroughProperty("BillMasterToolStripMenuItem1")]
  private ToolStripMenuItem _BillMasterToolStripMenuItem1;
  [AccessedThroughProperty("BillFormatToolStripMenuItem1")]
  private ToolStripMenuItem _BillFormatToolStripMenuItem1;
  [AccessedThroughProperty("ReceiptToolStripMenuItem4")]
  private ToolStripMenuItem _ReceiptToolStripMenuItem4;
  [AccessedThroughProperty("MemberAccountToolStripMenuItem3")]
  private ToolStripMenuItem _MemberAccountToolStripMenuItem3;
  [AccessedThroughProperty("MemberRegisterToolStripMenuItem2")]
  private ToolStripMenuItem _MemberRegisterToolStripMenuItem2;
  [AccessedThroughProperty("OutstandingReminderToolStripMenuItem1")]
  private ToolStripMenuItem _OutstandingReminderToolStripMenuItem1;
  [AccessedThroughProperty("OutstandingLetterToolStripMenuItem1")]
  private ToolStripMenuItem _OutstandingLetterToolStripMenuItem1;
  [AccessedThroughProperty("MessageToolStripMenuItem1")]
  private ToolStripMenuItem _MessageToolStripMenuItem1;
  [AccessedThroughProperty("BalanceConfirmationLetterToolStripMenuItem1")]
  private ToolStripMenuItem _BalanceConfirmationLetterToolStripMenuItem1;
  [AccessedThroughProperty("MessageWithPdfToolStripMenuItem2")]
  private ToolStripMenuItem _MessageWithPdfToolStripMenuItem2;
  [AccessedThroughProperty("BillFormatToolStripMenuItem2")]
  private ToolStripMenuItem _BillFormatToolStripMenuItem2;
  [AccessedThroughProperty("ReceiptToolStripMenuItem1")]
  private ToolStripMenuItem _ReceiptToolStripMenuItem1;
  [AccessedThroughProperty("MemberAccountToolStripMenuItem1")]
  private ToolStripMenuItem _MemberAccountToolStripMenuItem1;
  [AccessedThroughProperty("MemberRegisterToolStripMenuItem")]
  private ToolStripMenuItem _MemberRegisterToolStripMenuItem;
  [AccessedThroughProperty("OutstandingReminderToolStripMenuItem2")]
  private ToolStripMenuItem _OutstandingReminderToolStripMenuItem2;
  [AccessedThroughProperty("MessageToolStripMenuItem2")]
  private ToolStripMenuItem _MessageToolStripMenuItem2;
  [AccessedThroughProperty("BalanceConfirmationLetterToolStripMenuItem2")]
  private ToolStripMenuItem _BalanceConfirmationLetterToolStripMenuItem2;
  [AccessedThroughProperty("MessageWithPdfToolStripMenuItem")]
  private ToolStripMenuItem _MessageWithPdfToolStripMenuItem;
  [AccessedThroughProperty("CommitteeMasterToolStripMenuItem1")]
  private ToolStripMenuItem _CommitteeMasterToolStripMenuItem1;
  [AccessedThroughProperty("IncomeExpenditureToolStripMenuItem")]
  private ToolStripMenuItem _IncomeExpenditureToolStripMenuItem;
  [AccessedThroughProperty("BalanceSheetToolStripMenuItem")]
  private ToolStripMenuItem _BalanceSheetToolStripMenuItem;
  [AccessedThroughProperty("TrialBalanceToolStripMenuItem")]
  private ToolStripMenuItem _TrialBalanceToolStripMenuItem;
  [AccessedThroughProperty("CashBankBookToolStripMenuItem1")]
  private ToolStripMenuItem _CashBankBookToolStripMenuItem1;
  [AccessedThroughProperty("LedgerToolStripMenuItem")]
  private ToolStripMenuItem _LedgerToolStripMenuItem;
  [AccessedThroughProperty("CodeWiseToolStripMenuItem1")]
  private ToolStripMenuItem _CodeWiseToolStripMenuItem1;
  [AccessedThroughProperty("GroupWiseToolStripMenuItem1")]
  private ToolStripMenuItem _GroupWiseToolStripMenuItem1;
  [AccessedThroughProperty("ReceiptPaymentAccoutToolStripMenuItem")]
  private ToolStripMenuItem _ReceiptPaymentAccoutToolStripMenuItem;
  [AccessedThroughProperty("ReceiptPaymentAccoutwiseToolStripMenuItem")]
  private ToolStripMenuItem _ReceiptPaymentAccoutwiseToolStripMenuItem;
  [AccessedThroughProperty("ScheduleToolStripMenuItem")]
  private ToolStripMenuItem _ScheduleToolStripMenuItem;
  [AccessedThroughProperty("MonthlyReportToolStripMenuItem")]
  private ToolStripMenuItem _MonthlyReportToolStripMenuItem;
  [AccessedThroughProperty("ReceiptRegisterToolStripMenuItem1")]
  private ToolStripMenuItem _ReceiptRegisterToolStripMenuItem1;
  [AccessedThroughProperty("PaymentRegisterToolStripMenuItem1")]
  private ToolStripMenuItem _PaymentRegisterToolStripMenuItem1;
  [AccessedThroughProperty("ContraRegisterToolStripMenuItem1")]
  private ToolStripMenuItem _ContraRegisterToolStripMenuItem1;
  [AccessedThroughProperty("JournalRegisterToolStripMenuItem1")]
  private ToolStripMenuItem _JournalRegisterToolStripMenuItem1;
  [AccessedThroughProperty("IncomeExpenditureToolStripMenuItem1")]
  private ToolStripMenuItem _IncomeExpenditureToolStripMenuItem1;
  [AccessedThroughProperty("BalanceSheetToolStripMenuItem1")]
  private ToolStripMenuItem _BalanceSheetToolStripMenuItem1;
  [AccessedThroughProperty("TrialBalanceToolStripMenuItem1")]
  private ToolStripMenuItem _TrialBalanceToolStripMenuItem1;
  [AccessedThroughProperty("CashBankBookToolStripMenuItem2")]
  private ToolStripMenuItem _CashBankBookToolStripMenuItem2;
  [AccessedThroughProperty("AccountLedgerToolStripMenuItem1")]
  private ToolStripMenuItem _AccountLedgerToolStripMenuItem1;
  [AccessedThroughProperty("CodewiseToolStripMenuItem2")]
  private ToolStripMenuItem _CodewiseToolStripMenuItem2;
  [AccessedThroughProperty("GroupWiseToolStripMenuItem2")]
  private ToolStripMenuItem _GroupWiseToolStripMenuItem2;
  [AccessedThroughProperty("ReceiptPaymentGroupwiseToolStripMenuItem")]
  private ToolStripMenuItem _ReceiptPaymentGroupwiseToolStripMenuItem;
  [AccessedThroughProperty("ReceiptPaymentAccoutwiseToolStripMenuItem1")]
  private ToolStripMenuItem _ReceiptPaymentAccoutwiseToolStripMenuItem1;
  [AccessedThroughProperty("ScheduleToolStripMenuItem2")]
  private ToolStripMenuItem _ScheduleToolStripMenuItem2;
  [AccessedThroughProperty("MonthlyReportToolStripMenuItem1")]
  private ToolStripMenuItem _MonthlyReportToolStripMenuItem1;
  [AccessedThroughProperty("ReceiptRegisterToolStripMenuItem2")]
  private ToolStripMenuItem _ReceiptRegisterToolStripMenuItem2;
  [AccessedThroughProperty("PaymentRegisterToolStripMenuItem2")]
  private ToolStripMenuItem _PaymentRegisterToolStripMenuItem2;
  [AccessedThroughProperty("ContraRegisterToolStripMenuItem2")]
  private ToolStripMenuItem _ContraRegisterToolStripMenuItem2;
  [AccessedThroughProperty("JournalRegisterToolStripMenuItem2")]
  private ToolStripMenuItem _JournalRegisterToolStripMenuItem2;
  [AccessedThroughProperty("ReceiptPaymentGroupwiseMarathiToolStripMenuItem")]
  private ToolStripMenuItem _ReceiptPaymentGroupwiseMarathiToolStripMenuItem;
  [AccessedThroughProperty("ReceiptPaymentAccountwiseMarathiToolStripMenuItem")]
  private ToolStripMenuItem _ReceiptPaymentAccountwiseMarathiToolStripMenuItem;

  [DebuggerNonUserCode]
  static frmMenu()
  {
  }

  [DebuggerNonUserCode]
  public frmMenu()
  {
    this.KeyDown += new KeyEventHandler(this.frmMenu_KeyDown);
    this.Load += new EventHandler(this.frmMenu_Load);
    frmMenu.__ENCAddToList((object) this);
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  private static void __ENCAddToList(object value)
  {
    lock (frmMenu.__ENCList)
    {
      if (frmMenu.__ENCList.Count == frmMenu.__ENCList.Capacity)
      {
        int index1 = 0;
        int num = checked (frmMenu.__ENCList.Count - 1);
        int index2 = 0;
        while (index2 <= num)
        {
          if (frmMenu.__ENCList[index2].IsAlive)
          {
            if (index2 != index1)
              frmMenu.__ENCList[index1] = frmMenu.__ENCList[index2];
            checked { ++index1; }
          }
          checked { ++index2; }
        }
        frmMenu.__ENCList.RemoveRange(index1, checked (frmMenu.__ENCList.Count - index1));
        frmMenu.__ENCList.Capacity = frmMenu.__ENCList.Count;
      }
      frmMenu.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmMenu));
    this.ToolTip = new ToolTip(this.components);
    this.MS = new MenuStrip();
    this.MasterToolStripMenuItem = new ToolStripMenuItem();
    this.SocietyToolStripMenuItem = new ToolStripMenuItem();
    this.GroupToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripMenuItem8 = new ToolStripMenuItem();
    this.ToolStripSeparator8 = new ToolStripSeparator();
    this.AccountToolStripMenuItem = new ToolStripMenuItem();
    this.MemberToolStripMenuItem = new ToolStripMenuItem();
    this.MemberBillingToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripMenuItem13 = new ToolStripMenuItem();
    this.ToolStripSeparator9 = new ToolStripSeparator();
    this.OpeningBankRecoToolStripMenuItem = new ToolStripMenuItem();
    this.OpeningBalancesToolStripMenuItem = new ToolStripMenuItem();
    this.MemberOpeningBalanceBifurcationToolStripMenuItem = new ToolStripMenuItem();
    this.SocietyMasterReceiptRemarkToolStripMenuItem = new ToolStripMenuItem();
    this.SetBillPrintingOptionToolStripMenuItem = new ToolStripMenuItem();
    this.GSTMasterToolStripMenuItem = new ToolStripMenuItem();
    this.SelectedBillingMasterToolStripMenuItem = new ToolStripMenuItem();
    this.SocietyMasterReceiptRemarkToolStripMenuItem1 = new ToolStripMenuItem();
    this.TransactionToolStripMenuItem = new ToolStripMenuItem();
    this.MemberBillToolStripMenuItem = new ToolStripMenuItem();
    this.MemberReceiptToolStripMenuItem = new ToolStripMenuItem();
    this.MemberDebitNoteToolStripMenuItem1 = new ToolStripMenuItem();
    this.MemberCreditNoteToolStripMenuItem1 = new ToolStripMenuItem();
    this.MemberAdjustmentToolStripMenuItem1 = new ToolStripMenuItem();
    this.ToolStripMenuItem20 = new ToolStripMenuItem();
    this.ToolStripSeparator2 = new ToolStripSeparator();
    this.ReceiptToolStripMenuItem = new ToolStripMenuItem();
    this.PaymentToolStripMenuItem = new ToolStripMenuItem();
    this.ContraToolStripMenuItem1 = new ToolStripMenuItem();
    this.JournalToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripSeparator3 = new ToolStripSeparator();
    this.MultiReceiptToolStripMenuItem = new ToolStripMenuItem();
    this.MULToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripSeparator12 = new ToolStripSeparator();
    this.BankRecoToolStripMenuItem = new ToolStripMenuItem();
    this.QuickNoteToolStripMenuItem = new ToolStripMenuItem();
    this.PToolStripMenuItem = new ToolStripMenuItem();
    this.AllToolStripMenuItem = new ToolStripMenuItem();
    this.OkToolStripMenuItem = new ToolStripMenuItem();
    this.CheckToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripMenuItem2 = new ToolStripMenuItem();
    this.BillToolStripMenuItem1 = new ToolStripMenuItem();
    this.HalfPageGSTVerticalDoubleBillToolStripMenuItem = new ToolStripMenuItem();
    this.FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem = new ToolStripMenuItem();
    this.ReceiptToolStripMenuItem3 = new ToolStripMenuItem();
    this.DebitNoteToolStripMenuItem = new ToolStripMenuItem();
    this.HalfPageToolStripMenuItem = new ToolStripMenuItem();
    this.FullPage14HeadToolStripMenuItem = new ToolStripMenuItem();
    this.FullPage21HeadToolStripMenuItem = new ToolStripMenuItem();
    this.CreditNoteToolStripMenuItem = new ToolStripMenuItem();
    this.HalfPageToolStripMenuItem1 = new ToolStripMenuItem();
    this.FullPage14HeadToolStripMenuItem1 = new ToolStripMenuItem();
    this.FullPage21HeadToolStripMenuItem1 = new ToolStripMenuItem();
    this.ToolStripMenuItem10 = new ToolStripMenuItem();
    this.ToolStripSeparator1 = new ToolStripSeparator();
    this.OutstandingListToolStripMenuItem = new ToolStripMenuItem();
    this.MemberAccountToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripMenuItem1 = new ToolStripMenuItem();
    this.ToolStripMenuItem7 = new ToolStripMenuItem();
    this.ToolStripMenuItem4 = new ToolStripMenuItem();
    this.ToolStripSeparator10 = new ToolStripSeparator();
    this.BillRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.NormalToolStripMenuItem = new ToolStripMenuItem();
    this.BillRegisgerWithReceiptToolStripMenuItem = new ToolStripMenuItem();
    this.GSTBillRegisterToolStripMenuItem1 = new ToolStripMenuItem();
    this.ReceiptRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.DebitNoteRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.CreditNoteRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.AdjustmentRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripMenuItem21 = new ToolStripMenuItem();
    this.ToolStripSeparator11 = new ToolStripSeparator();
    this.DataSheetToolStripMenuItem1 = new ToolStripMenuItem();
    this.BankDepositListToolStripMenuItem1 = new ToolStripMenuItem();
    this.FundRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripMenuItem3 = new ToolStripMenuItem();
    this.CashBankBookToolStripMenuItem = new ToolStripMenuItem();
    this.AccountLedgerToolStripMenuItem = new ToolStripMenuItem();
    this.CodeWiseToolStripMenuItem = new ToolStripMenuItem();
    this.GroupWiseToolStripMenuItem = new ToolStripMenuItem();
    this.TrialBalanceToolStripMenuItem3 = new ToolStripMenuItem();
    this.IncomeExpenditureAcToolStripMenuItem = new ToolStripMenuItem();
    this.BalanceSheetToolStripMenuItem2 = new ToolStripMenuItem();
    this.ScheduleToolStripMenuItem1 = new ToolStripMenuItem();
    this.GroupReceiptPaymentAcToolStripMenuItem = new ToolStripMenuItem();
    this.ReceiptPaymentAcToolStripMenuItem1 = new ToolStripMenuItem();
    this.ToolStripMenuItem6 = new ToolStripMenuItem();
    this.ToolStripSeparator4 = new ToolStripSeparator();
    this.ReceiptRegiToolStripMenuItem = new ToolStripMenuItem();
    this.PaymentRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.ContraRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.JournalRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.IncomeExpenditureAcMarathiToolStripMenuItem = new ToolStripMenuItem();
    this.BalanceSheetMarathiToolStripMenuItem = new ToolStripMenuItem();
    this.ReceiptPaymentGroupwiseMarathiToolStripMenuItem = new ToolStripMenuItem();
    this.ReceiptPaymentAccountwiseMarathiToolStripMenuItem = new ToolStripMenuItem();
    this.VoucherCheckReportToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripMenuItem5 = new ToolStripMenuItem();
    this.ReceiptVoucherToolStripMenuItem1 = new ToolStripMenuItem();
    this.PaymentVoucherToolStripMenuItem1 = new ToolStripMenuItem();
    this.ContraVoucherToolStripMenuItem1 = new ToolStripMenuItem();
    this.JournalVoucherToolStripMenuItem = new ToolStripMenuItem();
    this.BooksOfAccountToolStripMenuItem = new ToolStripMenuItem();
    this.WhatsNewIn202425ToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripMenuItem14 = new ToolStripMenuItem();
    this.MailToMemberToolStripMenuItem = new ToolStripMenuItem();
    this.BillFormatToolStripMenuItem1 = new ToolStripMenuItem();
    this.ReceiptToolStripMenuItem4 = new ToolStripMenuItem();
    this.MemberAccountToolStripMenuItem3 = new ToolStripMenuItem();
    this.MemberRegisterToolStripMenuItem2 = new ToolStripMenuItem();
    this.OutstandingReminderToolStripMenuItem1 = new ToolStripMenuItem();
    this.OutstandingLetterToolStripMenuItem1 = new ToolStripMenuItem();
    this.MessageToolStripMenuItem1 = new ToolStripMenuItem();
    this.BalanceConfirmationLetterToolStripMenuItem1 = new ToolStripMenuItem();
    this.MessageWithPdfToolStripMenuItem2 = new ToolStripMenuItem();
    this.MailToCommitteeToolStripMenuItem = new ToolStripMenuItem();
    this.IncomeExpenditureToolStripMenuItem = new ToolStripMenuItem();
    this.BalanceSheetToolStripMenuItem = new ToolStripMenuItem();
    this.TrialBalanceToolStripMenuItem = new ToolStripMenuItem();
    this.CashBankBookToolStripMenuItem1 = new ToolStripMenuItem();
    this.LedgerToolStripMenuItem = new ToolStripMenuItem();
    this.CodeWiseToolStripMenuItem1 = new ToolStripMenuItem();
    this.GroupWiseToolStripMenuItem1 = new ToolStripMenuItem();
    this.ReceiptPaymentAccoutToolStripMenuItem = new ToolStripMenuItem();
    this.ReceiptPaymentAccoutwiseToolStripMenuItem = new ToolStripMenuItem();
    this.ScheduleToolStripMenuItem = new ToolStripMenuItem();
    this.MonthlyReportToolStripMenuItem = new ToolStripMenuItem();
    this.ReceiptRegisterToolStripMenuItem1 = new ToolStripMenuItem();
    this.PaymentRegisterToolStripMenuItem1 = new ToolStripMenuItem();
    this.ContraRegisterToolStripMenuItem1 = new ToolStripMenuItem();
    this.JournalRegisterToolStripMenuItem1 = new ToolStripMenuItem();
    this.EmailIdSettingToolStripMenuItem = new ToolStripMenuItem();
    this.WhatsupToMemberToolStripMenuItem = new ToolStripMenuItem();
    this.BillFormatToolStripMenuItem2 = new ToolStripMenuItem();
    this.ReceiptToolStripMenuItem1 = new ToolStripMenuItem();
    this.MemberAccountToolStripMenuItem1 = new ToolStripMenuItem();
    this.MemberRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.OutstandingReminderToolStripMenuItem2 = new ToolStripMenuItem();
    this.MessageToolStripMenuItem2 = new ToolStripMenuItem();
    this.BalanceConfirmationLetterToolStripMenuItem2 = new ToolStripMenuItem();
    this.MessageWithPdfToolStripMenuItem = new ToolStripMenuItem();
    this.WhatsupToCommitteeToolStripMenuItem = new ToolStripMenuItem();
    this.IncomeExpenditureToolStripMenuItem1 = new ToolStripMenuItem();
    this.BalanceSheetToolStripMenuItem1 = new ToolStripMenuItem();
    this.TrialBalanceToolStripMenuItem1 = new ToolStripMenuItem();
    this.CashBankBookToolStripMenuItem2 = new ToolStripMenuItem();
    this.AccountLedgerToolStripMenuItem1 = new ToolStripMenuItem();
    this.CodewiseToolStripMenuItem2 = new ToolStripMenuItem();
    this.GroupWiseToolStripMenuItem2 = new ToolStripMenuItem();
    this.ReceiptPaymentGroupwiseToolStripMenuItem = new ToolStripMenuItem();
    this.ReceiptPaymentAccoutwiseToolStripMenuItem1 = new ToolStripMenuItem();
    this.ScheduleToolStripMenuItem2 = new ToolStripMenuItem();
    this.MonthlyReportToolStripMenuItem1 = new ToolStripMenuItem();
    this.ReceiptRegisterToolStripMenuItem2 = new ToolStripMenuItem();
    this.PaymentRegisterToolStripMenuItem2 = new ToolStripMenuItem();
    this.ContraRegisterToolStripMenuItem2 = new ToolStripMenuItem();
    this.JournalRegisterToolStripMenuItem2 = new ToolStripMenuItem();
    this.WhatsupSettingToolStripMenuItem = new ToolStripMenuItem();
    this.CommitteeMasterToolStripMenuItem1 = new ToolStripMenuItem();
    this.UtilityToolStripMenuItem = new ToolStripMenuItem();
    this.TranferToolStripMenuItem = new ToolStripMenuItem();
    this.RenumberToolStripMenuItem = new ToolStripMenuItem();
    this.YearBfToolStripMenuItem = new ToolStripMenuItem();
    this.IToolStripMenuItem = new ToolStripMenuItem();
    this.GroupAccountMasterFromOtherSoceityToolStripMenuItem = new ToolStripMenuItem();
    this.BankListFromOtherSocietyToolStripMenuItem = new ToolStripMenuItem();
    this.PersonListFromOtherSocietyToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripMenuItem12 = new ToolStripMenuItem();
    this.MemberMasterFromExcelToolStripMenuItem = new ToolStripMenuItem();
    this.MemberReceiptFromExcelToolStripMenuItem = new ToolStripMenuItem();
    this.PaymentFromExcelToolStripMenuItem = new ToolStripMenuItem();
    this.ReceiptFromExcelToolStripMenuItem = new ToolStripMenuItem();
    this.BooksOfAccountTableFromOtherSocietyToolStripMenuItem = new ToolStripMenuItem();
    this.ExportTestToolStripMenuItem = new ToolStripMenuItem();
    this.ListToolStripMenuItem = new ToolStripMenuItem();
    this.FormToolStripMenuItem = new ToolStripMenuItem();
    this.DefultGroupSettingToolStripMenuItem = new ToolStripMenuItem();
    this.RebuildToolStripMenuItem = new ToolStripMenuItem();
    this.CheckDifferenceToolStripMenuItem = new ToolStripMenuItem();
    this.YearCfToolStripMenuItem = new ToolStripMenuItem();
    this.NewTtanTypeToolStripMenuItem = new ToolStripMenuItem();
    this.ChangeYearToolStripMenuItem = new ToolStripMenuItem();
    this.CaclulatorToolStripMenuItem = new ToolStripMenuItem();
    this.GSTCalculateToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripMenuItem16 = new ToolStripMenuItem();
    this.ToolStripMenuItem15 = new ToolStripMenuItem();
    this.InterestZerowiseToolStripMenuItem = new ToolStripMenuItem();
    this.InterestCalculateToolStripMenuItem = new ToolStripMenuItem();
    this.DayWiseInterestCalculateToolStripMenuItem1 = new ToolStripMenuItem();
    this.BillSettingToolStripMenuItem1 = new ToolStripMenuItem();
    this.BillMasterToolStripMenuItem1 = new ToolStripMenuItem();
    this.ExitToolStripMenuItem = new ToolStripMenuItem();
    this.VendorToolStripMenuItem = new ToolStripMenuItem();
    this.ServantToolStripMenuItem = new ToolStripMenuItem();
    this.FToolStripMenuItem = new ToolStripMenuItem();
    this.CommitteeMasterToolStripMenuItem = new ToolStripMenuItem();
    this.OtherInfoToolStripMenuItem = new ToolStripMenuItem();
    this.StatutoryToolStripMenuItem = new ToolStripMenuItem();
    this.SocietyStatMasterToolStripMenuItem = new ToolStripMenuItem();
    this.MasterToolStripMenuItem1 = new ToolStripMenuItem();
    this.ToolStripMenuItem9 = new ToolStripMenuItem();
    this.ToolStripSeparator13 = new ToolStripSeparator();
    this.JRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.ShareRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.IRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.IRegisterToolStripMenuItem1 = new ToolStripMenuItem();
    this.ToolStripSeparator14 = new ToolStripSeparator();
    this.PropertyRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.SinkingFundLedgerToolStripMenuItem = new ToolStripMenuItem();
    this.InvestmentRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripSeparator15 = new ToolStripSeparator();
    this.AuditFormNo28ToolStripMenuItem = new ToolStripMenuItem();
    this.AuditFormNo1ToolStripMenuItem = new ToolStripMenuItem();
    this.AuditGeneralRemarkToolStripMenuItem = new ToolStripMenuItem();
    this.AuditOFormToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripSeparator16 = new ToolStripSeparator();
    this.ByeLawsToolStripMenuItem = new ToolStripMenuItem();
    this.MultiJRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.ShareRegisterMultiUpdateToolStripMenuItem = new ToolStripMenuItem();
    this.IRegisterMulitUpdateToolStripMenuItem = new ToolStripMenuItem();
    this.TransferFlatToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripSeparator18 = new ToolStripSeparator();
    this.MemberListToolStripMenuItem = new ToolStripMenuItem();
    this.ElectionListToolStripMenuItem = new ToolStripMenuItem();
    this.ToolStripMenuItem11 = new ToolStripMenuItem();
    this.CalculatorToolStripMenuItem = new ToolStripMenuItem();
    this.JRegisterToolStripMenuItem1 = new ToolStripMenuItem();
    this.A4ToolStripMenuItem = new ToolStripMenuItem();
    this.LegalPaperToolStripMenuItem = new ToolStripMenuItem();
    this.ShareRegisterToolStripMenuItem1 = new ToolStripMenuItem();
    this.A4PaperToolStripMenuItem = new ToolStripMenuItem();
    this.LegalPaperToolStripMenuItem1 = new ToolStripMenuItem();
    this.NominationRegisterToolStripMenuItem = new ToolStripMenuItem();
    this.A4PaperToolStripMenuItem1 = new ToolStripMenuItem();
    this.LegalPaperToolStripMenuItem2 = new ToolStripMenuItem();
    this.IRegisterToolStripMenuItem2 = new ToolStripMenuItem();
    this.A4PaperToolStripMenuItem2 = new ToolStripMenuItem();
    this.LegalPaperToolStripMenuItem3 = new ToolStripMenuItem();
    this.PropertyRegisterToolStripMenuItem1 = new ToolStripMenuItem();
    this.InvestmentRegisterToolStripMenuItem1 = new ToolStripMenuItem();
    this.SinkingFundLedgerToolStripMenuItem1 = new ToolStripMenuItem();
    this.NominationFormToolStripMenuItem = new ToolStripMenuItem();
    this.FlatTransferDocumentToolStripMenuItem = new ToolStripMenuItem();
    this.ShareCertificateToolStripMenuItem = new ToolStripMenuItem();
    this.MemberDetailFormToolStripMenuItem = new ToolStripMenuItem();
    this.SocietyDetailFormToolStripMenuItem = new ToolStripMenuItem();
    this.OtherFormatsToolStripMenuItem = new ToolStripMenuItem();
    this.AboutUsToolStripMenuItem = new ToolStripMenuItem();
    this.TS = new ToolStrip();
    this.ToolStripButton14 = new ToolStripButton();
    this.ToolStripButton11 = new ToolStripButton();
    this.ToolStripButton1 = new ToolStripButton();
    this.ToolStripSeparator17 = new ToolStripSeparator();
    this.ToolStripButton7 = new ToolStripButton();
    this.ToolStripButton5 = new ToolStripButton();
    this.ToolStripButton4 = new ToolStripButton();
    this.ToolStripButton8 = new ToolStripButton();
    this.ToolStripButton2 = new ToolStripButton();
    this.ToolStripSeparator5 = new ToolStripSeparator();
    this.ToolStripButton10 = new ToolStripButton();
    this.ToolStripButton9 = new ToolStripButton();
    this.ToolStripButton6 = new ToolStripButton();
    this.ToolStripButton3 = new ToolStripButton();
    this.ToolStripSeparator6 = new ToolStripSeparator();
    this.ToolStripButton19 = new ToolStripButton();
    this.ToolStripButton13 = new ToolStripButton();
    this.ToolStripButton15 = new ToolStripButton();
    this.ToolStripButton16 = new ToolStripButton();
    this.ToolStripButton17 = new ToolStripButton();
    this.ToolStripSeparator7 = new ToolStripSeparator();
    this.ToolStripButton18 = new ToolStripButton();
    this.ToolStripButton12 = new ToolStripButton();
    this.ToolStripSeparator21 = new ToolStripSeparator();
    this.ToolStripButton20 = new ToolStripButton();
    this.ToolStripButton22 = new ToolStripButton();
    this.StatusStrip1 = new StatusStrip();
    this.lblTS1 = new ToolStripStatusLabel();
    this.ToolStripSplitButton1 = new ToolStripSplitButton();
    this.DataGridView1 = new DataGridView();
    this.DataGridView3 = new DataGridView();
    this.DataGridView2 = new DataGridView();
    this.ToolStripButton21 = new ToolStripButton();
    this.ToolStripButton24 = new ToolStripButton();
    this.MS.SuspendLayout();
    this.TS.SuspendLayout();
    this.StatusStrip1.SuspendLayout();
    ((ISupportInitialize) this.DataGridView1).BeginInit();
    ((ISupportInitialize) this.DataGridView3).BeginInit();
    ((ISupportInitialize) this.DataGridView2).BeginInit();
    this.SuspendLayout();
    this.MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    MenuStrip ms1 = this.MS;
    Padding padding1 = new Padding(0);
    Padding padding2 = padding1;
    ms1.GripMargin = padding2;
    this.MS.Items.AddRange(new ToolStripItem[12]
    {
      (ToolStripItem) this.MasterToolStripMenuItem,
      (ToolStripItem) this.TransactionToolStripMenuItem,
      (ToolStripItem) this.ToolStripMenuItem2,
      (ToolStripItem) this.ToolStripMenuItem3,
      (ToolStripItem) this.ToolStripMenuItem5,
      (ToolStripItem) this.ToolStripMenuItem14,
      (ToolStripItem) this.UtilityToolStripMenuItem,
      (ToolStripItem) this.ToolStripMenuItem15,
      (ToolStripItem) this.ExitToolStripMenuItem,
      (ToolStripItem) this.StatutoryToolStripMenuItem,
      (ToolStripItem) this.CalculatorToolStripMenuItem,
      (ToolStripItem) this.AboutUsToolStripMenuItem
    });
    MenuStrip ms2 = this.MS;
    System.Drawing.Point point1 = new System.Drawing.Point(0, 0);
    System.Drawing.Point point2 = point1;
    ms2.Location = point2;
    MenuStrip ms3 = this.MS;
    padding1 = new Padding(3);
    Padding padding3 = padding1;
    ms3.Margin = padding3;
    this.MS.Name = "MS";
    MenuStrip ms4 = this.MS;
    Size size1 = new Size(1165, 30);
    Size size2 = size1;
    ms4.Size = size2;
    this.MS.TabIndex = 5;
    this.MS.Text = "MenuStrip";
    this.MasterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[17]
    {
      (ToolStripItem) this.SocietyToolStripMenuItem,
      (ToolStripItem) this.GroupToolStripMenuItem,
      (ToolStripItem) this.ToolStripMenuItem8,
      (ToolStripItem) this.ToolStripSeparator8,
      (ToolStripItem) this.AccountToolStripMenuItem,
      (ToolStripItem) this.MemberToolStripMenuItem,
      (ToolStripItem) this.MemberBillingToolStripMenuItem,
      (ToolStripItem) this.ToolStripMenuItem13,
      (ToolStripItem) this.ToolStripSeparator9,
      (ToolStripItem) this.OpeningBankRecoToolStripMenuItem,
      (ToolStripItem) this.OpeningBalancesToolStripMenuItem,
      (ToolStripItem) this.MemberOpeningBalanceBifurcationToolStripMenuItem,
      (ToolStripItem) this.SocietyMasterReceiptRemarkToolStripMenuItem,
      (ToolStripItem) this.SetBillPrintingOptionToolStripMenuItem,
      (ToolStripItem) this.GSTMasterToolStripMenuItem,
      (ToolStripItem) this.SelectedBillingMasterToolStripMenuItem,
      (ToolStripItem) this.SocietyMasterReceiptRemarkToolStripMenuItem1
    });
    this.MasterToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ToolStripMenuItem toolStripMenuItem1 = this.MasterToolStripMenuItem;
    padding1 = new Padding(3);
    Padding padding4 = padding1;
    toolStripMenuItem1.Margin = padding4;
    this.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem2 = this.MasterToolStripMenuItem;
    padding1 = new Padding(10, 0, 10, 0);
    Padding padding5 = padding1;
    toolStripMenuItem2.Padding = padding5;
    ToolStripMenuItem toolStripMenuItem3 = this.MasterToolStripMenuItem;
    size1 = new Size(73, 20);
    Size size3 = size1;
    toolStripMenuItem3.Size = size3;
    this.MasterToolStripMenuItem.Text = "&Master";
    this.SocietyToolStripMenuItem.Name = "SocietyToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem4 = this.SocietyToolStripMenuItem;
    size1 = new Size(339, 22);
    Size size4 = size1;
    toolStripMenuItem4.Size = size4;
    this.SocietyToolStripMenuItem.Text = "Society  Master";
    this.GroupToolStripMenuItem.Name = "GroupToolStripMenuItem";
    this.GroupToolStripMenuItem.ShortcutKeys = Keys.G | Keys.Control;
    ToolStripMenuItem toolStripMenuItem5 = this.GroupToolStripMenuItem;
    size1 = new Size(339, 22);
    Size size5 = size1;
    toolStripMenuItem5.Size = size5;
    this.GroupToolStripMenuItem.Text = "Group Master";
    this.ToolStripMenuItem8.Name = "ToolStripMenuItem8";
    ToolStripMenuItem toolStripMenuItem8 = this.ToolStripMenuItem8;
    size1 = new Size(339, 22);
    Size size6 = size1;
    toolStripMenuItem8.Size = size6;
    this.ToolStripMenuItem8.Text = "Sub Group Master";
    this.ToolStripMenuItem8.Visible = false;
    this.ToolStripSeparator8.Name = "ToolStripSeparator8";
    ToolStripSeparator toolStripSeparator8 = this.ToolStripSeparator8;
    size1 = new Size(336, 6);
    Size size7 = size1;
    toolStripSeparator8.Size = size7;
    this.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem";
    this.AccountToolStripMenuItem.ShortcutKeys = Keys.A | Keys.Control;
    ToolStripMenuItem toolStripMenuItem6 = this.AccountToolStripMenuItem;
    size1 = new Size(339, 22);
    Size size8 = size1;
    toolStripMenuItem6.Size = size8;
    this.AccountToolStripMenuItem.Text = "Account Master";
    this.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem";
    this.MemberToolStripMenuItem.ShortcutKeys = Keys.M | Keys.Control;
    ToolStripMenuItem toolStripMenuItem7 = this.MemberToolStripMenuItem;
    size1 = new Size(339, 22);
    Size size9 = size1;
    toolStripMenuItem7.Size = size9;
    this.MemberToolStripMenuItem.Text = "Member Master";
    this.MemberBillingToolStripMenuItem.Name = "MemberBillingToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem9 = this.MemberBillingToolStripMenuItem;
    size1 = new Size(339, 22);
    Size size10 = size1;
    toolStripMenuItem9.Size = size10;
    this.MemberBillingToolStripMenuItem.Text = "Billing Master";
    this.ToolStripMenuItem13.Name = "ToolStripMenuItem13";
    ToolStripMenuItem toolStripMenuItem13 = this.ToolStripMenuItem13;
    size1 = new Size(339, 22);
    Size size11 = size1;
    toolStripMenuItem13.Size = size11;
    this.ToolStripMenuItem13.Text = "Area Master";
    this.ToolStripSeparator9.Name = "ToolStripSeparator9";
    ToolStripSeparator toolStripSeparator9 = this.ToolStripSeparator9;
    size1 = new Size(336, 6);
    Size size12 = size1;
    toolStripSeparator9.Size = size12;
    this.OpeningBankRecoToolStripMenuItem.Name = "OpeningBankRecoToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem10 = this.OpeningBankRecoToolStripMenuItem;
    size1 = new Size(339, 22);
    Size size13 = size1;
    toolStripMenuItem10.Size = size13;
    this.OpeningBankRecoToolStripMenuItem.Text = "Opening Bank Reco";
    this.OpeningBalancesToolStripMenuItem.Name = "OpeningBalancesToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem11 = this.OpeningBalancesToolStripMenuItem;
    size1 = new Size(339, 22);
    Size size14 = size1;
    toolStripMenuItem11.Size = size14;
    this.OpeningBalancesToolStripMenuItem.Text = "Opening Balances";
    this.MemberOpeningBalanceBifurcationToolStripMenuItem.Name = "MemberOpeningBalanceBifurcationToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem12 = this.MemberOpeningBalanceBifurcationToolStripMenuItem;
    size1 = new Size(339, 22);
    Size size15 = size1;
    toolStripMenuItem12.Size = size15;
    this.MemberOpeningBalanceBifurcationToolStripMenuItem.Text = "Member Opening Balance (Bifurcation)";
    this.SocietyMasterReceiptRemarkToolStripMenuItem.Name = "SocietyMasterReceiptRemarkToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem14 = this.SocietyMasterReceiptRemarkToolStripMenuItem;
    size1 = new Size(339, 22);
    Size size16 = size1;
    toolStripMenuItem14.Size = size16;
    this.SocietyMasterReceiptRemarkToolStripMenuItem.Text = "Society Master Receipt Remark (Bifurcation)";
    this.SetBillPrintingOptionToolStripMenuItem.Name = "SetBillPrintingOptionToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem15 = this.SetBillPrintingOptionToolStripMenuItem;
    size1 = new Size(339, 22);
    Size size17 = size1;
    toolStripMenuItem15.Size = size17;
    this.SetBillPrintingOptionToolStripMenuItem.Text = "Set Bill Printing Option";
    this.GSTMasterToolStripMenuItem.Name = "GSTMasterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem16 = this.GSTMasterToolStripMenuItem;
    size1 = new Size(339, 22);
    Size size18 = size1;
    toolStripMenuItem16.Size = size18;
    this.GSTMasterToolStripMenuItem.Text = "GST Master";
    this.SelectedBillingMasterToolStripMenuItem.Name = "SelectedBillingMasterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem17 = this.SelectedBillingMasterToolStripMenuItem;
    size1 = new Size(339, 22);
    Size size19 = size1;
    toolStripMenuItem17.Size = size19;
    this.SelectedBillingMasterToolStripMenuItem.Text = "Selected Billing Master";
    this.SelectedBillingMasterToolStripMenuItem.Visible = false;
    this.SocietyMasterReceiptRemarkToolStripMenuItem1.Name = "SocietyMasterReceiptRemarkToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_1 = this.SocietyMasterReceiptRemarkToolStripMenuItem1;
    size1 = new Size(339, 22);
    Size size20 = size1;
    toolStripMenuItem1_1.Size = size20;
    this.SocietyMasterReceiptRemarkToolStripMenuItem1.Text = "Society Master Receipt Remark";
    this.TransactionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[18]
    {
      (ToolStripItem) this.MemberBillToolStripMenuItem,
      (ToolStripItem) this.MemberReceiptToolStripMenuItem,
      (ToolStripItem) this.MemberDebitNoteToolStripMenuItem1,
      (ToolStripItem) this.MemberCreditNoteToolStripMenuItem1,
      (ToolStripItem) this.MemberAdjustmentToolStripMenuItem1,
      (ToolStripItem) this.ToolStripMenuItem20,
      (ToolStripItem) this.ToolStripSeparator2,
      (ToolStripItem) this.ReceiptToolStripMenuItem,
      (ToolStripItem) this.PaymentToolStripMenuItem,
      (ToolStripItem) this.ContraToolStripMenuItem1,
      (ToolStripItem) this.JournalToolStripMenuItem,
      (ToolStripItem) this.ToolStripSeparator3,
      (ToolStripItem) this.MultiReceiptToolStripMenuItem,
      (ToolStripItem) this.MULToolStripMenuItem,
      (ToolStripItem) this.ToolStripSeparator12,
      (ToolStripItem) this.BankRecoToolStripMenuItem,
      (ToolStripItem) this.QuickNoteToolStripMenuItem,
      (ToolStripItem) this.PToolStripMenuItem
    });
    this.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem18 = this.TransactionToolStripMenuItem;
    size1 = new Size(91, 26);
    Size size21 = size1;
    toolStripMenuItem18.Size = size21;
    this.TransactionToolStripMenuItem.Text = "&Transaction";
    this.MemberBillToolStripMenuItem.Name = "MemberBillToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem19 = this.MemberBillToolStripMenuItem;
    size1 = new Size(272, 22);
    Size size22 = size1;
    toolStripMenuItem19.Size = size22;
    this.MemberBillToolStripMenuItem.Text = "Member Bill";
    this.MemberReceiptToolStripMenuItem.Name = "MemberReceiptToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem20 = this.MemberReceiptToolStripMenuItem;
    size1 = new Size(272, 22);
    Size size23 = size1;
    toolStripMenuItem20.Size = size23;
    this.MemberReceiptToolStripMenuItem.Text = "Member Receipt";
    this.MemberDebitNoteToolStripMenuItem1.Name = "MemberDebitNoteToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_2 = this.MemberDebitNoteToolStripMenuItem1;
    size1 = new Size(272, 22);
    Size size24 = size1;
    toolStripMenuItem1_2.Size = size24;
    this.MemberDebitNoteToolStripMenuItem1.Text = "Member Debit Note";
    this.MemberCreditNoteToolStripMenuItem1.Name = "MemberCreditNoteToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_3 = this.MemberCreditNoteToolStripMenuItem1;
    size1 = new Size(272, 22);
    Size size25 = size1;
    toolStripMenuItem1_3.Size = size25;
    this.MemberCreditNoteToolStripMenuItem1.Text = "Member Credit Note";
    this.MemberAdjustmentToolStripMenuItem1.Name = "MemberAdjustmentToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_4 = this.MemberAdjustmentToolStripMenuItem1;
    size1 = new Size(272, 22);
    Size size26 = size1;
    toolStripMenuItem1_4.Size = size26;
    this.MemberAdjustmentToolStripMenuItem1.Text = "Member Adjustment (Chq.Return)";
    this.ToolStripMenuItem20.Name = "ToolStripMenuItem20";
    ToolStripMenuItem toolStripMenuItem20_1 = this.ToolStripMenuItem20;
    size1 = new Size(272, 22);
    Size size27 = size1;
    toolStripMenuItem20_1.Size = size27;
    this.ToolStripMenuItem20.Text = "Member Journal";
    this.ToolStripSeparator2.Name = "ToolStripSeparator2";
    ToolStripSeparator toolStripSeparator2 = this.ToolStripSeparator2;
    size1 = new Size(269, 6);
    Size size28 = size1;
    toolStripSeparator2.Size = size28;
    this.ReceiptToolStripMenuItem.Name = "ReceiptToolStripMenuItem";
    this.ReceiptToolStripMenuItem.ShortcutKeys = Keys.I | Keys.Control;
    ToolStripMenuItem toolStripMenuItem21 = this.ReceiptToolStripMenuItem;
    size1 = new Size(272, 22);
    Size size29 = size1;
    toolStripMenuItem21.Size = size29;
    this.ReceiptToolStripMenuItem.Text = "Receipt";
    this.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem";
    this.PaymentToolStripMenuItem.ShortcutKeys = Keys.P | Keys.Control;
    ToolStripMenuItem toolStripMenuItem22 = this.PaymentToolStripMenuItem;
    size1 = new Size(272, 22);
    Size size30 = size1;
    toolStripMenuItem22.Size = size30;
    this.PaymentToolStripMenuItem.Text = "Payment";
    this.ContraToolStripMenuItem1.Name = "ContraToolStripMenuItem1";
    this.ContraToolStripMenuItem1.ShortcutKeys = Keys.C | Keys.Control;
    ToolStripMenuItem toolStripMenuItem1_5 = this.ContraToolStripMenuItem1;
    size1 = new Size(272, 22);
    Size size31 = size1;
    toolStripMenuItem1_5.Size = size31;
    this.ContraToolStripMenuItem1.Text = "Contra";
    this.JournalToolStripMenuItem.Name = "JournalToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem23 = this.JournalToolStripMenuItem;
    size1 = new Size(272, 22);
    Size size32 = size1;
    toolStripMenuItem23.Size = size32;
    this.JournalToolStripMenuItem.Text = "Journal";
    this.ToolStripSeparator3.Name = "ToolStripSeparator3";
    ToolStripSeparator toolStripSeparator3 = this.ToolStripSeparator3;
    size1 = new Size(269, 6);
    Size size33 = size1;
    toolStripSeparator3.Size = size33;
    this.MultiReceiptToolStripMenuItem.Name = "MultiReceiptToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem24 = this.MultiReceiptToolStripMenuItem;
    size1 = new Size(272, 22);
    Size size34 = size1;
    toolStripMenuItem24.Size = size34;
    this.MultiReceiptToolStripMenuItem.Text = "Multi Receipt ( Flat Wise )";
    this.MULToolStripMenuItem.Name = "MULToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem25 = this.MULToolStripMenuItem;
    size1 = new Size(272, 22);
    Size size35 = size1;
    toolStripMenuItem25.Size = size35;
    this.MULToolStripMenuItem.Text = "Multi Receipt  ( Blank )";
    this.ToolStripSeparator12.Name = "ToolStripSeparator12";
    ToolStripSeparator stripSeparator12 = this.ToolStripSeparator12;
    size1 = new Size(269, 6);
    Size size36 = size1;
    stripSeparator12.Size = size36;
    this.BankRecoToolStripMenuItem.Name = "BankRecoToolStripMenuItem";
    this.BankRecoToolStripMenuItem.ShortcutKeys = Keys.K | Keys.Control;
    ToolStripMenuItem toolStripMenuItem26 = this.BankRecoToolStripMenuItem;
    size1 = new Size(272, 22);
    Size size37 = size1;
    toolStripMenuItem26.Size = size37;
    this.BankRecoToolStripMenuItem.Text = "Bank Reco";
    this.QuickNoteToolStripMenuItem.Name = "QuickNoteToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem27 = this.QuickNoteToolStripMenuItem;
    size1 = new Size(272, 22);
    Size size38 = size1;
    toolStripMenuItem27.Size = size38;
    this.QuickNoteToolStripMenuItem.Text = "Quick Note";
    this.PToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.AllToolStripMenuItem,
      (ToolStripItem) this.OkToolStripMenuItem,
      (ToolStripItem) this.CheckToolStripMenuItem
    });
    this.PToolStripMenuItem.Name = "PToolStripMenuItem";
    ToolStripMenuItem ptoolStripMenuItem = this.PToolStripMenuItem;
    size1 = new Size(272, 22);
    Size size39 = size1;
    ptoolStripMenuItem.Size = size39;
    this.PToolStripMenuItem.Text = "Voucher Check";
    this.AllToolStripMenuItem.Name = "AllToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem28 = this.AllToolStripMenuItem;
    size1 = new Size(131, 22);
    Size size40 = size1;
    toolStripMenuItem28.Size = size40;
    this.AllToolStripMenuItem.Text = "All";
    this.OkToolStripMenuItem.Name = "OkToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem29 = this.OkToolStripMenuItem;
    size1 = new Size(131, 22);
    Size size41 = size1;
    toolStripMenuItem29.Size = size41;
    this.OkToolStripMenuItem.Text = "UnCheck";
    this.CheckToolStripMenuItem.Name = "CheckToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem30 = this.CheckToolStripMenuItem;
    size1 = new Size(131, 22);
    Size size42 = size1;
    toolStripMenuItem30.Size = size42;
    this.CheckToolStripMenuItem.Text = "Check";
    this.ToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[22]
    {
      (ToolStripItem) this.BillToolStripMenuItem1,
      (ToolStripItem) this.ReceiptToolStripMenuItem3,
      (ToolStripItem) this.DebitNoteToolStripMenuItem,
      (ToolStripItem) this.CreditNoteToolStripMenuItem,
      (ToolStripItem) this.ToolStripMenuItem10,
      (ToolStripItem) this.ToolStripSeparator1,
      (ToolStripItem) this.OutstandingListToolStripMenuItem,
      (ToolStripItem) this.MemberAccountToolStripMenuItem,
      (ToolStripItem) this.ToolStripMenuItem1,
      (ToolStripItem) this.ToolStripMenuItem7,
      (ToolStripItem) this.ToolStripMenuItem4,
      (ToolStripItem) this.ToolStripSeparator10,
      (ToolStripItem) this.BillRegisterToolStripMenuItem,
      (ToolStripItem) this.ReceiptRegisterToolStripMenuItem,
      (ToolStripItem) this.DebitNoteRegisterToolStripMenuItem,
      (ToolStripItem) this.CreditNoteRegisterToolStripMenuItem,
      (ToolStripItem) this.AdjustmentRegisterToolStripMenuItem,
      (ToolStripItem) this.ToolStripMenuItem21,
      (ToolStripItem) this.ToolStripSeparator11,
      (ToolStripItem) this.DataSheetToolStripMenuItem1,
      (ToolStripItem) this.BankDepositListToolStripMenuItem1,
      (ToolStripItem) this.FundRegisterToolStripMenuItem
    });
    this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_1 = this.ToolStripMenuItem2;
    size1 = new Size(114, 26);
    Size size43 = size1;
    toolStripMenuItem2_1.Size = size43;
    this.ToolStripMenuItem2.Text = "Member &Report";
    this.BillToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.HalfPageGSTVerticalDoubleBillToolStripMenuItem,
      (ToolStripItem) this.FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem
    });
    this.BillToolStripMenuItem1.Name = "BillToolStripMenuItem1";
    this.BillToolStripMenuItem1.ShortcutKeys = Keys.B | Keys.Control;
    ToolStripMenuItem toolStripMenuItem1_6 = this.BillToolStripMenuItem1;
    size1 = new Size(239, 22);
    Size size44 = size1;
    toolStripMenuItem1_6.Size = size44;
    this.BillToolStripMenuItem1.Text = "Bill Format";
    this.HalfPageGSTVerticalDoubleBillToolStripMenuItem.Name = "HalfPageGSTVerticalDoubleBillToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem31 = this.HalfPageGSTVerticalDoubleBillToolStripMenuItem;
    size1 = new Size(315, 22);
    Size size45 = size1;
    toolStripMenuItem31.Size = size45;
    this.HalfPageGSTVerticalDoubleBillToolStripMenuItem.Text = "13.Half Page - GST Vertical Double (Bill)";
    this.HalfPageGSTVerticalDoubleBillToolStripMenuItem.Visible = false;
    this.FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem.Name = "FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem32 = this.FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem;
    size1 = new Size(315, 22);
    Size size46 = size1;
    toolStripMenuItem32.Size = size46;
    this.FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem.Text = "A01. Deepak Kadam";
    this.FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem.Visible = false;
    this.ReceiptToolStripMenuItem3.Name = "ReceiptToolStripMenuItem3";
    this.ReceiptToolStripMenuItem3.ShortcutKeys = Keys.T | Keys.Control;
    ToolStripMenuItem toolStripMenuItem3_1 = this.ReceiptToolStripMenuItem3;
    size1 = new Size(239, 22);
    Size size47 = size1;
    toolStripMenuItem3_1.Size = size47;
    this.ReceiptToolStripMenuItem3.Text = "Receipt";
    this.DebitNoteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.HalfPageToolStripMenuItem,
      (ToolStripItem) this.FullPage14HeadToolStripMenuItem,
      (ToolStripItem) this.FullPage21HeadToolStripMenuItem
    });
    this.DebitNoteToolStripMenuItem.Name = "DebitNoteToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem33 = this.DebitNoteToolStripMenuItem;
    size1 = new Size(239, 22);
    Size size48 = size1;
    toolStripMenuItem33.Size = size48;
    this.DebitNoteToolStripMenuItem.Text = "Debit Note";
    this.HalfPageToolStripMenuItem.Name = "HalfPageToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem34 = this.HalfPageToolStripMenuItem;
    size1 = new Size(200, 22);
    Size size49 = size1;
    toolStripMenuItem34.Size = size49;
    this.HalfPageToolStripMenuItem.Text = "1. Half Page";
    this.FullPage14HeadToolStripMenuItem.Name = "FullPage14HeadToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem35 = this.FullPage14HeadToolStripMenuItem;
    size1 = new Size(200, 22);
    Size size50 = size1;
    toolStripMenuItem35.Size = size50;
    this.FullPage14HeadToolStripMenuItem.Text = "2. Full Page 14 Head";
    this.FullPage21HeadToolStripMenuItem.Name = "FullPage21HeadToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem36 = this.FullPage21HeadToolStripMenuItem;
    size1 = new Size(200, 22);
    Size size51 = size1;
    toolStripMenuItem36.Size = size51;
    this.FullPage21HeadToolStripMenuItem.Text = "3. Full Page 21 Head";
    this.CreditNoteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.HalfPageToolStripMenuItem1,
      (ToolStripItem) this.FullPage14HeadToolStripMenuItem1,
      (ToolStripItem) this.FullPage21HeadToolStripMenuItem1
    });
    this.CreditNoteToolStripMenuItem.Name = "CreditNoteToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem37 = this.CreditNoteToolStripMenuItem;
    size1 = new Size(239, 22);
    Size size52 = size1;
    toolStripMenuItem37.Size = size52;
    this.CreditNoteToolStripMenuItem.Text = "Credit Note";
    this.HalfPageToolStripMenuItem1.Name = "HalfPageToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_7 = this.HalfPageToolStripMenuItem1;
    size1 = new Size(200, 22);
    Size size53 = size1;
    toolStripMenuItem1_7.Size = size53;
    this.HalfPageToolStripMenuItem1.Text = "1. Half Page";
    this.FullPage14HeadToolStripMenuItem1.Name = "FullPage14HeadToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_8 = this.FullPage14HeadToolStripMenuItem1;
    size1 = new Size(200, 22);
    Size size54 = size1;
    toolStripMenuItem1_8.Size = size54;
    this.FullPage14HeadToolStripMenuItem1.Text = "2. Full Page 14 Head";
    this.FullPage21HeadToolStripMenuItem1.Name = "FullPage21HeadToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_9 = this.FullPage21HeadToolStripMenuItem1;
    size1 = new Size(200, 22);
    Size size55 = size1;
    toolStripMenuItem1_9.Size = size55;
    this.FullPage21HeadToolStripMenuItem1.Text = "3. Full Page 21 Head";
    this.ToolStripMenuItem10.Name = "ToolStripMenuItem10";
    ToolStripMenuItem toolStripMenuItem10_1 = this.ToolStripMenuItem10;
    size1 = new Size(239, 22);
    Size size56 = size1;
    toolStripMenuItem10_1.Size = size56;
    this.ToolStripMenuItem10.Text = "Adjustment";
    this.ToolStripSeparator1.Name = "ToolStripSeparator1";
    ToolStripSeparator toolStripSeparator1 = this.ToolStripSeparator1;
    size1 = new Size(236, 6);
    Size size57 = size1;
    toolStripSeparator1.Size = size57;
    this.OutstandingListToolStripMenuItem.Name = "OutstandingListToolStripMenuItem";
    this.OutstandingListToolStripMenuItem.ShortcutKeys = Keys.O | Keys.Control;
    ToolStripMenuItem toolStripMenuItem38 = this.OutstandingListToolStripMenuItem;
    size1 = new Size(239, 22);
    Size size58 = size1;
    toolStripMenuItem38.Size = size58;
    this.OutstandingListToolStripMenuItem.Text = "Outstanding List";
    this.MemberAccountToolStripMenuItem.Name = "MemberAccountToolStripMenuItem";
    this.MemberAccountToolStripMenuItem.ShortcutKeys = Keys.E | Keys.Control;
    ToolStripMenuItem toolStripMenuItem39 = this.MemberAccountToolStripMenuItem;
    size1 = new Size(239, 22);
    Size size59 = size1;
    toolStripMenuItem39.Size = size59;
    this.MemberAccountToolStripMenuItem.Text = "Member Account";
    this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_10 = this.ToolStripMenuItem1;
    size1 = new Size(239, 22);
    Size size60 = size1;
    toolStripMenuItem1_10.Size = size60;
    this.ToolStripMenuItem1.Text = "Member Register";
    this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
    ToolStripMenuItem toolStripMenuItem7_1 = this.ToolStripMenuItem7;
    size1 = new Size(239, 22);
    Size size61 = size1;
    toolStripMenuItem7_1.Size = size61;
    this.ToolStripMenuItem7.Text = "Member Control Account";
    this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
    ToolStripMenuItem toolStripMenuItem4_1 = this.ToolStripMenuItem4;
    size1 = new Size(239, 22);
    Size size62 = size1;
    toolStripMenuItem4_1.Size = size62;
    this.ToolStripMenuItem4.Text = "Balance Confirmation Letter";
    this.ToolStripSeparator10.Name = "ToolStripSeparator10";
    ToolStripSeparator stripSeparator10 = this.ToolStripSeparator10;
    size1 = new Size(236, 6);
    Size size63 = size1;
    stripSeparator10.Size = size63;
    this.BillRegisterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.NormalToolStripMenuItem,
      (ToolStripItem) this.BillRegisgerWithReceiptToolStripMenuItem,
      (ToolStripItem) this.GSTBillRegisterToolStripMenuItem1
    });
    this.BillRegisterToolStripMenuItem.Name = "BillRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem40 = this.BillRegisterToolStripMenuItem;
    size1 = new Size(239, 22);
    Size size64 = size1;
    toolStripMenuItem40.Size = size64;
    this.BillRegisterToolStripMenuItem.Text = "Bill Register";
    this.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem41 = this.NormalToolStripMenuItem;
    size1 = new Size(228, 22);
    Size size65 = size1;
    toolStripMenuItem41.Size = size65;
    this.NormalToolStripMenuItem.Text = "Normal";
    this.BillRegisgerWithReceiptToolStripMenuItem.Name = "BillRegisgerWithReceiptToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem42 = this.BillRegisgerWithReceiptToolStripMenuItem;
    size1 = new Size(228, 22);
    Size size66 = size1;
    toolStripMenuItem42.Size = size66;
    this.BillRegisgerWithReceiptToolStripMenuItem.Text = "Bill Regisger with Receipt";
    this.GSTBillRegisterToolStripMenuItem1.Name = "GSTBillRegisterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_11 = this.GSTBillRegisterToolStripMenuItem1;
    size1 = new Size(228, 22);
    Size size67 = size1;
    toolStripMenuItem1_11.Size = size67;
    this.GSTBillRegisterToolStripMenuItem1.Text = "GST Bill Register";
    this.ReceiptRegisterToolStripMenuItem.Name = "ReceiptRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem43 = this.ReceiptRegisterToolStripMenuItem;
    size1 = new Size(239, 22);
    Size size68 = size1;
    toolStripMenuItem43.Size = size68;
    this.ReceiptRegisterToolStripMenuItem.Text = "Receipt Register";
    this.DebitNoteRegisterToolStripMenuItem.Name = "DebitNoteRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem44 = this.DebitNoteRegisterToolStripMenuItem;
    size1 = new Size(239, 22);
    Size size69 = size1;
    toolStripMenuItem44.Size = size69;
    this.DebitNoteRegisterToolStripMenuItem.Text = "Debit Note Register";
    this.CreditNoteRegisterToolStripMenuItem.Name = "CreditNoteRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem45 = this.CreditNoteRegisterToolStripMenuItem;
    size1 = new Size(239, 22);
    Size size70 = size1;
    toolStripMenuItem45.Size = size70;
    this.CreditNoteRegisterToolStripMenuItem.Text = "Credit Note Register";
    this.AdjustmentRegisterToolStripMenuItem.Name = "AdjustmentRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem46 = this.AdjustmentRegisterToolStripMenuItem;
    size1 = new Size(239, 22);
    Size size71 = size1;
    toolStripMenuItem46.Size = size71;
    this.AdjustmentRegisterToolStripMenuItem.Text = "Adjustment Register";
    this.ToolStripMenuItem21.Name = "ToolStripMenuItem21";
    ToolStripMenuItem toolStripMenuItem21_1 = this.ToolStripMenuItem21;
    size1 = new Size(239, 22);
    Size size72 = size1;
    toolStripMenuItem21_1.Size = size72;
    this.ToolStripMenuItem21.Text = "Member JV Register";
    this.ToolStripSeparator11.Name = "ToolStripSeparator11";
    ToolStripSeparator stripSeparator11 = this.ToolStripSeparator11;
    size1 = new Size(236, 6);
    Size size73 = size1;
    stripSeparator11.Size = size73;
    this.DataSheetToolStripMenuItem1.Name = "DataSheetToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_12 = this.DataSheetToolStripMenuItem1;
    size1 = new Size(239, 22);
    Size size74 = size1;
    toolStripMenuItem1_12.Size = size74;
    this.DataSheetToolStripMenuItem1.Text = "Data Sheet";
    this.BankDepositListToolStripMenuItem1.Name = "BankDepositListToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_13 = this.BankDepositListToolStripMenuItem1;
    size1 = new Size(239, 22);
    Size size75 = size1;
    toolStripMenuItem1_13.Size = size75;
    this.BankDepositListToolStripMenuItem1.Text = "Bank Deposit List";
    this.FundRegisterToolStripMenuItem.Name = "FundRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem47 = this.FundRegisterToolStripMenuItem;
    size1 = new Size(239, 22);
    Size size76 = size1;
    toolStripMenuItem47.Size = size76;
    this.FundRegisterToolStripMenuItem.Text = "Fund Register";
    this.ToolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[19]
    {
      (ToolStripItem) this.CashBankBookToolStripMenuItem,
      (ToolStripItem) this.AccountLedgerToolStripMenuItem,
      (ToolStripItem) this.TrialBalanceToolStripMenuItem3,
      (ToolStripItem) this.IncomeExpenditureAcToolStripMenuItem,
      (ToolStripItem) this.BalanceSheetToolStripMenuItem2,
      (ToolStripItem) this.ScheduleToolStripMenuItem1,
      (ToolStripItem) this.GroupReceiptPaymentAcToolStripMenuItem,
      (ToolStripItem) this.ReceiptPaymentAcToolStripMenuItem1,
      (ToolStripItem) this.ToolStripMenuItem6,
      (ToolStripItem) this.ToolStripSeparator4,
      (ToolStripItem) this.ReceiptRegiToolStripMenuItem,
      (ToolStripItem) this.PaymentRegisterToolStripMenuItem,
      (ToolStripItem) this.ContraRegisterToolStripMenuItem,
      (ToolStripItem) this.JournalRegisterToolStripMenuItem,
      (ToolStripItem) this.IncomeExpenditureAcMarathiToolStripMenuItem,
      (ToolStripItem) this.BalanceSheetMarathiToolStripMenuItem,
      (ToolStripItem) this.ReceiptPaymentGroupwiseMarathiToolStripMenuItem,
      (ToolStripItem) this.ReceiptPaymentAccountwiseMarathiToolStripMenuItem,
      (ToolStripItem) this.VoucherCheckReportToolStripMenuItem
    });
    this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
    ToolStripMenuItem toolStripMenuItem3_2 = this.ToolStripMenuItem3;
    size1 = new Size(112 /*0x70*/, 26);
    Size size77 = size1;
    toolStripMenuItem3_2.Size = size77;
    this.ToolStripMenuItem3.Text = "&Account Report";
    this.CashBankBookToolStripMenuItem.Name = "CashBankBookToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem48 = this.CashBankBookToolStripMenuItem;
    size1 = new Size(330, 22);
    Size size78 = size1;
    toolStripMenuItem48.Size = size78;
    this.CashBankBookToolStripMenuItem.Text = "Cash / Bank Book";
    this.AccountLedgerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.CodeWiseToolStripMenuItem,
      (ToolStripItem) this.GroupWiseToolStripMenuItem
    });
    this.AccountLedgerToolStripMenuItem.Name = "AccountLedgerToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem49 = this.AccountLedgerToolStripMenuItem;
    size1 = new Size(330, 22);
    Size size79 = size1;
    toolStripMenuItem49.Size = size79;
    this.AccountLedgerToolStripMenuItem.Text = "Account Ledger";
    this.CodeWiseToolStripMenuItem.Name = "CodeWiseToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem50 = this.CodeWiseToolStripMenuItem;
    size1 = new Size(144 /*0x90*/, 22);
    Size size80 = size1;
    toolStripMenuItem50.Size = size80;
    this.CodeWiseToolStripMenuItem.Text = "CodeWise";
    this.GroupWiseToolStripMenuItem.Name = "GroupWiseToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem51 = this.GroupWiseToolStripMenuItem;
    size1 = new Size(144 /*0x90*/, 22);
    Size size81 = size1;
    toolStripMenuItem51.Size = size81;
    this.GroupWiseToolStripMenuItem.Text = "GroupWise";
    this.TrialBalanceToolStripMenuItem3.Name = "TrialBalanceToolStripMenuItem3";
    ToolStripMenuItem toolStripMenuItem3_3 = this.TrialBalanceToolStripMenuItem3;
    size1 = new Size(330, 22);
    Size size82 = size1;
    toolStripMenuItem3_3.Size = size82;
    this.TrialBalanceToolStripMenuItem3.Text = "Trial Balance";
    this.IncomeExpenditureAcToolStripMenuItem.Name = "IncomeExpenditureAcToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem52 = this.IncomeExpenditureAcToolStripMenuItem;
    size1 = new Size(330, 22);
    Size size83 = size1;
    toolStripMenuItem52.Size = size83;
    this.IncomeExpenditureAcToolStripMenuItem.Text = "Income && Expenditure A/c.";
    this.BalanceSheetToolStripMenuItem2.Name = "BalanceSheetToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_2 = this.BalanceSheetToolStripMenuItem2;
    size1 = new Size(330, 22);
    Size size84 = size1;
    toolStripMenuItem2_2.Size = size84;
    this.BalanceSheetToolStripMenuItem2.Text = "Balance Sheet";
    this.ScheduleToolStripMenuItem1.Name = "ScheduleToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_14 = this.ScheduleToolStripMenuItem1;
    size1 = new Size(330, 22);
    Size size85 = size1;
    toolStripMenuItem1_14.Size = size85;
    this.ScheduleToolStripMenuItem1.Text = "Schedule";
    this.GroupReceiptPaymentAcToolStripMenuItem.Name = "GroupReceiptPaymentAcToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem53 = this.GroupReceiptPaymentAcToolStripMenuItem;
    size1 = new Size(330, 22);
    Size size86 = size1;
    toolStripMenuItem53.Size = size86;
    this.GroupReceiptPaymentAcToolStripMenuItem.Text = "Receipt && Payment A/c. - Groupwise";
    this.ReceiptPaymentAcToolStripMenuItem1.Name = "ReceiptPaymentAcToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_15 = this.ReceiptPaymentAcToolStripMenuItem1;
    size1 = new Size(330, 22);
    Size size87 = size1;
    toolStripMenuItem1_15.Size = size87;
    this.ReceiptPaymentAcToolStripMenuItem1.Text = "Receipt && Payment A/c. - Accoutwise";
    this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
    ToolStripMenuItem toolStripMenuItem6_1 = this.ToolStripMenuItem6;
    size1 = new Size(330, 22);
    Size size88 = size1;
    toolStripMenuItem6_1.Size = size88;
    this.ToolStripMenuItem6.Text = "Monthly Report";
    this.ToolStripSeparator4.Name = "ToolStripSeparator4";
    ToolStripSeparator toolStripSeparator4 = this.ToolStripSeparator4;
    size1 = new Size(327, 6);
    Size size89 = size1;
    toolStripSeparator4.Size = size89;
    this.ReceiptRegiToolStripMenuItem.Name = "ReceiptRegiToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem54 = this.ReceiptRegiToolStripMenuItem;
    size1 = new Size(330, 22);
    Size size90 = size1;
    toolStripMenuItem54.Size = size90;
    this.ReceiptRegiToolStripMenuItem.Text = "Receipt Register";
    this.PaymentRegisterToolStripMenuItem.Name = "PaymentRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem55 = this.PaymentRegisterToolStripMenuItem;
    size1 = new Size(330, 22);
    Size size91 = size1;
    toolStripMenuItem55.Size = size91;
    this.PaymentRegisterToolStripMenuItem.Text = "Payment Register";
    this.ContraRegisterToolStripMenuItem.Name = "ContraRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem56 = this.ContraRegisterToolStripMenuItem;
    size1 = new Size(330, 22);
    Size size92 = size1;
    toolStripMenuItem56.Size = size92;
    this.ContraRegisterToolStripMenuItem.Text = "Contra Register";
    this.JournalRegisterToolStripMenuItem.Name = "JournalRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem57 = this.JournalRegisterToolStripMenuItem;
    size1 = new Size(330, 22);
    Size size93 = size1;
    toolStripMenuItem57.Size = size93;
    this.JournalRegisterToolStripMenuItem.Text = "Journal Register";
    this.IncomeExpenditureAcMarathiToolStripMenuItem.Name = "IncomeExpenditureAcMarathiToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem58 = this.IncomeExpenditureAcMarathiToolStripMenuItem;
    size1 = new Size(330, 22);
    Size size94 = size1;
    toolStripMenuItem58.Size = size94;
    this.IncomeExpenditureAcMarathiToolStripMenuItem.Text = "Income && Expenditure A/c. - Marathi";
    this.BalanceSheetMarathiToolStripMenuItem.Name = "BalanceSheetMarathiToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem59 = this.BalanceSheetMarathiToolStripMenuItem;
    size1 = new Size(330, 22);
    Size size95 = size1;
    toolStripMenuItem59.Size = size95;
    this.BalanceSheetMarathiToolStripMenuItem.Text = "Balance Sheet - Marathi";
    this.ReceiptPaymentGroupwiseMarathiToolStripMenuItem.Name = "ReceiptPaymentGroupwiseMarathiToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem60 = this.ReceiptPaymentGroupwiseMarathiToolStripMenuItem;
    size1 = new Size(330, 22);
    Size size96 = size1;
    toolStripMenuItem60.Size = size96;
    this.ReceiptPaymentGroupwiseMarathiToolStripMenuItem.Text = "Receipt && Payment - Groupwise - Marathi";
    this.ReceiptPaymentAccountwiseMarathiToolStripMenuItem.Name = "ReceiptPaymentAccountwiseMarathiToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem61 = this.ReceiptPaymentAccountwiseMarathiToolStripMenuItem;
    size1 = new Size(330, 22);
    Size size97 = size1;
    toolStripMenuItem61.Size = size97;
    this.ReceiptPaymentAccountwiseMarathiToolStripMenuItem.Text = "Receipt && Payment - Accountwise - Marathi";
    this.VoucherCheckReportToolStripMenuItem.Name = "VoucherCheckReportToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem62 = this.VoucherCheckReportToolStripMenuItem;
    size1 = new Size(330, 22);
    Size size98 = size1;
    toolStripMenuItem62.Size = size98;
    this.VoucherCheckReportToolStripMenuItem.Text = "Voucher Check Report";
    this.ToolStripMenuItem5.DropDownItems.AddRange(new ToolStripItem[6]
    {
      (ToolStripItem) this.ReceiptVoucherToolStripMenuItem1,
      (ToolStripItem) this.PaymentVoucherToolStripMenuItem1,
      (ToolStripItem) this.ContraVoucherToolStripMenuItem1,
      (ToolStripItem) this.JournalVoucherToolStripMenuItem,
      (ToolStripItem) this.BooksOfAccountToolStripMenuItem,
      (ToolStripItem) this.WhatsNewIn202425ToolStripMenuItem
    });
    this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
    ToolStripMenuItem toolStripMenuItem5_1 = this.ToolStripMenuItem5;
    size1 = new Size(124, 26);
    Size size99 = size1;
    toolStripMenuItem5_1.Size = size99;
    this.ToolStripMenuItem5.Text = "A&dditional Report";
    this.ReceiptVoucherToolStripMenuItem1.Name = "ReceiptVoucherToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_16 = this.ReceiptVoucherToolStripMenuItem1;
    size1 = new Size(205, 22);
    Size size100 = size1;
    toolStripMenuItem1_16.Size = size100;
    this.ReceiptVoucherToolStripMenuItem1.Text = "Receipt Voucher";
    this.PaymentVoucherToolStripMenuItem1.Name = "PaymentVoucherToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_17 = this.PaymentVoucherToolStripMenuItem1;
    size1 = new Size(205, 22);
    Size size101 = size1;
    toolStripMenuItem1_17.Size = size101;
    this.PaymentVoucherToolStripMenuItem1.Text = "Payment Voucher";
    this.ContraVoucherToolStripMenuItem1.Name = "ContraVoucherToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_18 = this.ContraVoucherToolStripMenuItem1;
    size1 = new Size(205, 22);
    Size size102 = size1;
    toolStripMenuItem1_18.Size = size102;
    this.ContraVoucherToolStripMenuItem1.Text = "Contra Voucher";
    this.JournalVoucherToolStripMenuItem.Name = "JournalVoucherToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem63 = this.JournalVoucherToolStripMenuItem;
    size1 = new Size(205, 22);
    Size size103 = size1;
    toolStripMenuItem63.Size = size103;
    this.JournalVoucherToolStripMenuItem.Text = "Journal Voucher";
    this.BooksOfAccountToolStripMenuItem.Name = "BooksOfAccountToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem64 = this.BooksOfAccountToolStripMenuItem;
    size1 = new Size(205, 22);
    Size size104 = size1;
    toolStripMenuItem64.Size = size104;
    this.BooksOfAccountToolStripMenuItem.Text = "Mauli Report";
    this.WhatsNewIn202425ToolStripMenuItem.Name = "WhatsNewIn202425ToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem65 = this.WhatsNewIn202425ToolStripMenuItem;
    size1 = new Size(205, 22);
    Size size105 = size1;
    toolStripMenuItem65.Size = size105;
    this.WhatsNewIn202425ToolStripMenuItem.Text = "Whats New in 2025.26";
    this.ToolStripMenuItem14.DropDownItems.AddRange(new ToolStripItem[7]
    {
      (ToolStripItem) this.MailToMemberToolStripMenuItem,
      (ToolStripItem) this.MailToCommitteeToolStripMenuItem,
      (ToolStripItem) this.EmailIdSettingToolStripMenuItem,
      (ToolStripItem) this.WhatsupToMemberToolStripMenuItem,
      (ToolStripItem) this.WhatsupToCommitteeToolStripMenuItem,
      (ToolStripItem) this.WhatsupSettingToolStripMenuItem,
      (ToolStripItem) this.CommitteeMasterToolStripMenuItem1
    });
    this.ToolStripMenuItem14.Name = "ToolStripMenuItem14";
    ToolStripMenuItem toolStripMenuItem14_1 = this.ToolStripMenuItem14;
    size1 = new Size(117, 26);
    Size size106 = size1;
    toolStripMenuItem14_1.Size = size106;
    this.ToolStripMenuItem14.Text = "Email / Whatsup";
    this.MailToMemberToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[9]
    {
      (ToolStripItem) this.BillFormatToolStripMenuItem1,
      (ToolStripItem) this.ReceiptToolStripMenuItem4,
      (ToolStripItem) this.MemberAccountToolStripMenuItem3,
      (ToolStripItem) this.MemberRegisterToolStripMenuItem2,
      (ToolStripItem) this.OutstandingReminderToolStripMenuItem1,
      (ToolStripItem) this.OutstandingLetterToolStripMenuItem1,
      (ToolStripItem) this.MessageToolStripMenuItem1,
      (ToolStripItem) this.BalanceConfirmationLetterToolStripMenuItem1,
      (ToolStripItem) this.MessageWithPdfToolStripMenuItem2
    });
    this.MailToMemberToolStripMenuItem.Name = "MailToMemberToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem66 = this.MailToMemberToolStripMenuItem;
    size1 = new Size(210, 22);
    Size size107 = size1;
    toolStripMenuItem66.Size = size107;
    this.MailToMemberToolStripMenuItem.Text = "Mail to Member";
    this.BillFormatToolStripMenuItem1.Name = "BillFormatToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_19 = this.BillFormatToolStripMenuItem1;
    size1 = new Size(239, 22);
    Size size108 = size1;
    toolStripMenuItem1_19.Size = size108;
    this.BillFormatToolStripMenuItem1.Text = "Bill Format";
    this.ReceiptToolStripMenuItem4.Name = "ReceiptToolStripMenuItem4";
    ToolStripMenuItem toolStripMenuItem4_2 = this.ReceiptToolStripMenuItem4;
    size1 = new Size(239, 22);
    Size size109 = size1;
    toolStripMenuItem4_2.Size = size109;
    this.ReceiptToolStripMenuItem4.Text = "Receipt";
    this.MemberAccountToolStripMenuItem3.Name = "MemberAccountToolStripMenuItem3";
    ToolStripMenuItem toolStripMenuItem3_4 = this.MemberAccountToolStripMenuItem3;
    size1 = new Size(239, 22);
    Size size110 = size1;
    toolStripMenuItem3_4.Size = size110;
    this.MemberAccountToolStripMenuItem3.Text = "Member Account";
    this.MemberRegisterToolStripMenuItem2.Name = "MemberRegisterToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_3 = this.MemberRegisterToolStripMenuItem2;
    size1 = new Size(239, 22);
    Size size111 = size1;
    toolStripMenuItem2_3.Size = size111;
    this.MemberRegisterToolStripMenuItem2.Text = "Member Register";
    this.OutstandingReminderToolStripMenuItem1.Name = "OutstandingReminderToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_20 = this.OutstandingReminderToolStripMenuItem1;
    size1 = new Size(239, 22);
    Size size112 = size1;
    toolStripMenuItem1_20.Size = size112;
    this.OutstandingReminderToolStripMenuItem1.Text = "Outstanding Reminder";
    this.OutstandingLetterToolStripMenuItem1.Name = "OutstandingLetterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_21 = this.OutstandingLetterToolStripMenuItem1;
    size1 = new Size(239, 22);
    Size size113 = size1;
    toolStripMenuItem1_21.Size = size113;
    this.OutstandingLetterToolStripMenuItem1.Text = "Outstanding Letter";
    this.MessageToolStripMenuItem1.Name = "MessageToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_22 = this.MessageToolStripMenuItem1;
    size1 = new Size(239, 22);
    Size size114 = size1;
    toolStripMenuItem1_22.Size = size114;
    this.MessageToolStripMenuItem1.Text = "Message";
    this.BalanceConfirmationLetterToolStripMenuItem1.Name = "BalanceConfirmationLetterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_23 = this.BalanceConfirmationLetterToolStripMenuItem1;
    size1 = new Size(239, 22);
    Size size115 = size1;
    toolStripMenuItem1_23.Size = size115;
    this.BalanceConfirmationLetterToolStripMenuItem1.Text = "Balance Confirmation Letter";
    this.MessageWithPdfToolStripMenuItem2.Name = "MessageWithPdfToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_4 = this.MessageWithPdfToolStripMenuItem2;
    size1 = new Size(239, 22);
    Size size116 = size1;
    toolStripMenuItem2_4.Size = size116;
    this.MessageWithPdfToolStripMenuItem2.Text = "Message with Pdf";
    this.MailToCommitteeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[13]
    {
      (ToolStripItem) this.IncomeExpenditureToolStripMenuItem,
      (ToolStripItem) this.BalanceSheetToolStripMenuItem,
      (ToolStripItem) this.TrialBalanceToolStripMenuItem,
      (ToolStripItem) this.CashBankBookToolStripMenuItem1,
      (ToolStripItem) this.LedgerToolStripMenuItem,
      (ToolStripItem) this.ReceiptPaymentAccoutToolStripMenuItem,
      (ToolStripItem) this.ReceiptPaymentAccoutwiseToolStripMenuItem,
      (ToolStripItem) this.ScheduleToolStripMenuItem,
      (ToolStripItem) this.MonthlyReportToolStripMenuItem,
      (ToolStripItem) this.ReceiptRegisterToolStripMenuItem1,
      (ToolStripItem) this.PaymentRegisterToolStripMenuItem1,
      (ToolStripItem) this.ContraRegisterToolStripMenuItem1,
      (ToolStripItem) this.JournalRegisterToolStripMenuItem1
    });
    this.MailToCommitteeToolStripMenuItem.Name = "MailToCommitteeToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem67 = this.MailToCommitteeToolStripMenuItem;
    size1 = new Size(210, 22);
    Size size117 = size1;
    toolStripMenuItem67.Size = size117;
    this.MailToCommitteeToolStripMenuItem.Text = "Mail to Committee";
    this.IncomeExpenditureToolStripMenuItem.Name = "IncomeExpenditureToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem68 = this.IncomeExpenditureToolStripMenuItem;
    size1 = new Size(270, 22);
    Size size118 = size1;
    toolStripMenuItem68.Size = size118;
    this.IncomeExpenditureToolStripMenuItem.Text = "Income && Expenditure";
    this.BalanceSheetToolStripMenuItem.Name = "BalanceSheetToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem69 = this.BalanceSheetToolStripMenuItem;
    size1 = new Size(270, 22);
    Size size119 = size1;
    toolStripMenuItem69.Size = size119;
    this.BalanceSheetToolStripMenuItem.Text = "Balance Sheet";
    this.TrialBalanceToolStripMenuItem.Name = "TrialBalanceToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem70 = this.TrialBalanceToolStripMenuItem;
    size1 = new Size(270, 22);
    Size size120 = size1;
    toolStripMenuItem70.Size = size120;
    this.TrialBalanceToolStripMenuItem.Text = "Trial Balance";
    this.CashBankBookToolStripMenuItem1.Name = "CashBankBookToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_24 = this.CashBankBookToolStripMenuItem1;
    size1 = new Size(270, 22);
    Size size121 = size1;
    toolStripMenuItem1_24.Size = size121;
    this.CashBankBookToolStripMenuItem1.Text = "Cash / Bank Book";
    this.LedgerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.CodeWiseToolStripMenuItem1,
      (ToolStripItem) this.GroupWiseToolStripMenuItem1
    });
    this.LedgerToolStripMenuItem.Name = "LedgerToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem71 = this.LedgerToolStripMenuItem;
    size1 = new Size(270, 22);
    Size size122 = size1;
    toolStripMenuItem71.Size = size122;
    this.LedgerToolStripMenuItem.Text = "Account Ledger";
    this.CodeWiseToolStripMenuItem1.Name = "CodeWiseToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_25 = this.CodeWiseToolStripMenuItem1;
    size1 = new Size(147, 22);
    Size size123 = size1;
    toolStripMenuItem1_25.Size = size123;
    this.CodeWiseToolStripMenuItem1.Text = "Code Wise";
    this.GroupWiseToolStripMenuItem1.Name = "GroupWiseToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_26 = this.GroupWiseToolStripMenuItem1;
    size1 = new Size(147, 22);
    Size size124 = size1;
    toolStripMenuItem1_26.Size = size124;
    this.GroupWiseToolStripMenuItem1.Text = "Group Wise";
    this.ReceiptPaymentAccoutToolStripMenuItem.Name = "ReceiptPaymentAccoutToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem72 = this.ReceiptPaymentAccoutToolStripMenuItem;
    size1 = new Size(270, 22);
    Size size125 = size1;
    toolStripMenuItem72.Size = size125;
    this.ReceiptPaymentAccoutToolStripMenuItem.Text = "Receipt && Payment (Groupwise)";
    this.ReceiptPaymentAccoutwiseToolStripMenuItem.Name = "ReceiptPaymentAccoutwiseToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem73 = this.ReceiptPaymentAccoutwiseToolStripMenuItem;
    size1 = new Size(270, 22);
    Size size126 = size1;
    toolStripMenuItem73.Size = size126;
    this.ReceiptPaymentAccoutwiseToolStripMenuItem.Text = "Receipt && Payment (Accoutwise)";
    this.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem74 = this.ScheduleToolStripMenuItem;
    size1 = new Size(270, 22);
    Size size127 = size1;
    toolStripMenuItem74.Size = size127;
    this.ScheduleToolStripMenuItem.Text = "Schedule";
    this.MonthlyReportToolStripMenuItem.Name = "MonthlyReportToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem75 = this.MonthlyReportToolStripMenuItem;
    size1 = new Size(270, 22);
    Size size128 = size1;
    toolStripMenuItem75.Size = size128;
    this.MonthlyReportToolStripMenuItem.Text = "Monthly Report";
    this.ReceiptRegisterToolStripMenuItem1.Name = "ReceiptRegisterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_27 = this.ReceiptRegisterToolStripMenuItem1;
    size1 = new Size(270, 22);
    Size size129 = size1;
    toolStripMenuItem1_27.Size = size129;
    this.ReceiptRegisterToolStripMenuItem1.Text = "Receipt Register";
    this.PaymentRegisterToolStripMenuItem1.Name = "PaymentRegisterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_28 = this.PaymentRegisterToolStripMenuItem1;
    size1 = new Size(270, 22);
    Size size130 = size1;
    toolStripMenuItem1_28.Size = size130;
    this.PaymentRegisterToolStripMenuItem1.Text = "Payment Register";
    this.ContraRegisterToolStripMenuItem1.Name = "ContraRegisterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_29 = this.ContraRegisterToolStripMenuItem1;
    size1 = new Size(270, 22);
    Size size131 = size1;
    toolStripMenuItem1_29.Size = size131;
    this.ContraRegisterToolStripMenuItem1.Text = "Contra Register";
    this.JournalRegisterToolStripMenuItem1.Name = "JournalRegisterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_30 = this.JournalRegisterToolStripMenuItem1;
    size1 = new Size(270, 22);
    Size size132 = size1;
    toolStripMenuItem1_30.Size = size132;
    this.JournalRegisterToolStripMenuItem1.Text = "Journal Register";
    this.EmailIdSettingToolStripMenuItem.Name = "EmailIdSettingToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem76 = this.EmailIdSettingToolStripMenuItem;
    size1 = new Size(210, 22);
    Size size133 = size1;
    toolStripMenuItem76.Size = size133;
    this.EmailIdSettingToolStripMenuItem.Text = "Email Id Setting";
    this.WhatsupToMemberToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[8]
    {
      (ToolStripItem) this.BillFormatToolStripMenuItem2,
      (ToolStripItem) this.ReceiptToolStripMenuItem1,
      (ToolStripItem) this.MemberAccountToolStripMenuItem1,
      (ToolStripItem) this.MemberRegisterToolStripMenuItem,
      (ToolStripItem) this.OutstandingReminderToolStripMenuItem2,
      (ToolStripItem) this.MessageToolStripMenuItem2,
      (ToolStripItem) this.BalanceConfirmationLetterToolStripMenuItem2,
      (ToolStripItem) this.MessageWithPdfToolStripMenuItem
    });
    this.WhatsupToMemberToolStripMenuItem.Enabled = false;
    this.WhatsupToMemberToolStripMenuItem.Name = "WhatsupToMemberToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem77 = this.WhatsupToMemberToolStripMenuItem;
    size1 = new Size(210, 22);
    Size size134 = size1;
    toolStripMenuItem77.Size = size134;
    this.WhatsupToMemberToolStripMenuItem.Text = "Whatsup to Member";
    this.BillFormatToolStripMenuItem2.Name = "BillFormatToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_5 = this.BillFormatToolStripMenuItem2;
    size1 = new Size(239, 22);
    Size size135 = size1;
    toolStripMenuItem2_5.Size = size135;
    this.BillFormatToolStripMenuItem2.Text = "Bill Format";
    this.ReceiptToolStripMenuItem1.Name = "ReceiptToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_31 = this.ReceiptToolStripMenuItem1;
    size1 = new Size(239, 22);
    Size size136 = size1;
    toolStripMenuItem1_31.Size = size136;
    this.ReceiptToolStripMenuItem1.Text = "Receipt";
    this.MemberAccountToolStripMenuItem1.Name = "MemberAccountToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_32 = this.MemberAccountToolStripMenuItem1;
    size1 = new Size(239, 22);
    Size size137 = size1;
    toolStripMenuItem1_32.Size = size137;
    this.MemberAccountToolStripMenuItem1.Text = "Member Account";
    this.MemberRegisterToolStripMenuItem.Name = "MemberRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem78 = this.MemberRegisterToolStripMenuItem;
    size1 = new Size(239, 22);
    Size size138 = size1;
    toolStripMenuItem78.Size = size138;
    this.MemberRegisterToolStripMenuItem.Text = "Member Register";
    this.OutstandingReminderToolStripMenuItem2.Name = "OutstandingReminderToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_6 = this.OutstandingReminderToolStripMenuItem2;
    size1 = new Size(239, 22);
    Size size139 = size1;
    toolStripMenuItem2_6.Size = size139;
    this.OutstandingReminderToolStripMenuItem2.Text = "Outstanding Reminder";
    this.MessageToolStripMenuItem2.Name = "MessageToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_7 = this.MessageToolStripMenuItem2;
    size1 = new Size(239, 22);
    Size size140 = size1;
    toolStripMenuItem2_7.Size = size140;
    this.MessageToolStripMenuItem2.Text = "Message";
    this.BalanceConfirmationLetterToolStripMenuItem2.Name = "BalanceConfirmationLetterToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_8 = this.BalanceConfirmationLetterToolStripMenuItem2;
    size1 = new Size(239, 22);
    Size size141 = size1;
    toolStripMenuItem2_8.Size = size141;
    this.BalanceConfirmationLetterToolStripMenuItem2.Text = "Balance Confirmation Letter";
    this.MessageWithPdfToolStripMenuItem.Name = "MessageWithPdfToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem79 = this.MessageWithPdfToolStripMenuItem;
    size1 = new Size(239, 22);
    Size size142 = size1;
    toolStripMenuItem79.Size = size142;
    this.MessageWithPdfToolStripMenuItem.Text = "Message with Pdf";
    this.WhatsupToCommitteeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[13]
    {
      (ToolStripItem) this.IncomeExpenditureToolStripMenuItem1,
      (ToolStripItem) this.BalanceSheetToolStripMenuItem1,
      (ToolStripItem) this.TrialBalanceToolStripMenuItem1,
      (ToolStripItem) this.CashBankBookToolStripMenuItem2,
      (ToolStripItem) this.AccountLedgerToolStripMenuItem1,
      (ToolStripItem) this.ReceiptPaymentGroupwiseToolStripMenuItem,
      (ToolStripItem) this.ReceiptPaymentAccoutwiseToolStripMenuItem1,
      (ToolStripItem) this.ScheduleToolStripMenuItem2,
      (ToolStripItem) this.MonthlyReportToolStripMenuItem1,
      (ToolStripItem) this.ReceiptRegisterToolStripMenuItem2,
      (ToolStripItem) this.PaymentRegisterToolStripMenuItem2,
      (ToolStripItem) this.ContraRegisterToolStripMenuItem2,
      (ToolStripItem) this.JournalRegisterToolStripMenuItem2
    });
    this.WhatsupToCommitteeToolStripMenuItem.Enabled = false;
    this.WhatsupToCommitteeToolStripMenuItem.Name = "WhatsupToCommitteeToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem80 = this.WhatsupToCommitteeToolStripMenuItem;
    size1 = new Size(210, 22);
    Size size143 = size1;
    toolStripMenuItem80.Size = size143;
    this.WhatsupToCommitteeToolStripMenuItem.Text = "Whatsup to Committee";
    this.IncomeExpenditureToolStripMenuItem1.Name = "IncomeExpenditureToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_33 = this.IncomeExpenditureToolStripMenuItem1;
    size1 = new Size(270, 22);
    Size size144 = size1;
    toolStripMenuItem1_33.Size = size144;
    this.IncomeExpenditureToolStripMenuItem1.Text = "Income && Expenditure";
    this.BalanceSheetToolStripMenuItem1.Name = "BalanceSheetToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_34 = this.BalanceSheetToolStripMenuItem1;
    size1 = new Size(270, 22);
    Size size145 = size1;
    toolStripMenuItem1_34.Size = size145;
    this.BalanceSheetToolStripMenuItem1.Text = "Balance Sheet";
    this.TrialBalanceToolStripMenuItem1.Name = "TrialBalanceToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_35 = this.TrialBalanceToolStripMenuItem1;
    size1 = new Size(270, 22);
    Size size146 = size1;
    toolStripMenuItem1_35.Size = size146;
    this.TrialBalanceToolStripMenuItem1.Text = "Trial Balance";
    this.CashBankBookToolStripMenuItem2.Name = "CashBankBookToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_9 = this.CashBankBookToolStripMenuItem2;
    size1 = new Size(270, 22);
    Size size147 = size1;
    toolStripMenuItem2_9.Size = size147;
    this.CashBankBookToolStripMenuItem2.Text = "Cash / Bank Book";
    this.AccountLedgerToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.CodewiseToolStripMenuItem2,
      (ToolStripItem) this.GroupWiseToolStripMenuItem2
    });
    this.AccountLedgerToolStripMenuItem1.Name = "AccountLedgerToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_36 = this.AccountLedgerToolStripMenuItem1;
    size1 = new Size(270, 22);
    Size size148 = size1;
    toolStripMenuItem1_36.Size = size148;
    this.AccountLedgerToolStripMenuItem1.Text = "Account Ledger";
    this.CodewiseToolStripMenuItem2.Name = "CodewiseToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_10 = this.CodewiseToolStripMenuItem2;
    size1 = new Size(147, 22);
    Size size149 = size1;
    toolStripMenuItem2_10.Size = size149;
    this.CodewiseToolStripMenuItem2.Text = "Code Wise";
    this.GroupWiseToolStripMenuItem2.Name = "GroupWiseToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_11 = this.GroupWiseToolStripMenuItem2;
    size1 = new Size(147, 22);
    Size size150 = size1;
    toolStripMenuItem2_11.Size = size150;
    this.GroupWiseToolStripMenuItem2.Text = "Group Wise";
    this.ReceiptPaymentGroupwiseToolStripMenuItem.Name = "ReceiptPaymentGroupwiseToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem81 = this.ReceiptPaymentGroupwiseToolStripMenuItem;
    size1 = new Size(270, 22);
    Size size151 = size1;
    toolStripMenuItem81.Size = size151;
    this.ReceiptPaymentGroupwiseToolStripMenuItem.Text = "Receipt && Payment (Groupwise)";
    this.ReceiptPaymentAccoutwiseToolStripMenuItem1.Name = "ReceiptPaymentAccoutwiseToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_37 = this.ReceiptPaymentAccoutwiseToolStripMenuItem1;
    size1 = new Size(270, 22);
    Size size152 = size1;
    toolStripMenuItem1_37.Size = size152;
    this.ReceiptPaymentAccoutwiseToolStripMenuItem1.Text = "Receipt && Payment (Accoutwise)";
    this.ScheduleToolStripMenuItem2.Name = "ScheduleToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_12 = this.ScheduleToolStripMenuItem2;
    size1 = new Size(270, 22);
    Size size153 = size1;
    toolStripMenuItem2_12.Size = size153;
    this.ScheduleToolStripMenuItem2.Text = "Schedule";
    this.MonthlyReportToolStripMenuItem1.Name = "MonthlyReportToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_38 = this.MonthlyReportToolStripMenuItem1;
    size1 = new Size(270, 22);
    Size size154 = size1;
    toolStripMenuItem1_38.Size = size154;
    this.MonthlyReportToolStripMenuItem1.Text = "Monthly Report";
    this.ReceiptRegisterToolStripMenuItem2.Name = "ReceiptRegisterToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_13 = this.ReceiptRegisterToolStripMenuItem2;
    size1 = new Size(270, 22);
    Size size155 = size1;
    toolStripMenuItem2_13.Size = size155;
    this.ReceiptRegisterToolStripMenuItem2.Text = "Receipt Register";
    this.PaymentRegisterToolStripMenuItem2.Name = "PaymentRegisterToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_14 = this.PaymentRegisterToolStripMenuItem2;
    size1 = new Size(270, 22);
    Size size156 = size1;
    toolStripMenuItem2_14.Size = size156;
    this.PaymentRegisterToolStripMenuItem2.Text = "Payment Register";
    this.ContraRegisterToolStripMenuItem2.Name = "ContraRegisterToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_15 = this.ContraRegisterToolStripMenuItem2;
    size1 = new Size(270, 22);
    Size size157 = size1;
    toolStripMenuItem2_15.Size = size157;
    this.ContraRegisterToolStripMenuItem2.Text = "Contra Register";
    this.JournalRegisterToolStripMenuItem2.Name = "JournalRegisterToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_16 = this.JournalRegisterToolStripMenuItem2;
    size1 = new Size(270, 22);
    Size size158 = size1;
    toolStripMenuItem2_16.Size = size158;
    this.JournalRegisterToolStripMenuItem2.Text = "Journal Register";
    this.WhatsupSettingToolStripMenuItem.Enabled = false;
    this.WhatsupSettingToolStripMenuItem.Name = "WhatsupSettingToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem82 = this.WhatsupSettingToolStripMenuItem;
    size1 = new Size(210, 22);
    Size size159 = size1;
    toolStripMenuItem82.Size = size159;
    this.WhatsupSettingToolStripMenuItem.Text = "Whatsup Setting";
    this.CommitteeMasterToolStripMenuItem1.Name = "CommitteeMasterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_39 = this.CommitteeMasterToolStripMenuItem1;
    size1 = new Size(210, 22);
    Size size160 = size1;
    toolStripMenuItem1_39.Size = size160;
    this.CommitteeMasterToolStripMenuItem1.Text = "Committee Master";
    this.UtilityToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[14]
    {
      (ToolStripItem) this.TranferToolStripMenuItem,
      (ToolStripItem) this.RenumberToolStripMenuItem,
      (ToolStripItem) this.YearBfToolStripMenuItem,
      (ToolStripItem) this.IToolStripMenuItem,
      (ToolStripItem) this.ExportTestToolStripMenuItem,
      (ToolStripItem) this.DefultGroupSettingToolStripMenuItem,
      (ToolStripItem) this.RebuildToolStripMenuItem,
      (ToolStripItem) this.CheckDifferenceToolStripMenuItem,
      (ToolStripItem) this.YearCfToolStripMenuItem,
      (ToolStripItem) this.NewTtanTypeToolStripMenuItem,
      (ToolStripItem) this.ChangeYearToolStripMenuItem,
      (ToolStripItem) this.CaclulatorToolStripMenuItem,
      (ToolStripItem) this.GSTCalculateToolStripMenuItem,
      (ToolStripItem) this.ToolStripMenuItem16
    });
    this.UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem";
    this.UtilityToolStripMenuItem.RightToLeft = RightToLeft.No;
    ToolStripMenuItem toolStripMenuItem83 = this.UtilityToolStripMenuItem;
    size1 = new Size(52, 26);
    Size size161 = size1;
    toolStripMenuItem83.Size = size161;
    this.UtilityToolStripMenuItem.Text = "&Utility";
    this.TranferToolStripMenuItem.Name = "TranferToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem84 = this.TranferToolStripMenuItem;
    size1 = new Size(211, 22);
    Size size162 = size1;
    toolStripMenuItem84.Size = size162;
    this.TranferToolStripMenuItem.Text = "Tranfer";
    this.RenumberToolStripMenuItem.Name = "RenumberToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem85 = this.RenumberToolStripMenuItem;
    size1 = new Size(211, 22);
    Size size163 = size1;
    toolStripMenuItem85.Size = size163;
    this.RenumberToolStripMenuItem.Text = "Renumber";
    this.YearBfToolStripMenuItem.Name = "YearBfToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem86 = this.YearBfToolStripMenuItem;
    size1 = new Size(211, 22);
    Size size164 = size1;
    toolStripMenuItem86.Size = size164;
    this.YearBfToolStripMenuItem.Text = "Last Year B/f";
    this.IToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[9]
    {
      (ToolStripItem) this.GroupAccountMasterFromOtherSoceityToolStripMenuItem,
      (ToolStripItem) this.BankListFromOtherSocietyToolStripMenuItem,
      (ToolStripItem) this.PersonListFromOtherSocietyToolStripMenuItem,
      (ToolStripItem) this.ToolStripMenuItem12,
      (ToolStripItem) this.MemberMasterFromExcelToolStripMenuItem,
      (ToolStripItem) this.MemberReceiptFromExcelToolStripMenuItem,
      (ToolStripItem) this.PaymentFromExcelToolStripMenuItem,
      (ToolStripItem) this.ReceiptFromExcelToolStripMenuItem,
      (ToolStripItem) this.BooksOfAccountTableFromOtherSocietyToolStripMenuItem
    });
    this.IToolStripMenuItem.Name = "IToolStripMenuItem";
    ToolStripMenuItem itoolStripMenuItem = this.IToolStripMenuItem;
    size1 = new Size(211, 22);
    Size size165 = size1;
    itoolStripMenuItem.Size = size165;
    this.IToolStripMenuItem.Text = "Import Master Data";
    this.GroupAccountMasterFromOtherSoceityToolStripMenuItem.Name = "GroupAccountMasterFromOtherSoceityToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem87 = this.GroupAccountMasterFromOtherSoceityToolStripMenuItem;
    size1 = new Size(332, 22);
    Size size166 = size1;
    toolStripMenuItem87.Size = size166;
    this.GroupAccountMasterFromOtherSoceityToolStripMenuItem.Text = "Group && Account Master from Other Soceity";
    this.BankListFromOtherSocietyToolStripMenuItem.Name = "BankListFromOtherSocietyToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem88 = this.BankListFromOtherSocietyToolStripMenuItem;
    size1 = new Size(332, 22);
    Size size167 = size1;
    toolStripMenuItem88.Size = size167;
    this.BankListFromOtherSocietyToolStripMenuItem.Text = "Bank List from Other Society";
    this.PersonListFromOtherSocietyToolStripMenuItem.Name = "PersonListFromOtherSocietyToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem89 = this.PersonListFromOtherSocietyToolStripMenuItem;
    size1 = new Size(332, 22);
    Size size168 = size1;
    toolStripMenuItem89.Size = size168;
    this.PersonListFromOtherSocietyToolStripMenuItem.Text = "Person List from Other Society";
    this.ToolStripMenuItem12.Name = "ToolStripMenuItem12";
    ToolStripMenuItem toolStripMenuItem12_1 = this.ToolStripMenuItem12;
    size1 = new Size(332, 22);
    Size size169 = size1;
    toolStripMenuItem12_1.Size = size169;
    this.ToolStripMenuItem12.Text = "Particular List from Other Society";
    this.MemberMasterFromExcelToolStripMenuItem.Name = "MemberMasterFromExcelToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem90 = this.MemberMasterFromExcelToolStripMenuItem;
    size1 = new Size(332, 22);
    Size size170 = size1;
    toolStripMenuItem90.Size = size170;
    this.MemberMasterFromExcelToolStripMenuItem.Text = "Member Master from Excel";
    this.MemberReceiptFromExcelToolStripMenuItem.Name = "MemberReceiptFromExcelToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem91 = this.MemberReceiptFromExcelToolStripMenuItem;
    size1 = new Size(332, 22);
    Size size171 = size1;
    toolStripMenuItem91.Size = size171;
    this.MemberReceiptFromExcelToolStripMenuItem.Text = "Member Receipt from Excel";
    this.PaymentFromExcelToolStripMenuItem.Name = "PaymentFromExcelToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem92 = this.PaymentFromExcelToolStripMenuItem;
    size1 = new Size(332, 22);
    Size size172 = size1;
    toolStripMenuItem92.Size = size172;
    this.PaymentFromExcelToolStripMenuItem.Text = "Payment From Excel";
    this.ReceiptFromExcelToolStripMenuItem.Name = "ReceiptFromExcelToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem93 = this.ReceiptFromExcelToolStripMenuItem;
    size1 = new Size(332, 22);
    Size size173 = size1;
    toolStripMenuItem93.Size = size173;
    this.ReceiptFromExcelToolStripMenuItem.Text = "Receipt (Other than Member) From Excel";
    this.BooksOfAccountTableFromOtherSocietyToolStripMenuItem.Name = "BooksOfAccountTableFromOtherSocietyToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem94 = this.BooksOfAccountTableFromOtherSocietyToolStripMenuItem;
    size1 = new Size(332, 22);
    Size size174 = size1;
    toolStripMenuItem94.Size = size174;
    this.BooksOfAccountTableFromOtherSocietyToolStripMenuItem.Text = "Books of Account Table from Other Society";
    this.ExportTestToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.ListToolStripMenuItem,
      (ToolStripItem) this.FormToolStripMenuItem
    });
    this.ExportTestToolStripMenuItem.Name = "ExportTestToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem95 = this.ExportTestToolStripMenuItem;
    size1 = new Size(211, 22);
    Size size175 = size1;
    toolStripMenuItem95.Size = size175;
    this.ExportTestToolStripMenuItem.Text = "Export Member Master";
    this.ListToolStripMenuItem.Name = "ListToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem96 = this.ListToolStripMenuItem;
    size1 = new Size(107, 22);
    Size size176 = size1;
    toolStripMenuItem96.Size = size176;
    this.ListToolStripMenuItem.Text = "List";
    this.FormToolStripMenuItem.Name = "FormToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem97 = this.FormToolStripMenuItem;
    size1 = new Size(107, 22);
    Size size177 = size1;
    toolStripMenuItem97.Size = size177;
    this.FormToolStripMenuItem.Text = "Form";
    this.DefultGroupSettingToolStripMenuItem.Name = "DefultGroupSettingToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem98 = this.DefultGroupSettingToolStripMenuItem;
    size1 = new Size(211, 22);
    Size size178 = size1;
    toolStripMenuItem98.Size = size178;
    this.DefultGroupSettingToolStripMenuItem.Text = "Defult Group Setting";
    this.RebuildToolStripMenuItem.Name = "RebuildToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem99 = this.RebuildToolStripMenuItem;
    size1 = new Size(211, 22);
    Size size179 = size1;
    toolStripMenuItem99.Size = size179;
    this.RebuildToolStripMenuItem.Text = "Rebuild";
    this.CheckDifferenceToolStripMenuItem.Name = "CheckDifferenceToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem100 = this.CheckDifferenceToolStripMenuItem;
    size1 = new Size(211, 22);
    Size size180 = size1;
    toolStripMenuItem100.Size = size180;
    this.CheckDifferenceToolStripMenuItem.Text = "Check Difference";
    this.YearCfToolStripMenuItem.Name = "YearCfToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem101 = this.YearCfToolStripMenuItem;
    size1 = new Size(211, 22);
    Size size181 = size1;
    toolStripMenuItem101.Size = size181;
    this.YearCfToolStripMenuItem.Text = "New Year C/f ";
    this.NewTtanTypeToolStripMenuItem.Name = "NewTtanTypeToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem102 = this.NewTtanTypeToolStripMenuItem;
    size1 = new Size(211, 22);
    Size size182 = size1;
    toolStripMenuItem102.Size = size182;
    this.NewTtanTypeToolStripMenuItem.Text = "New Ttan Type";
    this.ChangeYearToolStripMenuItem.Name = "ChangeYearToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem103 = this.ChangeYearToolStripMenuItem;
    size1 = new Size(211, 22);
    Size size183 = size1;
    toolStripMenuItem103.Size = size183;
    this.ChangeYearToolStripMenuItem.Text = "Select Year";
    this.CaclulatorToolStripMenuItem.Name = "CaclulatorToolStripMenuItem";
    this.CaclulatorToolStripMenuItem.ShortcutKeys = Keys.C | Keys.Alt;
    ToolStripMenuItem toolStripMenuItem104 = this.CaclulatorToolStripMenuItem;
    size1 = new Size(211, 22);
    Size size184 = size1;
    toolStripMenuItem104.Size = size184;
    this.CaclulatorToolStripMenuItem.Text = "Calculator";
    this.GSTCalculateToolStripMenuItem.Name = "GSTCalculateToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem105 = this.GSTCalculateToolStripMenuItem;
    size1 = new Size(211, 22);
    Size size185 = size1;
    toolStripMenuItem105.Size = size185;
    this.GSTCalculateToolStripMenuItem.Text = "GST Calculate";
    this.ToolStripMenuItem16.Name = "ToolStripMenuItem16";
    ToolStripMenuItem toolStripMenuItem16_1 = this.ToolStripMenuItem16;
    size1 = new Size(211, 22);
    Size size186 = size1;
    toolStripMenuItem16_1.Size = size186;
    this.ToolStripMenuItem16.Text = "Year Extension";
    this.ToolStripMenuItem15.DropDownItems.AddRange(new ToolStripItem[5]
    {
      (ToolStripItem) this.InterestZerowiseToolStripMenuItem,
      (ToolStripItem) this.InterestCalculateToolStripMenuItem,
      (ToolStripItem) this.DayWiseInterestCalculateToolStripMenuItem1,
      (ToolStripItem) this.BillSettingToolStripMenuItem1,
      (ToolStripItem) this.BillMasterToolStripMenuItem1
    });
    this.ToolStripMenuItem15.Name = "ToolStripMenuItem15";
    ToolStripMenuItem toolStripMenuItem15_1 = this.ToolStripMenuItem15;
    size1 = new Size(91, 26);
    Size size187 = size1;
    toolStripMenuItem15_1.Size = size187;
    this.ToolStripMenuItem15.Text = "Billing Utility";
    this.InterestZerowiseToolStripMenuItem.Name = "InterestZerowiseToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem106 = this.InterestZerowiseToolStripMenuItem;
    size1 = new Size(237, 22);
    Size size188 = size1;
    toolStripMenuItem106.Size = size188;
    this.InterestZerowiseToolStripMenuItem.Text = "Interest Zerowise";
    this.InterestCalculateToolStripMenuItem.Name = "InterestCalculateToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem107 = this.InterestCalculateToolStripMenuItem;
    size1 = new Size(237, 22);
    Size size189 = size1;
    toolStripMenuItem107.Size = size189;
    this.InterestCalculateToolStripMenuItem.Text = "Interest Calculate";
    this.DayWiseInterestCalculateToolStripMenuItem1.Name = "DayWiseInterestCalculateToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_40 = this.DayWiseInterestCalculateToolStripMenuItem1;
    size1 = new Size(237, 22);
    Size size190 = size1;
    toolStripMenuItem1_40.Size = size190;
    this.DayWiseInterestCalculateToolStripMenuItem1.Text = "DayWise Interest Calculate";
    this.BillSettingToolStripMenuItem1.Name = "BillSettingToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_41 = this.BillSettingToolStripMenuItem1;
    size1 = new Size(237, 22);
    Size size191 = size1;
    toolStripMenuItem1_41.Size = size191;
    this.BillSettingToolStripMenuItem1.Text = "Bill Setting";
    this.BillMasterToolStripMenuItem1.Name = "BillMasterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_42 = this.BillMasterToolStripMenuItem1;
    size1 = new Size(237, 22);
    Size size192 = size1;
    toolStripMenuItem1_42.Size = size192;
    this.BillMasterToolStripMenuItem1.Text = "Bill Master";
    this.ExitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[5]
    {
      (ToolStripItem) this.VendorToolStripMenuItem,
      (ToolStripItem) this.ServantToolStripMenuItem,
      (ToolStripItem) this.FToolStripMenuItem,
      (ToolStripItem) this.CommitteeMasterToolStripMenuItem,
      (ToolStripItem) this.OtherInfoToolStripMenuItem
    });
    this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem108 = this.ExitToolStripMenuItem;
    size1 = new Size(96 /*0x60*/, 26);
    Size size193 = size1;
    toolStripMenuItem108.Size = size193;
    this.ExitToolStripMenuItem.Text = "&Other Master";
    this.VendorToolStripMenuItem.Name = "VendorToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem109 = this.VendorToolStripMenuItem;
    size1 = new Size(184, 22);
    Size size194 = size1;
    toolStripMenuItem109.Size = size194;
    this.VendorToolStripMenuItem.Text = "Vendor";
    this.ServantToolStripMenuItem.Name = "ServantToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem110 = this.ServantToolStripMenuItem;
    size1 = new Size(184, 22);
    Size size195 = size1;
    toolStripMenuItem110.Size = size195;
    this.ServantToolStripMenuItem.Text = "Servant";
    this.FToolStripMenuItem.Name = "FToolStripMenuItem";
    ToolStripMenuItem ftoolStripMenuItem = this.FToolStripMenuItem;
    size1 = new Size(184, 22);
    Size size196 = size1;
    ftoolStripMenuItem.Size = size196;
    this.FToolStripMenuItem.Text = "Fixed Deposit";
    this.CommitteeMasterToolStripMenuItem.Name = "CommitteeMasterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem111 = this.CommitteeMasterToolStripMenuItem;
    size1 = new Size(184, 22);
    Size size197 = size1;
    toolStripMenuItem111.Size = size197;
    this.CommitteeMasterToolStripMenuItem.Text = "Committee Master";
    this.OtherInfoToolStripMenuItem.Name = "OtherInfoToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem112 = this.OtherInfoToolStripMenuItem;
    size1 = new Size(184, 22);
    Size size198 = size1;
    toolStripMenuItem112.Size = size198;
    this.OtherInfoToolStripMenuItem.Text = "Other Info";
    this.StatutoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[27]
    {
      (ToolStripItem) this.SocietyStatMasterToolStripMenuItem,
      (ToolStripItem) this.MasterToolStripMenuItem1,
      (ToolStripItem) this.ToolStripMenuItem9,
      (ToolStripItem) this.ToolStripSeparator13,
      (ToolStripItem) this.JRegisterToolStripMenuItem,
      (ToolStripItem) this.ShareRegisterToolStripMenuItem,
      (ToolStripItem) this.IRegisterToolStripMenuItem,
      (ToolStripItem) this.IRegisterToolStripMenuItem1,
      (ToolStripItem) this.ToolStripSeparator14,
      (ToolStripItem) this.PropertyRegisterToolStripMenuItem,
      (ToolStripItem) this.SinkingFundLedgerToolStripMenuItem,
      (ToolStripItem) this.InvestmentRegisterToolStripMenuItem,
      (ToolStripItem) this.ToolStripSeparator15,
      (ToolStripItem) this.AuditFormNo28ToolStripMenuItem,
      (ToolStripItem) this.AuditFormNo1ToolStripMenuItem,
      (ToolStripItem) this.AuditGeneralRemarkToolStripMenuItem,
      (ToolStripItem) this.AuditOFormToolStripMenuItem,
      (ToolStripItem) this.ToolStripSeparator16,
      (ToolStripItem) this.ByeLawsToolStripMenuItem,
      (ToolStripItem) this.MultiJRegisterToolStripMenuItem,
      (ToolStripItem) this.ShareRegisterMultiUpdateToolStripMenuItem,
      (ToolStripItem) this.IRegisterMulitUpdateToolStripMenuItem,
      (ToolStripItem) this.TransferFlatToolStripMenuItem,
      (ToolStripItem) this.ToolStripSeparator18,
      (ToolStripItem) this.MemberListToolStripMenuItem,
      (ToolStripItem) this.ElectionListToolStripMenuItem,
      (ToolStripItem) this.ToolStripMenuItem11
    });
    this.StatutoryToolStripMenuItem.Name = "StatutoryToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem113 = this.StatutoryToolStripMenuItem;
    size1 = new Size(72, 26);
    Size size199 = size1;
    toolStripMenuItem113.Size = size199;
    this.StatutoryToolStripMenuItem.Text = "&Statutory";
    this.SocietyStatMasterToolStripMenuItem.Name = "SocietyStatMasterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem114 = this.SocietyStatMasterToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size200 = size1;
    toolStripMenuItem114.Size = size200;
    this.SocietyStatMasterToolStripMenuItem.Text = "Society Stat Master";
    this.MasterToolStripMenuItem1.Name = "MasterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_43 = this.MasterToolStripMenuItem1;
    size1 = new Size(252, 22);
    Size size201 = size1;
    toolStripMenuItem1_43.Size = size201;
    this.MasterToolStripMenuItem1.Text = "Member Stat Master";
    this.ToolStripMenuItem9.Name = "ToolStripMenuItem9";
    ToolStripMenuItem toolStripMenuItem9_1 = this.ToolStripMenuItem9;
    size1 = new Size(252, 22);
    Size size202 = size1;
    toolStripMenuItem9_1.Size = size202;
    this.ToolStripMenuItem9.Text = "Import Master from Account";
    this.ToolStripSeparator13.Name = "ToolStripSeparator13";
    ToolStripSeparator stripSeparator13 = this.ToolStripSeparator13;
    size1 = new Size(249, 6);
    Size size203 = size1;
    stripSeparator13.Size = size203;
    this.JRegisterToolStripMenuItem.Name = "JRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem115 = this.JRegisterToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size204 = size1;
    toolStripMenuItem115.Size = size204;
    this.JRegisterToolStripMenuItem.Text = "J Register";
    this.ShareRegisterToolStripMenuItem.Name = "ShareRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem116 = this.ShareRegisterToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size205 = size1;
    toolStripMenuItem116.Size = size205;
    this.ShareRegisterToolStripMenuItem.Text = "Share Register";
    this.IRegisterToolStripMenuItem.Name = "IRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem117 = this.IRegisterToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size206 = size1;
    toolStripMenuItem117.Size = size206;
    this.IRegisterToolStripMenuItem.Text = "Nomination Register";
    this.IRegisterToolStripMenuItem1.Name = "IRegisterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_44 = this.IRegisterToolStripMenuItem1;
    size1 = new Size(252, 22);
    Size size207 = size1;
    toolStripMenuItem1_44.Size = size207;
    this.IRegisterToolStripMenuItem1.Text = "I Register";
    this.ToolStripSeparator14.Name = "ToolStripSeparator14";
    ToolStripSeparator stripSeparator14 = this.ToolStripSeparator14;
    size1 = new Size(249, 6);
    Size size208 = size1;
    stripSeparator14.Size = size208;
    this.PropertyRegisterToolStripMenuItem.Name = "PropertyRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem118 = this.PropertyRegisterToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size209 = size1;
    toolStripMenuItem118.Size = size209;
    this.PropertyRegisterToolStripMenuItem.Text = "Property Register";
    this.SinkingFundLedgerToolStripMenuItem.Name = "SinkingFundLedgerToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem119 = this.SinkingFundLedgerToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size210 = size1;
    toolStripMenuItem119.Size = size210;
    this.SinkingFundLedgerToolStripMenuItem.Text = "Sinking Fund Ledger";
    this.InvestmentRegisterToolStripMenuItem.Name = "InvestmentRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem120 = this.InvestmentRegisterToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size211 = size1;
    toolStripMenuItem120.Size = size211;
    this.InvestmentRegisterToolStripMenuItem.Text = "Investment Register";
    this.ToolStripSeparator15.Name = "ToolStripSeparator15";
    ToolStripSeparator stripSeparator15 = this.ToolStripSeparator15;
    size1 = new Size(249, 6);
    Size size212 = size1;
    stripSeparator15.Size = size212;
    this.AuditFormNo28ToolStripMenuItem.Name = "AuditFormNo28ToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem121 = this.AuditFormNo28ToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size213 = size1;
    toolStripMenuItem121.Size = size213;
    this.AuditFormNo28ToolStripMenuItem.Text = "Audit Form No.28";
    this.AuditFormNo1ToolStripMenuItem.Name = "AuditFormNo1ToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem122 = this.AuditFormNo1ToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size214 = size1;
    toolStripMenuItem122.Size = size214;
    this.AuditFormNo1ToolStripMenuItem.Text = "Audit Form No. 1";
    this.AuditGeneralRemarkToolStripMenuItem.Name = "AuditGeneralRemarkToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem123 = this.AuditGeneralRemarkToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size215 = size1;
    toolStripMenuItem123.Size = size215;
    this.AuditGeneralRemarkToolStripMenuItem.Text = "Audit General Remark";
    this.AuditOFormToolStripMenuItem.Name = "AuditOFormToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem124 = this.AuditOFormToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size216 = size1;
    toolStripMenuItem124.Size = size216;
    this.AuditOFormToolStripMenuItem.Text = "Audit Rectification \"O\" Form";
    this.ToolStripSeparator16.Name = "ToolStripSeparator16";
    ToolStripSeparator stripSeparator16 = this.ToolStripSeparator16;
    size1 = new Size(249, 6);
    Size size217 = size1;
    stripSeparator16.Size = size217;
    this.ByeLawsToolStripMenuItem.Name = "ByeLawsToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem125 = this.ByeLawsToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size218 = size1;
    toolStripMenuItem125.Size = size218;
    this.ByeLawsToolStripMenuItem.Text = "Bye Laws";
    this.MultiJRegisterToolStripMenuItem.Name = "MultiJRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem126 = this.MultiJRegisterToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size219 = size1;
    toolStripMenuItem126.Size = size219;
    this.MultiJRegisterToolStripMenuItem.Text = "J Register (Multi Update)";
    this.ShareRegisterMultiUpdateToolStripMenuItem.Name = "ShareRegisterMultiUpdateToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem127 = this.ShareRegisterMultiUpdateToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size220 = size1;
    toolStripMenuItem127.Size = size220;
    this.ShareRegisterMultiUpdateToolStripMenuItem.Text = "Share Register (Multi Update)";
    this.IRegisterMulitUpdateToolStripMenuItem.Name = "IRegisterMulitUpdateToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem128 = this.IRegisterMulitUpdateToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size221 = size1;
    toolStripMenuItem128.Size = size221;
    this.IRegisterMulitUpdateToolStripMenuItem.Text = "I Register (Mulit Update)";
    this.TransferFlatToolStripMenuItem.Name = "TransferFlatToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem129 = this.TransferFlatToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size222 = size1;
    toolStripMenuItem129.Size = size222;
    this.TransferFlatToolStripMenuItem.Text = "Transfer Flat";
    this.ToolStripSeparator18.Name = "ToolStripSeparator18";
    ToolStripSeparator stripSeparator18 = this.ToolStripSeparator18;
    size1 = new Size(249, 6);
    Size size223 = size1;
    stripSeparator18.Size = size223;
    this.MemberListToolStripMenuItem.Name = "MemberListToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem130 = this.MemberListToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size224 = size1;
    toolStripMenuItem130.Size = size224;
    this.MemberListToolStripMenuItem.Text = "Member List";
    this.ElectionListToolStripMenuItem.Name = "ElectionListToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem131 = this.ElectionListToolStripMenuItem;
    size1 = new Size(252, 22);
    Size size225 = size1;
    toolStripMenuItem131.Size = size225;
    this.ElectionListToolStripMenuItem.Text = "Election List";
    this.ToolStripMenuItem11.Name = "ToolStripMenuItem11";
    ToolStripMenuItem toolStripMenuItem11_1 = this.ToolStripMenuItem11;
    size1 = new Size(252, 22);
    Size size226 = size1;
    toolStripMenuItem11_1.Size = size226;
    this.ToolStripMenuItem11.Text = "Transfer List";
    this.CalculatorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[13]
    {
      (ToolStripItem) this.JRegisterToolStripMenuItem1,
      (ToolStripItem) this.ShareRegisterToolStripMenuItem1,
      (ToolStripItem) this.NominationRegisterToolStripMenuItem,
      (ToolStripItem) this.IRegisterToolStripMenuItem2,
      (ToolStripItem) this.PropertyRegisterToolStripMenuItem1,
      (ToolStripItem) this.InvestmentRegisterToolStripMenuItem1,
      (ToolStripItem) this.SinkingFundLedgerToolStripMenuItem1,
      (ToolStripItem) this.NominationFormToolStripMenuItem,
      (ToolStripItem) this.FlatTransferDocumentToolStripMenuItem,
      (ToolStripItem) this.ShareCertificateToolStripMenuItem,
      (ToolStripItem) this.MemberDetailFormToolStripMenuItem,
      (ToolStripItem) this.SocietyDetailFormToolStripMenuItem,
      (ToolStripItem) this.OtherFormatsToolStripMenuItem
    });
    this.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem132 = this.CalculatorToolStripMenuItem;
    size1 = new Size(154, 26);
    Size size227 = size1;
    toolStripMenuItem132.Size = size227;
    this.CalculatorToolStripMenuItem.Text = "Statutory &Blank Format";
    this.JRegisterToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.A4ToolStripMenuItem,
      (ToolStripItem) this.LegalPaperToolStripMenuItem
    });
    this.JRegisterToolStripMenuItem1.Name = "JRegisterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_45 = this.JRegisterToolStripMenuItem1;
    size1 = new Size(215, 22);
    Size size228 = size1;
    toolStripMenuItem1_45.Size = size228;
    this.JRegisterToolStripMenuItem1.Text = "J Register";
    this.A4ToolStripMenuItem.Name = "A4ToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem133 = this.A4ToolStripMenuItem;
    size1 = new Size(150, 22);
    Size size229 = size1;
    toolStripMenuItem133.Size = size229;
    this.A4ToolStripMenuItem.Text = "A4 Paper";
    this.LegalPaperToolStripMenuItem.Name = "LegalPaperToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem134 = this.LegalPaperToolStripMenuItem;
    size1 = new Size(150, 22);
    Size size230 = size1;
    toolStripMenuItem134.Size = size230;
    this.LegalPaperToolStripMenuItem.Text = "Legal Paper";
    this.ShareRegisterToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.A4PaperToolStripMenuItem,
      (ToolStripItem) this.LegalPaperToolStripMenuItem1
    });
    this.ShareRegisterToolStripMenuItem1.Name = "ShareRegisterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_46 = this.ShareRegisterToolStripMenuItem1;
    size1 = new Size(215, 22);
    Size size231 = size1;
    toolStripMenuItem1_46.Size = size231;
    this.ShareRegisterToolStripMenuItem1.Text = "Share Register";
    this.A4PaperToolStripMenuItem.Name = "A4PaperToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem135 = this.A4PaperToolStripMenuItem;
    size1 = new Size(150, 22);
    Size size232 = size1;
    toolStripMenuItem135.Size = size232;
    this.A4PaperToolStripMenuItem.Text = "A4 Paper";
    this.LegalPaperToolStripMenuItem1.Name = "LegalPaperToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_47 = this.LegalPaperToolStripMenuItem1;
    size1 = new Size(150, 22);
    Size size233 = size1;
    toolStripMenuItem1_47.Size = size233;
    this.LegalPaperToolStripMenuItem1.Text = "Legal Paper";
    this.NominationRegisterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.A4PaperToolStripMenuItem1,
      (ToolStripItem) this.LegalPaperToolStripMenuItem2
    });
    this.NominationRegisterToolStripMenuItem.Name = "NominationRegisterToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem136 = this.NominationRegisterToolStripMenuItem;
    size1 = new Size(215, 22);
    Size size234 = size1;
    toolStripMenuItem136.Size = size234;
    this.NominationRegisterToolStripMenuItem.Text = "Nomination Register";
    this.A4PaperToolStripMenuItem1.Name = "A4PaperToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_48 = this.A4PaperToolStripMenuItem1;
    size1 = new Size(150, 22);
    Size size235 = size1;
    toolStripMenuItem1_48.Size = size235;
    this.A4PaperToolStripMenuItem1.Text = "A4 Paper";
    this.LegalPaperToolStripMenuItem2.Name = "LegalPaperToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_17 = this.LegalPaperToolStripMenuItem2;
    size1 = new Size(150, 22);
    Size size236 = size1;
    toolStripMenuItem2_17.Size = size236;
    this.LegalPaperToolStripMenuItem2.Text = "Legal Paper";
    this.IRegisterToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.A4PaperToolStripMenuItem2,
      (ToolStripItem) this.LegalPaperToolStripMenuItem3
    });
    this.IRegisterToolStripMenuItem2.Name = "IRegisterToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_18 = this.IRegisterToolStripMenuItem2;
    size1 = new Size(215, 22);
    Size size237 = size1;
    toolStripMenuItem2_18.Size = size237;
    this.IRegisterToolStripMenuItem2.Text = "I Register";
    this.A4PaperToolStripMenuItem2.Name = "A4PaperToolStripMenuItem2";
    ToolStripMenuItem toolStripMenuItem2_19 = this.A4PaperToolStripMenuItem2;
    size1 = new Size(150, 22);
    Size size238 = size1;
    toolStripMenuItem2_19.Size = size238;
    this.A4PaperToolStripMenuItem2.Text = "A4 Paper";
    this.LegalPaperToolStripMenuItem3.Name = "LegalPaperToolStripMenuItem3";
    ToolStripMenuItem toolStripMenuItem3_5 = this.LegalPaperToolStripMenuItem3;
    size1 = new Size(150, 22);
    Size size239 = size1;
    toolStripMenuItem3_5.Size = size239;
    this.LegalPaperToolStripMenuItem3.Text = "Legal Paper";
    this.PropertyRegisterToolStripMenuItem1.Name = "PropertyRegisterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_49 = this.PropertyRegisterToolStripMenuItem1;
    size1 = new Size(215, 22);
    Size size240 = size1;
    toolStripMenuItem1_49.Size = size240;
    this.PropertyRegisterToolStripMenuItem1.Text = "Property Register";
    this.InvestmentRegisterToolStripMenuItem1.Name = "InvestmentRegisterToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_50 = this.InvestmentRegisterToolStripMenuItem1;
    size1 = new Size(215, 22);
    Size size241 = size1;
    toolStripMenuItem1_50.Size = size241;
    this.InvestmentRegisterToolStripMenuItem1.Text = "Investment Register";
    this.SinkingFundLedgerToolStripMenuItem1.Name = "SinkingFundLedgerToolStripMenuItem1";
    ToolStripMenuItem toolStripMenuItem1_51 = this.SinkingFundLedgerToolStripMenuItem1;
    size1 = new Size(215, 22);
    Size size242 = size1;
    toolStripMenuItem1_51.Size = size242;
    this.SinkingFundLedgerToolStripMenuItem1.Text = "Sinking Fund Ledger";
    this.NominationFormToolStripMenuItem.Name = "NominationFormToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem137 = this.NominationFormToolStripMenuItem;
    size1 = new Size(215, 22);
    Size size243 = size1;
    toolStripMenuItem137.Size = size243;
    this.NominationFormToolStripMenuItem.Text = "Nomination Form";
    this.FlatTransferDocumentToolStripMenuItem.Name = "FlatTransferDocumentToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem138 = this.FlatTransferDocumentToolStripMenuItem;
    size1 = new Size(215, 22);
    Size size244 = size1;
    toolStripMenuItem138.Size = size244;
    this.FlatTransferDocumentToolStripMenuItem.Text = "Flat Transfer Document";
    this.ShareCertificateToolStripMenuItem.Name = "ShareCertificateToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem139 = this.ShareCertificateToolStripMenuItem;
    size1 = new Size(215, 22);
    Size size245 = size1;
    toolStripMenuItem139.Size = size245;
    this.ShareCertificateToolStripMenuItem.Text = "Share Certificate";
    this.MemberDetailFormToolStripMenuItem.Name = "MemberDetailFormToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem140 = this.MemberDetailFormToolStripMenuItem;
    size1 = new Size(215, 22);
    Size size246 = size1;
    toolStripMenuItem140.Size = size246;
    this.MemberDetailFormToolStripMenuItem.Text = "Member Detail Form";
    this.SocietyDetailFormToolStripMenuItem.Name = "SocietyDetailFormToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem141 = this.SocietyDetailFormToolStripMenuItem;
    size1 = new Size(215, 22);
    Size size247 = size1;
    toolStripMenuItem141.Size = size247;
    this.SocietyDetailFormToolStripMenuItem.Text = "Society Detail Form";
    this.OtherFormatsToolStripMenuItem.Name = "OtherFormatsToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem142 = this.OtherFormatsToolStripMenuItem;
    size1 = new Size(215, 22);
    Size size248 = size1;
    toolStripMenuItem142.Size = size248;
    this.OtherFormatsToolStripMenuItem.Text = "Other Formats";
    this.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem";
    ToolStripMenuItem toolStripMenuItem143 = this.AboutUsToolStripMenuItem;
    size1 = new Size(116, 26);
    Size size249 = size1;
    toolStripMenuItem143.Size = size249;
    this.AboutUsToolStripMenuItem.Text = "Registration Info";
    this.TS.Font = new System.Drawing.Font("Verdana", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TS.Items.AddRange(new ToolStripItem[26]
    {
      (ToolStripItem) this.ToolStripButton14,
      (ToolStripItem) this.ToolStripButton11,
      (ToolStripItem) this.ToolStripButton1,
      (ToolStripItem) this.ToolStripSeparator17,
      (ToolStripItem) this.ToolStripButton7,
      (ToolStripItem) this.ToolStripButton5,
      (ToolStripItem) this.ToolStripButton4,
      (ToolStripItem) this.ToolStripButton8,
      (ToolStripItem) this.ToolStripButton2,
      (ToolStripItem) this.ToolStripSeparator5,
      (ToolStripItem) this.ToolStripButton10,
      (ToolStripItem) this.ToolStripButton9,
      (ToolStripItem) this.ToolStripButton6,
      (ToolStripItem) this.ToolStripButton3,
      (ToolStripItem) this.ToolStripSeparator6,
      (ToolStripItem) this.ToolStripButton19,
      (ToolStripItem) this.ToolStripButton13,
      (ToolStripItem) this.ToolStripButton15,
      (ToolStripItem) this.ToolStripButton16,
      (ToolStripItem) this.ToolStripButton17,
      (ToolStripItem) this.ToolStripSeparator7,
      (ToolStripItem) this.ToolStripButton18,
      (ToolStripItem) this.ToolStripButton12,
      (ToolStripItem) this.ToolStripSeparator21,
      (ToolStripItem) this.ToolStripButton20,
      (ToolStripItem) this.ToolStripButton22
    });
    ToolStrip ts1 = this.TS;
    point1 = new System.Drawing.Point(0, 30);
    System.Drawing.Point point3 = point1;
    ts1.Location = point3;
    this.TS.Name = "TS";
    this.TS.ShowItemToolTips = false;
    ToolStrip ts2 = this.TS;
    size1 = new Size(1165, 37);
    Size size250 = size1;
    ts2.Size = size250;
    this.TS.TabIndex = 9;
    this.TS.Text = "ToolStrip2";
    this.ToolStripButton14.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton14.Image = (Image) componentResourceManager.GetObject("ToolStripButton14.Image");
    this.ToolStripButton14.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton14.Name = "ToolStripButton14";
    ToolStripButton toolStripButton14 = this.ToolStripButton14;
    size1 = new Size(54, 34);
    Size size251 = size1;
    toolStripButton14.Size = size251;
    this.ToolStripButton14.Text = " Group ";
    this.ToolStripButton14.TextDirection = ToolStripTextDirection.Horizontal;
    this.ToolStripButton14.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton11.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton11.Image = (Image) componentResourceManager.GetObject("ToolStripButton11.Image");
    this.ToolStripButton11.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton11.Name = "ToolStripButton11";
    ToolStripButton toolStripButton11 = this.ToolStripButton11;
    size1 = new Size(56, 34);
    Size size252 = size1;
    toolStripButton11.Size = size252;
    this.ToolStripButton11.Text = "Account";
    this.ToolStripButton11.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton1.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton1.Image = (Image) componentResourceManager.GetObject("ToolStripButton1.Image");
    this.ToolStripButton1.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton1.Name = "ToolStripButton1";
    ToolStripButton toolStripButton1 = this.ToolStripButton1;
    size1 = new Size(57, 34);
    Size size253 = size1;
    toolStripButton1.Size = size253;
    this.ToolStripButton1.Text = "Member";
    this.ToolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripSeparator17.Name = "ToolStripSeparator17";
    ToolStripSeparator stripSeparator17 = this.ToolStripSeparator17;
    size1 = new Size(6, 37);
    Size size254 = size1;
    stripSeparator17.Size = size254;
    this.ToolStripButton7.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton7.Image = (Image) componentResourceManager.GetObject("ToolStripButton7.Image");
    this.ToolStripButton7.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton7.Name = "ToolStripButton7";
    ToolStripButton toolStripButton7 = this.ToolStripButton7;
    size1 = new Size(67, 34);
    Size size255 = size1;
    toolStripButton7.Size = size255;
    this.ToolStripButton7.Text = "Mem.Rcpt";
    this.ToolStripButton7.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton5.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton5.Image = (Image) componentResourceManager.GetObject("ToolStripButton5.Image");
    this.ToolStripButton5.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton5.Name = "ToolStripButton5";
    ToolStripButton toolStripButton5 = this.ToolStripButton5;
    size1 = new Size(61, 34);
    Size size256 = size1;
    toolStripButton5.Size = size256;
    this.ToolStripButton5.Text = "Payment";
    this.ToolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton4.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton4.Image = (Image) componentResourceManager.GetObject("ToolStripButton4.Image");
    this.ToolStripButton4.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton4.Name = "ToolStripButton4";
    ToolStripButton toolStripButton4 = this.ToolStripButton4;
    size1 = new Size(53, 34);
    Size size257 = size1;
    toolStripButton4.Size = size257;
    this.ToolStripButton4.Text = "Receipt";
    this.ToolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton8.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton8.Image = (Image) componentResourceManager.GetObject("ToolStripButton8.Image");
    this.ToolStripButton8.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton8.Name = "ToolStripButton8";
    ToolStripButton toolStripButton8 = this.ToolStripButton8;
    size1 = new Size(50, 34);
    Size size258 = size1;
    toolStripButton8.Size = size258;
    this.ToolStripButton8.Text = "Contra";
    this.ToolStripButton8.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton2.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton2.Image = (Image) componentResourceManager.GetObject("ToolStripButton2.Image");
    this.ToolStripButton2.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton2.Name = "ToolStripButton2";
    ToolStripButton toolStripButton2 = this.ToolStripButton2;
    size1 = new Size(72, 34);
    Size size259 = size1;
    toolStripButton2.Size = size259;
    this.ToolStripButton2.Text = "Bank Reco";
    this.ToolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripSeparator5.Name = "ToolStripSeparator5";
    ToolStripSeparator toolStripSeparator5 = this.ToolStripSeparator5;
    size1 = new Size(6, 37);
    Size size260 = size1;
    toolStripSeparator5.Size = size260;
    this.ToolStripButton10.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton10.Image = (Image) componentResourceManager.GetObject("ToolStripButton10.Image");
    this.ToolStripButton10.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton10.Name = "ToolStripButton10";
    ToolStripButton toolStripButton10 = this.ToolStripButton10;
    size1 = new Size(63 /*0x3F*/, 34);
    Size size261 = size1;
    toolStripButton10.Size = size261;
    this.ToolStripButton10.Text = "Mem. Bill";
    this.ToolStripButton10.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton9.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton9.Image = (Image) componentResourceManager.GetObject("ToolStripButton9.Image");
    this.ToolStripButton9.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton9.Name = "ToolStripButton9";
    ToolStripButton toolStripButton9 = this.ToolStripButton9;
    size1 = new Size(67, 34);
    Size size262 = size1;
    toolStripButton9.Size = size262;
    this.ToolStripButton9.Text = "Mem.Rcpt";
    this.ToolStripButton9.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton6.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton6.Image = (Image) componentResourceManager.GetObject("ToolStripButton6.Image");
    this.ToolStripButton6.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton6.Name = "ToolStripButton6";
    ToolStripButton toolStripButton6 = this.ToolStripButton6;
    size1 = new Size(62, 34);
    Size size263 = size1;
    toolStripButton6.Size = size263;
    this.ToolStripButton6.Text = "Mem.O/s";
    this.ToolStripButton6.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton3.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton3.Image = (Image) componentResourceManager.GetObject("ToolStripButton3.Image");
    this.ToolStripButton3.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton3.Name = "ToolStripButton3";
    ToolStripButton toolStripButton3 = this.ToolStripButton3;
    size1 = new Size(65, 34);
    Size size264 = size1;
    toolStripButton3.Size = size264;
    this.ToolStripButton3.Text = "Mem A/c.";
    this.ToolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripSeparator6.Name = "ToolStripSeparator6";
    ToolStripSeparator toolStripSeparator6 = this.ToolStripSeparator6;
    size1 = new Size(6, 37);
    Size size265 = size1;
    toolStripSeparator6.Size = size265;
    this.ToolStripButton19.Image = (Image) componentResourceManager.GetObject("ToolStripButton19.Image");
    this.ToolStripButton19.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton19.Name = "ToolStripButton19";
    ToolStripButton toolStripButton19 = this.ToolStripButton19;
    size1 = new Size(79, 34);
    Size size266 = size1;
    toolStripButton19.Size = size266;
    this.ToolStripButton19.Text = "Cash/Bank";
    this.ToolStripButton19.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton13.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton13.Image = (Image) componentResourceManager.GetObject("ToolStripButton13.Image");
    this.ToolStripButton13.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton13.Name = "ToolStripButton13";
    ToolStripButton toolStripButton13 = this.ToolStripButton13;
    size1 = new Size(50, 34);
    Size size267 = size1;
    toolStripButton13.Size = size267;
    this.ToolStripButton13.Text = "Ledger";
    this.ToolStripButton13.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton13.ToolTipText = "Ctrl + L";
    this.ToolStripButton15.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton15.Image = (Image) componentResourceManager.GetObject("ToolStripButton15.Image");
    this.ToolStripButton15.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton15.Name = "ToolStripButton15";
    ToolStripButton toolStripButton15 = this.ToolStripButton15;
    size1 = new Size(61, 34);
    Size size268 = size1;
    toolStripButton15.Size = size268;
    this.ToolStripButton15.Text = "Trial Bal.";
    this.ToolStripButton15.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton15.ToolTipText = "Ctrl + T";
    this.ToolStripButton16.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton16.Image = (Image) componentResourceManager.GetObject("ToolStripButton16.Image");
    this.ToolStripButton16.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton16.Name = "ToolStripButton16";
    ToolStripButton toolStripButton16 = this.ToolStripButton16;
    size1 = new Size(39, 34);
    Size size269 = size1;
    toolStripButton16.Size = size269;
    this.ToolStripButton16.Text = "I && E";
    this.ToolStripButton16.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton17.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton17.Image = (Image) componentResourceManager.GetObject("ToolStripButton17.Image");
    this.ToolStripButton17.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton17.Name = "ToolStripButton17";
    ToolStripButton toolStripButton17 = this.ToolStripButton17;
    size1 = new Size(56, 34);
    Size size270 = size1;
    toolStripButton17.Size = size270;
    this.ToolStripButton17.Text = "B.Sheet";
    this.ToolStripButton17.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripSeparator7.Name = "ToolStripSeparator7";
    ToolStripSeparator toolStripSeparator7 = this.ToolStripSeparator7;
    size1 = new Size(6, 37);
    Size size271 = size1;
    toolStripSeparator7.Size = size271;
    this.ToolStripButton18.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton18.Image = (Image) componentResourceManager.GetObject("ToolStripButton18.Image");
    this.ToolStripButton18.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton18.Name = "ToolStripButton18";
    ToolStripButton toolStripButton18 = this.ToolStripButton18;
    size1 = new Size(75, 34);
    Size size272 = size1;
    toolStripButton18.Size = size272;
    this.ToolStripButton18.Text = "Data Sheet";
    this.ToolStripButton18.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton12.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton12.Image = (Image) componentResourceManager.GetObject("ToolStripButton12.Image");
    this.ToolStripButton12.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton12.Name = "ToolStripButton12";
    ToolStripButton toolStripButton12 = this.ToolStripButton12;
    size1 = new Size(78, 33);
    Size size273 = size1;
    toolStripButton12.Size = size273;
    this.ToolStripButton12.Text = "Cheque List";
    this.ToolStripButton12.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripSeparator21.Name = "ToolStripSeparator21";
    ToolStripSeparator stripSeparator21 = this.ToolStripSeparator21;
    size1 = new Size(6, 6);
    Size size274 = size1;
    stripSeparator21.Size = size274;
    this.ToolStripButton20.Font = new System.Drawing.Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ToolStripButton20.Image = (Image) componentResourceManager.GetObject("ToolStripButton20.Image");
    this.ToolStripButton20.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton20.Name = "ToolStripButton20";
    ToolStripButton toolStripButton20 = this.ToolStripButton20;
    size1 = new Size(75, 33);
    Size size275 = size1;
    toolStripButton20.Size = size275;
    this.ToolStripButton20.Text = "Select Year";
    this.ToolStripButton20.TextImageRelation = TextImageRelation.ImageAboveText;
    this.ToolStripButton20.ToolTipText = "Select Year";
    this.ToolStripButton22.Image = (Image) componentResourceManager.GetObject("ToolStripButton22.Image");
    this.ToolStripButton22.ImageTransparentColor = Color.Magenta;
    this.ToolStripButton22.Name = "ToolStripButton22";
    ToolStripButton toolStripButton22 = this.ToolStripButton22;
    size1 = new Size(80 /*0x50*/, 34);
    Size size276 = size1;
    toolStripButton22.Size = size276;
    this.ToolStripButton22.Text = "Mem.Detail";
    this.ToolStripButton22.TextImageRelation = TextImageRelation.ImageAboveText;
    this.StatusStrip1.Items.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.lblTS1,
      (ToolStripItem) this.ToolStripSplitButton1
    });
    StatusStrip statusStrip1_1 = this.StatusStrip1;
    point1 = new System.Drawing.Point(0, 444);
    System.Drawing.Point point4 = point1;
    statusStrip1_1.Location = point4;
    this.StatusStrip1.Name = "StatusStrip1";
    StatusStrip statusStrip1_2 = this.StatusStrip1;
    size1 = new Size(1165, 22);
    Size size277 = size1;
    statusStrip1_2.Size = size277;
    this.StatusStrip1.TabIndex = 11;
    this.StatusStrip1.Text = "StatusStrip1";
    this.lblTS1.BackColor = SystemColors.Control;
    this.lblTS1.Name = "lblTS1";
    ToolStripStatusLabel lblTs1 = this.lblTS1;
    size1 = new Size(396, 17);
    Size size278 = size1;
    lblTs1.Size = size278;
    this.lblTS1.Text = "MAULI SOFTWARE - 9869045370 / 9969507742                     Version : 2025.26";
    this.ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
    this.ToolStripSplitButton1.Image = (Image) componentResourceManager.GetObject("ToolStripSplitButton1.Image");
    this.ToolStripSplitButton1.ImageTransparentColor = Color.Magenta;
    this.ToolStripSplitButton1.Name = "ToolStripSplitButton1";
    ToolStripSplitButton stripSplitButton1 = this.ToolStripSplitButton1;
    size1 = new Size(32 /*0x20*/, 20);
    Size size279 = size1;
    stripSplitButton1.Size = size279;
    this.ToolStripSplitButton1.Text = "ToolStripSplitButton1";
    this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView1_1 = this.DataGridView1;
    point1 = new System.Drawing.Point(652, 116);
    System.Drawing.Point point5 = point1;
    dataGridView1_1.Location = point5;
    this.DataGridView1.Name = "DataGridView1";
    DataGridView dataGridView1_2 = this.DataGridView1;
    size1 = new Size(230, 277);
    Size size280 = size1;
    dataGridView1_2.Size = size280;
    this.DataGridView1.TabIndex = 13;
    this.DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView3_1 = this.DataGridView3;
    point1 = new System.Drawing.Point(400, 116);
    System.Drawing.Point point6 = point1;
    dataGridView3_1.Location = point6;
    this.DataGridView3.Name = "DataGridView3";
    DataGridView dataGridView3_2 = this.DataGridView3;
    size1 = new Size(236, 280);
    Size size281 = size1;
    dataGridView3_2.Size = size281;
    this.DataGridView3.TabIndex = 15;
    this.DataGridView3.Visible = false;
    this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    DataGridView dataGridView2_1 = this.DataGridView2;
    point1 = new System.Drawing.Point(142, 115);
    System.Drawing.Point point7 = point1;
    dataGridView2_1.Location = point7;
    this.DataGridView2.Name = "DataGridView2";
    DataGridView dataGridView2_2 = this.DataGridView2;
    size1 = new Size(236, 280);
    Size size282 = size1;
    dataGridView2_2.Size = size282;
    this.DataGridView2.TabIndex = 17;
    this.DataGridView2.Visible = false;
    this.ToolStripButton21.Name = "ToolStripButton21";
    ToolStripButton toolStripButton21 = this.ToolStripButton21;
    size1 = new Size(23, 23);
    Size size283 = size1;
    toolStripButton21.Size = size283;
    this.ToolStripButton24.Name = "ToolStripButton24";
    ToolStripButton toolStripButton24 = this.ToolStripButton24;
    size1 = new Size(23, 23);
    Size size284 = size1;
    toolStripButton24.Size = size284;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackgroundImageLayout = ImageLayout.Stretch;
    size1 = new Size(1165, 466);
    this.ClientSize = size1;
    this.Controls.Add((Control) this.DataGridView2);
    this.Controls.Add((Control) this.DataGridView3);
    this.Controls.Add((Control) this.DataGridView1);
    this.Controls.Add((Control) this.StatusStrip1);
    this.Controls.Add((Control) this.TS);
    this.Controls.Add((Control) this.MS);
    this.DoubleBuffered = true;
    this.Icon = (System.Drawing.Icon) componentResourceManager.GetObject("$this.Icon");
    this.IsMdiContainer = true;
    this.KeyPreview = true;
    this.Name = nameof (frmMenu);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.WindowState = FormWindowState.Maximized;
    this.MS.ResumeLayout(false);
    this.MS.PerformLayout();
    this.TS.ResumeLayout(false);
    this.TS.PerformLayout();
    this.StatusStrip1.ResumeLayout(false);
    this.StatusStrip1.PerformLayout();
    ((ISupportInitialize) this.DataGridView1).EndInit();
    ((ISupportInitialize) this.DataGridView3).EndInit();
    ((ISupportInitialize) this.DataGridView2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual ToolTip ToolTip
  {
    [DebuggerNonUserCode] get => this._ToolTip;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolTip = value;
  }

  internal virtual MenuStrip MS
  {
    [DebuggerNonUserCode] get => this._MS;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MS = value;
  }

  internal virtual ToolStripMenuItem MasterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MasterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._MasterToolStripMenuItem = value;
    }
  }

  internal virtual ToolStripMenuItem GroupToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._GroupToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GroupToolStripMenuItem_Click);
      if (this._GroupToolStripMenuItem != null)
        this._GroupToolStripMenuItem.Click -= eventHandler;
      this._GroupToolStripMenuItem = value;
      if (this._GroupToolStripMenuItem == null)
        return;
      this._GroupToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem AccountToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._AccountToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AccountToolStripMenuItem_Click);
      if (this._AccountToolStripMenuItem != null)
        this._AccountToolStripMenuItem.Click -= eventHandler;
      this._AccountToolStripMenuItem = value;
      if (this._AccountToolStripMenuItem == null)
        return;
      this._AccountToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem TransactionToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._TransactionToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._TransactionToolStripMenuItem = value;
    }
  }

  internal virtual ToolStripMenuItem UtilityToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._UtilityToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._UtilityToolStripMenuItem = value;
    }
  }

  internal virtual ToolStripMenuItem ExitToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ExitToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ExitToolStripMenuItem_Click);
      if (this._ExitToolStripMenuItem != null)
        this._ExitToolStripMenuItem.Click -= eventHandler;
      this._ExitToolStripMenuItem = value;
      if (this._ExitToolStripMenuItem == null)
        return;
      this._ExitToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MemberToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberToolStripMenuItem_Click);
      if (this._MemberToolStripMenuItem != null)
        this._MemberToolStripMenuItem.Click -= eventHandler;
      this._MemberToolStripMenuItem = value;
      if (this._MemberToolStripMenuItem == null)
        return;
      this._MemberToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberBillingToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MemberBillingToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberBillingToolStripMenuItem_Click);
      if (this._MemberBillingToolStripMenuItem != null)
        this._MemberBillingToolStripMenuItem.Click -= eventHandler;
      this._MemberBillingToolStripMenuItem = value;
      if (this._MemberBillingToolStripMenuItem == null)
        return;
      this._MemberBillingToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem PaymentToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._PaymentToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PaymentToolStripMenuItem_Click);
      if (this._PaymentToolStripMenuItem != null)
        this._PaymentToolStripMenuItem.Click -= eventHandler;
      this._PaymentToolStripMenuItem = value;
      if (this._PaymentToolStripMenuItem == null)
        return;
      this._PaymentToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberReceiptToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MemberReceiptToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberReceiptToolStripMenuItem_Click);
      if (this._MemberReceiptToolStripMenuItem != null)
        this._MemberReceiptToolStripMenuItem.Click -= eventHandler;
      this._MemberReceiptToolStripMenuItem = value;
      if (this._MemberReceiptToolStripMenuItem == null)
        return;
      this._MemberReceiptToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberBillToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MemberBillToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberBillToolStripMenuItem_Click);
      if (this._MemberBillToolStripMenuItem != null)
        this._MemberBillToolStripMenuItem.Click -= eventHandler;
      this._MemberBillToolStripMenuItem = value;
      if (this._MemberBillToolStripMenuItem == null)
        return;
      this._MemberBillToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ReceiptToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptToolStripMenuItem_Click);
      if (this._ReceiptToolStripMenuItem != null)
        this._ReceiptToolStripMenuItem.Click -= eventHandler;
      this._ReceiptToolStripMenuItem = value;
      if (this._ReceiptToolStripMenuItem == null)
        return;
      this._ReceiptToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem JournalToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._JournalToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.JournalToolStripMenuItem_Click);
      if (this._JournalToolStripMenuItem != null)
        this._JournalToolStripMenuItem.Click -= eventHandler;
      this._JournalToolStripMenuItem = value;
      if (this._JournalToolStripMenuItem == null)
        return;
      this._JournalToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem SocietyToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._SocietyToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SocietyToolStripMenuItem_Click);
      if (this._SocietyToolStripMenuItem != null)
        this._SocietyToolStripMenuItem.Click -= eventHandler;
      this._SocietyToolStripMenuItem = value;
      if (this._SocietyToolStripMenuItem == null)
        return;
      this._SocietyToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ContraToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._ContraToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ContraToolStripMenuItem1_Click);
      if (this._ContraToolStripMenuItem1 != null)
        this._ContraToolStripMenuItem1.Click -= eventHandler;
      this._ContraToolStripMenuItem1 = value;
      if (this._ContraToolStripMenuItem1 == null)
        return;
      this._ContraToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem OpeningBankRecoToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._OpeningBankRecoToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OpeningBankRecoToolStripMenuItem_Click);
      if (this._OpeningBankRecoToolStripMenuItem != null)
        this._OpeningBankRecoToolStripMenuItem.Click -= eventHandler;
      this._OpeningBankRecoToolStripMenuItem = value;
      if (this._OpeningBankRecoToolStripMenuItem == null)
        return;
      this._OpeningBankRecoToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem RenumberToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._RenumberToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RenumberToolStripMenuItem_Click);
      if (this._RenumberToolStripMenuItem != null)
        this._RenumberToolStripMenuItem.Click -= eventHandler;
      this._RenumberToolStripMenuItem = value;
      if (this._RenumberToolStripMenuItem == null)
        return;
      this._RenumberToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberAdjustmentToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._MemberAdjustmentToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberAdjustmentToolStripMenuItem1_Click);
      if (this._MemberAdjustmentToolStripMenuItem1 != null)
        this._MemberAdjustmentToolStripMenuItem1.Click -= eventHandler;
      this._MemberAdjustmentToolStripMenuItem1 = value;
      if (this._MemberAdjustmentToolStripMenuItem1 == null)
        return;
      this._MemberAdjustmentToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberDebitNoteToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._MemberDebitNoteToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberDebitNoteToolStripMenuItem1_Click);
      if (this._MemberDebitNoteToolStripMenuItem1 != null)
        this._MemberDebitNoteToolStripMenuItem1.Click -= eventHandler;
      this._MemberDebitNoteToolStripMenuItem1 = value;
      if (this._MemberDebitNoteToolStripMenuItem1 == null)
        return;
      this._MemberDebitNoteToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberCreditNoteToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._MemberCreditNoteToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberCreditNoteToolStripMenuItem1_Click);
      if (this._MemberCreditNoteToolStripMenuItem1 != null)
        this._MemberCreditNoteToolStripMenuItem1.Click -= eventHandler;
      this._MemberCreditNoteToolStripMenuItem1 = value;
      if (this._MemberCreditNoteToolStripMenuItem1 == null)
        return;
      this._MemberCreditNoteToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BankRecoToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._BankRecoToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BankRecoToolStripMenuItem_Click);
      if (this._BankRecoToolStripMenuItem != null)
        this._BankRecoToolStripMenuItem.Click -= eventHandler;
      this._BankRecoToolStripMenuItem = value;
      if (this._BankRecoToolStripMenuItem == null)
        return;
      this._BankRecoToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem TranferToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._TranferToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TranferToolStripMenuItem_Click);
      if (this._TranferToolStripMenuItem != null)
        this._TranferToolStripMenuItem.Click -= eventHandler;
      this._TranferToolStripMenuItem = value;
      if (this._TranferToolStripMenuItem == null)
        return;
      this._TranferToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator2
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator2 = value;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator3
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator3 = value;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem2_Click);
      if (this._ToolStripMenuItem2 != null)
        this._ToolStripMenuItem2.Click -= eventHandler;
      this._ToolStripMenuItem2 = value;
      if (this._ToolStripMenuItem2 == null)
        return;
      this._ToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem3
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripMenuItem3 = value;
    }
  }

  internal virtual ToolStripMenuItem MemberAccountToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MemberAccountToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberAccountToolStripMenuItem_Click);
      if (this._MemberAccountToolStripMenuItem != null)
        this._MemberAccountToolStripMenuItem.Click -= eventHandler;
      this._MemberAccountToolStripMenuItem = value;
      if (this._MemberAccountToolStripMenuItem == null)
        return;
      this._MemberAccountToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem OutstandingListToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._OutstandingListToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OutstandingListToolStripMenuItem_Click);
      if (this._OutstandingListToolStripMenuItem != null)
        this._OutstandingListToolStripMenuItem.Click -= eventHandler;
      this._OutstandingListToolStripMenuItem = value;
      if (this._OutstandingListToolStripMenuItem == null)
        return;
      this._OutstandingListToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem TrialBalanceToolStripMenuItem3
  {
    [DebuggerNonUserCode] get => this._TrialBalanceToolStripMenuItem3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TrialBalanceToolStripMenuItem3_Click);
      if (this._TrialBalanceToolStripMenuItem3 != null)
        this._TrialBalanceToolStripMenuItem3.Click -= eventHandler;
      this._TrialBalanceToolStripMenuItem3 = value;
      if (this._TrialBalanceToolStripMenuItem3 == null)
        return;
      this._TrialBalanceToolStripMenuItem3.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptPaymentAcToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._ReceiptPaymentAcToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptPaymentAcToolStripMenuItem1_Click);
      if (this._ReceiptPaymentAcToolStripMenuItem1 != null)
        this._ReceiptPaymentAcToolStripMenuItem1.Click -= eventHandler;
      this._ReceiptPaymentAcToolStripMenuItem1 = value;
      if (this._ReceiptPaymentAcToolStripMenuItem1 == null)
        return;
      this._ReceiptPaymentAcToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem IncomeExpenditureAcToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._IncomeExpenditureAcToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.IncomeExpenditureAcToolStripMenuItem_Click);
      if (this._IncomeExpenditureAcToolStripMenuItem != null)
        this._IncomeExpenditureAcToolStripMenuItem.Click -= eventHandler;
      this._IncomeExpenditureAcToolStripMenuItem = value;
      if (this._IncomeExpenditureAcToolStripMenuItem == null)
        return;
      this._IncomeExpenditureAcToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BalanceSheetToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._BalanceSheetToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BalanceSheetToolStripMenuItem2_Click);
      if (this._BalanceSheetToolStripMenuItem2 != null)
        this._BalanceSheetToolStripMenuItem2.Click -= eventHandler;
      this._BalanceSheetToolStripMenuItem2 = value;
      if (this._BalanceSheetToolStripMenuItem2 == null)
        return;
      this._BalanceSheetToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BillToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._BillToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BillToolStripMenuItem1_Click);
      if (this._BillToolStripMenuItem1 != null)
        this._BillToolStripMenuItem1.Click -= eventHandler;
      this._BillToolStripMenuItem1 = value;
      if (this._BillToolStripMenuItem1 == null)
        return;
      this._BillToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptToolStripMenuItem3
  {
    [DebuggerNonUserCode] get => this._ReceiptToolStripMenuItem3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptToolStripMenuItem3_Click);
      if (this._ReceiptToolStripMenuItem3 != null)
        this._ReceiptToolStripMenuItem3.Click -= eventHandler;
      this._ReceiptToolStripMenuItem3 = value;
      if (this._ReceiptToolStripMenuItem3 == null)
        return;
      this._ReceiptToolStripMenuItem3.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem DebitNoteToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._DebitNoteToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DebitNoteToolStripMenuItem_Click);
      if (this._DebitNoteToolStripMenuItem != null)
        this._DebitNoteToolStripMenuItem.Click -= eventHandler;
      this._DebitNoteToolStripMenuItem = value;
      if (this._DebitNoteToolStripMenuItem == null)
        return;
      this._DebitNoteToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem CreditNoteToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._CreditNoteToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CreditNoteToolStripMenuItem_Click);
      if (this._CreditNoteToolStripMenuItem != null)
        this._CreditNoteToolStripMenuItem.Click -= eventHandler;
      this._CreditNoteToolStripMenuItem = value;
      if (this._CreditNoteToolStripMenuItem == null)
        return;
      this._CreditNoteToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem5
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripMenuItem5 = value;
    }
  }

  internal virtual ToolStripMenuItem ReceiptVoucherToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._ReceiptVoucherToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptVoucherToolStripMenuItem1_Click);
      if (this._ReceiptVoucherToolStripMenuItem1 != null)
        this._ReceiptVoucherToolStripMenuItem1.Click -= eventHandler;
      this._ReceiptVoucherToolStripMenuItem1 = value;
      if (this._ReceiptVoucherToolStripMenuItem1 == null)
        return;
      this._ReceiptVoucherToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem PaymentVoucherToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._PaymentVoucherToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PaymentVoucherToolStripMenuItem1_Click);
      if (this._PaymentVoucherToolStripMenuItem1 != null)
        this._PaymentVoucherToolStripMenuItem1.Click -= eventHandler;
      this._PaymentVoucherToolStripMenuItem1 = value;
      if (this._PaymentVoucherToolStripMenuItem1 == null)
        return;
      this._PaymentVoucherToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ContraVoucherToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._ContraVoucherToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ContraVoucherToolStripMenuItem1_Click);
      if (this._ContraVoucherToolStripMenuItem1 != null)
        this._ContraVoucherToolStripMenuItem1.Click -= eventHandler;
      this._ContraVoucherToolStripMenuItem1 = value;
      if (this._ContraVoucherToolStripMenuItem1 == null)
        return;
      this._ContraVoucherToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStrip TS
  {
    [DebuggerNonUserCode] get => this._TS;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TS = value;
  }

  internal virtual ToolStripButton ToolStripButton1
  {
    [DebuggerNonUserCode] get => this._ToolStripButton1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton1_Click);
      if (this._ToolStripButton1 != null)
        this._ToolStripButton1.Click -= eventHandler;
      this._ToolStripButton1 = value;
      if (this._ToolStripButton1 == null)
        return;
      this._ToolStripButton1.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator17
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator17 = value;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator5
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator5 = value;
    }
  }

  internal virtual ToolStripButton ToolStripButton7
  {
    [DebuggerNonUserCode] get => this._ToolStripButton7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton7_Click);
      if (this._ToolStripButton7 != null)
        this._ToolStripButton7.Click -= eventHandler;
      this._ToolStripButton7 = value;
      if (this._ToolStripButton7 == null)
        return;
      this._ToolStripButton7.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton5
  {
    [DebuggerNonUserCode] get => this._ToolStripButton5;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton5_Click);
      if (this._ToolStripButton5 != null)
        this._ToolStripButton5.Click -= eventHandler;
      this._ToolStripButton5 = value;
      if (this._ToolStripButton5 == null)
        return;
      this._ToolStripButton5.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton4
  {
    [DebuggerNonUserCode] get => this._ToolStripButton4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton4_Click);
      if (this._ToolStripButton4 != null)
        this._ToolStripButton4.Click -= eventHandler;
      this._ToolStripButton4 = value;
      if (this._ToolStripButton4 == null)
        return;
      this._ToolStripButton4.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton8
  {
    [DebuggerNonUserCode] get => this._ToolStripButton8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton8_Click);
      if (this._ToolStripButton8 != null)
        this._ToolStripButton8.Click -= eventHandler;
      this._ToolStripButton8 = value;
      if (this._ToolStripButton8 == null)
        return;
      this._ToolStripButton8.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton14
  {
    [DebuggerNonUserCode] get => this._ToolStripButton14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton14_Click);
      if (this._ToolStripButton14 != null)
        this._ToolStripButton14.Click -= eventHandler;
      this._ToolStripButton14 = value;
      if (this._ToolStripButton14 == null)
        return;
      this._ToolStripButton14.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton11
  {
    [DebuggerNonUserCode] get => this._ToolStripButton11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton11_Click);
      if (this._ToolStripButton11 != null)
        this._ToolStripButton11.Click -= eventHandler;
      this._ToolStripButton11 = value;
      if (this._ToolStripButton11 == null)
        return;
      this._ToolStripButton11.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton2
  {
    [DebuggerNonUserCode] get => this._ToolStripButton2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton2_Click);
      if (this._ToolStripButton2 != null)
        this._ToolStripButton2.Click -= eventHandler;
      this._ToolStripButton2 = value;
      if (this._ToolStripButton2 == null)
        return;
      this._ToolStripButton2.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton10
  {
    [DebuggerNonUserCode] get => this._ToolStripButton10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton10_Click);
      if (this._ToolStripButton10 != null)
        this._ToolStripButton10.Click -= eventHandler;
      this._ToolStripButton10 = value;
      if (this._ToolStripButton10 == null)
        return;
      this._ToolStripButton10.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton9
  {
    [DebuggerNonUserCode] get => this._ToolStripButton9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton9_Click);
      if (this._ToolStripButton9 != null)
        this._ToolStripButton9.Click -= eventHandler;
      this._ToolStripButton9 = value;
      if (this._ToolStripButton9 == null)
        return;
      this._ToolStripButton9.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton6
  {
    [DebuggerNonUserCode] get => this._ToolStripButton6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton6_Click);
      if (this._ToolStripButton6 != null)
        this._ToolStripButton6.Click -= eventHandler;
      this._ToolStripButton6 = value;
      if (this._ToolStripButton6 == null)
        return;
      this._ToolStripButton6.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton3
  {
    [DebuggerNonUserCode] get => this._ToolStripButton3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton3_Click);
      if (this._ToolStripButton3 != null)
        this._ToolStripButton3.Click -= eventHandler;
      this._ToolStripButton3 = value;
      if (this._ToolStripButton3 == null)
        return;
      this._ToolStripButton3.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton12
  {
    [DebuggerNonUserCode] get => this._ToolStripButton12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton12_Click);
      if (this._ToolStripButton12 != null)
        this._ToolStripButton12.Click -= eventHandler;
      this._ToolStripButton12 = value;
      if (this._ToolStripButton12 == null)
        return;
      this._ToolStripButton12.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator6
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator6 = value;
    }
  }

  internal virtual ToolStripButton ToolStripButton13
  {
    [DebuggerNonUserCode] get => this._ToolStripButton13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton13_Click);
      if (this._ToolStripButton13 != null)
        this._ToolStripButton13.Click -= eventHandler;
      this._ToolStripButton13 = value;
      if (this._ToolStripButton13 == null)
        return;
      this._ToolStripButton13.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton15
  {
    [DebuggerNonUserCode] get => this._ToolStripButton15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton15_Click);
      if (this._ToolStripButton15 != null)
        this._ToolStripButton15.Click -= eventHandler;
      this._ToolStripButton15 = value;
      if (this._ToolStripButton15 == null)
        return;
      this._ToolStripButton15.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton16
  {
    [DebuggerNonUserCode] get => this._ToolStripButton16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton16_Click);
      if (this._ToolStripButton16 != null)
        this._ToolStripButton16.Click -= eventHandler;
      this._ToolStripButton16 = value;
      if (this._ToolStripButton16 == null)
        return;
      this._ToolStripButton16.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton17
  {
    [DebuggerNonUserCode] get => this._ToolStripButton17;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton17_Click);
      if (this._ToolStripButton17 != null)
        this._ToolStripButton17.Click -= eventHandler;
      this._ToolStripButton17 = value;
      if (this._ToolStripButton17 == null)
        return;
      this._ToolStripButton17.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator7
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator7 = value;
    }
  }

  internal virtual ToolStripButton ToolStripButton18
  {
    [DebuggerNonUserCode] get => this._ToolStripButton18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton18_Click);
      if (this._ToolStripButton18 != null)
        this._ToolStripButton18.Click -= eventHandler;
      this._ToolStripButton18 = value;
      if (this._ToolStripButton18 == null)
        return;
      this._ToolStripButton18.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ScheduleToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._ScheduleToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ScheduleToolStripMenuItem1_Click);
      if (this._ScheduleToolStripMenuItem1 != null)
        this._ScheduleToolStripMenuItem1.Click -= eventHandler;
      this._ScheduleToolStripMenuItem1 = value;
      if (this._ScheduleToolStripMenuItem1 == null)
        return;
      this._ScheduleToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator1
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator1 = value;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator8
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator8 = value;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator9
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator9 = value;
    }
  }

  internal virtual ToolStripMenuItem YearCfToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._YearCfToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.YearCfToolStripMenuItem_Click);
      if (this._YearCfToolStripMenuItem != null)
        this._YearCfToolStripMenuItem.Click -= eventHandler;
      this._YearCfToolStripMenuItem = value;
      if (this._YearCfToolStripMenuItem == null)
        return;
      this._YearCfToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual StatusStrip StatusStrip1
  {
    [DebuggerNonUserCode] get => this._StatusStrip1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._StatusStrip1 = value;
    }
  }

  internal virtual ToolStripStatusLabel lblTS1
  {
    [DebuggerNonUserCode] get => this._lblTS1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTS1 = value;
  }

  internal virtual ToolStripMenuItem GroupReceiptPaymentAcToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._GroupReceiptPaymentAcToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GroupReceiptPaymentAcToolStripMenuItem_Click);
      if (this._GroupReceiptPaymentAcToolStripMenuItem != null)
        this._GroupReceiptPaymentAcToolStripMenuItem.Click -= eventHandler;
      this._GroupReceiptPaymentAcToolStripMenuItem = value;
      if (this._GroupReceiptPaymentAcToolStripMenuItem == null)
        return;
      this._GroupReceiptPaymentAcToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem DefultGroupSettingToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._DefultGroupSettingToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DefultGroupSettingToolStripMenuItem_Click);
      if (this._DefultGroupSettingToolStripMenuItem != null)
        this._DefultGroupSettingToolStripMenuItem.Click -= eventHandler;
      this._DefultGroupSettingToolStripMenuItem = value;
      if (this._DefultGroupSettingToolStripMenuItem == null)
        return;
      this._DefultGroupSettingToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem QuickNoteToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._QuickNoteToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.QuickNoteToolStripMenuItem_Click);
      if (this._QuickNoteToolStripMenuItem != null)
        this._QuickNoteToolStripMenuItem.Click -= eventHandler;
      this._QuickNoteToolStripMenuItem = value;
      if (this._QuickNoteToolStripMenuItem == null)
        return;
      this._QuickNoteToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ExportTestToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ExportTestToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ExportTestToolStripMenuItem = value;
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

  internal virtual ToolStripMenuItem CashBankBookToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._CashBankBookToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CashBankBookToolStripMenuItem_Click);
      if (this._CashBankBookToolStripMenuItem != null)
        this._CashBankBookToolStripMenuItem.Click -= eventHandler;
      this._CashBankBookToolStripMenuItem = value;
      if (this._CashBankBookToolStripMenuItem == null)
        return;
      this._CashBankBookToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem RebuildToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._RebuildToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.RebuildToolStripMenuItem_Click);
      if (this._RebuildToolStripMenuItem != null)
        this._RebuildToolStripMenuItem.Click -= eventHandler;
      this._RebuildToolStripMenuItem = value;
      if (this._RebuildToolStripMenuItem == null)
        return;
      this._RebuildToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator10
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator10 = value;
    }
  }

  internal virtual ToolStripMenuItem BillRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._BillRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._BillRegisterToolStripMenuItem = value;
    }
  }

  internal virtual ToolStripMenuItem ReceiptRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ReceiptRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptRegisterToolStripMenuItem_Click);
      if (this._ReceiptRegisterToolStripMenuItem != null)
        this._ReceiptRegisterToolStripMenuItem.Click -= eventHandler;
      this._ReceiptRegisterToolStripMenuItem = value;
      if (this._ReceiptRegisterToolStripMenuItem == null)
        return;
      this._ReceiptRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem DebitNoteRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._DebitNoteRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DebitNoteRegisterToolStripMenuItem_Click);
      if (this._DebitNoteRegisterToolStripMenuItem != null)
        this._DebitNoteRegisterToolStripMenuItem.Click -= eventHandler;
      this._DebitNoteRegisterToolStripMenuItem = value;
      if (this._DebitNoteRegisterToolStripMenuItem == null)
        return;
      this._DebitNoteRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem CreditNoteRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._CreditNoteRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CreditNoteRegisterToolStripMenuItem_Click);
      if (this._CreditNoteRegisterToolStripMenuItem != null)
        this._CreditNoteRegisterToolStripMenuItem.Click -= eventHandler;
      this._CreditNoteRegisterToolStripMenuItem = value;
      if (this._CreditNoteRegisterToolStripMenuItem == null)
        return;
      this._CreditNoteRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem AdjustmentRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._AdjustmentRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AdjustmentRegisterToolStripMenuItem_Click);
      if (this._AdjustmentRegisterToolStripMenuItem != null)
        this._AdjustmentRegisterToolStripMenuItem.Click -= eventHandler;
      this._AdjustmentRegisterToolStripMenuItem = value;
      if (this._AdjustmentRegisterToolStripMenuItem == null)
        return;
      this._AdjustmentRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator11
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator11 = value;
    }
  }

  internal virtual ToolStripMenuItem DataSheetToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._DataSheetToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DataSheetToolStripMenuItem1_Click);
      if (this._DataSheetToolStripMenuItem1 != null)
        this._DataSheetToolStripMenuItem1.Click -= eventHandler;
      this._DataSheetToolStripMenuItem1 = value;
      if (this._DataSheetToolStripMenuItem1 == null)
        return;
      this._DataSheetToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BankDepositListToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._BankDepositListToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BankDepositListToolStripMenuItem1_Click);
      if (this._BankDepositListToolStripMenuItem1 != null)
        this._BankDepositListToolStripMenuItem1.Click -= eventHandler;
      this._BankDepositListToolStripMenuItem1 = value;
      if (this._BankDepositListToolStripMenuItem1 == null)
        return;
      this._BankDepositListToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem AccountLedgerToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._AccountLedgerToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AccountLedgerToolStripMenuItem_Click);
      if (this._AccountLedgerToolStripMenuItem != null)
        this._AccountLedgerToolStripMenuItem.Click -= eventHandler;
      this._AccountLedgerToolStripMenuItem = value;
      if (this._AccountLedgerToolStripMenuItem == null)
        return;
      this._AccountLedgerToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptRegiToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ReceiptRegiToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptRegiToolStripMenuItem_Click);
      if (this._ReceiptRegiToolStripMenuItem != null)
        this._ReceiptRegiToolStripMenuItem.Click -= eventHandler;
      this._ReceiptRegiToolStripMenuItem = value;
      if (this._ReceiptRegiToolStripMenuItem == null)
        return;
      this._ReceiptRegiToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem PaymentRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._PaymentRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PaymentRegisterToolStripMenuItem_Click);
      if (this._PaymentRegisterToolStripMenuItem != null)
        this._PaymentRegisterToolStripMenuItem.Click -= eventHandler;
      this._PaymentRegisterToolStripMenuItem = value;
      if (this._PaymentRegisterToolStripMenuItem == null)
        return;
      this._PaymentRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ContraRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ContraRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ContraRegisterToolStripMenuItem_Click);
      if (this._ContraRegisterToolStripMenuItem != null)
        this._ContraRegisterToolStripMenuItem.Click -= eventHandler;
      this._ContraRegisterToolStripMenuItem = value;
      if (this._ContraRegisterToolStripMenuItem == null)
        return;
      this._ContraRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem JournalRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._JournalRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.JournalRegisterToolStripMenuItem_Click);
      if (this._JournalRegisterToolStripMenuItem != null)
        this._JournalRegisterToolStripMenuItem.Click -= eventHandler;
      this._JournalRegisterToolStripMenuItem = value;
      if (this._JournalRegisterToolStripMenuItem == null)
        return;
      this._JournalRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem1_Click);
      if (this._ToolStripMenuItem1 != null)
        this._ToolStripMenuItem1.Click -= eventHandler;
      this._ToolStripMenuItem1 = value;
      if (this._ToolStripMenuItem1 == null)
        return;
      this._ToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator4
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator4 = value;
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

  internal virtual ToolStripButton ToolStripButton19
  {
    [DebuggerNonUserCode] get => this._ToolStripButton19;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton19_Click);
      if (this._ToolStripButton19 != null)
        this._ToolStripButton19.Click -= eventHandler;
      this._ToolStripButton19 = value;
      if (this._ToolStripButton19 == null)
        return;
      this._ToolStripButton19.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ChangeYearToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ChangeYearToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ChangeYearToolStripMenuItem_Click);
      if (this._ChangeYearToolStripMenuItem != null)
        this._ChangeYearToolStripMenuItem.Click -= eventHandler;
      this._ChangeYearToolStripMenuItem = value;
      if (this._ChangeYearToolStripMenuItem == null)
        return;
      this._ChangeYearToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem4
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem4_Click);
      if (this._ToolStripMenuItem4 != null)
        this._ToolStripMenuItem4.Click -= eventHandler;
      this._ToolStripMenuItem4 = value;
      if (this._ToolStripMenuItem4 == null)
        return;
      this._ToolStripMenuItem4.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem6
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem6;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem6_Click);
      if (this._ToolStripMenuItem6 != null)
        this._ToolStripMenuItem6.Click -= eventHandler;
      this._ToolStripMenuItem6 = value;
      if (this._ToolStripMenuItem6 == null)
        return;
      this._ToolStripMenuItem6.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem7
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem7;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem7_Click);
      if (this._ToolStripMenuItem7 != null)
        this._ToolStripMenuItem7.Click -= eventHandler;
      this._ToolStripMenuItem7 = value;
      if (this._ToolStripMenuItem7 == null)
        return;
      this._ToolStripMenuItem7.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem VendorToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._VendorToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.VendorToolStripMenuItem_Click);
      if (this._VendorToolStripMenuItem != null)
        this._VendorToolStripMenuItem.Click -= eventHandler;
      this._VendorToolStripMenuItem = value;
      if (this._VendorToolStripMenuItem == null)
        return;
      this._VendorToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ServantToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ServantToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ServantToolStripMenuItem_Click);
      if (this._ServantToolStripMenuItem != null)
        this._ServantToolStripMenuItem.Click -= eventHandler;
      this._ServantToolStripMenuItem = value;
      if (this._ServantToolStripMenuItem == null)
        return;
      this._ServantToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem FToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._FToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.FToolStripMenuItem_Click);
      if (this._FToolStripMenuItem != null)
        this._FToolStripMenuItem.Click -= eventHandler;
      this._FToolStripMenuItem = value;
      if (this._FToolStripMenuItem == null)
        return;
      this._FToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MultiReceiptToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MultiReceiptToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MultiReceiptToolStripMenuItem_Click);
      if (this._MultiReceiptToolStripMenuItem != null)
        this._MultiReceiptToolStripMenuItem.Click -= eventHandler;
      this._MultiReceiptToolStripMenuItem = value;
      if (this._MultiReceiptToolStripMenuItem == null)
        return;
      this._MultiReceiptToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MULToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MULToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MULToolStripMenuItem_Click);
      if (this._MULToolStripMenuItem != null)
        this._MULToolStripMenuItem.Click -= eventHandler;
      this._MULToolStripMenuItem = value;
      if (this._MULToolStripMenuItem == null)
        return;
      this._MULToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator12
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator12 = value;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem8
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem8;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem8_Click);
      if (this._ToolStripMenuItem8 != null)
        this._ToolStripMenuItem8.Click -= eventHandler;
      this._ToolStripMenuItem8 = value;
      if (this._ToolStripMenuItem8 == null)
        return;
      this._ToolStripMenuItem8.Click += eventHandler;
    }
  }

  internal virtual ToolStripSplitButton ToolStripSplitButton1
  {
    [DebuggerNonUserCode] get => this._ToolStripSplitButton1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSplitButton1 = value;
    }
  }

  internal virtual ToolStripMenuItem CalculatorToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._CalculatorToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._CalculatorToolStripMenuItem = value;
    }
  }

  internal virtual ToolStripMenuItem YearBfToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._YearBfToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.YearBfToolStripMenuItem_Click);
      if (this._YearBfToolStripMenuItem != null)
        this._YearBfToolStripMenuItem.Click -= eventHandler;
      this._YearBfToolStripMenuItem = value;
      if (this._YearBfToolStripMenuItem == null)
        return;
      this._YearBfToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem NewTtanTypeToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._NewTtanTypeToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.NewTtanTypeToolStripMenuItem_Click);
      if (this._NewTtanTypeToolStripMenuItem != null)
        this._NewTtanTypeToolStripMenuItem.Click -= eventHandler;
      this._NewTtanTypeToolStripMenuItem = value;
      if (this._NewTtanTypeToolStripMenuItem == null)
        return;
      this._NewTtanTypeToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem StatutoryToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._StatutoryToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._StatutoryToolStripMenuItem = value;
    }
  }

  internal virtual ToolStripMenuItem MasterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._MasterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MasterToolStripMenuItem1_Click);
      if (this._MasterToolStripMenuItem1 != null)
        this._MasterToolStripMenuItem1.Click -= eventHandler;
      this._MasterToolStripMenuItem1 = value;
      if (this._MasterToolStripMenuItem1 == null)
        return;
      this._MasterToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem JRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._JRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.JRegisterToolStripMenuItem_Click);
      if (this._JRegisterToolStripMenuItem != null)
        this._JRegisterToolStripMenuItem.Click -= eventHandler;
      this._JRegisterToolStripMenuItem = value;
      if (this._JRegisterToolStripMenuItem == null)
        return;
      this._JRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ShareRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ShareRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ShareRegisterToolStripMenuItem_Click);
      if (this._ShareRegisterToolStripMenuItem != null)
        this._ShareRegisterToolStripMenuItem.Click -= eventHandler;
      this._ShareRegisterToolStripMenuItem = value;
      if (this._ShareRegisterToolStripMenuItem == null)
        return;
      this._ShareRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem IRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._IRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.IRegisterToolStripMenuItem_Click);
      if (this._IRegisterToolStripMenuItem != null)
        this._IRegisterToolStripMenuItem.Click -= eventHandler;
      this._IRegisterToolStripMenuItem = value;
      if (this._IRegisterToolStripMenuItem == null)
        return;
      this._IRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem IRegisterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._IRegisterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.IRegisterToolStripMenuItem1_Click);
      if (this._IRegisterToolStripMenuItem1 != null)
        this._IRegisterToolStripMenuItem1.Click -= eventHandler;
      this._IRegisterToolStripMenuItem1 = value;
      if (this._IRegisterToolStripMenuItem1 == null)
        return;
      this._IRegisterToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem PropertyRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._PropertyRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PropertyRegisterToolStripMenuItem_Click);
      if (this._PropertyRegisterToolStripMenuItem != null)
        this._PropertyRegisterToolStripMenuItem.Click -= eventHandler;
      this._PropertyRegisterToolStripMenuItem = value;
      if (this._PropertyRegisterToolStripMenuItem == null)
        return;
      this._PropertyRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem SocietyStatMasterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._SocietyStatMasterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SocietyStatMasterToolStripMenuItem_Click);
      if (this._SocietyStatMasterToolStripMenuItem != null)
        this._SocietyStatMasterToolStripMenuItem.Click -= eventHandler;
      this._SocietyStatMasterToolStripMenuItem = value;
      if (this._SocietyStatMasterToolStripMenuItem == null)
        return;
      this._SocietyStatMasterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator13
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator13 = value;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator14
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator14 = value;
    }
  }

  internal virtual ToolStripMenuItem SinkingFundLedgerToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._SinkingFundLedgerToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SinkingFundLedgerToolStripMenuItem_Click);
      if (this._SinkingFundLedgerToolStripMenuItem != null)
        this._SinkingFundLedgerToolStripMenuItem.Click -= eventHandler;
      this._SinkingFundLedgerToolStripMenuItem = value;
      if (this._SinkingFundLedgerToolStripMenuItem == null)
        return;
      this._SinkingFundLedgerToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem InvestmentRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._InvestmentRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.InvestmentRegisterToolStripMenuItem_Click);
      if (this._InvestmentRegisterToolStripMenuItem != null)
        this._InvestmentRegisterToolStripMenuItem.Click -= eventHandler;
      this._InvestmentRegisterToolStripMenuItem = value;
      if (this._InvestmentRegisterToolStripMenuItem == null)
        return;
      this._InvestmentRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem9
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem9;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem9_Click);
      if (this._ToolStripMenuItem9 != null)
        this._ToolStripMenuItem9.Click -= eventHandler;
      this._ToolStripMenuItem9 = value;
      if (this._ToolStripMenuItem9 == null)
        return;
      this._ToolStripMenuItem9.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem AboutUsToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._AboutUsToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AboutUsToolStripMenuItem_Click);
      if (this._AboutUsToolStripMenuItem != null)
        this._AboutUsToolStripMenuItem.Click -= eventHandler;
      this._AboutUsToolStripMenuItem = value;
      if (this._AboutUsToolStripMenuItem == null)
        return;
      this._AboutUsToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator15
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator15 = value;
    }
  }

  internal virtual ToolStripMenuItem AuditFormNo28ToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._AuditFormNo28ToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AuditFormNo28ToolStripMenuItem_Click);
      if (this._AuditFormNo28ToolStripMenuItem != null)
        this._AuditFormNo28ToolStripMenuItem.Click -= eventHandler;
      this._AuditFormNo28ToolStripMenuItem = value;
      if (this._AuditFormNo28ToolStripMenuItem == null)
        return;
      this._AuditFormNo28ToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem AuditFormNo1ToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._AuditFormNo1ToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AuditFormNo1ToolStripMenuItem_Click);
      if (this._AuditFormNo1ToolStripMenuItem != null)
        this._AuditFormNo1ToolStripMenuItem.Click -= eventHandler;
      this._AuditFormNo1ToolStripMenuItem = value;
      if (this._AuditFormNo1ToolStripMenuItem == null)
        return;
      this._AuditFormNo1ToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem AuditGeneralRemarkToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._AuditGeneralRemarkToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AuditGeneralRemarkToolStripMenuItem_Click);
      if (this._AuditGeneralRemarkToolStripMenuItem != null)
        this._AuditGeneralRemarkToolStripMenuItem.Click -= eventHandler;
      this._AuditGeneralRemarkToolStripMenuItem = value;
      if (this._AuditGeneralRemarkToolStripMenuItem == null)
        return;
      this._AuditGeneralRemarkToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem AuditOFormToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._AuditOFormToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AuditOFormToolStripMenuItem_Click);
      if (this._AuditOFormToolStripMenuItem != null)
        this._AuditOFormToolStripMenuItem.Click -= eventHandler;
      this._AuditOFormToolStripMenuItem = value;
      if (this._AuditOFormToolStripMenuItem == null)
        return;
      this._AuditOFormToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator16
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator16 = value;
    }
  }

  internal virtual ToolStripMenuItem ByeLawsToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ByeLawsToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ByeLawsToolStripMenuItem_Click);
      if (this._ByeLawsToolStripMenuItem != null)
        this._ByeLawsToolStripMenuItem.Click -= eventHandler;
      this._ByeLawsToolStripMenuItem = value;
      if (this._ByeLawsToolStripMenuItem == null)
        return;
      this._ByeLawsToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem CaclulatorToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._CaclulatorToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CaclulatorToolStripMenuItem_Click);
      if (this._CaclulatorToolStripMenuItem != null)
        this._CaclulatorToolStripMenuItem.Click -= eventHandler;
      this._CaclulatorToolStripMenuItem = value;
      if (this._CaclulatorToolStripMenuItem == null)
        return;
      this._CaclulatorToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem JRegisterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._JRegisterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._JRegisterToolStripMenuItem1 = value;
    }
  }

  internal virtual ToolStripMenuItem ShareRegisterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._ShareRegisterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ShareRegisterToolStripMenuItem1 = value;
    }
  }

  internal virtual ToolStripMenuItem NominationRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._NominationRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._NominationRegisterToolStripMenuItem = value;
    }
  }

  internal virtual ToolStripMenuItem IRegisterToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._IRegisterToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._IRegisterToolStripMenuItem2 = value;
    }
  }

  internal virtual ToolStripMenuItem PropertyRegisterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._PropertyRegisterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PropertyRegisterToolStripMenuItem1_Click);
      if (this._PropertyRegisterToolStripMenuItem1 != null)
        this._PropertyRegisterToolStripMenuItem1.Click -= eventHandler;
      this._PropertyRegisterToolStripMenuItem1 = value;
      if (this._PropertyRegisterToolStripMenuItem1 == null)
        return;
      this._PropertyRegisterToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem InvestmentRegisterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._InvestmentRegisterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.InvestmentRegisterToolStripMenuItem1_Click);
      if (this._InvestmentRegisterToolStripMenuItem1 != null)
        this._InvestmentRegisterToolStripMenuItem1.Click -= eventHandler;
      this._InvestmentRegisterToolStripMenuItem1 = value;
      if (this._InvestmentRegisterToolStripMenuItem1 == null)
        return;
      this._InvestmentRegisterToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem SinkingFundLedgerToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._SinkingFundLedgerToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SinkingFundLedgerToolStripMenuItem1_Click);
      if (this._SinkingFundLedgerToolStripMenuItem1 != null)
        this._SinkingFundLedgerToolStripMenuItem1.Click -= eventHandler;
      this._SinkingFundLedgerToolStripMenuItem1 = value;
      if (this._SinkingFundLedgerToolStripMenuItem1 == null)
        return;
      this._SinkingFundLedgerToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem NominationFormToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._NominationFormToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.NominationFormToolStripMenuItem_Click);
      if (this._NominationFormToolStripMenuItem != null)
        this._NominationFormToolStripMenuItem.Click -= eventHandler;
      this._NominationFormToolStripMenuItem = value;
      if (this._NominationFormToolStripMenuItem == null)
        return;
      this._NominationFormToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem FlatTransferDocumentToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._FlatTransferDocumentToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.FlatTransferDocumentToolStripMenuItem_Click);
      if (this._FlatTransferDocumentToolStripMenuItem != null)
        this._FlatTransferDocumentToolStripMenuItem.Click -= eventHandler;
      this._FlatTransferDocumentToolStripMenuItem = value;
      if (this._FlatTransferDocumentToolStripMenuItem == null)
        return;
      this._FlatTransferDocumentToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ShareCertificateToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ShareCertificateToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ShareCertificateToolStripMenuItem_Click);
      if (this._ShareCertificateToolStripMenuItem != null)
        this._ShareCertificateToolStripMenuItem.Click -= eventHandler;
      this._ShareCertificateToolStripMenuItem = value;
      if (this._ShareCertificateToolStripMenuItem == null)
        return;
      this._ShareCertificateToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberDetailFormToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MemberDetailFormToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberDetailFormToolStripMenuItem_Click);
      if (this._MemberDetailFormToolStripMenuItem != null)
        this._MemberDetailFormToolStripMenuItem.Click -= eventHandler;
      this._MemberDetailFormToolStripMenuItem = value;
      if (this._MemberDetailFormToolStripMenuItem == null)
        return;
      this._MemberDetailFormToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem SocietyDetailFormToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._SocietyDetailFormToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SocietyDetailFormToolStripMenuItem_Click);
      if (this._SocietyDetailFormToolStripMenuItem != null)
        this._SocietyDetailFormToolStripMenuItem.Click -= eventHandler;
      this._SocietyDetailFormToolStripMenuItem = value;
      if (this._SocietyDetailFormToolStripMenuItem == null)
        return;
      this._SocietyDetailFormToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem OtherFormatsToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._OtherFormatsToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OtherFormatsToolStripMenuItem_Click);
      if (this._OtherFormatsToolStripMenuItem != null)
        this._OtherFormatsToolStripMenuItem.Click -= eventHandler;
      this._OtherFormatsToolStripMenuItem = value;
      if (this._OtherFormatsToolStripMenuItem == null)
        return;
      this._OtherFormatsToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem10
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem10;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem10_Click);
      if (this._ToolStripMenuItem10 != null)
        this._ToolStripMenuItem10.Click -= eventHandler;
      this._ToolStripMenuItem10 = value;
      if (this._ToolStripMenuItem10 == null)
        return;
      this._ToolStripMenuItem10.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem CommitteeMasterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._CommitteeMasterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CommitteeMasterToolStripMenuItem_Click);
      if (this._CommitteeMasterToolStripMenuItem != null)
        this._CommitteeMasterToolStripMenuItem.Click -= eventHandler;
      this._CommitteeMasterToolStripMenuItem = value;
      if (this._CommitteeMasterToolStripMenuItem == null)
        return;
      this._CommitteeMasterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem CheckDifferenceToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._CheckDifferenceToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckDifferenceToolStripMenuItem_Click);
      if (this._CheckDifferenceToolStripMenuItem != null)
        this._CheckDifferenceToolStripMenuItem.Click -= eventHandler;
      this._CheckDifferenceToolStripMenuItem = value;
      if (this._CheckDifferenceToolStripMenuItem == null)
        return;
      this._CheckDifferenceToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem OpeningBalancesToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._OpeningBalancesToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OpeningBalancesToolStripMenuItem_Click);
      if (this._OpeningBalancesToolStripMenuItem != null)
        this._OpeningBalancesToolStripMenuItem.Click -= eventHandler;
      this._OpeningBalancesToolStripMenuItem = value;
      if (this._OpeningBalancesToolStripMenuItem == null)
        return;
      this._OpeningBalancesToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem IToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._IToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.IToolStripMenuItem_Click);
      if (this._IToolStripMenuItem != null)
        this._IToolStripMenuItem.Click -= eventHandler;
      this._IToolStripMenuItem = value;
      if (this._IToolStripMenuItem == null)
        return;
      this._IToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MultiJRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MultiJRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MultiJRegisterToolStripMenuItem_Click);
      if (this._MultiJRegisterToolStripMenuItem != null)
        this._MultiJRegisterToolStripMenuItem.Click -= eventHandler;
      this._MultiJRegisterToolStripMenuItem = value;
      if (this._MultiJRegisterToolStripMenuItem == null)
        return;
      this._MultiJRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ShareRegisterMultiUpdateToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ShareRegisterMultiUpdateToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ShareRegisterMultiUpdateToolStripMenuItem_Click);
      if (this._ShareRegisterMultiUpdateToolStripMenuItem != null)
        this._ShareRegisterMultiUpdateToolStripMenuItem.Click -= eventHandler;
      this._ShareRegisterMultiUpdateToolStripMenuItem = value;
      if (this._ShareRegisterMultiUpdateToolStripMenuItem == null)
        return;
      this._ShareRegisterMultiUpdateToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem IRegisterMulitUpdateToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._IRegisterMulitUpdateToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.IRegisterMulitUpdateToolStripMenuItem_Click);
      if (this._IRegisterMulitUpdateToolStripMenuItem != null)
        this._IRegisterMulitUpdateToolStripMenuItem.Click -= eventHandler;
      this._IRegisterMulitUpdateToolStripMenuItem = value;
      if (this._IRegisterMulitUpdateToolStripMenuItem == null)
        return;
      this._IRegisterMulitUpdateToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem TransferFlatToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._TransferFlatToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TransferFlatToolStripMenuItem_Click);
      if (this._TransferFlatToolStripMenuItem != null)
        this._TransferFlatToolStripMenuItem.Click -= eventHandler;
      this._TransferFlatToolStripMenuItem = value;
      if (this._TransferFlatToolStripMenuItem == null)
        return;
      this._TransferFlatToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberListToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MemberListToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberListToolStripMenuItem_Click);
      if (this._MemberListToolStripMenuItem != null)
        this._MemberListToolStripMenuItem.Click -= eventHandler;
      this._MemberListToolStripMenuItem = value;
      if (this._MemberListToolStripMenuItem == null)
        return;
      this._MemberListToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ElectionListToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ElectionListToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ElectionListToolStripMenuItem_Click);
      if (this._ElectionListToolStripMenuItem != null)
        this._ElectionListToolStripMenuItem.Click -= eventHandler;
      this._ElectionListToolStripMenuItem = value;
      if (this._ElectionListToolStripMenuItem == null)
        return;
      this._ElectionListToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem11
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem11;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem11_Click);
      if (this._ToolStripMenuItem11 != null)
        this._ToolStripMenuItem11.Click -= eventHandler;
      this._ToolStripMenuItem11 = value;
      if (this._ToolStripMenuItem11 == null)
        return;
      this._ToolStripMenuItem11.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator18
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator18;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator18 = value;
    }
  }

  internal virtual ToolStripMenuItem MemberMasterFromExcelToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MemberMasterFromExcelToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberMasterFromExcelToolStripMenuItem_Click);
      if (this._MemberMasterFromExcelToolStripMenuItem != null)
        this._MemberMasterFromExcelToolStripMenuItem.Click -= eventHandler;
      this._MemberMasterFromExcelToolStripMenuItem = value;
      if (this._MemberMasterFromExcelToolStripMenuItem == null)
        return;
      this._MemberMasterFromExcelToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BankListFromOtherSocietyToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._BankListFromOtherSocietyToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BankListFromOtherSocietyToolStripMenuItem_Click);
      if (this._BankListFromOtherSocietyToolStripMenuItem != null)
        this._BankListFromOtherSocietyToolStripMenuItem.Click -= eventHandler;
      this._BankListFromOtherSocietyToolStripMenuItem = value;
      if (this._BankListFromOtherSocietyToolStripMenuItem == null)
        return;
      this._BankListFromOtherSocietyToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem PersonListFromOtherSocietyToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._PersonListFromOtherSocietyToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PersonListFromOtherSocietyToolStripMenuItem_Click);
      if (this._PersonListFromOtherSocietyToolStripMenuItem != null)
        this._PersonListFromOtherSocietyToolStripMenuItem.Click -= eventHandler;
      this._PersonListFromOtherSocietyToolStripMenuItem = value;
      if (this._PersonListFromOtherSocietyToolStripMenuItem == null)
        return;
      this._PersonListFromOtherSocietyToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem12
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem12;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem12_Click);
      if (this._ToolStripMenuItem12 != null)
        this._ToolStripMenuItem12.Click -= eventHandler;
      this._ToolStripMenuItem12 = value;
      if (this._ToolStripMenuItem12 == null)
        return;
      this._ToolStripMenuItem12.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem GroupAccountMasterFromOtherSoceityToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._GroupAccountMasterFromOtherSoceityToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GroupAccountMasterFromOtherSoceityToolStripMenuItem_Click);
      if (this._GroupAccountMasterFromOtherSoceityToolStripMenuItem != null)
        this._GroupAccountMasterFromOtherSoceityToolStripMenuItem.Click -= eventHandler;
      this._GroupAccountMasterFromOtherSoceityToolStripMenuItem = value;
      if (this._GroupAccountMasterFromOtherSoceityToolStripMenuItem == null)
        return;
      this._GroupAccountMasterFromOtherSoceityToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberOpeningBalanceBifurcationToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MemberOpeningBalanceBifurcationToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberOpeningBalanceBifurcationToolStripMenuItem_Click);
      if (this._MemberOpeningBalanceBifurcationToolStripMenuItem != null)
        this._MemberOpeningBalanceBifurcationToolStripMenuItem.Click -= eventHandler;
      this._MemberOpeningBalanceBifurcationToolStripMenuItem = value;
      if (this._MemberOpeningBalanceBifurcationToolStripMenuItem == null)
        return;
      this._MemberOpeningBalanceBifurcationToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem SocietyMasterReceiptRemarkToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._SocietyMasterReceiptRemarkToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SocietyMasterReceiptRemarkToolStripMenuItem_Click);
      if (this._SocietyMasterReceiptRemarkToolStripMenuItem != null)
        this._SocietyMasterReceiptRemarkToolStripMenuItem.Click -= eventHandler;
      this._SocietyMasterReceiptRemarkToolStripMenuItem = value;
      if (this._SocietyMasterReceiptRemarkToolStripMenuItem == null)
        return;
      this._SocietyMasterReceiptRemarkToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem SetBillPrintingOptionToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._SetBillPrintingOptionToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SetBillPrintingOptionToolStripMenuItem_Click);
      if (this._SetBillPrintingOptionToolStripMenuItem != null)
        this._SetBillPrintingOptionToolStripMenuItem.Click -= eventHandler;
      this._SetBillPrintingOptionToolStripMenuItem = value;
      if (this._SetBillPrintingOptionToolStripMenuItem == null)
        return;
      this._SetBillPrintingOptionToolStripMenuItem.Click += eventHandler;
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

  internal virtual ToolStripMenuItem HalfPageToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._HalfPageToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.HalfPageToolStripMenuItem_Click);
      if (this._HalfPageToolStripMenuItem != null)
        this._HalfPageToolStripMenuItem.Click -= eventHandler;
      this._HalfPageToolStripMenuItem = value;
      if (this._HalfPageToolStripMenuItem == null)
        return;
      this._HalfPageToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem FullPage14HeadToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._FullPage14HeadToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.FullPage14HeadToolStripMenuItem_Click);
      if (this._FullPage14HeadToolStripMenuItem != null)
        this._FullPage14HeadToolStripMenuItem.Click -= eventHandler;
      this._FullPage14HeadToolStripMenuItem = value;
      if (this._FullPage14HeadToolStripMenuItem == null)
        return;
      this._FullPage14HeadToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem FullPage21HeadToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._FullPage21HeadToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.FullPage21HeadToolStripMenuItem_Click);
      if (this._FullPage21HeadToolStripMenuItem != null)
        this._FullPage21HeadToolStripMenuItem.Click -= eventHandler;
      this._FullPage21HeadToolStripMenuItem = value;
      if (this._FullPage21HeadToolStripMenuItem == null)
        return;
      this._FullPage21HeadToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem HalfPageToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._HalfPageToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.HalfPageToolStripMenuItem1_Click);
      if (this._HalfPageToolStripMenuItem1 != null)
        this._HalfPageToolStripMenuItem1.Click -= eventHandler;
      this._HalfPageToolStripMenuItem1 = value;
      if (this._HalfPageToolStripMenuItem1 == null)
        return;
      this._HalfPageToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem FullPage14HeadToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._FullPage14HeadToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.FullPage14HeadToolStripMenuItem1_Click);
      if (this._FullPage14HeadToolStripMenuItem1 != null)
        this._FullPage14HeadToolStripMenuItem1.Click -= eventHandler;
      this._FullPage14HeadToolStripMenuItem1 = value;
      if (this._FullPage14HeadToolStripMenuItem1 == null)
        return;
      this._FullPage14HeadToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem FullPage21HeadToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._FullPage21HeadToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.FullPage21HeadToolStripMenuItem1_Click);
      if (this._FullPage21HeadToolStripMenuItem1 != null)
        this._FullPage21HeadToolStripMenuItem1.Click -= eventHandler;
      this._FullPage21HeadToolStripMenuItem1 = value;
      if (this._FullPage21HeadToolStripMenuItem1 == null)
        return;
      this._FullPage21HeadToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem GSTMasterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._GSTMasterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GSTMasterToolStripMenuItem_Click);
      if (this._GSTMasterToolStripMenuItem != null)
        this._GSTMasterToolStripMenuItem.Click -= eventHandler;
      this._GSTMasterToolStripMenuItem = value;
      if (this._GSTMasterToolStripMenuItem == null)
        return;
      this._GSTMasterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem GSTCalculateToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._GSTCalculateToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GSTCalculateToolStripMenuItem_Click);
      if (this._GSTCalculateToolStripMenuItem != null)
        this._GSTCalculateToolStripMenuItem.Click -= eventHandler;
      this._GSTCalculateToolStripMenuItem = value;
      if (this._GSTCalculateToolStripMenuItem == null)
        return;
      this._GSTCalculateToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem HalfPageGSTVerticalDoubleBillToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._HalfPageGSTVerticalDoubleBillToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.HalfPageGSTVerticalDoubleBillToolStripMenuItem_Click);
      if (this._HalfPageGSTVerticalDoubleBillToolStripMenuItem != null)
        this._HalfPageGSTVerticalDoubleBillToolStripMenuItem.Click -= eventHandler;
      this._HalfPageGSTVerticalDoubleBillToolStripMenuItem = value;
      if (this._HalfPageGSTVerticalDoubleBillToolStripMenuItem == null)
        return;
      this._HalfPageGSTVerticalDoubleBillToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ListToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ListToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ListToolStripMenuItem_Click);
      if (this._ListToolStripMenuItem != null)
        this._ListToolStripMenuItem.Click -= eventHandler;
      this._ListToolStripMenuItem = value;
      if (this._ListToolStripMenuItem == null)
        return;
      this._ListToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem FormToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._FormToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.FormToolStripMenuItem_Click);
      if (this._FormToolStripMenuItem != null)
        this._FormToolStripMenuItem.Click -= eventHandler;
      this._FormToolStripMenuItem = value;
      if (this._FormToolStripMenuItem == null)
        return;
      this._FormToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem OtherInfoToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._OtherInfoToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OtherInfoToolStripMenuItem_Click);
      if (this._OtherInfoToolStripMenuItem != null)
        this._OtherInfoToolStripMenuItem.Click -= eventHandler;
      this._OtherInfoToolStripMenuItem = value;
      if (this._OtherInfoToolStripMenuItem == null)
        return;
      this._OtherInfoToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberReceiptFromExcelToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MemberReceiptFromExcelToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberReceiptFromExcelToolStripMenuItem_Click);
      if (this._MemberReceiptFromExcelToolStripMenuItem != null)
        this._MemberReceiptFromExcelToolStripMenuItem.Click -= eventHandler;
      this._MemberReceiptFromExcelToolStripMenuItem = value;
      if (this._MemberReceiptFromExcelToolStripMenuItem == null)
        return;
      this._MemberReceiptFromExcelToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem A4ToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._A4ToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.A4ToolStripMenuItem_Click);
      if (this._A4ToolStripMenuItem != null)
        this._A4ToolStripMenuItem.Click -= eventHandler;
      this._A4ToolStripMenuItem = value;
      if (this._A4ToolStripMenuItem == null)
        return;
      this._A4ToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem LegalPaperToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._LegalPaperToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.LegalPaperToolStripMenuItem_Click);
      if (this._LegalPaperToolStripMenuItem != null)
        this._LegalPaperToolStripMenuItem.Click -= eventHandler;
      this._LegalPaperToolStripMenuItem = value;
      if (this._LegalPaperToolStripMenuItem == null)
        return;
      this._LegalPaperToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem A4PaperToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._A4PaperToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.A4PaperToolStripMenuItem_Click);
      if (this._A4PaperToolStripMenuItem != null)
        this._A4PaperToolStripMenuItem.Click -= eventHandler;
      this._A4PaperToolStripMenuItem = value;
      if (this._A4PaperToolStripMenuItem == null)
        return;
      this._A4PaperToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem LegalPaperToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._LegalPaperToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.LegalPaperToolStripMenuItem1_Click);
      if (this._LegalPaperToolStripMenuItem1 != null)
        this._LegalPaperToolStripMenuItem1.Click -= eventHandler;
      this._LegalPaperToolStripMenuItem1 = value;
      if (this._LegalPaperToolStripMenuItem1 == null)
        return;
      this._LegalPaperToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem A4PaperToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._A4PaperToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.A4PaperToolStripMenuItem1_Click);
      if (this._A4PaperToolStripMenuItem1 != null)
        this._A4PaperToolStripMenuItem1.Click -= eventHandler;
      this._A4PaperToolStripMenuItem1 = value;
      if (this._A4PaperToolStripMenuItem1 == null)
        return;
      this._A4PaperToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem LegalPaperToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._LegalPaperToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.LegalPaperToolStripMenuItem2_Click);
      if (this._LegalPaperToolStripMenuItem2 != null)
        this._LegalPaperToolStripMenuItem2.Click -= eventHandler;
      this._LegalPaperToolStripMenuItem2 = value;
      if (this._LegalPaperToolStripMenuItem2 == null)
        return;
      this._LegalPaperToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem A4PaperToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._A4PaperToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.A4PaperToolStripMenuItem2_Click);
      if (this._A4PaperToolStripMenuItem2 != null)
        this._A4PaperToolStripMenuItem2.Click -= eventHandler;
      this._A4PaperToolStripMenuItem2 = value;
      if (this._A4PaperToolStripMenuItem2 == null)
        return;
      this._A4PaperToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem LegalPaperToolStripMenuItem3
  {
    [DebuggerNonUserCode] get => this._LegalPaperToolStripMenuItem3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.LegalPaperToolStripMenuItem3_Click);
      if (this._LegalPaperToolStripMenuItem3 != null)
        this._LegalPaperToolStripMenuItem3.Click -= eventHandler;
      this._LegalPaperToolStripMenuItem3 = value;
      if (this._LegalPaperToolStripMenuItem3 == null)
        return;
      this._LegalPaperToolStripMenuItem3.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem13
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem13;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem13_Click_1);
      if (this._ToolStripMenuItem13 != null)
        this._ToolStripMenuItem13.Click -= eventHandler;
      this._ToolStripMenuItem13 = value;
      if (this._ToolStripMenuItem13 == null)
        return;
      this._ToolStripMenuItem13.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem16
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem16;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem16_Click);
      if (this._ToolStripMenuItem16 != null)
        this._ToolStripMenuItem16.Click -= eventHandler;
      this._ToolStripMenuItem16 = value;
      if (this._ToolStripMenuItem16 == null)
        return;
      this._ToolStripMenuItem16.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem PaymentFromExcelToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._PaymentFromExcelToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PaymentFromExcelToolStripMenuItem_Click);
      if (this._PaymentFromExcelToolStripMenuItem != null)
        this._PaymentFromExcelToolStripMenuItem.Click -= eventHandler;
      this._PaymentFromExcelToolStripMenuItem = value;
      if (this._PaymentFromExcelToolStripMenuItem == null)
        return;
      this._PaymentFromExcelToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripSeparator ToolStripSeparator21
  {
    [DebuggerNonUserCode] get => this._ToolStripSeparator21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripSeparator21 = value;
    }
  }

  internal virtual ToolStripButton ToolStripButton20
  {
    [DebuggerNonUserCode] get => this._ToolStripButton20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton20_Click);
      if (this._ToolStripButton20 != null)
        this._ToolStripButton20.Click -= eventHandler;
      this._ToolStripButton20 = value;
      if (this._ToolStripButton20 == null)
        return;
      this._ToolStripButton20.Click += eventHandler;
    }
  }

  internal virtual ToolStripLabel ToolStripLabel1
  {
    [DebuggerNonUserCode] get => this._ToolStripLabel1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripLabel1 = value;
    }
  }

  internal virtual ToolStripButton ToolStripButton21
  {
    [DebuggerNonUserCode] get => this._ToolStripButton21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripButton21 = value;
    }
  }

  internal virtual ToolStripButton ToolStripButton22
  {
    [DebuggerNonUserCode] get => this._ToolStripButton22;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripButton22_Click);
      if (this._ToolStripButton22 != null)
        this._ToolStripButton22.Click -= eventHandler;
      this._ToolStripButton22 = value;
      if (this._ToolStripButton22 == null)
        return;
      this._ToolStripButton22.Click += eventHandler;
    }
  }

  internal virtual ToolStripButton ToolStripButton23
  {
    [DebuggerNonUserCode] get => this._ToolStripButton23;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripButton23 = value;
    }
  }

  internal virtual ToolStripButton ToolStripButton24
  {
    [DebuggerNonUserCode] get => this._ToolStripButton24;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripButton24 = value;
    }
  }

  internal virtual ToolStripMenuItem IncomeExpenditureAcMarathiToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._IncomeExpenditureAcMarathiToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.IncomeExpenditureAcMarathiToolStripMenuItem_Click);
      if (this._IncomeExpenditureAcMarathiToolStripMenuItem != null)
        this._IncomeExpenditureAcMarathiToolStripMenuItem.Click -= eventHandler;
      this._IncomeExpenditureAcMarathiToolStripMenuItem = value;
      if (this._IncomeExpenditureAcMarathiToolStripMenuItem == null)
        return;
      this._IncomeExpenditureAcMarathiToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BalanceSheetMarathiToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._BalanceSheetMarathiToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BalanceSheetMarathiToolStripMenuItem_Click);
      if (this._BalanceSheetMarathiToolStripMenuItem != null)
        this._BalanceSheetMarathiToolStripMenuItem.Click -= eventHandler;
      this._BalanceSheetMarathiToolStripMenuItem = value;
      if (this._BalanceSheetMarathiToolStripMenuItem == null)
        return;
      this._BalanceSheetMarathiToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem SelectedBillingMasterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._SelectedBillingMasterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SelectedBillingMasterToolStripMenuItem_Click);
      if (this._SelectedBillingMasterToolStripMenuItem != null)
        this._SelectedBillingMasterToolStripMenuItem.Click -= eventHandler;
      this._SelectedBillingMasterToolStripMenuItem = value;
      if (this._SelectedBillingMasterToolStripMenuItem == null)
        return;
      this._SelectedBillingMasterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem JournalVoucherToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._JournalVoucherToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.JournalVoucherToolStripMenuItem_Click);
      if (this._JournalVoucherToolStripMenuItem != null)
        this._JournalVoucherToolStripMenuItem.Click -= eventHandler;
      this._JournalVoucherToolStripMenuItem = value;
      if (this._JournalVoucherToolStripMenuItem == null)
        return;
      this._JournalVoucherToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem SocietyMasterReceiptRemarkToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._SocietyMasterReceiptRemarkToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.SocietyMasterReceiptRemarkToolStripMenuItem1_Click);
      if (this._SocietyMasterReceiptRemarkToolStripMenuItem1 != null)
        this._SocietyMasterReceiptRemarkToolStripMenuItem1.Click -= eventHandler;
      this._SocietyMasterReceiptRemarkToolStripMenuItem1 = value;
      if (this._SocietyMasterReceiptRemarkToolStripMenuItem1 == null)
        return;
      this._SocietyMasterReceiptRemarkToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptFromExcelToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ReceiptFromExcelToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptFromExcelToolStripMenuItem_Click);
      if (this._ReceiptFromExcelToolStripMenuItem != null)
        this._ReceiptFromExcelToolStripMenuItem.Click -= eventHandler;
      this._ReceiptFromExcelToolStripMenuItem = value;
      if (this._ReceiptFromExcelToolStripMenuItem == null)
        return;
      this._ReceiptFromExcelToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem FundRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._FundRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.FundRegisterToolStripMenuItem_Click);
      if (this._FundRegisterToolStripMenuItem != null)
        this._FundRegisterToolStripMenuItem.Click -= eventHandler;
      this._FundRegisterToolStripMenuItem = value;
      if (this._FundRegisterToolStripMenuItem == null)
        return;
      this._FundRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem20
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem20;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem20_Click);
      if (this._ToolStripMenuItem20 != null)
        this._ToolStripMenuItem20.Click -= eventHandler;
      this._ToolStripMenuItem20 = value;
      if (this._ToolStripMenuItem20 == null)
        return;
      this._ToolStripMenuItem20.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem21
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem21;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem21_Click);
      if (this._ToolStripMenuItem21 != null)
        this._ToolStripMenuItem21.Click -= eventHandler;
      this._ToolStripMenuItem21 = value;
      if (this._ToolStripMenuItem21 == null)
        return;
      this._ToolStripMenuItem21.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem NormalToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._NormalToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.NormalToolStripMenuItem_Click);
      if (this._NormalToolStripMenuItem != null)
        this._NormalToolStripMenuItem.Click -= eventHandler;
      this._NormalToolStripMenuItem = value;
      if (this._NormalToolStripMenuItem == null)
        return;
      this._NormalToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BillRegisgerWithReceiptToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._BillRegisgerWithReceiptToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BillRegisgerWithReceiptToolStripMenuItem_Click);
      if (this._BillRegisgerWithReceiptToolStripMenuItem != null)
        this._BillRegisgerWithReceiptToolStripMenuItem.Click -= eventHandler;
      this._BillRegisgerWithReceiptToolStripMenuItem = value;
      if (this._BillRegisgerWithReceiptToolStripMenuItem == null)
        return;
      this._BillRegisgerWithReceiptToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem GSTBillRegisterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._GSTBillRegisterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GSTBillRegisterToolStripMenuItem1_Click);
      if (this._GSTBillRegisterToolStripMenuItem1 != null)
        this._GSTBillRegisterToolStripMenuItem1.Click -= eventHandler;
      this._GSTBillRegisterToolStripMenuItem1 = value;
      if (this._GSTBillRegisterToolStripMenuItem1 == null)
        return;
      this._GSTBillRegisterToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem_Click);
      if (this._FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem != null)
        this._FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem.Click -= eventHandler;
      this._FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem = value;
      if (this._FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem == null)
        return;
      this._FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem PToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._PToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._PToolStripMenuItem = value;
    }
  }

  internal virtual ToolStripMenuItem AllToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._AllToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.AllToolStripMenuItem_Click);
      if (this._AllToolStripMenuItem != null)
        this._AllToolStripMenuItem.Click -= eventHandler;
      this._AllToolStripMenuItem = value;
      if (this._AllToolStripMenuItem == null)
        return;
      this._AllToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem OkToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._OkToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OkToolStripMenuItem_Click);
      if (this._OkToolStripMenuItem != null)
        this._OkToolStripMenuItem.Click -= eventHandler;
      this._OkToolStripMenuItem = value;
      if (this._OkToolStripMenuItem == null)
        return;
      this._OkToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem CheckToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._CheckToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CheckToolStripMenuItem_Click);
      if (this._CheckToolStripMenuItem != null)
        this._CheckToolStripMenuItem.Click -= eventHandler;
      this._CheckToolStripMenuItem = value;
      if (this._CheckToolStripMenuItem == null)
        return;
      this._CheckToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem VoucherCheckReportToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._VoucherCheckReportToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.VoucherCheckReportToolStripMenuItem_Click);
      if (this._VoucherCheckReportToolStripMenuItem != null)
        this._VoucherCheckReportToolStripMenuItem.Click -= eventHandler;
      this._VoucherCheckReportToolStripMenuItem = value;
      if (this._VoucherCheckReportToolStripMenuItem == null)
        return;
      this._VoucherCheckReportToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem CodeWiseToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._CodeWiseToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CodeWiseToolStripMenuItem_Click);
      if (this._CodeWiseToolStripMenuItem != null)
        this._CodeWiseToolStripMenuItem.Click -= eventHandler;
      this._CodeWiseToolStripMenuItem = value;
      if (this._CodeWiseToolStripMenuItem == null)
        return;
      this._CodeWiseToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem GroupWiseToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._GroupWiseToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GroupWiseToolStripMenuItem_Click);
      if (this._GroupWiseToolStripMenuItem != null)
        this._GroupWiseToolStripMenuItem.Click -= eventHandler;
      this._GroupWiseToolStripMenuItem = value;
      if (this._GroupWiseToolStripMenuItem == null)
        return;
      this._GroupWiseToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BooksOfAccountToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._BooksOfAccountToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BooksOfAccountToolStripMenuItem_Click);
      if (this._BooksOfAccountToolStripMenuItem != null)
        this._BooksOfAccountToolStripMenuItem.Click -= eventHandler;
      this._BooksOfAccountToolStripMenuItem = value;
      if (this._BooksOfAccountToolStripMenuItem == null)
        return;
      this._BooksOfAccountToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BooksOfAccountTableFromOtherSocietyToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._BooksOfAccountTableFromOtherSocietyToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BooksOfAccountTableFromOtherSocietyToolStripMenuItem_Click);
      if (this._BooksOfAccountTableFromOtherSocietyToolStripMenuItem != null)
        this._BooksOfAccountTableFromOtherSocietyToolStripMenuItem.Click -= eventHandler;
      this._BooksOfAccountTableFromOtherSocietyToolStripMenuItem = value;
      if (this._BooksOfAccountTableFromOtherSocietyToolStripMenuItem == null)
        return;
      this._BooksOfAccountTableFromOtherSocietyToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem WhatsNewIn202425ToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._WhatsNewIn202425ToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.WhatsNewIn202425ToolStripMenuItem_Click);
      if (this._WhatsNewIn202425ToolStripMenuItem != null)
        this._WhatsNewIn202425ToolStripMenuItem.Click -= eventHandler;
      this._WhatsNewIn202425ToolStripMenuItem = value;
      if (this._WhatsNewIn202425ToolStripMenuItem == null)
        return;
      this._WhatsNewIn202425ToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem14
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem14;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripMenuItem14 = value;
    }
  }

  internal virtual ToolStripMenuItem MailToMemberToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MailToMemberToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._MailToMemberToolStripMenuItem = value;
    }
  }

  internal virtual ToolStripMenuItem MailToCommitteeToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MailToCommitteeToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._MailToCommitteeToolStripMenuItem = value;
    }
  }

  internal virtual ToolStripMenuItem EmailIdSettingToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._EmailIdSettingToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.EmailIdSettingToolStripMenuItem_Click);
      if (this._EmailIdSettingToolStripMenuItem != null)
        this._EmailIdSettingToolStripMenuItem.Click -= eventHandler;
      this._EmailIdSettingToolStripMenuItem = value;
      if (this._EmailIdSettingToolStripMenuItem == null)
        return;
      this._EmailIdSettingToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem WhatsupToMemberToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._WhatsupToMemberToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._WhatsupToMemberToolStripMenuItem = value;
    }
  }

  internal virtual ToolStripMenuItem WhatsupToCommitteeToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._WhatsupToCommitteeToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._WhatsupToCommitteeToolStripMenuItem = value;
    }
  }

  internal virtual ToolStripMenuItem WhatsupSettingToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._WhatsupSettingToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.WhatsupSettingToolStripMenuItem_Click);
      if (this._WhatsupSettingToolStripMenuItem != null)
        this._WhatsupSettingToolStripMenuItem.Click -= eventHandler;
      this._WhatsupSettingToolStripMenuItem = value;
      if (this._WhatsupSettingToolStripMenuItem == null)
        return;
      this._WhatsupSettingToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ToolStripMenuItem15
  {
    [DebuggerNonUserCode] get => this._ToolStripMenuItem15;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._ToolStripMenuItem15 = value;
    }
  }

  internal virtual ToolStripMenuItem InterestZerowiseToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._InterestZerowiseToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.InterestZerowiseToolStripMenuItem_Click);
      if (this._InterestZerowiseToolStripMenuItem != null)
        this._InterestZerowiseToolStripMenuItem.Click -= eventHandler;
      this._InterestZerowiseToolStripMenuItem = value;
      if (this._InterestZerowiseToolStripMenuItem == null)
        return;
      this._InterestZerowiseToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem InterestCalculateToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._InterestCalculateToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.InterestCalculateToolStripMenuItem_Click);
      if (this._InterestCalculateToolStripMenuItem != null)
        this._InterestCalculateToolStripMenuItem.Click -= eventHandler;
      this._InterestCalculateToolStripMenuItem = value;
      if (this._InterestCalculateToolStripMenuItem == null)
        return;
      this._InterestCalculateToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem DayWiseInterestCalculateToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._DayWiseInterestCalculateToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DayWiseInterestCalculateToolStripMenuItem1_Click);
      if (this._DayWiseInterestCalculateToolStripMenuItem1 != null)
        this._DayWiseInterestCalculateToolStripMenuItem1.Click -= eventHandler;
      this._DayWiseInterestCalculateToolStripMenuItem1 = value;
      if (this._DayWiseInterestCalculateToolStripMenuItem1 == null)
        return;
      this._DayWiseInterestCalculateToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BillSettingToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._BillSettingToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BillSettingToolStripMenuItem1_Click);
      if (this._BillSettingToolStripMenuItem1 != null)
        this._BillSettingToolStripMenuItem1.Click -= eventHandler;
      this._BillSettingToolStripMenuItem1 = value;
      if (this._BillSettingToolStripMenuItem1 == null)
        return;
      this._BillSettingToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BillMasterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._BillMasterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BillMasterToolStripMenuItem1_Click);
      if (this._BillMasterToolStripMenuItem1 != null)
        this._BillMasterToolStripMenuItem1.Click -= eventHandler;
      this._BillMasterToolStripMenuItem1 = value;
      if (this._BillMasterToolStripMenuItem1 == null)
        return;
      this._BillMasterToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BillFormatToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._BillFormatToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BillFormatToolStripMenuItem1_Click);
      if (this._BillFormatToolStripMenuItem1 != null)
        this._BillFormatToolStripMenuItem1.Click -= eventHandler;
      this._BillFormatToolStripMenuItem1 = value;
      if (this._BillFormatToolStripMenuItem1 == null)
        return;
      this._BillFormatToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptToolStripMenuItem4
  {
    [DebuggerNonUserCode] get => this._ReceiptToolStripMenuItem4;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptToolStripMenuItem4_Click);
      if (this._ReceiptToolStripMenuItem4 != null)
        this._ReceiptToolStripMenuItem4.Click -= eventHandler;
      this._ReceiptToolStripMenuItem4 = value;
      if (this._ReceiptToolStripMenuItem4 == null)
        return;
      this._ReceiptToolStripMenuItem4.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberAccountToolStripMenuItem3
  {
    [DebuggerNonUserCode] get => this._MemberAccountToolStripMenuItem3;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberAccountToolStripMenuItem3_Click);
      if (this._MemberAccountToolStripMenuItem3 != null)
        this._MemberAccountToolStripMenuItem3.Click -= eventHandler;
      this._MemberAccountToolStripMenuItem3 = value;
      if (this._MemberAccountToolStripMenuItem3 == null)
        return;
      this._MemberAccountToolStripMenuItem3.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberRegisterToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._MemberRegisterToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberRegisterToolStripMenuItem2_Click);
      if (this._MemberRegisterToolStripMenuItem2 != null)
        this._MemberRegisterToolStripMenuItem2.Click -= eventHandler;
      this._MemberRegisterToolStripMenuItem2 = value;
      if (this._MemberRegisterToolStripMenuItem2 == null)
        return;
      this._MemberRegisterToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem OutstandingReminderToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._OutstandingReminderToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OutstandingReminderToolStripMenuItem1_Click);
      if (this._OutstandingReminderToolStripMenuItem1 != null)
        this._OutstandingReminderToolStripMenuItem1.Click -= eventHandler;
      this._OutstandingReminderToolStripMenuItem1 = value;
      if (this._OutstandingReminderToolStripMenuItem1 == null)
        return;
      this._OutstandingReminderToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem OutstandingLetterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._OutstandingLetterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OutstandingLetterToolStripMenuItem1_Click);
      if (this._OutstandingLetterToolStripMenuItem1 != null)
        this._OutstandingLetterToolStripMenuItem1.Click -= eventHandler;
      this._OutstandingLetterToolStripMenuItem1 = value;
      if (this._OutstandingLetterToolStripMenuItem1 == null)
        return;
      this._OutstandingLetterToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MessageToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._MessageToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MessageToolStripMenuItem1_Click);
      if (this._MessageToolStripMenuItem1 != null)
        this._MessageToolStripMenuItem1.Click -= eventHandler;
      this._MessageToolStripMenuItem1 = value;
      if (this._MessageToolStripMenuItem1 == null)
        return;
      this._MessageToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BalanceConfirmationLetterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._BalanceConfirmationLetterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BalanceConfirmationLetterToolStripMenuItem1_Click);
      if (this._BalanceConfirmationLetterToolStripMenuItem1 != null)
        this._BalanceConfirmationLetterToolStripMenuItem1.Click -= eventHandler;
      this._BalanceConfirmationLetterToolStripMenuItem1 = value;
      if (this._BalanceConfirmationLetterToolStripMenuItem1 == null)
        return;
      this._BalanceConfirmationLetterToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MessageWithPdfToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._MessageWithPdfToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MessageWithPdfToolStripMenuItem2_Click);
      if (this._MessageWithPdfToolStripMenuItem2 != null)
        this._MessageWithPdfToolStripMenuItem2.Click -= eventHandler;
      this._MessageWithPdfToolStripMenuItem2 = value;
      if (this._MessageWithPdfToolStripMenuItem2 == null)
        return;
      this._MessageWithPdfToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BillFormatToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._BillFormatToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BillFormatToolStripMenuItem2_Click);
      if (this._BillFormatToolStripMenuItem2 != null)
        this._BillFormatToolStripMenuItem2.Click -= eventHandler;
      this._BillFormatToolStripMenuItem2 = value;
      if (this._BillFormatToolStripMenuItem2 == null)
        return;
      this._BillFormatToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._ReceiptToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptToolStripMenuItem1_Click);
      if (this._ReceiptToolStripMenuItem1 != null)
        this._ReceiptToolStripMenuItem1.Click -= eventHandler;
      this._ReceiptToolStripMenuItem1 = value;
      if (this._ReceiptToolStripMenuItem1 == null)
        return;
      this._ReceiptToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberAccountToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._MemberAccountToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberAccountToolStripMenuItem1_Click);
      if (this._MemberAccountToolStripMenuItem1 != null)
        this._MemberAccountToolStripMenuItem1.Click -= eventHandler;
      this._MemberAccountToolStripMenuItem1 = value;
      if (this._MemberAccountToolStripMenuItem1 == null)
        return;
      this._MemberAccountToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MemberRegisterToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MemberRegisterToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MemberRegisterToolStripMenuItem_Click);
      if (this._MemberRegisterToolStripMenuItem != null)
        this._MemberRegisterToolStripMenuItem.Click -= eventHandler;
      this._MemberRegisterToolStripMenuItem = value;
      if (this._MemberRegisterToolStripMenuItem == null)
        return;
      this._MemberRegisterToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem OutstandingReminderToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._OutstandingReminderToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.OutstandingReminderToolStripMenuItem2_Click);
      if (this._OutstandingReminderToolStripMenuItem2 != null)
        this._OutstandingReminderToolStripMenuItem2.Click -= eventHandler;
      this._OutstandingReminderToolStripMenuItem2 = value;
      if (this._OutstandingReminderToolStripMenuItem2 == null)
        return;
      this._OutstandingReminderToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MessageToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._MessageToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MessageToolStripMenuItem2_Click);
      if (this._MessageToolStripMenuItem2 != null)
        this._MessageToolStripMenuItem2.Click -= eventHandler;
      this._MessageToolStripMenuItem2 = value;
      if (this._MessageToolStripMenuItem2 == null)
        return;
      this._MessageToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BalanceConfirmationLetterToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._BalanceConfirmationLetterToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BalanceConfirmationLetterToolStripMenuItem2_Click);
      if (this._BalanceConfirmationLetterToolStripMenuItem2 != null)
        this._BalanceConfirmationLetterToolStripMenuItem2.Click -= eventHandler;
      this._BalanceConfirmationLetterToolStripMenuItem2 = value;
      if (this._BalanceConfirmationLetterToolStripMenuItem2 == null)
        return;
      this._BalanceConfirmationLetterToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MessageWithPdfToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MessageWithPdfToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MessageWithPdfToolStripMenuItem_Click);
      if (this._MessageWithPdfToolStripMenuItem != null)
        this._MessageWithPdfToolStripMenuItem.Click -= eventHandler;
      this._MessageWithPdfToolStripMenuItem = value;
      if (this._MessageWithPdfToolStripMenuItem == null)
        return;
      this._MessageWithPdfToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem CommitteeMasterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._CommitteeMasterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CommitteeMasterToolStripMenuItem1_Click);
      if (this._CommitteeMasterToolStripMenuItem1 != null)
        this._CommitteeMasterToolStripMenuItem1.Click -= eventHandler;
      this._CommitteeMasterToolStripMenuItem1 = value;
      if (this._CommitteeMasterToolStripMenuItem1 == null)
        return;
      this._CommitteeMasterToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem IncomeExpenditureToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._IncomeExpenditureToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.IncomeExpenditureToolStripMenuItem_Click);
      if (this._IncomeExpenditureToolStripMenuItem != null)
        this._IncomeExpenditureToolStripMenuItem.Click -= eventHandler;
      this._IncomeExpenditureToolStripMenuItem = value;
      if (this._IncomeExpenditureToolStripMenuItem == null)
        return;
      this._IncomeExpenditureToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BalanceSheetToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._BalanceSheetToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BalanceSheetToolStripMenuItem_Click);
      if (this._BalanceSheetToolStripMenuItem != null)
        this._BalanceSheetToolStripMenuItem.Click -= eventHandler;
      this._BalanceSheetToolStripMenuItem = value;
      if (this._BalanceSheetToolStripMenuItem == null)
        return;
      this._BalanceSheetToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem TrialBalanceToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._TrialBalanceToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TrialBalanceToolStripMenuItem_Click);
      if (this._TrialBalanceToolStripMenuItem != null)
        this._TrialBalanceToolStripMenuItem.Click -= eventHandler;
      this._TrialBalanceToolStripMenuItem = value;
      if (this._TrialBalanceToolStripMenuItem == null)
        return;
      this._TrialBalanceToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem CashBankBookToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._CashBankBookToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CashBankBookToolStripMenuItem1_Click);
      if (this._CashBankBookToolStripMenuItem1 != null)
        this._CashBankBookToolStripMenuItem1.Click -= eventHandler;
      this._CashBankBookToolStripMenuItem1 = value;
      if (this._CashBankBookToolStripMenuItem1 == null)
        return;
      this._CashBankBookToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem LedgerToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._LedgerToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._LedgerToolStripMenuItem = value;
    }
  }

  internal virtual ToolStripMenuItem CodeWiseToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._CodeWiseToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CodeWiseToolStripMenuItem1_Click);
      if (this._CodeWiseToolStripMenuItem1 != null)
        this._CodeWiseToolStripMenuItem1.Click -= eventHandler;
      this._CodeWiseToolStripMenuItem1 = value;
      if (this._CodeWiseToolStripMenuItem1 == null)
        return;
      this._CodeWiseToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem GroupWiseToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._GroupWiseToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GroupWiseToolStripMenuItem1_Click);
      if (this._GroupWiseToolStripMenuItem1 != null)
        this._GroupWiseToolStripMenuItem1.Click -= eventHandler;
      this._GroupWiseToolStripMenuItem1 = value;
      if (this._GroupWiseToolStripMenuItem1 == null)
        return;
      this._GroupWiseToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptPaymentAccoutToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ReceiptPaymentAccoutToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptPaymentAccoutToolStripMenuItem_Click);
      if (this._ReceiptPaymentAccoutToolStripMenuItem != null)
        this._ReceiptPaymentAccoutToolStripMenuItem.Click -= eventHandler;
      this._ReceiptPaymentAccoutToolStripMenuItem = value;
      if (this._ReceiptPaymentAccoutToolStripMenuItem == null)
        return;
      this._ReceiptPaymentAccoutToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptPaymentAccoutwiseToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ReceiptPaymentAccoutwiseToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptPaymentAccoutwiseToolStripMenuItem_Click);
      if (this._ReceiptPaymentAccoutwiseToolStripMenuItem != null)
        this._ReceiptPaymentAccoutwiseToolStripMenuItem.Click -= eventHandler;
      this._ReceiptPaymentAccoutwiseToolStripMenuItem = value;
      if (this._ReceiptPaymentAccoutwiseToolStripMenuItem == null)
        return;
      this._ReceiptPaymentAccoutwiseToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ScheduleToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ScheduleToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ScheduleToolStripMenuItem_Click);
      if (this._ScheduleToolStripMenuItem != null)
        this._ScheduleToolStripMenuItem.Click -= eventHandler;
      this._ScheduleToolStripMenuItem = value;
      if (this._ScheduleToolStripMenuItem == null)
        return;
      this._ScheduleToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MonthlyReportToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._MonthlyReportToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MonthlyReportToolStripMenuItem_Click);
      if (this._MonthlyReportToolStripMenuItem != null)
        this._MonthlyReportToolStripMenuItem.Click -= eventHandler;
      this._MonthlyReportToolStripMenuItem = value;
      if (this._MonthlyReportToolStripMenuItem == null)
        return;
      this._MonthlyReportToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptRegisterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._ReceiptRegisterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptRegisterToolStripMenuItem1_Click);
      if (this._ReceiptRegisterToolStripMenuItem1 != null)
        this._ReceiptRegisterToolStripMenuItem1.Click -= eventHandler;
      this._ReceiptRegisterToolStripMenuItem1 = value;
      if (this._ReceiptRegisterToolStripMenuItem1 == null)
        return;
      this._ReceiptRegisterToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem PaymentRegisterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._PaymentRegisterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PaymentRegisterToolStripMenuItem1_Click);
      if (this._PaymentRegisterToolStripMenuItem1 != null)
        this._PaymentRegisterToolStripMenuItem1.Click -= eventHandler;
      this._PaymentRegisterToolStripMenuItem1 = value;
      if (this._PaymentRegisterToolStripMenuItem1 == null)
        return;
      this._PaymentRegisterToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ContraRegisterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._ContraRegisterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ContraRegisterToolStripMenuItem1_Click);
      if (this._ContraRegisterToolStripMenuItem1 != null)
        this._ContraRegisterToolStripMenuItem1.Click -= eventHandler;
      this._ContraRegisterToolStripMenuItem1 = value;
      if (this._ContraRegisterToolStripMenuItem1 == null)
        return;
      this._ContraRegisterToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem JournalRegisterToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._JournalRegisterToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.JournalRegisterToolStripMenuItem1_Click);
      if (this._JournalRegisterToolStripMenuItem1 != null)
        this._JournalRegisterToolStripMenuItem1.Click -= eventHandler;
      this._JournalRegisterToolStripMenuItem1 = value;
      if (this._JournalRegisterToolStripMenuItem1 == null)
        return;
      this._JournalRegisterToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem IncomeExpenditureToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._IncomeExpenditureToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.IncomeExpenditureToolStripMenuItem1_Click);
      if (this._IncomeExpenditureToolStripMenuItem1 != null)
        this._IncomeExpenditureToolStripMenuItem1.Click -= eventHandler;
      this._IncomeExpenditureToolStripMenuItem1 = value;
      if (this._IncomeExpenditureToolStripMenuItem1 == null)
        return;
      this._IncomeExpenditureToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem BalanceSheetToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._BalanceSheetToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.BalanceSheetToolStripMenuItem1_Click);
      if (this._BalanceSheetToolStripMenuItem1 != null)
        this._BalanceSheetToolStripMenuItem1.Click -= eventHandler;
      this._BalanceSheetToolStripMenuItem1 = value;
      if (this._BalanceSheetToolStripMenuItem1 == null)
        return;
      this._BalanceSheetToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem TrialBalanceToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._TrialBalanceToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.TrialBalanceToolStripMenuItem1_Click);
      if (this._TrialBalanceToolStripMenuItem1 != null)
        this._TrialBalanceToolStripMenuItem1.Click -= eventHandler;
      this._TrialBalanceToolStripMenuItem1 = value;
      if (this._TrialBalanceToolStripMenuItem1 == null)
        return;
      this._TrialBalanceToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem CashBankBookToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._CashBankBookToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CashBankBookToolStripMenuItem2_Click);
      if (this._CashBankBookToolStripMenuItem2 != null)
        this._CashBankBookToolStripMenuItem2.Click -= eventHandler;
      this._CashBankBookToolStripMenuItem2 = value;
      if (this._CashBankBookToolStripMenuItem2 == null)
        return;
      this._CashBankBookToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem AccountLedgerToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._AccountLedgerToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      this._AccountLedgerToolStripMenuItem1 = value;
    }
  }

  internal virtual ToolStripMenuItem CodewiseToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._CodewiseToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.CodewiseToolStripMenuItem2_Click);
      if (this._CodewiseToolStripMenuItem2 != null)
        this._CodewiseToolStripMenuItem2.Click -= eventHandler;
      this._CodewiseToolStripMenuItem2 = value;
      if (this._CodewiseToolStripMenuItem2 == null)
        return;
      this._CodewiseToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem GroupWiseToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._GroupWiseToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GroupWiseToolStripMenuItem2_Click);
      if (this._GroupWiseToolStripMenuItem2 != null)
        this._GroupWiseToolStripMenuItem2.Click -= eventHandler;
      this._GroupWiseToolStripMenuItem2 = value;
      if (this._GroupWiseToolStripMenuItem2 == null)
        return;
      this._GroupWiseToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptPaymentGroupwiseToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ReceiptPaymentGroupwiseToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptPaymentGroupwiseToolStripMenuItem_Click);
      if (this._ReceiptPaymentGroupwiseToolStripMenuItem != null)
        this._ReceiptPaymentGroupwiseToolStripMenuItem.Click -= eventHandler;
      this._ReceiptPaymentGroupwiseToolStripMenuItem = value;
      if (this._ReceiptPaymentGroupwiseToolStripMenuItem == null)
        return;
      this._ReceiptPaymentGroupwiseToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptPaymentAccoutwiseToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._ReceiptPaymentAccoutwiseToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptPaymentAccoutwiseToolStripMenuItem1_Click);
      if (this._ReceiptPaymentAccoutwiseToolStripMenuItem1 != null)
        this._ReceiptPaymentAccoutwiseToolStripMenuItem1.Click -= eventHandler;
      this._ReceiptPaymentAccoutwiseToolStripMenuItem1 = value;
      if (this._ReceiptPaymentAccoutwiseToolStripMenuItem1 == null)
        return;
      this._ReceiptPaymentAccoutwiseToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ScheduleToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._ScheduleToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ScheduleToolStripMenuItem2_Click);
      if (this._ScheduleToolStripMenuItem2 != null)
        this._ScheduleToolStripMenuItem2.Click -= eventHandler;
      this._ScheduleToolStripMenuItem2 = value;
      if (this._ScheduleToolStripMenuItem2 == null)
        return;
      this._ScheduleToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem MonthlyReportToolStripMenuItem1
  {
    [DebuggerNonUserCode] get => this._MonthlyReportToolStripMenuItem1;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MonthlyReportToolStripMenuItem1_Click);
      if (this._MonthlyReportToolStripMenuItem1 != null)
        this._MonthlyReportToolStripMenuItem1.Click -= eventHandler;
      this._MonthlyReportToolStripMenuItem1 = value;
      if (this._MonthlyReportToolStripMenuItem1 == null)
        return;
      this._MonthlyReportToolStripMenuItem1.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptRegisterToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._ReceiptRegisterToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptRegisterToolStripMenuItem2_Click);
      if (this._ReceiptRegisterToolStripMenuItem2 != null)
        this._ReceiptRegisterToolStripMenuItem2.Click -= eventHandler;
      this._ReceiptRegisterToolStripMenuItem2 = value;
      if (this._ReceiptRegisterToolStripMenuItem2 == null)
        return;
      this._ReceiptRegisterToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem PaymentRegisterToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._PaymentRegisterToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PaymentRegisterToolStripMenuItem2_Click);
      if (this._PaymentRegisterToolStripMenuItem2 != null)
        this._PaymentRegisterToolStripMenuItem2.Click -= eventHandler;
      this._PaymentRegisterToolStripMenuItem2 = value;
      if (this._PaymentRegisterToolStripMenuItem2 == null)
        return;
      this._PaymentRegisterToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ContraRegisterToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._ContraRegisterToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ContraRegisterToolStripMenuItem2_Click);
      if (this._ContraRegisterToolStripMenuItem2 != null)
        this._ContraRegisterToolStripMenuItem2.Click -= eventHandler;
      this._ContraRegisterToolStripMenuItem2 = value;
      if (this._ContraRegisterToolStripMenuItem2 == null)
        return;
      this._ContraRegisterToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem JournalRegisterToolStripMenuItem2
  {
    [DebuggerNonUserCode] get => this._JournalRegisterToolStripMenuItem2;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.JournalRegisterToolStripMenuItem2_Click);
      if (this._JournalRegisterToolStripMenuItem2 != null)
        this._JournalRegisterToolStripMenuItem2.Click -= eventHandler;
      this._JournalRegisterToolStripMenuItem2 = value;
      if (this._JournalRegisterToolStripMenuItem2 == null)
        return;
      this._JournalRegisterToolStripMenuItem2.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptPaymentGroupwiseMarathiToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ReceiptPaymentGroupwiseMarathiToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptPaymentGroupwiseMarathiToolStripMenuItem_Click);
      if (this._ReceiptPaymentGroupwiseMarathiToolStripMenuItem != null)
        this._ReceiptPaymentGroupwiseMarathiToolStripMenuItem.Click -= eventHandler;
      this._ReceiptPaymentGroupwiseMarathiToolStripMenuItem = value;
      if (this._ReceiptPaymentGroupwiseMarathiToolStripMenuItem == null)
        return;
      this._ReceiptPaymentGroupwiseMarathiToolStripMenuItem.Click += eventHandler;
    }
  }

  internal virtual ToolStripMenuItem ReceiptPaymentAccountwiseMarathiToolStripMenuItem
  {
    [DebuggerNonUserCode] get => this._ReceiptPaymentAccountwiseMarathiToolStripMenuItem;
    [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReceiptPaymentAccountwiseMarathiToolStripMenuItem_Click);
      if (this._ReceiptPaymentAccountwiseMarathiToolStripMenuItem != null)
        this._ReceiptPaymentAccountwiseMarathiToolStripMenuItem.Click -= eventHandler;
      this._ReceiptPaymentAccountwiseMarathiToolStripMenuItem = value;
      if (this._ReceiptPaymentAccountwiseMarathiToolStripMenuItem == null)
        return;
      this._ReceiptPaymentAccountwiseMarathiToolStripMenuItem.Click += eventHandler;
    }
  }

  private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
  {
  }

  private void GroupToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmGroup.ShowDialog();
    MyProject.Forms.frmGroup = (frmGroup) null;
  }

  private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "M";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    MyProject.Forms.frmAccount.lblAccountType.Text = "All";
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    MyProject.Forms.frmAccount = (frmAccount) null;
  }

  private void MemberToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "M";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    MyProject.Forms.frmMember = (frmMember) null;
  }

  private void MemberBillingToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    MyProject.Forms.frmMemberBillMasterSelect.lblType.Text = "1";
    MyProject.Forms.frmMemberBillMasterSelect.lblHeading.Text = " Member Bill Master ";
    int num = (int) MyProject.Forms.frmMemberBillMasterSelect.ShowDialog();
  }

  private void PaymentToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount >= 1)
    {
      if (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount >= 1)
      {
        MyProject.Forms.frmPayment.lblTrType.Text = "Pymt";
        MyProject.Forms.frmPayment.Text = "Payment Voucher List";
        int num = (int) MyProject.Forms.frmPayment.ShowDialog();
        MyProject.Forms.frmPayment = (frmPayment) null;
      }
      else
      {
        int num1 = (int) Interaction.MsgBox((object) "First create General Account");
      }
    }
    else
    {
      int num2 = (int) Interaction.MsgBox((object) "First create Cash /Bank Account");
    }
  }

  private void MemberReceiptToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount >= 1)
    {
      MyProject.Forms.frmMemReceipt.lblTrType.Text = "MRct";
      MyProject.Forms.frmMemReceipt.Text = "Member Receipt List";
      int num = (int) MyProject.Forms.frmMemReceipt.ShowDialog();
      MyProject.Forms.frmMemReceipt = (frmMemReceipt) null;
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "First create Member Account");
    }
  }

  private void MemberBillToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount >= 1)
    {
      MyProject.Forms.frmMemBilling.lblTrType.Text = "MBil";
      MyProject.Forms.frmMemBilling.Text = "Member Bill List";
      int num = (int) MyProject.Forms.frmMemBilling.ShowDialog();
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "First create Member Account");
    }
  }

  private void ReceiptToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount >= 1)
    {
      if (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount >= 1)
      {
        MyProject.Forms.frmPayment.lblTrType.Text = "Rcpt";
        MyProject.Forms.frmPayment.Text = "Receipt Voucher List";
        int num = (int) MyProject.Forms.frmPayment.ShowDialog();
        MyProject.Forms.frmPayment = (frmPayment) null;
      }
      else
      {
        int num1 = (int) Interaction.MsgBox((object) "First create General Account");
      }
    }
    else
    {
      int num2 = (int) Interaction.MsgBox((object) "First create Cash /Bank Account");
    }
  }

  private void JournalToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount >= 1)
    {
      MyProject.Forms.frmPayment.lblTrType.Text = "Jrnl";
      MyProject.Forms.frmPayment.Text = "Journal Voucher List";
      int num = (int) MyProject.Forms.frmPayment.ShowDialog();
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "First create General Account");
    }
  }

  private void SocietyToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmSocietyMaster.ShowDialog();
    MyProject.Forms.frmSocietyMaster = (frmSocietyMaster) null;
  }

  private void GroupToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportGroupList.ShowDialog();
    MyProject.Forms.frmReportGroupList = (frmReportGroupList) null;
  }

  private void AccountToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmreportAccountList.ShowDialog();
    MyProject.Forms.frmreportAccountList = (frmreportAccountList) null;
  }

  private void ContraToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount >= 1)
    {
      MyProject.Forms.frmPayment.lblTrType.Text = "Ctra";
      MyProject.Forms.frmPayment.Text = "Contra Voucher List";
      int num = (int) MyProject.Forms.frmPayment.ShowDialog();
      MyProject.Forms.frmPayment = (frmPayment) null;
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "First create Cash /Bank Account");
    }
  }

  private void OpeningBankRecoToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount >= 1)
    {
      MyProject.Forms.frmPayment.lblTrType.Text = "OpBR";
      MyProject.Forms.frmPayment.Text = "Opening Bank Reco. Voucher List";
      int num = (int) MyProject.Forms.frmPayment.ShowDialog();
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "First create Cash /Bank Account");
    }
  }

  private void RenumberToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmRenumber.ShowDialog();
    MyProject.Forms.frmRenumber = (frmRenumber) null;
  }

  private void MemberAdjustmentToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount >= 1)
    {
      MyProject.Forms.frmMemReceipt.lblTrType.Text = "MAdj";
      MyProject.Forms.frmMemReceipt.Text = "Member Adjustment List";
      int num = (int) MyProject.Forms.frmMemReceipt.ShowDialog();
      MyProject.Forms.frmMemReceipt = (frmMemReceipt) null;
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "First create Member Account");
    }
  }

  private void MemberDebitNoteToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount >= 1)
    {
      MyProject.Forms.frmMemBilling.lblTrType.Text = "MDbn";
      MyProject.Forms.frmMemBilling.Text = "Member Debit Note List";
      int num = (int) MyProject.Forms.frmMemBilling.ShowDialog();
      MyProject.Forms.frmMemBilling = (frmMemBilling) null;
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "First create Member Account");
    }
  }

  private void MemberCreditNoteToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount >= 1)
    {
      MyProject.Forms.frmMemBilling.lblTrType.Text = "MCrn";
      MyProject.Forms.frmMemBilling.Text = "Member Credit Note List";
      int num = (int) MyProject.Forms.frmMemBilling.ShowDialog();
      MyProject.Forms.frmMemBilling = (frmMemBilling) null;
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "First create Member Account");
    }
  }

  private void BankRecoToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "4", false) == 0)
      return;
    int num = (int) MyProject.Forms.frmBankReco.ShowDialog();
    MyProject.Forms.frmBankReco = (frmBankReco) null;
  }

  private void TranferToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmTransfer.ShowDialog();
    MyProject.Forms.frmTransfer = (frmTransfer) null;
  }

  private void ToolStripButton14_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmGroup.ShowDialog();
    MyProject.Forms.frmGroup = (frmGroup) null;
  }

  private void ToolStripButton11_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "M";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    MyProject.Forms.frmAccount.lblAccountType.Text = "All";
    int num = (int) MyProject.Forms.frmAccount.ShowDialog();
    MyProject.Forms.frmAccount = (frmAccount) null;
  }

  private void ToolStripButton1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "M";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    MyProject.Forms.frmMember = (frmMember) null;
  }

  private void ToolStripButton7_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount >= 1)
    {
      MyProject.Forms.frmMemReceipt.lblTrType.Text = "MRct";
      MyProject.Forms.frmMemReceipt.Text = "Member Receipt List";
      int num = (int) MyProject.Forms.frmMemReceipt.ShowDialog();
      MyProject.Forms.frmMemReceipt = (frmMemReceipt) null;
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "First create Member Account");
    }
  }

  private void ToolStripButton5_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount >= 1)
    {
      if (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount >= 1)
      {
        MyProject.Forms.frmPayment.lblTrType.Text = "Pymt";
        MyProject.Forms.frmPayment.Text = "Payment Voucher List";
        int num = (int) MyProject.Forms.frmPayment.ShowDialog();
        MyProject.Forms.frmPayment = (frmPayment) null;
      }
      else
      {
        int num1 = (int) Interaction.MsgBox((object) "First create General Account");
      }
    }
    else
    {
      int num2 = (int) Interaction.MsgBox((object) "First create Cash /Bank Account");
    }
  }

  private void ToolStripButton4_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount >= 1)
    {
      if (MyProject.Forms.frmConstantGrid.DataGridViewNonCashAccount.RowCount >= 1)
      {
        MyProject.Forms.frmPayment.lblTrType.Text = "Rcpt";
        MyProject.Forms.frmPayment.Text = "Receipt Voucher List";
        int num = (int) MyProject.Forms.frmPayment.ShowDialog();
        MyProject.Forms.frmPayment = (frmPayment) null;
      }
      else
      {
        int num1 = (int) Interaction.MsgBox((object) "First create General Account");
      }
    }
    else
    {
      int num2 = (int) Interaction.MsgBox((object) "First create Cash /Bank Account");
    }
  }

  private void ToolStripButton8_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewCashAccount.RowCount >= 1)
    {
      MyProject.Forms.frmPayment.lblTrType.Text = "Ctra";
      MyProject.Forms.frmPayment.Text = "Contra Voucher List";
      int num = (int) MyProject.Forms.frmPayment.ShowDialog();
      MyProject.Forms.frmPayment = (frmPayment) null;
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "First create Cash /Bank Account");
    }
  }

  private void ToolStripButton2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    int num = (int) MyProject.Forms.frmBankReco.ShowDialog();
    MyProject.Forms.frmBankReco = (frmBankReco) null;
  }

  private void ToolStripButton9_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportMemberReceiptPrint.lblType.Text = "MRct";
    int num = (int) MyProject.Forms.frmReportMemberReceiptPrint.ShowDialog();
    MyProject.Forms.frmReportMemberReceiptPrint = (frmReportMemberReceiptPrint) null;
  }

  private void ToolStripButton10_Click(object sender, EventArgs e)
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocInfo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    System.Data.DataTable dataTable = new System.Data.DataTable("SocBillSetting");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "1. Half Page (Bill)", false) == 0)
    {
      MyProject.Forms.frmReportBillFullPage.lblType.Text = "MBil";
      MyProject.Forms.frmReportBillFullPage.rb3.Checked = true;
      MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "BILL";
      int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
      MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "2. Half Page Vertical (Bill)", false) == 0)
    {
      MyProject.Forms.frmReportBillFullPage.lblType.Text = "MBil";
      MyProject.Forms.frmReportBillFullPage.rb5.Checked = true;
      MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "BILL";
      int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
      MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "3. Half Page Vertical Double (Bill)", false) == 0)
    {
      MyProject.Forms.frmReportBillFullPage.lblType.Text = "MBil";
      MyProject.Forms.frmReportBillFullPage.rb6.Checked = true;
      MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "BILL";
      int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
      MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "4. Full Page (Bill)", false) == 0)
    {
      MyProject.Forms.frmReportBillFullPage.lblType.Text = "MBil";
      MyProject.Forms.frmReportBillFullPage.rb10.Checked = true;
      MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "BILL";
      int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
      MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "5. Full Page New (Bill)", false) == 0)
    {
      MyProject.Forms.frmReportBillFullPage.lblType.Text = "MBil";
      MyProject.Forms.frmReportBillFullPage.rb11.Checked = true;
      MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "BILL";
      int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
      MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "6. Half Page (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb3.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "7. Full Page - 21 Head (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb6.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "8. Full Page - 14 Head New (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb5.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "9. Full Page - 14 Head Old (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb4.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "10. Full Page - 21 Head New (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb9.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "11.Full Page - GST (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb7.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "12.Full Page - GST1 (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb8.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "11. Half Page - vertical (Marathi)", false) == 0)
    {
      MyProject.Forms.frmReportBillFullPage.lblType.Text = "MBil";
      MyProject.Forms.frmReportBillFullPage.rb12.Checked = true;
      MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "देयक";
      int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
      MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "12. Full Page - 21 Head New (Bill with Receipt)(Marathi)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb12.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "देयक";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "13.Full Page - GST (Bill with Receipt)(With address)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb13.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "11.Full Page - 21 Head (Bill with Receipt) Format-1", false) != 0)
      return;
    MyProject.Forms.frmReportBillWithReceipt.rb10.Checked = true;
    MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
    MyProject.Forms.frmReportBillWithReceipt.txtPrintReceiptName.Text = "N";
    int num1 = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
    MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
  }

  private void ToolStripButton6_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportMemberOutstandingNew.ShowDialog();
    MyProject.Forms.frmReportMemberOutstandingNew = (frmReportMemberOutstandingNew) null;
  }

  private void ToolStripButton3_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportMemberAccountNew.ShowDialog();
    MyProject.Forms.frmReportMemberAccountNew = (frmReportMemberAccountNew) null;
  }

  private void ToolStripButton13_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportAccountLedgerNew.ShowDialog();
    MyProject.Forms.frmReportAccountLedgerNew = (frmReportAccountLedgerNew) null;
  }

  private void ToolStripButton15_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.FrmReportTrialBalance.ShowDialog();
    MyProject.Forms.FrmReportTrialBalance = (FrmReportTrialBalance) null;
  }

  private void ToolStripButton16_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportIncomeExpenditure.ShowDialog();
    MyProject.Forms.frmReportIncomeExpenditure = (frmReportIncomeExpenditure) null;
  }

  private void ToolStripButton17_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportBalanceSheet.ShowDialog();
    MyProject.Forms.frmReportBalanceSheet = (frmReportBalanceSheet) null;
  }

  private void ToolStripButton18_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportMemberBillRegisterNew.lblType.Text = "MBil";
    MyProject.Forms.frmReportMemberBillRegisterNew.cmbReportType.Text = "Data Sheet";
    int num = (int) MyProject.Forms.frmReportMemberBillRegisterNew.ShowDialog();
    MyProject.Forms.frmReportMemberBillRegisterNew = (frmReportMemberBillRegisterNew) null;
  }

  private void ToolStripButton12_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPVRegister.lblType.Text = "MRct";
    MyProject.Forms.frmReportPVRegister.cmbReportType.Text = "Cheque Deposit List";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
    MyProject.Forms.frmReportPVRegister = (frmReportPVRegister) null;
  }

  private void MemberAccountToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportMemberAccountNew.ShowDialog();
    MyProject.Forms.frmReportMemberAccountNew = (frmReportMemberAccountNew) null;
  }

  private void OutstandingListToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportMemberOutstandingNew.ShowDialog();
    MyProject.Forms.frmReportMemberOutstandingNew = (frmReportMemberOutstandingNew) null;
  }

  private void TrialBalanceToolStripMenuItem3_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.FrmReportTrialBalance.ShowDialog();
    MyProject.Forms.FrmReportTrialBalance = (FrmReportTrialBalance) null;
  }

  private void ReceiptToolStripMenuItem3_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportMemberReceiptPrint.lblType.Text = "MRct";
    MyProject.Forms.frmReportMemberReceiptPrint.lblReportType.Text = "0";
    int num = (int) MyProject.Forms.frmReportMemberReceiptPrint.ShowDialog();
    MyProject.Forms.frmReportMemberReceiptPrint = (frmReportMemberReceiptPrint) null;
  }

  private void BalanceSheetToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportBalanceSheet.ShowDialog();
    MyProject.Forms.frmReportBalanceSheet = (frmReportBalanceSheet) null;
  }

  private void BillToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocInfo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    System.Data.DataTable dataTable = new System.Data.DataTable("SocBillSetting");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "1. Half Page (Bill)", false) == 0)
    {
      MyProject.Forms.frmReportBillFullPage.lblType.Text = "MBil";
      MyProject.Forms.frmReportBillFullPage.rb3.Checked = true;
      MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillFullPage.Text = "1. Half Page (Bill)";
      int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
      MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "2. Half Page Vertical (Bill)", false) == 0)
    {
      MyProject.Forms.frmReportBillFullPage.lblType.Text = "MBil";
      MyProject.Forms.frmReportBillFullPage.rb5.Checked = true;
      MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillFullPage.Text = "2. Half Page Vertical (Bill)";
      int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
      MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "3. Half Page Vertical Double (Bill)", false) == 0)
    {
      MyProject.Forms.frmReportBillFullPage.lblType.Text = "MBil";
      MyProject.Forms.frmReportBillFullPage.rb6.Checked = true;
      MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillFullPage.Text = "3. Half Page Vertical Double (Bill)";
      int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
      MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "4. Full Page (Bill)", false) == 0)
    {
      MyProject.Forms.frmReportBillFullPage.lblType.Text = "MBil";
      MyProject.Forms.frmReportBillFullPage.rb10.Checked = true;
      MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillFullPage.Text = "4. Full Page (Bill)";
      int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
      MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "5. Full Page New (Bill)", false) == 0)
    {
      MyProject.Forms.frmReportBillFullPage.lblType.Text = "MBil";
      MyProject.Forms.frmReportBillFullPage.rb11.Checked = true;
      MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillFullPage.Text = "5. Full Page New (Bill)";
      int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
      MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "6. Half Page (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb3.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillWithReceipt.Text = "6. Half Page (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "7. Full Page - 21 Head (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb6.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillWithReceipt.Text = "7. Full Page - 21 Head (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "8. Full Page - 14 Head New (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb5.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillWithReceipt.Text = "8. Full Page - 14 Head New (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "9. Full Page - 14 Head Old (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb4.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillWithReceipt.Text = "9. Full Page - 14 Head Old (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "10. Full Page - 21 Head New (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb9.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillWithReceipt.Text = "10. Full Page - 21 Head New (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "11.Full Page - 21 Head (Bill with Receipt) Format-1", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb10.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillWithReceipt.txtPrintReceiptName.Text = "N";
      MyProject.Forms.frmReportBillWithReceipt.Text = "11.Full Page - 21 Head (Bill with Receipt) Format-1";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "12.Full Page - 21 Head (Bill with Receipt) Format-2", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb14.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillWithReceipt.txtPrintReceiptName.Text = "N";
      MyProject.Forms.frmReportBillWithReceipt.Text = "12.Full Page - 21 Head (Bill with Receipt) Format-2";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "G01.Full Page - GST (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb7.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillWithReceipt.Text = "G01.Full Page - GST (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "G02.Full Page - GST1 (Bill with Receipt)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb8.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillWithReceipt.Text = "G02.Full Page - GST1 (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "G03.Full Page - GST (Bill with Receipt)(With address)", false) == 0)
    {
      MyProject.Forms.frmReportBillWithReceipt.rb13.Checked = true;
      MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
      MyProject.Forms.frmReportBillWithReceipt.Text = "G03.Full Page - GST (Bill with Receipt)(With address)";
      int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
      MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "M01. Half Page - vertical (Marathi)", false) == 0)
    {
      MyProject.Forms.frmReportBillFullPage.lblType.Text = "MBil";
      MyProject.Forms.frmReportBillFullPage.rb12.Checked = true;
      MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "देयक";
      MyProject.Forms.frmReportBillFullPage.Text = "M01. Half Page - vertical (Marathi)";
      int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
      MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "M02. Full Page - 21 Head New (Bill with Receipt)(Marathi)", false) != 0)
      return;
    MyProject.Forms.frmReportBillWithReceipt.rb12.Checked = true;
    MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "देयक";
    MyProject.Forms.frmReportBillWithReceipt.Text = "M02. Full Page - 21 Head New (Bill with Receipt)(Marathi)";
    int num1 = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
    MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
  }

  private void EmailToolStripMenuItem_Click(object sender, EventArgs e)
  {
  }

  private void IncomeExpenditureAcToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportIncomeExpenditure.ShowDialog();
    MyProject.Forms.frmReportIncomeExpenditure = (frmReportIncomeExpenditure) null;
  }

  private void ScheduleToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportSchedule.ShowDialog();
    MyProject.Forms.frmReportSchedule = (frmReportSchedule) null;
  }

  private void MemberBillToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportBillDetail.lblType.Text = "MBil";
    int num = (int) MyProject.Forms.frmReportBillDetail.ShowDialog();
    MyProject.Forms.frmReportBillDetail = (frmReportBillDetail) null;
  }

  private void MemberDebitNoteToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportBillDetail.lblType.Text = "MDbn";
    int num = (int) MyProject.Forms.frmReportBillDetail.ShowDialog();
    MyProject.Forms.frmReportBillDetail = (frmReportBillDetail) null;
  }

  private void MemberCreditNoteToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportBillDetail.lblType.Text = "MCrn";
    int num = (int) MyProject.Forms.frmReportBillDetail.ShowDialog();
    MyProject.Forms.frmReportBillDetail = (frmReportBillDetail) null;
  }

  private void frmMenu_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Escape || !this.MS.Visible)
      return;
    MyProject.Forms.frmCloseConfirm.lblStatus.Text = "0";
    int num = (int) MyProject.Forms.frmCloseConfirm.ShowDialog();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(MyProject.Forms.frmCloseConfirm.lblStatus.Text, "1", false) == 0)
      this.Close();
  }

  private void frmMenu_Load(object sender, EventArgs e)
  {
    this.DataGridView1.Visible = false;
    this.TS.Visible = false;
    this.MS.Visible = false;
    MyProject.Forms.LoginForm1.MdiParent = (Form) this;
    MyProject.Forms.LoginForm1.Show();
    MyProject.Forms.frmBillMasterOnOff.cmbBillMasterOnOff.Text = "Off";
  }

  private void ReceiptPaymentAcToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportReceiptPayment.ShowDialog();
    MyProject.Forms.frmReportReceiptPayment = (frmReportReceiptPayment) null;
  }

  private void YearCfToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmYearcf.ShowDialog();
  }

  private void BillWithReceiptToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
    int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
    MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
  }

  private void DebitNoteToolStripMenuItem_Click(object sender, EventArgs e)
  {
  }

  private void CreditNoteToolStripMenuItem_Click(object sender, EventArgs e)
  {
  }

  private void GroupReceiptPaymentAcToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportReceiptPaymentGroup.ShowDialog();
    MyProject.Forms.frmReportReceiptPaymentGroup = (frmReportReceiptPaymentGroup) null;
  }

  private void PaymentVoucherToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPayment.lblType.Text = "Pymt";
    int num = (int) MyProject.Forms.frmReportPayment.ShowDialog();
  }

  private void ReceiptVoucherToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPayment.lblType.Text = "Rcpt";
    int num = (int) MyProject.Forms.frmReportPayment.ShowDialog();
  }

  private void ContraVoucherToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPayment.lblType.Text = "Ctra";
    int num = (int) MyProject.Forms.frmReportPayment.ShowDialog();
  }

  private void DefultGroupSettingToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmDefaultGroupSetting.ShowDialog();
    MyProject.Forms.frmDefaultGroupSetting = (frmDefaultGroupSetting) null;
  }

  private void QuickNoteToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "4", false) == 0)
      return;
    string str = Constant.socDataPath + "\\societyInfo.txt";
    if (File.Exists(str))
      Process.Start(str);
  }

  private void CashBankBookToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportAccountCashBank.ShowDialog();
    MyProject.Forms.frmReportAccountCashBank = (frmReportAccountCashBank) null;
  }

  private void RebuildToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmRebuild.ShowDialog();
    MyProject.Forms.frmRebuild = (frmRebuild) null;
  }

  private void AccountLedgerToolStripMenuItem_Click(object sender, EventArgs e)
  {
  }

  private void DebitNoteRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportMemberBillRegisterNew.lblType.Text = "MDbn";
    int num = (int) MyProject.Forms.frmReportMemberBillRegisterNew.ShowDialog();
    MyProject.Forms.frmReportMemberBillRegisterNew = (frmReportMemberBillRegisterNew) null;
  }

  private void CreditNoteRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportMemberBillRegisterNew.lblType.Text = "MCrn";
    int num = (int) MyProject.Forms.frmReportMemberBillRegisterNew.ShowDialog();
    MyProject.Forms.frmReportMemberBillRegisterNew = (frmReportMemberBillRegisterNew) null;
  }

  private void DataSheetToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportMemberBillRegisterNew.lblType.Text = "MBil";
    MyProject.Forms.frmReportMemberBillRegisterNew.cmbReportType.Text = "Data Sheet";
    int num = (int) MyProject.Forms.frmReportMemberBillRegisterNew.ShowDialog();
    MyProject.Forms.frmReportMemberBillRegisterNew = (frmReportMemberBillRegisterNew) null;
  }

  private void BankDepositListToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPVRegister.lblType.Text = "MRct";
    MyProject.Forms.frmReportPVRegister.cmbReportType.Text = "Cheque Deposit List";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
    MyProject.Forms.frmReportPVRegister = (frmReportPVRegister) null;
  }

  private void ReceiptRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPVRegister.lblType.Text = "MRct";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
    MyProject.Forms.frmReportPVRegister = (frmReportPVRegister) null;
  }

  private void AdjustmentRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPVRegister.lblType.Text = "MAdj";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
    MyProject.Forms.frmReportPVRegister = (frmReportPVRegister) null;
  }

  private void ReceiptRegiToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPVRegister.lblType.Text = "Rcpt";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
  }

  private void PaymentRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPVRegister.lblType.Text = "Pymt";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
  }

  private void ContraRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPVRegister.lblType.Text = "Ctra";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
  }

  private void JournalRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPVRegister.lblType.Text = "Jrnl";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
  }

  private void ToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportMemberMemberRegisterNew.ShowDialog();
    MyProject.Forms.frmReportMemberMemberRegisterNew = (frmReportMemberMemberRegisterNew) null;
  }

  private void ToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT SocAccount.SocAccountMainId, SocAccount.AccCode, SocAccount.AccName, SocBillSetting.SocBSAccId, SocBillSetting.SocAccountMainId, SocBillSetting.AccIndex, SocBillSetting.AccShortName, SocAccountMain.SocAccountMainId, SocAccountMain.SocSubGroupId, SocAccountMain.SocGroupId, SocAccountMain.GrpMainId FROM SocAccountMain INNER JOIN (SocBillSetting INNER JOIN SocAccount ON SocBillSetting.SocAccountMainId = SocAccount.SocAccountMainId) ON SocAccountMain.SocAccountMainId = SocAccount.SocAccountMainId order by SocBillSetting.AccIndex asc", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    System.Data.DataTable dataTable = new System.Data.DataTable("SocBillSetting");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView3.DataSource = (object) dataTable;
    this.DataGridView3.ReadOnly = true;
    this.DataGridView3.RowHeadersVisible = false;
    this.DataGridView3.AllowUserToAddRows = false;
  }

  private void ToolStripButton19_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportAccountCashBank.ShowDialog();
    MyProject.Forms.frmReportAccountCashBank = (frmReportAccountCashBank) null;
  }

  private void ChangeYearToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmSocSelectionChange.ShowDialog();
    MyProject.Forms.frmSocSelectionChange = (frmSocSelectionChange) null;
  }

  private void ToolStripMenuItem4_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportMemberConfirmationNew.ShowDialog();
    MyProject.Forms.frmReportMemberConfirmationNew = (frmReportMemberConfirmationNew) null;
  }

  private void ToolStripMenuItem6_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportMonthly.ShowDialog();
    MyProject.Forms.frmReportMonthly = (frmReportMonthly) null;
  }

  private void ToolStripMenuItem7_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportMemberControlAccount.ShowDialog();
    MyProject.Forms.frmReportMemberControlAccount = (frmReportMemberControlAccount) null;
  }

  private void VendorToolStripMenuItem_Click(object sender, EventArgs e)
  {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    MyProject.Forms.frmVendor.lblTrType.Text = "Vendor";
    MyProject.Forms.frmVendor.Text = "Vendor List";
    int num = (int) MyProject.Forms.frmVendor.ShowDialog();
    MyProject.Forms.frmVendor = (frmVendor) null;
  }

  private void ServantToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "2", false) == 0))
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    MyProject.Forms.frmVendor.lblTrType.Text = "Servant";
    MyProject.Forms.frmVendor.Text = "Servant List";
    int num = (int) MyProject.Forms.frmVendor.ShowDialog();
    MyProject.Forms.frmVendor = (frmVendor) null;
  }

  private void FToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "2", false) == 0))
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    MyProject.Forms.frmVendor.lblTrType.Text = "FDR";
    MyProject.Forms.frmVendor.Text = "Fixed Deposit List";
    int num = (int) MyProject.Forms.frmVendor.ShowDialog();
    MyProject.Forms.frmVendor = (frmVendor) null;
  }

  private void MultiReceiptToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmMultiReceiptMemberSelect1.lblType.Text = "Format1";
    int num = (int) MyProject.Forms.frmMultiReceiptMemberSelect1.ShowDialog();
    MyProject.Forms.frmMultiReceiptMemberSelect1 = (frmMultiReceiptMemberSelect1) null;
  }

  private void MULToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmMultiReceiptMemberSelect1.lblType.Text = "Format2";
    int num = (int) MyProject.Forms.frmMultiReceiptMemberSelect1.ShowDialog();
    MyProject.Forms.frmMultiReceiptMemberSelect1 = (frmMultiReceiptMemberSelect1) null;
  }

  private void ToolStripMenuItem8_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmSubGroup.ShowDialog();
    MyProject.Forms.frmSubGroup = (frmSubGroup) null;
  }

  private void YearBfToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmYearBf.ShowDialog();
  }

  private void NewTtanTypeToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmTranType.ShowDialog();
    MyProject.Forms.frmTranType = (frmTranType) null;
  }

  private void SocietyStatMasterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmStatSocietyDetail.ShowDialog();
    MyProject.Forms.frmStatSocietyDetail = (frmStatSocietyDetail) null;
  }

  private void MasterToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmStatMemberList.ShowDialog();
    MyProject.Forms.frmStatMemberList = (frmStatMemberList) null;
  }

  private void JRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmStatJList.ShowDialog();
    MyProject.Forms.frmStatJList = (frmStatJList) null;
  }

  private void ShareRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmStatSList.ShowDialog();
    MyProject.Forms.frmStatSList = (frmStatSList) null;
  }

  private void IRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmStatNList.ShowDialog();
    MyProject.Forms.frmStatNList = (frmStatNList) null;
  }

  private void IRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmStatIList.ShowDialog();
    MyProject.Forms.frmStatIList = (frmStatIList) null;
  }

  private void PropertyRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmStatPList.ShowDialog();
    MyProject.Forms.frmStatPList = (frmStatPList) null;
  }

  private void SinkingFundLedgerToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmStatSIList.ShowDialog();
    MyProject.Forms.frmStatSIList = (frmStatSIList) null;
  }

  private void InvestmentRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmStatINList.ShowDialog();
    MyProject.Forms.frmStatINList = (frmStatINList) null;
  }

  private void AboutUsToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmAboutUs.ShowDialog();
    MyProject.Forms.frmAboutUs = (frmAboutUs) null;
  }

  private void AuditFormNo28ToolStripMenuItem_Click(object sender, EventArgs e)
  {
    string str = $"{Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}_F28.doc";
    if (!MyProject.Computer.FileSystem.FileExists(str))
      File.Copy(Constant.CnString2 + "\\Data\\Byelaws\\AuditForm28.doc", str, true);
    Microsoft.Office.Interop.Word.Application application = (Microsoft.Office.Interop.Word.Application) new Microsoft.Office.Interop.Word.ApplicationClass();
    Document document1 = (Document) new DocumentClass();
    Documents documents = application.Documents;
    object obj1 = (object) str;
    ref object local1 = ref obj1;
    object obj2 = (object) Missing.Value;
    ref object local2 = ref obj2;
    object obj3 = (object) Missing.Value;
    ref object local3 = ref obj3;
    object obj4 = (object) Missing.Value;
    ref object local4 = ref obj4;
    object obj5 = (object) Missing.Value;
    ref object local5 = ref obj5;
    object obj6 = (object) Missing.Value;
    ref object local6 = ref obj6;
    object obj7 = (object) Missing.Value;
    ref object local7 = ref obj7;
    object obj8 = (object) Missing.Value;
    ref object local8 = ref obj8;
    object obj9 = (object) Missing.Value;
    ref object local9 = ref obj9;
    object obj10 = (object) Missing.Value;
    ref object local10 = ref obj10;
    object obj11 = (object) Missing.Value;
    ref object local11 = ref obj11;
    object obj12 = (object) Missing.Value;
    ref object local12 = ref obj12;
    object obj13 = (object) Missing.Value;
    ref object local13 = ref obj13;
    object obj14 = (object) Missing.Value;
    ref object local14 = ref obj14;
    object obj15 = (object) Missing.Value;
    ref object local15 = ref obj15;
    object obj16 = (object) Missing.Value;
    ref object local16 = ref obj16;
    Document document2 = documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
    Conversions.ToString(obj1);
    document1 = document2;
    application.Visible = true;
  }

  private void AuditFormNo1ToolStripMenuItem_Click(object sender, EventArgs e)
  {
    string str = $"{Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}_F1.doc";
    if (!MyProject.Computer.FileSystem.FileExists(str))
      File.Copy(Constant.CnString2 + "\\Data\\Byelaws\\AuditForm1.doc", str, true);
    Microsoft.Office.Interop.Word.Application application = (Microsoft.Office.Interop.Word.Application) new Microsoft.Office.Interop.Word.ApplicationClass();
    Document document1 = (Document) new DocumentClass();
    Documents documents = application.Documents;
    object obj1 = (object) str;
    ref object local1 = ref obj1;
    object obj2 = (object) Missing.Value;
    ref object local2 = ref obj2;
    object obj3 = (object) Missing.Value;
    ref object local3 = ref obj3;
    object obj4 = (object) Missing.Value;
    ref object local4 = ref obj4;
    object obj5 = (object) Missing.Value;
    ref object local5 = ref obj5;
    object obj6 = (object) Missing.Value;
    ref object local6 = ref obj6;
    object obj7 = (object) Missing.Value;
    ref object local7 = ref obj7;
    object obj8 = (object) Missing.Value;
    ref object local8 = ref obj8;
    object obj9 = (object) Missing.Value;
    ref object local9 = ref obj9;
    object obj10 = (object) Missing.Value;
    ref object local10 = ref obj10;
    object obj11 = (object) Missing.Value;
    ref object local11 = ref obj11;
    object obj12 = (object) Missing.Value;
    ref object local12 = ref obj12;
    object obj13 = (object) Missing.Value;
    ref object local13 = ref obj13;
    object obj14 = (object) Missing.Value;
    ref object local14 = ref obj14;
    object obj15 = (object) Missing.Value;
    ref object local15 = ref obj15;
    object obj16 = (object) Missing.Value;
    ref object local16 = ref obj16;
    Document document2 = documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
    Conversions.ToString(obj1);
    document1 = document2;
    application.Visible = true;
  }

  private void AuditGeneralRemarkToolStripMenuItem_Click(object sender, EventArgs e)
  {
    string str = $"{Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}_GR.doc";
    if (!MyProject.Computer.FileSystem.FileExists(str))
      File.Copy(Constant.CnString2 + "\\Data\\Byelaws\\General_Remark.doc", str, true);
    Microsoft.Office.Interop.Word.Application application = (Microsoft.Office.Interop.Word.Application) new Microsoft.Office.Interop.Word.ApplicationClass();
    Document document1 = (Document) new DocumentClass();
    Documents documents = application.Documents;
    object obj1 = (object) str;
    ref object local1 = ref obj1;
    object obj2 = (object) Missing.Value;
    ref object local2 = ref obj2;
    object obj3 = (object) Missing.Value;
    ref object local3 = ref obj3;
    object obj4 = (object) Missing.Value;
    ref object local4 = ref obj4;
    object obj5 = (object) Missing.Value;
    ref object local5 = ref obj5;
    object obj6 = (object) Missing.Value;
    ref object local6 = ref obj6;
    object obj7 = (object) Missing.Value;
    ref object local7 = ref obj7;
    object obj8 = (object) Missing.Value;
    ref object local8 = ref obj8;
    object obj9 = (object) Missing.Value;
    ref object local9 = ref obj9;
    object obj10 = (object) Missing.Value;
    ref object local10 = ref obj10;
    object obj11 = (object) Missing.Value;
    ref object local11 = ref obj11;
    object obj12 = (object) Missing.Value;
    ref object local12 = ref obj12;
    object obj13 = (object) Missing.Value;
    ref object local13 = ref obj13;
    object obj14 = (object) Missing.Value;
    ref object local14 = ref obj14;
    object obj15 = (object) Missing.Value;
    ref object local15 = ref obj15;
    object obj16 = (object) Missing.Value;
    ref object local16 = ref obj16;
    Document document2 = documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
    Conversions.ToString(obj1);
    document1 = document2;
    application.Visible = true;
  }

  private void AuditOFormToolStripMenuItem_Click(object sender, EventArgs e)
  {
    string str = $"{Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}_O.doc";
    if (!MyProject.Computer.FileSystem.FileExists(str))
      File.Copy(Constant.CnString2 + "\\Data\\Byelaws\\FormO.doc", str, true);
    Microsoft.Office.Interop.Word.Application application = (Microsoft.Office.Interop.Word.Application) new Microsoft.Office.Interop.Word.ApplicationClass();
    Document document1 = (Document) new DocumentClass();
    Documents documents = application.Documents;
    object obj1 = (object) str;
    ref object local1 = ref obj1;
    object obj2 = (object) Missing.Value;
    ref object local2 = ref obj2;
    object obj3 = (object) Missing.Value;
    ref object local3 = ref obj3;
    object obj4 = (object) Missing.Value;
    ref object local4 = ref obj4;
    object obj5 = (object) Missing.Value;
    ref object local5 = ref obj5;
    object obj6 = (object) Missing.Value;
    ref object local6 = ref obj6;
    object obj7 = (object) Missing.Value;
    ref object local7 = ref obj7;
    object obj8 = (object) Missing.Value;
    ref object local8 = ref obj8;
    object obj9 = (object) Missing.Value;
    ref object local9 = ref obj9;
    object obj10 = (object) Missing.Value;
    ref object local10 = ref obj10;
    object obj11 = (object) Missing.Value;
    ref object local11 = ref obj11;
    object obj12 = (object) Missing.Value;
    ref object local12 = ref obj12;
    object obj13 = (object) Missing.Value;
    ref object local13 = ref obj13;
    object obj14 = (object) Missing.Value;
    ref object local14 = ref obj14;
    object obj15 = (object) Missing.Value;
    ref object local15 = ref obj15;
    object obj16 = (object) Missing.Value;
    ref object local16 = ref obj16;
    Document document2 = documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
    Conversions.ToString(obj1);
    document1 = document2;
    application.Visible = true;
  }

  private void ByeLawsToolStripMenuItem_Click(object sender, EventArgs e)
  {
    Process.Start(Constant.CnString2 + "\\Data\\Byelaws\\NewByeLaw.pdf");
  }

  private void ToolStripMenuItem9_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmImportStatMaster.ShowDialog();
    MyProject.Forms.frmImportStatMaster = (frmImportStatMaster) null;
  }

  private void CaclulatorToolStripMenuItem_Click(object sender, EventArgs e)
  {
    new Process() { StartInfo = { FileName = "Calc.exe" } }.Start();
  }

  private void PropertyRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    PregisterBlank pregisterBlank = new PregisterBlank();
    frmCRShow frmCrShow = new frmCRShow();
    pregisterBlank.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) pregisterBlank;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void InvestmentRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    InvRegisterBlank invRegisterBlank = new InvRegisterBlank();
    frmCRShow frmCrShow = new frmCRShow();
    invRegisterBlank.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) invRegisterBlank;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void SinkingFundLedgerToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    SILedgerBlank siLedgerBlank = new SILedgerBlank();
    frmCRShow frmCrShow = new frmCRShow();
    siLedgerBlank.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) siLedgerBlank;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void NominationFormToolStripMenuItem_Click(object sender, EventArgs e)
  {
    Microsoft.Office.Interop.Word.Application application = (Microsoft.Office.Interop.Word.Application) new Microsoft.Office.Interop.Word.ApplicationClass();
    Document document = (Document) new DocumentClass();
    Documents documents = application.Documents;
    object obj1 = (object) (Constant.CnString2.Trim() + "\\Data\\Byelaws\\14.doc");
    ref object local1 = ref obj1;
    object obj2 = (object) Missing.Value;
    ref object local2 = ref obj2;
    object obj3 = (object) Missing.Value;
    ref object local3 = ref obj3;
    object obj4 = (object) Missing.Value;
    ref object local4 = ref obj4;
    document = documents.Add(ref local1, ref local2, ref local3, ref local4);
    application.Visible = true;
  }

  private void FlatTransferDocumentToolStripMenuItem_Click(object sender, EventArgs e)
  {
    Microsoft.Office.Interop.Word.Application application = (Microsoft.Office.Interop.Word.Application) new Microsoft.Office.Interop.Word.ApplicationClass();
    Document document = (Document) new DocumentClass();
    Documents documents = application.Documents;
    object obj1 = (object) (Constant.CnString2.Trim() + "\\Data\\Byelaws\\List_Transfer.doc");
    ref object local1 = ref obj1;
    object obj2 = (object) Missing.Value;
    ref object local2 = ref obj2;
    object obj3 = (object) Missing.Value;
    ref object local3 = ref obj3;
    object obj4 = (object) Missing.Value;
    ref object local4 = ref obj4;
    object obj5 = (object) Missing.Value;
    ref object local5 = ref obj5;
    object obj6 = (object) Missing.Value;
    ref object local6 = ref obj6;
    object obj7 = (object) Missing.Value;
    ref object local7 = ref obj7;
    object obj8 = (object) Missing.Value;
    ref object local8 = ref obj8;
    object obj9 = (object) Missing.Value;
    ref object local9 = ref obj9;
    object obj10 = (object) Missing.Value;
    ref object local10 = ref obj10;
    object obj11 = (object) Missing.Value;
    ref object local11 = ref obj11;
    object obj12 = (object) Missing.Value;
    ref object local12 = ref obj12;
    object obj13 = (object) Missing.Value;
    ref object local13 = ref obj13;
    object obj14 = (object) Missing.Value;
    ref object local14 = ref obj14;
    object obj15 = (object) Missing.Value;
    ref object local15 = ref obj15;
    object obj16 = (object) Missing.Value;
    ref object local16 = ref obj16;
    document = documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
    application.Visible = true;
  }

  private void ShareCertificateToolStripMenuItem_Click(object sender, EventArgs e)
  {
    Microsoft.Office.Interop.Word.Application application = (Microsoft.Office.Interop.Word.Application) new Microsoft.Office.Interop.Word.ApplicationClass();
    Document document = (Document) new DocumentClass();
    Documents documents = application.Documents;
    object obj1 = (object) (Constant.CnString2.Trim() + "\\Data\\Byelaws\\1.doc");
    ref object local1 = ref obj1;
    object obj2 = (object) Missing.Value;
    ref object local2 = ref obj2;
    object obj3 = (object) Missing.Value;
    ref object local3 = ref obj3;
    object obj4 = (object) Missing.Value;
    ref object local4 = ref obj4;
    document = documents.Add(ref local1, ref local2, ref local3, ref local4);
    application.Visible = true;
  }

  private void MemberDetailFormToolStripMenuItem_Click(object sender, EventArgs e)
  {
    Microsoft.Office.Interop.Word.Application application = (Microsoft.Office.Interop.Word.Application) new Microsoft.Office.Interop.Word.ApplicationClass();
    Document document = (Document) new DocumentClass();
    Documents documents = application.Documents;
    object obj1 = (object) (Constant.CnString2.Trim() + "\\Data\\Byelaws\\Members_Details.doc");
    ref object local1 = ref obj1;
    object obj2 = (object) Missing.Value;
    ref object local2 = ref obj2;
    object obj3 = (object) Missing.Value;
    ref object local3 = ref obj3;
    object obj4 = (object) Missing.Value;
    ref object local4 = ref obj4;
    document = documents.Add(ref local1, ref local2, ref local3, ref local4);
    application.Visible = true;
  }

  private void SocietyDetailFormToolStripMenuItem_Click(object sender, EventArgs e)
  {
    Microsoft.Office.Interop.Word.Application application = (Microsoft.Office.Interop.Word.Application) new Microsoft.Office.Interop.Word.ApplicationClass();
    Document document = (Document) new DocumentClass();
    Documents documents = application.Documents;
    object obj1 = (object) (Constant.CnString2.Trim() + "\\Data\\Byelaws\\Society_Details.doc");
    ref object local1 = ref obj1;
    object obj2 = (object) Missing.Value;
    ref object local2 = ref obj2;
    object obj3 = (object) Missing.Value;
    ref object local3 = ref obj3;
    object obj4 = (object) Missing.Value;
    ref object local4 = ref obj4;
    document = documents.Add(ref local1, ref local2, ref local3, ref local4);
    application.Visible = true;
  }

  private void OtherFormatsToolStripMenuItem_Click(object sender, EventArgs e)
  {
    Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application) new Microsoft.Office.Interop.Excel.ApplicationClass();
    application.Workbooks.Open(Constant.CnString2.Trim() + "\\Data\\OtherReports\\Other_Report_Index.xlsx", (object) Missing.Value, (object) true, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value);
    application.Visible = true;
  }

  private void ToolStripMenuItem10_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportMemberAdjustmentPrint.lblType.Text = "MAdj";
    int num = (int) MyProject.Forms.frmReportMemberAdjustmentPrint.ShowDialog();
    MyProject.Forms.frmReportMemberAdjustmentPrint = (frmReportMemberAdjustmentPrint) null;
  }

  private void CommitteeMasterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmCommittee.ShowDialog();
    MyProject.Forms.frmCommittee = (frmCommittee) null;
  }

  private void CheckDifferenceToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmCheckDiff.ShowDialog();
    MyProject.Forms.frmCheckDiff = (frmCheckDiff) null;
  }

  private void OpeningBalancesToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmOpeningBalance.ShowDialog();
    MyProject.Forms.frmOpeningBalance = (frmOpeningBalance) null;
  }

  private void IToolStripMenuItem_Click(object sender, EventArgs e)
  {
  }

  private void MultiJRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) new JLISTMulti().ShowDialog();
  }

  private void ShareRegisterMultiUpdateToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) new SLISTMultiple().ShowDialog();
  }

  private void IRegisterMulitUpdateToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) new ILISTMultiple().ShowDialog();
  }

  private void TransferFlatToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) new frmFlatTransfer().ShowDialog();
  }

  private void MemberListToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) new frmMemberListReport().ShowDialog();
  }

  private void ElectionListToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) new frmMemberElectionListReport().ShowDialog();
  }

  private void ToolStripMenuItem11_Click(object sender, EventArgs e)
  {
    int num = (int) new frmMemberListTransferReport().ShowDialog();
  }

  private void MemberMasterFromExcelToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "2", false) == 0))
      return;
    int num = (int) MyProject.Forms.frmImportMemberMaster.ShowDialog();
    MyProject.Forms.frmImportMemberMaster = (frmImportMemberMaster) null;
  }

  private void BankListFromOtherSocietyToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmImportBankList.lblType.Text = "Bank";
    int num = (int) MyProject.Forms.frmImportBankList.ShowDialog();
    MyProject.Forms.frmImportBankList = (frmImportBankList) null;
  }

  private void PersonListFromOtherSocietyToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmImportBankList.lblType.Text = "Person";
    int num = (int) MyProject.Forms.frmImportBankList.ShowDialog();
    MyProject.Forms.frmImportBankList = (frmImportBankList) null;
  }

  private void ToolStripMenuItem12_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmImportBankList.lblType.Text = "Particular";
    int num = (int) MyProject.Forms.frmImportBankList.ShowDialog();
    MyProject.Forms.frmImportBankList = (frmImportBankList) null;
  }

  private void GroupAccountMasterFromOtherSoceityToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    MyProject.Forms.frmImportBankList.lblType.Text = "Account";
    int num = (int) MyProject.Forms.frmImportBankList.ShowDialog();
    MyProject.Forms.frmImportBankList = (frmImportBankList) null;
  }

  private void MemberOpeningBalanceBifurcationToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    MyProject.Forms.frmMemberBillMasterSelect.lblType.Text = "2";
    MyProject.Forms.frmMemberBillMasterSelect.lblHeading.Text = " Member Opening Balance ";
    int num = (int) MyProject.Forms.frmMemberBillMasterSelect.ShowDialog();
  }

  private void ToolStripMenuItem13_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportMemberReceiptPrint.lblType.Text = "MRct";
    MyProject.Forms.frmReportMemberReceiptPrint.lblReportType.Text = "1";
    int num = (int) MyProject.Forms.frmReportMemberReceiptPrint.ShowDialog();
    MyProject.Forms.frmReportMemberReceiptPrint = (frmReportMemberReceiptPrint) null;
  }

  private void SocietyMasterReceiptRemarkToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmSocietyMasterReceipt.ShowDialog();
    MyProject.Forms.frmSocietyMaster = (frmSocietyMaster) null;
  }

  private void SetBillPrintingOptionToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmSocietyMasterBillPrintSet.ShowDialog();
    MyProject.Forms.frmSocietyMaster = (frmSocietyMaster) null;
  }

  private void HalfPageToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportBillFullPage.lblType.Text = "MDbn";
    MyProject.Forms.frmReportBillFullPage.rb3.Checked = true;
    MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "DEBIT NOTE";
    int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
    MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
  }

  private void FullPage14HeadToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportBillFullPage.lblType.Text = "MDbn";
    MyProject.Forms.frmReportBillFullPage.rb10.Checked = true;
    MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "DEBIT NOTE";
    int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
    MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
  }

  private void FullPage21HeadToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportBillFullPage.lblType.Text = "MDbn";
    MyProject.Forms.frmReportBillFullPage.rb11.Checked = true;
    MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "DEBIT NOTE";
    int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
    MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
  }

  private void FullPage14HeadToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportBillFullPage.lblType.Text = "MCrn";
    MyProject.Forms.frmReportBillFullPage.rb10.Checked = true;
    MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "CREDIT NOTE";
    int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
    MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
  }

  private void HalfPageToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportBillFullPage.lblType.Text = "MCrn";
    MyProject.Forms.frmReportBillFullPage.rb3.Checked = true;
    MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "CREDIT NOTE";
    int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
    MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
  }

  private void FullPage21HeadToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportBillFullPage.lblType.Text = "MCrn";
    MyProject.Forms.frmReportBillFullPage.rb11.Checked = true;
    MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "CREDIT NOTE";
    int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
    MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
  }

  private void GSTMasterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmSocietyMasterGST.ShowDialog();
    MyProject.Forms.frmSocietyMaster = (frmSocietyMaster) null;
  }

  private void GSTCalculateToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    int num = (int) MyProject.Forms.frmGSTCalculate.ShowDialog();
    MyProject.Forms.frmGSTCalculate = (frmGSTCalculate) null;
  }

  private void HalfPageGSTVerticalDoubleBillToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportBillFullPage.lblType.Text = "MBil";
    MyProject.Forms.frmReportBillFullPage.rb7.Checked = true;
    MyProject.Forms.frmReportBillFullPage.txtBillHeading.Text = "BILL";
    int num = (int) MyProject.Forms.frmReportBillFullPage.ShowDialog();
    MyProject.Forms.frmReportBillFullPage = (frmReportBillFullPage) null;
  }

  private void ListToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmMemberExportList.btnExport.Visible = true;
    MyProject.Forms.frmMemberExportList.btnPreviewForm.Visible = false;
    int num = (int) MyProject.Forms.frmMemberExportList.ShowDialog();
    MyProject.Forms.frmMemberExportList = (frmMemberExportList) null;
  }

  private void FormToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmMemberExportList.btnExport.Visible = false;
    MyProject.Forms.frmMemberExportList.btnPreviewForm.Visible = true;
    int num = (int) MyProject.Forms.frmMemberExportList.ShowDialog();
    MyProject.Forms.frmMemberExportList = (frmMemberExportList) null;
  }

  private void OtherInfoToolStripMenuItem_Click(object sender, EventArgs e)
  {
    string str = $"{Constant.socDataPath}\\{Constant.Clientcode}_{Constant.societycode}_{Conversion.Str((object) DateAndTime.Year(Constant.socFYSTART)).Trim()}{Conversion.Str((object) DateAndTime.Year(Constant.socFYEND)).Trim()}_OtherRemark.doc";
    Microsoft.Office.Interop.Word.Application application = (Microsoft.Office.Interop.Word.Application) new Microsoft.Office.Interop.Word.ApplicationClass();
    Document document1 = (Document) new DocumentClass();
    object obj1;
    object obj2;
    object obj3;
    object obj4;
    object obj5;
    object obj6;
    if (!MyProject.Computer.FileSystem.FileExists(str))
    {
      File.Copy(Constant.CnString2 + "\\Data\\Society_Other_Remark.doc", str, true);
      Documents documents1 = application.Documents;
      object obj7 = (object) str;
      ref object local1 = ref obj7;
      object obj8 = (object) Missing.Value;
      ref object local2 = ref obj8;
      obj1 = (object) Missing.Value;
      ref object local3 = ref obj1;
      object obj9 = (object) Missing.Value;
      ref object local4 = ref obj9;
      obj2 = (object) Missing.Value;
      ref object local5 = ref obj2;
      object obj10 = (object) Missing.Value;
      ref object local6 = ref obj10;
      object obj11 = (object) Missing.Value;
      ref object local7 = ref obj11;
      obj3 = (object) Missing.Value;
      ref object local8 = ref obj3;
      object obj12 = (object) Missing.Value;
      ref object local9 = ref obj12;
      object obj13 = (object) Missing.Value;
      ref object local10 = ref obj13;
      obj4 = (object) Missing.Value;
      ref object local11 = ref obj4;
      object obj14 = (object) Missing.Value;
      ref object local12 = ref obj14;
      object obj15 = (object) Missing.Value;
      ref object local13 = ref obj15;
      obj5 = (object) Missing.Value;
      ref object local14 = ref obj5;
      object obj16 = (object) Missing.Value;
      ref object local15 = ref obj16;
      obj6 = (object) Missing.Value;
      ref object local16 = ref obj6;
      Document document2 = documents1.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
      str = Conversions.ToString(obj7);
      Document document3 = document2;
      Tables tables = document3.Tables;
      Bookmarks bookmarks = document3.Bookmarks;
      obj6 = (object) "\\endofdoc";
      ref object local17 = ref obj6;
      Microsoft.Office.Interop.Word.Range range = bookmarks[ref local17].Range;
      object obj17 = (object) Missing.Value;
      ref object local18 = ref obj17;
      obj5 = (object) Missing.Value;
      ref object local19 = ref obj5;
      Table table = tables.Add(range, 3, 3, ref local18, ref local19);
      table.Range.ParagraphFormat.SpaceAfter = 6f;
      table.Cell(1, 1).Range.Text = Constant.societyname;
      Documents documents2 = application.Documents;
      obj6 = (object) WdSaveOptions.wdSaveChanges;
      ref object local20 = ref obj6;
      object obj18 = (object) Missing.Value;
      ref object local21 = ref obj18;
      obj5 = (object) Missing.Value;
      ref object local22 = ref obj5;
      documents2.Close(ref local20, ref local21, ref local22);
    }
    Documents documents = application.Documents;
    obj6 = (object) str;
    ref object local23 = ref obj6;
    object obj19 = (object) Missing.Value;
    ref object local24 = ref obj19;
    obj5 = (object) Missing.Value;
    ref object local25 = ref obj5;
    object obj20 = (object) Missing.Value;
    ref object local26 = ref obj20;
    object obj21 = (object) Missing.Value;
    ref object local27 = ref obj21;
    obj4 = (object) Missing.Value;
    ref object local28 = ref obj4;
    object obj22 = (object) Missing.Value;
    ref object local29 = ref obj22;
    object obj23 = (object) Missing.Value;
    ref object local30 = ref obj23;
    obj3 = (object) Missing.Value;
    ref object local31 = ref obj3;
    object obj24 = (object) Missing.Value;
    ref object local32 = ref obj24;
    object obj25 = (object) Missing.Value;
    ref object local33 = ref obj25;
    obj2 = (object) Missing.Value;
    ref object local34 = ref obj2;
    object obj26 = (object) Missing.Value;
    ref object local35 = ref obj26;
    obj1 = (object) Missing.Value;
    ref object local36 = ref obj1;
    object obj27 = (object) Missing.Value;
    ref object local37 = ref obj27;
    object obj28 = (object) Missing.Value;
    ref object local38 = ref obj28;
    Document document4 = documents.Open(ref local23, ref local24, ref local25, ref local26, ref local27, ref local28, ref local29, ref local30, ref local31, ref local32, ref local33, ref local34, ref local35, ref local36, ref local37, ref local38);
    Conversions.ToString(obj6);
    document1 = document4;
    application.Visible = true;
  }

  private void MemberReceiptFromExcelToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    int num = (int) MyProject.Forms.frmImportMemberReceipt.ShowDialog();
    MyProject.Forms.frmImportMemberReceipt = (frmImportMemberReceipt) null;
  }

  private void A4ToolStripMenuItem_Click(object sender, EventArgs e)
  {
    JregisterBlank jregisterBlank = new JregisterBlank();
    frmCRShow frmCrShow = new frmCRShow();
    jregisterBlank.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) jregisterBlank;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void A4PaperToolStripMenuItem_Click(object sender, EventArgs e)
  {
    ShareRegisterBlank shareRegisterBlank = new ShareRegisterBlank();
    frmCRShow frmCrShow = new frmCRShow();
    shareRegisterBlank.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) shareRegisterBlank;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void A4PaperToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    NregisterBlank nregisterBlank = new NregisterBlank();
    frmCRShow frmCrShow = new frmCRShow();
    nregisterBlank.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) nregisterBlank;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void A4PaperToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    IregisterBlank iregisterBlank = new IregisterBlank();
    frmCRShow frmCrShow = new frmCRShow();
    iregisterBlank.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) iregisterBlank;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void LegalPaperToolStripMenuItem_Click(object sender, EventArgs e)
  {
    JregisterBlankLegal jregisterBlankLegal = new JregisterBlankLegal();
    frmCRShow frmCrShow = new frmCRShow();
    jregisterBlankLegal.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) jregisterBlankLegal;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void LegalPaperToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    ShareRegisterBlankLegal registerBlankLegal = new ShareRegisterBlankLegal();
    frmCRShow frmCrShow = new frmCRShow();
    registerBlankLegal.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) registerBlankLegal;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void LegalPaperToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    NregisterBlankLegal nregisterBlankLegal = new NregisterBlankLegal();
    frmCRShow frmCrShow = new frmCRShow();
    nregisterBlankLegal.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) nregisterBlankLegal;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void LegalPaperToolStripMenuItem3_Click(object sender, EventArgs e)
  {
    IregisterBlankLegal iregisterBlankLegal = new IregisterBlankLegal();
    frmCRShow frmCrShow = new frmCRShow();
    iregisterBlankLegal.SetParameterValue("societyname", (object) Constant.societyname);
    MyProject.Forms.frmCRShow.CrystalReportViewer1.ReportSource = (object) iregisterBlankLegal;
    MyProject.Forms.frmCRShow.CrystalReportViewer1.Refresh();
    int num = (int) MyProject.Forms.frmCRShow.ShowDialog();
  }

  private void ToolStripMenuItem13_Click_1(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    MyProject.Forms.frmMemberBillMasterSelect.lblType.Text = "3";
    MyProject.Forms.frmMemberBillMasterSelect.lblHeading.Text = " Member Bill Master ";
    int num = (int) MyProject.Forms.frmMemberBillMasterSelect.ShowDialog();
  }

  private void ToolStripMenuItem16_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmYearExten.ShowDialog();
    MyProject.Forms.frmYearExten = (frmYearExten) null;
  }

  private void PaymentFromExcelToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    int num = (int) MyProject.Forms.frmImportPayment.ShowDialog();
    MyProject.Forms.frmImportPayment = (frmImportPayment) null;
  }

  private void ToolStripButton20_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmSocSelectionChange.ShowDialog();
    MyProject.Forms.frmSocSelectionChange = (frmSocSelectionChange) null;
  }

  private void ToolStripButton22_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    MyProject.Forms.frmConstantGrid.lblGridLocation.Text = "M";
    MyProject.Forms.frmConstantGrid.lblConstStat.Text = Conversions.ToString(Conversion.Val(MyProject.Forms.frmConstantGrid.lblConstStat.Text.ToString()) + 1.0);
    int num = (int) MyProject.Forms.frmMember.ShowDialog();
    MyProject.Forms.frmMember = (frmMember) null;
  }

  private void IncomeExpenditureAcMarathiToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportIncomeExpenditureMarathi.ShowDialog();
    MyProject.Forms.frmReportIncomeExpenditureMarathi = (frmReportIncomeExpenditureMarathi) null;
  }

  private void BalanceSheetMarathiToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportBalanceSheetMarathi.ShowDialog();
    MyProject.Forms.frmReportBalanceSheetMarathi = (frmReportBalanceSheetMarathi) null;
  }

  private void SelectedBillingMasterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmMemberMasterSelected.ShowDialog();
    MyProject.Forms.frmMemberMasterSelected = (frmMemberMasterSelected) null;
  }

  private void JournalVoucherToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPayment.lblType.Text = "Jrnl";
    int num = (int) MyProject.Forms.frmReportPayment.ShowDialog();
  }

  private void SocietyMasterReceiptRemarkToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmSocietyMasterRecRek.ShowDialog();
    MyProject.Forms.frmSocietyMasterRecRek = (frmSocietyMasterRecRek) null;
  }

  private void ReceiptFromExcelToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    int num = (int) MyProject.Forms.frmImportReceipt.ShowDialog();
    MyProject.Forms.frmImportReceipt = (frmImportReceipt) null;
  }

  private void FundRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportFundRegister.ShowDialog();
    MyProject.Forms.frmReportFundRegister = (frmReportFundRegister) null;
  }

  private void ToolStripMenuItem20_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);
    if (MyProject.Forms.frmConstantGrid.DataGridViewMember.RowCount >= 1)
    {
      MyProject.Forms.frmMemReceipt.lblTrType.Text = "MJnl";
      MyProject.Forms.frmMemReceipt.Text = "Member Journal List";
      int num = (int) MyProject.Forms.frmMemReceipt.ShowDialog();
      MyProject.Forms.frmMemReceipt = (frmMemReceipt) null;
    }
    else
    {
      int num1 = (int) Interaction.MsgBox((object) "First create Member Account");
    }
  }

  private void ToolStripMenuItem21_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportPVRegister.lblType.Text = "MJnl";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
    MyProject.Forms.frmReportPVRegister = (frmReportPVRegister) null;
  }

  private void NormalToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportMemberBillRegisterNew.lblType.Text = "MBil";
    int num = (int) MyProject.Forms.frmReportMemberBillRegisterNew.ShowDialog();
    MyProject.Forms.frmReportMemberBillRegisterNew = (frmReportMemberBillRegisterNew) null;
  }

  private void BillRegisgerWithReceiptToolStripMenuItem_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportMemberBillRegisterNewReceipt.lblType.Text = "MBil";
    int num = (int) MyProject.Forms.frmReportMemberBillRegisterNewReceipt.ShowDialog();
    MyProject.Forms.frmReportMemberBillRegisterNewReceipt = (frmReportMemberBillRegisterNewReceipt) null;
  }

  private void GSTBillRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    MyProject.Forms.frmReportMemberBillRegisterNewGST.lblType.Text = "MBil";
    int num = (int) MyProject.Forms.frmReportMemberBillRegisterNewGST.ShowDialog();
    MyProject.Forms.frmReportMemberBillRegisterNewGST = (frmReportMemberBillRegisterNewGST) null;
  }

  private void FullPage21HeadBillWithReceiptFormat2ToolStripMenuItem_Click(
    object sender,
    EventArgs e)
  {
    MyProject.Forms.frmReportBillWithReceipt.rb9.Checked = true;
    MyProject.Forms.frmReportBillWithReceipt.txtBillHeading.Text = "BILL";
    int num = (int) MyProject.Forms.frmReportBillWithReceipt.ShowDialog();
    MyProject.Forms.frmReportBillWithReceipt = (frmReportBillWithReceipt) null;
  }

  private void AllToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "3", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "4", false) == 0)
      return;
    MyProject.Forms.frmPaymentVerify.lblAllCheckUncheck.Text = "ALL";
    int num = (int) MyProject.Forms.frmPaymentVerify.ShowDialog();
    MyProject.Forms.frmPaymentVerify = (frmPaymentVerify) null;
  }

  private void VoucherCheckReportToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportVoucherCheck.ShowDialog();
    MyProject.Forms.frmReportVoucherCheck = (frmReportVoucherCheck) null;
  }

  private void OkToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "3", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "4", false) == 0)
      return;
    MyProject.Forms.frmPaymentVerify.lblAllCheckUncheck.Text = "UNCHECK";
    int num = (int) MyProject.Forms.frmPaymentVerify.ShowDialog();
    MyProject.Forms.frmPaymentVerify = (frmPaymentVerify) null;
  }

  private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "3", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel.ToString().Trim(), "4", false) == 0)
      return;
    MyProject.Forms.frmPaymentVerify.lblAllCheckUncheck.Text = "CHECK";
    int num = (int) MyProject.Forms.frmPaymentVerify.ShowDialog();
    MyProject.Forms.frmPaymentVerify = (frmPaymentVerify) null;
  }

  private void CodeWiseToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportAccountLedgerNew.ShowDialog();
    MyProject.Forms.frmReportAccountLedgerNew = (frmReportAccountLedgerNew) null;
  }

  private void GroupWiseToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportAccountLedgerNewGroup.ShowDialog();
    MyProject.Forms.frmReportAccountLedgerNew = (frmReportAccountLedgerNew) null;
  }

  private void BooksOfAccountToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmBOA.ShowDialog();
    MyProject.Forms.frmBOA = (frmBOA) null;
  }

  private void BooksOfAccountTableFromOtherSocietyToolStripMenuItem_Click(
    object sender,
    EventArgs e)
  {
    MyProject.Forms.frmImportBankList.lblType.Text = "BOA";
    int num = (int) MyProject.Forms.frmImportBankList.ShowDialog();
    MyProject.Forms.frmImportBankList = (frmImportBankList) null;
  }

  private void WhatsNewIn202425ToolStripMenuItem_Click(object sender, EventArgs e)
  {
    Process.Start(Constant.CnString2 + "\\Data\\Whatsnew2425.pdf");
  }

  private void InterestZerowiseToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    int num = (int) MyProject.Forms.frmZerowise.ShowDialog();
    MyProject.Forms.frmZerowise = (frmZerowise) null;
  }

  private void InterestCalculateToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    int num = (int) MyProject.Forms.frmCalculate.ShowDialog();
    MyProject.Forms.frmCalculate = (frmCalculate) null;
  }

  private void DayWiseInterestCalculateToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    int num = (int) MyProject.Forms.frmCalculateDayWise.ShowDialog();
    MyProject.Forms.frmCalculateDayWise = (frmCalculateDayWise) null;
  }

  private void BillSettingToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmBillSetting.ShowDialog();
    MyProject.Forms.frmBillSetting = (frmBillSetting) null;
  }

  private void BillMasterToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    int num = (int) MyProject.Forms.frmBillMasterOnOff.ShowDialog();
  }

  private void EmailIdSettingToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmEmailSetting.ShowDialog();
    MyProject.Forms.frmEmailSetting = (frmEmailSetting) null;
  }

  private void WhatsupSettingToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "1", false) != 0)
      return;
    int num = (int) MyProject.Forms.frmWhatsupSetting.ShowDialog();
    MyProject.Forms.frmWhatsupSetting = (frmWhatsupSetting) null;
  }

  private void BillFormatToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocInfo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    System.Data.DataTable dataTable = new System.Data.DataTable("SocBillSetting");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "1. Half Page (Bill)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill";
      MyProject.Forms.frmEmailMemberAccount.rb3.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "1. Half Page (Bill)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "2. Half Page Vertical (Bill)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill";
      MyProject.Forms.frmEmailMemberAccount.rb5.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "2. Half Page Vertical (Bill)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "3. Half Page Vertical Double (Bill)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill";
      MyProject.Forms.frmEmailMemberAccount.rb6.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "3. Half Page Vertical Double (Bill)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "4. Full Page (Bill)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill";
      MyProject.Forms.frmEmailMemberAccount.rb10.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "4. Full Page (Bill)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "5. Full Page New (Bill)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill";
      MyProject.Forms.frmEmailMemberAccount.rb11.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "5. Full Page New (Bill)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "6. Half Page (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmEmailMemberAccount.rb3.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "6. Half Page (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "7. Full Page - 21 Head (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmEmailMemberAccount.rb9.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "7. Full Page - 21 Head (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "8. Full Page - 14 Head New (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmEmailMemberAccount.rb11.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "8. Full Page - 14 Head New (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "9. Full Page - 14 Head Old (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmEmailMemberAccount.rb4.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "9. Full Page - 14 Head Old (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "10. Full Page - 21 Head New (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmEmailMemberAccount.rb12.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "10. Full Page - 21 Head New (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "11.Full Page - 21 Head (Bill with Receipt) Format-1", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmEmailMemberAccount.rb17.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "11.Full Page - 21 Head (Bill with Receipt) Format-1";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "12.Full Page - 21 Head (Bill with Receipt) Format-2", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmEmailMemberAccount.rb18.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "12.Full Page - 21 Head (Bill with Receipt) Format-2";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "G01.Full Page - GST (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmEmailMemberAccount.rb7.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "G01.Full Page - GST (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "G02.Full Page - GST1 (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmEmailMemberAccount.rb8.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "G02.Full Page - GST1 (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "G03.Full Page - GST (Bill with Receipt)(With address)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmEmailMemberAccount.rb16.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.Text = "G03.Full Page - GST (Bill with Receipt)(With address)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "M01. Half Page - vertical (Marathi)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill";
      MyProject.Forms.frmEmailMemberAccount.rb13.Checked = true;
      MyProject.Forms.frmEmailMemberAccount.txtBillHeading.Text = "देयक";
      MyProject.Forms.frmEmailMemberAccount.Text = "M01. Half Page - vertical (Marathi)";
      int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
      MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "M02. Full Page - 21 Head New (Bill with Receipt)(Marathi)", false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Bill With Receipt";
    MyProject.Forms.frmEmailMemberAccount.rb15.Checked = true;
    MyProject.Forms.frmEmailMemberAccount.txtBillHeading.Text = "देयक";
    MyProject.Forms.frmEmailMemberAccount.Text = "M02. Full Page - 21 Head New (Bill with Receipt)(Marathi)";
    int num1 = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
    MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
  }

  private void ReceiptToolStripMenuItem4_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Receipt";
    int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
    MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
  }

  private void MemberAccountToolStripMenuItem3_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Member Account";
    int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
    MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
  }

  private void MemberRegisterToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Member Register";
    int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
    MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
  }

  private void OutstandingReminderToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Member Outstanding";
    int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
    MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
  }

  private void OutstandingLetterToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Outstanding Letter";
    int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
    MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
  }

  private void MessageToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Blank Mail";
    MyProject.Forms.frmEmailMemberAccount.txtBodyOs.Text = "";
    int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
    MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
  }

  private void BalanceConfirmationLetterToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Balance Confirmation Letter";
    int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
    MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
  }

  private void MessageWithPdfToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmEmailMemberAccount.lblReportType.Text = "Pdf Mail";
    MyProject.Forms.frmEmailMemberAccount.txtBodyOs.Text = "";
    int num = (int) MyProject.Forms.frmEmailMemberAccount.ShowDialog();
    MyProject.Forms.frmEmailMemberAccount = (frmEmailMemberAccount) null;
  }

  private void BillFormatToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("SELECT * FROM SocInfo", new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.socDataPath}{Constant.SocDataFile}"));
    System.Data.DataTable dataTable = new System.Data.DataTable("SocBillSetting");
    oleDbDataAdapter.Fill(dataTable);
    this.DataGridView2.DataSource = (object) dataTable;
    this.DataGridView2.ReadOnly = true;
    this.DataGridView2.RowHeadersVisible = false;
    this.DataGridView2.AllowUserToAddRows = false;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "1. Half Page (Bill)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill";
      MyProject.Forms.frmWhatsupMemberAccount.rb3.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "1. Half Page (Bill)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "2. Half Page Vertical (Bill)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill";
      MyProject.Forms.frmWhatsupMemberAccount.rb5.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "2. Half Page Vertical (Bill)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "3. Half Page Vertical Double (Bill)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill";
      MyProject.Forms.frmWhatsupMemberAccount.rb6.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "3. Half Page Vertical Double (Bill)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "4. Full Page (Bill)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill";
      MyProject.Forms.frmWhatsupMemberAccount.rb10.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "4. Full Page (Bill)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "5. Full Page New (Bill)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill";
      MyProject.Forms.frmWhatsupMemberAccount.rb11.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "5. Full Page New (Bill)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "6. Half Page (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmWhatsupMemberAccount.rb3.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "6. Half Page (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "7. Full Page - 21 Head (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmWhatsupMemberAccount.rb9.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "7. Full Page - 21 Head (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "8. Full Page - 14 Head New (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmWhatsupMemberAccount.rb11.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "8. Full Page - 14 Head New (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "9. Full Page - 14 Head Old (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmWhatsupMemberAccount.rb4.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "9. Full Page - 14 Head Old (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "10. Full Page - 21 Head New (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmWhatsupMemberAccount.rb12.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "10. Full Page - 21 Head New (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "11.Full Page - 21 Head (Bill with Receipt) Format-1", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmWhatsupMemberAccount.rb17.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "11.Full Page - 21 Head (Bill with Receipt) Format-1";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "12.Full Page - 21 Head (Bill with Receipt) Format-2", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmWhatsupMemberAccount.rb18.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "12.Full Page - 21 Head (Bill with Receipt) Format-2";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "G01.Full Page - GST (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmWhatsupMemberAccount.rb7.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "G01.Full Page - GST (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "G02.Full Page - GST1 (Bill with Receipt)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmWhatsupMemberAccount.rb8.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "G02.Full Page - GST1 (Bill with Receipt)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "G03.Full Page - GST (Bill with Receipt)(With address)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill With Receipt";
      MyProject.Forms.frmWhatsupMemberAccount.rb16.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.Text = "G03.Full Page - GST (Bill with Receipt)(With address)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "M01. Half Page - vertical (Marathi)", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) != 0)
    {
      MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill";
      MyProject.Forms.frmWhatsupMemberAccount.rb13.Checked = true;
      MyProject.Forms.frmWhatsupMemberAccount.txtBillHeading.Text = "देयक";
      MyProject.Forms.frmWhatsupMemberAccount.Text = "M01. Half Page - vertical (Marathi)";
      int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
      MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.DataGridView2.Rows[0].Cells[65].Value.ToString().Trim(), "M02. Full Page - 21 Head New (Bill with Receipt)(Marathi)", false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Bill With Receipt";
    MyProject.Forms.frmWhatsupMemberAccount.rb15.Checked = true;
    MyProject.Forms.frmWhatsupMemberAccount.txtBillHeading.Text = "देयक";
    MyProject.Forms.frmWhatsupMemberAccount.Text = "M02. Full Page - 21 Head New (Bill with Receipt)(Marathi)";
    int num1 = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
    MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
  }

  private void ReceiptToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Receipt";
    int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
    MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
  }

  private void MemberAccountToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Member Account";
    int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
    MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
  }

  private void MemberRegisterToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Member Register";
    int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
    MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
  }

  private void OutstandingReminderToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Member Outstanding";
    int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
    MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
  }

  private void MessageToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Blank Mail";
    MyProject.Forms.frmWhatsupMemberAccount.txtBodyOs.Text = "";
    int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
    MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
  }

  private void BalanceConfirmationLetterToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Balance Confirmation Letter";
    int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
    MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
  }

  private void MessageWithPdfToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmWhatsupMemberAccount.lblReportType.Text = "Pdf Mail";
    MyProject.Forms.frmWhatsupMemberAccount.txtBodyOs.Text = "";
    int num = (int) MyProject.Forms.frmWhatsupMemberAccount.ShowDialog();
    MyProject.Forms.frmWhatsupMemberAccount = (frmWhatsupMemberAccount) null;
  }

  private void CommitteeMasterToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    int num = (int) MyProject.Forms.frmCommittee.ShowDialog();
    MyProject.Forms.frmCommittee = (frmCommittee) null;
  }

  private void IncomeExpenditureToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportIncomeExpenditure.btnPrint.Text = "Mail to Committee";
    int num = (int) MyProject.Forms.frmReportIncomeExpenditure.ShowDialog();
    MyProject.Forms.frmReportIncomeExpenditure = (frmReportIncomeExpenditure) null;
  }

  private void BalanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportBalanceSheet.btnPrint.Text = "Mail to Committee";
    int num = (int) MyProject.Forms.frmReportBalanceSheet.ShowDialog();
    MyProject.Forms.frmReportBalanceSheet = (frmReportBalanceSheet) null;
  }

  private void TrialBalanceToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.FrmReportTrialBalance.btnPrint.Text = "Mail to Committee";
    int num = (int) MyProject.Forms.FrmReportTrialBalance.ShowDialog();
    MyProject.Forms.FrmReportTrialBalance = (FrmReportTrialBalance) null;
  }

  private void CashBankBookToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportAccountCashBank.btnPrintRegister.Text = "Mail to Committee";
    int num = (int) MyProject.Forms.frmReportAccountCashBank.ShowDialog();
    MyProject.Forms.frmReportAccountCashBank = (frmReportAccountCashBank) null;
  }

  private void CodeWiseToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportAccountLedgerNew.btnPrintRegister.Text = "Mail to Committee";
    int num = (int) MyProject.Forms.frmReportAccountLedgerNew.ShowDialog();
    MyProject.Forms.frmReportAccountLedgerNew = (frmReportAccountLedgerNew) null;
  }

  private void GroupWiseToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportAccountLedgerNewGroup.btnPrintRegister.Text = "Mail to Committee";
    int num = (int) MyProject.Forms.frmReportAccountLedgerNewGroup.ShowDialog();
    MyProject.Forms.frmReportAccountLedgerNew = (frmReportAccountLedgerNew) null;
  }

  private void ReceiptPaymentAccoutToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportReceiptPaymentGroup.btnPrint.Text = "Mail to Committee";
    int num = (int) MyProject.Forms.frmReportReceiptPaymentGroup.ShowDialog();
    MyProject.Forms.frmReportReceiptPaymentGroup = (frmReportReceiptPaymentGroup) null;
  }

  private void ReceiptPaymentAccoutwiseToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportReceiptPayment.btnPrint.Text = "Mail to Committee";
    int num = (int) MyProject.Forms.frmReportReceiptPayment.ShowDialog();
    MyProject.Forms.frmReportReceiptPayment = (frmReportReceiptPayment) null;
  }

  private void ScheduleToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportSchedule.btnPrint.Text = "Mail to Committee";
    int num = (int) MyProject.Forms.frmReportSchedule.ShowDialog();
    MyProject.Forms.frmReportSchedule = (frmReportSchedule) null;
  }

  private void MonthlyReportToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportMonthly.btnPrint.Text = "Mail to Committee";
    int num = (int) MyProject.Forms.frmReportMonthly.ShowDialog();
    MyProject.Forms.frmReportMonthly = (frmReportMonthly) null;
  }

  private void ReceiptRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportPVRegister.btnPrintRegister.Text = "Mail to Committee";
    MyProject.Forms.frmReportPVRegister.lblType.Text = "Rcpt";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
  }

  private void PaymentRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportPVRegister.btnPrintRegister.Text = "Mail to Committee";
    MyProject.Forms.frmReportPVRegister.lblType.Text = "Pymt";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
  }

  private void ContraRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportPVRegister.btnPrintRegister.Text = "Mail to Committee";
    MyProject.Forms.frmReportPVRegister.lblType.Text = "Ctra";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
  }

  private void JournalRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportPVRegister.btnPrintRegister.Text = "Mail to Committee";
    MyProject.Forms.frmReportPVRegister.lblType.Text = "Jrnl";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
  }

  private void IncomeExpenditureToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportIncomeExpenditure.btnPrint.Text = "Whatsup to Committee";
    int num = (int) MyProject.Forms.frmReportIncomeExpenditure.ShowDialog();
    MyProject.Forms.frmReportIncomeExpenditure = (frmReportIncomeExpenditure) null;
  }

  private void BalanceSheetToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportBalanceSheet.btnPrint.Text = "Whatsup to Committee";
    int num = (int) MyProject.Forms.frmReportBalanceSheet.ShowDialog();
    MyProject.Forms.frmReportBalanceSheet = (frmReportBalanceSheet) null;
  }

  private void TrialBalanceToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.FrmReportTrialBalance.btnPrint.Text = "Whatsup to Committee";
    int num = (int) MyProject.Forms.FrmReportTrialBalance.ShowDialog();
    MyProject.Forms.FrmReportTrialBalance = (FrmReportTrialBalance) null;
  }

  private void CashBankBookToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportAccountCashBank.btnPrintRegister.Text = "Whatsup to Committee";
    int num = (int) MyProject.Forms.frmReportAccountCashBank.ShowDialog();
    MyProject.Forms.frmReportAccountCashBank = (frmReportAccountCashBank) null;
  }

  private void CodewiseToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportAccountLedgerNew.btnPrintRegister.Text = "Whatsup to Committee";
    int num = (int) MyProject.Forms.frmReportAccountLedgerNew.ShowDialog();
    MyProject.Forms.frmReportAccountLedgerNew = (frmReportAccountLedgerNew) null;
  }

  private void GroupWiseToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportAccountLedgerNewGroup.btnPrintRegister.Text = "Whatsup to Committee";
    int num = (int) MyProject.Forms.frmReportAccountLedgerNewGroup.ShowDialog();
    MyProject.Forms.frmReportAccountLedgerNew = (frmReportAccountLedgerNew) null;
  }

  private void ReceiptPaymentGroupwiseToolStripMenuItem_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportReceiptPaymentGroup.btnPrint.Text = "Whatsup to Committee";
    int num = (int) MyProject.Forms.frmReportReceiptPaymentGroup.ShowDialog();
    MyProject.Forms.frmReportReceiptPaymentGroup = (frmReportReceiptPaymentGroup) null;
  }

  private void ReceiptPaymentAccoutwiseToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportReceiptPayment.btnPrint.Text = "Whatsup to Committee";
    int num = (int) MyProject.Forms.frmReportReceiptPayment.ShowDialog();
    MyProject.Forms.frmReportReceiptPayment = (frmReportReceiptPayment) null;
  }

  private void ScheduleToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportSchedule.btnPrint.Text = "Whatsup to Committee";
    int num = (int) MyProject.Forms.frmReportSchedule.ShowDialog();
    MyProject.Forms.frmReportSchedule = (frmReportSchedule) null;
  }

  private void MonthlyReportToolStripMenuItem1_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportMonthly.btnPrint.Text = "Whatsup to Committee";
    int num = (int) MyProject.Forms.frmReportMonthly.ShowDialog();
    MyProject.Forms.frmReportMonthly = (frmReportMonthly) null;
  }

  private void ReceiptRegisterToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportPVRegister.btnPrintRegister.Text = "Whatsup to Committee";
    MyProject.Forms.frmReportPVRegister.lblType.Text = "Rcpt";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
  }

  private void PaymentRegisterToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportPVRegister.btnPrintRegister.Text = "Whatsup to Committee";
    MyProject.Forms.frmReportPVRegister.lblType.Text = "Pymt";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
  }

  private void ContraRegisterToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportPVRegister.btnPrintRegister.Text = "Whatsup to Committee";
    MyProject.Forms.frmReportPVRegister.lblType.Text = "Ctra";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
  }

  private void JournalRegisterToolStripMenuItem2_Click(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Constant.loginLevel, "3", false) == 0)
      return;
    MyProject.Forms.frmReportPVRegister.btnPrintRegister.Text = "Whatsup to Committee";
    MyProject.Forms.frmReportPVRegister.lblType.Text = "Jrnl";
    int num = (int) MyProject.Forms.frmReportPVRegister.ShowDialog();
  }

  private void ReceiptPaymentGroupwiseMarathiToolStripMenuItem_Click(object sender, EventArgs e)
  {
  }

  private void ReceiptPaymentAccountwiseMarathiToolStripMenuItem_Click(object sender, EventArgs e)
  {
    int num = (int) MyProject.Forms.frmReportReceiptPaymentMarathi.ShowDialog();
    MyProject.Forms.frmReportReceiptPaymentMarathi = (frmReportReceiptPaymentMarathi) null;
  }
}
