using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSURLSessionDownloadDelegate", false)]
[Model]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public abstract class NSUrlSessionDownloadDelegate : NSUrlSessionTaskDelegate, INSUrlSessionDownloadDelegate, INativeObject, IDisposable, INSUrlSessionTaskDelegate, INSUrlSessionDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TaskResumeDataKey;

	[Field("NSURLSessionDownloadTaskResumeData", "Foundation")]
	public static NSString TaskResumeDataKey
	{
		get
		{
			if (_TaskResumeDataKey == null)
			{
				_TaskResumeDataKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLSessionDownloadTaskResumeData");
			}
			return _TaskResumeDataKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSUrlSessionDownloadDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlSessionDownloadDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlSessionDownloadDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("URLSession:downloadTask:didFinishDownloadingToURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void DidFinishDownloading(NSUrlSession session, NSUrlSessionDownloadTask downloadTask, NSUrl location);

	[Export("URLSession:downloadTask:didResumeAtOffset:expectedTotalBytes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidResume(NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long resumeFileOffset, long expectedTotalBytes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("URLSession:downloadTask:didWriteData:totalBytesWritten:totalBytesExpectedToWrite:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidWriteData(NSUrlSession session, NSUrlSessionDownloadTask downloadTask, long bytesWritten, long totalBytesWritten, long totalBytesExpectedToWrite)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
