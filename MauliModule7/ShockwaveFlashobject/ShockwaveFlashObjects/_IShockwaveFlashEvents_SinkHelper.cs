// Decompiled with JetBrains decompiler
// Type: ShockwaveFlashObjects._IShockwaveFlashEvents_SinkHelper
// Assembly: ShockwaveFlashObjects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 074923B7-35CE-44D7-AC6B-153DD1515B7D
// Assembly location: C:\WINDOWS\assembly\GAC\ShockwaveFlashObjects\1.0.0.0__692fbea5521e1304\ShockwaveFlashObjects.dll

using System.Runtime.InteropServices;

#nullable disable
namespace ShockwaveFlashObjects;

[ClassInterface(ClassInterfaceType.None)]
public sealed class _IShockwaveFlashEvents_SinkHelper : _IShockwaveFlashEvents
{
  public _IShockwaveFlashEvents_FlashCallEventHandler m_FlashCallDelegate;
  public _IShockwaveFlashEvents_FSCommandEventHandler m_FSCommandDelegate;
  public _IShockwaveFlashEvents_OnProgressEventHandler m_OnProgressDelegate;
  public _IShockwaveFlashEvents_OnReadyStateChangeEventHandler m_OnReadyStateChangeDelegate;
  public int m_dwCookie;

  public virtual void FlashCall([In] string obj0)
  {
    if (this.m_FlashCallDelegate == null)
      return;
    this.m_FlashCallDelegate(obj0);
  }

  public virtual void FSCommand([In] string obj0, [In] string obj1)
  {
    if (this.m_FSCommandDelegate == null)
      return;
    this.m_FSCommandDelegate(obj0, obj1);
  }

  public virtual void OnProgress([In] int obj0)
  {
    if (this.m_OnProgressDelegate == null)
      return;
    this.m_OnProgressDelegate(obj0);
  }

  public virtual void OnReadyStateChange([In] int obj0)
  {
    if (this.m_OnReadyStateChangeDelegate == null)
      return;
    this.m_OnReadyStateChangeDelegate(obj0);
  }

  internal _IShockwaveFlashEvents_SinkHelper()
  {
    this.m_dwCookie = 0;
    this.m_FlashCallDelegate = (_IShockwaveFlashEvents_FlashCallEventHandler) null;
    this.m_FSCommandDelegate = (_IShockwaveFlashEvents_FSCommandEventHandler) null;
    this.m_OnProgressDelegate = (_IShockwaveFlashEvents_OnProgressEventHandler) null;
    this.m_OnReadyStateChangeDelegate = (_IShockwaveFlashEvents_OnReadyStateChangeEventHandler) null;
  }
}
