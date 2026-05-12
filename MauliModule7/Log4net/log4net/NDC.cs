// Decompiled with JetBrains decompiler
// Type: log4net.NDC
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Util;
using System;
using System.Collections;

#nullable disable
namespace log4net;

public sealed class NDC
{
  private NDC()
  {
  }

  public static int Depth => ThreadContext.Stacks[nameof (NDC)].Count;

  public static void Clear() => ThreadContext.Stacks[nameof (NDC)].Clear();

  public static Stack CloneStack() => ThreadContext.Stacks[nameof (NDC)].InternalStack;

  public static void Inherit(Stack stack)
  {
    ThreadContext.Stacks[nameof (NDC)].InternalStack = stack;
  }

  public static string Pop() => ThreadContext.Stacks[nameof (NDC)].Pop();

  public static IDisposable Push(string message)
  {
    return ThreadContext.Stacks[nameof (NDC)].Push(message);
  }

  public static void Remove()
  {
  }

  public static void SetMaxDepth(int maxDepth)
  {
    if (maxDepth < 0)
      return;
    ThreadContextStack stack = ThreadContext.Stacks[nameof (NDC)];
    if (maxDepth == 0)
    {
      stack.Clear();
    }
    else
    {
      while (stack.Count > maxDepth)
        stack.Pop();
    }
  }
}
