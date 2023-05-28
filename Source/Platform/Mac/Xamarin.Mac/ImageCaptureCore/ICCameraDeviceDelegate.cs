using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Protocol]
[Register("Xamarin_Mac__ImageCaptureCore_ICCameraDeviceDelegate", false)]
[Model]
public abstract class ICCameraDeviceDelegate : NSObject, IICCameraDeviceDelegate, INativeObject, IDisposable, IICDeviceDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected ICCameraDeviceDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICCameraDeviceDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICCameraDeviceDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("cameraDevice:didAddItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidAddItem(ICCameraDevice camera, ICCameraItem item);

	[Export("cameraDevice:didAddItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidAddItems(ICCameraDevice camera, ICCameraItem[] items)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("deviceDidBecomeReady:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidBecomeReady(ICDevice device)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("deviceDidBecomeReadyWithCompleteContentCatalog:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidBecomeReadyWithCompleteContentCatalog(ICDevice device);

	[Export("cameraDeviceDidChangeCapability:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidChangeCapability(ICCameraDevice camera);

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

	[Export("cameraDevice:didCompleteDeleteFilesWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidCompleteDeleteFiles(ICCameraDevice scanner, NSError? error);

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

	[Export("cameraDevice:didReceiveMetadataForItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidReceiveMetadata(ICCameraDevice camera, ICCameraItem forItem);

	[Export("cameraDevice:didReceivePTPEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidReceivePtpEvent(ICCameraDevice camera, NSData eventData);

	[Export("device:didReceiveStatusInformation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveStatusInformation(ICDevice device, NSDictionary<NSString, NSObject> status)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("cameraDevice:didReceiveThumbnailForItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidReceiveThumbnail(ICCameraDevice camera, ICCameraItem forItem);

	[Export("didRemoveDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRemoveDevice(ICDevice device)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("cameraDevice:didRemoveItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidRemoveItem(ICCameraDevice camera, ICCameraItem item);

	[Export("cameraDevice:didRemoveItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidRemoveItems(ICCameraDevice camera, ICCameraItem[] items)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("cameraDevice:didRenameItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidRenameItems(ICCameraDevice camera, ICCameraItem[] items);

	[Export("cameraDevice:shouldGetMetadataOfItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldGetMetadata(ICCameraDevice cameraDevice, ICCameraItem ofItem)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("cameraDevice:shouldGetThumbnailOfItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldGetThumbnail(ICCameraDevice cameraDevice, ICCameraItem ofItem)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
