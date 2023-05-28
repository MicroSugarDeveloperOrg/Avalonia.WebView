using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Mac(10, 12, 2)]
public class MPNowPlayingInfo
{
	public double? ElapsedPlaybackTime;

	public double? PlaybackRate;

	public int? PlaybackQueueIndex;

	public int? PlaybackQueueCount;

	public int? ChapterNumber;

	public int? ChapterCount;

	public int? AlbumTrackCount;

	public int? AlbumTrackNumber;

	public int? DiscCount;

	public int? DiscNumber;

	public ulong? PersistentID;

	public double? PlaybackDuration;

	[iOS(8, 0)]
	public double? DefaultPlaybackRate;

	public string AlbumTitle;

	public string Artist;

	public MPMediaItemArtwork Artwork;

	public string Composer;

	public string Genre;

	public string Title;

	[iOS(9, 0)]
	public MPNowPlayingInfoLanguageOptionGroup[] AvailableLanguageOptions { get; set; }

	[iOS(9, 0)]
	public MPNowPlayingInfoLanguageOption[] CurrentLanguageOptions { get; set; }

	[iOS(10, 0)]
	public string CollectionIdentifier { get; set; }

	[iOS(10, 0)]
	public string ExternalContentIdentifier { get; set; }

	[iOS(10, 0)]
	public string ExternalUserProfileIdentifier { get; set; }

	[iOS(10, 0)]
	public float? PlaybackProgress { get; set; }

	[iOS(10, 0)]
	public MPNowPlayingInfoMediaType? MediaType { get; set; }

	[iOS(10, 0)]
	public bool? IsLiveStream { get; set; }

	[iOS(10, 3)]
	public NSUrl AssetUrl { get; set; }

	[iOS(11, 1)]
	[TV(11, 1)]
	[Mac(10, 13, 1)]
	public NSDate CurrentPlaybackDate { get; set; }

	public MPNowPlayingInfo()
	{
	}

