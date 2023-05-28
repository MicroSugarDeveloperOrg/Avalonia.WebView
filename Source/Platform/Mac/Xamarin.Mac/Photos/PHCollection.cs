using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHCollection", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class PHCollection : PHObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanContainAssets = "canContainAssets";

	private static readonly IntPtr selCanContainAssetsHandle = Selector.GetHandle("canContainAssets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanContainCollections = "canContainCollections";

	private static readonly IntPtr selCanContainCollectionsHandle = Selector.GetHandle("canContainCollections");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPerformEditOperation_ = "canPerformEditOperation:";

	private static readonly IntPtr selCanPerformEditOperation_Handle = Selector.GetHandle("canPerformEditOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchCollectionsInCollectionList_Options_ = "fetchCollectionsInCollectionList:options:";

	private static readonly IntPtr selFetchCollectionsInCollectionList_Options_Handle = Selector.GetHandle("fetchCollectionsInCollectionList:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchTopLevelUserCollectionsWithOptions_ = "fetchTopLevelUserCollectionsWithOptions:";

	private static readonly IntPtr selFetchTopLevelUserCollectionsWithOptions_Handle = Selector.GetHandle("fetchTopLevelUserCollectionsWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedTitle = "localizedTitle";

	private static readonly IntPtr selLocalizedTitleHandle = Selector.GetHandle("localizedTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHCollection");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanContainAssets
	{
		[Export("canContainAssets")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanContainAssetsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanContainAssetsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanContainCollections
	{
		[Export("canContainCollections")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanContainCollectionsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanContainCollectionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual string LocalizedTitle
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("localizedTitle", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHCollection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHCollection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("canPerformEditOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanPerformEditOperation(PHCollectionEditOperation anOperation)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selCanPerformEditOperation_Handle, (long)anOperation);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selCanPerformEditOperation_Handle, (long)anOperation);
	}

	[Export("fetchCollectionsInCollectionList:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchCollections(PHCollectionList collectionList, PHFetchOptions? options)
	{
		if (collectionList == null)
		{
			throw new ArgumentNullException("collectionList");
		}
		return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFetchCollectionsInCollectionList_Options_Handle, collectionList.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("fetchTopLevelUserCollectionsWithOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchTopLevelUserCollections(PHFetchOptions? options)
	{
		return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFetchTopLevelUserCollectionsWithOptions_Handle, options?.Handle ?? IntPtr.Zero));
	}
}
