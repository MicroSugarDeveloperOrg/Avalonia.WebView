using System;
using Foundation;
using ObjCRuntime;

namespace iTunesLibrary;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class MediaItemPropertyExtensions
{
	private static IntPtr[] values = new IntPtr[70];

	[Field("ITLibMediaItemPropertyAlbumTitle", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyAlbumTitle
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyAlbumTitle", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertySortAlbumTitle", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertySortAlbumTitle
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertySortAlbumTitle", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyAlbumArtist", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyAlbumArtist
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyAlbumArtist", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyAlbumRating", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyAlbumRating
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyAlbumRating", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyAlbumRatingComputed", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyAlbumRatingComputed
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyAlbumRatingComputed", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertySortAlbumArtist", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertySortAlbumArtist
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertySortAlbumArtist", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyAlbumIsGapless", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyAlbumIsGapless
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyAlbumIsGapless", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyAlbumIsCompilation", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyAlbumIsCompilation
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyAlbumIsCompilation", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyAlbumDiscCount", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyAlbumDiscCount
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyAlbumDiscCount", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyAlbumDiscNumber", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyAlbumDiscNumber
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyAlbumDiscNumber", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyAlbumTrackCount", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyAlbumTrackCount
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyAlbumTrackCount", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyArtistName", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyArtistName
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyArtistName", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertySortArtistName", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertySortArtistName
	{
		get
		{
			fixed (IntPtr* storage = &values[12])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertySortArtistName", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyVideoIsHD", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyVideoIsHD
	{
		get
		{
			fixed (IntPtr* storage = &values[13])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyVideoIsHD", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyVideoWidth", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyVideoWidth
	{
		get
		{
			fixed (IntPtr* storage = &values[14])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyVideoWidth", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyVideoHeight", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyVideoHeight
	{
		get
		{
			fixed (IntPtr* storage = &values[15])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyVideoHeight", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyVideoSeries", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyVideoSeries
	{
		get
		{
			fixed (IntPtr* storage = &values[16])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyVideoSeries", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyVideoSortSeries", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyVideoSortSeries
	{
		get
		{
			fixed (IntPtr* storage = &values[17])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyVideoSortSeries", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyVideoSeason", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyVideoSeason
	{
		get
		{
			fixed (IntPtr* storage = &values[18])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyVideoSeason", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyVideoEpisode", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyVideoEpisode
	{
		get
		{
			fixed (IntPtr* storage = &values[19])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyVideoEpisode", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyVideoEpisodeOrder", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyVideoEpisodeOrder
	{
		get
		{
			fixed (IntPtr* storage = &values[20])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyVideoEpisodeOrder", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyHasArtwork", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyHasArtwork
	{
		get
		{
			fixed (IntPtr* storage = &values[21])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyHasArtwork", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyBitRate", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyBitRate
	{
		get
		{
			fixed (IntPtr* storage = &values[22])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyBitRate", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyBeatsPerMinute", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyBeatsPerMinute
	{
		get
		{
			fixed (IntPtr* storage = &values[23])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyBeatsPerMinute", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyCategory", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyCategory
	{
		get
		{
			fixed (IntPtr* storage = &values[24])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyCategory", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyComments", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyComments
	{
		get
		{
			fixed (IntPtr* storage = &values[25])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyComments", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyComposer", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyComposer
	{
		get
		{
			fixed (IntPtr* storage = &values[26])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyComposer", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertySortComposer", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertySortComposer
	{
		get
		{
			fixed (IntPtr* storage = &values[27])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertySortComposer", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyContentRating", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyContentRating
	{
		get
		{
			fixed (IntPtr* storage = &values[28])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyContentRating", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyLyricsContentRating", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyLyricsContentRating
	{
		get
		{
			fixed (IntPtr* storage = &values[29])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyLyricsContentRating", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyAddedDate", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyAddedDate
	{
		get
		{
			fixed (IntPtr* storage = &values[30])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyAddedDate", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyModifiedDate", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyModifiedDate
	{
		get
		{
			fixed (IntPtr* storage = &values[31])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyModifiedDate", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyDescription", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyDescription
	{
		get
		{
			fixed (IntPtr* storage = &values[32])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyDescription", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyIsUserDisabled", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyIsUserDisabled
	{
		get
		{
			fixed (IntPtr* storage = &values[33])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyIsUserDisabled", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyFileType", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyFileType
	{
		get
		{
			fixed (IntPtr* storage = &values[34])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyFileType", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyGenre", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyGenre
	{
		get
		{
			fixed (IntPtr* storage = &values[35])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyGenre", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyGrouping", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyGrouping
	{
		get
		{
			fixed (IntPtr* storage = &values[36])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyGrouping", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyIsVideo", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyIsVideo
	{
		get
		{
			fixed (IntPtr* storage = &values[37])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyIsVideo", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyKind", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyKind
	{
		get
		{
			fixed (IntPtr* storage = &values[38])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyKind", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyTitle", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyTitle
	{
		get
		{
			fixed (IntPtr* storage = &values[39])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyTitle", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertySortTitle", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertySortTitle
	{
		get
		{
			fixed (IntPtr* storage = &values[40])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertySortTitle", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyVolumeNormalizationEnergy", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyVolumeNormalizationEnergy
	{
		get
		{
			fixed (IntPtr* storage = &values[41])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyVolumeNormalizationEnergy", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyPlayCount", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyPlayCount
	{
		get
		{
			fixed (IntPtr* storage = &values[42])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyPlayCount", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyLastPlayDate", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyLastPlayDate
	{
		get
		{
			fixed (IntPtr* storage = &values[43])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyLastPlayDate", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyPlayStatus", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyPlayStatus
	{
		get
		{
			fixed (IntPtr* storage = &values[44])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyPlayStatus", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyIsDRMProtected", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyIsDRMProtected
	{
		get
		{
			fixed (IntPtr* storage = &values[45])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyIsDRMProtected", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyIsPurchased", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyIsPurchased
	{
		get
		{
			fixed (IntPtr* storage = &values[46])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyIsPurchased", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyMovementCount", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyMovementCount
	{
		get
		{
			fixed (IntPtr* storage = &values[47])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyMovementCount", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyMovementName", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyMovementName
	{
		get
		{
			fixed (IntPtr* storage = &values[48])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyMovementName", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyMovementNumber", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyMovementNumber
	{
		get
		{
			fixed (IntPtr* storage = &values[49])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyMovementNumber", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyRating", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyRating
	{
		get
		{
			fixed (IntPtr* storage = &values[50])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyRating", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyRatingComputed", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyRatingComputed
	{
		get
		{
			fixed (IntPtr* storage = &values[51])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyRatingComputed", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyReleaseDate", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyReleaseDate
	{
		get
		{
			fixed (IntPtr* storage = &values[52])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyReleaseDate", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertySampleRate", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertySampleRate
	{
		get
		{
			fixed (IntPtr* storage = &values[53])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertySampleRate", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertySize", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertySize
	{
		get
		{
			fixed (IntPtr* storage = &values[54])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertySize", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyFileSize", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyFileSize
	{
		get
		{
			fixed (IntPtr* storage = &values[55])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyFileSize", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyUserSkipCount", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyUserSkipCount
	{
		get
		{
			fixed (IntPtr* storage = &values[56])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyUserSkipCount", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertySkipDate", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertySkipDate
	{
		get
		{
			fixed (IntPtr* storage = &values[57])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertySkipDate", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyStartTime", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyStartTime
	{
		get
		{
			fixed (IntPtr* storage = &values[58])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyStartTime", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyStopTime", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyStopTime
	{
		get
		{
			fixed (IntPtr* storage = &values[59])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyStopTime", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyTotalTime", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyTotalTime
	{
		get
		{
			fixed (IntPtr* storage = &values[60])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyTotalTime", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyTrackNumber", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyTrackNumber
	{
		get
		{
			fixed (IntPtr* storage = &values[61])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyTrackNumber", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyLocationType", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyLocationType
	{
		get
		{
			fixed (IntPtr* storage = &values[62])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyLocationType", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyVoiceOverLanguage", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyVoiceOverLanguage
	{
		get
		{
			fixed (IntPtr* storage = &values[63])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyVoiceOverLanguage", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyVolumeAdjustment", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyVolumeAdjustment
	{
		get
		{
			fixed (IntPtr* storage = &values[64])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyVolumeAdjustment", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyWork", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyWork
	{
		get
		{
			fixed (IntPtr* storage = &values[65])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyWork", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyYear", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyYear
	{
		get
		{
			fixed (IntPtr* storage = &values[66])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyYear", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyMediaKind", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyMediaKind
	{
		get
		{
			fixed (IntPtr* storage = &values[67])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyMediaKind", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyLocation", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyLocation
	{
		get
		{
			fixed (IntPtr* storage = &values[68])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyLocation", storage);
			}
		}
	}

	[Field("ITLibMediaItemPropertyArtwork", "iTunesLibrary")]
	internal unsafe static IntPtr ITLibMediaItemPropertyArtwork
	{
		get
		{
			fixed (IntPtr* storage = &values[69])
			{
				return Dlfcn.CachePointer(Libraries.iTunesLibrary.Handle, "ITLibMediaItemPropertyArtwork", storage);
			}
		}
	}

	public static NSString? GetConstant(this MediaItemProperty self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = ITLibMediaItemPropertyAlbumTitle;
			break;
		case 1:
			ptr = ITLibMediaItemPropertySortAlbumTitle;
			break;
		case 2:
			ptr = ITLibMediaItemPropertyAlbumArtist;
			break;
		case 3:
			ptr = ITLibMediaItemPropertyAlbumRating;
			break;
		case 4:
			ptr = ITLibMediaItemPropertyAlbumRatingComputed;
			break;
		case 5:
			ptr = ITLibMediaItemPropertySortAlbumArtist;
			break;
		case 6:
			ptr = ITLibMediaItemPropertyAlbumIsGapless;
			break;
		case 7:
			ptr = ITLibMediaItemPropertyAlbumIsCompilation;
			break;
		case 8:
			ptr = ITLibMediaItemPropertyAlbumDiscCount;
			break;
		case 9:
			ptr = ITLibMediaItemPropertyAlbumDiscNumber;
			break;
		case 10:
			ptr = ITLibMediaItemPropertyAlbumTrackCount;
			break;
		case 11:
			ptr = ITLibMediaItemPropertyArtistName;
			break;
		case 12:
			ptr = ITLibMediaItemPropertySortArtistName;
			break;
		case 13:
			ptr = ITLibMediaItemPropertyVideoIsHD;
			break;
		case 14:
			ptr = ITLibMediaItemPropertyVideoWidth;
			break;
		case 15:
			ptr = ITLibMediaItemPropertyVideoHeight;
			break;
		case 16:
			ptr = ITLibMediaItemPropertyVideoSeries;
			break;
		case 17:
			ptr = ITLibMediaItemPropertyVideoSortSeries;
			break;
		case 18:
			ptr = ITLibMediaItemPropertyVideoSeason;
			break;
		case 19:
			ptr = ITLibMediaItemPropertyVideoEpisode;
			break;
		case 20:
			ptr = ITLibMediaItemPropertyVideoEpisodeOrder;
			break;
		case 21:
			ptr = ITLibMediaItemPropertyHasArtwork;
			break;
		case 22:
			ptr = ITLibMediaItemPropertyBitRate;
			break;
		case 23:
			ptr = ITLibMediaItemPropertyBeatsPerMinute;
			break;
		case 24:
			ptr = ITLibMediaItemPropertyCategory;
			break;
		case 25:
			ptr = ITLibMediaItemPropertyComments;
			break;
		case 26:
			ptr = ITLibMediaItemPropertyComposer;
			break;
		case 27:
			ptr = ITLibMediaItemPropertySortComposer;
			break;
		case 28:
			ptr = ITLibMediaItemPropertyContentRating;
			break;
		case 29:
			ptr = ITLibMediaItemPropertyLyricsContentRating;
			break;
		case 30:
			ptr = ITLibMediaItemPropertyAddedDate;
			break;
		case 31:
			ptr = ITLibMediaItemPropertyModifiedDate;
			break;
		case 32:
			ptr = ITLibMediaItemPropertyDescription;
			break;
		case 33:
			ptr = ITLibMediaItemPropertyIsUserDisabled;
			break;
		case 34:
			ptr = ITLibMediaItemPropertyFileType;
			break;
		case 35:
			ptr = ITLibMediaItemPropertyGenre;
			break;
		case 36:
			ptr = ITLibMediaItemPropertyGrouping;
			break;
		case 37:
			ptr = ITLibMediaItemPropertyIsVideo;
			break;
		case 38:
			ptr = ITLibMediaItemPropertyKind;
			break;
		case 39:
			ptr = ITLibMediaItemPropertyTitle;
			break;
		case 40:
			ptr = ITLibMediaItemPropertySortTitle;
			break;
		case 41:
			ptr = ITLibMediaItemPropertyVolumeNormalizationEnergy;
			break;
		case 42:
			ptr = ITLibMediaItemPropertyPlayCount;
			break;
		case 43:
			ptr = ITLibMediaItemPropertyLastPlayDate;
			break;
		case 44:
			ptr = ITLibMediaItemPropertyPlayStatus;
			break;
		case 45:
			ptr = ITLibMediaItemPropertyIsDRMProtected;
			break;
		case 46:
			ptr = ITLibMediaItemPropertyIsPurchased;
			break;
		case 47:
			ptr = ITLibMediaItemPropertyMovementCount;
			break;
		case 48:
			ptr = ITLibMediaItemPropertyMovementName;
			break;
		case 49:
			ptr = ITLibMediaItemPropertyMovementNumber;
			break;
		case 50:
			ptr = ITLibMediaItemPropertyRating;
			break;
		case 51:
			ptr = ITLibMediaItemPropertyRatingComputed;
			break;
		case 52:
			ptr = ITLibMediaItemPropertyReleaseDate;
			break;
		case 53:
			ptr = ITLibMediaItemPropertySampleRate;
			break;
		case 54:
			ptr = ITLibMediaItemPropertySize;
			break;
		case 55:
			ptr = ITLibMediaItemPropertyFileSize;
			break;
		case 56:
			ptr = ITLibMediaItemPropertyUserSkipCount;
			break;
		case 57:
			ptr = ITLibMediaItemPropertySkipDate;
			break;
		case 58:
			ptr = ITLibMediaItemPropertyStartTime;
			break;
		case 59:
			ptr = ITLibMediaItemPropertyStopTime;
			break;
		case 60:
			ptr = ITLibMediaItemPropertyTotalTime;
			break;
		case 61:
			ptr = ITLibMediaItemPropertyTrackNumber;
			break;
		case 62:
			ptr = ITLibMediaItemPropertyLocationType;
			break;
		case 63:
			ptr = ITLibMediaItemPropertyVoiceOverLanguage;
			break;
		case 64:
			ptr = ITLibMediaItemPropertyVolumeAdjustment;
			break;
		case 65:
			ptr = ITLibMediaItemPropertyWork;
			break;
		case 66:
			ptr = ITLibMediaItemPropertyYear;
			break;
		case 67:
			ptr = ITLibMediaItemPropertyMediaKind;
			break;
		case 68:
			ptr = ITLibMediaItemPropertyLocation;
			break;
		case 69:
			ptr = ITLibMediaItemPropertyArtwork;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static MediaItemProperty GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyAlbumTitle))
		{
			return MediaItemProperty.AlbumTitle;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertySortAlbumTitle))
		{
			return MediaItemProperty.SortAlbumTitle;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyAlbumArtist))
		{
			return MediaItemProperty.AlbumArtist;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyAlbumRating))
		{
			return MediaItemProperty.AlbumRating;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyAlbumRatingComputed))
		{
			return MediaItemProperty.AlbumRatingComputed;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertySortAlbumArtist))
		{
			return MediaItemProperty.SortAlbumArtist;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyAlbumIsGapless))
		{
			return MediaItemProperty.AlbumIsGapless;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyAlbumIsCompilation))
		{
			return MediaItemProperty.AlbumIsCompilation;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyAlbumDiscCount))
		{
			return MediaItemProperty.AlbumDiscCount;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyAlbumDiscNumber))
		{
			return MediaItemProperty.AlbumDiscNumber;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyAlbumTrackCount))
		{
			return MediaItemProperty.AlbumTrackCount;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyArtistName))
		{
			return MediaItemProperty.ArtistName;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertySortArtistName))
		{
			return MediaItemProperty.SortArtistName;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyVideoIsHD))
		{
			return MediaItemProperty.VideoIsHD;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyVideoWidth))
		{
			return MediaItemProperty.VideoWidth;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyVideoHeight))
		{
			return MediaItemProperty.VideoHeight;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyVideoSeries))
		{
			return MediaItemProperty.VideoSeries;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyVideoSortSeries))
		{
			return MediaItemProperty.VideoSortSeries;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyVideoSeason))
		{
			return MediaItemProperty.VideoSeason;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyVideoEpisode))
		{
			return MediaItemProperty.VideoEpisode;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyVideoEpisodeOrder))
		{
			return MediaItemProperty.VideoEpisodeOrder;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyHasArtwork))
		{
			return MediaItemProperty.HasArtwork;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyBitRate))
		{
			return MediaItemProperty.BitRate;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyBeatsPerMinute))
		{
			return MediaItemProperty.BeatsPerMinute;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyCategory))
		{
			return MediaItemProperty.Category;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyComments))
		{
			return MediaItemProperty.Comments;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyComposer))
		{
			return MediaItemProperty.Composer;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertySortComposer))
		{
			return MediaItemProperty.SortComposer;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyContentRating))
		{
			return MediaItemProperty.ContentRating;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyLyricsContentRating))
		{
			return MediaItemProperty.LyricsContentRating;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyAddedDate))
		{
			return MediaItemProperty.AddedDate;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyModifiedDate))
		{
			return MediaItemProperty.ModifiedDate;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyDescription))
		{
			return MediaItemProperty.Description;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyIsUserDisabled))
		{
			return MediaItemProperty.IsUserDisabled;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyFileType))
		{
			return MediaItemProperty.FileType;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyGenre))
		{
			return MediaItemProperty.Genre;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyGrouping))
		{
			return MediaItemProperty.Grouping;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyIsVideo))
		{
			return MediaItemProperty.IsVideo;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyKind))
		{
			return MediaItemProperty.Kind;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyTitle))
		{
			return MediaItemProperty.Title;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertySortTitle))
		{
			return MediaItemProperty.SortTitle;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyVolumeNormalizationEnergy))
		{
			return MediaItemProperty.VolumeNormalizationEnergy;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyPlayCount))
		{
			return MediaItemProperty.PlayCount;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyLastPlayDate))
		{
			return MediaItemProperty.LastPlayDate;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyPlayStatus))
		{
			return MediaItemProperty.PlayStatus;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyIsDRMProtected))
		{
			return MediaItemProperty.IsDrmProtected;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyIsPurchased))
		{
			return MediaItemProperty.IsPurchased;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyMovementCount))
		{
			return MediaItemProperty.MovementCount;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyMovementName))
		{
			return MediaItemProperty.MovementName;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyMovementNumber))
		{
			return MediaItemProperty.MovementNumber;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyRating))
		{
			return MediaItemProperty.Rating;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyRatingComputed))
		{
			return MediaItemProperty.RatingComputed;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyReleaseDate))
		{
			return MediaItemProperty.ReleaseDate;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertySampleRate))
		{
			return MediaItemProperty.SampleRate;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertySize))
		{
			return MediaItemProperty.Size;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyFileSize))
		{
			return MediaItemProperty.FileSize;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyUserSkipCount))
		{
			return MediaItemProperty.UserSkipCount;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertySkipDate))
		{
			return MediaItemProperty.SkipDate;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyStartTime))
		{
			return MediaItemProperty.StartTime;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyStopTime))
		{
			return MediaItemProperty.StopTime;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyTotalTime))
		{
			return MediaItemProperty.TotalTime;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyTrackNumber))
		{
			return MediaItemProperty.TrackNumber;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyLocationType))
		{
			return MediaItemProperty.LocationType;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyVoiceOverLanguage))
		{
			return MediaItemProperty.VoiceOverLanguage;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyVolumeAdjustment))
		{
			return MediaItemProperty.VolumeAdjustment;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyWork))
		{
			return MediaItemProperty.Work;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyYear))
		{
			return MediaItemProperty.Year;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyMediaKind))
		{
			return MediaItemProperty.MediaKind;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyLocation))
		{
			return MediaItemProperty.Location;
		}
		if (constant.IsEqualTo(ITLibMediaItemPropertyArtwork))
		{
			return MediaItemProperty.Artwork;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
