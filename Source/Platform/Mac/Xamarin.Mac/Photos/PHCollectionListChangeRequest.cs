using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Photos;

[Register("PHCollectionListChangeRequest", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class PHCollectionListChangeRequest : PHChangeRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddChildCollections_ = "addChildCollections:";

	private static readonly IntPtr selAddChildCollections_Handle = Selector.GetHandle("addChildCollections:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeRequestForCollectionList_ = "changeRequestForCollectionList:";

	private static readonly IntPtr selChangeRequestForCollectionList_Handle = Selector.GetHandle("changeRequestForCollectionList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeRequestForCollectionList_ChildCollections_ = "changeRequestForCollectionList:childCollections:";

	private static readonly IntPtr selChangeRequestForCollectionList_ChildCollections_Handle = Selector.GetHandle("changeRequestForCollectionList:childCollections:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreationRequestForCollectionListWithTitle_ = "creationRequestForCollectionListWithTitle:";

	private static readonly IntPtr selCreationRequestForCollectionListWithTitle_Handle = Selector.GetHandle("creationRequestForCollectionListWithTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteCollectionLists_ = "deleteCollectionLists:";

	private static readonly IntPtr selDeleteCollectionLists_Handle = Selector.GetHandle("deleteCollectionLists:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertChildCollections_AtIndexes_ = "insertChildCollections:atIndexes:";

	private static readonly IntPtr selInsertChildCollections_AtIndexes_Handle = Selector.GetHandle("insertChildCollections:atIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveChildCollectionsAtIndexes_ToIndex_ = "moveChildCollectionsAtIndexes:toIndex:";

	private static readonly IntPtr selMoveChildCollectionsAtIndexes_ToIndex_Handle = Selector.GetHandle("moveChildCollectionsAtIndexes:toIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaceholderForCreatedCollectionList = "placeholderForCreatedCollectionList";

	private static readonly IntPtr selPlaceholderForCreatedCollectionListHandle = Selector.GetHandle("placeholderForCreatedCollectionList");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveChildCollections_ = "removeChildCollections:";

	private static readonly IntPtr selRemoveChildCollections_Handle = Selector.GetHandle("removeChildCollections:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveChildCollectionsAtIndexes_ = "removeChildCollectionsAtIndexes:";

	private static readonly IntPtr selRemoveChildCollectionsAtIndexes_Handle = Selector.GetHandle("removeChildCollectionsAtIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceChildCollectionsAtIndexes_WithChildCollections_ = "replaceChildCollectionsAtIndexes:withChildCollections:";

	private static readonly IntPtr selReplaceChildCollectionsAtIndexes_WithChildCollections_Handle = Selector.GetHandle("replaceChildCollectionsAtIndexes:withChildCollections:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHCollectionListChangeRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHObjectPlaceholder PlaceholderForCreatedCollectionList
	{
		[Export("placeholderForCreatedCollectionList", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PHObjectPlaceholder>(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaceholderForCreatedCollectionListHandle));
			}
			return Runtime.GetNSObject<PHObjectPlaceholder>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaceholderForCreatedCollectionListHandle));
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
	protected PHCollectionListChangeRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHCollectionListChangeRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addChildCollections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddChildCollections(PHCollection[] collections)
	{
		if (collections == null)
		{
			throw new ArgumentNullException("collections");
		}
		NSArray nSArray = NSArray.FromNSObjects(collections);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddChildCollections_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddChildCollections_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("changeRequestForCollectionList:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHCollectionListChangeRequest ChangeRequest(PHCollectionList collectionList)
	{
		if (collectionList == null)
		{
			throw new ArgumentNullException("collectionList");
		}
		return Runtime.GetNSObject<PHCollectionListChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selChangeRequestForCollectionList_Handle, collectionList.Handle));
	}

	[Export("changeRequestForCollectionList:childCollections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHCollectionListChangeRequest ChangeRequest(PHCollectionList collectionList, PHFetchResult childCollections)
	{
		if (collectionList == null)
		{
			throw new ArgumentNullException("collectionList");
		}
		if (childCollections == null)
		{
			throw new ArgumentNullException("childCollections");
		}
		return Runtime.GetNSObject<PHCollectionListChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selChangeRequestForCollectionList_ChildCollections_Handle, collectionList.Handle, childCollections.Handle));
	}

	[Export("creationRequestForCollectionListWithTitle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHCollectionListChangeRequest CreateAssetCollection(string title)
	{
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		PHCollectionListChangeRequest nSObject = Runtime.GetNSObject<PHCollectionListChangeRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCreationRequestForCollectionListWithTitle_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("deleteCollectionLists:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteCollectionLists(PHCollectionList[] collectionLists)
	{
		if (collectionLists == null)
		{
			throw new ArgumentNullException("collectionLists");
		}
		NSArray nSArray = NSArray.FromNSObjects(collectionLists);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selDeleteCollectionLists_Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Export("insertChildCollections:atIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertChildCollections(PHCollection[] collections, NSIndexSet indexes)
	{
		if (collections == null)
		{
			throw new ArgumentNullException("collections");
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		NSArray nSArray = NSArray.FromNSObjects(collections);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertChildCollections_AtIndexes_Handle, nSArray.Handle, indexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertChildCollections_AtIndexes_Handle, nSArray.Handle, indexes.Handle);
		}
		nSArray.Dispose();
	}

	[Export("moveChildCollectionsAtIndexes:toIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveChildCollections(NSIndexSet indexes, nuint toIndex)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selMoveChildCollectionsAtIndexes_ToIndex_Handle, indexes.Handle, toIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selMoveChildCollectionsAtIndexes_ToIndex_Handle, indexes.Handle, toIndex);
		}
	}

	[Export("removeChildCollections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveChildCollections(PHCollection[] collections)
	{
		if (collections == null)
		{
			throw new ArgumentNullException("collections");
		}
		NSArray nSArray = NSArray.FromNSObjects(collections);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveChildCollections_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveChildCollections_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeChildCollectionsAtIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveChildCollections(NSIndexSet indexes)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveChildCollectionsAtIndexes_Handle, indexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveChildCollectionsAtIndexes_Handle, indexes.Handle);
		}
	}

	[Export("replaceChildCollectionsAtIndexes:withChildCollections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceChildCollection(NSIndexSet indexes, PHCollection[] collections)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (collections == null)
		{
			throw new ArgumentNullException("collections");
		}
		NSArray nSArray = NSArray.FromNSObjects(collections);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceChildCollectionsAtIndexes_WithChildCollections_Handle, indexes.Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReplaceChildCollectionsAtIndexes_WithChildCollections_Handle, indexes.Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}
}
