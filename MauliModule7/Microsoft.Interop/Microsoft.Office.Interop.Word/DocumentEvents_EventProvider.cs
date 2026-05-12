// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.DocumentEvents_EventProvider
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;

#nullable disable
namespace Microsoft.Office.Interop.Word;

internal sealed class DocumentEvents_EventProvider : DocumentEvents_Event, IDisposable
{
  private UCOMIConnectionPointContainer m_ConnectionPointContainer;
  private ArrayList m_aEventSinkHelpers;
  private UCOMIConnectionPoint m_ConnectionPoint;

  private void Init()
  {
    UCOMIConnectionPoint ppCP = (UCOMIConnectionPoint) null;
    Guid riid = new Guid(new byte[16 /*0x10*/]
    {
      (byte) 246,
      (byte) 9,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 192 /*0xC0*/,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 70
    });
    this.m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
    this.m_ConnectionPoint = ppCP;
    this.m_aEventSinkHelpers = new ArrayList();
  }

  public virtual void add_Close([In] DocumentEvents_CloseEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      DocumentEvents_SinkHelper pUnkSink = new DocumentEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_CloseDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_Close([In] DocumentEvents_CloseEventHandler obj0)
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
        DocumentEvents_SinkHelper aEventSinkHelper = (DocumentEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_CloseDelegate != null && ((aEventSinkHelper.m_CloseDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_Open([In] DocumentEvents_OpenEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      DocumentEvents_SinkHelper pUnkSink = new DocumentEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_OpenDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_Open([In] DocumentEvents_OpenEventHandler obj0)
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
        DocumentEvents_SinkHelper aEventSinkHelper = (DocumentEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_OpenDelegate != null && ((aEventSinkHelper.m_OpenDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public virtual void add_New([In] DocumentEvents_NewEventHandler obj0)
  {
    Monitor.Enter((object) this);
    try
    {
      if (this.m_ConnectionPoint == null)
        this.Init();
      DocumentEvents_SinkHelper pUnkSink = new DocumentEvents_SinkHelper();
      int pdwCookie = 0;
      this.m_ConnectionPoint.Advise((object) pUnkSink, out pdwCookie);
      pUnkSink.m_dwCookie = pdwCookie;
      pUnkSink.m_NewDelegate = obj0;
      this.m_aEventSinkHelpers.Add((object) pUnkSink);
    }
    finally
    {
      Monitor.Exit((object) this);
    }
  }

  public virtual void remove_New([In] DocumentEvents_NewEventHandler obj0)
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
        DocumentEvents_SinkHelper aEventSinkHelper = (DocumentEvents_SinkHelper) this.m_aEventSinkHelpers[index];
        if (aEventSinkHelper.m_NewDelegate != null && ((aEventSinkHelper.m_NewDelegate.Equals((object) obj0) ? 1 : 0) & (int) byte.MaxValue) != 0)
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

  public DocumentEvents_EventProvider([In] object obj0)
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
          this.m_ConnectionPoint.Unadvise(((DocumentEvents_SinkHelper) this.m_aEventSinkHelpers[index]).m_dwCookie);
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
