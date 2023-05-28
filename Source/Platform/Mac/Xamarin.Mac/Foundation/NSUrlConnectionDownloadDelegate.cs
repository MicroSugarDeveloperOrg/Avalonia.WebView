using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSURLConnectionDownloadDelegate", false)]
[Model]
public abstract class NSUrlConnectionDownloadDelegate : NSUrlConnectionDelegate, INSUrlConnectionDownloadDelegate, INativeObject, IDisposable, INSUrlConnectionDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSUrlConnectionDownloadDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlConnectionDownloadDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlConnectionDownloadDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("connectionDidFinishDownloading:destinationURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void FinishedDownloading(NSUrlConnection connection, NSUrl destinationUrl);

	[Export("connectionDidResumeDownloading:totalBytesWritten:expectedTotalBytes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResumedDownloading(NSUrlConnection connection, long totalBytesWritten, long expectedTotalBytes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connection:didWriteData:totalBytesWritten:expectedTotalBytes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WroteData(NSUrlConnection connection, long bytesWritten, long totalBytesWritten, long expectedTotalBytes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
