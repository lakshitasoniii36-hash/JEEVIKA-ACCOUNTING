// Decompiled with JetBrains decompiler
// Type: log4net.Util.LevelMapping
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Core;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace log4net.Util;

public sealed class LevelMapping : IOptionHandler
{
  private Hashtable m_entriesMap = new Hashtable();
  private LevelMappingEntry[] m_entries;

  public void Add(LevelMappingEntry entry)
  {
    if (this.m_entriesMap.ContainsKey((object) entry.Level))
      this.m_entriesMap.Remove((object) entry.Level);
    this.m_entriesMap.Add((object) entry.Level, (object) entry);
  }

  public LevelMappingEntry Lookup(Level level)
  {
    if (this.m_entries != null)
    {
      foreach (LevelMappingEntry entry in this.m_entries)
      {
        if (level >= entry.Level)
          return entry;
      }
    }
    return (LevelMappingEntry) null;
  }

  public void ActivateOptions()
  {
    Level[] keys = new Level[this.m_entriesMap.Count];
    LevelMappingEntry[] items = new LevelMappingEntry[this.m_entriesMap.Count];
    this.m_entriesMap.Keys.CopyTo((Array) keys, 0);
    this.m_entriesMap.Values.CopyTo((Array) items, 0);
    Array.Sort<Level, LevelMappingEntry>(keys, items, 0, keys.Length, (IComparer<Level>) null);
    Array.Reverse((Array) items, 0, items.Length);
    foreach (LevelMappingEntry levelMappingEntry in items)
      levelMappingEntry.ActivateOptions();
    this.m_entries = items;
  }
}
