// Decompiled with JetBrains decompiler
// Type: log4net.Core.FixFlags
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;

#nullable disable
namespace log4net.Core;

[Flags]
public enum FixFlags
{
  [Obsolete("Replaced by composite Properties")] Mdc = 1,
  Ndc = 2,
  Message = 4,
  ThreadName = 8,
  LocationInfo = 16, // 0x00000010
  UserName = 32, // 0x00000020
  Domain = 64, // 0x00000040
  Identity = 128, // 0x00000080
  Exception = 256, // 0x00000100
  Properties = 512, // 0x00000200
  None = 0,
  All = 268435455, // 0x0FFFFFFF
  Partial = Properties | Exception | Domain | ThreadName | Message, // 0x0000034C
}
