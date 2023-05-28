using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAsset", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVAsset : NSObject, INSCopying, INativeObject, IDisposable
{
	public static class Notifications
	{
		public static NSObject ObserveChapterMetadataGroupsDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChapterMetadataGroupsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveChapterMetadataGroupsDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChapterMetadataGroupsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveContainsFragmentsDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ContainsFragmentsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveContainsFragmentsDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ContainsFragmentsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDurationDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DurationDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDurationDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DurationDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveMediaSelectionGroupsDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MediaSelectionGroupsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveMediaSelectionGroupsDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(MediaSelectionGroupsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWasDefragmented(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasDefragmentedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWasDefragmented(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasDefragmentedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllMediaSelections = "allMediaSelections";

	private static readonly IntPtr selAllMediaSelectionsHandle = Selector.GetHandle("allMediaSelections");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetWithURL_ = "assetWithURL:";

	private static readonly IntPtr selAssetWithURL_Handle = Selector.GetHandle("assetWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableChapterLocales = "availableChapterLocales";

	private static readonly IntPtr selAvailableChapterLocalesHandle = Selector.GetHandle("availableChapterLocales");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableMediaCharacteristicsWithMediaSelectionOptions = "availableMediaCharacteristicsWithMediaSelectionOptions";

	private static readonly IntPtr selAvailableMediaCharacteristicsWithMediaSelectionOptionsHandle = Selector.GetHandle("availableMediaCharacteristicsWithMediaSelectionOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableMetadataFormats = "availableMetadataFormats";

	private static readonly IntPtr selAvailableMetadataFormatsHandle = Selector.GetHandle("availableMetadataFormats");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanContainFragments = "canContainFragments";

	private static readonly IntPtr selCanContainFragmentsHandle = Selector.GetHandle("canContainFragments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelLoading = "cancelLoading";

	private static readonly IntPtr selCancelLoadingHandle = Selector.GetHandle("cancelLoading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChapterMetadataGroupsBestMatchingPreferredLanguages_ = "chapterMetadataGroupsBestMatchingPreferredLanguages:";

	private static readonly IntPtr selChapterMetadataGroupsBestMatchingPreferredLanguages_Handle = Selector.GetHandle("chapterMetadataGroupsBestMatchingPreferredLanguages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChapterMetadataGroupsWithTitleLocale_ContainingItemsWithCommonKeys_ = "chapterMetadataGroupsWithTitleLocale:containingItemsWithCommonKeys:";

	private static readonly IntPtr selChapterMetadataGroupsWithTitleLocale_ContainingItemsWithCommonKeys_Handle = Selector.GetHandle("chapterMetadataGroupsWithTitleLocale:containingItemsWithCommonKeys:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommonMetadata = "commonMetadata";

	private static readonly IntPtr selCommonMetadataHandle = Selector.GetHandle("commonMetadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsFragments = "containsFragments";

	private static readonly IntPtr selContainsFragmentsHandle = Selector.GetHandle("containsFragments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreationDate = "creationDate";

	private static readonly IntPtr selCreationDateHandle = Selector.GetHandle("creationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasProtectedContent = "hasProtectedContent";

	private static readonly IntPtr selHasProtectedContentHandle = Selector.GetHandle("hasProtectedContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCompatibleWithAirPlayVideo = "isCompatibleWithAirPlayVideo";

	private static readonly IntPtr selIsCompatibleWithAirPlayVideoHandle = Selector.GetHandle("isCompatibleWithAirPlayVideo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsComposable = "isComposable";

	private static readonly IntPtr selIsComposableHandle = Selector.GetHandle("isComposable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExportable = "isExportable";

	private static readonly IntPtr selIsExportableHandle = Selector.GetHandle("isExportable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlayable = "isPlayable";

	private static readonly IntPtr selIsPlayableHandle = Selector.GetHandle("isPlayable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsReadable = "isReadable";

	private static readonly IntPtr selIsReadableHandle = Selector.GetHandle("isReadable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadValuesAsynchronouslyForKeys_CompletionHandler_ = "loadValuesAsynchronouslyForKeys:completionHandler:";

	private static readonly IntPtr selLoadValuesAsynchronouslyForKeys_CompletionHandler_Handle = Selector.GetHandle("loadValuesAsynchronouslyForKeys:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLyrics = "lyrics";

	private static readonly IntPtr selLyricsHandle = Selector.GetHandle("lyrics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSelectionGroupForMediaCharacteristic_ = "mediaSelectionGroupForMediaCharacteristic:";

	private static readonly IntPtr selMediaSelectionGroupForMediaCharacteristic_Handle = Selector.GetHandle("mediaSelectionGroupForMediaCharacteristic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadata = "metadata";

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataForFormat_ = "metadataForFormat:";

	private static readonly IntPtr selMetadataForFormat_Handle = Selector.GetHandle("metadataForFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumTimeOffsetFromLive = "minimumTimeOffsetFromLive";

	private static readonly IntPtr selMinimumTimeOffsetFromLiveHandle = Selector.GetHandle("minimumTimeOffsetFromLive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNaturalSize = "naturalSize";

	private static readonly IntPtr selNaturalSizeHandle = Selector.GetHandle("naturalSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverallDurationHint = "overallDurationHint";

	private static readonly IntPtr selOverallDurationHintHandle = Selector.GetHandle("overallDurationHint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredMediaSelection = "preferredMediaSelection";

	private static readonly IntPtr selPreferredMediaSelectionHandle = Selector.GetHandle("preferredMediaSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredRate = "preferredRate";

	private static readonly IntPtr selPreferredRateHandle = Selector.GetHandle("preferredRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredTransform = "preferredTransform";

	private static readonly IntPtr selPreferredTransformHandle = Selector.GetHandle("preferredTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredVolume = "preferredVolume";

	private static readonly IntPtr selPreferredVolumeHandle = Selector.GetHandle("preferredVolume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProvidesPreciseDurationAndTiming = "providesPreciseDurationAndTiming";

	private static readonly IntPtr selProvidesPreciseDurationAndTimingHandle = Selector.GetHandle("providesPreciseDurationAndTiming");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReferenceRestrictions = "referenceRestrictions";

	private static readonly IntPtr selReferenceRestrictionsHandle = Selector.GetHandle("referenceRestrictions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatusOfValueForKey_Error_ = "statusOfValueForKey:error:";

	private static readonly IntPtr selStatusOfValueForKey_Error_Handle = Selector.GetHandle("statusOfValueForKey:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackGroups = "trackGroups";

	private static readonly IntPtr selTrackGroupsHandle = Selector.GetHandle("trackGroups");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackWithTrackID_ = "trackWithTrackID:";

	private static readonly IntPtr selTrackWithTrackID_Handle = Selector.GetHandle("trackWithTrackID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTracks = "tracks";

	private static readonly IntPtr selTracksHandle = Selector.GetHandle("tracks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTracksWithMediaCharacteristic_ = "tracksWithMediaCharacteristic:";

	private static readonly IntPtr selTracksWithMediaCharacteristic_Handle = Selector.GetHandle("tracksWithMediaCharacteristic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTracksWithMediaType_ = "tracksWithMediaType:";

	private static readonly IntPtr selTracksWithMediaType_Handle = Selector.GetHandle("tracksWithMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnusedTrackID = "unusedTrackID";

	private static readonly IntPtr selUnusedTrackIDHandle = Selector.GetHandle("unusedTrackID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAsset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChapterMetadataGroupsDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContainsFragmentsDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DurationDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaSelectionGroupsDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WasDefragmentedNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	public virtual AVMediaSelection[] AllMediaSelections
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Export("allMediaSelections")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMediaSelection>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllMediaSelectionsHandle));
			}
			return NSArray.ArrayFromHandle<AVMediaSelection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllMediaSelectionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLocale[] AvailableChapterLocales
	{
		[Export("availableChapterLocales")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSLocale>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableChapterLocalesHandle));
			}
			return NSArray.ArrayFromHandle<NSLocale>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableChapterLocalesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AvailableMediaCharacteristicsWithMediaSelectionOptions
	{
		[Export("availableMediaCharacteristicsWithMediaSelectionOptions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableMediaCharacteristicsWithMediaSelectionOptionsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableMediaCharacteristicsWithMediaSelectionOptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AvailableMetadataFormats
	{
		[Export("availableMetadataFormats")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableMetadataFormatsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableMetadataFormatsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool CanContainFragments
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("canContainFragments")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanContainFragmentsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanContainFragmentsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataItem[] CommonMetadata
	{
		[Export("commonMetadata")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selCommonMetadataHandle));
			}
			return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommonMetadataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool CompatibleWithAirPlayVideo
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("isCompatibleWithAirPlayVideo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCompatibleWithAirPlayVideoHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCompatibleWithAirPlayVideoHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Composable
	{
		[Export("isComposable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsComposableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsComposableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool ContainsFragments
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("containsFragments")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selContainsFragmentsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selContainsFragmentsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataItem? CreationDate
	{
		[Export("creationDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selCreationDateHandle));
			}
			return Runtime.GetNSObject<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreationDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime Duration
	{
		[Export("duration")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDurationHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Exportable
	{
		[Export("isExportable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExportableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExportableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Lyrics
	{
		[Export("lyrics")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLyricsHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLyricsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual AVMetadataItem[] Metadata
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("metadata")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetadataHandle));
			}
			return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetadataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual CMTime MinimumTimeOffsetFromLive
	{
		[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("minimumTimeOffsetFromLive")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selMinimumTimeOffsetFromLiveHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMinimumTimeOffsetFromLiveHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 5, 0, PlatformArchitecture.None, "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
	public virtual CGSize NaturalSize
	{
		[Deprecated(PlatformName.iOS, 5, 0, PlatformArchitecture.None, "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, "Use 'NaturalSize/PreferredTransform' as appropriate on the video track instead.")]
		[Export("naturalSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selNaturalSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selNaturalSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	public virtual CMTime OverallDurationHint
	{
		[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
		[Export("overallDurationHint")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selOverallDurationHintHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selOverallDurationHintHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Playable
	{
		[Export("isPlayable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlayableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlayableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual AVMediaSelection PreferredMediaSelection
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("preferredMediaSelection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVMediaSelection>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredMediaSelectionHandle));
			}
			return Runtime.GetNSObject<AVMediaSelection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredMediaSelectionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float PreferredRate
	{
		[Export("preferredRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPreferredRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPreferredRateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGAffineTransform PreferredTransform
	{
		[Export("preferredTransform")]
		get
		{
			CGAffineTransform retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGAffineTransform_objc_msgSend_stret(out retval, base.Handle, selPreferredTransformHandle);
			}
			else
			{
				Messaging.CGAffineTransform_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPreferredTransformHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float PreferredVolume
	{
		[Export("preferredVolume")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPreferredVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPreferredVolumeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ProtectedContent
	{
		[Export("hasProtectedContent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasProtectedContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasProtectedContentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ProvidesPreciseDurationAndTiming
	{
		[Export("providesPreciseDurationAndTiming")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selProvidesPreciseDurationAndTimingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selProvidesPreciseDurationAndTimingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Readable
	{
		[Export("isReadable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsReadableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsReadableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetReferenceRestrictions ReferenceRestrictions
	{
		[Export("referenceRestrictions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVAssetReferenceRestrictions)Messaging.UInt64_objc_msgSend(base.Handle, selReferenceRestrictionsHandle);
			}
			return (AVAssetReferenceRestrictions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selReferenceRestrictionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual AVAssetTrackGroup[] TrackGroups
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("trackGroups", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVAssetTrackGroup>(Messaging.IntPtr_objc_msgSend(base.Handle, selTrackGroupsHandle));
			}
			return NSArray.ArrayFromHandle<AVAssetTrackGroup>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrackGroupsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetTrack[] Tracks
	{
		[Export("tracks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTracksHandle));
			}
			return NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTracksHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int UnusedTrackId
	{
		[Export("unusedTrackID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selUnusedTrackIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selUnusedTrackIDHandle);
		}
	}

	[Field("AVAssetChapterMetadataGroupsDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Advice("Use AVAsset.Notifications.ObserveChapterMetadataGroupsDidChange helper method instead.")]
	public static NSString ChapterMetadataGroupsDidChangeNotification
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_ChapterMetadataGroupsDidChangeNotification == null)
			{
				_ChapterMetadataGroupsDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetChapterMetadataGroupsDidChangeNotification");
			}
			return _ChapterMetadataGroupsDidChangeNotification;
		}
	}

	[Field("AVAssetContainsFragmentsDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Advice("Use AVAsset.Notifications.ObserveContainsFragmentsDidChange helper method instead.")]
	public static NSString ContainsFragmentsDidChangeNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ContainsFragmentsDidChangeNotification == null)
			{
				_ContainsFragmentsDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetContainsFragmentsDidChangeNotification");
			}
			return _ContainsFragmentsDidChangeNotification;
		}
	}

	[Field("AVAssetDurationDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Advice("Use AVAsset.Notifications.ObserveDurationDidChange helper method instead.")]
	public static NSString DurationDidChangeNotification
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_DurationDidChangeNotification == null)
			{
				_DurationDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetDurationDidChangeNotification");
			}
			return _DurationDidChangeNotification;
		}
	}

	[Field("AVAssetMediaSelectionGroupsDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Advice("Use AVAsset.Notifications.ObserveMediaSelectionGroupsDidChange helper method instead.")]
	public static NSString MediaSelectionGroupsDidChangeNotification
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_MediaSelectionGroupsDidChangeNotification == null)
			{
				_MediaSelectionGroupsDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetMediaSelectionGroupsDidChangeNotification");
			}
			return _MediaSelectionGroupsDidChangeNotification;
		}
	}

	[Field("AVAssetWasDefragmentedNotification", "AVFoundation")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Advice("Use AVAsset.Notifications.ObserveWasDefragmented helper method instead.")]
	public static NSString WasDefragmentedNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_WasDefragmentedNotification == null)
			{
				_WasDefragmentedNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetWasDefragmentedNotification");
			}
			return _WasDefragmentedNotification;
		}
	}

	[Obsolete("Use 'GetChapterMetadataGroups'.")]
	public virtual AVMetadataItem[] ChapterMetadataGroups(NSLocale forLocale, AVMetadataItem[] commonKeys)
	{
		return null;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAsset(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAsset(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelLoading")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelLoading()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelLoadingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelLoadingHandle);
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("assetWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAsset FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAssetWithURL_Handle, url.Handle));
	}

	[Export("chapterMetadataGroupsWithTitleLocale:containingItemsWithCommonKeys:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVTimedMetadataGroup[] GetChapterMetadataGroups(NSLocale forLocale, AVMetadataItem[]? commonKeys)
	{
		if (forLocale == null)
		{
			throw new ArgumentNullException("forLocale");
		}
		NSArray nSArray = ((commonKeys == null) ? null : NSArray.FromNSObjects(commonKeys));
		AVTimedMetadataGroup[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<AVTimedMetadataGroup>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selChapterMetadataGroupsWithTitleLocale_ContainingItemsWithCommonKeys_Handle, forLocale.Handle, nSArray?.Handle ?? IntPtr.Zero)) : NSArray.ArrayFromHandle<AVTimedMetadataGroup>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selChapterMetadataGroupsWithTitleLocale_ContainingItemsWithCommonKeys_Handle, forLocale.Handle, nSArray?.Handle ?? IntPtr.Zero)));
		nSArray?.Dispose();
		return result;
	}

	[Export("chapterMetadataGroupsBestMatchingPreferredLanguages:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVTimedMetadataGroup[] GetChapterMetadataGroupsBestMatchingPreferredLanguages(string[] languages)
	{
		if (languages == null)
		{
			throw new ArgumentNullException("languages");
		}
		NSArray nSArray = NSArray.FromStrings(languages);
		AVTimedMetadataGroup[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<AVTimedMetadataGroup>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selChapterMetadataGroupsBestMatchingPreferredLanguages_Handle, nSArray.Handle)) : NSArray.ArrayFromHandle<AVTimedMetadataGroup>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selChapterMetadataGroupsBestMatchingPreferredLanguages_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVMediaSelectionGroup? GetMediaSelectionGroupForMediaCharacteristic(AVMediaCharacteristics avMediaCharacteristic)
	{
		return MediaSelectionGroupForMediaCharacteristic(avMediaCharacteristic.GetConstant());
	}

	[Export("metadataForFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataItem[] GetMetadataForFormat(NSString format)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMetadataForFormat_Handle, format.Handle));
		}
		return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMetadataForFormat_Handle, format.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVMetadataItem[] GetMetadataForFormat(AVMetadataFormat format)
	{
		return GetMetadataForFormat(format.GetConstant());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetTrack[] GetTracks(AVMediaTypes mediaType)
	{
		return TracksWithMediaType(mediaType.GetConstant());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetTrack[] GetTracks(AVMediaCharacteristics mediaCharacteristic)
	{
		return TracksWithMediaType(mediaCharacteristic.GetConstant());
	}

	[Export("loadValuesAsynchronouslyForKeys:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadValuesAsynchronously(string[] keys, [BlockProxy(typeof(Trampolines.NIDAction))] Action handler)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		NSArray nSArray = NSArray.FromStrings(keys);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadValuesAsynchronouslyForKeys_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadValuesAsynchronouslyForKeys_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task LoadValuesTaskAsync(string[] keys)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		LoadValuesAsynchronously(keys, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("mediaSelectionGroupForMediaCharacteristic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMediaSelectionGroup? MediaSelectionGroupForMediaCharacteristic(string avMediaCharacteristic)
	{
		if (avMediaCharacteristic == null)
		{
			throw new ArgumentNullException("avMediaCharacteristic");
		}
		IntPtr arg = NSString.CreateNative(avMediaCharacteristic);
		AVMediaSelectionGroup result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<AVMediaSelectionGroup>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMediaSelectionGroupForMediaCharacteristic_Handle, arg)) : Runtime.GetNSObject<AVMediaSelectionGroup>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMediaSelectionGroupForMediaCharacteristic_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Obsolete("Use 'GetMetadataForFormat' with enum values AVMetadataFormat.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataItem[] MetadataForFormat(string format)
	{
		return GetMetadataForFormat(new NSString(format));
	}

	[Export("statusOfValueForKey:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVKeyValueStatus StatusOfValue(string key, out NSError error)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(key);
		AVKeyValueStatus result = (AVKeyValueStatus)((!base.IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selStatusOfValueForKey_Error_Handle, arg2, ref arg) : Messaging.Int64_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selStatusOfValueForKey_Error_Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("trackWithTrackID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetTrack? TrackWithTrackID(int trackID)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVAssetTrack>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selTrackWithTrackID_Handle, trackID));
		}
		return Runtime.GetNSObject<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selTrackWithTrackID_Handle, trackID));
	}

	[Export("tracksWithMediaCharacteristic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetTrack[] TracksWithMediaCharacteristic(string mediaCharacteristic)
	{
		if (mediaCharacteristic == null)
		{
			throw new ArgumentNullException("mediaCharacteristic");
		}
		IntPtr arg = NSString.CreateNative(mediaCharacteristic);
		AVAssetTrack[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTracksWithMediaCharacteristic_Handle, arg)) : NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTracksWithMediaCharacteristic_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("tracksWithMediaType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetTrack[] TracksWithMediaType(string mediaType)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		AVAssetTrack[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTracksWithMediaType_Handle, arg)) : NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTracksWithMediaType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
