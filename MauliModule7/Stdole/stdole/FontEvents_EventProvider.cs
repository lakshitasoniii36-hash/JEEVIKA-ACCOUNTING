// Decompiled with JetBrains decompiler
// Type: stdole.FontEvents_EventProvider
// Assembly: stdole, Version=7.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// MVID: 1DF05181-E8B1-41E5-9E16-182D6B591D92
// Assembly location: C:\WINDOWS\assembly\GAC\stdole\7.0.3300.0__b03f5f7f11d50a3a\stdole.dll

using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;

#nullable disable
namespace stdole;

internal sealed class FontEvents_EventProvider : FontEvents_Event, IDisposable
{
  private UCOMIConnectionPointContainer m_ConnectionPointContainer;
  private ArrayList m_aEventSinkHelpers;
  private UCOMIConnectionPoint m_ConnectionPoint;

  private void Init()
  {
    UCOMIConnectionPoint ppCP = (UCOMIConnectionPoint) null;
    Guid riid = new Guid(new byte[16 /*0x10*/]
    {
      (byte) 10,
      (byte) 16 /*0x10*/,
      (byte) 246,
      (byte) 78,
      (byte) 136,
      (byte) 175,
      (byte) 208 /*0xD0*/,
      (byte) 17,
      (byte) 152,
      (byte) 70,
      (byte) 0,
      (byte) 192 /*0xC0*/,
      (byte) 79,
      (byte) 194,
      (byte) 153,
      (byte) 147
    });
    this.m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
    this.m_ConnectionPoint = ppCP;
    this.m_aEventSinkHelpers = new ArrayList();
  }

  public virtual void add_FontChanged(FontEvents_FontChangedEventHandler A_1)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      FontEvents_SinkHelper pUnkSink = new FontEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_FontChangedDelegate = A_1;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_FontChanged(FontEvents_FontChangedEventHandler A_1)
  {
    Monitor.Enter((object) this);
    try
    {
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        FontEvents_SinkHelper aEventSinkHelper = (FontEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_FontChangedDelegate != null && ((aEventSinkHelper.m_FontChangedDelegate.Equals((object) A_1) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            this.m_ConnectionPoint = (UCOMIConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_8;
        }
        ++index;
      }
      while (index < count);
      goto label_9;
label_8:
      return;
label_9:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public FontEvents_EventProvider(object A_1)
  {
    this.m_ConnectionPointContainer = (UCOMIConnectionPointContainer) A_1;
  }

  public override void Finalize()
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        return;
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        this.m_ConnectionPoint.Unadvise(((FontEvents_SinkHelper) this.m_aEventSinkHelpers[index]).m_dwCookie);
        ++index;
      }
      while (index < count);
    }
    catch (Exception ex)
    {
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void Dispose()
  {
    this.Finalize();
    GC.SuppressFinalize((object) this);
  }
}