	internal NSDictionary ToDictionary()
	{
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		if (ElapsedPlaybackTime.HasValue)
		{
			nSMutableDictionary.Add(MPNowPlayingInfoCenter.PropertyElapsedPlaybackTime, new NSNumber(ElapsedPlaybackTime.Value));
		}
		if (PlaybackRate.HasValue)
		{
			nSMutableDictionary.Add(MPNowPlayingInfoCenter.PropertyPlaybackRate, new NSNumber(PlaybackRate.Value));
		}
		if (PlaybackQueueIndex.HasValue)
		{
			nSMutableDictionary.Add(MPNowPlayingInfoCenter.PropertyPlaybackQueueIndex, new NSNumber(PlaybackQueueIndex.Value));
		}
		if (PlaybackQueueCount.HasValue)
		{
			nSMutableDictionary.Add(MPNowPlayingInfoCenter.PropertyPlaybackQueueCount, new NSNumber(PlaybackQueueCount.Value));
		}
		if (ChapterNumber.HasValue)
		{
			nSMutableDictionary.Add(MPNowPlayingInfoCenter.PropertyChapterNumber, new NSNumber(ChapterNumber.Value));
		}
		if (ChapterCount.HasValue)
		{
			nSMutableDictionary.Add(MPNowPlayingInfoCenter.PropertyChapterCount, new NSNumber(ChapterCount.Value));
		}
		if (DefaultPlaybackRate.HasValue)
		{
			Add(nSMutableDictionary, MPNowPlayingInfoCenter.PropertyDefaultPlaybackRate, new NSNumber(DefaultPlaybackRate.Value));
		}
		if (AvailableLanguageOptions != null && AvailableLanguageOptions.Length != 0)
		{
			NSString propertyAvailableLanguageOptions = MPNowPlayingInfoCenter.PropertyAvailableLanguageOptions;
			object[] availableLanguageOptions = AvailableLanguageOptions;
			Add(nSMutableDictionary, propertyAvailableLanguageOptions, NSArray.FromObjects(availableLanguageOptions));
		}
		if (CurrentLanguageOptions != null && CurrentLanguageOptions.Length != 0)
		{
			NSString propertyCurrentLanguageOptions = MPNowPlayingInfoCenter.PropertyCurrentLanguageOptions;
			object[] availableLanguageOptions = CurrentLanguageOptions;
			Add(nSMutableDictionary, propertyCurrentLanguageOptions, NSArray.FromObjects(availableLanguageOptions));
		}
		if (CollectionIdentifier != null)
		{
			Add(nSMutableDictionary, MPNowPlayingInfoCenter.PropertyCollectionIdentifier, new NSString(CollectionIdentifier));
		}
		if (ExternalContentIdentifier != null)
		{
			Add(nSMutableDictionary, MPNowPlayingInfoCenter.PropertyExternalContentIdentifier, new NSString(ExternalContentIdentifier));
		}
		if (ExternalUserProfileIdentifier != null)
		{
			Add(nSMutableDictionary, MPNowPlayingInfoCenter.PropertyExternalUserProfileIdentifier, new NSString(ExternalUserProfileIdentifier));
		}
		if (PlaybackProgress.HasValue)
		{
			Add(nSMutableDictionary, MPNowPlayingInfoCenter.PropertyPlaybackProgress, new NSNumber(PlaybackProgress.Value));
		}
		if (MediaType.HasValue)
		{
			Add(nSMutableDictionary, MPNowPlayingInfoCenter.PropertyMediaType, new NSNumber((int)MediaType.Value));
		}
		if (IsLiveStream.HasValue)
		{
			Add(nSMutableDictionary, MPNowPlayingInfoCenter.PropertyIsLiveStream, new NSNumber(IsLiveStream.Value));
		}
		if (AssetUrl != null)
		{
			Add(nSMutableDictionary, MPNowPlayingInfoCenter.PropertyAssetUrl, AssetUrl);
		}
		if (CurrentPlaybackDate != null)
		{
			Add(nSMutableDictionary, MPNowPlayingInfoCenter.PropertyCurrentPlaybackDate, CurrentPlaybackDate);
		}
		if (AlbumTrackCount.HasValue)
		{
			nSMutableDictionary.Add(MPMediaItem.AlbumTrackCountProperty, new NSNumber(AlbumTrackCount.Value));
		}
		if (AlbumTrackNumber.HasValue)
		{
			nSMutableDictionary.Add(MPMediaItem.AlbumTrackNumberProperty, new NSNumber(AlbumTrackNumber.Value));
		}
		if (DiscCount.HasValue)
		{
			nSMutableDictionary.Add(MPMediaItem.DiscCountProperty, new NSNumber(DiscCount.Value));
		}
		if (DiscNumber.HasValue)
		{
			nSMutableDictionary.Add(MPMediaItem.DiscNumberProperty, new NSNumber(DiscNumber.Value));
		}
		if (PersistentID.HasValue)
		{
			nSMutableDictionary.Add(MPMediaItem.PersistentIDProperty, new NSNumber(PersistentID.Value));
		}
		if (PlaybackDuration.HasValue)
		{
			nSMutableDictionary.Add(MPMediaItem.PlaybackDurationProperty, new NSNumber(PlaybackDuration.Value));
		}
		if (AlbumTitle != null)
		{
			nSMutableDictionary.Add(MPMediaItem.AlbumTitleProperty, new NSString(AlbumTitle));
		}
		if (Artist != null)
		{
			nSMutableDictionary.Add(MPMediaItem.ArtistProperty, new NSString(Artist));
		}
		if (Artwork != null)
		{
			nSMutableDictionary.Add(MPMediaItem.ArtworkProperty, Artwork);
		}
		if (Composer != null)
		{
			nSMutableDictionary.Add(MPMediaItem.ComposerProperty, new NSString(Composer));
		}
		if (Genre != null)
		{
			nSMutableDictionary.Add(MPMediaItem.GenreProperty, new NSString(Genre));
		}
		if (Title != null)
		{
			nSMutableDictionary.Add(MPMediaItem.TitleProperty, new NSString(Title));
		}
		return nSMutableDictionary;
	}

	private void Add(NSMutableDictionary dictionary, NSObject key, NSObject value)
	{
		if (key != null)
		{
			dictionary.Add(key, value);
		}
	}

