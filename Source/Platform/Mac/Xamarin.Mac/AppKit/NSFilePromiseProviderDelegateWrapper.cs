using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSFilePromiseProviderDelegateWrapper : BaseWrapper, INSFilePromiseProviderDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSFilePromiseProviderDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("filePromiseProvider:fileNameForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string GetFileNameForDestination(NSFilePromiseProvider filePromiseProvider, string fileType)
	{
		NSApplication.EnsureUIThread();
		if (filePromiseProvider == null)
		{
			throw new ArgumentNullException("filePromiseProvider");
		}
		if (fileType == null)
		{
			throw new ArgumentNullException("fileType");
		}
		IntPtr intPtr = NSString.CreateNative(fileType);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("filePromiseProvider:fileNameForType:"), filePromiseProvider.Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return result;
	}
}
