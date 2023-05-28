using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPMediaItem", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
public class MPMediaItem : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanFilterByProperty_ = "canFilterByProperty:";

	private static readonly IntPtr selCanFilterByProperty_Handle = Selector.GetHandle("canFilterByProperty:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateValuesForProperties_UsingBlock_ = "enumerateValuesForProperties:usingBlock:";

	private static readonly IntPtr selEnumerateValuesForProperties_UsingBlock_Handle = Selector.GetHandle("enumerateValuesForProperties:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKeyedSubscript_ = "objectForKeyedSubscript:";

	private static readonly IntPtr selObjectForKeyedSubscript_Handle = Selector.GetHandle("objectForKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForProperty_ = "valueForProperty:";

	private static readonly IntPtr selValueForProperty_Handle = Selector.GetHandle("valueForProperty:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPMediaItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AlbumArtistPersistentIDProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AlbumArtistProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AlbumPersistentIDProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AlbumTitleProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AlbumTrackCountProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AlbumTrackNumberProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ArtistPersistentIDProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ArtistProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ArtworkProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AssetURLProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BeatsPerMinuteProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BookmarkTimeProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CommentsProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ComposerPersistentIDProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ComposerProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DateAddedProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DiscCountProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DiscNumberProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenrePersistentIDProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenreProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HasProtectedAssetProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsCloudItemProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsCompilationProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsExplicitProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LastPlayedDateProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LyricsProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaTypeProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PersistentIDProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlayCountProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaybackDurationProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaybackStoreIDProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PodcastPersistentIDProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PodcastTitleProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyPersistentID;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RatingProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReleaseDateProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SkipCountProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TitleProperty;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UserGroupingProperty;

	public override IntPtr ClassHandle => class_ptr;

	[Field("MPMediaItemPropertyAlbumArtistPersistentID", "MediaPlayer")]
	public static NSString AlbumArtistPersistentIDProperty
	{
		get
		{
			if (_AlbumArtistPersistentIDProperty == null)
			{
				_AlbumArtistPersistentIDProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAlbumArtistPersistentID");
			}
			return _AlbumArtistPersistentIDProperty;
		}
	}

	[Field("MPMediaItemPropertyAlbumArtist", "MediaPlayer")]
	public static NSString AlbumArtistProperty
	{
		get
		{
			if (_AlbumArtistProperty == null)
			{
				_AlbumArtistProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAlbumArtist");
			}
			return _AlbumArtistProperty;
		}
	}

	[Field("MPMediaItemPropertyAlbumPersistentID", "MediaPlayer")]
	public static NSString AlbumPersistentIDProperty
	{
		get
		{
			if (_AlbumPersistentIDProperty == null)
			{
				_AlbumPersistentIDProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAlbumPersistentID");
			}
			return _AlbumPersistentIDProperty;
		}
	}

	[Field("MPMediaItemPropertyAlbumTitle", "MediaPlayer")]
	public static NSString AlbumTitleProperty
	{
		get
		{
			if (_AlbumTitleProperty == null)
			{
				_AlbumTitleProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAlbumTitle");
			}
			return _AlbumTitleProperty;
		}
	}

	[Field("MPMediaItemPropertyAlbumTrackCount", "MediaPlayer")]
	public static NSString AlbumTrackCountProperty
	{
		get
		{
			if (_AlbumTrackCountProperty == null)
			{
				_AlbumTrackCountProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAlbumTrackCount");
			}
			return _AlbumTrackCountProperty;
		}
	}

	[Field("MPMediaItemPropertyAlbumTrackNumber", "MediaPlayer")]
	public static NSString AlbumTrackNumberProperty
	{
		get
		{
			if (_AlbumTrackNumberProperty == null)
			{
				_AlbumTrackNumberProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAlbumTrackNumber");
			}
			return _AlbumTrackNumberProperty;
		}
	}

	[Field("MPMediaItemPropertyArtistPersistentID", "MediaPlayer")]
	public static NSString ArtistPersistentIDProperty
	{
		get
		{
			if (_ArtistPersistentIDProperty == null)
			{
				_ArtistPersistentIDProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyArtistPersistentID");
			}
			return _ArtistPersistentIDProperty;
		}
	}

	[Field("MPMediaItemPropertyArtist", "MediaPlayer")]
	public static NSString ArtistProperty
	{
		get
		{
			if (_ArtistProperty == null)
			{
				_ArtistProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyArtist");
			}
			return _ArtistProperty;
		}
	}

	[Field("MPMediaItemPropertyArtwork", "MediaPlayer")]
	[Introduced(PlatformName.MacOSX, 10, 13, 1, PlatformArchitecture.All, null)]
	public static NSString ArtworkProperty
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 1, PlatformArchitecture.All, null)]
		get
		{
			if (_ArtworkProperty == null)
			{
				_ArtworkProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyArtwork");
			}
			return _ArtworkProperty;
		}
	}

	[Field("MPMediaItemPropertyAssetURL", "MediaPlayer")]
	public static NSString AssetURLProperty
	{
		get
		{
			if (_AssetURLProperty == null)
			{
				_AssetURLProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyAssetURL");
			}
			return _AssetURLProperty;
		}
	}

	[Field("MPMediaItemPropertyBeatsPerMinute", "MediaPlayer")]
	public static NSString BeatsPerMinuteProperty
	{
		get
		{
			if (_BeatsPerMinuteProperty == null)
			{
				_BeatsPerMinuteProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyBeatsPerMinute");
			}
			return _BeatsPerMinuteProperty;
		}
	}

	[Field("MPMediaItemPropertyBookmarkTime", "MediaPlayer")]
	public static NSString BookmarkTimeProperty
	{
		get
		{
			if (_BookmarkTimeProperty == null)
			{
				_BookmarkTimeProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyBookmarkTime");
			}
			return _BookmarkTimeProperty;
		}
	}

	[Field("MPMediaItemPropertyComments", "MediaPlayer")]
	public static NSString CommentsProperty
	{
		get
		{
			if (_CommentsProperty == null)
			{
				_CommentsProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyComments");
			}
			return _CommentsProperty;
		}
	}

	[Field("MPMediaItemPropertyComposerPersistentID", "MediaPlayer")]
	public static NSString ComposerPersistentIDProperty
	{
		get
		{
			if (_ComposerPersistentIDProperty == null)
			{
				_ComposerPersistentIDProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyComposerPersistentID");
			}
			return _ComposerPersistentIDProperty;
		}
	}

	[Field("MPMediaItemPropertyComposer", "MediaPlayer")]
	public static NSString ComposerProperty
	{
		get
		{
			if (_ComposerProperty == null)
			{
				_ComposerProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyComposer");
			}
			return _ComposerProperty;
		}
	}

	[Field("MPMediaItemPropertyDateAdded", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString DateAddedProperty
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_DateAddedProperty == null)
			{
				_DateAddedProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyDateAdded");
			}
			return _DateAddedProperty;
		}
	}

	[Field("MPMediaItemPropertyDiscCount", "MediaPlayer")]
	public static NSString DiscCountProperty
	{
		get
		{
			if (_DiscCountProperty == null)
			{
				_DiscCountProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyDiscCount");
			}
			return _DiscCountProperty;
		}
	}

	[Field("MPMediaItemPropertyDiscNumber", "MediaPlayer")]
	public static NSString DiscNumberProperty
	{
		get
		{
			if (_DiscNumberProperty == null)
			{
				_DiscNumberProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyDiscNumber");
			}
			return _DiscNumberProperty;
		}
	}

	[Field("MPMediaItemPropertyGenrePersistentID", "MediaPlayer")]
	public static NSString GenrePersistentIDProperty
	{
		get
		{
			if (_GenrePersistentIDProperty == null)
			{
				_GenrePersistentIDProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyGenrePersistentID");
			}
			return _GenrePersistentIDProperty;
		}
	}

	[Field("MPMediaItemPropertyGenre", "MediaPlayer")]
	public static NSString GenreProperty
	{
		get
		{
			if (_GenreProperty == null)
			{
				_GenreProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyGenre");
			}
			return _GenreProperty;
		}
	}

	[Field("MPMediaItemPropertyHasProtectedAsset", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 9, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	public static NSString HasProtectedAssetProperty
	{
		[Introduced(PlatformName.iOS, 9, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
		get
		{
			if (_HasProtectedAssetProperty == null)
			{
				_HasProtectedAssetProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyHasProtectedAsset");
			}
			return _HasProtectedAssetProperty;
		}
	}

	[Field("MPMediaItemPropertyIsCloudItem", "MediaPlayer")]
	public static NSString IsCloudItemProperty
	{
		get
		{
			if (_IsCloudItemProperty == null)
			{
				_IsCloudItemProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyIsCloudItem");
			}
			return _IsCloudItemProperty;
		}
	}

	[Field("MPMediaItemPropertyIsCompilation", "MediaPlayer")]
	public static NSString IsCompilationProperty
	{
		get
		{
			if (_IsCompilationProperty == null)
			{
				_IsCompilationProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyIsCompilation");
			}
			return _IsCompilationProperty;
		}
	}

	[Field("MPMediaItemPropertyIsExplicit", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString IsExplicitProperty
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_IsExplicitProperty == null)
			{
				_IsExplicitProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyIsExplicit");
			}
			return _IsExplicitProperty;
		}
	}

	[Field("MPMediaItemPropertyLastPlayedDate", "MediaPlayer")]
	public static NSString LastPlayedDateProperty
	{
		get
		{
			if (_LastPlayedDateProperty == null)
			{
				_LastPlayedDateProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyLastPlayedDate");
			}
			return _LastPlayedDateProperty;
		}
	}

	[Field("MPMediaItemPropertyLyrics", "MediaPlayer")]
	public static NSString LyricsProperty
	{
		get
		{
			if (_LyricsProperty == null)
			{
				_LyricsProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyLyrics");
			}
			return _LyricsProperty;
		}
	}

	[Field("MPMediaItemPropertyMediaType", "MediaPlayer")]
	public static NSString MediaTypeProperty
	{
		get
		{
			if (_MediaTypeProperty == null)
			{
				_MediaTypeProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyMediaType");
			}
			return _MediaTypeProperty;
		}
	}

	[Field("MPMediaItemPropertyPersistentID", "MediaPlayer")]
	public static NSString PersistentIDProperty
	{
		get
		{
			if (_PersistentIDProperty == null)
			{
				_PersistentIDProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyPersistentID");
			}
			return _PersistentIDProperty;
		}
	}

	[Field("MPMediaItemPropertyPlayCount", "MediaPlayer")]
	public static NSString PlayCountProperty
	{
		get
		{
			if (_PlayCountProperty == null)
			{
				_PlayCountProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyPlayCount");
			}
			return _PlayCountProperty;
		}
	}

	[Field("MPMediaItemPropertyPlaybackDuration", "MediaPlayer")]
	public static NSString PlaybackDurationProperty
	{
		get
		{
			if (_PlaybackDurationProperty == null)
			{
				_PlaybackDurationProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyPlaybackDuration");
			}
			return _PlaybackDurationProperty;
		}
	}

	[Field("MPMediaItemPropertyPlaybackStoreID", "MediaPlayer")]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 3, PlatformArchitecture.All, null)]
	public static NSString PlaybackStoreIDProperty
	{
		[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 3, PlatformArchitecture.All, null)]
		get
		{
			if (_PlaybackStoreIDProperty == null)
			{
				_PlaybackStoreIDProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyPlaybackStoreID");
			}
			return _PlaybackStoreIDProperty;
		}
	}

	[Field("MPMediaItemPropertyPodcastPersistentID", "MediaPlayer")]
	public static NSString PodcastPersistentIDProperty
	{
		get
		{
			if (_PodcastPersistentIDProperty == null)
			{
				_PodcastPersistentIDProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyPodcastPersistentID");
			}
			return _PodcastPersistentIDProperty;
		}
	}

	[Field("MPMediaItemPropertyPodcastTitle", "MediaPlayer")]
	public static NSString PodcastTitleProperty
	{
		get
		{
			if (_PodcastTitleProperty == null)
			{
				_PodcastTitleProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyPodcastTitle");
			}
			return _PodcastTitleProperty;
		}
	}

	[Field("MPMediaEntityPropertyPersistentID", "MediaPlayer")]
	public static NSString PropertyPersistentID
	{
		get
		{
			if (_PropertyPersistentID == null)
			{
				_PropertyPersistentID = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaEntityPropertyPersistentID");
			}
			return _PropertyPersistentID;
		}
	}

	[Field("MPMediaItemPropertyRating", "MediaPlayer")]
	public static NSString RatingProperty
	{
		get
		{
			if (_RatingProperty == null)
			{
				_RatingProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyRating");
			}
			return _RatingProperty;
		}
	}

	[Field("MPMediaItemPropertyReleaseDate", "MediaPlayer")]
	public static NSString ReleaseDateProperty
	{
		get
		{
			if (_ReleaseDateProperty == null)
			{
				_ReleaseDateProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyReleaseDate");
			}
			return _ReleaseDateProperty;
		}
	}

	[Field("MPMediaItemPropertySkipCount", "MediaPlayer")]
	public static NSString SkipCountProperty
	{
		get
		{
			if (_SkipCountProperty == null)
			{
				_SkipCountProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertySkipCount");
			}
			return _SkipCountProperty;
		}
	}

	[Field("MPMediaItemPropertyTitle", "MediaPlayer")]
	public static NSString TitleProperty
	{
		get
		{
			if (_TitleProperty == null)
			{
				_TitleProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyTitle");
			}
			return _TitleProperty;
		}
	}

	[Field("MPMediaItemPropertyUserGrouping", "MediaPlayer")]
	public static NSString UserGroupingProperty
	{
		get
		{
			if (_UserGroupingProperty == null)
			{
				_UserGroupingProperty = Dlfcn.GetStringConstant(Libraries.MediaPlayer.Handle, "MPMediaItemPropertyUserGrouping");
			}
			return _UserGroupingProperty;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MPMediaItem()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPMediaItem(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPMediaItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPMediaItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("canFilterByProperty:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanFilterByProperty(NSString property)
	{
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanFilterByProperty_Handle, property.Handle);
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("enumerateValuesForProperties:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateValues(NSSet propertiesToEnumerate, [BlockProxy(typeof(Trampolines.NIDMPMediaItemEnumerator))] MPMediaItemEnumerator enumerator)
	{
		if (propertiesToEnumerate == null)
		{
			throw new ArgumentNullException("propertiesToEnumerate");
		}
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMPMediaItemEnumerator.Handler, enumerator);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEnumerateValuesForProperties_UsingBlock_Handle, propertiesToEnumerate.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEnumerateValuesForProperties_UsingBlock_Handle, propertiesToEnumerate.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("objectForKeyedSubscript:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetObject(NSObject key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKeyedSubscript_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKeyedSubscript_Handle, key.Handle));
	}

	[Export("valueForProperty:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ValueForProperty(NSString property)
	{
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForProperty_Handle, property.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForProperty_Handle, property.Handle));
	}
}
