// Decompiled with JetBrains decompiler
// Type: log4net.Util.FormattingInfo
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

#nullable disable
namespace log4net.Util;

public class FormattingInfo
{
  private int m_min = -1;
  private int m_max = int.MaxValue;
  private bool m_leftAlign;

  public FormattingInfo()
  {
  }

  public FormattingInfo(int min, int max, bool leftAlign)
  {
    this.m_min = min;
    this.m_max = max;
    this.m_leftAlign = leftAlign;
  }

  public int Min
  {
    get => this.m_min;
    set => this.m_min = value;
  }

  public int Max
  {
    get => this.m_max;
    set => this.m_max = value;
  }

  public bool LeftAlign
  {
    get => this.m_leftAlign;
    set => this.m_leftAlign = value;
  }
}
