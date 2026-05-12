// Decompiled with JetBrains decompiler
// Type: MauliModule7.GeneralValidation
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;

#nullable disable
namespace MauliModule7;

public class GeneralValidation
{
  private string strNumber;

  [DebuggerNonUserCode]
  public GeneralValidation()
  {
  }

  public bool Vdate(string vd)
  {
    bool flag = true;
    if (!Information.IsDate((object) vd))
    {
      int num = (int) Interaction.MsgBox((object) Constant.SMsgDateValid, Title: (object) Constant.SIMsgWarn);
      flag = false;
    }
    return flag;
  }

  public bool VdateRange(DateTime vd1)
  {
    bool flag = true;
    int num1 = DateTime.Compare(Constant.socFYSTART, vd1);
    int num2 = DateTime.Compare(Constant.socFYEND, vd1);
    if (num1 > 0)
    {
      int num3 = (int) Interaction.MsgBox((object) $"Valid Period {Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}", Title: (object) Constant.SIMsgWarn);
      flag = false;
    }
    if (num2 < 0)
    {
      int num4 = (int) Interaction.MsgBox((object) $"Valid Period {Conversions.ToString(Constant.socFYSTART)}-{Conversions.ToString(Constant.socFYEND)}", Title: (object) Constant.SIMsgWarn);
      flag = false;
    }
    return flag;
  }

  public bool VdateEqual(DateTime vd1)
  {
    bool flag = true;
    if (DateTime.Compare(Constant.socFYSTART, vd1) == 0)
      flag = false;
    return flag;
  }

  public bool VdateRangeLower(DateTime vd1)
  {
    bool flag = true;
    if (DateTime.Compare(Constant.socFYSTART, vd1) > 0)
    {
      int num = (int) Interaction.MsgBox((object) ("Period Should Greater than " + Conversions.ToString(Constant.socFYSTART)), Title: (object) Constant.SIMsgWarn);
      flag = false;
    }
    return flag;
  }

  public bool VdateLower(DateTime vd1, DateTime vd2) => DateTime.Compare(vd2, vd1) <= 0;

  public bool VdateLessRange(DateTime vd1)
  {
    bool flag = true;
    if (DateTime.Compare(Constant.socFYSTART, vd1) <= 0)
    {
      int num = (int) Interaction.MsgBox((object) ("Valid Date Less than " + Conversions.ToString(Constant.socFYSTART)), Title: (object) Constant.SIMsgWarn);
      flag = false;
    }
    return flag;
  }

  public static bool NValue(string NV)
  {
    bool flag;
    if (!Versioned.IsNumeric((object) NV))
    {
      int num = (int) Interaction.MsgBox((object) "Valid Only Numeric Value", Title: (object) Constant.SIMsgWarn);
      flag = false;
    }
    return flag;
  }

  public static string NumberToWords(int number)
  {
    if (number == 0)
      return "zero";
    if (number < 0)
      return GeneralValidation.NumberToWords(Math.Abs(number));
    string Left = "";
    if (number / 10000000 > 0)
    {
      Left = $"{Left}{GeneralValidation.NumberToWords(number / 10000000)} Corer ";
      number %= 10000000;
    }
    if (number / 100000 > 0)
    {
      Left = $"{Left}{GeneralValidation.NumberToWords(number / 100000)} Lakh ";
      number %= 100000;
    }
    if (number / 1000 > 0)
    {
      Left = $"{Left}{GeneralValidation.NumberToWords(number / 1000)} Thousand ";
      number %= 1000;
    }
    if (number / 100 > 0)
    {
      Left = $"{Left}{GeneralValidation.NumberToWords(number / 100)} Hundred ";
      number %= 100;
    }
    if (number > 0)
    {
      if (Operators.CompareString(Left, "", false) != 0)
        Left += "and ";
      string[] strArray1 = new string[20]
      {
        "Zero",
        "One",
        "Two",
        "Three",
        "Four",
        "Five",
        "Six",
        "Seven",
        "Eight",
        "Nine",
        "Ten",
        "Eleven",
        "Twelve",
        "Thirteen",
        "Fourteen",
        "Fifteen",
        "Sixteen",
        "Seventeen",
        "Eighteen",
        "Nineteen"
      };
      string[] strArray2 = new string[10]
      {
        "Zero",
        "Ten",
        "Twenty",
        "Thirty",
        "Forty",
        "Fifty",
        "Sixty",
        "Seventy",
        "Eighty",
        "Ninety"
      };
      if (number < 20)
      {
        Left += strArray1[number];
      }
      else
      {
        Left += strArray2[number / 10];
        if (number % 10 > 0)
          Left = $"{Left}-{strArray1[number % 10]}";
      }
    }
    return Left;
  }

  public static string CRupees(string NV)
  {
    string str1 = "Rupees ";
    if (Conversion.Val(NV.Trim()) > 0.0)
      str1 = "Rupees " + GeneralValidation.NumberToWords(checked ((int) Math.Round(Math.Truncate(Conversion.Val(NV.Trim())))));
    if (Conversion.Val(NV.Trim()) < 0.0)
      str1 = "Credit Rupees " + GeneralValidation.NumberToWords(checked ((int) Math.Round(Math.Truncate(Conversion.Val(NV.Trim())))));
    string str2 = Conversions.ToString(Math.Abs(Math.Round(Conversion.Val(NV.Trim()) - Math.Truncate(Conversion.Val(NV.Trim())), 2)));
    if (str2.Trim().Length == 3)
      str2 = str2.Trim() + "0";
    string str3;
    if (str2.Trim().Length == 4)
      str3 = $" & {GeneralValidation.NumberToWords(Conversions.ToInteger(str2.ToString().Substring(2, 2)))} Paise Only ";
    if (str2.Trim().Length == 1)
      str3 = " Only ";
    return $"{str1.Trim()} {str3.Trim()}";
  }

