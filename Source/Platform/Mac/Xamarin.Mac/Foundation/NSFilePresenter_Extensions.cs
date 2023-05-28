using System;
using ObjCRuntime;

namespace Foundation;

public static class NSFilePresenter_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RelinquishPresentedItemToReader(this INSFilePresenter This, [BlockProxy(typeof(Trampolines.NIDNSFilePresenterReacquirer))] NSFilePresenterReacquirer readerAction)
	{
		if (readerAction == null)
		{
			throw new ArgumentNullException("readerAction");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSFilePresenterReacquirer.Handler, readerAction);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("relinquishPresentedItemToReader:"), (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RelinquishPresentedItemToWriter(this INSFilePresenter This, [BlockProxy(typeof(Trampolines.NIDNSFilePresenterReacquirer))] NSFilePresenterReacquirer writerAction)
	{
		if (writerAction == null)
		{
			throw new ArgumentNullException("writerAction");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSFilePresenterReacquirer.Handler, writerAction);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("relinquishPresentedItemToWriter:"), (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void SavePresentedItemChanges(this INSFilePresenter This, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("savePresentedItemChangesWithCompletionHandler:"), (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void AccommodatePresentedItemDeletion(this INSFilePresenter This, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("accommodatePresentedItemDeletionWithCompletionHandler:"), (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentedItemMoved(this INSFilePresenter This, NSUrl newURL)
	{
		if (newURL == null)
		{
			throw new ArgumentNullException("newURL");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("presentedItemDidMoveToURL:"), newURL.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentedItemChanged(this INSFilePresenter This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("presentedItemDidChange"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentedItemGainedVersion(this INSFilePresenter This, NSFileVersion version)
	{
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("presentedItemDidGainVersion:"), version.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentedItemLostVersion(this INSFilePresenter This, NSFileVersion version)
	{
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("presentedItemDidLoseVersion:"), version.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentedItemResolveConflictVersion(this INSFilePresenter This, NSFileVersion version)
	{
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("presentedItemDidResolveConflictVersion:"), version.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void AccommodatePresentedSubitemDeletion(this INSFilePresenter This, NSUrl url, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("accommodatePresentedSubitemDeletionAtURL:completionHandler:"), url.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentedSubitemAppeared(this INSFilePresenter This, NSUrl atUrl)
	{
		if (atUrl == null)
		{
			throw new ArgumentNullException("atUrl");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("presentedSubitemDidAppearAtURL:"), atUrl.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentedSubitemMoved(this INSFilePresenter This, NSUrl oldURL, NSUrl newURL)
	{
		if (oldURL == null)
		{
			throw new ArgumentNullException("oldURL");
		}
		if (newURL == null)
		{
			throw new ArgumentNullException("newURL");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("presentedSubitemAtURL:didMoveToURL:"), oldURL.Handle, newURL.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentedSubitemChanged(this INSFilePresenter This, NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("presentedSubitemDidChangeAtURL:"), url.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentedSubitemGainedVersion(this INSFilePresenter This, NSUrl url, NSFileVersion version)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("presentedSubitemAtURL:didGainVersion:"), url.Handle, version.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentedSubitemLostVersion(this INSFilePresenter This, NSUrl url, NSFileVersion version)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("presentedSubitemAtURL:didLoseVersion:"), url.Handle, version.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentedSubitemResolvedConflictVersion(this INSFilePresenter This, NSUrl url, NSFileVersion version)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("presentedSubitemAtURL:didResolveConflictVersion:"), url.Handle, version.Handle);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentedItemChangedUbiquityAttributes(this INSFilePresenter This, NSSet<NSString> attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("presentedItemDidChangeUbiquityAttributes:"), attributes.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSet<NSString> GetPresentedItemObservedUbiquityAttributes(this INSFilePresenter This)
	{
		return Runtime.GetNSObject<NSSet<NSString>>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("observedPresentedItemUbiquityAttributes")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl GetPrimaryPresentedItemUrl(this INSFilePresenter This)
	{
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("primaryPresentedItemURL")));
	}
}
