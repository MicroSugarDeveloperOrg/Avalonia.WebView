using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSUrlConnectionDownloadDelegate", true)]
[Model]
public abstract class NSUrlConnectionDownloadDelegate : NSUrlConnectionDelegate
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUrlConnectionDownloadDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUrlConnectionDownloadDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlConnectionDownloadDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlConnectionDownloadDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("connection:didWriteData:totalBytesWritten:expectedTotalBytes:")]
	public virtual void WroteData(NSUrlConnection connection, long bytesWritten, long totalBytesWritten, long expectedTotalBytes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connectionDidResumeDownloading:totalBytesWritten:expectedTotalBytes:")]
	public virtual void ResumedDownloading(NSUrlConnection connection, long totalBytesWritten, long expectedTotalBytes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("connectionDidFinishDownloading:destinationURL:")]
	public abstract void FinishedDownloading(NSUrlConnection connection, NSUrl destinationUrl);
}
