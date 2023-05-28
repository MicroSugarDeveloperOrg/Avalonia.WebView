using System;
using System.ComponentModel;
using Foundation;
using ImageCaptureCore;
using ObjCRuntime;

namespace ImageKit;

[Protocol]
[Register("IKCameraDeviceViewDelegate", false)]
[Model]
public class IKCameraDeviceViewDelegate : NSObject, IIKCameraDeviceViewDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKCameraDeviceViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected IKCameraDeviceViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKCameraDeviceViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("cameraDeviceView:didDownloadFile:location:fileData:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidDownloadFile(IKCameraDeviceView cameraDeviceView, ICCameraFile file, NSUrl url, NSData data, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("cameraDeviceView:didEncounterError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEncounterError(IKCameraDeviceView cameraDeviceView, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("cameraDeviceViewSelectionDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectionDidChange(IKCameraDeviceView cameraDeviceView)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
