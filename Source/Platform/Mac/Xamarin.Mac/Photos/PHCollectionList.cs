using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHCollectionList", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class PHCollectionList : PHCollection
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollectionListSubtype = "collectionListSubtype";

	private static readonly IntPtr selCollectionListSubtypeHandle = Selector.GetHandle("collectionListSubtype");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollectionListType = "collectionListType";

	private static readonly IntPtr selCollectionListTypeHandle = Selector.GetHandle("collectionListType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndDate = "endDate";

	private static readonly IntPtr selEndDateHandle = Selector.GetHandle("endDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchCollectionListsContainingCollection_Options_ = "fetchCollectionListsContainingCollection:options:";

	private static readonly IntPtr selFetchCollectionListsContainingCollection_Options_Handle = Selector.GetHandle("fetchCollectionListsContainingCollection:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchCollectionListsWithLocalIdentifiers_Options_ = "fetchCollectionListsWithLocalIdentifiers:options:";

	private static readonly IntPtr selFetchCollectionListsWithLocalIdentifiers_Options_Handle = Selector.GetHandle("fetchCollectionListsWithLocalIdentifiers:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchCollectionListsWithType_Subtype_Options_ = "fetchCollectionListsWithType:subtype:options:";

	private static readonly IntPtr selFetchCollectionListsWithType_Subtype_Options_Handle = Selector.GetHandle("fetchCollectionListsWithType:subtype:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedLocationNames = "localizedLocationNames";

	private static readonly IntPtr selLocalizedLocationNamesHandle = Selector.GetHandle("localizedLocationNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartDate = "startDate";

	private static readonly IntPtr selStartDateHandle = Selector.GetHandle("startDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransientCollectionListWithCollections_Title_ = "transientCollectionListWithCollections:title:";

	private static readonly IntPtr selTransientCollectionListWithCollections_Title_Handle = Selector.GetHandle("transientCollectionListWithCollections:title:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransientCollectionListWithCollectionsFetchResult_Title_ = "transientCollectionListWithCollectionsFetchResult:title:";

	private static readonly IntPtr selTransientCollectionListWithCollectionsFetchResult_Title_Handle = Selector.GetHandle("transientCollectionListWithCollectionsFetchResult:title:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHCollectionList");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHCollectionListSubtype CollectionListSubtype
	{
		[Export("collectionListSubtype")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHCollectionListSubtype)Messaging.Int64_objc_msgSend(base.Handle, selCollectionListSubtypeHandle);
			}
			return (PHCollectionListSubtype)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCollectionListSubtypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHCollectionListType CollectionListType
	{
		[Export("collectionListType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHCollectionListType)Messaging.Int64_objc_msgSend(base.Handle, selCollectionListTypeHandle);
			}
			return (PHCollectionListType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCollectionListTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate EndDate
	{
		[Export("endDate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selEndDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEndDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] LocalizedLocationNames
	{
		[Export("localizedLocationNames", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedLocationNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedLocationNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate StartDate
	{
		[Export("startDate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selStartDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStartDateHandle));
		}
	}

	[Obsolete("Compatibility stub - This was marked as unavailable on macOS with Xcode 11.")]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	public static PHFetchResult FetchMomentLists(PHCollectionListSubtype subType, PHFetchOptions options)
	{
		return null;
	}

	[Obsolete("Compatibility stub - This was marked as unavailable on macOS with Xcode 11.")]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	public static PHFetchResult FetchMomentLists(PHCollectionListSubtype subType, PHAssetCollection moment, PHFetchOptions options)
	{
		return null;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PHCollectionList()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHCollectionList(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHCollectionList(IntPtr handle)
		: base(handle)
	{
	}

	[Export("transientCollectionListWithCollections:title:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHCollectionList CreateTransientCollectionList(PHAssetCollection[] collections, string title)
	{
		if (collections == null)
		{
			throw new ArgumentNullException("collections");
		}
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		NSArray nSArray = NSArray.FromNSObjects(collections);
		IntPtr arg = NSString.CreateNative(title);
		PHCollectionList nSObject = Runtime.GetNSObject<PHCollectionList>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTransientCollectionListWithCollections_Title_Handle, nSArray.Handle, arg));
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("transientCollectionListWithCollectionsFetchResult:title:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHCollectionList CreateTransientCollectionList(PHFetchResult fetchResult, string title)
	{
		if (fetchResult == null)
		{
			throw new ArgumentNullException("fetchResult");
		}
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		PHCollectionList nSObject = Runtime.GetNSObject<PHCollectionList>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTransientCollectionListWithCollectionsFetchResult_Title_Handle, fetchResult.Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("fetchCollectionListsContainingCollection:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchCollectionLists(PHCollection collection, PHFetchOptions? options)
	{
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFetchCollectionListsContainingCollection_Options_Handle, collection.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("fetchCollectionListsWithLocalIdentifiers:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchCollectionLists(string[] identifiers, PHFetchOptions? options)
	{
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		PHFetchResult nSObject = Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFetchCollectionListsWithLocalIdentifiers_Options_Handle, nSArray.Handle, options?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("fetchCollectionListsWithType:subtype:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchCollectionLists(PHCollectionListType type, PHCollectionListSubtype subType, PHFetchOptions? options)
	{
		return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_Int64_Int64_IntPtr(class_ptr, selFetchCollectionListsWithType_Subtype_Options_Handle, (long)type, (long)subType, options?.Handle ?? IntPtr.Zero));
	}
}