	internal MPNowPlayingInfo(NSDictionary source)
	{
		if (source != null)
		{
			if (source.TryGetValue(MPNowPlayingInfoCenter.PropertyElapsedPlaybackTime, out var value))
			{
				ElapsedPlaybackTime = (value as NSNumber).DoubleValue;
			}
			if (source.TryGetValue(MPNowPlayingInfoCenter.PropertyPlaybackRate, out value))
			{
				PlaybackRate = (value as NSNumber).DoubleValue;
			}
			if (source.TryGetValue(MPNowPlayingInfoCenter.PropertyPlaybackQueueIndex, out value))
			{
				PlaybackQueueIndex = (int)(value as NSNumber).UInt32Value;
			}
			if (source.TryGetValue(MPNowPlayingInfoCenter.PropertyPlaybackQueueCount, out value))
			{
				PlaybackQueueCount = (int)(value as NSNumber).UInt32Value;
			}
			if (source.TryGetValue(MPNowPlayingInfoCenter.PropertyChapterNumber, out value))
			{
				ChapterNumber = (int)(value as NSNumber).UInt32Value;
			}
			if (source.TryGetValue(MPNowPlayingInfoCenter.PropertyChapterCount, out value))
			{
				ChapterCount = (int)(value as NSNumber).UInt32Value;
			}
			if (TryGetValue(source, MPNowPlayingInfoCenter.PropertyDefaultPlaybackRate, out value))
			{
				DefaultPlaybackRate = (value as NSNumber).DoubleValue;
			}
			if (TryGetValue(source, MPNowPlayingInfoCenter.PropertyAvailableLanguageOptions, out value))
			{
				AvailableLanguageOptions = NSArray.ArrayFromHandle<MPNowPlayingInfoLanguageOptionGroup>(value.Handle);
			}
			if (TryGetValue(source, MPNowPlayingInfoCenter.PropertyCurrentLanguageOptions, out value))
			{
				CurrentLanguageOptions = NSArray.ArrayFromHandle<MPNowPlayingInfoLanguageOption>(value.Handle);
			}
			if (TryGetValue(source, MPNowPlayingInfoCenter.PropertyCollectionIdentifier, out value))
			{
				CollectionIdentifier = value as NSString;
			}
			if (TryGetValue(source, MPNowPlayingInfoCenter.PropertyExternalContentIdentifier, out value))
			{
				ExternalContentIdentifier = value as NSString;
			}
			if (TryGetValue(source, MPNowPlayingInfoCenter.PropertyExternalUserProfileIdentifier, out value))
			{
				ExternalUserProfileIdentifier = value as NSString;
			}
			if (TryGetValue(source, MPNowPlayingInfoCenter.PropertyPlaybackProgress, out value))
			{
				PlaybackProgress = (value as NSNumber).FloatValue;
			}
			if (TryGetValue(source, MPNowPlayingInfoCenter.PropertyMediaType, out value))
			{
				MediaType = (MPNowPlayingInfoMediaType)(value as NSNumber).UInt32Value;
			}
			if (TryGetValue(source, MPNowPlayingInfoCenter.PropertyIsLiveStream, out value))
			{
				IsLiveStream = (value as NSNumber).BoolValue;
			}
			if (TryGetValue(source, MPNowPlayingInfoCenter.PropertyAssetUrl, out value))
			{
				AssetUrl = value as NSUrl;
			}
			if (TryGetValue(source, MPNowPlayingInfoCenter.PropertyCurrentPlaybackDate, out value))
			{
				CurrentPlaybackDate = value as NSDate;
			}
			if (source.TryGetValue(MPMediaItem.AlbumTrackCountProperty, out value))
			{
				AlbumTrackCount = (int)(value as NSNumber).UInt32Value;
			}
			if (source.TryGetValue(MPMediaItem.AlbumTrackNumberProperty, out value))
			{
				AlbumTrackNumber = (int)(value as NSNumber).UInt32Value;
			}
			if (source.TryGetValue(MPMediaItem.DiscCountProperty, out value))
			{
				DiscCount = (int)(value as NSNumber).UInt32Value;
			}
			if (source.TryGetValue(MPMediaItem.DiscNumberProperty, out value))
			{
				DiscNumber = (int)(value as NSNumber).UInt32Value;
			}
			if (source.TryGetValue(MPMediaItem.PersistentIDProperty, out value))
			{
				PersistentID = (value as NSNumber).UInt64Value;
			}
			if (source.TryGetValue(MPMediaItem.PlaybackDurationProperty, out value))
			{
				PlaybackDuration = (value as NSNumber).DoubleValue;
			}
			if (source.TryGetValue(MPMediaItem.AlbumTitleProperty, out value))
			{
				AlbumTitle = value as NSString;
			}
			if (source.TryGetValue(MPMediaItem.ArtistProperty, out value))
			{
				Artist = value as NSString;
			}
			if (source.TryGetValue(MPMediaItem.ArtworkProperty, out value))
			{
				Artwork = value as MPMediaItemArtwork;
			}
			if (source.TryGetValue(MPMediaItem.ComposerProperty, out value))
			{
				Composer = value as NSString;
			}
			if (source.TryGetValue(MPMediaItem.GenreProperty, out value))
			{
				Genre = value as NSString;
			}
			if (source.TryGetValue(MPMediaItem.TitleProperty, out value))
			{
				Title = value as NSString;
			}
		}
	}

	private bool TryGetValue(NSDictionary source, NSObject key, out NSObject result)
	{
		result = null;
		if (key != null)
		{
			return source.TryGetValue(key, out result);
		}
		return false;
	}
}
