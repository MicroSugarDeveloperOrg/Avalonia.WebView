using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Photos;

[Register("PHAssetCollectionChangeRequest", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class PHAssetCollectionChangeRequest : PHChangeRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAssets_ = "addAssets:";

	private static readonly IntPtr selAddAssets_Handle = Selector.GetHandle("addAssets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeRequestForAssetCollection_ = "changeRequestForAssetCollection:";

	private static readonly IntPtr selChangeRequestForAssetCollection_Handle = Selector.GetHandle("changeRequestForAssetCollection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeRequestForAssetCollection_Assets_ = "changeRequestForAssetCollection:assets:";

	private static readonly IntPtr selChangeRequestForAssetCollection_Assets_Handle = Selector.GetHandle("changeRequestForAssetCollection:assets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreationRequestForAssetCollectionWithTitle_ = "creationRequestForAssetCollectionWithTitle:";

	private static readonly IntPtr selCreationRequestForAssetCollectionWithTitle_Handle = Selector.GetHandle("creationRequestForAssetCollectionWithTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteAssetCollections_ = "deleteAssetCollections:";

	private static readonly IntPtr selDeleteAssetCollections_Handle = Selector.GetHandle("deleteAssetCollections:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertAssets_AtIndexes_ = "insertAssets:atIndexes:";

	private static readonly IntPtr selInsertAssets_AtIndexes_Handle = Selector.GetHandle("insertAssets:atIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveAssetsAtIndexes_ToIndex_ = "moveAssetsAtIndexes:toIndex:";

	private static readonly IntPtr selMoveAssetsAtIndexes_ToIndex_Handle = Selector.GetHandle("moveAssetsAtIndexes:toIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaceholderForCreatedAssetCollection = "placeholderForCreatedAssetCollection";

	private static readonly IntPtr selPlaceholderForCreatedAssetCollectionHandle = Selector.GetHandle("placeholderForCreatedAssetCollection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAssets_ = "removeAssets:";

	private static readonly IntPtr selRemoveAssets_Handle = Selector.GetHandle("removeAssets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAssetsAtIndexes_ = "removeAssetsAtIndexes:";

	private static readonly IntPtr selRemoveAssetsAtIndexes_Handle = Selector.GetHandle("removeAssetsAtIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceAssetsAtIndexes_WithAssets_ = "replaceAssetsAtIndexes:withAssets:";

	private static readonly IntPtr selReplaceAssetsAtIndexes_WithAssets_Handle = Selector.GetHandle("replaceAssetsAtIndexes:withAssets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHAssetCollectionChangeRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHObjectPlaceholder PlaceholderForCreatedAssetCollection
	{
		[Export("placeholderForCreatedAssetCollection", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PHObjectPlaceholder>(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaceholderForCreatedAssetCollectionHandle));
			}
			return Runtime.GetNSObject<PHObjectPlaceholder>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaceholderForCreatedAssetCollectionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHAssetCollectionChangeRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHAssetCollectionChangeRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addAssets:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAssets(PHObject[] assets)
	{
		if (assets == null)
		{
			throw new ArgumentNullException("assets");
		}
		NSArray nSArray = NSArray.FromNSObjects(assets);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddAssets_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddAssets_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("changeRequestForAssetCollection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAssetCollectionChangeRequest ChangeRequest(PHAssetCollection assetCollection)
	{
		if (assetCollection == null)
		{
			throw new ArgumentNullException("assetCollection");
		}
		return Runtime.GetNSObject<PHAssetCollectionChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selChangeRequestForAssetCollection_Handle, assetCollection.Handle));
	}

	[Export("changeRequestForAssetCollection:assets:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAssetCollectionChangeRequest ChangeRequest(PHAssetCollection assetCollection, PHFetchResult assets)
	{
		if (assetCollection == null)
		{
			throw new ArgumentNullException("assetCollection");
		}
		if (assets == null)
		{
			throw new ArgumentNullException("assets");
		}
		return Runtime.GetNSObject<PHAssetCollectionChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selChangeRequestForAssetCollection_Assets_Handle, assetCollection.Handle, assets.Handle));
	}

	[Export("creationRequestForAssetCollectionWithTitle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAssetCollectionChangeRequest CreateAssetCollection(string title)
	{
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		PHAssetCollectionChangeRequest nSObject = Runtime.GetNSObject<PHAssetCollectionChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCreationRequestForAssetCollectionWithTitle_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("deleteAssetCollections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteAssetCollections(PHAssetCollection[] assetCollections)
	{
		if (assetCollections == null)
		{
			throw new ArgumentNullException("assetCollections");
		}
		NSArray nSArray = NSArray.FromNSObjects(assetCollections);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selDeleteAssetCollections_Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Export("insertAssets:atIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertAssets(PHObject[] assets, NSIndexSet indexes)
	{
		if (assets == null)
		{
			throw new ArgumentNullException("assets");
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		NSArray nSArray = NSArray.FromNSObjects(assets);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertAssets_AtIndexes_Handle, nSArray.Handle, indexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertAssets_AtIndexes_Handle, nSArray.Handle, indexes.Handle);
		}
		nSArray.Dispose();
	}

	[Export("moveAssetsAtIndexes:toIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveAssets(NSIndexSet fromIndexes, nuint toIndex)
	{
		if (fromIndexes == null)
		{
			throw new ArgumentNullException("fromIndexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selMoveAssetsAtIndexes_ToIndex_Handle, fromIndexes.Handle, toIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selMoveAssetsAtIndexes_ToIndex_Handle, fromIndexes.Handle, toIndex);
		}
	}

	[Export("removeAssets:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAssets(PHObject[] assets)
	{
		if (assets == null)
		{
			throw new ArgumentNullException("assets");
		}
		NSArray nSArray = NSArray.FromNSObjects(assets);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAssets_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAssets_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeAssetsAtIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAssets(NSIndexSet indexes)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAssetsAtIndexes_Handle, indexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAssetsAtIndexes_Handle, indexes.Handle);
		}
	}

	[Export("replaceAssetsAtIndexes:withAssets:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceAssets(NSIndexSet indexes, PHObject[] assets)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (assets == null)
		{
			throw new ArgumentNullException("assets");
		}
		NSArray nSArray = NSArray.FromNSObjects(assets);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceAssetsAtIndexes_WithAssets_Handle, indexes.Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReplaceAssetsAtIndexes_WithAssets_Handle, indexes.Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}
}
