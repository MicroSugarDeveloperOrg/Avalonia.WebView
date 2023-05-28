using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPNowPlayingInfoCenter", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class MPNowPlayingInfoCenter : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultCenter = "defaultCenter";

	private static readonly IntPtr selDefaultCenterHandle = Selector.GetHandle("defaultCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNowPlayingInfo = "nowPlayingInfo";

	private static readonly IntPtr selNowPlayingInfoHandle = Selector.GetHandle("nowPlayingInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaybackState = "playbackState";

	private static readonly IntPtr selPlaybackStateHandle = Selector.GetHandle("playbackState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNowPlayingInfo_ = "setNowPlayingInfo:";

	private static readonly IntPtr selSetNowPlayingInfo_Handle = Selector.GetHandle("setNowPlayingInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlaybackState_ = "setPlaybackState:";

	private static readonly IntPtr selSetPlaybackState_Handle = Selector.GetHandle("setPlaybackState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPNowPlayingInfoCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyAssetUrl;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyAvailableLanguageOptions;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyChapterCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyChapterNumber;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyCollectionIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyCurrentLanguageOptions;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyCurrentPlaybackDate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyDefaultPlaybackRate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyElapsedPlaybackTime;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyExternalContentIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyExternalUserProfileIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyIsLiveStream;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyMediaType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyPlaybackProgress;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyPlaybackQueueCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyPlaybackQueueIndex;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyPlaybackRate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyServiceIdentifier;

	public MPNowPlayingInfo NowPlaying
	{
		get
		{
			return new MPNowPlayingInfo(_NowPlayingInfo);
		}
		set
		{
			_NowPlayingInfo = value?.ToDictionary();
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPNowPlayingInfoCenter DefaultCenter
	{
		[Export("defaultCenter")]
		get
		{
			return Runtime.GetNSObject<MPNowPlayingInfoCenter>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultCenterHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	public virtual MPNowPlayingPlaybackState PlaybackState
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
		[Export("playbackState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPNowPlayingPlaybackState)Messaging.UInt64_objc_msgSend(base.Handle, selPlaybackStateHandle);
			}
			return (MPNowPlayingPlaybackState)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPlaybackStateHandle);
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
		[Export("setPlaybackState:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPlaybackState_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPlaybackState_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSDictionary? _NowPlayingInfo
	{
		[Export("nowPlayingInfo", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selNowPlayingInfoHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNowPlayingInfoHandle));
		}
		[Export("setNowPlayingInfo:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNowPlayingInfo_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNowPlayingInfo_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[Field("MPNowPlayingInfoPropertyAssetURL", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 3, PlatformArchitecture.All, null)]
	public static NSString PropertyAssetUrl
	{
		[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_PropertyAssetUrl == null)
			{
				_PropertyAssetUrl = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyAssetURL");
			}
			return _PropertyAssetUrl;
		}
	}

	[Field("MPNowPlayingInfoPropertyAvailableLanguageOptions", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	internal static NSString PropertyAvailableLanguageOptions
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PropertyAvailableLanguageOptions == null)
			{
				_PropertyAvailableLanguageOptions = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyAvailableLanguageOptions");
			}
			return _PropertyAvailableLanguageOptions;
		}
	}

	[Field("MPNowPlayingInfoPropertyChapterCount", "MediaPlayer")]
	internal static NSString PropertyChapterCount
	{
		get
		{
			if (_PropertyChapterCount == null)
			{
				_PropertyChapterCount = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyChapterCount");
			}
			return _PropertyChapterCount;
		}
	}

	[Field("MPNowPlayingInfoPropertyChapterNumber", "MediaPlayer")]
	internal static NSString PropertyChapterNumber
	{
		get
		{
			if (_PropertyChapterNumber == null)
			{
				_PropertyChapterNumber = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyChapterNumber");
			}
			return _PropertyChapterNumber;
		}
	}

	[Field("MPNowPlayingInfoCollectionIdentifier", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString PropertyCollectionIdentifier
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PropertyCollectionIdentifier == null)
			{
				_PropertyCollectionIdentifier = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoCollectionIdentifier");
			}
			return _PropertyCollectionIdentifier;
		}
	}

	[Field("MPNowPlayingInfoPropertyCurrentLanguageOptions", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	internal static NSString PropertyCurrentLanguageOptions
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PropertyCurrentLanguageOptions == null)
			{
				_PropertyCurrentLanguageOptions = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyCurrentLanguageOptions");
			}
			return _PropertyCurrentLanguageOptions;
		}
	}

	[Field("MPNowPlayingInfoPropertyCurrentPlaybackDate", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 11, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 1, PlatformArchitecture.All, null)]
	internal static NSString PropertyCurrentPlaybackDate
	{
		[Introduced(PlatformName.iOS, 11, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 1, PlatformArchitecture.All, null)]
		get
		{
			if (_PropertyCurrentPlaybackDate == null)
			{
				_PropertyCurrentPlaybackDate = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyCurrentPlaybackDate");
			}
			return _PropertyCurrentPlaybackDate;
		}
	}

	[Field("MPNowPlayingInfoPropertyDefaultPlaybackRate", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	internal static NSString PropertyDefaultPlaybackRate
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PropertyDefaultPlaybackRate == null)
			{
				_PropertyDefaultPlaybackRate = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyDefaultPlaybackRate");
			}
			return _PropertyDefaultPlaybackRate;
		}
	}

	[Field("MPNowPlayingInfoPropertyElapsedPlaybackTime", "MediaPlayer")]
	internal static NSString PropertyElapsedPlaybackTime
	{
		get
		{
			if (_PropertyElapsedPlaybackTime == null)
			{
				_PropertyElapsedPlaybackTime = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyElapsedPlaybackTime");
			}
			return _PropertyElapsedPlaybackTime;
		}
	}

	[Field("MPNowPlayingInfoPropertyExternalContentIdentifier", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString PropertyExternalContentIdentifier
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PropertyExternalContentIdentifier == null)
			{
				_PropertyExternalContentIdentifier = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyExternalContentIdentifier");
			}
			return _PropertyExternalContentIdentifier;
		}
	}

	[Field("MPNowPlayingInfoPropertyExternalUserProfileIdentifier", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString PropertyExternalUserProfileIdentifier
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PropertyExternalUserProfileIdentifier == null)
			{
				_PropertyExternalUserProfileIdentifier = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyExternalUserProfileIdentifier");
			}
			return _PropertyExternalUserProfileIdentifier;
		}
	}

	[Field("MPNowPlayingInfoPropertyIsLiveStream", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString PropertyIsLiveStream
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PropertyIsLiveStream == null)
			{
				_PropertyIsLiveStream = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyIsLiveStream");
			}
			return _PropertyIsLiveStream;
		}
	}

	[Field("MPNowPlayingInfoPropertyMediaType", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString PropertyMediaType
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PropertyMediaType == null)
			{
				_PropertyMediaType = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyMediaType");
			}
			return _PropertyMediaType;
		}
	}

	[Field("MPNowPlayingInfoPropertyPlaybackProgress", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString PropertyPlaybackProgress
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PropertyPlaybackProgress == null)
			{
				_PropertyPlaybackProgress = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyPlaybackProgress");
			}
			return _PropertyPlaybackProgress;
		}
	}

	[Field("MPNowPlayingInfoPropertyPlaybackQueueCount", "MediaPlayer")]
	internal static NSString PropertyPlaybackQueueCount
	{
		get
		{
			if (_PropertyPlaybackQueueCount == null)
			{
				_PropertyPlaybackQueueCount = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyPlaybackQueueCount");
			}
			return _PropertyPlaybackQueueCount;
		}
	}

	[Field("MPNowPlayingInfoPropertyPlaybackQueueIndex", "MediaPlayer")]
	internal static NSString PropertyPlaybackQueueIndex
	{
		get
		{
			if (_PropertyPlaybackQueueIndex == null)
			{
				_PropertyPlaybackQueueIndex = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyPlaybackQueueIndex");
			}
			return _PropertyPlaybackQueueIndex;
		}
	}

	[Field("MPNowPlayingInfoPropertyPlaybackRate", "MediaPlayer")]
	internal static NSString PropertyPlaybackRate
	{
		get
		{
			if (_PropertyPlaybackRate == null)
			{
				_PropertyPlaybackRate = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyPlaybackRate");
			}
			return _PropertyPlaybackRate;
		}
	}

	[Field("MPNowPlayingInfoPropertyServiceIdentifier", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	public static NSString PropertyServiceIdentifier
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_PropertyServiceIdentifier == null)
			{
				_PropertyServiceIdentifier = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPNowPlayingInfoPropertyServiceIdentifier");
			}
			return _PropertyServiceIdentifier;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPNowPlayingInfoCenter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPNowPlayingInfoCenter(IntPtr handle)
		: base(handle)
	{
	}
}
