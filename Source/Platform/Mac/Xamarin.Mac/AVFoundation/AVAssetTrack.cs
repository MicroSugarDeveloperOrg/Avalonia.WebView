using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetTrack", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVAssetTrack : NSObject, INSCopying, INativeObject, IDisposable
{
	public static class Notifications
	{
		public static NSObject ObserveSegmentsDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SegmentsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveSegmentsDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(SegmentsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveTimeRangeDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TimeRangeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveTimeRangeDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TimeRangeDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveTrackAssociationsDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TrackAssociationsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveTrackAssociationsDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(TrackAssociationsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAsset = "asset";

	private static readonly IntPtr selAssetHandle = Selector.GetHandle("asset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssociatedTracksOfType_ = "associatedTracksOfType:";

	private static readonly IntPtr selAssociatedTracksOfType_Handle = Selector.GetHandle("associatedTracksOfType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableMetadataFormats = "availableMetadataFormats";

	private static readonly IntPtr selAvailableMetadataFormatsHandle = Selector.GetHandle("availableMetadataFormats");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableTrackAssociationTypes = "availableTrackAssociationTypes";

	private static readonly IntPtr selAvailableTrackAssociationTypesHandle = Selector.GetHandle("availableTrackAssociationTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanProvideSampleCursors = "canProvideSampleCursors";

	private static readonly IntPtr selCanProvideSampleCursorsHandle = Selector.GetHandle("canProvideSampleCursors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommonMetadata = "commonMetadata";

	private static readonly IntPtr selCommonMetadataHandle = Selector.GetHandle("commonMetadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEstimatedDataRate = "estimatedDataRate";

	private static readonly IntPtr selEstimatedDataRateHandle = Selector.GetHandle("estimatedDataRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendedLanguageTag = "extendedLanguageTag";

	private static readonly IntPtr selExtendedLanguageTagHandle = Selector.GetHandle("extendedLanguageTag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatDescriptions = "formatDescriptions";

	private static readonly IntPtr selFormatDescriptionsHandle = Selector.GetHandle("formatDescriptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasAudioSampleDependencies = "hasAudioSampleDependencies";

	private static readonly IntPtr selHasAudioSampleDependenciesHandle = Selector.GetHandle("hasAudioSampleDependencies");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasMediaCharacteristic_ = "hasMediaCharacteristic:";

	private static readonly IntPtr selHasMediaCharacteristic_Handle = Selector.GetHandle("hasMediaCharacteristic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDecodable = "isDecodable";

	private static readonly IntPtr selIsDecodableHandle = Selector.GetHandle("isDecodable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlayable = "isPlayable";

	private static readonly IntPtr selIsPlayableHandle = Selector.GetHandle("isPlayable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSelfContained = "isSelfContained";

	private static readonly IntPtr selIsSelfContainedHandle = Selector.GetHandle("isSelfContained");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageCode = "languageCode";

	private static readonly IntPtr selLanguageCodeHandle = Selector.GetHandle("languageCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeSampleCursorAtFirstSampleInDecodeOrder = "makeSampleCursorAtFirstSampleInDecodeOrder";

	private static readonly IntPtr selMakeSampleCursorAtFirstSampleInDecodeOrderHandle = Selector.GetHandle("makeSampleCursorAtFirstSampleInDecodeOrder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeSampleCursorAtLastSampleInDecodeOrder = "makeSampleCursorAtLastSampleInDecodeOrder";

	private static readonly IntPtr selMakeSampleCursorAtLastSampleInDecodeOrderHandle = Selector.GetHandle("makeSampleCursorAtLastSampleInDecodeOrder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeSampleCursorWithPresentationTimeStamp_ = "makeSampleCursorWithPresentationTimeStamp:";

	private static readonly IntPtr selMakeSampleCursorWithPresentationTimeStamp_Handle = Selector.GetHandle("makeSampleCursorWithPresentationTimeStamp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaType = "mediaType";

	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadata = "metadata";

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataForFormat_ = "metadataForFormat:";

	private static readonly IntPtr selMetadataForFormat_Handle = Selector.GetHandle("metadataForFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinFrameDuration = "minFrameDuration";

	private static readonly IntPtr selMinFrameDurationHandle = Selector.GetHandle("minFrameDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNaturalSize = "naturalSize";

	private static readonly IntPtr selNaturalSizeHandle = Selector.GetHandle("naturalSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNaturalTimeScale = "naturalTimeScale";

	private static readonly IntPtr selNaturalTimeScaleHandle = Selector.GetHandle("naturalTimeScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNominalFrameRate = "nominalFrameRate";

	private static readonly IntPtr selNominalFrameRateHandle = Selector.GetHandle("nominalFrameRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredTransform = "preferredTransform";

	private static readonly IntPtr selPreferredTransformHandle = Selector.GetHandle("preferredTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredVolume = "preferredVolume";

	private static readonly IntPtr selPreferredVolumeHandle = Selector.GetHandle("preferredVolume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequiresFrameReordering = "requiresFrameReordering";

	private static readonly IntPtr selRequiresFrameReorderingHandle = Selector.GetHandle("requiresFrameReordering");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSamplePresentationTimeForTrackTime_ = "samplePresentationTimeForTrackTime:";

	private static readonly IntPtr selSamplePresentationTimeForTrackTime_Handle = Selector.GetHandle("samplePresentationTimeForTrackTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSegmentForTrackTime_ = "segmentForTrackTime:";

	private static readonly IntPtr selSegmentForTrackTime_Handle = Selector.GetHandle("segmentForTrackTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSegments = "segments";

	private static readonly IntPtr selSegmentsHandle = Selector.GetHandle("segments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeRange = "timeRange";

	private static readonly IntPtr selTimeRangeHandle = Selector.GetHandle("timeRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTotalSampleDataLength = "totalSampleDataLength";

	private static readonly IntPtr selTotalSampleDataLengthHandle = Selector.GetHandle("totalSampleDataLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackID = "trackID";

	private static readonly IntPtr selTrackIDHandle = Selector.GetHandle("trackID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetTrack");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Asset_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SegmentsDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TimeRangeDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TrackAssociationsDidChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAsset? Asset
	{
		[Export("asset", ArgumentSemantic.Weak)]
		get
		{
			AVAsset aVAsset = ((!base.IsDirectBinding) ? Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetHandle)) : Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetHandle)));
			MarkDirty();
			__mt_Asset_var = aVAsset;
			return aVAsset;
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
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSString[] AvailableTrackAssociationTypes
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("availableTrackAssociationTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableTrackAssociationTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableTrackAssociationTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool CanProvideSampleCursors
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("canProvideSampleCursors")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanProvideSampleCursorsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanProvideSampleCursorsHandle);
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
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool Decodable
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("isDecodable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDecodableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDecodableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float EstimatedDataRate
	{
		[Export("estimatedDataRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selEstimatedDataRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selEstimatedDataRateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ExtendedLanguageTag
	{
		[Export("extendedLanguageTag")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selExtendedLanguageTagHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtendedLanguageTagHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CMFormatDescription[] FormatDescriptions => Array.ConvertAll(FormatDescriptionsAsObjects, (NSObject l) => CMFormatDescription.Create(l.Handle, owns: false));

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] FormatDescriptionsAsObjects
	{
		[Export("formatDescriptions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual bool HasAudioSampleDependencies
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("hasAudioSampleDependencies")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasAudioSampleDependenciesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasAudioSampleDependenciesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? LanguageCode
	{
		[Export("languageCode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageCodeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageCodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MediaType
	{
		[Export("mediaType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
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
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CMTime MinFrameDuration
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("minFrameDuration")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selMinFrameDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMinFrameDurationHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize NaturalSize
	{
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
	public virtual int NaturalTimeScale
	{
		[Export("naturalTimeScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNaturalTimeScaleHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNaturalTimeScaleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float NominalFrameRate
	{
		[Export("nominalFrameRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selNominalFrameRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selNominalFrameRateHandle);
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
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool RequiresFrameReordering
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("requiresFrameReordering")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequiresFrameReorderingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequiresFrameReorderingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetTrackSegment[] Segments
	{
		[Export("segments", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVAssetTrackSegment>(Messaging.IntPtr_objc_msgSend(base.Handle, selSegmentsHandle));
			}
			return NSArray.ArrayFromHandle<AVAssetTrackSegment>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSegmentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SelfContained
	{
		[Export("isSelfContained")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelfContainedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelfContainedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTimeRange TimeRange
	{
		[Export("timeRange")]
		get
		{
			CMTimeRange retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTimeRange_objc_msgSend_stret(out retval, base.Handle, selTimeRangeHandle);
			}
			else
			{
				Messaging.CMTimeRange_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTimeRangeHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long TotalSampleDataLength
	{
		[Export("totalSampleDataLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selTotalSampleDataLengthHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTotalSampleDataLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int TrackID
	{
		[Export("trackID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTrackIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTrackIDHandle);
		}
	}

	[Field("AVAssetTrackSegmentsDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Advice("Use AVAssetTrack.Notifications.ObserveSegmentsDidChange helper method instead.")]
	public static NSString SegmentsDidChangeNotification
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_SegmentsDidChangeNotification == null)
			{
				_SegmentsDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetTrackSegmentsDidChangeNotification");
			}
			return _SegmentsDidChangeNotification;
		}
	}

	[Field("AVAssetTrackTimeRangeDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Advice("Use AVAssetTrack.Notifications.ObserveTimeRangeDidChange helper method instead.")]
	public static NSString TimeRangeDidChangeNotification
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_TimeRangeDidChangeNotification == null)
			{
				_TimeRangeDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetTrackTimeRangeDidChangeNotification");
			}
			return _TimeRangeDidChangeNotification;
		}
	}

	[Field("AVAssetTrackTrackAssociationsDidChangeNotification", "AVFoundation")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Advice("Use AVAssetTrack.Notifications.ObserveTrackAssociationsDidChange helper method instead.")]
	public static NSString TrackAssociationsDidChangeNotification
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_TrackAssociationsDidChangeNotification == null)
			{
				_TrackAssociationsDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAssetTrackTrackAssociationsDidChangeNotification");
			}
			return _TrackAssociationsDidChangeNotification;
		}
	}

	[Obsolete("Use 'GetAssociatedTracks'.")]
	public virtual NSString GetAssociatedTracksOfType(NSString avAssetTrackTrackAssociationType)
	{
		return null;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetTrack(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetTrack(IntPtr handle)
		: base(handle)
	{
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

	[Export("associatedTracksOfType:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetTrack[] GetAssociatedTracks(NSString avAssetTrackTrackAssociationType)
	{
		if (avAssetTrackTrackAssociationType == null)
		{
			throw new ArgumentNullException("avAssetTrackTrackAssociationType");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAssociatedTracksOfType_Handle, avAssetTrackTrackAssociationType.Handle));
		}
		return NSArray.ArrayFromHandle<AVAssetTrack>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAssociatedTracksOfType_Handle, avAssetTrackTrackAssociationType.Handle));
	}

	[Export("hasMediaCharacteristic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasMediaCharacteristic(string mediaCharacteristic)
	{
		if (mediaCharacteristic == null)
		{
			throw new ArgumentNullException("mediaCharacteristic");
		}
		IntPtr arg = NSString.CreateNative(mediaCharacteristic);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasMediaCharacteristic_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasMediaCharacteristic_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("makeSampleCursorWithPresentationTimeStamp:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSampleCursor? MakeSampleCursor(CMTime presentationTimeStamp)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVSampleCursor>(Messaging.IntPtr_objc_msgSend_CMTime(base.Handle, selMakeSampleCursorWithPresentationTimeStamp_Handle, presentationTimeStamp));
		}
		return Runtime.GetNSObject<AVSampleCursor>(Messaging.IntPtr_objc_msgSendSuper_CMTime(base.SuperHandle, selMakeSampleCursorWithPresentationTimeStamp_Handle, presentationTimeStamp));
	}

	[Export("makeSampleCursorAtFirstSampleInDecodeOrder")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSampleCursor? MakeSampleCursorAtFirstSampleInDecodeOrder()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVSampleCursor>(Messaging.IntPtr_objc_msgSend(base.Handle, selMakeSampleCursorAtFirstSampleInDecodeOrderHandle));
		}
		return Runtime.GetNSObject<AVSampleCursor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMakeSampleCursorAtFirstSampleInDecodeOrderHandle));
	}

	[Export("makeSampleCursorAtLastSampleInDecodeOrder")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSampleCursor? MakeSampleCursorAtLastSampleInDecodeOrder()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVSampleCursor>(Messaging.IntPtr_objc_msgSend(base.Handle, selMakeSampleCursorAtLastSampleInDecodeOrderHandle));
		}
		return Runtime.GetNSObject<AVSampleCursor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMakeSampleCursorAtLastSampleInDecodeOrderHandle));
	}

	[Export("metadataForFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataItem[] MetadataForFormat(string format)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		IntPtr arg = NSString.CreateNative(format);
		AVMetadataItem[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMetadataForFormat_Handle, arg)) : NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMetadataForFormat_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("samplePresentationTimeForTrackTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime SamplePresentationTimeForTrackTime(CMTime trackTime)
	{
		CMTime retval;
		if (base.IsDirectBinding)
		{
			Messaging.CMTime_objc_msgSend_stret_CMTime(out retval, base.Handle, selSamplePresentationTimeForTrackTime_Handle, trackTime);
		}
		else
		{
			Messaging.CMTime_objc_msgSendSuper_stret_CMTime(out retval, base.SuperHandle, selSamplePresentationTimeForTrackTime_Handle, trackTime);
		}
		return retval;
	}

	[Export("segmentForTrackTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetTrackSegment? SegmentForTrackTime(CMTime trackTime)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVAssetTrackSegment>(Messaging.IntPtr_objc_msgSend_CMTime(base.Handle, selSegmentForTrackTime_Handle, trackTime));
		}
		return Runtime.GetNSObject<AVAssetTrackSegment>(Messaging.IntPtr_objc_msgSendSuper_CMTime(base.SuperHandle, selSegmentForTrackTime_Handle, trackTime));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Asset_var = null;
		}
	}
}
