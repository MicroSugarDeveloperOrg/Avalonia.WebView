using System;
using System.ComponentModel;
using Foundation;
using ImageCaptureCore;
using ObjCRuntime;

namespace ImageKit;

[Protocol]
[Register("IKScannerDeviceViewDelegate", false)]
[Model]
public class IKScannerDeviceViewDelegate : NSObject, IIKScannerDeviceViewDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKScannerDeviceViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected IKScannerDeviceViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKScannerDeviceViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("scannerDeviceView:didEncounterError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEncounterError(IKScannerDeviceView scannerDeviceView, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scannerDeviceView:didScanToURL:fileData:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidScan(IKScannerDeviceView scannerDeviceView, NSUrl url, NSData data, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scannerDeviceView:didScanToBandData:scanInfo:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidScanToBandData(IKScannerDeviceView scannerDeviceView, ICScannerBandData data, NSDictionary scanInfo, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scannerDeviceView:didScanToURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidScanToUrl(IKScannerDeviceView scannerDeviceView, NSUrl url, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
