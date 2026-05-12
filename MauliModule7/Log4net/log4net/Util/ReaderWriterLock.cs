// Decompiled with JetBrains decompiler
// Type: log4net.Util.ReaderWriterLock
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

#nullable disable
namespace log4net.Util;

public sealed class ReaderWriterLock
{
  private System.Threading.ReaderWriterLock m_lock;

  public ReaderWriterLock() => this.m_lock = new System.Threading.ReaderWriterLock();

  public void AcquireReaderLock() => this.m_lock.AcquireReaderLock(-1);

  public void ReleaseReaderLock() => this.m_lock.ReleaseReaderLock();

  public void AcquireWriterLock() => this.m_lock.AcquireWriterLock(-1);

  public void ReleaseWriterLock() => this.m_lock.ReleaseWriterLock();
}
