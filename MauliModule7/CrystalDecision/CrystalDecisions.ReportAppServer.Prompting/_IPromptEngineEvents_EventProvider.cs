// Decompiled with JetBrains decompiler
// Type: CrystalDecisions.ReportAppServer.Prompting._IPromptEngineEvents_EventProvider
// Assembly: CrystalDecisions.ReportAppServer.Prompting, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 50393773-D187-42C3-9A0E-7AAAF93C2C84
// Assembly location: C:\WINDOWS\assembly\GAC_MSIL\CrystalDecisions.ReportAppServer.Prompting\13.0.2000.0__692fbea5521e1304\CrystalDecisions.ReportAppServer.Prompting.dll

using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

#nullable disable
namespace CrystalDecisions.ReportAppServer.Prompting;

internal sealed class _IPromptEngineEvents_EventProvider : _IPromptEngineEvents_Event, IDisposable
{
  private IConnectionPointContainer m_ConnectionPointContainer;
  private ArrayList m_aEventSinkHelpers;
  private IConnectionPoint m_ConnectionPoint;

  private void Init()
  {
    IConnectionPoint ppCP = (IConnectionPoint) null;
    Guid riid = new Guid(new byte[16 /*0x10*/]
    {
      (byte) 156,
      (byte) 94,
      (byte) 13,
      (byte) 182,
      (byte) 116,
      (byte) 41,
      (byte) 247,
      (byte) 72,
      (byte) 164,
      (byte) 112 /*0x70*/,
      (byte) 11,
      (byte) 248,
      (byte) 85,
      (byte) 126,
      (byte) 210,
      (byte) 29
    });
    this.m_ConnectionPointContainer.FindConnectionPoint(ref riid, out ppCP);
    this.m_ConnectionPoint = ppCP;
    this.m_aEventSinkHelpers = new ArrayList();
  }

  public _IPromptEngineEvents_EventProvider(object A_1)
  {
    this.m_ConnectionPointContainer = (IConnectionPointContainer) A_1;
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
          this.m_ConnectionPoint.Unadvise(((_IPromptEngineEvents_SinkHelper) this.m_aEventSinkHelpers[index]).m_dwCookie);
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
