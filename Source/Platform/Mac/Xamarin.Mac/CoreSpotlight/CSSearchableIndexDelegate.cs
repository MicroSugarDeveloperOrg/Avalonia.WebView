using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreSpotlight;

[Protocol]
[Register("CSSearchableIndexDelegate", false)]
[Model]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public abstract class CSSearchableIndexDelegate : NSObject, ICSSearchableIndexDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected CSSearchableIndexDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CSSearchableIndexDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CSSearchableIndexDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("searchableIndexDidFinishThrottle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishThrottle(CSSearchableIndex searchableIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("searchableIndexDidThrottle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidThrottle(CSSearchableIndex searchableIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("dataForSearchableIndex:itemIdentifier:typeIdentifier:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetData(CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, out NSError outError)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileURLForSearchableIndex:itemIdentifier:typeIdentifier:inPlace:error:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? GetFileUrl(CSSearchableIndex searchableIndex, string itemIdentifier, string typeIdentifier, bool inPlace, out NSError outError)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("searchableIndex:reindexAllSearchableItemsWithAcknowledgementHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void ReindexAllSearchableItems(CSSearchableIndex searchableIndex, [BlockProxy(typeof(Trampolines.NIDAction))] Action acknowledgementHandler);

	[Export("searchableIndex:reindexSearchableItemsWithIdentifiers:acknowledgementHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void ReindexSearchableItems(CSSearchableIndex searchableIndex, string[] identifiers, [BlockProxy(typeof(Trampolines.NIDAction))] Action acknowledgementHandler);
}
