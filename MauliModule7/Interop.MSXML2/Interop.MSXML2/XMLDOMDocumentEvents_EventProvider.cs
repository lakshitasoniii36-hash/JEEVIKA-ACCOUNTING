// Decompiled with JetBrains decompiler
// Type: MSXML2.XMLDOMDocumentEvents_EventProvider
// Assembly: Interop.MSXML2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42FF73EE-2D3B-484F-8393-2D9B139D2D95
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Interop.MSXML2.dll

using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

#nullable disable
namespace MSXML2;

internal sealed class XMLDOMDocumentEvents_EventProvider : XMLDOMDocumentEvents_Event, IDisposable
{
  private IConnectionPointContainer m_ConnectionPointContainer;
  private ArrayList m_aEventSinkHelpers;
  private IConnectionPoint m_ConnectionPoint;

  private void Init()
  {
    IConnectionPoint ppCP = (IConnectionPoint) null;
    Guid riid = new Guid(new byte[16 /*0x10*/]
    {
      (byte) 39,
      (byte) 164,
      (byte) 250,
      (byte) 62,
      (byte) 47,
      (byte) 39,
      (byte) 210,
      (byte) 17,
      (byte) 131,
      (byte) 111,
      (byte) 0,
      (byte) 0,
      (byte) 248,
      (byte) 122,
      (byte) 119,
      (byte) 130
    });
    this.m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
    this.m_ConnectionPoint = ppCP;
    this.m_aEventSinkHelpers = new ArrayList();
  }

  public virtual void add_ondataavailable(
    [In] XMLDOMDocumentEvents_ondataavailableEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      XMLDOMDocumentEvents_SinkHelper pUnkSink = new XMLDOMDocumentEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_ondataavailableDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_ondataavailable(
    [In] XMLDOMDocumentEvents_ondataavailableEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_aEventSinkHelpers == null)
        return;
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        XMLDOMDocumentEvents_SinkHelper aEventSinkHelper = (XMLDOMDocumentEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_ondataavailableDelegate != null && ((aEventSinkHelper.m_ondataavailableDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (IConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_10;
        }
        ++index;
      }
      while (index < count);
      goto label_11;
label_10:
      return;
label_11:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void add_onreadystatechange(
    [In] XMLDOMDocumentEvents_onreadystatechangeEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      XMLDOMDocumentEvents_SinkHelper pUnkSink = new XMLDOMDocumentEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_onreadystatechangeDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_onreadystatechange(
    [In] XMLDOMDocumentEvents_onreadystatechangeEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_aEventSinkHelpers == null)
        return;
      int count = this.m_aEventSinkHelpers.Count;
      int index = 0;
      if (0 >= count)
        return;
      do
      {
        XMLDOMDocumentEvents_SinkHelper aEventSinkHelper = (XMLDOMDocumentEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_onreadystatechangeDelegate != null && ((aEventSinkHelper.m_onreadystatechangeDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
        {
          this.m_aEventSinkHelpers.RemoveAt(index);
          this.m_ConnectionPoint.Unadvise(aEventSinkHelper.m_dwCookie);
          if (count <= 1)
          {
            Marshal.ReleaseComObject((object) this.m_ConnectionPoint);
            this.m_ConnectionPoint = (IConnectionPoint) null;
            this.m_aEventSinkHelpers = (ArrayList) null;
            return;
          }
          goto label_10;
        }
        ++index;
      }
      while (index < count);
      goto label_11;
label_10:
      return;
label_11:;
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public XMLDOMDocumentEvents_EventProvider([In] object obj0)
  {
    this.m_ConnectionPointContainer = (IConnectionPointContainer) obj0;
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
          this.m_ConnectionPoint.Unadvise(((XMLDOMDocumentEvents_SinkHelper) this.m_aEventSinkHelpers[index]).m_dwCookie);
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