  public static string MarNumberToWords(int number)
  {
    if (number == 0)
      return "शून्य";
    if (number < 0)
      return GeneralValidation.MarNumberToWords(Math.Abs(number));
    string words = "";
    if (number / 10000000 > 0)
    {
      words = $"{words}{GeneralValidation.MarNumberToWords(number / 10000000)} करोड ";
      number %= 10000000;
    }
    if (number / 100000 > 0)
    {
      words = $"{words}{GeneralValidation.MarNumberToWords(number / 100000)} लाख  ";
      number %= 100000;
    }
    if (number / 1000 > 0)
    {
      words = $"{words}{GeneralValidation.MarNumberToWords(number / 1000)} हजार ";
      number %= 1000;
    }
    if (number / 100 > 0)
    {
      words = $"{words}{GeneralValidation.MarNumberToWords(number / 100)}शे ";
      number %= 100;
    }
    if (number > 0)
    {
      string[] strArray1 = new string[101]
      {
        "शून्य",
        "एक",
        "दोन",
        "तीन",
        "चार",
        "पाच",
        "सहा",
        "सात",
        "आठ",
        "नऊ",
        "दहा",
        "अकरा",
        "बारा",
        "तेरा",
        "चौदा",
        "पंधरा",
        "सोळा",
        "सतरा",
        "अठरा",
        "एकोणीस",
        "वीस",
        "एकवीस",
        "बावीस",
        "तेवीस",
        "चौवीस",
        "पंचवीस",
        "सव्वीस",
        "सत्तावीस",
        "अठ्ठावीस",
        "एकोणतीस",
        "तीस",
        "एकतीस",
        "बत्तीस",
        "तेहेत्तीस",
        "चौतीस",
        "पस्तीस",
        "छत्तीस",
        "सदतीस",
        "अडतीस",
        "एकोणचाळीस",
        "चाळीस",
        "एक्केचाळीस",
        "बेचाळीस",
        "त्रेचाळीस",
        "चौव्वेचाळीस",
        "पंचेचाळीस",
        "सेहेचाळीस",
        "सत्तेचाळीस",
        "अठ्ठेचाळीस ",
        "एकोणपन्नास",
        "पन्नास",
        "एक्कावन",
        "बावन",
        "त्रेपन्न",
        "चोपन",
        "पंचावन्न",
        "छपन्न",
        "सत्तावन",
        "अठ्ठावन्न",
        "एकोणसाठ",
        "साठ",
        "एकसष्ट",
        "बासष्ट",
        "त्रेसष्ट",
        "चौसष्ट",
        "पासष्ट",
        "सहासष्ट",
        "सदुसष्ट",
        "अडुसष्ट",
        "एकोणसत्तर",
        "सत्तर",
        "एकाहत्तर",
        "बाहत्तर",
        "त्र्याहत्तर",
        "चौर्\u200Dयाहत्तर",
        "पंच्याहत्तर",
        "शहात्तर",
        "सत्याहत्तर",
        "अठ्ठाहत्तर",
        "एकोणऐंशी",
        "ऐंशी",
        "एक्याऐंशी",
        "ब्याऐंशी",
        "त्र्याऐंशी",
        "चौर्\u200Dयाऐंशी",
        "पंच्याऐंशी",
        "शहाऐंशी",
        "सत्याऐंशी",
        "अठ्ठयाऐंशी",
        "एकोणनव्वद",
        "नव्वद",
        "एक्याण्णव",
        "ब्याण्णव",
        "त्र्याण्णव",
        "चौर्\u200Dयाण्णव",
        "पंच्याण्णव",
        "शहाण्णव",
        "सत्याण्णव",
        "अठ्ठयाण्णव",
        "नव्याण्णव",
        "शंभर"
      };
      string[] strArray2 = new string[10]
      {
        "शून्य",
        "दहा",
        "वीस",
        "तीस",
        "चाळीस",
        "पन्नास",
        "साठ",
        "सत्तर",
        "ऐंशी",
        "नव्वद"
      };
      if (number < 100)
      {
        words += strArray1[number];
      }
      else
      {
        words += strArray2[number / 10];
        if (number % 10 > 0)
          words = $"{words}-{strArray1[number % 10]}";
      }
    }
    return words;
  }

  public static string MARCRupees(string NV)
  {
    string str1 = "रुपये  ";
    if (Conversion.Val(NV.Trim()) > 0.0)
      str1 = "रुपये  " + GeneralValidation.MarNumberToWords(checked ((int) Math.Round(Math.Truncate(Conversion.Val(NV.Trim())))));
    if (Conversion.Val(NV.Trim()) < 0.0)
      str1 = "आगाऊ रुपये  " + GeneralValidation.MarNumberToWords(checked ((int) Math.Round(Math.Truncate(Conversion.Val(NV.Trim())))));
    string str2 = Conversions.ToString(Math.Abs(Math.Round(Conversion.Val(NV.Trim()) - Math.Truncate(Conversion.Val(NV.Trim())), 2)));
    if (str2.Trim().Length == 3)
      str2 = str2.Trim() + "0";
    string str3;
    if (str2.Trim().Length == 4)
      str3 = $" आणि {GeneralValidation.MarNumberToWords(Conversions.ToInteger(str2.ToString().Substring(2, 2)))} पैसे फक्त ";
    if (str2.Trim().Length == 1)
      str3 = " फक्त ";
    return $"{str1.Trim()} {str3.Trim()}";
  }
}
