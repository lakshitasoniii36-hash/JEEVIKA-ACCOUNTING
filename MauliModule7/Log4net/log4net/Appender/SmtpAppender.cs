// Decompiled with JetBrains decompiler
// Type: log4net.Appender.SmtpAppender
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System;
using System.Globalization;
using System.IO;
using System.Web.Mail;

#nullable disable
namespace log4net.Appender;

public class SmtpAppender : BufferingAppenderSkeleton
{
  private string m_to;
  private string m_from;
  private string m_subject;
  private string m_smtpHost;
  private SmtpAppender.SmtpAuthentication m_authentication;
  private string m_username;
  private string m_password;
  private int m_port = 25;
  private MailPriority m_mailPriority;

  public string To
  {
    get => this.m_to;
    set => this.m_to = value;
  }

  public string From
  {
    get => this.m_from;
    set => this.m_from = value;
  }

  public string Subject
  {
    get => this.m_subject;
    set => this.m_subject = value;
  }

  public string SmtpHost
  {
    get => this.m_smtpHost;
    set => this.m_smtpHost = value;
  }

  [Obsolete("Use the BufferingAppenderSkeleton Fix methods")]
  public bool LocationInfo
  {
    get => false;
    set
    {
    }
  }

  public SmtpAppender.SmtpAuthentication Authentication
  {
    get => this.m_authentication;
    set => this.m_authentication = value;
  }

  public string Username
  {
    get => this.m_username;
    set => this.m_username = value;
  }

  public string Password
  {
    get => this.m_password;
    set => this.m_password = value;
  }

  public int Port
  {
    get => this.m_port;
    set => this.m_port = value;
  }

  public MailPriority Priority
  {
    get => this.m_mailPriority;
    set => this.m_mailPriority = value;
  }

  protected override void SendBuffer(LoggingEvent[] events)
  {
    try
    {
      StringWriter writer = new StringWriter((IFormatProvider) CultureInfo.InvariantCulture);
      string header = this.Layout.Header;
      if (header != null)
        writer.Write(header);
      for (int index = 0; index < events.Length; ++index)
        this.RenderLoggingEvent((TextWriter) writer, events[index]);
      string footer = this.Layout.Footer;
      if (footer != null)
        writer.Write(footer);
      this.SendEmail(writer.ToString());
    }
    catch (Exception ex)
    {
      this.ErrorHandler.Error("Error occurred while sending e-mail notification.", ex);
    }
  }

  protected override bool RequiresLayout => true;

  protected virtual void SendEmail(string messageBody)
  {
    MailMessage message = new MailMessage();
    message.Body = messageBody;
    message.From = this.m_from;
    message.To = this.m_to;
    message.Subject = this.m_subject;
    message.Priority = this.m_mailPriority;
    if (this.m_authentication != SmtpAppender.SmtpAuthentication.None)
      this.ErrorHandler.Error("SmtpAppender: Authentication is only supported on the MS .NET 1.1 or MS .NET 2.0 builds of log4net");
    if (this.m_port != 25)
      this.ErrorHandler.Error("SmtpAppender: Server Port is only supported on the MS .NET 1.1 or MS .NET 2.0 builds of log4net");
    if (this.m_smtpHost != null && this.m_smtpHost.Length > 0)
      SmtpMail.SmtpServer = this.m_smtpHost;
    SmtpMail.Send(message);
  }

  public enum SmtpAuthentication
  {
    None,
    Basic,
    Ntlm,
  }
}
