// Decompiled with JetBrains decompiler
// Type: log4net.ObjectRenderer.DefaultRenderer
// Assembly: log4net, Version=1.2.10.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 7C47EEE6-E76D-4EE6-BAD3-6F27F14CD2E4
// Assembly location: C:\WINDOWS\assembly\GAC_32\log4net\1.2.10.0__692fbea5521e1304\log4net.dll

using log4net.Util;
using System;
using System.Collections;
using System.IO;

#nullable disable
namespace log4net.ObjectRenderer;

public sealed class DefaultRenderer : IObjectRenderer
{
  public void RenderObject(RendererMap rendererMap, object obj, TextWriter writer)
  {
    if (rendererMap == null)
      throw new ArgumentNullException(nameof (rendererMap));
    switch (obj)
    {
      case null:
        writer.Write(SystemInfo.NullText);
        break;
      case Array array:
        this.RenderArray(rendererMap, array, writer);
        break;
      case IEnumerable enumerable:
        switch (obj)
        {
          case ICollection collection when collection.Count == 0:
            writer.Write("{}");
            return;
          case IDictionary dictionary:
            this.RenderEnumerator(rendererMap, (IEnumerator) dictionary.GetEnumerator(), writer);
            return;
          default:
            this.RenderEnumerator(rendererMap, enumerable.GetEnumerator(), writer);
            return;
        }
      case IEnumerator enumerator:
        this.RenderEnumerator(rendererMap, enumerator, writer);
        break;
      case DictionaryEntry entry:
        this.RenderDictionaryEntry(rendererMap, entry, writer);
        break;
      default:
        string str = obj.ToString();
        writer.Write(str == null ? SystemInfo.NullText : str);
        break;
    }
  }

  private void RenderArray(RendererMap rendererMap, Array array, TextWriter writer)
  {
    if (array.Rank != 1)
    {
      writer.Write(array.ToString());
    }
    else
    {
      writer.Write(array.GetType().Name + " {");
      int length = array.Length;
      if (length > 0)
      {
        rendererMap.FindAndRender(array.GetValue(0), writer);
        for (int index = 1; index < length; ++index)
        {
          writer.Write(", ");
          rendererMap.FindAndRender(array.GetValue(index), writer);
        }
      }
      writer.Write("}");
    }
  }

  private void RenderEnumerator(RendererMap rendererMap, IEnumerator enumerator, TextWriter writer)
  {
    writer.Write("{");
    if (enumerator != null && enumerator.MoveNext())
    {
      rendererMap.FindAndRender(enumerator.Current, writer);
      while (enumerator.MoveNext())
      {
        writer.Write(", ");
        rendererMap.FindAndRender(enumerator.Current, writer);
      }
    }
    writer.Write("}");
  }

  private void RenderDictionaryEntry(
    RendererMap rendererMap,
    DictionaryEntry entry,
    TextWriter writer)
  {
    rendererMap.FindAndRender(entry.Key, writer);
    writer.Write("=");
    rendererMap.FindAndRender(entry.Value, writer);
  }
}
