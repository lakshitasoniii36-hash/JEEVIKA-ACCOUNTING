// Decompiled with JetBrains decompiler
// Type: MauliModule7.Constant
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic.CompilerServices;
using System;

#nullable disable
namespace MauliModule7;

[StandardModule]
internal sealed class Constant
{
  public const string CnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
  public static string SoftSrno = "00000";
  public static string vCliName = "Demo Software";
  public static string CnPass = "SAKSHEE131629";
  public static string CnString2 = "C:\\MAULIMODULE7";
  public static string CnString3 = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.CnString2.Trim()}\\Data\\Login.accdb;Jet OLEDB:Database Password={Constant.CnPass.Trim()}";
  public static string CnString4 = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Constant.CnString2.Trim()}\\Data\\SamSys.accdb;Jet OLEDB:Database Password={Constant.CnPass.Trim()}";
  public static string Clientcode = "00000";
  public static string ClientHDNO = "00000000";
  public static string ClientMobile = "0000000000";
  public static string ClientEmail = "samcomputers07@gmail.com";
  public static string ClientAddress = "-----";
  public static string ClientAMCEnd = "00/00/0000";
  public static string SoftType = "5";
  public static string societyname;
  public static string societyId;
  public static string societycode;
  public static string societyAdd;
  public static string societyRegNo;
  public static string societyRegDt;
  public static string societyShAmt;
  public static string socDataPath;
  public static string socAppDataPath;
  public static DateTime socFYSTART;
  public static DateTime socFYEND;
  public static string SocDataFile;
  public static string SocOtherMaster;
  public static string SocStatMaster;
  public static string SocDataFileWOPassword;
  public static long SocCashBank;
  public static long SocDebtor;
  public static long SocCreditor;
  public static long SocInterest;
  public static string SocIntprio;
  public static string dateRangeFrom;
  public static string dateRangeto;
  public static string recdateRangeFrom;
  public static string recdateRangeto;
  public static string defaDate;
  public static int NumberRangeFrom;
  public static int NumberRangeto;
  public static string MemberCodeRangeFrom;
  public static string MemberCodeRangeto;
  public static string loginStatus;
  public static string loginLevel;
  public static string loginUser;
  public static string loginPassword;
  public static string soconlinesrno = "00000_000_00000000_";
  public static string SocEmailId;
  public static string SocEmailPassword;
  public static string CnPassdb = "MSC";
  public static string SocEmailSubject;
  public static string Billformat = "0";
  public static string SMsgSave = "Saved";
  public static string SMsgUpdate = "Updated";
  public static string SMsgDelete = "Delete";
  public static string SMsgNumValid = "Valid only Numeric Value";
  public static string SMsgDateValid = "Valid only Date in Format 'dd/mm/yyyy'";
  public static string SMsgBlankValid = "Cannot be Blank";
  public static string SMsgSelectRecord = "Please Select the Record";
  public static string SIMsgInfo = "!!! Information !!!";
  public static string SIMsgWarn = "!!! Warning !!!";
  public static string SIMsgSugg = "!!! Suggestion !!!";
  public static string SearchStr = "";
  public static bool SearchStat = false;
  public static string ShowMemAc = "Hide";
  public static string RecBifurcation = "N";
  public static string SocMarathi = "N";
  public static string SocWhatsup = "N";
  public static string SocLockStatus = "N";
  public static string IPAddress;
  public static string PortNumber;
  public static string mobilenum;
  public static string emailid;
  public static string authkey;
  public static string contenttype;
  public static string company;
  public static string num;
  public static string content;
  public static string apitoken;
  public static object StrRequestXML;
}
