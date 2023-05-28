using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSUrlSessionDownloadDelegateWrapper : BaseWrapper, INSUrlSessionDownloadDelegate, INativeObject, IDisposable, INSUrlSessionTaskDelegate, INSUrlSessionDelegate
{
	[Preserve(Conditional = true)]
	public NSUrlSessionDownloadDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("URLSession:downloadTask:didFinishDownloadingToURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidFinishDownloading(NSUrlSession session, NSUrlSessionDownloadTask downloadTask, NSUrl location)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (downloadTask == null)
		{
			throw new ArgumentNullException("downloadTask");
		}
		if (location == null)
		{
			throw new ArgumentNullException("location");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("URLSession:downloadTask:didFinishDownloadingToURL:"), session.Handle, downloadTask.Handle, location.Handle);
	}
}
