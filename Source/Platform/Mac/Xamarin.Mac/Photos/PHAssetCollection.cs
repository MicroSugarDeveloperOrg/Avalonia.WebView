using System.ComponentModel;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Photos;

[Register("PHAssetCollection", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class PHAssetCollection : PHCollection
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApproximateLocation = "approximateLocation";

	private static readonly IntPtr selApproximateLocationHandle = Selector.GetHandle("approximateLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetCollectionSubtype = "assetCollectionSubtype";

	private static readonly IntPtr selAssetCollectionSubtypeHandle = Selector.GetHandle("assetCollectionSubtype");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetCollectionType = "assetCollectionType";

	private static readonly IntPtr selAssetCollectionTypeHandle = Selector.GetHandle("assetCollectionType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndDate = "endDate";

	private static readonly IntPtr selEndDateHandle = Selector.GetHandle("endDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEstimatedAssetCount = "estimatedAssetCount";

	private static readonly IntPtr selEstimatedAssetCountHandle = Selector.GetHandle("estimatedAssetCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAssetCollectionsContainingAsset_WithType_Options_ = "fetchAssetCollectionsContainingAsset:withType:options:";

	private static readonly IntPtr selFetchAssetCollectionsContainingAsset_WithType_Options_Handle = Selector.GetHandle("fetchAssetCollectionsContainingAsset:withType:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAssetCollectionsWithALAssetGroupURLs_Options_ = "fetchAssetCollectionsWithALAssetGroupURLs:options:";

	private static readonly IntPtr selFetchAssetCollectionsWithALAssetGroupURLs_Options_Handle = Selector.GetHandle("fetchAssetCollectionsWithALAssetGroupURLs:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAssetCollectionsWithLocalIdentifiers_Options_ = "fetchAssetCollectionsWithLocalIdentifiers:options:";

	private static readonly IntPtr selFetchAssetCollectionsWithLocalIdentifiers_Options_Handle = Selector.GetHandle("fetchAssetCollectionsWithLocalIdentifiers:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAssetCollectionsWithType_Subtype_Options_ = "fetchAssetCollectionsWithType:subtype:options:";

	private static readonly IntPtr selFetchAssetCollectionsWithType_Subtype_Options_Handle = Selector.GetHandle("fetchAssetCollectionsWithType:subtype:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedLocationNames = "localizedLocationNames";

	private static readonly IntPtr selLocalizedLocationNamesHandle = Selector.GetHandle("localizedLocationNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartDate = "startDate";

	private static readonly IntPtr selStartDateHandle = Selector.GetHandle("startDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransientAssetCollectionWithAssetFetchResult_Title_ = "transientAssetCollectionWithAssetFetchResult:title:";

	private static readonly IntPtr selTransientAssetCollectionWithAssetFetchResult_Title_Handle = Selector.GetHandle("transientAssetCollectionWithAssetFetchResult:title:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransientAssetCollectionWithAssets_Title_ = "transientAssetCollectionWithAssets:title:";

	private static readonly IntPtr selTransientAssetCollectionWithAssets_Title_Handle = Selector.GetHandle("transientAssetCollectionWithAssets:title:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHAssetCollection");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CLLocation ApproximateLocation
	{
		[Export("approximateLocation", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CLLocation>(Messaging.IntPtr_objc_msgSend(base.Handle, selApproximateLocationHandle));
			}
			return Runtime.GetNSObject<CLLocation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selApproximateLocationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHAssetCollectionSubtype AssetCollectionSubtype
	{
		[Export("assetCollectionSubtype")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHAssetCollectionSubtype)Messaging.Int64_objc_msgSend(base.Handle, selAssetCollectionSubtypeHandle);
			}
			return (PHAssetCollectionSubtype)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAssetCollectionSubtypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHAssetCollectionType AssetCollectionType
	{
		[Export("assetCollectionType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHAssetCollectionType)Messaging.Int64_objc_msgSend(base.Handle, selAssetCollectionTypeHandle);
			}
			return (PHAssetCollectionType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAssetCollectionTypeHandle);
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
	public virtual nuint EstimatedAssetCount
	{
		[Export("estimatedAssetCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selEstimatedAssetCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selEstimatedAssetCountHandle);
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
	public static PHFetchResult FetchMoments(PHFetchOptions options)
	{
		return null;
	}

	[Obsolete("Compatibility stub - This was marked as unavailable on macOS with Xcode 11.")]
	[Unavailable(PlatformName.MacOSX, PlatformArchitecture.All, null)]
	public static PHFetchResult FetchMoments(PHCollectionList momentList, PHFetchOptions options)
	{
		return null;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PHAssetCollection()
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
	protected PHAssetCollection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHAssetCollection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("fetchAssetCollectionsWithLocalIdentifiers:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchAssetCollections(string[] identifiers, PHFetchOptions? options)
	{
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		PHFetchResult nSObject = Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFetchAssetCollectionsWithLocalIdentifiers_Options_Handle, nSArray.Handle, options?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("fetchAssetCollectionsWithType:subtype:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchAssetCollections(PHAssetCollectionType type, PHAssetCollectionSubtype subtype, PHFetchOptions? options)
	{
		return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_Int64_Int64_IntPtr(class_ptr, selFetchAssetCollectionsWithType_Subtype_Options_Handle, (long)type, (long)subtype, options?.Handle ?? IntPtr.Zero));
	}

	[Export("fetchAssetCollectionsContainingAsset:withType:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchAssetCollections(PHAsset asset, PHAssetCollectionType type, PHFetchOptions? options)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_IntPtr_Int64_IntPtr(class_ptr, selFetchAssetCollectionsContainingAsset_WithType_Options_Handle, asset.Handle, (long)type, options?.Handle ?? IntPtr.Zero));
	}

	[Export("fetchAssetCollectionsWithALAssetGroupURLs:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchAssetCollections(NSUrl[] assetGroupUrls, PHFetchOptions? options)
	{
		if (assetGroupUrls == null)
		{
			throw new ArgumentNullException("assetGroupUrls");
		}
		NSArray nSArray = NSArray.FromNSObjects(assetGroupUrls);
		PHFetchResult nSObject = Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFetchAssetCollectionsWithALAssetGroupURLs_Options_Handle, nSArray.Handle, options?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("transientAssetCollectionWithAssets:title:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAssetCollection GetTransientAssetCollection(PHAsset[] assets, string title)
	{
		if (assets == null)
		{
			throw new ArgumentNullException("assets");
		}
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		NSArray nSArray = NSArray.FromNSObjects(assets);
		IntPtr arg = NSString.CreateNative(title);
		PHAssetCollection nSObject = Runtime.GetNSObject<PHAssetCollection>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTransientAssetCollectionWithAssets_Title_Handle, nSArray.Handle, arg));
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("transientAssetCollectionWithAssetFetchResult:title:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAssetCollection GetTransientAssetCollection(PHFetchResult fetchResult, string title)
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
		PHAssetCollection nSObject = Runtime.GetNSObject<PHAssetCollection>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTransientAssetCollectionWithAssetFetchResult_Title_Handle, fetchResult.Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
