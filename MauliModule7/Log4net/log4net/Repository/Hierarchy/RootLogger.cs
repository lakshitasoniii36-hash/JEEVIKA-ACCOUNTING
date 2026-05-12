// Decompiled with JetBrains decompiler
// Type: log4net.Repository.Hierarchy.RootLogger
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using log4net.Util;
using System;

#nullable disable
namespace log4net.Repository.Hierarchy;

public class RootLogger : Logger
{
  public RootLogger(Level level)
    : base("root")
  {
    this.Level = level;
  }

  public override Level EffectiveLevel => base.Level;

  public override Level Level
  {
    get => base.Level;
    set
    {
      if (value == (Level) null)
        LogLog.Error("RootLogger: You have tried to set a null level to root.", (Exception) new LogException());
      else
        base.Level = value;
    }
  }
}
