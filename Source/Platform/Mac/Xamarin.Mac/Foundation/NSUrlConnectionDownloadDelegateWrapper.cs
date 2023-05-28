using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSUrlConnectionDownloadDelegateWrapper : BaseWrapper, INSUrlConnectionDownloadDelegate, INativeObject, IDisposable, INSUrlConnectionDelegate
{
	[Preserve(Conditional = true)]
	public NSUrlConnectionDownloadDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("connectionDidFinishDownloading:destinationURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FinishedDownloading(NSUrlConnection connection, NSUrl destinationUrl)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (destinationUrl == null)
		{
			throw new ArgumentNullException("destinationUrl");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("connectionDidFinishDownloading:destinationURL:"), connection.Handle, destinationUrl.Handle);
	}
}
