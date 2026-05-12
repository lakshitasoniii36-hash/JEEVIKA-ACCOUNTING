// Decompiled with JetBrains decompiler
// Type: log4net.Util.PropertiesDictionary
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using System;
using System.Collections;
using System.Runtime.Serialization;

#nullable disable
namespace log4net.Util;

[Serializable]
public sealed class PropertiesDictionary : 
  ReadOnlyPropertiesDictionary,
  ISerializable,
  IDictionary,
  ICollection,
  IEnumerable
{
  public PropertiesDictionary()
  {
  }

  public PropertiesDictionary(ReadOnlyPropertiesDictionary propertiesDictionary)
    : base(propertiesDictionary)
  {
  }

  private PropertiesDictionary(SerializationInfo info, StreamingContext context)
    : base(info, context)
  {
  }

  public override object this[string key]
  {
    get => this.InnerHashtable[(object) key];
    set => this.InnerHashtable[(object) key] = value;
  }

  public void Remove(string key) => this.InnerHashtable.Remove((object) key);

  IDictionaryEnumerator IDictionary.GetEnumerator() => this.InnerHashtable.GetEnumerator();

  void IDictionary.Remove(object key) => this.InnerHashtable.Remove(key);

  bool IDictionary.Contains(object key) => this.InnerHashtable.Contains(key);

  public override void Clear() => this.InnerHashtable.Clear();

  void IDictionary.Add(object key, object value)
  {
    if (!(key is string))
      throw new ArgumentException("key must be a string", nameof (key));
    this.InnerHashtable.Add(key, value);
  }

  bool IDictionary.IsReadOnly => false;

  object IDictionary.this[object key]
  {
    get
    {
      return key is string ? this.InnerHashtable[key] : throw new ArgumentException("key must be a string", nameof (key));
    }
    set
    {
      if (!(key is string))
        throw new ArgumentException("key must be a string", nameof (key));
      this.InnerHashtable[key] = value;
    }
  }

  ICollection IDictionary.Values => this.InnerHashtable.Values;

  ICollection IDictionary.Keys => this.InnerHashtable.Keys;

  bool IDictionary.IsFixedSize => false;

  void ICollection.CopyTo(Array array, int index) => this.InnerHashtable.CopyTo(array, index);

  bool ICollection.IsSynchronized => this.InnerHashtable.IsSynchronized;

  object ICollection.SyncRoot => this.InnerHashtable.SyncRoot;

  IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable) this.InnerHashtable).GetEnumerator();
}
