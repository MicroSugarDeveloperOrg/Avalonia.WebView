using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace iTunesLibrary;

[Register("ITLibMediaItem", true)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public class ITLibMediaItem : ITLibMediaEntity
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddedDate = "addedDate";

	private static readonly IntPtr selAddedDateHandle = Selector.GetHandle("addedDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlbum = "album";

	private static readonly IntPtr selAlbumHandle = Selector.GetHandle("album");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArtist = "artist";

	private static readonly IntPtr selArtistHandle = Selector.GetHandle("artist");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArtwork = "artwork";

	private static readonly IntPtr selArtworkHandle = Selector.GetHandle("artwork");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeatsPerMinute = "beatsPerMinute";

	private static readonly IntPtr selBeatsPerMinuteHandle = Selector.GetHandle("beatsPerMinute");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitrate = "bitrate";

	private static readonly IntPtr selBitrateHandle = Selector.GetHandle("bitrate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCategory = "category";

	private static readonly IntPtr selCategoryHandle = Selector.GetHandle("category");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComments = "comments";

	private static readonly IntPtr selCommentsHandle = Selector.GetHandle("comments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComposer = "composer";

	private static readonly IntPtr selComposerHandle = Selector.GetHandle("composer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentRating = "contentRating";

	private static readonly IntPtr selContentRatingHandle = Selector.GetHandle("contentRating");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescription = "description";

	private static readonly IntPtr selDescriptionHandle = Selector.GetHandle("description");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileSize = "fileSize";

	private static readonly IntPtr selFileSizeHandle = Selector.GetHandle("fileSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileType = "fileType";

	private static readonly IntPtr selFileTypeHandle = Selector.GetHandle("fileType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenre = "genre";

	private static readonly IntPtr selGenreHandle = Selector.GetHandle("genre");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGrouping = "grouping";

	private static readonly IntPtr selGroupingHandle = Selector.GetHandle("grouping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasArtworkAvailable = "hasArtworkAvailable";

	private static readonly IntPtr selHasArtworkAvailableHandle = Selector.GetHandle("hasArtworkAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCloud = "isCloud";

	private static readonly IntPtr selIsCloudHandle = Selector.GetHandle("isCloud");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDRMProtected = "isDRMProtected";

	private static readonly IntPtr selIsDRMProtectedHandle = Selector.GetHandle("isDRMProtected");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPurchased = "isPurchased";

	private static readonly IntPtr selIsPurchasedHandle = Selector.GetHandle("isPurchased");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRatingComputed = "isRatingComputed";

	private static readonly IntPtr selIsRatingComputedHandle = Selector.GetHandle("isRatingComputed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsUserDisabled = "isUserDisabled";

	private static readonly IntPtr selIsUserDisabledHandle = Selector.GetHandle("isUserDisabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVideo = "isVideo";

	private static readonly IntPtr selIsVideoHandle = Selector.GetHandle("isVideo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKind = "kind";

	private static readonly IntPtr selKindHandle = Selector.GetHandle("kind");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastPlayedDate = "lastPlayedDate";

	private static readonly IntPtr selLastPlayedDateHandle = Selector.GetHandle("lastPlayedDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocation = "location";

	private static readonly IntPtr selLocationHandle = Selector.GetHandle("location");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocationType = "locationType";

	private static readonly IntPtr selLocationTypeHandle = Selector.GetHandle("locationType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLyricsContentRating = "lyricsContentRating";

	private static readonly IntPtr selLyricsContentRatingHandle = Selector.GetHandle("lyricsContentRating");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaKind = "mediaKind";

	private static readonly IntPtr selMediaKindHandle = Selector.GetHandle("mediaKind");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModifiedDate = "modifiedDate";

	private static readonly IntPtr selModifiedDateHandle = Selector.GetHandle("modifiedDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayCount = "playCount";

	private static readonly IntPtr selPlayCountHandle = Selector.GetHandle("playCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayStatus = "playStatus";

	private static readonly IntPtr selPlayStatusHandle = Selector.GetHandle("playStatus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRating = "rating";

	private static readonly IntPtr selRatingHandle = Selector.GetHandle("rating");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReleaseDate = "releaseDate";

	private static readonly IntPtr selReleaseDateHandle = Selector.GetHandle("releaseDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleRate = "sampleRate";

	private static readonly IntPtr selSampleRateHandle = Selector.GetHandle("sampleRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSkipCount = "skipCount";

	private static readonly IntPtr selSkipCountHandle = Selector.GetHandle("skipCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSkipDate = "skipDate";

	private static readonly IntPtr selSkipDateHandle = Selector.GetHandle("skipDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortComposer = "sortComposer";

	private static readonly IntPtr selSortComposerHandle = Selector.GetHandle("sortComposer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortTitle = "sortTitle";

	private static readonly IntPtr selSortTitleHandle = Selector.GetHandle("sortTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartTime = "startTime";

	private static readonly IntPtr selStartTimeHandle = Selector.GetHandle("startTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopTime = "stopTime";

	private static readonly IntPtr selStopTimeHandle = Selector.GetHandle("stopTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTotalTime = "totalTime";

	private static readonly IntPtr selTotalTimeHandle = Selector.GetHandle("totalTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackNumber = "trackNumber";

	private static readonly IntPtr selTrackNumberHandle = Selector.GetHandle("trackNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoInfo = "videoInfo";

	private static readonly IntPtr selVideoInfoHandle = Selector.GetHandle("videoInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVoiceOverLanguage = "voiceOverLanguage";

	private static readonly IntPtr selVoiceOverLanguageHandle = Selector.GetHandle("voiceOverLanguage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolumeAdjustment = "volumeAdjustment";

	private static readonly IntPtr selVolumeAdjustmentHandle = Selector.GetHandle("volumeAdjustment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolumeNormalizationEnergy = "volumeNormalizationEnergy";

	private static readonly IntPtr selVolumeNormalizationEnergyHandle = Selector.GetHandle("volumeNormalizationEnergy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYear = "year";

	private static readonly IntPtr selYearHandle = Selector.GetHandle("year");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ITLibMediaItem");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? AddedDate
	{
		[Export("addedDate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selAddedDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAddedDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibAlbum Album
	{
		[Export("album", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<ITLibAlbum>(Messaging.IntPtr_objc_msgSend(base.Handle, selAlbumHandle));
			}
			return Runtime.GetNSObject<ITLibAlbum>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlbumHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibArtist? Artist
	{
		[Export("artist", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<ITLibArtist>(Messaging.IntPtr_objc_msgSend(base.Handle, selArtistHandle));
			}
			return Runtime.GetNSObject<ITLibArtist>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArtistHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibArtwork? Artwork
	{
		[Export("artwork", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<ITLibArtwork>(Messaging.IntPtr_objc_msgSend(base.Handle, selArtworkHandle));
			}
			return Runtime.GetNSObject<ITLibArtwork>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArtworkHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ArtworkAvailable
	{
		[Export("hasArtworkAvailable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasArtworkAvailableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasArtworkAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint BeatsPerMinute
	{
		[Export("beatsPerMinute")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBeatsPerMinuteHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBeatsPerMinuteHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Bitrate
	{
		[Export("bitrate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBitrateHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBitrateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Category
	{
		[Export("category")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCategoryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCategoryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Cloud
	{
		[Export("isCloud")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCloudHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCloudHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Comments
	{
		[Export("comments")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCommentsHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Composer
	{
		[Export("composer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selComposerHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selComposerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ContentRating
	{
		[Export("contentRating")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContentRatingHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentRatingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string? Description
	{
		[Export("description")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DrmProtected
	{
		[Export("isDRMProtected")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDRMProtectedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDRMProtectedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong FileSize
	{
		[Export("fileSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selFileSizeHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFileSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint FileType
	{
		[Export("fileType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFileTypeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFileTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Genre
	{
		[Export("genre")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGenreHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGenreHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Grouping
	{
		[Export("grouping")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupingHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Kind
	{
		[Export("kind")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKindHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKindHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? LastPlayedDate
	{
		[Export("lastPlayedDate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selLastPlayedDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastPlayedDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? Location
	{
		[Export("location", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocationHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibMediaItemLocationType LocationType
	{
		[Export("locationType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ITLibMediaItemLocationType)Messaging.UInt64_objc_msgSend(base.Handle, selLocationTypeHandle);
			}
			return (ITLibMediaItemLocationType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLocationTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibMediaItemLyricsContentRating LyricsContentRating
	{
		[Export("lyricsContentRating", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ITLibMediaItemLyricsContentRating)Messaging.UInt64_objc_msgSend(base.Handle, selLyricsContentRatingHandle);
			}
			return (ITLibMediaItemLyricsContentRating)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLyricsContentRatingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibMediaItemMediaKind MediaKind
	{
		[Export("mediaKind", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ITLibMediaItemMediaKind)Messaging.UInt64_objc_msgSend(base.Handle, selMediaKindHandle);
			}
			return (ITLibMediaItemMediaKind)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMediaKindHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? ModifiedDate
	{
		[Export("modifiedDate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selModifiedDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModifiedDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint PlayCount
	{
		[Export("playCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPlayCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPlayCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibMediaItemPlayStatus PlayStatus
	{
		[Export("playStatus", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ITLibMediaItemPlayStatus)Messaging.UInt64_objc_msgSend(base.Handle, selPlayStatusHandle);
			}
			return (ITLibMediaItemPlayStatus)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPlayStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Purchased
	{
		[Export("isPurchased")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPurchasedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPurchasedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Rating
	{
		[Export("rating")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selRatingHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selRatingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RatingComputed
	{
		[Export("isRatingComputed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRatingComputedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRatingComputedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? ReleaseDate
	{
		[Export("releaseDate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selReleaseDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReleaseDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SampleRate
	{
		[Export("sampleRate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSampleRateHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSampleRateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Size
	{
		[Export("size")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SkipCount
	{
		[Export("skipCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSkipCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSkipCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? SkipDate
	{
		[Export("skipDate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selSkipDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSkipDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? SortComposer
	{
		[Export("sortComposer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSortComposerHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortComposerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? SortTitle
	{
		[Export("sortTitle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSortTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint StartTime
	{
		[Export("startTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selStartTimeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selStartTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint StopTime
	{
		[Export("stopTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selStopTimeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selStopTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint TotalTime
	{
		[Export("totalTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selTotalTimeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selTotalTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint TrackNumber
	{
		[Export("trackNumber")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selTrackNumberHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selTrackNumberHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UserDisabled
	{
		[Export("isUserDisabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsUserDisabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsUserDisabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Video
	{
		[Export("isVideo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVideoHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVideoHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibMediaItemVideoInfo? VideoInfo
	{
		[Export("videoInfo", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<ITLibMediaItemVideoInfo>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoInfoHandle));
			}
			return Runtime.GetNSObject<ITLibMediaItemVideoInfo>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoInfoHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? VoiceOverLanguage
	{
		[Export("voiceOverLanguage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVoiceOverLanguageHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVoiceOverLanguageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint VolumeAdjustment
	{
		[Export("volumeAdjustment")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selVolumeAdjustmentHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selVolumeAdjustmentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint VolumeNormalizationEnergy
	{
		[Export("volumeNormalizationEnergy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selVolumeNormalizationEnergyHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVolumeNormalizationEnergyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Year
	{
		[Export("year")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selYearHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selYearHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ITLibMediaItem()
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
	protected ITLibMediaItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ITLibMediaItem(IntPtr handle)
		: base(handle)
	{
	}
}
