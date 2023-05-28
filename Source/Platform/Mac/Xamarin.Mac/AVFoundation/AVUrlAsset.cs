using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVURLAsset", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVUrlAsset : AVAsset, IAVContentKeyRecipient, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLAssetWithURL_Options_ = "URLAssetWithURL:options:";

	private static readonly IntPtr selURLAssetWithURL_Options_Handle = Selector.GetHandle("URLAssetWithURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetCache = "assetCache";

	private static readonly IntPtr selAssetCacheHandle = Selector.GetHandle("assetCache");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudiovisualMIMETypes = "audiovisualMIMETypes";

	private static readonly IntPtr selAudiovisualMIMETypesHandle = Selector.GetHandle("audiovisualMIMETypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudiovisualTypes = "audiovisualTypes";

	private static readonly IntPtr selAudiovisualTypesHandle = Selector.GetHandle("audiovisualTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompatibleTrackForCompositionTrack_ = "compatibleTrackForCompositionTrack:";

	private static readonly IntPtr selCompatibleTrackForCompositionTrack_Handle = Selector.GetHandle("compatibleTrackForCompositionTrack:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Options_ = "initWithURL:options:";

	private static readonly IntPtr selInitWithURL_Options_Handle = Selector.GetHandle("initWithURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlayableExtendedMIMEType_ = "isPlayableExtendedMIMEType:";

	private static readonly IntPtr selIsPlayableExtendedMIMEType_Handle = Selector.GetHandle("isPlayableExtendedMIMEType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMayRequireContentKeysForMediaDataProcessing = "mayRequireContentKeysForMediaDataProcessing";

	private static readonly IntPtr selMayRequireContentKeysForMediaDataProcessingHandle = Selector.GetHandle("mayRequireContentKeysForMediaDataProcessing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceLoader = "resourceLoader";

	private static readonly IntPtr selResourceLoaderHandle = Selector.GetHandle("resourceLoader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVURLAsset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowsCellularAccessKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowsConstrainedNetworkAccessKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AllowsExpensiveNetworkAccessKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HttpCookiesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreferPreciseDurationAndTimingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReferenceRestrictionsKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] AudiovisualMimeTypes
	{
		[Export("audiovisualMIMETypes")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selAudiovisualMIMETypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] AudiovisualTypes
	{
		[Export("audiovisualTypes")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selAudiovisualTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVAssetCache? Cache
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("assetCache")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAssetCache>(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetCacheHandle));
			}
			return Runtime.GetNSObject<AVAssetCache>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetCacheHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool MayRequireContentKeysForMediaDataProcessing
	{
		[Export("mayRequireContentKeysForMediaDataProcessing")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMayRequireContentKeysForMediaDataProcessingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMayRequireContentKeysForMediaDataProcessingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVAssetResourceLoader ResourceLoader
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("resourceLoader")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAssetResourceLoader>(Messaging.IntPtr_objc_msgSend(base.Handle, selResourceLoaderHandle));
			}
			return Runtime.GetNSObject<AVAssetResourceLoader>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResourceLoaderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("URL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	[Field("AVURLAssetAllowsCellularAccessKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString AllowsCellularAccessKey
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_AllowsCellularAccessKey == null)
			{
				_AllowsCellularAccessKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVURLAssetAllowsCellularAccessKey");
			}
			return _AllowsCellularAccessKey;
		}
	}

	[Field("AVURLAssetAllowsConstrainedNetworkAccessKey", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString AllowsConstrainedNetworkAccessKey
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AllowsConstrainedNetworkAccessKey == null)
			{
				_AllowsConstrainedNetworkAccessKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVURLAssetAllowsConstrainedNetworkAccessKey");
			}
			return _AllowsConstrainedNetworkAccessKey;
		}
	}

	[Field("AVURLAssetAllowsExpensiveNetworkAccessKey", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static NSString AllowsExpensiveNetworkAccessKey
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_AllowsExpensiveNetworkAccessKey == null)
			{
				_AllowsExpensiveNetworkAccessKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVURLAssetAllowsExpensiveNetworkAccessKey");
			}
			return _AllowsExpensiveNetworkAccessKey;
		}
	}

	[Field("AVURLAssetHTTPCookiesKey", "AVFoundation")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString HttpCookiesKey
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_HttpCookiesKey == null)
			{
				_HttpCookiesKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVURLAssetHTTPCookiesKey");
			}
			return _HttpCookiesKey;
		}
	}

	[Field("AVURLAssetPreferPreciseDurationAndTimingKey", "AVFoundation")]
	public static NSString PreferPreciseDurationAndTimingKey
	{
		get
		{
			if (_PreferPreciseDurationAndTimingKey == null)
			{
				_PreferPreciseDurationAndTimingKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVURLAssetPreferPreciseDurationAndTimingKey");
			}
			return _PreferPreciseDurationAndTimingKey;
		}
	}

	[Field("AVURLAssetReferenceRestrictionsKey", "AVFoundation")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public static NSString ReferenceRestrictionsKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		get
		{
			if (_ReferenceRestrictionsKey == null)
			{
				_ReferenceRestrictionsKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVURLAssetReferenceRestrictionsKey");
			}
			return _ReferenceRestrictionsKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVUrlAsset(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVUrlAsset(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:options:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVUrlAsset(NSUrl url, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithURL_Options_Handle, url.Handle, options?.Handle ?? IntPtr.Zero), "initWithURL:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithURL_Options_Handle, url.Handle, options?.Handle ?? IntPtr.Zero), "initWithURL:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVUrlAsset(NSUrl url, AVUrlAssetOptions? options)
		: this(url, options.GetDictionary())
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVUrlAsset(NSUrl url)
		: this(url, (NSDictionary?)null)
	{
	}

	[Export("compatibleTrackForCompositionTrack:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetTrack? CompatibleTrack(AVCompositionTrack forCompositionTrack)
	{
		if (forCompositionTrack == null)
		{
			throw new ArgumentNullException("forCompositionTrack");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVAssetTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCompatibleTrackForCompositionTrack_Handle, forCompositionTrack.Handle));
		}
		return Runtime.GetNSObject<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompatibleTrackForCompositionTrack_Handle, forCompositionTrack.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVUrlAsset Create(NSUrl url, AVUrlAssetOptions? options)
	{
		return FromUrl(url, options.GetDictionary());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVUrlAsset Create(NSUrl url)
	{
		return FromUrl(url, null);
	}

	[Export("URLAssetWithURL:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use constructor or 'Create' method instead.")]
	internal static AVUrlAsset FromUrl(NSUrl url, NSDictionary? options)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<AVUrlAsset>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selURLAssetWithURL_Options_Handle, url.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("isPlayableExtendedMIMEType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsPlayable(string extendedMimeType)
	{
		if (extendedMimeType == null)
		{
			throw new ArgumentNullException("extendedMimeType");
		}
		IntPtr arg = NSString.CreateNative(extendedMimeType);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selIsPlayableExtendedMIMEType_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}
}
