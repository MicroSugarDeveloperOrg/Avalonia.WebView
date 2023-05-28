using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUrlSessionDownloadDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidWriteData(this INSUrlSessionDownloadDelegate This, NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long bytesWritten, long totalBytesWritten, long totalBytesExpectedToWrite)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (downloadTask == null)
		{
			throw new ArgumentNullException("downloadTask");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64_Int64_Int64(This.Handle, Selector.GetHandle("URLSession:downloadTask:didWriteData:totalBytesWritten:totalBytesExpectedToWrite:"), session.Handle, downloadTask.Handle, bytesWritten, totalBytesWritten, totalBytesExpectedToWrite);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidResume(this INSUrlSessionDownloadDelegate This, NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long resumeFileOffset, long expectedTotalBytes)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (downloadTask == null)
		{
			throw new ArgumentNullException("downloadTask");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64_Int64(This.Handle, Selector.GetHandle("URLSession:downloadTask:didResumeAtOffset:expectedTotalBytes:"), session.Handle, downloadTask.Handle, resumeFileOffset, expectedTotalBytes);
	}
}
