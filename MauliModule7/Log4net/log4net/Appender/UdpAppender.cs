// Decompiled with JetBrains decompiler
// Type: log4net.Appender.UdpAppender
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using log4net.Util;
using System;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;

#nullable disable
namespace log4net.Appender;

public class UdpAppender : AppenderSkeleton
{
  private IPAddress m_remoteAddress;
  private int m_remotePort;
  private IPEndPoint m_remoteEndPoint;
  private int m_localPort;
  private UdpClient m_client;
  private Encoding m_encoding = Encoding.Default;

  public IPAddress RemoteAddress
  {
    get => this.m_remoteAddress;
    set => this.m_remoteAddress = value;
  }

  public int RemotePort
  {
    get => this.m_remotePort;
    set
    {
      this.m_remotePort = value >= 0 && value <= (int) ushort.MaxValue ? value : throw SystemInfo.CreateArgumentOutOfRangeException(nameof (value), (object) value, $"The value specified is less than {0.ToString((IFormatProvider) NumberFormatInfo.InvariantInfo)} or greater than {((int) ushort.MaxValue).ToString((IFormatProvider) NumberFormatInfo.InvariantInfo)}.");
    }
  }

  public int LocalPort
  {
    get => this.m_localPort;
    set
    {
      this.m_localPort = value == 0 || value >= 0 && value <= (int) ushort.MaxValue ? value : throw SystemInfo.CreateArgumentOutOfRangeException(nameof (value), (object) value, $"The value specified is less than {0.ToString((IFormatProvider) NumberFormatInfo.InvariantInfo)} or greater than {((int) ushort.MaxValue).ToString((IFormatProvider) NumberFormatInfo.InvariantInfo)}.");
    }
  }

  public Encoding Encoding
  {
    get => this.m_encoding;
    set => this.m_encoding = value;
  }

  protected UdpClient Client
  {
    get => this.m_client;
    set => this.m_client = value;
  }

  protected IPEndPoint RemoteEndPoint
  {
    get => this.m_remoteEndPoint;
    set => this.m_remoteEndPoint = value;
  }

  public override void ActivateOptions()
  {
    base.ActivateOptions();
    if (this.RemoteAddress == null)
      throw new ArgumentNullException("The required property 'Address' was not specified.");
    if (this.RemotePort < 0 || this.RemotePort > (int) ushort.MaxValue)
      throw SystemInfo.CreateArgumentOutOfRangeException("this.RemotePort", (object) this.RemotePort, $"The RemotePort is less than {0.ToString((IFormatProvider) NumberFormatInfo.InvariantInfo)} or greater than {((int) ushort.MaxValue).ToString((IFormatProvider) NumberFormatInfo.InvariantInfo)}.");
    if (this.LocalPort != 0 && (this.LocalPort < 0 || this.LocalPort > (int) ushort.MaxValue))
      throw SystemInfo.CreateArgumentOutOfRangeException("this.LocalPort", (object) this.LocalPort, $"The LocalPort is less than {0.ToString((IFormatProvider) NumberFormatInfo.InvariantInfo)} or greater than {((int) ushort.MaxValue).ToString((IFormatProvider) NumberFormatInfo.InvariantInfo)}.");
    this.RemoteEndPoint = new IPEndPoint(this.RemoteAddress, this.RemotePort);
    this.InitializeClientConnection();
  }

  protected override void Append(LoggingEvent loggingEvent)
  {
    try
    {
      byte[] bytes = this.m_encoding.GetBytes(this.RenderLoggingEvent(loggingEvent).ToCharArray());
      this.Client.Send(bytes, bytes.Length, this.RemoteEndPoint);
    }
    catch (Exception ex)
    {
      this.ErrorHandler.Error($"Unable to send logging event to remote host {this.RemoteAddress.ToString()} on port {(object) this.RemotePort}.", ex, ErrorCode.WriteFailure);
    }
  }

  protected override bool RequiresLayout => true;

  protected override void OnClose()
  {
    base.OnClose();
    if (this.Client == null)
      return;
    this.Client.Close();
    this.Client = (UdpClient) null;
  }

  protected virtual void InitializeClientConnection()
  {
    try
    {
      if (this.LocalPort == 0)
        this.Client = new UdpClient();
      else
        this.Client = new UdpClient(this.LocalPort);
    }
    catch (Exception ex)
    {
      this.ErrorHandler.Error($"Could not initialize the UdpClient connection on port {this.LocalPort.ToString((IFormatProvider) NumberFormatInfo.InvariantInfo)}.", ex, ErrorCode.GenericFailure);
      this.Client = (UdpClient) null;
    }
  }
}
