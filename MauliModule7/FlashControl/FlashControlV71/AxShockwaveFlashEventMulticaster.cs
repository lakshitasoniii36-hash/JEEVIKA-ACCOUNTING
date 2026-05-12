// Decompiled with JetBrains decompiler
// Type: FlashControlV71.AxShockwaveFlashEventMulticaster
// Assembly: FlashControlV71, Version=1.0.3187.32366, Culture=neutral, PublicKeyToken=692fbea5521e1304
// MVID: 040B5991-52B3-42C2-AAE4-00B537F75ED6
// Assembly location: C:\WINDOWS\assembly\GAC\FlashControlV71\1.0.3187.32366__692fbea5521e1304\FlashControlV71.dll

using ShockwaveFlashObjects;

#nullable disable
namespace FlashControlV71;

public class AxShockwaveFlashEventMulticaster : _IShockwaveFlashEvents
{
  private AxShockwaveFlash parent;

  public AxShockwaveFlashEventMulticaster(AxShockwaveFlash parent) => this.parent = parent;

  public virtual void FlashCall(string request)
  {
    this.parent.RaiseOnFlashCall((object) this.parent, new _IShockwaveFlashEvents_FlashCallEvent(request));
  }

  public virtual void FSCommand(string command, string args)
  {
    this.parent.RaiseOnFSCommand((object) this.parent, new _IShockwaveFlashEvents_FSCommandEvent(command, args));
  }

  public virtual void OnProgress(int percentDone)
  {
    this.parent.RaiseOnOnProgress((object) this.parent, new _IShockwaveFlashEvents_OnProgressEvent(percentDone));
  }

  public virtual void OnReadyStateChange(int newState)
  {
    this.parent.RaiseOnOnReadyStateChange((object) this.parent, new _IShockwaveFlashEvents_OnReadyStateChangeEvent(newState));
  }
}
