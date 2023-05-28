using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Protocol]
[Register("Xamarin_Mac__ImageCaptureCore_ICDeviceBrowserDelegate", false)]
[Model]
public abstract class ICDeviceBrowserDelegate : NSObject, IICDeviceBrowserDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected ICDeviceBrowserDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICDeviceBrowserDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICDeviceBrowserDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("deviceBrowser:deviceDidChangeName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeviceDidChangeName(ICDeviceBrowser browser, ICDevice device)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("deviceBrowser:deviceDidChangeSharingState:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeviceDidChangeSharingState(ICDeviceBrowser browser, ICDevice device)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("deviceBrowser:didAddDevice:moreComing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidAddDevice(ICDeviceBrowser browser, ICDevice device, bool moreComing);

	[Export("deviceBrowserDidEnumerateLocalDevices:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEnumerateLocalDevices(ICDeviceBrowser browser)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("deviceBrowser:didRemoveDevice:moreGoing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidRemoveDevice(ICDeviceBrowser browser, ICDevice device, bool moreGoing);

	[Export("deviceBrowser:requestsSelectDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestsSelectDevice(ICDeviceBrowser browser, ICDevice device)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
