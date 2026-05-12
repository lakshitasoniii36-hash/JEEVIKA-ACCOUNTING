// Decompiled with JetBrains decompiler
// Type: MauliModule7.cEmailBlank
// Assembly: MauliModule7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F045263-56C9-469F-9585-90776CDB702C
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\MauliModule7.exe

using MauliModule7.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;

#nullable disable
namespace MauliModule7;

public class cEmailBlank
{
  [DebuggerNonUserCode]
  public cEmailBlank()
  {
  }

  public void Main(
    object sText,
    object vMailPassword,
    object vfromMailId,
    object vtoMailId,
    object vtoMailId1,
    object vtoMailId2,
    object vmailidno)
  {
    MailMessage message = new MailMessage();
    message.From = new MailAddress(Conversions.ToString(vfromMailId));
    MailAddressCollection to1 = message.To;
    object[] objArray1 = new object[1]
    {
      RuntimeHelpers.GetObjectValue(vtoMailId)
    };
    object[] Arguments1 = objArray1;
    bool[] flagArray1 = new bool[1]{ true };
    bool[] CopyBack1 = flagArray1;
    NewLateBinding.LateCall((object) to1, (Type) null, "Add", Arguments1, (string[]) null, (Type[]) null, CopyBack1, true);
    if (flagArray1[0])
      vtoMailId = RuntimeHelpers.GetObjectValue(objArray1[0]);
    if (Operators.ConditionalCompareObjectEqual(vmailidno, (object) 2, false) && Operators.CompareString(vtoMailId1.ToString().Trim(), "", false) != 0)
    {
      MailAddressCollection to2 = message.To;
      object[] objArray2 = new object[1]
      {
        RuntimeHelpers.GetObjectValue(vtoMailId1)
      };
      object[] Arguments2 = objArray2;
      bool[] flagArray2 = new bool[1]{ true };
      bool[] CopyBack2 = flagArray2;
      NewLateBinding.LateCall((object) to2, (Type) null, "Add", Arguments2, (string[]) null, (Type[]) null, CopyBack2, true);
      if (flagArray2[0])
        vtoMailId1 = RuntimeHelpers.GetObjectValue(objArray2[0]);
    }
    if (Operators.ConditionalCompareObjectEqual(vmailidno, (object) 3, false))
    {
      if (Operators.CompareString(vtoMailId1.ToString().Trim(), "", false) != 0)
      {
        MailAddressCollection to3 = message.To;
        object[] objArray3 = new object[1]
        {
          RuntimeHelpers.GetObjectValue(vtoMailId1)
        };
        object[] Arguments3 = objArray3;
        bool[] flagArray3 = new bool[1]{ true };
        bool[] CopyBack3 = flagArray3;
        NewLateBinding.LateCall((object) to3, (Type) null, "Add", Arguments3, (string[]) null, (Type[]) null, CopyBack3, true);
        if (flagArray3[0])
          vtoMailId1 = RuntimeHelpers.GetObjectValue(objArray3[0]);
      }
      if (Operators.CompareString(vtoMailId2.ToString().Trim(), "", false) != 0)
      {
        MailAddressCollection to4 = message.To;
        object[] objArray4 = new object[1]
        {
          RuntimeHelpers.GetObjectValue(vtoMailId2)
        };
        object[] Arguments4 = objArray4;
        bool[] flagArray4 = new bool[1]{ true };
        bool[] CopyBack4 = flagArray4;
        NewLateBinding.LateCall((object) to4, (Type) null, "Add", Arguments4, (string[]) null, (Type[]) null, CopyBack4, true);
        if (flagArray4[0])
          vtoMailId2 = RuntimeHelpers.GetObjectValue(objArray4[0]);
      }
    }
    message.Subject = MyProject.Forms.frmEmailMemberAccount.txtSubject.Text;
    message.Body = Conversions.ToString(sText);
    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
    smtpClient.Port = 587;
    smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential(Conversions.ToString(vfromMailId), Conversions.ToString(vMailPassword));
    smtpClient.EnableSsl = true;
    try
    {
      smtpClient.Send(message);
      MyProject.Forms.frmEmailMember.lblMailError.Text = "No";
    }
    catch (SmtpException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      MyProject.Forms.frmEmailMember.lblMailError.Text = "Yes";
      ProjectData.ClearProjectError();
    }
  }
}
