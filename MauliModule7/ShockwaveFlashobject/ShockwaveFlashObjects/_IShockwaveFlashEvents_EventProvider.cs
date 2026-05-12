// Decompiled with JetBrains decompiler
// Type: ShockwaveFlashObjects._IShockwaveFlashEvents_EventProvider
// Assembly: ShockwaveFlashObjects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 074923B7-35CE-44D7-AC6B-153DD1515B7D
// Assembly location: C:\WINDOWS\assembly\GAC\ShockwaveFlashObjects\1.0.0.0__692fbea5521e1304\ShockwaveFlashObjects.dll

using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;

#nullable disable
namespace ShockwaveFlashObjects;

internal sealed class _IShockwaveFlashEvents_EventProvider : 
  _IShockwaveFlashEvents_Event,
  IDisposable
{
  private UCOMIConnectionPointContainer m_ConnectionPointContainer;
  private ArrayList m_aEventSinkHelpers;
  private UCOMIConnectionPoint m_ConnectionPoint;

  private void Init()
  {
    UCOMIConnectionPoint ppCP = (UCOMIConnectionPoint) null;
    Guid riid = new Guid(new byte[16 /*0x10*/]
    {
      (byte) 109,
      (byte) 219,
      (byte) 124,
      (byte) 210,
      (byte) 109,
      (byte) 174,
      (byte) 207,
      (byte) 17,
      (byte) 150,
      (byte) 184,
      (byte) 68,
      (byte) 69,
      (byte) 83,
      (byte) 84,
      (byte) 0,
      (byte) 0
    });
    this.m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
    this.m_ConnectionPoint = ppCP;
    this.m_aEventSinkHelpers = new ArrayList();
  }

  public virtual void add_FlashCall([In] _IShockwaveFlashEvents_FlashCallEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      _IShockwaveFlashEvents_SinkHelper pUnkSink = new _IShockwaveFlashEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_FlashCallDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_FlashCall([In] _IShockwaveFlashEvents_FlashCallEventHandler obj0)
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
        _IShockwaveFlashEvents_SinkHelper aEventSinkHelper = (_IShockwaveFlashEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_FlashCallDelegate != null && ((aEventSinkHelper.m_FlashCallDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
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

  public virtual void add_FSCommand([In] _IShockwaveFlashEvents_FSCommandEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      _IShockwaveFlashEvents_SinkHelper pUnkSink = new _IShockwaveFlashEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_FSCommandDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_FSCommand([In] _IShockwaveFlashEvents_FSCommandEventHandler obj0)
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
        _IShockwaveFlashEvents_SinkHelper aEventSinkHelper = (_IShockwaveFlashEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_FSCommandDelegate != null && ((aEventSinkHelper.m_FSCommandDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
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

  public virtual void add_OnProgress([In] _IShockwaveFlashEvents_OnProgressEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      _IShockwaveFlashEvents_SinkHelper pUnkSink = new _IShockwaveFlashEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_OnProgressDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_OnProgress([In] _IShockwaveFlashEvents_OnProgressEventHandler obj0)
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
        _IShockwaveFlashEvents_SinkHelper aEventSinkHelper = (_IShockwaveFlashEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_OnProgressDelegate != null && ((aEventSinkHelper.m_OnProgressDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
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

  public virtual void add_OnReadyStateChange(
    [In] _IShockwaveFlashEvents_OnReadyStateChangeEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      _IShockwaveFlashEvents_SinkHelper pUnkSink = new _IShockwaveFlashEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_OnReadyStateChangeDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_OnReadyStateChange(
    [In] _IShockwaveFlashEvents_OnReadyStateChangeEventHandler obj0)
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
        _IShockwaveFlashEvents_SinkHelper aEventSinkHelper = (_IShockwaveFlashEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_OnReadyStateChangeDelegate != null && ((aEventSinkHelper.m_OnReadyStateChangeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
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

  public _IShockwaveFlashEvents_EventProvider([In] object obj0)
  {
    this.m_ConnectionPointContainer = (UCOMIConnectionPointContainer) obj0;
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
      if (0 < count)
      {
        do
        {
          this.m_ConnectionPoint.Unadvise(((_IShockwaveFlashEvents_SinkHelper) this.m_aEventSinkHelpers[index]).m_dwCookie);
          ++index;
        }
        while (index < count);
      }
      Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
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
