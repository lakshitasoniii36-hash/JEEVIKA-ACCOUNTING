// Decompiled with JetBrains decompiler
// Type: log4net.Util.NullDictionaryEnumerator
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;
using System.Collections;

#nullable disable
namespace log4net.Util;

public sealed class NullDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
{
  private static readonly NullDictionaryEnumerator s_instance = new NullDictionaryEnumerator();

  private NullDictionaryEnumerator()
  {
  }

  public static NullDictionaryEnumerator Instance => NullDictionaryEnumerator.s_instance;

  public object Current => throw new InvalidOperationException();

  public bool MoveNext() => false;

  public void Reset()
  {
  }

  public object Key => throw new InvalidOperationException();

  public object Value => throw new InvalidOperationException();

  public DictionaryEntry Entry => throw new InvalidOperationException();
}
