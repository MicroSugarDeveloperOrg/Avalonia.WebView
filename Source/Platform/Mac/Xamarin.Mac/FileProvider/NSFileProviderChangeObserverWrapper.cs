using System;
using Foundation;
using ObjCRuntime;

namespace FileProvider;

internal sealed class NSFileProviderChangeObserverWrapper : BaseWrapper, INSFileProviderChangeObserver, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSFileProviderChangeObserverWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("didUpdateItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidUpdateItems(INSFileProviderItem[] updatedItems)
	{
		if (updatedItems == null)
		{
			throw new ArgumentNullException("updatedItems");
		}
		NSArray nSArray = NSArray.FromNSObjects(updatedItems);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("didUpdateItems:"), nSArray.Handle);
		nSArray.Dispose();
	}

	[Export("didDeleteItemsWithIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidDeleteItems(string[] deletedItemIdentifiers)
	{
		if (deletedItemIdentifiers == null)
		{
			throw new ArgumentNullException("deletedItemIdentifiers");
		}
		NSArray nSArray = NSArray.FromStrings(deletedItemIdentifiers);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("didDeleteItemsWithIdentifiers:"), nSArray.Handle);
		nSArray.Dispose();
	}

	[Export("finishEnumeratingChangesUpToSyncAnchor:moreComing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FinishEnumeratingChanges(NSData anchor, bool moreComing)
	{
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, Selector.GetHandle("finishEnumeratingChangesUpToSyncAnchor:moreComing:"), anchor.Handle, moreComing);
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
