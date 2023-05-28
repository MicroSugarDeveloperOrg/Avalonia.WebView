using System.ComponentModel;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Photos;

[Register("PHAsset", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class PHAsset : PHObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBurstIdentifier = "burstIdentifier";

	private static readonly IntPtr selBurstIdentifierHandle = Selector.GetHandle("burstIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBurstSelectionTypes = "burstSelectionTypes";

	private static readonly IntPtr selBurstSelectionTypesHandle = Selector.GetHandle("burstSelectionTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPerformEditOperation_ = "canPerformEditOperation:";

	private static readonly IntPtr selCanPerformEditOperation_Handle = Selector.GetHandle("canPerformEditOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreationDate = "creationDate";

	private static readonly IntPtr selCreationDateHandle = Selector.GetHandle("creationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAssetsInAssetCollection_Options_ = "fetchAssetsInAssetCollection:options:";

	private static readonly IntPtr selFetchAssetsInAssetCollection_Options_Handle = Selector.GetHandle("fetchAssetsInAssetCollection:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAssetsWithBurstIdentifier_Options_ = "fetchAssetsWithBurstIdentifier:options:";

	private static readonly IntPtr selFetchAssetsWithBurstIdentifier_Options_Handle = Selector.GetHandle("fetchAssetsWithBurstIdentifier:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAssetsWithLocalIdentifiers_Options_ = "fetchAssetsWithLocalIdentifiers:options:";

	private static readonly IntPtr selFetchAssetsWithLocalIdentifiers_Options_Handle = Selector.GetHandle("fetchAssetsWithLocalIdentifiers:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAssetsWithMediaType_Options_ = "fetchAssetsWithMediaType:options:";

	private static readonly IntPtr selFetchAssetsWithMediaType_Options_Handle = Selector.GetHandle("fetchAssetsWithMediaType:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchAssetsWithOptions_ = "fetchAssetsWithOptions:";

	private static readonly IntPtr selFetchAssetsWithOptions_Handle = Selector.GetHandle("fetchAssetsWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchKeyAssetsInAssetCollection_Options_ = "fetchKeyAssetsInAssetCollection:options:";

	private static readonly IntPtr selFetchKeyAssetsInAssetCollection_Options_Handle = Selector.GetHandle("fetchKeyAssetsInAssetCollection:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFavorite = "isFavorite";

	private static readonly IntPtr selIsFavoriteHandle = Selector.GetHandle("isFavorite");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHidden = "isHidden";

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSyncFailureHidden = "isSyncFailureHidden";

	private static readonly IntPtr selIsSyncFailureHiddenHandle = Selector.GetHandle("isSyncFailureHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocation = "location";

	private static readonly IntPtr selLocationHandle = Selector.GetHandle("location");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSubtypes = "mediaSubtypes";

	private static readonly IntPtr selMediaSubtypesHandle = Selector.GetHandle("mediaSubtypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaType = "mediaType";

	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModificationDate = "modificationDate";

	private static readonly IntPtr selModificationDateHandle = Selector.GetHandle("modificationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelHeight = "pixelHeight";

	private static readonly IntPtr selPixelHeightHandle = Selector.GetHandle("pixelHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelWidth = "pixelWidth";

	private static readonly IntPtr selPixelWidthHandle = Selector.GetHandle("pixelWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaybackStyle = "playbackStyle";

	private static readonly IntPtr selPlaybackStyleHandle = Selector.GetHandle("playbackStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepresentsBurst = "representsBurst";

	private static readonly IntPtr selRepresentsBurstHandle = Selector.GetHandle("representsBurst");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceType = "sourceType";

	private static readonly IntPtr selSourceTypeHandle = Selector.GetHandle("sourceType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHAsset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LocalIdentifierNotFound;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual string BurstIdentifier
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("burstIdentifier", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBurstIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBurstIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual PHAssetBurstSelectionType BurstSelectionTypes
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("burstSelectionTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHAssetBurstSelectionType)Messaging.UInt64_objc_msgSend(base.Handle, selBurstSelectionTypesHandle);
			}
			return (PHAssetBurstSelectionType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBurstSelectionTypesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate CreationDate
	{
		[Export("creationDate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selCreationDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreationDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Favorite
	{
		[Export("isFavorite")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFavoriteHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFavoriteHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Hidden
	{
		[Export("isHidden")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CLLocation Location
	{
		[Export("location", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CLLocation>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocationHandle));
			}
			return Runtime.GetNSObject<CLLocation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHAssetMediaSubtype MediaSubtypes
	{
		[Export("mediaSubtypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHAssetMediaSubtype)Messaging.UInt64_objc_msgSend(base.Handle, selMediaSubtypesHandle);
			}
			return (PHAssetMediaSubtype)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMediaSubtypesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHAssetMediaType MediaType
	{
		[Export("mediaType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHAssetMediaType)Messaging.Int64_objc_msgSend(base.Handle, selMediaTypeHandle);
			}
			return (PHAssetMediaType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate ModificationDate
	{
		[Export("modificationDate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selModificationDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModificationDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint PixelHeight
	{
		[Export("pixelHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPixelHeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPixelHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint PixelWidth
	{
		[Export("pixelWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPixelWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPixelWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual PHAssetPlaybackStyle PlaybackStyle
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("playbackStyle", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHAssetPlaybackStyle)Messaging.Int64_objc_msgSend(base.Handle, selPlaybackStyleHandle);
			}
			return (PHAssetPlaybackStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPlaybackStyleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual bool RepresentsBurst
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("representsBurst")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRepresentsBurstHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRepresentsBurstHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual PHAssetSourceType SourceType
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("sourceType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHAssetSourceType)Messaging.UInt64_objc_msgSend(base.Handle, selSourceTypeHandle);
			}
			return (PHAssetSourceType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSourceTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "No longer supported.")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	public virtual bool SyncFailureHidden
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "No longer supported.")]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Export("isSyncFailureHidden")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSyncFailureHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSyncFailureHiddenHandle);
		}
	}

	[Field("PHLocalIdentifierNotFound", "Photos")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	public static NSString LocalIdentifierNotFound
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		get
		{
			if (_LocalIdentifierNotFound == null)
			{
				_LocalIdentifierNotFound = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHLocalIdentifierNotFound");
			}
			return _LocalIdentifierNotFound;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHAsset(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHAsset(IntPtr handle)
		: base(handle)
	{
	}

	[Export("canPerformEditOperation:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanPerformEditOperation(PHAssetEditOperation editOperation)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selCanPerformEditOperation_Handle, (long)editOperation);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selCanPerformEditOperation_Handle, (long)editOperation);
	}

	[Export("fetchAssetsInAssetCollection:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchAssets(PHAssetCollection assetCollection, PHFetchOptions? options)
	{
		if (assetCollection == null)
		{
			throw new ArgumentNullException("assetCollection");
		}
		return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFetchAssetsInAssetCollection_Options_Handle, assetCollection.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("fetchAssetsWithMediaType:options:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchAssets(PHAssetMediaType mediaType, PHFetchOptions? options)
	{
		return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_Int64_IntPtr(class_ptr, selFetchAssetsWithMediaType_Options_Handle, (long)mediaType, options?.Handle ?? IntPtr.Zero));
	}

	[Export("fetchAssetsWithBurstIdentifier:options:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchAssets(string burstIdentifier, PHFetchOptions? options)
	{
		if (burstIdentifier == null)
		{
			throw new ArgumentNullException("burstIdentifier");
		}
		IntPtr arg = NSString.CreateNative(burstIdentifier);
		PHFetchResult nSObject = Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFetchAssetsWithBurstIdentifier_Options_Handle, arg, options?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("fetchAssetsWithOptions:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchAssets(PHFetchOptions? options)
	{
		return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFetchAssetsWithOptions_Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("fetchAssetsWithLocalIdentifiers:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchAssetsUsingLocalIdentifiers(string[] identifiers, PHFetchOptions? options)
	{
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		PHFetchResult nSObject = Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFetchAssetsWithLocalIdentifiers_Options_Handle, nSArray.Handle, options?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("fetchKeyAssetsInAssetCollection:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResult FetchKeyAssets(PHAssetCollection assetCollection, PHFetchOptions? options)
	{
		if (assetCollection == null)
		{
			throw new ArgumentNullException("assetCollection");
		}
		return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFetchKeyAssetsInAssetCollection_Options_Handle, assetCollection.Handle, options?.Handle ?? IntPtr.Zero));
	}
}
