// Decompiled with JetBrains decompiler
// Type: log4net.Util.EmptyDictionary
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;
using System.Collections;

#nullable disable
namespace log4net.Util;

[Serializable]
public sealed class EmptyDictionary : IDictionary, ICollection, IEnumerable
{
  private static readonly EmptyDictionary s_instance = new EmptyDictionary();

  private EmptyDictionary()
  {
  }

  public static EmptyDictionary Instance => EmptyDictionary.s_instance;

  public void CopyTo(Array array, int index)
  {
  }

  public bool IsSynchronized => true;

  public int Count => 0;

  public object SyncRoot => (object) this;

  IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) NullEnumerator.Instance;

  public void Add(object key, object value) => throw new InvalidOperationException();

  public void Clear() => throw new InvalidOperationException();

  public bool Contains(object key) => false;

  public IDictionaryEnumerator GetEnumerator()
  {
    return (IDictionaryEnumerator) NullDictionaryEnumerator.Instance;
  }

  public void Remove(object key) => throw new InvalidOperationException();

  public bool IsFixedSize => true;

  public bool IsReadOnly => true;

  public ICollection Keys => (ICollection) EmptyCollection.Instance;

  public ICollection Values => (ICollection) EmptyCollection.Instance;

  public object this[object key]
  {
    get => (object) null;
    set => throw new InvalidOperationException();
  }
}
