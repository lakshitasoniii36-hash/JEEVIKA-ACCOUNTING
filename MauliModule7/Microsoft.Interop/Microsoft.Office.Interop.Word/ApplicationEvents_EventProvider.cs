// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.ApplicationEvents_EventProvider
// Assembly: Microsoft.Office.Interop.Word, Version=12.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c
// MVID: 0FCBC247-A161-4F2B-996F-3CF977673F41
// Assembly location: C:\Program Files (x86)\Sam Accounting Services\Module7\Microsoft.Office.Interop.Word.dll

using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;

#nullable disable
namespace Microsoft.Office.Interop.Word;

internal sealed class ApplicationEvents_EventProvider : ApplicationEvents_Event, IDisposable
{
  private UCOMIConnectionPointContainer m_ConnectionPointContainer;
  private ArrayList m_aEventSinkHelpers;
  private UCOMIConnectionPoint m_ConnectionPoint;

  private void Init()
  {
    UCOMIConnectionPoint ppCP = (UCOMIConnectionPoint) null;
    Guid riid = new Guid(new byte[16 /*0x10*/]
    {
      (byte) 247,
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

  public ApplicationEvents_EventProvider([In] object obj0)
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
          this.m_ConnectionPoint.Unadvise(((ApplicationEvents_SinkHelper) this.m_aEventSinkHelpers[index]).m_dwCookie);
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
