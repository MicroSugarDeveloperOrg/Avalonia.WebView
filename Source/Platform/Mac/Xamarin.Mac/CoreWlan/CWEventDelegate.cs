using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

[Protocol]
[Register("CWEventDelegate", false)]
[Model]
public class CWEventDelegate : NSObject, ICWEventDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CWEventDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CWEventDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CWEventDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("bssidDidChangeForWiFiInterfaceWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BssidDidChangeForWiFi(string interfaceName)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("clientConnectionInterrupted")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClientConnectionInterrupted()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("clientConnectionInvalidated")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClientConnectionInvalidated()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("countryCodeDidChangeForWiFiInterfaceWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CountryCodeDidChangeForWiFi(string interfaceName)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("linkDidChangeForWiFiInterfaceWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LinkDidChangeForWiFi(string interfaceName)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("linkQualityDidChangeForWiFiInterfaceWithName:rssi:transmitRate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LinkQualityDidChangeForWiFi(string interfaceName, int rssi, double transmitRate)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("modeDidChangeForWiFiInterfaceWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ModeDidChangeForWiFi(string interfaceName)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("powerStateDidChangeForWiFiInterfaceWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PowerStateDidChangeForWiFi(string interfaceName)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scanCacheUpdatedForWiFiInterfaceWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScanCacheUpdatedForWiFi(string interfaceName)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("ssidDidChangeForWiFiInterfaceWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SsidDidChangeForWiFi(string interfaceName)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
