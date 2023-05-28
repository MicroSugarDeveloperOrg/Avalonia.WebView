using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUrlConnectionDownloadDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WroteData(this INSUrlConnectionDownloadDelegate This, NSUrlConnection connection, long bytesWritten, long totalBytesWritten, long expectedTotalBytes)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		Messaging.void_objc_msgSend_IntPtr_Int64_Int64_Int64(This.Handle, Selector.GetHandle("connection:didWriteData:totalBytesWritten:expectedTotalBytes:"), connection.Handle, bytesWritten, totalBytesWritten, expectedTotalBytes);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ResumedDownloading(this INSUrlConnectionDownloadDelegate This, NSUrlConnection connection, long totalBytesWritten, long expectedTotalBytes)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		Messaging.void_objc_msgSend_IntPtr_Int64_Int64(This.Handle, Selector.GetHandle("connectionDidResumeDownloading:totalBytesWritten:expectedTotalBytes:"), connection.Handle, totalBytesWritten, expectedTotalBytes);
	}
}
