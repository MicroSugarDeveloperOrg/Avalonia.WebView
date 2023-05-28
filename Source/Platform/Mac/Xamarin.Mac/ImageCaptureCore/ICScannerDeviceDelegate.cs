using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Protocol]
[Register("Xamarin_Mac__ImageCaptureCore_ICScannerDeviceDelegate", false)]
[Model]
public class ICScannerDeviceDelegate : NSObject, IICScannerDeviceDelegate, INativeObject, IDisposable, IICDeviceDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ICScannerDeviceDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICScannerDeviceDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICScannerDeviceDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("scannerDeviceDidBecomeAvailable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidBecomeAvailable(ICScannerDevice scanner)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("deviceDidBecomeReady:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidBecomeReady(ICDevice device)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("deviceDidChangeName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeName(ICDevice device)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("deviceDidChangeSharingState:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeSharingState(ICDevice device)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("device:didCloseSessionWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCloseSession(ICDevice device, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scannerDevice:didCompleteOverviewScanWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCompleteOverviewScan(ICScannerDevice scanner, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scannerDevice:didCompleteScanWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCompleteScan(ICScannerDevice scanner, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("device:didEncounterError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEncounterError(ICDevice device, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("device:didOpenSessionWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidOpenSession(ICDevice device, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("device:didReceiveButtonPress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveButtonPress(ICDevice device, NSString buttonType)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("device:didReceiveCustomNotification:data:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveCustomNotification(ICDevice device, NSDictionary<NSString, NSObject> notification, NSData data)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("device:didReceiveStatusInformation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveStatusInformation(ICDevice device, NSDictionary<NSString, NSObject> status)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("didRemoveDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRemoveDevice(ICDevice device)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scannerDevice:didScanToBandData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidScanToBandData(ICScannerDevice scanner, ICScannerBandData data)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scannerDevice:didScanToURL:data:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidScanToUrl(ICScannerDevice scanner, NSUrl url, NSData data)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scannerDevice:didScanToURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidScanToUrl(ICScannerDevice scanner, NSUrl url)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scannerDevice:didSelectFunctionalUnit:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidSelectFunctionalUnit(ICScannerDevice scanner, ICScannerFunctionalUnit functionalUnit, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
