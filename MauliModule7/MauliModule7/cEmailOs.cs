// Decompiled with JetBrains decompiler
// Type: MauliModule7.cEmailOs
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

public class cEmailOs
{
  [DebuggerNonUserCode]
  public cEmailOs()
  {
  }

  public void Main(object sText, object vMailPassword, object vfromMailId, object vtoMailId)
  {
    MailMessage message = new MailMessage();
    message.From = new MailAddress(Conversions.ToString(vfromMailId));
    MailAddressCollection to = message.To;
    object[] objArray = new object[1]
    {
      RuntimeHelpers.GetObjectValue(vtoMailId)
    };
    object[] Arguments = objArray;
    bool[] flagArray = new bool[1]{ true };
    bool[] CopyBack = flagArray;
    NewLateBinding.LateCall((object) to, (Type) null, "Add", Arguments, (string[]) null, (Type[]) null, CopyBack, true);
    if (flagArray[0])
      vtoMailId = RuntimeHelpers.GetObjectValue(objArray[0]);
    message.Subject = Conversions.ToString(sText);
    message.Body = MyProject.Forms.frmEmailMemberAccount.txtBodyOs.Text + Constant.societyname;
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
