// Decompiled with JetBrains decompiler
// Type: MauliModule7.cWhatsupvalidation
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MSXML2;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

#nullable disable
namespace MauliModule7;

public class cWhatsupvalidation
{
  [DebuggerNonUserCode]
  public cWhatsupvalidation()
  {
  }

  public void InitializeWhatsApp(string IPAddressOrServerName, string MobileNumber, string Email)
  {
    Constant.IPAddress = IPAddressOrServerName;
    Constant.PortNumber = "5454";
    Constant.mobilenum = MobileNumber;
    Constant.emailid = Email;
  }

  public string CheckStatus()
  {
    ServerXMLHTTP60 serverXmlhttP60 = (ServerXMLHTTP60) new ServerXMLHTTP60Class();
    Constant.contenttype = "chksrv";
    Constant.authkey = "";
    Constant.company = "";
    Constant.apitoken = "";
    this.Request();
    string bstrUrl = $"http://{Constant.IPAddress}:5454/Morya/";
    ((IServerXMLHTTPRequest2) serverXmlhttP60).open("POST", bstrUrl, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value);
    ((IServerXMLHTTPRequest2) serverXmlhttP60).send(RuntimeHelpers.GetObjectValue(Constant.StrRequestXML));
    string responseText1 = ((IServerXMLHTTPRequest2) serverXmlhttP60).responseText;
    object objectValue1 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Microsoft.XMLDOM"));
    NewLateBinding.LateSet(objectValue1, (Type) null, "async", new object[1]
    {
      (object) false
    }, (string[]) null, (Type[]) null);
    object Instance1 = objectValue1;
    object[] objArray1 = new object[1]
    {
      (object) responseText1
    };
    object[] Arguments1 = objArray1;
    bool[] flagArray1 = new bool[1]{ true };
    bool[] CopyBack1 = flagArray1;
    NewLateBinding.LateCall(Instance1, (Type) null, "loadXML", Arguments1, (string[]) null, (Type[]) null, CopyBack1, true);
    string str1;
    if (flagArray1[0])
      str1 = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1[0]), typeof (string));
    object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue1, (Type) null, "selectSingleNode", new object[1]
    {
      (object) "//response"
    }, (string[]) null, (Type[]) null, (bool[]) null));
    Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, (Type) null, "selectSingleNode", new object[1]
    {
      (object) "success"
    }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Text", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
    string String1 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, (Type) null, "selectSingleNode", new object[1]
    {
      (object) "message"
    }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Text", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
    string str2;
    if (Strings.InStr(1, String1, "Running") > 0)
    {
      Constant.contenttype = "signup";
      this.Request();
      str1 = "";
      ((IServerXMLHTTPRequest2) serverXmlhttP60).open("POST", bstrUrl, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value);
      ((IServerXMLHTTPRequest2) serverXmlhttP60).send(RuntimeHelpers.GetObjectValue(Constant.StrRequestXML));
      string responseText2 = ((IServerXMLHTTPRequest2) serverXmlhttP60).responseText;
      if (Operators.CompareString(responseText2, "", false) != 0)
      {
        object Instance2 = objectValue1;
        object[] objArray2 = new object[1]
        {
          (object) responseText2
        };
        object[] Arguments2 = objArray2;
        bool[] flagArray2 = new bool[1]{ true };
        bool[] CopyBack2 = flagArray2;
        NewLateBinding.LateCall(Instance2, (Type) null, "loadXML", Arguments2, (string[]) null, (Type[]) null, CopyBack2, true);
        if (flagArray2[0])
          str1 = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray2[0]), typeof (string));
        object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue1, (Type) null, "selectSingleNode", new object[1]
        {
          (object) "//Response"
        }, (string[]) null, (Type[]) null, (bool[]) null));
        Constant.apitoken = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, (Type) null, "selectSingleNode", new object[1]
        {
          (object) "Authkey"
        }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Text", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
        Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, (Type) null, "selectSingleNode", new object[1]
        {
          (object) "Message"
        }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Text", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
        if (Strings.Len(Constant.apitoken) > 0)
        {
          Constant.contenttype = "login";
          this.Request();
          str1 = "";
          ((IServerXMLHTTPRequest2) serverXmlhttP60).open("POST", bstrUrl, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value);
          ((IServerXMLHTTPRequest2) serverXmlhttP60).send(RuntimeHelpers.GetObjectValue(Constant.StrRequestXML));
          string responseText3 = ((IServerXMLHTTPRequest2) serverXmlhttP60).responseText;
          if (Operators.CompareString(responseText3, "", false) != 0)
          {
            object Instance3 = objectValue1;
            object[] objArray3 = new object[1]
            {
              (object) responseText3
            };
            object[] Arguments3 = objArray3;
            bool[] flagArray3 = new bool[1]{ true };
            bool[] CopyBack3 = flagArray3;
            NewLateBinding.LateCall(Instance3, (Type) null, "loadXML", Arguments3, (string[]) null, (Type[]) null, CopyBack3, true);
            if (flagArray3[0])
              str1 = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray3[0]), typeof (string));
            string Left = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue1, (Type) null, "selectSingleNode", new object[1]
            {
              (object) "/response"
            }, (string[]) null, (Type[]) null, (bool[]) null)), (Type) null, "selectSingleNode", new object[1]
            {
              (object) "message"
            }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Text", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
            if (Operators.CompareString(Left, "Validity Is Over", false) != 0)
            {
              Constant.authkey = Left;
              Constant.contenttype = "walogin";
              this.Request();
              str1 = "";
              ((IServerXMLHTTPRequest2) serverXmlhttP60).open("POST", bstrUrl, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value);
              ((IServerXMLHTTPRequest2) serverXmlhttP60).send(RuntimeHelpers.GetObjectValue(Constant.StrRequestXML));
              string responseText4 = ((IServerXMLHTTPRequest2) serverXmlhttP60).responseText;
              if (Operators.CompareString(responseText4, "", false) != 0)
              {
                object Instance4 = objectValue1;
                object[] objArray4 = new object[1]
                {
                  (object) responseText4
                };
                object[] Arguments4 = objArray4;
                bool[] flagArray4 = new bool[1]{ true };
                bool[] CopyBack4 = flagArray4;
                NewLateBinding.LateCall(Instance4, (Type) null, "loadXML", Arguments4, (string[]) null, (Type[]) null, CopyBack4, true);
                if (flagArray4[0])
                  str1 = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray4[0]), typeof (string));
                str2 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue1, (Type) null, "selectSingleNode", new object[1]
                {
                  (object) "//response"
                }, (string[]) null, (Type[]) null, (bool[]) null)), (Type) null, "selectSingleNode", new object[1]
                {
                  (object) "message"
                }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Text", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
              }
              else
                str2 = "You are not Authorized User";
            }
            else
              str2 = "You are not Authorized User";
          }
          else
            str2 = "You are not Authorized User";
        }
        else
          str2 = "You are not Authorized User";
      }
    }
    else
      str2 = String1;
    return str2;
  }

  public string SendWhatsApp(string msgtype, string msg_or_file, string number)
  {
    ServerXMLHTTP60 serverXmlhttP60 = (ServerXMLHTTP60) new ServerXMLHTTP60Class();
    string bstrUrl = $"http://{Constant.IPAddress}:5454/Morya/";
    Constant.contenttype = Operators.CompareString(msgtype, "text", false) != 0 ? "doc" : "msg";
    Constant.num = number;
    Constant.content = msg_or_file;
    this.WARequest();
    string str = "";
    ((IServerXMLHTTPRequest2) serverXmlhttP60).open("POST", bstrUrl, (object) Missing.Value, (object) Missing.Value, (object) Missing.Value);
    ((IServerXMLHTTPRequest2) serverXmlhttP60).send(RuntimeHelpers.GetObjectValue(Constant.StrRequestXML));
    string responseText = ((IServerXMLHTTPRequest2) serverXmlhttP60).responseText;
    object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Microsoft.XMLDOM"));
    NewLateBinding.LateSet(objectValue, (Type) null, "async", new object[1]
    {
      (object) false
    }, (string[]) null, (Type[]) null);
    object Instance = objectValue;
    object[] objArray = new object[1]
    {
      (object) responseText
    };
    object[] Arguments = objArray;
    bool[] flagArray = new bool[1]{ true };
    bool[] CopyBack = flagArray;
    NewLateBinding.LateCall(Instance, (Type) null, "loadXML", Arguments, (string[]) null, (Type[]) null, CopyBack, true);
    if (flagArray[0])
      str = (string) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (string));
    return Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type) null, "selectSingleNode", new object[1]
    {
      (object) "//response"
    }, (string[]) null, (Type[]) null, (bool[]) null)), (Type) null, "selectSingleNode", new object[1]
    {
      (object) "message"
    }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Text", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
  }

  private void Request()
  {
    Constant.StrRequestXML = (object) $"<Request><tsn>{Constant.mobilenum}</tsn><num>{Constant.mobilenum}</num><content>{Constant.emailid}</content><mac></mac><ipaddr></ipaddr><authkey>{Constant.authkey}</authkey><compname></compname><contenttype>{Constant.contenttype}</contenttype><company>{Constant.company}</company><apitoken>{Constant.apitoken}</apitoken></Request>";
  }

  private void WARequest()
  {
    Constant.StrRequestXML = (object) $"<Request><num>{Constant.num}</num><content>{Constant.content}</content><contenttype>{Constant.contenttype}</contenttype><tsn>{Constant.mobilenum}</tsn><mac></mac><ipaddr></ipaddr><authkey>{Constant.authkey}</authkey><compname></compname><company>{Constant.company}</company></Request>";
  }
}
