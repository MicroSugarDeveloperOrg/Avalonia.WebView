using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSFilePresenter", false)]
[Model]
public abstract class NSFilePresenter : NSObject, INSFilePresenter, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSOperationQueue PesentedItemOperationQueue
	{
		[Export("presentedItemOperationQueue", ArgumentSemantic.Retain)]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NSSet<NSString> PresentedItemObservedUbiquityAttributes
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("observedPresentedItemUbiquityAttributes", ArgumentSemantic.Retain)]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSUrl PresentedItemURL
	{
		[Export("presentedItemURL", ArgumentSemantic.Retain)]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl PrimaryPresentedItemUrl
	{
		[Export("primaryPresentedItemURL")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSFilePresenter()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSFilePresenter(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFilePresenter(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("accommodatePresentedItemDeletionWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AccommodatePresentedItemDeletion([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("accommodatePresentedSubitemDeletionAtURL:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AccommodatePresentedSubitemDeletion(NSUrl url, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedItemDidChange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedItemChanged()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedItemDidChangeUbiquityAttributes:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedItemChangedUbiquityAttributes(NSSet<NSString> attributes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedItemDidGainVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedItemGainedVersion(NSFileVersion version)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedItemDidLoseVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedItemLostVersion(NSFileVersion version)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedItemDidMoveToURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedItemMoved(NSUrl newURL)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedItemDidResolveConflictVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedItemResolveConflictVersion(NSFileVersion version)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedSubitemDidAppearAtURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedSubitemAppeared(NSUrl atUrl)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedSubitemDidChangeAtURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedSubitemChanged(NSUrl url)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedSubitemAtURL:didGainVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedSubitemGainedVersion(NSUrl url, NSFileVersion version)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedSubitemAtURL:didLoseVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedSubitemLostVersion(NSUrl url, NSFileVersion version)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedSubitemAtURL:didMoveToURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedSubitemMoved(NSUrl oldURL, NSUrl newURL)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedSubitemAtURL:didResolveConflictVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedSubitemResolvedConflictVersion(NSUrl url, NSFileVersion version)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("relinquishPresentedItemToReader:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RelinquishPresentedItemToReader([BlockProxy(typeof(Trampolines.NIDNSFilePresenterReacquirer))] NSFilePresenterReacquirer readerAction)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("relinquishPresentedItemToWriter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RelinquishPresentedItemToWriter([BlockProxy(typeof(Trampolines.NIDNSFilePresenterReacquirer))] NSFilePresenterReacquirer writerAction)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("savePresentedItemChangesWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SavePresentedItemChanges([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
