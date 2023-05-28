using System;
using Foundation;
using ObjCRuntime;

namespace FileProvider;

internal sealed class NSFileProviderEnumerationObserverWrapper : BaseWrapper, INSFileProviderEnumerationObserver, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSFileProviderEnumerationObserverWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("didEnumerateItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidEnumerateItems(INSFileProviderItem[] updatedItems)
	{
		if (updatedItems == null)
		{
			throw new ArgumentNullException("updatedItems");
		}
		NSArray nSArray = NSArray.FromNSObjects(updatedItems);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("didEnumerateItems:"), nSArray.Handle);
		nSArray.Dispose();
	}

	[Export("finishEnumeratingUpToPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FinishEnumerating(NSData? upToPage)
	{
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("finishEnumeratingUpToPage:"), upToPage?.Handle ?? IntPtr.Zero);
	}

	[Export("finishEnumeratingWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FinishEnumerating(NSError error)
	{
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("finishEnumeratingWithError:"), error.Handle);
	}
}
