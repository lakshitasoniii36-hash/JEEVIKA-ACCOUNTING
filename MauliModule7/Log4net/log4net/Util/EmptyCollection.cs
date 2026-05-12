// Decompiled with JetBrains decompiler
// Type: log4net.Util.EmptyCollection
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;
using System.Collections;

#nullable disable
namespace log4net.Util;

[Serializable]
public sealed class EmptyCollection : ICollection, IEnumerable
{
  private static readonly EmptyCollection s_instance = new EmptyCollection();

  private EmptyCollection()
  {
  }

  public static EmptyCollection Instance => EmptyCollection.s_instance;

  public void CopyTo(Array array, int index)
  {
  }

  public bool IsSynchronized => true;

  public int Count => 0;

  public object SyncRoot => (object) this;

  public IEnumerator GetEnumerator() => (IEnumerator) NullEnumerator.Instance;
}
