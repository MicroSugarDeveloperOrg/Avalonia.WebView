using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSFilePresenter", true)]
[Model]
public abstract class NSFilePresenter : NSObject
{
	public abstract NSUrl PresentedItemURL
	{
		[Export("presentedItemURL")]
		get;
	}

	public virtual NSOperationQueue PesentedItemOperationQueue
	{
		[Export("presentedItemOperationQueue")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFilePresenter()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSFilePresenter(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFilePresenter(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFilePresenter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("presentedItemDidMoveToURL:")]
	public virtual void PresentedItemMoved(NSUrl newURL)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedItemDidChange")]
	public virtual void PresentedItemChanged()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedItemDidGainVersion:")]
	public virtual void PresentedItemGainedVersion(NSFileVersion version)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedItemDidLoseVersion:")]
	public virtual void PresentedItemLostVersion(NSFileVersion version)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedItemDidResolveConflictVersion:")]
	public virtual void PresentedItemResolveConflictVersion(NSFileVersion version)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedSubitemDidAppearAtURL:")]
	public virtual void PresentedSubitemAppeared(NSUrl atUrl)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedSubitemAtURL:didMoveToURL:")]
	public virtual void PresentedSubitemMoved(NSUrl oldURL, NSUrl newURL)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedSubitemDidChangeAtURL:")]
	public virtual void PresentedSubitemChanged(NSUrl url)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedSubitemAtURL:didGainVersion:")]
	public virtual void PresentedSubitemGainedVersion(NSUrl url, NSFileVersion version)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedSubitemAtURL:didLoseVersion:")]
	public virtual void PresentedSubitemLostVersion(NSUrl url, NSFileVersion version)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("presentedSubitemAtURL:didResolveConflictVersion:")]
	public virtual void PresentedSubitemResolvedConflictVersion(NSUrl url, NSFileVersion version)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
