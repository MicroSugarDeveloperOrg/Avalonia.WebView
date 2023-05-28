using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Protocol]
[Register("Xamarin_Mac__ImageCaptureCore_ICCameraDeviceDownloadDelegate", false)]
[Model]
public class ICCameraDeviceDownloadDelegate : NSObject, IICCameraDeviceDownloadDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ICCameraDeviceDownloadDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICCameraDeviceDownloadDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICCameraDeviceDownloadDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("didDownloadFile:error:options:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidDownloadFile(ICCameraFile file, NSError? error, NSDictionary<NSString, NSObject>? options, IntPtr contextInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("didReceiveDownloadProgressForFile:downloadedBytes:maxBytes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidReceiveDownloadProgress(ICCameraFile file, long downloadedBytes, long maxBytes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
