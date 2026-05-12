// Decompiled with JetBrains decompiler
// Type: log4net.Util.QuietTextWriter
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System;
using System.IO;

#nullable disable
namespace log4net.Util;

public class QuietTextWriter : TextWriterAdapter
{
  private IErrorHandler m_errorHandler;
  private bool m_closed;

  public QuietTextWriter(TextWriter writer, IErrorHandler errorHandler)
    : base(writer)
  {
    this.ErrorHandler = errorHandler != null ? errorHandler : throw new ArgumentNullException(nameof (errorHandler));
  }

  public IErrorHandler ErrorHandler
  {
    get => this.m_errorHandler;
    set
    {
      this.m_errorHandler = value != null ? value : throw new ArgumentNullException(nameof (value));
    }
  }

  public bool Closed => this.m_closed;

  public override void Write(char value)
  {
    try
    {
      base.Write(value);
    }
    catch (Exception ex)
    {
      this.m_errorHandler.Error($"Failed to write [{(object) value}].", ex, ErrorCode.WriteFailure);
    }
  }

  public override void Write(char[] buffer, int index, int count)
  {
    try
    {
      base.Write(buffer, index, count);
    }
    catch (Exception ex)
    {
      this.m_errorHandler.Error("Failed to write buffer.", ex, ErrorCode.WriteFailure);
    }
  }

  public override void Write(string value)
  {
    try
    {
      base.Write(value);
    }
    catch (Exception ex)
    {
      this.m_errorHandler.Error($"Failed to write [{value}].", ex, ErrorCode.WriteFailure);
    }
  }

  public override void Close()
  {
    this.m_closed = true;
    base.Close();
  }
}
